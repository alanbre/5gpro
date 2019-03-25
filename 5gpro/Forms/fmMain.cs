﻿using _5gpro.Daos;
using _5gpro.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();

        }

        private void cadastrosDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadPessoas = new fmCadastroPessoa();
            formCadPessoas.Show();
        }

        private void cadastroDePaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadPais = new fmCadastroPais();
            formCadPais.Show(this);
        }

        private void cadastroDeItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadItens = new fmCadastroItens();
            formCadItens.Show(this);
        }

        private void cadastroDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadFuncionario = new fmCadastroFuncionario();
            formCadFuncionario.Show(this);
        }
    }
}