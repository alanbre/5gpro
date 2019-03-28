using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace _5gpro.Funcoes
{
    class FuncoesBanco : Daos.ConexaoDAO
    {
        public int ExecutaUpdate(string tabela, IDictionary<string, string> dados, IDictionary<string, List<string>> where)
        {
            //Exemplo de uso
            //FuncoesBanco funcoesBanco = new FuncoesBanco();
            //IDictionary<string, string> dados = new Dictionary<string, string>();
            //dados.Add("valor", "3");

            //IDictionary<string, List<string>> where = new Dictionary<string, List<string>>();
            //where.Add("variavel", new List<string> { "=", "versaodb" });
            //funcoesBanco.ExecutaUpdate("configuracoes", dados, where);
            int retorno = 0;
            string sql = "UPDATE " + tabela + " SET";
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

            try
            {
                AbrirConexao();


                Comando = new MySqlCommand(sql, Conexao);

                foreach (string key in dados.Keys)
                {
                    Comando.Parameters.AddWithValue("@" + key + "s", dados[key]);
                }
                foreach (string key in where.Keys)
                {
                    Comando.Parameters.AddWithValue("@" + key + "w", where[key][1]);
                }

                retorno = Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                FecharConexao();
            }
            return retorno;
        }

        public int ExecutaInsert(string tabela)
        {
            return 1;
        }
    }
}
