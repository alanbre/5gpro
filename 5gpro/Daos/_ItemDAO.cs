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
            MySqlCommand comando = null;
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO item (iditem, descitem, denominacaocompra, tipo, referencia, valorentrada, valorsaida, estoquenecessario, unimedida_idunimedida) VALUES(@iditem, @descitem, @denominacaocompra, @tipo, @referencia, @valorentrada, @valorsaida, @estoquenecessario, @unimedida_idunimedida)", conexao);
                comando.Parameters.AddWithValue("@iditem", _Item.Iditem);
                comando.Parameters.AddWithValue("@descitem", _Item.Descricao);
                comando.Parameters.AddWithValue("@denominacaocompra", _Item.DenomCompra);
                comando.Parameters.AddWithValue("@tipo", _Item.TipoItem);
                comando.Parameters.AddWithValue("@referencia", _Item.Referencia);
                comando.Parameters.AddWithValue("@valorentrada", _Item.ValorEntrada);
                comando.Parameters.AddWithValue("@valorsaida", _Item.ValorSaida);
                comando.Parameters.AddWithValue("@estoquenecessario", _Item.Estoquenecessario);
                comando.Parameters.AddWithValue("@unimedida_idunimedida", _Item.Unimedida);

                return comando.ExecuteNonQuery();
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
