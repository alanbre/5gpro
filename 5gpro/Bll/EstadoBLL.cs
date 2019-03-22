using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class EstadoBLL
    {
        EstadoDAO EstadoDAO = new EstadoDAO();

        public Estado BuscaEstadoByCod(string cod)
        {
            return EstadoDAO.BuscaEstadoByCod(cod);
        }

        public List<Estado> BuscaEstadoByNome(string nome)
        {
            return EstadoDAO.BuscaEstadoByNome(nome);
        }
    }
}
