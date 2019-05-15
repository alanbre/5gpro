using System;
using System.Windows.Forms;
using _5gpro.Forms;
using _5gpro.Entities;
using System.ComponentModel;
using _5gpro.Daos;

namespace _5gpro.Controls
{
    public partial class BuscaOperacao : UserControl
    {
        public Operacao operacao;
        private readonly OperacaoDAO operacaoDAO = new OperacaoDAO();

        public BuscaOperacao()
        {
            InitializeComponent();
        }

        private void TbCodigoOperacao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaOperacao();
            }
        }

        private void TbCodigoOperacao_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigoOperacao.Text, out int codigo)) { tbCodigoOperacao.Clear(); }
            if (tbCodigoOperacao.Text.Length > 0)
            {
                operacao = operacaoDAO.BuscaById(int.Parse(tbCodigoOperacao.Text));
                PreencheCamposOperacao(operacao);
            }
            else
            {
                operacao = null;
                tbNomeOperacao.Clear();
            }
        }

        private void BtBuscaOperacao_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaOperacao();
        }



        private void AbreTelaBuscaOperacao()
        {
            var buscaOperacao = new fmBuscaOperacao();
            buscaOperacao.ShowDialog();
            if (buscaOperacao.operacaoSelecionada != null)
            {
                operacao = buscaOperacao.operacaoSelecionada;
                PreencheCamposOperacao(operacao);
            }
        }

        private void PreencheCamposOperacao(Operacao operacao)
        {
            if (operacao != null)
            {
                tbCodigoOperacao.Text = operacao.OperacaoID.ToString();
                tbNomeOperacao.Text = operacao.Nome;
            }
            else
            {
                MessageBox.Show("Operação não encontrada na base de dados",
                "Operação não encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigoOperacao.Clear();
                tbCodigoOperacao.Focus();
                tbCodigoOperacao.SelectAll();
            }
        }

        public void PreencheCampos(Operacao operacao)
        {
            this.operacao = operacao;
            tbCodigoOperacao.Text = this.operacao != null ? operacao.OperacaoID.ToString() : "";
            tbNomeOperacao.Text = this.operacao != null ? this.operacao.Nome : "";
        }

        public void Limpa()
        {
            tbCodigoOperacao.Clear();
            tbNomeOperacao.Clear();
            operacao = null;
        }









        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código da pessoa é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoOperacao_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
