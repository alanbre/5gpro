using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace _5gpro.Daos
{
    class NotaFiscalDAO : ConexaoDAO
    {

        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT nf1.idnotafiscal + 1 AS proximoid 
                                             FROM notafiscal AS nf1 
                                             LEFT OUTER JOIN notafiscal AS nf2 ON nf1.idnotafiscal + 1 = nf2.idnotafiscal 
                                             WHERE nf2.idnotafiscal IS NULL 
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

        public NotaFiscalItem BuscaItemByCod(int codigo)
        {
            NotaFiscalItem _item = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM item WHERE iditem = @iditem", Conexao);
                Comando.Parameters.AddWithValue("@iditem", codigo);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    _Item item = new _Item();
                    item._ItemID = reader.GetInt32(reader.GetOrdinal("iditem"));
                    item.Descricao = reader.GetString(reader.GetOrdinal("descitem"));
                    item.DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra"));
                    item.TipoItem = reader.GetString(reader.GetOrdinal("tipo"));
                    item.Referencia = reader.GetString(reader.GetOrdinal("referencia"));
                    item.ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada"));
                    item.ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida"));
                    item.Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario"));
                    item.Unimedida = new UnimedidaDAO().BuscaUnimedidaByCod(reader.GetInt32(reader.GetOrdinal("idunimedida")));
                    _item.Item = item;
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
            return _item;
        }
    }
}