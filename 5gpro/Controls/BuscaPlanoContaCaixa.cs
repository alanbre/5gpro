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
        private bool entrada;
        private bool saida;

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

        [Description("Entrada"), Category("Appearance")]
        public bool Entrada
        {
            get
            {
                return entrada;
            }
            set
            {
                entrada = value;
            }
        }

        [Description("Saida"), Category("Appearance")]
        public bool Saida
        {
            get
            {
                return saida;
            }
            set
            {
                saida = value;
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
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (tbCodigo.Text.Length > 0)
            {
                conta = planoContaDAO.BuscaByID(int.Parse(tbCodigo.Text));
                PreencheCamposContaCaixa(conta);
            }
            else
            {
                conta = null;
                tbNome.Clear();
            }
        }

        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void AbreTelaBuscaContaCaixa()
        {
            var buscaContaCaixa = new fmBuscaContaCaixa();
            buscaContaCaixa.ShowDialog();
            if (buscaContaCaixa.planoContaSelecionada != null)
            {
                conta = buscaContaCaixa.planoContaSelecionada;
                PreencheCamposContaCaixa(conta);
            }
        }

        private void PreencheCamposContaCaixa(PlanoConta conta)
        {
            if (conta != null)
            {
                tbCodigo.Text = conta.PlanoContaID.ToString();
                tbNome.Text = conta.Descricao;
            }
            else
            {
                MessageBox.Show("Conta não encontrada no banco de dados",
                "Conta não encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigo.Clear();
                tbCodigo.Focus();
                tbCodigo.SelectAll();
            }
        }

        public void PreencheCampos(PlanoConta conta)
        {
            this.conta = conta;
            tbCodigo.Text = this.conta != null ? this.conta.PlanoContaID.ToString() : "";
            tbNome.Text = this.conta != null ? this.conta.Descricao : "";
        }

        public void Limpa()
        {
            tbCodigo.Clear();
            tbNome.Clear();
            conta = null;
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
