using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _5gpro.Entities
{
    public class Orcamento
    {
        public Orcamento()
        {
            OrcamentoItem = new HashSet<OrcamentoItem>();
        }

        public int OrcamentoID { get; set; }

        [Required(ErrorMessage = "O Cliente é obrigatório.|buscaPessoa", AllowEmptyStrings = false)]
        public Pessoa Pessoa { get; set; }

        public NotaFiscalPropria NotaFiscal { get; set; } = null;
        public DateTime DataCadastro { get; set; }
        public DateTime? DataValidade { get; set; } = null;

        public decimal ValorTotalItens { get; set; }
        public decimal ValorTotalOrcamento { get; set; }
        public decimal DescontoTotalItens { get; set; }
        public decimal DescontoOrcamento { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<OrcamentoItem> OrcamentoItem { get; set; }
    }
}
