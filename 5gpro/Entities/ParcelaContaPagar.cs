﻿using System;

namespace _5gpro.Entities
{
    public class ParcelaContaPagar
    {
        public int ParcelaContaPagarID { get; set; }

        public int Sequencia { get; set; }

        public DateTime DataVencimento { get; set; }

        public decimal Valor { get; set; }

        public decimal Multa { get; set; }

        public decimal Juros { get; set; }

        public decimal ValorFinal
        {
            get
            {
                return this.Valor + this.Multa + this.Juros;
            }
        }

        public DateTime? DataQuitacao { get; set; }

        public FormaPagamento FormaPagamento { get; set; }
    }
}