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
    public partial class fmBuscaEstado : Form, IMessageFilter
    {
        public fmBuscaEstado()
        {
            InitializeComponent();
            Application.AddMessageFilter(this); // código para trocar o enter por tab
            tbFiltroNomeCidade.Focus();
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
            //busca e preenche os estados no grid
        }
    }
}
