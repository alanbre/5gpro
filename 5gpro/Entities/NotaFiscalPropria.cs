using System;
using System.Collections.Generic;

namespace _5gpro.Entities
{
    public class NotaFiscalPropria
    {
        public NotaFiscalPropria()
        {
            NotaFiscalItem = new HashSet<NotaFiscalPropriaItem>();
        }

        public int NotaFiscalPropriaID { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntradaSaida { get; set; }

        public decimal ValorTotalItens { get; set; }
        public decimal ValorTotalDocumento { get; set; }
        public decimal DescontoTotalItens { get; set; }
        public decimal DescontoDocumento { get; set; }

        public virtual ICollection<NotaFiscalPropriaItem> NotaFiscalItem { get; set; }
    }
}
