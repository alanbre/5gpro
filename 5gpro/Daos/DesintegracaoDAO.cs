using _5gpro.Entities;
using MySQLConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Daos
{
    class DesintegracaoDAO
    {
        private static readonly ConexaoDAO Connect = new ConexaoDAO();

        //public int SalvaOuAtualiza(Item item)
        //{

        //}

        public Desintegracao BuscaByID(int Codigo)
        {

            var desintegracao = new Desintegracao();
            using (MySQLConn sql = new MySQLConn(Connect.Conecta))
            {
                sql.Query = @"SELECT * FROM desintegracao d
                              INNER JOIN resultado_desintegracao r 
                              ON d.iddesintegracao = r.iddesintegracao
                              INNER JOIN item i 
                              ON r.iditemparte = i.iditem
                              WHERE d.iddesintegracao = @iddesintegracao";

                sql.addParam("@iddesintegracao", Codigo);

                var data = sql.selectQuery();
                if (data == null)
                {
                    return null;
                }
                desintegracao = LeDadosReader(data);
            }
            return desintegracao;

        }

        //public Item Anterior(int Codigo)
        //{ }

        //public Item Proximo(int Codigo)
        //{ }


        private Desintegracao LeDadosReader(List<Dictionary<string, object>> data)
        {
            if (data.Count == 0)
            {
                return null;
            }

            List<DesintegracaoResultado> listapartes = new List<DesintegracaoResultado>();
            var desintegracao = new Desintegracao();
            var item = new Item();

            item.ItemID = Convert.ToInt32(data[0]["iditemdesintegrado"]);

            desintegracao.DesintegracaoID = Convert.ToInt32(data[0]["iddesintegracao"]);
            desintegracao.Itemdesintegrado = item;

            foreach (var p in data)
            {
                var parte = new DesintegracaoResultado();
                item = new Item();
                item.ItemID = Convert.ToInt32(p["iditemparte"]);
                item.Descricao = (string)p["descitem"];
                parte.Desintegracao = desintegracao;
                parte.Item = item;
                parte.Porcentagem = (decimal)p["porcentagem"];
                listapartes.Add(parte);
            }

            desintegracao.Partes = listapartes;
            return desintegracao;

        }

    }
}
