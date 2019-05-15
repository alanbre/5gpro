using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _5gpro.Entities
{
    public class Item
    {
        public Item()
        {
            NotaFiscalItem = new HashSet<NotaFiscalPropriaItem>();
        }

        public int ItemID { get; set; }

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

        [Required(ErrorMessage = "A Unidade de medida é obrigatória.|buscaUnimedidaItem", AllowEmptyStrings = false)]
        public Unimedida Unimedida { get; set; }

        public virtual ICollection<NotaFiscalPropriaItem> NotaFiscalItem { get; set; }

        [Required(ErrorMessage = "SubGrupo necessário.|buscaSubGrupoItem", AllowEmptyStrings = false)]
        public SubGrupoItem SubGrupoItem { get; set; }

        public decimal Quantidade { get; set; }
    }
}
