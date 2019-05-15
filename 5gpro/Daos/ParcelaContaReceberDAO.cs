using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace _5gpro.Daos
{
    public class ParcelaContaReceberDAO
    {
        private readonly static ConexaoDAO Connect = ConexaoDAO.GetInstance();


        public IEnumerable<ParcelaContaReceber> Busca(fmCarQuitacaoConta.Filtros f)
        {
            var parcelas = new List<ParcelaContaReceber>();
            string wherePessoa = f.filtroPessoa != null ? "AND cr.idpessoa = @idpessoa" : "";
            string whereConta = f.filtroConta > 0 ? "AND cr.idconta_receber = @idconta_receber" : "";
            string whereValorFinal = f.usarvalorContaFiltro ? "AND cr.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final" : "";
            string whereDatCadastro = f.usardataCadastroFiltro ? "AND cr.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataVencimento = f.usardataVencimentoFiltro ? "AND pcr.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final" : "";

            try
            {
                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela_conta_receber pcr
                                                     LEFT JOIN conta_receber cr
                                                     ON pcr.idconta_receber = cr.idconta_receber
                                                     WHERE 1 = 1 "
                                                    + wherePessoa + ""
                                                    + whereConta + "" 
                                                    + whereValorFinal +" "
                                                    + whereDatCadastro +" "
                                                    + whereDataVencimento +
                                                    @" AND pcr.data_quitacao IS NULL
                                                      ");

                if (f.filtroPessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", f.filtroPessoa.PessoaID); }
                if (f.filtroConta > 0) { Connect.Comando.Parameters.AddWithValue("@idconta_receber", f.filtroConta); }

                Connect.Comando.Parameters.AddWithValue("@valor_conta_inicial", f.filtroValorInicial);
                Connect.Comando.Parameters.AddWithValue("@valor_conta_final", f.filtroValorFinal);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro_inicial", f.filtroDataCadastroInicial);
                Connect.Comando.Parameters.AddWithValue("@data_cadastro_final", f.filtroDataCadastroFinal);
                Connect.Comando.Parameters.AddWithValue("@data_vencimento_inicial", f.filtroDataVencimentoInicial);
                Connect.Comando.Parameters.AddWithValue("@data_vencimento_final", f.filtroDataVencimentoFinal);

                Connect.AbrirConexao();
                Connect.Comando.Connection = Connect.Conexao;
                using (var reader = Connect.Comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        parcelas.Add(LeDadosReader(reader));
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
            return parcelas;
        }

        public int QuitarParcelas(List<ParcelaContaReceber> parcelas)
        {
            int retorno = 0;
            try
            {

                Connect.Comando = new MySqlCommand(@"UPDATE parcela_conta_receber 
                                                     SET data_quitacao = @data_quitacao
                                                     WHERE idparcela_conta_receber = @idparcela_conta_receber
                                                     AND idconta_receber = @idconta_receber");
                Connect.AbrirConexao();
                Connect.Comando.Connection = Connect.Conexao;
                foreach (var p in parcelas)
                {
                    Connect.Comando.Parameters.Clear();
                    Connect.Comando.Parameters.AddWithValue("@data_quitacao", DateTime.Now);
                    Connect.Comando.Parameters.AddWithValue("@idparcela_conta_receber", p.ParcelaContaReceberID);
                    Connect.Comando.Parameters.AddWithValue("@idconta_receber", p.ContaReceberID);
                    Connect.Comando.ExecuteNonQuery();
                }
                retorno = 1;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
            return retorno;
        }

        private ParcelaContaReceber LeDadosReader(IDataReader reader)
        {
            var parcela = new ParcelaContaReceber()
            {
                ParcelaContaReceberID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_receber")),
                Sequencia = reader.GetInt32(reader.GetOrdinal("sequencia")),
                DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                Valor = reader.GetDecimal(reader.GetOrdinal("valor")),
                Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo")),
                Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                DataQuitacao = reader.IsDBNull(reader.GetOrdinal("data_quitacao")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                ContaReceberID = reader.GetInt32(reader.GetOrdinal("idconta_receber"))
            };
            return parcela;
        }

    }
}
