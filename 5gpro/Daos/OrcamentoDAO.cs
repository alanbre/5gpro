using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class OrcamentoDAO : ConexaoDAO
    {
        private static ConexaoDAO connection = new ConexaoDAO();
        private readonly PessoaDAO pessoaDAO = new PessoaDAO(connection);
        private readonly NotaFiscalDAO notafiscalDAO = new NotaFiscalDAO();

        public Orcamento BuscaOrcamentoById(int cod)
        {
            Orcamento orcamento = new Orcamento();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM orcamento WHERE idorcamento = @idorcamento", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    orcamento = new Orcamento
                    {
                        OrcamentoID = reader.GetInt32(reader.GetOrdinal("idorcamento")),
                        DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                        DataValidade = reader.IsDBNull(reader.GetOrdinal("data_validade")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_validade")),
                        ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens")),
                        ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento")),
                        DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens")),
                        DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"))
                    };
                    orcamento.Pessoa = pessoaDAO.BuscaById(reader.GetInt32(reader.GetOrdinal("idpessoa")));
                    orcamento.NotaFiscal = notafiscalDAO.BuscaNotaByCod(reader.GetInt32(reader.GetOrdinal("idnotafiscal")));
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
                FecharConexao();
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

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM orcamento WHERE idorcamento = (SELECT min(idorcamento) FROM orcamento WHERE idorcamento > @idorcamento)", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    orcamento = new Orcamento
                    {
                        OrcamentoID = reader.GetInt32(reader.GetOrdinal("idorcamento")),
                        DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                        DataValidade = reader.IsDBNull(reader.GetOrdinal("data_validade")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_validade")),
                        ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens")),
                        ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento")),
                        DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens")),
                        DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"))
                    };
                    orcamento.Pessoa = pessoaDAO.BuscaById(reader.GetInt32(reader.GetOrdinal("idpessoa")));
                    orcamento.NotaFiscal = notafiscalDAO.BuscaNotaByCod(reader.GetInt32(reader.GetOrdinal("idnotafiscal")));
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
                FecharConexao();
            }

            if (orcamento != null) { orcamento.OrcamentoItem = BuscaItensDoOrcamento(orcamento); }

            return orcamento;
        }

        public Orcamento BuscaOrcamentoAnterior(string codAtual)
        {
            Orcamento orcamento = new Orcamento();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM orcamento WHERE idorcamento = (SELECT max(idorcamento) FROM orcamento WHERE idorcamento < @idorcamento)", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    orcamento = new Orcamento
                    {
                        OrcamentoID = reader.GetInt32(reader.GetOrdinal("idorcamento")),
                        DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                        DataValidade = reader.IsDBNull(reader.GetOrdinal("data_validade")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_validade")),
                        ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens")),
                        ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento")),
                        DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens")),
                        DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"))
                    };
                    orcamento.Pessoa = pessoaDAO.BuscaById(reader.GetInt32(reader.GetOrdinal("idpessoa")));
                    orcamento.NotaFiscal = notafiscalDAO.BuscaNotaByCod(reader.GetInt32(reader.GetOrdinal("idnotafiscal")));
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
                FecharConexao();
            }

            if (orcamento != null) { orcamento.OrcamentoItem = BuscaItensDoOrcamento(orcamento); }

            return orcamento;
        }

        public List<Orcamento> BuscaOrcamentos(fmBuscaOrcamento.Filtros f)
        {
            List<Orcamento> orcamentos = new List<Orcamento>();
            string wherePessoa = f.filtroPessoa != null ? "AND idpessoa = @idpessoa" : "";
            string whereCidade = f.filtroCidade != null ? "AND idcidade = @idcidade" : "";
            string contemValidade = f.contemValidade ? "NOT" : "";

            try
            {
                AbrirConexao();
                //TODO: Adicionar aos filtros a data de efetivação.
                Comando = new MySqlCommand(@"SELECT *
                                             FROM orcamento 
                                             WHERE 1 = 1 "
                                             + whereCidade + ""
                                             + wherePessoa + "" +
                                          @" AND valor_orcamento BETWEEN @valor_total_inicial AND @valor_total_final
                                             AND data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final
                                             AND (data_validade BETWEEN @data_validade_inicial AND @data_validade_final OR data_validade IS " + contemValidade + @" NULL)
                                             ORDER BY idorcamento", Conexao);
                if (f.filtroCidade != null) { Comando.Parameters.AddWithValue("@idcidade", f.filtroCidade.CidadeID); }
                if (f.filtroPessoa != null) { Comando.Parameters.AddWithValue("@idpessoa", f.filtroPessoa.PessoaID); }
                Comando.Parameters.AddWithValue("@valor_total_inicial", f.filtroValorTotalInical);
                Comando.Parameters.AddWithValue("@valor_total_final", f.filtroValorTotalFinal);
                Comando.Parameters.AddWithValue("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                Comando.Parameters.AddWithValue("@data_cadastro_final", f.filtroDataCadastroFinal);
                Comando.Parameters.AddWithValue("@data_validade_inicial", f.filtroDataValidadeInicial);
                Comando.Parameters.AddWithValue("@data_validade_final", f.filtroDataValidadeFinal);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Orcamento orcamento = new Orcamento
                    {
                        OrcamentoID = reader.GetInt32(reader.GetOrdinal("idorcamento")),
                        DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                        DataValidade = reader.IsDBNull(reader.GetOrdinal("data_validade")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_validade")),
                        ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens")),
                        ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento")),
                        DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens")),
                        DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento")),
                        Pessoa = pessoaDAO.BuscaById(reader.GetInt32(reader.GetOrdinal("idpessoa"))),
                        NotaFiscal = notafiscalDAO.BuscaNotaByCod(reader.GetInt32(reader.GetOrdinal("idnotafiscal")))
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
                FecharConexao();
            }
            return orcamentos;
        }


        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT o1.idorcamento + 1 AS proximoid
                                             FROM orcamento AS o1
                                             LEFT OUTER JOIN orcamento AS o2 ON o1.idorcamento + 1 = o2.idorcamento
                                             WHERE o2.idorcamento IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Conexao);

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }

            return proximoid;
        }

        public List<OrcamentoItem> BuscaItensDoOrcamento(Orcamento orcamento)
        {
            List<OrcamentoItem> itensOrcamento = new List<OrcamentoItem>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * 
                                             FROM orcamento_has_item oi INNER JOIN item i 
                                             ON oi.iditem = i.iditem 
                                             WHERE idorcamento = @idorcamento", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", orcamento.OrcamentoID);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
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
                        Unimedida = new UnimedidaDAO().BuscaUnimedidaByCod(reader.GetInt32(reader.GetOrdinal("idunimedida"))),
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
                FecharConexao();
            }
            return itensOrcamento;
        }

        public int SalvarOuAtualizarOrcamento(Orcamento orcamento)
        {
            int retorno = 0;
            try
            {
                AbrirConexao();
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;


                Comando.CommandText = @"INSERT INTO orcamento
                         (idorcamento, data_cadastro, data_validade, valor_total_itens, valor_orcamento, desconto_total_itens, desconto_orcamento, idpessoa)
                          VALUES
                         (@idorcamento, @data_cadastro, @data_validade, @valor_total_itens, @valor_orcamento, @desconto_total_itens, @desconto_orcamento, @idpessoa)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, data_validade = @data_validade, valor_total_itens = @valor_total_itens,
                          valor_orcamento = @valor_orcamento, desconto_total_itens = @desconto_total_itens, desconto_orcamento = @desconto_orcamento,
                          idpessoa = @idpessoa
                          ";

                Comando.Parameters.AddWithValue("@idorcamento", orcamento.OrcamentoID);
                Comando.Parameters.AddWithValue("@data_cadastro", orcamento.DataCadastro);
                Comando.Parameters.AddWithValue("@data_validade", orcamento.DataValidade);
                Comando.Parameters.AddWithValue("@valor_total_itens", orcamento.ValorTotalItens);
                Comando.Parameters.AddWithValue("@valor_orcamento", orcamento.ValorTotalOrcamento);
                Comando.Parameters.AddWithValue("@desconto_total_itens", orcamento.DescontoTotalItens);
                Comando.Parameters.AddWithValue("@desconto_orcamento", orcamento.DescontoOrcamento);
                if (orcamento.Pessoa != null) { Comando.Parameters.AddWithValue("@idpessoa", orcamento.Pessoa.PessoaID); }

                retorno = Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Comando.CommandText = @"DELETE FROM orcamento_has_item WHERE idorcamento = @idorcamento";
                    Comando.ExecuteNonQuery();

                    Comando.CommandText = @"INSERT INTO orcamento_has_item (idorcamento, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                            VALUES
                                            (@idorcamento, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (OrcamentoItem oi in orcamento.OrcamentoItem)
                    {
                        Comando.Parameters.Clear();
                        Comando.Parameters.AddWithValue("@idorcamento", orcamento.OrcamentoID);
                        Comando.Parameters.AddWithValue("@iditem", oi.Item.ItemID);
                        Comando.Parameters.AddWithValue("@quantidade", oi.Quantidade);
                        Comando.Parameters.AddWithValue("@valor_unitario", oi.ValorUnitario);
                        Comando.Parameters.AddWithValue("@valor_total", oi.ValorTotal);
                        Comando.Parameters.AddWithValue("@desconto_porc", oi.DescontoPorc);
                        Comando.Parameters.AddWithValue("@desconto", oi.Desconto);
                        Comando.ExecuteNonQuery();
                    }
                }
                tr.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                FecharConexao();
            }
            return retorno;
        }

        public int VincularNotaAoOrcamento(Orcamento orcamento, NotaFiscal notafiscal)
        {
            int retorno = 0;

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"UPDATE orcamento SET idnotafiscal = @idnotafiscal WHERE idorcamento = @idorcamento", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", orcamento.OrcamentoID);
                Comando.Parameters.AddWithValue("@idnotafiscal", notafiscal.NotaFiscalID);

                retorno = Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            return retorno;
        }
    }
}
