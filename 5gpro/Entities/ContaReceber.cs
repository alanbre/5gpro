 using System;
using System.Collections.Generic;

namespace _5gpro.Entities
{
    public class ContaReceber
    {
        public ContaReceber()
        {
            Parcelas = new HashSet<Parcela>();
        }


        public int ContaReceberID { get; set; }

        public DateTime DataCadastro { get; set; }

        public Operacao Operacao { get; set; }

        public decimal ValorOriginal { get; set; }

        public decimal Multa { get; set; }

        public decimal Juros { get; set; }

        public decimal ValorFinal { get; set; }

        public virtual ICollection<Parcela> Parcelas { get; set; }
    }
}
