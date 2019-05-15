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
        private static ConexaoDAO connection = new ConexaoDAO();
        private readonly NotaFiscalPropriaDAO notaFiscalPropriaDAO = new NotaFiscalPropriaDAO(connection);
        private readonly PessoaDAO pessoaDAO = new PessoaDAO(connection);
        private readonly FuncoesAuxiliares f = new FuncoesAuxiliares();

        private NotaFiscalPropria notaFiscalPropria = new NotaFiscalPropria();
        private NotaFiscalPropriaItem itemSelecionado;
        private List<NotaFiscalPropriaItem> itens = new List<NotaFiscalPropriaItem>();

        //Controle de Permissões
        PermissaoDAO permissaoDAO = new PermissaoDAO(new ConexaoDAO());
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO(new ConexaoDAO());
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

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

        private void FmSaidaEmissaoNota_FormClosing(object sender, FormClosingEventArgs e)
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



        private void BtNovoItem_Click(object sender, EventArgs e)
        {
            LimpaCamposItem(true);
            buscaItem.Focus();
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
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => ProximoCadastro();
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
        private void BuscaItem_Codigo_Leave(object sender, EventArgs e) => BuscaItem();
        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                //AbreTelaBuscaDocumento();
            }
        }
        private void BuscaPessoa_Text_Changed(object sender, EventArgs e) => Editando(true);
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
        private void DbDescontoItem_Leave(object sender, EventArgs e) => CalculaTotalItem();






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
                    Limpa(false);
                    tbCodigo.Text = notaFiscalPropriaDAO.BuscaProxCodigoDisponivel().ToString();
                    notaFiscalPropria = null;
                    buscaPessoa.Focus();
                    ignoracheckevent = false;
                    Editando(true);
                }
            }
            else
            {
                ignoracheckevent = true;
                Limpa(false);
                tbCodigo.Text = notaFiscalPropriaDAO.BuscaProxCodigoDisponivel().ToString();
                notaFiscalPropria = null;
                Editando(false);
                buscaPessoa.Focus();
                ignoracheckevent = false;
                Editando(true);
            }
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
                PreencheCampos(notaFiscalPropria);
            }
        }
        private void Salva()
        {
            if (editando)
            {
                var notaFiscalPropriaNova = new NotaFiscalPropria
                {
                    NotaFiscalPropriaID = int.Parse(tbCodigo.Text),
                    Pessoa = buscaPessoa.pessoa,
                    DataEmissao = dtpEmissao.Value,
                    DataEntradaSaida = dtpSaida.Value,

                    ValorTotalItens = dbValorTotalItens.Valor,
                    DescontoTotalItens = dbDescontoTotalItens.Valor,
                    DescontoDocumento = dbDescontoDocumento.Valor,
                    ValorTotalDocumento = dbValorTotalDocumento.Valor,

                    NotaFiscalPropriaItem = itens
                };

                int resultado = notaFiscalPropriaDAO.SalvarOuAtualizar(notaFiscalPropriaNova);

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
                    Editando(false);
                }
                else if (resultado == 2)
                {
                    notaFiscalPropriaDAO.LimpaRegistrosEstoque(notaFiscalPropria);
                    notaFiscalPropriaDAO.MovimentaEstoque(notaFiscalPropriaNova);
                    tbAjuda.Text = "Dados atualizados com sucesso";
                    Editando(false);
                }
                notaFiscalPropria = notaFiscalPropriaNova;
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
                notaFiscalPropria.Pessoa = pessoaDAO.BuscaById(notaFiscalPropria.Pessoa.PessoaID);
                PreencheCampos(notaFiscalPropria);
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
        private void ProximoCadastro()
        {
            //Busca o registro com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se pessoa existe. Se não existir busca o maior anterior ao digitado
            if (!editando && tbCodigo.Text.Length > 0)
            {
                NotaFiscalPropria newnotafiscal = notaFiscalPropriaDAO.Proximo(int.Parse(tbCodigo.Text));
                if (newnotafiscal != null)
                {
                    notaFiscalPropria = newnotafiscal;
                    itens = notaFiscalPropria.NotaFiscalPropriaItem.ToList();
                    PreencheCampos(notaFiscalPropria);
                }
            }
            else if (editando && tbCodigo.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    NotaFiscalPropria newnotafiscal = notaFiscalPropriaDAO.Proximo(int.Parse(tbCodigo.Text));
                    if (newnotafiscal != null)
                    {
                        notaFiscalPropria = newnotafiscal;
                        itens = notaFiscalPropria.NotaFiscalPropriaItem.ToList();
                        PreencheCampos(notaFiscalPropria);
                        Editando(false);
                    }
                    else
                    {
                        newnotafiscal = notaFiscalPropriaDAO.Anterior(int.Parse(tbCodigo.Text));
                        if (newnotafiscal != null)
                        {
                            notaFiscalPropria = newnotafiscal;
                            itens = notaFiscalPropria.NotaFiscalPropriaItem.ToList();
                            PreencheCampos(notaFiscalPropria);
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
                NotaFiscalPropria newnotafiscal = notaFiscalPropriaDAO.Anterior(int.Parse(tbCodigo.Text));
                if (newnotafiscal != null)
                {
                    notaFiscalPropria = newnotafiscal;
                    itens = notaFiscalPropria.NotaFiscalPropriaItem.ToList();
                    PreencheCampos(notaFiscalPropria);
                }
            }
            else if (editando && tbCodigo.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    NotaFiscalPropria newnotafiscal = notaFiscalPropriaDAO.Anterior(int.Parse(tbCodigo.Text));
                    if (newnotafiscal != null)
                    {
                        notaFiscalPropria = newnotafiscal;
                        itens = notaFiscalPropria.NotaFiscalPropriaItem.ToList();
                        PreencheCampos(notaFiscalPropria);
                        Editando(false);
                    }
                    else
                    {
                        newnotafiscal = notaFiscalPropriaDAO.Proximo(int.Parse(tbCodigo.Text));
                        if (newnotafiscal != null)
                        {
                            notaFiscalPropria = newnotafiscal;
                            itens = notaFiscalPropria.NotaFiscalPropriaItem.ToList();
                            PreencheCampos(notaFiscalPropria);
                            Editando(false);
                        }
                    }
                }
            }
        }
        private void CarregaDados()
        {
            int codigo = 0;
            if (!int.TryParse(tbCodigo.Text, out codigo)) { tbCodigo.Clear(); }
            if (notaFiscalPropria?.NotaFiscalPropriaID == codigo)
                return;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?", "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            if (tbCodigo.Text.Length == 0)
            {
                Limpa(true);
                Editando(false);
                return;
            }

            var newNotaFiscalPropria = notaFiscalPropriaDAO.BuscaByID(codigo);
            if (newNotaFiscalPropria != null)
            {
                newNotaFiscalPropria.Pessoa = pessoaDAO.BuscaById(newNotaFiscalPropria.Pessoa.PessoaID);
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
            dtpEmissao.Value = DateTime.Now;
            dtpSaida.Value = DateTime.Now;
            dbValorTotalItens.Valor = 0.00m;
            dbDescontoTotalItens.Valor = 0.00m;
            dbDescontoDocumento.Valor = 0.00m;
            dbValorTotalDocumento.Valor = 0.00m;
            tbAjuda.Text = "";
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

            var item = new NotaFiscalPropriaItem();
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
            var item = new NotaFiscalPropriaItem();
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
            }
        }
        private void PreencheCampos(NotaFiscalPropria notafiscal)
        {
            ignoracheckevent = true;
            Limpa(false);
            tbCodigo.Text = notafiscal.NotaFiscalPropriaID.ToString();
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

        private void BuscaItem_Codigo_Changed(object sender, EventArgs e)
        {

        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("030100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
