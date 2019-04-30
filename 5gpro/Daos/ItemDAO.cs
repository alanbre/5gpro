using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class ItemDAO : ConexaoDAO
    {
        private readonly UnimedidaDAO unimedidaDAO = new UnimedidaDAO();


        public int SalvarOuAtualizarItem(Item item)
        {
            int retorno = 0;
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand(@"INSERT INTO item 
                          (iditem, descitem, denominacaocompra, tipo, referencia, valorentrada, valorsaida, estoquenecessario, idunimedida, idsubgrupoitem) 
                          VALUES
                          (@iditem, @descitem, @denominacaocompra, @tipo, @referencia, @valorentrada, @valorsaida, @estoquenecessario, @idunimedida, @idsubgrupoitem)
                          ON DUPLICATE KEY UPDATE
                           descitem = @descitem, denominacaocompra = @denominacaocompra, tipo = @tipo, referencia = @referencia, valorentrada = @valorentrada,
                           valorsaida = @valorsaida, estoquenecessario = @estoquenecessario, idunimedida = @idunimedida, idsubgrupoitem = @idsubgrupoitem
                         ;",
                         Conexao);

                Comando.Parameters.AddWithValue("@iditem", item.ItemID);
                Comando.Parameters.AddWithValue("@descitem", item.Descricao);
                Comando.Parameters.AddWithValue("@denominacaocompra", item.DescCompra);
                Comando.Parameters.AddWithValue("@tipo", item.TipoItem);
                Comando.Parameters.AddWithValue("@referencia", item.Referencia);
                Comando.Parameters.AddWithValue("@valorentrada", item.ValorEntrada);
                Comando.Parameters.AddWithValue("@valorsaida", item.ValorSaida);
                Comando.Parameters.AddWithValue("@estoquenecessario", item.Estoquenecessario);
                Comando.Parameters.AddWithValue("@idunimedida", item.Unimedida.UnimedidaID);
                Comando.Parameters.AddWithValue("@idsubgrupoitem", item.SubGrupoItem.SubGrupoItemID);


                retorno = Comando.ExecuteNonQuery();
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

        public Item BuscarItemById(int cod)
        {
            Item item = new Item();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM item WHERE iditem = @iditem", Conexao);
                Comando.Parameters.AddWithValue("@iditem", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    item = new Item
                    {
                        ItemID = reader.GetInt32(reader.GetOrdinal("iditem")),
                        Descricao = reader.GetString(reader.GetOrdinal("descitem")),
                        DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra")),
                        TipoItem = reader.GetString(reader.GetOrdinal("tipo")),
                        Referencia = reader.GetString(reader.GetOrdinal("referencia")),
                        ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada")),
                        ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida")),
                        Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario")),
                        Unimedida = unimedidaDAO.BuscaUnimedidaByCod(reader.GetInt32(reader.GetOrdinal("idunimedida")))
                    };
                    reader.Close();
                }
                else
                {
                    item = null;
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
            return item;
        }

        public Item BuscarProximoItem(string codAtual)
        {
            Item item = new Item();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM item WHERE iditem = (SELECT min(iditem) FROM item WHERE iditem > @iditem)", Conexao);
                Comando.Parameters.AddWithValue("@iditem", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    item = new Item
                    {
                        ItemID = reader.GetInt32(reader.GetOrdinal("iditem")),
                        Descricao = reader.GetString(reader.GetOrdinal("descitem")),
                        DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra")),
                        TipoItem = reader.GetString(reader.GetOrdinal("tipo")),
                        Referencia = reader.GetString(reader.GetOrdinal("referencia")),
                        ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada")),
                        ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida")),
                        Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario")),
                        Unimedida = new UnimedidaDAO().BuscaUnimedidaByCod(reader.GetInt32(reader.GetOrdinal("idunimedida")))
                    };
                    reader.Close();
                }
                else
                {
                    item = null;
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

            return item;
        }

        public Item BuscarItemAnterior(string codAtual)
        {
            Item item = new Item();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM item WHERE iditem = (SELECT max(iditem) FROM item WHERE iditem < @iditem)", Conexao);
                Comando.Parameters.AddWithValue("@iditem", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    item = new Item
                    {
                        ItemID = reader.GetInt32(reader.GetOrdinal("iditem")),
                        Descricao = reader.GetString(reader.GetOrdinal("descitem")),
                        DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra")),
                        TipoItem = reader.GetString(reader.GetOrdinal("tipo")),
                        Referencia = reader.GetString(reader.GetOrdinal("referencia")),
                        ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada")),
                        ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida")),
                        Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario")),
                        Unimedida = new UnimedidaDAO().BuscaUnimedidaByCod(reader.GetInt32(reader.GetOrdinal("idunimedida")))
                    };
                    reader.Close();
                }
                else
                {
                    item = null;
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

            return item;
        }

        public List<Item> BuscaItem(string descItem, string denomItem, string tipoItem)
        {
            List<Item> itens = new List<Item>();
            string conDescItem = descItem.Length > 0 ? "AND i.descitem LIKE @descitem" : "";
            string conDenomItem = denomItem.Length > 0 ? "AND i.denominacaocompra LIKE @denominacaocompra" : "";
            string conTipoItem = tipoItem.Length > 0 ? "AND i.tipo LIKE @tipo" : "";

            try
            {
                AbrirConexao();

                Comando = new MySqlCommand(@"SELECT * 
                                             FROM item i INNER JOIN unimedida u 
                                             ON i.idunimedida = u.idunimedida
                                             WHERE 1=1
                                             " + conDescItem + @"                                         
                                             " + conDenomItem + @"
                                             " + conTipoItem + @"
                                             ORDER BY i.iditem;", Conexao);


                if (denomItem.Length > 0) { Comando.Parameters.AddWithValue("@denominacaocompra", "%" + denomItem + "%"); }
                if (descItem.Length > 0) { Comando.Parameters.AddWithValue("@descitem", "%" + descItem + "%"); }
                if (tipoItem.Length > 0) { Comando.Parameters.AddWithValue("@tipo", "%" + tipoItem + "%"); }

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {

                    Item item = new Item
                    {
                        ItemID = reader.GetInt32(reader.GetOrdinal("iditem")),
                        Descricao = reader.GetString(reader.GetOrdinal("descitem")),
                        DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra")),
                        TipoItem = reader.GetString(reader.GetOrdinal("tipo")),
                        Referencia = reader.GetString(reader.GetOrdinal("referencia")),
                        ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada")),
                        ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida")),
                        Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario")),
                        Unimedida = unimedidaDAO.BuscaUnimedidaByCod(reader.GetInt32(reader.GetOrdinal("idunimedida")))
                    };
                    itens.Add(item);
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
            return itens;
        }

        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT i1.iditem + 1 AS proximoid
                                             FROM item AS i1
                                             LEFT OUTER JOIN item AS i2 ON i1.iditem + 1 = i2.iditem
                                             WHERE i2.iditem IS NULL
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
    }

}
