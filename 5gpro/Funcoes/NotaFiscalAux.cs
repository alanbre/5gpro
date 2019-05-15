using _5gpro.Daos;
using _5gpro.Entities;
using System;

namespace _5gpro.Funcoes
{
    class NotaFiscalAux
    {
        static ConexaoDAO connection = new ConexaoDAO();
        NotaFiscalPropriaDAO notaFiscalDAO = new NotaFiscalPropriaDAO(connection);
        OrcamentoDAO orcamentoDAO = new OrcamentoDAO(connection);


        public NotaFiscalPropria GerarNotaFiscal(Orcamento orcamento)
        {
            NotaFiscalPropria notafiscal = new NotaFiscalPropria();

            notafiscal.NotaFiscalPropriaID = notaFiscalDAO.BuscaProxCodigoDisponivel();

            notafiscal.Pessoa = orcamento.Pessoa;
            notafiscal.DataEmissao = DateTime.Now;
            notafiscal.DataEntradaSaida = DateTime.Now;
            notafiscal.ValorTotalItens = orcamento.ValorTotalItens;
            notafiscal.ValorTotalDocumento = orcamento.ValorTotalOrcamento;
            notafiscal.DescontoTotalItens = orcamento.DescontoTotalItens;
            notafiscal.DescontoDocumento = orcamento.DescontoOrcamento;

            foreach (OrcamentoItem oi in orcamento.OrcamentoItem)
            {
                NotaFiscalPropriaItem nfi = new NotaFiscalPropriaItem();
                nfi.Item = oi.Item;
                nfi.NotaFiscal = notafiscal;
                nfi.Quantidade = oi.Quantidade;
                nfi.ValorUnitario = oi.ValorUnitario;
                nfi.ValorTotal = oi.ValorTotal;
                nfi.DescontoPorc = oi.DescontoPorc;
                nfi.Desconto = oi.Desconto;
                notafiscal.NotaFiscalPropriaItem.Add(nfi);
            }

            int resultado = notaFiscalDAO.SalvarOuAtualizar(notafiscal);
            if (resultado > 0) { resultado = orcamentoDAO.VincularNotaAoOrcamento(orcamento, notafiscal); }
            return resultado > 0 ? notafiscal : null;
        }
    }
}
