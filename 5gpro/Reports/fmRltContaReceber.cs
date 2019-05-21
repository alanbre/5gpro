using _5gpro.Daos;
using _5gpro.Entities;
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
    public partial class fmRltContaReceber : Form
    {
        public fmRltContaReceber()
        {
            InitializeComponent();
        }

        private void FmRltContaReceber_Load(object sender, EventArgs e)
        {

            var dataTable = new DataTable();

            dataTable.Columns.Add("ContaReceberID", typeof(int));
            dataTable.Columns.Add("ValorFinal");
            dataTable.Columns.Add("Pessoa");



            //ItemDAO itemDAO = new ItemDAO();
            ContaReceberDAO contareceberDAO = new ContaReceberDAO();

            List<ContaReceber> listacontareceber = new List<ContaReceber>();
            Forms.fmBuscaContaReceber.Filtros f = new Forms.fmBuscaContaReceber.Filtros();
            listacontareceber = contareceberDAO.Busca(f).ToList();

            foreach (ContaReceber c in listacontareceber)
            {
                dataTable.Rows.Add(c.ContaReceberID, c.ValorFinal, c.Pessoa);
                //dataTable.Rows.Add(i.ItemID, i.Descricao, i.DescCompra, i.TipoItem, i.Referencia, i.ValorEntrada, i.ValorSaida, i.Estoquenecessario, i.Unimedida.Sigla, i.SubGrupoItem.Nome, i.Quantidade);
            }

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ContaReceberSet", dataTable));
            //this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsItem", dataTable));

            this.reportViewer1.RefreshReport();
        }
    }
}
