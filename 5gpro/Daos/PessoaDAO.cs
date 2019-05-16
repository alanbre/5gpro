using _5gpro.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using MySQLConnection;

namespace _5gpro.Daos
{
    class PessoaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();


        public int SalvaOuAtualiza(Pessoa pessoa)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"INSERT INTO pessoa
                         (idpessoa, nome, fantasia, rua, numero, bairro, complemento, cpf, cnpj, endereco, telefone, email, idcidade, tipo_pessoa, idsubgrupopessoa, atuacao, situacao)
                          VALUES
                         (@idpessoa, @nome, @fantasia, @rua, @numero, @bairro, @complemento, @cpf, @cnpj, @endereco, @telefone, @email, @idcidade, @tipoPessoa, @idsubgrupopessoa, @atuacao, @situacao)
                          ON DUPLICATE KEY UPDATE
                          nome = @nome, fantasia = @fantasia, rua = @rua, numero = @numero, bairro = @bairro, complemento = @complemento,
                          cpf = @cpf, cnpj = @cnpj, endereco = @endereco, telefone = @telefone, email = @email, idcidade = @idcidade, tipo_pessoa = @tipoPessoa, idsubgrupopessoa = @idsubgrupopessoa,
                          atuacao = @atuacao, situacao = @situacao
                          ";
                sql.addParam("@idpessoa", pessoa.PessoaID);
                sql.addParam("@nome", pessoa.Nome);
                sql.addParam("@fantasia", pessoa.Fantasia);
                sql.addParam("@rua", pessoa.Rua);
                sql.addParam("@numero", pessoa.Numero);
                sql.addParam("@bairro", pessoa.Bairro);
                sql.addParam("@complemento", pessoa.Complemento);
                sql.addParam("@atuacao", pessoa.Atuacao);
                sql.addParam("@situacao", pessoa.Situacao);

                if (pessoa.TipoPessoa == "F")
                {
                    sql.addParam("@cpf", pessoa.CpfCnpj);
                    sql.addParam("@cnpj", "");
                }
                else
                {
                    sql.addParam("@cpf", "");
                    sql.addParam("@cnpj", pessoa.CpfCnpj);
                }
                sql.addParam("@endereco", pessoa.Rua + ", " + pessoa.Numero + "-" + pessoa.Bairro);
                sql.addParam("@telefone", pessoa.Telefone);
                sql.addParam("@email", pessoa.Email);
                sql.addParam("@idcidade", pessoa.Cidade.CidadeID);
                sql.addParam("@tipoPessoa", pessoa.TipoPessoa);
                sql.addParam("@idsubgrupopessoa", pessoa.SubGrupoPessoa.SubGrupoPessoaID);

                retorno = sql.insertQuery();
            }
            return retorno;
        }

        public Pessoa BuscaById(int cod)
        {
            Pessoa pessoa = new Pessoa();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                            e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                            p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                            telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao
                            FROM pessoa p
                            INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                            INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                            INNER JOIN cidade c ON p.idcidade = c.idcidade
                            INNER JOIN estado e ON e.idestado = c.idestado
                            WHERE p.idpessoa = @idpessoa
                            LIMIT 1";
                sql.addParam("@idpessoa", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                var grupopessoa = new GrupoPessoa
                {
                    GrupoPessoaID = int.Parse(data["idgrupopessoa"]),
                    Nome = data["nomegrupopessoa"]
                };
                var subgrupopessoa = new SubGrupoPessoa
                {
                    SubGrupoPessoaID = int.Parse(data["idsubgrupopessoa"]),
                    Nome = data["nomesubgrupopessoa"]
                };
                var estado = new Estado
                {
                    EstadoID = int.Parse(data["idestado"]),
                    Nome = data["nomeestado"],
                    Uf = data["uf"]
                };

                var cidade = new Cidade
                {
                    CidadeID = int.Parse(data["idcidade"]),
                    Nome = data["nomecidade"],
                    Estado = estado
                };

                pessoa = new Pessoa
                {
                    PessoaID = int.Parse(data["idpessoa"]),
                    Nome = data["nomepessoa"],
                    Fantasia = data["fantasia"],
                    TipoPessoa = data["tipo_pessoa"],
                    Rua = data["rua"],
                    Numero = data["numero"],
                    Bairro = data["bairro"],
                    Complemento = data["complemento"],
                    Cidade = cidade,
                    Telefone = data["telefone"],
                    Email = data["email"],
                    SubGrupoPessoa = subgrupopessoa,
                    Atuacao = data["atuacao"],
                    Situacao = data["situacao"]
                };
                pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? data["cpf"] : data["cnpj"];
            }
            return pessoa;
        }

        public Pessoa Proximo(string cod)
        {
            Pessoa pessoa = new Pessoa();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                            e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                            p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                            telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao
                            FROM pessoa p
                            INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                            INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                            INNER JOIN cidade c ON p.idcidade = c.idcidade
                            INNER JOIN estado e ON e.idestado = c.idestado
                            WHERE p.idpessoa = (SELECT min(idpessoa) FROM pessoa WHERE idpessoa > @idpessoa)";
                sql.addParam("@idpessoa", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                var grupopessoa = new GrupoPessoa
                {
                    GrupoPessoaID = int.Parse(data["idgrupopessoa"]),
                    Nome = data["nomegrupopessoa"]
                };
                var subgrupopessoa = new SubGrupoPessoa
                {
                    SubGrupoPessoaID = int.Parse(data["idsubgrupopessoa"]),
                    Nome = data["nomesubgrupopessoa"]
                };
                var estado = new Estado
                {
                    EstadoID = int.Parse(data["idestado"]),
                    Nome = data["nomeestado"],
                    Uf = data["uf"]
                };

                var cidade = new Cidade
                {
                    CidadeID = int.Parse(data["idcidade"]),
                    Nome = data["nomecidade"],
                    Estado = estado
                };

                pessoa = new Pessoa
                {
                    PessoaID = int.Parse(data["idpessoa"]),
                    Nome = data["nomepessoa"],
                    Fantasia = data["fantasia"],
                    TipoPessoa = data["tipo_pessoa"],
                    Rua = data["rua"],
                    Numero = data["numero"],
                    Bairro = data["bairro"],
                    Complemento = data["complemento"],
                    Cidade = cidade,
                    Telefone = data["telefone"],
                    Email = data["email"],
                    SubGrupoPessoa = subgrupopessoa,
                    Atuacao = data["atuacao"],
                    Situacao = data["situacao"]
                };
                pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? data["cpf"] : data["cnpj"];
            }
            return pessoa;
        }

        public Pessoa Anterior(string cod)
        {
            Pessoa pessoa = new Pessoa();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                            e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                            p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                            telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao
                            FROM pessoa p
                            INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                            INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                            INNER JOIN cidade c ON p.idcidade = c.idcidade
                            INNER JOIN estado e ON e.idestado = c.idestado
                            WHERE p.idpessoa = (SELECT max(idpessoa) FROM pessoa WHERE idpessoa < @idpessoa)";
                sql.addParam("@idpessoa", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                var grupopessoa = new GrupoPessoa
                {
                    GrupoPessoaID = int.Parse(data["idgrupopessoa"]),
                    Nome = data["nomegrupopessoa"]
                };
                var subgrupopessoa = new SubGrupoPessoa
                {
                    SubGrupoPessoaID = int.Parse(data["idsubgrupopessoa"]),
                    Nome = data["nomesubgrupopessoa"]
                };
                var estado = new Estado
                {
                    EstadoID = int.Parse(data["idestado"]),
                    Nome = data["nomeestado"],
                    Uf = data["uf"]
                };

                var cidade = new Cidade
                {
                    CidadeID = int.Parse(data["idcidade"]),
                    Nome = data["nomecidade"],
                    Estado = estado
                };

                pessoa = new Pessoa
                {
                    PessoaID = int.Parse(data["idpessoa"]),
                    Nome = data["nomepessoa"],
                    Fantasia = data["fantasia"],
                    TipoPessoa = data["tipo_pessoa"],
                    Rua = data["rua"],
                    Numero = data["numero"],
                    Bairro = data["bairro"],
                    Complemento = data["complemento"],
                    Cidade = cidade,
                    Telefone = data["telefone"],
                    Email = data["email"],
                    SubGrupoPessoa = subgrupopessoa,
                    Atuacao = data["atuacao"],
                    Situacao = data["situacao"]
                };
                pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? data["cpf"] : data["cnpj"];
            }
            return pessoa;
        }

        public List<Pessoa> Busca(string nome, string cpfCnpj, int idcidade)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            string conCodPessoa = nome.Length > 0 ? "AND p.nome LIKE @nome" : "";
            string conCpfCnpj = cpfCnpj.Length > 0 ? "AND (cpf LIKE @cpfcnpj OR cnpj LIKE @cpfcnpj)" : "";
            string conCidade = idcidade > 0 ? "AND idcidade = @idcidade" : "";

            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
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
                                             ORDER BY idpessoa";
                if (conCodPessoa.Length > 0) { sql.addParam("@nome", "%" + nome + "%"); }
                if (conCpfCnpj.Length > 0) { sql.addParam("@cpfcnpj", "%" + cpfCnpj + "%"); }
                if (conCidade.Length > 0) { sql.addParam("@idcidade", idcidade); }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var grupopessoa = new GrupoPessoa
                    {
                        GrupoPessoaID = int.Parse(d["idgrupopessoa"]),
                        Nome = d["nomegrupopessoa"]
                    };
                    var subgrupopessoa = new SubGrupoPessoa
                    {
                        SubGrupoPessoaID = int.Parse(d["idsubgrupopessoa"]),
                        Nome = d["nomesubgrupopessoa"]
                    };
                    var estado = new Estado
                    {
                        EstadoID = int.Parse(d["idestado"]),
                        Nome = d["nomeestado"],
                        Uf = d["uf"]
                    };

                    var cidade = new Cidade
                    {
                        CidadeID = int.Parse(d["idcidade"]),
                        Nome = d["nomecidade"],
                        Estado = estado
                    };

                    var pessoa = new Pessoa
                    {
                        PessoaID = int.Parse(d["idpessoa"]),
                        Nome = d["nomepessoa"],
                        Fantasia = d["fantasia"],
                        TipoPessoa = d["tipo_pessoa"],
                        Rua = d["rua"],
                        Numero = d["numero"],
                        Bairro = d["bairro"],
                        Complemento = d["complemento"],
                        Cidade = cidade,
                        Telefone = d["telefone"],
                        Email = d["email"],
                        SubGrupoPessoa = subgrupopessoa,
                        Atuacao = d["atuacao"],
                        Situacao = d["situacao"]
                    };
                    pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? d["cpf"] : d["cnpj"];
                    pessoas.Add(pessoa);
                }
                return pessoas;
            }
        }


        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT p1.idpessoa + 1 AS proximoid
                            FROM pessoa AS p1
                            LEFT OUTER JOIN pessoa AS p2 ON p1.idpessoa + 1 = p2.idpessoa
                            WHERE p2.idpessoa IS NULL
                            ORDER BY proximoid
                            LIMIT 1";
                var data = sql.selectQueryForSingleRecord();
                if (data != null)
                {
                    proximoid = int.Parse(data["proximoid"]);
                }
            }
            return proximoid;
        }
    }
}
