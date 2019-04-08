using _5gpro.Daos;
using _5gpro.Entities;

namespace _5gpro.Bll
{
    class NotaFiscalBLL
    {
        private readonly NotaFiscalDAO notaFiscalDAO = new NotaFiscalDAO();

        public string BuscaProxCodigoDisponivel()
        {
            return notaFiscalDAO.BuscaProxCodigoDisponivel();
        }

        public NotaFiscalItem BuscaItemByCod(int codigo)
        {
            return notaFiscalDAO.BuscaItemByCod(codigo);
        }

        public NotaFiscal BuscaNotaByCod(int codigo)
        {
            return notaFiscalDAO.BuscaNotaByCod(codigo);
        }

        public NotaFiscal BuscaProximaNotaFiscal(int codAtual)
        {
            return notaFiscalDAO.BuscaProximaNotaFiscal(codAtual);
        }

        public NotaFiscal BuscaNotaFiscalAnterior(int codAtual)
        {
            return notaFiscalDAO.BuscaNotaFiscalAnterior(codAtual);
        }

        public int SalvarOuAtualizarDocumento(NotaFiscal notafiscal)
        {
            return notaFiscalDAO.SalvarOuAtualizarDocumento(notafiscal);
        }
    }
}