using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class ParcelaContaPagarDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();
        

        public IEnumerable<ParcelaContaPagar> Busca(fmCapQuitacaoConta.Filtros f)
        {
            var parcelas = new List<ParcelaContaPagar>();
            string wherePessoa = f.filtroPessoa != null ? "AND cp.idpessoa = @idpessoa" : "";
            string whereConta = f.filtroConta > 0 ? "AND cp.idconta_pagar = @idconta_pagar" : "";
            string whereValorFinal = f.usarvalorContaFiltro ? "AND cp.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final" : "";
            string whereDatCadastro = f.usardataCadastroFiltro ? "AND cp.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataVencimento = f.usardataVencimentoFiltro ? "AND pcp.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final" : "";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM parcela_conta_pagar pcp
                                                     LEFT JOIN conta_pagar cp
                                                     ON pcp.idconta_pagar = cp.idconta_pagar
                                                     WHERE 1 = 1 "
                                                    + wherePessoa + " "
                                                    + whereConta + " "
                                                    + whereValorFinal + " "
                                                    + whereDatCadastro + " "
                                                    + whereDataVencimento +
                                                    @" AND pcp.data_quitacao IS NULL";
                if (f.filtroPessoa != null) { sql.addParam("@idpessoa", f.filtroPessoa.PessoaID); }
                if (f.filtroConta > 0) { sql.addParam("@idconta_pagar", f.filtroConta); }
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

        public ParcelaContaPagar BuscaByID(string codigo)
        {
            ParcelaContaPagar parcelaContaPagar = null;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM parcela_conta_pagar pcp
                              LEFT JOIN conta_pagar cp
                              ON pcp.idconta_pagar = cp.idconta_pagar
                              WHERE idparcela_conta_pagar = @idparcela_conta_pagar";

                sql.addParam("@idparcela_conta_pagar", codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                parcelaContaPagar = LeDadosReader(data)[0];
            }
            return parcelaContaPagar;
        }

        public int QuitarParcelas(List<ParcelaContaPagar> parcelas)
        {
            int retorno = 0;
            string pago = "Pago";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"UPDATE parcela_conta_pagar 
                            SET data_quitacao = @data_quitacao, situacao = @situacao
                            WHERE idparcela_conta_pagar = @idparcela_conta_pagar
                            AND idconta_pagar = @idconta_pagar";
                foreach (var p in parcelas)
                {
                    sql.clearParams();
                    sql.addParam("@data_quitacao", DateTime.Now);
                    sql.addParam("@idparcela_conta_pagar", p.ParcelaContaPagarID);
                    sql.addParam("@idconta_pagar", p.ContaPagarID);
                    sql.addParam("@situacao", pago);
                    sql.updateQuery();
                }
                retorno = 1;
            }
            return retorno;
        }
        private List<ParcelaContaPagar> LeDadosReader(List<Dictionary<string, object>> data)
        {
            var parcelas = new List<ParcelaContaPagar>();
            if (data.Count == 0)
            {
                return parcelas;
            }

            foreach (var d in data)
            {
                var parcela = new ParcelaContaPagar();
                parcela.ParcelaContaPagarID = Convert.ToInt32(d["idparcela_conta_pagar"]);
                
                parcela.Sequencia = Convert.ToInt32(d["sequencia"]);
                parcela.DataVencimento = (DateTime)d["data_vencimento"];
                parcela.Valor = (decimal)d["valor"];
                parcela.Multa = (decimal)d["multa"];
                parcela.Juros = (decimal)d["juros"];
                parcela.Acrescimo = (decimal)d["acrescimo"];
                parcela.Desconto = (decimal)d["desconto"];
                parcela.DataQuitacao = (DateTime?)d["data_quitacao"];
                parcela.ContaPagarID = Convert.ToInt32(d["idconta_pagar"]);
                parcelas.Add(parcela);
            }



            return parcelas;
        }
    }
}
