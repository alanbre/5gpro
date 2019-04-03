using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                Comando = Conexao.CreateCommand();
                tr = Conexao.BeginTransaction();
                Comando.Connection = Conexao;
                Comando.Transaction = tr;


                Comando.CommandText = @"INSERT INTO pessoa
                         (idpessoa, nome, fantasia, rua, numero, bairro, complemento, cpf, cnpj, endereco, telefone, email, idcidade, tipo_pessoa)
                          VALUES
                         (@idpessoa, @nome, @fantasia, @rua, @numero, @bairro, @complemento, @cpf, @cnpj, @endereco, @telefone, @email, @idcidade, @tipoPessoa)
                          ON DUPLICATE KEY UPDATE
                          nome = @nome, fantasia = @fantasia, rua = @rua, numero = @numero, bairro = @bairro, complemento = @complemento,
                          cpf = @cpf, cnpj = @cnpj, endereco = @endereco, telefone = @telefone, email = @email, idcidade = @idcidade, tipo_pessoa = @tipoPessoa
                          ";

                Comando.Parameters.AddWithValue("@idpessoa", pessoa.PessoaID);
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
                Comando.Parameters.AddWithValue("@idcidade", pessoa.Cidade.CidadeID);
                Comando.Parameters.AddWithValue("@tipoPessoa", pessoa.TipoPessoa);

                retorno = Comando.ExecuteNonQuery();


                if (retorno > 0) //Checa se conseguiu inserir ou atualizar pelo menos 1 registro
                {
                    Comando.CommandText = @"UPDATE atuacao_has_pessoa SET ativo = FALSE where pessoa_idpessoa = @idpessoa";
                    Comando.ExecuteNonQuery();

                    foreach (string atuacao in pessoa.Atuacao)
                    {
                        switch (atuacao)
                        {
                            case "Cliente":
                                Comando.CommandText = @"INSERT INTO atuacao_has_pessoa (pessoa_idpessoa, atuacao_idatuacao, ativo)
                                                        VALUES (@idpessoa, 1, TRUE)
                                                        ON DUPLICATE KEY UPDATE
                                                        ativo = TRUE";
                                break;
                            case "Fornecedor":
                                Comando.CommandText = @"INSERT INTO atuacao_has_pessoa (pessoa_idpessoa, atuacao_idatuacao, ativo)
                                                        VALUES (@idpessoa, 2, TRUE)
                                                        ON DUPLICATE KEY UPDATE
                                                        ativo = TRUE";
                                break;
                        }
                        Comando.ExecuteNonQuery();
                    }
                }
                tr.Commit();
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

        public Pessoa BuscarPessoaById(int cod)
        {
            Pessoa pessoa = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM pessoa WHERE idpessoa = @idpessoa", Conexao);
                Comando.Parameters.AddWithValue("@idpessoa", cod);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    pessoa = new Pessoa();
                    pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
                    pessoa.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    pessoa.Fantasia = reader.GetString(reader.GetOrdinal("fantasia"));
                    pessoa.TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa"));
                    pessoa.Rua = reader.GetString(reader.GetOrdinal("rua"));
                    pessoa.Numero = reader.GetString(reader.GetOrdinal("numero"));
                    pessoa.Bairro = reader.GetString(reader.GetOrdinal("bairro"));
                    pessoa.Complemento = reader.GetString(reader.GetOrdinal("complemento"));
                    pessoa.Cidade = new CidadeDAO().BuscaCidadeByCod(reader.GetInt32(reader.GetOrdinal("idcidade")));                
                    pessoa.CpfCnpj = pessoa.TipoPessoa == "F"? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    pessoa.Telefone = reader.GetString(reader.GetOrdinal("telefone"));
                    pessoa.Email = reader.GetString(reader.GetOrdinal("email"));
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

            if (pessoa != null) { pessoa.Atuacao = buscaAtuacoes(pessoa); }
            return pessoa;
        }

        public Pessoa BuscarProximaPessoa(string codAtual)
        {
            Pessoa pessoa = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM pessoa WHERE idpessoa = (SELECT min(idpessoa) FROM pessoa WHERE idpessoa > @idpessoa)", Conexao);
                Comando.Parameters.AddWithValue("@idpessoa", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    pessoa = new Pessoa();
                    pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
                    pessoa.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    pessoa.Fantasia = reader.GetString(reader.GetOrdinal("fantasia"));
                    pessoa.TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa"));
                    pessoa.Rua = reader.GetString(reader.GetOrdinal("rua"));
                    pessoa.Numero = reader.GetString(reader.GetOrdinal("numero"));
                    pessoa.Bairro = reader.GetString(reader.GetOrdinal("bairro"));
                    pessoa.Complemento = reader.GetString(reader.GetOrdinal("complemento"));
                    pessoa.Cidade = new CidadeDAO().BuscaCidadeByCod(reader.GetInt32(reader.GetOrdinal("idcidade")));
                    pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    pessoa.Telefone = reader.GetString(reader.GetOrdinal("telefone"));
                    pessoa.Email = reader.GetString(reader.GetOrdinal("email"));
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

            if (pessoa != null) { pessoa.Atuacao = buscaAtuacoes(pessoa); }
            return pessoa;
        }

        public Pessoa BuscarPessoaAnterior(string codAtual)
        {
            Pessoa pessoa = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM pessoa WHERE idpessoa = (SELECT max(idpessoa) FROM pessoa WHERE idpessoa < @idpessoa)", Conexao);
                Comando.Parameters.AddWithValue("@idpessoa", codAtual);

                IDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    pessoa = new Pessoa();
                    pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
                    pessoa.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    pessoa.Fantasia = reader.GetString(reader.GetOrdinal("fantasia"));
                    pessoa.TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa"));
                    pessoa.Rua = reader.GetString(reader.GetOrdinal("rua"));
                    pessoa.Numero = reader.GetString(reader.GetOrdinal("numero"));
                    pessoa.Bairro = reader.GetString(reader.GetOrdinal("bairro"));
                    pessoa.Complemento = reader.GetString(reader.GetOrdinal("complemento"));
                    pessoa.Cidade = new CidadeDAO().BuscaCidadeByCod(reader.GetInt32(reader.GetOrdinal("idcidade")));
                    pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    pessoa.Telefone = reader.GetString(reader.GetOrdinal("telefone"));
                    pessoa.Email = reader.GetString(reader.GetOrdinal("email"));
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

            if (pessoa != null) { pessoa.Atuacao = buscaAtuacoes(pessoa); }
            return pessoa;
        }

        public List<Pessoa> BuscarPessoas(string nome, string cpfCnpj, string cidade)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            string conCodPessoa = nome.Length > 0 ? "AND nome LIKE @nome" : "";
            string conCpfCnpj = cpfCnpj.Length > 0 ? "AND (cpf LIKE @cpfcnpj OR cnpj LIKE @cpfcnpj)" : "";
            string conCidade = cidade.Length > 0 ? "AND idcidade = @idcidade" : "";

            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT *
                                             FROM pessoa 
                                             WHERE 1=1
                                             " + conCodPessoa + @"
                                             " + conCpfCnpj + @"
                                             " + conCidade + @"
                                             ORDER BY idpessoa", Conexao);
                if (conCodPessoa.Length > 0) { Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }
                if (conCpfCnpj.Length > 0) { Comando.Parameters.AddWithValue("@cpfcnpj", "%" + cpfCnpj + "%"); }
                if (conCidade.Length > 0) { Comando.Parameters.AddWithValue("@idcidade", cidade); }

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa"));
                    pessoa.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    pessoa.Fantasia = reader.GetString(reader.GetOrdinal("fantasia"));
                    pessoa.TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa"));
                    pessoa.Rua = reader.GetString(reader.GetOrdinal("rua"));
                    pessoa.Numero = reader.GetString(reader.GetOrdinal("numero"));
                    pessoa.Bairro = reader.GetString(reader.GetOrdinal("bairro"));
                    pessoa.Complemento = reader.GetString(reader.GetOrdinal("complemento"));              
                    pessoa.Cidade = new CidadeDAO().BuscaCidadeByCod(reader.GetInt32(reader.GetOrdinal("idcidade")));
                    pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    pessoa.Telefone = reader.GetString(reader.GetOrdinal("telefone"));
                    pessoa.Email = reader.GetString(reader.GetOrdinal("email"));
                    pessoa.Atuacao = buscaAtuacoes(pessoa);
                    pessoas.Add(pessoa);
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
            return pessoas;
        }

        public List<string> buscaAtuacoes(Pessoa pessoa)
        {
            List<string> atuacoes = new List<string>();
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("SELECT * FROM atuacao_has_pessoa WHERE pessoa_idpessoa = @idpessoa AND ativo = TRUE", Conexao);
                Comando.Parameters.AddWithValue("@idpessoa", pessoa.PessoaID);

                IDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    switch (reader.GetInt32(reader.GetOrdinal("atuacao_idatuacao")))
                    {
                        case 1:
                            atuacoes.Add("Cliente");
                            break;
                        case 2:
                            atuacoes.Add("Fornecedor");
                            break;
                    }
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
            return atuacoes;
        }

        public string BuscaProxCodigoDisponivel()
        {
            string proximoid = null;
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand(@"SELECT p1.idpessoa + 1 AS proximoid
                                             FROM pessoa AS p1
                                             LEFT OUTER JOIN pessoa AS p2 ON p1.idpessoa + 1 = p2.idpessoa
                                             WHERE p2.idpessoa IS NULL
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
    }
}
