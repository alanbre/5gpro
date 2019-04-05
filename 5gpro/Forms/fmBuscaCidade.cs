using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaCidade : Form
    {
        public List<Cidade> Cidades;
        public List<Estado> Estados;
        public Cidade cidadeSelecionada;
        private CidadeBLL cidadeBLL = new CidadeBLL();
        private EstadoBLL estadoBLL = new EstadoBLL();




        public fmBuscaCidade()
        {
            InitializeComponent();
            tbFiltroCodEstado.Focus();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            BuscaCidades();
        }

        private void btProcuraEstado_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaEstado();
        }

        private void tbFiltroCodEstado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaEstado();
            }

        }

        private void tbFiltroCodEstado_Leave(object sender, EventArgs e)
        {
            if (tbFiltroCodEstado.Text.Length > 0)
            {
                Estados = estadoBLL.BuscaEstadoByCod(tbFiltroCodEstado.Text);
                tbNomeEstado.Text = Estados[0].Nome;
            }
            else
            {
                tbNomeEstado.Text = "";
            }
        }

        private void tbFiltroCodEstado_Enter(object sender, EventArgs e)
        {
            tbFiltroCodEstado.SelectAll();
        }

        private void dgvCidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvCidades.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvCidades.Rows[selectedRowIndex];
            cidadeSelecionada = Cidades.Find(c => c.CidadeID == Convert.ToInt32(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA
            this.Close();
        }

        private void BuscaCidades()
        {

            dgvCidades.Rows.Clear();
            Cidades = cidadeBLL.BuscaCidades(tbFiltroCodEstado.Text, tbFiltroNomeCidade.Text);
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            foreach (Cidade c in Cidades)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvCidades,
                c.CidadeID,
                c.Nome,
                c.Estado.EstadoID,
                c.Estado.Nome,
                c.Estado.Uf
                );
                rows.Add(linha);

                //MÉTODO QUE PRIMEIRO ADICIONA A LINHA A LISTA DEPOIS CRIA AS CÉLULAS
                //rows.Add(new DataGridViewRow());
                //rows[rows.Count - 1].CreateCells(dgvCidades,
                //c.CidadeID,
                //c.Nome,
                //c.Estado.EstadoID,
                //c.Estado.Nome,
                //c.Estado.Uf
                //);
            }
            dgvCidades.Rows.AddRange(rows.ToArray());
            dgvCidades.Refresh();

        }



        private void AbreTelaBuscaEstado()
        {
            var buscaEstado = new fmBuscaEstado();
            buscaEstado.ShowDialog();
            Estados = new List<Estado>();
            Estados.Add(buscaEstado.EstadoSelecionado);
            if (Estados != null)
            {
                tbFiltroCodEstado.Text = Estados[0].EstadoID.ToString();
                tbNomeEstado.Text = Estados[0].Nome;
            }
            tbFiltroCodEstado.Focus();
        }

        private void tbFiltroNomeCidade_TextChanged(object sender, EventArgs e)
        {
            BuscaCidades();
        }
    }
}

