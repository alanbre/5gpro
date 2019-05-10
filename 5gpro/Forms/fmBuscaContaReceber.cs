using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaContaReceber : Form
    {
        public ContaReceber contaReceberSelecionada = null;
        private IEnumerable<ContaReceber> contasReceber;
        private static ConexaoDAO connection = new ConexaoDAO();
        private readonly ContaReceberDAO contaReceberDAO = new ContaReceberDAO(connection);

        public struct Filtros
        {
            public Pessoa filtroPessoa;
            public Operacao filtroOperacao;
            public decimal filtroValorInicial;
            public decimal filtroValorFinal;
            public DateTime filtroDataCadastroInicial;
            public DateTime filtroDataCadastroFinal;
            public DateTime filtroDataVencimentoInicial;
            public DateTime filtroDataVencimentoFinal;
        }


        public fmBuscaContaReceber()
        {
            InitializeComponent();
            DatasIniciais();
        }

        private void FmBuscaContaReceber_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();
        private void DgvContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvContas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvContas.Rows[selectedRowIndex];
            contaReceberSelecionada = contaReceberDAO.BuscaById(Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }



        private void Pesquisar()
        {
            Filtros f = new Filtros
            {
                filtroOperacao = buscaOperacao.operacao,
                filtroPessoa = buscaPessoa.pessoa,
                filtroValorInicial = dbValorInicial.Valor,
                filtroValorFinal = dbValorFinal.Valor,
                filtroDataCadastroInicial = dtpDataCadastroInicial.Value,
                filtroDataCadastroFinal = dtpDataCadastroFinal.Value,
                filtroDataVencimentoInicial = dtpDataVencimentoInicial.Value,
                filtroDataVencimentoFinal = dtpDataVencimentoFinal.Value
            };

            contasReceber = contaReceberDAO.Busca(f);
            dgvContas.Rows.Clear();

            foreach (var cr in contasReceber)
                dgvContas.Rows.Add(cr.ContaReceberID,
                                   cr.Pessoa.PessoaID,
                                   cr.Pessoa.Nome,
                                   cr.DataCadastro,
                                   cr.Operacao.Nome,
                                   cr.ValorOriginal,
                                   cr.Multa,
                                   cr.Juros,
                                   cr.Acrescimo,
                                   cr.Desconto,
                                   cr.ValorFinal);

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
