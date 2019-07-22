using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.StaticFiles;
using MySql.Data.MySqlClient;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Funcoes
{
    class PermissoesUpdate
    {
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private readonly GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO();
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
                    InserirRelacoesPermissao(p.PermissaoId);
                }
            }

            foreach (GrupoUsuario g in listagrupos)
            {
                if (!idgrupousuariosNpraN.Contains(g.GrupoUsuarioID))
                {
                    InserirRelacoesGrupoUsuarios(g.GrupoUsuarioID);
                }
            }

        }
        public int InserirRelacoesPermissao(int inseriridpermissao)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO permissao_has_grupo_usuario 
                            (idgrupousuario, idpermissao, nivel) VALUES
                            (@idgrupousuario, @idpermissao, @nivel)
                            ON DUPLICATE KEY UPDATE
                            nivel = @nivel";
                foreach (GrupoUsuario g in listagrupos)
                {
                    sql.clearParams();
                    sql.addParam("@idgrupousuario", g.GrupoUsuarioID);
                    sql.addParam("@idpermissao", inseriridpermissao);
                    sql.addParam("@nivel", 0);
                    retorno += sql.insertQuery();
                }
            }
            return retorno;
        }
        public int InserirRelacoesGrupoUsuarios(int inseriridgrupousuario)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                            VALUES
                            (@idgrupousuario, @idpermissao, @nivel)
                            ON DUPLICATE KEY UPDATE
                            nivel = @nivel";
                foreach (Permissao p in listapermissoes.Todas)
                {
                    sql.clearParams();
                    sql.addParam("@idgrupousuario", inseriridgrupousuario);
                    sql.addParam("@idpermissao", p.PermissaoId);
                    sql.addParam("@nivel", 0);
                    retorno += sql.insertQuery();
                }
                sql.Commit();
            }
            return retorno;
        }
    }
}
