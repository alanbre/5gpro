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
    public partial class fmCalculoPrecoVenda : Form
    {

        public decimal custo = 0;
        public decimal valorsugerido = 0;
        public decimal valor = 0;

        public fmCalculoPrecoVenda()
        {
            InitializeComponent();
        }

        private void FmCalculoPrecoVenda_Load(object sender, EventArgs e)
        {
            dbCusto.Valor = custo;
        }


        //EVENTOS DE LEAVE
        private void DbPorcentagem_Leave(object sender, EventArgs e)
        {
            Metodo1();
        }

        private void DbCusto_Leave(object sender, EventArgs e)
        {
            Metodo1();
        }

        private void DbValorSugerido_Leave(object sender, EventArgs e)
        {
            PorcentagemCalculo();
        }


        //EVENTOS DE CLICK
        private void BtAceitar_Click(object sender, EventArgs e)
        {
            dbValor.Valor = dbValorSugerido.Valor;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            valor = dbValor.Valor;
            custo = dbCusto.Valor;
            this.Close();
        }


        //FUNÇÕES DE CÁLCULO
        private void Metodo1()
        {
            valorsugerido = dbCusto.Valor + (dbCusto.Valor * dbPorcentagem.Valor / 100);
            dbValorSugerido.Valor = valorsugerido;
        }

        private void PorcentagemCalculo()
        {
            if(dbCusto.Valor > 0)
            dbPorcentagem.Valor = ((dbValorSugerido.Valor * 100) / dbCusto.Valor) - 100;
        }
    }
}
