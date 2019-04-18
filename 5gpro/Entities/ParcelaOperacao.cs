using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class ParcelaOperacao
    {
        public int ParcelaOperacaoID { get; set; }
        public int Numero { get; set; }
        public int Dias { get; set; }
        public Operacao Operacao { get; set; }
    }
}
