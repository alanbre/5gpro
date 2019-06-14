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
    public partial class fmCaiSangria : Form
    {
        private List<CaixaLancamento> caixaLancamentos = null;
        private CaixaLancamento sangriaDinheiro = new CaixaLancamento();
        private List<CaixaLancamento> sangriaCheque = new List<CaixaLancamento>();
        private List<CaixaLancamento> sangriaCartaoCredito = new List<CaixaLancamento>();
        private List<CaixaLancamento> sangriaCartaoDebito = new List<CaixaLancamento>();
        private List<CaixaLancamento> sangriaLancamentos = new List<CaixaLancamento>();
        private readonly CaixaLancamentoDAO caixaLancamentoDAO = new CaixaLancamentoDAO();
        

        public fmCaiSangria()
        {
            InitializeComponent();
        }

        private void FmCaiSangria_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void BuscaCaixa_Leave(object sender, EventArgs e) => CarregaDados();
        private void BcDestino_Leave(object sender, EventArgs e)
        {
            if(bcDestino.caixa == null)
            {
                return;
            }
            tbStatusCaixaDestino.Text = bcDestino.caixa.Aberto ? "Aberto" : "Fechado";
        }
        private void BtRealizarSangria_Click(object sender, EventArgs e) => Sangrar();

        private void Sangrar()
        {
            if (dbSangriaDinheiroTotal.Valor > 0)
            {
                sangriaDinheiro.Data = DateTime.Now;
                sangriaDinheiro.Valor = dbSangriaDinheiroTotal.Valor;
                sangriaDinheiro.ValorPago = dbSangriaDinheiroTotal.Valor;
                sangriaDinheiro.Troco = 0;
                sangriaDinheiro.Lancamento = 0;
                sangriaLancamentos.Add(sangriaDinheiro);
            }
            int retorno = caixaLancamentoDAO.Sangrar(sangriaLancamentos, bcOrigem.caixa, bcDestino.caixa);
            if (retorno == 0)
            {
                MessageBox.Show("Problema ao realizar a sangria",
                    "Problema ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Sangria realizada com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK);
                LimpaDados();
                CarregaDados();
            }
        }
        private void CarregaDados()
        {
            if (bcOrigem.caixa == null)
            {
                LimpaDados();
                return;
            }

            gbTotaisSangria.Enabled = bcOrigem.caixa.Aberto;

            caixaLancamentos = caixaLancamentoDAO.Busca(bcOrigem.caixa).ToList();
            if (caixaLancamentos == null)
            {
                return;
            }

            PreencheCampos();
        }
        private void PreencheCampos()
        {
            LimpaDados();
            tbStatusCaixaOrigem.Text = bcOrigem.caixa.Aberto ? "Aberto" : "Fechado";
            dbCaixaAbertura.Valor = bcOrigem.caixa.ValorAbertura;
            dbCaixaFaturamento.Valor = caixaLancamentos.Where(l => l.TipoMovimento == 0).Sum(l => l.Valor);
            dbCaixaSangria.Valor = caixaLancamentos.Where(l => l.TipoMovimento == 5).Sum(l => l.Valor);
            dbDemonstrativoDinheiro.Valor = caixaLancamentos.Where(l => l.TipoDocumento == 0 && l.TipoMovimento == 0).Sum(l => l.Valor) - caixaLancamentos.Where(l => l.TipoDocumento == 0 && l.TipoMovimento == 5 || l.TipoMovimento == 1).Sum(l => l.Valor);
            dbDemonstrativoCheque.Valor = caixaLancamentos.Where(l => l.TipoDocumento == 1 && l.TipoMovimento == 0).Sum(l => l.Valor);
            dbDemonstrativoCartaoCredito.Valor = caixaLancamentos.Where(l => l.TipoDocumento == 2 && l.TipoMovimento == 0).Sum(l => l.Valor);
            dbDemonstrativoCartaoDebito.Valor = caixaLancamentos.Where(l => l.TipoDocumento == 3 && l.TipoMovimento == 0).Sum(l => l.Valor);
            dbCaixaTotal.Valor = dbCaixaAbertura.Valor + dbCaixaFaturamento.Valor - dbCaixaSangria.Valor;
            PreencheGrids();
        }
        private void PreencheGrids()
        {
            foreach (var lanc in caixaLancamentos)
            {
                switch (lanc.TipoDocumento)
                {
                    case 1:
                        dgvCheque.Rows.Add();
                        break;
                    case 2:
                        dgvCartaoCredito.Rows.Add();
                        break;
                    case 3:
                        dgvCartaoDebito.Rows.Add();
                        break;
                }
            }
        }
        private void LimpaDados()
        {
            tbStatusCaixaOrigem.Clear();
            dbCaixaAbertura.Valor = 0;
            dbCaixaFaturamento.Valor = 0;
            dbCaixaSangria.Valor = 0;
            dbCaixaTotal.Valor = 0;
            dbDemonstrativoDinheiro.Valor = 0;
            dbDemonstrativoCheque.Valor = 0;
            dbDemonstrativoCartaoCredito.Valor = 0;
            dbDemonstrativoCartaoDebito.Valor = 0;
            dbSangriaDinheiroTotal.Valor = 0;
            dbSangriaChequeTotal.Valor = 0;
            dbSangriaCartaoCreditoTotal.Valor = 0;
            dbSangriaCartaoDebitoTotal.Valor = 0;
            dbSangriaDinheiroTotal.Valor = 0;
            dbSangriaChequeTotal.Valor = 0;
            dbSangriaCartaoCreditoTotal.Valor = 0;
            dbSangriaCartaoDebitoTotal.Valor = 0;
            dbSangriaTotal.Valor = 0;
            cbTodosCheques.Checked = false;
            cbTodosCartaoCredito.Checked = false;
            cbTodosCartaoDebito.Checked = false;
            dgvCheque.Rows.Clear();
            dgvCartaoCredito.Rows.Clear();
            dgvCartaoDebito.Rows.Clear();
            bcDestino.Limpa();
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
