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

        public int Salvar(Pais pais)
        {
            MySqlCommand comando = null;
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO pais (idpais, nome, sigla) VALUES(@idpais, @nome, @sigla)", conexao);
                comando.Parameters.AddWithValue("@idpais", pais.idpais);
                comando.Parameters.AddWithValue("@nome", pais.nome);
                comando.Parameters.AddWithValue("@sigla", pais.sigla);

                return comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
