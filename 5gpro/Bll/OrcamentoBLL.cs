using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using System.Collections.Generic;

namespace _5gpro.Bll
{
    class OrcamentoBLL
    {
        OrcamentoDAO orcamentoDAO = new OrcamentoDAO();

        public int SalvarOuAtualizarOrcamento(Orcamento orcamento)
        {
            return orcamentoDAO.SalvarOuAtualizarOrcamento(orcamento);
        }

        public string BuscaProxCodigoDisponivel()
        {
            return orcamentoDAO.BuscaProxCodigoDisponivel();
        }

        public Orcamento BuscaOrcamentoById(int cod)
        {
            return orcamentoDAO.BuscaOrcamentoById(cod);
        }

        public Orcamento BuscaProximoOrcamento(string codAtual)
        {
            return orcamentoDAO.BuscaProximoOrcamento(codAtual);
        }

        public Orcamento BuscaOrcamentoAnterior(string codAtual)
        {
            return orcamentoDAO.BuscaOrcamentoAnterior(codAtual);
        }

        public List<Orcamento> BuscaOrcamentos(fmBuscaOrcamento.Filtros f)
        {
            return orcamentoDAO.BuscaOrcamentos(f);
        }
    }
}
