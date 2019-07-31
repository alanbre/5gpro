using _5gpro.Funcoes;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Reports
{
    public partial class fmRltNotasEntradas : Form
    {
        private FuncoesAuxiliares fa = new FuncoesAuxiliares();
        private DataTable _dados = new DataTable();
        private DateTime _dataInicial, _dataFinal;
        private bool _usaData;
        public fmRltNotasEntradas(DataTable dados, DateTime dataInicial, DateTime dataFinal, bool usaData)
        {
            InitializeComponent();
            _dados = fa.DeepCopy(dados);
            _dataInicial = dataInicial;
            _dataFinal = dataFinal;
            _usaData = usaData;
        }

        private void FmRltNotasTerceiro_Load(object sender, EventArgs e)
        {
            _dados.TableName = "notas_entradas";
            this.rvNotasEntradas.LocalReport.DisplayName = "Relatório de notas de saída";
            this.rvNotasEntradas.LocalReport.SetParameters(new ReportParameter($"dataInicial", _usaData? _dataInicial.ToString() : null, true));
            this.rvNotasEntradas.LocalReport.SetParameters(new ReportParameter($"dataFinal", _usaData ? _dataFinal.ToString() : null, true));
            this.rvNotasEntradas.LocalReport.DataSources.Clear();
            this.rvNotasEntradas.LocalReport.DataSources.Add(new ReportDataSource("dsNotasEntradas", _dados));
            this.rvNotasEntradas.SetDisplayMode(DisplayMode.PrintLayout);
            this.rvNotasEntradas.RefreshReport();
        }
    }
}
