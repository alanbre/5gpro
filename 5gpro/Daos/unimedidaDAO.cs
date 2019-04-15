using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class UnimedidaDAO : ConexaoDAO
    {

        public int Salvar(UnidadeMedida unimedida)
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("INSERT INTO unimedida (idunimedida, sigla, descricao) VALUES(@idunimedida, @sigla, @descricao)", Conexao);
                Comando.Parameters.AddWithValue("@idunimedida", unimedida.UnidadeMedidaID);
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

        public List<UnidadeMedida> BuscarTodasUnimedidas()
        {
            
            List<UnidadeMedida> listaunimedida = new List<UnidadeMedida>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM unimedida", Conexao);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    UnidadeMedida unimedida = new UnidadeMedida
                    {
                        UnidadeMedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida")),
                        Sigla = reader.GetString(reader.GetOrdinal("sigla")),
                        Descricao = reader.GetString(reader.GetOrdinal("descricao"))
                    };
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

        public UnidadeMedida BuscaUnimedidaByCod(int cod)
        {
            UnidadeMedida unimedida = new UnidadeMedida();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM unimedida WHERE idunimedida = @idunimedida", Conexao);
                Comando.Parameters.AddWithValue("@idunimedida", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    unimedida = new UnidadeMedida
                    {
                        UnidadeMedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida")),
                        Sigla = reader.GetString(reader.GetOrdinal("sigla")),
                        Descricao = reader.GetString(reader.GetOrdinal("descricao"))
                    };
                }
                else
                {
                    unimedida = null;
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
            return unimedida;
        }

    }
}