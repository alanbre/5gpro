using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaCidade : Form, IMessageFilter
    {
        public Cidade Cidade;
        public Estado Estado;
        private CidadeBLL cidadeBLL = new CidadeBLL();
        private EstadoBLL estadoBLL = new EstadoBLL();

        public fmBuscaCidade()
        {
            InitializeComponent();
            Application.AddMessageFilter(this); // código para trocar o enter por tab
            tbFiltroCodEstado.Focus();
        }

        //Continuação do código para trocar o enter por tab
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x100)//WM_KEYDOWN
            {
                if (m.WParam.ToInt32() == 0xd)//VK_RETURN = 0xd
                {
                    if (this.ActiveControl is TextBox || this.ActiveControl is RadioButton || this.ActiveControl is MaskedTextBox)
                    {
                        SendKeys.Send("{TAB}");
                        return true; //Discard the Enter key
                    }
                }
            }
            return false;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //Cidade = cidadeBLL.BuscaCidadeByCod("4328");
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Código do estado", typeof(string));
            foreach (Cidade c in cidadeBLL.BuscaCidadesByCodEstado(tbFiltroCodEstado.Text))
            {
                table.Rows.Add(c.CodCidade, c.Nome, c.CodEstado);
            }
            dgvCidades.DataSource = table;
        }

        private void btProcuraEstado_Click(object sender, EventArgs e)
        {
            var buscaEstado = new fmBuscaEstado();
            buscaEstado.ShowDialog();
        }

        private void tbFiltroCodEstado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                var buscaEstado = new fmBuscaEstado();
                buscaEstado.ShowDialog();
            }

        }

        private void tbFiltroCodEstado_Leave(object sender, EventArgs e)
        {
            if (tbFiltroCodEstado.Text.Length > 0)
            {
                Estado = estadoBLL.BuscaEstadoByCod(tbFiltroCodEstado.Text);
                tbNomeEstado.Text = Estado.Nome;
            }
            else
            {
                tbFiltroCodEstado.Text = "";
            }
        }

        private void tbFiltroCodEstado_Enter(object sender, EventArgs e)
        {
            tbFiltroCodEstado.SelectAll();
        }

        private void dgvCidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvCidades.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCidades.Rows[selectedRowIndex];
            Cidade = new Cidade();
            Cidade.CodCidade = Convert.ToString(selectedRow.Cells[0].Value);
            Cidade.Nome = Convert.ToString(selectedRow.Cells[1].Value);
            Cidade.CodEstado = Convert.ToString(selectedRow.Cells[2].Value);
            this.Close();
        }
    }
}
