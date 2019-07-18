using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaContaPagar : Form
    {

        public ContaPagar contaPagarSelecionada = null;
        private IEnumerable<ContaPagar> contasPagar;
        private readonly ContaPagarDAO contaPagarDAO = new ContaPagarDAO();
        private bool valorContaFiltro = false;
        private bool dataCadastroFiltro = false;
        private bool dataVencimentoFiltro = false;

        public struct Filtros
        {
            public Pessoa filtroPessoa;
            public decimal filtroValorInicial;
            public decimal filtroValorFinal;
            public DateTime filtroDataCadastroInicial;
            public DateTime filtroDataCadastroFinal;
            public DateTime filtroDataVencimentoInicial;
            public DateTime filtroDataVencimentoFinal;
            public bool usarvalorContaFiltro;
            public bool usardataCadastroFiltro;
            public bool usardataVencimentoFiltro;
        }

        public fmBuscaContaPagar()
        {
            InitializeComponent();
            DatasIniciais();
        }

        //KEYUP, KEYDOWN
        private void FmBuscaContaPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();
        private void DgvContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvContas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvContas.Rows[selectedRowIndex];
            contaPagarSelecionada = contaPagarDAO.BuscaByID(Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }

        //TEXTCHANGED
        private void CbValor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValorConta.Checked)
            {
                dbValorInicial.Enabled = true;
                dbValorFinal.Enabled = true;
                valorContaFiltro = true;
            }
            else
            {
                dbValorInicial.Enabled = false;
                dbValorFinal.Enabled = false;
                valorContaFiltro = false;
            }
        }
        private void CbDataCadastro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataCadastro.Checked)
            {
                dtpDataCadastroInicial.Enabled = true;
                dtpDataCadastroFinal.Enabled = true;
                dataCadastroFiltro = true;
            }
            else
            {
                dtpDataCadastroInicial.Enabled = false;
                dtpDataCadastroFinal.Enabled = false;
                dataCadastroFiltro = false;
            }
        }
        private void CbDataVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataVencimentoParcela.Checked)
            {
                dtpDataVencimentoInicial.Enabled = true;
                dtpDataVencimentoFinal.Enabled = true;
                dataVencimentoFiltro = true;
            }
            else
            {
                dtpDataVencimentoInicial.Enabled = false;
                dtpDataVencimentoFinal.Enabled = false;
                dataVencimentoFiltro = false;
            }
        }

        //FUNÇÕES
        private void Pesquisar()
        {
            Filtros f = new Filtros
            {
                filtroPessoa = buscaPessoa.pessoa,
                filtroValorInicial = dbValorInicial.Valor,
                filtroValorFinal = dbValorFinal.Valor,
                filtroDataCadastroInicial = dtpDataCadastroInicial.Value,
                filtroDataCadastroFinal = dtpDataCadastroFinal.Value,
                filtroDataVencimentoInicial = dtpDataVencimentoInicial.Value,
                filtroDataVencimentoFinal = dtpDataVencimentoFinal.Value,
                usardataCadastroFiltro = dataCadastroFiltro,
                usardataVencimentoFiltro = dataVencimentoFiltro,
                usarvalorContaFiltro = valorContaFiltro
            };

            contasPagar = contaPagarDAO.Busca(f);
            dgvContas.Rows.Clear();

            foreach (var cp in contasPagar)
                dgvContas.Rows.Add(cp.ContaPagarID,
                                   cp.Descricao,
                                   cp.Pessoa.Nome,
                                   cp.DataCadastro.ToShortDateString(),
                                   cp.ValorOriginal,
                                   cp.Multa,
                                   cp.Juros,
                                   cp.Acrescimo,
                                   cp.Desconto,
                                   cp.ValorFinal);

            dgvContas.Refresh();
        }
        private void DatasIniciais()
        {
            dtpDataCadastroInicial.Value = DateTime.Today.AddDays(-30);
            dtpDataVencimentoInicial.Value = DateTime.Today.AddDays(-30);
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
