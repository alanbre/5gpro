using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace _5gpro.Entities
{
    public class _Item
    {
        public string Codigo { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatória.", AllowEmptyStrings = false)]
        public string Descricao { get; set; }

        public string DescCompra { get; set; }
        public string TipoItem { get; set; }
        public string Referencia { get; set; }

        [Required(ErrorMessage = "O Valor da Entrada é obrigatório.", AllowEmptyStrings = false)]
        [Range(1, 99999, ErrorMessage = "Valor da Entrada deve ser maior que 0")]
        public decimal ValorEntrada { get; set; }

        [Required(ErrorMessage = "O Valor da saída é obrigatório.", AllowEmptyStrings = false)]
        [Range(1, 99999, ErrorMessage = "Valor da Saída deve ser maior que 0")]
        public decimal ValorSaida { get; set; }

        public decimal Estoquenecessario { get; set; }

        [Required(ErrorMessage = "A unidade de medida é obrigatória.", AllowEmptyStrings = false)]
        public string Unimedida { get; set; }

        //ADICIONEI ESSES DADOS PARA O ORÇAMENTO.
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal DescontoPorc { get; set; }
        public decimal Desconto { get; set; }
        public decimal Quantidade { get; set; }


        public _Item()
        {
            ValorUnitario = 0;
            ValorTotal = 0;
            DescontoPorc = 0;
            Desconto = 0;
            Quantidade = 0;
        }

        public _Item(string codigo, string descricao, string desccompra, string tipoitem, string referencia, decimal valorentrada, decimal valorsaida, decimal estoquenecessario, string unimedida)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.DescCompra = desccompra;
            this.TipoItem = tipoitem;
            this.Referencia = referencia;
            this.ValorEntrada = valorentrada;
            this.ValorSaida = valorsaida;
            this.Estoquenecessario = estoquenecessario;
            this.Unimedida = unimedida;

        }
    }
}
