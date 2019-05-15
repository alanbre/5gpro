using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class CidadeDAO
    {
        private readonly static ConexaoDAO Connect = ConexaoDAO.GetInstance();


        public Cidade BuscaByID(int cod)
        {
            Cidade cidade = new Cidade();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM cidade WHERE idcidade = @idcidade", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idcidade", cod);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    cidade = new Cidade
                    {
                        CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };
                }
                else
                {
                    cidade = null;
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
            return cidade;
        }

        public List<Cidade> Busca(int codEstado, string nomeCidade)
        {
            List<Cidade> cidades = new List<Cidade>();
            string conCodEstado = codEstado > 0 ? "AND e.idestado = @idestado" : "";
            string conNomeCidade = nomeCidade.Length > 0 ? "AND c.nome LIKE @nomecidade" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT c.idcidade, c.nome AS nomecidade, e.idestado, e.nome AS nomeestado, e.uf
                                             FROM cidade c INNER JOIN estado e 
                                             ON c.idestado = e.idestado
                                             WHERE 1=1
                                             " + conCodEstado + @"
                                             " + conNomeCidade + @"
                                             ORDER BY c.idcidade;", Connect.Conexao);

                if (codEstado > 0) { Connect.Comando.Parameters.AddWithValue("@idestado", codEstado); }
                if (nomeCidade.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nomecidade", "%" + nomeCidade + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    Estado estado = new Estado
                    {
                        EstadoID = reader.GetInt32(reader.GetOrdinal("idestado")),
                        Nome = reader.GetString(reader.GetOrdinal("nomeestado")),
                        Uf = reader.GetString(reader.GetOrdinal("uf"))
                    };

                    Cidade cidade = new Cidade
                    {
                        CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade")),
                        Nome = reader.GetString(reader.GetOrdinal("nomecidade")),
                        Estado = estado
                    };
                    cidades.Add(cidade);
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
            return cidades;
        }
    }
}


