using System;
using System.Collections.Generic;

namespace _5gpro.Entities
{
    public class Orcamento
    {
        public string Codigo { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataValidade { get; set; } = null;
        public List<_Item> Itens { get; set; }
        public decimal ValorTotalItens { get; set; }
        public decimal ValorTotalOrcamento { get; set; }
        public decimal DescontoTotalItens { get; set; }
        public decimal DescontoOrcamento { get; set; }
    }
}
