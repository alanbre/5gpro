using _5gpro.Bll;
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
    public partial class fmBuscaGrupoUsuario : Form
    {

        public List<GrupoUsuario> Listagrupousuario;
        public GrupoUsuario GrupoUsuario;
        private GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
        public GrupoUsuario grupousuarioSelecionado;

        public fmBuscaGrupoUsuario()
        {
            InitializeComponent();
        }

        public void buscaGrupousuario()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));


            Listagrupousuario = grupousuarioBLL.BuscarGrupoUsuario(tbFiltroNomeGrupoUsuario.Text);

            foreach (GrupoUsuario gu in Listagrupousuario)
            {
                table.Rows.Add(gu.GrupoUsuarioID, gu.Nome);
            }
            dgvGrupoUsuario.DataSource = table;
        }

        private void fmBuscaGrupoUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void tbFiltroNomeGrupoUsuario_TextChanged(object sender, EventArgs e)
        {
            buscaGrupousuario();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            buscaGrupousuario();
        }

        private void dgvGrupoUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvGrupoUsuario.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvGrupoUsuario.Rows[selectedRowIndex];
            //grupousuarioSelecionado = Listagrupousuario.Find(g => g.GrupoUsuarioID == Convert.ToString(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            grupousuarioSelecionado = Listagrupousuario.Find(g => (g.GrupoUsuarioID).ToString() == Convert.ToString(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA

            this.Close();
        }
    }
}
