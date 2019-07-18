using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
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

        //LOAD
        private void FmBuscaGrupoUsuario_Load(object sender, EventArgs e) => Busca();

        //KEYUP, KEYDOWN
        private void FmBuscaGrupoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void DgvGrupoUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvGrupoUsuario.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvGrupoUsuario.Rows[selectedRowIndex];
            grupoUsuarioSelecionado = Listagrupousuario.Find(g => (g.GrupoUsuarioID).ToString() == Convert.ToString(selectedRow.Cells[0].Value));

            this.Close();
        }

        //TEXTCHANGED
        private void TbFiltroNomeGrupoUsuario_TextChanged(object sender, EventArgs e) => Busca();

        //FUNÇÕES         
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
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }      
    }
}
