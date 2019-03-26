using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaItem : Form
    {

        public List<_Item> _itens;
        public _Item itemSelecionado;
        private _ItemBLL itemBLL = new _ItemBLL();


        public fmBuscaItem()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

            _itens = itemBLL.BuscaItens(tbDescricao.Text, tbDenomCompra.Text, tipodoitem);

            foreach (_Item i in _itens)
            {
                table.Rows.Add(i.Codigo, i.Descricao, i.DescCompra, i.TipoItem, i.Referencia, i.Estoquenecessario, i.Unimedida, i.ValorEntrada, i.ValorSaida);
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
    }
}
