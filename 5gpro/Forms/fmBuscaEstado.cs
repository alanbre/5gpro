using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaEstado : Form, IMessageFilter
    {
        public Estado Estado;
        private EstadoBLL estadoBLL = new EstadoBLL();


        public fmBuscaEstado()
        {
            InitializeComponent();
            Application.AddMessageFilter(this); // código para trocar o enter por tab
            tbFiltroNomeEstado.Focus();
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
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            foreach (Estado estado in estadoBLL.BuscaEstadoByNome(tbFiltroNomeEstado.Text))
            {
                table.Rows.Add(estado.CodEstado, estado.Nome);
            }
            dgvEstados.DataSource = table;
        }

        private void dgvEstados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvEstados.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvEstados.Rows[selectedRowIndex];
            Estado = new Estado();
            Estado.CodEstado = Convert.ToString(selectedRow.Cells[0].Value);
            Estado.Nome = Convert.ToString(selectedRow.Cells[1].Value);
            this.Close();
        }
    }
}
