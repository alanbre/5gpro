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

        UnimedidaDAO UnimedidaDAO = new UnimedidaDAO();

        public Unimedida BuscaUnimedidaByCod(int cod)
        {
            return UnimedidaDAO.BuscaUnimedidaByCod(cod);
        }

        public List<Unimedida> BuscarTodasUnimedidas()
        {
            return UnimedidaDAO.BuscarTodasUnimedidas();
        }

    }
}
