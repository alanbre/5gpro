using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class SubGrupoPessoa
    {
        public int SubGrupoPessoaID { get; set; }
        public string Nome { get; set; }
        public GrupoPessoa GrupoPessoa { get; set; }
    }
}
