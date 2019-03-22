using _5gpro.Daos;
using _5gpro.Entities;
using System.Collections.Generic;

namespace _5gpro.Bll
{
    class CidadeBLL
    {
        CidadeDAO CidadeDAO = new CidadeDAO();
        public Cidade BuscaCidadeByCod(string cod)
        {
            return CidadeDAO.BuscaCidadeByCod(cod);
        }

        public List<Cidade> BuscaCidadesByCodEstado(string codEstado)
        {
            return CidadeDAO.BuscaCidadesByCodEstado(codEstado);
        }
    }
}
