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

        FuncoesAuxiliares f = new FuncoesAuxiliares();

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
        }

        public fmOrcBuscaOrcamento()
        {
            InitializeComponent();
        }

        private void FmBuscaOrcamento_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void TbFiltroValorTotalOrcamentoInicial_Leave(object sender, EventArgs e)
        {
            tbFiltroValorTotalOrcamentoInicial.Text = tbFiltroValorTotalOrcamentoInicial.Text.Length > 0 ? Convert.ToDecimal(tbFiltroValorTotalOrcamentoInicial.Text).ToString("############0.00") : "0,00";
        }
        private void TbFiltroValorTotalOrcamentoFinal_Leave(object sender, EventArgs e)
        {
            tbFiltroValorTotalOrcamentoFinal.Text = tbFiltroValorTotalOrcamentoFinal.Text.Length > 0 ? Convert.ToDecimal(tbFiltroValorTotalOrcamentoFinal.Text).ToString("############0.00") : "999999,00";
        }
        private void TbFiltroValorTotalOrcamentoInicial_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void tbFiltroValorTotalOrcamentoFinal_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);





        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
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
            f.filtroDataEfetivacaoInicial = dtpFiltroDataEfetivacaoInicial.Value;
            f.filtroDataEfetivacaoFinal = dtpFiltroDataEfetivacaoFinal.Value;
            f.contemValidade = cblFiltros.GetItemChecked(0);
            f.contemEfetivacao = cblFiltros.GetItemChecked(1);
            f.filtroValorTotalInical = Convert.ToDecimal(tbFiltroValorTotalOrcamentoInicial.Text);
            f.filtroValorTotalFinal = Convert.ToDecimal(tbFiltroValorTotalOrcamentoFinal.Text);

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
    }
}
