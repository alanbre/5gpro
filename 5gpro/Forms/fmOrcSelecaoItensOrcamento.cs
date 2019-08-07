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
    public partial class fmOrcSelecaoItensOrcamento : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        fmOrcCadastro fmorcamento;

        public OrcamentoItem itemOrcamento = new OrcamentoItem();
        private OrcamentoItem itemRemover = new OrcamentoItem();
        public List<OrcamentoItem> listaitensorcamento = new List<OrcamentoItem>();

        public Item itemSelecionado;
        public List<Item> listadeitens = new List<Item>();

        private readonly ItemDAO itemDAO = new ItemDAO();
        decimal quantidade = 0, valorunitario, totalitem, total;

        public fmOrcSelecaoItensOrcamento(fmOrcCadastro fmorc)
        {
            InitializeComponent();
            fmorcamento = fmorc;
        }

        private void FmSelecaoOrcamento_Load(object sender, EventArgs e)
        {
        }

        private void BuscaItens()
        {
            dgvItensorcamento.Rows.Clear();

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

            listadeitens = itemDAO.Busca(tbDescricao.Text, tbDenomCompra.Text, tbReferencia.Text, tipodoitem, buscaGrupoItem.grupoItem, buscaSubGrupoItem.subgrupoItem, "");
            foreach (Item i in listadeitens)
            {
                itemOrcamento = listaitensorcamento.Find(p => p.Item.ItemID == i.ItemID);

                if(itemOrcamento != null)
                {
                    dgvItensorcamento.Rows.Add(i.ItemID,
                           i.Descricao,
                           i.Referencia,
                           i.Quantidade,
                           i.Unimedida.Sigla,
                           i.ValorUnitario,
                           itemOrcamento.Quantidade,
                           itemOrcamento.ValorTotal);
                }
                else
                {
                    dgvItensorcamento.Rows.Add(i.ItemID,
                           i.Descricao,
                           i.Referencia,
                           i.Quantidade,
                           i.Unimedida.Sigla,
                           i.ValorUnitario);
                }
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

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            fmorcamento.InserirItensSelecionados(listaitensorcamento);
            this.Dispose();
        }

        private void BtBuscarItens_Click(object sender, EventArgs e)
        {
            BuscaItens();
        }

        private void DgvItensorcamento_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItensorcamento.Rows.Count > 0)
            {
                decimal c;

                if (decimal.TryParse(dgvItensorcamento.SelectedRows[0].Cells[6].Value.ToString(), out c))
                {
                    itemOrcamento = new OrcamentoItem();
                    itemOrcamento.Item = itemDAO.BuscaByID((int)dgvItensorcamento.CurrentRow.Cells[0].Value);
                    
                    quantidade = c;
                    valorunitario = decimal.Parse(dgvItensorcamento.SelectedRows[0].Cells[5].Value.ToString());
                    totalitem = quantidade * valorunitario;
                    dgvItensorcamento.SelectedRows[0].Cells[7].Value = totalitem;

                    itemOrcamento.Quantidade = quantidade;
                    itemOrcamento.ValorTotal = totalitem;

                    itemRemover = listaitensorcamento.Find(i => i.Item.ItemID == itemOrcamento.Item.ItemID);

                    listaitensorcamento.Remove(itemRemover);
                    if(itemRemover != null)
                    total -= itemRemover.ValorTotal;

                    if (c > 0)
                    {
                        listaitensorcamento.Add(itemOrcamento);
                        if (itemOrcamento != null)
                        total += itemOrcamento.ValorTotal;
                    }

                }
                else
                {
                    quantidade = 0;
                    dgvItensorcamento.SelectedRows[0].Cells[6].Value = 0.00;
                    dgvItensorcamento.SelectedRows[0].Cells[7].Value = 0.00;
                }
                dbTotal.Valor = total;
            }
        }
    }
}
