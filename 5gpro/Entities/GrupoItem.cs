using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _5gpro.Entities
{
    public class GrupoItem
    {
        public int GrupoItemID { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.|tbNomeGrupoItem", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        public List<SubGrupoItem> SubGrupoItens { get; set; }
    }
}
