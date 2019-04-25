using System;

namespace _5gpro.Entities
{
    class Parcela
    {
        public int ParcelaID { get; set; }

        public DateTime DataVencimento { get; set; }

        public decimal Valor { get; set; }

        public decimal Multa { get; set; }

        public decimal Juros { get; set; }

        public DateTime? DataQuitacao { get; set; }
    }
}
