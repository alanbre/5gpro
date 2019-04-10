using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace _5gpro.Funcoes
{
    class PermissoesUpdate : Daos.ConexaoDAO
    {
        private PermissaoBLL permissaoBLL = new PermissaoBLL();
        private GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
        private List<GrupoUsuario> listagrupos = new List<GrupoUsuario>();
        private fmCadastroGrupoUsuario.PermissoesStruct listapermissoes = new fmCadastroGrupoUsuario.PermissoesStruct();
        private List<int> idpermissoesNpraN = new List<int>();
        private List<int> idgrupousuariosNpraN = new List<int>();
        

        public void AtualizarNpraN()
        {
            //Busca uma lista com todos os ID's das permissões na tabela N para N
            idpermissoesNpraN = permissaoBLL.BuscarIDPermissoesNpraN();

            //Busca uma lista com todo os ID's dos grupos de usuário na tabela N para N
            idgrupousuariosNpraN = grupousuarioBLL.BuscarIDGrupoUsuariosNpraN();

            //Struct com todas as permissões e Lista com todos os grupos
            listapermissoes = permissaoBLL.BuscaTodasPermissoes();
            listagrupos = grupousuarioBLL.BuscarTodosGrupoUsuarios();
          

            //Percorre uma lista com todas as permissões e verifica se o ID da permissão
            //está inserido na tabela N para N, caso contrário insere e faz todas as relações
            foreach (Permissao p in listapermissoes.Todas)
            {
                if (!idpermissoesNpraN.Contains(p.PermissaoId))
                {
                    inserirRelacoesPermissao(p.PermissaoId);
                }
            }

            foreach (GrupoUsuario g in listagrupos)
            {
                if (!idgrupousuariosNpraN.Contains(g.GrupoUsuarioID))
                {
                    inserirRelacoesGrupoUsuarios(g.GrupoUsuarioID);
                }
            }

        }

        public int inserirRelacoesPermissao(int inseriridpermissao)
        {
            int retorno = 0;
            try
            {
                AbrirConexao();
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;


                Comando.CommandText = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                            VALUES
                                            (@idgrupousuario, @idpermissao, @nivel)
                                            ON DUPLICATE KEY UPDATE
                                             nivel = @nivel
                                             ";

                foreach (GrupoUsuario g in listagrupos)
                {
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("@idgrupousuario", g.GrupoUsuarioID);
                    Comando.Parameters.AddWithValue("@idpermissao", inseriridpermissao);
                    Comando.Parameters.AddWithValue("@nivel", 0);
                    Comando.ExecuteNonQuery();
                }

                retorno = Comando.ExecuteNonQuery();

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

        public int inserirRelacoesGrupoUsuarios(int inseriridgrupousuario)
        {
            int retorno = 0;
            try
            {
                AbrirConexao();
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;


                Comando.CommandText = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                            VALUES
                                            (@idgrupousuario, @idpermissao, @nivel)
                                            ON DUPLICATE KEY UPDATE
                                             nivel = @nivel
                                             ";

                foreach (Permissao p in listapermissoes.Todas)
                {
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("@idgrupousuario", inseriridgrupousuario);
                    Comando.Parameters.AddWithValue("@idpermissao", p.PermissaoId);
                    Comando.Parameters.AddWithValue("@nivel", 0);
                    Comando.ExecuteNonQuery();
                }

                retorno = Comando.ExecuteNonQuery();

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
    }
}
