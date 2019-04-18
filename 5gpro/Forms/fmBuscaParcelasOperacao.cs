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
    public partial class fmBuscaParcelasOperacao : Form
    {

        public List<ParcelaOperacao> listaparcelasbusca;

        public fmBuscaParcelasOperacao()
        {
            InitializeComponent();
            BuscaParcelas();
        }

        private void BuscaParcelas()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Parcela", typeof(string));
            table.Columns.Add("Dias", typeof(string));

            foreach (ParcelaOperacao p in listaparcelasbusca)
            {
                table.Rows.Add(p.Numero, p.Dias);
            }
            dgvParcelasOperacao.DataSource = table;

        }

    }
}
