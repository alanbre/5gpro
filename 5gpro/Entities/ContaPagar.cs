using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _5gpro.Entities
{
    public class ContaPagar
    {
        public ContaPagar()
        {
            Parcelas = new HashSet<ParcelaContaPagar>();
        }

        public int ContaPagarID { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataConta { get; set; }

        [Required(ErrorMessage = "Fornecedor/Cliente é obrigatório.|buscaPessoa", AllowEmptyStrings = false)]
        public Pessoa Pessoa { get; set; }

        public decimal ValorOriginal { get; set; }
        public decimal Multa { get; set; }
        public decimal Juros { get; set; }
        public decimal ValorFinal { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal Desconto { get; set; }
        public string Situacao { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ParcelaContaPagar> Parcelas { get; set; }
    }
}
