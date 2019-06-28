using _5gpro.Funcoes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace _5gpro.Reports
{
    public partial class fmRltGenerico : Form
    {
        private FuncoesAuxiliares fa = new FuncoesAuxiliares();
        private DataTable _dados = new DataTable();
        public fmRltGenerico(DataTable dados)
        {
            InitializeComponent();
            _dados = fa.DeepCopy(dados);
        }

        private void FmRltGenerico_Load(object sender, EventArgs e)
        {
            var i = 0;
            foreach (var c in _dados.Columns)
            {
                this.rpGenerico.LocalReport.SetParameters(new ReportParameter($"coluna{i}", c.ToString(), true));
                _dados.Columns[c.ToString()].ColumnName = $"coluna{i}";
                i++;
            }
            while (i <= 46)
            {
                _dados.Columns.Add($"coluna{i}");
                this.rpGenerico.LocalReport.SetParameters(new ReportParameter($"coluna{i}", "N", false));
                _dados.Columns[i].ColumnName = $"coluna{i}";
                i++;
            }

            this.rpGenerico.LocalReport.DataSources.Clear();
            this.rpGenerico.LocalReport.DataSources.Add(new ReportDataSource("dsGenerico", _dados));
            this.rpGenerico.RefreshReport();
        }
    }
}
