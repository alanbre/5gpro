using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class SubGrupoItemDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int SalvaOuAtualiza(SubGrupoItem subgrupoitem)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"INSERT INTO subgrupoitem 
                            (idsubgrupoitem, nome, idgrupoitem) 
                            VALUES
                            (@idsubgrupoitem, @nome, @idgrupoitem)
                            ON DUPLICATE KEY UPDATE
                            nome = @nome, idgrupoitem = @idgrupoitem";
                sql.addParam("@idsubgrupoitem", subgrupoitem.SubGrupoItemID);
                sql.addParam("@nome", subgrupoitem.Nome);
                sql.addParam("@idgrupoitem", subgrupoitem.GrupoItem.GrupoItemID);
                retorno = sql.insertQuery();
            }
            return retorno;
        }
        public IEnumerable<SubGrupoItem> Busca(string nome, int grupoitemID)
        {
            var listaSubGrupoItem = new List<SubGrupoItem>();
            var conNome = nome.Length > 0 ? "AND nome LIKE @nome" : "";
            var conGrupoItem = "AND idgrupoitem = @idgrupoitem";

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM subgrupoitem  
                            WHERE 1=1 "
                            + conGrupoItem + " "
                            + conNome + " "
                            + @" ORDER BY codigo";
                sql.addParam("@idgrupoitem", grupoitemID);
                if (nome.Length > 0) { sql.addParam("@nome", "%" + nome + "%"); }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    listaSubGrupoItem.Add(LeDadosReader(d));
                }
            }
            return listaSubGrupoItem;
        }
        public SubGrupoItem BuscaByID(int Codigo, int grupoitemID)
        {
            var subgrupoitem = new SubGrupoItem();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM subgrupoitem 
                            WHERE codigo = @codigo
                            AND idgrupoitem = @idgrupoitem";
                sql.addParam("@codigo", Codigo);
                sql.addParam("@idgrupoitem", grupoitemID);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                subgrupoitem = LeDadosReader(data);
            }
            return subgrupoitem;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT i1.idsubgrupoitem + 1 AS proximoid
                            FROM subgrupoitem AS i1
                            LEFT OUTER JOIN subgrupoitem AS i2 ON i1.idsubgrupoitem + 1 = i2.idsubgrupoitem
                            WHERE i2.idsubgrupoitem IS NULL
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
        public int Remover(string idsub)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"DELETE FROM subgrupoitem WHERE idsubgrupoitem = @idsubgrupoitem";
                sql.addParam("@idsubgrupoitem", idsub);
                retorno = sql.deleteQuery();
            }
            return retorno;
        }
        private SubGrupoItem LeDadosReader(Dictionary<string, object> data)
        {
            var grupoitem = new GrupoItem();
            grupoitem.GrupoItemID = Convert.ToInt32(data["idgrupoitem"]);

            var subgrupoitem = new SubGrupoItem();
            subgrupoitem.SubGrupoItemID = Convert.ToInt32(data["idsubgrupoitem"]);
            subgrupoitem.Nome = (string)data["nome"];
            subgrupoitem.GrupoItem = grupoitem;
            subgrupoitem.Codigo = Convert.ToInt32(data["codigo"]);
            return subgrupoitem;
        }

    }
}
