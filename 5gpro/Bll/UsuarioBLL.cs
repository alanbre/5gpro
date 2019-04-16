using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Bll
{
    class UsuarioBLL
    {
        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();

        public int SalvarOuAtualizarUsuario(Usuario usuario)
        {
            return usuarioDAO.SalvarOuAtualizarUsuario(usuario);
        }

        public Usuario Logar(string idusuario, string senha)
        {
            return usuarioDAO.Logar(idusuario, senha);
        }

        public string BuscaProxCodigoDisponivel()
        {
            return usuarioDAO.BuscaProxCodigoDisponivel();
        }

        public Usuario BuscarUsuarioById(int cod)
        {
            return usuarioDAO.BuscarUsuarioById(cod);
        }

        public Usuario BuscarProximoUsuario(string codAtual)
        {
            return usuarioDAO.BuscarProximoUsuario(codAtual);
        }

        public Usuario BuscarUsuarioAnterior(string codAtual)
        {
            return usuarioDAO.BuscarUsuarioAnterior(codAtual);
        }

        public List<Usuario> BuscaUsuarios(string codGrupoUsuario, string nomeUsuario, string sobrenomeUsuario)
        {
            return usuarioDAO.BuscaUsuarios(codGrupoUsuario, nomeUsuario, sobrenomeUsuario);
        }

        public int GravarLogado(Usuario usuario, string mac)
        {
            return usuarioDAO.GravarLogado(usuario, mac);
        }

        public int RemoverLogado(Logado logado)
        {
            return usuarioDAO.RemoverLogado(logado);
        }

        public Logado BuscaLogado(Usuario usuario, string mac)
        {
            return usuarioDAO.BuscaLogado(usuario, mac);
        }
    }
}
