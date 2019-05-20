using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{

    class GrupoUsuarioDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public GrupoUsuario BuscaByID(int Codigo)
        {
            var grupoUsuario = new GrupoUsuario();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = "SELECT * FROM grupo_usuario WHERE idgrupousuario = @idgrupousuario LIMIT 1";
                sql.addParam("@idgrupousuario", Codigo);
                var data = sql.selectQueryForSingleRecord();
                grupoUsuario = LeDadosReader(data);
            }

            return grupoUsuario;
        }

        public IEnumerable<GrupoUsuario> Busca(string nome)
        {
            var grupoUsuarios = new List<GrupoUsuario>();
            string conNome = nome.Length > 0 ? "AND nome LIKE @nome" : "";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM grupo_usuario
                            WHERE 1=1"
                            + conNome +
                            @" ORDER BY nome";
                if (conNome.Length > 0) { sql.addParam("@nome", "%" + nome + "%"); }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var grupoUsuario = LeDadosReader(d);
                    grupoUsuarios.Add(grupoUsuario);
                }
            }
            return grupoUsuarios;
        }


        public List<GrupoUsuario> BuscaTodos()
        {
            var grupoUsuarios = new List<GrupoUsuario>();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = "SELECT * FROM grupo_usuario";
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var grupoUsuario = LeDadosReader(d);
                    grupoUsuarios.Add(grupoUsuario);
                }
            }
            return grupoUsuarios;
        }

        public int SalvarOuAtualizar(GrupoUsuario grupousuario, List<Permissao> listapermissoes)
        {
            var permissaoDAO = new PermissaoDAO();
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();

                sql.Query = @"INSERT INTO grupo_usuario 
                          (idgrupousuario, nome) 
                          VALUES
                          (@idusuario, @nome)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome
                         ";
                sql.addParam("@idusuario", grupousuario.GrupoUsuarioID);
                sql.addParam("@nome", grupousuario.Nome);
                retorno = sql.insertQuery();
                if (retorno > 0)
                {
                    var todaspermissoes = new fmCadastroGrupoUsuario.PermissoesStruct();
                    todaspermissoes = permissaoDAO.BuscaTodasPermissoes();

                    sql.Query = @"INSERT INTO permissao_has_grupo_usuario (idgrupousuario, idpermissao, nivel)
                                VALUES
                                (@idgrupousuario, @idpermissao, @nivel)
                                ON DUPLICATE KEY UPDATE
                                nivel = @nivel";
                    foreach (Permissao p in todaspermissoes.Todas)
                    {
                        sql.clearParams();
                        sql.addParam("@idgrupousuario", grupousuario.GrupoUsuarioID);
                        sql.addParam("@idpermissao", p.PermissaoId);
                        sql.addParam("@nivel", 0);
                        sql.insertQuery();
                    }

                    foreach (Permissao p in listapermissoes)
                    {
                        sql.clearParams();
                        sql.addParam("@idgrupousuario", grupousuario.GrupoUsuarioID);
                        sql.addParam("@idpermissao", p.PermissaoId);
                        sql.addParam("@nivel", 0);
                        sql.insertQuery();
                    }
                }
                sql.Commit();
            }
            return retorno;
        }

        public GrupoUsuario Proximo(string Codigo)
        {
            var grupoUsuario = new GrupoUsuario();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = "SELECT * FROM grupo_usuario WHERE idgrupousuario = (SELECT min(idgrupousuario) FROM grupo_usuario WHERE idgrupousuario > @idgrupousuario) LIMIT 1";
                sql.addParam("@idgrupousuario", Codigo);
                var data = sql.selectQueryForSingleRecord();
                grupoUsuario = LeDadosReader(data);
            }

            return grupoUsuario;
        }

        public GrupoUsuario Anterior(string Codigo)
        {
            var grupoUsuario = new GrupoUsuario();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = "SELECT * FROM grupo_usuario WHERE idgrupousuario = (SELECT max(idgrupousuario) FROM grupo_usuario WHERE idgrupousuario < @idgrupousuario) LIMIT 1";
                sql.addParam("@idgrupousuario", Codigo);
                var data = sql.selectQueryForSingleRecord();
                grupoUsuario = LeDadosReader(data);
            }
            return grupoUsuario;
        }

        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g1.idgrupousuario + 1 AS proximoid
                            FROM grupo_usuario AS g1
                            LEFT OUTER JOIN grupo_usuario AS g2 ON g1.idgrupousuario + 1 = g2.idgrupousuario
                            WHERE g2.idgrupousuario IS NULL
                            ORDER BY proximoid
                            LIMIT 1";
                var data = sql.selectQueryForSingleRecord();
                if (data != null)
                {
                    proximoid = Convert.ToInt32(data["proximoid"]);
                }
            }
            return proximoid;
        }

        public List<int> BuscarIDNpraN()
        {
            var idgrupousuariosNpraN = new List<int>();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT DISTINCT p.idgrupousuario 
                            FROM permissao_has_grupo_usuario as p";
                var data = sql.selectQuery();
                foreach(var d in data)
                {
                    idgrupousuariosNpraN.Add(Convert.ToInt32(d["idgrupousuario"]));
                }
            }
            return idgrupousuariosNpraN;
        }

        private GrupoUsuario LeDadosReader(Dictionary<string, object> data)
        {
            var grupoUsuario = new GrupoUsuario();
            grupoUsuario.GrupoUsuarioID = Convert.ToInt32(data["idgrupousuario"]);
            grupoUsuario.Nome = (string)data["nome"];
            return grupoUsuario;
        }
    }
}
