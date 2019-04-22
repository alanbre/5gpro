using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class OperacaoDAO
    {

        public ConexaoDAO Connect { get; }
        public OperacaoDAO(ConexaoDAO c)
        {
            Connect = c;
        }

        public int SalvarOuAtualizarOperacao(Operacao operacao, List<ParcelaOperacao> listaparcelas)
        {
            int retorno = 0;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;

                Connect.Comando.CommandText = @"INSERT INTO operacao 
                          (idoperacao, nome, descricao, condicao, desconto, entrada, acrescimo) 
                          VALUES
                          (@idoperacao, @nome, @descricao, @condicao, @desconto, @entrada, @acrescimo)
                          ON DUPLICATE KEY UPDATE
                           nome = @nome, descricao = @descricao, condicao = @condicao, desconto = @desconto, entrada = @entrada, acrescimo = @acrescimo
                         ";

                Connect.Comando.Parameters.AddWithValue("@idoperacao", operacao.OperacaoID);
                Connect.Comando.Parameters.AddWithValue("@nome", operacao.Nome);
                Connect.Comando.Parameters.AddWithValue("@descricao", operacao.Descricao);
                Connect.Comando.Parameters.AddWithValue("@condicao", operacao.Condicao);
                Connect.Comando.Parameters.AddWithValue("@desconto", operacao.Desconto);
                Connect.Comando.Parameters.AddWithValue("@entrada", operacao.Entrada);
                Connect.Comando.Parameters.AddWithValue("@acrescimo", operacao.Acrescimo);

                retorno = Connect.Comando.ExecuteNonQuery();

                if (retorno > 0 && listaparcelas.Count > 0 && operacao.Condicao.Equals("AP"))
                {

                    Connect.Comando.CommandText = @"INSERT INTO parcelaoperacao 
                                            (idparcelaoperacao, numero, dias, idoperacao)
                                            VALUES
                                            (@idparcelaoperacao, @numero, @dias, @idoperacao)
                                            ON DUPLICATE KEY UPDATE
                                             numero = @numero, dias = @dias, idoperacao = @idoperacao 
                                             ";

                    foreach (ParcelaOperacao p in listaparcelas)
                    {
                        Connect.Comando.Parameters.Clear();
                        Connect.Comando.Parameters.AddWithValue("@idparcelaoperacao", p.ParcelaOperacaoID);
                        Connect.Comando.Parameters.AddWithValue("@numero", p.Numero);
                        Connect.Comando.Parameters.AddWithValue("@dias", p.Dias);
                        Connect.Comando.Parameters.AddWithValue("@idoperacao", operacao.OperacaoID);
                        Connect.Comando.ExecuteNonQuery();
                    }

                }
                Connect.tr.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                Connect.FecharConexao();
            }
            return retorno;
        }


        public IEnumerable<Operacao> BuscaOperacoes(string nomeOperacao)
        {
            List<ParcelaOperacao> parcelas = new List<ParcelaOperacao>();
            List<Operacao> operacoes = new List<Operacao>();

            string conNomeOperacao = nomeOperacao.Length > 0 ? "AND o.nome LIKE @nomeoperacao" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM operacao o 
                                             LEFT JOIN parcelaoperacao p 
                                             ON o.idoperacao = p.idoperacao
                                             WHERE 1=1
                                             " + conNomeOperacao + @"
                                             ORDER BY o.nome;", Connect.Conexao);

                if (nomeOperacao.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nomeoperacao", "%" + nomeOperacao + "%"); }

                IDataReader reader = Connect.Comando.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("condicao")).Equals("AP"))
                    {
                        Operacao operacaoparcela = new Operacao();
                        operacaoparcela.OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao"));

                        ParcelaOperacao parcela = new ParcelaOperacao
                        {
                            ParcelaOperacaoID = reader.GetInt32(reader.GetOrdinal("idparcelaoperacao")),
                            Numero = reader.GetInt32(reader.GetOrdinal("numero")),
                            Dias = reader.GetInt32(reader.GetOrdinal("dias")),
                            Operacao = operacaoparcela
                        };

                        parcelas.Add(parcela);
                    }

                    Operacao operacao = new Operacao
                    {
                        OperacaoID = reader.GetInt32(reader.GetOrdinal("idoperacao")),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Descricao = reader.GetString(reader.GetOrdinal("descricao")),
                        Condicao = reader.GetString(reader.GetOrdinal("condicao")),
                        Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                        Entrada = reader.GetDecimal(reader.GetOrdinal("entrada")),
                        Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo")),
                    };

                    //O Any funciona como o IEnumerable
                    if (!operacoes.Any(l => l.OperacaoID == reader.GetInt32(reader.GetOrdinal("idoperacao"))))
                    {
                        operacoes.Add(operacao);
                    }

                }

                foreach (Operacao o in operacoes)
                {
                    o.Parcelas = new List<ParcelaOperacao>();
                    foreach (ParcelaOperacao p in parcelas)
                    {
                        if (p.Operacao.OperacaoID == o.OperacaoID)
                        {
                            o.Parcelas.Add(p);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
            return operacoes;
        }


        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                Connect.AbrirConexao();

                Connect.Comando = new MySqlCommand(@"SELECT o1.idoperacao + 1 AS proximoid
                                             FROM operacao AS o1
                                             LEFT OUTER JOIN operacao AS o2 ON o1.idoperacao + 1 = o2.idoperacao
                                             WHERE o2.idoperacao IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Connect.Conexao);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    proximoid = reader.GetInt32(reader.GetOrdinal("proximoid"));
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }

            return proximoid;
        }


        public Operacao BuscarProximaOperacao(string codAtual)
        {
            Operacao operacao = new Operacao();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * FROM operacao
                                                   WHERE idoperacao = (SELECT min(idoperacao) 
                                                   FROM operacao 
                                                   WHERE idoperacao > @idoperacao)", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idoperacao", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    operacao = new Operacao
                    {
                        OperacaoID = int.Parse(reader.GetString(reader.GetOrdinal("idoperacao"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Descricao = reader.GetString(reader.GetOrdinal("descricao")),
                        Condicao = reader.GetString(reader.GetOrdinal("condicao")),
                        Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                        Entrada = reader.GetDecimal(reader.GetOrdinal("entrada")),
                        Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo"))
                    };
                    reader.Close();
                }
                else
                {
                    operacao = null;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }

            return operacao;
        }

        public Operacao BuscarOperacaoAnterior(string codAtual)
        {
            Operacao operacao = new Operacao();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT * 
                                                   FROM operacao 
                                                   WHERE idoperacao = (SELECT max(idoperacao) 
                                                   FROM operacao 
                                                   WHERE idoperacao < @idoperacao)", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idoperacao", codAtual);

                IDataReader reader = Connect.Comando.ExecuteReader();

                if (reader.Read())
                {
                    operacao = new Operacao
                    {
                        OperacaoID = int.Parse(reader.GetString(reader.GetOrdinal("idoperacao"))),
                        Nome = reader.GetString(reader.GetOrdinal("nome")),
                        Descricao = reader.GetString(reader.GetOrdinal("descricao")),
                        Condicao = reader.GetString(reader.GetOrdinal("condicao")),
                        Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                        Entrada = reader.GetDecimal(reader.GetOrdinal("entrada")),
                        Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo"))
                    };
                    reader.Close();
                }
                else
                {
                    operacao = null;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }

            return operacao;
        }
    }
}
