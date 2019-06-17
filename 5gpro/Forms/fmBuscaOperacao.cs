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
        OperacaoDAO operacaoDAO = new OperacaoDAO();

        public fmBuscaOperacao()
        {
            InitializeComponent();
        }

        private void FmBuscaOperacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void DgvOperacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvOperacao.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvOperacao.Rows[selectedRowIndex];
            operacaoSelecionada = operacaoDAO.BuscaByID(int.Parse(selectedRow.Cells[0].Value.ToString()));
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


        private void BuscaOperacao()
        {
            

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Condição", typeof(string));
            table.Columns.Add("Desconto", typeof(string));
            table.Columns.Add("Entrada", typeof(string));

            operacoes = operacaoDAO.Busca(tbNomeOperacao.Text).ToList();

            foreach (var o in operacoes)
            {
                table.Rows.Add(o.OperacaoID, o.Nome, o.Descricao, o.Condicao, o.Desconto, o.Entrada);
            }
            dgvOperacao.DataSource = table;
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
