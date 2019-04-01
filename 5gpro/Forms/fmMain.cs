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
            formCadPessoas.Show(this);
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
            var formOrcamentoCadOrcamentos = new fmOrcamentoCadastroOrcamento();
            formOrcamentoCadOrcamentos.Show(this);
        }

        private void tsmiCadastroUsuariosMenuItem_Click(object sender, EventArgs e)
        {
            var formCadUsuarios = new fmCadastroUsuario();
            formCadUsuarios.Show(this);
        }

        private void tsmiEntradaDoc_Click(object sender, EventArgs e)
        {
            var formEstoqueEntradaDocumentos = new fmEstoqueEntradaDocumentos();
            formEstoqueEntradaDocumentos.Show(this);
        }
    }
}
