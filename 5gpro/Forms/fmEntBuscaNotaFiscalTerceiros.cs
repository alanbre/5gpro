using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmEntBuscaNotaFiscalTerceiros : Form
    {
        private IEnumerable<NotaFiscalTerceiros> notasFiscaisTerceiros;
        public NotaFiscalTerceiros notaFiscalTerceirosSelecionada = null;
        private readonly NotaFiscalTerceirosDAO notaFiscalTerceirosDAO = new NotaFiscalTerceirosDAO();
        private bool valorTotalFiltro = false;
        private bool dataEntradaFiltro = false;
        private bool dataEmissaoFiltro = false;

        private DataTable rel = new DataTable();

        public struct Filtros
        {
            public Cidade Cidade;
            public Pessoa Pessoa;
            public DateTime DataEmissaoInicial;
            public DateTime DataEmissaoFinal;
            public DateTime DataEntradaInicial;
            public DateTime DataEntradaFinal;
            public decimal ValorInicial;
            public decimal ValorFinal;
            public bool usarvalorTotalFiltro;
            public bool usardataEntradaFiltro;
            public bool usardataEmissaoFiltro;
        }

        public struct row
        {
            public DateTime data;
            public string codigo;
            public string item;
            public string tamanho;
            public decimal quantidade;
            public decimal valorunit;
            public decimal estoque;
        }

        public fmEntBuscaNotaFiscalTerceiros()
        {
            InitializeComponent();
        }

        private void FmEntBuscaNotaFiscalTerceiros_Load(object sender, EventArgs e)
        {
            rel.Columns.Add("data", typeof(DateTime));
            rel.Columns.Add("codigo", typeof(string));
            rel.Columns.Add("item", typeof(string));
            rel.Columns.Add("tamanho", typeof(string));
            rel.Columns.Add("quantidade", typeof(decimal));
            rel.Columns.Add("valorunit", typeof(decimal));
            rel.Columns.Add("estoque", typeof(decimal));
        }
        private void FmEntBuscaNotaFiscalTerceiros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();
        private void DgvDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Selecionar();
        private void CbValorTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValorTotal.Checked)
            {
                dbValorInicial.Enabled = true;
                dbValorFinal.Enabled = true;
                valorTotalFiltro = true;
            }
            else
            {
                dbValorInicial.Enabled = false;
                dbValorFinal.Enabled = false;
                valorTotalFiltro = false;
            }
        }
        private void CbDataEmissao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataEmissao.Checked)
            {
                dtpFiltroDataEmissaoInicial.Enabled = true;
                dtpFiltroDataEmissaoFinal.Enabled = true;
                dataEmissaoFiltro = true;
            }
            else
            {
                dtpFiltroDataEmissaoInicial.Enabled = false;
                dtpFiltroDataEmissaoFinal.Enabled = false;
                dataEmissaoFiltro = false;
            }
        }
        private void CbDataEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataEntrada.Checked)
            {
                dtpFiltroDataEntradaSaidaInicial.Enabled = true;
                dtpFiltroDataEntradaSaidaFinal.Enabled = true;
                dataEntradaFiltro = true;
            }
            else
            {
                dtpFiltroDataEntradaSaidaInicial.Enabled = false;
                dtpFiltroDataEntradaSaidaFinal.Enabled = false;
                dataEntradaFiltro = false;
            }
        }
        private void BtImprimir_Click(object sender, EventArgs e)
        {
            rel.Rows.Clear();
            var f = new Filtros
            {
                Cidade = buscaCidade.cidade,
                Pessoa = buscaPessoa.pessoa,
                DataEmissaoInicial = dtpFiltroDataEmissaoInicial.Value,
                DataEmissaoFinal = dtpFiltroDataEmissaoFinal.Value,
                DataEntradaInicial = dtpFiltroDataEntradaSaidaInicial.Value,
                DataEntradaFinal = dtpFiltroDataEntradaSaidaFinal.Value,
                ValorInicial = dbValorInicial.Valor,
                ValorFinal = dbValorFinal.Valor,
                usarvalorTotalFiltro = valorTotalFiltro,
                usardataEntradaFiltro = dataEntradaFiltro,
                usardataEmissaoFiltro = dataEmissaoFiltro
            };


            foreach (var row in notaFiscalTerceirosDAO.BuscaParaRelatorio(f))
            {
                rel.Rows.Add(
                    row.data,
                    row.codigo,
                    row.item,
                    row.tamanho,
                    row.quantidade,
                    row.valorunit,
                    row.estoque
                    );

            }
            var formRelatorioNotasTerceiros = new fmRltNotasEntradas(
                rel,
                dtpFiltroDataEntradaSaidaInicial.Value,
                dtpFiltroDataEntradaSaidaFinal.Value,
                cbDataEntrada.Checked);
            formRelatorioNotasTerceiros.Show(this);
        }



        private void Pesquisar()
        {
            var f = new Filtros
            {
                Cidade = buscaCidade.cidade,
                Pessoa = buscaPessoa.pessoa,
                DataEmissaoInicial = dtpFiltroDataEmissaoInicial.Value,
                DataEmissaoFinal = dtpFiltroDataEmissaoFinal.Value,
                DataEntradaInicial = dtpFiltroDataEntradaSaidaInicial.Value,
                DataEntradaFinal = dtpFiltroDataEntradaSaidaFinal.Value,
                ValorInicial = dbValorInicial.Valor,
                ValorFinal = dbValorFinal.Valor,
                usarvalorTotalFiltro = valorTotalFiltro,
                usardataEntradaFiltro = dataEntradaFiltro,
                usardataEmissaoFiltro = dataEmissaoFiltro
            };

            notasFiscaisTerceiros = notaFiscalTerceirosDAO.Busca(f);
            dgvDocumentos.Rows.Clear();


            foreach (var nf in notasFiscaisTerceiros)
            {
                dgvDocumentos.Rows.Add(nf.NotaFiscalTerceirosID,
                                       nf.Pessoa.PessoaID,
                                       nf.Pessoa.Nome,
                                       nf.DataEmissao,
                                       nf.DataEntradaSaida.Date,
                                       nf.ValorTotalDocumento);

            }
            dgvDocumentos.Refresh();
        }
        private void Selecionar()
        {
            if (dgvDocumentos.SelectedRows.Count <= 0)
                return;

            var selectedRowIndex = dgvDocumentos.SelectedCells[0].RowIndex;
            var selectedRow = dgvDocumentos.Rows[selectedRowIndex];
            notaFiscalTerceirosSelecionada = notaFiscalTerceirosDAO.BuscaByID(Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

    }
}
