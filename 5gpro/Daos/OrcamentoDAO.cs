using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class OrcamentoDAO
    {
        private readonly static ConexaoDAO Connect = ConexaoDAO.GetInstance();


        public Orcamento BuscaOrcamentoById(int cod)
        {
            Orcamento orcamento = new Orcamento();
            Pessoa pessoa = null;
            NotaFiscalPropria notafiscal = null;
            Cidade cidade = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT p.idpessoa, p.nome, p.fantasia, p.tipo_pessoa, p.rua, p.numero, p.bairro,
                                                    p.complemento, p.idcidade, p.telefone, p.email,
                                                    n.idnotafiscal, n.data_emissao, n.data_entradasaida, n.valor_total_itens AS valortotalitensnota,
                                                    n.valor_documento, n.desconto_total_itens AS descontototalitensnota, n.desconto_documento,
                                                    o.idorcamento, o.data_cadastro, o.data_validade, o.valor_total_itens AS valortotalitensorcamento,
                                                    o.valor_orcamento, o.desconto_total_itens AS descontototalitensorcamento, o.desconto_orcamento
                                                    FROM orcamento o 
                                                    INNER JOIN pessoa p ON p.idpessoa = o.idpessoa
                                                    LEFT JOIN notafiscal n ON o.idnotafiscal = n.idnotafiscal
                                                    WHERE o.idorcamento = @idorcamento", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idorcamento", cod);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    cidade = new Cidade
                    {
                        CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade"))
                    };

                    pessoa = new Pessoa
                    {
                        PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                        TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                        Rua = reader.GetString(reader.GetOrdinal("rua")),
                        Numero = reader.GetString(reader.GetOrdinal("numero")),
                        Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                        Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                        Cidade = cidade,
                        Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                        Email = reader.GetString(reader.GetOrdinal("email"))
                    };

                    try
                    {
                        notafiscal = new NotaFiscalPropria
                        {
                            NotaFiscalPropriaID = reader.GetInt32(reader.GetOrdinal("idnotafiscal")),
                            DataEmissao = reader.GetDateTime(reader.GetOrdinal("data_emissao")),
                            DataEntradaSaida = reader.GetDateTime(reader.GetOrdinal("data_entradasaida")),
                            ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valortotalitensnota")),
                            ValorTotalDocumento = reader.GetDecimal(reader.GetOrdinal("valor_documento")),
                            DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("descontototalitensnota")),
                            DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento")),
                            Pessoa = pessoa
                        };
                    }
                    catch (Exception)
                    {
                        notafiscal = null;
                    }

                    orcamento = new Orcamento
                    {
                        OrcamentoID = reader.GetInt32(reader.GetOrdinal("idorcamento")),
                        DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                        DataValidade = reader.IsDBNull(reader.GetOrdinal("data_validade")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_validade")),
                        ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valortotalitensorcamento")),
                        ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento")),
                        DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("descontototalitensorcamento")),
                        DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"))
                    };
                    orcamento.Pessoa = pessoa;
                    if (notafiscal != null)
                    {
                        orcamento.NotaFiscal = notafiscal;
                    }

                    reader.Close();
                }
                else
                {
                    orcamento = null;
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
            if (orcamento != null)
            {
                orcamento.OrcamentoItem = BuscaItensDoOrcamento(orcamento);
            }
            return orcamento;
        }



        public Orcamento BuscaProximoOrcamento(string codAtual)
        {
            Orcamento orcamento = new Orcamento();
            Pessoa pessoa = null;
            NotaFiscalPropria notafiscal = null;
            Cidade cidade = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT p.idpessoa, p.nome, p.fantasia, p.tipo_pessoa, p.rua, p.numero, p.bairro,
                                                    p.complemento, p.idcidade, p.telefone, p.email,
                                                    n.idnotafiscal, n.data_emissao, n.data_entradasaida, n.valor_total_itens AS valortotalitensnota,
                                                    n.valor_documento, n.desconto_total_itens AS descontototalitensnota, n.desconto_documento,
                                                    o.idorcamento, o.data_cadastro, o.data_validade, o.valor_total_itens AS valortotalitensorcamento,
                                                    o.valor_orcamento, o.desconto_total_itens AS descontototalitensorcamento, o.desconto_orcamento
                                                    FROM orcamento o 
                                                    INNER JOIN pessoa p ON p.idpessoa = o.idpessoa
                                                    LEFT JOIN notafiscal n ON o.idnotafiscal = n.idnotafiscal
                                                    WHERE o.idorcamento = (SELECT min(idorcamento) FROM orcamento WHERE idorcamento > @idorcamento)", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idorcamento", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    cidade = new Cidade
                    {
                        CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade"))
                    };

                    pessoa = new Pessoa
                    {
                        PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                        TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                        Rua = reader.GetString(reader.GetOrdinal("rua")),
                        Numero = reader.GetString(reader.GetOrdinal("numero")),
                        Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                        Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                        Cidade = cidade,
                        Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                        Email = reader.GetString(reader.GetOrdinal("email"))
                    };

                    try
                    {
                        notafiscal = new NotaFiscalPropria
                        {
                            NotaFiscalPropriaID = reader.GetInt32(reader.GetOrdinal("idnotafiscal")),
                            DataEmissao = reader.GetDateTime(reader.GetOrdinal("data_emissao")),
                            DataEntradaSaida = reader.GetDateTime(reader.GetOrdinal("data_entradasaida")),
                            ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valortotalitensnota")),
                            ValorTotalDocumento = reader.GetDecimal(reader.GetOrdinal("valor_documento")),
                            DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("descontototalitensnota")),
                            DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento")),
                            Pessoa = pessoa
                        };
                    }
                    catch (Exception)
                    {
                        notafiscal = null;
                    }

                    orcamento = new Orcamento
                    {
                        OrcamentoID = reader.GetInt32(reader.GetOrdinal("idorcamento")),
                        DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                        DataValidade = reader.IsDBNull(reader.GetOrdinal("data_validade")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_validade")),
                        ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valortotalitensorcamento")),
                        ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento")),
                        DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("descontototalitensorcamento")),
                        DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"))
                    };
                    orcamento.Pessoa = pessoa;
                    if (notafiscal != null)
                    {
                        orcamento.NotaFiscal = notafiscal;
                    }

                    reader.Close();
                }
                else
                {
                    orcamento = null;
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

            if (orcamento != null) { orcamento.OrcamentoItem = BuscaItensDoOrcamento(orcamento); }

            return orcamento;
        }

        public Orcamento BuscaOrcamentoAnterior(string codAtual)
        {

            Orcamento orcamento = new Orcamento();
            Pessoa pessoa = null;
            NotaFiscalPropria notafiscal = null;
            Cidade cidade = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT p.idpessoa, p.nome, p.fantasia, p.tipo_pessoa, p.rua, p.numero, p.bairro,
                                                    p.complemento, p.idcidade, p.telefone, p.email,
                                                    n.idnotafiscal, n.data_emissao, n.data_entradasaida, n.valor_total_itens AS valortotalitensnota,
                                                    n.valor_documento, n.desconto_total_itens AS descontototalitensnota, n.desconto_documento,
                                                    o.idorcamento, o.data_cadastro, o.data_validade, o.valor_total_itens AS valortotalitensorcamento,
                                                    o.valor_orcamento, o.desconto_total_itens AS descontototalitensorcamento, o.desconto_orcamento
                                                    FROM orcamento o 
                                                    INNER JOIN pessoa p ON p.idpessoa = o.idpessoa
                                                    LEFT JOIN notafiscal n ON o.idnotafiscal = n.idnotafiscal
                                                    WHERE o.idorcamento = (SELECT max(idorcamento) FROM orcamento WHERE idorcamento < @idorcamento)", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idorcamento", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {

                    cidade = new Cidade
                    {
                        CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade"))
                    };

                    pessoa = new Pessoa
                    {
                        PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                        TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                        Rua = reader.GetString(reader.GetOrdinal("rua")),
                        Numero = reader.GetString(reader.GetOrdinal("numero")),
                        Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                        Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                        Cidade = cidade,
                        Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                        Email = reader.GetString(reader.GetOrdinal("email"))
                    };

                    try
                    {
                        notafiscal = new NotaFiscalPropria
                        {
                            NotaFiscalPropriaID = reader.GetInt32(reader.GetOrdinal("idnotafiscal")),
                            DataEmissao = reader.GetDateTime(reader.GetOrdinal("data_emissao")),
                            DataEntradaSaida = reader.GetDateTime(reader.GetOrdinal("data_entradasaida")),
                            ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valortotalitensnota")),
                            ValorTotalDocumento = reader.GetDecimal(reader.GetOrdinal("valor_documento")),
                            DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("descontototalitensnota")),
                            DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento")),
                            Pessoa = pessoa
                        };
                    }
                    catch (Exception)
                    {
                        notafiscal = null;
                    }

                    orcamento = new Orcamento
                    {
                        OrcamentoID = reader.GetInt32(reader.GetOrdinal("idorcamento")),
                        DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                        DataValidade = reader.IsDBNull(reader.GetOrdinal("data_validade")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_validade")),
                        ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valortotalitensorcamento")),
                        ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento")),
                        DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("descontototalitensorcamento")),
                        DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"))
                    };
                    orcamento.Pessoa = pessoa;
                    if (notafiscal != null)
                    {
                        orcamento.NotaFiscal = notafiscal;
                    }

                    reader.Close();
                }
                else
                {
                    orcamento = null;
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

            if (orcamento != null) { orcamento.OrcamentoItem = BuscaItensDoOrcamento(orcamento); }

            return orcamento;

        }

        public List<Orcamento> BuscaOrcamentos(fmOrcBuscaOrcamento.Filtros f)
        {
            List<Orcamento> orcamentos = new List<Orcamento>();
            Pessoa pessoa = null;
            NotaFiscalPropria notafiscal = null;
            Cidade cidade = null;

            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            string whereCidade = f.filtroCidade != null ? "AND p.idcidade = @idcidade" : "";
            string contemValidade = f.contemValidade ? "NOT" : "";

            try
            {
                Connect.AbrirConexao();
                //TODO: Adicionar aos filtros a data de efetivação.
                Connect.Comando = new MySqlCommand(@"SELECT p.idpessoa, p.nome, p.fantasia, p.tipo_pessoa, p.rua, p.numero, p.bairro,
                                                    p.complemento, p.idcidade, p.telefone, p.email,
                                                    n.idnotafiscal, n.data_emissao, n.data_entradasaida, n.valor_total_itens AS valortotalitensnota,
                                                    n.valor_documento, n.desconto_total_itens AS descontototalitensnota, n.desconto_documento,
                                                    o.idorcamento, o.data_cadastro, o.data_validade, o.valor_total_itens AS valortotalitensorcamento,
                                                    o.valor_orcamento, o.desconto_total_itens AS descontototalitensorcamento, o.desconto_orcamento
                                                    FROM orcamento o 
                                                    INNER JOIN pessoa p ON p.idpessoa = o.idpessoa
                                                    LEFT JOIN notafiscal n ON o.idnotafiscal = n.idnotafiscal 
                                             WHERE 1 = 1 "
                                             + whereCidade + ""
                                             + wherePessoa + "" +
                                          @" AND valor_orcamento BETWEEN @valor_total_inicial AND @valor_total_final
                                             AND data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final
                                             AND (data_validade BETWEEN @data_validade_inicial AND @data_validade_final OR data_validade IS " + contemValidade + @" NULL)
                                             ORDER BY idorcamento", Connect.Conexao);
                if (f.filtroCidade != null) { Connect.Comando.Parameters.AddWithValue("@idcidade", f.filtroCidade.CidadeID); }
                if (f.filtroPessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", f.filtroPessoa.PessoaID); }
                Connect.Comando.Parameters.AddWithValue("@valor_total_inicial", f.filtroValorTotalInical);
                Connect.Comando.Parameters.AddWithValue("@valor_total_final", f.filtroValorTotalFinal);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro_final", f.filtroDataCadastroFinal);
                Connect.Comando.Parameters.AddWithValue("@data_validade_inicial", f.filtroDataValidadeInicial);
                Connect.Comando.Parameters.AddWithValue("@data_validade_final", f.filtroDataValidadeFinal);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    cidade = new Cidade
                    {
                        CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade"))
                    };

                    pessoa = new Pessoa
                    {
                        PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                        TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                        Rua = reader.GetString(reader.GetOrdinal("rua")),
                        Numero = reader.GetString(reader.GetOrdinal("numero")),
                        Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                        Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                        Cidade = cidade,
                        Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                        Email = reader.GetString(reader.GetOrdinal("email"))
                    };

                    try
                    {
                        notafiscal = new NotaFiscalPropria
                        {
                            NotaFiscalPropriaID = reader.GetInt32(reader.GetOrdinal("idnotafiscal")),
                            DataEmissao = reader.GetDateTime(reader.GetOrdinal("data_emissao")),
                            DataEntradaSaida = reader.GetDateTime(reader.GetOrdinal("data_entradasaida")),
                            ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valortotalitensnota")),
                            ValorTotalDocumento = reader.GetDecimal(reader.GetOrdinal("valor_documento")),
                            DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("descontototalitensnota")),
                            DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento")),
                            Pessoa = pessoa
                        };
                    }
                    catch (Exception)
                    {
                        notafiscal = null;
                    }

                    Orcamento orcamento = new Orcamento
                    {
                        OrcamentoID = reader.GetInt32(reader.GetOrdinal("idorcamento")),
                        DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                        DataValidade = reader.IsDBNull(reader.GetOrdinal("data_validade")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_validade")),
                        ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valortotalitensorcamento")),
                        ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento")),
                        DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("descontototalitensorcamento")),
                        DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento")),
                        Pessoa = pessoa,
                        NotaFiscal = notafiscal
                    };
                    orcamento.OrcamentoItem = BuscaItensDoOrcamento(orcamento);
                    orcamentos.Add(orcamento);
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
            return orcamentos;
        }


        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT o1.idorcamento + 1 AS proximoid
                                             FROM orcamento AS o1
                                             LEFT OUTER JOIN orcamento AS o2 ON o1.idorcamento + 1 = o2.idorcamento
                                             WHERE o2.idorcamento IS NULL
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
                    //FIZ ESSE ELSE PARA CASO N TIVER NENHUM REGISTRO NA BASE... PODE DAR PROBLEMA EM ALGUM MOMENTO xD
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

        public List<OrcamentoItem> BuscaItensDoOrcamento(Orcamento orcamento)
        {
            List<OrcamentoItem> itensOrcamento = new List<OrcamentoItem>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * 
                                             FROM orcamento_has_item oi INNER JOIN item i 
                                             ON oi.iditem = i.iditem 
                                             WHERE idorcamento = @idorcamento", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idorcamento", orcamento.OrcamentoID);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    Unimedida u = new Unimedida
                    {
                        UnimedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida")),
                    };

                    Item i = new Item
                    {
                        ItemID = reader.GetInt32(reader.GetOrdinal("iditem")),
                        Descricao = reader.GetString(reader.GetOrdinal("descitem")),
                        DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra")),
                        TipoItem = reader.GetString(reader.GetOrdinal("tipo")),
                        Referencia = reader.GetString(reader.GetOrdinal("referencia")),
                        ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada")),
                        ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida")),
                        Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario")),
                        Unimedida = u
                    };

                    OrcamentoItem oi = new OrcamentoItem
                    {
                        Quantidade = reader.GetDecimal(reader.GetOrdinal("quantidade")),
                        ValorUnitario = reader.GetDecimal(reader.GetOrdinal("valor_unitario")),
                        ValorTotal = reader.GetDecimal(reader.GetOrdinal("valor_total")),
                        DescontoPorc = reader.GetDecimal(reader.GetOrdinal("desconto_porc")),
                        Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                        Item = i
                    };

                    itensOrcamento.Add(oi);
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
            return itensOrcamento;
        }

        public int SalvarOuAtualizarOrcamento(Orcamento orcamento)
        {
            int retorno = 0;
            try
            {

                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;

                Connect.Comando.CommandText = @"INSERT INTO orcamento
                         (idorcamento, data_cadastro, data_validade, valor_total_itens, valor_orcamento, desconto_total_itens, desconto_orcamento, idpessoa)
                          VALUES
                         (@idorcamento, @data_cadastro, @data_validade, @valor_total_itens, @valor_orcamento, @desconto_total_itens, @desconto_orcamento, @idpessoa)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, data_validade = @data_validade, valor_total_itens = @valor_total_itens,
                          valor_orcamento = @valor_orcamento, desconto_total_itens = @desconto_total_itens, desconto_orcamento = @desconto_orcamento,
                          idpessoa = @idpessoa
                          ";

                Connect.Comando.Parameters.AddWithValue("@idorcamento", orcamento.OrcamentoID);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro", orcamento.DataCadastro);
                Connect.Comando.Parameters.AddWithValue("@data_validade", orcamento.DataValidade);
                Connect.Comando.Parameters.AddWithValue("@valor_total_itens", orcamento.ValorTotalItens);
                Connect.Comando.Parameters.AddWithValue("@valor_orcamento", orcamento.ValorTotalOrcamento);
                Connect.Comando.Parameters.AddWithValue("@desconto_total_itens", orcamento.DescontoTotalItens);
                Connect.Comando.Parameters.AddWithValue("@desconto_orcamento", orcamento.DescontoOrcamento);
                if (orcamento.Pessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", orcamento.Pessoa.PessoaID); }

                retorno = Connect.Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Connect.Comando.CommandText = @"DELETE FROM orcamento_has_item WHERE idorcamento = @idorcamento";
                    Connect.Comando.ExecuteNonQuery();

                    Connect.Comando.CommandText = @"INSERT INTO orcamento_has_item (idorcamento, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                            VALUES
                                            (@idorcamento, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (OrcamentoItem oi in orcamento.OrcamentoItem)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@idorcamento", orcamento.OrcamentoID);
                        Connect.Comando.Parameters.AddWithValue("@iditem", oi.Item.ItemID);
                        Connect.Comando.Parameters.AddWithValue("@quantidade", oi.Quantidade);
                        Connect.Comando.Parameters.AddWithValue("@valor_unitario", oi.ValorUnitario);
                        Connect.Comando.Parameters.AddWithValue("@valor_total", oi.ValorTotal);
                        Connect.Comando.Parameters.AddWithValue("@desconto_porc", oi.DescontoPorc);
                        Connect.Comando.Parameters.AddWithValue("@desconto", oi.Desconto);
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

        public int VincularNotaAoOrcamento(Orcamento orcamento, NotaFiscalPropria notafiscal)
        {
            int retorno = 0;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"UPDATE orcamento SET idnotafiscal = @idnotafiscal WHERE idorcamento = @idorcamento", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idorcamento", orcamento.OrcamentoID);
                Connect.Comando.Parameters.AddWithValue("@idnotafiscal", notafiscal.NotaFiscalPropriaID);

                retorno = Connect.Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            return retorno;
        }
    }
}
