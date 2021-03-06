﻿using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace _5gpro.Controls
{
    public partial class BuscaCidade : UserControl
    {
        [Description("Texto do Label"), Category("Appearance")]
        public string LabelText
        {
            get
            {
                // Insert code here.
                return lbFiltroCidade.Text;
            }
            set
            {
                lbFiltroCidade.Text = value;
            }
        }
        public BuscaCidade()
        {
            InitializeComponent();
        }


        public Cidade cidade = null;
        
        private readonly CidadeDAO cidadeDAO = new CidadeDAO();


        private void BtBuscaCidade_Click(object sender, System.EventArgs e) => Busca();
        private void TbFiltroCodigoCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                Busca();
            }
        }
        private void TbFiltroCodigoCidade_Leave(object sender, System.EventArgs e)
        {
            if (!int.TryParse(tbCodigoCidade.Text, out int codigo)) { tbCodigoCidade.Clear(); }
            if (tbCodigoCidade.Text.Length > 0)
            {
                cidade = cidadeDAO.BuscaByID(int.Parse(tbCodigoCidade.Text));
                PreencheCamposCidade(cidade);
            }
            else
            {
                cidade = null;
                tbNomeCidade.Clear();
            }
        }


        private void Busca()
        {
            var buscaCidade = new fmBuscaCidade();
            buscaCidade.ShowDialog();
            if (buscaCidade.cidadeSelecionada != null)
            {
                cidade = buscaCidade.cidadeSelecionada;
                PreencheCamposCidade(cidade);
            }
        }
        private void PreencheCamposCidade(Cidade cidade)
        {
            if (cidade != null)
            {
                tbCodigoCidade.Text = cidade.CidadeID.ToString();
                tbNomeCidade.Text = cidade.Nome;
            }
            else
            {
                MessageBox.Show("Cidade não encontrada no banco de dados",
                "Cidade não encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigoCidade.Clear();
                tbCodigoCidade.Focus();
                tbCodigoCidade.SelectAll();
            }
        }
        public void PreencheCampos(Cidade cidade)
        {
            this.cidade = cidade;
            tbCodigoCidade.Text = this.cidade != null ? this.cidade.CidadeID.ToString() : "";
            tbNomeCidade.Text = this.cidade != null ? this.cidade.Nome : "";
        }
        public void Limpa()
        {
            tbCodigoCidade.Clear();
            tbNomeCidade.Clear();
            cidade = null;
        }




        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código da pessoa é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoCidade_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
