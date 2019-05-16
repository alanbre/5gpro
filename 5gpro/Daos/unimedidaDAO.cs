using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class UnimedidaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int Salvar(Unimedida unimedida)
        {
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("INSERT INTO unimedida (idunimedida, sigla, descricao) VALUES(@idunimedida, @sigla, @descricao)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idunimedida", unimedida.UnimedidaID);
                Connect.Comando.Parameters.AddWithValue("@sigla", unimedida.Sigla);
                Connect.Comando.Parameters.AddWithValue("@descricao", unimedida.Descricao);

                return Connect.Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                Connect.FecharConexao();
            }
        }

        public IEnumerable<Unimedida> BuscarUnimedida(string descricao)
        {
            List<Unimedida> listaunimedida = new List<Unimedida>();
            string conDescUnimedida = descricao.Length > 0 ? "AND descricao LIKE @descricao" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM unimedida 
                                             WHERE 1=1
                                             " + conDescUnimedida + @"
                                             ORDER BY idunimedida", Connect.Conexao);

                if (conDescUnimedida.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + descricao + "%"); }

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        Unimedida unimedida = new Unimedida
                        {
                            UnimedidaID = int.Parse(reader.GetString(reader.GetOrdinal("idunimedida"))),
                            Descricao = reader.GetString(reader.GetOrdinal("descricao")),
                            Sigla = reader.GetString(reader.GetOrdinal("sigla"))
                        };
                        listaunimedida.Add(unimedida);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
            return listaunimedida;
        }


        public List<Unimedida> BuscarTodasUnimedidas()
        {

            List<Unimedida> listaunimedida = new List<Unimedida>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM unimedida", Connect.Conexao);

                using (var reader = Connect.Comando.ExecuteReader())
                {

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
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
            return listaunimedida;
        }

        public Unimedida BuscaUnimedidaByID(int cod)
        {
            Unimedida unimedida = new Unimedida();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM unimedida WHERE idunimedida = @idunimedida", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idunimedida", cod);

                using (var reader = Connect.Comando.ExecuteReader())
                {

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
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
            return unimedida;
        }

    }
}