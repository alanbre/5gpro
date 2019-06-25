using _5gpro.Daos;
using System.Collections.Generic;


namespace _5gpro.Entities
{
    public class PlanoConta
    {

        public int PlanoContaID { get; set; }
        public int Codigo { get; set; }
        public int PaiID { get; set; }
        public int Level { get; set; }
        public string Descricao { get; set; }
        public List<PlanoConta> SubContas { get; set; } = new List<PlanoConta>();
    }
}
