using _5gpro.Entities;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    public class BancoDAO
    {
        public Banco BuscaByCod(string Codigo)
        {
            var banco = new Banco();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT * FROM banco WHERE codigo = @codigo LIMIT 1";
                sql.addParam("@codigo", Codigo);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                banco = LeDadosReader(data);
            }
            return banco;
        }

        public List<Banco> Busca(string nome)
        {
            var bancos = new List<Banco>();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT * FROM banco WHERE nome LIKE @nome ORDER BY codigo";
                sql.addParam(@"nome", $"%{nome}%");
                var data = sql.selectQuery();
                foreach(var d in data)
                {
                    var banco = LeDadosReader(d);
                    bancos.Add(banco);
                }
                
            }
            return bancos;
        }

        private Banco LeDadosReader(Dictionary<string, object> data)
        {
            var banco = new Banco();

            banco.BancoID = Convert.ToInt32(data["idbanco"]);
            banco.Codigo = (string)data["codigo"];
            banco.Ispb = (string)data["ispb"];
            banco.Nome = (string)data["nome"];
            banco.NomeReduzido = (string)data["nomereduzido"];
            banco.Compe = Convert.ToBoolean(data["compe"]);
            banco.AcessoPrincipal = (string)data["acessoprincipal"];
            banco.InicioOperacao = (DateTime)data["iniciooperacao"];

            return banco;
        }
    }
}
