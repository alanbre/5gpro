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
    }
}
