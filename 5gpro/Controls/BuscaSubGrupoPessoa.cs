using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Entities;
using _5gpro.Daos;
using _5gpro.Forms;

namespace _5gpro.Controls
{
    public partial class BuscaSubGrupoPessoa : UserControl
    {

        public SubGrupoPessoa subgrupoPessoa = null;
        private GrupoPessoa gruporecebido = null;
        private static readonly ConexaoDAO conexao = new ConexaoDAO();
        private readonly SubGrupoPessoaDAO subgrupoPessoaDAO = new SubGrupoPessoaDAO(conexao);

        public BuscaSubGrupoPessoa()
        {
            InitializeComponent();
        }

        public void EnviarGrupo(GrupoPessoa grupopessoa)
        {
            gruporecebido = grupopessoa;
        }

        private void TbCodigoSubGrupoPessoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaSubGrupoPessoa();
            }
        }

        private void TbCodigoSubGrupoPessoa_Leave(object sender, EventArgs e)
        {

            if (!int.TryParse(tbCodigoSubGrupoPessoa.Text, out int codigo)) { tbCodigoSubGrupoPessoa.Clear(); }

            if (gruporecebido == null)
            {
                tbNomeSubGrupoPessoa.Text = "Escolha o Grupo";
            }
            else
            {
                if (tbCodigoSubGrupoPessoa.Text.Length > 0)
                {
                    subgrupoPessoa = subgrupoPessoaDAO.BuscarByID(int.Parse(tbCodigoSubGrupoPessoa.Text), gruporecebido.GrupoPessoaID);
                    PreencheCamposSubGrupoPessoa(subgrupoPessoa);
                }
                else
                {
                    subgrupoPessoa = null;
                    tbNomeSubGrupoPessoa.Clear();
                }
            }
        }

        private void BtBuscaSubGrupoPessoa_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaSubGrupoPessoa();
        }

        private void AbreTelaBuscaSubGrupoPessoa()
        {
            if (gruporecebido == null)
            {
                MessageBox.Show("Escolha o Grupo antes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var buscaSubGrupoPessoa = new fmBuscaSubGrupoPessoa(gruporecebido.GrupoPessoaID);
                buscaSubGrupoPessoa.ShowDialog();
                if (buscaSubGrupoPessoa.subgrupopessoaSelecionado != null)
                {
                    subgrupoPessoa = buscaSubGrupoPessoa.subgrupopessoaSelecionado;
                    PreencheCamposSubGrupoPessoa(subgrupoPessoa);
                }
            }
        }

        private void PreencheCamposSubGrupoPessoa(SubGrupoPessoa subgrupoPessoa)
        {
            if (subgrupoPessoa != null)
            {
                tbCodigoSubGrupoPessoa.Text = subgrupoPessoa.SubGrupoPessoaID.ToString();
                tbNomeSubGrupoPessoa.Text = subgrupoPessoa.Nome;
            }
            else
            {
                MessageBox.Show("Sub-Grupo de pessoas não encontrado no banco de dados",
                "Sub-Grupo de pessoas não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                Limpa();
            }
        }

        public void PreencheCampos(SubGrupoPessoa subgrupoPessoa)
        {
            if (subgrupoPessoa != null)
            {
                this.subgrupoPessoa = subgrupoPessoa;
                tbCodigoSubGrupoPessoa.Text = subgrupoPessoa.SubGrupoPessoaID.ToString();
                tbNomeSubGrupoPessoa.Text = subgrupoPessoa.Nome;
            }
            else
            {
                Limpa();
            }
        }

        public void EscolhaOGrupo()
        {
            tbNomeSubGrupoPessoa.Text = "Escolha o Grupo";
        }

        public void Limpa()
        {
            this.subgrupoPessoa = null;
            tbCodigoSubGrupoPessoa.Clear();
            tbNomeSubGrupoPessoa.Clear();
        }

        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo do código é alterado")]
        public event text_changedEventHandler Text_Changed;
        //--------------------------------------------------

        private void TbCodigoSubGrupoPessoa_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
