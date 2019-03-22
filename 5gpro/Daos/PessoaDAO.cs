using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace _5gpro.Daos
{
    class PessoaDAO : ConexaoDAO
    {
        public int SalvarOuAtualizarPessoa(Pessoa pessoa)
        {

            int retorno = 0;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"INSERT INTO pessoa
                         (idpessoa, nome, fantasia, rua, numero, bairro, complemento, cpf, cnpj, endereco, telefone, email, idcidade, tipo_pessoa)
                          VALUES
                         (@idpessoa, @nome, @fantasia, @rua, @numero, @bairro, @complemento, @cpf, @cnpj, @endereco, @telefone, @email, @idcidade, @tipoPessoa)
                          ON DUPLICATE KEY UPDATE
                          nome = @nome, fantasia = @fantasia, rua = @rua, numero = @numero, bairro = @bairro, complemento = @complemento,
                          cpf = @cpf, cnpj = @cnpj, endereco = @endereco, telefone = @telefone, email = @email, idcidade = @idcidade, tipo_pessoa = @tipoPessoa
                         ;",
                                           Conexao);
                Comando.Parameters.AddWithValue("@idpessoa", pessoa.Codigo);
                Comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                Comando.Parameters.AddWithValue("@fantasia", pessoa.Fantasia);
                Comando.Parameters.AddWithValue("@rua", pessoa.Rua);
                Comando.Parameters.AddWithValue("@numero", pessoa.Numero);
                Comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                Comando.Parameters.AddWithValue("@complemento", pessoa.Complemento);
                if (pessoa.TipoPessoa == "F")
                {
                    Comando.Parameters.AddWithValue("@cpf", pessoa.CpfCnpj);
                    Comando.Parameters.AddWithValue("@cnpj", "");
                }
                else
                {
                    Comando.Parameters.AddWithValue("@cpf", "");
                    Comando.Parameters.AddWithValue("@cnpj", pessoa.CpfCnpj);
                }
                Comando.Parameters.AddWithValue("@endereco", pessoa.Rua + ", " + pessoa.Numero + "-" + pessoa.Bairro);
                Comando.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                Comando.Parameters.AddWithValue("@email", pessoa.Email);
                Comando.Parameters.AddWithValue("@idcidade", pessoa.Cidade);
                Comando.Parameters.AddWithValue("@tipoPessoa", pessoa.TipoPessoa);

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

        public Pessoa BuscarPessoaById(string cod)
        {
            Pessoa pessoa = new Pessoa();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM pessoa WHERE idpessoa = @idpessoa", Conexao);
                Comando.Parameters.AddWithValue("@idpessoa", cod);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    pessoa.Codigo = reader.GetString(reader.GetOrdinal("idpessoa"));
                    pessoa.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    pessoa.Fantasia = reader.GetString(reader.GetOrdinal("fantasia"));
                    pessoa.TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa"));
                    pessoa.Rua = reader.GetString(reader.GetOrdinal("rua"));
                    pessoa.Numero = reader.GetString(reader.GetOrdinal("numero"));
                    pessoa.Bairro = reader.GetString(reader.GetOrdinal("bairro"));
                    pessoa.Complemento = reader.GetString(reader.GetOrdinal("complemento"));
                    pessoa.Cidade = reader.GetString(reader.GetOrdinal("idcidade"));
                    pessoa.CpfCnpj = pessoa.TipoPessoa == "F"? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    pessoa.Telefone = reader.GetString(reader.GetOrdinal("telefone"));
                    pessoa.Email = reader.GetString(reader.GetOrdinal("email"));
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
            return pessoa;
        }
    }
}
