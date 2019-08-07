using _5gpro.Entities;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;


namespace _5gpro.Daos
{
    class ItemDAO
    {
        public int SalvaOuAtualiza(Item item)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"INSERT INTO item 
                            (iditem, codigointerno, descitem, denominacaocompra, tipo, referencia,
                            valorentrada, valorsaida, estoquenecessario, idunimedida, idsubgrupoitem,
                            quantidade, custo, idusuario) 
                            VALUES
                            (@iditem, @codigointerno, @descitem, @denominacaocompra, @tipo, @referencia,
                            @valorentrada, @valorsaida, @estoquenecessario, @idunimedida, @idsubgrupoitem,
                            @quantidade, @custo, @idusuario)
                            ON DUPLICATE KEY UPDATE
                            codigointerno = @codigointerno, descitem = @descitem, denominacaocompra = @denominacaocompra,
                            tipo = @tipo, referencia = @referencia, valorentrada = @valorentrada, valorsaida = @valorsaida,
                            estoquenecessario = @estoquenecessario, idunimedida = @idunimedida, idsubgrupoitem = @idsubgrupoitem,
                            quantidade = @quantidade, custo = @custo, idusuario = @idusuario";

                sql.addParam("@iditem", item.ItemID);
                sql.addParam("@codigointerno", item.CodigoInterno);
                sql.addParam("@descitem", item.Descricao);
                sql.addParam("@denominacaocompra", item.DescCompra);
                sql.addParam("@tipo", item.TipoItem);
                sql.addParam("@referencia", item.Referencia);
                sql.addParam("@valorentrada", item.ValorEntrada);
                sql.addParam("@valorsaida", item.ValorUnitario);
                sql.addParam("@estoquenecessario", item.Estoquenecessario);
                sql.addParam("@idunimedida", item.Unimedida.UnimedidaID);
                sql.addParam("@idsubgrupoitem", item.SubGrupoItem.SubGrupoItemID);
                sql.addParam("@quantidade", item.Quantidade);
                sql.addParam("@custo", item.Custo);
                sql.addParam("@idusuario", Logado.Usuario.UsuarioID);
                retorno = sql.insertQuery();
            }

            return retorno;
        }
        public int AlteracaoValores(List<Item> itens)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"UPDATE item SET valorsaida = @valorsaida WHERE iditem = @iditem";
                foreach(var i in itens)
                {
                    sql.clearParams();
                    sql.addParam("@valorsaida", i.ValorUnitario);
                    sql.addParam("@iditem", i.ItemID);
                    retorno += sql.updateQuery();
                }
                sql.Commit();
            }
            return retorno;
        }
        public string ChecaSeExistemItemIgual(string codigoInterno, string referencia)
        {
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT * FROM item WHERE referencia = @referencia AND codigointerno = @codigointerno";
                sql.addParam("@referencia", referencia);
                sql.addParam("@codigoInterno", codigoInterno);
                var data = sql.selectQueryForSingleValue();
                return (string)data?.ToString() ?? null;
            }
        }
        public Item BuscaByID(int Codigo)
        {
            var item = new Item();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, g.nome AS grupoitemnome FROM item i
                            INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                            INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                            INNER JOIN unimedida u ON u.idunimedida = i.idunimedida
                            WHERE iditem = @iditem";
                sql.addParam("@iditem", Codigo);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                item = LeDadosReader(data);
            }
            return item;
        }
        public Item Anterior(int Codigo)
        {
            var item = new Item();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, g.nome AS grupoitemnome FROM item i 
                            INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                            INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                            INNER JOIN unimedida u ON u.idunimedida = i.idunimedida
                            WHERE iditem = (SELECT max(iditem) FROM item WHERE iditem < @iditem)";
                sql.addParam("@iditem", Codigo);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                item = LeDadosReader(data);
            }
            return item;
        }
        public Item Proximo(int Codigo)
        {
            var item = new Item();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, g.nome AS grupoitemnome FROM item i
                            INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                            INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                            INNER JOIN unimedida u ON u.idunimedida = i.idunimedida
                            WHERE iditem = (SELECT min(iditem) FROM item WHERE iditem > @iditem)";
                sql.addParam("@iditem", Codigo);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                item = LeDadosReader(data);
            }
            return item;
        }
        public List<Item> Busca(string descItem, string denomItem, string refeItem,
                                string tipoItem, GrupoItem grupoitem,
                                SubGrupoItem subgrupoitem, string codigoInterno)
        {
            List<Item> itens = new List<Item>();
            string conDescItem = descItem.Length > 0 ? "AND i.descitem LIKE @descitem" : "";
            string conDenomItem = denomItem.Length > 0 ? "AND i.denominacaocompra LIKE @denominacaocompra" : "";
            string conRefeItem = refeItem.Length > 0 ? "AND i.referencia LIKE @referencia" : "";
            string conTipoItem = tipoItem.Length > 0 ? "AND i.tipo LIKE @tipo" : "";
            string conGrupoItem = grupoitem != null ? "AND g.idgrupoitem = @idgrupoitem" : "";
            string conSubgrupoItem = subgrupoitem != null ? "AND i.idsubgrupoitem = @idsubgrupoitem" : "";
            string conCodigoInterno = codigoInterno.Length > 0 ? "AND i.codigointerno LIKE @codigointerno" : "";
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = $@"SELECT *, g.nome AS grupoitemnome FROM item i
                            INNER JOIN unimedida u ON i.idunimedida = u.idunimedida
                            INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                            INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                            WHERE 1=1 
                            { conDescItem} 
                            { conDenomItem } 
                            { conRefeItem } 
                            { conTipoItem } 
                            { conSubgrupoItem } 
                            { conCodigoInterno }
                            { conGrupoItem }
                             ORDER BY i.codigointerno, i.referencia";
                if (denomItem.Length > 0) { sql.addParam("@denominacaocompra", "%" + denomItem + "%"); }
                if (descItem.Length > 0) { sql.addParam("@descitem", "%" + descItem + "%"); }
                if (refeItem.Length > 0) { sql.addParam("@referencia", "%" + refeItem + "%"); }
                if (tipoItem.Length > 0) { sql.addParam("@tipo", "%" + tipoItem + "%"); }
                if (conCodigoInterno.Length > 0) { sql.addParam("@codigointerno", "%" + codigoInterno + "%"); }
                if (grupoitem != null) { sql.addParam("@idgrupoitem", grupoitem.GrupoItemID); }
                if (subgrupoitem != null) { sql.addParam("@idsubgrupoitem", subgrupoitem.SubGrupoItemID); }

                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var item = LeDadosReader(d);
                    itens.Add(item);
                }
            }
            return itens;
        }
        public List<Item> Busca(string codigoInterno)
        {
            var itens = new List<Item>();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, g.nome AS grupoitemnome FROM item i
                            INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
                            INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
                            INNER JOIN unimedida u ON u.idunimedida = i.idunimedida
                            WHERE i.codigointerno = @codigointerno";
                sql.addParam("@codigoInterno", codigoInterno);
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var item = LeDadosReader(d);
                    itens.Add(item);
                }
                return itens;
            }
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT i1.iditem + 1 AS proximoid
                            FROM item AS i1
                            LEFT OUTER JOIN item AS i2 ON i1.iditem + 1 = i2.iditem
                            WHERE i2.iditem IS NULL
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
        private Item LeDadosReader(Dictionary<string, object> data)
        {
            var unidadeMedida = new Unimedida();
            unidadeMedida.UnimedidaID = Convert.ToInt32(data["idunimedida"]);
            unidadeMedida.Sigla = (string)data["sigla"];
            unidadeMedida.Descricao = (string)data["descricao"];

            var grupoItem = new GrupoItem();
            grupoItem.GrupoItemID = Convert.ToInt32(data["idgrupoitem"]);
            grupoItem.Nome = (string)data["grupoitemnome"];

            var subGrupoItem = new SubGrupoItem();
            subGrupoItem.SubGrupoItemID = Convert.ToInt32(data["idsubgrupoitem"]);
            subGrupoItem.Nome = (string)data["nome"];
            subGrupoItem.Codigo = Convert.ToInt32(data["codigo"]);
            subGrupoItem.GrupoItem = grupoItem;

            var item = new Item();
            item.ItemID = Convert.ToInt32(data["iditem"]);
            item.CodigoInterno = (string)data["codigointerno"];
            item.Descricao = (string)data["descitem"];
            item.DescCompra = (string)data["denominacaocompra"];
            item.TipoItem = (string)data["tipo"];
            item.Referencia = (string)data["referencia"];
            item.ValorEntrada = (decimal)data["valorentrada"];
            item.ValorUnitario = (decimal)data["valorsaida"];
            item.Estoquenecessario = (decimal)data["estoquenecessario"];
            item.Quantidade = (decimal)data["quantidade"];
            item.Custo = (decimal)data["custo"];
            item.Unimedida = unidadeMedida;
            item.SubGrupoItem = subGrupoItem;

            return item;
        }
    }

}
