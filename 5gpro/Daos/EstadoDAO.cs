using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class EstadoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public Estado BuscaEstadoByCod(int cod)
        {
            Estado estado = new Estado();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM estado WHERE idestado = @idestado", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idestado", cod);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    estado = new Estado
                    {
                        EstadoID = reader.GetInt32(reader.GetOrdinal("idestado")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };
                }
                else
                {
                    estado = null;
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
            return estado;
        }

        public List<Estado> BuscaEstadoByNome(string nome)
        {
            List<Estado> estados = new List<Estado>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM estado WHERE nome LIKE @nome", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    Estado estado = new Estado
                    {
                        EstadoID = reader.GetInt32(reader.GetOrdinal("idestado")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };
                    estados.Add(estado);
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
            return estados;
        }
    }
}
