using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class NotaFiscalTerceirosDAO
    {
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT nf1.idnota_fiscal_terceiros + 1 AS proximoid 
                            FROM nota_fiscal_terceiros AS nf1 
                            LEFT OUTER JOIN nota_fiscal_terceiros AS nf2 ON nf1.idnota_fiscal_terceiros + 1 = nf2.idnota_fiscal_terceiros 
                            WHERE nf2.idnota_fiscal_terceiros IS NULL 
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
        public NotaFiscalTerceiros BuscaByID(int Codigo)
        {
            var notaFiscalTerceiros = new NotaFiscalTerceiros();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, nftitem.quantidade AS quantidadenfti, i.quantidade AS estoque
                            FROM nota_fiscal_terceiros nft
                            LEFT JOIN nota_fiscal_terceiros_has_item nftitem
                            ON nft.idnota_fiscal_terceiros = nftitem.idnota_fiscal_terceiros
                            INNER JOIN item i ON i.iditem = nftitem.iditem
                            WHERE nft.idnota_fiscal_terceiros = @idnota_fiscal_terceiros";

                sql.addParam("@idnota_fiscal_terceiros", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                notaFiscalTerceiros = LeDadosReader(data);
            }
            return notaFiscalTerceiros;
        }
        public IEnumerable<NotaFiscalTerceiros> Busca(fmEntBuscaNotaFiscalTerceiros.Filtros f)
        {
            var notasFiscais = new List<NotaFiscalTerceiros>();
            var wherePessoa = f.Pessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            var whereCidade = f.Cidade != null ? "AND p.idcidade = @idcidade" : "";
            string whereValorTotal = f.usarvalorTotalFiltro ? "AND nft.valor_documento BETWEEN @valor_documento_inicial AND @valor_documento_final" : "";
            string whereDataEmissao = f.usardataEmissaoFiltro ? "AND nft.data_emissao BETWEEN @data_emissao_inicial AND @data_emissao_final" : "";
            string whereDataEntrada = f.usardataEntradaFiltro ? "AND nft.data_entradasaida BETWEEN @data_entradasaida_inicial AND @data_entradasaida_final" : "";


            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT nft.idnota_fiscal_terceiros, p.idpessoa, p.nome, nft.data_emissao, nft.data_entradasaida, nft.valor_documento
                            FROM
                            nota_fiscal_terceiros nft
                            LEFT JOIN pessoa p ON nft.idpessoa = p.idpessoa
                            WHERE 1=1 "
                            + wherePessoa + " "
                            + whereCidade + " "
                            + whereValorTotal + " "
                            + whereDataEmissao + " "
                            + whereDataEntrada + " "
                            + "GROUP BY nft.idnota_fiscal_terceiros";

                if (f.Pessoa != null) { sql.addParam("@idpessoa", f.Pessoa.PessoaID); }
                if (f.Cidade != null) { sql.addParam("@idcidade", f.Cidade.CidadeID); }

                sql.addParam("@valor_documento_inicial", f.ValorInicial);
                sql.addParam("@valor_documento_final", f.ValorFinal);
                sql.addParam("@data_emissao_inicial", f.DataEmissaoInicial);
                sql.addParam("@data_emissao_final", f.DataEmissaoFinal);
                sql.addParam("@data_entradasaida_inicial", f.DataEntradaInicial);
                sql.addParam("@data_entradasaida_final", f.DataEntradaFinal);
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var pessoa = new Pessoa();
                    pessoa.PessoaID = Convert.ToInt32(d["idpessoa"]);
                    pessoa.Nome = (string)d["nome"];

                    var notaTerceiros = new NotaFiscalTerceiros();
                    notaTerceiros.NotaFiscalTerceirosID = Convert.ToInt32(d["idnota_fiscal_terceiros"]);
                    notaTerceiros.DataEmissao = (DateTime)d["data_emissao"];
                    notaTerceiros.DataEntradaSaida = (DateTime)d["data_entradasaida"];
                    notaTerceiros.ValorTotalDocumento = (decimal)d["valor_documento"];
                    notaTerceiros.Pessoa = pessoa;
                    notasFiscais.Add(notaTerceiros);
                }
            }
            return notasFiscais;
        }
        public List<fmEntBuscaNotaFiscalTerceiros.row> BuscaParaRelatorio(fmEntBuscaNotaFiscalTerceiros.Filtros f)
        {
            var result = new List<fmEntBuscaNotaFiscalTerceiros.row>();
            var wherePessoa = f.Pessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            var whereCidade = f.Cidade != null ? "AND p.idcidade = @idcidade" : "";
            string whereValorTotal = f.usarvalorTotalFiltro ? "AND nft.valor_documento BETWEEN @valor_documento_inicial AND @valor_documento_final" : "";
            string whereDataEmissao = f.usardataEmissaoFiltro ? "AND nft.data_emissao BETWEEN @data_emissao_inicial AND @data_emissao_final" : "";
            string whereDataEntrada = f.usardataEntradaFiltro ? "AND nft.data_entradasaida BETWEEN @data_entradasaida_inicial AND @data_entradasaida_final" : "";
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = $@"SELECT DATE(nft.data_entradasaida) AS data,
                            i.codigointerno, i.descitem, i.referencia,
                            SUM(nftitem.quantidade) as qtd, i.valorsaida, SUM(nftitem.valor_total) AS total
                            FROM nota_fiscal_terceiros nft
                            LEFT JOIN pessoa p
                            ON p.idpessoa = nft.idpessoa
                            LEFT JOIN nota_fiscal_terceiros_has_item nftitem
                            ON nft.idnota_fiscal_terceiros = nftitem.idnota_fiscal_terceiros
                            LEFT JOIN item i ON i.iditem = nftitem.iditem
                            WHERE 1 = 1
                            { wherePessoa } 
                            { whereCidade } 
                            { whereValorTotal } 
                            { whereDataEmissao } 
                            { whereDataEntrada } 
                            GROUP BY DATE(nft.data_entradasaida), i.codigointerno, i.descitem, i.referencia, i.valorsaida
                            ORDER BY 1";

                if (f.Pessoa != null) { sql.addParam("@idpessoa", f.Pessoa.PessoaID); }
                if (f.Cidade != null) { sql.addParam("@idcidade", f.Cidade.CidadeID); }

                sql.addParam("@valor_documento_inicial", f.ValorInicial);
                sql.addParam("@valor_documento_final", f.ValorFinal);
                sql.addParam("@data_emissao_inicial", f.DataEmissaoInicial);
                sql.addParam("@data_emissao_final", f.DataEmissaoFinal);
                sql.addParam("@data_entradasaida_inicial", f.DataEntradaInicial);
                sql.addParam("@data_entradasaida_final", f.DataEntradaFinal);
                var data = sql.selectQuery();
                if (data != null)
                {
                    foreach(var r in data)
                    {
                        var row = new fmEntBuscaNotaFiscalTerceiros.row();
                        row.data = (DateTime)r["data"];
                        row.codigo = (string)r["codigointerno"];
                        row.item = (string)r["descitem"];
                        row.tamanho = (string)r["referencia"];
                        row.quantidade = (decimal)r["qtd"];
                        row.valorunit = (decimal)r["valorsaida"];
                        row.estoque = (decimal)r["total"];
                        result.Add(row);
                    }
                }

            }
            return result;
        }
        public NotaFiscalTerceiros Proximo(int Codigo)
        {
            var notaFiscalTerceiros = new NotaFiscalTerceiros();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, nftitem.quantidade AS quantidadenfti, i.quantidade AS estoque
                            FROM nota_fiscal_terceiros nft
                            LEFT JOIN nota_fiscal_terceiros_has_item nftitem
                            ON nft.idnota_fiscal_terceiros = nftitem.idnota_fiscal_terceiros
                            INNER JOIN item i ON i.iditem = nftitem.iditem
                            WHERE nft.idnota_fiscal_terceiros = (SELECT min(idnota_fiscal_terceiros) FROM nota_fiscal_terceiros WHERE idnota_fiscal_terceiros > @idnota_fiscal_terceiros)";

                sql.addParam("@idnota_fiscal_terceiros", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                notaFiscalTerceiros = LeDadosReader(data);
            }
            return notaFiscalTerceiros;
        }
        public NotaFiscalTerceiros Anterior(int Codigo)
        {
            var notaFiscalTerceiros = new NotaFiscalTerceiros();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT *, nftitem.quantidade AS quantidadenfti, i.quantidade AS estoque 
                            FROM nota_fiscal_terceiros nft
                            LEFT JOIN nota_fiscal_terceiros_has_item nftitem
                            ON nft.idnota_fiscal_terceiros = nftitem.idnota_fiscal_terceiros
                            INNER JOIN item i ON i.iditem = nftitem.iditem
                            WHERE nft.idnota_fiscal_terceiros = (SELECT max(idnota_fiscal_terceiros) FROM nota_fiscal_terceiros WHERE idnota_fiscal_terceiros < @idnota_fiscal_terceiros)";

                sql.addParam("@idnota_fiscal_terceiros", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                notaFiscalTerceiros = LeDadosReader(data);
            }
            return notaFiscalTerceiros;
        }
        public int SalvarOuAtualizar(NotaFiscalTerceiros notafiscal)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO nota_fiscal_terceiros
                         (idnota_fiscal_terceiros, data_emissao, data_entradasaida, tiponf, valor_total_itens, valor_documento, desconto_total_itens, desconto_documento, idpessoa, descricao)
                          VALUES
                         (@idnota_fiscal_terceiros, @data_emissao, @data_entradasaida, @tiponf, @valor_total_itens, @valor_documento, @desconto_total_itens, @desconto_documento, @idpessoa, @descricao)
                          ON DUPLICATE KEY UPDATE
                          data_emissao = @data_emissao, data_entradasaida = @data_entradasaida, valor_total_itens = @valor_total_itens,
                          valor_documento = @valor_documento, desconto_total_itens = @desconto_total_itens, desconto_documento = @desconto_documento,
                          idpessoa = @idpessoa, descricao = @descricao";
                sql.addParam("@idnota_fiscal_terceiros", notafiscal.NotaFiscalTerceirosID);
                sql.addParam("@data_emissao", notafiscal.DataEmissao);
                sql.addParam("@data_entradasaida", notafiscal.DataEntradaSaida);
                sql.addParam("@tiponf", "S");
                sql.addParam("@valor_total_itens", notafiscal.ValorTotalItens);
                sql.addParam("@valor_documento", notafiscal.ValorTotalDocumento);
                sql.addParam("@desconto_total_itens", notafiscal.DescontoTotalItens);
                sql.addParam("@desconto_documento", notafiscal.DescontoDocumento);
                sql.addParam("@descricao", notafiscal.Descricao);
                if (notafiscal.Pessoa != null) { sql.addParam("@idpessoa", notafiscal.Pessoa.PessoaID); }
                retorno = sql.insertQuery();
                if (retorno > 0)
                {
                    sql.Query = @"DELETE FROM nota_fiscal_terceiros_has_item WHERE idnota_fiscal_terceiros = @idnota_fiscal_terceiros";
                    sql.deleteQuery();
                    sql.Query = @"INSERT INTO nota_fiscal_terceiros_has_item (idnota_fiscal_terceiros, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                VALUES
                                (@idnota_fiscal_terceiros, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (var i in notafiscal.NotaFiscalTerceirosItem)
                    {
                        sql.clearParams();
                        sql.addParam("@idnota_fiscal_terceiros", notafiscal.NotaFiscalTerceirosID);
                        sql.addParam("@iditem", i.Item.ItemID);
                        sql.addParam("@quantidade", i.Quantidade);
                        sql.addParam("@valor_unitario", i.ValorUnitario);
                        sql.addParam("@valor_total", i.ValorTotal);
                        sql.addParam("@desconto_porc", i.DescontoPorc);
                        sql.addParam("@desconto", i.Desconto);
                        sql.insertQuery();
                    }
                }
                sql.Commit();
            }
            return retorno;
        }
        public void LimpaRegistrosEstoque(NotaFiscalTerceiros nota)
        {
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"DELETE FROM registro_estoque 
                            WHERE documento = @documento
                            AND idpessoa = @idpessoa
                            AND tipomovimentacao = 'E'";
                sql.addParam("@documento", nota.NotaFiscalTerceirosID.ToString());
                sql.addParam("@idpessoa", nota.Pessoa?.PessoaID ?? null);
                sql.deleteQuery();
            }
        }
        public int MovimentaEstoque(NotaFiscalTerceiros nota)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.beginTransaction();
                foreach (var i in nota.NotaFiscalTerceirosItem)
                {
                    sql.Query = @"INSERT INTO registro_estoque 
                                (tipomovimentacao, data, documento, iditem, quantidade, idpessoa)
                                VALUES
                                (@tipomovimentacao, @data, @documento, @iditem, @quantidade, @idpessoa)";
                    sql.clearParams();
                    sql.addParam("@tipomovimentacao", "E");
                    sql.addParam("@data", nota.DataEntradaSaida);
                    sql.addParam("@documento", nota.NotaFiscalTerceirosID.ToString());
                    sql.addParam("@iditem", i.Item.ItemID);
                    sql.addParam("@quantidade", i.Quantidade);
                    sql.addParam("@idpessoa", nota.Pessoa?.PessoaID ?? null);
                    retorno = sql.insertQuery();

                    sql.clearParams();

                    sql.Query = @"UPDATE item SET quantidade = 
                                (SELECT COALESCE(SUM(quantidade), 0) FROM registro_estoque WHERE iditem = @iditem AND tipomovimentacao = 'E')
                                -
                                (SELECT COALESCE(SUM(quantidade), 0) FROM registro_estoque WHERE iditem = @iditem AND tipomovimentacao = 'S')
                                WHERE iditem = @iditem";
                    sql.addParam("@quantidade_atualizada", i.Item.Quantidade - i.Quantidade);
                    sql.addParam("@iditem", i.Item.ItemID);
                    sql.updateQuery();
                }
                sql.Commit();
            }
            return retorno;
        }
        public void LimpaRegistrosCaixa(NotaFiscalTerceiros nota)
        {
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.addParam("@documento", nota.NotaFiscalTerceirosID.ToString());

                sql.Query = @"DELETE FROM caixa_lancamento_ent 
                              WHERE idnota_fiscal_terceiros = @documento";
                sql.deleteQuery();

                sql.Query = @"DELETE FROM caixa_lancamento 
                            WHERE documento = @documento";
                sql.deleteQuery();
            }
        }
        public int MovimentaCaixa(NotaFiscalTerceiros nota)
        {
            int retorno = 0;

            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {

                sql.beginTransaction();
                sql.Query = @"INSERT INTO caixa_lancamento
                            (data, valor, tipomovimento, tipodocumento, lancamento, documento, idcaixa, idcaixa_plano_contas)
                            VALUES
                            (@data, @valor, @tipomovimento, @tipodocumento, @lancamento, @documento, @idcaixa, @idcaixa_plano_contas)";
                sql.addParam("@data", nota.DataEntradaSaida);
                sql.addParam("@valor", nota.ValorTotalDocumento);
                sql.addParam("@tipomovimento", 1);
                sql.addParam("@tipodocumento", 3);
                sql.addParam("@lancamento", 1);
                sql.addParam("@documento", nota.NotaFiscalTerceirosID);
                sql.addParam("@idcaixa", nota.Caixa.CaixaID);
                sql.addParam("@idcaixa_plano_contas", nota.PlanoDeConta.PlanoContaID);
                retorno = sql.insertQuery();


                if (retorno > 0)
                {
                    sql.Query = "SELECT LAST_INSERT_ID() AS idcaixalancamento;";
                    var data = sql.selectQueryForSingleRecord();
                    int idcaixalancamento = Convert.ToInt32(data["idcaixalancamento"]);

                    sql.Query = @"DELETE FROM caixa_lancamento_ent 
                                  WHERE idnota_fiscal_terceiros = @idnota_fiscal_terceiros
                                  AND idcaixa_lancamento = @idcaixa_lancamento";

                    sql.clearParams();
                    sql.addParam("@idcaixa_lancamento", idcaixalancamento);
                    sql.addParam("@idnota_fiscal_terceiros", nota.NotaFiscalTerceirosID);

                    sql.deleteQuery();

                    sql.Query = @"INSERT INTO caixa_lancamento_ent (idcaixa_lancamento, idnota_fiscal_terceiros)
                                VALUES
                                (@idcaixa_lancamento, @idnota_fiscal_terceiros)";

                    sql.clearParams();
                    sql.addParam("@idcaixa_lancamento", idcaixalancamento);
                    sql.addParam("@idnota_fiscal_terceiros", nota.NotaFiscalTerceirosID);
                    sql.insertQuery();

                }

                sql.Commit();
            }

            return retorno;
        }
        private NotaFiscalTerceiros LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }
            var notaFiscalItens = new List<NotaFiscalTerceirosItem>();

            var notaFiscalTerceiros = new NotaFiscalTerceiros();
            notaFiscalTerceiros.NotaFiscalTerceirosID = Convert.ToInt32(data[0]["idnota_fiscal_terceiros"]);
            notaFiscalTerceiros.Descricao = (string)data[0]["descricao"];
            notaFiscalTerceiros.DataEmissao = (DateTime)data[0]["data_emissao"];
            notaFiscalTerceiros.DataEntradaSaida = (DateTime)data[0]["data_entradasaida"];
            notaFiscalTerceiros.ValorTotalItens = (decimal)data[0]["valor_total_itens"];
            notaFiscalTerceiros.ValorTotalDocumento = (decimal)data[0]["valor_documento"];
            notaFiscalTerceiros.DescontoTotalItens = (decimal)data[0]["desconto_total_itens"];
            notaFiscalTerceiros.DescontoDocumento = (decimal)data[0]["desconto_documento"];
            var pessoa = new Pessoa();
            pessoa.PessoaID = Convert.ToInt32(data[0]["idpessoa"]);
            notaFiscalTerceiros.Pessoa = pessoa;

            foreach (var d in data)
            {
                var i = new Item();
                i.ItemID = Convert.ToInt32(d["iditem"]);
                i.Descricao = (string)d["descitem"];
                i.DescCompra = (string)d["denominacaocompra"];
                i.TipoItem = (string)d["tipo"];
                i.Referencia = (string)d["referencia"];
                i.ValorEntrada = (decimal)d["valorentrada"];
                i.ValorUnitario = (decimal)d["valorsaida"];
                i.Estoquenecessario = (decimal)d["estoquenecessario"];
                i.CodigoInterno = (string)d["codigointerno"];
                i.Quantidade = (decimal)d["estoque"];

                var nfi = new NotaFiscalTerceirosItem();
                nfi.Quantidade = (decimal)d["quantidadenfti"];
                nfi.ValorUnitario = (decimal)d["valor_unitario"];
                nfi.ValorTotal = (decimal)d["valor_total"];
                nfi.DescontoPorc = (decimal)d["desconto_porc"];
                nfi.Desconto = (decimal)d["desconto"];
                nfi.Item = i;
                notaFiscalItens.Add(nfi);
            }

            notaFiscalTerceiros.NotaFiscalTerceirosItem = notaFiscalItens;

            return notaFiscalTerceiros;
        }
    }
}
