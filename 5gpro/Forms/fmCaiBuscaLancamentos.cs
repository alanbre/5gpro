using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
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
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();

        private ParcelaContaReceberDAO parcelacontareceberDAO = new ParcelaContaReceberDAO();
        private ParcelaContaPagarDAO  parcelacontapagarDAO = new ParcelaContaPagarDAO();
        private NotaFiscalPropriaDAO notafiscalpropriaDAO = new NotaFiscalPropriaDAO();
        private NotaFiscalTerceirosDAO notafiscalterceirosDAO = new NotaFiscalTerceirosDAO();

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
            string desc = "", tipomovimento = "";
            dgvDados.Rows.Clear();
            foreach (var cl in caixaLancamentos)
            {
                switch (cl.TipoMovimento)
                {
                    case 0:
                        tipomovimento = "Crédito";
                        break;
                    case 1:
                        tipomovimento = "Débito";
                        break;
                    case 5:
                        tipomovimento = "Sangria";
                        break;
                }

                switch (cl.TipoDocumento)
                {
                    case 0:
                        desc = parcelacontareceberDAO.BuscaByID(cl.Documento).Descricao;
                        break;
                    case 1:
                        desc = parcelacontapagarDAO.BuscaByID(cl.Documento).Descricao;
                        break;
                    case 2:
                        desc = notafiscalpropriaDAO.BuscaByID(int.Parse(cl.Documento)).Descricao;
                        break;
                    case 3:
                        desc = notafiscalterceirosDAO.BuscaByID(int.Parse(cl.Documento)).Descricao;
                        break;
                    case 5:
                        desc = "Sangria";
                        break;
                }
                dgvDados.Rows.Add(
                    cl.Data,
                    cl.Documento,
                    desc,
                    cl.Valor,                 
                    cl.Caixa.Nome,
                    cl.PlanoConta.CodigoCompleto,
                    cl.PlanoConta.Descricao,
                    tipomovimento
                    );
            }
            funaux.TratarTamanhoColunas(dgvDados);
        }
    }
}
