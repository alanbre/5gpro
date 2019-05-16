using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _5gpro.Daos
{
    class PessoaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int SalvaOuAtualiza(Pessoa pessoa)
        {

            int retorno = 0;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = Connect.Conexao.CreateCommand();
                Connect.tr = Connect.Conexao.BeginTransaction();
                Connect.Comando.Connection = Connect.Conexao;
                Connect.Comando.Transaction = Connect.tr;


                Connect.Comando.CommandText = @"INSERT INTO pessoa
                         (idpessoa, nome, fantasia, rua, numero, bairro, complemento, cpf, cnpj, endereco, telefone, email, idcidade, tipo_pessoa, idsubgrupopessoa, atuacao, situacao)
                          VALUES
                         (@idpessoa, @nome, @fantasia, @rua, @numero, @bairro, @complemento, @cpf, @cnpj, @endereco, @telefone, @email, @idcidade, @tipoPessoa, @idsubgrupopessoa, @atuacao, @situacao)
                          ON DUPLICATE KEY UPDATE
                          nome = @nome, fantasia = @fantasia, rua = @rua, numero = @numero, bairro = @bairro, complemento = @complemento,
                          cpf = @cpf, cnpj = @cnpj, endereco = @endereco, telefone = @telefone, email = @email, idcidade = @idcidade, tipo_pessoa = @tipoPessoa, idsubgrupopessoa = @idsubgrupopessoa,
                          atuacao = @atuacao, situacao = @situacao
                          ";

                Connect.Comando.Parameters.AddWithValue("@idpessoa", pessoa.PessoaID);
                Connect.Comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                Connect.Comando.Parameters.AddWithValue("@fantasia", pessoa.Fantasia);
                Connect.Comando.Parameters.AddWithValue("@rua", pessoa.Rua);
                Connect.Comando.Parameters.AddWithValue("@numero", pessoa.Numero);
                Connect.Comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                Connect.Comando.Parameters.AddWithValue("@complemento", pessoa.Complemento);
                Connect.Comando.Parameters.AddWithValue("@atuacao", pessoa.Atuacao);
                Connect.Comando.Parameters.AddWithValue("@situacao", pessoa.Situacao);

                if (pessoa.TipoPessoa == "F")
                {
                    Connect.Comando.Parameters.AddWithValue("@cpf", pessoa.CpfCnpj);
                    Connect.Comando.Parameters.AddWithValue("@cnpj", "");
                }
                else
                {
                    Connect.Comando.Parameters.AddWithValue("@cpf", "");
                    Connect.Comando.Parameters.AddWithValue("@cnpj", pessoa.CpfCnpj);
                }
                Connect.Comando.Parameters.AddWithValue("@endereco", pessoa.Rua + ", " + pessoa.Numero + "-" + pessoa.Bairro);
                Connect.Comando.Parameters.AddWithValue("@telefone", pessoa.Telefone);
                Connect.Comando.Parameters.AddWithValue("@email", pessoa.Email);
                Connect.Comando.Parameters.AddWithValue("@idcidade", pessoa.Cidade.CidadeID);
                Connect.Comando.Parameters.AddWithValue("@tipoPessoa", pessoa.TipoPessoa);
                Connect.Comando.Parameters.AddWithValue("@idsubgrupopessoa", pessoa.SubGrupoPessoa.SubGrupoPessoaID);

                retorno = Connect.Comando.ExecuteNonQuery();

                Connect.tr.Commit();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                retorno = 0;
            }
            finally
            {
                Connect.FecharConexao();
            }
            return retorno;
        }

        public Pessoa BuscaById(int cod)
        {
            Pessoa pessoa = new Pessoa();
            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = null;
            Estado estado = null;
            Cidade cidade = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                                             e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                                             p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                                             telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao
                                             FROM pessoa p
                                             INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                                             INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                                             INNER JOIN cidade c ON p.idcidade = c.idcidade
                                             INNER JOIN estado e ON e.idestado = c.idestado
                                             WHERE p.idpessoa = @idpessoa", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idpessoa", cod);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa"))
                        };

                        subgrupopessoa = new SubGrupoPessoa
                        {
                            SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idsubgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomesubgrupopessoa"))
                        };

                        estado = new Estado
                        {
                            EstadoID = reader.GetInt32(reader.GetOrdinal("idestado")),
                            Nome = reader.GetString(reader.GetOrdinal("nomeestado")),
                            Uf = reader.GetString(reader.GetOrdinal("uf"))
                        };

                        cidade = new Cidade
                        {
                            CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade")),
                            Nome = reader.GetString(reader.GetOrdinal("nomecidade")),
                            Estado = estado
                        };

                        pessoa = new Pessoa
                        {
                            PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomepessoa")),
                            Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                            TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                            Rua = reader.GetString(reader.GetOrdinal("rua")),
                            Numero = reader.GetString(reader.GetOrdinal("numero")),
                            Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                            Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                            Cidade = cidade,
                            Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                            Email = reader.GetString(reader.GetOrdinal("email")),
                            SubGrupoPessoa = subgrupopessoa,
                            Atuacao = reader.GetString(reader.GetOrdinal("atuacao")),
                            Situacao = reader.GetString(reader.GetOrdinal("situacao"))
                        };
                        pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    }
                    else
                    {
                        pessoa = null;
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
            return pessoa;
        }

        public Tuple<Pessoa, int> BuscaById(int cod, Logado logado)
        {
            Pessoa pessoa = new Pessoa();
            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = null;
            Estado estado = null;
            Cidade cidade = null;
            int dono = 0;
            try
            {

                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                                             e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                                             p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                                             telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao
                                             FROM pessoa p
                                             INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                                             INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                                             INNER JOIN cidade c ON p.idcidade = c.idcidade
                                             INNER JOIN estado e ON e.idestado = c.idestado
                                             WHERE p.idpessoa = @idpessoa", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idpessoa", cod);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa"))
                        };

                        subgrupopessoa = new SubGrupoPessoa
                        {
                            SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idsubgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomesubgrupopessoa"))
                        };

                        estado = new Estado
                        {
                            EstadoID = reader.GetInt32(reader.GetOrdinal("idestado")),
                            Nome = reader.GetString(reader.GetOrdinal("nomeestado")),
                            Uf = reader.GetString(reader.GetOrdinal("uf"))
                        };

                        cidade = new Cidade
                        {
                            CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade")),
                            Nome = reader.GetString(reader.GetOrdinal("nomecidade")),
                            Estado = estado
                        };

                        pessoa = new Pessoa
                        {
                            PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomepessoa")),
                            Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                            TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                            Rua = reader.GetString(reader.GetOrdinal("rua")),
                            Numero = reader.GetString(reader.GetOrdinal("numero")),
                            Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                            Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                            Cidade = cidade,
                            Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                            Email = reader.GetString(reader.GetOrdinal("email")),
                            SubGrupoPessoa = subgrupopessoa,
                            Atuacao = reader.GetString(reader.GetOrdinal("atuacao")),
                            Situacao = reader.GetString(reader.GetOrdinal("situacao"))
                        };
                        pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    }
                    else
                    {
                        pessoa = null;
                    }
                }

                if (pessoa != null)
                {
                    Connect.Comando.CommandText = "SELECT * FROM 5gprodatabase.lock WHERE tabela = 'pessoa' AND codigo_registro = @codigo_registro AND idusuario != @idusuario";
                    Connect.Comando.Parameters.AddWithValue("@codigo_registro", cod);
                    Connect.Comando.Parameters.AddWithValue("@idusuario", logado.Usuario.UsuarioID);
                    using (var reader = Connect.Comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dono = reader.GetInt32(reader.GetOrdinal("idusuario"));
                        }

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
            return Tuple.Create<Pessoa, int>(pessoa, dono);
        }


        public Pessoa BuscaProximo(string codAtual)
        {
            Pessoa pessoa = new Pessoa();
            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = null;
            Estado estado = null;
            Cidade cidade = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                                             e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                                             p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                                             telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao
                                             FROM pessoa p
                                             INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                                             INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                                             INNER JOIN cidade c ON p.idcidade = c.idcidade
                                             INNER JOIN estado e ON e.idestado = c.idestado
                                             WHERE p.idpessoa = (SELECT min(idpessoa) FROM pessoa WHERE idpessoa > @idpessoa)", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idpessoa", codAtual);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa"))
                        };

                        subgrupopessoa = new SubGrupoPessoa
                        {
                            SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idsubgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomesubgrupopessoa"))
                        };

                        estado = new Estado
                        {
                            EstadoID = reader.GetInt32(reader.GetOrdinal("idestado")),
                            Nome = reader.GetString(reader.GetOrdinal("nomeestado")),
                            Uf = reader.GetString(reader.GetOrdinal("uf"))
                        };

                        cidade = new Cidade
                        {
                            CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade")),
                            Nome = reader.GetString(reader.GetOrdinal("nomecidade")),
                            Estado = estado
                        };

                        pessoa = new Pessoa
                        {
                            PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomepessoa")),
                            Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                            TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                            Rua = reader.GetString(reader.GetOrdinal("rua")),
                            Numero = reader.GetString(reader.GetOrdinal("numero")),
                            Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                            Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                            Cidade = cidade,
                            Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                            Email = reader.GetString(reader.GetOrdinal("email")),
                            SubGrupoPessoa = subgrupopessoa,
                            Atuacao = reader.GetString(reader.GetOrdinal("atuacao")),
                            Situacao = reader.GetString(reader.GetOrdinal("situacao"))
                        };
                        pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    }
                    else
                    {
                        pessoa = null;
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
            return pessoa;
        }

        public Pessoa BuscaAnterior(string codAtual)
        {
            Pessoa pessoa = new Pessoa();
            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = null;
            Estado estado = null;
            Cidade cidade = null;

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                                             e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                                             p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                                             telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao
                                             FROM pessoa p
                                             INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                                             INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                                             INNER JOIN cidade c ON p.idcidade = c.idcidade
                                             INNER JOIN estado e ON e.idestado = c.idestado
                                             WHERE p.idpessoa = (SELECT max(idpessoa) FROM pessoa WHERE idpessoa < @idpessoa)", Connect.Conexao);

                Connect.Comando.Parameters.AddWithValue("@idpessoa", codAtual);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa"))
                        };

                        subgrupopessoa = new SubGrupoPessoa
                        {
                            SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idsubgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomesubgrupopessoa"))
                        };

                        estado = new Estado
                        {
                            EstadoID = reader.GetInt32(reader.GetOrdinal("idestado")),
                            Nome = reader.GetString(reader.GetOrdinal("nomeestado")),
                            Uf = reader.GetString(reader.GetOrdinal("uf"))
                        };

                        cidade = new Cidade
                        {
                            CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade")),
                            Nome = reader.GetString(reader.GetOrdinal("nomecidade")),
                            Estado = estado
                        };

                        pessoa = new Pessoa
                        {
                            PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomepessoa")),
                            Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                            TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                            Rua = reader.GetString(reader.GetOrdinal("rua")),
                            Numero = reader.GetString(reader.GetOrdinal("numero")),
                            Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                            Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                            Cidade = cidade,
                            Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                            Email = reader.GetString(reader.GetOrdinal("email")),
                            SubGrupoPessoa = subgrupopessoa,
                            Atuacao = reader.GetString(reader.GetOrdinal("atuacao")),
                            Situacao = reader.GetString(reader.GetOrdinal("situacao"))
                        };
                        pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));
                    }
                    else
                    {
                        pessoa = null;
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
            return pessoa;
        }

        public List<Pessoa> Busca(string nome, string cpfCnpj, int idcidade)
        {
            Pessoa pessoa = null;
            SubGrupoPessoa subgrupopessoa = null;
            GrupoPessoa grupopessoa = null;
            Estado estado = null;
            Cidade cidade = null;
            List<Pessoa> listapessoas = new List<Pessoa>();
            List<string> listaatuacoes = new List<string>();

            string conCodPessoa = nome.Length > 0 ? "AND p.nome LIKE @nome" : "";
            string conCpfCnpj = cpfCnpj.Length > 0 ? "AND (cpf LIKE @cpfcnpj OR cnpj LIKE @cpfcnpj)" : "";
            string conCidade = idcidade > 0 ? "AND idcidade = @idcidade" : "";

            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                                             e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                                             p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                                             telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao
                                             FROM pessoa p
                                             INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                                             INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                                             INNER JOIN cidade c ON p.idcidade = c.idcidade
                                             INNER JOIN estado e ON e.idestado = c.idestado
                                             WHERE 1=1
                                             " + conCodPessoa + @"
                                             " + conCpfCnpj + @"
                                             " + conCidade + @"
                                             ORDER BY idpessoa", Connect.Conexao);

                if (conCodPessoa.Length > 0) { Connect.Comando.Parameters.AddWithValue("@nome", "%" + nome + "%"); }
                if (conCpfCnpj.Length > 0) { Connect.Comando.Parameters.AddWithValue("@cpfcnpj", "%" + cpfCnpj + "%"); }
                if (conCidade.Length > 0) { Connect.Comando.Parameters.AddWithValue("@idcidade", idcidade); }

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        grupopessoa = new GrupoPessoa
                        {
                            GrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomegrupopessoa"))
                        };

                        subgrupopessoa = new SubGrupoPessoa
                        {
                            SubGrupoPessoaID = reader.GetInt32(reader.GetOrdinal("idsubgrupopessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomesubgrupopessoa"))
                        };

                        estado = new Estado
                        {
                            EstadoID = reader.GetInt32(reader.GetOrdinal("idestado")),
                            Nome = reader.GetString(reader.GetOrdinal("nomeestado")),
                            Uf = reader.GetString(reader.GetOrdinal("uf"))
                        };

                        cidade = new Cidade
                        {
                            CidadeID = reader.GetInt32(reader.GetOrdinal("idcidade")),
                            Nome = reader.GetString(reader.GetOrdinal("nomecidade")),
                            Estado = estado
                        };

                        pessoa = new Pessoa
                        {
                            PessoaID = reader.GetInt32(reader.GetOrdinal("idpessoa")),
                            Nome = reader.GetString(reader.GetOrdinal("nomepessoa")),
                            Fantasia = reader.GetString(reader.GetOrdinal("fantasia")),
                            TipoPessoa = reader.GetString(reader.GetOrdinal("tipo_pessoa")),
                            Rua = reader.GetString(reader.GetOrdinal("rua")),
                            Numero = reader.GetString(reader.GetOrdinal("numero")),
                            Bairro = reader.GetString(reader.GetOrdinal("bairro")),
                            Complemento = reader.GetString(reader.GetOrdinal("complemento")),
                            Cidade = cidade,
                            Telefone = reader.GetString(reader.GetOrdinal("telefone")),
                            Email = reader.GetString(reader.GetOrdinal("email")),
                            SubGrupoPessoa = subgrupopessoa,
                            Atuacao = reader.GetString(reader.GetOrdinal("atuacao")),
                            Situacao = reader.GetString(reader.GetOrdinal("situacao"))

                        };
                        pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? reader.GetString(reader.GetOrdinal("cpf")) : reader.GetString(reader.GetOrdinal("cnpj"));

                        listapessoas.Add(pessoa);

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
            return listapessoas;
        }


        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand(@"SELECT p1.idpessoa + 1 AS proximoid
                                             FROM pessoa AS p1
                                             LEFT OUTER JOIN pessoa AS p2 ON p1.idpessoa + 1 = p2.idpessoa
                                             WHERE p2.idpessoa IS NULL
                                             ORDER BY proximoid
                                             LIMIT 1;", Connect.Conexao);

                using (var reader = Connect.Comando.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        proximoid = reader.GetInt32(reader.GetOrdinal("proximoid"));
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

            return proximoid;
        }

        public void Lock(int codigo, Logado logado)
        {
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("INSERT INTO 5gprodatabase.lock (idusuario, tabela, codigo_registro) VALUES (@idusuario, @tabela, @codigo_registro)", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idusuario", logado.Usuario.UsuarioID);
                Connect.Comando.Parameters.AddWithValue("@tabela", "pessoa");
                Connect.Comando.Parameters.AddWithValue("@codigo_registro", codigo);

                Connect.Comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
        }

        public void Unlock(int codigo, Logado logado)
        {
            try
            {
                Connect.AbrirConexao();
                Connect.Comando = new MySqlCommand("DELETE FROM 5gprodatabase.lock WHERE tabela = @tabela AND codigo_registro = @codigo_registro AND idusuario = @idusuario", Connect.Conexao);
                Connect.Comando.Parameters.AddWithValue("@idusuario", logado.Usuario.UsuarioID);
                Connect.Comando.Parameters.AddWithValue("@tabela", "pessoa");
                Connect.Comando.Parameters.AddWithValue("@codigo_registro", codigo);

                Connect.Comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                Connect.FecharConexao();
            }
        }
    }
}
