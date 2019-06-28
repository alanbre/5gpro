using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5gpro.Entities
{
    class PlanoContaPadrao
    {
        public int PlanoContaPadraoID { get; set; }
        public PlanoConta Compras { get; set; }
        public PlanoConta ContasPagar { get; set; }
        public PlanoConta DescontosConcedidos { get; set; }
        public PlanoConta JurosPagos { get; set; }
        public PlanoConta Vendas { get; set; }
        public PlanoConta ContasReceber { get; set; }
        public PlanoConta DescontosRecebidos { get; set; }
        public PlanoConta JurosRecebidos { get; set; }
    }
}
