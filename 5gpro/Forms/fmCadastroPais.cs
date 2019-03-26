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
        public fmCadastroPais()
        {
            InitializeComponent();
        }

        private void salvar(Pais pais)
        {
            PaisBLL pbl = new PaisBLL();

            pais.idpais = tbIdpais.Text;
            pais.nome = tbNomepais.Text;
            pais.sigla = tbSigla.Text;

            Validacao vl = new Validacao();
            bool ok = vl.ValidarEntidade(pais);

            //QUANDO A VARIÁVEL OK FOR RETORNADO COM O VALOR 0
            //SALVA O REGISTRO
            if (ok)
            {
                pbl.salvar(pais);
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


        //private void ValidarPais(object obj)
        //{
        //    var erros = Validacao.getValidationErros(obj);
        //    List<string> listaerros = new List<string>();

        //    foreach (var error in erros)
        //    {

        //        listaerros.Add(error.ErrorMessage);

        //    }
        //    if (listaerros.Count > 0)
        //    {
        //        MessageBox.Show(listaerros[0]);
        //    }

        //}

    }
}
