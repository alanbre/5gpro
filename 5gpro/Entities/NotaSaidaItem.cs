namespace _5gpro.Entities
{
    class NotaSaidaItem
    {
        public int NotaSaidaID { get; set; }
        public virtual NotaSaida NotaSaida { get; set; }
        public int ItemID { get; set; }
        public virtual _Item Item { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal DescontoPorc { get; set; }
        public decimal Desconto { get; set; }
    }
}
