using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class NotaFiscalTerceirosItem
    {
        public NotaFiscalTerceirosItem()
        {
            this.Quantidade = 0;
            this.ValorUnitario = 0;
            this.ValorTotal = 0;
            this.DescontoPorc = 0;
            this.Desconto = 0;
        }
        public int NotaFiscalTerceirosID { get; set; }
        public virtual NotaFiscalTerceiros NotaFiscal { get; set; }
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal DescontoPorc { get; set; }
        public decimal Desconto { get; set; }
    }
}
