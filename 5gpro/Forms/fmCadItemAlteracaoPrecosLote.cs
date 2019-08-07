using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadItemAlteracaoPrecosLote : Form
    {
        private readonly ItemDAO itemDAO = new ItemDAO();
        private List<Item> itens = new List<Item>();


        public fmCadItemAlteracaoPrecosLote()
        {
            InitializeComponent();
        }

        private void FmCadItemAlteracaoPrecosLote_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void BtBuscarItens_Click(object sender, EventArgs e) => Buscar();
        private void RbPorcentagem_CheckedChanged(object sender, EventArgs e) => TrocarTipo();
        private void BtSimular_Click(object sender, EventArgs e) => Simular();
        private void BtConfirmar_Click(object sender, EventArgs e) => Confirmar();
        private void RbValorFixo_CheckedChanged(object sender, EventArgs e)
        {
            gbAplicar.Enabled = !rbValorFixo.Checked;
        }

        private void Buscar()
        {
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
            PreencheGrid();
            tcAltercaoPrecosItens.SelectTab(1);
        }
        private void PreencheGrid()
        {
            dgvItens.Rows.Clear();
            foreach (var i in itens)
            {
                dgvItens.Rows.Add(
                    i.ItemID,
                    i.CodigoInterno,
                    i.Descricao,
                    i.DescCompra,
                    i.ValorUnitario);
            }
            dgvItens.Refresh();
        }
        private void TrocarTipo()
        {
            lbPorcentagemValor.Text = rbPorcentagem.Checked ? "Porcentagem" : "Valor";
            dbPorcentagemValor.Valor = 0;
        }
        private void Simular()
        {
            foreach (var i in itens)
            {
                if (rbValorFixo.Checked)
                {
                    i.ValorUnitario = dbPorcentagemValor.Valor;
                }
                else
                {
                    i.ValorUnitario = rbAcrescimo.Checked ? i.ValorUnitario * (100 + dbPorcentagemValor.Valor) / 100 : i.ValorUnitario * (100 - dbPorcentagemValor.Valor) / 100;
                }
            }
            PreencheGrid();
        }
        private void Confirmar()
        {
            if (MessageBox.Show("Tem certeza que deseja alterar o preço dos itens?",
                "Aviso",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            var resultado = itemDAO.AlteracaoValores(itens);
            if (resultado == 0)
            {
                MessageBox.Show("Problema ao salvar o(s) registro(s)",
                "Problema ao salvar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show($"Foram alterados {resultado} itens!",
                "Registros alterados com sucesso",
                MessageBoxButtons.OK);
            }
            Buscar();
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