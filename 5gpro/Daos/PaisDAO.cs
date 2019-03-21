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
            MySqlCommand Comando = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("INSERT INTO pais (idpais, nome, sigla) VALUES(@idpais, @nome, @sigla)", Conexao);
                Comando.Parameters.AddWithValue("@idpais", pais.idpais);
                Comando.Parameters.AddWithValue("@nome", pais.nome);
                Comando.Parameters.AddWithValue("@sigla", pais.sigla);

                return Comando.ExecuteNonQuery();
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
