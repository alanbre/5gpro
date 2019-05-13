using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class NotaFiscalPropriaDAO : ConexaoDAO
    {
        private static ConexaoDAO connection = new ConexaoDAO();
        private readonly PessoaDAO pessoaDAO = new PessoaDAO(connection);

        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT nf1.idnotafiscal + 1 AS proximoid 
                                             FROM notafiscal AS nf1 
                                             LEFT OUTER JOIN notafiscal AS nf2 ON nf1.idnotafiscal + 1 = nf2.idnotafiscal 
                                             WHERE nf2.idnotafiscal IS NULL 
                                             ORDER BY proximoid 
                                             LIMIT 1;", Conexao);

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }

            return proximoid;
        }
        public NotaFiscalPropria BuscaByID(int codigo)
        {
            NotaFiscalPropria notafiscal = new NotaFiscalPropria();
           
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM notafiscal WHERE idnotafiscal = @idnotafiscal", Conexao);
                Comando.Parameters.AddWithValue("@idnotafiscal", codigo);

                IDataReader reader = Comando.ExecuteReader();

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
                        DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento")),
                        Pessoa = pessoaDAO.BuscaById(reader.GetInt32(reader.GetOrdinal("idpessoa")))
                    };
                    reader.Close();
                }
                else
                {
                    notafiscal = null;
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
            if (notafiscal != null)
            {
                notafiscal.NotaFiscalPropriaItem = BuscaItensDaNotaFiscal(notafiscal);
            }
            return notafiscal;
        }
        public NotaFiscalPropria Proximo(int codAtual)
        {
            NotaFiscalPropria notafiscal = new NotaFiscalPropria();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM notafiscal WHERE idnotafiscal = (SELECT min(idnotafiscal) FROM notafiscal WHERE idnotafiscal > @idnotafiscal)", Conexao);
                Comando.Parameters.AddWithValue("@idnotafiscal", codAtual);

                IDataReader reader = Comando.ExecuteReader();

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
                        DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento")),
                        Pessoa = pessoaDAO.BuscaById(reader.GetInt32(reader.GetOrdinal("idpessoa")))
                    };
                    reader.Close();
                }
                else
                {
                    notafiscal = null;
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

            if (notafiscal != null) { notafiscal.NotaFiscalPropriaItem = BuscaItensDaNotaFiscal(notafiscal); }

            return notafiscal;
        }
        public NotaFiscalPropria Anterior(int codAtual)
        {
            NotaFiscalPropria notafiscal = new NotaFiscalPropria();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM notafiscal WHERE idnotafiscal = (SELECT max(idnotafiscal) FROM notafiscal WHERE idnotafiscal < @idnotafiscal)", Conexao);
                Comando.Parameters.AddWithValue("@idnotafiscal", codAtual);

                IDataReader reader = Comando.ExecuteReader();

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
                        DescontoDocumento = reader.GetDecimal(reader.GetOrdinal("desconto_documento")),
                        Pessoa = pessoaDAO.BuscaById(reader.GetInt32(reader.GetOrdinal("idpessoa")))
                    };
                    reader.Close();
                }
                else
                {
                    notafiscal = null;
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

            if (notafiscal != null) { notafiscal.NotaFiscalPropriaItem = BuscaItensDaNotaFiscal(notafiscal); }

            return notafiscal;
        }
        public int SalvarOuAtualizar(NotaFiscalPropria notafiscal)
        {
            int retorno = 0;
            try
            {
                AbrirConexao();
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;


                Comando.CommandText = @"INSERT INTO notafiscal
                         (idnotafiscal, data_emissao, data_entradasaida, tiponf, valor_total_itens, valor_documento, desconto_total_itens, desconto_documento, idpessoa)
                          VALUES
                         (@idnotafiscal, @data_emissao, @data_entradasaida, @tiponf, @valor_total_itens, @valor_documento, @desconto_total_itens, @desconto_documento, @idpessoa)
                          ON DUPLICATE KEY UPDATE
                          data_emissao = @data_emissao, data_entradasaida = @data_entradasaida, valor_total_itens = @valor_total_itens,
                          valor_documento = @valor_documento, desconto_total_itens = @desconto_total_itens, desconto_documento = @desconto_documento,
                          idpessoa = @idpessoa
                          ";

                Comando.Parameters.AddWithValue("@idnotafiscal", notafiscal.NotaFiscalPropriaID);
                Comando.Parameters.AddWithValue("@data_emissao", notafiscal.DataEmissao);
                Comando.Parameters.AddWithValue("@data_entradasaida", notafiscal.DataEntradaSaida);
                Comando.Parameters.AddWithValue("@tiponf", "S");
                Comando.Parameters.AddWithValue("@valor_total_itens", notafiscal.ValorTotalItens);
                Comando.Parameters.AddWithValue("@valor_documento", notafiscal.ValorTotalDocumento);
                Comando.Parameters.AddWithValue("@desconto_total_itens", notafiscal.DescontoTotalItens);
                Comando.Parameters.AddWithValue("@desconto_documento", notafiscal.DescontoDocumento);
                if (notafiscal.Pessoa != null) { Comando.Parameters.AddWithValue("@idpessoa", notafiscal.Pessoa.PessoaID); }

                retorno = Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Comando.CommandText = @"DELETE FROM notafiscal_has_item WHERE idnotafiscal = @idnotafiscal";
                    Comando.ExecuteNonQuery();

                    Comando.CommandText = @"INSERT INTO notafiscal_has_item (idnotafiscal, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                            VALUES
                                            (@idnotafiscal, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (NotaFiscalPropriaItem i in notafiscal.NotaFiscalPropriaItem)
                    {
                        Comando.Parameters.Clear();
                        Comando.Parameters.AddWithValue("@idnotafiscal", notafiscal.NotaFiscalPropriaID);
                        Comando.Parameters.AddWithValue("@iditem", i.Item.ItemID);
                        Comando.Parameters.AddWithValue("@quantidade", i.Quantidade);
                        Comando.Parameters.AddWithValue("@valor_unitario", i.ValorUnitario);
                        Comando.Parameters.AddWithValue("@valor_total", i.ValorTotal);
                        Comando.Parameters.AddWithValue("@desconto_porc", i.DescontoPorc);
                        Comando.Parameters.AddWithValue("@desconto", i.Desconto);
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
        public List<NotaFiscalPropriaItem> BuscaItensDaNotaFiscal(NotaFiscalPropria notafiscal)
        {
            List<NotaFiscalPropriaItem> itensNotaFiscal = new List<NotaFiscalPropriaItem>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * 
                                             FROM notafiscal_has_item ni INNER JOIN item i 
                                             ON ni.iditem = i.iditem 
                                             WHERE idnotafiscal = @idnotafiscal", Conexao);
                Comando.Parameters.AddWithValue("@idnotafiscal", notafiscal.NotaFiscalPropriaID);

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
            return itensNotaFiscal;
        }
    }
}