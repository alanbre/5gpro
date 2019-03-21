using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class _ItemDAO : ConexaoDAO
    {
        public int Salvar(_Item _Item)
        {
            MySqlCommand Comando = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"INSERT INTO item (iditem, descitem, denominacaocompra, tipo, referencia, valorentrada, valorsaida, estoquenecessario, unimedida_idunimedida) 
                                                        VALUES(@iditem, @descitem, @denominacaocompra, @tipo, @referencia, @valorentrada, @valorsaida, @estoquenecessario, @unimedida_idunimedida)", Conexao);
                Comando.Parameters.AddWithValue("@iditem", _Item.Iditem);
                Comando.Parameters.AddWithValue("@descitem", _Item.Descricao);
                Comando.Parameters.AddWithValue("@denominacaocompra", _Item.DenomCompra);
                Comando.Parameters.AddWithValue("@tipo", _Item.TipoItem);
                Comando.Parameters.AddWithValue("@referencia", _Item.Referencia);
                Comando.Parameters.AddWithValue("@valorentrada", _Item.ValorEntrada);
                Comando.Parameters.AddWithValue("@valorsaida", _Item.ValorSaida);
                Comando.Parameters.AddWithValue("@estoquenecessario", _Item.Estoquenecessario);
                Comando.Parameters.AddWithValue("@unimedida_idunimedida", _Item.Unimedida);

                return Comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }

}
