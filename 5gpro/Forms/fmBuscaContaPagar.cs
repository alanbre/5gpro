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
        public struct Filtros
        {
            public Pessoa filtroPessoa;
            public decimal filtroValorInicial;
            public decimal filtroValorFinal;
            public DateTime filtroDataCadastroInicial;
            public DateTime filtroDataCadastroFinal;
            public DateTime filtroDataVencimentoInicial;
            public DateTime filtroDataVencimentoFinal;
        }

        public fmBuscaContaPagar()
        {
            InitializeComponent();
            DatasIniciais();
        }



        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();
        private void DgvContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvContas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvContas.Rows[selectedRowIndex];
            contaPagarSelecionada = contaPagarDAO.BuscaById(Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }


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
                filtroDataVencimentoFinal = dtpDataVencimentoFinal.Value
            };

            contasPagar = contaPagarDAO.Busca(f);
            dgvContas.Rows.Clear();

            foreach (var cp in contasPagar)
                dgvContas.Rows.Add(cp.ContaPagarID,
                                   cp.Pessoa.PessoaID, cp.Pessoa.Nome,
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
    }
}
