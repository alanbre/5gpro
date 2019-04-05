using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Forms;
using System.Windows.Forms;

namespace _5gpro.Controls
{
    public partial class buscaCidade : UserControl
    {
        public Cidade cidade = null;

        private readonly CidadeBLL cidadeBLL = new CidadeBLL();

        public buscaCidade()
        {
            InitializeComponent();
        }

        private void BtBuscaCidade_Click(object sender, System.EventArgs e)
        {
            AbreTelaBuscaCidade();
        }

        private void TbFiltroCodigoCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaCidade();
            }
        }

        private void TbFiltroCodigoCidade_Leave(object sender, System.EventArgs e)
        {
            if (tbFiltroCodigoCidade.Text.Length > 0)
            {
                cidade = cidadeBLL.BuscaCidadeByCod(int.Parse(tbFiltroCodigoCidade.Text));
                PreencheCamposCidade(cidade);
            }
            else
            {
                tbNomeCidade.Text = "";
            }
        }


        private void AbreTelaBuscaCidade()
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
                tbFiltroCodigoCidade.Text = cidade.CidadeID.ToString();
                tbNomeCidade.Text = cidade.Nome;
            }
            else
            {
                MessageBox.Show("Cidade não encontrada no banco de dados",
                "Cidade não encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbFiltroCodigoCidade.Clear();
                tbFiltroCodigoCidade.Focus();
                tbFiltroCodigoCidade.SelectAll();
            }
        }

    }
}
