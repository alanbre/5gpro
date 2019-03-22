using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmLogin : Form, IMessageFilter
    {
        public Usuario usuario;
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        public fmLogin()
        {
            InitializeComponent();
            Application.AddMessageFilter(this); // código para trocar o enter por tab
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

        private void btEntrar_Click(object sender, EventArgs e)
        {
            usuario = usuarioBLL.Logar(tbLogin.Text, tbSenha.Text);
            if (usuario.Codigo != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Login e senha inválidos",
                "Login mal sucessido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbLogin.Focus();
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            tbLogin.SelectAll();
        }

        private void tbSenha_Enter(object sender, EventArgs e)
        {
            tbSenha.SelectAll();
        }
    }
}
