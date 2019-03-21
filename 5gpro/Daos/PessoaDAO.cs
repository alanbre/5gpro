using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;

namespace _5gpro.Daos
{
    class PessoaDAO : ConexaoDAO
    {
        public int SalvarPessoa(Pessoa pessoa)
        {
            MySqlCommand comando = null;
            try
            {
                AbrirConexao();
                comando = new MySqlCommand(@"INSERT INTO pessoa (idpessoa, nome, fantasia, rua, numero, bairro, complemento, cpf, cnpj, endereco, telefone, email, idcidade)
                                                         VALUES (@idpessoa, @nome, @fantasia, @rua, @numero, @bairro, @complemento, @cpf, @cnpj, @endereco, @telefone, @email, @idcidade)",
                                           conexao);
                comando.Parameters.AddWithValue("@idpessoa", pessoa.Codigo);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@fantasia", pessoa.Fantasia);
                comando.Parameters.AddWithValue("@rua", pessoa.Rua);
                comando.Parameters.AddWithValue("@numero", pessoa.Numero);
                comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                comando.Parameters.AddWithValue("@complemento", pessoa.Complemento);
                if (pessoa.TipoPessoa == "F")
                {
                    comando.Parameters.AddWithValue("@cpf", pessoa.CpfCnpj);
                    comando.Parameters.AddWithValue("@cnpj", "");
                }
                else
                {
                    comando.Parameters.AddWithValue("@cpf", "");
                    comando.Parameters.AddWithValue("@cnpj", pessoa.CpfCnpj);
                }
                

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
