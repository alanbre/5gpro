using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.rpGenerico.LocalReport.DataSources.Clear();
            this.rpGenerico.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsGenerico", _dados));
            this.rpGenerico.RefreshReport();
            this.rpGenerico.RefreshReport();
        }
    }
}
