using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class GrupoUsuario
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public List<Permissao> Permissoes { get; set; }

    }
}
