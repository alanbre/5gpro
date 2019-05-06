using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class ContaPagarDAO
    {
        private static ConexaoDAO Connect;
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
                         (idconta_pagar, data_cadastro, valor_original, multa, juros, valor_final, idpessoa)
                          VALUES
                         (@idconta_pagar, @data_cadastro, @valor_original, @multa, @juros, @valor_final, @idpessoa)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, valor_original = @valor_original, multa = @multa,
                          juros = @juros, valor_final = @valor_final, idpessoa = @idpessoa
                          ";

                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", contaPagar.ContaPagarID);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro", contaPagar.DataCadastro);
                Connect.Comando.Parameters.AddWithValue("@valor_original", contaPagar.ValorOriginal);
                Connect.Comando.Parameters.AddWithValue("@multa", contaPagar.Multa);
                Connect.Comando.Parameters.AddWithValue("@juros", contaPagar.Juros);
                Connect.Comando.Parameters.AddWithValue("@valor_final", contaPagar.ValorFinal);
                Connect.Comando.Parameters.AddWithValue("@idpessoa", contaPagar.Pessoa.PessoaID);


                retorno = Connect.Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Connect.Comando.CommandText = @"DELETE FROM parcela_conta_pagar WHERE idconta_pagar = @idconta_pagar";
                    Connect.Comando.ExecuteNonQuery();

                    Connect.Comando.CommandText = @"INSERT INTO parcela_conta_pagar
                                            (sequencia, data_vencimento, valor, multa, juros, valor_final, data_quitacao, idconta_pagar, idformapagamento)
                                            VALUES
                                            (@sequencia, @data_vencimento, @valor, @multa, @juros, @valor_final, @data_quitacao, @idconta_pagar, @idformapagamento)";
                    foreach (ParcelaContaPagar parcela in contaPagar.Parcelas)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@sequencia", parcela.Sequencia);
                        Connect.Comando.Parameters.AddWithValue("@data_vencimento", parcela.DataVencimento);
                        Connect.Comando.Parameters.AddWithValue("@valor", parcela.Valor);
                        Connect.Comando.Parameters.AddWithValue("@multa", parcela.Multa);
                        Connect.Comando.Parameters.AddWithValue("@juros", parcela.Juros);
                        Connect.Comando.Parameters.AddWithValue("@valor_final", parcela.ValorFinal);
                        Connect.Comando.Parameters.AddWithValue("@data_quitacao", parcela.DataQuitacao);
                        Connect.Comando.Parameters.AddWithValue("@idconta_pagar", contaPagar.ContaPagarID);
                        Connect.Comando.Parameters.AddWithValue("@idformapagamento", parcela.FormaPagamento?.FormaPagamentoID ?? null);
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
                    contaPagar = LeDadosReader(reader);
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
                contaPagar.Parcelas = BuscaParcelasDaConta(contaPagar);
            return contaPagar;
        }
        public IEnumerable<ContaPagar> Busca(fmBuscaContaPagar.Filtros f)
        {
            var contaPagars = new List<ContaPagar>();
            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            Pessoa pessoa = null;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT cp.idconta_pagar, p.idpessoa, p.nome, cp.data_cadastro,
                                                    cp.valor_original, cp.multa, cp.juros, cp.valor_final
                                                    FROM 
                                                    conta_pagar cp 
                                                    LEFT JOIN pessoa p ON cp.idpessoa = p.idpessoa
                                                    LEFT JOIN parcela_conta_pagar pa ON pa.idconta_pagar = cp.idconta_pagar
                                                    WHERE 1 = 1"
                                             + wherePessoa + "" +
                                          @" AND cp.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final
                                             AND cp.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final
                                             AND pa.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final
                                             GROUP BY cp.idconta_pagar", Connect.Conexao);
                if (f.filtroPessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", f.filtroPessoa.PessoaID); }

                Connect.Comando.Parameters.AddWithValue("@valor_conta_inicial", f.filtroValorInicial);
                Connect.Comando.Parameters.AddWithValue("@valor_conta_final", f.filtroValorFinal);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro_final", f.filtroDataCadastroFinal);
                Connect.Comando.Parameters.AddWithValue("@data_vencimento_inicial", f.filtroDataVencimentoInicial);
                Connect.Comando.Parameters.AddWithValue("@data_vencimento_final", f.filtroDataVencimentoFinal);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pessoa = new Pessoa
                        {
                            PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nome"))
                        };

                        var contaPagar = new ContaPagar
                        {
                            ContaPagarID = reader.GetInt32(reader.GetOrdinal("idconta_pagar")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };

                        contaPagar.Pessoa = pessoa;
                        contaPagars.Add(contaPagar);
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
            return contaPagars;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT cp1.idconta_pagar + 1 AS proximoid
                                             FROM conta_pagar AS cp1
                                             LEFT OUTER JOIN conta_pagar AS cp2 ON cp1.idconta_pagar + 1 = cp2.idconta_pagar
                                             WHERE cp2.idconta_pagar IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Connect.Conexao);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        proximoid = reader.GetInt32(reader.GetOrdinal("proximoid"));
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
                    contaPagar = LeDadosReader(reader);
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
                contaPagar.Parcelas = BuscaParcelasDaConta(contaPagar);
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
                    contaPagar = LeDadosReader(reader);
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
                contaPagar.Parcelas = BuscaParcelasDaConta(contaPagar);
            return contaPagar;
        }
        private ContaPagar LeDadosReader(IDataReader reader)
        {
            var contaPagar = new ContaPagar();
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
                contaPagar.Pessoa = new Pessoa();
                contaPagar.Pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
            }
            else
            {
                contaPagar = null;
            }
            return contaPagar;
        }
        private List<ParcelaContaPagar> BuscaParcelasDaConta(ContaPagar contaPagar)
        {
            var parcelas = new List<ParcelaContaPagar>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela_conta_pagar p LEFT JOIN formapagamento fp
                                                     ON p.idformapagamento = fp.idformapagamento 
                                                     WHERE idconta_pagar = @idconta_pagar", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_pagar", contaPagar.ContaPagarID);
                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParcelaContaPagar parcela = new ParcelaContaPagar
                        {
                            ParcelaContaPagarID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_pagar")),
                            DataQuitacao = reader.IsDBNull(reader.GetOrdinal("data_quitacao")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                            DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Sequencia = reader.GetInt32(reader.GetOrdinal("sequencia")),
                            Valor = reader.GetDecimal(reader.GetOrdinal("valor"))
                        };
                        parcelas.Add(parcela);
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

            return parcelas;
        }
    }
}

