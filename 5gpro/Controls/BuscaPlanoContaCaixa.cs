using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5gpro.Forms;
using _5gpro.Entities;
using _5gpro.Daos;

namespace _5gpro.Controls
{
    public partial class BuscaPlanoContaCaixa : UserControl
    {
        public PlanoConta conta = null;
        private readonly PlanoContaDAO planoContaDAO = new PlanoContaDAO();

        [Description("Texto do Label"), Category("Appearance")]
        public string LabelText
        {
            get
            {
                // Insert code here.
                return lbNome.Text;
            }
            set
            {
                lbNome.Text = value;
            }
        }

        public BuscaPlanoContaCaixa()
        {
            InitializeComponent();
        }

        private void BtBusca_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaContaCaixa();
        }

        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            //if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            //if (tbCodigo.Text.Length > 0)
            //{
            //    conta = planoContaDAO.BuscaByID(int.Parse(tbCodigoPessoa.Text));
            //    PreencheCamposPessoa(pessoa);
            //}
            //else
            //{
            //    pessoa = null;
            //    tbNomePessoa.Clear();
            //}
        }

        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void AbreTelaBuscaContaCaixa()
        {
            //var buscaContaCaixa = new fmBuscaContaCaixa();
            //buscaContaCaixa.ShowDialog();
            //if (buscaContaCaixa.contaSelecionada != null)
            //{
            //    conta = buscaContaCaixa.contaSelecionada;
            //    PreencheCamposContaCaixa(conta);
            //}
        }

        private void PreencheCamposContaCaixa(Pessoa pessoa)
        {
            //if (pessoa != null)
            //{
            //    tbCodigoPessoa.Text = pessoa.PessoaID.ToString();
            //    tbNomePessoa.Text = pessoa.Nome;
            //}
            //else
            //{
            //    MessageBox.Show("Cliente não encontrado no banco de dados",
            //    "Cliente não encontrado",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Warning);
            //    tbCodigoPessoa.Clear();
            //    tbCodigoPessoa.Focus();
            //    tbCodigoPessoa.SelectAll();
            //}
        }

        public void PreencheCampos(Pessoa pessoa)
        {
            //this.pessoa = pessoa;
            //tbCodigoPessoa.Text = this.pessoa != null ? this.pessoa.PessoaID.ToString() : "";
            //tbNomePessoa.Text = this.pessoa != null ? this.pessoa.Nome : "";
        }

        public void Limpa()
        {
            //tbCodigoPessoa.Clear();
            //tbNomePessoa.Clear();
            //pessoa = null;
        }


        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código da pessoa é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigo_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
