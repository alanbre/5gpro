using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmOrcamento : Form
    {
        Pessoa pessoa = null;
        List<_Item> itens = null;
        PessoaBLL pessoaBLL = new PessoaBLL();
        _ItemBLL itemBLL = new _ItemBLL();

        DataTable table = new DataTable();
        bool editando = false;



        public fmOrcamento()
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
                _Item item = itemBLL.BuscaItemById(tbCodItem.Text);
                PreencheCamposItem(item);
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
        }

        private void tbValorUnitItem_Leave(object sender, EventArgs e)
        {
            tbValorUnitItem.Text = Convert.ToDecimal(tbValorUnitItem.Text).ToString("############0.00");
            tbValorTotItem.Text = (Convert.ToDecimal(tbQuantidade.Text) * Convert.ToDecimal(tbValorUnitItem.Text)).ToString("############0.00");
        }

        private void tbValorTotItem_Leave(object sender, EventArgs e)
        {
            tbValorTotItem.Text = Convert.ToDecimal(tbValorTotItem.Text).ToString("############0.00");
        }

        private void tbDescontoItemPorc_Leave(object sender, EventArgs e)
        {
            tbDescontoItemPorc.Text = Convert.ToDecimal(tbDescontoItemPorc.Text).ToString("##0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) /100).ToString("############0.00");
        }

        private void tbDescontoItem_Leave(object sender, EventArgs e)
        {
            tbDescontoItem.Text = Convert.ToDecimal(tbDescontoItem.Text).ToString("############0.00");
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

        private void tbValorUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbValorTot_KeyDown(object sender, KeyEventArgs e)
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




        private void btInserirItem_Click(object sender, EventArgs e)
        {

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

    }
}
