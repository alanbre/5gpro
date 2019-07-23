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
    public partial class fmDecimal : Form
    {
        public decimal fmdecimalvalor;
        private Form telarecebida;
        public fmDecimal(string Label, Form tela)
        {
            InitializeComponent();
            lbDescDecimal.Text = Label;
            telarecebida = tela;
        }
        
        public void PegarValor()
        {
            fmdecimalvalor = dbValor.Valor;
            this.Dispose();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            PegarValor();
        }
    }
}
