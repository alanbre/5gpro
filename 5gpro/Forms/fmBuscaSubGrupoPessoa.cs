using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaSubGrupoPessoa : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        GrupoPessoa grupopessoa = null;
        List<SubGrupoPessoa> listasubgrupopessoa;
        public SubGrupoPessoa subgrupopessoaSelecionado = null;
        SubGrupoPessoaDAO subgrupopessoaDAO = new SubGrupoPessoaDAO();

        public fmBuscaSubGrupoPessoa(int grupopessoaID)
        {
            InitializeComponent();
            FiltroGrupo(grupopessoaID);
        }

        //LOAD
        private void FmBuscaSubGrupoPessoa_Load(object sender, EventArgs e) => BuscaSubGrupoPessoa();

        //KEYUP, KEYDOWN
        private void FmBuscaSubGrupoPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        //CLICK
        private void DgvSubGrupoPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvSubGrupoPessoa.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSubGrupoPessoa.Rows[selectedRowIndex];
            subgrupopessoaSelecionado = listasubgrupopessoa.Find(g => g.Codigo == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        //TEXTCHANGED
        private void TbNomeSubGrupo_TextChanged(object sender, EventArgs e) => BuscaSubGrupoPessoa();

        //FUNÇÕES
        private void FiltroGrupo(int grupoid)
        {
            grupopessoa = new GrupoPessoa();
            grupopessoa.GrupoPessoaID = grupoid;
        }
        private void BuscaSubGrupoPessoa()
        {
            dgvSubGrupoPessoa.Columns.Clear();

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));

            listasubgrupopessoa = subgrupopessoaDAO.Busca(tbNomeSubGrupo.Text, grupopessoa.GrupoPessoaID).ToList();

            foreach (SubGrupoPessoa g in listasubgrupopessoa)
            {
                table.Rows.Add(g.Codigo, g.Nome);
            }
            dgvSubGrupoPessoa.DataSource = table;

            funaux.TratarTamanhoColunas(dgvSubGrupoPessoa);
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
