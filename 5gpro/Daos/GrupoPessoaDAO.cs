using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class GrupoPessoaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int SalvarOuAtualizar(GrupoPessoa grupopessoa)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"INSERT INTO grupopessoa 
                            (idgrupopessoa, nome) 
                            VALUES
                            (@idgrupopessoa, @nome)
                            ON DUPLICATE KEY UPDATE
                            nome = @nome";
                sql.addParam("@idgrupopessoa", grupopessoa.GrupoPessoaID);
                sql.addParam("@nome", grupopessoa.Nome);
                retorno = sql.insertQuery();
            }
            return retorno;
        }


        public IEnumerable<GrupoPessoa> Busca(string nome)
        {
            List<GrupoPessoa> listaGrupoPessoa = new List<GrupoPessoa>();
            string conNome = nome.Length > 0 ? "AND g.nome LIKE @nome" : "";

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM grupopessoa
                            WHERE 1=1"
                            + conNome +
                            @" ORDER BY nome";
                if (nome.Length > 0) { sql.addParam("@nome", "%" + nome + "%"); }
                var data = sql.selectQuery();
                foreach(var d in data)
                {
                    var grupoPessoa = new GrupoPessoa();
                    grupoPessoa.GrupoPessoaID = Convert.ToInt32(d["idgrupopessoa"]);
                    grupoPessoa.Nome = (string)d["nome"];
                    listaGrupoPessoa.Add(grupoPessoa);
                }
            }
            return listaGrupoPessoa;
        }


        public GrupoPessoa BuscarByID(int Codigo)
        {
            var grupopessoa = new GrupoPessoa();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa AS grupopessoaID, g.nome AS nomegrupopessoa,
                            s.idsubgrupopessoa AS subgrupopessoaID, s.nome AS subgrupopessoanome,
                            FROM grupopessoa g 
                            LEFT JOIN subgrupopessoa s 
                            ON g.idgrupopessoa = s.idgrupopessoa 
                            WHERE g.idgrupopessoa = @idgrupopessoa";
                sql.addParam("@idgrupoitem", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                grupopessoa = LeDadosReader(data);
            }
            return grupopessoa;
        }


        public GrupoPessoa Proximo(string Codigo)
        {
            var grupopessoa = new GrupoPessoa();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa AS grupopessoaID, g.nome AS nomegrupopessoa,
                            s.idsubgrupopessoa AS subgrupopessoaID, s.nome AS subgrupopessoanome,
                            FROM grupopessoa g 
                            LEFT JOIN subgrupopessoa s 
                            ON g.idgrupopessoa = s.idgrupopessoa 
                            WHERE g.idgrupopessoa = (SELECT MIN(idgrupopessoa) 
                            FROM grupopessoa WHERE idgrupopessoa > @idgrupopessoa)";
                sql.addParam("@idgrupoitem", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                grupopessoa = LeDadosReader(data);
            }
            return grupopessoa;
        }

        public GrupoPessoa Anterior(string Codigo)
        {
            var grupopessoa = new GrupoPessoa();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa AS grupopessoaID, g.nome AS nomegrupopessoa,
                            s.idsubgrupopessoa AS subgrupopessoaID, s.nome AS subgrupopessoanome,
                            FROM grupopessoa g 
                            LEFT JOIN subgrupopessoa s 
                            ON g.idgrupopessoa = s.idgrupopessoa 
                            WHERE g.idgrupopessoa = (SELECT MAX(idgrupopessoa) 
                            FROM grupopessoa WHERE idgrupopessoa < @idgrupopessoa)";
                sql.addParam("@idgrupoitem", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                grupopessoa = LeDadosReader(data);
            }
            return grupopessoa;
        }

        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT i1.idgrupopessoa + 1 AS proximoid
                            FROM grupopessoa AS i1
                            LEFT OUTER JOIN grupopessoa AS i2 ON i1.idgrupopessoa + 1 = i2.idgrupopessoa
                            WHERE i2.idgrupopessoa IS NULL
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

        private GrupoPessoa LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }

            var grupoPessoa = new GrupoPessoa();
            grupoPessoa.GrupoPessoaID = Convert.ToInt32(data[0]["grupopessoaID"]);
            grupoPessoa.Nome = (string)data[0]["nomegrupopessoa"];

            var listaSubGrupoPessoa = new List<SubGrupoPessoa>();

            foreach (var d in data)
            {
                var subGrupoPessoa = new SubGrupoPessoa();
                subGrupoPessoa.SubGrupoPessoaID = Convert.ToInt32(d["subgrupopessoaID"]);
                subGrupoPessoa.Nome = (string)d["subgrupopessoanome"];
                subGrupoPessoa.GrupoPessoa = grupoPessoa;

                listaSubGrupoPessoa.Add(subGrupoPessoa);
            }
            grupoPessoa.SubGrupoPessoas = listaSubGrupoPessoa;

            return grupoPessoa;
        }
    }
}
