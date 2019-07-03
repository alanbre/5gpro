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
    public partial class fmBuscaSubGrupoItem : Form
    {

        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        GrupoItem grupoitem = null;
        List<SubGrupoItem> listasubgrupoitem;
        public SubGrupoItem subgrupoitemSelecionado = null;
        SubGrupoItemDAO subgrupoitemDAO = new SubGrupoItemDAO();

        public fmBuscaSubGrupoItem(int grupoitemID)
        {
            InitializeComponent();
            FiltroGrupo(grupoitemID);
            
        }

        //LOAD
        private void FmBuscaSubGrupoItem_Load(object sender, EventArgs e) => BuscaSubGrupoItem();

        //KEYUP, KEYDOWN
        private void FmBuscaSubGrupoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void DgvSubGrupoItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvSubGrupoItem.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSubGrupoItem.Rows[selectedRowIndex];
            subgrupoitemSelecionado = listasubgrupoitem.Find(g => g.Codigo == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        //TEXTCHANGED
        private void TbNomeSubGrupo_TextChanged(object sender, EventArgs e) => BuscaSubGrupoItem();


        //FUNÇÕES
        private void FiltroGrupo(int grupoid)
        {
            grupoitem = new GrupoItem();
            grupoitem.GrupoItemID = grupoid;
        }

        private void BuscaSubGrupoItem()
        {
            dgvSubGrupoItem.Columns.Clear();

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));

            listasubgrupoitem = subgrupoitemDAO.Busca(tbNomeSubGrupo.Text, grupoitem.GrupoItemID).ToList();

            foreach (SubGrupoItem g in listasubgrupoitem)
            {
                table.Rows.Add(g.Codigo, g.Nome);
            }
            dgvSubGrupoItem.DataSource = table;

            funaux.TratarTamanhoColunas(dgvSubGrupoItem);
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
