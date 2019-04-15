using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

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
                Comando.Parameters.AddWithValue("@idunimedida", unimedida.UnimedidaID);
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
            
            List<Unimedida> listaunimedida = new List<Unimedida>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM unimedida", Conexao);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Unimedida unimedida = new Unimedida
                    {
                        UnimedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida")),
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

        public Unimedida BuscaUnimedidaByCod(int cod)
        {
            Unimedida unimedida = new Unimedida();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM unimedida WHERE idunimedida = @idunimedida", Conexao);
                Comando.Parameters.AddWithValue("@idunimedida", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    unimedida = new Unimedida
                    {
                        UnimedidaID = reader.GetInt32(reader.GetOrdinal("idunimedida")),
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