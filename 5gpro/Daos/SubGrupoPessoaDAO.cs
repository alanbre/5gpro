using _5gpro.Entities;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class SubGrupoPessoaDAO
    {
        public int SalvaOuAtualiza(SubGrupoPessoa subgrupoipessoa)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"INSERT INTO subgrupopessoa 
                            (idsubgrupopessoa, nome, idgrupopessoa) 
                            VALUES
                            (@idsubgrupopessoa, @nome, @idgrupopessoa)
                            ON DUPLICATE KEY UPDATE
                            nome = @nome, idgrupopessoa = @idgrupopessoa";
                sql.addParam("@idsubgrupopessoa", subgrupoipessoa.SubGrupoPessoaID);
                sql.addParam("@nome", subgrupoipessoa.Nome);
                sql.addParam("@idgrupopessoa", subgrupoipessoa.GrupoPessoa.GrupoPessoaID);
                retorno = sql.insertQuery();
            }
            return retorno;
        }
        public IEnumerable<SubGrupoPessoa> Busca(string nome, int grupopessoaID)
        {
            var listaSubGrupoPessoa = new List<SubGrupoPessoa>();
            string conNome = nome.Length > 0 ? "AND nome LIKE @nome" : "";
            string conGrupoPessoa = "AND idgrupopessoa = @idgrupopessoa";
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM subgrupopessoa 
                            WHERE 1=1 "
                            + conGrupoPessoa + " "
                            + conNome + " "
                            +@"ORDER BY codigo";
                sql.addParam("@idgrupopessoa", grupopessoaID);
                if (nome.Length > 0) { sql.addParam("@nome", "%" + nome + "%"); }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    listaSubGrupoPessoa.Add(LeDadosReader(d));
                }
            }
            return listaSubGrupoPessoa;
        }
        public SubGrupoPessoa BuscarByID(int Codigo, int grupopessoaID)
        {
            var subGrupoPessoa = new SubGrupoPessoa();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM subgrupopessoa 
                            WHERE codigo = @codigo
                            AND idgrupopessoa = @idgrupopessoa";
                sql.addParam("@codigo", Codigo);
                sql.addParam("@idgrupopessoa", grupopessoaID);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                subGrupoPessoa = LeDadosReader(data);
            }
            return subGrupoPessoa;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT i1.idsubgrupopessoa + 1 AS proximoid
                            FROM subgrupopessoa AS i1
                            LEFT OUTER JOIN subgrupopessoa AS i2 ON i1.idsubgrupopessoa + 1 = i2.idsubgrupopessoa
                            WHERE i2.idsubgrupopessoa IS NULL
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
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"DELETE FROM subgrupopessoa WHERE idsubgrupopessoa = @idsubgrupopessoa";
                sql.addParam("@idsubgrupopessoa", idsub);
                retorno = sql.deleteQuery();
            }
            return retorno;
        }
        private SubGrupoPessoa LeDadosReader(Dictionary<string, object> data)
        {
            var grupoPessoa = new GrupoPessoa();
            grupoPessoa.GrupoPessoaID = Convert.ToInt32(data["idgrupopessoa"]);

            var subGrupoPessoa = new SubGrupoPessoa();
            subGrupoPessoa.SubGrupoPessoaID = Convert.ToInt32(data["idsubgrupopessoa"]);
            subGrupoPessoa.Nome = (string)data["nome"];
            subGrupoPessoa.GrupoPessoa = grupoPessoa;
            subGrupoPessoa.Codigo = Convert.ToInt32(data["codigo"]);
            return subGrupoPessoa;
        }
    }
}
