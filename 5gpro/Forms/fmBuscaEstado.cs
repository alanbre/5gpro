using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaEstado : Form
    {
        public List<Estado> Estados;
        public Estado EstadoSelecionado;
        private EstadoBLL estadoBLL = new EstadoBLL();


        public fmBuscaEstado()
        {
            InitializeComponent();
            tbFiltroNomeEstado.Focus();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Estados = estadoBLL.BuscaEstadoByNome(tbFiltroNomeEstado.Text);
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            foreach (Estado estado in Estados)
            {
                table.Rows.Add(estado.CodEstado, estado.Nome);
            }
            dgvEstados.DataSource = table;
        }

        private void dgvEstados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvEstados.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvEstados.Rows[selectedRowIndex];
            EstadoSelecionado = Estados.Find(est => est.CodEstado == Convert.ToString(selectedRow.Cells[0].Value));
            this.Close();
        }
    }
}
