namespace _5gpro.Entities
{
    class NotaFiscalItem
    {
        public int NotaFiscalID { get; set; }
        public virtual NotaFiscal NotaFiscal { get; set; }
        public int ItemID { get; set; }
        public virtual _Item Item { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal DescontoPorc { get; set; }
        public decimal Desconto { get; set; }
    }
}