using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class GrupoItem
    {
        public int GrupoItemID { get; set; }
        public string Nome { get; set; }
        public List<SubGrupoItem> SubGrupoItens { get; set; }
    }
}
