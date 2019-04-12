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

        private readonly GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO();

        public GrupoUsuario BuscaGrupoUsuarioByID(int cod)
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

        public int SalvarOuAtualizarGrupoUsuario(GrupoUsuario grupousuario, List<Permissao> listapermissoes)
        {
            return grupousuarioDAO.SalvarOuAtualizarGrupoUsuario(grupousuario, listapermissoes);
        }

        public GrupoUsuario BuscarProximoGrupoUsuario(string codAtual)
        {
            return grupousuarioDAO.BuscarProximoGrupoUsuario(codAtual);
        }

        public GrupoUsuario BuscarGrupoUsuarioAnterior(string codAtual)
        {
            return grupousuarioDAO.BuscarGrupoUsuarioAnterior(codAtual);
        }

        public string BuscaProxCodigoDisponivel()
        {
            return grupousuarioDAO.BuscaProxCodigoDisponivel();
        }

        public List<int> BuscarIDGrupoUsuariosNpraN()
        {
            return grupousuarioDAO.BuscarIDGrupoUsuariosNpraN();
        }
    }
}
