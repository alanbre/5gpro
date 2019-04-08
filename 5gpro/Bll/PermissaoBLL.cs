using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class PermissaoBLL
    {
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
      

        public fmCadastroGrupoUsuario.PermissoesStruct BuscaPermissoesGrupo(string cod)
        {
            return permissaoDAO.BuscaPermissoesByIdGrupo(cod);
        }

        public fmCadastroGrupoUsuario.PermissoesStruct BuscaTodasPermissoes()
        {
            return permissaoDAO.BuscaTodasPermissoes();
        }

        public int BuscarIDbyCodigo(string codpermissao)
        {
            return permissaoDAO.BuscarIDbyCodigo(codpermissao);
        }


    }
}


