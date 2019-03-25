﻿using _5gpro.Bll;
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
            DataTable table = new DataTable();
            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Cidade", typeof(string));
            table.Columns.Add("Código do estado", typeof(string));
            table.Columns.Add("Estado", typeof(string));
            table.Columns.Add("UF", typeof(string));

            Cidades = cidadeBLL.BuscaCidades(tbFiltroCodEstado.Text, tbFiltroNomeCidade.Text);

            foreach (Cidade c in Cidades)
            {
                table.Rows.Add(c.CodCidade, c.Nome, c.Estado.CodEstado, c.Estado.Nome, c.Estado.Uf);
            }
            dgvCidades.DataSource = table;
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
            cidadeSelecionada = new Cidade();
            cidadeSelecionada.CodCidade = Convert.ToString(selectedRow.Cells[0].Value);
            cidadeSelecionada.Nome = Convert.ToString(selectedRow.Cells[1].Value);
            this.Close();
        }




        private void AbreTelaBuscaEstado()
        {
            var buscaEstado = new fmBuscaEstado();
            buscaEstado.ShowDialog();
            Estados = new List<Estado>();
            Estados.Add(buscaEstado.EstadoSelecionado);
            if (Estados != null)
            {
                tbFiltroCodEstado.Text = Estados[0].CodEstado;
                tbNomeEstado.Text = Estados[0].Nome;
            }
            tbFiltroCodEstado.Focus();
        }
    }
}