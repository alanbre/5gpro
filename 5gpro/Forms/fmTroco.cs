using _5gpro.Controls;
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
        public List<Tuple<FormaPagamento, decimal>> formasPagamento = new List<Tuple<FormaPagamento, decimal>>();
        public bool pago = false;

        private decimal totalPago = 0.00m;
        private decimal totalAPagar = 0.00m;
        private int codigoAtual = 0;


        public fmTroco(decimal valorAPagar)
        {
            InitializeComponent();
            this.totalAPagar = valorAPagar;
            lbValorTotal.Text = this.totalAPagar.ToString();
            CalculaTotalPagamento();
        }

        private void FmTroco_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void TbCodigoFormaPagamento1_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento1, tbNomeFormaPagamento1, e);
        private void TbCodigoFormaPagamento2_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento2, tbNomeFormaPagamento2, e);
        private void TbCodigoFormaPagamento3_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento3, tbNomeFormaPagamento3, e);
        private void TbCodigoFormaPagamento4_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento4, tbNomeFormaPagamento4, e);
        private void TbCodigoFormaPagamento5_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento5, tbNomeFormaPagamento5, e);
        private void TbCodigoFormaPagamento6_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento6, tbNomeFormaPagamento6, e);
        private void TbCodigoFormaPagamento7_KeyUp(object sender, KeyEventArgs e) => AtalhoAbreBuscaFormaPagamento(tbCodigoFormaPagamento7, tbNomeFormaPagamento7, e);
        private void TbCodigoFormaPagamento1_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento1, tbNomeFormaPagamento1, dbPagamento1);
        private void TbCodigoFormaPagamento2_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento2, tbNomeFormaPagamento2, dbPagamento2);
        private void TbCodigoFormaPagamento3_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento3, tbNomeFormaPagamento3, dbPagamento3);
        private void TbCodigoFormaPagamento4_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento4, tbNomeFormaPagamento4, dbPagamento4);
        private void TbCodigoFormaPagamento5_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento5, tbNomeFormaPagamento5, dbPagamento5);
        private void TbCodigoFormaPagamento6_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento6, tbNomeFormaPagamento6, dbPagamento6);
        private void TbCodigoFormaPagamento7_Leave(object sender, EventArgs e) => BuscaFormaPagamento(tbCodigoFormaPagamento7, tbNomeFormaPagamento7, dbPagamento7);
        private void DbPagamento1_Leave(object sender, EventArgs e) => CalculaTotalPagamento(tbCodigoFormaPagamento1, dbPagamento1);        
        private void DbPagamento2_Leave(object sender, EventArgs e) => CalculaTotalPagamento(tbCodigoFormaPagamento2, dbPagamento2);
        private void DbPagamento3_Leave(object sender, EventArgs e) => CalculaTotalPagamento(tbCodigoFormaPagamento3, dbPagamento3);
        private void DbPagamento4_Leave(object sender, EventArgs e) => CalculaTotalPagamento(tbCodigoFormaPagamento4, dbPagamento4);
        private void DbPagamento5_Leave(object sender, EventArgs e) => CalculaTotalPagamento(tbCodigoFormaPagamento5, dbPagamento5);
        private void DbPagamento6_Leave(object sender, EventArgs e) => CalculaTotalPagamento(tbCodigoFormaPagamento6, dbPagamento6);
        private void DbPagamento7_Leave(object sender, EventArgs e) => CalculaTotalPagamento(tbCodigoFormaPagamento7, dbPagamento7);
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (totalPago < totalAPagar)
            {
                MessageBox.Show("O valor pago é menor que o valor cobrado.", "Pagamento menor que a cobrança", MessageBoxButtons.OK);
                return;
            }
            pago = true;

            if (tbCodigoFormaPagamento1.Text.Length > 0 && dbPagamento1.Valor > 0)
            {
                var vp = formaPagamentoDAO.BuscarByID(int.Parse(tbCodigoFormaPagamento1.Text));
                var forma = new Tuple<FormaPagamento, decimal>(vp, dbPagamento1.Valor);
                formasPagamento.Add(forma);
            }
            if (tbCodigoFormaPagamento2.Text.Length > 0 && dbPagamento2.Valor > 0)
            {
                var vp = formaPagamentoDAO.BuscarByID(int.Parse(tbCodigoFormaPagamento2.Text));
                var forma = new Tuple<FormaPagamento, decimal>(vp, dbPagamento2.Valor);
                formasPagamento.Add(forma);
            }
            if (tbCodigoFormaPagamento3.Text.Length > 0 && dbPagamento3.Valor > 0)
            {
                var vp = formaPagamentoDAO.BuscarByID(int.Parse(tbCodigoFormaPagamento1.Text));
                var forma = new Tuple<FormaPagamento, decimal>(vp, dbPagamento3.Valor);
                formasPagamento.Add(forma);
            }
            if (tbCodigoFormaPagamento4.Text.Length > 0 && dbPagamento4.Valor > 0)
            {
                var vp = formaPagamentoDAO.BuscarByID(int.Parse(tbCodigoFormaPagamento4.Text));
                var forma = new Tuple<FormaPagamento, decimal>(vp, dbPagamento4.Valor);
                formasPagamento.Add(forma);
            }
            if (tbCodigoFormaPagamento5.Text.Length > 0 && dbPagamento5.Valor > 0)
            {
                var vp = formaPagamentoDAO.BuscarByID(int.Parse(tbCodigoFormaPagamento5.Text));
                var forma = new Tuple<FormaPagamento, decimal>(vp, dbPagamento5.Valor);
                formasPagamento.Add(forma);
            }
            if (tbCodigoFormaPagamento6.Text.Length > 0 && dbPagamento6.Valor > 0)
            {
                var vp = formaPagamentoDAO.BuscarByID(int.Parse(tbCodigoFormaPagamento6.Text));
                var forma = new Tuple<FormaPagamento, decimal>(vp, dbPagamento6.Valor);
                formasPagamento.Add(forma);
            }
            if (tbCodigoFormaPagamento7.Text.Length > 0 && dbPagamento7.Valor > 0)
            {
                var vp = formaPagamentoDAO.BuscarByID(int.Parse(tbCodigoFormaPagamento7.Text));
                var forma = new Tuple<FormaPagamento, decimal>(vp, dbPagamento7.Valor);
                formasPagamento.Add(forma);
            }
            this.Close();
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
                //this.formasPagamento.Add(buscaFormaPagamento.formapagamentoSelecionada);
            }
        }
        private void BuscaFormaPagamento(TextBox codigo, TextBox nome, DecimalBox valor)
        {
            if (this.codigoAtual.ToString() == codigo.Text)
                return;

            int id = 0;

            if (!int.TryParse(codigo.Text, out id))
            {
                codigo.Clear();
                nome.Clear();
                valor.Valor = 0.00m;
                CalculaTotalPagamento();
                return;
            }

            if (codigo.Text.Length <= 0)
                return;


            var formaPagamento = formaPagamentoDAO.BuscarByID(id);
            if (formaPagamento != null)
            {
                PreencheCamposFormaPagamento(formaPagamento, codigo, nome);
            }
            else
            {
                LimpaFormaPagamento(codigo, nome, valor);
            }
        }
        private void PreencheCamposFormaPagamento(FormaPagamento formaPagamento, TextBox codigo, TextBox nome)
        {
            codigo.Text = formaPagamento.FormaPagamentoID.ToString();
            nome.Text = formaPagamento.Nome;
        }
        private void CalculaTotalPagamento(TextBox codigo, DecimalBox valor)
        {
            if (codigo.Text.Length == 0)
            {
                valor.Valor = 0.00m;
            }
            totalPago = 0.00m;
            totalPago += dbPagamento1.Valor;
            totalPago += dbPagamento2.Valor;
            totalPago += dbPagamento3.Valor;
            totalPago += dbPagamento4.Valor;
            totalPago += dbPagamento5.Valor;
            totalPago += dbPagamento6.Valor;
            totalPago += dbPagamento7.Valor;
            lbValorTroco.Text = (totalPago - totalAPagar).ToString("R$ ############0.00");
            lbValorTroco.ForeColor = totalPago < totalAPagar ? System.Drawing.Color.Red : System.Drawing.Color.Green;

        }
        private void CalculaTotalPagamento()
        {
            totalPago = 0.00m;
            totalPago += dbPagamento1.Valor;
            totalPago += dbPagamento2.Valor;
            totalPago += dbPagamento3.Valor;
            totalPago += dbPagamento4.Valor;
            totalPago += dbPagamento5.Valor;
            totalPago += dbPagamento6.Valor;
            totalPago += dbPagamento7.Valor;
            lbValorTroco.Text = (totalPago - totalAPagar).ToString("R$ ############0.00");
            lbValorTroco.ForeColor = totalPago < totalAPagar ? System.Drawing.Color.Red : System.Drawing.Color.Green;
        }
        private void LimpaFormaPagamento(TextBox codigo, TextBox nome, DecimalBox valor)
        {
            codigo.Clear();
            nome.Clear();
            valor.Valor = 0.00m;
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

    }
}
