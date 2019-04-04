using _5gpro.Daos;
using _5gpro.Entities;

namespace _5gpro.Bll
{
    class NotaFiscalBLL
    {
        NotaFiscalDAO notafiscalDAO = new NotaFiscalDAO();

        public string BuscaProxCodigoDisponivel()
        {
            return notafiscalDAO.BuscaProxCodigoDisponivel();
        }

        public NotaFiscalItem BuscaItemByCod(int codigo)
        {
            return notafiscalDAO.BuscaItemByCod(codigo);
        }
    }
}