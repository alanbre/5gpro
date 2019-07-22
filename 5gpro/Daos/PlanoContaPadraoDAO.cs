using _5gpro.Entities;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class PlanoContaPadraoDAO
    {

        public int Salva(PlanoContaPadrao planoContaPadrao)
        {

            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
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

                sql.addParam("@compras", planoContaPadrao.Compras?.PlanoContaID);
                sql.addParam("@contas_pagar", planoContaPadrao.ContasPagar?.PlanoContaID);
                sql.addParam("@descontos_concedidos", planoContaPadrao.DescontosConcedidos?.PlanoContaID);
                sql.addParam("@juros_pagos", planoContaPadrao.JurosPagos?.PlanoContaID);
                sql.addParam("@vendas", planoContaPadrao.Vendas?.PlanoContaID);
                sql.addParam("@contas_receber", planoContaPadrao.ContasReceber?.PlanoContaID);
                sql.addParam("@descontos_recebidos", planoContaPadrao.DescontosRecebidos?.PlanoContaID);
                sql.addParam("@juros_recebidos", planoContaPadrao.JurosRecebidos?.PlanoContaID);

                retorno = sql.insertQuery();
                sql.Commit();
            }
            return retorno;
        }

        public PlanoContaPadrao Busca()
        {
            PlanoContaPadrao planocontapadrao = new PlanoContaPadrao();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
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
