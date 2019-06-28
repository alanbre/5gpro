using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaGrupoPessoa : Form
    {

        List<GrupoPessoa> listagrupopessoa;
        public GrupoPessoa grupoPessoaSelecionado = null;
        GrupoPessoaDAO grupoPessoaDAO = new GrupoPessoaDAO();

        public fmBuscaGrupoPessoa()
        {
            InitializeComponent();
        }

        private void FmBuscaGrupoPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void FmBuscaGrupoPessoa_Load(object sender, EventArgs e) => BuscaGrupoPessoa();
        private void TbNomeGrupoPessoa_TextChanged(object sender, EventArgs e) => BuscaGrupoPessoa();

        private void DgvGrupoPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvGrupoPessoa.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvGrupoPessoa.Rows[selectedRowIndex];
            grupoPessoaSelecionado = grupoPessoaDAO.BuscaByID(Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }


        private void BuscaGrupoPessoa()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(int));
            table.Columns.Add("Nome", typeof(string));

            listagrupopessoa = grupoPessoaDAO.Busca(tbNomeGrupoPessoa.Text).ToList();

            foreach (GrupoPessoa g in listagrupopessoa)
            {
                table.Rows.Add(g.GrupoPessoaID, g.Nome);
            }
            dgvGrupoPessoa.DataSource = table;
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
