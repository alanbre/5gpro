using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace _5gpro.Funcoes
{
    class FuncoesBanco : Daos.ConexaoDAO
    {
        MySqlCommand Comando = null;

        public int ExecutaUpdate(string table, IDictionary<string, string> dados, IDictionary<string, string> where)
        {
            AbrirConexao();

            string sql = "UPDATE " + table + " SET";
            //UPDATE configuracao SET valor = @valor WHERE variavel = @versaodb
            int length = dados.Count;
            foreach (string key in dados.Keys)
            {
                sql += " " + key + " = @" + key;
                if(length == dados.Count)
                {

                }
            }
            System.Console.WriteLine(sql);
            //Comando = new MySqlCommand(sql, Conexao);


            return 1;
        }
    }
}
