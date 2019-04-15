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
    public class PermissaoDAO
    {

        public ConexaoDAO Connect { get; }
        public PermissaoDAO(ConexaoDAO c)
        {
            Connect = c;
        }


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
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * 
                                             FROM permissao_has_grupo_usuario pg INNER JOIN permissao p 
                                             ON pg.idpermissao = p.idpermissao 
                                             WHERE idgrupousuario = @idgrupousuario", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idgrupousuario", cod);

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    
                    string codfiltro = reader.GetString(reader.GetOrdinal("codigo"));

                    Permissao p = new Permissao
                    {
                        PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                        Nivel = reader.GetString(reader.GetOrdinal("nivel"))
                    };
                    permissoes.Todas.Add(p);

                    if (codfiltro.Substring(2) == "0000")
                    {
                        permissoes.Modulos.Add(p);
                    }

                    if (codfiltro.Substring(4) == "00")
                    {
                        permissoes.Telas.Add(p);
                    }

                    if (codfiltro.Substring(4) != "00")
                    {
                        permissoes.Funcoes.Add(p);
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

            return permissoes;
        }


        public fmCadastroGrupoUsuario.PermissoesStruct BuscaTodasPermissoes()
        {
            fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();
            
            permissoes.Todas = new List<Permissao>();
            permissoes.Modulos = new List<Permissao>();
            permissoes.Telas = new List<Permissao>();
            permissoes.Funcoes = new List<Permissao>();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * 
                                             FROM permissao", Connect.Conexao);


                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    string codfiltro = reader.GetString(reader.GetOrdinal("codigo"));

                    Permissao p = new Permissao
                    {
                        PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                        Nivel = "0"
                    };
                    permissoes.Todas.Add(p);

                    if (codfiltro.Substring(2) == "0000")
                    {
                        permissoes.Modulos.Add(p);
                    }

                    if (codfiltro.Substring(4) == "00")
                    {
                        permissoes.Telas.Add(p);
                    }

                    if (codfiltro.Substring(4) != "00")
                    {
                        permissoes.Funcoes.Add(p);
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

            return permissoes;
        }


        public Permissao BuscarPermissaoByID(string idpermissao)
        {
            Permissao permissao = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT * FROM permissao as p WHERE p.idpermissao = @idpermissao", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idpermissao", idpermissao);

                IDataReader reader = Connect.Comando.ExecuteReader();

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
                Connect.FecharConexao();
            }
            return permissao;
        }

        public int BuscarIDbyCodigo(string codpermissao)
        {
            int permissaoid = 0;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("SELECT p.idpermissao FROM permissao as p WHERE p.codigo = @codigo", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@codigo", codpermissao);

                IDataReader reader = Connect.Comando.ExecuteReader();

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
                Connect.FecharConexao();
            }
            return permissaoid;
        }


        public int BuscarNivelPermissao(string codgrupousuario, string codpermissao)
        {
            int nivel = 0;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT pg.nivel FROM permissao_has_grupo_usuario as pg 
                                             WHERE idgrupousuario = @idgrupousuario 
                                             AND idpermissao = @idpermissao", Connect.Conexao);


                Connect.Comando.Parameters.AddWithValue("@idgrupousuario", codgrupousuario);
                Connect.Comando.Parameters.AddWithValue("@idpermissao", codpermissao);

                IDataReader reader = Connect.Comando.ExecuteReader();

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
                Connect.FecharConexao();
            }
            return nivel;
        }

        public List<int> BuscarIDPermissoesNpraN()
        {
            List<int> idpermissoesNpraN = new List<int>();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT DISTINCT p.idpermissao 
                                             FROM permissao_has_grupo_usuario as p", Connect.Conexao);

                IDataReader reader = Connect.Comando.ExecuteReader();

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
                Connect.FecharConexao();
            }

            return idpermissoesNpraN;
        }

        public List<fmMain.PermissaoNivelStruct> PermissoesNiveisStructByCodGrupoUsuario(string codgrupousuario)
        {
            List<fmMain.PermissaoNivelStruct> listacomniveis = new List<fmMain.PermissaoNivelStruct>();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * 
                                             FROM permissao_has_grupo_usuario as p
                                             WHERE p.idgrupousuario = @idgrupousuario
                                            ", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idgrupousuario", codgrupousuario);

                IDataReader reader = Connect.Comando.ExecuteReader();

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
                Connect.FecharConexao();
            }

            return listacomniveis;
        }


    }
}
