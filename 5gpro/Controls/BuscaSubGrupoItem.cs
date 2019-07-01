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
        private GrupoItem gruporecebido = null;
        private readonly SubGrupoItemDAO subgrupoItemDAO = new SubGrupoItemDAO();

        public BuscaSubGrupoItem()
        {
            InitializeComponent();
        }

        public void EnviarGrupo(GrupoItem grupoitem)
        {
            gruporecebido = grupoitem;
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

            if (gruporecebido == null)
            {
                tbNomeSubGrupoItem.Text = "Escolha o Grupo";
            }
            else
            {
                if (tbCodigoSubGrupoItem.Text.Length > 0)
                {
                    subgrupoItem = subgrupoItemDAO.BuscaByID(int.Parse(tbCodigoSubGrupoItem.Text), gruporecebido.GrupoItemID);
                    PreencheCamposSubGrupoItem(subgrupoItem);
                }
                else
                {
                    subgrupoItem = null;
                    tbNomeSubGrupoItem.Clear();
                }
            }
        }

        private void BtBuscaSubGrupoItem_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaSubGrupoItem();
        }

        private void AbreTelaBuscaSubGrupoItem()
        {
            if (gruporecebido == null)
            {
                MessageBox.Show("Escolha o Grupo antes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var buscaSubGrupoItem = new fmBuscaSubGrupoItem(gruporecebido.GrupoItemID);
                buscaSubGrupoItem.ShowDialog();
                if (buscaSubGrupoItem.subgrupoitemSelecionado != null)
                {
                    subgrupoItem = buscaSubGrupoItem.subgrupoitemSelecionado;
                    PreencheCamposSubGrupoItem(subgrupoItem);
                }
            }
        }


        private void PreencheCamposSubGrupoItem(SubGrupoItem subgrupoItem)
        {
            if (subgrupoItem != null)
            {
                tbCodigoSubGrupoItem.Text = subgrupoItem.Codigo.ToString();
                tbNomeSubGrupoItem.Text = subgrupoItem.Nome;
            }
            else
            {
                MessageBox.Show("Sub-Grupo de itens não encontrado no banco de dados",
                "Sub-Grupo de itens não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Limpa(false);
            }
        }

        public void PreencheCampos(SubGrupoItem subgrupoItem)
        {
            if (subgrupoItem != null)
            {
                this.subgrupoItem = subgrupoItem;
                tbCodigoSubGrupoItem.Text = subgrupoItem.Codigo.ToString();
                tbNomeSubGrupoItem.Text = subgrupoItem.Nome;
            }
            else
            {
                Limpa();
            }
        }

        public void EscolhaOGrupo(bool ok)
        {
            if (ok)
            {
                if (subgrupoItem != null)
                    tbNomeSubGrupoItem.Text = subgrupoItem.Nome;
                else
                    tbNomeSubGrupoItem.Text = "";
            }
            else
            {
                tbNomeSubGrupoItem.Text = "Escolha o Grupo";
            }
        }

        public void Limpa(bool limpagrupo = true)
        {
            this.subgrupoItem = null;

            if(limpagrupo)
            this.gruporecebido = null;

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
