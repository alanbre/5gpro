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
    public partial class fmCadastroUsuario : Form
    {
        public fmCadastroUsuario()
        {
            InitializeComponent();
            tbSenhaUsuario.UseSystemPasswordChar = true;
            tbConfirmaSenhaUsuario.UseSystemPasswordChar = true;

        }

        private void tbNomeGrupoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMostrarSenhaUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenhaUsuario.Checked)
            {
                tbSenhaUsuario.UseSystemPasswordChar = false;
                tbConfirmaSenhaUsuario.UseSystemPasswordChar = false;
            }
            else
            {
                tbSenhaUsuario.UseSystemPasswordChar = true;
                tbConfirmaSenhaUsuario.UseSystemPasswordChar = true;
            }
            
        }
    }
}
