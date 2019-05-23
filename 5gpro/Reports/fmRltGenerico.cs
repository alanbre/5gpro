using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Reports
{
    public partial class fmRltGenerico : Form
    {
        private DataTable _dados;
        public fmRltGenerico(DataTable dados)
        {
            InitializeComponent();
            _dados = dados;
        }

        private void FmRltGenerico_Load(object sender, EventArgs e)
        {
            var i = 1;
            foreach (var c in _dados.Columns)
            {
                this.rpGenerico.LocalReport.SetParameters(new ReportParameter($"coluna{i}", c.ToString(), true));
                _dados.Columns[c.ToString()].ColumnName = $"coluna{i}";
                i++;
            }
            while(i <= 7)
            {
                this.rpGenerico.LocalReport.SetParameters(new ReportParameter($"coluna{i}", "", false));
                _dados.Columns[i].ColumnName = $"coluna{i}";
                i++;
            }

            this.rpGenerico.LocalReport.DataSources.Clear();
            this.rpGenerico.LocalReport.DataSources.Add(new ReportDataSource("dsGenerico", _dados));
            this.rpGenerico.RefreshReport();
        }
    }
}
