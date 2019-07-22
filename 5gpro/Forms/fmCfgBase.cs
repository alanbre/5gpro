using _5gpro.Funcoes;
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
    public partial class fmCfgBase : Form
    {
        public fmCfgBase()
        {
            InitializeComponent();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtConfirmar_Click(object sender, EventArgs e)
        {
            DadosEstaticos.SalvaDadoEstatico("Base de dados", "ip", tbIp.Text);
            DadosEstaticos.SalvaDadoEstatico("Base de dados", "usuario", tbUsuario.Text);
            DadosEstaticos.SalvaDadoEstatico("Base de dados", "senha", tbSenha.Text);
            this.Close();
        }
    }
}
