using _5gpro.Entities;
using MySQLConnection;
using System;

namespace _5gpro.Daos
{
    public class EstabelecimentoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();
        public int SalvaOuAtualiza()
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
                sql.addParam("@nome", Estabelecimento.Nome);
                sql.addParam("@fantasia", Estabelecimento.Fantasia);
                sql.addParam("@rua", Estabelecimento.Rua);
                sql.addParam("@numero", Estabelecimento.Numero);
                sql.addParam("@bairro", Estabelecimento.Bairro);
                sql.addParam("@complemento", Estabelecimento.Complemento);
                sql.addParam("@cnpj", Estabelecimento.CpfCnpj);
                sql.addParam("@telefone", Estabelecimento.Telefone);
                sql.addParam("@email", Estabelecimento.Email);
                sql.addParam("@idcidade", Estabelecimento.Cidade.CidadeID);

                retorno = sql.insertQuery();
            }
            return retorno;
        }

        public void Busca()
        {
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
                if (data == null) return;

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

                Estabelecimento.EstabelecimentoID = Convert.ToInt32(data["idestabelecimento"]);
                Estabelecimento.Nome = (string)data["nomeestabelecimento"];
                Estabelecimento.Fantasia = (string)data["fantasia"];
                Estabelecimento.Rua = (string)data["rua"];
                Estabelecimento.Numero = (string)data["numero"];
                Estabelecimento.Bairro = (string)data["bairro"];
                Estabelecimento.Complemento = (string)data["complemento"];
                Estabelecimento.Cidade = cidade;
                Estabelecimento.Telefone = (string)data["telefone"];
                Estabelecimento.Email = (string)data["email"];
                Estabelecimento.CpfCnpj = (string)data["cnpj"];
            }
        }
    }
}
