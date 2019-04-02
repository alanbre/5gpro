using _5gpro.Bll;
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

    class GrupoUsuarioDAO : ConexaoDAO
    {
        public PermissaoBLL permissaoBLL = new PermissaoBLL();

        public GrupoUsuario BuscarGrupoUsuarioById(string cod)
        {
            GrupoUsuario grupousuario = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM grupo_usuario WHERE idgrupousuario = @idgrupousuario", Conexao);
                Comando.Parameters.AddWithValue("@idgrupousuario", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupousuario = new GrupoUsuario();
                    grupousuario.GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario")));
                    grupousuario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    grupousuario.Permissoes = permissaoBLL.BuscaPermissoesGrupo(reader.GetString(reader.GetOrdinal("idgrupousuario"))).Todas;
                  
                    reader.Close();
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
            return grupousuario;
        }

        public List<GrupoUsuario> BuscarGrupoUsuario(string nome)
        {
            List<GrupoUsuario> gruposusuarios = new List<GrupoUsuario>();
            string conNomeGrupoUsuario = nome.Length > 0 ? "AND nome LIKE @nome" : "";

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT *
                                             FROM grupo_usuario 
                                             WHERE 1=1
                                             " + conNomeGrupoUsuario + @"
                                             ORDER BY idgrupousuario", Conexao);

                if (conNomeGrupoUsuario.Length > 0) { Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }


                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {

                    GrupoUsuario grupousuario = new GrupoUsuario();
                    grupousuario.GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario")));
                    grupousuario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    gruposusuarios.Add(grupousuario);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }
            return gruposusuarios;
        }

        public List<GrupoUsuario> BuscarTodosGrupoUsuarios()
        {

            List<GrupoUsuario> listagrupousuario = new List<GrupoUsuario>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM grupo_usuario", Conexao);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    GrupoUsuario grupousuario = new GrupoUsuario();
                    grupousuario.GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario")));
                    grupousuario.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    listagrupousuario.Add(grupousuario);

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
            return listagrupousuario;
        }

        public int SalvarOuAtualizarGrupoUsuario(GrupoUsuario grupousuario)
        {

            int retorno = 0;
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand(@"INSERT INTO grupo_usuario 
                          (idgrupousuario, nome) 
                          VALUES
                          (@idusuario, @nome)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome
                         ;",
                         Conexao);

                Comando.Parameters.AddWithValue("@idusuario", grupousuario.GrupoUsuarioID);
                Comando.Parameters.AddWithValue("@nome", grupousuario.Nome);

                retorno = Comando.ExecuteNonQuery();

                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                FecharConexao();
            }
            return retorno;
        }

    }
}
