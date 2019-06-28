using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class Unimedida
    {
        public int UnimedidaID { get; set; }
        [Required(ErrorMessage = "A sigla é obrigatória.|tbSigla", AllowEmptyStrings = false)]
        public string Sigla { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória.|tbDescricao", AllowEmptyStrings = false)]
        public string Descricao { get; set; }

    }
}
