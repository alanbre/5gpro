using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
   public class Operacao
    {
        public int OperacaoID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.|tbNomeOperacao", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Selecione a condição de pagamento.|gbCondicaoOperacao", AllowEmptyStrings = false)]
        public string Condicao { get; set; }
        public decimal Desconto { get; set; }
        public decimal Entrada { get; set; }
        public decimal Acrescimo { get; set; }
        public List<ParcelaOperacao> Parcelas { get; set; }
    }
}
