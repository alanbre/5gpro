using System;
using System.Windows.Forms;
using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaEstado : UserControl
    {
        public Estado estado = null;

        private readonly EstadoBLL estadoBLL = new EstadoBLL();

        public BuscaEstado()
        {
            InitializeComponent();
        }

        private void TbCodigoEstado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaEstado();
            }
        }

        private void TbCodigoEstado_Leave(object sender, EventArgs e)
        {
            if (tbCodigoEstado.Text.Length > 0)
            {
                estado = estadoBLL.BuscaEstadoByCod(int.Parse(tbCodigoEstado.Text));
                PreencheCamposEstado(estado);
            }
            else
            {
                estado = null;
                tbNomeEstado.Text = "";
            }
        }

        private void BtBuscaEstado_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaEstado();
        }

        private void AbreTelaBuscaEstado()
        {
            var buscaEstado = new fmBuscaEstado();
            buscaEstado.ShowDialog();
            if (buscaEstado.EstadoSelecionado != null)
            {
                estado = buscaEstado.EstadoSelecionado;
                PreencheCamposEstado(estado);

            }
            tbCodigoEstado.Focus();
        }


        private void PreencheCamposEstado(Estado estado)
        {
            if (estado != null)
            {
                tbCodigoEstado.Text = estado.EstadoID.ToString();
                tbNomeEstado.Text = estado.Nome;
            }
            else
            {
                MessageBox.Show("Estado não encontrado no banco de dados",
                "Estado não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbNomeEstado.Clear();
                tbCodigoEstado.Focus();
                tbCodigoEstado.SelectAll();
            }
        }
    }
}
