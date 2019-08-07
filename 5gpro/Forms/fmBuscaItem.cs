using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaItem : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        public List<Item> itens;
        public Item itemSelecionado;
        private readonly ItemDAO itemDAO = new ItemDAO();

        private DataTable table = new DataTable();
        private DataTable rel = new DataTable();
        private decimal total = 0;

        public fmBuscaItem()
        {
            InitializeComponent();
        }

        private void FmBuscaItem_Load(object sender, EventArgs e)
        {
            rel.Columns.Add("codigo", typeof(string));
            rel.Columns.Add("referencia", typeof(string));
            rel.Columns.Add("desc_item", typeof(string));
            rel.Columns.Add("desc_comp", typeof(string));
            rel.Columns.Add("quantidade", typeof(decimal));
            rel.Columns.Add("valor", typeof(decimal));
            rel.Columns.Add("total", typeof(decimal));


            table.Columns.Add("Código", typeof(int));
            table.Columns.Add("Código Int.", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Denominação da Compra", typeof(string));
            table.Columns.Add("Grupo", typeof(string));
            table.Columns.Add("SubGrupo", typeof(string));
            table.Columns.Add("Tipo", typeof(string));
            table.Columns.Add("Referência", typeof(string));
            table.Columns.Add("Estoque Necessário", typeof(string));
            table.Columns.Add("Quantidade em Estoque", typeof(string));
            table.Columns.Add("Unidade de Medida", typeof(string));
            table.Columns.Add("Valor de Entrada", typeof(string));
            table.Columns.Add("Valor de Saída", typeof(string));
            BuscaItens();
        }
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
        private void FmBuscaItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void CbProduto_Click(object sender, EventArgs e) => BuscaItens();
        private void CbServico_Click(object sender, EventArgs e) => BuscaItens();
        private void BtBuscarItens_Click(object sender, EventArgs e) => BuscaItens();
        private void DgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
            itemSelecionado = itens.Find(p => p.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }
        private void BuscaGrupoItem_Text_Changed(object sender, EventArgs e) => buscaSubGrupoItem.Limpa();
        private void TbDescricao_TextChanged(object sender, EventArgs e) => BuscaItens();
        private void TbDenomCompra_TextChanged(object sender, EventArgs e) => BuscaItens();
        private void TbReferencia_TextChanged(object sender, EventArgs e) => BuscaItens();
        private void BtImprimir_Click(object sender, EventArgs e)
        {
            var formRelatorioItens = new fmRltItens(rel, total);
            formRelatorioItens.Show(this);
        }



        private void BuscaItens()
        {
            rel.Rows.Clear();
            table.Rows.Clear();
            total = 0;

            string tipodoitem = "";
            if (cbProduto.Checked)
            {
                tipodoitem = "P";
            }
            if (cbServico.Checked)
            {
                tipodoitem = "S";
            }
            if (cbProduto.Checked && cbServico.Checked)
            {
                tipodoitem = "";
            }

            itens = itemDAO.Busca(tbDescricao.Text, tbDenomCompra.Text, tbReferencia.Text, tipodoitem, buscaGrupoItem.grupoItem, buscaSubGrupoItem.subgrupoItem, tbCodigoInterno.Text);

            foreach (Item i in itens)
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
                rel.Rows.Add(i.CodigoInterno, i.Referencia, i.Descricao, i.DescCompra, i.Quantidade, i.ValorUnitario, i.Quantidade * i.ValorUnitario);
                total += i.Quantidade * i.ValorUnitario;
            }

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
