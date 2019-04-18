using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaItem : UserControl
    {
        public Item item = null;
        private readonly ItemDAO itemDAO = new ItemDAO();

        public BuscaItem()
        {
            InitializeComponent();
        }

        private void BtProcuraItem_Click(object sender, System.EventArgs e)
        {
            AbreTelaBuscaItem();
        }

        private void TbCodigoItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaItem();
            }
        }

        private void TbCodigoItem_Leave(object sender, System.EventArgs e)
        {
            if (!int.TryParse(tbCodigoItem.Text, out int codigo)) { tbCodigoItem.Clear(); }
            if (tbCodigoItem.Text.Length > 0)
            {
                item = itemDAO.BuscarItemById(int.Parse(tbCodigoItem.Text));
                PreencheCamposItem(item);
            }
            else
            {
                item = null;
                tbDescricaoItem.Clear();
            }
            this.Codigo_Leave?.Invoke(this, e);
        }




        private void AbreTelaBuscaItem()
        {
            var buscaItem = new fmBuscaItem();
            buscaItem.ShowDialog();
            if (buscaItem.itemSelecionado != null)
            {
                Item item = buscaItem.itemSelecionado;
                PreencheCamposItem(item);
            }
        }

        private void PreencheCamposItem(Item item)
        {
            if (item != null)
            {
                tbCodigoItem.Text = item.ItemID.ToString();
                tbDescricaoItem.Text = item.Descricao;
            }
            else
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigoItem.Focus();
                tbCodigoItem.SelectAll();
            }
        }

        public void PreencheCampos(Item item)
        {
            this.item = item;
            tbCodigoItem.Text = item.ItemID.ToString();
            tbDescricaoItem.Text = item.Descricao;
        }

        public void Limpa()
        {
            this.item = null;
            tbCodigoItem.Clear();
            tbDescricaoItem.Clear();
        }


        //--------------------------------------------------
        //CRIA OS EVENTOS DO USERCONTROL
        //--------------------------------------------------
        public delegate void codigo_leaveEventHandler(object sender, EventArgs e);
        public delegate void codigo_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o foco sai do campo Código do item")]
        public event codigo_leaveEventHandler Codigo_Leave;

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código do item é alterado")]
        public event codigo_changedEventHandler Codigo_Changed;

        //--------------------------------------------------


        private void TbCodigoItem_TextChanged(object sender, EventArgs e)
        {
            this.Codigo_Changed?.Invoke(this, e);
        }
    }
}
