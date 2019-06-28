using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCaiBuscaCaixa : Form
    {
        private List<Caixa> caixas = null;
        private readonly CaixaDAO caixaDAO = new CaixaDAO();

        public Caixa caixaSelecionada = null;

        public fmCaiBuscaCaixa()
        {
            InitializeComponent();
        }

        private void FmCaiBuscaCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void FmCaiBuscaCaixa_Load(object sender, EventArgs e) => Busca();
        private void TbNome_TextChanged(object sender, EventArgs e) => Busca();
        private void DgvCaixa_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Selecionar();

        private void Busca()
        {
            dgvCaixa.Rows.Clear();
            caixas = caixaDAO.Busca(tbNome.Text);
            foreach(var c in caixas)
            {
                dgvCaixa.Rows.Add(c.Codigo, c.Nome);
            }

            dgvCaixa.Refresh();
        }
        private void Selecionar()
        {
            var selectedRowIndex = dgvCaixa.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCaixa.Rows[selectedRowIndex];
            caixaSelecionada = caixas.Find(c => c.Codigo == Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
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
