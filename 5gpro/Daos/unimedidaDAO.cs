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
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("INSERT INTO unimedida (idunimedida, sigla, descricao) VALUES(@idunimedida, @sigla, @descricao)", Conexao);
                Comando.Parameters.AddWithValue("@idunimedida", unimedida.idunimedida);
                Comando.Parameters.AddWithValue("@sigla", unimedida.sigla);
                Comando.Parameters.AddWithValue("@descricao", unimedida.descricao);

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
