using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmEntEntradaNota : Form
    {
        private NotaFiscalTerceiros notaFiscalTerceirosNova;

        private CaixaLancamento caixalancamento = new CaixaLancamento();
        private readonly CaixaLancamentoDAO caixalancamentoDAO = new CaixaLancamentoDAO();
        private readonly NotaFiscalTerceirosDAO notaFiscalTerceirosDAO = new NotaFiscalTerceirosDAO();
        private readonly PessoaDAO pessoaDAO = new PessoaDAO();
        private readonly DesintegracaoDAO desintegracaoDAO = new DesintegracaoDAO();
        private Desintegracao desintegracao;

        private bool quantitativa;
        private decimal quantidadeparte = 0;
        private decimal percentualparte = 0;

        Validacao validacao = new Validacao();

        private NotaFiscalTerceiros notaFiscalTerceiros = new NotaFiscalTerceiros();
        private NotaFiscalTerceirosItem itemSelecionado = null;
        private List<NotaFiscalTerceirosItem> itens = new List<NotaFiscalTerceirosItem>();

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;
        int codigo = 0;

        bool editando, ignoracheckevent = false;


        public fmEntEntradaNota()
        {
            InitializeComponent();
            SetarNivel();
        }
        private void FmEntEntradaNota_KeyDown(object sender, KeyEventArgs e)
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
        private void FmEntEntradaNota_FormClosing(object sender, FormClosingEventArgs e)
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
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }
        private void TbCodigo_Leave(object sender, EventArgs e) => CarregaDados();
        private void BuscaPessoa_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void TbDescricao_TextChanged(object sender, EventArgs e) => Editando(true);
        private void DtpEmissao_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void DtpEntrada_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void DbDescontoDocumento_Valor_Changed(object sender, EventArgs e) => Editando(true);
        private void DbValorTotalDocumento_Valor_Changed(object sender, EventArgs e) => Editando(true);
        private void BtInserirItem_Click(object sender, EventArgs e)
        {
            BotaoInserirItem();
            CalculaTotalDocumento();
            btExcluirItem.Enabled = false;
            LimpaCamposItem(true);
        }
        private void BtExcluirItem_Click(object sender, EventArgs e) => ExcluirItem();
        private void DbQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
            CalculaDescontoItem();
        }
        private void DbValorTotItem_Leave(object sender, EventArgs e) => CalculaDescontoItem();
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
        private void DbDescontoItem_Leave(object sender, EventArgs e) => CalculaTotalItem();
        private void DbDescontoDocumento_Leave(object sender, EventArgs e) => CalculaTotalDocumento();
        private void DgvItens_CurrentCellChanged(object sender, EventArgs e) => SelecionarItem();
        private void BuscaItem_Codigo_Leave(object sender, EventArgs e) => BuscaItem();


        private void Novo()
        {
            if (editando)
                return;

            ignoracheckevent = true;
            Limpa(false);
            tbCodigo.Text = notaFiscalTerceirosDAO.BuscaProxCodigoDisponivel().ToString();
            notaFiscalTerceiros = null;
            buscaPessoa.Focus();
            ignoracheckevent = false;
            Editando(true);

        }
        private void Busca()
        {
            if (editando)
                return;
            var buscaNotaFiscalTerceiros = new fmEntBuscaNotaFiscalTerceiros();
            buscaNotaFiscalTerceiros.ShowDialog();
            if (buscaNotaFiscalTerceiros.notaFiscalTerceirosSelecionada != null)
            {
                notaFiscalTerceiros = buscaNotaFiscalTerceiros.notaFiscalTerceirosSelecionada;
                notaFiscalTerceiros.Pessoa = pessoaDAO.BuscaByID(notaFiscalTerceiros.Pessoa.PessoaID);
                PreencheCampos(notaFiscalTerceiros);
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
                    tbCodigo.Text = notaFiscalTerceirosDAO.BuscaProxCodigoDisponivel().ToString();
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

                notaFiscalTerceirosNova = new NotaFiscalTerceiros();
                notaFiscalTerceirosNova.NotaFiscalTerceirosID = int.Parse(tbCodigo.Text);
                notaFiscalTerceirosNova.Descricao = tbDescricao.Text;
                notaFiscalTerceirosNova.Pessoa = buscaPessoa.pessoa;
                notaFiscalTerceirosNova.DataEmissao = dtpEmissao.Value;
                notaFiscalTerceirosNova.DataEntradaSaida = dtpEntrada.Value;

                notaFiscalTerceirosNova.ValorTotalItens = dbValorTotalItens.Valor;
                notaFiscalTerceirosNova.DescontoTotalItens = dbDescontoTotalItens.Valor;
                notaFiscalTerceirosNova.DescontoDocumento = dbDescontoDocumento.Valor;
                notaFiscalTerceirosNova.ValorTotalDocumento = dbValorTotalDocumento.Valor;

                notaFiscalTerceirosNova.Caixa = buscaCaixa.caixa;
                notaFiscalTerceirosNova.PlanoDeConta = buscaPlanoDeConta.conta;

                notaFiscalTerceirosNova.NotaFiscalTerceirosItem = itens;
                

                ok = validacao.ValidarEntidade(notaFiscalTerceirosNova, controls);
            }

            if (ok)
            {
                validacao.despintarCampos(controls);

                int resultado = notaFiscalTerceirosDAO.SalvarOuAtualizar(notaFiscalTerceirosNova);

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
                    notaFiscalTerceirosDAO.MovimentaEstoque(notaFiscalTerceirosNova);
                    notaFiscalTerceirosDAO.MovimentaCaixa(notaFiscalTerceirosNova);

                    Editando(false);
                }
                else if (resultado == 2)
                {
                    tbAjuda.Text = "Dados atualizados com sucesso";
                    notaFiscalTerceirosDAO.LimpaRegistrosEstoque(notaFiscalTerceiros);
                    notaFiscalTerceirosDAO.MovimentaEstoque(notaFiscalTerceirosNova);
                    notaFiscalTerceirosDAO.LimpaRegistrosCaixa(notaFiscalTerceirosNova);
                    notaFiscalTerceirosDAO.MovimentaCaixa(notaFiscalTerceirosNova);
                    Editando(false);
                }
                notaFiscalTerceiros = notaFiscalTerceirosNova;
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

            if (notaFiscalTerceiros != null)
            {
                notaFiscalTerceiros = notaFiscalTerceirosDAO.BuscaByID(notaFiscalTerceiros.NotaFiscalTerceirosID);
                notaFiscalTerceiros.Pessoa = pessoaDAO.BuscaByID(notaFiscalTerceiros.Pessoa.PessoaID);
                PreencheCampos(notaFiscalTerceiros);
                if (editando)
                    Editando(false);
            }
            else
            {
                ignoracheckevent = true;
                Limpa(true);
                ignoracheckevent = false;
            }
        }
        private void Proximo()
        {
            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            validacao.despintarCampos(controls);

            if (tbCodigo.Text.Length > 0)
            {
                var newNotaFiscalTerceiros = notaFiscalTerceirosDAO.Proximo(int.Parse(tbCodigo.Text));

                if (newNotaFiscalTerceiros != null)
                {
                    newNotaFiscalTerceiros.Pessoa = pessoaDAO.BuscaByID(newNotaFiscalTerceiros.Pessoa.PessoaID);
                    notaFiscalTerceiros = newNotaFiscalTerceiros;
                    itens = notaFiscalTerceiros.NotaFiscalTerceirosItem.ToList();
                    PreencheCampos(notaFiscalTerceiros);
                    if (editando)
                        Editando(false);
                }
            }
        }
        private void Anterior()
        {
            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            validacao.despintarCampos(controls);

            if (tbCodigo.Text.Length > 0)
            {
                var newNotaFiscalTerceiros = notaFiscalTerceirosDAO.Anterior(int.Parse(tbCodigo.Text));
                if (newNotaFiscalTerceiros != null)
                {
                    newNotaFiscalTerceiros.Pessoa = pessoaDAO.BuscaByID(newNotaFiscalTerceiros.Pessoa.PessoaID);
                    notaFiscalTerceiros = newNotaFiscalTerceiros;
                    itens = notaFiscalTerceiros.NotaFiscalTerceirosItem.ToList();
                    PreencheCampos(notaFiscalTerceiros);
                    if (editando)
                        Editando(false);
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

            if (notaFiscalTerceiros?.NotaFiscalTerceirosID == codigo)
                return;


            if (tbCodigo.Text.Length == 0)
            {
                Limpa(true);
                Editando(false);
                return;
            }

            var newNotaFiscalTerceiros = notaFiscalTerceirosDAO.BuscaByID(codigo);
            if (newNotaFiscalTerceiros != null)
            {
                newNotaFiscalTerceiros.Pessoa = pessoaDAO.BuscaByID(newNotaFiscalTerceiros.Pessoa.PessoaID);
                notaFiscalTerceiros = newNotaFiscalTerceiros;
                PreencheCampos(notaFiscalTerceiros);
                notaFiscalTerceiros = newNotaFiscalTerceiros;
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
            buscaCaixa.Limpa();
            buscaPlanoDeConta.Limpa();
            tbDescricao.Clear();
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            dbValorTotalItens.Valor = 0.00m;
            dbDescontoTotalItens.Valor = 0.00m;
            dbDescontoDocumento.Valor = 0.00m;
            dbValorTotalDocumento.Valor = 0.00m;
            tbAjuda.Clear();
            dgvItens.Rows.Clear();
            dgvItens.Refresh();
            LimpaCamposItem(limpaCod);
            notaFiscalTerceiros = null;
            codigo = 0;
            itens.Clear();

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
            //if (focus) { buscaItem1.Focus(); }
            BotaoDesintegrar(buscaItem1.item);
        }

        private void InserirItem(Item itemrecebido, bool partedesintegrada)
        {

            var item = new NotaFiscalTerceirosItem();
            item.Item = itemrecebido;
            item.ValorUnitario = dbValorUnitItem.Valor;
            item.DescontoPorc = dbDescontoItemPorc.Valor;
            item.Desconto = dbDescontoItem.Valor;

            if (partedesintegrada)
            {
                item.ValorUnitario = itemrecebido.ValorEntrada;
                if (quantitativa)
                {
                    item.Quantidade = dbQuantidade.Valor * quantidadeparte;
                    item.ValorTotal = item.Quantidade * item.ValorUnitario;
                }
                else
                {
                    item.Quantidade = (dbQuantidade.Valor * percentualparte) / 100;
                    item.ValorTotal = item.Quantidade * item.ValorUnitario;
                }
                
            }
            else
            {
                item.Quantidade = dbQuantidade.Valor;
                item.ValorTotal = dbValorTotItem.Valor;
            }

            var dr = dgvItens.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells[0].Value.ToString()) == item.Item.ItemID).FirstOrDefault();
            if (dr == null)
            {
                itens.Add(item);
                dgvItens.Rows.Add(item.Item.ItemID, item.Item.Descricao, item.Quantidade, item.ValorUnitario, item.ValorTotal, item.DescontoPorc, item.Desconto);
                btNovoItem.PerformClick();
            }
            else
            {
                if (partedesintegrada)
                {
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Quantidade = dbQuantidade.Valor + itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Quantidade;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorUnitario = dbValorUnitItem.Valor;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorTotal = dbValorTotItem.Valor + itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorTotal;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().DescontoPorc = dbDescontoItemPorc.Valor;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Desconto = dbDescontoItem.Valor;
                    dr.Cells[dgvtbcQuantidade.Index].Value = itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Quantidade;
                    dr.Cells[dgvtbcValorUnitario.Index].Value = dbValorUnitItem.Valor;
                    dr.Cells[dgvtbcValorTotalItem.Index].Value = itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorTotal;
                    dr.Cells[dgvtbcDescontoPorc.Index].Value = dbDescontoItemPorc.Valor;
                    dr.Cells[dgvtbcDescontoItem.Index].Value = dbDescontoItem.Valor;
                    dgvItens.Update();
                    dgvItens.Refresh();
                }
                else
                {
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Quantidade = dbQuantidade.Valor;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorUnitario = dbValorUnitItem.Valor;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().ValorTotal = dbValorTotItem.Valor;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().DescontoPorc = dbDescontoItemPorc.Valor;
                    itens.Where(i => i.Item.ItemID == item.Item.ItemID).First().Desconto = dbDescontoItem.Valor;
                    dr.Cells[dgvtbcQuantidade.Index].Value = dbQuantidade.Valor;
                    dr.Cells[dgvtbcValorUnitario.Index].Value = dbValorUnitItem.Valor;
                    dr.Cells[dgvtbcValorTotalItem.Index].Value = dbValorTotItem.Valor;
                    dr.Cells[dgvtbcDescontoPorc.Index].Value = dbDescontoItemPorc.Valor;
                    dr.Cells[dgvtbcDescontoItem.Index].Value = dbDescontoItem.Valor;
                    dgvItens.Update();
                    dgvItens.Refresh();
                }
            }
            CalculaTotalDocumento();
            btExcluirItem.Enabled = false;
        }

        private void BotaoInserirItem()
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
            InserirItem(buscaItem1.item, false);
            LimpaCamposItem(true);
        }

        private void BuscaItem()
        {
            if (buscaItem1.item == null)
                return;
            var item = new NotaFiscalTerceirosItem();
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
            BotaoDesintegrar(buscaItem1.item);
        }

        private void BotaoDesintegrar(Item item)
        {
            if (item == null)
            {
                btDesintegrar.Enabled = false;
            }
            else
            {
                if (desintegracaoDAO.BuscaByID(item.ItemID) != null)
                {
                    btDesintegrar.Enabled = true;
                }
                else
                {
                    btDesintegrar.Enabled = false;
                }
            }
        }

        private void ExcluirItem()
        {

            if (itemSelecionado == null)
                return;

            itens.RemoveAll(i => i.Item.ItemID == itemSelecionado.Item.ItemID);
            dgvItens.Rows.Clear();
            dgvItens.Refresh();
            LimpaCamposItem(false);
            PreencheGridItens(itens);
            CalculaTotalDocumento();
            itemSelecionado = null;
            btExcluirItem.Enabled = false;

        }
        private void SelecionarItem()
        {
            if (dgvItens.SelectedRows.Count <= 0)
                return;

            int selectedRowIndex = dgvItens.SelectedCells[0].RowIndex;
            var selectedRow = dgvItens.Rows[selectedRowIndex];
            itemSelecionado = itens.Find(i => i.Item.ItemID == Convert.ToInt32(selectedRow.Cells[0].Value));
            PreencheCamposItem(itemSelecionado);
            btExcluirItem.Enabled = true;
        }

        private void PreencheCaixaEPlano(NotaFiscalTerceiros notafiscal)
        {
            caixalancamento = caixalancamentoDAO.BuscaByDocumento(notafiscal.NotaFiscalTerceirosID.ToString());
            buscaCaixa.PreencheCampos(caixalancamento.Caixa);
            buscaPlanoDeConta.PreencheCampos(caixalancamento.PlanoConta);
        }

        private void PreencheCampos(NotaFiscalTerceiros notafiscal)
        {
            ignoracheckevent = true;
            Limpa(false);
            tbCodigo.Text = notafiscal.NotaFiscalTerceirosID.ToString();
            tbDescricao.Text = notafiscal.Descricao;
            buscaPessoa.PreencheCampos(notafiscal.Pessoa);
            dtpEmissao.Value = notafiscal.DataEmissao;
            dtpEntrada.Value = notafiscal.DataEntradaSaida;
            dbValorTotalItens.Valor = notafiscal.ValorTotalItens;
            dbDescontoTotalItens.Valor = notafiscal.DescontoTotalItens;
            dbDescontoDocumento.Valor = notafiscal.DescontoDocumento;
            dbValorTotalDocumento.Valor = notafiscal.ValorTotalDocumento;
            itens = notafiscal.NotaFiscalTerceirosItem.ToList();
            PreencheGridItens(itens);
            PreencheCaixaEPlano(notafiscal);
            btInserirItem.Text = "Inserir";
            notaFiscalTerceiros = notafiscal;
            ignoracheckevent = false;
        }
        private void PreencheGridItens(List<NotaFiscalTerceirosItem> itens)
        {
            foreach (var i in itens)
            {
                dgvItens.Rows.Add(i.Item.ItemID, i.Item.Descricao, i.Quantidade, i.ValorUnitario, i.ValorTotal, i.DescontoPorc, i.Desconto);
            }
            dgvItens.Refresh();
        }
        private void PreencheCamposItem(NotaFiscalTerceirosItem item)
        {
            if (item == null)
            {
                buscaItem1.Focus();
                return;
            }

            ignoracheckevent = true;
            buscaItem1.PreencheCampos(item.Item);
            dbQuantidade.Valor = item.Quantidade;
            dbValorUnitItem.Valor = item.ValorUnitario;
            dbValorTotItem.Valor = item.ValorTotal;
            dbDescontoItemPorc.Valor = item.DescontoPorc;
            dbDescontoItem.Valor = item.Desconto;
            ignoracheckevent = false;
            BotaoDesintegrar(item.Item);

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
        private void CalculaTotalDocumento()
        {
            if (itens.Count > 0)
            {
                dbValorTotalItens.Valor = itens.Sum(i => i.ValorTotal);
                dbDescontoTotalItens.Valor = itens.Sum(i => i.Desconto);
                dbValorTotalDocumento.Valor = (itens.Sum(i => i.ValorTotal) - itens.Sum(i => i.Desconto) - dbDescontoDocumento.Valor);
            }
        }


        private void BtDesintegrar_Click(object sender, EventArgs e)
        {
            desintegracao = desintegracaoDAO.BuscaByID(buscaItem1.item.ItemID);

            foreach (var d in desintegracao.Partes)
            {
                if (desintegracao.Tipo == "Q")
                {
                    quantidadeparte = d.Quantidade;
                    quantitativa = true;

                }
                else
                {
                    percentualparte = d.Porcentagem;
                    quantitativa = false;
                }

                InserirItem(d.Item, true);
            }
            RemoverDesintegrado(desintegracao.Itemdesintegrado);
            LimpaCamposItem(true);
        }

        private void RemoverDesintegrado(Item itemdesintegrado)
        {
            if (itens.Any(l => l.Item.ItemID == itemdesintegrado.ItemID))
            {
                itens.Remove(itens.Where(i => i.Item.ItemID == itemdesintegrado.ItemID).First());
                dgvItens.Rows.Remove(dgvItens.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells[0].Value.ToString()) == itemdesintegrado.ItemID).FirstOrDefault());
            }
        }

        private void BuscaItem_Leave(object sender, EventArgs e)
        {
            if (buscaItem1.item != null)
            {
                dbValorUnitItem.Valor = buscaItem1.item.ValorEntrada;
            }
            else
            {
                dbValorUnitItem.Valor = 0;
            }
        }

        private void BuscaItem1_Codigo_Changed(object sender, EventArgs e)
        {
            BotaoDesintegrar(buscaItem1.item);
        }

        private void BuscaItem1_Codigo_Leave(object sender, EventArgs e)
        {
            BotaoDesintegrar(buscaItem1.item);
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("070100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
