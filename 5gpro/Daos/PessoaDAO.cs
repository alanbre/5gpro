using _5gpro.Entities;
using System;
using System.Collections.Generic;
using MySQLConnection;
using _5gpro.StaticFiles;

namespace _5gpro.Daos
{
    class PessoaDAO
    {
        public int SalvaOuAtualiza(Pessoa pessoa)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"INSERT INTO pessoa
                            (idpessoa, nome, fantasia, rua, numero, bairro, cep, complemento, cpf, cnpj, endereco,
                            telefone, email, idcidade, tipo_pessoa, idsubgrupopessoa, atuacao, situacao, idusuario,
                            idbanco, agencia, conta, tipoconta)
                            VALUES
                            (@idpessoa, @nome, @fantasia, @rua, @numero, @bairro, @cep, @complemento, @cpf, @cnpj, @endereco,
                            @telefone, @email, @idcidade, @tipoPessoa, @idsubgrupopessoa, @atuacao, @situacao, @idusuario,
                            @idbanco, @agencia, @conta, @tipoconta)
                            ON DUPLICATE KEY UPDATE
                            nome = @nome, fantasia = @fantasia, rua = @rua, numero = @numero, bairro = @bairro, cep = @cep,
                            complemento = @complemento, cpf = @cpf, cnpj = @cnpj, endereco = @endereco, telefone = @telefone,
                            email = @email, idcidade = @idcidade, tipo_pessoa = @tipoPessoa, idsubgrupopessoa = @idsubgrupopessoa,
                            atuacao = @atuacao, situacao = @situacao, idusuario = @idusuario, idbanco = @idbanco, agencia = @agencia,
                            conta = @conta, tipoconta = @tipoconta";
                sql.addParam("@idpessoa", pessoa.PessoaID);
                sql.addParam("@nome", pessoa.Nome);
                sql.addParam("@fantasia", pessoa.Fantasia);
                sql.addParam("@rua", pessoa.Rua);
                sql.addParam("@numero", pessoa.Numero);
                sql.addParam("@bairro", pessoa.Bairro);
                sql.addParam("@cep", pessoa.Cep);
                sql.addParam("@complemento", pessoa.Complemento);
                sql.addParam("@atuacao", pessoa.Atuacao);
                sql.addParam("@situacao", pessoa.Situacao);
                sql.addParam("@idusuario", Logado.Usuario.UsuarioID);

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
                sql.addParam("@idbanco", pessoa.Banco?.BancoID);
                sql.addParam("@agencia", pessoa.Agencia);
                sql.addParam("@conta", pessoa.ContaBancaria);
                sql.addParam("@tipoconta", pessoa.TipoContaBancaria);

                retorno = sql.insertQuery();
            }
            return retorno;
        }
        public Pessoa BuscaByID(int cod)
        {
            var pessoa = new Pessoa();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                            e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                            p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                            telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao, p.cep, p.agencia, p.conta,
                            p.tipoconta,
                            b.idbanco, b.codigo AS b_codigo, b.nome AS b_nome
                            FROM pessoa p
                            INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                            INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                            INNER JOIN cidade c ON p.idcidade = c.idcidade
                            INNER JOIN estado e ON e.idestado = c.idestado
                            LEFT JOIN banco b ON p.idbanco = b.idbanco
                            WHERE p.idpessoa = @idpessoa
                            LIMIT 1";
                sql.addParam("@idpessoa", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                pessoa = LeDadosReader(data);
            }
            return pessoa;
        }
        public Pessoa BuscaByID(int cod, int atuacao)
        {
            var pessoa = new Pessoa();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                            e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                            p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                            telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao, p.cep, p.agencia, p.conta,
                            p.tipoconta,
                            b.idbanco, b.codigo AS b_codigo, b.nome AS b_nome
                            FROM pessoa p
                            INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                            INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                            INNER JOIN cidade c ON p.idcidade = c.idcidade
                            INNER JOIN estado e ON e.idestado = c.idestado
                            LEFT JOIN banco b ON p.idbanco = b.idbanco
                            WHERE p.idpessoa = @idpessoa AND p.atuacao LIKE @atuacao
                            LIMIT 1";
                sql.addParam("@idpessoa", cod);
                switch (atuacao)
                {
                    case 1:
                        sql.addParam("@atuacao", "%C%");
                        break;
                    case 2:
                        sql.addParam("@atuacao", "%F%");
                        break;
                    case 3:
                        sql.addParam("@atuacao", "%V%");
                        break;
                }
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                pessoa = LeDadosReader(data);
            }
            return pessoa;
        }
        public Pessoa Proximo(int cod)
        {
            var pessoa = new Pessoa();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                            e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                            p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                            telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao, p.cep, p.agencia, p.conta,
                            p.tipoconta,
                            b.idbanco, b.codigo AS b_codigo, b.nome AS b_nome
                            FROM pessoa p
                            INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                            INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                            INNER JOIN cidade c ON p.idcidade = c.idcidade
                            INNER JOIN estado e ON e.idestado = c.idestado
                            LEFT JOIN banco b ON p.idbanco = b.idbanco
                            WHERE p.idpessoa = (SELECT min(idpessoa) FROM pessoa WHERE idpessoa > @idpessoa)
                            LIMIT 1";
                sql.addParam("@idpessoa", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                pessoa = LeDadosReader(data);
            }
            return pessoa;
        }
        public Pessoa Anterior(int cod)
        {
            var pessoa = new Pessoa();
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = @"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                            e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                            p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                            telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao, p.cep, p.agencia, p.conta,
                            p.tipoconta,
                            b.idbanco, b.codigo AS b_codigo, b.nome AS b_nome
                            FROM pessoa p
                            INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                            INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                            INNER JOIN cidade c ON p.idcidade = c.idcidade
                            INNER JOIN estado e ON e.idestado = c.idestado
                            LEFT JOIN banco b ON p.idbanco = b.idbanco
                            WHERE p.idpessoa = (SELECT max(idpessoa) FROM pessoa WHERE idpessoa < @idpessoa)
                            LIMIT 1";
                sql.addParam("@idpessoa", cod);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                pessoa = LeDadosReader(data);
            }
            return pessoa;
        }
        public List<Pessoa> Busca(string nome, string cpfCnpj, int idcidade, int atuacao)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            string conCodPessoa = nome.Length > 0 ? "AND p.nome LIKE @nome" : "";
            string conCpfCnpj = cpfCnpj.Length > 0 ? "AND (cpf LIKE @cpfcnpj OR cnpj LIKE @cpfcnpj)" : "";
            string conCidade = idcidade > 0 ? "AND c.idcidade = @idcidade" : "";
            string conAtuacao = atuacao > 0 ? "AND p.atuacao LIKE @atuacao" : "";


            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
            {
                sql.Query = $@"SELECT g.idgrupopessoa, g.nome AS nomegrupopessoa, s.idsubgrupopessoa, s.nome AS nomesubgrupopessoa,
                                             e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                                             p.idpessoa, p.nome AS nomepessoa, fantasia, tipo_pessoa, rua, numero, bairro, complemento, 
                                             telefone, email, p.cpf, p.cnpj, p.atuacao, p.situacao, p.cep
                                             FROM pessoa p
                                             INNER JOIN subgrupopessoa s ON s.idsubgrupopessoa = p.idsubgrupopessoa
                                             INNER JOIN grupopessoa g ON g.idgrupopessoa = s.idgrupopessoa
                                             INNER JOIN cidade c ON p.idcidade = c.idcidade
                                             INNER JOIN estado e ON e.idestado = c.idestado
                                             WHERE 1=1 
                                             { conCodPessoa } 
                                             { conCpfCnpj } 
                                             { conCidade } 
                                             { conAtuacao } 
                                             ORDER BY p.idpessoa";
                if (conCodPessoa.Length > 0) { sql.addParam("@nome", "%" + nome + "%"); }
                if (conCpfCnpj.Length > 0) { sql.addParam("@cpfcnpj", "%" + cpfCnpj + "%"); }
                if (conCidade.Length > 0) { sql.addParam("@idcidade", idcidade); }
                switch (atuacao)
                {
                    case 1:
                        sql.addParam("@atuacao", "%C%");
                        break;
                    case 2:
                        sql.addParam("@atuacao", "%F%");
                        break;
                    case 3:
                        sql.addParam("@atuacao", "%V%");
                        break;
                }
                var data = sql.selectQuery();
                foreach (var d in data)
                {
                    var grupopessoa = new GrupoPessoa
                    {
                        GrupoPessoaID = Convert.ToInt32(d["idgrupopessoa"]),
                        Nome = (string)d["nomegrupopessoa"]
                    };
                    var subgrupopessoa = new SubGrupoPessoa
                    {
                        SubGrupoPessoaID = Convert.ToInt32(d["idsubgrupopessoa"]),
                        Nome = (string)d["nomesubgrupopessoa"],
                        GrupoPessoa = grupopessoa
                    };
                    var estado = new Estado
                    {
                        EstadoID = Convert.ToInt32(d["idestado"]),
                        Nome = (string)d["nomeestado"],
                        Uf = (string)d["uf"]
                    };

                    var cidade = new Cidade
                    {
                        CidadeID = Convert.ToInt32(d["idcidade"]),
                        Nome = (string)d["nomecidade"],
                        Estado = estado
                    };

                    var pessoa = new Pessoa
                    {
                        PessoaID = Convert.ToInt32(d["idpessoa"]),
                        Nome = (string)d["nomepessoa"],
                        Fantasia = (string)d["fantasia"],
                        TipoPessoa = (string)d["tipo_pessoa"],
                        Rua = (string)d["rua"],
                        Numero = (string)d["numero"],
                        Bairro = (string)d["bairro"],
                        Cep = (string)d["cep"],
                        Complemento = (string)d["complemento"],
                        Cidade = cidade,
                        Telefone = (string)d["telefone"],
                        Email = (string)d["email"],
                        SubGrupoPessoa = subgrupopessoa,
                        Atuacao = (string)d["atuacao"],
                        Situacao = (string)d["situacao"]
                    };
                    pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? (string)d["cpf"] : (string)d["cnpj"];
                    pessoas.Add(pessoa);
                }
                return pessoas;
            }
        }
        public int BuscaProxCodigoDisponivel()
        {
            int proximoid = 1;
            using (MySQLConn sql = new MySQLConn(Configuracao.Conecta))
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
                    proximoid = Convert.ToInt32(data["proximoid"]);
                }
            }
            return proximoid;
        }
        private Pessoa LeDadosReader(Dictionary<string, object> data)
        {
            var grupopessoa = new GrupoPessoa();
            grupopessoa.GrupoPessoaID = Convert.ToInt32(data["idgrupopessoa"]);
            grupopessoa.Nome = (string)data["nomegrupopessoa"];

            var subgrupopessoa = new SubGrupoPessoa();
            subgrupopessoa.SubGrupoPessoaID = Convert.ToInt32(data["idsubgrupopessoa"]);
            subgrupopessoa.Nome = (string)data["nomesubgrupopessoa"];
            subgrupopessoa.GrupoPessoa = grupopessoa;


            var estado = new Estado();
            estado.EstadoID = Convert.ToInt32(data["idestado"]);
            estado.Nome = (string)data["nomeestado"];
            estado.Uf = (string)data["uf"];


            var cidade = new Cidade();
            cidade.CidadeID = Convert.ToInt32(data["idcidade"]);
            cidade.Nome = (string)data["nomecidade"];
            cidade.Estado = estado;

            var banco = new Banco();
            banco.BancoID = Convert.ToInt32(data["idbanco"]);
            banco.Codigo = (string)data["b_codigo"];
            banco.Nome = (string)data["b_nome"];

            var pessoa = new Pessoa();
            pessoa.PessoaID = Convert.ToInt32(data["idpessoa"]);
            pessoa.Nome = (string)data["nomepessoa"];
            pessoa.Fantasia = (string)data["fantasia"];
            pessoa.TipoPessoa = (string)data["tipo_pessoa"];
            pessoa.Rua = (string)data["rua"];
            pessoa.Numero = (string)data["numero"];
            pessoa.Bairro = (string)data["bairro"];
            pessoa.Cep = (string)data["cep"];
            pessoa.Complemento = (string)data["complemento"];
            pessoa.Cidade = cidade;
            pessoa.Telefone = (string)data["telefone"];
            pessoa.Email = (string)data["email"];
            pessoa.SubGrupoPessoa = subgrupopessoa;
            pessoa.Atuacao = (string)data["atuacao"];
            pessoa.Situacao = (string)data["situacao"];
            pessoa.Banco = banco;
            pessoa.Agencia = (string)data["agencia"];
            pessoa.ContaBancaria = (string)data["conta"];
            pessoa.TipoContaBancaria = (string)data["tipoconta"];
            pessoa.CpfCnpj = pessoa.TipoPessoa == "F" ? (string)data["cpf"] : (string)data["cnpj"];

            return pessoa;
        }
    }
}
