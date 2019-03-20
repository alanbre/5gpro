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
    public partial class formCadastroPessoas : Form
    {
        Pessoa pessoa = new Pessoa();
        bool editando = false;

        public formCadastroPessoas()
        {
            InitializeComponent();
            AlteraBotoes();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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
                }
            }
            else
            {
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
            }
            else
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_blue;
            } 
        }

        private void NovoRegistro()
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is MaskedTextBox)
                    {
                        (control as MaskedTextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
            };
            foreach (int i in cblAtuacao.CheckedIndices)
            {
                cblAtuacao.SetItemCheckState(i, CheckState.Unchecked);
            }
            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;

            func(Controls);
        }
    }
}
