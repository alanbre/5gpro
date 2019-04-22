using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
   public class Operacao
    {
        public int OperacaoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Condicao { get; set; }
        public decimal Desconto { get; set; }
        public decimal Entrada { get; set; }
        public decimal Acrescimo { get; set; }
        public List<ParcelaOperacao> Parcelas { get; set; }
    }
}
