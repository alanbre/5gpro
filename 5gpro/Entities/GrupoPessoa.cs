using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class GrupoPessoa
    {
        public int GrupoPessoaID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.|tbNomeGrupoPessoa", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public List<SubGrupoPessoa> SubGrupoPessoas { get; set; } = new List<SubGrupoPessoa>();

    }
}
