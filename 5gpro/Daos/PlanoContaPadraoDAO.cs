using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class PlanoContaPadraoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public int Salva(PlanoContaPadrao planoContaPadrao)
        {

            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();

                sql.Query = "DELETE FROM caixa_plano_contas_padrao";
                sql.deleteQuery();

                sql.Query = @"INSERT INTO caixa_plano_contas_padrao 
                              (idcaixa_plano_contas_padrao, compras, contas_pagar, descontos_concedidos, juros_pagos, vendas,
                              contas_receber, descontos_recebidos, juros_recebidos)
                              VALUES
                              (1, @compras, @contas_pagar, @descontos_concedidos, @juros_pagos, @vendas, @contas_receber,
                               @descontos_recebidos, @juros_recebidos)";

                sql.addParam("@compras", planoContaPadrao.Compras != null ? planoContaPadrao.Compras.PlanoContaID.ToString() : null);
                sql.addParam("@contas_pagar", planoContaPadrao.ContasPagar != null ? planoContaPadrao.ContasPagar.PlanoContaID.ToString() : null);
                sql.addParam("@descontos_concedidos", planoContaPadrao.DescontosConcedidos != null ? planoContaPadrao.DescontosConcedidos.PlanoContaID.ToString() : null);
                sql.addParam("@juros_pagos", planoContaPadrao.JurosPagos != null ? planoContaPadrao.JurosPagos.PlanoContaID.ToString() : null);
                sql.addParam("@vendas", planoContaPadrao.Vendas != null ? planoContaPadrao.Vendas.PlanoContaID.ToString() : null);
                sql.addParam("@contas_receber", planoContaPadrao.ContasReceber != null ? planoContaPadrao.ContasReceber.PlanoContaID.ToString() : null);
                sql.addParam("@descontos_recebidos", planoContaPadrao.DescontosRecebidos != null ? planoContaPadrao.DescontosRecebidos.PlanoContaID.ToString() : null);
                sql.addParam("@juros_recebidos", planoContaPadrao.JurosRecebidos != null ? planoContaPadrao.JurosRecebidos.PlanoContaID.ToString() : null);

                retorno = sql.insertQuery();
                sql.Commit();
            }
            return retorno;
        }

        public PlanoContaPadrao Busca()
        {
            PlanoContaPadrao planocontapadrao = new PlanoContaPadrao();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM caixa_plano_contas_padrao";

                var data = sql.selectQueryForSingleRecord();
                planocontapadrao = LeDadosReaderConta(data);

            }
            return planocontapadrao;
        }

        private PlanoContaPadrao LeDadosReaderConta(Dictionary<string, object> dado)
        {
            PlanoContaPadrao planocontaPadrao = new PlanoContaPadrao();

            planocontaPadrao.PlanoContaPadraoID = Convert.ToInt32(dado["idcaixa_plano_contas_padrao"]);

            PlanoConta planoconta = new PlanoConta();
            planoconta.PlanoContaID = Convert.ToInt32(dado["compras"]);
            planocontaPadrao.Compras = planoconta;

            planoconta = new PlanoConta();
            planoconta.PlanoContaID = Convert.ToInt32(dado["contas_pagar"]);
            planocontaPadrao.ContasPagar = planoconta;

            planoconta = new PlanoConta();
            planoconta.PlanoContaID = Convert.ToInt32(dado["contas_receber"]);
            planocontaPadrao.ContasReceber = planoconta;

            planoconta = new PlanoConta();
            planoconta.PlanoContaID = Convert.ToInt32(dado["descontos_concedidos"]);
            planocontaPadrao.DescontosConcedidos = planoconta;

            planoconta = new PlanoConta();
            planoconta.PlanoContaID = Convert.ToInt32(dado["descontos_recebidos"]);
            planocontaPadrao.DescontosRecebidos = planoconta;

            planoconta = new PlanoConta();
            planoconta.PlanoContaID = Convert.ToInt32(dado["juros_pagos"]);
            planocontaPadrao.JurosPagos = planoconta;

            planoconta = new PlanoConta();
            planoconta.PlanoContaID = Convert.ToInt32(dado["juros_recebidos"]);
            planocontaPadrao.JurosRecebidos = planoconta;

            planoconta = new PlanoConta();
            planoconta.PlanoContaID = Convert.ToInt32(dado["vendas"]);
            planocontaPadrao.Vendas = planoconta;

            return planocontaPadrao;
        }

    }
}
