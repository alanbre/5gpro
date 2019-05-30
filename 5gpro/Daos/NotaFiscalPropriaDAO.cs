using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using MySQLConnection;
using _5gpro.Reports;

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
                sql.Query = @"SELECT *, nfhi.quantidade AS quantidadenfhi
                            FROM notafiscal nf
                            LEFT JOIN notafiscal_has_item nfhi
                            ON nf.idnotafiscal = nfhi.idnotafiscal
                            INNER JOIN item i ON i.iditem = nfhi.iditem
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
                sql.Query = @"SELECT *, nfhi.quantidade AS quantidadenfhi
                            FROM notafiscal nf
                            LEFT JOIN notafiscal_has_item nfhi
                            ON nf.idnotafiscal = nfhi.idnotafiscal
                            INNER JOIN item i ON i.iditem = nfhi.iditem
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
                sql.Query = @"SELECT *, nfhi.quantidade AS quantidadenfhi
                            FROM notafiscal nf
                            LEFT JOIN notafiscal_has_item nfhi
                            ON nf.idnotafiscal = nfhi.idnotafiscal
                            INNER JOIN item i ON i.iditem = nfhi.iditem
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
        public IEnumerable<NotaFiscalPropria> BuscaParaRelatorio(fmRltNotasSaida.Filtros f)
        {
            var notaFiscalProprias = new List<NotaFiscalPropria>();
            var wherePessoa = f.usaFiltroClientes ? " AND nf.idpessoa BETWEEN @idpessoa_inicial AND @idpessoa_final" : "";
            var whereCidade = f.usaFiltroCidades ? " AND p.idcidade BETWEEN @idcidade_inicial AND @idcidade_final" : "";
            var whereDataEmissao = f.usaFiltroDataEmissao ? " AND nf.data_emissao BETWEEN @data_emissao_inicial AND @data_emissao_final" : "";
            var whereDataSaida = f.usaFiltroDataSaida ? " AND nf.data_entradasaida BETWEEN @data_saida_inicial AND @data_saida_final" : "";
            var whereValor = f.usaFiltroValor ? " AND nf.valor_documento BETWEEN @valor_inicial AND @valor_final" : "";

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = $@"SELECT 
                            nf.idnotafiscal AS nf_idnotafiscal, nf.data_emissao AS nf_data_emissao, nf.data_entradasaida AS nf_entradasaida, nf.tiponf AS nf_tiponf, nf.valor_total_itens AS nf_valor_total_itens, nf.valor_documento AS nf_valor_documento,  nf.desconto_total_itens AS nf_desconto_total_itens, nf.desconto_documento AS nf_desconto_documento, 
                            p.idpessoa AS p_idpessoa, p.nome AS p_nome, p.fantasia AS p_fantasia, p.rua AS p_rua, p.numero AS p_numero, p.bairro AS p_bairro, p.complemento AS p_complemento, p.cpf AS p_cpf, p.cnpj AS p_cnpj, p.endereco AS p_endereco, p.telefone AS p_telefone, p.email AS p_email,
                            c.idcidade AS c_idcidade, c.nome AS c_nome,
                            sbp.idsubgrupopessoa AS sbp_idsubgrupopessoa, sbp.nome AS sbp_nome,
                            gp.idgrupopessoa AS gp_idgrupopessoa, gp.nome AS gp_nome,
                            nfhi.quantidade AS nfhi_quantidade, nfhi.valor_unitario AS nfhi_valorunitario, nfhi.valor_total AS nfhi_valortotal, nfhi.desconto_porc AS nfhi_descontoporc, nfhi.desconto AS nfhi_desconto,
                            i.iditem AS i_iditem, i.descitem AS i_desc, i.denominacaocompra AS i_desccompra, i.tipo AS i_tipo, i.referencia AS i_referencia, i.valorentrada AS i_valorentrada, i.valorsaida AS i_valorsaida, i.estoquenecessario AS i_estoquenecessario, i.quantidade AS i_quantidade,
                            uni.idunimedida AS uni_idunimedida, uni.sigla AS uni_sigla, uni.descricao AS uni_descricao,
                            sbi.idsubgrupoitem AS sbi_idsubgrupoitem, sbi.codigo AS sbi_codigo, sbi.nome AS sbi_nome,
                            gi.idgrupoitem AS gi_idgrupoitem, gi.nome AS gi_nome
                            FROM
                            notafiscal nf 
                            LEFT JOIN pessoa p
	                            ON nf.idpessoa = p.idpessoa
                            LEFT JOIN cidade c
	                            ON p.idcidade = c.idcidade
                            LEFT JOIN subgrupopessoa sbp
	                            ON sbp.idsubgrupopessoa = p.idsubgrupopessoa
                            LEFT JOIN grupopessoa gp
	                            ON gp.idgrupopessoa = sbp.idgrupopessoa
                            LEFT JOIN notafiscal_has_item nfhi
	                            ON nfhi.idnotafiscal = nf.idnotafiscal
                            LEFT JOIN item i
	                            ON nfhi.iditem = i.iditem
                            LEFT JOIN unimedida uni
	                            ON i.idunimedida = uni.idunimedida
                            LEFT JOIN subgrupoitem sbi
	                            ON  i.idsubgrupoitem = sbi.idsubgrupoitem
                            LEFT JOIN grupoitem gi
	                            ON sbi.idgrupoitem = gi.idgrupoitem
                            WHERE 1 = 1 
                            {wherePessoa}
                            {whereCidade}
                            {whereDataEmissao}
                            {whereDataSaida}
                            {whereValor}
                            ORDER BY nf.idnotafiscal";
                if (f.usaFiltroClientes)
                {
                    sql.addParam("@idpessoa_inicial", f.pessoaInicial.PessoaID);
                    sql.addParam("@idpessoa_final", f.pessoaFinal.PessoaID);
                }
                if (f.usaFiltroCidades)
                {
                    sql.addParam("@idcidade_inicial", f.cidadeInicial.CidadeID);
                    sql.addParam("@idcidade_final", f.cidadeFinal.CidadeID);
                }
                if (f.usaFiltroDataEmissao)
                {
                    sql.addParam("@data_emissao_inicial", f.dataEmissaoInicial);
                    sql.addParam("@data_emissao_final", f.dataEmissaoFinal);
                }
                if (f.usaFiltroDataSaida)
                {
                    sql.addParam("@data_saida_inicial", f.dataSaidaInicial);
                    sql.addParam("@data_saida_final", f.dataSaidaFinal);
                }
                if (f.usaFiltroValor)
                {
                    sql.addParam("@valor_inicial", f.valorInicial);
                    sql.addParam("@valor_final", f.valorFinal);
                }
                var data = sql.selectQuery();
                var i = 0;
                NotaFiscalPropria notaFiscalPropria = null;
                foreach (var d in data)
                {
                    var grupoItem = new GrupoItem();
                    grupoItem.GrupoItemID = Convert.ToInt32(d["gi_idgrupoitem"]);
                    grupoItem.Nome = (string)d["gi_nome"];

                    var subGrupoItem = new SubGrupoItem();
                    subGrupoItem.SubGrupoItemID = Convert.ToInt32(d["sbi_idsubgrupoitem"]);
                    subGrupoItem.Nome = (string)d["sbi_nome"];
                    subGrupoItem.Codigo = Convert.ToInt32(d["sbi_codigo"]);
                    subGrupoItem.GrupoItem = grupoItem;

                    var uniMedida = new Unimedida();
                    uniMedida.UnimedidaID = Convert.ToInt32(d["uni_idunimedida"]);
                    uniMedida.Sigla = (string)d["uni_sigla"];
                    uniMedida.Descricao = (string)d["uni_descricao"];

                    var item = new Item();
                    item.ItemID = Convert.ToInt32(d["i_iditem"]);
                    item.Descricao = (string)d["i_desc"];
                    item.DescCompra = (string)d["i_desccompra"];
                    item.TipoItem = (string)d["i_tipo"];
                    item.Referencia = (string)d["i_referencia"];
                    item.ValorEntrada = (decimal)d["i_valorentrada"];
                    item.ValorSaida = (decimal)d["i_valorsaida"];
                    item.Estoquenecessario = (decimal)d["i_estoquenecessario"];
                    item.Unimedida = uniMedida;
                    item.SubGrupoItem = subGrupoItem;
                    item.Quantidade = (decimal)d["i_quantidade"];

                    var nfi = new NotaFiscalPropriaItem();
                    nfi.NotaFiscal = notaFiscalPropria;
                    nfi.Item = item;
                    nfi.Quantidade = (decimal)d["nfhi_quantidade"];
                    nfi.ValorUnitario = (decimal)d["nfhi_valorunitario"];
                    nfi.ValorTotal = (decimal)d["nfhi_valortotal"];
                    nfi.DescontoPorc = (decimal)d["nfhi_descontoporc"];
                    nfi.Desconto = (decimal)d["nfhi_desconto"];

                    if (Convert.ToInt32(d["nf_idnotafiscal"]) != i)
                    {
                        notaFiscalProprias.Add(notaFiscalPropria);
                        i = Convert.ToInt32(d["nf_idnotafiscal"]);


                        var grupoPessoa = new GrupoPessoa();
                        grupoPessoa.GrupoPessoaID = Convert.ToInt32(d["gp_idgrupopessoa"]);
                        grupoPessoa.Nome = (string)d["gp_nome"];

                        var subGrupoPessoa = new SubGrupoPessoa();
                        subGrupoPessoa.SubGrupoPessoaID = Convert.ToInt32(d["sbp_idsubgrupopessoa"]);
                        subGrupoPessoa.Nome = (string)d["sbp_nome"];
                        subGrupoPessoa.GrupoPessoa = grupoPessoa;

                        var cidade = new Cidade();
                        cidade.CidadeID = Convert.ToInt32(d["c_idcidade"]);
                        cidade.Nome = (string)d["c_nome"];

                        var pessoa = new Pessoa();
                        pessoa.PessoaID = Convert.ToInt32(d["p_idpessoa"]);
                        pessoa.Nome = (string)d["p_nome"];
                        pessoa.Fantasia = (string)d["p_fantasia"];
                        pessoa.Rua = (string)d["p_rua"];
                        pessoa.Numero = (string)d["p_numero"];
                        pessoa.Bairro = (string)d["p_bairro"];
                        pessoa.Complemento = (string)d["p_complemento"];
                        pessoa.Cidade = cidade;
                        pessoa.CpfCnpj = (string)d["p_cnpj"];
                        pessoa.Telefone = (string)d["p_endereco"];
                        pessoa.Email = (string)d["p_telefone"];
                        pessoa.SubGrupoPessoa = subGrupoPessoa;


                        notaFiscalPropria = new NotaFiscalPropria();
                        notaFiscalPropria.NotaFiscalPropriaID = Convert.ToInt32(d["nf_idnotafiscal"]);
                        notaFiscalPropria.DataEmissao = (DateTime)d["nf_data_emissao"];
                        notaFiscalPropria.DataEntradaSaida = (DateTime)d["nf_entradasaida"];
                        notaFiscalPropria.TipoNf = (string)d["nf_tiponf"];
                        notaFiscalPropria.ValorTotalItens = (decimal)d["nf_valor_total_itens"];
                        notaFiscalPropria.ValorTotalDocumento = (decimal)d["nf_valor_documento"];
                        notaFiscalPropria.DescontoTotalItens = (decimal)d["nf_desconto_total_itens"];
                        notaFiscalPropria.DescontoDocumento = (decimal)d["nf_desconto_documento"];
                        notaFiscalPropria.Pessoa = pessoa;
                    }
                    notaFiscalPropria.NotaFiscalPropriaItem.Add(nfi);
                }
                notaFiscalProprias.Add(notaFiscalPropria);
            }
            notaFiscalProprias.RemoveAt(0);
            return notaFiscalProprias;
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
            notaFiscalPropria.DataEmissao = (DateTime)data[0]["data_emissao"];
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
                nfi.Quantidade = (decimal)d["quantidadenfhi"];
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