using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    class _Item
    {
        public string Iditem { get; set; }
        public string Descricao { get; set; }
        public string DenomCompra { get; set; }
        public string TipoItem { get; set; }
        public string Referencia { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorSaida { get; set; }
        public decimal Estoquenecessario { get; set; }
        public int Unimedida { get; set; }
    }
}
