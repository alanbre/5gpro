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

namespace _5gpro.Reports
{
    public partial class fmRltItem : Form
    {

        private SubGrupoItem subgrupoitemfiltro = null;

        public fmRltItem(SubGrupoItem subgrupoitemrecebido)
        {
            InitializeComponent();
            subgrupoitemfiltro = subgrupoitemrecebido;
        }

        private void FmRltItem_Load(object sender, EventArgs e)
        {

            var dataTable = new DataTable();
            dataTable.Columns.Add("iditem", typeof(int));
            dataTable.Columns.Add("descitem");
            dataTable.Columns.Add("denominacaocompra");
            dataTable.Columns.Add("tipo");
            dataTable.Columns.Add("referencia");
            dataTable.Columns.Add("valorentrada");
            dataTable.Columns.Add("valorsaida");
            dataTable.Columns.Add("estoquenecessario");
            dataTable.Columns.Add("unimedida");
            dataTable.Columns.Add("subgrupoitem");
            dataTable.Columns.Add("quantidade");


            ItemDAO itemDAO = new ItemDAO();

            List<Item> listaitem = new List<Item>();
            listaitem = itemDAO.Busca("", "", "", subgrupoitemfiltro).ToList();

            foreach (Item i in listaitem)
            {
                dataTable.Rows.Add(i.ItemID, i.Descricao, i.DescCompra, i.TipoItem, i.Referencia, i.ValorEntrada, i.ValorSaida, i.Estoquenecessario, i.Unimedida.Sigla, i.SubGrupoItem.Nome, i.Quantidade);
            }

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsItem", dataTable));

            this.reportViewer1.RefreshReport();
        }
    }
}
