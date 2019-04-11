using _5gpro.Entities;
using _5gpro.Bll;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5gpro.Forms;

namespace _5gpro.Daos
{
    class PermissaoDAO : ConexaoDAO
    {

        //TENTANDO MELHORAR
        public fmCadastroGrupoUsuario.PermissoesStruct BuscaPermissoesByIdGrupo(string cod)
        {

            fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();

            permissoes.Todas = new List<Permissao>();
            permissoes.Modulos = new List<Permissao>();
            permissoes.Telas = new List<Permissao>();
            permissoes.Funcoes = new List<Permissao>();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * 
                                             FROM permissao_has_grupo_usuario pg INNER JOIN permissao p 
                                             ON pg.idpermissao = p.idpermissao 
                                             WHERE idgrupousuario = @idgrupousuario", Conexao);
                Comando.Parameters.AddWithValue("@idgrupousuario", cod);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    string codfiltro = reader.GetString(reader.GetOrdinal("codigo"));

                    if (codfiltro.Substring(2) == "0000")
                    {
                        Permissao p = new Permissao
                        {
                            PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
                            Nome = reader.GetString(reader.GetOrdinal("nome")),
                            Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                            Nivel = reader.GetString(reader.GetOrdinal("nivel"))
                        };
                        permissoes.Modulos.Add(p);
                        permissoes.Todas.Add(p);
                    }

                    if (codfiltro.Substring(4) == "00")
                    {
                        Permissao p = new Permissao
                        {
                            PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
                            Nome = reader.GetString(reader.GetOrdinal("nome")),
                            Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                            Nivel = reader.GetString(reader.GetOrdinal("nivel"))
                        };

                        permissoes.Telas.Add(p);
                        permissoes.Todas.Add(p);

                    }

                    if (codfiltro.Substring(4) != "00")
                    {
                        Permissao p = new Permissao
                        {
                            PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
                            Nome = reader.GetString(reader.GetOrdinal("nome")),
                            Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                            Nivel = reader.GetString(reader.GetOrdinal("nivel"))
                        };

                        permissoes.Funcoes.Add(p);
                        permissoes.Todas.Add(p);

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
                FecharConexao();
            }

            return permissoes;
        }

        //public fmCadastroGrupoUsuario.PermissoesStruct BuscaPermissoesByIdGrupo(string cod)
        //{
        //    List<Permissao> permissoesGrupo = new List<Permissao>();

        //    fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();

        //    try
        //    {
        //        AbrirConexao();
        //        Comando = new MySqlCommand(@"SELECT * 
        //                                     FROM permissao_has_grupo_usuario pg INNER JOIN permissao p 
        //                                     ON pg.idpermissao = p.idpermissao 
        //                                     WHERE idgrupousuario = @idgrupousuario", Conexao);
        //        Comando.Parameters.AddWithValue("@idgrupousuario", cod);

        //        IDataReader reader = Comando.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Permissao p = new Permissao
        //            {
        //                PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
        //                Nome = reader.GetString(reader.GetOrdinal("nome")),
        //                Codigo = reader.GetString(reader.GetOrdinal("codigo")),
        //                Nivel = reader.GetString(reader.GetOrdinal("nivel"))
        //            };

        //            permissoesGrupo.Add(p);
        //        }
        //        reader.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine("Error: {0}", ex.ToString());
        //    }
        //    finally
        //    {
        //        FecharConexao();
        //    }

        //    permissoes.Todas = permissoesGrupo;
        //    permissoes.Modulos = permissoesGrupo.Where(p => p.Codigo.Substring(2) == "0000").ToList();
        //    permissoes.Telas = permissoesGrupo.Where(p => p.Codigo.Substring(4) == "00").ToList();
        //    permissoes.Funcoes = permissoesGrupo.Where(p => p.Codigo.Substring(4) != "00").ToList();

        //    return permissoes;
        //}

        public fmCadastroGrupoUsuario.PermissoesStruct BuscaTodasPermissoes()
        {
            //List<Permissao> TodaspermissoesGrupo = new List<Permissao>();
            //List<Permissao> ModulospermissoesGrupo = new List<Permissao>();
            //List<Permissao> TelaspermissoesGrupo = new List<Permissao>();
            //List<Permissao> FuncoespermissoesGrupo = new List<Permissao>();

            fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();
            
            permissoes.Todas = new List<Permissao>();
            permissoes.Modulos = new List<Permissao>();
            permissoes.Telas = new List<Permissao>();
            permissoes.Funcoes = new List<Permissao>();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * 
                                             FROM permissao", Conexao);


                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    string codfiltro = reader.GetString(reader.GetOrdinal("codigo"));

                    if (codfiltro.Substring(2) == "0000")
                    {
                        Permissao p = new Permissao
                        {
                            PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
                            Nome = reader.GetString(reader.GetOrdinal("nome")),
                            Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                            Nivel = "0"
                        };

                        permissoes.Modulos.Add(p);
                        permissoes.Todas.Add(p);
                    }

                    if (codfiltro.Substring(4) == "00")
                    {
                        Permissao p = new Permissao
                        {
                            PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
                            Nome = reader.GetString(reader.GetOrdinal("nome")),
                            Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                            Nivel = "0"
                        };

                        permissoes.Telas.Add(p);
                        permissoes.Todas.Add(p);
                    }

                    if (codfiltro.Substring(4) != "00")
                    {
                        Permissao p = new Permissao
                        {
                            PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
                            Nome = reader.GetString(reader.GetOrdinal("nome")),
                            Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                            Nivel = "0"
                        };

                        permissoes.Funcoes.Add(p);
                        permissoes.Todas.Add(p);
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
                FecharConexao();
            }

            //permissoes.Todas = TodaspermissoesGrupo;
            //permissoes.Modulos = ModulospermissoesGrupo;
            //permissoes.Telas = TelaspermissoesGrupo;
            //permissoes.Funcoes = FuncoespermissoesGrupo;

            return permissoes;
        }


        //public fmCadastroGrupoUsuario.PermissoesStruct BuscaTodasPermissoes()
        //{
        //    List<Permissao> permissoesGrupo = new List<Permissao>();

        //    fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();

        //    try
        //    {
        //        AbrirConexao();
        //        Comando = new MySqlCommand(@"SELECT * 
        //                                     FROM permissao", Conexao);


        //        IDataReader reader = Comando.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Permissao p = new Permissao
        //            {
        //                PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
        //                Nome = reader.GetString(reader.GetOrdinal("nome")),
        //                Codigo = reader.GetString(reader.GetOrdinal("codigo")),
        //                Nivel = "0"
        //            };

        //            permissoesGrupo.Add(p);
        //        }
        //        reader.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine("Error: {0}", ex.ToString());
        //    }
        //    finally
        //    {
        //        FecharConexao();
        //    }

        //    permissoes.Todas = permissoesGrupo;
        //    permissoes.Modulos = permissoesGrupo.Where(p => p.Codigo.Substring(2) == "0000").ToList();
        //    permissoes.Telas = permissoesGrupo.Where(p => p.Codigo.Substring(4) == "00").ToList();
        //    permissoes.Funcoes = permissoesGrupo.Where(p => p.Codigo.Substring(4) != "00").ToList();


        //    return permissoes;
        //}

        public Permissao BuscarPermissaoByID(string idpermissao)
        {
            Permissao permissao = null;

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM permissao as p WHERE p.idpermissao = @idpermissao", Conexao);
                Comando.Parameters.AddWithValue("@idpermissao", idpermissao);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    permissao = new Permissao();
                    permissao.PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao"));
                    permissao.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    permissao.Codigo = reader.GetString(reader.GetOrdinal("codigo"));
                    permissao.Nivel = "0";
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
            return permissao;
        }

        public int BuscarIDbyCodigo(string codpermissao)
        {
            int permissaoid = 0;

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT p.idpermissao FROM permissao as p WHERE p.codigo = @codigo", Conexao);
                Comando.Parameters.AddWithValue("@codigo", codpermissao);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    permissaoid = reader.GetInt32(reader.GetOrdinal("idpermissao"));
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
            return permissaoid;
        }


        public int BuscarNivelPermissao(string codgrupousuario, string codpermissao)
        {
            int nivel = 0;

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT pg.nivel FROM permissao_has_grupo_usuario as pg 
                                             WHERE idgrupousuario = @idgrupousuario 
                                             AND idpermissao = @idpermissao", Conexao);
                        
                
                Comando.Parameters.AddWithValue("@idgrupousuario", codgrupousuario);
                Comando.Parameters.AddWithValue("@idpermissao", codpermissao);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    nivel = reader.GetInt32(reader.GetOrdinal("nivel"));
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
            return nivel;
        }

        public List<int> BuscarIDPermissoesNpraN()
        {
            List<int> idpermissoesNpraN = new List<int>();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT DISTINCT p.idpermissao 
                                             FROM permissao_has_grupo_usuario as p", Conexao);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    int a = reader.GetInt32(reader.GetOrdinal("idpermissao"));

                    idpermissoesNpraN.Add(a);
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

            return idpermissoesNpraN;
        }

        public List<fmMain.PermissaoNivelStruct> PermissoesNiveisStructByCodGrupoUsuario(string codgrupousuario)
        {
            List<fmMain.PermissaoNivelStruct> listacomniveis = new List<fmMain.PermissaoNivelStruct>();

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * 
                                             FROM permissao_has_grupo_usuario as p
                                             WHERE p.idgrupousuario = @idgrupousuario
                                            ", Conexao);

                Comando.Parameters.AddWithValue("@idgrupousuario", codgrupousuario);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    fmMain.PermissaoNivelStruct permissaonivel = new fmMain.PermissaoNivelStruct();
                    permissaonivel.permissao = BuscarPermissaoByID(reader.GetString(reader.GetOrdinal("idpermissao")));
                    permissaonivel.Nivel = reader.GetInt32(reader.GetOrdinal("nivel"));

                    listacomniveis.Add(permissaonivel);
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

            return listacomniveis;
        }


    }
}
