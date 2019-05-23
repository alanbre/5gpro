using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Relatorios
{
    public partial class fmRelatorioContas : Form
    {

        private IEnumerable<ContaPagar> contasPagar;
        private IEnumerable<ContaReceber> contasReceber;
        private readonly ContaPagarDAO contaPagarDAO = new ContaPagarDAO();
        private readonly ContaReceberDAO contaReceberDAO = new ContaReceberDAO();

        private bool valorContaFiltro = false;
        private bool dataCadastroFiltro = false;
        private bool dataContaFiltro = false;


        public struct Filtros
        {
            public decimal filtroValorInicial;
            public decimal filtroValorFinal;
            public DateTime filtroDataCadastroInicial;
            public DateTime filtroDataCadastroFinal;
            public DateTime filtroDataContaInicial;
            public DateTime filtroDataContaFinal;
            public bool usarvalorContaFiltro;
            public bool usardataCadastroFiltro;
            public bool usardataContaFiltro;
            public bool usarAberto;
            public bool usarPago;
        }


        public fmRelatorioContas()
        {
            InitializeComponent();

            for (int i = 0; i < clContas.Items.Count; i++)
                clContas.SetItemChecked(i, true);
        }


        private void CbDataCadastro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataCadastro.Checked)
            {
                dtpCadinicio.Enabled = true;
                dtpCadfim.Enabled = true;
                dataCadastroFiltro = true;
            }
            else
            {
                dtpCadinicio.Enabled = false;
                dtpCadfim.Enabled = false;
                dataCadastroFiltro = false;
            }


        }

        private void CbDataConta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataConta.Checked)
            {
                dtpContainicio.Enabled = true;
                dtpContafim.Enabled = true;
                dataContaFiltro = true;
            }
            else
            {
                dtpContainicio.Enabled = false;
                dtpContafim.Enabled = false;
                dataContaFiltro = false;
            }
        }

        private void CbValor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValor.Checked)
            {
                dbValorinicial.Enabled = true;
                dbValorfinal.Enabled = true;
                valorContaFiltro = true;
            }
            else
            {
                dbValorinicial.Enabled = false;
                dbValorfinal.Enabled = false;
                valorContaFiltro = false;
            }
        }

        private void BtListar_Click(object sender, EventArgs e)
        {
            contasPagar = new List<ContaPagar>();
            contasReceber = new List<ContaReceber>();

            Filtros f = new Filtros
            {
                filtroValorInicial = dbValorinicial.Valor,
                filtroValorFinal = dbValorfinal.Valor,
                filtroDataCadastroInicial = dtpCadinicio.Value,
                filtroDataCadastroFinal = dtpCadfim.Value,
                filtroDataContaInicial = dtpContainicio.Value,
                filtroDataContaFinal = dtpContafim.Value,
                usardataCadastroFiltro = dataCadastroFiltro,
                usardataContaFiltro = dataContaFiltro,
                usarvalorContaFiltro = valorContaFiltro

            };

            dgvRelatorioFiltro.Rows.Clear();

            foreach (var s in clContas.CheckedItems)
            {
                switch (s)
                {
                    case "Aberto":
                        f.usarAberto = true;
                        break;
                    case "Pago":
                        f.usarPago = true;
                        break;
                    case "A Pagar":
                        contasPagar = contaPagarDAO.BuscaParaRelatorio(f);
                        foreach (var cp in contasPagar)
                            dgvRelatorioFiltro.Rows.Add(cp.ContaPagarID,
                                                        cp.Pessoa.PessoaID, cp.Pessoa.Nome,
                                                        cp.DataCadastro.ToShortDateString(),
                                                        cp.ValorOriginal,
                                                        cp.Multa,
                                                        cp.Juros,
                                                        cp.Acrescimo,
                                                        cp.Desconto,
                                                        cp.ValorFinal);
                        break;
                    case "A Receber":
                        contasReceber = contaReceberDAO.BuscaParaRelatorio(f);
                        foreach (var cr in contasReceber)
                            dgvRelatorioFiltro.Rows.Add(cr.ContaReceberID,
                                                        cr.Pessoa.PessoaID, cr.Pessoa.Nome,
                                                        cr.DataCadastro.ToShortDateString(),
                                                        cr.ValorOriginal,
                                                        cr.Multa,
                                                        cr.Juros,
                                                        cr.Acrescimo,
                                                        cr.Desconto,
                                                        cr.ValorFinal);
                        break;

                }
            }


            dgvRelatorioFiltro.Refresh();

        }

        private void BtGerar_Click(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Conta", typeof(int));
            dataTable.Columns.Add("Clientefornecedor");
            dataTable.Columns.Add("Nome");
            dataTable.Columns.Add("Datacadastro");
            dataTable.Columns.Add("Valororiginal");
            dataTable.Columns.Add("Multa");
            dataTable.Columns.Add("Juros");
            dataTable.Columns.Add("Acrescimo");
            dataTable.Columns.Add("Desconto");
            dataTable.Columns.Add("Valorfinal");

            foreach (ContaReceber c in contasReceber)
            {
                dataTable.Rows.Add(c.ContaReceberID,
                    c.Pessoa.PessoaID,
                    c.Pessoa.Nome,
                    c.DataCadastro,
                    c.ValorOriginal,
                    c.Multa,
                    c.Juros,
                    c.Acrescimo,
                    c.Desconto,
                    c.ValorFinal
                    );
            }
            foreach (ContaPagar c in contasPagar)
            {
                dataTable.Rows.Add(c.ContaPagarID,
                    c.Pessoa.PessoaID,
                    c.Pessoa.Nome,
                    c.DataCadastro,
                    c.ValorOriginal,
                    c.Multa,
                    c.Juros,
                    c.Acrescimo,
                    c.Desconto,
                    c.ValorFinal
                    );
            }

            var frv = new fmReportViewer(dataTable);
            frv.Show(this);
        }

        private void ClContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
