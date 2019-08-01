using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.StaticFiles;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmLogin : Form
    {
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();
        private readonly LogadoDAO logadoDAO = new LogadoDAO();

        private readonly NetworkAdapter adaptador = new NetworkAdapter();


        public fmLogin()
        {
            InitializeComponent();
        }
        private void FmLogin_Load(object sender, EventArgs e)
        {
            if (Configuracao.CodUsuario != null)
            {
                tbCodigo.Text = Configuracao.CodUsuario;
                PreencheUsuario();
            }
        }

        private void BtEntrar_Click(object sender, EventArgs e) => Entrar();
        private void BtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TbLogin_Enter(object sender, EventArgs e)
        {
            tbCodigo.SelectAll();
        }
        private void TbSenha_Enter(object sender, EventArgs e)
        {
            tbSenha.SelectAll();
        }
        private void TbLogin_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void TbSenha_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void BtProcuraUsuario_Click(object sender, EventArgs e) => Busca();
        private void TbCodigo_Leave(object sender, EventArgs e) => PreencheUsuario();

        private void Entrar()
        {
            var usuariologado = usuarioDAO.Logar(tbCodigo.Text, tbSenha.Text);


            if (usuariologado == null)
            {
                MessageBox.Show("Login e senha inválidos",
                "Login mal sucessido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigo.Focus();
                return;
            }

            Logado.Mac = adaptador.Mac;
            Logado.IPdoPC = adaptador.IP;
            Logado.NomePC = adaptador.Nome;
            Logado.Usuario = usuariologado;
            if (logadoDAO.ChecaLogado(Logado.Mac, Logado.NomePC, Logado.IPdoPC))
            {
                MessageBox.Show("Usuário " + Logado.Usuario.Nome + " logado no computador " + Logado.NomePC, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                logadoDAO.GravarLogado();
                if (tbCodigo.Text != Configuracao.CodUsuario)
                {
                    DadosEstaticos.SalvaDadoEstatico("Login", "codusuario", tbCodigo.Text);
                }
                this.Close();
            }

        }
        private void PreencheUsuario()
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (tbCodigo.Text.Length > 0)
            {
                PreencheCamposCodUsuario(usuarioDAO.BuscaByIDLogin(int.Parse(tbCodigo.Text)));
            }
            else
            {
                tbNomeUsuario.Clear();
            }
        }
        private void Busca()
        {
            var buscaUsuario = new fmBuscaUsuario();
            buscaUsuario.ShowDialog();
            if (buscaUsuario.usuarioSelecionado != null)
            {
                PreencheCamposCodUsuario(buscaUsuario.usuarioSelecionado);
            }
        }
        private void PreencheCamposCodUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                tbCodigo.Text = usuario.UsuarioID.ToString();
                tbNomeUsuario.Text = usuario.Nome;
            }
            else
            {
                tbCodigo.Clear();
                tbNomeUsuario.Clear();
            }
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
