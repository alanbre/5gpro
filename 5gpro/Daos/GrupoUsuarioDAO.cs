using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{

    class GrupoUsuarioDAO : ConexaoDAO
    {
        private readonly PermissaoBLL permissaoBLL = new PermissaoBLL();

        public GrupoUsuario BuscarGrupoUsuarioById(string cod)
        {
            GrupoUsuario grupousuario = new GrupoUsuario(); ;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM grupo_usuario WHERE idgrupousuario = @idgrupousuario", Conexao);
                Comando.Parameters.AddWithValue("@idgrupousuario", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    grupousuario = new GrupoUsuario
                    {
                        GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Permissoes = permissaoBLL.BuscaPermissoesGrupo(reader.GetString(reader.GetOrdinal("idgrupousuario"))).Todas
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
                    GrupoUsuario grupousuario = new GrupoUsuario
                    {
                        GrupoUsuarioID = int.Parse(reader.GetString(reader.GetOrdinal("idgrupousuario"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome"))
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
                FecharConexao();
            }
            return listagrupousuario;
        }

        public int SalvarOuAtualizarGrupoUsuario(GrupoUsuario grupousuario, List<Permissao>listapermissoes)
        {

            int retorno = 0;
            try
            {
                AbrirConexao();
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;

                Comando.CommandText = @"INSERT INTO grupo_usuario 
                          (idgrupousuario, nome) 
                          VALUES
                          (@idusuario, @nome)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome
                         ";

                Comando.Parameters.AddWithValue("@idusuario", grupousuario.GrupoUsuarioID);
                Comando.Parameters.AddWithValue("@nome", grupousuario.Nome);

                retorno = Comando.ExecuteNonQuery();

                if (retorno > 0)
                {
                    fmCadastroGrupoUsuario.PermissoesStruct todaspermissoes = new fmCadastroGrupoUsuario.PermissoesStruct();
                    todaspermissoes = permissaoBLL.BuscaTodasPermissoes();

                    Comando.CommandText = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                            VALUES
                                            (@idgrupousuario, @idpermissao, @nivel)
                                            ON DUPLICATE KEY UPDATE
                                             nivel = @nivel
                                             ";

                    //FAZ TODAS AS RELAÇÕES COM NIVEL 0
                    foreach (Permissao p in todaspermissoes.Todas)
                    {
                        Comando.Parameters.Clear();
                        Comando.Parameters.AddWithValue("@idgrupousuario", grupousuario.GrupoUsuarioID);
                        Comando.Parameters.AddWithValue("@idpermissao", p.PermissaoId);
                        Comando.Parameters.AddWithValue("@nivel", 0);
                        Comando.ExecuteNonQuery();
                    }

                    //ALTERA APENAS OS NIVEIS ENVIADOS
                    foreach (Permissao p in listapermissoes)
                    {
                        Comando.Parameters.Clear();
                        Comando.Parameters.AddWithValue("@idgrupousuario", grupousuario.GrupoUsuarioID);
                        Comando.Parameters.AddWithValue("@idpermissao", p.PermissaoId);
                        Comando.Parameters.AddWithValue("@nivel", p.Nivel);
                        Comando.ExecuteNonQuery();
                    }

                }
                tr.Commit();
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

        public GrupoUsuario BuscarProximoGrupoUsuario(string codAtual)
        {
            GrupoUsuario grupousuario = new GrupoUsuario();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM grupo_usuario WHERE idgrupousuario = (SELECT min(idgrupousuario) FROM grupo_usuario WHERE idgrupousuario > @idgrupousuario)", Conexao);
                Comando.Parameters.AddWithValue("@idgrupousuario", codAtual);

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }

            return grupousuario;
        }

        public GrupoUsuario BuscarGrupoUsuarioAnterior(string codAtual)
        {
            GrupoUsuario grupousuario = new GrupoUsuario();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM grupo_usuario WHERE idgrupousuario = (SELECT max(idgrupousuario) FROM grupo_usuario WHERE idgrupousuario < @idgrupousuario)", Conexao);
                Comando.Parameters.AddWithValue("@idgrupousuario", codAtual);

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }

            return grupousuario;
        }

        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT g1.idgrupousuario + 1 AS proximoid
                                             FROM grupo_usuario AS g1
                                             LEFT OUTER JOIN grupo_usuario AS g2 ON g1.idgrupousuario + 1 = g2.idgrupousuario
                                             WHERE g2.idgrupousuario IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Conexao);

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }

            return proximoid;
        }

        public List<int> BuscarIDGrupoUsuariosNpraN()
        {
            List<int> idgrupousuariosNpraN = new List<int>();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT DISTINCT p.idgrupousuario 
                                             FROM permissao_has_grupo_usuario as p", Conexao);

                IDataReader reader = Comando.ExecuteReader();

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
                FecharConexao();
            }

            return idgrupousuariosNpraN;
        }

    }
}
