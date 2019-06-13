using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.Funcoes;
using _5gpro.Reports;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

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
            EntradaHidden, SaidaHidden, OrcamentoHidden, RelatorioSaidaHidden, CaixaHidden;

        private int cadastrosOn = 8,
                    areceberOn = 2,
                    apagarOn = 2,
                    entradasOn = 1,
                    saidasOn = 2,
                    orcamentosOn = 1,
                    relatoriosOn = 1,
                    caixaOn = 4,
                    tamanhopanel
            ;

        int panelWidth;

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


        public fmMain()
        {
            InitializeComponent();
            panelWidth = panelEsquerdo.Width;
            timerDropLateral.Start();
            FiltroDePermissoes();
            t = new Thread(new ThreadStart(AtualizaLogado));
            t.Start();
            timerRelogio.Start();
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
                            //Cadastro Pessoa
                            if (p.Nivel == 0) { btiCadPessoa.Visible = false; cadastrosOn = cadastrosOn - 1; }
                            else
                            { btiCadPessoa.Visible = true; }
                            break;

                        case "010300":
                            //Cadastro Itens
                            if (p.Nivel == 0) { btiItens.Visible = false; cadastrosOn = cadastrosOn - 1; }
                            else
                            { btiItens.Visible = true; }
                            break;

                        case "010200":
                            //Cadastro Usuário
                            if (p.Nivel == 0) { btiUsuarios.Visible = false; cadastrosOn = cadastrosOn - 1; }
                            else
                            { btiUsuarios.Visible = true; }
                            break;

                        case "010400":
                            //Cadastro Grupo de usuários
                            if (p.Nivel == 0) { btiGruposusuarios.Visible = false; cadastrosOn = cadastrosOn - 1; }
                            else
                            { btiGruposusuarios.Visible = true; }
                            break;

                        case "040100":
                            //Cadastro de Operações
                            if (p.Nivel == 0) { btiOperacoes.Visible = false; cadastrosOn = cadastrosOn - 1; }
                            else
                            { btiOperacoes.Visible = true; }
                            break;

                        case "010500":
                            //Cadastro de Grupo de Itens
                            if (p.Nivel == 0) { btiGrupoitens.Visible = false; cadastrosOn = cadastrosOn - 1; }
                            else
                            { btiGrupoitens.Visible = true; }
                            break;

                        case "010600":
                            //Cadastro de Grupo de Pessoas
                            if (p.Nivel == 0) { btiGrupopessoa.Visible = false; cadastrosOn = cadastrosOn - 1; }
                            else
                            { btiGrupopessoa.Visible = true; }
                            break;
                        case "010700":
                            //Cadastro de unidades de medida
                            if (p.Nivel == 0) { btiUnimedida.Visible = false; cadastrosOn -= 1; }
                            else
                            { btiUnimedida.Visible = true; }
                            break;
                        case "050100":
                            //Cadastro de Conta a Receber
                            if (p.Nivel == 0) { btiCadContaReceber.Visible = false; areceberOn = areceberOn - 1; }
                            else
                            { btiCadContaReceber.Visible = true; }
                            break;

                        case "050200":
                            //Quitação de Conta a Receber
                            if (p.Nivel == 0) { btiQuitacaoAReceber.Visible = false; areceberOn = areceberOn - 1; }
                            else
                            { btiQuitacaoAReceber.Visible = true; }
                            break;

                        case "060100":
                            //Cadastro de Conta a Pagar
                            if (p.Nivel == 0) { btiCadContaPagar.Visible = false; apagarOn = apagarOn - 1; }
                            else
                            { btiCadContaPagar.Visible = true; }
                            break;

                        //Quitação de Conta a Pagar
                        case "060200":
                            if (p.Nivel == 0) { btiQuitacaoAPagar.Visible = false; apagarOn = apagarOn - 1; }
                            else
                            { btiQuitacaoAPagar.Visible = true; }
                            break;


                        //Entrada
                        case "070100":
                            if (p.Nivel == 0) { btiEntrada.Visible = false; entradasOn = entradasOn - 1; }
                            else
                            { btiEntrada.Visible = true; }
                            break;

                        //Saida
                        case "030100":
                            if (p.Nivel == 0) { btiSaida.Visible = false; saidasOn = saidasOn - 1; }
                            else
                            { btiSaida.Visible = true; }
                            break;

                        case "030200":
                            //Relatório de Notas
                            if (p.Nivel == 0) { btiRltNotaSaida.Visible = false; relatoriosOn = relatoriosOn - 1; }
                            else
                            { btiRltNotaSaida.Visible = true; }
                            if (relatoriosOn == 0) { saidasOn = saidasOn - 1; }
                            break;

                        case "020100":
                            //Cadastro de Orçamentos
                            if (p.Nivel == 0) { btiCadOrcamento.Visible = false; orcamentosOn = orcamentosOn - 1; }
                            else
                            { btiCadOrcamento.Visible = true; }
                            break;

                        case "090100":
                            //Cadastro de caixas
                            if (p.Nivel == 0) { btiCadastroCaixa.Visible = false; caixaOn -= 1; }
                            else { btiCadastroCaixa.Visible = true; }
                            break;

                        case "090200":
                            //Abertura e fechamento de caixa
                            if (p.Nivel == 0) { btiAberturaFechamento.Visible = false; caixaOn -= 1; }
                            else { btiAberturaFechamento.Visible = true; }
                            break;

                        case "090300":
                            //Sangria de caixa
                            if (p.Nivel == 0) { btiSangria.Visible = false; caixaOn -= 1; }
                            else { btiSangria.Visible = true; }
                            break;
                    }
                }

                btCadastrosmenu.Enabled = cadastrosOn == 0 ? false : true;
                btCReceber.Enabled = areceberOn == 0 ? false : true;
                btCPagar.Enabled = apagarOn == 0 ? false : true;
                btEntradas.Enabled = entradasOn == 0 ? false : true;
                btSaidas.Enabled = saidasOn == 0 ? false : true;
                btOrcamentos.Enabled = orcamentosOn == 0 ? false : true;
                btiRltNotaSaida.Enabled = relatoriosOn == 0 ? false : true;
                btiCadastroCaixa.Enabled = caixaOn == 0 ? false : true;

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

        private void BtCaixa_Click(object sender, EventArgs e)
        {
            DesmarcarBotoes();
            btCaixa.BackColor = System.Drawing.ColorTranslator.FromHtml("#0092F4");
            timerDropLateral.Start();
            botaoPressionado = "botaocaixa";
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


        private void BtiCadastroCaixa_Click(object sender, EventArgs e)
        {
            var formCadCaixa = new fmCaiCadastroCaixa();
            formCadCaixa.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();

        }

        private void BtiLancamentoManual_Click(object sender, EventArgs e)
        {
            var formCaiLancamentoManual = new fmCaiLancamentoManual();
            formCaiLancamentoManual.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }


        private void BtiSangria_Click(object sender, EventArgs e)
        {
            var formCaiSangria = new fmCaiSangria();
            formCaiSangria.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiAberturaFechamento_Click(object sender, EventArgs e)
        {
            var formAberturaFechamento = new fmCaiAberturaFechamento();
            formAberturaFechamento.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }


        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            lbRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        private void BtiUnimedida_Click(object sender, EventArgs e)
        {
            var formCadUnidadeMedida = new fmCadastroUnimedida();
            formCadUnidadeMedida.Show(this);
            botaoPressionado = "";
            RecolherMenus();
            DesmarcarBotoes();
        }

        private void BtiDefPartes_Click(object sender, EventArgs e)
        {
            var formDefPartes = new fmCadastroDesintegracao();
            formDefPartes.Show(this);
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
            btCadastrosmenu.BackColor = ColorTranslator.FromHtml("#007ACC");
            btCReceber.BackColor = ColorTranslator.FromHtml("#007ACC");
            btCPagar.BackColor = ColorTranslator.FromHtml("#007ACC");
            btEntradas.BackColor = ColorTranslator.FromHtml("#007ACC");
            btSaidas.BackColor = ColorTranslator.FromHtml("#007ACC");
            btOrcamentos.BackColor = ColorTranslator.FromHtml("#007ACC");
            btiRltNotaSaida.BackColor = ColorTranslator.FromHtml("#007ACC");
            btCaixa.BackColor = ColorTranslator.FromHtml("#007ACC");
        }
        private void RecolherMenus()
        {
            Image imgdefault = Properties.Resources.right_18px;
            btiRltNotaSaida.Image = imgdefault;

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

            if (botaoPressionado != "subrelatoriosaida")
            {
                paneldentroRltSaida.Height = 0;
                RelatorioSaidaHidden = true;
            }

            if (botaoPressionado != "botaocaixa")
            {
                paneldropCaixa.Height = 0;
                CaixaHidden = true;
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

                    paneldropCaixa.Height = 0;
                    CaixaHidden = true;

                    Image imgdefault = Properties.Resources.right_18px;
                    btiRltNotaSaida.Image = imgdefault;

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
                        tamanhopanel = cadastrosOn * 28;
                        paneldropCadastros.Height += tamanhopanel > 0 ? 28 : 0;

                        if (paneldropCadastros.Size.Height == tamanhopanel)
                        {
                            timerDropLateral.Stop();
                            CadastrosHidden = false;
                            paneldropCadastros.BringToFront();
                        }
                    }
                    else
                    {
                        paneldropCadastros.Height -= 28;
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
                        tamanhopanel = areceberOn * 28;
                        paneldropAreceber.Height += tamanhopanel > 0 ? 28 : 0;

                        if (paneldropAreceber.Size.Height == tamanhopanel)
                        {
                            timerDropLateral.Stop();
                            ContareceberHidden = false;
                            paneldropAreceber.BringToFront();
                        }
                    }
                    else
                    {
                        paneldropAreceber.Height -= 28;
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
                        tamanhopanel = apagarOn * 28;
                        paneldropApagar.Height += tamanhopanel > 0 ? 28 : 0;

                        if (paneldropApagar.Size.Height == tamanhopanel)
                        {
                            timerDropLateral.Stop();
                            ContapagarHidden = false;
                            paneldropApagar.BringToFront();
                        }
                    }
                    else
                    {
                        paneldropApagar.Height -= 28;
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
                        tamanhopanel = entradasOn * 28;
                        paneldropEntrada.Height += tamanhopanel > 0 ? 28 : 0;

                        if (paneldropEntrada.Size.Height == tamanhopanel)
                        {
                            timerDropLateral.Stop();
                            EntradaHidden = false;
                            paneldropEntrada.BringToFront();
                        }
                    }
                    else
                    {
                        paneldropEntrada.Height -= 28;
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
                        tamanhopanel = saidasOn * 28;
                        paneldropSaida.Height += tamanhopanel > 0 ? 28 : 0;

                        if (paneldropSaida.Size.Height == tamanhopanel)
                        {
                            timerDropLateral.Stop();
                            SaidaHidden = false;
                            paneldropSaida.BringToFront();
                        }
                    }
                    else
                    {
                        paneldropSaida.Height -= 28;
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
                        tamanhopanel = orcamentosOn * 28;
                        paneldropOrcamento.Height += tamanhopanel > 0 ? 28 : 0;

                        if (paneldropOrcamento.Size.Height == tamanhopanel)
                        {
                            timerDropLateral.Stop();
                            OrcamentoHidden = false;
                            paneldropOrcamento.BringToFront();
                        }
                    }
                    else
                    {
                        paneldropOrcamento.Height -= 28;
                        if (paneldropOrcamento.Size == paneldropOrcamento.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            OrcamentoHidden = true;
                            DesmarcarBotoes();
                        }
                    }
                    RecolherMenus();
                    break;

                case "botaocaixa":
                    if (CaixaHidden)
                    {
                        tamanhopanel = caixaOn * 28;
                        paneldropCaixa.Height += tamanhopanel > 0 ? 28 : 0;

                        if (paneldropCaixa.Size.Height == tamanhopanel)
                        {
                            timerDropLateral.Stop();
                            CaixaHidden = false;
                            paneldropCaixa.BringToFront();
                        }
                    }
                    else
                    {
                        paneldropCaixa.Height -= 28;
                        if (paneldropCaixa.Size == paneldropCaixa.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            CaixaHidden = true;
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
                            Image imgleft = Properties.Resources.left_18px;
                            btiRltNotaSaida.Image = imgleft;
                            paneldentroRltSaida.BringToFront();
                        }
                    }
                    else
                    {
                        paneldentroRltSaida.Height -= 100;
                        if (paneldentroRltSaida.Size == paneldentroRltSaida.MinimumSize)
                        {
                            timerDropLateral.Stop();
                            RelatorioSaidaHidden = true;
                            Image imgright = Properties.Resources.right_18px;
                            btiRltNotaSaida.Image = imgright;
                            btiRltNotaSaida.BackColor = System.Drawing.ColorTranslator.FromHtml("#007ACC");
                        }
                    }
                    break;
            }
        }
    }
}
