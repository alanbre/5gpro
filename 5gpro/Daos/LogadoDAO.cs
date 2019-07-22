using _5gpro.Entities;
using System;
using MySql.Data.MySqlClient;
using MySQLConnection;
using _5gpro.StaticFiles;

namespace _5gpro.Daos
{
    public class LogadoDAO
    {
        public Logado BuscaByUsuario(Usuario usuario)
        {
            Logado usuarioLogado = null;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT * FROM logado WHERE idusuario = @idusuario";
                sql.addParam("@idusuario", usuario.UsuarioID);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }

                usuario = new Usuario
                {
                    UsuarioID = Convert.ToInt32( data["idusuario"])
                };

                usuarioLogado = new Logado
                {
                    Usuario = usuario,
                    Mac = (string) data["mac"],
                    NomePC = (string) data["nomepc"],
                    IPdoPC = (string) data["ipdopc"]
                };
            }
            return usuarioLogado;
        }

        public Logado BuscaByMac(string mac)
        {
            Logado usuarioLogado = null;
            GrupoUsuario grupousuario = null;
            Usuario usuario = null;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT * FROM logado l INNER JOIN usuario u
                            ON l.idusuario = u.idusuario
                            WHERE mac = @mac LIMIT 1";

                sql.addParam("@mac", mac);

                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                grupousuario = new GrupoUsuario
                {
                    GrupoUsuarioID = Convert.ToInt32( data["idgrupousuario"])
                };

                usuario = new Usuario
                {
                    UsuarioID = Convert.ToInt32( data["idusuario"]),
                    Grupousuario = grupousuario
                };

                usuarioLogado = new Logado
                {
                    Usuario = usuario,
                    Mac = (string) data["mac"],
                    NomePC = (string) data["nomepc"],
                    IPdoPC = (string) data["ipdopc"]
                };
            }
            return usuarioLogado;
        }

        //Registra login na tabela Logado
        public int GravarLogado(Usuario usuario, string mac, string nomepc, string ipdopc)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"INSERT INTO logado
                         (idusuario, mac, nomepc, ipdopc, data_update)
                          VALUES
                         (@idusuario, @mac, @nomepc, @ipdopc, @data_update)";
                sql.addParam("@idusuario", usuario.UsuarioID);
                sql.addParam("@mac", mac);
                sql.addParam("@nomepc", nomepc);
                sql.addParam("@ipdopc", ipdopc);
                sql.addParam("@data_update", DateTime.Now);
                retorno = sql.insertQuery();
            }
            return retorno;
        }

        //Remove login da tabela Logado
        public int RemoverLogado(string mac)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "DELETE FROM logado WHERE mac = @mac";
                sql.addParam("@mac", mac);
                retorno = sql.deleteQuery();
            }
            return retorno;
        }

        public void AtualizarLogado(string mac)
        {
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"UPDATE logado SET data_update = NOW() WHERE mac = @mac";
                sql.addParam("@mac", mac);
                sql.updateQuery();
            }
        }

        public void RemoveTodosLocks(Logado logado)
        {
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "DELETE FROM 5gprodatabase.lock WHERE idusuario = @idusuario";
                sql.addParam("@idusuario", logado.Usuario.UsuarioID);
                sql.deleteQuery();
            }
        }
    }
}
