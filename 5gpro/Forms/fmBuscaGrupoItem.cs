using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaGrupoItem : Form
    {

        List<GrupoItem> listagrupoitem;
        public GrupoItem grupoitemSelecionado = null;
        static ConexaoDAO connection = new ConexaoDAO();
        GrupoItemDAO grupoitemDAO = new GrupoItemDAO(connection);

        public fmBuscaGrupoItem()
        {
            InitializeComponent();
        }

        private void BuscaGrupoItem()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(int));
            table.Columns.Add("Nome", typeof(string));

            listagrupoitem = grupoitemDAO.BuscaTodos(tbNomeGrupoIten.Text).ToList();

            foreach (GrupoItem g in listagrupoitem)
            {
                table.Rows.Add(g.GrupoItemID, g.Nome);
            }
            dgvGrupoItens.DataSource = table;
        }

        private void FmBuscaGrupoItem_Load(object sender, EventArgs e)
        {
            BuscaGrupoItem();
        }

        private void TbNomeGrupoIten_TextChanged(object sender, EventArgs e)
        {
            BuscaGrupoItem();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            BuscaGrupoItem();
        }

        private void DgvGrupoItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvGrupoItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvGrupoItens.Rows[selectedRowIndex];
            grupoitemSelecionado = listagrupoitem.Find(g => g.GrupoItemID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

    }
}
