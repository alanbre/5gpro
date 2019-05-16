using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class NotaFiscalPropriaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT nf1.idnotafiscal + 1 AS proximoid 
                                             FROM notafiscal AS nf1 
                                             LEFT OUTER JOIN notafiscal AS nf2 ON nf1.idnotafiscal + 1 = nf2.idnotafiscal 
                                             WHERE nf2.idnotafiscal IS NULL 
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
        public NotaFiscalPropria BuscaByID(int codigo)
        {
            var notafiscal = new NotaFiscalPropria();
            var pessoa = new Pessoa();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM notafiscal WHERE idnotafiscal = @idnotafiscal", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idnotafiscal", codigo);


                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        notafiscal = new NotaFiscalPropria
                        {
                            NotaFiscalPropriaID = reader.GetInt32(reader.GetOrdinal("idnotafiscal")),
                            DataEmissao = reader.GetDateTime(reader.GetOrdinal("data_emissao")),
                            DataEntradaSaida = reader.GetDateTime(reader.GetOrdinal("data_entradasaida")),
                            ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens")),
                            ValorTotalDocumento = reader.GetDecimal(reader.GetOrdinal("valor_documento")),
                            DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens")),
                            DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento"))
                        };
                        pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
                        notafiscal.Pessoa = pessoa;
                    }
                    else
                    {
                        notafiscal = null;
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
            if (notafiscal != null)
            {
                notafiscal.NotaFiscalPropriaItem = BuscaItensDaNotaFiscal(notafiscal);
            }
            return notafiscal;
        }
        public NotaFiscalPropria Proximo(int codAtual)
        {
            NotaFiscalPropria notafiscal = new NotaFiscalPropria();
            var pessoa = new Pessoa();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM notafiscal WHERE idnotafiscal = (SELECT min(idnotafiscal) FROM notafiscal WHERE idnotafiscal > @idnotafiscal)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idnotafiscal", codAtual);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        notafiscal = new NotaFiscalPropria
                        {
                            NotaFiscalPropriaID = reader.GetInt32(reader.GetOrdinal("idnotafiscal")),
                            DataEmissao = reader.GetDateTime(reader.GetOrdinal("data_emissao")),
                            DataEntradaSaida = reader.GetDateTime(reader.GetOrdinal("data_entradasaida")),
                            ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens")),
                            ValorTotalDocumento = reader.GetDecimal(reader.GetOrdinal("valor_documento")),
                            DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens")),
                            DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento"))
                        };
                        pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
                        notafiscal.Pessoa = pessoa;
                    }
                    else
                    {
                        notafiscal = null;
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

            if (notafiscal != null) { notafiscal.NotaFiscalPropriaItem = BuscaItensDaNotaFiscal(notafiscal); }

            return notafiscal;
        }
        public NotaFiscalPropria Anterior(int codAtual)
        {
            var notafiscal = new NotaFiscalPropria();
            var pessoa = new Pessoa();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM notafiscal WHERE idnotafiscal = (SELECT max(idnotafiscal) FROM notafiscal WHERE idnotafiscal < @idnotafiscal)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idnotafiscal", codAtual);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        notafiscal = new NotaFiscalPropria
                        {
                            NotaFiscalPropriaID = reader.GetInt32(reader.GetOrdinal("idnotafiscal")),
                            DataEmissao = reader.GetDateTime(reader.GetOrdinal("data_emissao")),
                            DataEntradaSaida = reader.GetDateTime(reader.GetOrdinal("data_entradasaida")),
                            ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens")),
                            ValorTotalDocumento = reader.GetDecimal(reader.GetOrdinal("valor_documento")),
                            DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens")),
                            DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento"))
                        };
                        pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
                        notafiscal.Pessoa = pessoa;
                    }
                    else
                    {
                        notafiscal = null;
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

            if (notafiscal != null) { notafiscal.NotaFiscalPropriaItem = BuscaItensDaNotaFiscal(notafiscal); }

            return notafiscal;
        }
        public int SalvarOuAtualizar(NotaFiscalPropria notafiscal)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;


                Connect.Comando.CommandText = @"INSERT INTO notafiscal
                         (idnotafiscal, data_emissao, data_entradasaida, tiponf, valor_total_itens, valor_documento, desconto_total_itens, desconto_documento, idpessoa)
                          VALUES
                         (@idnotafiscal, @data_emissao, @data_entradasaida, @tiponf, @valor_total_itens, @valor_documento, @desconto_total_itens, @desconto_documento, @idpessoa)
                          ON DUPLICATE KEY UPDATE
                          data_emissao = @data_emissao, data_entradasaida = @data_entradasaida, valor_total_itens = @valor_total_itens,
                          valor_documento = @valor_documento, desconto_total_itens = @desconto_total_itens, desconto_documento = @desconto_documento,
                          idpessoa = @idpessoa
                          ";

                Connect.Comando.Parameters.AddWithValue("@idnotafiscal", notafiscal.NotaFiscalPropriaID);
                Connect.Comando.Parameters.AddWithValue("@data_emissao", notafiscal.DataEmissao);
                Connect.Comando.Parameters.AddWithValue("@data_entradasaida", notafiscal.DataEntradaSaida);
                Connect.Comando.Parameters.AddWithValue("@tiponf", "S");
                Connect.Comando.Parameters.AddWithValue("@valor_total_itens", notafiscal.ValorTotalItens);
                Connect.Comando.Parameters.AddWithValue("@valor_documento", notafiscal.ValorTotalDocumento);
                Connect.Comando.Parameters.AddWithValue("@desconto_total_itens", notafiscal.DescontoTotalItens);
                Connect.Comando.Parameters.AddWithValue("@desconto_documento", notafiscal.DescontoDocumento);
                Connect.Comando.Parameters.AddWithValue("@idpessoa", notafiscal.Pessoa?.PessoaID ?? null);

                retorno = Connect.Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Connect.Comando.CommandText = @"DELETE FROM notafiscal_has_item WHERE idnotafiscal = @idnotafiscal";
                    Connect.Comando.ExecuteNonQuery();

                    Connect.Comando.CommandText = @"INSERT INTO notafiscal_has_item (idnotafiscal, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                            VALUES
                                            (@idnotafiscal, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (var i in notafiscal.NotaFiscalPropriaItem)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@idnotafiscal", notafiscal.NotaFiscalPropriaID);
                        Connect.Comando.Parameters.AddWithValue("@iditem", i.Item.ItemID);
                        Connect.Comando.Parameters.AddWithValue("@quantidade", i.Quantidade);
                        Connect.Comando.Parameters.AddWithValue("@valor_unitario", i.ValorUnitario);
                        Connect.Comando.Parameters.AddWithValue("@valor_total", i.ValorTotal);
                        Connect.Comando.Parameters.AddWithValue("@desconto_porc", i.DescontoPorc);
                        Connect.Comando.Parameters.AddWithValue("@desconto", i.Desconto);
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
        public List<NotaFiscalPropriaItem> BuscaItensDaNotaFiscal(NotaFiscalPropria notafiscal)
        {
            List<NotaFiscalPropriaItem> itensNotaFiscal = new List<NotaFiscalPropriaItem>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * 
                                             FROM notafiscal_has_item ni INNER JOIN item i 
                                             ON ni.iditem = i.iditem 
                                             WHERE idnotafiscal = @idnotafiscal", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idnotafiscal", notafiscal.NotaFiscalPropriaID);

                using (var reader = Connect.Comando.ExecuteReader())
                {

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
                            //Unimedida = new UnimedidaDAO().BuscaUnimedidaByID(reader.GetInt32(reader.GetOrdinal("idunimedida")))
                        };

                        NotaFiscalPropriaItem nfi = new NotaFiscalPropriaItem
                        {
                            Quantidade = reader.GetDecimal(reader.GetOrdinal("quantidade")),
                            ValorUnitario = reader.GetDecimal(reader.GetOrdinal("valor_unitario")),
                            ValorTotal = reader.GetDecimal(reader.GetOrdinal("valor_total")),
                            DescontoPorc = reader.GetDecimal(reader.GetOrdinal("desconto_porc")),
                            Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                            Item = i
                        };
                        itensNotaFiscal.Add(nfi);
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
            return itensNotaFiscal;
        }

        public void LimpaRegistrosEstoque(NotaFiscalPropria nota)
        {
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"DELETE FROM registro_estoque 
                                                WHERE documento = @documento
                                                AND idpessoa = @idpessoa
                                                AND tipomovimentacao = 'S'", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@documento", nota.NotaFiscalPropriaID.ToString());
                Connect.Comando.Parameters.AddWithValue("@idpessoa", nota.Pessoa?.PessoaID ?? null);
                Connect.Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
        }

        public int MovimentaEstoque(NotaFiscalPropria nota)
        {
            int retorno = 0;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;

                foreach (var i in nota.NotaFiscalPropriaItem)
                {
                    Connect.Comando.CommandText = @"INSERT INTO registro_estoque 
                                                (tipomovimentacao, data, documento, iditem, quantidade, idpessoa)
                                                VALUES
                                                (@tipomovimentacao, @data, @documento, @iditem, @quantidade, @idpessoa)";
                    Connect.Comando.Parameters.Clear();
                    Connect.Comando.Parameters.AddWithValue("@tipomovimentacao", "S");
                    Connect.Comando.Parameters.AddWithValue("@data", nota.DataEntradaSaida);
                    Connect.Comando.Parameters.AddWithValue("@documento", nota.NotaFiscalPropriaID.ToString());
                    Connect.Comando.Parameters.AddWithValue("@iditem", i.Item.ItemID);
                    Connect.Comando.Parameters.AddWithValue("@quantidade", i.Quantidade);
                    Connect.Comando.Parameters.AddWithValue("@idpessoa", nota.Pessoa?.PessoaID ?? null);
                    retorno = Connect.Comando.ExecuteNonQuery();

                    Connect.Comando.Parameters.Clear();
                    Connect.Comando.CommandText = @"UPDATE item SET quantidade = 
                                                    (SELECT COALESCE(SUM(quantidade), 0) FROM registro_estoque WHERE iditem = @iditem AND tipomovimentacao = 'E')
                                                    -
                                                    (SELECT COALESCE(SUM(quantidade), 0) FROM registro_estoque WHERE iditem = @iditem AND tipomovimentacao = 'S')
                                                    WHERE iditem = @iditem";
                    Connect.Comando.Parameters.AddWithValue("@quantidade_atualizada", i.Item.Quantidade - i.Quantidade);
                    Connect.Comando.Parameters.AddWithValue("@iditem", i.Item.ItemID);
                    Connect.Comando.ExecuteNonQuery();
                }
                Connect.tr.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }

            return retorno;
        }
    }
}