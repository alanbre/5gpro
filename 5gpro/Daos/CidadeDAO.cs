using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace _5gpro.Daos
{
    class CidadeDAO : ConexaoDAO
    {
        public Cidade BuscaCidadeByCod(string cod)
        {
            Cidade cidade = new Cidade();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM cidade WHERE idcidade = @idcidade", Conexao);
                Comando.Parameters.AddWithValue("@idcidade", cod);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    cidade.CodCidade = reader.GetString(reader.GetOrdinal("idcidade"));
                    cidade.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    cidade.CodEstado = reader.GetString(reader.GetOrdinal("idestado"));
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
            return cidade;
        }
    }
}

