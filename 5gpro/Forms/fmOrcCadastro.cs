using _5gpro.Controls;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmOrcCadastro : Form
    {
        private readonly OrcamentoDAO orcamentoDAO = new OrcamentoDAO();

        private NotaFiscalPropria notafiscal = null;
        private readonly NotaFiscalAux nfa = new NotaFiscalAux();

        private Orcamento orcamento = new Orcamento();
        private List<OrcamentoItem> itens = new List<OrcamentoItem>();
        private OrcamentoItem itemSelecionado;
        private readonly FuncoesAuxiliares f = new FuncoesAuxiliares();

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        private bool editando, ignoracheckevent = false;



        public fmOrcCadastro()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("020100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

        private void FmCadastroOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Recarrega(orcamento);
            }

            if (e.KeyCode == Keys.F1)
            {
                Novo();
            }

            if (e.KeyCode == Keys.F2)
            {
                Salva();
            }

            EnterTab(this.ActiveControl, e);
        }
        private void FmOrcamentoCadastroOrcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!editando)
                return;

            if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            "Aviso de alteração",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void CbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            dtpVencimento.Enabled = cbVencimento.Checked ? true : false;
            Editando(true);
        }
        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    Orcamento neworcamento = orcamentoDAO.BuscaByID(int.Parse(tbCodigo.Text));
                    if (neworcamento != null)
                    {
                        orcamento = neworcamento;
                        notafiscal = orcamento.NotaFiscal;
                        PreencheCampos(orcamento);
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
                    LimpaCampos(false);
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
                        Orcamento neworcamento = orcamentoDAO.BuscaByID(int.Parse(tbCodigo.Text));
                        if (neworcamento != null)
                        {
                            orcamento = neworcamento;
                            notafiscal = orcamento.NotaFiscal;
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
        private void BuscaItem_Codigo_Leave(object sender, EventArgs e)
        {
            if (buscaItem.item != null)
            {
                DataGridViewRow dr = dgvItens.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value.ToString().Equals(buscaItem.item.ItemID.ToString())).FirstOrDefault();
                OrcamentoItem item = new OrcamentoItem();
                if (dr == null)
                {
                    item.Item = buscaItem.item;
                    btInserirItem.Text = "Inserir";
                    btExcluirItem.Enabled = false;
                }
                else
                {
                    item = itens.Where(i => i.Item.ItemID == buscaItem.item.ItemID).First();
                    btInserirItem.Text = "Alterar";
                    btExcluirItem.Enabled = true;
                }
                PreencheCamposItem(item);
                Editando(true);
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
        private void TbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.ValidaTeclaDigitadaDecimal(e);
        }
        private void TbValorUnitItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.ValidaTeclaDigitadaDecimal(e);
        }
        private void TbValorTotItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.ValidaTeclaDigitadaDecimal(e);
        }
        private void TbDescontoItemPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.ValidaTeclaDigitadaDecimal(e);
        }
        private void TbDescontoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.ValidaTeclaDigitadaDecimal(e);
        }
        private void TbDescontoOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.ValidaTeclaDigitadaDecimal(e);
        }
        private void TbValorTotalOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            f.ValidaTeclaDigitadaDecimal(e);
        }
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e)
        {
            Novo();
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
            Salva();
        }
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e)
        {
            Recarrega(orcamento);
        }
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e)
        {
            Anterior();
        }
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e)
        {
            Proximo();
        }
        private void BtNovoItem_Click(object sender, EventArgs e)
        {
            LimpaCamposItem(true);
            buscaItem.Focus();
            btInserirItem.Text = "Inserir";
        }
        private void BtInserirItem_Click(object sender, EventArgs e)
        {
            if (buscaItem.item != null)
            {
                OrcamentoItem oi = new OrcamentoItem();
                oi.Item = buscaItem.item;
                InserirItem(itemSelecionado ?? oi);
            }
            else
            {
                MessageBox.Show("Deve ser selecionado um item para ser inserido",
                "Item não selecionado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaItem.Focus();
            }
        }
        private void BtDeletarItem_Click(object sender, EventArgs e)
        {
            ExcluirItem();
        }
        private void DgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
                itemSelecionado = itens.Find(i => i.Item.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
                btInserirItem.Text = "Alterar";
                PreencheCamposItem(itemSelecionado);
                btExcluirItem.Enabled = true;
            }
        }
        private void BtNotaGerar_Click(object sender, EventArgs e)
        {
            if (orcamento.NotaFiscal == null)
            {
                notafiscal = nfa.GerarNotaFiscal(orcamento);
                PreencheCamposNotaFiscal(notafiscal);
            }
        }
        private void BuscaPessoa_Text_Changed(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void DtpCadastro_ValueChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void DtpVencimento_ValueChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void TbQuantidade_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void TbValorUnitItem_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void TbValorTotItem_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void TbDescontoItemPorc_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void TbDescontoItem_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void TbDescontoOrcamento_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void TbValorTotalOrcamento_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }
        private void DgvItens_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvItens.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
                itemSelecionado = itens.Find(i => i.Item.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
                btInserirItem.Text = "Alterar";
                PreencheCamposItem(itemSelecionado);
                btExcluirItem.Enabled = true;
            }
        }






        private void Novo()
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
                    tbCodigo.Text = orcamentoDAO.BuscaProxCodigoDisponivel().ToString();
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
                tbCodigo.Text = orcamentoDAO.BuscaProxCodigoDisponivel().ToString();
                orcamento = null;
                Editando(false);
                buscaPessoa.Focus();
                ignoracheckevent = false;
                Editando(true);
            }
        }
        private void Salva()
        {
            if (!editando)
            {
                return;
            }

            if (itens.Count <= 0)
            {
                MessageBox.Show("Um orçamento não pode ser salvo sem itens!",
               "Problema ao salvar",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }

            orcamento = new Orcamento
            {
                OrcamentoID = int.Parse(tbCodigo.Text),
                Pessoa = buscaPessoa.pessoa,
                DataCadastro = dtpCadastro.Value,
                DataValidade = cbVencimento.Checked ? dtpVencimento.Value : (DateTime?)null,

                ValorTotalItens = Convert.ToDecimal(tbValorTotalItens.Text),
                DescontoTotalItens = Convert.ToDecimal(tbDescontoTotalItens.Text),
                DescontoOrcamento = Convert.ToDecimal(tbDescontoOrcamento.Text),
                ValorTotalOrcamento = Convert.ToDecimal(tbValorTotalOrcamento.Text),

                OrcamentoItem = itens
            };

            int resultado = orcamentoDAO.SalvaOuAtualiza(orcamento);

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
        private void Recarrega(Orcamento orcamento)
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
                        orcamento = orcamentoDAO.BuscaByID(orcamento.OrcamentoID);
                        PreencheCampos(orcamento);
                        Editando(false);
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
                    orcamento = orcamentoDAO.BuscaByID(orcamento.OrcamentoID);
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
        private void Proximo()
        {
            //Busca o orcamento com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se pessoa existe. Se não existir busca o maior anterior ao digitado
            if (!editando && tbCodigo.Text.Length > 0)
            {
                Orcamento neworcamento = orcamentoDAO.Proximo(int.Parse(tbCodigo.Text));
                if (neworcamento != null)
                {
                    orcamento = neworcamento;
                    itens = orcamento.OrcamentoItem.ToList();
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
                    Orcamento neworcamento = orcamentoDAO.Proximo(int.Parse(tbCodigo.Text));
                    if (neworcamento != null)
                    {
                        orcamento = neworcamento;
                        itens = orcamento.OrcamentoItem.ToList();
                        PreencheCampos(orcamento);
                        Editando(false);
                    }
                    else
                    {
                        neworcamento = orcamentoDAO.Anterior(int.Parse(tbCodigo.Text));
                        if (neworcamento != null)
                        {
                            orcamento = neworcamento;
                            itens = orcamento.OrcamentoItem.ToList();
                            PreencheCampos(orcamento);
                            Editando(false);
                        }
                    }
                }
            }
        }
        private void Anterior()
        {
            //Busca a orcamento com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            //Caso não houver registro com ID menor, verifica se pessoa existe. Se não existir busca o proximo ao digitado
            if (!editando && tbCodigo.Text.Length > 0)
            {
                Orcamento neworcamento = orcamentoDAO.Anterior(int.Parse(tbCodigo.Text));
                if (neworcamento != null)
                {
                    orcamento = neworcamento;
                    itens = orcamento.OrcamentoItem.ToList();
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
                    Orcamento neworcamento = orcamentoDAO.Anterior(int.Parse(tbCodigo.Text));
                    if (neworcamento != null)
                    {
                        orcamento = neworcamento;
                        itens = orcamento.OrcamentoItem.ToList();
                        PreencheCampos(orcamento);
                        Editando(false);
                    }
                    else
                    {
                        neworcamento = orcamentoDAO.Proximo(int.Parse(tbCodigo.Text));
                        if (neworcamento != null)
                        {
                            orcamento = neworcamento;
                            itens = orcamento.OrcamentoItem.ToList();
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
            itens = orcamento.OrcamentoItem.ToList();
            PreencheGridItens(orcamento.OrcamentoItem.ToList());
            btInserirItem.Text = "Inserir";
            if (orcamento.NotaFiscal != null)
            {
                btNotaGerar.Enabled = false;
                tbNotaNumero.Text = orcamento.NotaFiscal.NotaFiscalPropriaID.ToString();
                tbNotaDataEmissao.Text = orcamento.NotaFiscal.DataEmissao.ToShortDateString();
            }
            else
            {
                btNotaGerar.Enabled = true;
                tbNotaNumero.Clear();
                tbNotaDataEmissao.Clear();
            }
            ignoracheckevent = false;
        }
        private void AbreTelaBuscaOrcamento()
        {
            var buscaOrcamento = new fmOrcBuscaOrcamento();
            buscaOrcamento.ShowDialog();
            if (buscaOrcamento.orcamentoSelecionado != null)
            {
                orcamento = buscaOrcamento.orcamentoSelecionado;
                PreencheCampos(orcamento);
            }
        }
        private void PreencheCamposItem(OrcamentoItem item)
        {
            if (item != null)
            {
                ignoracheckevent = true;
                buscaItem.PreencheCampos(item.Item);
                tbQuantidade.Text = item.Quantidade.ToString("############0.00");
                tbValorUnitItem.Text = item.ValorUnitario.ToString("############0.00");
                tbValorTotItem.Text = item.ValorTotal.ToString("############0.00");
                tbDescontoItemPorc.Text = item.DescontoPorc.ToString("##0.00");
                tbDescontoItem.Text = item.Desconto.ToString("############0.00");
                ignoracheckevent = false;
            }
            else
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaItem.Focus();
            }
        }
        private void PreencheCamposNotaFiscal(NotaFiscalPropria notafiscal)
        {
            tbNotaDataEmissao.Text = notafiscal.DataEmissao.ToShortDateString();
            tbNotaNumero.Text = notafiscal.NotaFiscalPropriaID.ToString();
            btNotaGerar.Enabled = false;
        }
        private void Editando(bool edit)
        {
            if (!ignoracheckevent && notafiscal == null)
            {
                btNotaGerar.Enabled = !edit;
                editando = edit;
                menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
            }
        }
        private void InserirItem(OrcamentoItem orcamentoitem)
        {
            OrcamentoItem item = itemSelecionado ?? orcamentoitem;
            if (item != null)
            {
                item.Quantidade = Convert.ToDecimal(tbQuantidade.Text);
                item.ValorUnitario = Convert.ToDecimal(tbValorUnitItem.Text);
                item.ValorTotal = Convert.ToDecimal(tbValorTotItem.Text);
                item.DescontoPorc = Convert.ToDecimal(tbDescontoItemPorc.Text);
                item.Desconto = Convert.ToDecimal(tbDescontoItem.Text);
                DataGridViewRow dr = dgvItens.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells[0].Value.ToString()) == item.Item.ItemID).FirstOrDefault();
                if (dr == null)
                {
                    itens.Add(item);
                    dgvItens.Rows.Add(item.Item.ItemID, item.Item.Descricao, item.Quantidade, item.ValorUnitario, item.ValorTotal, item.DescontoPorc, item.Desconto);
                    btNovoItem.PerformClick();
                }
                else
                {
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Quantidade = item.Quantidade;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorUnitario = item.ValorUnitario;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorTotal = item.ValorTotal;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().DescontoPorc = item.DescontoPorc;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Desconto = item.Desconto;
                    dr.Cells[dgvtbcQuantidade.Index].Value = item.Quantidade;
                    dr.Cells[dgvtbcValorUnitario.Index].Value = item.ValorUnitario;
                    dr.Cells[dgvtbcValorTotalItem.Index].Value = item.ValorTotal;
                    dr.Cells[dgvtbcDescontoPorc.Index].Value = item.DescontoPorc;
                    dr.Cells[dgvtbcDescontoItem.Index].Value = item.Desconto;
                    dgvItens.Update();
                    dgvItens.Refresh();
                }
                CalculaTotalOrcamento();
                btExcluirItem.Enabled = false;
                LimpaCamposItem(true);
            }
            else
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaItem.Focus();
            }
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
            dgvItens.Rows.Clear();
            dgvItens.Refresh();
            btNotaGerar.Enabled = false;
            tbNotaNumero.Clear();
            tbNotaDataEmissao.Clear();
            LimpaCamposItem(limpaCod);
        }
        private void LimpaCamposItem(bool focus)
        {
            buscaItem.Limpa();
            tbQuantidade.Text = "0,00";
            tbValorUnitItem.Text = "0,00";
            tbValorTotItem.Text = "0,00";
            tbDescontoItemPorc.Text = "0,00";
            tbDescontoItem.Text = "0,00";
            itemSelecionado = null;
            btExcluirItem.Enabled = false;
            btInserirItem.Text = "Inserir";
            if (focus) { buscaItem.Focus(); }
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
                itens.RemoveAll(i => i.Item.ItemID == itemSelecionado.Item.ItemID);
                dgvItens.Rows.Clear();
                dgvItens.Refresh();
                LimpaCamposItem(false);
                PreencheGridItens(itens);
                CalculaTotalOrcamento();
            }
        }
        private void PreencheGridItens(List<OrcamentoItem> itens)
        {
            dgvItens.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var i in itens)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvItens, i.Item.ItemID, i.Item.Descricao, i.Quantidade, i.ValorUnitario, i.ValorTotal, i.DescontoPorc, i.Desconto);
                rows.Add(linha);
            }
            dgvItens.Rows.AddRange(rows.ToArray());
            dgvItens.Refresh();
        }
    }
}
