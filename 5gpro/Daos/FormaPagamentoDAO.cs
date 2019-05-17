using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class FormaPagamentoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public IEnumerable<FormaPagamento> Busca(string nome)
        {
            List<FormaPagamento> formapagamentos = new List<FormaPagamento>();
            string conNome = nome.Length > 0 ? "AND f.nome LIKE @nome" : "";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM formapagamento f 
                            WHERE 1=1
                            " + conNome + @"
                            ORDER BY f.idformapagamento";
                if (nome.Length > 0) { sql.addParam("@nome", "%" + nome + "%"); }
                var data = sql.selectQuery();
                foreach(var d in data)
                {
                    var formapagamento = new FormaPagamento();
                    formapagamento.FormaPagamentoID = Convert.ToInt32(d["idformapagamento"]);
                    formapagamento.Nome = (string)d["nome"];
                    formapagamentos.Add(formapagamento);
                }
            }
            return formapagamentos;
        }

        public FormaPagamento BuscarByID(int Codigo)
        {

            var formapagamento = new FormaPagamento();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM formapagamento f 
                            WHERE f.idformapagamento = @idformapagamento LIMIT 1";
                sql.addParam("@idformapagamento", Codigo);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }

                formapagamento.FormaPagamentoID = Convert.ToInt32(data["idformapagamento"]);
                formapagamento.Nome = (string)data["nome"];
            }
            return formapagamento;
        }
    }
}
