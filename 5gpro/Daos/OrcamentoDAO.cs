using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.StaticFiles;
using MySQLConnection;
using System;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class OrcamentoDAO
    {
        public Orcamento BuscaByID(int Codigo)
        {
            var orcamento = new Orcamento();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT p.idpessoa, p.nome, p.fantasia, p.tipo_pessoa, p.rua, p.numero, p.bairro,
                            p.complemento, p.telefone, p.email, p.cpf, p.cnpj, p.cep,
                            n.idnotafiscal, n.data_emissao, n.data_entradasaida, n.valor_total_itens AS valortotalitensnota,
                            n.valor_documento, n.desconto_total_itens AS descontototalitensnota, n.desconto_documento,
                            o.idorcamento, o.data_cadastro, o.data_validade, o.valor_total_itens AS valortotalitensorcamento,
                            o.valor_orcamento, o.desconto_total_itens AS descontototalitensorcamento, o.desconto_orcamento,
                            i.iditem, i.descitem, i.denominacaocompra, i.tipo, i.referencia, i.valorentrada, i.valorsaida, i.estoquenecessario,
                            i.idunimedida, oi.quantidade, oi.valor_unitario, oi.valor_total, oi.desconto_porc, oi.desconto,
                            c.idcidade, c.nome AS cidade_nome, e.idestado, e.nome AS estado_nome, e.uf
                            FROM orcamento o 
                            INNER JOIN pessoa p ON p.idpessoa = o.idpessoa
                            LEFT JOIN cidade c ON c.idcidade = p.idcidade
                            LEFT JOIN estado e ON c.idestado = e.idestado
                            LEFT JOIN notafiscal n ON o.idnotafiscal = n.idnotafiscal
                            LEFT JOIN orcamento_has_item oi ON oi.idorcamento = o.idorcamento
                            LEFT JOIN item i ON oi.iditem = i.iditem
                            WHERE o.idorcamento = @idorcamento";

                sql.addParam("@idorcamento", Codigo);

                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                orcamento = LeDadosReader(data);
            }
            return orcamento;
        }
        public Orcamento Proximo(int Codigo)
        {
            var orcamento = new Orcamento();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT p.idpessoa, p.nome, p.fantasia, p.tipo_pessoa, p.rua, p.numero, p.bairro,
                            p.complemento, p.idcidade, p.telefone, p.email, p.cpf, p.cnpj,
                            n.idnotafiscal, n.data_emissao, n.data_entradasaida, n.valor_total_itens AS valortotalitensnota,
                            n.valor_documento, n.desconto_total_itens AS descontototalitensnota, n.desconto_documento,
                            o.idorcamento, o.data_cadastro, o.data_validade, o.valor_total_itens AS valortotalitensorcamento,
                            o.valor_orcamento, o.desconto_total_itens AS descontototalitensorcamento, o.desconto_orcamento,
                            i.iditem, i.descitem, i.denominacaocompra, i.tipo, i.referencia, i.valorentrada, i.valorsaida, i.estoquenecessario,
                            i.idunimedida, oi.quantidade, oi.valor_unitario, oi.valor_total, oi.desconto_porc, oi.desconto,
                            c.idcidade, c.nome AS cidade_nome, e.idestado, e.nome AS estado_nome, e.uf
                            FROM orcamento o 
                            INNER JOIN pessoa p ON p.idpessoa = o.idpessoa
                            LEFT JOIN cidade c ON c.idcidade = p.idcidade
                            LEFT JOIN estado e ON c.idestado = e.idestado
                            LEFT JOIN notafiscal n ON o.idnotafiscal = n.idnotafiscal
                            LEFT JOIN orcamento_has_item oi ON oi.idorcamento = o.idorcamento
                            LEFT JOIN item i ON oi.iditem = i.iditem
                            WHERE o.idorcamento = (SELECT min(idorcamento) FROM orcamento WHERE idorcamento > @idorcamento)";
                sql.addParam("@idorcamento", Codigo);

                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                orcamento = LeDadosReader(data);
            }
            return orcamento;
        }
        public Orcamento Anterior(int Codigo)
        {
            var orcamento = new Orcamento();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT p.idpessoa, p.nome, p.fantasia, p.tipo_pessoa, p.rua, p.numero, p.bairro,
                            p.complemento, p.idcidade, p.telefone, p.email, p.cpf, p.cnpj,
                            n.idnotafiscal, n.data_emissao, n.data_entradasaida, n.valor_total_itens AS valortotalitensnota,
                            n.valor_documento, n.desconto_total_itens AS descontototalitensnota, n.desconto_documento,
                            o.idorcamento, o.data_cadastro, o.data_validade, o.valor_total_itens AS valortotalitensorcamento,
                            o.valor_orcamento, o.desconto_total_itens AS descontototalitensorcamento, o.desconto_orcamento,
                            i.iditem, i.descitem, i.denominacaocompra, i.tipo, i.referencia, i.valorentrada, i.valorsaida, i.estoquenecessario,
                            i.idunimedida, oi.quantidade, oi.valor_unitario, oi.valor_total, oi.desconto_porc, oi.desconto,
                            c.idcidade, c.nome AS cidade_nome, e.idestado, e.nome AS estado_nome, e.uf
                            FROM orcamento o 
                            INNER JOIN pessoa p ON p.idpessoa = o.idpessoa
                            LEFT JOIN cidade c ON c.idcidade = p.idcidade
                            LEFT JOIN estado e ON c.idestado = e.idestado
                            LEFT JOIN notafiscal n ON o.idnotafiscal = n.idnotafiscal
                            LEFT JOIN orcamento_has_item oi ON oi.idorcamento = o.idorcamento
                            LEFT JOIN item i ON oi.iditem = i.iditem
                            WHERE o.idorcamento = (SELECT max(idorcamento) FROM orcamento WHERE idorcamento < @idorcamento)";
                sql.addParam("@idorcamento", Codigo);

                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                orcamento = LeDadosReader(data);
            }
            return orcamento;
        }
        public List<Orcamento> Busca(fmOrcBuscaOrcamento.Filtros f)
        {
            List<Orcamento> orcamentos = new List<Orcamento>();
            string wherePessoa = f.filtroPessoa != null ? "AND p.idpessoa = @idpessoa" : "";
            string whereCidade = f.filtroCidade != null ? "AND p.idcidade = @idcidade" : "";
            string whereDataCadastro = f.usardataCadastroFiltro ? "AND o.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataValidade = f.usardataValidadeFiltro ? "AND o.data_validade BETWEEN @data_validade_inicial AND @data_validade_final" : "";
            string whereValorTotal = f.usarvalorTotalFiltro ? "AND o.valor_orcamento BETWEEN @valor_total_inicial AND @valor_total_final" : "";

            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT p.idpessoa, p.nome, p.fantasia, p.tipo_pessoa, p.rua, p.numero, p.bairro, p.cep,
                            p.complemento, p.idcidade, p.telefone, p.email,
                            o.idorcamento, o.data_cadastro, o.data_validade, o.valor_total_itens AS valortotalitensorcamento,
                            o.valor_orcamento, o.desconto_total_itens AS descontototalitensorcamento, o.desconto_orcamento
                            FROM orcamento o 
                            INNER JOIN pessoa p ON p.idpessoa = o.idpessoa
                            WHERE 1 = 1 "
                            + whereCidade + " "
                            + whereDataCadastro + " "
                            + whereDataValidade + " "
                            + whereValorTotal + " "
                            + wherePessoa + " " +                         
                            "ORDER BY o.idorcamento";

                if (f.filtroCidade != null) { sql.addParam("@idcidade", f.filtroCidade.CidadeID); }
                if (f.filtroPessoa != null) { sql.addParam("@idpessoa", f.filtroPessoa.PessoaID); }
                sql.addParam("@valor_total_inicial", f.filtroValorTotalInical);
                sql.addParam("@valor_total_final", f.filtroValorTotalFinal);
                sql.addParam("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                sql.addParam("@data_cadastro_final", f.filtroDataCadastroFinal);
                sql.addParam("@data_validade_inicial", f.filtroDataValidadeInicial);
                sql.addParam("@data_validade_final", f.filtroDataValidadeFinal);
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    Pessoa pessoa = null;
                    if (d["idpessoa"] != null)
                    {
                        var cidade = new Cidade();
                        cidade.CidadeID = Convert.ToInt32(d["idcidade"]);

                        pessoa = new Pessoa();
                        pessoa.PessoaID = Convert.ToInt32(d["idpessoa"]);
                        pessoa.Nome = (string)d["nome"];
                        pessoa.Fantasia = (string)d["fantasia"];
                        pessoa.TipoPessoa = (string)d["tipo_pessoa"];
                        pessoa.Rua = (string)d["rua"];
                        pessoa.Numero = (string)d["numero"];
                        pessoa.Bairro = (string)d["bairro"];
                        pessoa.Cep = (string)d["cep"];
                        pessoa.Complemento = (string)d["complemento"];
                        pessoa.Cidade = cidade;
                        pessoa.Telefone = (string)d["telefone"];
                        pessoa.Email = (string)d["email"];
                    }

                    var orcamento = new Orcamento();
                    orcamento.OrcamentoID = Convert.ToInt32(d["idorcamento"]);
                    orcamento.DataCadastro = (DateTime)d["data_cadastro"];
                    orcamento.DataValidade = (DateTime?)d["data_validade"];
                    orcamento.ValorTotalItens = (decimal)d["valortotalitensorcamento"];
                    orcamento.ValorTotalOrcamento = (decimal)d["valor_orcamento"];
                    orcamento.DescontoTotalItens = (decimal)d["descontototalitensorcamento"];
                    orcamento.DescontoOrcamento = (decimal)d["desconto_orcamento"];
                    orcamento.Pessoa = pessoa;
                    orcamentos.Add(orcamento);
                }
            }
            return orcamentos;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT o1.idorcamento + 1 AS proximoid
                            FROM orcamento AS o1
                            LEFT OUTER JOIN orcamento AS o2 ON o1.idorcamento + 1 = o2.idorcamento
                            WHERE o2.idorcamento IS NULL
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
        public int SalvaOuAtualiza(Orcamento orcamento)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO orcamento
                            (idorcamento, data_cadastro, data_validade, valor_total_itens, valor_orcamento, desconto_total_itens, desconto_orcamento, idpessoa)
                            VALUES
                            (@idorcamento, @data_cadastro, @data_validade, @valor_total_itens, @valor_orcamento, @desconto_total_itens, @desconto_orcamento, @idpessoa)
                            ON DUPLICATE KEY UPDATE
                            data_cadastro = @data_cadastro, data_validade = @data_validade, valor_total_itens = @valor_total_itens,
                            valor_orcamento = @valor_orcamento, desconto_total_itens = @desconto_total_itens, desconto_orcamento = @desconto_orcamento,
                            idpessoa = @idpessoa";
                sql.addParam("@idorcamento", orcamento.OrcamentoID);
                sql.addParam("@data_cadastro", orcamento.DataCadastro);
                sql.addParam("@data_validade", orcamento.DataValidade);
                sql.addParam("@valor_total_itens", orcamento.ValorTotalItens);
                sql.addParam("@valor_orcamento", orcamento.ValorTotalOrcamento);
                sql.addParam("@desconto_total_itens", orcamento.DescontoTotalItens);
                sql.addParam("@desconto_orcamento", orcamento.DescontoOrcamento);
                if (orcamento.Pessoa != null) { sql.addParam("@idpessoa", orcamento.Pessoa.PessoaID); }
                retorno = sql.insertQuery();
                if (retorno > 0)
                {
                    sql.Query = @"DELETE FROM orcamento_has_item WHERE idorcamento = @idorcamento";
                    sql.deleteQuery();
                    sql.Query = @"INSERT INTO orcamento_has_item (idorcamento, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                VALUES
                                (@idorcamento, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (var oi in orcamento.OrcamentoItem)
                    {
                        sql.clearParams();
                        sql.addParam("@idorcamento", orcamento.OrcamentoID);
                        sql.addParam("@iditem", oi.Item.ItemID);
                        sql.addParam("@quantidade", oi.Quantidade);
                        sql.addParam("@valor_unitario", oi.ValorUnitario);
                        sql.addParam("@valor_total", oi.ValorTotal);
                        sql.addParam("@desconto_porc", oi.DescontoPorc);
                        sql.addParam("@desconto", oi.Desconto);
                        sql.insertQuery();
                    }
                }
                sql.Commit();
            }
            return retorno;
        }
        public int VincularNotaAoOrcamento(Orcamento orcamento, NotaFiscalPropria notafiscal)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"UPDATE orcamento SET idnotafiscal = @idnotafiscal WHERE idorcamento = @idorcamento";
                sql.addParam("@idorcamento", orcamento.OrcamentoID);
                sql.addParam("@idnotafiscal", notafiscal.NotaFiscalPropriaID);
                retorno = sql.updateQuery();
            }
            return retorno;
        }
        private Orcamento LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }

            var orcamentoItens = new List<OrcamentoItem>();

            Pessoa pessoa = null;
            if (data[0]["idpessoa"] != null)
            {
                var estado = new Estado();
                estado.EstadoID = Convert.ToInt32(data[0]["idestado"]);
                estado.Nome = (string)data[0]["estado_nome"];
                estado.Uf = (string)data[0]["uf"];

                var cidade = new Cidade();
                cidade.CidadeID = Convert.ToInt32(data[0]["idcidade"]);
                cidade.Nome = (string)data[0]["cidade_nome"];
                cidade.Estado = estado;

                pessoa = new Pessoa();
                pessoa.PessoaID = Convert.ToInt32(data[0]["idpessoa"]);
                pessoa.Nome = (string)data[0]["nome"];
                pessoa.Fantasia = (string)data[0]["fantasia"];
                pessoa.TipoPessoa = (string)data[0]["tipo_pessoa"];
                pessoa.Rua = (string)data[0]["rua"];
                pessoa.Numero = (string)data[0]["numero"];
                pessoa.Bairro = (string)data[0]["bairro"];
                pessoa.Cep = (string)data[0]["cep"];
                pessoa.Complemento = (string)data[0]["complemento"];
                pessoa.Cidade = cidade;
                pessoa.Telefone = (string)data[0]["telefone"];
                pessoa.Email = (string)data[0]["email"];
                pessoa.CpfCnpj = (string)data[0]["cpf"] ?? (string)data[0]["cnpj"];
            }


            NotaFiscalPropria notafiscal = null;
            if (data[0]["idnotafiscal"] != null)
            {
                notafiscal = new NotaFiscalPropria();
                notafiscal.NotaFiscalPropriaID = Convert.ToInt32(data[0]["idnotafiscal"]);
                notafiscal.DataEmissao = (DateTime)data[0]["data_emissao"];
                notafiscal.DataEntradaSaida = (DateTime)data[0]["data_entradasaida"];
                notafiscal.ValorTotalItens = (decimal)data[0]["valortotalitensnota"];
                notafiscal.ValorTotalDocumento = (decimal)data[0]["valor_documento"];
                notafiscal.DescontoTotalItens = (decimal)data[0]["descontototalitensnota"];
                notafiscal.DescontoDocumento = (decimal)data[0]["desconto_documento"];
                notafiscal.Pessoa = pessoa;
            }

            var orcamento = new Orcamento();
            orcamento.OrcamentoID = Convert.ToInt32(data[0]["idorcamento"]);
            orcamento.DataCadastro = (DateTime)data[0]["data_cadastro"];
            orcamento.DataValidade = (DateTime?)data[0]["data_validade"];
            orcamento.ValorTotalItens = (decimal)data[0]["valortotalitensorcamento"];
            orcamento.ValorTotalOrcamento = (decimal)data[0]["valor_orcamento"];
            orcamento.DescontoTotalItens = (decimal)data[0]["descontototalitensorcamento"];
            orcamento.DescontoOrcamento = (decimal)data[0]["desconto_orcamento"];
            orcamento.Pessoa = pessoa;
            orcamento.NotaFiscal = notafiscal;

            foreach (var d in data)
            {
                var u = new Unimedida();
                u.UnimedidaID = Convert.ToInt32(d["idunimedida"]);

                var i = new Item();
                i.ItemID = Convert.ToInt32(d["iditem"]);
                i.Descricao = (string)d["descitem"];
                i.DescCompra = (string)d["denominacaocompra"];
                i.TipoItem = (string)d["tipo"];
                i.Referencia = (string)d["referencia"];
                i.ValorEntrada = (decimal)d["valorentrada"];
                i.ValorUnitario = (decimal)d["valorsaida"];
                i.Estoquenecessario = (decimal)d["estoquenecessario"];
                i.Unimedida = u;


                var oi = new OrcamentoItem();
                oi.Quantidade = (decimal)d["quantidade"];
                oi.ValorUnitario = (decimal)d["valor_unitario"];
                oi.ValorTotal = (decimal)d["valor_total"];
                oi.DescontoPorc = (decimal)d["desconto_porc"];
                oi.Desconto = (decimal)d["desconto"];
                oi.Item = i;

                orcamentoItens.Add(oi);
            }
            orcamento.OrcamentoItem = orcamentoItens;
            return orcamento;
        }

    }
}
