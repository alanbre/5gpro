using _5gpro.Controls;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.Reports;
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
        private Validacao validacao = new Validacao();

<<<<<<< HEAD
        private Orcamento orcamento = new Orcamento();
        private List<OrcamentoItem> listaorcamentoitens = new List<OrcamentoItem>();
=======
        private Orcamento orcamento = null;
        private List<OrcamentoItem> itens = new List<OrcamentoItem>();
>>>>>>> 7f8bc00e964034664f2fa62a74617d474d3f96fc
        private OrcamentoItem itemSelecionado;
        private DataTable rel = new DataTable();
        private readonly FuncoesAuxiliares f = new FuncoesAuxiliares();

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        private bool editando, ignoracheckevent = false;
        private int codigo = 0;



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

        private void FmOrcCadastro_Load(object sender, EventArgs e)
        {
            rel.Columns.Add("codigo", typeof(int));
            rel.Columns.Add("descricao", typeof(string));
            rel.Columns.Add("quantidade", typeof(decimal));
            rel.Columns.Add("valor_unit", typeof(decimal));
            rel.Columns.Add("valor_total", typeof(decimal));
            rel.Columns.Add("desconto_porc", typeof(decimal));
            rel.Columns.Add("desconto_total", typeof(decimal));
        }
        private void FmCadastroOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Recarrega();
                return;
            }

            if (e.KeyCode == Keys.F1)
            {
                Novo();
                return;
            }

            if (e.KeyCode == Keys.F2)
            {
                Salva();
                return;
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
        private void TbCodigo_Leave(object sender, EventArgs e) => CarregaDados();
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
                    item = listaorcamentoitens.Where(i => i.Item.ItemID == buscaItem.item.ItemID).First();
                    btInserirItem.Text = "Alterar";
                    btExcluirItem.Enabled = true;
                }
                PreencheCamposItem(item);
                Editando(true);
            }
        }
        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                Busca();
            }
        }
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void BtNovoItem_Click(object sender, EventArgs e) => NovoItem();
        private void BtInserirItem_Click(object sender, EventArgs e) => InserirItem();
        private void BtDeletarItem_Click(object sender, EventArgs e) => ExcluirItem();
        private void DgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
                itemSelecionado = listaorcamentoitens.Find(i => i.Item.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
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
        private void BuscaPessoa_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void DtpCadastro_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void DtpVencimento_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void DbQuantidade_Leave(object sender, EventArgs e) => CalculaTotaisItem();
        private void DbValorUnitItem_Leave(object sender, EventArgs e) => CalculaTotaisItem();
        private void DbValorTotItem_Leave(object sender, EventArgs e) => CalculaTotaisItem();
        private void DbDescontoItemPorc_Leave(object sender, EventArgs e) => CalculaTotaisItem();
        private void DbDescontoItem_Leave(object sender, EventArgs e) => CalculaTotaisItem();
        private void DbDescontoOrcamento_Leave(object sender, EventArgs e) => CalculaTotalOrcamento();
        private void DgvItens_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvItens.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
                itemSelecionado = listaorcamentoitens.Find(i => i.Item.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
                btInserirItem.Text = "Alterar";
                PreencheCamposItem(itemSelecionado);
                btExcluirItem.Enabled = true;
            }
        }
        private void BtImprimir_Click(object sender, EventArgs e) => Imprimir();

        private void Novo()
        {
            if (editando)
            {
                return;
            }

            if (Nivel > 1 || CodGrupoUsuario == "999")
            {
                ignoracheckevent = true;
                LimpaCampos(false);
                codigo = orcamentoDAO.BuscaProxCodigoDisponivel();
                tbCodigo.Text = codigo.ToString();
                orcamento = null;
                buscaPessoa.Focus();
                ignoracheckevent = false;
                Editando(true);
            }
        }
        private void Busca()
        {
            if (CodGrupoUsuario != "999" && Nivel <= 0)
            {
                return;
            }

            if (editando)
            {
                return;
            }

            var buscaOrcamento = new fmOrcBuscaOrcamento();
            buscaOrcamento.ShowDialog();
            if (buscaOrcamento.orcamentoSelecionado != null)
            {
                codigo = orcamento.OrcamentoID;
                PreencheCampos(buscaOrcamento.orcamentoSelecionado);
                orcamento = buscaOrcamento.orcamentoSelecionado;
            }
        }
        private void Salva()
        {
            if (!editando)
            {
                return;
            }
            bool ok = false;

            if (tbCodigo.Text.Length <= 0)
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                "Aviso",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbCodigo.Text = orcamentoDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
                return;
            }

            if (listaorcamentoitens.Count <= 0)
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

                ValorTotalItens = dbValorTotalItens.Valor,
                DescontoTotalItens = dbDescontoTotalItens.Valor,
                DescontoOrcamento = dbDescontoOrcamento.Valor,
                ValorTotalOrcamento = dbValorTotalOrcamento.Valor,

                OrcamentoItem = listaorcamentoitens
            };

            var controls = (ControlCollection)this.Controls;

            ok = validacao.ValidarEntidade(orcamento, controls);

            if (ok)
            {
                validacao.despintarCampos(controls);

                int resultado = orcamentoDAO.SalvaOuAtualiza(orcamento);

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
                    btNotaGerar.Enabled = true;
                }
                else if (resultado == 2)
                {
                    tbAjuda.Text = "Dados atualizados com sucesso";
                    Editando(false);
                }
            }

            PreencheGridItens(itens);

        }
        private void Recarrega()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }


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
            Editando(false);
        }
        private void Anterior()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            //validacao.despintarCampos(controls);

            var neworcamento = orcamentoDAO.Anterior(int.Parse(tbCodigo.Text));
            if (neworcamento != null)
            {
                codigo = neworcamento.OrcamentoID;
                PreencheCampos(neworcamento);
                orcamento = neworcamento;
                listaorcamentoitens = orcamento.OrcamentoItem.ToList();
                Editando(false);
            }
        }
        private void Proximo()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            //validacao.despintarCampos(controls);

            var neworcamento = orcamentoDAO.Proximo(int.Parse(tbCodigo.Text));
            if (neworcamento != null)
            {
                codigo = neworcamento.OrcamentoID;
                PreencheCampos(neworcamento);
                orcamento = neworcamento;
                listaorcamentoitens = orcamento.OrcamentoItem.ToList();
                Editando(false);
            }
        }
        private void Imprimir()
        {
            if (orcamento == null)
            {
                MessageBox.Show("Selecione um orçamento para impressão!",
               "Problema ao imprimir",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }

            var impOrcamento = new impOrcamento(rel, orcamento);
            impOrcamento.ShowDialog(this);
        }
        private void CarregaDados()
        {
            var controls = (ControlCollection)this.Controls;
            int c = 0;
            if (!int.TryParse(tbCodigo.Text, out c))
            {
                tbCodigo.Clear();
            }
            else
            {
                if (c != codigo)
                {
                    if (editando)
                    {
                        if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?", "Aviso de alteração",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    codigo = c;
                }
            }

            if (orcamento?.OrcamentoID == codigo)
            {
                return;
            }

            if (tbCodigo.Text.Length == 0)
            {
                LimpaCampos(true);
                Editando(false);
                return;
            }


            var neworcamento = orcamentoDAO.BuscaByID(int.Parse(tbCodigo.Text));
            if (neworcamento != null)
            {
                PreencheCampos(neworcamento);
                orcamento = neworcamento;
                Editando(false);
            }
            else
            {
                LimpaCampos(false);
                Editando(true);
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
            dbValorTotalItens.Valor = orcamento.ValorTotalItens;
            dbDescontoTotalItens.Valor = orcamento.DescontoTotalItens;
            dbDescontoOrcamento.Valor = orcamento.DescontoOrcamento;
            dbValorTotalOrcamento.Valor = orcamento.ValorTotalOrcamento;
            listaorcamentoitens = orcamento.OrcamentoItem.ToList();
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
            notafiscal = orcamento.NotaFiscal;
            ignoracheckevent = false;
        }
        private void PreencheCamposItem(OrcamentoItem item)
        {
            if (item != null)
            {
                ignoracheckevent = true;
                buscaItem.PreencheCampos(item.Item);
                dbQuantidade.Valor = item.Quantidade;
                dbValorUnitItem.Valor = item.ValorUnitario;
                dbValorTotItem.Valor = item.ValorTotal;
                dbDescontoItemPorc.Valor = item.DescontoPorc;
                dbDescontoItem.Valor = item.Desconto;
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
                editando = edit;
                menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
            }
        }
        private void InserirItem(OrcamentoItem orcamentoitem)
        {
            var item = itemSelecionado ?? orcamentoitem;
            if (item == null)
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaItem.Focus();
                return;
            }
            item.Quantidade = dbQuantidade.Valor;
            item.ValorUnitario = dbValorUnitItem.Valor;
            item.ValorTotal = dbValorTotItem.Valor;
            item.DescontoPorc = dbDescontoItemPorc.Valor;
            item.Desconto = dbDescontoItem.Valor;
            DataGridViewRow dr = dgvItens.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells[0].Value.ToString()) == item.Item.ItemID).FirstOrDefault();
            if (dr == null)
            {
                listaorcamentoitens.Add(item);
                dgvItens.Rows.Add(item.Item.ItemID, item.Item.Descricao, item.Quantidade, item.ValorUnitario, item.ValorTotal, item.DescontoPorc, item.Desconto);
                btNovoItem.PerformClick();
            }
            else
            {
                listaorcamentoitens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Quantidade = item.Quantidade;
                listaorcamentoitens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorUnitario = item.ValorUnitario;
                listaorcamentoitens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorTotal = item.ValorTotal;
                listaorcamentoitens.Where(i => i.Item.ItemID == item.Item.ItemID).First().DescontoPorc = item.DescontoPorc;
                listaorcamentoitens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Desconto = item.Desconto;
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
            SelecionaUltimoGrid();
            Editando(true);
        }
        private void SelecionaUltimoGrid()
        {
            dgvItens.ClearSelection();
            var nRowIndex = dgvItens.Rows.Count - 1;
            dgvItens.Rows[nRowIndex].Selected = true;
            dgvItens.FirstDisplayedScrollingRowIndex = nRowIndex;
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
            if (limpaCod) {
                tbCodigo.Clear();
                orcamento = null;
                notafiscal = null;
            }
            buscaPessoa.Limpa();
            dtpCadastro.Value = DateTime.Now;
            dtpVencimento.Value = DateTime.Now;
            dtpVencimento.Enabled = false;
            cbVencimento.Checked = false;
            dbValorTotItem.Valor = 0.00m;
            dbDescontoTotalItens.Valor = 0.00m;
            dbDescontoOrcamento.Valor = 0.00m;
            dbValorTotalOrcamento.Valor = 0.00m;
            tbAjuda.Text = "";
            dgvItens.Rows.Clear();
            dgvItens.Refresh();
            btNotaGerar.Enabled = false;
            tbNotaNumero.Clear();
            tbNotaDataEmissao.Clear();
            LimpaCamposItem(limpaCod);
<<<<<<< HEAD
            orcamento = null;
            listaorcamentoitens.Clear();
=======
            
>>>>>>> 7f8bc00e964034664f2fa62a74617d474d3f96fc
            codigo = 0;
        }
        private void LimpaCamposItem(bool focus)
        {
            buscaItem.Limpa();
            dbQuantidade.Valor = 0.00m;
            dbValorUnitItem.Valor = 0.00m;
            dbValorTotItem.Valor = 0.00m;
            dbDescontoItemPorc.Valor = 0.00m;
            dbDescontoItem.Valor = 0.00m;
            itemSelecionado = null;
            btExcluirItem.Enabled = false;
            btInserirItem.Text = "Inserir";
            if (focus) { buscaItem.Focus(); }
        }
        private void CalculaTotalOrcamento()
        {
            if (listaorcamentoitens.Count > 0)
            {
                dbValorTotalItens.Valor = listaorcamentoitens.Sum(i => i.ValorTotal);
                dbDescontoTotalItens.Valor = listaorcamentoitens.Sum(i => i.Desconto);
                dbValorTotalOrcamento.Valor = dbValorTotalItens.Valor - dbDescontoTotalItens.Valor - dbDescontoOrcamento.Valor;
            }
        }
        private void CalculaTotaisItem()
        {
            dbValorTotItem.Valor = dbQuantidade.Valor * dbValorUnitItem.Valor;
            dbDescontoItem.Valor = dbValorTotItem.Valor * dbDescontoItemPorc.Valor / 100;
            CalculaTotalOrcamento();
        }
        private void ExcluirItem()
        {
            if (itemSelecionado != null)
            {
                listaorcamentoitens.RemoveAll(i => i.Item.ItemID == itemSelecionado.Item.ItemID);
                dgvItens.Rows.Clear();
                dgvItens.Refresh();
                LimpaCamposItem(false);
                PreencheGridItens(listaorcamentoitens);
                CalculaTotalOrcamento();
            }
        }
        private void InserirItem()
        {
            if (buscaItem.item == null)
            {
                MessageBox.Show("Deve ser selecionado um item para ser inserido",
                "Item não selecionado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaItem.Focus();
                return;
            }


            var oi = new OrcamentoItem();
            oi.Item = buscaItem.item;
            InserirItem(itemSelecionado ?? oi); //verifica se itemSeleciona é nulo, se não for manda ele mesmo
                                                //e se for nulo manda o oi

        }
        private void NovoItem()
        {
            LimpaCamposItem(true);
            buscaItem.Focus();
            btInserirItem.Text = "Inserir";
        }

<<<<<<< HEAD
        private void BtConjunto_Click(object sender, EventArgs e)
        {
            var fmselecao = new fmSelecaoOrcamento();
            fmselecao.Show(this);
        }
=======
>>>>>>> 7f8bc00e964034664f2fa62a74617d474d3f96fc

        private void PreencheGridItens(List<OrcamentoItem> itens)
        {
            dgvItens.Rows.Clear();
            rel.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var i in itens)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvItens, i.Item.ItemID, i.Item.Descricao, i.Quantidade, i.ValorUnitario, i.ValorTotal, i.DescontoPorc, i.Desconto);
                rel.Rows.Add(i.Item.ItemID, i.Item.Descricao, i.Quantidade, i.ValorUnitario, i.ValorTotal, i.DescontoPorc, i.Desconto);
                rows.Add(linha);
            }
            dgvItens.Rows.AddRange(rows.ToArray());
            dgvItens.Refresh();
        }
    }
}
