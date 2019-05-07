using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmTroco : Form
    {
        private readonly static ConexaoDAO connection = new ConexaoDAO();
        private readonly FormaPagamentoDAO formaPagamentoDAO = new FormaPagamentoDAO(connection);
        private List<FormaPagamento> formasPagamento = new List<FormaPagamento>();

        private decimal total = 0.00m;


        public fmTroco()
        {
            InitializeComponent();
        }

        private void FmTroco_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }
        private void TbCodigoFormaPagamento1_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento1, tbNomeFormaPagamento1, e);
        private void TbCodigoFormaPagamento2_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento2, tbNomeFormaPagamento2, e);
        private void TbCodigoFormaPagamento3_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento3, tbNomeFormaPagamento3, e);
        private void TbCodigoFormaPagamento4_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento4, tbNomeFormaPagamento4, e);
        private void TbCodigoFormaPagamento5_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento5, tbNomeFormaPagamento5, e);
        private void TbCodigoFormaPagamento6_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento6, tbNomeFormaPagamento6, e);
        private void TbCodigoFormaPagamento7_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento7, tbNomeFormaPagamento7, e);
        private void TbCodigoFormaPagamento1_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento1, tbNomeFormaPagamento1);
        private void TbCodigoFormaPagamento2_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento2, tbNomeFormaPagamento2);
        private void TbCodigoFormaPagamento3_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento3, tbNomeFormaPagamento3);
        private void TbCodigoFormaPagamento4_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento4, tbNomeFormaPagamento4);
        private void TbCodigoFormaPagamento5_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento5, tbNomeFormaPagamento5);
        private void TbCodigoFormaPagamento6_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento6, tbNomeFormaPagamento6);
        private void TbCodigoFormaPagamento7_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento7, tbNomeFormaPagamento7);
        private void TbPagamento1_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalPagamento();
        }
        private void TbPagamento2_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalPagamento();
        }
        private void TbPagamento3_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalPagamento();
        }
        private void TbPagamento4_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalPagamento();
        }
        private void TbPagamento5_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalPagamento();
        }
        private void TbPagamento6_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalPagamento();
        }
        private void TbPagamento7_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalPagamento();
        }



        private void AtalhoAbreBuscaFormaPagamento(TextBox codigo, TextBox nome, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaFormaPagamento(codigo, nome);
            }
        }
        private void AbreTelaBuscaFormaPagamento(TextBox codigo, TextBox nome)
        {
            var buscaFormaPagamento = new fmBuscaFormaPagamento();
            buscaFormaPagamento.ShowDialog();
            if (buscaFormaPagamento.formapagamentoSelecionada != null)
            {
                PreencheCamposFormaPagamento(buscaFormaPagamento.formapagamentoSelecionada, codigo, nome);
            }
        }
        private void BuscaFormaPagamento(TextBox codigo, TextBox nome)
        {
            int id = 0;
            if (!int.TryParse(codigo.Text, out id)) { codigo.Clear(); nome.Clear(); }
            var formaPagamento = formaPagamentoDAO.BuscarByID(id);
            if (formaPagamento != null)
            {
                PreencheCamposFormaPagamento(formaPagamento, codigo, nome);
            }
            else
            {
                LimpaFormaPagamento(codigo, nome);
            }
        }
        private void PreencheCamposFormaPagamento(FormaPagamento formaPagamento, TextBox codigo, TextBox nome)
        {
            codigo.Text = formaPagamento.FormaPagamentoID.ToString();
            nome.Text = formaPagamento.Nome;
        }
        private void LimpaFormaPagamento(TextBox codigo, TextBox nome)
        {
            codigo.Clear();
            nome.Clear();
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }




        private void FormataCampoDecimal(TextBox sender)
        {
            sender.Text = sender.Text.Length > 0 ? Convert.ToDecimal(sender.Text).ToString("############0.00") : "";
        }
        private void CalculaTotalPagamento()
        {
            total = 0.00m;
            total += dbPagamento1.Valor;
            total += dbPagamento2.Valor;
            total += dbPagamento3.Valor;
            total += dbPagamento4.Valor;
            total += dbPagamento5.Valor;
            total += dbPagamento6.Valor;
            total += dbPagamento7.Valor;
            lbValorTroco.Text = total.ToString("R$ ############0.00");
            lbValorTroco.ForeColor = (total - Decimal.Parse(lbValorTotal.Text.Substring(2))) < 0 ? System.Drawing.Color.Red : System.Drawing.Color.Green;
        }
    }
}
