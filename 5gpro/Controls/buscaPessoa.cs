using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Forms;
using System.ComponentModel;
using System.Windows.Forms;

namespace _5gpro.Controls
{
    public partial class buscaPessoa : UserControl
    {
        public Pessoa pessoa = new Pessoa();
        private int atuacao;
        public bool editando = false;

        PessoaBLL pessoaBLL = new PessoaBLL();

        [Description("Texto do Label"), Category("Appearance")]
        public string LabelText
        {
            get
            {
                // Insert code here.
                return lbPessoa.Text;
            }
            set
            {
                lbPessoa.Text = value;
                if(value == "Cliente")
                {
                    atuacao = 1;
                }
                else if (value == "Fornecedor")
                {
                    atuacao = 2;
                }
            }
        }

        public buscaPessoa()
        {
            InitializeComponent();
        }

        private void BtProcuraCliente_Click(object sender, System.EventArgs e)
        {
            AbreTelaBuscaPessoa();
        }

        private void TbCodigoPessoa_Leave(object sender, System.EventArgs e)
        {
            if (tbCodigoPessoa.Text.Length > 0)
            {
                pessoa = pessoaBLL.BuscarPessoaById(int.Parse(tbCodigoPessoa.Text));
                PreencheCamposPessoa(pessoa);
            }
            else
            {
                tbNomePessoa.Text = "";
            }
        }

        private void TbCodigoPessoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                AbreTelaBuscaPessoa();
            }
        }

        private void AbreTelaBuscaPessoa()
        {
            var buscaPessoa = new fmBuscaPessoa();
            buscaPessoa.ShowDialog();
            if (buscaPessoa.pessoaSelecionada != null)
            {
                pessoa = buscaPessoa.pessoaSelecionada;
                PreencheCamposPessoa(pessoa);
            }
        }

        private void PreencheCamposPessoa(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                tbCodigoPessoa.Text = pessoa.PessoaID.ToString();
                tbNomePessoa.Text = pessoa.Nome;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado no banco de dados",
                "Cliente não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigoPessoa.Clear();
                tbCodigoPessoa.Focus();
                tbCodigoPessoa.SelectAll();
            }
        }

        public void Editando(bool edit)
        {
            editando = edit;
        }
    }
}
