using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaPessoa : UserControl
    {
        public Pessoa pessoa = new Pessoa();
        public int atuacao; //será utilizado para filtrar só fornecedor ou só cliente

        private readonly PessoaBLL pessoaBLL = new PessoaBLL();

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



        public BuscaPessoa()
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
                pessoa = null;
                tbNomePessoa.Text = "";
            }
        }

        private void TbCodigoPessoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
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

        public void PreencheCampos(Pessoa pessoa)
        {
            this.pessoa = pessoa;
            tbCodigoPessoa.Text = this.pessoa != null ? this.pessoa.PessoaID.ToString() : "";
            tbNomePessoa.Text = this.pessoa != null ? this.pessoa.Nome : "";
        }

        public void Limpa()
        {
            tbCodigoPessoa.Clear();
            tbNomePessoa.Clear();
            pessoa = null;
        }





        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código da pessoa é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoPessoa_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
