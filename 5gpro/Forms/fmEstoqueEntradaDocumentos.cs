using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmEstoqueEntradaDocumentos : Form
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private _ItemBLL itemBLL = new _ItemBLL();

        private _Item itemSelecionado;
        private List<_Item> itens = new List<_Item>();
        private Pessoa pessoa;
        private FuncoesAuxiliares f = new FuncoesAuxiliares();

        bool editando, ignoracheckevent = false;

        public fmEstoqueEntradaDocumentos()
        {
            InitializeComponent();

            AlteraBotoes();
        }

        private void fmEstoqueEntradaDocumentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                //RecarregaDados(orcamento);
            }

            if (e.KeyCode == Keys.F1)
            {
                //NovoCadastro();
            }

            if (e.KeyCode == Keys.F2)
            {
                //SalvaCadastro();
            }

            EnterTab(this.ActiveControl, e);
        }


        private void btNovo_Click(object sender, EventArgs e)
        {
            //NovoCadastro();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                //AbreTelaBuscaOrcamento();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //SalvaCadastro();
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            //RecarregaDados(orcamento);
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            //ProximoCadastro();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            //CadastroAnterior();
        }

        private void btProcuraFornecedor_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaPessoa();
        }



        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
            itemSelecionado = itens.Find(i => i._ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
            btInserirItem.Text = "Alterar";
            PreencheCamposItem(itemSelecionado);
            btExcluirItem.Enabled = true;
        }

        private void btNovoItem_Click(object sender, EventArgs e)
        {
            LimpaCampoItem();
            tbCodItem.Focus();
            itemSelecionado = null;
            btInserirItem.Text = "Inserir";
        }

        private void btInserirItem_Click(object sender, EventArgs e)
        {
            _Item item = itemSelecionado == null ? itemBLL.BuscaItemById(int.Parse(tbCodItem.Text)) : itemSelecionado;
            InserirItem(item);
        }

        private void btProcuraItem_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaItem();
        }



        private void tbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbValorUnitItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbValorTotItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbDescontoItemPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbDescontoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbDescontoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbValorTotalDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }




        private void tbQuantidade_Leave(object sender, EventArgs e)
        {
            tbQuantidade.Text = tbQuantidade.Text.Length > 0 ? Convert.ToDecimal(tbQuantidade.Text).ToString("############0.00") : "0,00";
            tbValorTotItem.Text = (Convert.ToDecimal(tbQuantidade.Text) * Convert.ToDecimal(tbValorUnitItem.Text)).ToString("############0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbValorUnitItem_Leave(object sender, EventArgs e)
        {
            tbValorUnitItem.Text = tbValorUnitItem.Text.Length > 0 ? Convert.ToDecimal(tbValorUnitItem.Text).ToString("############0.00") : "0,00";
            tbValorTotItem.Text = (Convert.ToDecimal(tbQuantidade.Text) * Convert.ToDecimal(tbValorUnitItem.Text)).ToString("############0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbValorTotItem_Leave(object sender, EventArgs e)
        {
            tbValorTotItem.Text = tbValorTotItem.Text.Length > 0 ? Convert.ToDecimal(tbValorTotItem.Text).ToString("############0.00") : "0,00";
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbDescontoItemPorc_Leave(object sender, EventArgs e)
        {
            tbDescontoItemPorc.Text = tbDescontoItemPorc.Text.Length > 0 ? Convert.ToDecimal(tbDescontoItemPorc.Text).ToString("##0.00") : "0,00";
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbDescontoItem_Leave(object sender, EventArgs e)
        {
            tbDescontoItem.Text = tbDescontoItem.Text.Length > 0 ? Convert.ToDecimal(tbDescontoItem.Text).ToString("############0.00") : "0,00";
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbDescontoDocumento_Leave(object sender, EventArgs e)
        {
            tbDescontoDocumento.Text = tbDescontoDocumento.Text.Length > 0 ? Convert.ToDecimal(tbDescontoDocumento.Text).ToString("############0.00") : "0,00";
            CalculaTotalDocumento();
        }

        private void tbValorTotalDocumento_Leave(object sender, EventArgs e)
        {
            tbValorTotalDocumento.Text = tbValorTotalDocumento.Text.Length > 0 ? Convert.ToDecimal(tbValorTotalDocumento.Text).ToString("############0.00") : "0,00";
        }




        private void tbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                //AbreTelaBuscaDocumento();
            }
        }

        private void tbCodFornecedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                AbreTelaBuscaPessoa();
            }
        }

        private void tbCodItem_KeyUp(object sender, KeyEventArgs e)
        {
            AbreTelaBuscaItem();
        }



        private void tbCodFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void dtpEmissao_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void tbQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void tbValorUnitItem_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void tbValorTotItem_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void tbDescontoItemPorc_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void tbDescontoItem_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }




        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void AlteraBotoes()
        {
            if (editando)
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_black;
                btNovo.Enabled = false;
                btSalvar.Image = Properties.Resources.iosOk_48px_Green;
                btSalvar.Enabled = true;
                btBuscar.Image = Properties.Resources.iosSearch_48px_black;
                btBuscar.Enabled = false;
                btDeletar.Image = Properties.Resources.iosDelete_48px_black;
                btDeletar.Enabled = false;
            }
            else
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_blue;
                btNovo.Enabled = true;
                btSalvar.Image = Properties.Resources.iosOk_48px_black;
                btSalvar.Enabled = false;
                btBuscar.Image = Properties.Resources.iosSearch_48px_Blue;
                btBuscar.Enabled = true;
                btDeletar.Image = Properties.Resources.iosDelete_48px_Red;
                btDeletar.Enabled = false;
            }
        }

        private void Editando(bool edit)
        {
            editando = edit;
            AlteraBotoes();
        }

        private void LimpaCampos(bool limpaCod)
        {
            if (limpaCod) { tbCodigo.Clear(); }
            tbCodFornecedor.Clear();
            tbNomeFornecedor.Clear();
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            tbValorTotItem.Text = "0,00";
            tbDescontoTotalItens.Text = "0,00";
            tbDescontoDocumento.Text = "0,00";
            tbValorTotalDocumento.Text = "0,00";
            tbAjuda.Text = "";
            dgvItens.Rows.Clear();
            dgvItens.Refresh();
            LimpaCampoItem();
        }

        private void LimpaCampoItem()
        {
            tbCodItem.Clear();
            tbDescItem.Clear();
            tbQuantidade.Text = "0,00";
            tbValorUnitItem.Text = "0,00";
            tbValorTotItem.Text = "0,00";
            tbDescontoItemPorc.Text = "0,00";
            tbDescontoItem.Text = "0,00";
        }


        private void InserirItem(_Item item)
        {
            if (item != null)
            {
                item.Quantidade = Convert.ToDecimal(tbQuantidade.Text);
                item.ValorUnitario = Convert.ToDecimal(tbValorUnitItem.Text);
                item.ValorTotal = Convert.ToDecimal(tbValorTotItem.Text);
                item.DescontoPorc = Convert.ToDecimal(tbDescontoItemPorc.Text);
                item.Desconto = Convert.ToDecimal(tbDescontoItem.Text);
                DataGridViewRow dr = dgvItens.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value.ToString().Equals(item._ItemID)).FirstOrDefault();
                if (dr == null)
                {
                    itens.Add(item);
                    dgvItens.Rows.Add(item._ItemID, item.Descricao, item.Quantidade, item.ValorUnitario, item.ValorTotal, item.DescontoPorc, item.Desconto);
                    btNovoItem.PerformClick();
                }
                else
                {
                    itens.Where(i => i._ItemID == item._ItemID).First().Quantidade = item.Quantidade;
                    itens.Where(i => i._ItemID == item._ItemID).First().ValorUnitario = item.ValorUnitario;
                    itens.Where(i => i._ItemID == item._ItemID).First().ValorTotal = item.ValorTotal;
                    itens.Where(i => i._ItemID == item._ItemID).First().DescontoPorc = item.DescontoPorc;
                    itens.Where(i => i._ItemID == item._ItemID).First().Desconto = item.Desconto;
                    dr.Cells[dgvtbcQuantidade.Index].Value = item.Quantidade;
                    dr.Cells[dgvtbcValorUnitario.Index].Value = item.ValorUnitario;
                    dr.Cells[dgvtbcValorTotalItem.Index].Value = item.ValorTotal;
                    dr.Cells[dgvtbcDescontoPorc.Index].Value = item.DescontoPorc;
                    dr.Cells[dgvtbcDescontoItem.Index].Value = item.Desconto;
                    dgvItens.Update();
                    dgvItens.Refresh();
                }
                CalculaTotalDocumento();
                btExcluirItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodItem.Focus();
                tbCodItem.SelectAll();
            }
        }

        private void PreencheCamposItem(_Item item)
        {
            if (item != null)
            {
                tbCodItem.Text = item._ItemID.ToString();
                tbDescItem.Text = item.Descricao;
                tbQuantidade.Text = item.Quantidade.ToString("############0.00");
                tbValorUnitItem.Text = item.ValorUnitario.ToString("############0.00");
                tbValorTotItem.Text = item.ValorTotal.ToString("############0.00");
                tbDescontoItemPorc.Text = item.DescontoPorc.ToString("##0.00");
                tbDescontoItem.Text = item.Desconto.ToString("############0.00");
            }
            else
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodItem.Focus();
                tbCodItem.SelectAll();

            }
        }

        private void AbreTelaBuscaPessoa()
        {
            var buscaPessoa = new fmBuscaPessoa();
            buscaPessoa.ShowDialog();
            if (buscaPessoa.pessoaSelecionada != null)
            {
                pessoa = buscaPessoa.pessoaSelecionada;
                PreencheCamposPessoa(pessoa);
            }
        }

        private void AbreTelaBuscaItem()
        {
            var buscaItem = new fmBuscaItem();
            buscaItem.ShowDialog();
            if (buscaItem.itemSelecionado != null)
            {
                PreencheCamposItem(buscaItem.itemSelecionado);
            }
            else
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodItem.Focus();
                tbCodItem.SelectAll();
            }
        }

        private void PreencheCamposPessoa(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                tbCodFornecedor.Text = pessoa.PessoaID.ToString();
                tbNomeFornecedor.Text = pessoa.Nome;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado no banco de dados",
                "Cliente não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodFornecedor.Clear();
                tbCodFornecedor.Focus();
                tbCodFornecedor.SelectAll();
            }
        }



        private void CalculaTotalDocumento()
        {
            if (itens.Count > 0)
            {
                tbValorTotalItens.Text = itens.Sum(i => i.ValorTotal).ToString("############0.00");
                tbDescontoTotalItens.Text = itens.Sum(i => i.Desconto).ToString("############0.00");
                tbValorTotalDocumento.Text = (itens.Sum(i => i.ValorTotal) - itens.Sum(i => i.Desconto) - Convert.ToDecimal(tbDescontoDocumento.Text)).ToString("############0.00");
            }
        }
    }
}
