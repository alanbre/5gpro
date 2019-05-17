﻿using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Data;

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
                         (idconta_pagar, data_cadastro, data_conta, valor_original, multa, juros, acrescimo, desconto, valor_final, idpessoa, situacao)
                          VALUES
                         (@idconta_pagar, @data_cadastro, @data_conta, @valor_original, @multa, @juros, @acrescimo, @desconto, @valor_final, @idpessoa, @situacao)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, data_conta = @data_conta, valor_original = @valor_original, multa = @multa,
                          juros = @juros, acrescimo = @acrescimo, desconto = @desconto, valor_final = @valor_final, idpessoa = @idpessoa, situacao = @situacao
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
                retorno = sql.insertQuery();
                if (retorno > 0)
                {
                    sql.Query = @"DELETE FROM parcela_conta_pagar WHERE idconta_pagar = @idconta_pagar";
                    sql.deleteQuery();
                    sql.Query = @"INSERT INTO parcela_conta_pagar
                                (sequencia, data_vencimento, valor, multa, juros, acrescimo, desconto, valor_final, data_quitacao, idconta_pagar, idformapagamento, situacao)
                                VALUES
                                (@sequencia, @data_vencimento, @valor, @multa, @juros, @acrescimo, @desconto, @valor_final, @data_quitacao, @idconta_pagar, @idformapagamento, @situacao)";
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
                        sql.insertQuery();
                    }
                }
                sql.Commit();
            }
            return retorno;
        }


        public ContaPagar BuscaById(int codigo)
        {
            ContaPagar contaPagar = null;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *, p.situacao AS psituacao, p.idformapagamento AS pformapagamento,
                            p.multa AS pmulta, p.juros AS pjuros, p.acrescimo AS pacrescimo,
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final  
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
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            Pessoa pessoa = null;
            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            string whereValorFinal = f.usarvalorContaFiltro ? "AND cp.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final" : "";
            string whereDatCadastro = f.usardataCadastroFiltro ? "AND cp.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataVencimento = f.usardataVencimentoFiltro ? "AND pa.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final" : "";


            try
            {
                sql.Query = @"SELECT cp.idconta_pagar, p.idpessoa, p.nome, cp.data_cadastro, cp.data_conta,
                            cp.valor_original, cp.multa, cp.juros, cp.acrescimo, cp.desconto, cp.valor_final, cp.situacao
                            FROM 
                            conta_pagar cp 
                            LEFT JOIN pessoa p ON cp.idpessoa = p.idpessoa
                            LEFT JOIN parcela_conta_pagar pa ON pa.idconta_pagar = cp.idconta_pagar
                            WHERE 1 = 1 "
                            + wherePessoa + " " +
                            @"AND cp.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final
                            AND cp.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final
                            AND pa.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final
                            GROUP BY cp.idconta_pagar";
                if (f.filtroPessoa != null) { sql.addParam("@idpessoa", f.filtroPessoa.PessoaID); }
                sql.addParam("@valor_conta_inicial", f.filtroValorInicial);
                sql.addParam("@valor_conta_final", f.filtroValorFinal);
                sql.addParam("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                sql.addParam("@data_cadastro_final", f.filtroDataCadastroFinal);
                sql.addParam("@data_vencimento_inicial", f.filtroDataVencimentoInicial);
                sql.addParam("@data_vencimento_final", f.filtroDataVencimentoFinal);
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT cp.idconta_pagar, p.idpessoa, p.nome, cp.data_cadastro, cp.data_conta,
                                                    cp.valor_original, cp.multa, cp.juros, cp.acrescimo, cp.desconto, cp.valor_final, cp.situacao
                                                    FROM 
                                                    conta_pagar cp 
                                                    LEFT JOIN pessoa p ON cp.idpessoa = p.idpessoa
                                                    LEFT JOIN parcela_conta_pagar pa ON pa.idconta_pagar = cp.idconta_pagar
                                                    WHERE 1 = 1"
                                             + wherePessoa + " "
                                             + whereValorFinal + " "
                                             + whereDatCadastro + " "
                                             + whereDataVencimento + " "
                                             +"GROUP BY cp.idconta_pagar", Connect.Conexao);

                if (f.filtroPessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", f.filtroPessoa.PessoaID); }

                var data = sql.selectQuery();

                foreach(var d in data)
                {
                    Pessoa pessoa = null;
                    pessoa = new Pessoa
                    {
                        PessoaID = (int)d["idpessoa"],
                        Nome = (string)d["nome"]
                    };

                    var contaPagar = new ContaPagar
                    {
                        ContaPagarID = (int)data[0]["idconta_pagar"],
                        DataCadastro = (DateTime)data[0]["data_cadastro"],
                        DataConta = (DateTime)data[0]["data_conta"],
                        ValorOriginal = (decimal)data[0]["valor_original"],
                        Multa = (decimal)data[0]["multa"],
                        Juros = (decimal)data[0]["juros"],
                        Acrescimo = (decimal)data[0]["acrescimo"],
                        Desconto = (decimal)data[0]["desconto"],
                        ValorFinal = (decimal)data[0]["valor_final"],
                        Situacao = (string)data[0]["situacao"]
                    };
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
                    proximoid = (int)data["proximoid"];
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
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final  
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
                            p.desconto AS pdesconto, p.valor_final AS pvalor_final  
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
            ContaPagar contaPagar = null;
            List<ParcelaContaPagar> listaparcelas = new List<ParcelaContaPagar>();

            contaPagar = new ContaPagar
            {
                ContaPagarID = (int)data[0]["idconta_pagar"],
                DataCadastro = (DateTime)data[0]["data_cadastro"],
                DataConta = (DateTime)data[0]["data_conta"],
                ValorOriginal = (decimal)data[0]["valor_original"],
                Multa = (decimal)data[0]["multa"],
                Juros = (decimal)data[0]["juros"],
                Acrescimo = (decimal)data[0]["acrescimo"],
                Desconto = (decimal)data[0]["desconto"],
                ValorFinal = (decimal)data[0]["valor_final"],
                Situacao = (string)data[0]["situacao"]
            };
            contaPagar.Pessoa = new Pessoa();
            contaPagar.Pessoa.PessoaID = (int)data[0]["idpessoa"];

            foreach (var d in data)
            {
                ParcelaContaPagar parcela = null;
                FormaPagamento formapagamento = null;

                if (d["pformapagamento"] != null)
                {
                    formapagamento = new FormaPagamento
                    {
                        FormaPagamentoID = (int)d["pformapagamento"],
                        Nome = (string)d["nome"]
                    };
                }

                parcela = new ParcelaContaPagar
                {
                    ParcelaContaPagarID = (int)d["idparcela_conta_pagar"],
                    DataQuitacao = (DateTime?)d["data_quitacao"],
                    DataVencimento = (DateTime)d["data_vencimento"],
                    Juros = (decimal)d["pjuros"],
                    Acrescimo = (decimal)d["pacrescimo"],
                    Desconto = (decimal)d["pdesconto"],
                    Multa = (decimal)d["pmulta"],
                    Sequencia = (int)d["sequencia"],
                    Valor = (decimal)d["valor"],
                    Situacao = (string)d["psituacao"],
                    FormaPagamento = formapagamento
                };
                listaparcelas.Add(parcela);
            }
            contaPagar.Parcelas = listaparcelas;

            return contaPagar;
        }

    }
}

