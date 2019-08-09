using System;
using System.ComponentModel;
using System.Windows.Forms;
using _5gpro.Entities;
using _5gpro.Daos;
using _5gpro.Forms;

namespace _5gpro.Controls
{

    public partial class BuscaBanco : UserControl
    {
        private readonly BancoDAO bancoDAO = new BancoDAO();

        public Banco banco = null;


        public BuscaBanco()
        {
            InitializeComponent();
        }

        private void TbCodigoBanco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaBanco();
            }
        }
        private void TbCodigoBanco_Leave(object sender, EventArgs e) => Busca();
        private void BtBuscaBanco_Click(object sender, EventArgs e) => AbreTelaBuscaBanco();

        private void Busca()
        {
            if (!int.TryParse(tbCodigoBanco.Text, out int codigo)) { tbCodigoBanco.Clear(); }
            if (tbCodigoBanco.Text.Length > 0)
            {
                banco = bancoDAO.BuscaByCod(tbCodigoBanco.Text);
                PreencheCamposBanco(banco);
            }
            else
            {
                banco = null;
                tbNomeBanco.Clear();
            }
        }
        private void AbreTelaBuscaBanco()
        {
            var buscaBanco = new fmBuscaBanco();
            buscaBanco.ShowDialog();
            if (buscaBanco.bancoSelecionado != null)
            {
                banco = buscaBanco.bancoSelecionado;
                PreencheCamposBanco(banco);
            }
        }
        private void PreencheCamposBanco(Banco banco)
        {
            if (banco == null)
            {
                MessageBox.Show($"Banco não encontrado no banco de dados",
                $"Banco não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodigoBanco.Clear();
                tbCodigoBanco.Focus();
                tbCodigoBanco.SelectAll();
                return;
            }

            tbCodigoBanco.Text = banco.Codigo;
            tbNomeBanco.Text = banco.Nome;

        }
        public void PreencheCampos(Banco banco)
        {
            this.banco = banco;
            tbCodigoBanco.Text = this.banco?.Codigo ?? "";
            tbNomeBanco.Text = this.banco?.Nome ?? "";
        }

        public void Limpa()
        {
            tbCodigoBanco.Clear();
            tbNomeBanco.Clear();
            this.banco = null;
        }

        //--------------------------------------------------
        //CRIA O EVENTO Text_Changed DO USERCONTROL
        //--------------------------------------------------
        public delegate void text_changedEventHandler(object sender, EventArgs e);

        [Category("Action")]
        [Description("É acionado quando o conteúdo é alterado")]
        public event text_changedEventHandler Text_Changed;

        private void TbCodigoBanco_TextChanged(object sender, EventArgs e)
        {
            this.Text_Changed?.Invoke(this, e);
        }
    }
}
