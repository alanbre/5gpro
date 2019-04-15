using _5gpro.Bll;
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
        List<Usuario> usuarios;
        public Usuario usuarioSelecionado = null;
        static ConexaoDAO connection = new ConexaoDAO();


        public fmBuscaUsuario()
        {
            InitializeComponent();
        }

        private void BuscaUsuario()
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO(connection);

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Sobrenome", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telefone", typeof(string));



        usuarios = usuarioDAO.BuscaUsuarios(tbFiltroCodUsuario.Text, tbFiltroNomeUsuario.Text, tbFiltroSobrenomeUsuario.Text).ToList();

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
            usuarioSelecionado = usuarios.Find(u => u.UsuarioID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
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

        private void dgvUsuarios_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }
    }
}
