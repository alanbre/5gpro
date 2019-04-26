using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class ContaReceberDAO
    {
        static private ConexaoDAO Connect { get; set; }
        private OperacaoDAO operacaoDAO = new OperacaoDAO(Connect);

        public ContaReceberDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        public int SalvaOuAtualiza(ContaReceber contaReceber)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;


                Connect.Comando.CommandText = @"INSERT INTO conta_receber
                         (idconta_receber, data_cadastro, idoperacao, valor_original, multa, juros, valor_final)
                          VALUES
                         (@idconta_receber, @data_cadastro, @idoperacao, @valor_original, @multa, @juros, @valor_final)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, idoperacao = @idoperacao, valor_original = @valor_original,
                          multa = @multa, juros = @juros, valor_final = @valor_final
                          ";

                Connect.Comando.Parameters.AddWithValue("@idconta_receber", contaReceber.ContaReceberID);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro", contaReceber.DataCadastro);
                Connect.Comando.Parameters.AddWithValue("@idoperacao", contaReceber.Operacao.OperacaoID);
                Connect.Comando.Parameters.AddWithValue("@valor_original", contaReceber.ValorOriginal);
                Connect.Comando.Parameters.AddWithValue("@multa", contaReceber.Multa);
                Connect.Comando.Parameters.AddWithValue("@juros", contaReceber.Juros);
                Connect.Comando.Parameters.AddWithValue("@valor_final", contaReceber.ValorFinal);


                retorno = Connect.Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Connect.Comando.CommandText = @"DELETE FROM parcela WHERE idconta_receber = @idconta_receber";
                    Connect.Comando.ExecuteNonQuery();

                    Connect.Comando.CommandText = @"INSERT INTO parcela
                                            (sequencia, data_vencimento, valor, multa, juros, data_quitacao)
                                            VALUES
                                            (@sequencia, @data_vencimento, @valor, @multa, @juros, @data_quitacao)";
                    foreach (Parcela parcela in contaReceber.Parcelas)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@sequencia", parcela.Sequencia);
                        Connect.Comando.Parameters.AddWithValue("@data_vencimento", parcela.Sequencia);
                        Connect.Comando.Parameters.AddWithValue("@valor", parcela.Valor);
                        Connect.Comando.Parameters.AddWithValue("@multa", parcela.Multa);
                        Connect.Comando.Parameters.AddWithValue("@juros", parcela.Juros);
                        Connect.Comando.Parameters.AddWithValue("@data_quitacao", parcela.DataQuitacao);
                        Connect.Comando.ExecuteNonQuery();
                    }
                }
                Connect.tr.Commit();
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

        public ContaReceber BuscaById(int codigo)
        {
            ContaReceber contaReceber = new ContaReceber();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM conta_receber WHERE idconta_receber = @idconta_receber", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaReceber = new ContaReceber
                        {
                            ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };
                        contaReceber.Operacao = new Operacao();
                        contaReceber.Operacao.OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao"));
                    }
                    else
                    {
                        contaReceber = null;
                    }
                }

                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela p INNER JOIN forma_pagamento fp
                                                     ON p.idformapagamento = fp.idformapagamento 
                                                     WHERE idconta_receber = @idconta_receber)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Parcela parcela = new Parcela
                        {
                            ParcelaID = reader.GetInt32(reader.GetOrdinal("idparcela")),
                            DataQuitacao = reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                            DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Sequencia = reader.GetInt32(reader.GetOrdinal("sequencia")),
                            Valor = reader.GetDecimal(reader.GetOrdinal("valor"))
                        };

                        //forma de pagamento
                    }
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

            if (contaReceber != null)
                contaReceber.Operacao = operacaoDAO.BuscarOperacaoById(contaReceber.Operacao.OperacaoID);
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
            var parcelas = new List<Parcela>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM conta_receber WHERE idconta_receber = (SELECT min(idconta_receber) FROM conta_receber WHERE idconta_receber > @idconta_receber)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaReceber = new ContaReceber
                        {
                            ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };
                        contaReceber.Operacao = new Operacao();
                        contaReceber.Operacao.OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao"));
                    }
                    else
                    {
                        contaReceber = null;
                    }
                }

                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela p INNER JOIN forma_pagamento fp
                                                     ON p.idformapagamento = fp.idformapagamento 
                                                     WHERE idconta_receber = @idconta_receber)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Parcela parcela = new Parcela
                        {
                            ParcelaID = reader.GetInt32(reader.GetOrdinal("idparcela")),
                            DataQuitacao = reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                            DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Sequencia  = reader.GetInt32(reader.GetOrdinal("sequencia")),
                            Valor = reader.GetDecimal(reader.GetOrdinal("valor"))
                        };

                        //forma de pagamento
                    }
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

            if (contaReceber != null)
                contaReceber.Operacao = operacaoDAO.BuscarOperacaoById(contaReceber.Operacao.OperacaoID);
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

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaReceber = new ContaReceber
                        {
                            ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };
                        contaReceber.Operacao = new Operacao();
                        contaReceber.Operacao.OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao"));
                    }
                    else
                    {
                        contaReceber = null;
                    }
                }

                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela p INNER JOIN forma_pagamento fp
                                                     ON p.idformapagamento = fp.idformapagamento 
                                                     WHERE idconta_receber = @idconta_receber)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Parcela parcela = new Parcela
                        {
                            ParcelaID = reader.GetInt32(reader.GetOrdinal("idparcela")),
                            DataQuitacao = reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                            DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Sequencia = reader.GetInt32(reader.GetOrdinal("sequencia")),
                            Valor = reader.GetDecimal(reader.GetOrdinal("valor"))
                        };

                        //forma de pagamento
                    }
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

            if (contaReceber != null)
                contaReceber.Operacao = operacaoDAO.BuscarOperacaoById(contaReceber.Operacao.OperacaoID);
            return contaReceber;
        }


    }
}
