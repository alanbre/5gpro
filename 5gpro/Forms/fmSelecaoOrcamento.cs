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
    public partial class fmSelecaoOrcamento : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        public List<Item> listadeitens = new List<Item>();
        public List<OrcamentoItem> listaitensorcamento = new List<OrcamentoItem>();
        public Item itemSelecionado;
        private readonly ItemDAO itemDAO = new ItemDAO();
        decimal quantidade = 0, valorunitario;

        DataTable table = new DataTable();
        DataTable tableselecionados = new DataTable();

        public fmSelecaoOrcamento()
        {
            InitializeComponent();
        }

        private void FmSelecaoOrcamento_Load(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void BuscaItens()
        {
            table.Rows.Clear();


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

            listadeitens = itemDAO.Busca(tbDescricao.Text, tbDenomCompra.Text, tbReferencia.Text, tipodoitem, buscaSubGrupoItem.subgrupoItem);

            foreach (Item i in listadeitens)
            {
                dgvItensorcamento.Rows.Add(i.ItemID, i.Descricao, i.Quantidade, i.Unimedida.Sigla, i.ValorUnitario);
            }

        }

        private void TbDenomCompra_TextChanged(object sender, EventArgs e) => BuscaItens();
        private void TbDescricao_TextChanged(object sender, EventArgs e) => BuscaItens();
        private void TbReferencia_TextChanged(object sender, EventArgs e) => BuscaItens();
        private void CbProduto_Click(object sender, EventArgs e) => BuscaItens();
        private void CbServico_Click(object sender, EventArgs e) => BuscaItens();

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

        private void BuscaSubGrupoItem_Leave(object sender, EventArgs e) => BuscaItens();

        private void DgvItensorcamento_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //}
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DgvItensorcamento_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItensorcamento.Rows.Count > 0)
            {
                decimal c;

                if (decimal.TryParse(dgvItensorcamento.SelectedRows[0].Cells[5].Value.ToString(), out c))
                {
                    quantidade = c;
                    valorunitario = decimal.Parse(dgvItensorcamento.SelectedRows[0].Cells[4].Value.ToString());
                    dgvItensorcamento.SelectedRows[0].Cells[6].Value = quantidade * valorunitario;
                }
                else
                {
                    quantidade = 0;
                    dgvItensorcamento.SelectedRows[0].Cells[5].Value = 0.00;
                    dgvItensorcamento.SelectedRows[0].Cells[6].Value = 0.00;

                }
            }
        }
    }
}
