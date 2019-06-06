using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaUsuario : UserControl
    {
        public Usuario usuario = null;
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();

        public BuscaUsuario()
        {
            InitializeComponent();
        }

        private void BtBusca_Click(object sender, EventArgs e) => Busca();
        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                Busca();
            }
        }
        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (tbCodigo.Text.Length > 0)
            {
                usuario = usuarioDAO.BuscaByID(int.Parse(tbCodigo.Text));
                PreencheCamposUsuario(usuario);
            }
            else
            {
                usuario = null;
                tbNome.Clear();
            }
        }

        private void Busca()
        {
            var buscaUsuario = new fmBuscaUsuario();
            buscaUsuario.ShowDialog();
            if (buscaUsuario.usuarioSelecionado != null)
            {
                usuario = buscaUsuario.usuarioSelecionado;
                PreencheCamposUsuario(usuario);
            }
        }
        private void PreencheCamposUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                MessageBox.Show("Caixa não encontrado no banco de dados",
                "Caixa não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigo.Clear();
                tbCodigo.Focus();
                tbCodigo.SelectAll();
                return;
            }

            tbCodigo.Text = usuario.UsuarioID.ToString();
            tbNome.Text = usuario.Nome;
        }
        public void PreencheCampos(Usuario usuario)
        {
            this.usuario = usuario;
            tbCodigo.Text = this.usuario != null ? this.usuario.UsuarioID.ToString() : "";
            tbNome.Text = this.usuario != null ? this.usuario.Nome : "";
        }
        public void Limpa()
        {
            tbCodigo.Clear();
            tbNome.Clear();
            usuario = null;
        }



        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código do usuário é alterado")]
        public event text_changedEventHandler Text_Changed;

        private void TbCodigo_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
