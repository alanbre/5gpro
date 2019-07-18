using System;
using System.Windows.Forms;
using _5gpro.Forms;
using _5gpro.Entities;
using System.ComponentModel;
using _5gpro.Daos;

namespace _5gpro.Controls
{
    public partial class BuscaGrupoUsuario : UserControl
    {
        public GrupoUsuario grupoUsuario = null;
        private readonly GrupoUsuarioDAO grupoUsuarioDAO = new GrupoUsuarioDAO();

        public BuscaGrupoUsuario()
        {
            InitializeComponent();
        }

        private void TbCodigoGrupoUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaGrupoUsuario();
            }
        }


        private void TbCodigoGrupoUsuario_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigoGrupoUsuario.Text, out int codigo)) { tbCodigoGrupoUsuario.Clear(); }
            if (tbCodigoGrupoUsuario.Text.Length > 0)
            {
                grupoUsuario = grupoUsuarioDAO.BuscaByID(int.Parse(tbCodigoGrupoUsuario.Text));
                PreencheCamposGrupoUsuario(grupoUsuario);
            }
            else
            {
                grupoUsuario = null;
                tbNomeGrupoUsuario.Clear();
            }
        }

        private void BtBuscaGrupoUsuario_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaGrupoUsuario();
        }


        private void AbreTelaBuscaGrupoUsuario()
        {
            var buscaGrupoUsuario = new fmBuscaGrupoUsuario();
            buscaGrupoUsuario.ShowDialog();
            if (buscaGrupoUsuario.grupoUsuarioSelecionado != null)
            {
                grupoUsuario = buscaGrupoUsuario.grupoUsuarioSelecionado;
                PreencheCamposGrupoUsuario(grupoUsuario);
            }
        }

        private void PreencheCamposGrupoUsuario(GrupoUsuario grupoUsuario)
        {
            if (grupoUsuario != null)
            {
                tbCodigoGrupoUsuario.Text = grupoUsuario.GrupoUsuarioID.ToString();
                tbNomeGrupoUsuario.Text = grupoUsuario.Nome;
            }
            else
            {
                MessageBox.Show("Grupo de usuários não encontrado no banco de dados",
                "Grupo de usuários não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigoGrupoUsuario.Focus();
                tbNomeGrupoUsuario.SelectAll();
            }
        }

        public void PreencheCampos(GrupoUsuario grupoUsuario)
        {
            if (grupoUsuario != null)
            {
                this.grupoUsuario = grupoUsuario;
                tbCodigoGrupoUsuario.Text = grupoUsuario.GrupoUsuarioID.ToString();
                tbNomeGrupoUsuario.Text = grupoUsuario.Nome;
            }
            else
            {
                Limpa();
            }
        }

        public void Limpa()
        {
            this.grupoUsuario = null;
            tbCodigoGrupoUsuario.Clear();
            tbNomeGrupoUsuario.Clear();
        }

        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------


        private void TbCodigoGrupoUsuario_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
