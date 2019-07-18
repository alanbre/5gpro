using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaPessoa : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        public Pessoa pessoaSelecionada = null;
        private List<Pessoa> Pessoas;
        private readonly PessoaDAO pessoaDAO = new PessoaDAO();

        public fmBuscaPessoa()
        {
            InitializeComponent();
        }

        //LOAD
        private void FmBuscaPessoa_Load(object sender, EventArgs e) => BuscaPessoas();

        //LEAVE
        private void BuscaCidade_Leave(object sender, EventArgs e) => BuscaPessoas();

        //KEYUP, KEYDOWN
        private void FmBuscaPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void DgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvPessoas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPessoas.Rows[selectedRowIndex];
            pessoaSelecionada = Pessoas.Find(p => p.PessoaID == Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }

        //TEXTCHANGED
        private void TbFiltroNome_TextChanged(object sender, EventArgs e) => BuscaPessoas();
        private void TbCpfCnpj_TextChanged(object sender, EventArgs e) => BuscaPessoas();
        private void BuscaCidade_Text_Changed(object sender, EventArgs e) => BuscaPessoas();

        //FUNÇÕES
        private void BuscaPessoas()
        {
            dgvPessoas.Columns.Clear();

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
            Pessoas = pessoaDAO.Busca(tbFiltroNome.Text, tbCpfCnpj.Text, idcidade);

            foreach (Pessoa p in Pessoas)
            {
                table.Rows.Add(p.PessoaID, p.Nome, p.Fantasia, p.TipoPessoa, p.Endereco, p.Cidade.Nome, p.CpfCnpj, p.Telefone, p.Email);
            }
            dgvPessoas.DataSource = table;

            funaux.TratarTamanhoColunas(dgvPessoas);
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
