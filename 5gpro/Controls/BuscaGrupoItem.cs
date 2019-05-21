using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Entities;
using _5gpro.Daos;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaGrupoItem : UserControl
    {

        public GrupoItem grupoItem = null;
        private readonly GrupoItemDAO grupoItemDAO = new GrupoItemDAO();

        public BuscaGrupoItem()
        {
            InitializeComponent();
        }

        private void TbCodigoGrupoItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaGrupoItem();
            }
        }

        private void TbCodigoGrupoItem_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigoGrupoItem.Text, out int codigo)) { tbCodigoGrupoItem.Clear(); }
            if (tbCodigoGrupoItem.Text.Length > 0)
            {
                grupoItem = grupoItemDAO.BuscaByID(int.Parse(tbCodigoGrupoItem.Text));
                PreencheCamposGrupoItem(grupoItem);
            }
            else
            {
                grupoItem = null;
                tbNomeGrupoItem.Clear();
            }
        }

        private void BtBuscaGrupoItem_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaGrupoItem();
        }

        private void AbreTelaBuscaGrupoItem()
        {
            var buscaGrupoItem = new fmBuscaGrupoItem();
            buscaGrupoItem.ShowDialog();
            if (buscaGrupoItem.grupoitemSelecionado != null)
            {
                grupoItem = buscaGrupoItem.grupoitemSelecionado;
                PreencheCamposGrupoItem(grupoItem);
            }
        }

        private void AbreTelaCadGrupoItem()
        {
            var cadGrupoItem = new fmCadastroGrupoItem();
            cadGrupoItem.ShowDialog();
        }

        private void PreencheCamposGrupoItem(GrupoItem grupoItem)
        {
            if (grupoItem != null)
            {
                tbCodigoGrupoItem.Text = grupoItem.GrupoItemID.ToString();
                tbNomeGrupoItem.Text = grupoItem.Nome;
            }
            else
            {
                MessageBox.Show("Grupo de itens não encontrado no banco de dados",
                "Grupo de itens não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Limpa();
            }
        }

        public void PreencheCampos(GrupoItem grupoItem)
        {
            if (grupoItem != null)
            {
                this.grupoItem = grupoItem;
                tbCodigoGrupoItem.Text = grupoItem.GrupoItemID.ToString();
                tbNomeGrupoItem.Text = grupoItem.Nome;
            }
            else
            {
                Limpa();
            }
        }

        public void Limpa()
        {
            this.grupoItem = null;
            tbCodigoGrupoItem.Clear();
            tbNomeGrupoItem.Clear();
        }


        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoGrupoItem_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            AbreTelaCadGrupoItem();
        }
    }
}
