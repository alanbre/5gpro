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
    public partial class fmCaiBuscaLancamentos : Form
    {
        public fmCaiBuscaLancamentos()
        {
            InitializeComponent();
        }

        public struct Filtros
        {
            public DateTime DataInicial;
            public DateTime DataFinal;
            public Caixa caixa;
            public PlanoConta planoConta;
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
