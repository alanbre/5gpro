using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaPessoa : Form
    {
        public Pessoa pessoaSelecionada = null;
        private List<Pessoa> Pessoas;
        private readonly PessoaDAO pessoaDAO = new PessoaDAO();

        public fmBuscaPessoa()
        {
            InitializeComponent();
        }

        private void fmBuscaPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }


        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            BuscaPessoas();
        }


        //EVENTOS DE TEXT CHANGED
        private void TbFiltroNome_TextChanged(object sender, EventArgs e)
        {
            if (tbFiltroNome.Text.Length > 0) { BuscaPessoas(); }
        }

        private void TbCpfCnpj_TextChanged(object sender, EventArgs e)
        {
            if (tbCpfCnpj.Text.Length > 0) { BuscaPessoas(); }
        }

        //EVENTOS DE CELL DOUBLE CLICK
        private void DgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvPessoas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPessoas.Rows[selectedRowIndex];
            pessoaSelecionada = Pessoas.Find(p => p.PessoaID == Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }


        private void BuscaPessoas()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome / Razão social", typeof(string));
            table.Columns.Add("Apelido / Fantasia", typeof(string));
            table.Columns.Add("Tipo de pessoa", typeof(string));
            table.Columns.Add("Endereço", typeof(string));
            table.Columns.Add("Cidade", typeof(string));
            table.Columns.Add("Cpf/Cnpj", typeof(string));
            table.Columns.Add("Telefone", typeof(string));
            table.Columns.Add("E-Mail", typeof(string));

            int idcidade = buscaCidade.cidade?.CidadeID ?? 0;
            Pessoas = pessoaDAO.BuscarPessoas(tbFiltroNome.Text, tbCpfCnpj.Text, idcidade);

            foreach (Pessoa p in Pessoas)
            {
                table.Rows.Add(p.PessoaID, p.Nome, p.Fantasia, p.TipoPessoa, p.Endereco, p.Cidade.Nome, p.CpfCnpj, p.Telefone, p.Email);
            }
            dgvPessoas.DataSource = table;
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
