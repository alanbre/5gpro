using _5gpro.Funcoes;
using Microsoft.Reporting.WinForms;
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
    public partial class fmRltItens : Form
    {
        private FuncoesAuxiliares fa = new FuncoesAuxiliares();
        private DataTable _dados = new DataTable();
        private decimal _total = 0;
        public fmRltItens(DataTable dados, decimal total)
        {
            InitializeComponent();
            _dados = fa.DeepCopy(dados);
            _total = total;
        }

        private void FmRltItens_Load(object sender, EventArgs e)
        {
            _dados.TableName = "itens";
            this.rvItens.LocalReport.DisplayName = "Listagem de itens";
            this.rvItens.LocalReport.DataSources.Clear();
            this.rvItens.LocalReport.DataSources.Add(new ReportDataSource("dsItens", _dados));
            this.rvItens.LocalReport.SetParameters(new ReportParameter($"total", _total.ToString(), true));
            this.rvItens.SetDisplayMode(DisplayMode.PrintLayout);
            this.rvItens.RefreshReport();
        }
    }
}
