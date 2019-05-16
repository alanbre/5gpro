using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _5gpro.Daos
{
    class GrupoPessoaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int SalvarOuAtualizar(GrupoPessoa grupopessoa)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"INSERT INTO grupopessoa 
                          (idgrupopessoa, nome) 
                          VALUES
                          (@idgrupopessoa, @nome)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome
                         ;",
                         Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupopessoa", grupopessoa.GrupoPessoaID);
                Connect.Comando.Parameters.AddWithValue("@nome", grupopessoa.Nome);



                retorno = Connect.Comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                Connect.FecharConexao();
            }
            return retorno;
        }


        public IEnumerable<GrupoPessoa> BuscaTodos(string nome)
        {
            List<GrupoPessoa> listagrupopessoa = new List<GrupoPessoa>();
            List<SubGrupoPessoa> listasubgrupopessoa = new List<SubGrupoPessoa>();
            GrupoPessoa grupopessoa = null;
            SubGrupoPessoa subgrupopessoa = null;

            string conNome = nome.Length > 0 ? "AND g.nome LIKE @nome" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa AS grupopessoaID, g.nome AS nomegrupopessoa,
                                                   s.idsubgrupopessoa AS subgrupopessoaID, s.nome AS subgrupopessoanome,
                                                   s.idgrupopessoa AS idgrupopessoasub 
                                                   FROM grupopessoa g 
                                                   LEFT JOIN subgrupopessoa s 
                                                   ON g.idgrupopessoa = s.idgrupopessoa 
                                                   WHERE 1=1
                                                   " + conNome + @"
                                                   ORDER BY g.nome;", Connect.Conexao);


                if (nome.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("grupopessoaID")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa"))
                        };

                        if (!reader.IsDBNull(reader.GetOrdinal("subgrupopessoaID")))
                        {
                            subgrupopessoa = new SubGrupoPessoa
                            {
                                SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("subgrupopessoaID")),
                                Nome = reader.GetString(reader.GetOrdinal("subgrupopessoanome")),
                                GrupoPessoa = grupopessoa
                            };
                            listasubgrupopessoa.Add(subgrupopessoa);
                        }

                        //O Any funciona como o IEnumerable
                        //Para não adicionar repetidos
                        if (!listagrupopessoa.Any(l => l.GrupoPessoaID == reader.GetInt32(reader.GetOrdinal("grupopessoaID"))))
                        {
                            listagrupopessoa.Add(grupopessoa);
                        }
                    }
                }

                foreach (GrupoPessoa g in listagrupopessoa)
                {
                    g.SubGrupoPessoas = new List<SubGrupoPessoa>();
                    foreach (SubGrupoPessoa s in listasubgrupopessoa)
                    {
                        if (s.GrupoPessoa.GrupoPessoaID == g.GrupoPessoaID)
                        {
                            g.SubGrupoPessoas.Add(s);
                        }
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
            return listagrupopessoa;
        }


        public GrupoPessoa BuscarByID(int Codigo)
        {
            GrupoPessoa grupopessoa = null;
            SubGrupoPessoa subgrupopessoa = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa AS grupopessoaID, g.nome AS nomegrupopessoa,
                                                   s.idsubgrupopessoa AS subgrupopessoaID, s.nome AS subgrupopessoanome,
                                                   s.idgrupopessoa AS idgrupopessoasub 
                                                   FROM grupopessoa g 
                                                   LEFT JOIN subgrupopessoa s 
                                                   ON g.idgrupopessoa = s.idgrupopessoa 
                                                   WHERE g.idgrupopessoa = @idgrupopessoa"
                                                   , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupopessoa", Codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("grupopessoaID")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa")),
                            SubGrupoPessoas = new List<SubGrupoPessoa>()
                        };

                        if (!reader.IsDBNull(reader.GetOrdinal("subgrupopessoaID")))
                        {
                            subgrupopessoa = new SubGrupoPessoa
                            {
                                SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("subgrupopessoaID")),
                                Nome = reader.GetString(reader.GetOrdinal("subgrupopessoanome")),
                                GrupoPessoa = grupopessoa
                            };
                            grupopessoa.SubGrupoPessoas.Add(subgrupopessoa);
                        }
                    }
                    else
                    {
                        grupopessoa = null;
                    }

                    while (reader.Read())
                    {
                        if (reader.GetString(reader.GetOrdinal("subgrupopessoaID")) != null)
                        {
                            subgrupopessoa = new SubGrupoPessoa
                            {
                                SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("subgrupopessoaID")),
                                Nome = reader.GetString(reader.GetOrdinal("subgrupopessoanome")),
                                GrupoPessoa = grupopessoa
                            };

                            grupopessoa.SubGrupoPessoas.Add(subgrupopessoa);
                        }
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

            return grupopessoa;
        }


        public GrupoPessoa BuscarProximo(string codAtual)
        {
            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = new GrupoPessoa();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa AS grupopessoaID, g.nome AS nomegrupopessoa,
                                                   s.idsubgrupopessoa AS subgrupopessoaID, s.nome AS subgrupopessoanome,
                                                   s.idgrupopessoa AS idgrupopessoasub 
                                                   FROM grupopessoa g 
                                                   LEFT JOIN subgrupopessoa s 
                                                   ON g.idgrupopessoa = s.idgrupopessoa 
                                                   WHERE g.idgrupopessoa = (SELECT MIN(idgrupopessoa) 
                                                   FROM grupopessoa WHERE idgrupopessoa > @idgrupopessoa)"
                                                   , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupopessoa", codAtual);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("grupopessoaID")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa")),
                            SubGrupoPessoas = new List<SubGrupoPessoa>()
                        };

                        if (!reader.IsDBNull(reader.GetOrdinal("subgrupopessoaID")))
                        {
                            subgrupopessoa = new SubGrupoPessoa
                            {
                                SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("subgrupopessoaID")),
                                Nome = reader.GetString(reader.GetOrdinal("subgrupopessoanome")),
                                GrupoPessoa = grupopessoa
                            };
                            grupopessoa.SubGrupoPessoas.Add(subgrupopessoa);
                        }
                    }
                    else
                    {
                        grupopessoa = null;
                    }

                    while (reader.Read())
                    {
                        if (reader.GetString(reader.GetOrdinal("subgrupopessoaID")) != null)
                        {
                            subgrupopessoa = new SubGrupoPessoa
                            {
                                SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("subgrupopessoaID")),
                                Nome = reader.GetString(reader.GetOrdinal("subgrupopessoanome")),
                                GrupoPessoa = grupopessoa
                            };

                            grupopessoa.SubGrupoPessoas.Add(subgrupopessoa);
                        }
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
            return grupopessoa;
        }

        public GrupoPessoa BuscarAnterior(string codAtual)
        {
            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = new GrupoPessoa();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa AS grupopessoaID, g.nome AS nomegrupopessoa,
                                                   s.idsubgrupopessoa AS subgrupopessoaID, s.nome AS subgrupopessoanome,
                                                   s.idgrupopessoa AS idgrupopessoasub 
                                                   FROM grupopessoa g 
                                                   LEFT JOIN subgrupopessoa s 
                                                   ON g.idgrupopessoa = s.idgrupopessoa 
                                                   WHERE g.idgrupopessoa = (SELECT MAX(idgrupopessoa) 
                                                   FROM grupopessoa WHERE idgrupopessoa < @idgrupopessoa)"
                                                   , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupopessoa", codAtual);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("grupopessoaID")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa")),
                            SubGrupoPessoas = new List<SubGrupoPessoa>()
                        };

                        if (!reader.IsDBNull(reader.GetOrdinal("subgrupopessoaID")))
                        {
                            subgrupopessoa = new SubGrupoPessoa
                            {
                                SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("subgrupopessoaID")),
                                Nome = reader.GetString(reader.GetOrdinal("subgrupopessoanome")),
                                GrupoPessoa = grupopessoa
                            };
                            grupopessoa.SubGrupoPessoas.Add(subgrupopessoa);
                        }
                    }
                    else
                    {
                        grupopessoa = null;
                    }

                    while (reader.Read())
                    {
                        if (reader.GetString(reader.GetOrdinal("subgrupopessoaID")) != null)
                        {
                            subgrupopessoa = new SubGrupoPessoa
                            {
                                SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("subgrupopessoaID")),
                                Nome = reader.GetString(reader.GetOrdinal("subgrupopessoanome")),
                                GrupoPessoa = grupopessoa
                            };

                            grupopessoa.SubGrupoPessoas.Add(subgrupopessoa);
                        }
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
            return grupopessoa;
        }

        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT i1.idgrupopessoa + 1 AS proximoid
                                             FROM grupopessoa AS i1
                                             LEFT OUTER JOIN grupopessoa AS i2 ON i1.idgrupopessoa + 1 = i2.idgrupopessoa
                                             WHERE i2.idgrupopessoa IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Connect.Conexao);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        proximoid = reader.GetInt32(reader.GetOrdinal("proximoid"));
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
            return proximoid;
        }
    }
}
