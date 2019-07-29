using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaItemSeleciona : Form
    {
        private FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        private List<Item> itens = new List<Item>();
        public Item itemSelecionado = null;

        private readonly ItemDAO itemDAO = new ItemDAO();
        private fmCadastroItem parent = null;
        private DataTable table = new DataTable();

        public fmBuscaItemSeleciona(fmCadastroItem parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public fmBuscaItemSeleciona()
        {
            InitializeComponent();
        }
        private void FmBuscaItemSeleciona_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Código", typeof(int));
            table.Columns.Add("Código Int.", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Denominação da Compra", typeof(string));
            table.Columns.Add("Grupo", typeof(string));
            table.Columns.Add("SubGrupo", typeof(string));
            table.Columns.Add("Tipo", typeof(string));
            table.Columns.Add("Referência", typeof(string));
            table.Columns.Add("Estoque Necessário", typeof(decimal));
            table.Columns.Add("Quantidade em Estoque", typeof(decimal));
            table.Columns.Add("Unidade de Medida", typeof(string));
            table.Columns.Add("Valor de Entrada", typeof(decimal));
            table.Columns.Add("Valor de Saída", typeof(decimal));
        }
        private void TbCodigoInterno_TextChanged(object sender, EventArgs e)
        {
            itens = itemDAO.Busca(tbCodigoInterno.Text);
            PreencheGrid();
        }
        private void TbCodigoInterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void DgvItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
                itemSelecionado = itens.Find(p => p.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
                if (parent != null)
                {
                    if (parent.editando) return;
                    parent.item = itemSelecionado;
                    parent.PreencheCampos(itemSelecionado);
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void DgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
            itemSelecionado = itens.Find(p => p.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
            if (parent != null)
            {
                if (parent.editando) return;
                parent.item = itemSelecionado;
                parent.PreencheCampos(itemSelecionado);
            }
            else
            {
                this.Close();
            }
        }

        private void PreencheGrid()
        {
            table.Rows.Clear();

            foreach (var i in itens)
            {
                string grupo = $"{i.SubGrupoItem.GrupoItem.GrupoItemID.ToString()} - {i.SubGrupoItem.GrupoItem.Nome}";
                string subgrupo = $"{i.SubGrupoItem.Codigo.ToString()} - {i.SubGrupoItem.Nome}";
                table.Rows.Add(
                    i.ItemID,
                    i.CodigoInterno,
                    i.Descricao,
                    i.DescCompra,
                    grupo,
                    subgrupo,
                    i.TipoItem,
                    i.Referencia,
                    i.Estoquenecessario,
                    i.Quantidade,
                    i.Unimedida.Sigla,
                    i.ValorEntrada,
                    i.ValorUnitario);
            }
            dgvItens.DataSource = table;
            dgvItens = funaux.TratarTamanhoColunas(dgvItens);
        }

    }
}
