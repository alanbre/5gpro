using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{

    class GrupoUsuarioDAO
    {

        public ConexaoDAO Connect { get; }
        public GrupoUsuarioDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        
        public GrupoUsuario BuscarGrupoUsuarioById(int cod)
        {

            GrupoUsuario grupousuario = new GrupoUsuario();
            PermissaoDAO permissaoDAO = new PermissaoDAO(Connect);

            try
            {

                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand("SELECT * FROM grupo_usuario WHERE idgrupousuario = @idgrupousuario", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idgrupousuario", cod);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupousuario = new GrupoUsuario
                    {
                        GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                    };

                    reader.Close();
                }
                else
                {
                    grupousuario = null;
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
            return grupousuario;
        }

        public IEnumerable<GrupoUsuario> BuscarGrupoUsuario(string nome)
        {
            List<GrupoUsuario> gruposusuarios = new List<GrupoUsuario>();
            string conNomeGrupoUsuario = nome.Length > 0 ? "AND nome LIKE @nome" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM grupo_usuario 
                                             WHERE 1=1
                                             " + conNomeGrupoUsuario + @"
                                             ORDER BY idgrupousuario", Connect.Conexao);

                if (conNomeGrupoUsuario.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {

                    GrupoUsuario grupousuario = new GrupoUsuario
                    {
                        GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };
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
                Connect.FecharConexao();
            }
            return gruposusuarios;
        }


        public List<GrupoUsuario> BuscarTodosGrupoUsuarios()
        {
            PermissaoDAO permissaoDAO = new PermissaoDAO(Connect);
            List<GrupoUsuario> listagrupousuario = new List<GrupoUsuario>();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM grupo_usuario", Connect.Conexao);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    GrupoUsuario grupousuario = new GrupoUsuario
                    {
                        GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                    };
                    listagrupousuario.Add(grupousuario);

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
            return listagrupousuario;
        }

        public int SalvarOuAtualizarGrupoUsuario(GrupoUsuario grupousuario, List<Permissao> listapermissoes)
        {
            PermissaoDAO permissaoDAO = new PermissaoDAO(new ConexaoDAO());
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;

                Connect.Comando.CommandText = @"INSERT INTO grupo_usuario 
                          (idgrupousuario, nome) 
                          VALUES
                          (@idusuario, @nome)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome
                         ";

                Connect.Comando.Parameters.AddWithValue("@idusuario", grupousuario.GrupoUsuarioID);
                Connect.Comando.Parameters.AddWithValue("@nome", grupousuario.Nome);

                retorno = Connect.Comando.ExecuteNonQuery();

                if (retorno > 0)
                {
                    fmCadastroGrupoUsuario.PermissoesStruct todaspermissoes = new fmCadastroGrupoUsuario.PermissoesStruct();
                    todaspermissoes = permissaoDAO.BuscaTodasPermissoes();
                    

                    Connect.Comando.CommandText = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                            VALUES
                                            (@idgrupousuario, @idpermissao, @nivel)
                                            ON DUPLICATE KEY UPDATE
                                             nivel = @nivel
                                             ";

                    //FAZ TODAS AS RELAÇÕES COM NIVEL 0
                    foreach (Permissao p in todaspermissoes.Todas)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@idgrupousuario", grupousuario.GrupoUsuarioID);
                        Connect.Comando.Parameters.AddWithValue("@idpermissao", p.PermissaoId);
                        Connect.Comando.Parameters.AddWithValue("@nivel", 0);
                        Connect.Comando.ExecuteNonQuery();
                    }

                    //ALTERA APENAS OS NIVEIS ENVIADOS
                    foreach (Permissao p in listapermissoes)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@idgrupousuario", grupousuario.GrupoUsuarioID);
                        Connect.Comando.Parameters.AddWithValue("@idpermissao", p.PermissaoId);
                        Connect.Comando.Parameters.AddWithValue("@nivel", p.Nivel);
                        Connect.Comando.ExecuteNonQuery();
                    }

                }
                Connect.tr.Commit();
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

        public GrupoUsuario BuscarProximoGrupoUsuario(string codAtual)
        {
            GrupoUsuario grupousuario = new GrupoUsuario();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM grupo_usuario WHERE idgrupousuario = (SELECT min(idgrupousuario) FROM grupo_usuario WHERE idgrupousuario > @idgrupousuario)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idgrupousuario", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupousuario = new GrupoUsuario
                    {
                        GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };
                    reader.Close();
                }
                else
                {
                    grupousuario = null;
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

            return grupousuario;
        }

        public GrupoUsuario BuscarGrupoUsuarioAnterior(string codAtual)
        {
            GrupoUsuario grupousuario = new GrupoUsuario();
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM grupo_usuario WHERE idgrupousuario = (SELECT max(idgrupousuario) FROM grupo_usuario WHERE idgrupousuario < @idgrupousuario)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idgrupousuario", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupousuario = new GrupoUsuario
                    {
                        GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                    };
                    reader.Close();
                }
                else
                {
                    grupousuario = null;
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

            return grupousuario;
        }

        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g1.idgrupousuario + 1 AS proximoid
                                             FROM grupo_usuario AS g1
                                             LEFT OUTER JOIN grupo_usuario AS g2 ON g1.idgrupousuario + 1 = g2.idgrupousuario
                                             WHERE g2.idgrupousuario IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Connect.Conexao);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    proximoid = reader.GetString(reader.GetOrdinal("proximoid"));
                    reader.Close();
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

        public List<int> BuscarIDGrupoUsuariosNpraN()
        {
            List<int> idgrupousuariosNpraN = new List<int>();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT DISTINCT p.idgrupousuario 
                                             FROM permissao_has_grupo_usuario as p", Connect.Conexao);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    int a = reader.GetInt32(reader.GetOrdinal("idgrupousuario"));

                    idgrupousuariosNpraN.Add(a);
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

            return idgrupousuariosNpraN;
        }

    }
}
