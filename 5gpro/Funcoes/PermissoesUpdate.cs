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
        private static ConexaoDAO connection = new ConexaoDAO();
        private PermissaoDAO permissaoDAO = new PermissaoDAO(connection);
        private GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO(connection);
        private List<GrupoUsuario> listagrupos = new List<GrupoUsuario>();
        private fmCadastroGrupoUsuario.PermissoesStruct listapermissoes = new fmCadastroGrupoUsuario.PermissoesStruct();
        private List<int> idpermissoesNpraN = new List<int>();
        private List<int> idgrupousuariosNpraN = new List<int>();
        

        public void AtualizarNpraN()
        {
            //Busca uma lista com todos os ID's das permissões na tabela N para N
            idpermissoesNpraN = permissaoDAO.BuscarIDPermissoesNpraN();

            //Busca uma lista com todo os ID's dos grupos de usuário na tabela N para N
            idgrupousuariosNpraN = grupousuarioDAO.BuscarIDGrupoUsuariosNpraN();

            //Struct com todas as permissões e Lista com todos os grupos
            listapermissoes = permissaoDAO.BuscaTodasPermissoes();
            listagrupos = grupousuarioDAO.BuscarTodosGrupoUsuarios();
          

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
                connection.AbrirConexao();
                connection.Comando = connection.Conexao.CreateCommand();
                connection.tr = connection.Conexao.BeginTransaction();
                connection.Comando.Connection = connection.Conexao;
                connection.Comando.Transaction = connection.tr;


                connection.Comando.CommandText = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                            VALUES
                                            (@idgrupousuario, @idpermissao, @nivel)
                                            ON DUPLICATE KEY UPDATE
                                             nivel = @nivel
                                             ";

                foreach (GrupoUsuario g in listagrupos)
                {
                    connection.Comando.Parameters.Clear();
                    connection.Comando.Parameters.AddWithValue("@idgrupousuario", g.GrupoUsuarioID);
                    connection.Comando.Parameters.AddWithValue("@idpermissao", inseriridpermissao);
                    connection.Comando.Parameters.AddWithValue("@nivel", 0);
                    connection.Comando.ExecuteNonQuery();
                }

                retorno = connection.Comando.ExecuteNonQuery();

                connection.tr.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                connection.FecharConexao();
            }
            return retorno;
        }

        public int inserirRelacoesGrupoUsuarios(int inseriridgrupousuario)
        {
            int retorno = 0;
            try
            {
                connection.AbrirConexao();
                connection.Comando = connection.Conexao.CreateCommand();
                connection.tr = connection.Conexao.BeginTransaction();
                connection.Comando.Connection = connection.Conexao;
                connection.Comando.Transaction = connection.tr;


                connection.Comando.CommandText = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                            VALUES
                                            (@idgrupousuario, @idpermissao, @nivel)
                                            ON DUPLICATE KEY UPDATE
                                             nivel = @nivel
                                             ";

                foreach (Permissao p in listapermissoes.Todas)
                {
                    connection.Comando.Parameters.Clear();
                    connection.Comando.Parameters.AddWithValue("@idgrupousuario", inseriridgrupousuario);
                    connection.Comando.Parameters.AddWithValue("@idpermissao", p.PermissaoId);
                    connection.Comando.Parameters.AddWithValue("@nivel", 0);
                    connection.Comando.ExecuteNonQuery();
                }

                retorno = connection.Comando.ExecuteNonQuery();

                connection.tr.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                connection.FecharConexao();
            }
            return retorno;
        }
    }
}
