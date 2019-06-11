using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            (data, valor, valorpago, troco, tipo, lancamento, documento, idcaixa)
                            VALUES
                            (@data, @valor, @valorpago, @troco, @tipo, @lancamento, @documento, @idcaixa)";
                sql.addParam("@data", caixaLancamento.Data);
                sql.addParam("@valor", caixaLancamento.Valor);
                sql.addParam("@valorpago", caixaLancamento.ValorPago);
                sql.addParam("@troco", caixaLancamento.Troco);
                sql.addParam("@tipo", caixaLancamento.Tipo);
                sql.addParam("@lancamento", caixaLancamento.Lancamento);
                sql.addParam("@documento", caixaLancamento.Documento);
                sql.addParam("@idcaixa", caixaLancamento.Caixa.CaixaID);
                retorno = sql.insertQuery();
            }
            return retorno;
        }
    }
}
