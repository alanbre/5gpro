using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaCaixa : UserControl
    {
        public Caixa caixa = null;
        private readonly CaixaDAO caixaDAO = new CaixaDAO();
        public BuscaCaixa()
        {
            InitializeComponent();
        }

        private void BtBusca_Click(object sender, EventArgs e) => Busca();
        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                Busca();
            }
        }
        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (tbCodigo.Text.Length > 0)
            {
                caixa = caixaDAO.Busca(int.Parse(tbCodigo.Text));
                PreencheCamposCaixa(caixa);
            }
            else
            {
                caixa = null;
                tbNome.Clear();
            }
        }



        private void Busca()
        {
            var buscaCaixa = new fmCaiBuscaCaixa();
            buscaCaixa.ShowDialog();
            if (buscaCaixa.caixaSelecionada != null)
            {
                caixa = buscaCaixa.caixaSelecionada;
                PreencheCamposCaixa(caixa);
            }
        }
        private void PreencheCamposCaixa(Caixa caixa)
        {
            if (caixa == null)
            {
                MessageBox.Show("Caixa não encontrado no banco de dados",
                "Caixa não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigo.Clear();
                tbCodigo.Focus();
                tbCodigo.SelectAll();
                return;
            }

            tbCodigo.Text = caixa.Codigo.ToString();
            tbNome.Text = caixa.Nome;
        }
        public void PreencheCampos(Caixa caixa)
        {
            this.caixa = caixa;
            tbCodigo.Text = this.caixa != null ? this.caixa.Codigo.ToString() : "";
            tbNome.Text = this.caixa != null ? this.caixa.Nome : "";
        }
        public void Limpa()
        {
            tbCodigo.Clear();
            tbNome.Clear();
            caixa = null;
        }

        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código do caixa é alterado")]
        public event text_changedEventHandler Text_Changed;

        private void TbCodigo_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
