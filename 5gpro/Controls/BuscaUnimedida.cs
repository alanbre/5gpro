using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Entities;
using _5gpro.Daos;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaUnimedida : UserControl
    {
        public Unimedida unimedida = null;
        private readonly UnimedidaDAO unimedidaDAO = new UnimedidaDAO();

        public BuscaUnimedida()
        {
            InitializeComponent();
        }

        private void TbCodigoUnimedida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaUnimedida();
            }
        }

        private void TbCodigoUnimedida_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigoUnimedida.Text, out int codigo)) { tbCodigoUnimedida.Clear(); }
            if (tbCodigoUnimedida.Text.Length > 0)
            {
                unimedida = unimedidaDAO.BuscaUnimedidaByID(int.Parse(tbCodigoUnimedida.Text));
                PreencheCamposUnimedida(unimedida);
            }
            else
            {
                unimedida = null;
                Limpa();
            }
        }

        private void BtBuscaUnimedida_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaUnimedida();
        }

        private void AbreTelaBuscaUnimedida()
        {
            var buscaUnimedida = new fmBuscaUnimedida();
            buscaUnimedida.ShowDialog();
            if (buscaUnimedida != null)
            {
                unimedida = buscaUnimedida.unimedidaSelecionada;
                PreencheCamposUnimedida(unimedida);
            }
        }

        private void PreencheCamposUnimedida(Unimedida unimedida)
        {
            if (unimedida != null)
            {
                tbCodigoUnimedida.Text = unimedida.UnimedidaID.ToString();
                tbSiglaUnimedida.Text = unimedida.Sigla;
                tbDescricaoUnimedida.Text = unimedida.Descricao;
            }
            else
            {
                MessageBox.Show("Unimedida não encontrada no banco de dados",
                "Unimedida não encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Limpa();
            }
        }

        public void PreencheCampos(Unimedida unimedida)
        {
            if (unimedida != null)
            {
                this.unimedida = unimedida;
                tbCodigoUnimedida.Text = unimedida.UnimedidaID.ToString();
                tbSiglaUnimedida.Text = unimedida.Sigla;
                tbDescricaoUnimedida.Text = unimedida.Descricao;
            }
            else
            {
                Limpa();
            }
        }

        public void Limpa()
        {
            this.unimedida = null;
            tbCodigoUnimedida.Clear();
            tbSiglaUnimedida.Clear();
            tbDescricaoUnimedida.Clear();
        }

        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código é alterado")]
        public event text_changedEventHandler Text_Changed;

        //--------------------------------------------------

        private void TbCodigoUnimedida_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }

    }
}
