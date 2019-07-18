using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
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

        Thread t;

        //CÓDIGOS DAS TELAS
        //Cadastro de Pessoa = 010100
        //Cadastro de Usuário = 010200
        //Cadastro de Item = 010300
        //Cadastro de Grupo de Usuário = 010400
        //Cadastro de Grupo de Itens = 010500
        //Cadastro de Grupo de Pessoas = 010600
        //Cadastro de Unidade de medida = 010700
        //Cadastro de Orçamento = 020100
        //Cadastro de Nota Fiscal = 030100
        //Cadastro de Operações = 040100
        //Cadastro de Contas a Receber = 050100
        //Quitação de Contas a Receber = 050200
        //Cadastro de Contas a Pagar = 060100
        //Quitação de Contas a Pagar = 060200
        //Entrada de notas = 070100
        //Definir Partes = 080100
        //Cadastro de Caixa = 090100
        //Abertura e fechamento de caixa = 090200
        //Sangria de caixa = 090300
        //Lançamento manual caixa = 090400
        //Plano de contas = 090500


        public fmMain()
        {
            InitializeComponent();
        }



        public struct PermissaoNivelStruct
        {
            public Permissao permissao;
            public int Nivel;

        }
        private void FmMain_Load(object sender, EventArgs e)
        {
            FiltroDePermissoes();
            timerRelogio.Start();
            t = new Thread(new ThreadStart(AtualizaLogado));
            t.Start();
        }
        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
            logadoDAO.RemoveTodosLocks(logado);
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
                            tsmiCadCliForPessoa.Visible = p.Nivel != 0; //Cadastro de pessoa
                            break;
                        case "010300":
                            tsmiCadItens.Visible = p.Nivel != 0; //Cadastro de item
                            break;
                        case "010200":
                            tsmiUsuCadUsu.Visible = p.Nivel != 0; //Cadastro de usuário
                            break;
                        case "010400":
                            tsmiUsuGrupo.Visible = p.Nivel != 0; //Cadastro de grupo de usuários
                            break;
                        case "040100":
                            tsmiOpe.Visible = p.Nivel != 0;//Cadastro de Operações
                            break;
                        case "010500":
                            tsmiCadItensGrupo.Visible = p.Nivel != 0;//Cadastro de Grupo de Itens
                            break;
                        case "010600":
                            tsmiCadCliForGrupoPessoa.Visible = p.Nivel != 0;//Cadastro de Grupo de Pessoas
                            break;
                        case "010700":
                            tsmiCadItensUniMedida.Visible = p.Nivel != 0;//Cadastro de unidades de medida
                            break;
                        case "050100":
                            tsmiCarCadastro.Visible = p.Nivel != 0;//Cadastro de Conta a Receber
                            break;
                        case "050200":
                            tsmiCarQuitacao.Visible = p.Nivel != 0;//Quitação de Conta a Receber
                            break;
                        case "060100":
                            tsmiCapCadastro.Visible = p.Nivel != 0;//Cadastro de Conta a Pagar
                            break;
                        case "060200":
                            tsmiCapQuitacao.Visible = p.Nivel != 0;//Quitação de Conta a Pagar
                            break;
                        case "070100":
                            tsmiEntNota.Visible = p.Nivel != 0;//Entrada
                            break;
                        case "030100":
                            tsmiSaiNota.Visible = p.Nivel != 0;//Saida
                            break;
                        case "020100":
                            tsmiOrcCadastro.Visible = p.Nivel != 0;//Cadastro de Orçamentos
                            break;
                        case "090100":
                            tsmiCaiCadCaixa.Visible = p.Nivel != 0;//Cadastro de caixas
                            break;
                        case "090200":
                            tsmiCaiAberturaFechamento.Visible = p.Nivel != 0;//Abertura e fechamento de caixa
                            break;
                        case "090300":
                            tsmiCaiSangria.Visible = p.Nivel != 0;//Sangria de caixa
                            break;
                        case "090400":
                            tsmiCaiManual.Visible = p.Nivel != 0;//Lançamento Manual
                            break;
                        case "090500":
                            tsmiCaiPlanoContas.Visible = p.Nivel != 0;//Plano de Contas
                            break;
                        case "090600":
                            tsmiCaiPlanoContasPadrao.Visible = p.Nivel != 0;//Plano de contas padrão
                            break;
                    }
                }
            }
        }
        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            lbRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        private void TsmiCadCliForPessoa_Click(object sender, EventArgs e)
        {
            var fmCadastroPessoa = new fmCadastroPessoa();
            fmCadastroPessoa.Show(this);
        }
        private void TsmiCadCliForGrupoPessoa_Click(object sender, EventArgs e)
        {
            var fmCadastroGrupoPessoa = new fmCadastroGrupoPessoa();
            fmCadastroGrupoPessoa.Show(this);
        }
        private void TsmiCadItensItem_Click(object sender, EventArgs e)
        {
            var fmCadastroItem = new fmCadastroItem();
            fmCadastroItem.Show(this);
        }
        private void TsmiCadItensGrupo_Click(object sender, EventArgs e)
        {
            var fmCadastroGrupoItem = new fmCadastroGrupoItem();
            fmCadastroGrupoItem.Show(this);
        }
        private void TsmiCadItensUniMedida_Click(object sender, EventArgs e)
        {
            var fmCadastroUnidadeMedidade = new fmCadastroUnimedida();
            fmCadastroUnidadeMedidade.Show(this);
        }
        private void TsmiUsuCadUsu_Click(object sender, EventArgs e)
        {
            var fmCadastroUsuario = new fmCadastroUsuario();
            fmCadastroUsuario.Show(this);
        }
        private void TsmiUsuGrupo_Click(object sender, EventArgs e)
        {
            var fmCadastroGrupoUsuario = new fmCadastroGrupoUsuario();
            fmCadastroGrupoUsuario.Show(this);
        }
        private void TsmiOpe_Click(object sender, EventArgs e)
        {
            var fmCadastroOperacao = new fmCadastroOperacao();
            fmCadastroOperacao.Show(this);
        }
        private void TsmiOrcCadastro_Click(object sender, EventArgs e)
        {
            var fmCadastroOrcamento = new fmOrcCadastro();
            fmCadastroOrcamento.Show(this);
        }
        private void TsmiEntNota_Click(object sender, EventArgs e)
        {
            var fmNotaEntrada = new fmEntEntradaNota();
            fmNotaEntrada.Show(this);
        }
        private void TsmiSaiNota_Click(object sender, EventArgs e)
        {
            var fmEmissaoNota = new fmSaiEmissaoNota();
            fmEmissaoNota.Show(this);
        }
        private void TsmiCarCadastro_Click(object sender, EventArgs e)
        {
            var fmCarCadstroConta = new fmCarCadastroConta();
            fmCarCadstroConta.Show(this);
        }
        private void TsmiCarQuitacao_Click(object sender, EventArgs e)
        {
            var fmCarQuitacaoConta = new fmCarQuitacaoConta();
            fmCarQuitacaoConta.Show(this);
        }
        private void TsmiCapCadastro_Click(object sender, EventArgs e)
        {
            var fmCapCadstroConta = new fmCapCadastroConta();
            fmCapCadstroConta.Show(this);
        }
        private void TsmiCapQuitacao_Click(object sender, EventArgs e)
        {
            var fmCapQuitacaoConta = new fmCapQuitacaoConta();
            fmCapQuitacaoConta.Show(this);
        }
        private void TsmiCaiCadCaixa_Click(object sender, EventArgs e)
        {
            var fmCaiCadastroCaixa = new fmCaiCadastroCaixa();
            fmCaiCadastroCaixa.Show(this);
        }
        private void TsmiCaiAberturaFechamento_Click(object sender, EventArgs e)
        {
            var fmCaiAberturaFechamento = new fmCaiAberturaFechamento();
            fmCaiAberturaFechamento.Show(this);
        }
        private void TsmiCaiSangria_Click(object sender, EventArgs e)
        {
            var fmCaiSangria = new fmCaiSangria();
            fmCaiSangria.Show(this);
        }
        private void TsmiCaiManual_Click(object sender, EventArgs e)
        {
            var fmCaiLancamentoManual = new fmCaiLancamentoManual();
            fmCaiLancamentoManual.Show(this);
        }
        private void TsmiCaiPlanoContas_Click(object sender, EventArgs e)
        {
            var fmCaiPlanoContas = new fmCaiPlanoContas();
            fmCaiPlanoContas.Show(this);
        }
        private void TsmiCaiPlanoContasPadrao_Click(object sender, EventArgs e)
        {
            var fmCaiPlanoContasPadrao = new fmCaiPlanoContasPadrao();
            fmCaiPlanoContasPadrao.Show(this);
        }
        private void TsmiCaiCaixa_Click(object sender, EventArgs e)
        {
            var fmCaiBuscaLancamentoCaixa = new fmCaiBuscaLancamentos();
            fmCaiBuscaLancamentoCaixa.Show(this);
        }
        private void TsmiCfgDadosEstabelecimento_Click(object sender, EventArgs e)
        {
            var fmCfgDadosEstabelecimento = new fmCfgDadosEstabelecimento();
            fmCfgDadosEstabelecimento.Show(this);
        }

    }
}
