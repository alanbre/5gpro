using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public static class Estabelecimento
    {
        public static int EstabelecimentoID { get; set; }
        public static int Codigo { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório.|tbNome", AllowEmptyStrings = false)]
        public static string Nome { get; set; }
        public static string Fantasia { get; set; }
        public static string Rua { get; set; }
        public static string Numero { get; set; }
        public static string Bairro { get; set; }
        public static string Complemento { get; set; }
        [Required(ErrorMessage = "A Cidade é obrigatória.|buscaCidade", AllowEmptyStrings = false)]
        public static Cidade Cidade { get; set; }
        public static string CpfCnpj { get; set; }
        public static string Telefone { get; set; }
        public static string Email { get; set; }
    }
}
