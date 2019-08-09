using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaBanco : Form
    {
        private readonly BancoDAO bancoDAO = new BancoDAO();

        public Banco bancoSelecionado = null;
        private List<Banco> bancos = new List<Banco>();
        public fmBuscaBanco()
        {
            InitializeComponent();
        }

        private void DgvBancos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvBancos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvBancos.Rows[selectedRowIndex];
            bancoSelecionado = bancos.Find(ban => ban.Codigo == selectedRow.Cells[0].Value.ToString());
            this.Close();
        }
        private void TbFiltroNomeEstado_TextChanged(object sender, EventArgs e) => Busca();
        private void FmBuscaBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        private void Busca()
        {
            bancos = bancoDAO.Busca(tbFiltroNomeBanco.Text);
            PreencheGrid();
        }
        private void PreencheGrid()
        {
            dgvBancos.Rows.Clear();
            foreach(var b in bancos)
            {
                dgvBancos.Rows.Add(
                    b.Codigo,
                    b.Nome
                    );
            }
            dgvBancos.Refresh();
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void FmBuscaBanco_Load(object sender, EventArgs e) => Busca();
        
    }
}
