using _5gpro.Entities;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class CidadeDAO
    {
        public Cidade BuscaByID(int cod)
        {
            var cidade = new Cidade();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "SELECT * FROM cidade WHERE idcidade = @idcidade LIMIT 1";
                sql.addParam("@idcidade", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                cidade.CidadeID = Convert.ToInt32(data["idcidade"]);
                cidade.Nome = (string)data["nome"];
            }
            return cidade;
        }
        public List<Cidade> Busca(int codEstado, string nomeCidade)
        {
            List<Cidade> cidades = new List<Cidade>();
            string conCodEstado = codEstado > 0 ? "AND e.idestado = @idestado" : "";
            string conNomeCidade = nomeCidade.Length > 0 ? "AND c.nome LIKE @nomecidade" : "";

            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT c.idcidade, c.nome AS nomecidade, e.idestado, e.nome AS nomeestado, e.uf
                                             FROM cidade c INNER JOIN estado e 
                                             ON c.idestado = e.idestado
                                             WHERE 1=1
                                             " + conCodEstado + @"
                                             " + conNomeCidade + @"
                                             ORDER BY c.idcidade";
                if (codEstado > 0) { sql.addParam("@idestado", codEstado); }
                if (nomeCidade.Length > 0) { sql.addParam("@nomecidade", "%" + nomeCidade + "%"); }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var estado = new Estado();
                    estado.EstadoID = Convert.ToInt32(d["idestado"]);
                    estado.Nome = (string)d["nomeestado"];
                    estado.Uf = (string)d["uf"];


                    var cidade = new Cidade();
                    cidade.CidadeID = Convert.ToInt32(d["idcidade"]);
                    cidade.Nome = (string)d["nomecidade"];
                    cidade.Estado = estado;
                    cidades.Add(cidade);
                }
            }
            return cidades;
        }
    }
}


