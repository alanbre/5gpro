﻿using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmSaiBuscaNotaFiscalPropria : Form
    {
        public fmSaiBuscaNotaFiscalPropria()
        {
            InitializeComponent();
        }

        private IEnumerable<NotaFiscalPropria> notasFiscaisProprias;
        public NotaFiscalPropria notaFiscalPropriaSelecionada = null;
        private readonly NotaFiscalPropriaDAO notaFiscalPropriasDAO = new NotaFiscalPropriaDAO();
        private bool valorTotalFiltro = false;
        private bool dataEntradaFiltro = false;
        private bool dataEmissaoFiltro = false;


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
            public bool usarvalorTotalFiltro;
            public bool usardataEntradaFiltro;
            public bool usardataEmissaoFiltro;
        }


        private void CbValorTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValorTotal.Checked)
            {
                dbValorInicial.Enabled = true;
                dbValorFinal.Enabled = true;
                valorTotalFiltro = true;
            }
            else
            {
                dbValorInicial.Enabled = false;
                dbValorFinal.Enabled = false;
                valorTotalFiltro = false;
            }
        }
        private void CbDataEmissao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataCadastro.Checked)
            {
                dtpFiltroDataEmissaoInicial.Enabled = true;
                dtpFiltroDataEmissaoFinal.Enabled = true;
                dataEmissaoFiltro = true;
            }
            else
            {
                dtpFiltroDataEmissaoInicial.Enabled = false;
                dtpFiltroDataEmissaoFinal.Enabled = false;
                dataEmissaoFiltro = false;
            }
        }
        private void CbDataEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataEntrada.Checked)
            {
                dtpFiltroDataEntradaSaidaInicial.Enabled = true;
                dtpFiltroDataEntradaSaidaFinal.Enabled = true;
                dataEntradaFiltro = true;
            }
            else
            {
                dtpFiltroDataEntradaSaidaInicial.Enabled = false;
                dtpFiltroDataEntradaSaidaFinal.Enabled = false;
                dataEntradaFiltro = false;
            }
        }

        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();

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
                ValorFinal = dbValorFinal.Valor,
                usarvalorTotalFiltro = valorTotalFiltro,
                usardataEntradaFiltro = dataEntradaFiltro,
                usardataEmissaoFiltro = dataEmissaoFiltro
            };

            //notasFiscaisProprias = notaFiscalPropriasDAO.Busca(f);
            dgvNotas.Rows.Clear();

            foreach (var nf in notasFiscaisProprias)
            {
                dgvNotas.Rows.Add(nf.NotaFiscalPropriaID,
                                       nf.Pessoa.PessoaID,
                                       nf.Pessoa.Nome,
                                       nf.DataEmissao,
                                       nf.DataEntradaSaida.Date,
                                       nf.ValorTotalDocumento);
            }
            dgvNotas.Refresh();
        }
    }
}
