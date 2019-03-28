using _5gpro.Daos;
using _5gpro.Entities;

namespace _5gpro.Bll
{
    class OrcamentoBLL
    {
        OrcamentoDAO orcamentoDAO = new OrcamentoDAO();

        public Orcamento BuscaOrcamentoById(string cod)
        {
            return orcamentoDAO.BuscaOrcamentoById(cod);
        }

        public string BuscaProxCodigoDisponivel()
        {
            return orcamentoDAO.BuscaProxCodigoDisponivel();
        }
    }
}
