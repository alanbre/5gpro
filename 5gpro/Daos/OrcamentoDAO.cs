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
                    orcamento.Codigo = reader.GetString(reader.GetOrdinal("idpessoa"));
                    orcamento.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));
                    orcamento.DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento"));
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

                    i.Unimedida = new UnimedidaDAO().BuscaUnimedidaByCod(reader.GetString(reader.GetOrdinal("unimedida_idunimedida")));
                    //i.Unimedida = reader.GetString(reader.GetOrdinal("unimedida_idunimedida"));

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
    }
}
