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
        static ConexaoDAO connection = new ConexaoDAO();
        public List<Unimedida> listaunimedida;
        public Unimedida Unimedida;
        private UnimedidaDAO unimedidaDAO = new UnimedidaDAO(connection);
        public Unimedida unimedidaSelecionada;


        public fmBuscaUnimedida()
        {
            InitializeComponent();
        }

        public void BuscaUnimedida()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Sigla", typeof(string));
            table.Columns.Add("Descrição", typeof(string));

            listaunimedida = unimedidaDAO.BuscarUnimedida(tbFiltroDescUnimedida.Text).ToList();

            dgvUnimedida.Rows.Clear();
            foreach (Unimedida u in listaunimedida)
            {
                table.Rows.Add(u.UnimedidaID, u.Sigla, u.Descricao);

            }
            dgvUnimedida.DataSource = table;
        }


        private void btPesquisar_Click(object sender, EventArgs e)
        {
            BuscaUnimedida();
        }

        private void fmBuscaUnimedida_Load(object sender, EventArgs e)
        {
            BuscaUnimedida();
        }

        private void dgvUnimedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvUnimedida.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvUnimedida.Rows[selectedRowIndex];
            unimedidaSelecionada = listaunimedida.Find(u => (u.UnimedidaID).ToString() == Convert.ToString(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        private void TbFiltroDescUnimedida_TextChanged(object sender, EventArgs e)
        {
            BuscaUnimedida();
        }
    }
}
