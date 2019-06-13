using _5gpro.Entities;
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
                            (data, valor, valorpago, troco, tipomovimento, tipodocumento, lancamento, documento, idcaixa)
                            VALUES
                            (@data, @valor, @valorpago, @troco, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa)";
                sql.addParam("@data", caixaLancamento.Data);
                sql.addParam("@valor", caixaLancamento.Valor);
                sql.addParam("@valorpago", caixaLancamento.ValorPago);
                sql.addParam("@troco", caixaLancamento.Troco);
                sql.addParam("@tipomovimento", caixaLancamento.TipoMovimento);
                sql.addParam("@tipodocumento", caixaLancamento.TipoDocumento);
                sql.addParam("@lancamento", caixaLancamento.Lancamento);
                sql.addParam("@documento", caixaLancamento.Documento);
                sql.addParam("@idcaixa", caixaLancamento.Caixa.CaixaID);
                retorno = sql.insertQuery();
            }
            return retorno;
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
<<<<<<< HEAD
        
=======
        public int Sangrar(List<CaixaLancamento> caixaLancamentos, Caixa caixaAtual, Caixa caixaDestino)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                foreach (var lanc in caixaLancamentos)
                {
                    sql.clearParams();
                    sql.Query = @"INSERT INTO caixa_lancamento
                            (data, valor, valorpago, troco, tipomovimento, tipodocumento, lancamento, documento, idcaixa)
                            VALUES
                            (@data, @valor, @valorpago, @troco, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa)";
                    sql.addParam("@data", lanc.Data);
                    sql.addParam("@valor", lanc.Valor);
                    sql.addParam("@valorpago", lanc.ValorPago);
                    sql.addParam("@troco", lanc.Troco);
                    sql.addParam("@tipomovimento", 5);
                    sql.addParam("@tipodocumento", lanc.TipoDocumento);
                    sql.addParam("@lancamento", lanc.Lancamento);
                    sql.addParam("@documento", lanc.Documento);
                    sql.addParam("@idcaixa", caixaAtual.CaixaID);
                    sql.insertQuery();
                    sql.clearParams();
                    sql.Query = @"INSERT INTO caixa_lancamento
                            (data, valor, valorpago, troco, tipomovimento, tipodocumento, lancamento, documento, idcaixa)
                            VALUES
                            (@data, @valor, @valorpago, @troco, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa)";
                    sql.addParam("@data", lanc.Data);
                    sql.addParam("@valor", lanc.Valor);
                    sql.addParam("@valorpago", lanc.ValorPago);
                    sql.addParam("@troco", lanc.Troco);
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
>>>>>>> dce4fc6b089a63df1de70af3f17bd01916ccc0b9
        private CaixaLancamento LeDadosReader(Dictionary<string, object> data)
        {
            var caixaLancamento = new CaixaLancamento();
            caixaLancamento.CaixaLancamentoID = Convert.ToInt32(data["idcaixa_lancamento"]);
            caixaLancamento.Data = (DateTime)data["data"];
            caixaLancamento.Valor = (decimal)data["valor"];
            caixaLancamento.ValorPago = (decimal)data["valorpago"];
            caixaLancamento.Troco = (decimal)data["troco"];
            caixaLancamento.TipoMovimento = Convert.ToInt32(data["tipomovimento"]);
            caixaLancamento.TipoDocumento = Convert.ToInt32(data["tipodocumento"]);
            caixaLancamento.Lancamento = Convert.ToInt32(data["lancamento"]);
            caixaLancamento.Documento = (string)data["documento"];
            return caixaLancamento;
        }
    }
}
