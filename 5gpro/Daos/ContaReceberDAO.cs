using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace _5gpro.Daos
{
    class ContaReceberDAO
    {
        public ConexaoDAO Connect { get; }

        public ContaReceberDAO(ConexaoDAO c)
        {
            Connect = c;
        }


        public ContaReceber BuscaById(int codigo)
        {
            ContaReceber contaReceber = new ContaReceber();

            return contaReceber;
        }

        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT cr1.idconta_receber + 1 AS proximoid
                                             FROM conta_receber AS cr1
                                             LEFT OUTER JOIN conta_receber AS cr2 ON cr1.idconta_receber + 1 = cr2.idconta_receber
                                             WHERE cr2.idconta_receber IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Connect.Conexao);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    proximoid = reader.GetInt32(reader.GetOrdinal("proximoid"));
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

            return proximoid;
        }

        public ContaReceber BuscaProximo(int codigo)
        {
            var contaReceber = new ContaReceber();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM conta_receber WHERE idconta_receber = (SELECT min(idconta_receber) FROM conta_receber WHERE idconta_receber > @idconta_receber)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    contaReceber = new ContaReceber
                    {
                        ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber")),
                        
                    };
                    reader.Close();
                }
                else
                {
                    contaReceber = null;
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

            return contaReceber;
        }

        public ContaReceber BuscaAnterior(int codigo)
        {
            var contaReceber = new ContaReceber();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM conta_receber WHERE idconta_receber = (SELECT max(idconta_receber) FROM conta_receber WHERE idconta_receber < @idconta_receber)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    contaReceber = new ContaReceber
                    {
                        ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber")),

                    };
                    reader.Close();
                }
                else
                {
                    contaReceber = null;
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

            return contaReceber;
        }
    }
}
