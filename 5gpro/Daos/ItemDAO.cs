using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class ItemDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public int SalvarOuAtualizarItem(Item item)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"INSERT INTO item 
                          (iditem, descitem, denominacaocompra, tipo, referencia, valorentrada, valorsaida, estoquenecessario, idunimedida, idsubgrupoitem) 
                          VALUES
                          (@iditem, @descitem, @denominacaocompra, @tipo, @referencia, @valorentrada, @valorsaida, @estoquenecessario, @idunimedida, @idsubgrupoitem)
                          ON DUPLICATE KEY UPDATE
                           descitem = @descitem, denominacaocompra = @denominacaocompra, tipo = @tipo, referencia = @referencia, valorentrada = @valorentrada,
                           valorsaida = @valorsaida, estoquenecessario = @estoquenecessario, idunimedida = @idunimedida, idsubgrupoitem = @idsubgrupoitem
                         ;",
                         Connect.Conexao);

               Connect.Comando.Parameters.AddWithValue("@iditem", item.ItemID);
               Connect.Comando.Parameters.AddWithValue("@descitem", item.Descricao);
               Connect.Comando.Parameters.AddWithValue("@denominacaocompra", item.DescCompra);
               Connect.Comando.Parameters.AddWithValue("@tipo", item.TipoItem);
               Connect.Comando.Parameters.AddWithValue("@referencia", item.Referencia);
               Connect.Comando.Parameters.AddWithValue("@valorentrada", item.ValorEntrada);
               Connect.Comando.Parameters.AddWithValue("@valorsaida", item.ValorSaida);
               Connect.Comando.Parameters.AddWithValue("@estoquenecessario", item.Estoquenecessario);
               Connect.Comando.Parameters.AddWithValue("@idunimedida", item.Unimedida.UnimedidaID);
               Connect.Comando.Parameters.AddWithValue("@idsubgrupoitem", item.SubGrupoItem.SubGrupoItemID);


                retorno = Connect.Comando.ExecuteNonQuery();
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

        public Item BuscarById(int cod)
        {
            Item item = null;
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = null;
            Unimedida unimedida = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *, g.nome AS grupoitemnome FROM item i
                                                    INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                                                    INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                                                    WHERE iditem = @iditem", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@iditem", cod);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    unimedida = new Unimedida
                    {
                        UnimedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida"))
                    };

                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("idgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("grupoitemnome"))
                    };

                    subgrupoitem = new SubGrupoItem
                    {
                        SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("idsubgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        GrupoItem = grupoitem
                    };

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
                        Quantidade = reader.GetDecimal(reader.GetOrdinal("quantidade")),
                        Unimedida = unimedida,
                        SubGrupoItem = subgrupoitem
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
                Connect.FecharConexao();
            }
            return item;
        }

        public Item Proximo(string codAtual)
        {
            Item item = null;
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = null;
            Unimedida unimedida = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *, g.nome AS grupoitemnome FROM item i
                                                     INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                                                     INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                                                     WHERE iditem = (SELECT min(iditem) FROM item WHERE iditem > @iditem)"
                                                     , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@iditem", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    unimedida = new Unimedida
                    {
                        UnimedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida"))
                    };

                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("idgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("grupoitemnome"))
                    };

                    subgrupoitem = new SubGrupoItem
                    {
                        SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("idsubgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        GrupoItem = grupoitem
                    };

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
                        Quantidade = reader.GetDecimal(reader.GetOrdinal("quantidade")),
                        Unimedida = unimedida,
                        SubGrupoItem = subgrupoitem
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
                Connect.FecharConexao();
            }

            return item;
        }

        public Item Anterior(string codAtual)
        {
            Item item = new Item();
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = null;
            Unimedida unimedida = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *, g.nome AS grupoitemnome FROM item i 
                                                     INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                                                     INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                                                     WHERE iditem = (SELECT max(iditem) FROM item WHERE iditem < @iditem)"
                                                    , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@iditem", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    unimedida = new Unimedida
                    {
                        UnimedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida"))
                    };

                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("idgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("grupoitemnome"))
                    };

                    subgrupoitem = new SubGrupoItem
                    {
                        SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("idsubgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        GrupoItem = grupoitem
                    };

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
                        Quantidade = reader.GetDecimal(reader.GetOrdinal("quantidade")),
                        Unimedida = unimedida,
                        SubGrupoItem = subgrupoitem
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
                Connect.FecharConexao();
            }

            return item;
        }

        public List<Item> Busca(string descItem, string denomItem, string tipoItem)
        {
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = null;
            Unimedida unimedida = null;
            List<Item> itens = new List<Item>();
            string conDescItem = descItem.Length > 0 ? "AND i.descitem LIKE @descitem" : "";
            string conDenomItem = denomItem.Length > 0 ? "AND i.denominacaocompra LIKE @denominacaocompra" : "";
            string conTipoItem = tipoItem.Length > 0 ? "AND i.tipo LIKE @tipo" : "";

            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"SELECT *, g.nome AS grupoitemnome FROM item i
                                             INNER JOIN unimedida u ON i.idunimedida = u.idunimedida
                                             INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                                             INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                                             WHERE 1=1
                                             " + conDescItem + @"                                         
                                             " + conDenomItem + @"
                                             " + conTipoItem + @"
                                             ORDER BY i.iditem;", Connect.Conexao);


                if (denomItem.Length > 0) { Connect.Comando.Parameters.AddWithValue("@denominacaocompra", "%" + denomItem + "%"); }
                if (descItem.Length > 0) { Connect.Comando.Parameters.AddWithValue("@descitem", "%" + descItem + "%"); }
                if (tipoItem.Length > 0) { Connect.Comando.Parameters.AddWithValue("@tipo", "%" + tipoItem + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    unimedida = new Unimedida
                    {
                        UnimedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida")),
                        Sigla = reader.GetString(reader.GetOrdinal("sigla")),
                        Descricao = reader.GetString(reader.GetOrdinal("descricao"))
                    };

                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("idgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("grupoitemnome"))
                    };

                    subgrupoitem = new SubGrupoItem
                    {
                        SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("idsubgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        GrupoItem = grupoitem
                    };

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
                        Quantidade = reader.GetDecimal(reader.GetOrdinal("quantidade")),
                        Unimedida = unimedida,
                        SubGrupoItem = subgrupoitem
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
                Connect.FecharConexao();
            }
            return itens;
        }

        public string ProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT i1.iditem + 1 AS proximoid
                                             FROM item AS i1
                                             LEFT OUTER JOIN item AS i2 ON i1.iditem + 1 = i2.iditem
                                             WHERE i2.iditem IS NULL
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
    }

}
