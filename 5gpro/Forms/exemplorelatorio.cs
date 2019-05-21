using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class exemplorelatorio : Form
    {
        public exemplorelatorio()
        {
            InitializeComponent();
        }

        private void Exemplorelatorio_Load(object sender, EventArgs e)
        {

            //this.rvExemplo.RefreshReport();
        }

        private void ExportPdf()
        {

            ReportViewer Rv = new ReportViewer();
            ReportParameter[] Rp = new ReportParameter[3];
            BindingSource Bs = new BindingSource();
            ReportDataSource Rds = new ReportDataSource();
            DataTable Dt = new DataTable("Teste");
            DataRow Dr;

            Rp[0] = new ReportParameter("Name", "Name", true);
            Rp[1] = new ReportParameter("Age", "Age", true);
            Rp[2] = new ReportParameter("Phone", "Phone", true);

            Dt.Columns.Add("Name", typeof(string));
            Dt.Columns.Add("Age", typeof(string));
            Dt.Columns.Add("Phone", typeof(string));

            Dr = Dt.NewRow();
            Dr["Name"] = "Eduardo";
            Dr["Age"] = "28";
            Dr["Phone"] = "99999887";
            Dt.Rows.Add(Dr);

            Dr = Dt.NewRow();
            Dr["Name"] = "joao";
            Dr["Age"] = "15";
            Dr["Phone"] = "11111";
            Dt.Rows.Add(Dr);

            Dr = Dt.NewRow();
            Dr["Name"] = "Maiquel";
            Dr["Age"] = "34";
            Dr["Phone"] = "455";
            Dt.Rows.Add(Dr);

            Dr = Dt.NewRow();
            Dr["Name"] = "Lorena";
            Dr["Age"] = "50";
            Dr["Phone"] = "8888";
            Dt.Rows.Add(Dr);

            //for (int i = 0; i < 5; i++)
            //{
            //    Dr = Dt.NewRow();
            //    Dr["Name"] = "Vini " + i * i + 2;
            //    Dr["Age"] = "12 " + i + i + Math.PI;
            //    Dr["Phone"] = "2134 " + i + i / 0.5;

            //    Dt.Rows.Add(Dr);
            //}
            Bs.DataSource = Dt;
            Rds.Name = Dt.TableName;
            Rds.Value = Bs.DataSource;

            Rv.ProcessingMode = ProcessingMode.Local;
            Rv.LocalReport.ReportPath = @"Report2.rdlc";
            Rv.LocalReport.SetParameters(Rp);
            Rv.LocalReport.DataSources.Add(Rds);

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = Rv.LocalReport.Render(
            "Pdf", null, out mimeType, out encoding,
             out extension,
            out streamids, out warnings);

            FileStream fs = new FileStream(@"C:\Users\Eduardo\Documents\output.pdf", FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

            System.Diagnostics.Process.Start(@"C:\Users\Eduardo\Documents\output.pdf");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            ExportPdf();
            label1.Text = "Exportado com sucesso!";
        }
    }
}
