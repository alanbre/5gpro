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

        public fmCadastroGrupoUsuario.PermissoesStruct BuscaPermissoesByIdGrupo(string cod)
        {
            List<Permissao> permissoesGrupo = new List<Permissao>();

            fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();

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
                    Permissao p = new Permissao();

                    p.PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao"));
                    p.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    p.Codigo = reader.GetString(reader.GetOrdinal("codigo"));
                    p.Nivel = reader.GetString(reader.GetOrdinal("nivel"));

                    permissoesGrupo.Add(p);
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

            permissoes.Todas = permissoesGrupo;
            permissoes.Modulos = permissoesGrupo.Where(p => p.Codigo.Substring(2) == "0000").ToList();
            permissoes.Telas = permissoesGrupo.Where(p => p.Codigo.Substring(4) == "00").ToList();
            permissoes.Funcoes = permissoesGrupo.Where(p => p.Codigo.Substring(4) != "00").ToList();

            return permissoes;
        }

        public fmCadastroGrupoUsuario.PermissoesStruct BuscaTodasPermissoes()
        {
            List<Permissao> permissoesGrupo = new List<Permissao>();

            fmCadastroGrupoUsuario.PermissoesStruct permissoes = new fmCadastroGrupoUsuario.PermissoesStruct();


            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * 
                                             FROM permissao", Conexao);


                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Permissao p = new Permissao();

                    p.PermissaoId = reader.GetInt32(reader.GetOrdinal("idpermissao"));
                    p.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    p.Codigo = reader.GetString(reader.GetOrdinal("codigo"));
                    p.Nivel = "0";

                    permissoesGrupo.Add(p);
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

            permissoes.Todas = permissoesGrupo;
            permissoes.Modulos = permissoesGrupo.Where(p => p.Codigo.Substring(2) == "0000").ToList();
            permissoes.Telas = permissoesGrupo.Where(p => p.Codigo.Substring(4) == "00").ToList();
            permissoes.Funcoes = permissoesGrupo.Where(p => p.Codigo.Substring(4) != "00").ToList();


            return permissoes;
        }

        public int buscarIDbyCodigo(string codpermissao)
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


    }
}
