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
    public partial class fmSaiEmissaoNota : Form
    {
        private NotaFiscalPropria notaFiscalPropriaNova;
        private readonly NotaFiscalPropriaDAO notaFiscalPropriaDAO = new NotaFiscalPropriaDAO();
        private NotaFiscalPropria notaFiscalPropria = new NotaFiscalPropria();
        private NotaFiscalPropriaItem itemSelecionado;
        private List<NotaFiscalPropriaItem> itens = new List<NotaFiscalPropriaItem>();
        private readonly PessoaDAO pessoaDAO = new PessoaDAO();

        private ContaReceber contaReceber;
        private ContaReceberDAO contaReceberDAO = new ContaReceberDAO();

        private List<ParcelaContaReceber> parcelas = new List<ParcelaContaReceber>();

        Validacao validacao = new Validacao();

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;
        private decimal totaldocumento = 0, jurosparcela, descontoparcela;

        int codigo = 0;

        bool editando, ignoracheckevent = false;

        public fmSaiEmissaoNota()
        {
            InitializeComponent();
            SetarNivel();
        }


        private void FmEstoqueEntradaDocumentos_KeyDown(object sender, KeyEventArgs e)
        {
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

            if (e.KeyCode == Keys.F5)
            {
                Recarrega();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void FmSaiEmissaoNota_FormClosing(object sender, FormClosingEventArgs e)
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
        private void BtNovoItem_Click(object sender, EventArgs e)
        {
            LimpaCamposItem(true);
            buscaItem1.Focus();
            itemSelecionado = null;
            btInserirItem.Text = "Inserir";
        }
        private void BtInserirItem_Click(object sender, EventArgs e) => InserirItem();
        private void BtExcluirItem_Click(object sender, EventArgs e) => ExcluirItem();
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }
        private void DgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
                itemSelecionado = itens.Find(i => i.Item.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
                btInserirItem.Text = "Alterar";
                PreencheCamposItem(itemSelecionado);
                btExcluirItem.Enabled = true;
            }
        }
        private void TbCodigo_Leave(object sender, EventArgs e) => CarregaDados();
        private void buscaItem1_Codigo_Leave(object sender, EventArgs e) => BuscaItem();
        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                //AbreTelaBuscaDocumento();
            }
        }
        private void BuscaPessoa_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void TbDescricao_TextChanged(object sender, EventArgs e) => Editando(true);
        private void DtpEmissao_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void DtpEntrada_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void DgvItens_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvItens.Rows[selectedRowIndex];
                itemSelecionado = itens.Find(i => i.Item.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
                btInserirItem.Text = "Alterar";
                PreencheCamposItem(itemSelecionado);
                btExcluirItem.Enabled = true;
            }
        }
        private void DbDescontoDocumento_Valor_Changed(object sender, EventArgs e) => Editando(true);
        private void DbValorTotalDocumento_Valor_Changed(object sender, EventArgs e) => Editando(true);
        private void DbQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
            CalculaDescontoItem();
        }
        private void DbValorUnitItem_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
            CalculaDescontoItem();
        }
        private void DbDescontoItemPorc_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
            CalculaDescontoItem();
        }
        private void DbValorTotItem_Leave(object sender, EventArgs e) => CalculaDescontoItem();
        private void DbDescontoItem_Leave(object sender, EventArgs e)
        {
            CalculaPorcDescontoItem();
            CalculaTotalItem();
        }
        private void Novo()
        {
            if (editando)
                return;

            ignoracheckevent = true;
            Limpa(false);
            tbCodigo.Text = notaFiscalPropriaDAO.BuscaProxCodigoDisponivel().ToString();
            notaFiscalPropria = null;
            buscaPessoa.Focus();
            ignoracheckevent = false;
            Editando(true);
        }
        private void Busca()
        {
            if (editando)
                return;
            var buscaNotaFiscalPropria = new fmSaiBuscaNotaFiscalPropria();
            buscaNotaFiscalPropria.ShowDialog();
            if (buscaNotaFiscalPropria.notaFiscalPropriaSelecionada != null)
            {
                notaFiscalPropria = buscaNotaFiscalPropria.notaFiscalPropriaSelecionada;
                notaFiscalPropria.Pessoa = pessoaDAO.BuscaByID(notaFiscalPropria.Pessoa.PessoaID);
                PreencheCampos(notaFiscalPropria);
            }
        }
        private void Salva()
        {
            var controls = (ControlCollection)this.Controls;
            if (!editando)
            {
                return;
            }
            var ok = false;

            if (tbCodigo.Text.Length <= 0)
            {
                if (MessageBox.Show("Número da nota em branco, deseja gerar um numero automaticamente?",
                "Aviso",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbCodigo.Text = notaFiscalPropriaDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
            }
            else
            {
                if (itens.Count <= 0)
                {
                    MessageBox.Show("Uma nota não pode ser salva sem itens!",
                   "Problema ao salvar",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                    return;
                }

                if(buscaOperacao.operacao == null)
                {
                    MessageBox.Show("Escolha uma operação!",
                    "Problema ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                notaFiscalPropriaNova = new NotaFiscalPropria
                {
                    NotaFiscalPropriaID = int.Parse(tbCodigo.Text),
                    Descricao = tbDescricao.Text,
                    Pessoa = buscaPessoa.pessoa,
                    DataEmissao = dtpEmissao.Value,
                    DataEntradaSaida = dtpSaida.Value,
                    ValorTotalItens = dbValorTotalItens.Valor,
                    DescontoTotalItens = dbDescontoTotalItens.Valor,
                    DescontoDocumento = dbDescontoDocumento.Valor,
                    ValorTotalDocumento = dbValorTotalDocumento.Valor,

                    NotaFiscalPropriaItem = itens
                };

                ok = validacao.ValidarEntidade(notaFiscalPropriaNova, controls);
            }


            if (ok)
            {
                int resultado = notaFiscalPropriaDAO.SalvaOuAtualiza(notaFiscalPropriaNova);

                // resultado 0 = nada foi inserido (houve algum erro)
                // resultado 1 = foi inserido com sucesso
                // resultado 2 = foi atualizado com sucesso
                if (resultado == 0)
                {
                    MessageBox.Show("Problema ao salvar o registro",
                    "Problema ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                else if (resultado == 1)
                {
                    tbAjuda.Text = "Dados salvos com sucesso";
                    notaFiscalPropriaDAO.MovimentaEstoque(notaFiscalPropriaNova);
                    GerarContaReceber();
                    Editando(false);
                }
                else if (resultado == 2)
                {
                    notaFiscalPropriaDAO.LimpaRegistrosEstoque(notaFiscalPropriaNova);
                    notaFiscalPropriaDAO.MovimentaEstoque(notaFiscalPropriaNova);
                    GerarContaReceber();

                    tbAjuda.Text = "Dados atualizados com sucesso";
                    Editando(false);
                }
                notaFiscalPropria = notaFiscalPropriaNova;
            }
        }

        private void GerarContaReceber()
        {
            GerarParcelas();

            contaReceber = new ContaReceber
            {
                ContaReceberID = contaReceberDAO.BuscaProxCodigoDisponivel(),
                DataCadastro = DateTime.Today,
                DataConta = dtpSaida.Value,
                Pessoa = buscaPessoa.pessoa,
                Operacao = buscaOperacao.operacao,
                ValorOriginal = dbValorTotalItens.Valor,                          
                Multa = 0m,
                Juros = dbJurosTotal.Valor,
                ValorFinal = dbValorTotalDocumento.Valor,
                Acrescimo = 0m,
                Desconto = dbDescontoDocumento.Valor,           
                Situacao = "Aberto",
                Descricao = tbDescricao.Text,
                Entrada = 0m,
                Parcelas = parcelas            
            };

            int resultado = contaReceberDAO.SalvaOuAtualiza(contaReceber);

            if(resultado > 0)
            {
                MessageBox.Show("Conta a Receber gerada com sucesso!",
                "Conta gerada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Problema ao gerar conta a receber",
                "Problema ao gerar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

        }

        private void Recarrega()
        {
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

            if (notaFiscalPropria != null)
            {
                notaFiscalPropria = notaFiscalPropriaDAO.BuscaByID(notaFiscalPropria.NotaFiscalPropriaID);
                notaFiscalPropria.Pessoa = pessoaDAO.BuscaByID(notaFiscalPropria.Pessoa.PessoaID);
                PreencheCampos(notaFiscalPropria);
                if (editando)
                    Editando(false);
            }
            else
            {
                ignoracheckevent = true;
                Limpa(true);
                ignoracheckevent = false;
                Editando(false);
            }
        }
        private void Anterior()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }


            if (tbCodigo.Text.Length > 0)
            {
                var newnotafiscal = notaFiscalPropriaDAO.Anterior(int.Parse(tbCodigo.Text));
                if (newnotafiscal != null)
                {
                    notaFiscalPropria = newnotafiscal;
                    notaFiscalPropria.Pessoa = pessoaDAO.BuscaByID(notaFiscalPropria.Pessoa.PessoaID);
                    itens = notaFiscalPropria.NotaFiscalPropriaItem.ToList();
                    PreencheCampos(notaFiscalPropria);
                    if (editando)
                    {
                        Editando(false);
                    }
                }
            }
        }
        private void Proximo()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }


            if (tbCodigo.Text.Length > 0)
            {
                var newnotafiscal = notaFiscalPropriaDAO.Proximo(int.Parse(tbCodigo.Text));
                if (newnotafiscal != null)
                {
                    notaFiscalPropria = newnotafiscal;
                    notaFiscalPropria.Pessoa = pessoaDAO.BuscaByID(notaFiscalPropria.Pessoa.PessoaID);
                    itens = notaFiscalPropria.NotaFiscalPropriaItem.ToList();
                    PreencheCampos(notaFiscalPropria);
                    if (editando)
                    {
                        Editando(false);
                    }
                }
            }
        }
        private void CarregaDados()
        {
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
            if (notaFiscalPropria?.NotaFiscalPropriaID == codigo)
                return;


            if (tbCodigo.Text.Length == 0)
            {
                Limpa(true);
                Editando(false);
                return;
            }

            var newNotaFiscalPropria = notaFiscalPropriaDAO.BuscaByID(codigo);
            if (newNotaFiscalPropria != null)
            {
                newNotaFiscalPropria.Pessoa = pessoaDAO.BuscaByID(newNotaFiscalPropria.Pessoa.PessoaID);
                notaFiscalPropria = newNotaFiscalPropria;
                PreencheCampos(notaFiscalPropria);
                Editando(false);
            }
            else
            {
                Editando(true);
                Limpa(false);
            }

        }
        private void Editando(bool edit)
        {
            if (!ignoracheckevent)
            {
                editando = edit;
                menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
            }
        }
        private void Limpa(bool limpaCod)
        {
            if (limpaCod) { tbCodigo.Clear(); }
            buscaPessoa.Limpa();
            buscaOperacao.Limpa();
            tbDescricao.Clear();
            dtpEmissao.Value = DateTime.Now;
            dtpSaida.Value = DateTime.Now;
            dbValorTotalItens.Valor = 0.00m;
            dbDescontoTotalItens.Valor = 0.00m;
            dbDescontoDocumento.Valor = 0.00m;
            dbValorTotalDocumento.Valor = 0.00m;
            itens.Clear();
            tbAjuda.Text = "";
            dgvItens.Rows.Clear();
            dgvItens.Refresh();
            LimpaCamposItem(limpaCod);
            notaFiscalPropria = null;
            codigo = 0;
        }
        private void LimpaCamposItem(bool focus)
        {
            buscaItem1.Limpa();
            dbQuantidade.Valor = 0.00m;
            dbValorUnitItem.Valor = 0.00m;
            dbValorTotItem.Valor = 0.00m;
            dbDescontoItemPorc.Valor = 0.00m;
            dbDescontoItem.Valor = 0.00m;
            itemSelecionado = null;
            btExcluirItem.Enabled = false;
            btInserirItem.Text = "Inserir";
            if (focus) { buscaItem1.Focus(); }
        }
        private void InserirItem()
        {
            if (buscaItem1.item == null)
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaItem1.Focus();
                return;
            }

            var item = new NotaFiscalPropriaItem();
            item.Item = buscaItem1.item;



            item.Quantidade = dbQuantidade.Valor;
            item.ValorUnitario = dbValorUnitItem.Valor;
            item.ValorTotal = dbValorTotItem.Valor;
            item.DescontoPorc = dbDescontoItemPorc.Valor;
            item.Desconto = dbDescontoItem.Valor;
            var dr = dgvItens.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells[0].Value.ToString()) == item.Item.ItemID).FirstOrDefault();
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
            CalculaTotalDocumento();
            btExcluirItem.Enabled = false;
            LimpaCamposItem(true);
        }

        private void BuscaItem()
        {
            if (buscaItem1.item == null)
                return;
            var item = new NotaFiscalPropriaItem();
            var dr = dgvItens.Rows.Cast<DataGridViewRow>().Where(r => (int)r.Cells[0].Value == buscaItem1.item.ItemID).FirstOrDefault();
            if (dr == null)
            {
                item.Item = buscaItem1.item;
                btInserirItem.Text = "Inserir";
                btExcluirItem.Enabled = false;
            }
            else
            {
                item = itens.Find(i => i.Item.ItemID == buscaItem1.item.ItemID);
                btInserirItem.Text = "Alterar";
                btExcluirItem.Enabled = true;
            }
            PreencheCamposItem(item);
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
                CalculaTotalDocumento();
                itemSelecionado = null;
                btExcluirItem.Enabled = false;
                Editando(true);
            }
        }


        private void PreencheCampos(NotaFiscalPropria notafiscal)
        {
            ignoracheckevent = true;
            Limpa(false);
            tbCodigo.Text = notafiscal.NotaFiscalPropriaID.ToString();
            tbDescricao.Text = notafiscal.Descricao;
            buscaPessoa.PreencheCampos(notafiscal.Pessoa);
            dtpEmissao.Value = notafiscal.DataEmissao;
            dtpSaida.Value = notafiscal.DataEntradaSaida;
            dbValorTotalItens.Valor = notafiscal.ValorTotalItens;
            dbDescontoTotalItens.Valor = notafiscal.DescontoTotalItens;
            dbDescontoDocumento.Valor = notafiscal.DescontoDocumento;
            dbValorTotalDocumento.Valor = notafiscal.ValorTotalDocumento;
            itens = notafiscal.NotaFiscalPropriaItem.ToList();
            PreencheGridItens(itens);
            btInserirItem.Text = "Inserir";
            ignoracheckevent = false;
        }
        private void PreencheGridItens(List<NotaFiscalPropriaItem> itens)
        {
            foreach (var i in itens)
            {
                dgvItens.Rows.Add(i.Item.ItemID, i.Item.Descricao, i.Quantidade, i.ValorUnitario, i.ValorTotal, i.DescontoPorc, i.Desconto);
            }
            dgvItens.Refresh();
        }
        private void PreencheCamposItem(NotaFiscalPropriaItem item)
        {
            if (item != null)
            {
                ignoracheckevent = true;
                buscaItem1.PreencheCampos(item.Item);
                dbValorUnitItem.Valor = item.Item.ValorUnitario;
                dbQuantidade.Valor = item.Quantidade;
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
                buscaItem1.Focus();
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
        private void CalculaTotalItem()
        {
            dbValorTotItem.Valor = dbQuantidade.Valor * dbValorUnitItem.Valor;
        }
        private void CalculaDescontoItem()
        {
            dbDescontoItem.Valor = dbValorTotItem.Valor * dbDescontoItemPorc.Valor / 100;
        }
        private void CalculaPorcDescontoItem()
        {
            if (dbValorTotItem.Valor > 0)
                dbDescontoItemPorc.Valor = (dbDescontoItem.Valor * 100) / dbValorTotItem.Valor;
        }
        private void CalculaTotalDocumento()
        {
            if (itens.Count > 0)
            {
                dbValorTotalItens.Valor = itens.Sum(i => i.ValorTotal);
                dbDescontoTotalItens.Valor = itens.Sum(i => i.Desconto);
                totaldocumento = (itens.Sum(i => i.ValorTotal) - itens.Sum(i => i.Desconto));
                dbValorTotalDocumento.Valor = totaldocumento;

                if (buscaOperacao.operacao != null)
                {
                    dbJurosTotal.Valor = (totaldocumento * buscaOperacao.operacao.Juros) / 100;
                    dbDescontoDocumento.Valor = (totaldocumento * buscaOperacao.operacao.Desconto) / 100;
                    totaldocumento = totaldocumento + dbJurosTotal.Valor - dbDescontoDocumento.Valor;
                    dbValorTotalDocumento.Valor = totaldocumento;
                }
                else
                {
                    dbJurosTotal.Valor = 0m;
                    dbDescontoDocumento.Valor = 0m;
                }
            }
            else
            {
                dbValorTotalItens.Valor = 0m;
                dbDescontoTotalItens.Valor = 0m;
                dbValorTotalDocumento.Valor = 0m;
                dbJurosTotal.Valor = 0m;
                dbDescontoDocumento.Valor = 0m;
            }
        }

        private void buscaItem1_Codigo_Changed(object sender, EventArgs e)
        {
            if (buscaItem1.item == null)
                return;

            dbValorUnitItem.Valor = buscaItem1.item.ValorUnitario;
        }


        private void GerarParcelas()
        {
            if (buscaOperacao.operacao == null)
            {
                MessageBox.Show("Você deve selecionar um operação para gerar as parcelas!",
                 "Operação não selecionada",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }
            parcelas.Clear();
            var parcelasOperacao = buscaOperacao.operacao.Parcelas;
            jurosparcela = dbJurosTotal.Valor / parcelasOperacao.Count;
            descontoparcela = dbDescontoDocumento.Valor / parcelasOperacao.Count;

            int sequencia = 1;
            foreach (var parcela in parcelasOperacao)
            {
                var par = new ParcelaContaReceber
                {
                    Sequencia = sequencia,        
                    DataVencimento = dtpSaida.Value.AddDays(parcela.Dias),
                    Multa = 0.00m,
                    Juros = jurosparcela,
                    Valor = dbValorTotalItens.Valor / parcelasOperacao.Count,
                    Acrescimo = dbValorTotalDocumento.Valor * buscaOperacao.operacao.Acrescimo / 100 / parcelasOperacao.Count,
                    Desconto = descontoparcela,
                    Descricao = tbDescricao.Text,
                    Situacao = "Aberto"
                };
                sequencia++;
                this.parcelas.Add(par);
            }
        }

        private void BtVisualizarparcelas_Click(object sender, EventArgs e)
        {
            var fmvisualizaparcelas = new fmVisualizaParcelas(parcelas);
            fmvisualizaparcelas.Show(this);
        }

        private void BuscaOperacao_Leave(object sender, EventArgs e)
        {
            CalculaTotalDocumento();
        }

        private void BuscaOperacao_Codigo_Leave(object sender, EventArgs e)
        {
            CalculaTotalDocumento();
        }

        private void BtSimular_Click(object sender, EventArgs e)
        {
            GerarParcelas();
            var fmvisualizaparcelas = new fmVisualizaParcelas(parcelas);
            fmvisualizaparcelas.Show(this);
        }

        private void BuscaOperacao_Leave_1(object sender, EventArgs e)
        {
            CalculaTotalDocumento();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("030100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
