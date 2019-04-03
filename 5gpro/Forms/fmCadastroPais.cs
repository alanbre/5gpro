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
        Pais pais;
        Validacao validacao = new Validacao();
        PaisBLL paisBLL = new PaisBLL();
    
        


        public fmCadastroPais()
        {
            InitializeComponent();
        }

    

        private void SalvaCadastro()
        {
            PaisBLL pbl = new PaisBLL();


            pais = new Pais();
            pais.PaisID = int.Parse(tbCodpais.Text);
            pais.nome = tbNomepais.Text;
            pais.sigla = tbSiglapais.Text;

            ControlCollection controls = (ControlCollection)this.Controls;

            bool ok = validacao.ValidarEntidade(pais, controls);

            //QUANDO A VARIÁVEL OK FOR RETORNADO COM O VALOR 0
            //SALVA O REGISTRO
            if (ok)
            {

                validacao.despintarCampos(controls);
                int resultado = paisBLL.SalvarOuAtualizarItem(pais);

                // resultado 0 = nada foi inserido (houve algum erro)
                // resultado 1 = foi inserido com sucesso
                // resultado 2 = foi atualizado com sucesso
                if (resultado == 0)
                {
                    MessageBox.Show("Problema ao salvar o registro",
                    "Problema ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Dados salvos com sucesso");
                    //tbAjuda.Text = "Dados salvos com sucesso";
                    //Editando(false);
                }
                else if (resultado == 2)
                {
                    MessageBox.Show("Dados atualizados com sucesso");
                    //tbAjuda.Text = "Dados atualizados com sucesso";
                    //Editando(false);
                }


            }

        }

        private void btSavepais_Click(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void fmCadastroPais_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
