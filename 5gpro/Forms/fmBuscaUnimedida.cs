using _5gpro.Bll;
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
    public partial class fmBuscaUnimedida : Form, IMessageFilter
    {

        public List<Unimedida> Listaunimedida;
        public Unimedida Unimedida;
        private UnimedidaBLL unimedidaBLL = new UnimedidaBLL();

        //Unimedida unimedida = new Unimedida();


        public fmBuscaUnimedida()
        {
            InitializeComponent();
            Application.AddMessageFilter(this); // código para trocar o enter por tab
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

        private void dgvUnimedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void btPesquisar_Click(object sender, EventArgs e)
        {

        }

        //Buscando todas Unimedidas do banco
        private void fmBuscaUnimedida_Load(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Sigla", typeof(string));
            table.Columns.Add("Descrição", typeof(string));


            Listaunimedida = unimedidaBLL.BuscarTodasUnimedidas();

            foreach (Unimedida u in Listaunimedida)
            {
                table.Rows.Add(u.Codigo, u.Sigla, u.Descricao);
            }
            dgvUnimedida.DataSource = table;

        }

        private void dgvUnimedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvUnimedida.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvUnimedida.Rows[selectedRowIndex];
            Unimedida = new Unimedida();
            Unimedida.Codigo = int.Parse(selectedRow.Cells[0].Value.ToString());
            Unimedida.Sigla = Convert.ToString(selectedRow.Cells[1].Value);
            Unimedida.Descricao = Convert.ToString(selectedRow.Cells[2].Value);
            this.Close();
        }
    }
}
