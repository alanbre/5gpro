using _5gpro.Entities;
using MySQLConnection;
using System.Collections.Generic;

namespace _5gpro.Daos
{
    class CaixaDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        public int SalvaOuAtualiza(Caixa caixa)
        {
            var retorno = 0;
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"INSERT INTO caixa 
                            (codigo, nome, descricao) 
                            VALUES
                            (@codigo, nome, descricao)
                            ON DUPLICATE KEY UPDATE
                            nome = @nome, descricao = @descricao";
                sql.addParam("@codigo", caixa.Codigo);
                sql.addParam("@nome", caixa.Nome);
                sql.addParam("@descricao", caixa.Descricao);
                retorno = sql.insertQuery();
            }
            return retorno;
        }

        public Caixa Busca(int Codigo)
        {
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM caixa WHERE codigo = @codigo";
                sql.addParam("@codigo", Codigo);
                var data = sql.selectQueryForSingleRecord();
                if (data == null)
                {
                    return null;
                }
                return LeDadosReader(data);
            }
        }

        private Caixa LeDadosReader(Dictionary<string, object> data)
        {
            var caixa = new Caixa();
            return caixa;
        }
    }
}
