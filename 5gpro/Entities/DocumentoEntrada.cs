using System;
using System.Collections.Generic;

namespace _5gpro.Entities
{
    public class DocumentoEntrada
    {
        public int DocumentoEntradaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public List<_Item> Itens { get; set; }
        public decimal ValorTotalItens { get; set; }
        public decimal ValorTotalDocumento { get; set; }
        public decimal DescontoTotalItens { get; set; }
        public decimal DescontoDocumento { get; set; }
    }
}
