using _5gpro.Daos;
using _5gpro.Entities;
using System.Collections.Generic;

namespace _5gpro.Bll
{
    class CidadeBLL
    {
        CidadeDAO CidadeDAO = new CidadeDAO();
        public Cidade BuscaCidadeByCod(int cod)
        {
            return CidadeDAO.BuscaCidadeByCod(cod);
        }

        public List<Cidade> BuscaCidades(string codEstado, string nomeCidade)
        {
            return CidadeDAO.BuscaCidades(codEstado, nomeCidade);
        }
    }
}
