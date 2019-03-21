using _5gpro.Entities;
using _5gpro.Bll;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaCidade : Form, IMessageFilter
    {
        public Cidade Cidade;
        private CidadeBLL cidadeBLL = new CidadeBLL();
        
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
            Cidade = cidadeBLL.BuscaCidadeByCod("4328");
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


    }
}
