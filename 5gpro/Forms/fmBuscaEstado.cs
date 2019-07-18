using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaEstado : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        public List<Estado> Estados;
        public Estado EstadoSelecionado;
        private readonly EstadoDAO estadoDAO = new EstadoDAO();


        public fmBuscaEstado()
        {
            InitializeComponent();
            tbFiltroNomeEstado.Focus();
        }

        //LOAD
        private void FmBuscaEstado_Load(object sender, EventArgs e) => BuscaEstados();

        //KEYUP, KEYDOWN
        private void FmBuscaEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void DgvEstados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvEstados.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvEstados.Rows[selectedRowIndex];
            EstadoSelecionado = Estados.Find(est => est.EstadoID == Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }

        //TEXTCHANGED
        private void TbFiltroNomeEstado_TextChanged(object sender, EventArgs e) => BuscaEstados();

        //FUNÇÕES
        private void BuscaEstados()
        {
            dgvEstados.Rows.Clear();
            Estados = estadoDAO.BuscaEstadoByNome(tbFiltroNomeEstado.Text);
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            foreach (Estado estado in Estados)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvEstados,
                    estado.EstadoID,
                    estado.Nome
                );
                rows.Add(linha);

            }
            dgvEstados.Rows.AddRange(rows.ToArray());
            funaux.TratarTamanhoColunas(dgvEstados);
            dgvEstados.Refresh();
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
