using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaPessoa : Form
    {
        Cidade cidade;
        public Pessoa pessoaSelecionada = null;
        List<Pessoa> Pessoas;
        PessoaBLL pessoaBLL = new PessoaBLL();
        CidadeBLL cidadeBLL = new CidadeBLL();

        public fmBuscaPessoa()
        {
            InitializeComponent();
        }


        //EVENTOS DE CLICK
        private void btBuscaCidade_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaCidade();
        }
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            BuscaPessoas();
        }

        //EVENTOS DE KEY UP
        private void tbCodCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaCidade();
            }
        }

        //EVENTOS DE KEY DOWN
        private void tbFiltroCodCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void tbFiltroNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void tbCpfCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        //EVENTOS DE LEAVE
        private void tbFiltroCodCidade_Leave(object sender, EventArgs e)
        {
            if (tbFiltroCodCidade.Text.Length > 0)
            {
                cidade = cidadeBLL.BuscaCidadeByCod(tbFiltroCodCidade.Text);
                PreencheCamposCidade(cidade);
            }
            else
            {
                tbNomeCidade.Text = "";
            }
        }

        //EVENTOS DE TEXT CHANGED
        private void tbFiltroNome_TextChanged(object sender, EventArgs e)
        {
            if (tbFiltroNome.Text.Length > 0) { BuscaPessoas(); }
        }
        private void tbCpfCnpj_TextChanged(object sender, EventArgs e)
        {
            if (tbCpfCnpj.Text.Length > 0) { BuscaPessoas(); }
        }

        private void dgvCidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvCidades.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCidades.Rows[selectedRowIndex];
            pessoaSelecionada = Pessoas.Find(p => p.Codigo == Convert.ToString(selectedRow.Cells[0].Value));
            this.Close();
        }







        private void AbreTelaBuscaCidade()
        {
            var buscaCidade = new fmBuscaCidade();
            buscaCidade.ShowDialog();
            if (buscaCidade.cidadeSelecionada != null)
            {
                cidade = buscaCidade.cidadeSelecionada;
                PreencheCamposCidade(cidade);
            }
        }
        private void PreencheCamposCidade(Cidade cidade)
        {
            if (cidade != null)
            {
                tbFiltroCodCidade.Text = cidade.CodCidade;
                tbNomeCidade.Text = cidade.Nome;
            }
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

            Pessoas = pessoaBLL.BuscarPessoas(tbFiltroNome.Text, tbCpfCnpj.Text, tbFiltroCodCidade.Text);

            foreach (Pessoa p in Pessoas)
            {
                table.Rows.Add(p.Codigo, p.Nome, p.Fantasia, p.TipoPessoa, p.Endereco, p.Cidade, p.CpfCnpj, p.Telefone, p.Email);
            }
            dgvCidades.DataSource = table;
        }

    }
}
