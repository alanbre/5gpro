using _5gpro.Entities;
using _5gpro.Forms;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    public class ParcelaContaReceberDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public IEnumerable<ParcelaContaReceber> Busca(fmCarQuitacaoConta.Filtros f)
        {
            var parcelas = new List<ParcelaContaReceber>();
            string wherePessoa = f.filtroPessoa != null ? "AND cr.idpessoa = @idpessoa" : "";
            string whereConta = f.filtroConta > 0 ? "AND cr.idconta_receber = @idconta_receber" : "";
            string whereValorFinal = f.usarvalorContaFiltro ? "AND cr.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final" : "";
            string whereDatCadastro = f.usardataCadastroFiltro ? "AND cr.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataVencimento = f.usardataVencimentoFiltro ? "AND pcr.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final" : "";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM parcela_conta_receber pcr
                                                     LEFT JOIN conta_receber cr
                                                     ON pcr.idconta_receber = cr.idconta_receber
                                                     WHERE 1 = 1 "
                                                    + wherePessoa + ""
                                                    + whereConta + ""
                                                    + whereValorFinal + " "
                                                    + whereDatCadastro + " "
                                                    + whereDataVencimento +
                                                    @" AND pcr.data_quitacao IS NULL";
                if (f.filtroPessoa != null) { sql.addParam("@idpessoa", f.filtroPessoa.PessoaID); }
                if (f.filtroConta > 0) { sql.addParam("@idconta_receber", f.filtroConta); }
                if (f.usarvalorContaFiltro)
                {
                    sql.addParam("@valor_conta_inicial", f.filtroValorInicial);
                    sql.addParam("@valor_conta_final", f.filtroValorFinal);
                }
                if (f.usardataCadastroFiltro)
                {
                    sql.addParam("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                    sql.addParam("@data_cadastro_final", f.filtroDataCadastroFinal);
                }
                if (f.usardataVencimentoFiltro)
                {
                    sql.addParam("@data_vencimento_inicial", f.filtroDataVencimentoInicial);
                    sql.addParam("@data_vencimento_final", f.filtroDataVencimentoFinal);
                }
                var data = sql.selectQuery();
                parcelas = LeDadosReader(data);
            }
            return parcelas;
        }
        public int QuitarParcelas(List<ParcelaContaReceber> parcelas)
        {
            int retorno = 0;
            string pago = "Pago";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"UPDATE parcela_conta_receber 
                            SET data_quitacao = @data_quitacao, situacao = @situacao
                            WHERE idparcela_conta_receber = @idparcela_conta_receber
                            AND idconta_receber = @idconta_receber";
                foreach (var p in parcelas)
                {
                    sql.clearParams();
                    sql.addParam("@data_quitacao", DateTime.Now);
                    sql.addParam("@idparcela_conta_receber", p.ParcelaContaReceberID);
                    sql.addParam("@idconta_receber", p.ContaReceberID);
                    sql.addParam("@situacao", pago);
                    sql.updateQuery();
                }
                retorno = 1;
            }
            return retorno;
        }
        private List<ParcelaContaReceber> LeDadosReader(List<Dictionary<string, object>> data)
        {
            var parcelas = new List<ParcelaContaReceber>();
            if (data.Count == 0)
            {
                return parcelas;
            }

            foreach (var d in data)
            {
                var parcela = new ParcelaContaReceber();
                parcela.ParcelaContaReceberID = Convert.ToInt32(d["idparcela_conta_receber"]);
                parcela.Sequencia = Convert.ToInt32(d["sequencia"]);
                parcela.DataVencimento = (DateTime)d["data_vencimento"];
                parcela.Valor = (decimal)d["valor"];
                parcela.Multa = (decimal)d["multa"];
                parcela.Juros = (decimal)d["juros"];
                parcela.Acrescimo = (decimal)d["acrescimo"];
                parcela.Desconto = (decimal)d["desconto"];
                parcela.DataQuitacao = (DateTime?)d["data_quitacao"];
                parcela.ContaReceberID = Convert.ToInt32(d["idconta_receber"]);
                parcelas.Add(parcela);
            }

            return parcelas;
        }

    }
}
