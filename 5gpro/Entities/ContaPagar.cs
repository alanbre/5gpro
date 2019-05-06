using System;
using System.Collections.Generic;

namespace _5gpro.Entities
{
    public class ContaPagar
    {
        public ContaPagar()
        {
            Parcelas = new HashSet<ParcelaContaPagar>();
        }

        public int ContaPagarID { get; set; }
        public DateTime DataCadastro { get; set; }
        public Pessoa Pessoa { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal Multa { get; set; }
        public decimal Juros { get; set; }
        public decimal ValorFinal { get; set; }
        public virtual ICollection<ParcelaContaPagar> Parcelas { get; set; }
    }
}
