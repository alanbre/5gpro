namespace _5gpro.Entities
{
    public class NotaFiscalItem
    {
        public NotaFiscalItem()
        {
            this.Quantidade = 0;
            this.ValorUnitario = 0;
            this.ValorTotal = 0;
            this.DescontoPorc = 0;
            this.Desconto = 0;
        }
        public int NotaFiscalID { get; set; }
        public virtual NotaFiscal NotaFiscal { get; set; }
        public int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal DescontoPorc { get; set; }
        public decimal Desconto { get; set; }
    }
}