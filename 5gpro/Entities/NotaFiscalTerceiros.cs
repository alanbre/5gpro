using System;
using System.Collections.Generic;

namespace _5gpro.Entities
{
    public class NotaFiscalTerceiros
    {
        public NotaFiscalTerceiros()
        {
            NotaFiscalTerceirosItem = new HashSet<NotaFiscalTerceirosItem>();
        }

        public int NotaFiscalTerceirosID { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntradaSaida { get; set; }

        public decimal ValorTotalItens { get; set; }
        public decimal ValorTotalDocumento { get; set; }
        public decimal DescontoTotalItens { get; set; }
        public decimal DescontoDocumento { get; set; }

        public virtual ICollection<NotaFiscalTerceirosItem> NotaFiscalTerceirosItem { get; set; }
    }
}
