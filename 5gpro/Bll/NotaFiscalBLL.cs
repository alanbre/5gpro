using _5gpro.Daos;

namespace _5gpro.Bll
{
    class NotaFiscalBLL
    {
        NotaFiscalDAO notafiscalDAO = new NotaFiscalDAO();

        public string BuscaProxCodigoDisponivel()
        {
            return notafiscalDAO.BuscaProxCodigoDisponivel();
        }
    }
}