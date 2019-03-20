using _5gpro.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();

        }

        private void cadastrosDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroPessoas formCadPessoas = new formCadastroPessoas();
            formCadPessoas.Show();
        }
    }
}
