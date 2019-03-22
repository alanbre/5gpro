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

        public List<Cidade> BuscaCidades(string codEstado, string nomeCidade)
        {
            List<Cidade> cidades = new List<Cidade>();
            string conCodEstado = codEstado.Length > 0 ? "AND e.idestado = @idestado" : "";
            string conNomeCidade = nomeCidade.Length > 0 ? "AND c.nome LIKE @nomecidade" : "";

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT c.idcidade, c.nome AS nomecidade, e.idestado, e.nome AS nomeestado 
                                             FROM cidade c INNER JOIN estado e 
                                             ON c.idestado = e.idestado
                                             WHERE 1=1
                                             " + conCodEstado + @"
                                             " + conNomeCidade + @"
                                             ORDER BY c.idcidade;", Conexao);

                if (codEstado.Length > 0) { Comando.Parameters.AddWithValue("@idestado", codEstado); }
                if (nomeCidade.Length > 0) { Comando.Parameters.AddWithValue("@nomecidade", "%" + nomeCidade + "%"); }

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Cidade cidade = new Cidade();
                    cidade.CodCidade = reader.GetString(reader.GetOrdinal("idcidade"));
                    cidade.Nome = reader.GetString(reader.GetOrdinal("nomecidade"));
                    Estado estado = new Estado();
                    estado.CodEstado = reader.GetString(reader.GetOrdinal("idestado"));
                    estado.Nome = reader.GetString(reader.GetOrdinal("nomeestado"));
                    cidade.Estado = estado;
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


