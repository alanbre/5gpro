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
    public partial class fmBuscaSubGrupoPessoa : Form
    {
        GrupoPessoa grupopessoa = null;
        List<SubGrupoPessoa> listasubgrupopessoa;
        public SubGrupoPessoa subgrupopessoaSelecionado = null;
        SubGrupoPessoaDAO subgrupopessoaDAO = new SubGrupoPessoaDAO();

        public fmBuscaSubGrupoPessoa(int grupopessoaID)
        {
            InitializeComponent();
            FiltroGrupo(grupopessoaID);
        }

        private void FmBuscaSubGrupoPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void FmBuscaSubGrupoPessoa_Load(object sender, EventArgs e)
        {
            BuscaSubGrupoPessoa();
        }
        private void TbNomeSubGrupo_TextChanged(object sender, EventArgs e)
        {
            BuscaSubGrupoPessoa();
        }
        private void BtPesquisarSubGrupoPessoa_Click(object sender, EventArgs e)
        {
            BuscaSubGrupoPessoa();
        }
        private void DgvSubGrupoPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvSubGrupoPessoa.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSubGrupoPessoa.Rows[selectedRowIndex];
            subgrupopessoaSelecionado = listasubgrupopessoa.Find(g => g.SubGrupoPessoaID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        private void FiltroGrupo(int grupoid)
        {
            grupopessoa = new GrupoPessoa();
            grupopessoa.GrupoPessoaID = grupoid;
        }
        private void BuscaSubGrupoPessoa()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));

            listasubgrupopessoa = subgrupopessoaDAO.Busca(tbNomeSubGrupo.Text, grupopessoa.GrupoPessoaID).ToList();

            foreach (SubGrupoPessoa g in listasubgrupopessoa)
            {
                table.Rows.Add(g.SubGrupoPessoaID, g.Nome);
            }
            dgvSubGrupoPessoa.DataSource = table;
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
