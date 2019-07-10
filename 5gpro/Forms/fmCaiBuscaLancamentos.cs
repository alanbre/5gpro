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
    public partial class fmCaiBuscaLancamentos : Form
    {
        private readonly CaixaLancamentoDAO caixaLancamentoDAO = new CaixaLancamentoDAO();
        private List<CaixaLancamento> caixaLancamentos = new List<CaixaLancamento>();

        public fmCaiBuscaLancamentos()
        {
            InitializeComponent();
        }

        public struct Filtros
        {
            public DateTime DataInicial;
            public DateTime DataFinal;
            public Caixa caixa;
            public PlanoConta planoConta;
        }

        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();

        private void Pesquisar()
        {
            Filtros f = new Filtros
            {
                DataInicial = dtpDataInicial.Value.Date,
                DataFinal = dtpDataFinal.Value.Date.AddDays(1).AddTicks(-1),
                caixa = buscaCaixa.caixa,
                planoConta = buscaPlanoContaCaixa.conta
            };

            caixaLancamentos = caixaLancamentoDAO.Busca(f).ToList();
            PreencheDados();

        }
        private void PreencheDados()
        {
            dgvDados.Rows.Clear();
            foreach (var cl in caixaLancamentos)
            {
                dgvDados.Rows.Add(
                    cl.Data,
                    cl.Valor,
                    cl.Documento,
                    cl.Caixa.Codigo.ToString() + cl.Caixa.Descricao,
                    cl.PlanoConta.CodigoCompleto,
                    cl.PlanoConta.Descricao
                    );
            }
        }
    }
}
