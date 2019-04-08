using _5gpro.Bll;
using _5gpro.Controls;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmOrcamentoCadastroOrcamento : Form
    {
        private readonly ItemBLL itemBLL = new ItemBLL();
        private readonly OrcamentoBLL orcamentoBLL = new OrcamentoBLL();

        private Orcamento orcamento;
        private List<Item> itens = new List<Item>();
        private Item itemSelecionado;
        private readonly Validacao validacao = new Validacao();
        private readonly FuncoesAuxiliares f = new FuncoesAuxiliares();

        private readonly DataTable table = new DataTable();
        private bool editando, ignoracheckevent = false;



        public fmOrcamentoCadastroOrcamento()
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

        private void FmCadastroOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RecarregaDados(orcamento);
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

        private void FmOrcamentoCadastroOrcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }




        private void CbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            dtpVencimento.Enabled = cbVencimento.Checked ? true : false;
            if (!ignoracheckevent) { Editando(true); }
        }


        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            tbCodigo.Text = tbCodigo.Text == "0" ? "" : tbCodigo.Text;
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    Orcamento neworcamento = orcamentoBLL.BuscaOrcamentoById(int.Parse(tbCodigo.Text));
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
                    ignoracheckevent = true;
                    LimpaCampos(true);
                    ignoracheckevent = false;
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
                        Orcamento neworcamento = orcamentoBLL.BuscaOrcamentoById(int.Parse(tbCodigo.Text));
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
                        ignoracheckevent = true;
                        LimpaCampos(true);
                        ignoracheckevent = false;
                    }
                }
            }
        }

        private void TbCodItem_Leave(object sender, EventArgs e)
        {
            if (tbCodItem.Text.Length > 0)
            {
                DataRow dr = table.Select("Código=" + tbCodItem.Text).FirstOrDefault();
                Item item;
                if (dr == null)
                {
                    item = itemBLL.BuscaItemById(int.Parse(tbCodItem.Text));
                    PreencheCamposItem(item);
                }
                else
                {
                    item = itens.Where(i => i.ItemID == int.Parse(tbCodItem.Text)).First();
                    PreencheCamposItem(item);
                }

            }
            else
            {
                tbCodItem.Text = "";
            }
        }

        private void TbQuantidade_Leave(object sender, EventArgs e)
        {
            tbQuantidade.Text = tbQuantidade.Text.Length > 0 ? Convert.ToDecimal(tbQuantidade.Text).ToString("############0.00") : "0,00";
            tbValorTotItem.Text = (Convert.ToDecimal(tbQuantidade.Text) * Convert.ToDecimal(tbValorUnitItem.Text)).ToString("############0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void TbValorUnitItem_Leave(object sender, EventArgs e)
        {
            tbValorUnitItem.Text = tbValorUnitItem.Text.Length > 0 ? Convert.ToDecimal(tbValorUnitItem.Text).ToString("############0.00") : "0,00";
            tbValorTotItem.Text = (Convert.ToDecimal(tbQuantidade.Text) * Convert.ToDecimal(tbValorUnitItem.Text)).ToString("############0.00");
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void TbValorTotItem_Leave(object sender, EventArgs e)
        {
            tbValorTotItem.Text = tbValorTotItem.Text.Length > 0 ? Convert.ToDecimal(tbValorTotItem.Text).ToString("############0.00") : "0,00";
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void TbDescontoItemPorc_Leave(object sender, EventArgs e)
        {
            tbDescontoItemPorc.Text = tbDescontoItemPorc.Text.Length > 0 ? Convert.ToDecimal(tbDescontoItemPorc.Text).ToString("##0.00") : "0,00";
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void TbDescontoItem_Leave(object sender, EventArgs e)
        {
            tbDescontoItem.Text = tbDescontoItem.Text.Length > 0 ? Convert.ToDecimal(tbDescontoItem.Text).ToString("############0.00") : "0,00";
            tbDescontoItem.Text = (Convert.ToDecimal(tbValorTotItem.Text) * Convert.ToDecimal(tbDescontoItemPorc.Text) / 100).ToString("############0.00");
        }

        private void TbDescontoOrcamento_Leave(object sender, EventArgs e)
        {
            tbDescontoOrcamento.Text = tbDescontoOrcamento.Text.Length > 0 ? Convert.ToDecimal(tbDescontoOrcamento.Text).ToString("############0.00") : "0,00";
            CalculaTotalOrcamento();
        }

        private void TbValorTotalOrcamento_Leave(object sender, EventArgs e)
        {
            tbValorTotalOrcamento.Text = tbValorTotalOrcamento.Text.Length > 0 ? Convert.ToDecimal(tbValorTotalOrcamento.Text).ToString("############0.00") : "0,00";
        }



        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                AbreTelaBuscaOrcamento();
            }
        }

        private void TbCodItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                AbreTelaBuscaItem();
            }
        }



        //EVENTOS DE KEY PRESS
        private void TbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void TbValorUnitItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void TbValorTotItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void TbDescontoItemPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void TbDescontoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void TbDescontoOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void TbValorTotalOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }




        private void MenuVertical_Novo_Clicked(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e)
        {
            if (!editando)
            {
                AbreTelaBuscaOrcamento();
            }
        }

        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e)
        {
            RecarregaDados(orcamento);
        }
        
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e)
        {
            CadastroAnterior();
        }


        private void BtProcuraItem_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaItem();
        }

        private void DgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
            itemSelecionado = itens.Find(i => i.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
            btInserirItem.Text = "Alterar";
            PreencheCamposItem(itemSelecionado);
            btExcluirItem.Enabled = true;
        }

        private void BtNovoItem_Click(object sender, EventArgs e)
        {
            LimpaCampoItem();
            tbCodItem.Focus();
            itemSelecionado = null;
            btInserirItem.Text = "Inserir";
        }

        private void BtInserirItem_Click(object sender, EventArgs e)
        {
            Item item = itemSelecionado ?? itemBLL.BuscaItemById(int.Parse(tbCodItem.Text));
            if (item != null)
            {
                item.Quantidade = Convert.ToDecimal(tbQuantidade.Text);
                item.ValorUnitario = Convert.ToDecimal(tbValorUnitItem.Text);
                item.ValorTotal = Convert.ToDecimal(tbValorTotItem.Text);
                item.DescontoPorc = Convert.ToDecimal(tbDescontoItemPorc.Text);
                item.Desconto = Convert.ToDecimal(tbDescontoItem.Text);
                DataRow dr = table.Select("Código=" + item.ItemID).FirstOrDefault();
                if (dr == null)
                {
                    itens.Add(item);
                    table.Rows.Add(item.ItemID, item.Descricao, item.Quantidade, item.ValorUnitario, item.ValorTotal, item.DescontoPorc, item.Desconto);
                    btNovoItem.PerformClick();
                }
                else
                {
                    itens.Where(i => i.ItemID == item.ItemID).First().Quantidade = item.Quantidade;
                    itens.Where(i => i.ItemID == item.ItemID).First().ValorUnitario = item.ValorUnitario;
                    itens.Where(i => i.ItemID == item.ItemID).First().ValorTotal = item.ValorTotal;
                    itens.Where(i => i.ItemID == item.ItemID).First().DescontoPorc = item.DescontoPorc;
                    itens.Where(i => i.ItemID == item.ItemID).First().Desconto = item.Desconto;
                    dr["Quantidade"] = item.Quantidade;
                    dr["Valor unitário"] = item.ValorUnitario;
                    dr["Valor total"] = item.ValorTotal;
                    dr["% Desc."] = item.DescontoPorc;
                    dr["Desc. Item"] = item.Desconto;
                    dgvItens.Update();
                    dgvItens.Refresh();
                }
                CalculaTotalOrcamento();
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

        private void BtDeletarItem_Click(object sender, EventArgs e)
        {
            ExcluirItem();
        }

        private void BuscaPessoa_Text_Changed(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void DtpCadastro_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void DtpVencimento_ValueChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void TbCodItem_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void TbQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void TbValorUnitItem_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void TbValorTotItem_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void TbDescontoItemPorc_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void TbDescontoItem_TextChanged(object sender, EventArgs e)
        {
            if (!ignoracheckevent) { Editando(true); }
        }

        private void TbDescontoOrcamento_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }

        private void TbValorTotalOrcamento_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
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
                    ignoracheckevent = true;
                    LimpaCampos(false);
                    tbCodigo.Text = orcamentoBLL.BuscaProxCodigoDisponivel();
                    orcamento = null;
                    buscaPessoa.Focus();
                    ignoracheckevent = false;
                    Editando(true);
                }
            }
            else
            {
                ignoracheckevent = true;
                LimpaCampos(false);
                tbCodigo.Text = orcamentoBLL.BuscaProxCodigoDisponivel();
                orcamento = null;
                Editando(false);
                buscaPessoa.Focus();
                ignoracheckevent = false;
                Editando(true);
            }
        }

        private void SalvaCadastro()
        {
            if (editando)
            {
                orcamento = new Orcamento();
                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(orcamento, controls);

                if (ok)
                {
                    orcamento.OrcamentoID = int.Parse(tbCodigo.Text);
                    orcamento.Pessoa = buscaPessoa.pessoa;
                    orcamento.DataCadastro = dtpCadastro.Value;
                    orcamento.DataValidade = cbVencimento.Checked ? dtpVencimento.Value : (DateTime?)null;
                    orcamento.Itens = itens;
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

        private void RecarregaDados(Orcamento orcamento)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (orcamento != null)
                    {
                        orcamento = orcamentoBLL.BuscaOrcamentoById(orcamento.OrcamentoID);
                        PreencheCampos(orcamento);
                    }
                    else
                    {
                        ignoracheckevent = true;
                        LimpaCampos(true);
                        ignoracheckevent = false;
                    }
                }
            }
            else
            {
                if (orcamento != null)
                {
                    orcamento = orcamentoBLL.BuscaOrcamentoById(orcamento.OrcamentoID);
                    PreencheCampos(orcamento);
                }
                else
                {
                    ignoracheckevent = true;
                    LimpaCampos(true);
                    ignoracheckevent = false;
                }
            }

        }

        private void ProximoCadastro()
        {
            //Busca o orcamento com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se pessoa existe. Se não existir busca o maior anterior ao digitado
            if (!editando && tbCodigo.Text.Length > 0)
            {
                Orcamento neworcamento = orcamentoBLL.BuscaProximoOrcamento(tbCodigo.Text);
                if (neworcamento != null)
                {
                    orcamento = neworcamento;
                    itens = orcamento.Itens;
                    PreencheCampos(orcamento);
                }
            }
            else if (editando && tbCodigo.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Orcamento neworcamento = orcamentoBLL.BuscaProximoOrcamento(tbCodigo.Text);
                    if (neworcamento != null)
                    {
                        orcamento = neworcamento;
                        itens = orcamento.Itens;
                        PreencheCampos(orcamento);
                        Editando(false);
                    }
                    else
                    {
                        neworcamento = orcamentoBLL.BuscaOrcamentoAnterior(tbCodigo.Text);
                        if (neworcamento != null)
                        {
                            orcamento = neworcamento;
                            itens = orcamento.Itens;
                            PreencheCampos(orcamento);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void CadastroAnterior()
        {
            //Busca a orcamento com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            //Caso não houver registro com ID menor, verifica se pessoa existe. Se não existir busca o proximo ao digitado
            if (!editando && tbCodigo.Text.Length > 0)
            {
                Orcamento neworcamento = orcamentoBLL.BuscaOrcamentoAnterior(tbCodigo.Text);
                if (neworcamento != null)
                {
                    orcamento = neworcamento;
                    itens = orcamento.Itens;
                    PreencheCampos(orcamento);
                }
            }
            else if (editando && tbCodigo.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Orcamento neworcamento = orcamentoBLL.BuscaOrcamentoAnterior(tbCodigo.Text);
                    if (neworcamento != null)
                    {
                        orcamento = neworcamento;
                        itens = orcamento.Itens;
                        PreencheCampos(orcamento);
                        Editando(false);
                    }
                    else
                    {
                        neworcamento = orcamentoBLL.BuscaProximoOrcamento(tbCodigo.Text);
                        if (neworcamento != null)
                        {
                            orcamento = neworcamento;
                            itens = orcamento.Itens;
                            PreencheCampos(neworcamento);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void PreencheCampos(Orcamento orcamento)
        {
            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigo.Text = orcamento.OrcamentoID.ToString();
            buscaPessoa.PreencheCampos(orcamento.Pessoa);
            dtpCadastro.Value = orcamento.DataCadastro;
            dtpVencimento.Value = orcamento.DataValidade.HasValue ? (DateTime)orcamento.DataValidade : DateTime.Now;
            cbVencimento.Checked = orcamento.DataValidade.HasValue ? true : false;
            tbValorTotalItens.Text = orcamento.ValorTotalItens.ToString("############0.00");
            tbDescontoTotalItens.Text = orcamento.DescontoTotalItens.ToString("############0.00");
            tbDescontoOrcamento.Text = orcamento.DescontoOrcamento.ToString("############0.00");
            tbValorTotalOrcamento.Text = orcamento.ValorTotalOrcamento.ToString("############0.00");
            itens = orcamento.Itens;
            PreencheGridItens(orcamento.Itens);
            btInserirItem.Text = "Inserir";
            ignoracheckevent = false;
        }

        private void AbreTelaBuscaOrcamento()
        {
            var buscaOrcamento = new fmBuscaOrcamento();
            buscaOrcamento.ShowDialog();
            if (buscaOrcamento.orcamentoSelecionado != null)
            {
                orcamento = buscaOrcamento.orcamentoSelecionado;
                PreencheCampos(orcamento);
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

        private void PreencheCamposItem(Item item)
        {
            if (item != null)
            {
                tbCodItem.Text = item.ItemID.ToString();
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

        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit);
        }

        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void LimpaCampos(bool limpaCod)
        {
            if (limpaCod) { tbCodigo.Clear(); }
            buscaPessoa.Limpa();
            dtpCadastro.Value = DateTime.Now;
            dtpVencimento.Value = DateTime.Now;
            dtpVencimento.Enabled = false;
            cbVencimento.Checked = false;
            tbValorTotItem.Text = "0,00";
            tbDescontoTotalItens.Text = "0,00";
            tbDescontoOrcamento.Text = "0,00";
            tbValorTotalOrcamento.Text = "0,00";
            tbAjuda.Text = "";
            table.Clear();
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

        private void CalculaTotalOrcamento()
        {
            if (itens.Count > 0)
            {
                tbValorTotalItens.Text = itens.Sum(i => i.ValorTotal).ToString("############0.00");
                tbDescontoTotalItens.Text = itens.Sum(i => i.Desconto).ToString("############0.00");
                tbValorTotalOrcamento.Text = (itens.Sum(i => i.ValorTotal) - itens.Sum(i => i.Desconto) - Convert.ToDecimal(tbDescontoOrcamento.Text)).ToString("############0.00");
            }
        }

        private void ExcluirItem()
        {
            if (itemSelecionado != null)
            {
                itens.RemoveAll(i => i.ItemID == itemSelecionado.ItemID);
                table.Clear();
                dgvItens.Refresh();
                LimpaCampoItem();
                PreencheGridItens(itens);
                CalculaTotalOrcamento();
                btExcluirItem.Enabled = false;
            }
        }


        private void PreencheGridItens(List<Item> itens)
        {
            foreach (var i in itens)
            {
                table.Rows.Add(i.ItemID, i.Descricao, i.Quantidade, i.ValorUnitario, i.ValorTotal, i.DescontoPorc, i.Desconto);
            }
            dgvItens.Refresh();
        }
    }
}
