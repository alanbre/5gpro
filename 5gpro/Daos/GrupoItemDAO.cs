using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _5gpro.Daos
{
    class GrupoItemDAO
    {
        public ConexaoDAO Connect { get; }
        public GrupoItemDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        public int SalvarOuAtualizar(GrupoItem grupoitem)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"INSERT INTO grupoitem 
                          (idgrupoitem, nome) 
                          VALUES
                          (@idgrupoitem, @nome)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome
                         ;",
                         Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupoitem", grupoitem.GrupoItemID);
                Connect.Comando.Parameters.AddWithValue("@nome", grupoitem.Nome);



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

        public IEnumerable<GrupoItem> BuscaTodos(string nome)
        {
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = null;
            List<GrupoItem> listagrupoitem = new List<GrupoItem>();
            List<SubGrupoItem> listasubgrupoitem = new List<SubGrupoItem>();

            string conNome = nome.Length > 0 ? "AND g.nome LIKE @nome" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupoitem AS grupoitemID, g.nome AS nomegrupoitem,
                                                   s.idsubgrupoitem AS subgrupoitemID, s.nome AS subgrupoitemnome,
                                                   s.idgrupoitem AS idgrupoitemsub 
                                                   FROM grupoitem g 
                                                   LEFT JOIN subgrupoitem s 
                                                   ON g.idgrupoitem = s.idgrupoitem 
                                                   WHERE 1=1
                                                   " + conNome + @"
                                                   ORDER BY g.nome;", Connect.Conexao);


                if (nome.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {

                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("grupoitemID")),
                        Nome = reader.GetString(reader.GetOrdinal("nomegrupoitem"))
                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("subgrupoitemID")))
                    {
                        subgrupoitem = new SubGrupoItem
                        {
                            SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("subgrupoitemID")),
                            Nome = reader.GetString(reader.GetOrdinal("subgrupoitemnome")),
                            GrupoItem = grupoitem
                        };
                        listasubgrupoitem.Add(subgrupoitem);
                    }

                    //O Any funciona como o IEnumerable
                    //Para não adicionar repetidos
                    if (!listagrupoitem.Any(l => l.GrupoItemID == reader.GetInt32(reader.GetOrdinal("grupoitemID"))))
                    {
                        listagrupoitem.Add(grupoitem);
                    }                 
                }
                reader.Close();

                foreach (GrupoItem g in listagrupoitem)
                {
                    g.SubGrupoItens = new List<SubGrupoItem>();
                    foreach (SubGrupoItem s in listasubgrupoitem)
                    {
                        if (s.GrupoItem.GrupoItemID == g.GrupoItemID)
                        {
                            g.SubGrupoItens.Add(s);
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
            return listagrupoitem;
        }


        public GrupoItem BuscarByID(int Codigo)
        {
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupoitem AS grupoitemID, g.nome AS nomegrupoitem,
                                                   s.idsubgrupoitem AS subgrupoitemID, s.nome AS subgrupoitemnome,
                                                   s.idgrupoitem AS idgrupoitemsub 
                                                   FROM grupoitem g 
                                                   LEFT JOIN subgrupoitem s 
                                                   ON g.idgrupoitem = s.idgrupoitem 
                                                   WHERE g.idgrupoitem = @idgrupoitem"
                                   , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupoitem", Codigo);

                IDataReader reader = Connect.Comando.ExecuteReader();
                if (reader.Read())
                {
                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("grupoitemID")),
                        Nome = reader.GetString(reader.GetOrdinal("nomegrupoitem")),
                        SubGrupoItens = new List<SubGrupoItem>()
                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("subgrupoitemID")))
                    {
                        subgrupoitem = new SubGrupoItem
                        {
                            SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("subgrupoitemID")),
                            Nome = reader.GetString(reader.GetOrdinal("subgrupoitemnome")),
                            GrupoItem = grupoitem
                        };
                        grupoitem.SubGrupoItens.Add(subgrupoitem);
                    }
                }
                else
                {
                    grupoitem = null;
                }

                while (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("subgrupoitemID")) != null)
                    {
                        subgrupoitem = new SubGrupoItem
                        {
                            SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("subgrupoitemID")),
                            Nome = reader.GetString(reader.GetOrdinal("subgrupoitemnome")),
                            GrupoItem = grupoitem
                        };

                        grupoitem.SubGrupoItens.Add(subgrupoitem);
                    }
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

            return grupoitem;
        }

        public GrupoItem BuscarProximo(string codAtual)
        {
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = new GrupoItem();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupoitem AS grupoitemID, g.nome AS nomegrupoitem,
                                                   s.idsubgrupoitem AS subgrupoitemID, s.nome AS subgrupoitemnome,
                                                   s.idgrupoitem AS idgrupoitemsub 
                                                   FROM grupoitem g 
                                                   LEFT JOIN subgrupoitem s 
                                                   ON g.idgrupoitem = s.idgrupoitem 
                                                   WHERE g.idgrupoitem = (SELECT MIN(idgrupoitem) 
                                                   FROM grupoitem WHERE idgrupoitem > @idgrupoitem)"
                                                   , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupoitem", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("grupoitemID")),
                        Nome = reader.GetString(reader.GetOrdinal("nomegrupoitem")),
                        SubGrupoItens = new List<SubGrupoItem>()
                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("subgrupoitemID")))
                    {
                        subgrupoitem = new SubGrupoItem
                        {
                            SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("subgrupoitemID")),
                            Nome = reader.GetString(reader.GetOrdinal("subgrupoitemnome")),
                            GrupoItem = grupoitem
                        };
                        grupoitem.SubGrupoItens.Add(subgrupoitem);
                    }
                }
                else
                {
                    grupoitem = null;
                }

                while (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("subgrupoitemID")) != null)
                    {
                        subgrupoitem = new SubGrupoItem
                        {
                            SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("subgrupoitemID")),
                            Nome = reader.GetString(reader.GetOrdinal("subgrupoitemnome")),
                            GrupoItem = grupoitem
                        };

                        grupoitem.SubGrupoItens.Add(subgrupoitem);
                    }
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
            return grupoitem;
        }

        public GrupoItem BuscarAnterior(string codAtual)
        {
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = new GrupoItem();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupoitem AS grupoitemID, g.nome AS nomegrupoitem,
                                                   s.idsubgrupoitem AS subgrupoitemID, s.nome AS subgrupoitemnome,
                                                   s.idgrupoitem AS idgrupoitemsub 
                                                   FROM grupoitem g 
                                                   LEFT JOIN subgrupoitem s 
                                                   ON g.idgrupoitem = s.idgrupoitem 
                                                   WHERE g.idgrupoitem = (SELECT MAX(idgrupoitem) 
                                                   FROM grupoitem WHERE idgrupoitem < @idgrupoitem)"
                                                   , Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupoitem", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("grupoitemID")),
                        Nome = reader.GetString(reader.GetOrdinal("nomegrupoitem")),
                        SubGrupoItens = new List<SubGrupoItem>()
                    };

                    if (!reader.IsDBNull(reader.GetOrdinal("subgrupoitemID")))
                    {
                        subgrupoitem = new SubGrupoItem
                        {
                            SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("subgrupoitemID")),
                            Nome = reader.GetString(reader.GetOrdinal("subgrupoitemnome")),
                            GrupoItem = grupoitem
                        };
                        grupoitem.SubGrupoItens.Add(subgrupoitem);
                    }
                }
                else
                {
                    grupoitem = null;
                }

                while (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("subgrupoitemID")) != null)
                    {
                        subgrupoitem = new SubGrupoItem
                        {
                            SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("subgrupoitemID")),
                            Nome = reader.GetString(reader.GetOrdinal("subgrupoitemnome")),
                            GrupoItem = grupoitem
                        };

                        grupoitem.SubGrupoItens.Add(subgrupoitem);
                    }
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
            return grupoitem;
        }

        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT i1.idgrupoitem + 1 AS proximoid
                                             FROM grupoitem AS i1
                                             LEFT OUTER JOIN grupoitem AS i2 ON i1.idgrupoitem + 1 = i2.idgrupoitem
                                             WHERE i2.idgrupoitem IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Connect.Conexao);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    proximoid = reader.GetString(reader.GetOrdinal("proximoid"));
                    reader.Close();
                }
                else
                {
                    proximoid = "1";
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
