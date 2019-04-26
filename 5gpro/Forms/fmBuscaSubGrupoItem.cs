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

namespace _5gpro.Forms
{
    public partial class fmBuscaSubGrupoItem : Form
    {
        GrupoItem grupoitem = null;
        List<SubGrupoItem> listasubgrupoitem;
        public SubGrupoItem subgrupoitemSelecionado = null;
        static ConexaoDAO connection = new ConexaoDAO();
        SubGrupoItemDAO subgrupoitemDAO = new SubGrupoItemDAO(connection);

        public fmBuscaSubGrupoItem(int grupoitemID)
        {
            InitializeComponent();
            FiltroGrupo(grupoitemID);
            
        }

        private void FiltroGrupo(int grupoid)
        {
            grupoitem = new GrupoItem();
            grupoitem.GrupoItemID = grupoid;
        }

        private void BuscaSubGrupoItem()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));

            listasubgrupoitem = subgrupoitemDAO.BuscaTodos(tbNomeSubGrupo.Text, grupoitem.GrupoItemID).ToList();

            foreach (SubGrupoItem g in listasubgrupoitem)
            {
                table.Rows.Add(g.SubGrupoItemID, g.Nome);
            }
            dgvSubGrupoItem.DataSource = table;
        }

        private void FmBuscaSubGrupoItem_Load(object sender, EventArgs e)
        {
            BuscaSubGrupoItem();
        }

        private void TbNomeSubGrupo_TextChanged(object sender, EventArgs e)
        {
            BuscaSubGrupoItem();
        }

        private void BtPesquisarSubGrupoItem_Click(object sender, EventArgs e)
        {
            BuscaSubGrupoItem();
        }

        private void DgvSubGrupoItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvSubGrupoItem.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSubGrupoItem.Rows[selectedRowIndex];
            subgrupoitemSelecionado = listasubgrupoitem.Find(g => g.SubGrupoItemID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }
    }
}
