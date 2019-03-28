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
        PessoaBLL pessoaBLL = new PessoaBLL();
        _ItemBLL itemBLL = new _ItemBLL();
        OrcamentoBLL orcamentoBLL = new OrcamentoBLL();

        Orcamento orcamento;
        List<_Item> itens = new List<_Item>();
        _Item itemSelecionado;
        Pessoa pessoa;
        Validacao validacao = new Validacao();
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
            AlteraBotoes();
        }

        private void fmCadastroOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RecarregaDados(pessoa);
            }

            if (e.KeyCode == Keys.F1)
            {
                NovoCadastro();
            }

            if (e.KeyCode == Keys.F2)
            {
                SalvaCadastro();
            }

            EnterTab(this.ActiveControl, e);
        }





        private void cbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            dtpVencimento.Enabled = cbVencimento.Checked ? true : false;
        }


        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            tbCodigo.Text = tbCodigo.Text == "0" ? "" : tbCodigo.Text;
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    Orcamento neworcamento = orcamentoBLL.BuscaOrcamentoById(tbCodigo.Text);
                    if (neworcamento != null)
                    {
                        orcamento = neworcamento;
                        PreencheCampos(orcamento);
                        Editando(false);
                    }
                    else
                    {
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodigo.Text.Length == 0)
                {
                    LimpaCampos(true);
                    Editando(false);
                }
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbCodigo.Text.Length > 0)
                    {
                        Orcamento neworcamento = orcamentoBLL.BuscaOrcamentoById(tbCodigo.Text);
                        if (neworcamento != null)
                        {
                            orcamento = neworcamento;
                            PreencheCampos(neworcamento);
                            Editando(false);
                        }
                        else
                        {
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodigo.Text.Length == 0)
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
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







        //PADRÕES CRIADAS
        private void NovoCadastro()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LimpaCampos(false);
                    tbCodigo.Text = orcamentoBLL.BuscaProxCodigoDisponivel();
                    orcamento = null;
                    tbCodCliente.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigo.Text = orcamentoBLL.BuscaProxCodigoDisponivel();
                orcamento = null;
                tbCodCliente.Focus();
                Editando(true);
            }
        }

        private void AbreTelaBuscaOrcamento()
        {
            //TODO: CRIAR TELA DE BUSCA DE ORÇAMENTO
            //var buscaPessoa = new fmBuscaPessoa();
            //buscaPessoa.ShowDialog();
            //if (buscaPessoa.pessoaSelecionada != null)
            //{
            //    pessoa = buscaPessoa.pessoaSelecionada;
            //    PreencheCampos(pessoa);
            //}
        }

        private void SalvaCadastro()
        {
            //TODO: IMPLEMENTAR SALVACADASTRO
            if (editando)
            {
                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(orcamento, controls);

                if (ok)
                {
                    orcamento = new Orcamento();
                    orcamento.Codigo = tbCodigo.Text;
                    orcamento.Pessoa = pessoa;
                    orcamento.DataCadastro = dtpCadastro.Value;
                    orcamento.DataVencimento = cbVencimento.Checked ? dtpVencimento.Value : dtpCadastro.Value;
                    orcamento.UsaVencimento = cbVencimento.Checked;
                    orcamento.Itens = itens;
                    List<string> atuacoes = new List<string>();
                    orcamento.ValorTotalItens = Convert.ToDecimal(tbValorTotalItens.Text);
                    orcamento.DescontoTotalItens = Convert.ToDecimal(tbDescontoTotalItens.Text);
                    orcamento.DescontoOrcamento = Convert.ToDecimal(tbDescontoOrcamento.Text);
                    orcamento.ValorTotalOrcamento = Convert.ToDecimal(tbValorTotalOrcamento.Text);

                    int resultado = orcamentoBLL.SalvarOuAtualizarOrcamento(orcamento);

                    // resultado 0 = nada foi inserido (houve algum erro)
                    // resultado 1 = foi inserido com sucesso
                    // resultado 2 = foi atualizado com sucesso
                    if (resultado == 0)
                    {
                        MessageBox.Show("Problema ao salvar o registro",
                        "Problema ao salvar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                    else if (resultado == 1)
                    {
                        tbAjuda.Text = "Dados salvos com sucesso";
                        Editando(false);
                    }
                    else if (resultado == 2)
                    {
                        tbAjuda.Text = "Dados atualizados com sucesso";
                        Editando(false);
                    }
                }
            }
        }

        private void RecarregaDados(Pessoa pessoa)
        {
            //TODO: IMPLEMENTAR O RECARREGADADOS
        }

        private void ProximoCadastro()
        {
            //TODO: IMPLEMENTAR O PROXIMOCADASTRO
            ////Busca a pessoa com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            ////Caso não houver registro com ID maior, verifica se pessoa existe. Se não existir busca o maior anterior ao digitado
            //if (!editando && tbCodigo.Text.Length > 0)
            //{
            //    //Os registros com newpessoa é só para garantir que não vai dar confusão com a variável "global"
            //    //la do inicio do arquivo.
            //    Pessoa newpessoa = pessoaBLL.BuscarProximaPessoa(tbCodigo.Text);
            //    if (newpessoa != null)
            //    {
            //        pessoa = newpessoa;
            //        PreencheCampos(pessoa);
            //    }
            //}
            //else if (editando && tbCodigo.Text.Length > 0)
            //{
            //    if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            //   "Aviso de alteração",
            //   MessageBoxButtons.YesNo,
            //   MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        Pessoa newpessoa = pessoaBLL.BuscarProximaPessoa(tbCodigo.Text);
            //        if (newpessoa != null)
            //        {
            //            pessoa = newpessoa;
            //            PreencheCampos(pessoa);
            //            Editando(false);
            //        }
            //        else
            //        {
            //            newpessoa = pessoaBLL.BuscarPessoaAnterior(tbCodigo.Text);
            //            if (newpessoa != null)
            //            {
            //                pessoa = newpessoa;
            //                PreencheCampos(pessoa);
            //                Editando(false);
            //            }
            //        }
            //    }
            //}
        }

        private void CadastroAnterior()
        {
            //TODO: IMPLEMENTAR O CADASTROANTERIOR
            ////Busca a pessoa com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            ////Caso não houver registro com ID menor, verifica se pessoa existe. Se não existir busca o proximo ao digitado
            //if (!editando && tbCodigo.Text.Length > 0)
            //{
            //    //Os registros com newpessoa é só para garantir que não vai dar confusão com a variável "global"
            //    //la do inicio do arquivo.
            //    Pessoa newpessoa = pessoaBLL.BuscarPessoaAnterior(tbCodigo.Text);
            //    if (newpessoa != null)
            //    {
            //        pessoa = newpessoa;
            //        PreencheCampos(pessoa);
            //    }
            //}
            //else if (editando && tbCodigo.Text.Length > 0)
            //{
            //    if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            //   "Aviso de alteração",
            //   MessageBoxButtons.YesNo,
            //   MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        Pessoa newpessoa = pessoaBLL.BuscarPessoaAnterior(tbCodigo.Text);
            //        if (newpessoa != null)
            //        {
            //            pessoa = newpessoa;
            //            PreencheCampos(pessoa);
            //            Editando(false);
            //        }
            //        else
            //        {
            //            newpessoa = pessoaBLL.BuscarProximaPessoa(tbCodigo.Text);
            //            if (newpessoa != null)
            //            {
            //                pessoa = newpessoa;
            //                PreencheCampos(pessoa);
            //                Editando(false);
            //            }
            //        }
            //    }
            //}
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
            else
            {
                MessageBox.Show("Cliente não encontrado no banco de dados",
                "Cliente não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodCliente.Focus();
                tbCodCliente.SelectAll();
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

        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
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

        private void PreencheCampos(Orcamento orcamento)
        {
            LimpaCampos(false);
            tbCodigo.Text = orcamento.Codigo;
            tbCodCliente.Text = orcamento.Pessoa != null ? orcamento.Pessoa.Codigo : "";
            tbNomeCliente.Text = orcamento.Pessoa != null ? orcamento.Pessoa.Nome : "";
            dtpCadastro.Value = orcamento.DataCadastro;
            dtpVencimento.Value = orcamento.DataVencimento != null ? orcamento.DataVencimento : DateTime.Now;
            cbVencimento.Checked = orcamento.DataVencimento != null ? true : false;
            tbValorTotItem.Text = orcamento.ValorTotalItens.ToString("############0.00");
            tbDescontoTotalItens.Text = orcamento.DescontoTotalItens.ToString("############0.00");
            tbDescontoOrcamento.Text = orcamento.DescontoOrcamento.ToString("############0.00");
            tbValorTotalOrcamento.Text = orcamento.ValorTotalOrcamento.ToString("############0.00");
        }

        private void LimpaCampos(bool limpaCod)
        {
            if (limpaCod) { tbCodigo.Clear(); }
            tbCodCliente.Clear();
            tbNomeCliente.Clear();
            dtpCadastro.Value = DateTime.Now;
            dtpVencimento.Value = DateTime.Now;
            dtpVencimento.Enabled = false;
            cbVencimento.Checked = false;
            tbValorTotItem.Text = "0,00";
            tbDescontoTotalItens.Text = "0,00";
            tbDescontoOrcamento.Text = "0,00";
            tbValorTotalOrcamento.Text = "0,00";
            table.Clear();
            dgvItens.Refresh();
        }

    }
}
