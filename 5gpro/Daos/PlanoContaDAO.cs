using _5gpro.Entities;
using MySQLConnection;
using System;

namespace _5gpro.Daos
{
    public class PlanoContaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public int SalvaOuAtualiza(PlanoConta planoConta)
        {
            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO caixa_plano_contas
                            (parentid, level, codigo, descricao)
                            VALUES
                            (@parentid, @level, @codigo, @descricao)
                            ON DUPLICATE KEY UPDATE
                            descricao = @descricao";
                sql.addParam("@parentid", planoConta.PaiID);
                sql.addParam("@level", planoConta.Level);
                sql.addParam("@codigo", planoConta.Codigo);
                sql.addParam("@descricao", planoConta.Descricao);
                retorno = sql.insertQuery();
                if (retorno > 0 && planoConta.PlanoContaID == 0)
                {
                    sql.Query = "SELECT LAST_INSERT_ID() AS id;";
                    var data = sql.selectQueryForSingleRecord();
                    planoConta.PlanoContaID = Convert.ToInt32(data["id"]);
                }
                sql.Commit();
            }
            return retorno;
        }
    }
}
