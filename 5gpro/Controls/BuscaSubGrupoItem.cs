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
        private static readonly ConexaoDAO conexao = new ConexaoDAO();
        private readonly SubGrupoItemDAO subgrupoItemDAO = new SubGrupoItemDAO(conexao);

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
                    subgrupoItem = subgrupoItemDAO.BuscarByID(int.Parse(tbCodigoSubGrupoItem.Text), gruporecebido.GrupoItemID);
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

        private void AbreTelaCadSubGrupoItem()
        {
            //var cadSubGrupoItem = new fmCadastroSubGrupoItem();
            //cadSubGrupoItem.ShowDialog();
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
                Limpa();
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

        public void EscolhaOGrupo()
        {
            tbNomeSubGrupoItem.Text = "Escolha o Grupo";
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

        private void BtAdd_Click(object sender, EventArgs e)
        {
            AbreTelaCadSubGrupoItem();
        }
    }
}
