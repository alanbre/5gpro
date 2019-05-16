using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _5gpro.Daos
{
    class FormaPagamentoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public IEnumerable<FormaPagamento> BuscaTodos(string nome)
        {
            List<FormaPagamento> formapagamentos = new List<FormaPagamento>();
            FormaPagamento formapagamento = null;

            string conNome = nome.Length > 0 ? "AND f.nome LIKE @nome" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM formapagamento f 
                                             WHERE 1=1
                                             " + conNome + @"
                                             ORDER BY f.idformapagamento;", Connect.Conexao);


                if (nome.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        formapagamento = new FormaPagamento
                        {
                            FormaPagamentoID = reader.GetInt32(reader.GetOrdinal("idformapagamento")),
                            Nome = reader.GetString(reader.GetOrdinal("nome"))
                        };

                        formapagamentos.Add(formapagamento);
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
            return formapagamentos;
        }

        public FormaPagamento BuscarByID(int Codigo)
        {

            FormaPagamento formapagamento = null;
            List<FormaPagamento> listaformapagamento = new List<FormaPagamento>();

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT *
                                             FROM formapagamento f 
                                             WHERE f.idformapagamento = @idformapagamento", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idformapagamento", Codigo);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        formapagamento = new FormaPagamento
                        {
                            FormaPagamentoID = reader.GetInt32(reader.GetOrdinal("idformapagamento")),
                            Nome = reader.GetString(reader.GetOrdinal("nome"))
                        };
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

            return formapagamento;
        }
    }
}
