using _5gpro.Daos;
using _5gpro.Entities;
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

namespace _5gpro.testesrelatorios
{
    public partial class rvTeste : Form
    {
        public rvTeste()
        {
            InitializeComponent();
        }

        private void RvTeste_Load(object sender, EventArgs e)
        {
            //PreencherDataSet();
            this.reportViewer1.RefreshReport();
        }
        private void PreencherDataSet()
        {
            Unimedida un = new Unimedida();
            un.UnimedidaID = 1;

            DataSetUnimedida datuni = new DataSetUnimedida();
            DataTable colab = datuni.Tables[0];

            colab.Rows.Add(un);

        }

            private void ReportViewer1_Load(object sender, EventArgs e)
        {
            List<Unimedida> listaunimedida = new List<Unimedida>();
            UnimedidaDAO unimedidaDAO = new UnimedidaDAO();

            //DataTable table = new DataTable();
            //table.Columns.Add("Código", typeof(string));
            //table.Columns.Add("Sigla", typeof(string));
            //table.Columns.Add("Descrição", typeof(string));
            //table.
            //table.Columns.Add("Código", typeof(string));
            //table.Columns.Add("Sigla", typeof(string));
            //table.Columns.Add("Descrição", typeof(string));

            //listaunimedida = unimedidaDAO.BuscarUnimedida("").ToList();

            //foreach (Unimedida u in listaunimedida)
            //{
            //    table.Rows.Add(u.UnimedidaID, u.Sigla, u.Descricao);

            //}

            DataTable table = new DataTable();
            table.Columns.Add("UnimedidaID", typeof(Int32));
            table.Columns.Add("Descricao", typeof(string));
            table.Columns.Add("Sigla", typeof(string));

            //Unimedida un = new Unimedida();
            //un.UnimedidaID = 1;
            //un.Descricao = "unimedida do report";
            //un.Sigla = "UDR";

            //DataSetUnimedida datuni = new DataSetUnimedida();
            //DataTable colab = new DataTable();

            listaunimedida = unimedidaDAO.BuscarUnimedida("").ToList();

            foreach (Unimedida u in listaunimedida)
            {
                table.Rows.Add(u.UnimedidaID, u.Descricao, u.Sigla);
            }

            // somehow get the data at runtime, application specific

            //this.myData = GetDataSource();

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetUnimedida", table));

            this.reportViewer1.RefreshReport();
        }
    }
}
