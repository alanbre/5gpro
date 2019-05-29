using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.Funcoes;
using _5gpro.Reports;
using _5gpro.Relatorios;
using _5gpro.testesrelatorios;
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

        private string botaoPressionado = "";
        private bool CadastrosHidden, ContareceberHidden, MenuHidden, ContapagarHidden, 
            EntradaHidden, SaidaHidden, OrcamentoHidden, RelatorioSaidaHidden;


        int panelWidth;


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
                            //tsmiCadastroPessoas.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "010200":
                           // tsmiCadastroUsuarios.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "010300":
                           // tsmiCadastroItens.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "010400":
                            //tsmiCadastroGrupoUsuario.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "020100":
                           //tsmiCadastroOrcamentos.Visible = p.Nivel == 0 ? false : true;
                            break;

                        case "030100":
                            //tsmiEmissaoNF.Visible = p.Nivel == 0 ? false : true;
                            break;

                    }
                }
            }
        }


       //MENU LATERAL
        private void BtExpandiretrai_Click(object sender, EventArgs e)
        {
            timerDropLateral.Start();
            botaoPressionado = "botaoexpandiretrai";
        }

        private void BtCadastrosesquerda_Click(object sender, EventArgs e)
        {
            DesmarcarBotoes();
            btCadastrosmenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#0092F4");
            timerDropLateral.Start();
            botaoPressionado = "botaocadastro";
        }

        private void BtCReceber_Click(object sender, EventArgs e)
        {
            DesmarcarBotoes();
            btCReceber.BackColor = System.Drawing.ColorTranslator.FromHtml("#0092F4");
            timerDropLateral.Start();
            botaoPressionado = "botaocontareceber";
        }

        private void BtCPagar_Click(object sender, EventArgs e)
        {
            DesmarcarBotoes();
            btCPagar.BackColor = System.Drawing.ColorTranslator.FromHtml("#0092F4");
            timerDropLateral.Start();
            botaoPressionado = "botaocontapagar";
        }

        private void BtEntradas_Click(object sender, EventArgs e)
        {
            DesmarcarBotoes();
            btEntradas.BackColor = System.Drawing.ColorTranslator.FromHtml("#0092F4");
            timerDropLateral.Start();
            botaoPressionado = "botaoentrada";
        }

        private void BtSaidas_Click(object sender, EventArgs e)
        {
            DesmarcarBotoes();
            btSaidas.BackColor = System.Drawing.ColorTranslator.FromHtml("#0092F4");
            timerDropLateral.Start();
            botaoPressionado = "botaosaida";
        }

        private void BtOrcamentos_Click(object sender, EventArgs e)
        {
            DesmarcarBotoes();
            btOrcamentos.BackColor = System.Drawing.ColorTranslator.FromHtml("#0092F4");
            timerDropLateral.Start();
            botaoPressionado = "botaoorcamento";
        }






        //BOTÕES DO MENU CADASTROS
        private void BtiCadPessoa_Click(object sender, EventArgs e)
        {
            var formCadPessoas = new fmCadastroPessoa();
            formCadPessoas.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiItens_Click(object sender, EventArgs e)
        {
            var formCadItens = new fmCadastroItem();
            formCadItens.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiUsuários_Click(object sender, EventArgs e)
        {
            var formCadUsuarios = new fmCadastroUsuario();
            formCadUsuarios.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiGruposusuarios_Click(object sender, EventArgs e)
        {
            var formCadGrupoUsuarios = new fmCadastroGrupoUsuario();
            formCadGrupoUsuarios.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiOperacoes_Click(object sender, EventArgs e)
        {
            var formCadOperacao = new fmCadastroOperacao();
            formCadOperacao.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiGrupoitens_Click(object sender, EventArgs e)
        {
            var formCadGrupoItem = new fmCadastroGrupoItem();
            formCadGrupoItem.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiGrupopessoa_Click(object sender, EventArgs e)
        {
            var formCadGrupoPessoa = new fmCadastroGrupoPessoa();
            formCadGrupoPessoa.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        //BOTÕES DO MENU A RECEBER
        private void BtiCadContaReceber_Click(object sender, EventArgs e)
        {
            var formCarCadContaReceber = new fmCarCadastroConta();
            formCarCadContaReceber.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiQuitacaoConta_Click(object sender, EventArgs e)
        {
            var formCarQuitacaoConta = new fmCarQuitacaoConta();
            formCarQuitacaoConta.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        //BOTÕES DO MENU A PAGAR
        private void BtiCadContaPagar_Click(object sender, EventArgs e)
        {
            var formCapCadContaPagar = new fmCapCadastroConta();
            formCapCadContaPagar.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiQuitacaoAPagar_Click(object sender, EventArgs e)
        {
            var formCapQuitacaoConta = new fmCapQuitacaoConta();
            formCapQuitacaoConta.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        //BOTÕES DO MENU ENTRADAS
        private void BtiEntrada_Click(object sender, EventArgs e)
        {
            var formEntradaNotas = new fmEntEntradaNota();
            formEntradaNotas.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        //BOTÕES DO MENU SAIDAS
        private void BtiSaida_Click(object sender, EventArgs e)
        {
            var formSaidaEmissaoNota = new fmSaiEmissaoNota();
            formSaidaEmissaoNota.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        //COM SUB MENU
        private void BtiRltNotaSaida_Click(object sender, EventArgs e)
        {
            btiRltNotaSaida.BackColor = System.Drawing.ColorTranslator.FromHtml("#0092F4");
            timerDropLateral.Start();
            botaoPressionado = "subrelatoriosaida";
        }

        //SUBMENU RELATORIOS SAIDA
        private void BtsRelatorionotas_Click(object sender, EventArgs e)
        {
            var formRelTeste = new fmRltNotasSaida();
            formRelTeste.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        //BOTÕES DO MENU ORCAMENTOS
        private void BtiCadOrcamento_Click(object sender, EventArgs e)
        {
            var formOrcamentoCadOrcamentos = new fmOrcCadastro();
            formOrcamentoCadOrcamentos.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }



        //FUNÇÕES DO MENU LATERAL
        private void DesmarcarBotoes()
        {
            btCadastrosmenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#007ACC");
            btCReceber.BackColor = System.Drawing.ColorTranslator.FromHtml("#007ACC");
            btCPagar.BackColor = System.Drawing.ColorTranslator.FromHtml("#007ACC");
            btEntradas.BackColor = System.Drawing.ColorTranslator.FromHtml("#007ACC");
            btSaidas.BackColor = System.Drawing.ColorTranslator.FromHtml("#007ACC");
            btOrcamentos.BackColor = System.Drawing.ColorTranslator.FromHtml("#007ACC");
        }

        private void RecolherMenus()
        {
            if (botaoPressionado != "botaocadastro")
            {
                paneldropCadastros.Height = 0;
                CadastrosHidden = true;
            }

            if (botaoPressionado != "botaocontareceber")
            {
                paneldropAreceber.Height = 0;
                ContareceberHidden = true;
            }

            if (botaoPressionado != "botaocontapagar")
            {
                paneldropApagar.Height = 0;
                ContapagarHidden = true;
            }

            if (botaoPressionado != "botaoentrada")
            {
                paneldropEntrada.Height = 0;
                EntradaHidden = true;
            }

            if (botaoPressionado != "botaosaida")
            {
                paneldropSaida.Height = 0;
                SaidaHidden = true;
            }

            if (botaoPressionado != "botaoorcamento")
            {
                paneldropOrcamento.Height = 0;
                OrcamentoHidden = true;
            }

            if(botaoPressionado != "subrelatoriosaida")
            {
                paneldentroRltSaida.Height = 0;
                RelatorioSaidaHidden = true;
            }
        }

        private void TimerDropLateral_Tick(object sender, EventArgs e)
        {
            switch (botaoPressionado)
            {
                case "":

                    paneldropCadastros.Height = 0;
                    CadastrosHidden = true;

                    paneldropAreceber.Height = 0;
                    ContareceberHidden = true;

                    paneldropApagar.Height = 0;
                    ContapagarHidden = true;

                    paneldropEntrada.Height = 0;
                    EntradaHidden = true;

                    paneldropSaida.Height = 0;
                    SaidaHidden = true;

                    paneldropOrcamento.Height = 0;
                    OrcamentoHidden = true;

                    paneldentroRltSaida.Height = 0;
                    RelatorioSaidaHidden = true;

                    panelEsquerdo.Width = 60;
                    MenuHidden = true;

                    


                    break;

                case "botaoexpandiretrai":
                    if (MenuHidden)
                    {
                        panelEsquerdo.Width = panelEsquerdo.Width + 50;
                        if (panelEsquerdo.Width >= panelWidth)
                        {
                            timerDropLateral.Stop();
                            MenuHidden = false;
                            this.Refresh();
                        }
                    }
                    else
                    {
                        panelEsquerdo.Width = panelEsquerdo.Width - 50;
                        if (panelEsquerdo.Width <= 70)
                        {
                            timerDropLateral.Stop();
                            MenuHidden = true;
                            this.Refresh();
                        }
                    }
                    break;

                case "botaocadastro":
                    if (CadastrosHidden)
                    {
                        paneldropCadastros.Height += 100;
                        if (paneldropCadastros.Size == paneldropCadastros.MaximumSize)
                        {
                            timerDropLateral.Stop();
                            CadastrosHidden = false;
                        }
                    }
                    else
                    {
                        paneldropCadastros.Height -= 100;
                        if (paneldropCadastros.Size == paneldropCadastros.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            CadastrosHidden = true;
                            DesmarcarBotoes();
                        }
                    }
                    RecolherMenus();
                    break;

                case "botaocontareceber":
                    if (ContareceberHidden)
                    {
                        paneldropAreceber.Height += 100;
                        if (paneldropAreceber.Size == paneldropAreceber.MaximumSize)
                        {
                            timerDropLateral.Stop();
                            ContareceberHidden = false;
                        }
                    }
                    else
                    {
                        paneldropAreceber.Height -= 100;
                        if (paneldropAreceber.Size == paneldropAreceber.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            ContareceberHidden = true;
                            DesmarcarBotoes();
                        }
                    }
                    RecolherMenus();
                    break;

                case "botaocontapagar":
                    if (ContapagarHidden)
                    {
                        paneldropApagar.Height += 100;
                        if (paneldropApagar.Size == paneldropApagar.MaximumSize)
                        {
                            timerDropLateral.Stop();
                            ContapagarHidden = false;
                        }
                    }
                    else
                    {
                        paneldropApagar.Height -= 100;
                        if (paneldropApagar.Size == paneldropApagar.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            ContapagarHidden = true;
                            DesmarcarBotoes();
                        }
                    }
                    RecolherMenus();
                    break;

                case "botaoentrada":
                    if (EntradaHidden)
                    {
                        paneldropEntrada.Height += 100;
                        if (paneldropEntrada.Size == paneldropEntrada.MaximumSize)
                        {
                            timerDropLateral.Stop();
                            EntradaHidden = false;
                        }
                    }
                    else
                    {
                        paneldropEntrada.Height -= 100;
                        if (paneldropEntrada.Size == paneldropEntrada.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            EntradaHidden = true;
                            DesmarcarBotoes();
                        }
                    }
                    RecolherMenus();
                    break;

                case "botaosaida":
                    if (SaidaHidden)
                    {
                        paneldropSaida.Height += 100;
                        if (paneldropSaida.Size == paneldropSaida.MaximumSize)
                        {
                            timerDropLateral.Stop();
                            SaidaHidden = false;
                        }
                    }
                    else
                    {
                        paneldropSaida.Height -= 100;
                        if (paneldropSaida.Size == paneldropSaida.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            SaidaHidden = true;
                            DesmarcarBotoes();
                        }
                    }
                    RecolherMenus();
                    break;

                case "botaoorcamento":
                    if (OrcamentoHidden)
                    {
                        paneldropOrcamento.Height += 100;
                        if (paneldropOrcamento.Size == paneldropOrcamento.MaximumSize)
                        {
                            timerDropLateral.Stop();
                            OrcamentoHidden = false;
                        }
                    }
                    else
                    {
                        paneldropOrcamento.Height -= 100;
                        if (paneldropOrcamento.Size == paneldropOrcamento.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            OrcamentoHidden = true;
                            DesmarcarBotoes();
                        }
                    }
                    RecolherMenus();
                    break;

                case "subrelatoriosaida":
                    if (RelatorioSaidaHidden)
                    {
                        paneldentroRltSaida.Height += 100;
                        if (paneldentroRltSaida.Size == paneldentroRltSaida.MaximumSize)
                        {
                            timerDropLateral.Stop();
                            RelatorioSaidaHidden = false;
                        }
                    }
                    else
                    {
                        paneldentroRltSaida.Height -= 100;
                        if (paneldentroRltSaida.Size == paneldentroRltSaida.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            RelatorioSaidaHidden = true;
                        }
                    }
                    break;
            }

        }

    }
}
