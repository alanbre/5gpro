using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class UnimedidaBLL
    {

        private readonly UnimedidaDAO UnimedidaDAO = new UnimedidaDAO();

        public UnidadeMedida BuscaUnimedidaByCod(int cod)
        {
            return UnimedidaDAO.BuscaUnimedidaByCod(cod);
        }

        public List<UnidadeMedida> BuscarTodasUnimedidas()
        {
            return UnimedidaDAO.BuscarTodasUnimedidas();
        }

    }
}
