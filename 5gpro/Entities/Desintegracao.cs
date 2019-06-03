using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    class Desintegracao
    {
        public int DesintegracaoID { get; set; }
        public Item Parteitem { get; set; }
        public Item Iteminteiro { get; set; }
        public decimal Porcentagem { get; set; }
    }
}
