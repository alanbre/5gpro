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
        public List<Unimedida> listaunimedida;
        public Unimedida Unimedida;
        private UnimedidaDAO unimedidaDAO = new UnimedidaDAO();
        public Unimedida unimedidaSelecionada;


        public fmBuscaUnimedida()
        {
            InitializeComponent();
        }

        private void FmBuscaUnimedida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void BtPesquisar_Click(object sender, EventArgs e) => Busca();
        private void FmBuscaUnimedida_Load(object sender, EventArgs e) => Busca();
        private void DgvUnimedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvUnimedida.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvUnimedida.Rows[selectedRowIndex];
            unimedidaSelecionada = listaunimedida.Find(u => (u.UnimedidaID).ToString() == Convert.ToString(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }
        private void TbFiltroDescUnimedida_TextChanged(object sender, EventArgs e) => Busca();

        private void Busca()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Sigla", typeof(string));
            table.Columns.Add("Descrição", typeof(string));

            listaunimedida = unimedidaDAO.Busca(tbFiltroDescUnimedida.Text).ToList();

            dgvUnimedida.Rows.Clear();
            foreach (Unimedida u in listaunimedida)
            {
                table.Rows.Add(u.UnimedidaID, u.Sigla, u.Descricao);

            }
            dgvUnimedida.DataSource = table;
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
