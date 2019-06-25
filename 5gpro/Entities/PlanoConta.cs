using _5gpro.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    public class PlanoConta
    {

        public int PlanoContaID { get; set; }
        public int Codigo { get; set; }
        public int PaiID { get; set; }
        public int Level { get; set; }
        public string Descricao { get; set; }
        public string CodigoCompleto { get; set; }
        public List<PlanoConta> SubContas { get; set; } = new List<PlanoConta>();
    }
}
