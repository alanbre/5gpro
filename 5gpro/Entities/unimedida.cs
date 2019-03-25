using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class Unimedida
    {
        public string Codigo { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public Unimedida()
        {

        }

        public Unimedida(string codigo, string sigla, string descricao)
        {
            this.Codigo = codigo;
            this.Sigla = sigla;
            this.Descricao = descricao;
        }

    }
}
