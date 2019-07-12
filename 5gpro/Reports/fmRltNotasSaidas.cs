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
    public partial class fmRltNotasSaidas : Form
    {
        private FuncoesAuxiliares fa = new FuncoesAuxiliares();
        private DataTable _dados = new DataTable();

        public fmRltNotasSaidas(DataTable dados)
        {
            InitializeComponent();
            _dados = fa.DeepCopy(dados);
        }

        private void FmRltNotasPropria_Load(object sender, EventArgs e)
        {
            _dados.TableName = "notas_saida";
            this.rvNotasProprias.LocalReport.DisplayName = "Relatório de notas de saída";
            this.rvNotasProprias.LocalReport.DataSources.Clear();
            this.rvNotasProprias.LocalReport.DataSources.Add(new ReportDataSource("dsNotasSaidas", _dados));
            this.rvNotasProprias.RefreshReport();
        }
    }
}
