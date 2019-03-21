using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace _5gpro.Funcoes
{
    class FuncoesBanco : Daos.ConexaoDAO
    {
        MySqlCommand Comando = null;

        public int ExecutaUpdate(string table, IDictionary<string, string> dados, IDictionary<string, List<string>> where)
        {
            AbrirConexao();

            string sql = "UPDATE " + table + " SET";
            //UPDATE configuracao SET valor = @valor WHERE variavel = @versaodb
            int lengthDados = dados.Count;
            foreach (string key in dados.Keys)
            {
                sql += " " + key + " = @" + key + "s";
                if (lengthDados == dados.Count && lengthDados > 1)
                {
                    sql += ",";
                    lengthDados -= 1;
                }
            }
            int lengthWhere = where.Count;

            if (lengthWhere > 0)
            {
                sql += " WHERE ";
                foreach (string key in where.Keys)
                {
                    sql += " " + key + " " + where[key][0] + " @" + key + "w";
                    if (lengthWhere == dados.Count && lengthWhere > 1)
                    {
                        sql += " AND";
                        lengthWhere -= 1;
                    }
                }
            }
            Comando = new MySqlCommand(sql, Conexao);

            foreach (string key in dados.Keys)
            {
                Comando.Parameters.AddWithValue("@" + key + "s", dados[key]);
            }
            foreach (string key in where.Keys)
            {
                Comando.Parameters.AddWithValue("@" + key + "w", where[key][1]);
            }

            int retorno = Comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
