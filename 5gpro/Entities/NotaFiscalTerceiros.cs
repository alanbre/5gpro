using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _5gpro.Entities
{
    public class NotaFiscalTerceiros
    {
        public NotaFiscalTerceiros()
        {
            NotaFiscalTerceirosItem = new HashSet<NotaFiscalTerceirosItem>();
        }

        [Required(ErrorMessage = "O Código é obrigatório.|tbCodigo", AllowEmptyStrings = false)]
        public int NotaFiscalTerceirosID { get; set; }
        
        [Required(ErrorMessage = "O Código é obrigatório.|buscaPessoa", AllowEmptyStrings = false)]
        public Pessoa Pessoa { get; set; }

        public DateTime DataEmissao { get; set; }
        public DateTime DataEntradaSaida { get; set; }

        public decimal ValorTotalItens { get; set; }
        public decimal ValorTotalDocumento { get; set; }
        public decimal DescontoTotalItens { get; set; }
        public decimal DescontoDocumento { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<NotaFiscalTerceirosItem> NotaFiscalTerceirosItem { get; set; }
    }
}
