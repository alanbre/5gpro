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

        public formCadastroPessoas()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pessoa.Codigo = tbCodigo.Text;
            pessoa.Nome = tbNome.Text;
            pessoa.Fantasia = tbFantasia.Text;
            foreach(string s in cblAtuacao.CheckedItems)
            {
                Console.WriteLine(s[0]);
            }
           // pessoa.Atuacao = cblAtuacao.SelectedItems.ToString;
        }
    }
}
