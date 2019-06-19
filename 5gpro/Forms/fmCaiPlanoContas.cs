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
    public partial class fmCaiPlanoContas : Form
    {
        public fmCaiPlanoContas()
        {
            InitializeComponent();
        }

        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();

        private void Salva()
        {
            tvPlanoContas.Nodes.Add(tbDescricao.Text);
        }
    }
}
