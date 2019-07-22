using _5gpro.Entities;
using System.Collections.Generic;
using MySQLConnection;
using System;
using _5gpro.StaticFiles;

namespace _5gpro.Daos
{
    public class UsuarioDAO
    {
        public Usuario Logar(string idusuario, string senha)
        {
            Usuario usuario = new Usuario();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "SELECT * FROM usuario WHERE idusuario = @idusuario AND BINARY senha = @senha LIMIT 1";
                sql.addParam("@idusuario", idusuario);
                sql.addParam("@senha", senha);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                usuario = new Usuario();
                usuario.UsuarioID = Convert.ToInt32(data["idusuario"]);
                usuario.Nome = (string)data["nome"];
                usuario.Sobrenome = (string)data["sobrenome"];
                usuario.Senha = (string)data["senha"];
            }
            return usuario;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
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
                    proximoid = Convert.ToInt32(data["proximoid"]);
                }
            }
            return proximoid;
        }
        public int Salvar(Usuario usuario)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
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
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
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
                    UsuarioID = Convert.ToInt32(data["idusuario"]),
                    Nome = (string)data["nome"]
                };
            }
            return usuario;
        }
        public Usuario BuscaByID(int cod)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, g.nome AS nomegrupo
                              FROM usuario
                              INNER JOIN grupo_usuario g
                              WHERE idusuario = @idusuario LIMIT 1";
                sql.addParam("@idusuario", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                grupousuario = new GrupoUsuario
                {
                    GrupoUsuarioID = Convert.ToInt32(data["idgrupousuario"]),
                    Nome = (string) data["nomegrupo"]
                };
                usuario = new Usuario
                {
                    UsuarioID = Convert.ToInt32(data["idusuario"]),
                    Senha = (string)data["senha"],
                    Grupousuario = grupousuario,
                    Nome = (string)data["nome"],
                    Sobrenome = (string)data["sobrenome"],
                    Email = (string)data["email"],
                    Telefone = (string)data["telefone"]
                };
            }
            return usuario;
        }
        public Usuario Proximo(int Codigo)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *,  g.nome AS nomegrupo
                              FROM usuario 
                              INNER JOIN grupo_usuario g
                              WHERE idusuario = (SELECT min(idusuario) 
                              FROM usuario 
                              WHERE idusuario > @idusuario) LIMIT 1";

                sql.addParam("@idusuario", Codigo);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                grupousuario = new GrupoUsuario
                {
                    GrupoUsuarioID = Convert.ToInt32(data["idgrupousuario"]),
                    Nome = (string)data["nomegrupo"]
                };
                usuario = new Usuario
                {
                    UsuarioID = Convert.ToInt32(data["idusuario"]),
                    Senha = (string)data["senha"],
                    Grupousuario = grupousuario,
                    Nome = (string)data["nome"],
                    Sobrenome = (string)data["sobrenome"],
                    Email = (string)data["email"],
                    Telefone = (string)data["telefone"]
                };
            }
            return usuario;
        }
        public Usuario Anterior(int Codigo)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();

            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, g.nome AS nomegrupo 
                              FROM usuario u
                              INNER JOIN grupo_usuario g
                              WHERE u.idusuario = (SELECT max(idusuario) 
                              FROM usuario 
                              WHERE idusuario < @idusuario) LIMIT 1";

                sql.addParam("@idusuario", Codigo);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                grupousuario = new GrupoUsuario
                {
                    GrupoUsuarioID = Convert.ToInt32(data["idgrupousuario"]),
                    Nome = (string)data["nomegrupo"]
                };
                usuario = new Usuario
                {
                    UsuarioID = Convert.ToInt32(data["idusuario"]),
                    Senha = (string)data["senha"],
                    Grupousuario = grupousuario,
                    Nome = (string)data["nome"],
                    Sobrenome = (string)data["sobrenome"],
                    Email = (string)data["email"],
                    Telefone = (string)data["telefone"]
                };
            }
            return usuario;
        }
        public IEnumerable<Usuario> Busca(GrupoUsuario grupousuariorecebido, string nomeUsuario, string sobrenomeUsuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string conCodGrupoUsuario = grupousuariorecebido != null ? "AND g.idgrupousuario = @idgrupousuario" : "";
            string conNomeUsuario = nomeUsuario.Length > 0 ? "AND u.nome LIKE @nomeusuario" : "";
            string conSobrenomeUsuario = sobrenomeUsuario.Length > 0 ? "AND u.sobrenome LIKE @sobrenomeusuario" : "";

            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, g.nome AS nomegrupo
                            FROM usuario u
                            LEFT JOIN grupo_usuario g
                            ON u.idgrupousuario = g.idgrupousuario
                            WHERE 1=1
                            " + conCodGrupoUsuario + @"
                            " + conNomeUsuario + @"
                            " + conSobrenomeUsuario + @"
                            ORDER BY u.idusuario";
                if (grupousuariorecebido != null) { sql.addParam("@idgrupousuario", grupousuariorecebido.GrupoUsuarioID); }
                if (nomeUsuario.Length > 0) { sql.addParam("@nomeusuario", "%" + nomeUsuario + "%"); }
                if (sobrenomeUsuario.Length > 0) { sql.addParam("@sobrenomeUsuario", "%" + sobrenomeUsuario + "%"); }

                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    GrupoUsuario grupousuario = new GrupoUsuario();
                    grupousuario.GrupoUsuarioID = Convert.ToInt32(d["idgrupousuario"]);
                    grupousuario.Nome = (string)d["nomegrupo"];
                    Usuario usuario = new Usuario
                    {
                        UsuarioID = Convert.ToInt32(d["idusuario"]),
                        Senha = (string)d["senha"],
                        Grupousuario = grupousuario,
                        Nome = (string)d["nome"],
                        Sobrenome = (string)d["sobrenome"],
                        Email = (string)d["email"],
                        Telefone = (string)d["telefone"]
                    };
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

    }
}
