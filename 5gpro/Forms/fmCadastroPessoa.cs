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
    public partial class fmCadastroPessoa : Form, IMessageFilter
    {
        Pessoa pessoa = new Pessoa();
        bool editando = false;

        public fmCadastroPessoa()
        {
            InitializeComponent();
            Application.AddMessageFilter(this); // código para trocar o enter por tab
            AlteraBotoes();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Clear();
            mtbCpfCnpj.Mask = "###.###.###-##";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Clear();
            mtbCpfCnpj.Mask = "##.###.###/####-##";
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                if(MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    editando = true;
                    NovoRegistro();
                    tbCodigo.Focus();
                }
                else
                {

                }
            }
            else
            {
                tbCodigo.Focus();
                editando = true;
            }
            AlteraBotoes();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            pessoa.Codigo = tbCodigo.Text;
            pessoa.Nome = tbNome.Text;
            pessoa.Fantasia = tbFantasia.Text;
            foreach (string s in cblAtuacao.CheckedItems)
            {
                pessoa.Atuacao.Add(s);
            }
            pessoa.TipoPessoa = rbPessoaFisica.Checked ? "F" : "J";
            pessoa.Rua = tbRua.Text;
            pessoa.Numero = tbNumero.Text;
            pessoa.Bairro = tbBairro.Text;
            pessoa.Complemento = tbComplemento.Text;
            pessoa.Cidade = tbCodCidade.Text;
            pessoa.CpfCnpj = mtbCpfCnpj.Text;
            pessoa.Telefone = mtbTelefone.Text;
            pessoa.Email = tbEmail.Text;
        }

        private void AlteraBotoes()
        {
            if (editando)
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_black;
                btNovo.Enabled = false;
                btSalvar.Image = Properties.Resources.iosOk_48px_Green;
                btSalvar.Enabled = true;
                btBuscar.Image = Properties.Resources.iosSearch_48px_black;
                btBuscar.Enabled = false;
                btDeletar.Image = Properties.Resources.iosDelete_48px_black;
                btDeletar.Enabled = false;
            }
            else
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_blue;
                btNovo.Enabled = true;
                btSalvar.Image = Properties.Resources.iosOk_48px_black;
                btSalvar.Enabled = false;
                btBuscar.Image = Properties.Resources.iosSearch_48px_Blue;
                btBuscar.Enabled = true;
                btDeletar.Image = Properties.Resources.iosDelete_48px_Red;
                btDeletar.Enabled = false;
            } 
        }

        private void NovoRegistro()
        {
            LimpaCampos(true);
        }

        private void LimpaCampos(bool cod)
        {
            if (cod) { tbCodigo.Clear(); }
            tbNome.Clear();
            tbFantasia.Clear();
            tbRua.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbComplemento.Clear();
            tbCodCidade.Clear();
            tbNomeCidade.Clear();
            mtbCpfCnpj.Clear();
            mtbTelefone.Clear();
            tbEmail.Clear();
            foreach (int i in cblAtuacao.CheckedIndices)
            {
                cblAtuacao.SetItemCheckState(i, CheckState.Unchecked);
            }
            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            if (pessoa.Codigo == null)
            {
                editando = tbCodigo.Text.Length > 0 ? true : false;
                LimpaCampos(false);
                AlteraBotoes();
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    editando = true;
                    NovoRegistro();
                }
            }
        }

        private void btBuscaCidade_Click(object sender, EventArgs e)
        {
            var buscaCidade = new fmBuscaCidade();
            buscaCidade.ShowDialog();
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            editando = true;
            AlteraBotoes();
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

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {

            }
        }

        private void btRight_Click(object sender, EventArgs e)
        {

        }

        private void btLeft_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            var buscaPessoa = new fmBuscaPessoa();
            buscaPessoa.ShowDialog();
        }

        private void tbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                var buscaPessoa = new fmBuscaPessoa();
                buscaPessoa.ShowDialog();
            }
        }
    }
}
