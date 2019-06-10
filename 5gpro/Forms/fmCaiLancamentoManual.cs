using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCaiLancamentoManual : Form
    {
        private CaixaLancamento caixaLancamento = null;

        private readonly CaixaLancamentoDAO caixaLancamentoDAO = new CaixaLancamentoDAO();

        private bool editando, ignoracheckevent = false;

        public fmCaiLancamentoManual()
        {
            InitializeComponent();
        }

        private void FmCaiLancamentoManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!editando)
                return;

            if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            "Aviso de alteração",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void FmCaiLancamentoManual_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }
        private void BtSalvar_Click(object sender, EventArgs e) => Salvar();
        private void BuscaCaixa_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void DtpData_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void RbCredito_CheckedChanged(object sender, EventArgs e) => Editando(true);
        private void RbDebito_CheckedChanged(object sender, EventArgs e) => Editando(true);
        private void TbDocumento_TextChanged(object sender, EventArgs e) => Editando(true);
        private void DbValor_Valor_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaCaixa_Leave(object sender, EventArgs e) => CarregaStatus();


        private void Salvar()
        {
            if (!editando)
            {
                return;
            }

            if (caixaLancamento == null)
            {
                caixaLancamento = new CaixaLancamento();
            }

            caixaLancamento.Caixa = buscaCaixa.caixa;
            caixaLancamento.Data = dtpData.Value;
            caixaLancamento.Documento = tbDocumento.Text;
            caixaLancamento.Lancamento = 0; // lançamento manual
            caixaLancamento.Valor = dbValor.Valor;
            caixaLancamento.ValorPago = dbValor.Valor;
            caixaLancamento.Troco = 0;
            caixaLancamento.Tipo = rbCredito.Checked ? 0 : 1;
            int retorno = caixaLancamentoDAO.Novo(caixaLancamento);

            if (retorno == 0)
            {
                MessageBox.Show("Houve um problema ao inserir a nova conta!",
                    "Problema ao inserir conta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Conta inserida com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK);
            }
            LimparDados();
        }
        private void LimparDados()
        {
            caixaLancamento = null;
            dtpData.Value = DateTime.Now;
            tbDocumento.Clear();
            dbValor.Valor = 0;
            Editando(false);
        }
        private void CarregaStatus()
        {
            if (buscaCaixa.caixa == null)
            {
                tbStatusCaixa.Clear();
                return;
            }

            tbStatusCaixa.Text = buscaCaixa.caixa.Aberto ? "Aberto" : "Fechado";
            btSalvar.Enabled = buscaCaixa.caixa.Aberto;

        }
        private void Editando(bool edit)
        {
            editando = edit;
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
