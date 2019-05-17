using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class ContaReceberDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int SalvaOuAtualiza(ContaReceber contaReceber)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO conta_receber
                         (idconta_receber, data_cadastro, data_conta, idoperacao, valor_original, multa, juros, acrescimo, desconto, valor_final, idpessoa, situacao)
                          VALUES
                         (@idconta_receber, @data_cadastro, @data_conta, @idoperacao, @valor_original, @multa, @juros, @acrescimo, @desconto, @valor_final, @idpessoa, @situacao)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, data_conta = @data_conta, idoperacao = @idoperacao, valor_original = @valor_original,
                          multa = @multa, juros = @juros, acrescimo = @acrescimo, desconto = @desconto, valor_final = @valor_final, idpessoa = @idpessoa, situacao = @situacao
                          ";
                sql.addParam("@idconta_receber", contaReceber.ContaReceberID);
                sql.addParam("@data_cadastro", contaReceber.DataCadastro);
                sql.addParam("@idoperacao", contaReceber.Operacao.OperacaoID);
                sql.addParam("@valor_original", contaReceber.ValorOriginal);
                sql.addParam("@multa", contaReceber.Multa);
                sql.addParam("@juros", contaReceber.Juros);
                sql.addParam("@acrescimo", contaReceber.Acrescimo);
                sql.addParam("@desconto", contaReceber.Desconto);
                sql.addParam("@valor_final", contaReceber.ValorFinal);
                sql.addParam("@idpessoa", contaReceber.Pessoa.PessoaID);
                sql.addParam("@situacao", contaReceber.Situacao);
                sql.addParam("@data_conta", contaReceber.DataConta);
                retorno = sql.insertQuery();
                if (retorno > 0)
                {
                    sql.Query = @"DELETE FROM parcela_conta_receber WHERE idconta_receber = @idconta_receber";
                    sql.deleteQuery();

                    sql.Query = @"INSERT INTO parcela_conta_receber
                                (sequencia, data_vencimento, valor, multa, juros, acrescimo, desconto, valor_final, data_quitacao, idconta_receber, idformapagamento, situacao)
                                VALUES
                                (@sequencia, @data_vencimento, @valor, @multa, @juros, @acrescimo, @desconto, @valor_final, @data_quitacao, @idconta_receber, @idformapagamento, @situacao)";
                    foreach (var parcela in contaReceber.Parcelas)
                    {
                        sql.clearParams();
                        sql.addParam("@sequencia", parcela.Sequencia);
                        sql.addParam("@data_vencimento", parcela.DataVencimento);
                        sql.addParam("@valor", parcela.Valor);
                        sql.addParam("@multa", parcela.Multa);
                        sql.addParam("@juros", parcela.Juros);
                        sql.addParam("@acrescimo", parcela.Acrescimo);
                        sql.addParam("@desconto", parcela.Desconto);
                        sql.addParam("@valor_final", parcela.ValorFinal);
                        sql.addParam("@data_quitacao", parcela.DataQuitacao);
                        sql.addParam("@idconta_receber", contaReceber.ContaReceberID);
                        sql.addParam("@idformapagamento", parcela.FormaPagamento?.FormaPagamentoID ?? null);
                        sql.addParam("@situacao", contaReceber.Situacao);
                        sql.insertQuery();
                    }
                }
                sql.Commit();
            }
            return retorno;
        }


        public ContaReceber BuscaById(int codigo)
        {
            ContaReceber contaReceber = null;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                            p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final  
                            FROM conta_receber AS c
                            LEFT JOIN parcela_conta_receber AS p 
                            ON  c.idconta_receber = p.idconta_receber
                            LEFT JOIN formapagamento f
                            ON f.idformapagamento = p.idformapagamento
                            WHERE c.idconta_receber = @idconta_receber";
                sql.addParam("@idconta_receber", codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                contaReceber = LeDadosReader(data);
            }
            return contaReceber;
        }

        public IEnumerable<ContaReceber> Busca(fmBuscaContaReceber.Filtros f)
        {
            var contaRecebers = new List<ContaReceber>();
            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            string whereOperacao = f.filtroOperacao != null ? "AND op.idoperacao = @idoperacao" : "";
            string whereValorFinal = f.usarvalorContaFiltro ? "AND cr.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final" : "";
            string whereDatCadastro = f.usardataCadastroFiltro ? "AND cr.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataVencimento = f.usardataVencimentoFiltro ? "AND pa.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final" : "";


            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT cr.idconta_receber, p.idpessoa, p.nome, cr.data_cadastro, cr.data_conta,
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
                                                    + "GROUP BY cr.idconta_receber";
                if (f.filtroPessoa != null) { sql.addParam("@idpessoa", f.filtroPessoa.PessoaID); }
                if (f.filtroOperacao != null) { sql.addParam("@idoperacao", f.filtroOperacao.OperacaoID); }
                if (f.usarvalorContaFiltro)
                {
                    sql.addParam("@valor_conta_inicial", f.filtroValorInicial);
                    sql.addParam("@valor_conta_final", f.filtroValorFinal);
                }
                if (f.usardataCadastroFiltro)
                {
                    sql.addParam("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                    sql.addParam("@data_cadastro_final", f.filtroDataCadastroFinal);
                }
                if (f.usardataVencimentoFiltro)
                {
                    sql.addParam("@data_vencimento_inicial", f.filtroDataVencimentoInicial);
                    sql.addParam("@data_vencimento_final", f.filtroDataVencimentoFinal);
                }
                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    Operacao operacao = null;
                    Pessoa pessoa = null;

                    pessoa = new Pessoa
                    {
                        PessoaID = (int)d["idpessoa"],
                        Nome = (string)d["nome"]
                    };
                    operacao = new Operacao
                    {
                        OperacaoID = (int)d["idoperacao"],
                        Nome = (string)d["nomeoperacao"]
                    };

                    var contaReceber = new ContaReceber
                    {
                        ContaReceberID = (int)d["idconta_receber"],
                        DataCadastro = (DateTime)d["data_cadastro"],
                        DataConta = (DateTime)d["data_conta"],
                        ValorOriginal = (decimal)d["valor_original"],
                        Multa = (decimal)d["multa"],
                        Juros = (decimal)d["juros"],
                        Acrescimo = (decimal)d["acrescimo"],
                        Desconto = (decimal)d["desconto"],
                        ValorFinal = (decimal)d["valor_final"],
                        Situacao = (string)d["situacao"]
                    };
                    contaReceber.Pessoa = pessoa;
                    contaReceber.Operacao = operacao;
                    contaRecebers.Add(contaReceber);
                }
            }
            return contaRecebers;
        }

        //ALTERAR A FORMA QUANDO FOR USAR (e mudar pra public) (e deletar esse comentário)
        private IEnumerable<ContaReceber> Busca(fmCarQuitacaoConta.Filtros f)
        {
            var contaRecebers = new List<ContaReceber>();
            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            string whereConta = f.filtroConta > 0 ? "AND cr.idconta_receber = @idconta_receber" : "";

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
                        var pessoa = new Pessoa();
                        pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
                        pessoa.Nome = reader.GetString(reader.GetOrdinal("nome"));


                        var contaReceber = new ContaReceber();
                        contaReceber.ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber"));
                        contaReceber.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));
                        contaReceber.DataConta = reader.GetDateTime(reader.GetOrdinal("data_conta"));
                        contaReceber.ValorOriginal = reader.GetDecimal(reader.GetOrdinal("valor_original"));
                        contaReceber.Multa = reader.GetDecimal(reader.GetOrdinal("multa"));
                        contaReceber.Juros = reader.GetDecimal(reader.GetOrdinal("juros"));
                        contaReceber.Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo"));
                        contaReceber.Desconto = reader.GetDecimal(reader.GetOrdinal("desconto"));
                        contaReceber.ValorFinal = reader.GetDecimal(reader.GetOrdinal("valor_final"));

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
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT cr1.idconta_receber + 1 AS proximoid
                            FROM conta_receber AS cr1
                            LEFT OUTER JOIN conta_receber AS cr2 ON cr1.idconta_receber + 1 = cr2.idconta_receber
                            WHERE cr2.idconta_receber IS NULL
                            ORDER BY proximoid
                            LIMIT 1";
                var data = sql.selectQueryForSingleRecord();
                if (data != null)
                {
                    proximoid = Convert.ToInt32(data["proximoid"]);
                }
            }
            return proximoid;
        }


        public ContaReceber Proximo(int codigo)
        {
            ContaReceber contaReceber = null;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                            p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final  
                            FROM conta_receber AS c
                            LEFT JOIN parcela_conta_receber AS p 
                            ON  c.idconta_receber = p.idconta_receber
                            LEFT JOIN formapagamento f
                            ON f.idformapagamento = p.idformapagamento
                            WHERE c.idconta_receber = (SELECT min(idconta_receber) 
                            FROM conta_receber 
                            WHERE idconta_receber > @idconta_receber)
                            LIMIT 1";

                sql.addParam("@idconta_receber", codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                contaReceber = LeDadosReader(data);
            }
            return contaReceber;
        }

        public ContaReceber Anterior(int codigo)
        {
            ContaReceber contaReceber = null;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                            p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final  
                            FROM conta_receber AS c
                            LEFT JOIN parcela_conta_receber AS p 
                            ON  c.idconta_receber = p.idconta_receber
                            LEFT JOIN formapagamento f
                            ON f.idformapagamento = p.idformapagamento
                            WHERE c.idconta_receber = (SELECT max(idconta_receber) 
                            FROM conta_receber 
                            WHERE idconta_receber < @idconta_receber)
                            LIMIT 1";

                sql.addParam("@idconta_receber", codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                contaReceber = LeDadosReader(data);
            }
            return contaReceber;
        }


        //ALTERAR QUANDO UTILIZAR A FUNÇÃO DE BUSCA 
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
                        var parcela = new ParcelaContaReceber();
                        parcela.ParcelaContaReceberID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_receber"));
                        parcela.DataQuitacao = reader.IsDBNull(reader.GetOrdinal("data_quitacao")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_quitacao"));
                        parcela.DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento"));
                        parcela.Juros = reader.GetDecimal(reader.GetOrdinal("juros"));
                        parcela.Multa = reader.GetDecimal(reader.GetOrdinal("multa"));
                        parcela.Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo"));
                        parcela.Desconto = reader.GetDecimal(reader.GetOrdinal("desconto"));
                        parcela.Sequencia = reader.GetInt32(reader.GetOrdinal("sequencia"));
                        parcela.Valor = reader.GetDecimal(reader.GetOrdinal("valor"));

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

        private ContaReceber LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }
            var contaReceber = new ContaReceber();
            var listaparcelas = new List<ParcelaContaReceber>();


            contaReceber.ContaReceberID = Convert.ToInt32(data[0]["idconta_receber"]);
            contaReceber.DataCadastro = (DateTime)data[0]["data_cadastro"];
            contaReceber.DataConta = (DateTime)data[0]["data_conta"];
            contaReceber.ValorOriginal = (decimal)data[0]["valor_original"];
            contaReceber.Multa = (decimal)data[0]["multa"];
            contaReceber.Juros = (decimal)data[0]["juros"];
            contaReceber.Acrescimo = (decimal)data[0]["acrescimo"];
            contaReceber.Desconto = (decimal)data[0]["desconto"];
            contaReceber.ValorFinal = (decimal)data[0]["valor_final"];
            contaReceber.Situacao = (string)data[0]["situacao"];
            contaReceber.Operacao = new Operacao();
            contaReceber.Operacao.OperacaoID = Convert.ToInt32(data[0]["idoperacao"]);
            contaReceber.Pessoa = new Pessoa();
            contaReceber.Pessoa.PessoaID = Convert.ToInt32(data[0]["idpessoa"]);

            foreach (var d in data)
            {
                var parcela = new ParcelaContaReceber();
                var formapagamento = new FormaPagamento();

                if (d["pformapagamento"] != null)
                {
                    formapagamento.FormaPagamentoID = Convert.ToInt32(d["pformapagamento"]);
                    formapagamento.Nome = (string)d["nome"];
                }
                else
                {
                    formapagamento = null;
                }


                parcela.ParcelaContaReceberID = (int)d["idparcela_conta_receber"];
                parcela.DataQuitacao = (DateTime?)d["data_quitacao"];
                parcela.DataVencimento = (DateTime)d["data_vencimento"];
                parcela.Juros = (decimal)d["pjuros"];
                parcela.Acrescimo = (decimal)d["pacrescimo"];
                parcela.Desconto = (decimal)d["pdesconto"];
                parcela.Multa = (decimal)d["pmulta"];
                parcela.Sequencia = (int)d["sequencia"];
                parcela.Valor = (decimal)d["valor"];
                parcela.Situacao = (string)d["psituacao"];


                parcela.FormaPagamento = formapagamento;
                listaparcelas.Add(parcela);
            }
            contaReceber.Parcelas = listaparcelas;
            return contaReceber;
        }
    }
}
