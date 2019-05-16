using _5gpro.Entities;
using _5gpro.Forms;
using System;
using System.Collections.Generic;
using MySQLConnection;

namespace _5gpro.Daos
{
    public class UsuarioDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public Usuario Logar(string idusuario, string senha)
        {
            Usuario usuario = new Usuario();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = "SELECT * FROM usuario WHERE idusuario = @idusuario AND senha = @senha LIMIT 1";
                sql.addParam("@idusuario", idusuario);
                sql.addParam("@senha", senha);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                usuario = new Usuario();
                usuario.UsuarioID = int.Parse(data["idusuario"]);
                usuario.Nome = data["nome"];
                usuario.Sobrenome = data["sobrenome"];
                usuario.Senha = data["senha"];
            }
            return usuario;
        }



        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT u1.idusuario + 1 AS proximoid
                                             FROM usuario AS u1
                                             LEFT OUTER JOIN usuario AS u2 ON u1.idusuario + 1 = u2.idusuario
                                             WHERE u2.idusuario IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1";
                var data = sql.selectQueryForSingleRecord();
                if (data != null)
                {
                    proximoid = int.Parse(data["proximoid"]);
                }
            }
            return proximoid;
        }

        public int Salvar(Usuario usuario)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"INSERT INTO usuario 
                          (idusuario, nome, sobrenome, senha, email, telefone, idgrupousuario) 
                          VALUES
                          (@idusuario, @nome, @sobrenome, @senha, @email, @telefone, @idgrupousuario)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome, sobrenome = @sobrenome, senha = @senha, email = @email,
                           telefone = @telefone, idgrupousuario = @idgrupousuario";
                sql.addParam("@idusuario", usuario.UsuarioID);
                sql.addParam("@nome", usuario.Nome);
                sql.addParam("@sobrenome", usuario.Sobrenome);
                sql.addParam("@senha", usuario.Senha);
                sql.addParam("@email", usuario.Email);
                sql.addParam("@telefone", usuario.Telefone);
                sql.addParam("@idgrupousuario", usuario.Grupousuario.GrupoUsuarioID);
                retorno = sql.insertQuery();
            }

            return retorno;
        }

        /// <summary>
        /// Retorna apenas o ID e o nome do usuário. Feito para tela de Login
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public Usuario BuscaByIDLogin(int cod)
        {
            Usuario usuario = new Usuario();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = "SELECT u.idusuario, u.nome FROM usuario AS u WHERE idusuario = @idusuario LIMIT 1";
                sql.addParam("@idusuario", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                usuario = new Usuario
                {
                    UsuarioID = int.Parse(data["idusuario"]),
                    Nome = data["nome"]
                };
            }
            return usuario;
        }


        public Usuario BuscaByID(int cod)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = "SELECT * FROM usuario WHERE idusuario = @idusuario LIMIT 1";
                sql.addParam("@idusuario", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                grupousuario = new GrupoUsuario
                {
                    GrupoUsuarioID = int.Parse(data["idgrupousuario"])
                };
                usuario = new Usuario
                {
                    UsuarioID = int.Parse(data["idusuario"]),
                    Senha = data["senha"],
                    Grupousuario = grupousuario,
                    Nome = data["nome"],
                    Sobrenome = data["sobrenome"],
                    Email = data["email"],
                    Telefone = data["telefone"]
                };
            }
            return usuario;
        }


        public Usuario Proximo(string codAtual)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM usuario WHERE idusuario = (SELECT min(idusuario) FROM usuario WHERE idusuario > @idusuario) LIMIT 1";
                sql.addParam("@idusuario", codAtual);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                grupousuario = new GrupoUsuario
                {
                    GrupoUsuarioID = int.Parse(data["idgrupousuario"])
                };
                usuario = new Usuario
                {
                    UsuarioID = int.Parse(data["idusuario"]),
                    Senha = data["senha"],
                    Grupousuario = grupousuario,
                    Nome = data["nome"],
                    Sobrenome = data["sobrenome"],
                    Email = data["email"],
                    Telefone = data["telefone"]
                };
            }
            return usuario;
        }

        public Usuario Anterior(string codAtual)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM usuario u WHERE u.idusuario = (SELECT max(idusuario) FROM usuario WHERE idusuario < @idusuario) LIMIT 1";
                sql.addParam("@idusuario", codAtual);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                grupousuario = new GrupoUsuario
                {
                    GrupoUsuarioID = int.Parse(data["idgrupousuario"])
                };
                usuario = new Usuario
                {
                    UsuarioID = int.Parse(data["idusuario"]),
                    Senha = data["senha"],
                    Grupousuario = grupousuario,
                    Nome = data["nome"],
                    Sobrenome = data["sobrenome"],
                    Email = data["email"],
                    Telefone = data["telefone"]
                };
            }
            return usuario;
        }


        public IEnumerable<Usuario> Busca(string codGrupoUsuario, string nomeUsuario, string sobrenomeUsuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string conCodGrupoUsuario = codGrupoUsuario.Length > 0 ? "AND g.idgrupousuario = @idgrupousuario" : "";
            string conNomeUsuario = nomeUsuario.Length > 0 ? "AND u.nome LIKE @nomeusuario" : "";
            string conSobrenomeUsuario = sobrenomeUsuario.Length > 0 ? "AND u.sobrenome LIKE @sobrenomeusuario" : "";

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM usuario u
                            WHERE 1=1
                            " + conCodGrupoUsuario + @"
                            " + conNomeUsuario + @"
                            " + conSobrenomeUsuario + @"
                            ORDER BY u.idusuario";
                if (codGrupoUsuario.Length > 0) { sql.addParam("@idgrupousuario", codGrupoUsuario); }
                if (nomeUsuario.Length > 0) { sql.addParam("@nomeusuario", "%" + nomeUsuario + "%"); }
                if (sobrenomeUsuario.Length > 0) { sql.addParam("@sobrenomeUsuario", "%" + sobrenomeUsuario + "%"); }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    GrupoUsuario grupousuario = new GrupoUsuario();
                    grupousuario.GrupoUsuarioID = int.Parse(d["idgrupousuario"]);
                    Usuario usuario = new Usuario
                    {
                        UsuarioID = int.Parse(d["idusuario"]),
                        Senha = d["senha"],
                        Grupousuario = grupousuario,
                        Nome = d["nome"],
                        Sobrenome = d["sobrenome"],
                        Email = d["email"],
                        Telefone = d["telefone"]
                    };
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

    }
}
