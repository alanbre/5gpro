using _5gpro.Bll;
using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class CidadeDAO : ConexaoDAO
    {
        public EstadoBLL estadoBLL = new EstadoBLL();


        public Cidade BuscaCidadeByCod(int cod)
        {
            Cidade cidade = new Cidade();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM cidade WHERE idcidade = @idcidade", Conexao);
                Comando.Parameters.AddWithValue("@idcidade", cod);

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }
            return cidade;
        }

        public List<Cidade> BuscaCidades(int codEstado, string nomeCidade)
        {
            List<Cidade> cidades = new List<Cidade>();
            string conCodEstado = codEstado > 0 ? "AND e.idestado = @idestado" : "";
            string conNomeCidade = nomeCidade.Length > 0 ? "AND c.nome LIKE @nomecidade" : "";

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT c.idcidade, c.nome AS nomecidade, e.idestado, e.nome AS nomeestado, e.uf
                                             FROM cidade c INNER JOIN estado e 
                                             ON c.idestado = e.idestado
                                             WHERE 1=1
                                             " + conCodEstado + @"
                                             " + conNomeCidade + @"
                                             ORDER BY c.idcidade;", Conexao);

                if (codEstado > 0) { Comando.Parameters.AddWithValue("@idestado", codEstado); }
                if (nomeCidade.Length > 0) { Comando.Parameters.AddWithValue("@nomecidade", "%" + nomeCidade + "%"); }

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }
            return cidades;
        }
    }
}


