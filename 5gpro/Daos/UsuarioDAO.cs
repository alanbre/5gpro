using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace _5gpro.Daos
{
    public class UsuarioDAO
    {
        public ConexaoDAO Connect { get; }
        public UsuarioDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        public List<GrupoUsuario> listagrupousuarios = new List<GrupoUsuario>();

        public Usuario Logar(string idusuario, string senha)
        {
            Usuario usuario = new Usuario();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM usuario WHERE idusuario = @idusuario AND senha = @senha", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idusuario", idusuario);
                Connect.Comando.Parameters.AddWithValue("@senha", senha);

                IDataReader reader = Connect.Comando.ExecuteReader();

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
                Connect.FecharConexao();
            }
            return usuario;
        }



        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT u1.idusuario + 1 AS proximoid
                                             FROM usuario AS u1
                                             LEFT OUTER JOIN usuario AS u2 ON u1.idusuario + 1 = u2.idusuario
                                             WHERE u2.idusuario IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Connect.Conexao);

                IDataReader reader = Connect.Comando.ExecuteReader();

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
                Connect.FecharConexao();
            }

            return proximoid;
        }

        public int SalvarOuAtualizarUsuario(Usuario usuario)
        {

            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"INSERT INTO usuario 
                          (idusuario, nome, sobrenome, senha, email, telefone, idgrupousuario) 
                          VALUES
                          (@idusuario, @nome, @sobrenome, @senha, @email, @telefone, @idgrupousuario)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome, sobrenome = @sobrenome, senha = @senha, email = @email,
                           telefone = @telefone, idgrupousuario = @idgrupousuario
                         ;",
                         Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idusuario", usuario.UsuarioID);
                Connect.Comando.Parameters.AddWithValue("@nome", usuario.Nome);
                Connect.Comando.Parameters.AddWithValue("@sobrenome", usuario.Sobrenome);
                Connect.Comando.Parameters.AddWithValue("@senha", usuario.Senha);
                Connect.Comando.Parameters.AddWithValue("@email", usuario.Email);
                Connect.Comando.Parameters.AddWithValue("@telefone", usuario.Telefone);
                Connect.Comando.Parameters.AddWithValue("@idgrupousuario", usuario.Grupousuario.GrupoUsuarioID);


                retorno = Connect.Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                Connect.FecharConexao();
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
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT u.idusuario, u.nome FROM usuario AS u WHERE idusuario = @idusuario", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idusuario", cod);

                IDataReader reader = Connect.Comando.ExecuteReader();

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
                Connect.FecharConexao();
            }

            return usuario;
        }


        public Usuario BuscarUsuarioById(int cod)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM usuario WHERE idusuario = @idusuario", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idusuario", cod);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupousuario = new GrupoUsuario
                    {
                        GrupoUsuarioID = reader.GetInt32(reader.GetOrdinal("idgrupousuario"))
                    };

                    usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Senha = reader.GetString(reader.GetOrdinal("senha")),
                        Grupousuario = grupousuario,
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
                Connect.FecharConexao();
            }

            return usuario;
        }


        public Usuario BuscarProximoUsuario(string codAtual)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * FROM usuario WHERE idusuario = (SELECT min(idusuario) FROM usuario WHERE idusuario > @idusuario)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idusuario", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupousuario.GrupoUsuarioID = reader.GetInt32(reader.GetOrdinal("idgrupousuario"));

                    usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Senha = reader.GetString(reader.GetOrdinal("senha")),
                        Grupousuario = grupousuario,
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
                Connect.FecharConexao();
            }

            return usuario;
        }

        public Usuario BuscarUsuarioAnterior(string codAtual)
        {
            Usuario usuario = new Usuario();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * FROM usuario u WHERE u.idusuario = (SELECT max(idusuario) FROM usuario WHERE idusuario < @idusuario)", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idusuario", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {

                    GrupoUsuario grupousuario = new GrupoUsuario();
                    grupousuario.GrupoUsuarioID = reader.GetInt32(reader.GetOrdinal("idgrupousuario"));

                    usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Senha = reader.GetString(reader.GetOrdinal("senha")),
                        Grupousuario = grupousuario,
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
                Connect.FecharConexao();
            }

            return usuario;
        }


        public IEnumerable<Usuario> BuscaUsuarios(string codGrupoUsuario, string nomeUsuario, string sobrenomeUsuario)
        {

            List<Usuario> usuarios = new List<Usuario>();
            GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO(Connect);

            string conCodGrupoUsuario = codGrupoUsuario.Length > 0 ? "AND g.idgrupousuario = @idgrupousuario" : "";
            string conNomeUsuario = nomeUsuario.Length > 0 ? "AND u.nome LIKE @nomeusuario" : "";
            string conSobrenomeUsuario = sobrenomeUsuario.Length > 0 ? "AND u.sobrenome LIKE @sobrenomeusuario" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM usuario u
                                             WHERE 1=1
                                             " + conCodGrupoUsuario + @"
                                             " + conNomeUsuario + @"
                                             " + conSobrenomeUsuario + @"
                                             ORDER BY u.idusuario;", Connect.Conexao);

                if (codGrupoUsuario.Length > 0) { Connect.Comando.Parameters.AddWithValue("@idgrupousuario", codGrupoUsuario); }
                if (nomeUsuario.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nomeusuario", "%" + nomeUsuario + "%"); }
                if (sobrenomeUsuario.Length > 0) { Connect.Comando.Parameters.AddWithValue("@sobrenomeUsuario", "%" + sobrenomeUsuario + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    GrupoUsuario grupousuario = new GrupoUsuario();
                    grupousuario.GrupoUsuarioID = reader.GetInt32(reader.GetOrdinal("idgrupousuario"));

                    Usuario usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario")),
                        Senha = reader.GetString(reader.GetOrdinal("senha")),
                        Grupousuario = grupousuario,
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
                Connect.FecharConexao();
            }
            return usuarios;
        }

    }
}
