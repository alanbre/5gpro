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
    public partial class fmBuscaFormaPagamento : Form
    {
        List<FormaPagamento> listaformapagamento;
        public FormaPagamento formapagamentoSelecionada = null;
        static ConexaoDAO connection = new ConexaoDAO();
        FormaPagamentoDAO formapagamentoDAO = new FormaPagamentoDAO(connection);

        public fmBuscaFormaPagamento()
        {
            InitializeComponent();
        }

        private void BuscaFormaPagamento()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));

            listaformapagamento = formapagamentoDAO.BuscaTodos(tbNomeFormaPagamento.Text).ToList();

            foreach (FormaPagamento f in listaformapagamento)
            {
                table.Rows.Add(f.FormaPagamentoID, f.Nome);
            }
            dgvFormaPagamento.DataSource = table;
        }

        private void FmBuscaFormaPagamento_Load(object sender, EventArgs e)
        {
            BuscaFormaPagamento();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            BuscaFormaPagamento();
        }

        private void TbNomeFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            BuscaFormaPagamento();
        }

        private void DgvFormaPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvFormaPagamento.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvFormaPagamento.Rows[selectedRowIndex];
            formapagamentoSelecionada = listaformapagamento.Find(f => f.FormaPagamentoID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }
    }
}
