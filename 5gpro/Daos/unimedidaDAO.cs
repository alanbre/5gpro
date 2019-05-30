using _5gpro.Entities;
using MySql.Data.MySqlClient;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class UnimedidaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int Salvar(Unimedida unimedida)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
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
        public IEnumerable<Unimedida> Busca(string descricao)
        {
            var listaUnimedida = new List<Unimedida>();
            string conDescUnimedida = descricao.Length > 0 ? "AND descricao LIKE @descricao" : "";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM unimedida 
                            WHERE 1=1 "
                            + conDescUnimedida +
                            @" ORDER BY idunimedida";
                if (conDescUnimedida.Length > 0) { sql.addParam("@nome", "%" + descricao + "%"); }
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
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
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
        public Unimedida BuscaByID(int Codigo)
        {
            var unimedida = new Unimedida();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
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