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

namespace _5gpro.Forms
{
    public partial class fmVisualizaParcelas : Form
    {
        public fmVisualizaParcelas(List<ParcelaContaReceber> parcelas)
        {
            InitializeComponent();
            PopularDGV(parcelas);
        }

        private void PopularDGV(List<ParcelaContaReceber> parcelas)
        {

            foreach (var parcela in parcelas)
                dgvParcelas.Rows.Add(parcela.Sequencia,
                                     parcela.DataVencimento,
                                     parcela.Valor,
                                     parcela.Multa,
                                     parcela.Juros,
                                     parcela.Acrescimo,
                                     parcela.Desconto,
                                     parcela.ValorFinal,
                                     parcela.DataQuitacao?.Date,
                                     parcela.Situacao,
                                     parcela.FormaPagamento
                                     );
            dgvParcelas.Refresh();

        }

    }
}
