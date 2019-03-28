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
            tbSenhaUsuario.PasswordChar = '*';
            tbConfirmaSenhaUsuario.PasswordChar = '*';

        }

        private void tbNomeGrupoUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
