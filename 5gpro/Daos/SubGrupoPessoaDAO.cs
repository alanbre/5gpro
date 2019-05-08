using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class SubGrupoPessoaDAO
    {
        public ConexaoDAO Connect { get; }
        public SubGrupoPessoaDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        public int SalvarOuAtualizar(SubGrupoPessoa subgrupoipessoa)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"INSERT INTO subgrupopessoa 
                          (idsubgrupopessoa, nome, idgrupopessoa) 
                          VALUES
                          (@idsubgrupopessoa, @nome, @idgrupopessoa)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome, idgrupopessoa = @idgrupopessoa
                         ;",
                         Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idsubgrupopessoa", subgrupoipessoa.SubGrupoPessoaID);
                Connect.Comando.Parameters.AddWithValue("@nome", subgrupoipessoa.Nome);
                Connect.Comando.Parameters.AddWithValue("@idgrupopessoa", subgrupoipessoa.GrupoPessoa.GrupoPessoaID);

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

        public IEnumerable<SubGrupoPessoa> BuscaTodos(string nome, int grupopessoaID)
        {
            List<SubGrupoPessoa> listasubgrupopessoa = new List<SubGrupoPessoa>();
            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = null;

            string conNome = nome.Length > 0 ? "AND g.nome LIKE @nome" : "";
            string conGrupoPessoa = "AND g.idgrupopessoa = @idgrupopessoa";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM subgrupopessoa g 
                                             WHERE 1=1
                                             " + conGrupoPessoa + @"
                                             " + conNome + @"
                                             ORDER BY g.nome;", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupopessoa", grupopessoaID);
                if (nome.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    grupopessoa = new GrupoPessoa
                    {
                        GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa"))
                    };

                    subgrupopessoa = new SubGrupoPessoa
                    {
                        SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idsubgrupopessoa")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        GrupoPessoa = grupopessoa
                    };

                    listasubgrupopessoa.Add(subgrupopessoa);
                }

                reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
            return listasubgrupopessoa;
        }

        public SubGrupoPessoa BuscarByID(int Codigo, int grupopessoaID)
        {

            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM subgrupopessoa g 
                                             WHERE g.idsubgrupopessoa = @idsubgrupopessoa
                                             AND g.idgrupopessoa = @idgrupopessoa
                                             ", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idsubgrupopessoa", Codigo);
                Connect.Comando.Parameters.AddWithValue("@idgrupopessoa", grupopessoaID);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    grupopessoa = new GrupoPessoa
                    {
                        GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa"))
                    };

                    subgrupopessoa = new SubGrupoPessoa
                    {
                        SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idsubgrupopessoa")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        GrupoPessoa = grupopessoa
                    };
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }

            return subgrupopessoa;
        }

        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT i1.idsubgrupopessoa + 1 AS proximoid
                                             FROM subgrupopessoa AS i1
                                             LEFT OUTER JOIN subgrupopessoa AS i2 ON i1.idsubgrupopessoa + 1 = i2.idsubgrupopessoa
                                             WHERE i2.idsubgrupopessoa IS NULL
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

        public int Remover(string idsub)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"DELETE FROM subgrupopessoa WHERE idsubgrupopessoa = @idsubgrupopessoa", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idsubgrupopessoa", idsub);

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
