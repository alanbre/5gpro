using _5gpro.Entities;
using _5gpro.Forms;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class CaixaLancamentoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();
        public int Novo(CaixaLancamento caixaLancamento)
        {
            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"INSERT INTO caixa_lancamento
                            (data, valor, tipomovimento, tipodocumento, lancamento, documento, idcaixa, idcaixa_plano_contas)
                            VALUES
                            (@data, @valor, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa, @idcaixa_plano_contas)";
                sql.addParam("@data", caixaLancamento.Data);
                sql.addParam("@valor", caixaLancamento.Valor);
                sql.addParam("@tipomovimento", caixaLancamento.TipoMovimento);
                sql.addParam("@tipodocumento", caixaLancamento.TipoDocumento);
                sql.addParam("@lancamento", caixaLancamento.Lancamento);
                sql.addParam("@documento", caixaLancamento.Documento);
                sql.addParam("@idcaixa", caixaLancamento.Caixa.CaixaID);
                sql.addParam("@idcaixa_plano_contas", caixaLancamento.PlanoConta.PlanoContaID);
                retorno = sql.insertQuery();
            }
            return retorno;
        }
        public int NovosCar(List<CaixaLancamento> caixaLancamentos)
        {
            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                foreach (var lanc in caixaLancamentos)
                {
                    sql.Query = @"INSERT INTO caixa_lancamento
                            (data, valor, tipomovimento, tipodocumento, lancamento, documento, idcaixa, idcaixa_plano_contas)
                            VALUES
                            (@data, @valor, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa, @idcaixa_plano_contas)";
                    sql.clearParams();
                    sql.addParam("@data", lanc.Data);
                    sql.addParam("@valor", lanc.Valor);
                    sql.addParam("@tipomovimento", lanc.TipoMovimento);
                    sql.addParam("@tipodocumento", lanc.TipoDocumento);
                    sql.addParam("@lancamento", lanc.Lancamento);
                    sql.addParam("@documento", lanc.Documento);
                    sql.addParam("@idcaixa", lanc.Caixa.CaixaID);
                    sql.addParam("@idcaixa_plano_contas", lanc.PlanoConta.PlanoContaID);
                    retorno += sql.insertQuery();
                    sql.clearParams();
                    sql.Query = @"INSERT INTO caixa_lancamento_car
                                (idcaixa_lancamento, idparcela_conta_receber)
                                VALUES
                                ((SELECT LAST_INSERT_ID()), @idparcela_conta_receber)";
                    sql.addParam("@idparcela_conta_receber", lanc.ParcelaContaReceber.ParcelaContaReceberID);
                    sql.insertQuery();
                }
                sql.Commit();
            }
            return retorno;
        }
        public int NovosCap(List<CaixaLancamento> caixaLancamentos)
        {
            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                foreach (var lanc in caixaLancamentos)
                {
                    sql.Query = @"INSERT INTO caixa_lancamento
                            (data, valor, tipomovimento, tipodocumento, lancamento, documento, idcaixa, idcaixa_plano_contas)
                            VALUES
                            (@data, @valor, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa, @idcaixa_plano_contas)";
                    sql.clearParams();
                    sql.addParam("@data", lanc.Data);
                    sql.addParam("@valor", lanc.Valor);
                    sql.addParam("@tipomovimento", lanc.TipoMovimento);
                    sql.addParam("@tipodocumento", lanc.TipoDocumento);
                    sql.addParam("@lancamento", lanc.Lancamento);
                    sql.addParam("@documento", lanc.Documento);
                    sql.addParam("@idcaixa", lanc.Caixa.CaixaID);
                    sql.addParam("@idcaixa_plano_contas", lanc.PlanoConta.PlanoContaID);
                    retorno += sql.insertQuery();
                    sql.clearParams();
                    sql.Query = @"INSERT INTO caixa_lancamento_cap
                                (idcaixa_lancamento, idparcela_conta_pagar)
                                VALUES
                                ((SELECT LAST_INSERT_ID()), @idparcela_conta_pagar)";
                    sql.addParam("@idparcela_conta_pagar", lanc.ParcelaContaPagar.ParcelaContaPagarID);
                    sql.insertQuery();
                }
                sql.Commit();
            }
            return retorno;
        }
        public IEnumerable<CaixaLancamento> Busca(fmCaiBuscaLancamentos.Filtros f)
        {
            var wherePlanoConta = f.planoConta != null ? "AND cpc.idcaixa_plano_contas = @idcaixa_plano_contas" : "";
            var whereCaixa = f.caixa != null ? "AND c.idcaixa = @idcaixa" : "";
            var whereData = "AND cl.data BETWEEN @datainicial AND @datafinal";
            var caixaLancamentos = new List<CaixaLancamento>();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = $@"SELECT *, c.codigo AS caixa_codigo, cpc.codigo AS cpc_codigo  
                            FROM caixa_lancamento cl 
                            LEFT JOIN caixa_plano_contas cpc ON cl.idcaixa_plano_contas = cpc.idcaixa_plano_contas 
                            LEFT JOIN caixa c ON cl.idcaixa = c.idcaixa 
                            WHERE 1 = 1 
                            {wherePlanoConta} 
                            {whereCaixa} 
                            {whereData} 
                            ORDER BY cl.idcaixa_lancamento";
                if (f.planoConta != null) sql.addParam("@idcaixa_plano_contas", f.planoConta.PlanoContaID);
                if (f.caixa != null) sql.addParam("@idcaixa", f.caixa.CaixaID);
                sql.addParam("@datainicial", f.DataInicial);
                sql.addParam("@datafinal", f.DataFinal);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return caixaLancamentos;
                }
                foreach(var d in data)
                {
                    caixaLancamentos.Add(LeDadosReaderComPlanos(d));
                }
            }
            return caixaLancamentos;
        }
        public IEnumerable<CaixaLancamento> Busca(Caixa caixa)
        {
            var caixaLancamentos = new List<CaixaLancamento>();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM caixa_lancamento
                            WHERE idcaixa = @idcaixa";
                sql.addParam("@idcaixa", caixa.CaixaID);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                foreach (var d in data)
                {
                    var retorno = LeDadosReader(d);
                    retorno.Caixa = caixa;
                    caixaLancamentos.Add(retorno);
                }
            }
            return caixaLancamentos;
        }

        public CaixaLancamento BuscaByDocumento(string documento)
        {
            var caixaLancamentos = new CaixaLancamento();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *, c.codigo AS caixa_codigo, cpc.codigo AS cpc_codigo  
                            FROM caixa_lancamento cl 
                            LEFT JOIN caixa_plano_contas cpc ON cl.idcaixa_plano_contas = cpc.idcaixa_plano_contas 
                            LEFT JOIN caixa c ON cl.idcaixa = c.idcaixa
                            WHERE documento = @documento";
                sql.addParam("@documento", documento);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                caixaLancamentos = LeDadosReaderComPlanos(data);
            }
            return caixaLancamentos;
        }

        public int Sangrar(List<CaixaLancamento> caixaLancamentos, Caixa caixaAtual, Caixa caixaDestino)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                foreach (var lanc in caixaLancamentos)
                {
                    sql.clearParams();
                    sql.Query = @"INSERT INTO caixa_lancamento
                            (data, valor, tipomovimento, tipodocumento, lancamento, documento, idcaixa)
                            VALUES
                            (@data, @valor, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa)";
                    sql.addParam("@data", lanc.Data);
                    sql.addParam("@valor", lanc.Valor);
                    sql.addParam("@tipomovimento", 5);
                    sql.addParam("@tipodocumento", lanc.TipoDocumento);
                    sql.addParam("@lancamento", lanc.Lancamento);
                    sql.addParam("@documento", lanc.Documento);
                    sql.addParam("@idcaixa", caixaAtual.CaixaID);
                    sql.insertQuery();
                    sql.clearParams();
                    sql.Query = @"INSERT INTO caixa_lancamento
                            (data, valor, tipomovimento, tipodocumento, lancamento, documento, idcaixa)
                            VALUES
                            (@data, @valor, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa)";
                    sql.addParam("@data", lanc.Data);
                    sql.addParam("@valor", lanc.Valor);
                    sql.addParam("@tipomovimento", 0);
                    sql.addParam("@tipodocumento", lanc.TipoDocumento);
                    sql.addParam("@lancamento", lanc.Lancamento);
                    sql.addParam("@documento", lanc.Documento);
                    sql.addParam("@idcaixa", caixaDestino.CaixaID);
                    sql.insertQuery();
                    retorno += 1;
                }
            }
            return retorno;
        }
        private CaixaLancamento LeDadosReader(Dictionary<string, object> data)
        {
            var caixaLancamento = new CaixaLancamento();
            caixaLancamento.CaixaLancamentoID = Convert.ToInt32(data["idcaixa_lancamento"]);
            caixaLancamento.Data = (DateTime)data["data"];
            caixaLancamento.Valor = (decimal)data["valor"];
            caixaLancamento.TipoMovimento = Convert.ToInt32(data["tipomovimento"]);
            caixaLancamento.TipoDocumento = Convert.ToInt32(data["tipodocumento"]);
            caixaLancamento.Lancamento = Convert.ToInt32(data["lancamento"]);
            caixaLancamento.Documento = (string)data["documento"];
            return caixaLancamento;
        }
        private CaixaLancamento LeDadosReaderComPlanos(Dictionary<string, object> data)
        {
            var planoConta = new PlanoConta();
            planoConta.PlanoContaID = Convert.ToInt32(data["idcaixa_plano_contas"]);
            planoConta.Codigo = Convert.ToInt32(data["cpc_codigo"]);
            planoConta.Level = Convert.ToInt32(data["level"]);
            planoConta.PaiID = Convert.ToInt32(data["paiid"]);
            planoConta.Descricao = (string)data["descricao"];
            planoConta.CodigoCompleto = (string)data["codigo_completo"];

            var caixa = new Caixa();
            caixa.CaixaID = Convert.ToInt32(data["idcaixa"]);
            caixa.Codigo = Convert.ToInt32(data["caixa_codigo"]);
            caixa.Nome = (string)data["nome"];

            var parcelaCAR = new ParcelaContaReceber();
            var parcelaCAP = new ParcelaContaPagar();
            var notafiscalpropria = new NotaFiscalPropria();
            var notafiscalterceiros = new NotaFiscalTerceiros();

            var caixaLancamento = new CaixaLancamento();
            caixaLancamento.PlanoConta = planoConta;
            caixaLancamento.Caixa = caixa;
            caixaLancamento.CaixaLancamentoID = Convert.ToInt32(data["idcaixa_lancamento"]);
            caixaLancamento.Data = (DateTime)data["data"];
            caixaLancamento.Valor = (decimal)data["valor"];
            caixaLancamento.TipoMovimento = Convert.ToInt32(data["tipomovimento"]);
            caixaLancamento.TipoDocumento = Convert.ToInt32(data["tipodocumento"]);
            caixaLancamento.Lancamento = Convert.ToInt32(data["lancamento"]);
            caixaLancamento.Documento = (string)data["documento"];
            
            
            return caixaLancamento;
        }
    }
}
