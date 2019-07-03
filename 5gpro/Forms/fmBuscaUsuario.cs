using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaUsuario : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        IEnumerable<Usuario> usuarios;
        public Usuario usuarioSelecionado = null;


        public fmBuscaUsuario()
        {
            InitializeComponent();
        }

        //LOAD
        private void FmBuscaUsuario_Load(object sender, EventArgs e) => BuscaUsuario();

        //LEAVE
        private void BuscaGrupoUsuario_Leave(object sender, EventArgs e) => BuscaUsuario();

        //KEYUP, KEYDOWN
        private void FmBuscaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvUsuarios.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvUsuarios.Rows[selectedRowIndex];
            usuarioSelecionado = usuarios.ToList().Find(u => u.UsuarioID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        //TEXTCHANGED
        private void TbFiltroNomeUsuario_TextChanged(object sender, EventArgs e) => BuscaUsuario();
        private void TbFiltroSobrenomeUsuario_TextChanged(object sender, EventArgs e) => BuscaUsuario();
        private void BuscaGrupoUsuario_Text_Changed(object sender, EventArgs e) => BuscaUsuario();

        //FUNÇÕES
        private void BuscaUsuario()
        {
            dgvUsuarios.Columns.Clear();

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Sobrenome", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telefone", typeof(string));


            usuarios = usuarioDAO.Busca(buscaGrupoUsuario.grupoUsuario, tbFiltroNomeUsuario.Text, tbFiltroSobrenomeUsuario.Text);

            foreach (Usuario u in usuarios)
            {
                table.Rows.Add(u.UsuarioID, u.Nome, u.Sobrenome, u.Email, u.Telefone);
            }
            dgvUsuarios.DataSource = table;

            funaux.TratarTamanhoColunas(dgvUsuarios);
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
