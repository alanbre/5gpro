using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.Funcoes;
using _5gpro.Reports;
using _5gpro.Relatorios;
using _5gpro.testesrelatorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace _5gpro
{
    public partial class fmMain : Form
    {
        private Permissao permissao = new Permissao();
        private PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado = new Logado();
        private LogadoDAO logadoDAO = new LogadoDAO();
        private NetworkAdapter adap = new NetworkAdapter();
        private string Codgrupousuario;
        private List<PermissaoNivelStruct> listapermissaonivel = new List<PermissaoNivelStruct>();

        private bool isCollapsed;

        int panelWidth;
        bool Hidden;


        Thread t;

        //CÓDIGOS DAS TELAS
        //Cadastro de Pessoa = 010100
        //Cadastro de Usuário = 010200
        //Cadastro de Item = 010300
        //Cadastro de Grupo de Usuário = 010400
        //Cadastro de Orçamento = 020100
        //Cadastro de Nota Fiscal = 030100
        //Cadastro de Operações = 040100
        //Cadastro de Contas a Receber = 050100
        //Quitação de Contas a Receber = 050200
        //Cadastro de Contas a Pagar = 060100
        //Quitação de Contas a Pagar = 060200
        //Cadastro de Grupo de Itens = 010500
        //Cadastro de Grupo de Pessoas = 010600
        //Entrada de notas = 070100

        public fmMain()
        {
            InitializeComponent();
            panelWidth = panelEsquerdo.Width;
            Hidden = false;
            TimerMain.Start();
            timerDropLateral.Start();
            FiltroDePermissoes();
            t = new Thread(new ThreadStart(AtualizaLogado));
            t.Start();
        }

        public struct PermissaoNivelStruct
        {
            public Permissao permissao;
            public int Nivel;

        }


        private void TsmiCadastroPessoas_Click(object sender, EventArgs e)
        {
            var formCadPessoas = new fmCadastroPessoa();
            formCadPessoas.Show(this);
        }
        private void TsmiCadastroItens_Click(object sender, EventArgs e)
        {
            var formCadItens = new fmCadastroItem();
            formCadItens.Show(this);
        }
        private void TsmiCadastroOrcamentos_Click(object sender, EventArgs e)
        {
            var formOrcamentoCadOrcamentos = new fmOrcCadastro();
            formOrcamentoCadOrcamentos.Show(this);
        }
        private void TsmiCadastroUsuarios_Click(object sender, EventArgs e)
        {
            var formCadUsuarios = new fmCadastroUsuario();
            formCadUsuarios.Show(this);
        }
        private void TsmiEmissaoNF_Click(object sender, EventArgs e)
        {
            var formSaidaEmissaoNota = new fmSaiEmissaoNota();
            formSaidaEmissaoNota.Show(this);
        }
        private void TsmiCadastroDeGrupoDeUsuários_Click(object sender, EventArgs e)
        {
            var formCadGrupoUsuarios = new fmCadastroGrupoUsuario();
            formCadGrupoUsuarios.Show(this);
        }
        private void TsmiCadastroDeOperações_Click(object sender, EventArgs e)
        {
            var formCadOperacao = new fmCadastroOperacao();
            formCadOperacao.Show(this);
        }
        private void TsmiCarCadastroContaReceber_Click(object sender, EventArgs e)
        {
            var formCarCadContaReceber = new fmCarCadastroConta();
            formCarCadContaReceber.Show(this);
        }
        private void TsmiCarQuitacaoConta_Click(object sender, EventArgs e)
        {
            var formCarQuitacaoConta = new fmCarQuitacaoConta();
            formCarQuitacaoConta.Show(this);
        }
        private void TsmiCapCadastroContaReceber_Click(object sender, EventArgs e)
        {
            var formCapCadContaPagar = new fmCapCadastroConta();
            formCapCadContaPagar.Show(this);
        }
        private void CadastroDeGrupoDeItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadGrupoItem = new fmCadastroGrupoItem();
            formCadGrupoItem.Show(this);
        }
        private void CadastroDeGrupoDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadGrupoPessoa = new fmCadastroGrupoPessoa();
            formCadGrupoPessoa.Show(this);
        }
        private void TsmiEntradaNotas_Click(object sender, EventArgs e)
        {
            var formEntradaNotas = new fmEntEntradaNota();
            formEntradaNotas.Show(this);
        }

        private void TsmiTeste_Click(object sender, EventArgs e)
        {
            var formRelTeste = new fmRltNotasSaida();
            formRelTeste.Show(this);
        }

        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
            logadoDAO.RemoveTodosLocks(logado);
            //Retira usuário da tabela Logado
            logadoDAO.RemoverLogado(adap.Mac);
        }


        private void AtualizaLogado()
        {
            while (true)
            {
                Thread.Sleep(1000);
                logadoDAO.AtualizarLogado(logado.Mac);
            }
        }
        private void FiltroDePermissoes()
        {

            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);

            Codgrupousuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();

            if (Codgrupousuario != "999")
            {
                listapermissaonivel = permissaoDAO.PermissoesNiveisStructByCodGrupoUsuario(Codgrupousuario);

                foreach (PermissaoNivelStruct p in listapermissaonivel)
                {
                    switch (p.permissao.Codigo)
                    {

                        case "010100":
                            tsmiCadastroPessoas.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "010200":
                            tsmiCadastroUsuarios.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "010300":
                            tsmiCadastroItens.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "010400":
                            tsmiCadastroGrupoUsuario.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "020100":
                            tsmiCadastroOrcamentos.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "030100":
                            tsmiEmissaoNF.Visible = p.Nivel == 0 ? false : true;
                            break;

                    }
                }
            }
        }

        private void QuitaçãoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCapQuitacaoConta = new fmCapQuitacaoConta();
            formCapQuitacaoConta.Show(this);
        }

        private void TesteeduardoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExemplorelatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ExemploRelatorio = new exemplorelatorio();
            ExemploRelatorio.Show(this);
        }

        private void RelatorioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RelatorioUsuario = new FormRelatUsu();
            RelatorioUsuario.Show(this);
        }

        private void RelatorioDeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FiltroRltItem = new fmItemReport();
            FiltroRltItem.Show(this);
        }

        private void RelatorioContaReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fmcontaReceber = new fmRltContaReceber();
            fmcontaReceber.Show(this);
        }

        private void RelatórioDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fmconta = new fmRelatorioContas();
            fmconta.Show(this);
        }

        private void BtCadastros_Click(object sender, EventArgs e)
        {
            TimerMain.Start();
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelEsquerdo.Width = panelEsquerdo.Width + 50;
                if (panelEsquerdo.Width >= panelWidth)
                {
                    TimerMain.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelEsquerdo.Width = panelEsquerdo.Width - 50;
                if (panelEsquerdo.Width <= 70)
                {
                    TimerMain.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void BtEntradas_Click(object sender, EventArgs e)
        {
            var formEntradaNotas = new fmEntEntradaNota();
            formEntradaNotas.Show(this);
        }

        private void BtExpandeRetrai_Click(object sender, EventArgs e)
        {
            timerDropLateral.Start();
            paneldropCadastros.Focus();
        }

        private void TimerDropLateral_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                paneldropCadastros.Height += 100;
                if (paneldropCadastros.Size == paneldropCadastros.MaximumSize)
                {
                    timerDropLateral.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                paneldropCadastros.Height -= 100;
                if (paneldropCadastros.Size == paneldropCadastros.MinimumSize)
                {
                    timerDropLateral.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void BtiCadPessoa_Click(object sender, EventArgs e)
        {
            var formCadPessoas = new fmCadastroPessoa();
            formCadPessoas.Show(this);
        }

        private void BtiItens_Click(object sender, EventArgs e)
        {
            var formCadItens = new fmCadastroItem();
            formCadItens.Show(this);
        }

        private void BtiUsuários_Click(object sender, EventArgs e)
        {
            var formCadUsuarios = new fmCadastroUsuario();
            formCadUsuarios.Show(this);
        }

        private void BtiGruposusuarios_Click(object sender, EventArgs e)
        {
            var formCadGrupoUsuarios = new fmCadastroGrupoUsuario();
            formCadGrupoUsuarios.Show(this);
        }

        private void BtiOperacoes_Click(object sender, EventArgs e)
        {
            var formCadOperacao = new fmCadastroOperacao();
            formCadOperacao.Show(this);
        }

        private void BtiGrupoitens_Click(object sender, EventArgs e)
        {
            var formCadGrupoItem = new fmCadastroGrupoItem();
            formCadGrupoItem.Show(this);
        }

        private void BtiGrupopessoa_Click(object sender, EventArgs e)
        {
            var formCadGrupoPessoa = new fmCadastroGrupoPessoa();
            formCadGrupoPessoa.Show(this);
        }


    }
}
