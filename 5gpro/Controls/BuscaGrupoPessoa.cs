using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaGrupoPessoa : UserControl
    {

        public GrupoPessoa grupoPessoa = null;
        private static readonly ConexaoDAO connection = new ConexaoDAO();
        private readonly GrupoPessoaDAO grupoPessoaDAO = new GrupoPessoaDAO(connection);

        public BuscaGrupoPessoa()
        {
            InitializeComponent();
        }

        private void TbCodigoGrupoPessoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaGrupoPessoa();
            }
        }

        private void TbCodigoGrupoPessoa_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigoGrupoPessoa.Text, out int codigo)) { tbCodigoGrupoPessoa.Clear(); }
            if (tbCodigoGrupoPessoa.Text.Length > 0)
            {
                grupoPessoa = grupoPessoaDAO.BuscarByID(int.Parse(tbCodigoGrupoPessoa.Text));
                PreencheCamposGrupoPessoa(grupoPessoa);
            }
            else
            {
                grupoPessoa = null;
                tbNomeGrupoPessoa.Clear();
            }
        }

        private void BtBuscaGrupoPessoa_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaGrupoPessoa();
        }

        private void AbreTelaBuscaGrupoPessoa()
        {
            var buscaGrupoPessoa = new fmBuscaGrupoPessoa();
            buscaGrupoPessoa.ShowDialog();
            if (buscaGrupoPessoa.grupoPessoaSelecionado != null)
            {
                grupoPessoa = buscaGrupoPessoa.grupoPessoaSelecionado;
                PreencheCamposGrupoPessoa(grupoPessoa);
            }
        }

        private void PreencheCamposGrupoPessoa(GrupoPessoa grupoPessoa)
        {
            if (grupoPessoa != null)
            {
                tbCodigoGrupoPessoa.Text = grupoPessoa.GrupoPessoaID.ToString();
                tbNomeGrupoPessoa.Text = grupoPessoa.Nome;
            }
            else
            {
                MessageBox.Show("Grupo de pessoas não encontrado no banco de dados",
                "Grupo de pessoas não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Limpa();
            }
        }

        public void PreencheCampos(GrupoPessoa grupoPessoa)
        {
            if (grupoPessoa != null)
            {
                this.grupoPessoa = grupoPessoa;
                tbCodigoGrupoPessoa.Text = grupoPessoa.GrupoPessoaID.ToString();
                tbNomeGrupoPessoa.Text = grupoPessoa.Nome;
            }
            else
            {
                Limpa();
            }
        }

        public void Limpa()
        {
            this.grupoPessoa = null;
            tbCodigoGrupoPessoa.Clear();
            tbNomeGrupoPessoa.Clear();
        }

        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoGrupoPessoa_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
