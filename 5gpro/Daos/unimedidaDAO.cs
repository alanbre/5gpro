using _5gpro.Entities;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class UnimedidaDAO
    {
        public int SalvaOuAtualiza(Unimedida unimedida)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"INSERT INTO unimedida
                            (idunimedida, sigla, descricao)
                            VALUES
                            (@idunimedida, @sigla, @descricao)
                            ON DUPLICATE KEY UPDATE
                            sigla = @sigla, descricao = @descricao";
                sql.addParam("@idunimedida", unimedida.UnimedidaID);
                sql.addParam("@sigla", unimedida.Sigla);
                sql.addParam("@descricao", unimedida.Descricao);
                retorno = sql.insertQuery();
            }
            return retorno;
        }
        public Unimedida BuscaByID(int Codigo)
        {
            var unimedida = new Unimedida();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "SELECT * FROM unimedida WHERE idunimedida = @idunimedida";
                sql.addParam("@idunimedida", Codigo);
                var data = sql.selectQueryForSingleRecord();
                if(data == null)
                {
                    return null;
                }
                unimedida = LeDadosReader(data);
            }
            return unimedida;
        }
        public Unimedida Anterior(int Codigo)
        {
            var unidadeMedida = new Unimedida();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM unimedida
                            WHERE idunimedida = (SELECT max(idunimedida) FROM unimedida WHERE idunimedida < @idunimedida)";
                sql.addParam("@idunimedida", Codigo);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                unidadeMedida = LeDadosReader(data);
            }
            return unidadeMedida;
        }
        public Unimedida Proximo(int Codigo)
        {
            var unidadeMedida = new Unimedida();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM unimedida
                            WHERE idunimedida = (SELECT min(idunimedida) FROM unimedida WHERE idunimedida > @idunimedida)";
                sql.addParam("@idunimedida", Codigo);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                unidadeMedida = LeDadosReader(data);
            }
            return unidadeMedida;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT u1.idunimedida + 1 AS proximoid
                            FROM unimedida AS u1
                            LEFT OUTER JOIN unimedida AS u2 ON u1.idunimedida + 1 = u2.idunimedida
                            WHERE u2.idunimedida IS NULL
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
        public IEnumerable<Unimedida> Busca(string descricao)
        {
            var listaUnimedida = new List<Unimedida>();
            string conDescUnimedida = descricao.Length > 0 ? "AND descricao LIKE @descricao" : "";
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM unimedida 
                            WHERE 1=1 "
                            + conDescUnimedida +
                            @" ORDER BY idunimedida";
                if (conDescUnimedida.Length > 0) { sql.addParam("@descricao", "%" + descricao + "%"); }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var unimedida = LeDadosReader(d);

                    listaUnimedida.Add(unimedida);
                }
            }
            return listaUnimedida;
        }
        public List<Unimedida> BuscaTodas()
        {

            var listaUnimedida = new List<Unimedida>();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "SELECT * FROM unimedida";
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var unimedida = LeDadosReader(d);

                    listaUnimedida.Add(unimedida);
                }
            }
            return listaUnimedida;
        }
        private Unimedida LeDadosReader(Dictionary<string, object> data)
        {
            var unimedida = new Unimedida();
            unimedida.UnimedidaID = Convert.ToInt32(data["idunimedida"]);
            unimedida.Descricao = (string)data["descricao"];
            unimedida.Sigla = (string)data["sigla"];
            return unimedida;
        }
    }
}