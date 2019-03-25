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
    public partial class fmBuscaPessoa : Form
    {
        public fmBuscaPessoa()
        {
            InitializeComponent();
        }

        private void btBuscaCidade_Click(object sender, EventArgs e)
        {
            var buscaCidade = new fmBuscaCidade();
            buscaCidade.ShowDialog();
        }

        private void tbCodCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                var buscaCidade = new fmBuscaCidade();
                buscaCidade.ShowDialog();
            }
        }
    }
}
