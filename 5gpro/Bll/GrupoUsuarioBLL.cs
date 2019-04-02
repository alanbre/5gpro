using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class GrupoUsuarioBLL
    {

        GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO();

        public GrupoUsuario BuscaGrupoUsuarioByCod(string cod)
        {
            return grupousuarioDAO.BuscarGrupoUsuarioById(cod);
        }

        public List<GrupoUsuario> BuscarTodosGrupoUsuarios()
        {
            return grupousuarioDAO.BuscarTodosGrupoUsuarios();
        }

        public List<GrupoUsuario> BuscarGrupoUsuario(string nome)
        {
            return grupousuarioDAO.BuscarGrupoUsuario(nome);
        }

       // public int SalvarOuAtualizarGrupoUsuario(GrupoUsuario grupousuario)
        //{
            //return GrupoUsuarioDAO.SalvarOuAtualizarGrupoUsuario(grupousuario);
        //}


    }
}
