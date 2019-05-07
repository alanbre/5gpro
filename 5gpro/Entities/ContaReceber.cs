﻿ using System;
using System.Collections.Generic;

namespace _5gpro.Entities
{
    public class ContaReceber
    {
        public ContaReceber()
        {
            Parcelas = new HashSet<ParcelaContaReceber>();
        }

        public int ContaReceberID { get; set; }
        public DateTime DataCadastro { get; set; }
        public Pessoa Pessoa { get; set; }
        public Operacao Operacao { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal Multa { get; set; }
        public decimal Juros { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal ValorFinal { get; set; }
        public virtual ICollection<ParcelaContaReceber> Parcelas { get; set; }
    }
}
