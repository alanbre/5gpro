using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class GrupoItemDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int SalvarOuAtualizar(GrupoItem grupoitem)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"INSERT INTO grupoitem 
                          (idgrupoitem, nome) 
                          VALUES
                          (@idgrupoitem, @nome)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome";
                sql.addParam("@idgrupoitem", grupoitem.GrupoItemID);
                sql.addParam("@nome", grupoitem.Nome);
                retorno = sql.insertQuery();
            }
            return retorno;
        }
        public IEnumerable<GrupoItem> Busca(string nome)
        {
            List<GrupoItem> listagrupoitem = new List<GrupoItem>();
            string conNome = nome.Length > 0 ? " AND nome LIKE @nome" : "";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM grupoitem 
                            WHERE 1=1"
                             + conNome +
                            @" ORDER BY nome";
                if (nome.Length > 0) { sql.addParam("@nome", "%" + nome + "%"); }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var grupoItem = new GrupoItem();
                    grupoItem.GrupoItemID = Convert.ToInt32(d["idgrupoitem"]);
                    grupoItem.Nome = (string)d["nome"];
                    listagrupoitem.Add(grupoItem);
                }
            }

            return listagrupoitem;
        }
        public GrupoItem BuscaByID(int Codigo)
        {
            var grupoitem = new GrupoItem();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupoitem AS grupoitemID, g.nome AS nomegrupoitem,
                                                   s.idsubgrupoitem AS subgrupoitemID, s.nome AS subgrupoitemnome,
                                                   s.idgrupoitem AS idgrupoitemsub, s.codigo
                                                   FROM grupoitem g 
                                                   LEFT JOIN subgrupoitem s 
                                                   ON g.idgrupoitem = s.idgrupoitem 
                                                   WHERE g.idgrupoitem = @idgrupoitem";
                sql.addParam("@idgrupoitem", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                grupoitem = LeDadosReader(data);
            }
            return grupoitem;
        }
        public GrupoItem Proximo(int Codigo)
        {
            var grupoitem = new GrupoItem();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupoitem AS grupoitemID, g.nome AS nomegrupoitem,
                            s.idsubgrupoitem AS subgrupoitemID, s.nome AS subgrupoitemnome,
                            s.idgrupoitem AS idgrupoitemsub , s.codigo
                            FROM grupoitem g 
                            LEFT JOIN subgrupoitem s 
                            ON g.idgrupoitem = s.idgrupoitem 
                            WHERE g.idgrupoitem = (SELECT MIN(idgrupoitem) 
                            FROM grupoitem WHERE idgrupoitem > @idgrupoitem)";
                sql.addParam("@idgrupoitem", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                grupoitem = LeDadosReader(data);
            }
            return grupoitem;
        }
        public GrupoItem Anterior(int Codigo)
        {
            var grupoitem = new GrupoItem();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupoitem AS grupoitemID, g.nome AS nomegrupoitem,
                            s.idsubgrupoitem AS subgrupoitemID, s.nome AS subgrupoitemnome,
                            s.idgrupoitem AS idgrupoitemsub , s.codigo
                            FROM grupoitem g 
                            LEFT JOIN subgrupoitem s 
                            ON g.idgrupoitem = s.idgrupoitem 
                            WHERE g.idgrupoitem = (SELECT MAX(idgrupoitem) 
                            FROM grupoitem WHERE idgrupoitem < @idgrupoitem)";
                sql.addParam("@idgrupoitem", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                grupoitem = LeDadosReader(data);
            }
            return grupoitem;
        }

        public int InserirSubGrupo(SubGrupoItem subGrupo)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO subgrupoitem (nome, idgrupoitem, codigo)
                            VALUES
                            (@nome, @idgrupoitem, @codigo)
                            ON DUPLICATE KEY UPDATE
                            nome = @nome, idgrupoitem = @idgrupoitem, codigo = @codigo";
                sql.addParam("@idsubgrupoitem", subGrupo.SubGrupoItemID);
                sql.addParam("@nome", subGrupo.Nome);
                sql.addParam("@idgrupoitem", subGrupo.GrupoItem.GrupoItemID);
                sql.addParam("@codigo", subGrupo.Codigo);
                retorno = sql.insertQuery();

                if( retorno > 0)
                {
                    sql.Query = "SELECT LAST_INSERT_ID() AS idsubgrupoitem;";
                    var data = sql.selectQueryForSingleRecord();
                    subGrupo.SubGrupoItemID = Convert.ToInt32(data["idsubgrupoitem"]);
                }
                sql.Commit();
            }
            return retorno;
        }
        public bool SubGrupoUsado(SubGrupoItem subGrupo)
        {
            var usado = true;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = "SELECT * FROM item WHERE idsubgrupoitem = @idsubgrupoitem LIMIT 1;";
                sql.addParam("@idsubgrupoitem", subGrupo.SubGrupoItemID);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    usado = false;
                }
            }
            return usado;
        }
        public int RemoverSubGrupo(SubGrupoItem subGrupo)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"DELETE FROM subgrupoitem WHERE idsubgrupoitem = @idsubgrupoitem";
                sql.addParam("@idsubgrupoitem", subGrupo.SubGrupoItemID);
                retorno = sql.deleteQuery();
            }
            return retorno;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT i1.idgrupoitem + 1 AS proximoid
                            FROM grupoitem AS i1
                            LEFT OUTER JOIN grupoitem AS i2 ON i1.idgrupoitem + 1 = i2.idgrupoitem
                            WHERE i2.idgrupoitem IS NULL
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
        private GrupoItem LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }

            var grupoItem = new GrupoItem();
            grupoItem.GrupoItemID = Convert.ToInt32(data[0]["grupoitemID"]);
            grupoItem.Nome = (string)data[0]["nomegrupoitem"];


            var listaSubGrupoItem = new List<SubGrupoItem>();

            foreach (var d in data)
            {
                if (d["subgrupoitemID"] != null)
                {
                    var subGrupoItem = new SubGrupoItem();
                    subGrupoItem.SubGrupoItemID = Convert.ToInt32(d["subgrupoitemID"]);
                    subGrupoItem.Codigo = Convert.ToInt32(d["codigo"]);
                    subGrupoItem.Nome = (string)d["subgrupoitemnome"];
                    subGrupoItem.GrupoItem = grupoItem;

                    listaSubGrupoItem.Add(subGrupoItem);
                }
            }
            grupoItem.SubGrupoItens = listaSubGrupoItem;

            return grupoItem;
        }

    }
}
