using System;
using System.Collections.Generic;

namespace _5gpro.Entities
{
    class NotaSaida
    {
        public NotaSaida()
        {
            NotaSaidaItens = new HashSet<NotaSaidaItem>();
        }

        public int NotaSaidaID { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataSaida { get; set; }
        public virtual ICollection<NotaSaidaItem> NotaSaidaItens { get; set; }
    }
}
