using _5gpro.Bll;
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
    public partial class fmCadastroPais : Form
    {
        public fmCadastroPais()
        {
            InitializeComponent();
        }

        private void salvar(Pais pais)
        {
            PaisBLL pbl = new PaisBLL();

            pais.idpais = int.Parse(tbIdpais.Text);
            pais.nome = tbNomepais.Text;
            pais.sigla = tbSigla.Text;

            pbl.salvar(pais);

            MessageBox.Show("País adicionado com sucesso!");


        }

        private void btSavepais_Click(object sender, EventArgs e)
        {
            Pais pais = new Pais();
            salvar(pais);
        }

        private void fmCadastroPais_Load(object sender, EventArgs e)
        {

        }
    }
}
