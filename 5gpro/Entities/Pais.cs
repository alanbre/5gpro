using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _5gpro.Entities
{
    class Pais
    {
        [Required(ErrorMessage = "O Código é obrigatório.|tbCodpais", AllowEmptyStrings = false)]
        public string idpais { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.|tbNomepais", AllowEmptyStrings = false)]
        [Display(Name = "Nome do País")]
        public string nome { get; set; }

        [Required(ErrorMessage = "A Sigla é obrigatório.|tbSiglapais", AllowEmptyStrings = false)]
        public string sigla { get; set; }


    }
}
