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
        private readonly static ConexaoDAO connection = new ConexaoDAO();
        private readonly NotaFiscalTerceirosDAO notaFiscalTerceirosDAO = new NotaFiscalTerceirosDAO(connection);
        private readonly PessoaDAO pessoaDAO = new PessoaDAO(connection);
        private readonly FuncoesAuxiliares f = new FuncoesAuxiliares();

        private NotaFiscalTerceiros notaFiscalTerceiros = new NotaFiscalTerceiros();
        private NotaFiscalTerceirosItem itemSelecionado = null;
        private List<NotaFiscalTerceirosItem> itens = new List<NotaFiscalTerceirosItem>();

        //Controle de Permissões
        PermissaoDAO permissaoDAO = new PermissaoDAO(new ConexaoDAO());
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO(new ConexaoDAO());
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

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
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }
        private void BuscaPessoa_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void DtpEmissao_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void DtpEntrada_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void BtInserirItem_Click(object sender, EventArgs e) => InserirItem();
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
                notaFiscalTerceiros.Pessoa = pessoaDAO.BuscaById(notaFiscalTerceiros.Pessoa.PessoaID);
                PreencheCampos(notaFiscalTerceiros);
            }
        }
        private void Salva()
        {
            if (!editando)
                return;


            notaFiscalTerceiros = new NotaFiscalTerceiros
            {
                NotaFiscalTerceirosID = int.Parse(tbCodigo.Text),
                Pessoa = buscaPessoa.pessoa,
                DataEmissao = dtpEmissao.Value,
                DataEntradaSaida = dtpEntrada.Value,

                ValorTotalItens = dbValorTotalItens.Valor,
                DescontoTotalItens = dbDescontoTotalItens.Valor,
                DescontoDocumento = dbDescontoDocumento.Valor,
                ValorTotalDocumento = dbValorTotalDocumento.Valor,

                NotaFiscalTerceirosItem = itens
            };

            int resultado = notaFiscalTerceirosDAO.SalvarOuAtualizar(notaFiscalTerceiros);

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
                notaFiscalTerceiros.Pessoa = pessoaDAO.BuscaById(notaFiscalTerceiros.Pessoa.PessoaID);
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
                var newNotaFiscalTerceiros = notaFiscalTerceirosDAO.Proximo(int.Parse(tbCodigo.Text));

                if (newNotaFiscalTerceiros != null)
                {
                    newNotaFiscalTerceiros.Pessoa = pessoaDAO.BuscaById(newNotaFiscalTerceiros.Pessoa.PessoaID);
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
                var newNotaFiscalTerceiros = notaFiscalTerceirosDAO.Anterior(int.Parse(tbCodigo.Text));
                if (newNotaFiscalTerceiros != null)
                {
                    newNotaFiscalTerceiros.Pessoa = pessoaDAO.BuscaById(newNotaFiscalTerceiros.Pessoa.PessoaID);
                    notaFiscalTerceiros = newNotaFiscalTerceiros;
                    itens = notaFiscalTerceiros.NotaFiscalTerceirosItem.ToList();
                    PreencheCampos(notaFiscalTerceiros);
                    if (editando)
                        Editando(false);
                }
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
        private void InserirItem()
        {
            if (buscaItem.item == null)
            {
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaItem.Focus();
                return;
            }

            var item = new NotaFiscalTerceirosItem();
            item.Item = buscaItem.item;



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
            if (buscaItem.item == null)
                return;
            var item = new NotaFiscalTerceirosItem();
            var dr = dgvItens.Rows.Cast<DataGridViewRow>().Where(r => (int)r.Cells[0].Value == buscaItem.item.ItemID).FirstOrDefault();
            if (dr == null)
            {
                item.Item = buscaItem.item;
                btInserirItem.Text = "Inserir";
                btExcluirItem.Enabled = false;
            }
            else
            {
                item = itens.Find(i => i.Item.ItemID == buscaItem.item.ItemID);
                btInserirItem.Text = "Alterar";
                btExcluirItem.Enabled = true;
            }
            PreencheCamposItem(item);
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
        private void PreencheCampos(NotaFiscalTerceiros notafiscal)
        {
            ignoracheckevent = true;
            Limpa(false);
            tbCodigo.Text = notafiscal.NotaFiscalTerceirosID.ToString();
            buscaPessoa.PreencheCampos(notafiscal.Pessoa);
            dtpEmissao.Value = notafiscal.DataEmissao;
            dtpEntrada.Value = notafiscal.DataEntradaSaida;
            dbValorTotalItens.Valor = notafiscal.ValorTotalItens;
            dbDescontoTotalItens.Valor = notafiscal.DescontoTotalItens;
            dbDescontoDocumento.Valor = notafiscal.DescontoDocumento;
            dbValorTotalDocumento.Valor = notafiscal.ValorTotalDocumento;
            itens = notafiscal.NotaFiscalTerceirosItem.ToList();
            PreencheGridItens(itens);
            btInserirItem.Text = "Inserir";
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
                MessageBox.Show("Item não encontrado no banco de dados",
                "Item não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaItem.Focus();
                return;
            }

            ignoracheckevent = true;
            buscaItem.PreencheCampos(item.Item);
            dbQuantidade.Valor = item.Quantidade;
            dbValorUnitItem.Valor = item.ValorUnitario;
            dbValorTotItem.Valor = item.ValorTotal;
            dbDescontoItemPorc.Valor = item.DescontoPorc;
            dbDescontoItem.Valor = item.Desconto;
            ignoracheckevent = false;
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


        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("070100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
