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
    class _ItemDAO : ConexaoDAO
    {

        public int SalvarOuAtualizarItem(_Item _item)
        {

            int retorno = 0;
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand(@"INSERT INTO item 
                          (iditem, descitem, denominacaocompra, tipo, referencia, valorentrada, valorsaida, estoquenecessario, unimedida_idunimedida) 
                          VALUES
                          (@iditem, @descitem, @denominacaocompra, @tipo, @referencia, @valorentrada, @valorsaida, @estoquenecessario, @unimedida_idunimedida)
                          ON DUPLICATE KEY UPDATE
                           descitem = @descitem, denominacaocompra = @denominacaocompra, tipo = @tipo, referencia = @referencia, valorentrada = @valorentrada,
                           valorsaida = @valorsaida, estoquenecessario = @estoquenecessario, unimedida_idunimedida = @unimedida_idunimedida
                         ;", 
                         Conexao);

                Comando.Parameters.AddWithValue("@iditem", _item.Codigo);
                Comando.Parameters.AddWithValue("@descitem", _item.Descricao);
                Comando.Parameters.AddWithValue("@denominacaocompra", _item.DescCompra);
                Comando.Parameters.AddWithValue("@tipo", _item.TipoItem);
                Comando.Parameters.AddWithValue("@referencia", _item.Referencia);
                Comando.Parameters.AddWithValue("@valorentrada", _item.ValorEntrada);
                Comando.Parameters.AddWithValue("@valorsaida", _item.ValorSaida);
                Comando.Parameters.AddWithValue("@estoquenecessario", _item.Estoquenecessario);
                Comando.Parameters.AddWithValue("@unimedida_idunimedida", _item.Unimedida);


                retorno = Comando.ExecuteNonQuery();
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

        public _Item BuscarItemById(string cod)
        {
            _Item _item = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM item WHERE iditem = @iditem", Conexao);
                Comando.Parameters.AddWithValue("@iditem", cod);

                IDataReader reader = Comando.ExecuteReader();

                if(reader.Read())
                {
                    _item = new _Item();
                    _item.Codigo = reader.GetString(reader.GetOrdinal("iditem"));
                    _item.Descricao = reader.GetString(reader.GetOrdinal("descitem"));
                    _item.DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra"));
                    _item.TipoItem = reader.GetString(reader.GetOrdinal("tipo"));
                    _item.Referencia = reader.GetString(reader.GetOrdinal("referencia"));
                    _item.ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada"));
                    _item.ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida"));
                    _item.Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario"));
                    _item.Unimedida = reader.GetString(reader.GetOrdinal("unimedida_idunimedida"));
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

        public _Item BuscarProximoItem(string codAtual)
        {
            _Item _item = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM item WHERE iditem = (SELECT min(iditem) FROM item WHERE iditem > @iditem)", Conexao);
                Comando.Parameters.AddWithValue("@iditem", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    _item = new _Item();
                    _item.Codigo = reader.GetString(reader.GetOrdinal("iditem"));
                    _item.Descricao = reader.GetString(reader.GetOrdinal("descitem"));
                    _item.DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra"));
                    _item.TipoItem = reader.GetString(reader.GetOrdinal("tipo"));
                    _item.Referencia = reader.GetString(reader.GetOrdinal("referencia"));
                    _item.ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada"));
                    _item.ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida"));
                    _item.Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario"));
                    _item.Unimedida = reader.GetString(reader.GetOrdinal("unimedida_idunimedida"));
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

        public _Item BuscarItemAnterior(string codAtual)
        {
            _Item _item = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM item WHERE iditem = (SELECT max(iditem) FROM item WHERE iditem < @iditem)", Conexao);
                Comando.Parameters.AddWithValue("@iditem", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    _item = new _Item();
                    _item.Codigo = reader.GetString(reader.GetOrdinal("iditem"));
                    _item.Descricao = reader.GetString(reader.GetOrdinal("descitem"));
                    _item.DescCompra = reader.GetString(reader.GetOrdinal("denominacaocompra"));
                    _item.TipoItem = reader.GetString(reader.GetOrdinal("tipo"));
                    _item.Referencia = reader.GetString(reader.GetOrdinal("referencia"));
                    _item.ValorEntrada = reader.GetDecimal(reader.GetOrdinal("valorentrada"));
                    _item.ValorSaida = reader.GetDecimal(reader.GetOrdinal("valorsaida"));
                    _item.Estoquenecessario = reader.GetDecimal(reader.GetOrdinal("estoquenecessario"));
                    _item.Unimedida = reader.GetString(reader.GetOrdinal("unimedida_idunimedida"));
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
