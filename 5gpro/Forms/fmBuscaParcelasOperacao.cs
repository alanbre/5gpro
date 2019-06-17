using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaParcelasOperacao : Form
    {

        List<ParcelaOperacao> listaparcelasbusca = new List<ParcelaOperacao>();
        public fmCadastroOperacao telacadoperacao;
        string diasalvo;

        public fmBuscaParcelasOperacao(List<ParcelaOperacao> lista, fmCadastroOperacao cadoperacao)
        {
            InitializeComponent();
            listaparcelasbusca = lista;
            BuscaParcelas();
            telacadoperacao = cadoperacao;
        }

        private void FmBuscaParcelasOperacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void BtAplicar_Click(object sender, EventArgs e)
        {
            EditarDias();
        }
        private void DgvParcelasOperacao_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!int.TryParse(dgvParcelasOperacao.CurrentRow.Cells[1].Value.ToString(), out int codigo)
                || string.IsNullOrWhiteSpace(dgvParcelasOperacao.CurrentRow.Cells[1].Value.ToString()))
            {
                dgvParcelasOperacao.CurrentRow.Cells[1].Value = diasalvo;
            }

            if (!dgvParcelasOperacao.CurrentRow.Cells[1].Value.ToString().Equals(diasalvo))
            {
                listaparcelasbusca.Find(p => p.Numero == int.Parse(dgvParcelasOperacao.CurrentRow.Cells[0].Value.ToString())).Dias = int.Parse(dgvParcelasOperacao.CurrentRow.Cells[1].Value.ToString());
                telacadoperacao.Dias_Changed();
            }
        }
        private void DgvParcelasOperacao_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            diasalvo = dgvParcelasOperacao.CurrentRow.Cells[1].Value.ToString();
        }


        private void EditarDias()
        {

            if (int.TryParse(tbDias.Text, out int codigo))
            {
                foreach (ParcelaOperacao p in listaparcelasbusca)
                {
                    p.Dias = p.Numero * int.Parse(tbDias.Text);
                }
                BuscaParcelas();
                telacadoperacao.Dias_Changed();
            }
            else
            {
                tbDias.Clear();
                MessageBox.Show("Apenas números", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuscaParcelas()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Parcela", typeof(string));
            table.Columns.Add("Dias", typeof(string));

            foreach (ParcelaOperacao p in listaparcelasbusca)
            {
                table.Rows.Add(p.Numero, p.Dias);
            }
            dgvParcelasOperacao.DataSource = table;
            dgvParcelasOperacao.Columns["Parcela"].ReadOnly = true;

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
