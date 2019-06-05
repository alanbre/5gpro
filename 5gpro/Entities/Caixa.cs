using System;
using System.ComponentModel.DataAnnotations;

namespace _5gpro.Entities
{
    class Caixa
    {
        public int CaixaID { get; }
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O nome do caixa é obrigatório.|tbNome", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength =2)]
        public string Nome { get; set; }
        [MaxLength(500)]
        public string Descricao { get; set; }
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public decimal ValorAbertura { get; set; }
        public decimal ValorFechamento { get; set; }
        public Usuario Usuario { get; set; }
    }
}
