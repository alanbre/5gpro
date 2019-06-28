using System;

namespace _5gpro.Entities
{
    class CaixaLancamento
    {
        public int CaixaLancamentoID { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int TipoMovimento { get; set; } // 0 = crédito 1 = débito 5 = Sangria
        public int TipoDocumento { get; set; } // 0 = CAR 1 = CAP 2 = NF saida 3 = NF entrada 5 = Sangria
        public int Lancamento { get; set; } // 0 = manual 1 = automático
        public string Documento { get; set; }
        public Caixa Caixa { get; set; }
        public ParcelaContaReceber ParcelaContaReceber { get; set; }
        public ParcelaContaPagar ParcelaContaPagar { get; set; }
        public NotaFiscalPropria NotaFiscalPropria { get; set; }
        public NotaFiscalTerceiros NotaFiscalTerceiros { get; set; }
        public PlanoConta PlanoConta { get; set; }
    }
}
