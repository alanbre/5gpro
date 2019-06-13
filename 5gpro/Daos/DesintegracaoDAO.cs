using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class DesintegracaoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public int SalvaOuAtualiza(Desintegracao desintegracao)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO desintegracao
                            (iddesintegracao, iditemdesintegrado, tipo)
                            VALUES
                            (@iddesintegracao, @iditemdesintegrado, @tipo)
                            ON DUPLICATE KEY UPDATE
                            tipo = @tipo";

                sql.addParam("@iddesintegracao", desintegracao.DesintegracaoID);
                sql.addParam("@iditemdesintegrado", desintegracao.Itemdesintegrado.ItemID);
                sql.addParam("@tipo", desintegracao.Tipo);

                retorno = sql.insertQuery();
                if (retorno > 0)
                {
                    sql.Query = @"DELETE FROM resultado_desintegracao WHERE iddesintegracao = @iddesintegracao";
                    sql.deleteQuery();
                    switch (desintegracao.Tipo)
                    {
                        case "P":
                            sql.Query = @"INSERT INTO resultado_desintegracao (iddesintegracao, iditemparte, porcentagem)
                                VALUES
                                (@iddesintegracao, @iditemparte, @porcentagem)";
                            break;

                        case "Q":
                            sql.Query = @"INSERT INTO resultado_desintegracao (iddesintegracao, iditemparte, quantidade)
                                VALUES
                                (@iddesintegracao, @iditemparte, @quantidade)";
                            break;
                    }

                    foreach (var p in desintegracao.Partes)
                    {
                        sql.clearParams();
                        sql.addParam("@iddesintegracao", p.Desintegracao.DesintegracaoID);
                        sql.addParam("@iditemparte", p.Item.ItemID);

                        if (desintegracao.Tipo == "P")
                            sql.addParam("@porcentagem", p.Porcentagem);
                        else
                            sql.addParam("@quantidade", p.Quantidade);

                        sql.insertQuery();
                    }
                }
                sql.Commit();
            }
            return retorno;
        }

        public Desintegracao BuscaByID(int Codigo)
        {
            var desintegracao = new Desintegracao();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM desintegracao d
                              INNER JOIN resultado_desintegracao r 
                              ON d.iddesintegracao = r.iddesintegracao
                              INNER JOIN item i 
                              ON r.iditemparte = i.iditem
                              WHERE d.iddesintegracao = @iddesintegracao";

                sql.addParam("@iddesintegracao", Codigo);

                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                desintegracao = LeDadosReader(data);
            }
            return desintegracao;

        }

        //public Item Anterior(int Codigo)
        //{
        //    var item = new Item();
        //    using (MySQLConn sql = new MySQLConn(Connect.Conecta))
        //    {
        //        sql.Query = @"SELECT *, g.nome AS grupoitemnome FROM item i 
        //                    INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
        //                    INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
        //                    INNER JOIN unimedida u ON u.idunimedida = i.idunimedida
        //                    WHERE iditem = (SELECT max(iditem) FROM item WHERE iditem < @iditem)";
        //        sql.addParam("@iditem", Codigo);

        //        var data = sql.selectQueryForSingleRecord();
        //        if (data == null)
        //        {
        //            return null;
        //        }
        //        item = LeDadosReader(data);
        //    }
        //    return item;
        //}
        //public Item Proximo(int Codigo)
        //{
            //var item = new Item();
            //using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            //{
            //    sql.Query = @"SELECT *, g.nome AS grupoitemnome FROM item i
            //                INNER JOIN subgrupoitem s ON i.idsubgrupoitem = s.idsubgrupoitem
            //                INNER JOIN grupoitem g ON s.idgrupoitem = g.idgrupoitem
            //                INNER JOIN unimedida u ON u.idunimedida = i.idunimedida
            //                WHERE iditem = (SELECT min(iditem) FROM item WHERE iditem > @iditem)";
            //    sql.addParam("@iditem", Codigo);

            //    var data = sql.selectQueryForSingleRecord();
            //    if (data == null)
            //    {
            //        return null;
            //    }
            //    item = LeDadosReader(data);
            //}
            //return item;
        //}


        private Desintegracao LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }

            List<DesintegracaoResultado> listapartes = new List<DesintegracaoResultado>();
            var desintegracao = new Desintegracao();
            var item = new Item();

            item.ItemID = Convert.ToInt32(data[0]["iditemdesintegrado"]);
            item.ValorEntrada = Convert.ToInt32(data[0]["valorentrada"]);
            item.ValorSaida = Convert.ToInt32(data[0]["valorsaida"]);


            desintegracao.DesintegracaoID = Convert.ToInt32(data[0]["iddesintegracao"]);
            desintegracao.Itemdesintegrado = item;
            desintegracao.Tipo = (string)(data[0]["tipo"]);

            foreach (var p in data)
            {
                var parte = new DesintegracaoResultado();
                item = new Item();
                item.ItemID = Convert.ToInt32(p["iditemparte"]);
                item.Descricao = (string)p["descitem"];
                item.ValorEntrada = (decimal)p["valorentrada"];
                item.ValorSaida = (decimal)p["valorsaida"];
                parte.Desintegracao = desintegracao;
                parte.Item = item;

                if (desintegracao.Tipo == "P")
                    parte.Porcentagem = (decimal)p["porcentagem"];
                else
                    parte.Quantidade = (decimal)p["quantidade"];

                listapartes.Add(parte);
            }
            desintegracao.Partes = listapartes;
            return desintegracao;

        }
    }
}
