﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Relatorios
{
    public partial class fmReportViewer : Form
    {
        private DataTable datatablelocal;
        public fmReportViewer(DataTable datatable)
        {
            InitializeComponent();
            datatablelocal = datatable;
        }

        private void FmReportViewer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsContas", datatablelocal));

            this.reportViewer1.RefreshReport();
        }
    }
}
