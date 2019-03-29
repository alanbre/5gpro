using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class PermissaoBLL
    {
        PermissaoDAO permissaoDAO = new PermissaoDAO();
      

        public List<Permissao> BuscaPermissoesGrupo(string cod)
        {
            return permissaoDAO.BuscaPermissoesGrupo(cod);
        }

    }
}


