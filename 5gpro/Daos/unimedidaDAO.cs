using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class UnimedidaDAO : ConexaoDAO
    {

        public int Salvar(Unimedida unimedida)
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("INSERT INTO unimedida (idunimedida, sigla, descricao) VALUES(@idunimedida, @sigla, @descricao)", Conexao);
                Comando.Parameters.AddWithValue("@idunimedida", unimedida.Codigo);
                Comando.Parameters.AddWithValue("@sigla", unimedida.Sigla);
                Comando.Parameters.AddWithValue("@descricao", unimedida.Descricao);

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

        public List<Unimedida> BuscarTodasUnimedidas()
        {
            Unimedida unimedida = new Unimedida();
            List<Unimedida> listaunimedida = new List<Unimedida>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM unimedida", Conexao);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    unimedida.Codigo = reader.GetInt32(reader.GetOrdinal("idunimedida"));
                    unimedida.Sigla = reader.GetString(reader.GetOrdinal("sigla"));
                    unimedida.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
                    listaunimedida.Add(unimedida);

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
            return listaunimedida;
        }
        
    }
}