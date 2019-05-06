using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaItem : Form
    {
        static ConexaoDAO connection = new ConexaoDAO();
        public List<Item> itens;
        public Item itemSelecionado;
        private readonly ItemDAO itemDAO = new ItemDAO(connection);


        public fmBuscaItem()
        {
            InitializeComponent();
        }

        private void BuscaItens()
        {


            DataTable table = new DataTable();
           
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Denominação da Compra", typeof(string));
            table.Columns.Add("Tipo", typeof(string));
            table.Columns.Add("Referência", typeof(string));
            table.Columns.Add("Estoque Necessário", typeof(string));
            table.Columns.Add("Unidade de Medida", typeof(string));
            table.Columns.Add("Valor de Entrada", typeof(string));
            table.Columns.Add("Valor de Saída", typeof(string));

            string tipodoitem = "";
            if (cbProduto.Checked)
            {
                tipodoitem = "P";
            }
            if (cbServico.Checked)
            {
                tipodoitem = "S";
            }
            if(cbProduto.Checked && cbServico.Checked)
            {
                tipodoitem = "";
            }

            itens = itemDAO.BuscaItem(tbDescricao.Text, tbDenomCompra.Text, tipodoitem);

            foreach (Item i in itens)
            {
                table.Rows.Add(i.ItemID, i.Descricao, i.DescCompra, i.TipoItem, i.Referencia, i.Estoquenecessario, i.Unimedida.Sigla, i.ValorEntrada, i.ValorSaida);
            }
            dgvItens.DataSource = table;
        }

        private void tbDescricao_TextChanged(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void tbDenomCompra_TextChanged(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void gbTipo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbProduto_Click(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void rbServico_Click(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbProduto_Click(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void cbServico_Click(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void fmBuscaItem_Load(object sender, EventArgs e)
        {

        }

        private void cbServico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btBuscarItens_Click(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
            itemSelecionado = itens.Find(p => p.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }
    }
}
