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
    public partial class fmRltNotasEntradas : Form
    {
        private FuncoesAuxiliares fa = new FuncoesAuxiliares();
        private DataTable _dados = new DataTable();
        public fmRltNotasEntradas(DataTable dados)
        {
            InitializeComponent();
            _dados = fa.DeepCopy(dados);
        }

        private void FmRltNotasTerceiro_Load(object sender, EventArgs e)
        {
            _dados.TableName = "notas_entradas";
            this.rvNotasEntradas.LocalReport.DisplayName = "Relatório de notas de saída";
            this.rvNotasEntradas.LocalReport.DataSources.Clear();
            this.rvNotasEntradas.LocalReport.DataSources.Add(new ReportDataSource("dsNotasEntradas", _dados));
            this.rvNotasEntradas.SetDisplayMode(DisplayMode.PrintLayout);
            this.rvNotasEntradas.RefreshReport();
        }
    }
}
