using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace _5gpro.Forms
{
    public partial class fmCadastroOrcamento : Form
    {
        Pessoa pessoa;
        List<_Item> itens = new List<_Item>();
        PessoaBLL pessoaBLL = new PessoaBLL();
        _ItemBLL itemBLL = new _ItemBLL();
        _Item itemSelecionado;

        FuncoesAuxiliares f = new FuncoesAuxiliares();

        DataTable table = new DataTable();
        bool editando = false;



        public fmCadastroOrcamento()
        {
            InitializeComponent();

            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Quantidade", typeof(decimal));
            table.Columns.Add("Valor unitário", typeof(decimal));
            table.Columns.Add("Valor total", typeof(decimal));
            table.Columns.Add("% Desc.", typeof(decimal));
            table.Columns.Add("Desc. Item", typeof(decimal));
            dgvItens.DataSource = table;
        }


        private void cbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            dtpVencimento.Enabled = cbVencimento.Checked ? true : false;
        }




        private void tbCodCliente_Leave(object sender, EventArgs e)
        {
            if (tbCodCliente.Text.Length > 0)
            {
                pessoa = pessoaBLL.BuscarPessoaById(tbCodCliente.Text);
                PreencheCamposPessoa(pessoa);
            }
            else
            {
                tbNomeCliente.Text = "";
            }
        }

        private void tbCodItem_Leave(object sender, EventArgs e)
        {
            if (tbCodItem.Text.Length > 0)
            {
                DataRow dr = table.Select("Código=" + tbCodItem.Text).FirstOrDefault();
                _Item item;
                if (dr == null)
                {
                    item = itemBLL.BuscaItemById(tbCodItem.Text);
                    PreencheCamposItem(item);
                }
                else
                {
                    item = itens.Where(i => i.Codigo == tbCodItem.Text).First();
                    PreencheCamposItem(item);
                }
                
            }
            else
            {
                tbNomeCliente.Text = "";
            }
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            //tbCodigo.Text = tbCodigo.Text == "0" ? "" : tbCodigo.Text;
            //if (!editando)
            //{
            //    if (tbCodigo.Text.Length > 0)
            //    {
            //        Pessoa newpessoa = pessoaBLL.BuscarPessoaById(tbCodigo.Text);
            //        if (newpessoa != null)
            //        {
            //            pessoa = newpessoa;
            //            PreencheCampos(orcamento);
            //            Editando(false);
            //        }
            //        else
            //        {
            //            Editando(true);
            //            LimpaCampos(false);
            //        }
            //    }
            //    else if (tbCodigo.Text.Length == 0)
            //    {
            //        LimpaCampos(true);
            //        Editando(false);
            //    }
            //}
            //else
            //{
            //    if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            //    "Aviso de alteração",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        if (tbCodigo.Text.Length > 0)
            //        {
            //            Pessoa newpessoa = pessoaBLL.BuscarPessoaById(tbCodigo.Text);
            //            if (newpessoa != null)
            //            {
            //                pessoa = newpessoa;
            //                PreencheCampos(pessoa);
            //                Editando(false);
            //            }
            //            else
            //            {
            //                Editando(true);
            //                LimpaCampos(false);
            //            }
            //        }
            //        else if (tbCodigo.Text.Length == 0)
            //        {
            //            LimpaCampos(true);
            //            Editando(false);
            //        }
            //    }
            //}
        }

        private void tbQuantidade_Leave(object sender, EventArgs e)
        {
            tbQuantidade.Text = Convert.ToDecimal(tbQuantidade.Text).ToString("############0.00");
            tbValorTotItem.Text = (Convert.ToDecimal(tbQuantidade.Text) * Convert.ToDecimal(tbValorUnitItem.Text)).ToString("############0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbValorUnitItem_Leave(object sender, EventArgs e)
        {
            tbValorUnitItem.Text = Convert.ToDecimal(tbValorUnitItem.Text).ToString("############0.00");
            tbValorTotItem.Text = (Convert.ToDecimal(tbQuantidade.Text) * Convert.ToDecimal(tbValorUnitItem.Text)).ToString("############0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbValorTotItem_Leave(object sender, EventArgs e)
        {
            tbValorTotItem.Text = Convert.ToDecimal(tbValorTotItem.Text).ToString("############0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbDescontoItemPorc_Leave(object sender, EventArgs e)
        {
            tbDescontoItemPorc.Text = Convert.ToDecimal(tbDescontoItemPorc.Text).ToString("##0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void tbDescontoItem_Leave(object sender, EventArgs e)
        {
            tbDescontoItem.Text = Convert.ToDecimal(tbDescontoItem.Text).ToString("############0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }




        private void dtpCadastro_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void tbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                AbreTelaBuscaPessoa();
            }
        }



        //EVENTOS DE KEY DOWN
        private void tbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbCodCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void dtpCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void dtpVencimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbCodItem_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }

        }

        private void tbValorUnitItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbValorTotItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbDescontoTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbDescontoItemPorc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbDescontoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }


        //EVENTOS DE KEY PRESS
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



        private void btInserirItem_Click(object sender, EventArgs e)
        {
            _Item item = itemSelecionado == null ? itemBLL.BuscaItemById(tbCodItem.Text) : itemSelecionado;
            if (item != null)
            {
                item.Quantidade = Convert.ToDecimal(tbQuantidade.Text);
                item.ValorUnitario = Convert.ToDecimal(tbValorUnitItem.Text);
                item.ValorTotal = Convert.ToDecimal(tbValorTotItem.Text);
                item.DescontoPorc = Convert.ToDecimal(tbDescontoItemPorc.Text);
                item.Desconto = Convert.ToDecimal(tbDescontoItem.Text);
                DataRow dr = table.Select("Código=" + item.Codigo).FirstOrDefault();
                if (dr == null)
                {
                    itens.Add(item);
                    table.Rows.Add(item.Codigo, item.Descricao, item.Quantidade, item.ValorUnitario, item.ValorTotal, item.DescontoPorc, item.Desconto);
                    btNovoItem.PerformClick();
                }
                else
                {
                    itens.Where(i => i.Codigo == item.Codigo).First().Quantidade = item.Quantidade;
                    itens.Where(i => i.Codigo == item.Codigo).First().ValorUnitario = item.ValorUnitario;
                    itens.Where(i => i.Codigo == item.Codigo).First().ValorTotal = item.ValorTotal;
                    itens.Where(i => i.Codigo == item.Codigo).First().DescontoPorc = item.DescontoPorc;
                    itens.Where(i => i.Codigo == item.Codigo).First().Desconto = item.Desconto;
                    dr["Quantidade"] = item.Quantidade;
                    dr["Valor unitário"] = item.ValorUnitario;
                    dr["Valor total"] = item.ValorTotal;
                    dr["% Desc."] = item.DescontoPorc;
                    dr["Desc. Item"] = item.Desconto;
                    dgvItens.Update();
                    dgvItens.Refresh();
                }
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

        private void btNovoItem_Click(object sender, EventArgs e)
        {
            LimpaCampoItem();
            tbCodItem.Focus();
            itemSelecionado = null;
            btInserirItem.Text = "Inserir";
        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
            itemSelecionado = itens.Find(i => i.Codigo == Convert.ToString(selectedRow.Cells[0].Value));
            btInserirItem.Text = "Alterar";
            PreencheCamposItem(itemSelecionado);
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

        private void PreencheCamposPessoa(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                tbCodCliente.Text = pessoa.Codigo;
                tbNomeCliente.Text = pessoa.Nome;
                Editando(true);
            }
        }

        private void PreencheCamposItem(_Item item)
        {
            if (item != null)
            {
                tbCodItem.Text = item.Codigo;
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

    }
}
