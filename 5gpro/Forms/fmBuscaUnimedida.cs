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
    public partial class fmBuscaUnimedida : Form
    {
        FuncoesAuxiliares funaux = new FuncoesAuxiliares();
        public List<Unimedida> listaunimedida;
        public Unimedida Unimedida;
        private UnimedidaDAO unimedidaDAO = new UnimedidaDAO();
        public Unimedida unimedidaSelecionada;


        public fmBuscaUnimedida()
        {
            InitializeComponent();
        }

        //LOAD
        private void FmBuscaUnimedida_Load(object sender, EventArgs e) => Busca();

        //KEYUP, KEYDOWN
        private void FmBuscaUnimedida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        //CLICK
        private void DgvUnimedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvUnimedida.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvUnimedida.Rows[selectedRowIndex];
            unimedidaSelecionada = listaunimedida.Find(u => (u.UnimedidaID).ToString() == Convert.ToString(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        //TEXTCHANGED
        private void TbFiltroDescUnimedida_TextChanged(object sender, EventArgs e) => Busca();

        //FUNÇÕES
        private void Busca()
        {
            dgvUnimedida.Columns.Clear();

            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Sigla", typeof(string));
            table.Columns.Add("Descrição", typeof(string));

            listaunimedida = unimedidaDAO.Busca(tbFiltroDescUnimedida.Text).ToList();

            foreach (Unimedida u in listaunimedida)
            {
                table.Rows.Add(u.UnimedidaID, u.Sigla, u.Descricao);

            }
            dgvUnimedida.DataSource = table;

            funaux.TratarTamanhoColunas(dgvUnimedida);
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
