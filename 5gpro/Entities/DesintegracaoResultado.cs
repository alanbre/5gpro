using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    class DesintegracaoResultado
    {
        public int DesintegracaoResultadoID { get; set; }
        public Desintegracao Desintegracao { get; set; }
        public Item Item { get; set; }
        public decimal Porcentagem { get; set; }
    }
}
