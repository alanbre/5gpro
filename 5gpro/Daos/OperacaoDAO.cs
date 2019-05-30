using _5gpro.Entities;
using MySql.Data.MySqlClient;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _5gpro.Daos
{
    class OperacaoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int SalvaOuAtualiza(Operacao operacao)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.beginTransaction();
                sql.Query = @"INSERT INTO operacao 
                            (idoperacao, nome, descricao, condicao, desconto, entrada, acrescimo) 
                            VALUES
                            (@idoperacao, @nome, @descricao, @condicao, @desconto, @entrada, @acrescimo)
                            ON DUPLICATE KEY UPDATE
                            nome = @nome, descricao = @descricao, condicao = @condicao, desconto = @desconto, entrada = @entrada, acrescimo = @acrescimo";
                sql.addParam("@idoperacao", operacao.OperacaoID);
                sql.addParam("@nome", operacao.Nome);
                sql.addParam("@descricao", operacao.Descricao);
                sql.addParam("@condicao", operacao.Condicao);
                sql.addParam("@desconto", operacao.Desconto);
                sql.addParam("@entrada", operacao.Entrada);
                sql.addParam("@acrescimo", operacao.Acrescimo);
                retorno = sql.insertQuery();

                sql.Query = @"DELETE FROM parcelaoperacao WHERE idoperacao = @idoperacao";
                sql.deleteQuery();

                if (retorno > 0 && operacao.Condicao.Equals("AP"))
                {

                    sql.Query = @"INSERT INTO parcelaoperacao 
                                (numero, dias, idoperacao)
                                VALUES
                                (@numero, @dias, @idoperacao)
                                ON DUPLICATE KEY UPDATE
                                numero = @numero, dias = @dias, idoperacao = @idoperacao ";
                    foreach (var p in operacao.Parcelas)
                    {
                        sql.clearParams();
                        sql.addParam("@numero", p.Numero);
                        sql.addParam("@dias", p.Dias);
                        sql.addParam("@idoperacao", operacao.OperacaoID);
                        sql.insertQuery();
                    }
                }
                sql.Commit();
            }
            return retorno;
        }
        public Operacao BuscaByID(int Codigo)
        {
            var operacao = new Operacao();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM operacao o 
                            LEFT JOIN parcelaoperacao p 
                            ON o.idoperacao = p.idoperacao
                            WHERE o.idoperacao = @idoperacao";
                sql.addParam("@idoperacao", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                operacao = LeDadosReader(data);
            }
            return operacao;
        }
        public IEnumerable<Operacao> Busca(string nomeOperacao)
        {
            List<Operacao> operacoes = new List<Operacao>();
            string conNomeOperacao = nomeOperacao.Length > 0 ? "AND o.nome LIKE @nomeoperacao" : "";
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM operacao o 
                            WHERE 1=1 "
                            + conNomeOperacao + " "
                            + @"ORDER BY o.nome";
                if (nomeOperacao.Length > 0) { sql.addParam("@nomeoperacao", "%" + nomeOperacao + "%"); }
                var data = sql.selectQuery();

                foreach (var d in data)
                {
                    var operacao = new Operacao();
                    operacao.OperacaoID = Convert.ToInt32(d["idoperacao"]);
                    operacao.Nome = (string)d["nome"];
                    operacao.Descricao = (string)d["descricao"];
                    operacao.Condicao = (string)d["condicao"];
                    operacao.Desconto = (decimal)d["desconto"];
                    operacao.Entrada = (decimal)d["entrada"];
                    operacao.Acrescimo = (decimal)d["acrescimo"];
                    operacoes.Add(operacao);
                }
            }
            return operacoes;
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT o1.idoperacao + 1 AS proximoid
                            FROM operacao AS o1
                            LEFT OUTER JOIN operacao AS o2 ON o1.idoperacao + 1 = o2.idoperacao
                            WHERE o2.idoperacao IS NULL
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
        public Operacao Proxima(string Codigo)
        {
            var operacao = new Operacao();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM operacao o 
                            LEFT JOIN parcelaoperacao p 
                            ON o.idoperacao = p.idoperacao
                            WHERE o.idoperacao = (SELECT min(idoperacao) FROM operacao WHERE idoperacao > @idoperacao)";
                sql.addParam("@idoperacao", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                operacao = LeDadosReader(data);
            }
            return operacao;
        }
        public Operacao Anterior(string Codigo)
        {
            var operacao = new Operacao();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT *
                            FROM operacao o 
                            LEFT JOIN parcelaoperacao p 
                            ON o.idoperacao = p.idoperacao
                            WHERE o.idoperacao = (SELECT max(idoperacao) FROM operacao WHERE idoperacao < @idoperacao)";
                sql.addParam("@idoperacao", Codigo);
                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                operacao = LeDadosReader(data);
            }
            return operacao;
        }
        private Operacao LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }
            var parcelas = new List<ParcelaOperacao>();
            var operacao = new Operacao();
            operacao.OperacaoID = Convert.ToInt32(data[0]["idoperacao"]);
            operacao.Nome = (string)data[0]["nome"];
            operacao.Descricao = (string)data[0]["descricao"];
            operacao.Condicao = (string)data[0]["condicao"];
            operacao.Desconto = (decimal)data[0]["desconto"];
            operacao.Entrada = (decimal)data[0]["entrada"];
            operacao.Acrescimo = (decimal)data[0]["acrescimo"];

            foreach (var d in data)
            {
                var parcela = new ParcelaOperacao();
                parcela.ParcelaOperacaoID = Convert.ToInt32(d["idparcelaoperacao"]);
                parcela.Numero = Convert.ToInt32(d["numero"]);
                parcela.Dias = Convert.ToInt32(d["dias"]);
                parcela.Operacao = operacao;
                parcelas.Add(parcela);
            }
            operacao.Parcelas = parcelas;
            return operacao;
        }
    }
}
