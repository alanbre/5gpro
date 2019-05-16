using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using _5gpro.Reports;
using System.Data;

namespace _5gpro.Forms
{
    public partial class fmRelatorio : Form
    {
        public fmRelatorio()
        {
            InitializeComponent();
        }

        private void FmRelatorio_Load(object sender, EventArgs e)
        {
            var parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("txFiltro1", "hello"));
            parameters.Add(new ReportParameter("txFiltro2", "world"));
            parameters.Add(new ReportParameter("txFiltro3", "loco"));
            var dt = new DataTable();


            var reportDataSource1 = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Namespace._5gpro.Reports.Report1.rdlc";

            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
