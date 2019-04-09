using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class LogadoBLL
    {
        private readonly LogadoDAO logadoDAO = new LogadoDAO();

        public int GravarLogado(Usuario usuario, string mac, string nomepc, string ipdopc)
        {
            return logadoDAO.GravarLogado(usuario, mac, nomepc, ipdopc);
        }

        public int RemoverLogado(Usuario usuario)
        {
            return logadoDAO.RemoverLogado(usuario);
        }

        public Logado BuscaLogado(Usuario usuario)
        {
            return logadoDAO.BuscaLogado(usuario);
        }
    }
}
