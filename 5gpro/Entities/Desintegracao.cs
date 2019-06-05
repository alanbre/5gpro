using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class Desintegracao
    {
        public int DesintegracaoID { get; set; }
        public Item Itemdesintegrado { get; set; }
        public List<DesintegracaoResultado> Partes { get; set; }
    }
}
