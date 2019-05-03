using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class GrupoPessoaDAO
    {
        public ConexaoDAO Connect { get; }
        public GrupoPessoaDAO(ConexaoDAO c)
        {
            Connect = c;
        }


        public IEnumerable<GrupoPessoa> BuscaTodos(string nome)
        {
            List<GrupoPessoa> listagrupopessoa = new List<GrupoPessoa>();
            GrupoPessoa grupopessoa = null;

            string conNome = nome.Length > 0 ? "AND g.nome LIKE @nome" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM grupopessoa g 
                                             WHERE 1=1
                                             " + conNome + @"
                                             ORDER BY g.nome;", Connect.Conexao);


                if (nome.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    grupopessoa = new GrupoPessoa
                    {
                        GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };

                    listagrupopessoa.Add(grupopessoa);
                }

                reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
            return listagrupopessoa;
        }


        public GrupoPessoa BuscarByID(int Codigo)
        {

            GrupoPessoa grupopessoa = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM grupopessoa g 
                                             WHERE g.idgrupopessoa = @idgrupopessoa", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupopessoa", Codigo);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    grupopessoa = new GrupoPessoa
                    {
                        GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }

            return grupopessoa;
        }

    }
}
