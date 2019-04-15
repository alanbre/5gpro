using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaUnidadeMedida : UserControl
    {
        public UnidadeMedida unidadeMedida = new UnidadeMedida();
        private readonly UnimedidaDAO unidadeMedidaDAO = new UnimedidaDAO();

        public BuscaUnidadeMedida()
        {
            InitializeComponent();
        }

        private void TbCodigoUnidadeMedida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaUnidadeMedida();
            }
        }

        private void TbCodigoUnidadeMedida_Leave(object sender, System.EventArgs e)
        {
            if (!int.TryParse(tbCodigoUnidadeMedida.Text, out int codigo)) { tbCodigoUnidadeMedida.Clear(); }
            if (tbCodigoUnidadeMedida.Text.Length > 0)
            {
                this.unidadeMedida = unidadeMedidaDAO.BuscaUnimedidaByCod(int.Parse(tbCodigoUnidadeMedida.Text));
                PreencheCamposUnidadeMedida(this.unidadeMedida);
            }
            else
            {
                this.unidadeMedida = null;
                tbNomeUnidadeMedida.Clear();
            }
        }


        private void BtBuscaUnidadeMedida_Click(object sender, System.EventArgs e)
        {
            AbreTelaBuscaUnidadeMedida();
        }

        private void AbreTelaBuscaUnidadeMedida()
        {
            var buscaUnidadeMedida = new fmBuscaUnidadeMedida();
            buscaUnidadeMedida.ShowDialog();
            if (buscaUnidadeMedida.unidadeMedidaSelecionada != null)
            {
                unidadeMedida = buscaUnidadeMedida.unidadeMedidaSelecionada;
                PreencheCamposUnidadeMedida(unidadeMedida);
            }
        }

        private void PreencheCamposUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            tbCodigoUnidadeMedida.Text = unidadeMedida.UnidadeMedidaID.ToString();
            tbNomeUnidadeMedida.Text = unidadeMedida.Descricao;
        }

        public void PreencheCampos(UnidadeMedida unidadeMedida)
        {
            this.unidadeMedida = unidadeMedida;
            PreencheCamposUnidadeMedida(unidadeMedida);
        }

        public void Limpa()
        {
            this.unidadeMedida = null;
            tbCodigoUnidadeMedida.Clear();
            tbNomeUnidadeMedida.Clear();
        }


        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código da pessoa é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoUnidadeMedida_TextChanged(object sender, System.EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
