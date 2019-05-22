using _5gpro.Entities;
using System;
using System.Collections.Generic;
using MySQLConnection;

namespace _5gpro.Daos
{
    class NotaFiscalPropriaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT nf1.idnotafiscal + 1 AS proximoid 
                            FROM notafiscal AS nf1 
                            LEFT OUTER JOIN notafiscal AS nf2 ON nf1.idnotafiscal + 1 = nf2.idnotafiscal 
                            WHERE nf2.idnotafiscal IS NULL 
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
        public NotaFiscalPropria BuscaByID(int Codigo)
        {
            var notaFiscalPropria = new NotaFiscalPropria();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * 
                            FROM notafiscal nf
                            LEFT JOIN notafiscal_has_item i
                            ON nf.idnotafiscal = i.idnotafiscal
                            WHERE nf.idnotafiscal = @idnotafiscal";
                sql.addParam("@idnotafiscal", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                notaFiscalPropria = LeDadosReader(data);
            }
            return notaFiscalPropria;
        }
        public NotaFiscalPropria Proximo(int Codigo)
        {
            var notaFiscalPropria = new NotaFiscalPropria();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * 
                            FROM notafiscal nf
                            LEFT JOIN notafiscal_has_item i
                            ON nf.idnotafiscal = i.idnotafiscal
                            WHERE nf.idnotafiscal = (SELECT min(idnotafiscal) FROM notafiscal WHERE idnotafiscal > @idnotafiscal)";
                sql.addParam("@idnotafiscal", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                notaFiscalPropria = LeDadosReader(data);
            }
            return notaFiscalPropria;
        }
        public NotaFiscalPropria Anterior(int Codigo)
        {
            var notaFiscalPropria = new NotaFiscalPropria();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * 
                            FROM notafiscal nf
                            LEFT JOIN notafiscal_has_item i
                            ON nf.idnotafiscal = i.idnotafiscal
                            WHERE nf.idnotafiscal = (SELECT max(idnotafiscal) FROM notafiscal WHERE idnotafiscal < @idnotafiscal)";
                sql.addParam("@idnotafiscal", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                notaFiscalPropria = LeDadosReader(data);
            }
            return notaFiscalPropria;
        }
        public int SalvaOuAtualiza(NotaFiscalPropria notafiscal)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO notafiscal
                         (idnotafiscal, data_emissao, data_entradasaida, tiponf, valor_total_itens, valor_documento, desconto_total_itens, desconto_documento, idpessoa)
                          VALUES
                         (@idnotafiscal, @data_emissao, @data_entradasaida, @tiponf, @valor_total_itens, @valor_documento, @desconto_total_itens, @desconto_documento, @idpessoa)
                          ON DUPLICATE KEY UPDATE
                          data_emissao = @data_emissao, data_entradasaida = @data_entradasaida, valor_total_itens = @valor_total_itens,
                          valor_documento = @valor_documento, desconto_total_itens = @desconto_total_itens, desconto_documento = @desconto_documento,
                          idpessoa = @idpessoa";
                sql.addParam("@idnotafiscal", notafiscal.NotaFiscalPropriaID);
                sql.addParam("@data_emissao", notafiscal.DataEmissao);
                sql.addParam("@data_entradasaida", notafiscal.DataEntradaSaida);
                sql.addParam("@tiponf", "S");
                sql.addParam("@valor_total_itens", notafiscal.ValorTotalItens);
                sql.addParam("@valor_documento", notafiscal.ValorTotalDocumento);
                sql.addParam("@desconto_total_itens", notafiscal.DescontoTotalItens);
                sql.addParam("@desconto_documento", notafiscal.DescontoDocumento);
                sql.addParam("@idpessoa", notafiscal.Pessoa?.PessoaID ?? null);
                retorno = sql.insertQuery();
                if (retorno > 0)
                {
                    sql.Query = @"DELETE FROM notafiscal_has_item WHERE idnotafiscal = @idnotafiscal";
                    sql.deleteQuery();
                    sql.Query = @"INSERT INTO notafiscal_has_item (idnotafiscal, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                            VALUES
                                            (@idnotafiscal, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (var i in notafiscal.NotaFiscalPropriaItem)
                    {
                        sql.clearParams();
                        sql.addParam("@idnotafiscal", notafiscal.NotaFiscalPropriaID);
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
        public void LimpaRegistrosEstoque(NotaFiscalPropria nota)
        {
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"DELETE FROM registro_estoque 
                            WHERE documento = @documento
                            AND idpessoa = @idpessoa
                            AND tipomovimentacao = 'S'";
                sql.addParam("@documento", nota.NotaFiscalPropriaID.ToString());
                sql.addParam("@idpessoa", nota.Pessoa?.PessoaID ?? null);
                sql.deleteQuery();
            }
        }
        public int MovimentaEstoque(NotaFiscalPropria nota)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                foreach (var i in nota.NotaFiscalPropriaItem)
                {
                    sql.Query = @"INSERT INTO registro_estoque 
                            (tipomovimentacao, data, documento, iditem, quantidade, idpessoa)
                            VALUES
                            (@tipomovimentacao, @data, @documento, @iditem, @quantidade, @idpessoa)";
                    sql.clearParams();
                    sql.addParam("@tipomovimentacao", "S");
                    sql.addParam("@data", nota.DataEntradaSaida);
                    sql.addParam("@documento", nota.NotaFiscalPropriaID.ToString());
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
        private NotaFiscalPropria LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }
            var notaFiscalItens = new List<NotaFiscalPropriaItem>();

            var notaFiscalPropria = new NotaFiscalPropria();
            notaFiscalPropria.NotaFiscalPropriaID = Convert.ToInt32(data[0]["idnotafiscal"]);
            notaFiscalPropria.DataEmissao =(DateTime) data[0]["data_emissao"];
            notaFiscalPropria.DataEntradaSaida = (DateTime)data[0]["data_entradasaida"];
            notaFiscalPropria.ValorTotalItens = (decimal)data[0]["valor_total_itens"];
            notaFiscalPropria.ValorTotalDocumento = (decimal)data[0]["valor_documento"];
            notaFiscalPropria.DescontoTotalItens = (decimal)data[0]["desconto_total_itens"];
            notaFiscalPropria.DescontoDocumento = (decimal)data[0]["desconto_documento"];
            var pessoa = new Pessoa();
            pessoa.PessoaID = Convert.ToInt32(data[0]["idpessoa"]);
            notaFiscalPropria.Pessoa = pessoa;

            foreach (var d in data)
            {
                var i = new Item();
                i.ItemID = Convert.ToInt32(d["iditem"]);
                i.Descricao = (string)d["descitem"];
                i.DescCompra = (string)d["denominacaocompra"];
                i.TipoItem = (string)d["tipo"];
                i.Referencia = (string)d["referencia"];
                i.ValorEntrada = (decimal)d["valorentrada"];
                i.ValorSaida = (decimal)d["valorsaida"];
                i.Estoquenecessario = (decimal)d["estoquenecessario"];

                var nfi = new NotaFiscalPropriaItem();
                nfi.Quantidade = (decimal)d["quantidade"];
                nfi.ValorUnitario = (decimal)d["valor_unitario"];
                nfi.ValorTotal = (decimal)d["valor_total"];
                nfi.DescontoPorc = (decimal)d["desconto_porc"];
                nfi.Desconto = (decimal)d["desconto"];
                nfi.Item = i;
                notaFiscalItens.Add(nfi);
            }
            notaFiscalPropria.NotaFiscalPropriaItem = notaFiscalItens;

            return notaFiscalPropria;
        }
    }
}