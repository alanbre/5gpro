using _5gpro.Bll;
using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    class OrcamentoDAO : ConexaoDAO
    {
        PessoaBLL pessoaBLL = new PessoaBLL();
        UnimedidaBLL unimedidaBLL = new UnimedidaBLL();

        public Orcamento BuscaOrcamentoById(string cod)
        {
            Orcamento orcamento = null;

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM orcamento WHERE idorcamento = @idorcamento", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    orcamento = new Orcamento();
                    orcamento.Codigo = reader.GetString(reader.GetOrdinal("idorcamento"));
                    orcamento.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));
                    orcamento.DataVencimento = reader.IsDBNull(reader.GetOrdinal("data_vencimento")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_vencimento"));
                    orcamento.ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens"));
                    orcamento.ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento"));
                    orcamento.DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens"));
                    orcamento.DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"));
                    orcamento.Pessoa = pessoaBLL.BuscarPessoaById(reader.GetString(reader.GetOrdinal("idpessoa")));
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }
            if (orcamento != null)
            {
                orcamento.Itens = BuscaItensDoOrcamento(orcamento);
            }
            return orcamento;
        }

        public Orcamento BuscaProximoOrcamento(string codAtual)
        {
            Orcamento orcamento = null;

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM orcamento WHERE idorcamento = (SELECT min(idorcamento) FROM orcamento WHERE idorcamento > @idorcamento)", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    orcamento = new Orcamento();
                    orcamento.Codigo = reader.GetString(reader.GetOrdinal("idorcamento"));
                    orcamento.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));
                    orcamento.DataVencimento = reader.IsDBNull(reader.GetOrdinal("data_vencimento")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_vencimento"));
                    orcamento.ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens"));
                    orcamento.ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento"));
                    orcamento.DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens"));
                    orcamento.DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"));
                    orcamento.Pessoa = pessoaBLL.BuscarPessoaById(reader.GetString(reader.GetOrdinal("idpessoa")));
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            if (orcamento != null) { orcamento.Itens = BuscaItensDoOrcamento(orcamento); }

            return orcamento;
        }

        public Orcamento BuscaOrcamentoAnterior(string codAtual)
        {
            Orcamento orcamento = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM orcamento WHERE idorcamento = (SELECT max(idorcamento) FROM orcamento WHERE idorcamento < @idorcamento)", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    orcamento = new Orcamento();
                    orcamento.Codigo = reader.GetString(reader.GetOrdinal("idorcamento"));
                    orcamento.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));
                    orcamento.DataVencimento = reader.IsDBNull(reader.GetOrdinal("data_vencimento")) ? null : (DateTime?)reader.GetDateTime(reader.GetOrdinal("data_vencimento"));
                    orcamento.ValorTotalItens = reader.GetDecimal(reader.GetOrdinal("valor_total_itens"));
                    orcamento.ValorTotalOrcamento = reader.GetDecimal(reader.GetOrdinal("valor_orcamento"));
                    orcamento.DescontoTotalItens = reader.GetDecimal(reader.GetOrdinal("desconto_total_itens"));
                    orcamento.DescontoOrcamento = reader.GetDecimal(reader.GetOrdinal("desconto_orcamento"));
                    orcamento.Pessoa = pessoaBLL.BuscarPessoaById(reader.GetString(reader.GetOrdinal("idpessoa")));
                    reader.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            if (orcamento != null) { orcamento.Itens = BuscaItensDoOrcamento(orcamento); }

            return orcamento;
        }



        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT o1.idorcamento + 1 AS proximoid
                                             FROM orcamento AS o1
                                             LEFT OUTER JOIN orcamento AS o2 ON o1.idorcamento + 1 = o2.idorcamento
                                             WHERE o2.idorcamento IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Conexao);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    proximoid = reader.GetString(reader.GetOrdinal("proximoid"));
                    reader.Close();
                }
                else
                {
                    //FIZ ESSE ELSE PARA CASO N TIVER NENHUM REGISTRO NA BASE... PODE DAR PROBLEMA EM ALGUM MOMENTO xD
                    proximoid = "1";
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }

            return proximoid;
        }

        public List<_Item> BuscaItensDoOrcamento(Orcamento orcamento)
        {
            List<_Item> itensOrcamento = new List<_Item>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT * 
                                             FROM orcamento_has_item oi INNER JOIN item i 
                                             ON oi.iditem = i.iditem 
                                             WHERE idorcamento = @idorcamento", Conexao);
                Comando.Parameters.AddWithValue("@idorcamento", orcamento.Codigo);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    _Item i = new _Item();
                    i.Codigo = reader.GetString(reader.GetOrdinal("iditem"));
                    i.Descricao = reader.GetString(reader.GetOrdinal("descitem"));
                    i.DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra"));
                    i.TipoItem = reader.GetString(reader.GetOrdinal("tipo"));
                    i.Referencia = reader.GetString(reader.GetOrdinal("referencia"));
                    i.ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada"));
                    i.ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida"));
                    i.Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario"));
                    i.Unimedida = new UnimedidaDAO().BuscaUnimedidaByCod(reader.GetString(reader.GetOrdinal("idunimedida")));
                    i.Quantidade = reader.GetDecimal(reader.GetOrdinal("quantidade"));
                    i.ValorUnitario = reader.GetDecimal(reader.GetOrdinal("valor_unitario"));
                    i.ValorTotal = reader.GetDecimal(reader.GetOrdinal("valor_total"));
                    i.DescontoPorc = reader.GetDecimal(reader.GetOrdinal("desconto_porc"));
                    i.Desconto = reader.GetDecimal(reader.GetOrdinal("desconto"));
                    itensOrcamento.Add(i);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                FecharConexao();
            }
            return itensOrcamento;
        }

        public int SalvarOuAtualizarOrcamento(Orcamento orcamento)
        {
            int retorno = 0;
            string vencimento = orcamento.DataVencimento.HasValue ? orcamento.DataVencimento.Value.Date.ToString() : "";
            string vencimento_campo = vencimento.Length > 0 ? "data_vencimento" : "";
            string vencimento_ref = vencimento.Length > 0 ? "@data_vencimento" : "";
            string idpessoa_campo = orcamento.Pessoa != null ? "idpessoa" : "";
            string idpessoa_ref = orcamento.Pessoa != null ? "@idpessoa" : "";
            try
            {
                AbrirConexao();
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;


                Comando.CommandText = @"INSERT INTO orcamento
                         (idorcamento, data_cadastro, data_vencimento, valor_total_itens, valor_orcamento, desconto_total_itens, desconto_orcamento, idpessoa)
                          VALUES
                         (@idorcamento, @data_cadastro, @data_vencimento, @valor_total_itens, @valor_orcamento, @desconto_total_itens, @desconto_orcamento, @idpessoa)
                          ON DUPLICATE KEY UPDATE
                          data_cadastro = @data_cadastro, data_vencimento = @data_vencimento, valor_total_itens = @valor_total_itens,
                          valor_orcamento = @valor_orcamento, desconto_total_itens = @desconto_total_itens, desconto_orcamento = @desconto_orcamento,
                          idpessoa = @idpessoa
                          ";

                Comando.Parameters.AddWithValue("@idorcamento", orcamento.Codigo);
                Comando.Parameters.AddWithValue("@data_cadastro", orcamento.DataCadastro);
                Comando.Parameters.AddWithValue("@data_vencimento", orcamento.DataVencimento);
                Comando.Parameters.AddWithValue("@valor_total_itens", orcamento.ValorTotalItens);
                Comando.Parameters.AddWithValue("@valor_orcamento", orcamento.ValorTotalOrcamento);
                Comando.Parameters.AddWithValue("@desconto_total_itens", orcamento.DescontoTotalItens);
                Comando.Parameters.AddWithValue("@desconto_orcamento", orcamento.DescontoOrcamento);
                if (orcamento.Pessoa != null) { Comando.Parameters.AddWithValue("@idpessoa", orcamento.Pessoa.Codigo); }

                retorno = Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Comando.CommandText = @"DELETE FROM orcamento_has_item WHERE idorcamento = @idorcamento";
                    Comando.ExecuteNonQuery();

                    Comando.CommandText = @"INSERT INTO orcamento_has_item (idorcamento, iditem, quantidade, valor_unitario, valor_total, desconto_porc, desconto)
                                            VALUES
                                            (@idorcamento, @iditem, @quantidade, @valor_unitario, @valor_total, @desconto_porc, @desconto)";
                    foreach (_Item i in orcamento.Itens)
                    {
                        Comando.Parameters.Clear();
                        Comando.Parameters.AddWithValue("@idorcamento", orcamento.Codigo);
                        Comando.Parameters.AddWithValue("@iditem", i.Codigo);
                        Comando.Parameters.AddWithValue("@quantidade", i.Quantidade);
                        Comando.Parameters.AddWithValue("@valor_unitario", i.ValorUnitario);
                        Comando.Parameters.AddWithValue("@valor_total", i.ValorTotal);
                        Comando.Parameters.AddWithValue("@desconto_porc", i.DescontoPorc);
                        Comando.Parameters.AddWithValue("@desconto", i.Desconto);
                        Comando.ExecuteNonQuery();
                    }
                }
                tr.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                FecharConexao();
            }
            return retorno;
        }
    }
}
