using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Entities;
using _5gpro.Daos;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaSubGrupoItem : UserControl
    {

        public SubGrupoItem subgrupoItem = null;
        private GrupoItem grupofiltro = null;
        private static readonly ConexaoDAO conexao = new ConexaoDAO();
        private readonly SubGrupoItemDAO subgrupoItemDAO = new SubGrupoItemDAO(conexao);


        public BuscaSubGrupoItem()
        {
            InitializeComponent();
        }

        public void GrupoFiltro(GrupoItem grupoitem)
        {
            if(grupoitem != null)
            {
                tbCodigoSubGrupoItem.Enabled = true;
                btBuscaSubGrupoItem.Enabled = true;
                tbNomeSubGrupoItem.Enabled = true;
                grupofiltro = grupoitem;
            }
            else
            {
                tbCodigoSubGrupoItem.Enabled = false;
                btBuscaSubGrupoItem.Enabled = false;
                tbNomeSubGrupoItem.Enabled = false;
            }
        }

        private void TbCodigoSubGrupoItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaSubGrupoItem();
            }
        }

        private void TbCodigoSubGrupoItem_Leave(object sender, EventArgs e)
        {

            if (!int.TryParse(tbCodigoSubGrupoItem.Text, out int codigo)) { tbCodigoSubGrupoItem.Clear(); }
            if (tbCodigoSubGrupoItem.Text.Length > 0)
            {
                subgrupoItem = subgrupoItemDAO.BuscarByID(int.Parse(tbCodigoSubGrupoItem.Text), grupofiltro.GrupoItemID);
                PreencheCamposSubGrupoItem(subgrupoItem);
            }
            else
            {
                subgrupoItem = null;
                tbNomeSubGrupoItem.Clear();
            }
        }

        private void BtBuscaSubGrupoItem_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaSubGrupoItem();
        }

        private void AbreTelaBuscaSubGrupoItem()
        {
            var buscaSubGrupoItem = new fmBuscaSubGrupoItem(grupofiltro.GrupoItemID);
            buscaSubGrupoItem.ShowDialog();
            if (buscaSubGrupoItem.subgrupoitemSelecionado != null)
            {
                subgrupoItem = buscaSubGrupoItem.subgrupoitemSelecionado;
                PreencheCamposSubGrupoItem(subgrupoItem);
            }
        }

        private void PreencheCamposSubGrupoItem(SubGrupoItem subgrupoItem)
        {
            if (subgrupoItem != null)
            {
                tbCodigoSubGrupoItem.Text = subgrupoItem.SubGrupoItemID.ToString();
                tbNomeSubGrupoItem.Text = subgrupoItem.Nome;
            }
            else
            {
                MessageBox.Show("Sub-Grupo de itens não encontrado no banco de dados",
                "Sub-Grupo de itens não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigoSubGrupoItem.Focus();
                tbNomeSubGrupoItem.SelectAll();
            }
        }

        public void PreencheCampos(SubGrupoItem subgrupoItem)
        {
            if (subgrupoItem != null)
            {
                this.subgrupoItem = subgrupoItem;
                tbCodigoSubGrupoItem.Text = subgrupoItem.SubGrupoItemID.ToString();
                tbNomeSubGrupoItem.Text = subgrupoItem.Nome;
            }
            else
            {
                Limpa();
            }
        }

        public void Limpa()
        {
            this.subgrupoItem = null;
            tbCodigoSubGrupoItem.Clear();
            tbNomeSubGrupoItem.Clear();
        }


        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoSubGrupoItem_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }

    }
}
