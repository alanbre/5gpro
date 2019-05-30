using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace _5gpro.Funcoes
{
    class PermissoesUpdate
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();
        private PermissaoDAO permissaoDAO = new PermissaoDAO();
        private GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO();
        private List<GrupoUsuario> listagrupos = new List<GrupoUsuario>();
        private fmCadastroGrupoUsuario.PermissoesStruct listapermissoes = new fmCadastroGrupoUsuario.PermissoesStruct();
        private List<int> idpermissoesNpraN = new List<int>();
        private List<int> idgrupousuariosNpraN = new List<int>();
        

        public void AtualizarNpraN()
        {
            //Busca uma lista com todos os ID's das permissões na tabela N para N
            idpermissoesNpraN = permissaoDAO.BuscarIDPermissoesNpraN();

            //Busca uma lista com todo os ID's dos grupos de usuário na tabela N para N
            idgrupousuariosNpraN = grupousuarioDAO.BuscarIDNpraN();

            //Struct com todas as permissões e Lista com todos os grupos
            listapermissoes = permissaoDAO.BuscaTodasPermissoes();
            listagrupos = grupousuarioDAO.BuscaTodos();
          

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
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;


                Connect.Comando.CommandText = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                            VALUES
                                            (@idgrupousuario, @idpermissao, @nivel)
                                            ON DUPLICATE KEY UPDATE
                                             nivel = @nivel
                                             ";

                foreach (GrupoUsuario g in listagrupos)
                {
                    Connect.Comando.Parameters.Clear();
                    Connect.Comando.Parameters.AddWithValue("@idgrupousuario", g.GrupoUsuarioID);
                    Connect.Comando.Parameters.AddWithValue("@idpermissao", inseriridpermissao);
                    Connect.Comando.Parameters.AddWithValue("@nivel", 0);
                    Connect.Comando.ExecuteNonQuery();
                }

                retorno = Connect.Comando.ExecuteNonQuery();

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

        public int inserirRelacoesGrupoUsuarios(int inseriridgrupousuario)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;


                Connect.Comando.CommandText = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                            VALUES
                                            (@idgrupousuario, @idpermissao, @nivel)
                                            ON DUPLICATE KEY UPDATE
                                             nivel = @nivel
                                             ";

                foreach (Permissao p in listapermissoes.Todas)
                {
                    Connect.Comando.Parameters.Clear();
                    Connect.Comando.Parameters.AddWithValue("@idgrupousuario", inseriridgrupousuario);
                    Connect.Comando.Parameters.AddWithValue("@idpermissao", p.PermissaoId);
                    Connect.Comando.Parameters.AddWithValue("@nivel", 0);
                    Connect.Comando.ExecuteNonQuery();
                }

                retorno = Connect.Comando.ExecuteNonQuery();

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
    }
}
