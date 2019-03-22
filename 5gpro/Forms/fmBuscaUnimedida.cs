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

            List<Unimedida> l = new List<Unimedida>();

            dgvUnimedida.ColumnCount = 3;
            dgvUnimedida.Columns[0].Name = "Código";
            dgvUnimedida.Columns[1].Name = "Sigla";
            dgvUnimedida.Columns[2].Name = "Descrição";

            var rows = new List<string[]>();
            List<Unimedida> lum = new List<Unimedida>();
            lum = new UnimedidaDAO().BuscarTodasUnimedidas();

            foreach (Unimedida unimedida in lum)
            {
                string[] row1 = new string[] { unimedida.Codigo.ToString(), unimedida.Sigla, unimedida.Descricao };
                rows.Add(row1);
            }

            foreach (string[] rowArray in rows)
            {
                dgvUnimedida.Rows.Add(rowArray);
            }


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
