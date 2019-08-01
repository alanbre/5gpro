using _5gpro.Entities;
using System;
using MySQLConnection;
using _5gpro.StaticFiles;

namespace _5gpro.Daos
{
    public class LogadoDAO
    {
        public int GravarLogado()
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"INSERT INTO logado
                         (idusuario, mac, nomepc, ipdopc, data_update)
                          VALUES
                         (@idusuario, @mac, @nomepc, @ipdopc, @data_update)";
                sql.addParam("@idusuario", Logado.Usuario.UsuarioID);
                sql.addParam("@mac", Logado.Mac);
                sql.addParam("@nomepc", Logado.NomePC);
                sql.addParam("@ipdopc", Logado.IPdoPC);
                sql.addParam("@data_update", DateTime.Now);
                retorno = sql.insertQuery();
            }
            return retorno;
        }
        public bool ChecaLogado(string mac, string nomepc, string ipdopc)
        {
            var retorno = false;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "SELECT * FROM logado WHERE mac = @mac AND nomepc = @nomepc AND ipdopc = @ipdopc";
                sql.addParam("@mac", mac);
                sql.addParam("@nomepc", nomepc);
                sql.addParam("@ipdopc", ipdopc);
                if (sql.selectQueryForSingleRecord()?.Count > 0) retorno = true;
            }
            return retorno;
        }
        public int RemoverLogado()
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = "DELETE FROM logado WHERE mac = @mac AND nomepc = @nomepc AND ipdopc = @ipdopc";
                sql.addParam("@mac", Logado.Mac);
                sql.addParam("@nomepc", Logado.NomePC);
                sql.addParam("@ipdopc", Logado.IPdoPC);
                retorno = sql.deleteQuery();
            }
            return retorno;
        }
        public void AtualizarLogado()
        {
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"UPDATE logado SET data_update = NOW() WHERE mac = @mac AND nomepc = @nomepc AND ipdopc = @ipdopc";
                sql.addParam("@mac", Logado.Mac);
                sql.addParam("@nomepc", Logado.NomePC);
                sql.addParam("@ipdopc", Logado.IPdoPC);
                sql.updateQuery();
            }
        }
    }
}
