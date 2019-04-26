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
    class GrupoItemDAO
    {
        public ConexaoDAO Connect { get; }
        public GrupoItemDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        public IEnumerable<GrupoItem> BuscaTodos(string nome)
        {
            List<GrupoItem> listagrupoitem = new List<GrupoItem>();
            GrupoItem grupoitem = null;

            string conNome = nome.Length > 0 ? "AND g.nome LIKE @nome" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM grupoitem g 
                                             WHERE 1=1
                                             " + conNome + @"
                                             ORDER BY g.nome;", Connect.Conexao);


                if (nome.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("idgrupoitem")),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };

                    listagrupoitem.Add(grupoitem);
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
            return listagrupoitem;
        }


        public GrupoItem BuscarByID(int Codigo)
        {

            GrupoItem grupoitem = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM grupoitem g 
                                             WHERE g.idgrupoitem = @idgrupoitem", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupoitem", Codigo);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    grupoitem = new GrupoItem
                    {
                        GrupoItemID = reader.GetInt32(reader.GetOrdinal("idgrupoitem")),
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

            return grupoitem;
        }

    }
}
