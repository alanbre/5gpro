using _5gpro.Entities;
using _5gpro.Forms;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class ContaPagarDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public int SalvaOuAtualiza(ContaPagar contaPagar)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO conta_pagar
                         (idconta_pagar, data_cadastro, data_conta, valor_original, multa, juros, acrescimo, desconto, valor_final, idpessoa, situacao, descricao)
                          VALUES
                         (@idconta_pagar, @data_cadastro, @data_conta, @valor_original, @multa, @juros, @acrescimo, @desconto, @valor_final, @idpessoa, @situacao, @descricao)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, data_conta = @data_conta, valor_original = @valor_original, multa = @multa,
                          juros = @juros, acrescimo = @acrescimo, desconto = @desconto, valor_final = @valor_final, idpessoa = @idpessoa, situacao = @situacao, descricao = @descricao
                          ";
                sql.addParam("@idconta_pagar", contaPagar.ContaPagarID);
                sql.addParam("@data_cadastro", contaPagar.DataCadastro);
                sql.addParam("@valor_original", contaPagar.ValorOriginal);
                sql.addParam("@multa", contaPagar.Multa);
                sql.addParam("@juros", contaPagar.Juros);
                sql.addParam("@acrescimo", contaPagar.Acrescimo);
                sql.addParam("@desconto", contaPagar.Desconto);
                sql.addParam("@valor_final", contaPagar.ValorFinal);
                sql.addParam("@idpessoa", contaPagar.Pessoa.PessoaID);
                sql.addParam("@situacao", contaPagar.Situacao);
                sql.addParam("data_conta", contaPagar.DataConta);
                sql.addParam("@descricao", contaPagar.Descricao);
                retorno = sql.insertQuery();
                if (retorno > 0)
                {
                    sql.Query = @"DELETE FROM parcela_conta_pagar WHERE idconta_pagar = @idconta_pagar";
                    sql.deleteQuery();
                    sql.Query = @"INSERT INTO parcela_conta_pagar
                                (sequencia, data_vencimento, valor, multa, juros, acrescimo, desconto, valor_final, data_quitacao, idconta_pagar, idformapagamento, situacao, descricao)
                                VALUES
                                (@sequencia, @data_vencimento, @valor, @multa, @juros, @acrescimo, @desconto, @valor_final, @data_quitacao, @idconta_pagar, @idformapagamento, @situacao, @descricao)";
                    foreach (var parcela in contaPagar.Parcelas)
                    {
                        sql.clearParams();
                        sql.addParam("@sequencia", parcela.Sequencia);
                        sql.addParam("@data_vencimento", parcela.DataVencimento);
                        sql.addParam("@valor", parcela.Valor);
                        sql.addParam("@multa", parcela.Multa);
                        sql.addParam("@juros", parcela.Juros);
                        sql.addParam("@acrescimo", parcela.Acrescimo);
                        sql.addParam("@desconto", parcela.Desconto);
                        sql.addParam("@valor_final", parcela.ValorFinal);
                        sql.addParam("@data_quitacao", parcela.DataQuitacao);
                        sql.addParam("@idconta_pagar", contaPagar.ContaPagarID);
                        sql.addParam("@idformapagamento", parcela.FormaPagamento?.FormaPagamentoID ?? null);
                        sql.addParam("@situacao", parcela.Situacao);
                        sql.addParam("@descricao", parcela.Descricao);
                        sql.insertQuery();
                    }
                }
                sql.Commit();
            }
            return retorno;
        }
        public ContaPagar BuscaByID(int codigo)
        {
            var contaPagar = new ContaPagar();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                            p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final, c.descricao AS cpdescricao  
                            FROM conta_pagar AS c
                            LEFT JOIN parcela_conta_pagar AS p 
                            ON  c.idconta_pagar = p.idconta_pagar
                            LEFT JOIN formapagamento f
                            ON f.idformapagamento = p.idformapagamento
                            WHERE c.idconta_pagar = @idconta_pagar";
                sql.addParam("@idconta_pagar", codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                contaPagar = LeDadosReader(data);
            }
            return contaPagar;
        }
        public IEnumerable<ContaPagar> Busca(fmBuscaContaPagar.Filtros f)
        {
            var contaPagars = new List<ContaPagar>();
            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            string whereValorFinal = f.usarvalorContaFiltro ? "AND cp.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final" : "";
            string whereDatCadastro = f.usardataCadastroFiltro ? "AND cp.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataVencimento = f.usardataVencimentoFiltro ? "AND pa.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final" : "";


            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT cp.idconta_pagar, p.idpessoa, p.nome, cp.data_cadastro, cp.data_conta,
                                                    cp.valor_original, cp.multa, cp.juros, cp.acrescimo, cp.desconto, cp.valor_final, cp.situacao, cp.descricao AS cpdescricao
                                                    FROM 
                                                    conta_pagar cp 
                                                    LEFT JOIN pessoa p ON cp.idpessoa = p.idpessoa
                                                    LEFT JOIN parcela_conta_pagar pa ON pa.idconta_pagar = cp.idconta_pagar
                                                    WHERE 1 = 1 "
                                             + wherePessoa + " "
                                             + whereValorFinal + " "
                                             + whereDatCadastro + " "
                                             + whereDataVencimento + " "
                                             + "GROUP BY cp.idconta_pagar";

                if (f.filtroPessoa != null) { sql.addParam("@idpessoa", f.filtroPessoa.PessoaID); }
                sql.addParam("@valor_conta_inicial", f.filtroValorInicial);
                sql.addParam("@valor_conta_final", f.filtroValorFinal);
                sql.addParam("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                sql.addParam("@data_cadastro_final", f.filtroDataCadastroFinal);
                sql.addParam("@data_vencimento_inicial", f.filtroDataVencimentoInicial);
                sql.addParam("@data_vencimento_final", f.filtroDataVencimentoFinal);


                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    var pessoa = new Pessoa();
                    pessoa.PessoaID = Convert.ToInt32(d["idpessoa"]);
                    pessoa.Nome = (string)d["nome"];

                    var contaPagar = new ContaPagar();

                    contaPagar.ContaPagarID = Convert.ToInt32(d["idconta_pagar"]);
                    contaPagar.DataCadastro = (DateTime)d["data_cadastro"];
                    contaPagar.DataConta = (DateTime)d["data_conta"];
                    contaPagar.Descricao = (string)d["cpdescricao"];
                    contaPagar.ValorOriginal = (decimal)d["valor_original"];
                    contaPagar.Multa = (decimal)d["multa"];
                    contaPagar.Juros = (decimal)d["juros"];
                    contaPagar.Acrescimo = (decimal)d["acrescimo"];
                    contaPagar.Desconto = (decimal)d["desconto"];
                    contaPagar.ValorFinal = (decimal)d["valor_final"];
                    contaPagar.Situacao = (string)d["situacao"];

                    contaPagar.Pessoa = pessoa;
                    contaPagars.Add(contaPagar);
                }
            }
            return contaPagars;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT cp1.idconta_pagar + 1 AS proximoid
                            FROM conta_pagar AS cp1
                            LEFT OUTER JOIN conta_pagar AS cp2 ON cp1.idconta_pagar + 1 = cp2.idconta_pagar
                            WHERE cp2.idconta_pagar IS NULL
                            ORDER BY proximoid
                            LIMIT 1";
                var data = sql.selectQueryForSingleRecord();
                if (data != null)
                {
                    proximoid = Convert.ToInt32(data["proximoid"]);
                }
            }
            return proximoid;
        }
        public ContaPagar Proximo(int codigo)
        {
            ContaPagar contaPagar = null;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                            p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final, c.descricao AS cpdescricao  
                            FROM conta_pagar AS c
                            LEFT JOIN parcela_conta_pagar AS p 
                            ON  c.idconta_pagar = p.idconta_pagar
                            LEFT JOIN formapagamento f
                            ON f.idformapagamento = p.idformapagamento
                            WHERE c.idconta_pagar = (SELECT min(idconta_pagar) 
                            FROM conta_pagar 
                            WHERE idconta_pagar > @idconta_pagar)";

                sql.addParam("@idconta_pagar", codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                contaPagar = LeDadosReader(data);
            }
            return contaPagar;
        }
        public ContaPagar Anterior(int codigo)
        {
            ContaPagar contaPagar = null;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                            p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final, c.descricao AS cpdescricao  
                            FROM conta_pagar AS c
                            LEFT JOIN parcela_conta_pagar AS p 
                            ON  c.idconta_pagar = p.idconta_pagar
                            LEFT JOIN formapagamento f
                            ON f.idformapagamento = p.idformapagamento
                            WHERE c.idconta_pagar = (SELECT max(idconta_pagar) 
                            FROM conta_pagar 
                            WHERE idconta_pagar < @idconta_pagar)";

                sql.addParam("@idconta_pagar", codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                contaPagar = LeDadosReader(data);
            }
            return contaPagar;
        }
        private ContaPagar LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }

            List<ParcelaContaPagar> listaparcelas = new List<ParcelaContaPagar>();
            var contaPagar = new ContaPagar();
            contaPagar.ContaPagarID = Convert.ToInt32(data[0]["idconta_pagar"]);
            contaPagar.DataCadastro = (DateTime)data[0]["data_cadastro"];
            contaPagar.DataConta = (DateTime)data[0]["data_conta"];
            contaPagar.Descricao = (string)data[0]["cpdescricao"];
            contaPagar.ValorOriginal = (decimal)data[0]["valor_original"];
            contaPagar.Multa = (decimal)data[0]["multa"];
            contaPagar.Juros = (decimal)data[0]["juros"];
            contaPagar.Acrescimo = (decimal)data[0]["acrescimo"];
            contaPagar.Desconto = (decimal)data[0]["desconto"];
            contaPagar.ValorFinal = (decimal)data[0]["valor_final"];
            contaPagar.Situacao = (string)data[0]["situacao"];
            contaPagar.Pessoa = new Pessoa();
            contaPagar.Pessoa.PessoaID = Convert.ToInt32(data[0]["idpessoa"]);

            foreach (var d in data)
            {
                ParcelaContaPagar parcela = new ParcelaContaPagar();
                FormaPagamento formapagamento = new FormaPagamento();

                if (d["pformapagamento"] != null)
                {
                    formapagamento.FormaPagamentoID = Convert.ToInt32(d["pformapagamento"]);
                    formapagamento.Nome = (string)d["nome"];
                }
                else
                {
                    formapagamento = null;
                }



                parcela.ParcelaContaPagarID = Convert.ToInt32(d["idparcela_conta_pagar"]);
                parcela.DataQuitacao = (DateTime?)d["data_quitacao"];
                parcela.DataVencimento = (DateTime)d["data_vencimento"];
                parcela.Descricao = (string)d["cpdescricao"];
                parcela.Juros = (decimal)d["pjuros"];
                parcela.Acrescimo = (decimal)d["pacrescimo"];
                parcela.Desconto = (decimal)d["pdesconto"];
                parcela.Multa = (decimal)d["pmulta"];
                parcela.Sequencia = Convert.ToInt32(d["sequencia"]);
                parcela.Valor = (decimal)d["valor"];
                parcela.Situacao = (string)d["psituacao"];
                parcela.FormaPagamento = formapagamento;

                listaparcelas.Add(parcela);
            }
            contaPagar.Parcelas = listaparcelas;

            return contaPagar;
        }
    }
}

