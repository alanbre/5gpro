using System.Collections.Generic;

namespace _5gpro.Entities
{
    public class Orcamento
    {
        public string Codigo { get; set; }
        public Pessoa Pessoa { get; set; }
        public string DataCadastro { get; set; }
        public string DataVencimento { get; set; }
        public List<_Item> Itens { get; set; }
        public decimal ValorTotalItens { get; set; }
        public decimal ValorTotalOrcamento { get; set; }

    }
}
