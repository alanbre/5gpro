using _5gpro.Entities;
using _5gpro.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class ParcelaContaPagarDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public IEnumerable<ParcelaContaPagar> Busca(fmCapQuitacaoConta.Filtros f)
        {
            var parcelas = new List<ParcelaContaPagar>();
            string wherePessoa = f.filtroPessoa != null ? "AND cp.idpessoa = @idpessoa" : "";
            string whereConta = f.filtroConta > 0 ? "AND cp.idconta_pagar = @idconta_pagar" : "";
            string whereValorFinal = f.usarvalorContaFiltro ? "AND cp.valor_final BETWEEN @valor_conta_inicial AND @valor_conta_final" : "";
            string whereDatCadastro = f.usardataCadastroFiltro ? "AND cp.data_cadastro BETWEEN @data_cadastro_inicial AND @data_cadastro_final" : "";
            string whereDataVencimento = f.usardataVencimentoFiltro ? "AND pcp.data_vencimento BETWEEN @data_vencimento_inicial AND @data_vencimento_final" : "";

            try
            {
                Connect.Comando = new MySqlCommand(@"SELECT * FROM parcela_conta_pagar pcp
                                                     LEFT JOIN conta_pagar cp
                                                     ON pcp.idconta_pagar = cp.idconta_pagar
                                                     WHERE 1 = 1 "
                                                    + wherePessoa + ""
                                                    + whereConta + ""
                                                    + whereValorFinal + " "
                                                    + whereDatCadastro + " "
                                                    + whereDataVencimento +
                                                    @" AND pcp.data_quitacao IS NULL
                                                      ");

                if (f.filtroPessoa != null) { Connect.Comando.Parameters.AddWithValue("@idpessoa", f.filtroPessoa.PessoaID); }
                if (f.filtroConta > 0) { Connect.Comando.Parameters.AddWithValue("@idconta_pagar", f.filtroConta); }

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

        public int QuitarParcelas(List<ParcelaContaPagar> parcelas)
        {
            int retorno = 0;
            string pago = "Pago";
            try
            {

                Connect.Comando = new MySqlCommand(@"UPDATE parcela_conta_pagar 
                                                     SET data_quitacao = @data_quitacao, situacao = @situacao
                                                     WHERE idparcela_conta_pagar = @idparcela_conta_pagar
                                                     AND idconta_pagar = @idconta_pagar");
                Connect.AbrirConexao();
                Connect.Comando.Connection = Connect.Conexao;
                foreach (var p in parcelas)
                {
                    Connect.Comando.Parameters.Clear();
                    Connect.Comando.Parameters.AddWithValue("@data_quitacao", DateTime.Now);
                    Connect.Comando.Parameters.AddWithValue("@idparcela_conta_pagar", p.ParcelaContaPagarID);
                    Connect.Comando.Parameters.AddWithValue("@idconta_pagar", p.ContaPagarID);
                    Connect.Comando.Parameters.AddWithValue("@situacao", pago);
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

        private ParcelaContaPagar LeDadosReader(IDataReader reader)
        {
            var parcela = new ParcelaContaPagar()
            {
                ParcelaContaPagarID = reader.GetInt32(reader.GetOrdinal("idparcela_conta_pagar")),
                Sequencia = reader.GetInt32(reader.GetOrdinal("sequencia")),
                DataVencimento = reader.GetDateTime(reader.GetOrdinal("data_vencimento")),
                Valor = reader.GetDecimal(reader.GetOrdinal("valor")),
                Multa = reader.GetDecimal(reader.GetOrdinal("multa")),
                Juros = reader.GetDecimal(reader.GetOrdinal("juros")),
                Acrescimo = reader.GetDecimal(reader.GetOrdinal("acrescimo")),
                Desconto = reader.GetDecimal(reader.GetOrdinal("desconto")),
                DataQuitacao = reader.IsDBNull(reader.GetOrdinal("data_quitacao")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("data_quitacao")),
                ContaPagarID = reader.GetInt32(reader.GetOrdinal("idconta_pagar"))
            };
            return parcela;
        }
    }
}
