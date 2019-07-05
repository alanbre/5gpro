using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaItem : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        public List<Item> itens;
        public Item itemSelecionado;
        private readonly ItemDAO itemDAO = new ItemDAO();


        public fmBuscaItem()
        {
            InitializeComponent();
        }

        //LOAD
        private void fmBuscaItem_Load(object sender, EventArgs e) => BuscaItens();

        //LEAVE
        private void BuscaSubGrupoItem_Leave(object sender, EventArgs e) => BuscaItens();
        private void BuscaGrupoItem_Leave(object sender, EventArgs e)
        {
            buscaSubGrupoItem.EnviarGrupo(buscaGrupoItem.grupoItem);
            if (buscaGrupoItem.grupoItem == null)
            {
                buscaSubGrupoItem.Limpa();
                buscaSubGrupoItem.EscolhaOGrupo(false);
            }
            else
            {
                buscaSubGrupoItem.EscolhaOGrupo(true);
            }
        }

        //KEYUP, KEYDOWN
        private void FmBuscaItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void cbProduto_Click(object sender, EventArgs e) => BuscaItens();
        private void cbServico_Click(object sender, EventArgs e) => BuscaItens();
        private void btBuscarItens_Click(object sender, EventArgs e) => BuscaItens();
        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
            itemSelecionado = itens.Find(p => p.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }

        //TEXTCHANGED
        private void BuscaGrupoItem_Text_Changed(object sender, EventArgs e) => buscaSubGrupoItem.Limpa();
        private void tbDescricao_TextChanged(object sender, EventArgs e) => BuscaItens();
        private void tbDenomCompra_TextChanged(object sender, EventArgs e) => BuscaItens();

        //FUNÇÕES
        private void BuscaItens()
        {

            dgvItens.Columns.Clear();

            DataTable table = new DataTable();   
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Denominação da Compra", typeof(string));
            table.Columns.Add("Tipo", typeof(string));
            table.Columns.Add("Referência", typeof(string));
            table.Columns.Add("Estoque Necessário", typeof(string));
            table.Columns.Add("Quantidade em Estoque", typeof(string));
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

            itens = itemDAO.Busca(tbDescricao.Text, tbDenomCompra.Text, tipodoitem, buscaSubGrupoItem.subgrupoItem);

            foreach (Item i in itens)
            {
                table.Rows.Add(i.ItemID, i.Descricao, i.DescCompra, i.TipoItem, i.Referencia, i.Estoquenecessario, i.Quantidade, i.Unimedida.Sigla, i.ValorEntrada, i.ValorUnitario);
            }

            ListCollectionView coleção = new ListCollectionView(table.DefaultView);
            coleção.GroupDescriptions.Add(new PropertyGroupDescription("Unidade de Medida"));
            dgvItens.DataSource = table;

            funaux.TratarTamanhoColunas(dgvItens);
        }
       
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        
    }
}
