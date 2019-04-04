using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmLogin : Form
    {
        public Usuario usuario;
        UsuarioBLL usuarioBLL = new UsuarioBLL();


        public fmLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            usuario = usuarioBLL.Logar(tbCodigo.Text, tbSenha.Text);
            if (usuario != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Login e senha inválidos",
                "Login mal sucessido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigo.Focus();
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            tbCodigo.SelectAll();
        }

        private void tbSenha_Enter(object sender, EventArgs e)
        {
            tbSenha.SelectAll();
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
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
                new Limpar().limparTudo(this.Controls);
            }


        }

        private void btProcuraUsuario_Click(object sender, EventArgs e)
        {
            var buscaUsuario = new fmBuscaUsuario();
            buscaUsuario.ShowDialog();
            if (buscaUsuario.usuarioSelecionado != null)
            {
                usuario = buscaUsuario.usuarioSelecionado;
                PreencheCamposCodUsuario(usuario);
            }
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Length > 0)
            {
                usuario = usuarioBLL.BuscarUsuarioById(int.Parse(tbCodigo.Text));
                PreencheCamposCodUsuario(usuario);
            }
            else
            {
                tbNomeUsuario.Text = "";
            }
        }
    }
}
