using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Funcoes;
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

        Validacao validacao = new Validacao();
    
        


        public fmCadastroPais()
        {
            InitializeComponent();
        }

        private void salvar(Pais pais)
        {
            PaisBLL pbl = new PaisBLL();

            pais.idpais = tbCodpais.Text;
            pais.nome = tbNomepais.Text;
            pais.sigla = tbSiglapais.Text;

            ControlCollection controls = (ControlCollection)this.Controls;

            bool ok = validacao.ValidarEntidade(pais, controls);

            //QUANDO A VARIÁVEL OK FOR RETORNADO COM O VALOR 0
            //SALVA O REGISTRO
            if (ok)
            {
                pbl.salvar(pais);
                
                
                new Limpar().limparTudo(this.Controls);
                MessageBox.Show("País adicionado com sucesso!");
            }

        }

        private void btSavepais_Click(object sender, EventArgs e)
        {
            Pais pais = new Pais();
            salvar(pais);
        }

        private void fmCadastroPais_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
