using _5gpro.Entities;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class EstadoDAO
    {
        public Estado BuscaByID(int cod)
        {
            Estado estado = new Estado();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "SELECT * FROM estado WHERE idestado = @idestado LIMIT 1";
                sql.addParam("@idestado", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                estado.EstadoID = Convert.ToInt32(data["idestado"]);
                estado.Nome = (string)data["nome"];
            }
            return estado;
        }

        public List<Estado> BuscaEstadoByNome(string nome)
        {
            List<Estado> estados = new List<Estado>();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "SELECT * FROM estado WHERE nome LIKE @nome";
                sql.addParam("@nome", "%" + nome + "%");
                var data = sql.selectQuery();
                foreach(var d in data)
                {
                    var estado = new Estado();
                    estado.EstadoID = Convert.ToInt32(d["idestado"]);
                    estado.Nome = (string)d["nome"];
                    estado.Uf = (string)d["uf"];
                    estados.Add(estado);
                }
            }
            return estados;
        }
    }
}
