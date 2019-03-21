using _5gpro.Entities;
using _5gpro.Daos;

namespace _5gpro.Bll
{
    class CidadeBLL
    {
        CidadeDAO CidadeDAO = new CidadeDAO();
        public Cidade BuscaCidadeByCod(string cod)
        {
            return CidadeDAO.BuscaCidadeByCod(cod);
        }
    }
}
