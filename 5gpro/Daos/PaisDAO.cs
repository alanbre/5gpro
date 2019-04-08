using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class PaisDAO: ConexaoDAO
    {

        public int SalvarOuAtualizarPais(Pais pais)
        {
            int retorno = 0;
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand(@"INSERT INTO pais 
                          (idpais, nome, sigla) 
                          VALUES
                          (@idpais, @nome, @sigla)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome, sigla = @sigla
                         ;",
                         Conexao);

                Comando.Parameters.AddWithValue("@idpais", pais.PaisID);
                Comando.Parameters.AddWithValue("@nome", pais.Nome);
                Comando.Parameters.AddWithValue("@sigla", pais.Sigla);


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

    }
}
