using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class NotaFiscalTerceirosDAO
    {
        private static ConexaoDAO Connect;

        public NotaFiscalTerceirosDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT nf1.idnota_fiscal_terceiros + 1 AS proximoid 
                                             FROM nota_fiscal_terceiros AS nf1 
                                             LEFT OUTER JOIN nota_fiscal_terceiros AS nf2 ON nf1.idnota_fiscal_terceiros + 1 = nf2.idnota_fiscal_terceiros 
                                             WHERE nf2.idnota_fiscal_terceiros IS NULL 
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
        public NotaFiscalTerceiros BuscaByID(int codigo)
        {
            var notafiscal = new NotaFiscalTerceiros();
            var pessoa = new Pessoa();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM nota_fiscal_terceiros WHERE idnota_fiscal_terceiros = @idnota_fiscal_terceiros", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idnota_fiscal_terceiros", codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        notafiscal = new NotaFiscalTerceiros
                        {
                            NotaFiscalTerceirosID = reader.GetInt32(reader.GetOrdinal("idnota_fiscal_terceiros")),
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
                notafiscal.NotaFiscalTerceirosItem = BuscaItensDaNotaFiscal(notafiscal);
            }
            return notafiscal;
        }
        public NotaFiscalTerceiros Proximo(int codAtual)
        {
            var notafiscal = new NotaFiscalTerceiros();
            var pessoa = new Pessoa();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM nota_fiscal_terceiros WHERE idnota_fiscal_terceiros = (SELECT min(idnota_fiscal_terceiros) FROM nota_fiscal_terceiros WHERE idnota_fiscal_terceiros > @idnota_fiscal_terceiros)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idnota_fiscal_terceiros", codAtual);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        notafiscal = new NotaFiscalTerceiros
                        {
                            NotaFiscalTerceirosID = reader.GetInt32(reader.GetOrdinal("idnota_fiscal_terceiros")),
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

            if (notafiscal != null) { notafiscal.NotaFiscalTerceirosItem = BuscaItensDaNotaFiscal(notafiscal); }

            return notafiscal;
        }
        public NotaFiscalTerceiros Anterior(int codAtual)
        {
            var notafiscal = new NotaFiscalTerceiros();
            var pessoa = new Pessoa();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM nota_fiscal_terceiros WHERE idnota_fiscal_terceiros = (SELECT max(idnota_fiscal_terceiros) FROM nota_fiscal_terceiros WHERE idnota_fiscal_terceiros < @idnota_fiscal_terceiros)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idnota_fiscal_terceiros", codAtual);

                using (var reader = Connect.Comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        notafiscal = new NotaFiscalTerceiros
                        {
                            NotaFiscalTerceirosID = reader.GetInt32(reader.GetOrdinal("idnota_fiscal_terceiros")),
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

            if (notafiscal != null) { notafiscal.NotaFiscalTerceirosItem = BuscaItensDaNotaFiscal(notafiscal); }

            return notafiscal;
        }
        public int SalvarOuAtualizar(NotaFiscalTerceiros notafiscal)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;


                Connect.Comando.CommandText = @"INSERT INTO nota_fiscal_terceiros
                         (idnota_fiscal_terceiros, data_emissao, data_entradasaida, tiponf, valor_total_itens, valor_documento, desconto_total_itens, desconto_documento, idpessoa)
                          VALUES
                         (@idnota_fiscal_terceiros, @data_emissao, @data_entradasaida, @tiponf, @valor_total_itens, @valor_documento, @desconto_total_itens, @desconto_documento, @idpessoa)
                          ON DUPLICATE KEY UPDATE
                          data_emissao = @data_emissao, data_entradasaida = @data_entradasaida, valor_total_itens = @valor_total_itens,
                          valor_documento = @valor_documento, desconto_total_itens = @desconto_total_itens, desconto_documento = @desconto_documento,
                          idpessoa = @idpessoa
                          ";

                Connect.Comando.Parameters.AddWithValue("@idnota_fiscal_terceiros", notafiscal.NotaFiscalTerceirosID);
                Connect.Comando.Parameters.AddWithValue("@data_emissao", notafiscal.DataEmissao);
                Connect.Comando.Parameters.AddWithValue("@data_entradasaida", notafiscal.DataEntradaSaida);
                Connect.Comando.Parameters.AddWithValue("@tiponf", "S");
                Connect.Comando.Parameters.AddWithValue("@valor_total_itens", notafiscal.ValorTotalItens);
                Connect.Comando.Parameters.AddWithValue("@valor_documento", notafiscal.ValorTotalDocumento);
                Connect.Comando.Parameters.AddWithValue("@desconto_total_itens", notafiscal.DescontoTotalItens);
                Connect.Comando.Parameters.AddWithValue("@desconto_documento", notafiscal.DescontoDocumento);
                if (notafiscal.Pessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", notafiscal.Pessoa.PessoaID); }

                retorno = Connect.Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Connect.Comando.CommandText = @"DELETE FROM nota_fiscal_terceiros_has_item WHERE idnota_fiscal_terceiros = @idnota_fiscal_terceiros";
                    Connect.Comando.ExecuteNonQuery();

                    Connect.Comando.CommandText = @"INSERT INTO nota_fiscal_terceiros_has_item (idnota_fiscal_terceiros, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                            VALUES
                                            (@idnota_fiscal_terceiros, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (var i in notafiscal.NotaFiscalTerceirosItem)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@idnota_fiscal_terceiros", notafiscal.NotaFiscalTerceirosID);
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
        public List<NotaFiscalTerceirosItem> BuscaItensDaNotaFiscal(NotaFiscalTerceiros notafiscal)
        {
            var itensNotaFiscal = new List<NotaFiscalTerceirosItem>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * 
                                             FROM nota_fiscal_terceiros_has_item ni INNER JOIN item i 
                                             ON ni.iditem = i.iditem 
                                             WHERE idnota_fiscal_terceiros = @idnota_fiscal_terceiros", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idnota_fiscal_terceiros", notafiscal.NotaFiscalTerceirosID);

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

                        var nfi = new NotaFiscalTerceirosItem
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
    }
}
