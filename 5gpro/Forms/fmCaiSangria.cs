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
        private readonly CaixaLancamentoDAO caixaLancamentoDAO = new CaixaLancamentoDAO();
        public fmCaiSangria()
        {
            InitializeComponent();
        }

        private void BuscaCaixa_Leave(object sender, EventArgs e) => CarregaDados();


        private void CarregaDados()
        {
            if (buscaCaixa.caixa == null)
            {
                LimpaDados();
                return;
            }

            gbTotaisSangria.Enabled = buscaCaixa.caixa.Aberto;

            caixaLancamentos = caixaLancamentoDAO.Busca(buscaCaixa.caixa).ToList();
            if (caixaLancamentos == null)
            {
                return;
            }

            PreencheCampos();
        }
        private void PreencheCampos()
        {
            tbStatusCaixa.Text = buscaCaixa.caixa.Aberto ? "Aberto" : "Fechado";
            dbCaixaAbertura.Valor = buscaCaixa.caixa.ValorAbertura;
            dbCaixaFaturamento.Valor =  caixaLancamentos.Sum(l => l.Valor);
            dbDemonstrativoDinheiro.Valor = caixaLancamentos.Where(l => l.TipoDocumento == 0).Sum(l => l.Valor);

            dbCaixaTotal.Valor = dbCaixaAbertura.Valor + dbCaixaFaturamento.Valor - dbCaixaSangria.Valor;
        }        
        private void LimpaDados()
        {
            buscaCaixa.Limpa();
            tbStatusCaixa.Clear();
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
            caixaLancamentos = null;
        }
    }
}
