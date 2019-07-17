using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class EstabelecimentoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();
        public int SalvaOuAtualiza(Estabelecimento estabelecimento)
        {
            int retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"INSERT INTO estabelecimento
                         (idestabelecimento, nome, fantasia, rua, numero, bairro, complemento, cnpj, telefone, email, idcidade)
                          VALUES
                         (@idestabelecimento, @nome, @fantasia, @rua, @numero, @bairro, @complemento, @cnpj, @telefone, @email, @idcidade)
                          ON DUPLICATE KEY UPDATE
                          nome = @nome, fantasia = @fantasia, rua = @rua, numero = @numero, bairro = @bairro, complemento = @complemento,
                          cnpj = @cnpj, telefone = @telefone, email = @email, idcidade = @idcidade";
                sql.addParam("@idestabelecimento", 1);
                sql.addParam("@nome", estabelecimento.Nome);
                sql.addParam("@fantasia", estabelecimento.Fantasia);
                sql.addParam("@rua", estabelecimento.Rua);
                sql.addParam("@numero", estabelecimento.Numero);
                sql.addParam("@bairro", estabelecimento.Bairro);
                sql.addParam("@complemento", estabelecimento.Complemento);
                sql.addParam("@cnpj", estabelecimento.CpfCnpj);
                sql.addParam("@telefone", estabelecimento.Telefone);
                sql.addParam("@email", estabelecimento.Email);
                sql.addParam("@idcidade", estabelecimento.Cidade.CidadeID);

                retorno = sql.insertQuery();
            }
            return retorno;
        }

        public Estabelecimento Busca()
        {
            Estabelecimento estabelecimento = null;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT e.idestado, e.nome AS nomeestado, uf, c.idcidade, c.nome AS nomecidade,
                            est.idestabelecimento, est.nome AS nomeestabelecimento, fantasia, rua, numero, bairro, complemento, 
                            telefone, email, est.cnpj
                            FROM estabelecimento est
                            INNER JOIN cidade c ON est.idcidade = c.idcidade
                            INNER JOIN estado e ON e.idestado = c.idestado
                            LIMIT 1";
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return estabelecimento;
                }

                var estado = new Estado
                {
                    EstadoID = Convert.ToInt32(data["idestado"]),
                    Nome = (string)data["nomeestado"],
                    Uf = (string)data["uf"]
                };

                var cidade = new Cidade
                {
                    CidadeID = Convert.ToInt32(data["idcidade"]),
                    Nome = (string)data["nomecidade"],
                    Estado = estado
                };

                estabelecimento = new Estabelecimento();
                estabelecimento.EstabelecimentoID = Convert.ToInt32(data["idestabelecimento"]);
                estabelecimento.Nome = (string)data["nomeestabelecimento"];
                estabelecimento.Fantasia = (string)data["fantasia"];
                estabelecimento.Rua = (string)data["rua"];
                estabelecimento.Numero = (string)data["numero"];
                estabelecimento.Bairro = (string)data["bairro"];
                estabelecimento.Complemento = (string)data["complemento"];
                estabelecimento.Cidade = cidade;
                estabelecimento.Telefone = (string)data["telefone"];
                estabelecimento.Email = (string)data["email"];
                estabelecimento.CpfCnpj = (string)data["cnpj"];
            }
            return estabelecimento;
        }
    }
}
