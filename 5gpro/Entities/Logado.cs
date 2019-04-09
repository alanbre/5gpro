using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    class Logado
    {
        public int LogadoID { get; set; }
        public string Mac { get; set; }
        public Usuario Usuario { get; set; }
        public string NomePC { get; set; }
        public string IPdoPC { get; set; }
    }
}
