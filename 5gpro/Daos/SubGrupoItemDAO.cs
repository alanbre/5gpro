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
    class SubGrupoItemDAO
    {

        public ConexaoDAO Connect { get; }
        public SubGrupoItemDAO(ConexaoDAO c)
        {
            Connect = c;
        }


        public int SalvarOuAtualizar(SubGrupoItem subgrupoitem)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"INSERT INTO subgrupoitem 
                          (idsubgrupoitem, nome, idgrupoitem) 
                          VALUES
                          (@idsubgrupoitem, @nome, @idgrupoitem)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome, idgrupoitem = @idgrupoitem
                         ;",
                         Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idsubgrupoitem", subgrupoitem.SubGrupoItemID);
                Connect.Comando.Parameters.AddWithValue("@nome", subgrupoitem.Nome);
                Connect.Comando.Parameters.AddWithValue("@idgrupoitem", subgrupoitem.GrupoItem.GrupoItemID);


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

        public IEnumerable<SubGrupoItem> BuscaTodos(string nome, int grupoitemID)
        {
            List<SubGrupoItem> listasubgrupoitem = new List<SubGrupoItem>();
            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = null;

            string conNome = nome.Length > 0 ? "AND g.nome LIKE @nome" : "";
            string conGrupoItem = "AND g.idgrupoitem = @idgrupoitem";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM subgrupoitem g 
                                             WHERE 1=1
                                             " + conGrupoItem + @"
                                             " + conNome + @"
                                             ORDER BY g.nome;", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupoitem", grupoitemID);
                if (nome.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("idgrupoitem"))
                    };

                    subgrupoitem = new SubGrupoItem
                    {
                        SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("idsubgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        GrupoItem = grupoitem
                    };

                    listasubgrupoitem.Add(subgrupoitem);
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
            return listasubgrupoitem;
        }

        public SubGrupoItem BuscarByID(int Codigo, int grupoitemID )
        {

            SubGrupoItem subgrupoitem = null;
            GrupoItem grupoitem = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM subgrupoitem g 
                                             WHERE g.idsubgrupoitem = @idsubgrupoitem
                                             AND g.idgrupoitem = @idgrupoitem
                                             ", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idsubgrupoitem", Codigo);
                Connect.Comando.Parameters.AddWithValue("@idgrupoitem", grupoitemID);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("idgrupoitem"))
                    };

                    subgrupoitem = new SubGrupoItem
                    {
                        SubGrupoItemID = reader.GetInt32(reader.GetOrdinal("idsubgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        GrupoItem = grupoitem
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

            return subgrupoitem;
        }


        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT i1.idsubgrupoitem + 1 AS proximoid
                                             FROM subgrupoitem AS i1
                                             LEFT OUTER JOIN subgrupoitem AS i2 ON i1.idsubgrupoitem + 1 = i2.idsubgrupoitem
                                             WHERE i2.idsubgrupoitem IS NULL
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

        public int Remover(string idsub)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"DELETE FROM subgrupoitem WHERE idsubgrupoitem = @idsubgrupoitem", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idsubgrupoitem", idsub);

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

    }
}
