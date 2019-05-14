using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmEntBuscaNotaFiscalTerceiros : Form
    {
        private IEnumerable<NotaFiscalTerceiros> notasFiscaisTerceiros;
        public NotaFiscalTerceiros notaFiscalTerceirosSelecionada = null;
        private static ConexaoDAO connection = new ConexaoDAO();
        private readonly NotaFiscalTerceirosDAO notaFiscalTerceirosDAO = new NotaFiscalTerceirosDAO(connection);


        public struct Filtros
        {
            public Cidade Cidade;
            public Pessoa Pessoa;
            public DateTime DataEmissaoInicial;
            public DateTime DataEmissaoFinal;
            public DateTime DataEntradaInicial;
            public DateTime DataEntradaFinal;
            public decimal ValorInicial;
            public decimal ValorFinal;
        }

        public fmEntBuscaNotaFiscalTerceiros()
        {
            InitializeComponent();
        }
        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();

        private void DgvDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pesquisar()
        {
            var f = new Filtros
            {
                Cidade = buscaCidade.cidade,
                Pessoa = buscaPessoa.pessoa,
                DataEmissaoInicial = dtpFiltroDataEmissaoInicial.Value,
                DataEmissaoFinal = dtpFiltroDataEmissaoFinal.Value,
                DataEntradaInicial = dtpFiltroDataEntradaSaidaInicial.Value,
                DataEntradaFinal = dtpFiltroDataEntradaSaidaFinal.Value,
                ValorInicial = dbValorInicial.Valor,
                ValorFinal = dbValorInicial.Valor
            };

            notasFiscaisTerceiros = notaFiscalTerceirosDAO.Busca(f);
            dgvDocumentos.Rows.Clear();

            foreach(var nf in notasFiscaisTerceiros)
            {
                dgvDocumentos.Rows.Add(nf.NotaFiscalTerceirosID,
                                       nf.Pessoa.PessoaID,
                                       nf.Pessoa.Nome,
                                       nf.DataEmissao,
                                       nf.DataEntradaSaida.Date,
                                       nf.ValorTotalDocumento);
            }
            dgvDocumentos.Refresh();
        }

    }
}
