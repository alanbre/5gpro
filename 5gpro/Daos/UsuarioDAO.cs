using _5gpro.Bll;
using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class UsuarioDAO : ConexaoDAO
    {

        public GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();

        public Usuario Logar(string idusuario, string senha)
        {
            Usuario usuario = new Usuario();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM usuario WHERE idusuario = @idusuario AND senha = @senha", Conexao);
                Comando.Parameters.AddWithValue("@idusuario", idusuario);
                Comando.Parameters.AddWithValue("@senha", senha);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario"));
                    usuario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    usuario.Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome"));
                    usuario.Senha = reader.GetString(reader.GetOrdinal("senha"));
                }
                else
                {
                    usuario = null;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }
            return usuario;
        }



        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT u1.idusuario + 1 AS proximoid
                                             FROM usuario AS u1
                                             LEFT OUTER JOIN usuario AS u2 ON u1.idusuario + 1 = u2.idusuario
                                             WHERE u2.idusuario IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Conexao);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    proximoid = reader.GetString(reader.GetOrdinal("proximoid"));
                    reader.Close();
                }
                else
                {
                    //FIZ ESSE ELSE PARA CASO N TIVER NENHUM REGISTRO NA BASE... PODE DAR PROBLEMA EM ALGUM MOMENTO xD
                    proximoid = "1";
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            return proximoid;
        }

        public int SalvarOuAtualizarUsuario(Usuario usuario)
        {

            int retorno = 0;
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand(@"INSERT INTO usuario 
                          (idusuario, nome, sobrenome, senha, email, telefone, idgrupousuario) 
                          VALUES
                          (@idusuario, @nome, @sobrenome, @senha, @email, @telefone, @idgrupousuario)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome, sobrenome = @sobrenome, senha = @senha, email = @email,
                           telefone = @telefone, idgrupousuario = @idgrupousuario
                         ;",
                         Conexao);

                Comando.Parameters.AddWithValue("@idusuario", usuario.UsuarioID);
                Comando.Parameters.AddWithValue("@nome", usuario.Nome);
                Comando.Parameters.AddWithValue("@sobrenome", usuario.Sobrenome);
                Comando.Parameters.AddWithValue("@senha", usuario.Senha);
                Comando.Parameters.AddWithValue("@email", usuario.Email);
                Comando.Parameters.AddWithValue("@telefone", usuario.Telefone);
                Comando.Parameters.AddWithValue("@idgrupousuario", usuario.Grupousuario.GrupoUsuarioID);


                retorno = Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                FecharConexao();
            }
            return retorno;
        }

        /// <summary>
        /// Retorna apenas o ID e o nome do usuário. Feito para tela de Login
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public Usuario BuscarUsuarioByIdLogin(int cod)
        {
            Usuario usuario = new Usuario();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT u.idusuario, u.nome FROM usuario AS u WHERE idusuario = @idusuario", Conexao);
                Comando.Parameters.AddWithValue("@idusuario", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {

                    usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                    };
                    reader.Close();
                }
                else
                {
                    usuario = null;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            return usuario;
        }

        public Usuario BuscarUsuarioById(int cod)
        {
            Usuario usuario = new Usuario();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM usuario WHERE idusuario = @idusuario", Conexao);
                Comando.Parameters.AddWithValue("@idusuario", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Senha = reader.GetString(reader.GetOrdinal("senha")),

                        //Grupousuario = grupousuario,
                        Grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(reader.GetInt32(reader.GetOrdinal("idgrupousuario"))),
                        
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome")),
                        Email = reader.GetString(reader.GetOrdinal("email")),
                        Telefone = reader.GetString(reader.GetOrdinal("telefone"))
                    };
                    reader.Close();
                }
                else
                {
                    usuario = null;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            return usuario;
        }


        public Usuario BuscarProximoUsuario(string codAtual)
        {
            Usuario usuario = new Usuario();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM usuario WHERE idusuario = (SELECT min(idusuario) FROM usuario WHERE idusuario > @idusuario)", Conexao);
                Comando.Parameters.AddWithValue("@idusuario", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Senha = reader.GetString(reader.GetOrdinal("senha")),
                        Grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(reader.GetInt32(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome")),
                        Email = reader.GetString(reader.GetOrdinal("email")),
                        Telefone = reader.GetString(reader.GetOrdinal("telefone"))
                    };

                    reader.Close();
                }
                else
                {
                    usuario = null;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            return usuario;
        }

        public Usuario BuscarUsuarioAnterior(string codAtual)
        {
            Usuario usuario = new Usuario();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM usuario WHERE idusuario = (SELECT max(idusuario) FROM usuario WHERE idusuario < @idusuario)", Conexao);
                Comando.Parameters.AddWithValue("@idusuario", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Senha = reader.GetString(reader.GetOrdinal("senha")),
                        Grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(reader.GetInt32(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome")),
                        Email = reader.GetString(reader.GetOrdinal("email")),
                        Telefone = reader.GetString(reader.GetOrdinal("telefone"))
                    };

                    reader.Close();
                }
                else
                {
                    usuario = null;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            return usuario;
        }

        public List<Usuario> BuscaUsuarios(string codGrupoUsuario, string nomeUsuario, string sobrenomeUsuario)
        {

            List<Usuario> usuarios = new List<Usuario>();

            string conCodGrupoUsuario = codGrupoUsuario.Length > 0 ? "AND g.idgrupousuario = @idgrupousuario" : "";
            string conNomeUsuario = nomeUsuario.Length > 0 ? "AND u.nome LIKE @nomeusuario" : "";
            string conSobrenomeUsuario = sobrenomeUsuario.Length > 0 ? "AND u.sobrenome LIKE @sobrenomeusuario" : "";


            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT *
                                             FROM usuario u INNER JOIN grupo_usuario g 
                                             ON u.idgrupousuario = g.idgrupousuario
                                             WHERE 1=1
                                             " + conCodGrupoUsuario + @"
                                             " + conNomeUsuario + @"
                                             " + conSobrenomeUsuario + @"
                                             ORDER BY u.idusuario;", Conexao);

                if (codGrupoUsuario.Length > 0) { Comando.Parameters.AddWithValue("@idgrupousuario", codGrupoUsuario); }
                if (nomeUsuario.Length > 0) { Comando.Parameters.AddWithValue("@nomeusuario", "%" + nomeUsuario + "%"); }
                if (sobrenomeUsuario.Length > 0) { Comando.Parameters.AddWithValue("@sobrenomeUsuario", "%" + sobrenomeUsuario + "%"); }

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {

                    Usuario usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Senha = reader.GetString(reader.GetOrdinal("senha")),
                        Grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(reader.GetInt32(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome")),
                        Email = reader.GetString(reader.GetOrdinal("email")),
                        Telefone = reader.GetString(reader.GetOrdinal("telefone"))
                    };

                    usuarios.Add(usuario);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }
            return usuarios;
        }

    }
}
