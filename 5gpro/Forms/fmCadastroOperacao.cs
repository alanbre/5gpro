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
    public partial class fmCadastroOperacao : Form
    {
        public fmCadastroOperacao()
        {
            InitializeComponent();
            RemoverTabs();
        }

        public void MudarOpcao()
        {
            tcOpcoes.TabPages.Remove(tpAvista);
        }

        private void RemoverTabs()
        {
            tcOpcoes.TabPages.Remove(tpAvista);
            tcOpcoes.TabPages.Remove(tpAprazo);
        }

        private void RbAvista_CheckedChanged(object sender, EventArgs e)
        {
            tcOpcoes.TabPages.Remove(tpAvista);
            tcOpcoes.TabPages.Remove(tpAprazo);
            tcOpcoes.TabPages.Add(tpAvista);
        }

        private void RbAprazo_CheckedChanged(object sender, EventArgs e)
        {
            tcOpcoes.TabPages.Remove(tpAvista);
            tcOpcoes.TabPages.Remove(tpAprazo);
            tcOpcoes.TabPages.Add(tpAprazo);
        }


        private void RbSim_CheckedChanged(object sender, EventArgs e)
        {
            tbEntrada.Enabled = true;
        }

        private void RbNao_CheckedChanged(object sender, EventArgs e)
        {
            tbEntrada.Enabled = false;
            tbEntrada.Text = "";
        }

        private void BtDias_Click(object sender, EventArgs e)
        {
            var fmdiasavencer = new fmDiasAVencer();
            fmdiasavencer.Show(this);
        }

    }
}
