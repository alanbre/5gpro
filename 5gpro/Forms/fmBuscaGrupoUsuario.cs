using _5gpro.Bll;
using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaGrupoUsuario : Form
    {
        static ConexaoDAO connection = new ConexaoDAO();

        public List<GrupoUsuario> Listagrupousuario;
        public GrupoUsuario GrupoUsuario;
        GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO(connection);
        
        public GrupoUsuario grupousuarioSelecionado;

        public fmBuscaGrupoUsuario()
        {
            InitializeComponent();
        }

        public void BuscaGrupousuario()
        {
            Listagrupousuario = grupousuarioDAO.BuscarGrupoUsuario(tbFiltroNomeGrupoUsuario.Text).ToList();

            dgvGrupoUsuario.Rows.Clear();
            foreach (GrupoUsuario gu in Listagrupousuario)
            {
                dgvGrupoUsuario.Rows.Add(gu.GrupoUsuarioID, gu.Nome);

            }
            dgvGrupoUsuario.Refresh();
        }

        private void TbFiltroNomeGrupoUsuario_TextChanged(object sender, EventArgs e)
        {
            BuscaGrupousuario();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            BuscaGrupousuario();
        }

        private void DgvGrupoUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvGrupoUsuario.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvGrupoUsuario.Rows[selectedRowIndex];
            grupousuarioSelecionado = Listagrupousuario.Find(g => (g.GrupoUsuarioID).ToString() == Convert.ToString(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA

            this.Close();
        }
    }
}
