using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class ContaReceberDAO
    {
        private readonly static ConexaoDAO Connect = ConexaoDAO.GetInstance();


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
                         (idconta_receber, data_cadastro, data_conta, idoperacao, valor_original, multa, juros, acrescimo, desconto, valor_final, idpessoa, situacao)
                          VALUES
                         (@idconta_receber, @data_cadastro, @data_conta, @idoperacao, @valor_original, @multa, @juros, @acrescimo, @desconto, @valor_final, @idpessoa, @situacao)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, data_conta = @data_conta, idoperacao = @idoperacao, valor_original = @valor_original,
                          multa = @multa, juros = @juros, acrescimo = @acrescimo, desconto = @desconto, valor_final = @valor_final, idpessoa = @idpessoa, situacao = @situacao
                          ";

                Connect.Comando.Parameters.AddWithValue("@idconta_receber", contaReceber.ContaReceberID);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro", contaReceber.DataCadastro);
                Connect.Comando.Parameters.AddWithValue("@idoperacao", contaReceber.Operacao.OperacaoID);
                Connect.Comando.Parameters.AddWithValue("@valor_original", contaReceber.ValorOriginal);
                Connect.Comando.Parameters.AddWithValue("@multa", contaReceber.Multa);
                Connect.Comando.Parameters.AddWithValue("@juros", contaReceber.Juros);
                Connect.Comando.Parameters.AddWithValue("@acrescimo", contaReceber.Acrescimo);
                Connect.Comando.Parameters.AddWithValue("@desconto", contaReceber.Desconto);
                Connect.Comando.Parameters.AddWithValue("@valor_final", contaReceber.ValorFinal);
                Connect.Comando.Parameters.AddWithValue("@idpessoa", contaReceber.Pessoa.PessoaID);
                Connect.Comando.Parameters.AddWithValue("@situacao", contaReceber.Situacao);
                Connect.Comando.Parameters.AddWithValue("@data_conta", contaReceber.DataConta);



                retorno = Connect.Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Connect.Comando.CommandText = @"DELETE FROM parcela_conta_receber WHERE idconta_receber = @idconta_receber";
                    Connect.Comando.ExecuteNonQuery();

                    Connect.Comando.CommandText = @"INSERT INTO parcela_conta_receber
                                            (sequencia, data_vencimento, valor, multa, juros, acrescimo, desconto, valor_final, data_quitacao, idconta_receber, idformapagamento, situacao)
                                            VALUES
                                            (@sequencia, @data_vencimento, @valor, @multa, @juros, @acrescimo, @desconto, @valor_final, @data_quitacao, @idconta_receber, @idformapagamento, @situacao)";

                    foreach (var parcela in contaReceber.Parcelas)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@sequencia", parcela.Sequencia);
                        Connect.Comando.Parameters.AddWithValue("@data_vencimento", parcela.DataVencimento);
                        Connect.Comando.Parameters.AddWithValue("@valor", parcela.Valor);
                        Connect.Comando.Parameters.AddWithValue("@multa", parcela.Multa);
                        Connect.Comando.Parameters.AddWithValue("@juros", parcela.Juros);
                        Connect.Comando.Parameters.AddWithValue("@acrescimo", parcela.Acrescimo);
                        Connect.Comando.Parameters.AddWithValue("@desconto", parcela.Desconto);
                        Connect.Comando.Parameters.AddWithValue("@valor_final", parcela.ValorFinal);
                        Connect.Comando.Parameters.AddWithValue("@data_quitacao", parcela.DataQuitacao);
                        Connect.Comando.Parameters.AddWithValue("@idconta_receber", contaReceber.ContaReceberID);
                        Connect.Comando.Parameters.AddWithValue("@idformapagamento", parcela.FormaPagamento?.FormaPagamentoID ?? null);
                        Connect.Comando.Parameters.AddWithValue("@situacao", contaReceber.Situacao);
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
            var contaReceber = new ContaReceber();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                                                    p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                                                    p.desconto AS pdesconto, p.valor_final AS pvalor_final  
                                                    FROM conta_receber AS c
                                                    LEFT JOIN parcela_conta_receber AS p 
                                                    ON  c.idconta_receber = p.idconta_receber
                                                    LEFT JOIN formapagamento f
                                                    ON f.idformapagamento = p.idformapagamento
                                                    WHERE c.idconta_receber = @idconta_receber"
                                                    , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    contaReceber = LeDadosReader(reader);
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

        public IEnumerable<ContaReceber> Busca(fmBuscaContaReceber.Filtros f )
        {
            var contaRecebers = new List<ContaReceber>();
            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            string whereOperacao = f.filtroOperacao != null ? "AND op.idoperacao = @idoperacao": "";
            string whereValorFinal = f.usarvalorContaFiltro ? "AND cr.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final" : "";
            string whereDatCadastro = f.usardataCadastroFiltro ? "AND cr.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataVencimento = f.usardataVencimentoFiltro ? "AND pa.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final" : "";

            Operacao operacao = null;
            Pessoa pessoa = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT cr.idconta_receber, p.idpessoa, p.nome, cr.data_cadastro, cr.data_conta,
                                                    op.idoperacao, op.nome as nomeoperacao, cr.valor_original, cr.multa, cr.juros,
                                                    cr.valor_final, cr.acrescimo, cr.desconto, pa.data_vencimento
                                                    FROM conta_receber cr 
                                                    LEFT JOIN operacao op ON cr.idoperacao = op.idoperacao
                                                    LEFT JOIN pessoa p ON cr.idpessoa = p.idpessoa
                                                    LEFT JOIN parcela_conta_receber pa ON pa.idconta_receber = cr.idconta_receber
                                                    WHERE 1 = 1 "
                                             + wherePessoa + " "
                                             + whereOperacao + " "
                                             + whereValorFinal + " "
                                             + whereDatCadastro + " "
                                             + whereDataVencimento + " " 
                                             +"GROUP BY cr.idconta_receber", Connect.Conexao);

                if (f.filtroPessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", f.filtroPessoa.PessoaID); }
                if (f.filtroOperacao != null) { Connect.Comando.Parameters.AddWithValue("@idoperacao", f.filtroOperacao.OperacaoID); }

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

                        operacao = new Operacao
                        {
                            OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao")),
                            Nome = reader.GetString(reader.GetOrdinal("nomeoperacao"))
                        };

                        var contaReceber = new ContaReceber
                        {
                            ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            DataConta = reader.GetDateTime(reader.GetOrdinal("data_conta")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo")),
                            Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };

                        contaReceber.Pessoa = pessoa;
                        contaReceber.Operacao = operacao;
                        contaRecebers.Add(contaReceber);
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
            return contaRecebers;
        }

        public IEnumerable<ContaReceber> Busca(fmCarQuitacaoConta.Filtros f)
        {
            var contaRecebers = new List<ContaReceber>();
            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            string whereConta = f.filtroConta > 0 ? "AND cr.idconta_receber = @idconta_receber" : "";


            Pessoa pessoa = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * 
                                                    FROM conta_receber cr
                                                    LEFT JOIN parcela_conta_receber pcr
	                                                    ON cr.idconta_receber = pcr.idconta_receber
                                                    LEFT JOIN pessoa p
	                                                    ON p.idpessoa = cr.idpessoa
                                                    WHERE 1=1 "
                                                    + wherePessoa + ""
                                                    + whereConta + "" +
                                                    @"AND pcr.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final
                                                      AND cr.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final
                                                      AND pcr.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final
                                                      AND pcr.data_quitacao IS NULL
                                                      GROUP BY cr.idconta_receber", Connect.Conexao);
                if (f.filtroPessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", f.filtroPessoa.PessoaID); }
                if (f.filtroConta > 0) { Connect.Comando.Parameters.AddWithValue("@idconta_receber", f.filtroConta); }

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

                        
                        var contaReceber = new ContaReceber
                        {
                            ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber")),
                            DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                            DataConta = reader.GetDateTime(reader.GetOrdinal("data_conta")),
                            ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo")),
                            Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                            ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                        };

                        contaReceber.Pessoa = pessoa;
                        contaRecebers.Add(contaReceber);
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

            foreach (var contaReceber in contaRecebers)
                contaReceber.Parcelas = BuscaParcelasDaConta(contaReceber);

            return contaRecebers;
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


        public ContaReceber BuscaProximo(int codigo)
        {
            var contaReceber = new ContaReceber();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                                                    p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                                                    p.desconto AS pdesconto, p.valor_final AS pvalor_final  
                                                    FROM conta_receber AS c
                                                    LEFT JOIN parcela_conta_receber AS p 
                                                    ON  c.idconta_receber = p.idconta_receber
                                                    LEFT JOIN formapagamento f
                                                    ON f.idformapagamento = p.idformapagamento
                                                    WHERE c.idconta_receber = (SELECT min(idconta_receber) 
                                                    FROM conta_receber 
                                                    WHERE idconta_receber > @idconta_receber)"
                                                    , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    contaReceber = LeDadosReader(reader);
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
                Connect.Comando = new MySqlCommand(@"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                                                    p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                                                    p.desconto AS pdesconto, p.valor_final AS pvalor_final  
                                                    FROM conta_receber AS c
                                                    LEFT JOIN parcela_conta_receber AS p 
                                                    ON  c.idconta_receber = p.idconta_receber
                                                    LEFT JOIN formapagamento f
                                                    ON f.idformapagamento = p.idformapagamento
                                                    WHERE c.idconta_receber = (SELECT max(idconta_receber) 
                                                    FROM conta_receber 
                                                    WHERE idconta_receber < @idconta_receber)"
                                                    , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idconta_receber", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    contaReceber = LeDadosReader(reader);
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


        private List<ParcelaContaReceber> BuscaParcelasDaConta(ContaReceber contaReceber)
        {
            var parcelas = new List<ParcelaContaReceber>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela_conta_receber p LEFT JOIN formapagamento fp
                                                     ON p.idformapagamento = fp.idformapagamento 
                                                     WHERE idconta_receber = @idconta_receber", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idconta_receber", contaReceber.ContaReceberID);
                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ParcelaContaReceber parcela = new ParcelaContaReceber
                        {
                            ParcelaContaReceberID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_receber")),
                            DataQuitacao = reader.IsDBNull(reader.GetOrdinal("data_quitacao")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                            DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                            Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                            Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                            Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo")),
                            Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
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

        private ContaReceber LeDadosReader(IDataReader reader)
        {
            ContaReceber contaReceber = null;
            ParcelaContaReceber parcela = null;
            FormaPagamento formapagamento = null;
            List<ParcelaContaReceber> listaparcelas = new List<ParcelaContaReceber>();

            if (reader.Read())
            {

                contaReceber = new ContaReceber
                {
                    ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber")),
                    DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                    DataConta = reader.GetDateTime(reader.GetOrdinal("data_conta")),
                    ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original")),
                    Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                    Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                    Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo")),
                    Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                    ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final")),
                    Situacao = reader.GetString(reader.GetOrdinal("situacao")),
                };
                contaReceber.Operacao = new Operacao();
                contaReceber.Operacao.OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao"));
                contaReceber.Pessoa = new Pessoa();
                contaReceber.Pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));

                if (!reader.IsDBNull(reader.GetOrdinal("idparcela_conta_receber")))
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("pformapagamento")))
                    {
                        formapagamento = new FormaPagamento
                        {
                            FormaPagamentoID = reader.GetInt32(reader.GetOrdinal("pformapagamento")),
                            Nome = reader.GetString(reader.GetOrdinal("nome"))
                        };
                    }

                    parcela = new ParcelaContaReceber
                    {
                        ParcelaContaReceberID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_receber")),
                        DataQuitacao = reader.IsDBNull(reader.GetOrdinal("data_quitacao")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                        DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                        Juros = reader.GetDecimal(reader.GetOrdinal("pjuros")),
                        Acrescimo = reader.GetDecimal(reader.GetOrdinal("pacrescimo")),
                        Desconto = reader.GetDecimal(reader.GetOrdinal("pdesconto")),
                        Multa = reader.GetDecimal(reader.GetOrdinal("pmulta")),
                        Sequencia = reader.GetInt32(reader.GetOrdinal("sequencia")),
                        Valor = reader.GetDecimal(reader.GetOrdinal("valor")),
                        Situacao = reader.GetString(reader.GetOrdinal("psituacao"))

                    };

                    if (formapagamento != null) { parcela.FormaPagamento = formapagamento; }
                    listaparcelas.Add(parcela);
                }
            }

            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("pformapagamento")))
                {
                    formapagamento = new FormaPagamento
                    {
                        FormaPagamentoID = reader.GetInt32(reader.GetOrdinal("pformapagamento")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };
                }
                else
                {
                    formapagamento = null;
                }

                parcela = new ParcelaContaReceber
                {
                    ParcelaContaReceberID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_receber")),
                    DataQuitacao = reader.IsDBNull(reader.GetOrdinal("data_quitacao")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                    DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                    Juros = reader.GetDecimal(reader.GetOrdinal("pjuros")),
                    Acrescimo = reader.GetDecimal(reader.GetOrdinal("pacrescimo")),
                    Desconto = reader.GetDecimal(reader.GetOrdinal("pdesconto")),
                    Multa = reader.GetDecimal(reader.GetOrdinal("pmulta")),
                    Sequencia = reader.GetInt32(reader.GetOrdinal("sequencia")),
                    Valor = reader.GetDecimal(reader.GetOrdinal("valor")),
                    Situacao = reader.GetString(reader.GetOrdinal("psituacao"))

                };

                if (formapagamento != null) { parcela.FormaPagamento = formapagamento; }
                listaparcelas.Add(parcela);
            }

            if (listaparcelas.Count > 0)
            {
                contaReceber.Parcelas = new List<ParcelaContaReceber>();
                contaReceber.Parcelas = listaparcelas;
            }

            return contaReceber;
        }
    }
}
