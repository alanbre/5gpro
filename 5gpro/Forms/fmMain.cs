using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro
{
    public partial class fmMain : Form
    {
        public fmMain(Usuario usuario)
        {
            InitializeComponent();
            SetarLogado(usuario);
        }

        public Usuario usuariologadomain;

        UsuarioDAO usuarioDAO = new UsuarioDAO();
        NetworkAdapter adap = new NetworkAdapter();

        public void SetarLogado(Usuario usuario)
        {
            usuariologadomain = usuario;
        }

        private void tsmiCadastroPessoas_Click(object sender, EventArgs e)
        {
            var formCadPessoas = new fmCadastroPessoa();
            formCadPessoas.Show(this);
            
        }

        private void tsmiCadastroPaises_Click(object sender, EventArgs e)
        {
            var formCadPais = new fmCadastroPais();
            formCadPais.Show(this);
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

        private void tsmiCadastroUsuariosMenuItem_Click(object sender, EventArgs e)
        {
            var formCadUsuarios = new fmCadastroUsuario();
            formCadUsuarios.Show(this);
        }

        private void tsmiEmissaoNF_Click(object sender, EventArgs e)
        {
            var formSaidaEmissaoNota = new fmSaidaEmissaoNota();
            formSaidaEmissaoNota.Show(this);
        }

        private void cadastroDeGrupoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadGrupoUsuarios = new fmCadastroGrupoUsuario();
            formCadGrupoUsuarios.Show(this);
        }


        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Logado lol = usuarioDAO.BuscaLogado(usuariologadomain, adap.Mac);
            usuarioDAO.RemoverLogado(usuarioDAO.BuscaLogado(usuariologadomain, adap.Mac));
        }
    }
}
