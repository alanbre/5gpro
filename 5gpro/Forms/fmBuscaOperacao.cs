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
    public partial class fmBuscaOperacao : Form
    {

        List<Operacao> operacoes;
        public Operacao operacaoSelecionada = null;

        public fmBuscaOperacao()
        {
            InitializeComponent();
        }

        private void BuscaOperacao()
        {
            OperacaoDAO operacaoDAO = new OperacaoDAO();

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Condição", typeof(string));
            table.Columns.Add("Desconto", typeof(string));
            table.Columns.Add("Entrada", typeof(string));

            operacoes = operacaoDAO.BuscaOperacoes(tbNomeOperacao.Text).ToList();

            foreach (Operacao o in operacoes)
            {
                table.Rows.Add(o.OperacaoID, o.Nome, o.Descricao, o.Condicao, o.Desconto, o.Entrada);
            }
            dgvOperacao.DataSource = table;
        }

        private void DgvOperacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvOperacao.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvOperacao.Rows[selectedRowIndex];
            operacaoSelecionada = operacoes.Find(o => o.OperacaoID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            BuscaOperacao();
        }

        private void TbNomeOperacao_TextChanged(object sender, EventArgs e)
        {
            BuscaOperacao();
        }
    }
}
