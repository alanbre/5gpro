using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Reports
{
    public partial class fmRltNotasSaida : Form
    {
        private IDictionary<string, string> camposCliente;
        private IDictionary<string, string> camposNota;
        private IDictionary<string, string> camposItens;
        private DataTable dados = new DataTable();

        private NotaFiscalPropriaDAO notaFiscalPropriaDAO = new NotaFiscalPropriaDAO();
        private List<NotaFiscalPropria> notaFiscalProprias = new List<NotaFiscalPropria>();

        public struct Filtros
        {
            public bool usaFiltroClientes;
            public bool usaFiltroCidades;
            public bool usaFiltroDataEmissao;
            public bool usaFiltroDataSaida;
            public bool usaFiltroValor;
            public Pessoa pessoaInicial;
            public Pessoa pessoaFinal;
            public Cidade cidadeInicial;
            public Cidade cidadeFinal;
            public DateTime dataEmissaoInicial;
            public DateTime dataEmissaoFinal;
            public DateTime dataSaidaInicial;
            public DateTime dataSaidaFinal;
            public decimal valorInicial;
            public decimal valorFinal;
        }

        public fmRltNotasSaida()
        {
            InitializeComponent();
            SetarCampos();
        }

        private void CbTodosCamposClientes_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cblCamposClientes.Items.Count; i++)
            {
                cblCamposClientes.SetItemChecked(i, cbTodosCamposClientes.Checked);
            }

        }
        private void CbTodosCamposNota_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cblCamposNota.Items.Count; i++)
            {
                cblCamposNota.SetItemChecked(i, cbTodosCamposNota.Checked);
            }
        }
        private void CbTodosCamposItens_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cblCamposItens.Items.Count; i++)
            {
                cblCamposItens.SetItemChecked(i, cbTodosCamposItens.Checked);
            }
        }
        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();
        private void BtGerar_Click(object sender, EventArgs e) => Gerar();
        private void CbFiltrosClientes_CheckedChanged(object sender, EventArgs e)
        {
            gbFiltrosClientes.Enabled = cbFiltrosClientes.Checked;
        }
        private void CbFiltrosCidades_CheckedChanged(object sender, EventArgs e)
        {
            gbFiltrosCidades.Enabled = cbFiltrosCidades.Checked;
        }
        private void CbFiltroDataEmissao_CheckedChanged(object sender, EventArgs e)
        {
            gbFiltrosDataEmissao.Enabled = cbFiltroDataEmissao.Checked;
        }
        private void CbFiltroDataSaida_CheckedChanged(object sender, EventArgs e)
        {
            gbFiltrosDataSaida.Enabled = cbFiltroDataSaida.Checked;
        }
        private void CbFiltroValor_CheckedChanged(object sender, EventArgs e)
        {
            gbFiltrosValor.Enabled = cbFiltroValor.Checked;
        }



        private void SetarCampos()
        {
            SetarCamposCliente();
            SetarCamposNota();
            SetarCamposItens();
        }
        private void SetarCamposCliente()
        {
            camposCliente = new Dictionary<string, string>()
            {
                {"PessoaID", "Pessoa" },
                {"Nome", "Nome/Razão social" },
                {"Fantasia", "Apelido/Nome fantasia" },
                {"GrupoPessoaID", "Grupo de pessoa" },
                {"NomeGrupoPessoa", "Descrição grupo pessoa" },
                {"SubGrupoPessoaID", "Sub-Grupo pessoa" },
                {"NomeSubGrupoPessoa", "Descrição sub-grupo pessoa" },
                {"TipoPessoa", "Tipo de pessoa" },
                {"Atuacao", "Atuação" },
                {"Situacao", "Situação" },
                {"Rua", "Rua" },
                {"Numero", "Número" },
                {"Bairro", "Bairro" },
                {"Complemento", "Complemento" },
                {"CidadeID", "Código da cidade" },
                {"NomeCidade", "Nome da cidade" },
                {"CpfCnpj", "CPF/CNPJ" },
                {"Telefone", "Telefone" },
                {"Email", "E-Mail" }
            };

            foreach (var key in camposCliente)
            {
                cblCamposClientes.Items.Add(key.Value);
            }
        }
        private void SetarCamposNota()
        {
            camposNota = new Dictionary<string, string>()
            {
                {"NotaFiscalPropriaID", "Número" },
                {"DataEmissao", "Data emissão" },
                {"DataEntradaSaida", "Data da saída" },
                {"ValorTotalItens", "Valor total dos itens" },
                {"DescontoTotalItens", "Desconto total dos itens" },
                {"DescontoDocumento", "Desconto do documento" },
                {"ValorTotalDocumento", "Valor total do documento" }
            };
            foreach (var key in camposNota)
            {
                cblCamposNota.Items.Add(key.Value);
            }
        }
        private void SetarCamposItens()
        {
            camposItens = new Dictionary<string, string>()
            {
                {"ItemID", "Código"},
                {"Descricao", "Descrição do item"},
                {"DescCompra", "Descrição de compra"},
                {"TipoItem", "Tipo de item"},
                {"Referencia", "Referência"},
                {"ValorEntrada", "Preço de entrada"},
                {"ValorSaida", "Preço de venda"},
                {"Estoquenecessario", "Estoque necessário"},
                {"UnimedidaID", "Código unidade medida"},
                {"SiglaUnidadeMedida", "Sigla da unidade medida"},
                {"DescricaoUnidadeMedida", "Descrição da unidade medida"},
                {"GrupoItemID", "Cógido do grupo do item"},
                {"NomeGrupoItem", "Nome do grupo do item"},
                {"CodigoSubGrupoItem", "Código do sub-grupo do item"},
                {"NomeSubGrupoItem", "Nome do sub-grupo do item"},
                {"QuantidadeEstoque", "Estoque"},
                {"QuantidadeVenda", "Quantidade Venda" },
                {"ValorUnitarioVenda", "Valores unitários dos itens" },
                {"ValorTotal", "Valores totais dos itens" },
                {"DescontoPorc", "Porcentagem de desconto dos itens" },
                {"Desconto", "Descontos dos itens" }
            };
            foreach (var key in camposItens)
            {
                cblCamposItens.Items.Add(key.Value);
            }
        }
        private void TratarTamanhoColunas()
        {
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            for (var i = 0; i <= dgvDados.Columns.Count - 1; i++)
            {
                var colw = dgvDados.Columns[i].Width;
                dgvDados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvDados.Columns[i].Width = colw;
            }
        }
        private void SetarColunasGrid()
        {
            tcPaginas.SelectTab(2);
            dgvDados.Columns.Clear();
            dgvDados.Rows.Clear();

            foreach (var i in cblCamposClientes.CheckedItems)
            {
                dgvDados.Columns.Add(camposCliente.First(x => x.Value == i.ToString()).Key, i.ToString());
            }
            foreach (var i in cblCamposNota.CheckedItems)
            {
                dgvDados.Columns.Add(camposNota.First(x => x.Value == i.ToString()).Key, i.ToString());
            }
            foreach (var i in cblCamposItens.CheckedItems)
            {
                dgvDados.Columns.Add(camposItens.First(x => x.Value == i.ToString()).Key, i.ToString());
            }

            TratarTamanhoColunas();

            dgvDados.Refresh();
        }
        private void Pesquisar()
        {
            if ((cblCamposClientes.CheckedItems.Count + cblCamposItens.CheckedItems.Count + cblCamposNota.CheckedItems.Count) <= 0)
            {
                MessageBox.Show(
                "Não é possível pesquisar sem campos selecionados!",
                "Erro ao pesquisar dados",
                MessageBoxButtons.OK);
                tcPaginas.SelectTab(0);
                return;
            }

            if (!ChecaFiltros())
            {
                return;
            }

            var f = new Filtros
            {
                usaFiltroClientes = cbFiltrosClientes.Checked,
                usaFiltroCidades = cbFiltrosCidades.Checked,
                usaFiltroDataEmissao = cbFiltroDataEmissao.Checked,
                usaFiltroDataSaida = cbFiltroDataSaida.Checked,
                usaFiltroValor = cbFiltroValor.Checked,
                pessoaInicial = bpInicial.pessoa,
                pessoaFinal = bpFinal.pessoa,
                cidadeInicial = bcInicial.cidade,
                cidadeFinal = bcFinal.cidade,
                dataEmissaoInicial = dtpDataEmissaoInicial.Value,
                dataEmissaoFinal = dtpDataEmissaoFinal.Value,
                dataSaidaInicial = dtpDataSaidaInicial.Value,
                dataSaidaFinal = dtpDataSaidaFinal.Value,
                valorInicial = dbValorInicial.Valor,
                valorFinal = dbValorFinal.Valor
            };
            notaFiscalProprias = notaFiscalPropriaDAO.BuscaParaRelatorio(f).ToList();
            SetarColunasGrid();
            PreencherLinhas();
        }
        private void Gerar()
        {
            if (!ExisteDados())
            {
                MessageBox.Show(
                "Não é possível gerar relatório sem dados!",
                "Erro ao gerar relatório",
                MessageBoxButtons.OK);
                return;
            }
            var dt = MontaDataTable();
            var frv = new fmRltGenerico(dt);
            frv.Show(this);
        }
        private void PreencherLinhas()
        {
            DataGridViewColumnCollection header = dgvDados.Columns;
            if (cblCamposItens.CheckedItems.Count > 0)
            {
                foreach (var nf in notaFiscalProprias)
                {
                    foreach (var i in nf.NotaFiscalPropriaItem)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        foreach (DataGridViewColumn c in header)
                        {
                            switch (c.Name)
                            {
                                case "PessoaID":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.PessoaID, ValueType = nf.Pessoa?.PessoaID.GetType() });
                                    break;
                                case "Nome":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Nome, ValueType = nf.Pessoa?.Nome?.GetType() });
                                    break;
                                case "Fantasia":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Fantasia, ValueType = nf.Pessoa?.Fantasia?.GetType() });
                                    break;
                                case "GrupoPessoaID":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.SubGrupoPessoa?.GrupoPessoa?.GrupoPessoaID, ValueType = nf.Pessoa?.SubGrupoPessoa?.GrupoPessoa?.GrupoPessoaID.GetType() });
                                    break;
                                case "NomeGrupoPessoa":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.SubGrupoPessoa?.GrupoPessoa?.Nome, ValueType = nf.Pessoa?.SubGrupoPessoa?.GrupoPessoa?.Nome.GetType() });
                                    break;
                                case "SubGrupoPessoaID":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.SubGrupoPessoa?.SubGrupoPessoaID, ValueType = nf.Pessoa?.SubGrupoPessoa?.SubGrupoPessoaID.GetType() });
                                    break;
                                case "NomeSubGrupoPessoa":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.SubGrupoPessoa?.Nome, ValueType = nf.Pessoa?.SubGrupoPessoa?.Nome.GetType() });
                                    break;
                                case "TipoPessoa":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.TipoPessoa, ValueType = nf.Pessoa?.TipoPessoa?.GetType() });
                                    break;
                                case "Atuacao":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Atuacao, ValueType = nf.Pessoa?.Atuacao?.GetType() });
                                    break;
                                case "Situacao":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Situacao, ValueType = nf.Pessoa?.Situacao?.GetType() });
                                    break;
                                case "Rua":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Rua, ValueType = nf.Pessoa?.Rua?.GetType() });
                                    break;
                                case "Numero":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Numero, ValueType = nf.Pessoa?.Numero?.GetType() });
                                    break;
                                case "Bairro":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Bairro, ValueType = nf.Pessoa?.Bairro?.GetType() });
                                    break;
                                case "Complemento":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Complemento, ValueType = nf.Pessoa?.Complemento?.GetType() });
                                    break;
                                case "CidadeID":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Cidade.CidadeID, ValueType = nf.Pessoa?.Cidade?.CidadeID.GetType() });
                                    break;
                                case "NomeCidade":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Cidade.Nome, ValueType = nf.Pessoa?.Cidade.Nome?.GetType() });
                                    break;
                                case "CpfCnpj":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.CpfCnpj, ValueType = nf.Pessoa?.CpfCnpj?.GetType() });
                                    break;
                                case "Telefone":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Telefone, ValueType = nf.Pessoa?.Telefone?.GetType() });
                                    break;
                                case "Email":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Email, ValueType = nf.Pessoa?.Email?.GetType() });
                                    break;
                                case "NotaFiscalPropriaID":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.NotaFiscalPropriaID, ValueType = nf.NotaFiscalPropriaID.GetType() });
                                    break;
                                case "DataEmissao":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.DataEmissao, ValueType = nf.DataEmissao.GetType() });
                                    break;
                                case "DataEntradaSaida":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.DataEntradaSaida, ValueType = nf.DataEntradaSaida.GetType() });
                                    break;
                                case "ValorTotalItens":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.ValorTotalItens, ValueType = nf.ValorTotalItens.GetType() });
                                    break;
                                case "DescontoDocumento":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.DescontoDocumento, ValueType = nf.DescontoDocumento.GetType() });
                                    break;
                                case "ValorTotalDocumento":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.ValorTotalDocumento, ValueType = nf.ValorTotalDocumento.GetType() });
                                    break;
                                case "ItemID":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item.ItemID, ValueType = i.Item.ItemID.GetType() });
                                    break;
                                case "Descricao":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.Descricao, ValueType = i.Item?.Descricao?.GetType() });
                                    break;
                                case "DescCompra":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.DescCompra, ValueType = i.Item?.DescCompra?.GetType() });
                                    break;
                                case "TipoItem":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.TipoItem, ValueType = i.Item?.TipoItem?.GetType() });
                                    break;
                                case "Referencia":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.Referencia, ValueType = i.Item?.Referencia?.GetType() });
                                    break;
                                case "ValorEntrada":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.ValorEntrada, ValueType = i.Item?.ValorEntrada.GetType() });
                                    break;
                                case "ValorSaida":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.ValorSaida, ValueType = i.Item?.ValorSaida.GetType() });
                                    break;
                                case "Estoquenecessario":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.Estoquenecessario, ValueType = i.Item?.Estoquenecessario.GetType() });
                                    break;
                                case "UnimedidaID":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.Unimedida.UnimedidaID, ValueType = i.Item?.Unimedida.UnimedidaID.GetType() });
                                    break;
                                case "SiglaUnidadeMedida":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.Unimedida.Sigla, ValueType = i.Item?.Unimedida.Sigla?.GetType() });
                                    break;
                                case "DescricaoUnidadeMedida":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.Unimedida.Descricao, ValueType = i.Item?.Unimedida.Descricao?.GetType() });
                                    break;
                                case "GrupoItemID":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.SubGrupoItem?.GrupoItem?.GrupoItemID, ValueType = i.Item?.SubGrupoItem?.GrupoItem?.GrupoItemID.GetType() });
                                    break;
                                case "NomeGrupoItem":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.SubGrupoItem?.GrupoItem?.Nome, ValueType = i.Item?.SubGrupoItem?.GrupoItem?.Nome?.GetType() });
                                    break;
                                case "CodigoSubGrupoItem":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.SubGrupoItem?.Codigo, ValueType = i.Item?.SubGrupoItem?.Codigo.GetType() });
                                    break;
                                case "NomeSubGrupoItem":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.SubGrupoItem?.Nome, ValueType = i.Item?.SubGrupoItem?.Nome?.GetType() });
                                    break;
                                case "QuantidadeEstoque":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Item?.Quantidade, ValueType = i.Item?.Quantidade.GetType() });
                                    break;
                                case "QuantidadeVenda":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Quantidade, ValueType = i.Quantidade.GetType() });
                                    break;
                                case "ValorUnitarioVenda":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.ValorUnitario, ValueType = i.ValorUnitario.GetType() });
                                    break;
                                case "ValorTotal":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.ValorTotal, ValueType = i.ValorTotal.GetType() });
                                    break;
                                case "DescontoPorc":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.DescontoPorc, ValueType = i.DescontoPorc.GetType() });
                                    break;
                                case "Desconto":
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = i.Desconto, ValueType = i.Desconto.GetType() });
                                    break;
                            }
                        }
                        dgvDados.Rows.Add(row);
                    }
                }
            }
            else
            {
                foreach (var nf in notaFiscalProprias)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    foreach (DataGridViewColumn c in header)
                    {
                        switch (c.Name)
                        {
                            case "PessoaID":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.PessoaID, ValueType = nf.Pessoa?.PessoaID.GetType() });
                                break;
                            case "Nome":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Nome, ValueType = nf.Pessoa?.Nome?.GetType() });
                                break;
                            case "Fantasia":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Fantasia, ValueType = nf.Pessoa?.Fantasia?.GetType() });
                                break;
                            case "GrupoPessoaID":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.SubGrupoPessoa?.GrupoPessoa?.GrupoPessoaID, ValueType = nf.Pessoa?.SubGrupoPessoa?.GrupoPessoa?.GrupoPessoaID.GetType() });
                                break;
                            case "NomeGrupoPessoa":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.SubGrupoPessoa?.GrupoPessoa?.Nome, ValueType = nf.Pessoa?.SubGrupoPessoa?.GrupoPessoa?.Nome.GetType() });
                                break;
                            case "SubGrupoPessoaID":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.SubGrupoPessoa?.SubGrupoPessoaID, ValueType = nf.Pessoa?.SubGrupoPessoa?.SubGrupoPessoaID.GetType() });
                                break;
                            case "NomeSubGrupoPessoa":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.SubGrupoPessoa?.Nome, ValueType = nf.Pessoa?.SubGrupoPessoa?.Nome.GetType() });
                                break;
                            case "TipoPessoa":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.TipoPessoa, ValueType = nf.Pessoa?.TipoPessoa?.GetType() });
                                break;
                            case "Atuacao":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Atuacao, ValueType = nf.Pessoa?.Atuacao?.GetType() });
                                break;
                            case "Situacao":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Situacao, ValueType = nf.Pessoa?.Situacao?.GetType() });
                                break;
                            case "Rua":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Rua, ValueType = nf.Pessoa?.Rua?.GetType() });
                                break;
                            case "Numero":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Numero, ValueType = nf.Pessoa?.Numero?.GetType() });
                                break;
                            case "Bairro":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Bairro, ValueType = nf.Pessoa?.Bairro?.GetType() });
                                break;
                            case "Complemento":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Complemento, ValueType = nf.Pessoa?.Complemento?.GetType() });
                                break;
                            case "CidadeID":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Cidade.CidadeID, ValueType = nf.Pessoa?.Cidade?.CidadeID.GetType() });
                                break;
                            case "NomeCidade":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Cidade.Nome, ValueType = nf.Pessoa?.Cidade.Nome?.GetType() });
                                break;
                            case "CpfCnpj":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.CpfCnpj, ValueType = nf.Pessoa?.CpfCnpj?.GetType() });
                                break;
                            case "Telefone":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Telefone, ValueType = nf.Pessoa?.Telefone?.GetType() });
                                break;
                            case "Email":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.Pessoa?.Email, ValueType = nf.Pessoa?.Email?.GetType() });
                                break;
                            case "NotaFiscalPropriaID":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.NotaFiscalPropriaID, ValueType = nf.NotaFiscalPropriaID.GetType() });
                                break;
                            case "DataEmissao":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.DataEmissao, ValueType = nf.DataEmissao.GetType() });
                                break;
                            case "DataEntradaSaida":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.DataEntradaSaida, ValueType = nf.DataEntradaSaida.GetType() });
                                break;
                            case "ValorTotalItens":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.ValorTotalItens, ValueType = nf.ValorTotalItens.GetType() });
                                break;
                            case "DescontoDocumento":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.DescontoDocumento, ValueType = nf.DescontoDocumento.GetType() });
                                break;
                            case "ValorTotalDocumento":
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = nf.ValorTotalDocumento, ValueType = nf.ValorTotalDocumento.GetType() });
                                break;
                        }
                    }
                    dgvDados.Rows.Add(row);
                }
            }
            dgvDados.Refresh();
        }
        private bool ExisteDados()
        {
            if (dgvDados.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private DataTable MontaDataTable()
        {
            var dt = new DataTable();

            DataGridViewColumnCollection header = dgvDados.Columns;
            foreach (DataGridViewColumn c in header)
            {
                dt.Columns.Add(c.HeaderText);
            }

            object[] cellValues = new object[dgvDados.Columns.Count];
            foreach (DataGridViewRow row in dgvDados.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }
        private bool ChecaFiltros()
        {
            var valido = true;
            var mensagem = "";
            if (bpInicial.pessoa?.PessoaID > bpFinal.pessoa?.PessoaID && cbFiltrosClientes.Checked)
            {
                mensagem += "Cliente final maior que cliente inicial\n";
                valido = false;
            }
            if (bcInicial.cidade?.CidadeID > bcFinal.cidade?.CidadeID && cbFiltrosCidades.Checked)
            {
                mensagem += "Cidade final maior que cidade inicial\n";
                valido = false;
            }
            if (dtpDataEmissaoInicial.Value > dtpDataEmissaoFinal.Value && cbFiltroDataEmissao.Checked)
            {
                mensagem += "Data de emissão final maior que data de emissão inicial\n";
                valido = false;
            }
            if (dtpDataSaidaInicial.Value > dtpDataSaidaFinal.Value && cbFiltroDataSaida.Checked)
            {
                mensagem += "Data de saida final maior que data de saida inicial\n";
                valido = false;
            }

            if (dbValorInicial.Valor > dbValorFinal.Valor && cbFiltroValor.Checked)
            {
                mensagem += "Valor final maior que valor inicial\n";
                valido = false;
            }
            if (!valido)
            {
                MessageBox.Show(
                mensagem,
                "Filtros incorretos",
                MessageBoxButtons.OK);
            }
            tcPaginas.SelectTab(1);
            return valido;
        }
    }
}

