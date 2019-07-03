using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
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
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        List<Operacao> operacoes;
        public Operacao operacaoSelecionada = null;
        OperacaoDAO operacaoDAO = new OperacaoDAO();

        public fmBuscaOperacao()
        {
            InitializeComponent();
        }

        //LOAD
        private void FmBuscaOperacao_Load(object sender, EventArgs e) => BuscaOperacao();

        //KEYUP, KEYDOWN
        private void FmBuscaOperacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void CbAvista_Click(object sender, EventArgs e) => BuscaOperacao();
        private void CbAprazo_Click(object sender, EventArgs e) => BuscaOperacao();
        private void DgvOperacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvOperacao.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvOperacao.Rows[selectedRowIndex];
            operacaoSelecionada = operacaoDAO.BuscaByID(int.Parse(selectedRow.Cells[0].Value.ToString()));
            this.Close();
        }

        //TEXTCHANGED
        private void TbNomeOperacao_TextChanged(object sender, EventArgs e) => BuscaOperacao();

        //FUNÇÕES         
        private void BuscaOperacao()
        {
            dgvOperacao.Columns.Clear();

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Condição", typeof(string));
            table.Columns.Add("Desconto", typeof(string));
            table.Columns.Add("Entrada", typeof(string));

            string condicao = "";
            if (cbAprazo.Checked)
            {
                condicao = "AP";
            }
            if (cbAvista.Checked)
            {
                condicao = "AV";
            }
            if (cbAprazo.Checked && cbAvista.Checked)
            {
                condicao = "";
            }

            operacoes = operacaoDAO.Busca(tbNomeOperacao.Text, condicao).ToList();

            foreach (var o in operacoes)
            {
                table.Rows.Add(o.OperacaoID, o.Nome, o.Descricao, o.Condicao, o.Desconto, o.Entrada);
            }
            dgvOperacao.DataSource = table;

            funaux.TratarTamanhoColunas(dgvOperacao);
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
