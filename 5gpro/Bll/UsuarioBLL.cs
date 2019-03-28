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
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public Usuario Logar(string login, string senha)
        {
            return usuarioDAO.Logar(login, senha);
        }
    }
}
