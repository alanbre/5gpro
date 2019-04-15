using _5gpro.Entities;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    usulogado = new Logado();
                    usulogado.LogadoID = reader.GetInt32(reader.GetOrdinal("idlogado"));
                    usulogado.Usuario = usuarioDAO.BuscarUsuarioById(reader.GetInt32(reader.GetOrdinal("idusuario")));
                    usulogado.Mac = reader.GetString(reader.GetOrdinal("mac"));
                    usulogado.NomePC = reader.GetString(reader.GetOrdinal("nomepc"));
                    usulogado.IPdoPC = reader.GetString(reader.GetOrdinal("ipdopc"));

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
            UsuarioDAO usuarioDAO = new UsuarioDAO(Connect);
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * FROM logado WHERE mac = @mac;", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@mac", mac);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    usulogado = new Logado();
                    usulogado.LogadoID = reader.GetInt32(reader.GetOrdinal("idlogado"));
                    usulogado.Usuario = usuarioDAO.BuscarUsuarioById(reader.GetInt32(reader.GetOrdinal("idusuario")));
                    usulogado.Mac = reader.GetString(reader.GetOrdinal("mac"));
                    usulogado.NomePC = reader.GetString(reader.GetOrdinal("nomepc"));
                    usulogado.IPdoPC = reader.GetString(reader.GetOrdinal("ipdopc"));

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
                         (idusuario, mac, nomepc, ipdopc)
                          VALUES
                         (@idusuario, @mac, @nomepc, @ipdopc)
                         ;",
                        Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idusuario", usuario.UsuarioID);
                Connect.Comando.Parameters.AddWithValue("@mac", mac);
                Connect.Comando.Parameters.AddWithValue("@nomepc", nomepc);
                Connect.Comando.Parameters.AddWithValue("@ipdopc", ipdopc);

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

    }
}
