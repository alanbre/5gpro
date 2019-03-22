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
        [Display(Name = "Código", Description = "Informe um inteiro entre 1 e 99999.")]
        [Range(1, 99999)]
        public int idpais { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string nome { get; set; }

        [Required(ErrorMessage = "A Sigla é obrigatório.")]
        public string sigla { get; set; }


    }
}
