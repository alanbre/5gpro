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
    public partial class fmBuscaGrupoItem : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        private List<GrupoItem> listagrupoitem;
        public GrupoItem grupoitemSelecionado = null;
        private GrupoItemDAO grupoitemDAO = new GrupoItemDAO();

        public fmBuscaGrupoItem()
        {
            InitializeComponent();
        }

        //LOAD
        private void FmBuscaGrupoItem_Load(object sender, EventArgs e) => BuscaGrupoItem();

        //KEYUP, KEYDOWN
        private void FmBuscaGrupoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void DgvGrupoItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvGrupoItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvGrupoItens.Rows[selectedRowIndex];
            grupoitemSelecionado = grupoitemDAO.BuscaByID(Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }

        //TEXTCHANGED
        private void TbNomeGrupoIten_TextChanged(object sender, EventArgs e) => BuscaGrupoItem();

        //FUNÇÕES
        private void BuscaGrupoItem()
        {
            dgvGrupoItens.Columns.Clear();

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(int));
            table.Columns.Add("Nome", typeof(string));

            listagrupoitem = grupoitemDAO.Busca(tbNomeGrupoIten.Text).ToList();

            foreach (GrupoItem g in listagrupoitem)
            {
                table.Rows.Add(g.GrupoItemID, g.Nome);
            }
            dgvGrupoItens.DataSource = table;

            funaux.TratarTamanhoColunas(dgvGrupoItens);
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
