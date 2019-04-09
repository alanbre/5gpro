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
    class LogadoDAO : ConexaoDAO
    {
        public UsuarioDAO usuarioDAO = new UsuarioDAO();

        public Logado BuscaLogado(Usuario usuario)
        {
            Logado usulogado = null;

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * FROM logado WHERE idusuario = @idusuario;", Conexao);

                Comando.Parameters.AddWithValue("@idusuario", usuario.UsuarioID);

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }

            return usulogado;
        }

        //Registra login na tabela Logado
        public int GravarLogado(Usuario usuario, string mac, string nomepc, string ipdopc)
        {
            int retorno = 0;
            try
            {
                AbrirConexao();
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;


                Comando.CommandText = @"INSERT INTO logado
                         (idusuario, mac, nomepc, ipdopc)
                          VALUES
                         (@idusuario, @mac, @nomepc, @ipdopc)
                          ";

                Comando.Parameters.AddWithValue("@idusuario", usuario.UsuarioID);
                Comando.Parameters.AddWithValue("@mac", mac);
                Comando.Parameters.AddWithValue("@nomepc", nomepc);
                Comando.Parameters.AddWithValue("@ipdopc", ipdopc);

                retorno = Comando.ExecuteNonQuery();

                tr.Commit();
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

        //Remove login da tabela Logado
        public int RemoverLogado(Usuario usuario)
        {
            int retorno = 0;
            try
            {
                AbrirConexao();
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;


                Comando.CommandText = @"DELETE FROM logado WHERE idusuario = @idusuario";

                Comando.Parameters.AddWithValue("@idusuario", usuario.UsuarioID);

                retorno = Comando.ExecuteNonQuery();

                tr.Commit();
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

    }
}
