using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace _5gpro.Entities
{
    class _Item
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string DescCompra { get; set; }
        public string TipoItem { get; set; }
        public string Referencia { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorSaida { get; set; }
        public decimal Estoquenecessario { get; set; }
        public string Unimedida { get; set; }


        public _Item()
        {

        }

        public _Item(string codigo, string descricao, string desccompra, string tipoitem, string referencia, decimal valorentrada, decimal valorsaida, decimal estoquenecessario, string unimedida)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.DescCompra = desccompra;
            this.TipoItem = tipoitem;
            this.Referencia = referencia;
            this.ValorEntrada = valorentrada;
            this.ValorSaida = valorsaida;
            this.Estoquenecessario = estoquenecessario;
            this.Unimedida = unimedida;

        }
    }
}
