using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.Reports;
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

        private DataTable datatableprincipal;
        private Colunas colunasativas;
        List<object> listaobjetos;



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

        public struct Colunas
        {
            public string colunaconta;
            public string colunaclientefornecedor;
            public string colunanome;
            public string colunadatacad;
            public decimal colunavalororiginal;
            public decimal colunamulta;
            public decimal colunajuros;
            public decimal colunaacrescimo;
            public decimal colunadesconto;
            public decimal colunavalorfinal;

            public bool usarcolunaconta;
            public bool usarcolunaclientefornecedor;
            public bool usarcolunanome;
            public bool usarcolunadatacad;
            public bool usarcolunavalororiginal;
            public bool usarcolunamulta;
            public bool usarcolunajuros;
            public bool usarcolunaacrescimo;
            public bool usarcolunadesconto;
            public bool usarcolunavalorfinal;
        }


        public fmRelatorioContas()
        {
            InitializeComponent();

            for (int i = 0; i < clContas.Items.Count; i++)
                clContas.SetItemChecked(i, true);

            for (int i = 0; i < clColunas.Items.Count; i++)
                clColunas.SetItemChecked(i, true);

            CriaDataTable();
        }

        private void CriaDataTable()
        {
            datatableprincipal = new DataTable();

            foreach (var s in clColunas.CheckedItems)
            {
                switch (s)
                {
                    case "Conta":
                        datatableprincipal.Columns.Add("Conta", typeof(string));
                        break;
                    case "ClienteFornecedor":
                        datatableprincipal.Columns.Add("ClienteFornecedor", typeof(string));
                        break;
                    case "Nome":
                        datatableprincipal.Columns.Add("Nome", typeof(string));
                        break;
                    case "Data cad.":
                        datatableprincipal.Columns.Add("Data cad.", typeof(string));
                        break;
                    case "Valor original":
                        datatableprincipal.Columns.Add("Valor original", typeof(decimal));
                        break;
                    case "Multa":
                        datatableprincipal.Columns.Add("Multa", typeof(decimal));
                        break;
                    case "Juros":
                        datatableprincipal.Columns.Add("Juros", typeof(decimal));
                        break;
                    case "Acréscimo":
                        datatableprincipal.Columns.Add("Acréscimo", typeof(decimal));
                        break;
                    case "Desconto":
                        datatableprincipal.Columns.Add("Desconto", typeof(decimal));
                        break;
                    case "Valor final":
                        datatableprincipal.Columns.Add("Valor final", typeof(decimal));
                        break;
                }
                dgvRelatorioFiltro.DataSource = datatableprincipal;
            }
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
            PopularDGV();
        }

        private void BtGerar_Click(object sender, EventArgs e)
        {
            var frv = new fmRltGenerico(datatableprincipal);
            frv.Show(this);

            //var dataTable = new DataTable();
            //dataTable.Columns.Add("Conta", typeof(int));
            //dataTable.Columns.Add("Clientefornecedor");
            //dataTable.Columns.Add("Nome");
            //dataTable.Columns.Add("Datacadastro");
            //dataTable.Columns.Add("Valororiginal");
            //dataTable.Columns.Add("Multa");
            //dataTable.Columns.Add("Juros");
            //dataTable.Columns.Add("Acrescimo");
            //dataTable.Columns.Add("Desconto");
            //dataTable.Columns.Add("Valorfinal");

            //foreach (ContaReceber c in contasReceber)
            //{
            //    dataTable.Rows.Add(c.ContaReceberID,
            //        c.Pessoa.PessoaID,
            //        c.Pessoa.Nome,
            //        c.DataCadastro,
            //        c.ValorOriginal,
            //        c.Multa,
            //        c.Juros,
            //        c.Acrescimo,
            //        c.Desconto,
            //        c.ValorFinal
            //        );
            //}
            //foreach (ContaPagar c in contasPagar)
            //{
            //    dataTable.Rows.Add(c.ContaPagarID,
            //        c.Pessoa.PessoaID,
            //        c.Pessoa.Nome,
            //        c.DataCadastro,
            //        c.ValorOriginal,
            //        c.Multa,
            //        c.Juros,
            //        c.Acrescimo,
            //        c.Desconto,
            //        c.ValorFinal
            //        );
            //}

            //var frv = new fmReportViewer(dataTable);
            //frv.Show(this);
        }


        private void CbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodos.Checked)
                for (int i = 0; i < clColunas.Items.Count; i++)
                    clColunas.SetItemChecked(i, true);
            else
                for (int i = 0; i < clColunas.Items.Count; i++)
                    clColunas.SetItemChecked(i, false);

            CriaDataTable();
        }

        private void ClColunas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Evento de seleção das colunas
            CriaDataTable();
        }

        private void PopularDGV()
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

            contasPagar = contaPagarDAO.BuscaParaRelatorio(f);
            contasReceber = contaReceberDAO.BuscaParaRelatorio(f);

            colunasativas = new Colunas();

            foreach (ContaReceber cr in contasReceber)
            {
                foreach (var c in datatableprincipal.Columns)
                {
                    switch (c.ToString())
                    {
                        case "Conta":
                            colunasativas.colunaconta = cr.ContaReceberID.ToString();
                            colunasativas.usarcolunaconta = true;
                            break;
                        case "ClienteFornecedor":
                            colunasativas.colunaclientefornecedor = cr.Pessoa.PessoaID.ToString();
                            colunasativas.usarcolunaclientefornecedor = true;
                            break;
                        case "Nome":
                            colunasativas.colunanome = cr.Pessoa.Nome.ToString();
                            colunasativas.usarcolunanome = true;
                            break;
                        case "Data cad.":
                            colunasativas.colunadatacad = cr.DataCadastro.ToShortDateString();
                            colunasativas.usarcolunadatacad = true;
                            break;
                        case "Valor original":
                            colunasativas.colunavalororiginal = cr.ValorOriginal;
                            colunasativas.usarcolunavalororiginal = true;
                            break;
                        case "Multa":
                            colunasativas.colunamulta = cr.Multa;
                            colunasativas.usarcolunamulta = true;
                            break;
                        case "Juros":
                            colunasativas.colunajuros = cr.Juros;
                            colunasativas.usarcolunajuros = true;
                            break;
                        case "Acréscimo":
                            colunasativas.colunaacrescimo = cr.Acrescimo;
                            colunasativas.usarcolunaacrescimo = true;
                            break;
                        case "Desconto":
                            colunasativas.colunadesconto = cr.Desconto;
                            colunasativas.usarcolunadesconto = true;
                            break;
                        case "Valor final":
                            colunasativas.colunavalorfinal = cr.ValorFinal;
                            colunasativas.usarcolunavalorfinal = true;
                            break;
                    }
                }
                listaobjetos = new List<object>();
                listaobjetos = ValorColunas();
                AdicionaLinha(listaobjetos);
            }

            colunasativas = new Colunas();

            foreach (ContaPagar cp in contasPagar)
            {
                foreach (var c in datatableprincipal.Columns)
                {
                    switch (c.ToString())
                    {
                        case "Conta":
                            colunasativas.colunaconta = cp.ContaPagarID.ToString();
                            colunasativas.usarcolunaconta = true;
                            break;
                        case "ClienteFornecedor":
                            colunasativas.colunaclientefornecedor = cp.Pessoa.PessoaID.ToString();
                            colunasativas.usarcolunaclientefornecedor = true;
                            break;
                        case "Nome":
                            colunasativas.colunanome = cp.Pessoa.Nome.ToString();
                            colunasativas.usarcolunanome = true;
                            break;
                        case "Data cad.":
                            colunasativas.colunadatacad = cp.DataCadastro.ToShortDateString();
                            colunasativas.usarcolunadatacad = true;
                            break;
                        case "Valor original":
                            colunasativas.colunavalororiginal = cp.ValorOriginal;
                            colunasativas.usarcolunavalororiginal = true;
                            break;
                        case "Multa":
                            colunasativas.colunamulta = cp.Multa;
                            colunasativas.usarcolunamulta = true;
                            break;
                        case "Juros":
                            colunasativas.colunajuros = cp.Juros;
                            colunasativas.usarcolunajuros = true;
                            break;
                        case "Acréscimo":
                            colunasativas.colunaacrescimo = cp.Acrescimo;
                            colunasativas.usarcolunaacrescimo = true;
                            break;
                        case "Desconto":
                            colunasativas.colunadesconto = cp.Desconto;
                            colunasativas.usarcolunadesconto = true;
                            break;
                        case "Valor final":
                            colunasativas.colunavalorfinal = cp.ValorFinal;
                            colunasativas.usarcolunavalorfinal = true;
                            break;
                    }
                }
                listaobjetos = new List<object>();
                listaobjetos = ValorColunas();
                AdicionaLinha(listaobjetos);
            }
        }

        private void AdicionaLinha(List<object> campos)
        {
            switch (datatableprincipal.Columns.Count)
            {
                case 1:
                    datatableprincipal.Rows.Add(listaobjetos[0]);
                    break;
                case 2:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1]);
                    break;
                case 3:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1], listaobjetos[2]);
                    break;
                case 4:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1], listaobjetos[2], listaobjetos[3]);
                    break;
                case 5:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1], listaobjetos[2], listaobjetos[3], listaobjetos[4]);
                    break;
                case 6:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1], listaobjetos[2], listaobjetos[3], listaobjetos[4], listaobjetos[5]);
                    break;
                case 7:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1], listaobjetos[2], listaobjetos[3], listaobjetos[4], listaobjetos[5], listaobjetos[6]);
                    break;
                case 8:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1], listaobjetos[2], listaobjetos[3], listaobjetos[4], listaobjetos[5], listaobjetos[6], listaobjetos[7]);
                    break;
                case 9:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1], listaobjetos[2], listaobjetos[3], listaobjetos[4], listaobjetos[5], listaobjetos[6], listaobjetos[7], listaobjetos[8]);
                    break;
                case 10:
                    datatableprincipal.Rows.Add(listaobjetos[0], listaobjetos[1], listaobjetos[2], listaobjetos[3], listaobjetos[4], listaobjetos[5], listaobjetos[6], listaobjetos[7], listaobjetos[8], listaobjetos[9]);
                    break;
            }
        }


        private List<object> ValorColunas()
        {
            List<object> Valores = new List<object>();

            if (colunasativas.usarcolunaconta)
                Valores.Add(colunasativas.colunaconta);

            if (colunasativas.usarcolunaclientefornecedor)
                Valores.Add(colunasativas.colunaclientefornecedor);

            if (colunasativas.usarcolunanome)
                Valores.Add(colunasativas.colunanome);

            if (colunasativas.usarcolunadatacad)
                Valores.Add(colunasativas.colunadatacad);

            if (colunasativas.usarcolunavalororiginal)
                Valores.Add(colunasativas.colunavalororiginal);

            if (colunasativas.usarcolunamulta)
                Valores.Add(colunasativas.colunamulta);

            if (colunasativas.usarcolunajuros)
                Valores.Add(colunasativas.colunajuros);

            if (colunasativas.usarcolunaacrescimo)
                Valores.Add(colunasativas.colunaacrescimo);

            if (colunasativas.usarcolunadesconto)
                Valores.Add(colunasativas.colunadesconto);

            if (colunasativas.usarcolunavalorfinal)
                Valores.Add(colunasativas.colunavalorfinal);

            return Valores;
        }
    }
}
