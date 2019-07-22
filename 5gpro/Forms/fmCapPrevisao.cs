using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _5gpro.Forms
{
    public partial class fmCapPrevisao : Form
    {
        private List<ParcelaContaPagar> parcelasContaPagar = new List<ParcelaContaPagar>();
        private readonly ParcelaContaPagarDAO parcelaContaPagarDAO = new ParcelaContaPagarDAO();
        private Dictionary<string, decimal> dados_pagos = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> dados_npagos = new Dictionary<string, decimal>();


        public struct Filtros
        {
            public Pessoa filtroPessoa;
            public DateTime filtroDataVencimentoInicial;
            public DateTime filtroDataVencimentoFinal;
        }

        public fmCapPrevisao()
        {
            InitializeComponent();
        }
        private void BtPrevisao_Click(object sender, EventArgs e) => Buscar();

        private void Buscar()
        {
            var f = new Filtros
            {
                filtroPessoa = buscaPessoa.pessoa,
                filtroDataVencimentoInicial = dtpDataInicial.Value,
                filtroDataVencimentoFinal = dtpDataFinal.Value
            };
            parcelasContaPagar = parcelaContaPagarDAO.Busca(f).ToList();

            foreach (var series in chartPrevisao.Series)
            {
                series.Points.Clear();
            }

            dados_npagos.Clear();
            dados_pagos.Clear();

            foreach (var p in parcelasContaPagar)
            {
                var mes = $"{p.DataVencimento.Month}/{p.DataVencimento.Year}";
                if (dados_npagos.ContainsKey(mes))
                {
                    dados_npagos[mes] += p.ValorFinal;
                }
                else
                {
                    dados_npagos[mes] = p.ValorFinal;
                }

                if (p.DataQuitacao != null)
                {
                    if (dados_pagos.ContainsKey(mes))
                    {
                        dados_pagos[mes] += p.ValorFinal;
                    }
                    else
                    {
                        dados_pagos[mes] = p.ValorFinal;
                    }
                }
            }

            foreach (var d in dados_npagos)
            {
                chartPrevisao.Series["Valor a pagar"].Points.AddXY(d.Key, d.Value);
            }

            foreach (var d in dados_pagos)
            {
                chartPrevisao.Series["Pago"].Points.AddXY(d.Key, d.Value);
            }

        }

    }
}
