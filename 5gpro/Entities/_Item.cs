using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _5gpro.Entities
{
    public class _Item
    {
        public _Item()
        {
            NotaFiscalItem = new HashSet<NotaFiscalItem>();
        }

        public int _ItemID { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatória.|tbDescricao", AllowEmptyStrings = false)]
        public string Descricao { get; set; }

        public string DescCompra { get; set; }
        public string TipoItem { get; set; }
        public string Referencia { get; set; }

        [Range(1, 99999, ErrorMessage = "Valor da Entrada deve ser maior que 0.|tbPrecoUltimaEntrada")]
        public decimal ValorEntrada { get; set; }

        [Range(1, 99999, ErrorMessage = "Valor da Saída deve ser maior que 0.|tbPrecoVenda")]
        public decimal ValorSaida { get; set; }

        public decimal Estoquenecessario { get; set; }

        [Required(ErrorMessage = "A Unidade de medida é obrigatória.|tbCodUnimedida", AllowEmptyStrings = false)]
        public Unimedida Unimedida { get; set; }

        public virtual ICollection<NotaFiscalItem> NotaFiscalItem { get; set; }


        //ADICIONEI ESSES DADOS PARA O ORÇAMENTO.
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; } //=> Quantidade * ValorUnitario;
        public decimal DescontoPorc { get; set; }
        public decimal Desconto { get; set; } //=> ValorTotal * DescontoPorc / 100;

    }
}
