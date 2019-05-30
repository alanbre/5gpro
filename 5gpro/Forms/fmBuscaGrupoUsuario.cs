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
        private List<GrupoUsuario> Listagrupousuario;
        private readonly GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO();       
        public GrupoUsuario grupoUsuarioSelecionado;

        public fmBuscaGrupoUsuario()
        {
            InitializeComponent();
        }


        private void TbFiltroNomeGrupoUsuario_TextChanged(object sender, EventArgs e) => Busca();
        private void BtPesquisar_Click(object sender, EventArgs e) => Busca();        
        private void DgvGrupoUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvGrupoUsuario.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvGrupoUsuario.Rows[selectedRowIndex];
            grupoUsuarioSelecionado = Listagrupousuario.Find(g => (g.GrupoUsuarioID).ToString() == Convert.ToString(selectedRow.Cells[0].Value));

            this.Close();
        }


        public void Busca()
        {
            Listagrupousuario = grupousuarioDAO.Busca(tbFiltroNomeGrupoUsuario.Text).ToList();

            dgvGrupoUsuario.Rows.Clear();
            foreach (GrupoUsuario gu in Listagrupousuario)
            {
                dgvGrupoUsuario.Rows.Add(gu.GrupoUsuarioID, gu.Nome);

            }
            dgvGrupoUsuario.Refresh();
        }
    }
}
