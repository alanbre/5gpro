using _5gpro.Forms;
using System;
using System.Windows.Forms;

namespace _5gpro
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();

        }

        private void tsmiCadastroPessoas_Click(object sender, EventArgs e)
        {
            var formCadPessoas = new fmCadastroPessoa();
            formCadPessoas.Show();
        }

        private void tsmiCadastroPaises_Click(object sender, EventArgs e)
        {
            var formCadPais = new fmCadastroPais();
            formCadPais.Show(this);
        }

        private void tsmiCadastroItens_Click(object sender, EventArgs e)
        {
            var formCadItens = new fmCadastroItens();
            formCadItens.Show(this);
        }

        private void tsmiCadastroOrcamentos_Click(object sender, EventArgs e)
        {
            var formCadOrcamentos = new fmCadastroOrcamento();
            formCadOrcamentos.Show(this);
        }
    }
}
