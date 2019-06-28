using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmOrcBuscaOrcamento : Form
    {
        public Orcamento orcamentoSelecionado = null;
        private List<Orcamento> orcamentos;
        private readonly OrcamentoDAO orcamentoDAO = new OrcamentoDAO();

        private bool dataCadastroFiltro = false;
        private bool dataValidadeFiltro = false;
        private bool valorTotalFiltro = false;

        private FuncoesAuxiliares f = new FuncoesAuxiliares();

        public struct Filtros
        {
            public Pessoa filtroPessoa;
            public Cidade filtroCidade;
            public DateTime? filtroDataCadastroInicial;
            public DateTime? filtroDataCadastroFinal;
            public DateTime? filtroDataValidadeInicial;
            public DateTime? filtroDataValidadeFinal;
            public DateTime? filtroDataEfetivacaoInicial;
            public DateTime? filtroDataEfetivacaoFinal;
            public decimal filtroValorTotalInical;
            public decimal filtroValorTotalFinal;
            public bool contemValidade;
            public bool contemEfetivacao;
            public bool usardataCadastroFiltro;
            public bool usardataValidadeFiltro;
            public bool usarvalorTotalFiltro;
        }

        public fmOrcBuscaOrcamento()
        {
            InitializeComponent();
        }

        private void FmBuscaOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            dgvOrcamentos.Rows.Clear();
            Filtros f = new Filtros();
            f.filtroCidade = buscaCidade.cidade;
            f.filtroPessoa = buscaPessoa.pessoa;
            f.filtroDataCadastroInicial = dtpFiltroDataCadastroInicial.Value;
            f.filtroDataCadastroFinal = dtpFiltroDataCadastroFinal.Value;
            f.filtroDataValidadeInicial = dtpFiltroDataValidadeInicial.Value;
            f.filtroDataValidadeFinal = dtpFiltroDataValidadeFinal.Value;
            f.filtroValorTotalInical = dbValorTotalIni.Valor;
            f.filtroValorTotalFinal = dbValorTotalFinal.Valor;
            f.usardataCadastroFiltro = dataCadastroFiltro;
            f.usardataValidadeFiltro = dataValidadeFiltro;
            f.usarvalorTotalFiltro = valorTotalFiltro;


            orcamentos = orcamentoDAO.Busca(f);

            foreach (var o in orcamentos)
            {
                if (o.DataValidade.HasValue)
                {
                    dgvOrcamentos.Rows.Add(o.OrcamentoID, o.Pessoa.PessoaID, o.Pessoa.Nome, o.DataCadastro, o.DataValidade, o.ValorTotalItens, o.DescontoTotalItens, o.DescontoOrcamento, o.ValorTotalOrcamento);
                }
                else
                {
                    dgvOrcamentos.Rows.Add(o.OrcamentoID, o.Pessoa.PessoaID, o.Pessoa.Nome, o.DataCadastro, o.DataValidade, o.ValorTotalItens, o.DescontoTotalItens, o.DescontoOrcamento, o.ValorTotalOrcamento);
                }
            }
            dgvOrcamentos.Refresh();
        }
        private void DgvOrcamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvOrcamentos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvOrcamentos.Rows[selectedRowIndex];
            orcamentoSelecionado = orcamentos.Find(o => o.OrcamentoID == Convert.ToInt32(selectedRow.Cells[0].Value));
            orcamentoSelecionado = orcamentoDAO.BuscaByID(orcamentoSelecionado.OrcamentoID);
            this.Close();
        }
        private void CbValorTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValorTotal.Checked)
            {
                dbValorTotalIni.Enabled = true;
                dbValorTotalFinal.Enabled = true;
                valorTotalFiltro = true;
            }
            else
            {
                dbValorTotalIni.Enabled = false;
                dbValorTotalFinal.Enabled = false;
                valorTotalFiltro = false;
            }
        }
        private void CbDataCadastro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataCadastro.Checked)
            {
                dtpFiltroDataCadastroInicial.Enabled = true;
                dtpFiltroDataCadastroFinal.Enabled = true;
                dataCadastroFiltro = true;
            }
            else
            {
                dtpFiltroDataCadastroInicial.Enabled = false;
                dtpFiltroDataCadastroFinal.Enabled = false;
                dataCadastroFiltro = false;
            }
        }
        private void CbDataValidade_CheckedChanged(object sender, EventArgs e)
        {

            if (cbDataValidade.Checked)
            {
                dtpFiltroDataValidadeInicial.Enabled = true;
                dtpFiltroDataValidadeFinal.Enabled = true;
                dataValidadeFiltro = true;
            }
            else
            {
                dtpFiltroDataValidadeInicial.Enabled = false;
                dtpFiltroDataValidadeFinal.Enabled = false;
                dataValidadeFiltro = false;
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

    }
}
