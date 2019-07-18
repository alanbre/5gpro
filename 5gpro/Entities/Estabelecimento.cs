using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    class Estabelecimento
    {
        public int EstabelecimentoID { get; set; }
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório.|tbNome", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "A Cidade é obrigatória.|buscaCidade", AllowEmptyStrings = false)]
        public Cidade Cidade { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
