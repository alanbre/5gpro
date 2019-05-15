using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _5gpro.Forms
{
    public partial class fmLogin : Form
    {
        public Usuario usuariologado;
        public Logado logado;

        public UsuarioDAO usuarioDAO = new UsuarioDAO();
        public LogadoDAO logadoDAO = new LogadoDAO();

        NetworkAdapter adap = new NetworkAdapter();


        public fmLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {

            usuariologado = usuarioDAO.Logar(tbCodigo.Text, tbSenha.Text);

            if (usuariologado != null)
            {
                logado = logadoDAO.BuscaLogadoByUsuario(usuariologado);
                if (logado != null)
                {                  
                    MessageBox.Show("Usuário "+usuariologado.Nome+" logado no computador "+logado.NomePC, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    logadoDAO.GravarLogado(usuariologado, adap.Mac, adap.Nome, adap.IP);
                    this.Close();
                }
               
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
                PreencheCamposCodUsuario(buscaUsuario.usuarioSelecionado);
            }
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (tbCodigo.Text.Length > 0)
            {
                PreencheCamposCodUsuario(usuarioDAO.BuscarUsuarioByIdLogin(int.Parse(tbCodigo.Text)));
            }
            else
            {
                tbNomeUsuario.Text = "";
            }
        }
    }
}
