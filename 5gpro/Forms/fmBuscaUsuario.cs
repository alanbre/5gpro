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
    public partial class fmBuscaUsuario : Form
    {
        IEnumerable<Usuario> usuarios;
        public Usuario usuarioSelecionado = null;


        public fmBuscaUsuario()
        {
            InitializeComponent();
        }

        private void BuscaUsuario()
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Sobrenome", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telefone", typeof(string));


            usuarios = usuarioDAO.Busca(buscaGrupoUsuario.grupoUsuario?.GrupoUsuarioID.ToString() ?? "", tbFiltroNomeUsuario.Text, tbFiltroSobrenomeUsuario.Text);

            foreach (Usuario u in usuarios)
            {
                table.Rows.Add(u.UsuarioID, u.Nome, u.Sobrenome, u.Email, u.Telefone);
            }
            dgvUsuarios.DataSource = table;

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvUsuarios.SelectedCells[0].RowIndex;           
            DataGridViewRow selectedRow = dgvUsuarios.Rows[selectedRowIndex];
            usuarioSelecionado = usuarios.ToList().Find(u => u.UsuarioID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            BuscaUsuario();
        }

        private void tbFiltroNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            BuscaUsuario();
        }

        private void tbFiltroSobrenomeUsuario_TextChanged(object sender, EventArgs e)
        {
            BuscaUsuario();
        }
    }
}
