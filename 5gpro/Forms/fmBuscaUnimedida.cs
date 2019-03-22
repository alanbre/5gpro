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

namespace _5gpro.Forms
{
    public partial class fmBuscaUnimedida : Form
    {
        public fmBuscaUnimedida()
        {
            InitializeComponent();
        }

        private void dgvUnimedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void fmBuscaUnimedida_Load(object sender, EventArgs e)
        {

            List<Unimedida> l = new List<Unimedida>();

            dgvUnimedida.ColumnCount = 3;
            dgvUnimedida.Columns[0].Name = "Código";
            dgvUnimedida.Columns[1].Name = "Sigla";
            dgvUnimedida.Columns[2].Name = "Descrição";

            var rows = new List<string[]>();
            List<Unimedida> lum = new List<Unimedida>();
            lum = new UnimedidaDAO().BuscarTodasUnimedidas();

            foreach (Unimedida unimedida in lum)
            {
                string[] row1 = new string[] { unimedida.Codigo.ToString(), unimedida.Sigla, unimedida.Descricao };
                rows.Add(row1);
            }

            foreach (string[] rowArray in rows)
            {
                dgvUnimedida.Rows.Add(rowArray);
            }
           

        }
    }
}
