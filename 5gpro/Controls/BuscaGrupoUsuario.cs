using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Bll;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaGrupoUsuario : UserControl
    {
        static ConexaoDAO connection = new ConexaoDAO();
        public GrupoUsuario grupoUsuario = new GrupoUsuario();
        private readonly GrupoUsuarioDAO grupoUsuarioDAO = new GrupoUsuarioDAO(connection);

        public BuscaGrupoUsuario()
        {
            InitializeComponent();
        }

        private void TbCodigoGrupoUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaCidade();
            }
        }

        private void TbCodigoGrupoUsuario_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNomeGrupoUsuario.Text, out int codigo)) { tbNomeGrupoUsuario.Clear(); }
            if (tbNomeGrupoUsuario.Text.Length > 0)
            {
                grupoUsuario = grupoUsuarioDAO.BuscarGrupoUsuarioById(int.Parse(tbNomeGrupoUsuario.Text));
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
            AbreTelaBuscaCidade();
        }



        private void AbreTelaBuscaCidade()
        {
            var buscaGrupoUsuario = new fmBuscaGrupoUsuario();
            buscaGrupoUsuario.ShowDialog();
            if (buscaGrupoUsuario.grupousuarioSelecionado != null)
            {
                grupoUsuario = buscaGrupoUsuario.grupousuarioSelecionado;
                PreencheCamposGrupoUsuario(grupoUsuario);
            }
        }

        private void PreencheCamposGrupoUsuario(GrupoUsuario grupoUsuario)
        {
            tbCodigoGrupoUsuario.Text = grupoUsuario.GrupoUsuarioID.ToString();
            tbNomeGrupoUsuario.Text = grupoUsuario.Nome;
        }

        public void PreencheCampos(GrupoUsuario grupoUsuario)
        {
            this.grupoUsuario = grupoUsuario;
            tbNomeGrupoUsuario.Text = grupoUsuario.Nome;
            tbCodigoGrupoUsuario.Text = grupoUsuario.GrupoUsuarioID.ToString();
        }

        public void Limpa()
        {
            grupoUsuario = null;
            tbCodigoGrupoUsuario.Clear();
            tbNomeGrupoUsuario.Clear();
        }






        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código da pessoa é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoGrupoUsuario_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
