using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class EstadoDAO : ConexaoDAO
    {
        public Estado BuscaEstadoByCod(string cod)
        {
            Estado estado = new Estado();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM estado WHERE idestado = @idestado", Conexao);
                Comando.Parameters.AddWithValue("@idestado", cod);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    estado.CodEstado = reader.GetString(reader.GetOrdinal("idestado"));
                    estado.Nome = reader.GetString(reader.GetOrdinal("nome"));
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
            return estado;
        }

        public List<Estado> BuscaEstadoByNome(string nome)
        {
            List<Estado> estados = new List<Estado>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM estado WHERE nome LIKE @nome", Conexao);
                Comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Estado estado = new Estado();
                    estado.CodEstado = reader.GetString(reader.GetOrdinal("idestado"));
                    estado.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    estados.Add(estado);
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
            return estados;
        }
    }
}
