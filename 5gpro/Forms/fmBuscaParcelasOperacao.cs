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
    public partial class fmBuscaParcelasOperacao : Form
    {

        public List<ParcelaOperacao> listaparcelasbusca;
        public fmCadastroOperacao telacadoperacao;
        ParcelaOperacao parcela;

        public fmBuscaParcelasOperacao(List<ParcelaOperacao> lista, fmCadastroOperacao cadoperacao)
        {
            InitializeComponent();
            listaparcelasbusca = lista;
            BuscaParcelas();
            telacadoperacao = cadoperacao;
        }

        private void AlterarRB()
        {
            if (rbSelecionar.Checked)
                tbNumeroParcela.Enabled = true;

            if (rbTodas.Checked)
            {
                tbNumeroParcela.Enabled = false;
                tbNumeroParcela.Clear();
            }                      
        }

        private void EditarDias()
        {
            if (rbTodas.Checked)
            {
                if(int.TryParse(tbDias.Text, out int codigo))
                {
                    int numero = listaparcelasbusca.Count;
                    listaparcelasbusca = new List<ParcelaOperacao>();

                    for (int a = 1; a <= numero; a++)
                    {
                        parcela = new ParcelaOperacao();
                        parcela.Numero = a;
                        parcela.Dias = int.Parse(tbDias.Text) * a;
                        listaparcelasbusca.Add(parcela);
                    }
                    BuscaParcelas();
                }
                else
                {
                    tbDias.Clear();
                    MessageBox.Show("Apenas números", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuscaParcelas()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Parcela", typeof(string));
            table.Columns.Add("Dias", typeof(string));

            foreach (ParcelaOperacao p in listaparcelasbusca)
            {
                table.Rows.Add(p.Numero, p.Dias);
            }
            dgvParcelasOperacao.DataSource = table;

        }

        private void BtAplicar_Click(object sender, EventArgs e)
        {
            EditarDias();
        }

        private void RbTodas_CheckedChanged(object sender, EventArgs e)
        {
            AlterarRB();
        }

        private void RbSelecionar_CheckedChanged(object sender, EventArgs e)
        {
            AlterarRB();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Salvar alteração ?",
                             "Aviso de alteração",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                telacadoperacao.listaparcelasprincipal = listaparcelasbusca;              
            }

        }
    }
}
