using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class ContaPagarDAO
    {
        static private ConexaoDAO Connect { get; set; }
        private OperacaoDAO operacaoDAO = new OperacaoDAO(Connect);

        public ContaPagarDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        public int SalvaOuAtualiza(ContaPagar contaPagar)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;


                Connect.Comando.CommandText = @"INSERT INTO conta_pagar
                         (idconta_pagar, data_cadastro, idoperacao, valor_original, multa, juros, valor_final)
                          VALUES
                         (@idconta_pagar, @data_cadastro, @idoperacao, @valor_original, @multa, @juros, @valor_final)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, idoperacao = @idoperacao, valor_original = @valor_original,
                          multa = @multa, juros = @juros, valor_final = @valor_final
                          ";

                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", contaPagar.ContaPagarID);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro", contaPagar.DataCadastro);
                Connect.Comando.Parameters.AddWithValue("@idoperacao", contaPagar.Operacao.OperacaoID);
                Connect.Comando.Parameters.AddWithValue("@valor_original", contaPagar.ValorOriginal);
                Connect.Comando.Parameters.AddWithValue("@multa", contaPagar.Multa);
                Connect.Comando.Parameters.AddWithValue("@juros", contaPagar.Juros);
                Connect.Comando.Parameters.AddWithValue("@valor_final", contaPagar.ValorFinal);


                retorno = Connect.Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Connect.Comando.CommandText = @"DELETE FROM parcela_conta_pagar WHERE idconta_pagar = @idconta_pagar";
                    Connect.Comando.ExecuteNonQuery();

                    Connect.Comando.CommandText = @"INSERT INTO parcela_conta_pagar
                                            (sequencia, data_vencimento, valor, multa, juros, data_quitacao, idconta_pagar, id_formapagamento)
                                            VALUES
                                            (@sequencia, @data_vencimento, @valor, @multa, @juros, @data_quitacao, @idconta_pagar, @id_formapagamento)";
                    foreach (ParcelaContaPagar parcela in contaPagar.Parcelas)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@sequencia", parcela.Sequencia);
                        Connect.Comando.Parameters.AddWithValue("@data_vencimento", parcela.Sequencia);
                        Connect.Comando.Parameters.AddWithValue("@valor", parcela.Valor);
                        Connect.Comando.Parameters.AddWithValue("@multa", parcela.Multa);
                        Connect.Comando.Parameters.AddWithValue("@juros", parcela.Juros);
                        Connect.Comando.Parameters.AddWithValue("@data_quitacao", parcela.DataQuitacao);
                        Connect.Comando.Parameters.AddWithValue("@idconta_pagar", contaPagar.ContaPagarID);
                        Connect.Comando.Parameters.AddWithValue("@id_formapagamento", parcela.FormaPagamento.FormaPagamentoID);
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

        public ContaPagar BuscaById(int codigo)
        {
            var contaPagar = new ContaPagar();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM conta_pagar WHERE idconta_pagar = @idconta_pagar", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaPagar = new ContaPagar
                        {
                            ContaPagarID = reader.GetInt32(reader.GetOrdinal("idconta_pagar")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };
                        contaPagar.Operacao = new Operacao();
                        contaPagar.Operacao.OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao"));
                    }
                    else
                    {
                        contaPagar = null;
                    }
                }

                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela_conta_pagar p INNER JOIN formapagamento fp
                                                     ON p.idformapagamento = fp.idformapagamento 
                                                     WHERE idconta_pagar = @idconta_pagar)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var parcela = new ParcelaContaPagar
                        {
                            ParcelaContaPagarID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_pagar")),
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

            if (contaPagar != null)
                contaPagar.Operacao = operacaoDAO.BuscarOperacaoById(contaPagar.Operacao.OperacaoID);
            return contaPagar;
        }

        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT cr1.idconta_pagar + 1 AS proximoid
                                             FROM conta_pagar AS cr1
                                             LEFT OUTER JOIN conta_pagar AS cr2 ON cr1.idconta_pagar + 1 = cr2.idconta_pagar
                                             WHERE cr2.idconta_pagar IS NULL
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

        public ContaPagar BuscaProximo(int codigo)
        {
            var contaPagar = new ContaPagar();
            var parcelas = new List<ParcelaContaPagar>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM conta_pagar WHERE idconta_pagar = (SELECT min(idconta_pagar) FROM conta_pagar WHERE idconta_pagar > @idconta_pagar)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaPagar = new ContaPagar
                        {
                            ContaPagarID = reader.GetInt32(reader.GetOrdinal("idconta_pagar")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };
                        contaPagar.Operacao = new Operacao();
                        contaPagar.Operacao.OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao"));
                    }
                    else
                    {
                        contaPagar = null;
                    }
                }

                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela_conta_pagar p INNER JOIN formapagamento fp
                                                     ON p.idformapagamento = fp.idformapagamento 
                                                     WHERE idconta_pagar = @idconta_pagar)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParcelaContaPagar parcela = new ParcelaContaPagar
                        {
                            ParcelaContaPagarID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_pagar")),
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

            if (contaPagar != null)
                contaPagar.Operacao = operacaoDAO.BuscarOperacaoById(contaPagar.Operacao.OperacaoID);
            return contaPagar;
        }

        public ContaPagar BuscaAnterior(int codigo)
        {
            var contaPagar = new ContaPagar();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM conta_pagar WHERE idconta_pagar = (SELECT max(idconta_pagar) FROM conta_pagar WHERE idconta_pagar < @idconta_pagar)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        contaPagar = new ContaPagar
                        {
                            ContaPagarID = reader.GetInt32(reader.GetOrdinal("idconta_pagar")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };
                        contaPagar.Operacao = new Operacao();
                        contaPagar.Operacao.OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao"));
                    }
                    else
                    {
                        contaPagar = null;
                    }
                }

                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela_conta_pagar p INNER JOIN formapagamento fp
                                                     ON p.idformapagamento = fp.idformapagamento 
                                                     WHERE idconta_pagar = @idconta_pagar)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParcelaContaPagar parcela = new ParcelaContaPagar
                        {
                            ParcelaContaPagarID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_pagar")),
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

            if (contaPagar != null)
                contaPagar.Operacao = operacaoDAO.BuscarOperacaoById(contaPagar.Operacao.OperacaoID);
            return contaPagar;
        }
    }
}
