using _5gpro.Entities;
using System;
using MySql.Data.MySqlClient;
using System.Data;


namespace _5gpro.Daos
{
    public class LogadoDAO
    {
        public ConexaoDAO Connect { get; }

        public LogadoDAO(ConexaoDAO c)
        {
            Connect = c;
        }



        public Logado BuscaLogadoByUsuario(Usuario usuario)
        {
            Logado usulogado = null;
            UsuarioDAO usuarioDAO = new UsuarioDAO(Connect);
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * FROM logado WHERE idusuario = @idusuario;", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idusuario", usuario.UsuarioID);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        UsuarioID = reader.GetInt32(reader.GetOrdinal("idusuario"))
                    };

                    usulogado = new Logado
                    {
                        Usuario = usuario,
                        Mac = reader.GetString(reader.GetOrdinal("mac")),
                        NomePC = reader.GetString(reader.GetOrdinal("nomepc")),
                        IPdoPC = reader.GetString(reader.GetOrdinal("ipdopc"))
                    };


                    reader.Close();
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

            return usulogado;
        }

        public Logado BuscaLogadoByMac(string mac)
        {
            Logado usulogado = null;
            Usuario usuario = null;
            GrupoUsuario grupousuario = null;

            UsuarioDAO usuarioDAO = new UsuarioDAO(Connect);
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * FROM logado l INNER JOIN usuario u
                                                    ON l.idusuario = u.idusuario
                                                    WHERE mac = @mac;", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@mac", mac);

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
                        Grupousuario = grupousuario
                    };

                    usulogado = new Logado
                    {
                        Usuario = usuario,
                        Mac = reader.GetString(reader.GetOrdinal("mac")),
                        NomePC = reader.GetString(reader.GetOrdinal("nomepc")),
                        IPdoPC = reader.GetString(reader.GetOrdinal("ipdopc"))
                    };

                    reader.Close();

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

            return usulogado;
        }

        //Registra login na tabela Logado
        public int GravarLogado(Usuario usuario, string mac, string nomepc, string ipdopc)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"INSERT INTO logado
                         (idusuario, mac, nomepc, ipdopc, data_update)
                          VALUES
                         (@idusuario, @mac, @nomepc, @ipdopc, @data_update)
                         ;",
                        Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idusuario", usuario.UsuarioID);
                Connect.Comando.Parameters.AddWithValue("@mac", mac);
                Connect.Comando.Parameters.AddWithValue("@nomepc", nomepc);
                Connect.Comando.Parameters.AddWithValue("@ipdopc", ipdopc);
                Connect.Comando.Parameters.AddWithValue("@data_update", DateTime.Now);

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

        //Remove login da tabela Logado
        public int RemoverLogado(string mac)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"DELETE FROM logado WHERE mac = @mac", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@mac", mac);

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

        public void AtualizarLogado(string mac)
        {
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"UPDATE logado SET data_update = NOW() WHERE mac = @mac", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@mac", mac);

                Connect.Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
        }

        public void RemoveTodosLocks(Logado logado)
        {
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("DELETE FROM 5gprodatabase.lock WHERE idusuario = @idusuario", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idusuario", logado.Usuario.UsuarioID);

                Connect.Comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
        }
    }
}
