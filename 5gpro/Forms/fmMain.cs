using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace _5gpro
{
    public partial class fmMain : Form
    {

        private Permissao permissao = new Permissao();
        private PermissaoDAO permissaoDAO = new PermissaoDAO(new ConexaoDAO());
        private Logado logado = new Logado();
        private LogadoDAO logadoDAO = new LogadoDAO(fmLogin.connection);
        private NetworkAdapter adap = new NetworkAdapter();
        private string Codgrupousuario;
        private List<PermissaoNivelStruct> listapermissaonivel = new List<PermissaoNivelStruct>();


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
        //Cadastro de Contas a Pagar = 060100
        //Cadastro de Grupo de Itens = 010500
        //Cadastro de Grupo de Pessoas = 010600

        public fmMain()
        {
            InitializeComponent();
            FiltroDePermissoes();
            t = new Thread(new ThreadStart(AtualizaLogado));
            t.Start();
        }

        static ConexaoDAO connection = new ConexaoDAO();

        public struct PermissaoNivelStruct
        {
            public Permissao permissao;
            public int Nivel;

        }

        private void FiltroDePermissoes()
        {

            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);

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

        private void tsmiCadastroPessoas_Click(object sender, EventArgs e)
        {
            var formCadPessoas = new fmCadastroPessoa();
            formCadPessoas.Show(this);
        }


        private void tsmiCadastroItens_Click(object sender, EventArgs e)
        {
            var formCadItens = new fmCadastroItem();
            formCadItens.Show(this);
        }

        private void tsmiCadastroOrcamentos_Click(object sender, EventArgs e)
        {
            var formOrcamentoCadOrcamentos = new fmOrcamentoCadastroOrcamento();
            formOrcamentoCadOrcamentos.Show(this);
        }

        private void tsmiCadastroUsuarios_Click(object sender, EventArgs e)
        {
            var formCadUsuarios = new fmCadastroUsuario();
            formCadUsuarios.Show(this);
        }

        private void tsmiEmissaoNF_Click(object sender, EventArgs e)
        {
            var formSaidaEmissaoNota = new fmSaidaEmissaoNota();
            formSaidaEmissaoNota.Show(this);
        }

        private void tsmiCadastroDeGrupoDeUsuários_Click(object sender, EventArgs e)
        {
            var formCadGrupoUsuarios = new fmCadastroGrupoUsuario();
            formCadGrupoUsuarios.Show(this);
        }

        private void tsmiCadastroDeOperações_Click(object sender, EventArgs e)
        {
            var formCadOperacao = new fmCadastroOperacao();
            formCadOperacao.Show(this);
        }

        private void TsmiCarCadastroContaReceber_Click(object sender, EventArgs e)
        {
            var formCarCadContaReceber = new fmCarCadastroConta();
            formCarCadContaReceber.Show(this);
        }


        private void TsmiCapCadastroContaReceber_Click(object sender, EventArgs e)
        {
            var formCapCadContaPagar = new fmCapCadastroConta();
            formCapCadContaPagar.Show(this);
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

        private void CadastroDeGrupoDeItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadGrupoItem = new fmCadastroGrupoItem();
            formCadGrupoItem.Show(this);
        }

        private void TESTETROCOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTroco = new fmTroco();
            formTroco.Show(this);
        }

        private void CadastroDeGrupoDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadGrupoPessoa = new fmCadastroGrupoPessoa();
            formCadGrupoPessoa.Show(this);
        }
    }
}
