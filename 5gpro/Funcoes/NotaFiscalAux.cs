using _5gpro.Bll;
using _5gpro.Entities;
using System;

namespace _5gpro.Funcoes
{
    class NotaFiscalAux
    {
        NotaFiscalBLL notaFiscalBLL = new NotaFiscalBLL();
        OrcamentoBLL orcamentoBLL = new OrcamentoBLL();


        public NotaFiscal GerarNotaFiscal(Orcamento orcamento)
        {
            NotaFiscal notafiscal = new NotaFiscal();

            notafiscal.NotaFiscalID = notaFiscalBLL.BuscaProxCodigoDisponivel();

            notafiscal.Pessoa = orcamento.Pessoa;
            notafiscal.DataEmissao = DateTime.Now;
            notafiscal.DataEntradaSaida = DateTime.Now;
            notafiscal.ValorTotalItens = orcamento.ValorTotalItens;
            notafiscal.ValorTotalDocumento = orcamento.ValorTotalOrcamento;
            notafiscal.DescontoTotalItens = orcamento.DescontoTotalItens;
            notafiscal.DescontoDocumento = orcamento.DescontoOrcamento;

            foreach (OrcamentoItem oi in orcamento.OrcamentoItem)
            {
                NotaFiscalItem nfi = new NotaFiscalItem();
                nfi.Item = oi.Item;
                nfi.NotaFiscal = notafiscal;
                nfi.Quantidade = oi.Quantidade;
                nfi.ValorUnitario = oi.ValorUnitario;
                nfi.ValorTotal = oi.ValorTotal;
                nfi.DescontoPorc = oi.DescontoPorc;
                nfi.Desconto = oi.Desconto;
                notafiscal.NotaFiscalItem.Add(nfi);
            }

            int resultado = notaFiscalBLL.SalvarOuAtualizarDocumento(notafiscal);
            if (resultado > 0) { resultado = orcamentoBLL.VincularNotaAoOrcamento(orcamento, notafiscal); }
            return resultado > 0 ? notafiscal : null;
        }
    }
}
