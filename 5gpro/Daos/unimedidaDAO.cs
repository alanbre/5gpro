using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class UnimedidaDAO: ConexaoDAO
    {

        public int Salvar(Unimedida unimedida)
        {
            MySqlCommand comando = null;
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO unimedida (idunimedida, sigla, descricao) VALUES(@idunimedida, @sigla, @descricao)", conexao);
                comando.Parameters.AddWithValue("@idunimedida", unimedida.idunimedida);
                comando.Parameters.AddWithValue("@sigla", unimedida.sigla);
                comando.Parameters.AddWithValue("@descricao", unimedida.descricao);

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
