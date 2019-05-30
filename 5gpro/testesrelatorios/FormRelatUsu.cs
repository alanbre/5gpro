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

namespace _5gpro.testesrelatorios
{
    public partial class FormRelatUsu : Form
    {
        public FormRelatUsu()
        {
            InitializeComponent();
        }

        private void FormRelatUsu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("idusuario", typeof(int));
            dataTable.Columns.Add("nome");
            dataTable.Columns.Add("sobrenome");
            dataTable.Columns.Add("senha");
            dataTable.Columns.Add("email");
            dataTable.Columns.Add("telefone");

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            List<Usuario> listausuario = new List<Usuario>();
            listausuario = usuarioDAO.Busca("", "", "").ToList();

            foreach (Usuario u in listausuario)
            {
                dataTable.Rows.Add(u.UsuarioID, u.Nome, u.Sobrenome, u.Senha, u.Email, u.Telefone);
            }

            //dataTable.Rows.Add(1, "André", "Lima", "snm", "eduardo@gmail.com", "999999");
            //dataTable.Rows.Add(2, "Fulano", "de Tal", "hyhyhy", "jjjjjjo@gmail.com", "33333");
            //dataTable.Rows.Add(3, "Beltrano", "da Silva", "fefefef", "effff@gmail.com", "44444");
            //dataTable.Rows.Add(4, "Zé", "Ninguém", "dqdqdq", "yyyyyo@gmail.com", "55555");

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("SetUsuario", dataTable));

            this.reportViewer1.RefreshReport();
        }
    }
}
