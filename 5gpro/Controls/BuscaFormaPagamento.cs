using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaFormaPagamento : UserControl
    {
        public FormaPagamento formaPagamento = new FormaPagamento();
        private static ConexaoDAO conexao = new ConexaoDAO();
        private readonly FormaPagamentoDAO formaPagamentoDAO = new FormaPagamentoDAO(conexao);

        public BuscaFormaPagamento()
        {
            InitializeComponent();
        }

        private void TbCodigoFormaPagamento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaFormaPagamento();
            }
        }

        private void TbCodigoFormaPagamento_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigoFormaPagamento.Text, out int codigo)) { tbCodigoFormaPagamento.Clear(); }
            if (tbCodigoFormaPagamento.Text.Length > 0)
            {
                formaPagamento = formaPagamentoDAO.BuscarByID(int.Parse(tbCodigoFormaPagamento.Text));
                PreencheCamposFormaPagamento(formaPagamento);
            }
            else
            {
                formaPagamento = null;
                tbNomeFormaPagamento.Clear();
            }
        }

        private void BtBuscaFormaPagamento_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaFormaPagamento();
        }


        private void AbreTelaBuscaFormaPagamento()
        {
            var buscaFormaPagamento = new fmBuscaFormaPagamento();
            buscaFormaPagamento.ShowDialog();
            if (buscaFormaPagamento.formapagamentoSelecionada != null)
            {
                formaPagamento = buscaFormaPagamento.formapagamentoSelecionada;
                PreencheCamposFormaPagamento(formaPagamento);
            }
        }

        private void PreencheCamposFormaPagamento(FormaPagamento formaPagamento)
        {
            if (formaPagamento != null)
            {
                tbCodigoFormaPagamento.Text = formaPagamento.FormaPagamentoID.ToString();
                tbNomeFormaPagamento.Text = formaPagamento.Nome;
            }
            else
            {
                MessageBox.Show("Forma de pagamento não encontrada no banco de dados",
                "Forma de pagamento não encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigoFormaPagamento.Clear();
                tbCodigoFormaPagamento.Focus();
                tbCodigoFormaPagamento.SelectAll();
            }
        }

        public void PreencheCampos(FormaPagamento formaPagamento)
        {
            this.formaPagamento = formaPagamento;
            tbCodigoFormaPagamento.Text = this.formaPagamento != null ? formaPagamento.FormaPagamentoID.ToString() : "";
            tbNomeFormaPagamento.Text = this.formaPagamento != null ? this.formaPagamento.Nome : "";
        }

        public void Limpa()
        {
            tbCodigoFormaPagamento.Clear();
            tbNomeFormaPagamento.Clear();
            formaPagamento = null;
        }


        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código da pessoa é alterado")]
        public event text_changedEventHandler Text_Changed;

        //--------------------------------------------------


        private void TbCodigoFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }

    }
}
