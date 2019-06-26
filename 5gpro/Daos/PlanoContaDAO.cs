using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    public class PlanoContaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public int Salva(PlanoConta planoConta)
        {
            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = "SELECT codigo_completo FROM caixa_plano_contas WHERE idcaixa_plano_contas = @paiid";
                sql.addParam("@paiid", planoConta.PaiID);
                string codigo_completo = sql.selectQueryForSingleValue().ToString();
                sql.clearParams();

                sql.Query = @"INSERT INTO caixa_plano_contas
                            (paiid, level, codigo, descricao, codigo_completo)
                            VALUES
                            (@paiid, @level, @codigo, @descricao, @codigo_completo)
                            ON DUPLICATE KEY UPDATE
                            descricao = @descricao";
                sql.addParam("@paiid", planoConta.PaiID);
                sql.addParam("@level", planoConta.Level);
                sql.addParam("@codigo", planoConta.Codigo);
                sql.addParam("@descricao", planoConta.Descricao);
                sql.addParam("@codigo_completo", planoConta.PaiID == 0 ? planoConta.Codigo.ToString() : codigo_completo + $".{planoConta.Codigo.ToString()}");
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
        public int Atualiza(PlanoConta planoConta)
        {
            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"UPDATE caixa_plano_contas SET descricao = @descricao WHERE codigo = @codigo AND paiid = @paiid";
                sql.addParam("@paiid", planoConta.PaiID);
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

        public List<PlanoConta> Busca(bool entrada = true, bool saida = true)
        {

            string conEntrada = entrada ? "AND SUBSTRING(codigo_completo, 1, 1) = 1" : "";
            string conSaida = saida ? "AND SUBSTRING(codigo_completo, 1, 1) = 2" : "";
            if (entrada && saida) { conEntrada = ""; conSaida = ""; }

            List<PlanoConta> planoContas = new List<PlanoConta>();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM caixa_plano_contas
                            WHERE 1=1 "
                            +conEntrada+""
                            +conSaida+"";

                var data = sql.selectQuery();
                foreach(var d in data)
                {
                    planoContas.Add(LeDadosReader(d));
                }
            }
            return planoContas;
        }

        public PlanoConta BuscaByID(int Codigo, bool entrada = true, bool saida = true)
        {
            string conEntrada = entrada ? "AND SUBSTRING(codigo_completo, 1, 1) = 1" : "";
            string conSaida = saida ? "AND SUBSTRING(codigo_completo, 1, 1) = 2" : "";
            if (entrada && saida) { conEntrada = ""; conSaida = ""; }

            var planoconta = new PlanoConta();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM caixa_plano_contas
                            WHERE idcaixa_plano_contas = @idcaixa_plano_contas "
                            + conEntrada + ""
                            + conSaida + "";

                sql.addParam("@idcaixa_plano_contas", Codigo);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                planoconta = LeDadosReader(data);
            }
            return planoconta;
        }
        public int BuscaProxCodigoDisponivel(int paiid)
        {
            int proximocodigo = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT COALESCE(MAX(pc.codigo) + 1, 1) AS proximocodigo
                            FROM caixa_plano_contas AS pc
                            WHERE pc.paiid = @paiid";
                sql.addParam("@paiid", paiid);
                var data = sql.selectQueryForSingleRecord();
                if (data != null)
                {
                    proximocodigo = Convert.ToInt32(data["proximocodigo"]);
                }
            }
            return proximocodigo;
        }
        private PlanoConta LeDadosReader(Dictionary<string, object> dado)
        {
            PlanoConta planoConta = new PlanoConta();
            planoConta.PlanoContaID = Convert.ToInt32(dado["idcaixa_plano_contas"]);
            planoConta.Codigo = Convert.ToInt32(dado["codigo"]);
            planoConta.Level = Convert.ToInt32(dado["level"]);
            planoConta.PaiID = dado["paiid"] != null ? Convert.ToInt32(dado["paiid"]) : 0;
            planoConta.Descricao = (string)dado["descricao"];
            planoConta.CodigoCompleto = (string)dado["codigo_completo"];
            return planoConta;
        }
    }
}
