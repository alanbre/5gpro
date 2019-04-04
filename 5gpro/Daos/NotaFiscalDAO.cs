using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace _5gpro.Daos
{
    class NotaFiscalDAO : ConexaoDAO
    {

        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT nf1.idnotafiscal + 1 AS proximoid 
                                             FROM notafiscal AS nf1 
                                             LEFT OUTER JOIN notafiscal AS nf2 ON nf1.idnotafiscal + 1 = nf2.idnotafiscal 
                                             WHERE nf2.idnotafiscal IS NULL 
                                             ORDER BY proximoid 
                                             LIMIT 1;", Conexao);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    proximoid = reader.GetString(reader.GetOrdinal("proximoid"));
                    reader.Close();
                }
                else
                {
                    //FIZ ESSE ELSE PARA CASO N TIVER NENHUM REGISTRO NA BASE... PODE DAR PROBLEMA EM ALGUM MOMENTO xD 
                    proximoid = "1";
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            return proximoid;
        }
    }
}