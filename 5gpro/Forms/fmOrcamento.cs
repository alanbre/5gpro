using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmOrcamento : Form
    {
        Pessoa pessoa = null;
        PessoaBLL pessoaBLL = new PessoaBLL();


        bool editando = false;



        public fmOrcamento()
        {
            InitializeComponent();
        }

        private void dtpCadastro_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsNumber((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void cbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            dtpVencimento.Enabled = cbVencimento.Checked ? true : false;
        }

        private void tbCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                AbreTelaBuscaPessoa();
            }
        }

        private void tbCodCliente_Leave(object sender, EventArgs e)
        {
            if (tbCodCliente.Text.Length > 0)
            {
                pessoa = pessoaBLL.BuscarPessoaById(tbCodCliente.Text);
                PreencheCamposPessoa(pessoa);
            }
            else
            {
                tbNomeCliente.Text = "";
            }
        }




        private void AbreTelaBuscaPessoa()
        {
            var buscaPessoa = new fmBuscaPessoa();
            buscaPessoa.ShowDialog();
            if (buscaPessoa.pessoaSelecionada != null)
            {
                pessoa = buscaPessoa.pessoaSelecionada;
                PreencheCamposPessoa(pessoa);
            }
        }

        private void PreencheCamposPessoa(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                tbCodCliente.Text = pessoa.Codigo;
                tbNomeCliente.Text = pessoa.Nome;
                Editando(true);
            }
        }

        private void AlteraBotoes()
        {
            if (editando)
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_black;
                btNovo.Enabled = false;
                btSalvar.Image = Properties.Resources.iosOk_48px_Green;
                btSalvar.Enabled = true;
                btBuscar.Image = Properties.Resources.iosSearch_48px_black;
                btBuscar.Enabled = false;
                btDeletar.Image = Properties.Resources.iosDelete_48px_black;
                btDeletar.Enabled = false;
            }
            else
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_blue;
                btNovo.Enabled = true;
                btSalvar.Image = Properties.Resources.iosOk_48px_black;
                btSalvar.Enabled = false;
                btBuscar.Image = Properties.Resources.iosSearch_48px_Blue;
                btBuscar.Enabled = true;
                btDeletar.Image = Properties.Resources.iosDelete_48px_Red;
                btDeletar.Enabled = false;
            }
        }

        private void Editando(bool edit)
        {
            editando = edit;
            AlteraBotoes();
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            //tbCodigo.Text = tbCodigo.Text == "0" ? "" : tbCodigo.Text;
            //if (!editando)
            //{
            //    if (tbCodigo.Text.Length > 0)
            //    {
            //        Pessoa newpessoa = pessoaBLL.BuscarPessoaById(tbCodigo.Text);
            //        if (newpessoa != null)
            //        {
            //            pessoa = newpessoa;
            //            PreencheCampos(orcamento);
            //            Editando(false);
            //        }
            //        else
            //        {
            //            Editando(true);
            //            LimpaCampos(false);
            //        }
            //    }
            //    else if (tbCodigo.Text.Length == 0)
            //    {
            //        LimpaCampos(true);
            //        Editando(false);
            //    }
            //}
            //else
            //{
            //    if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            //    "Aviso de alteração",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        if (tbCodigo.Text.Length > 0)
            //        {
            //            Pessoa newpessoa = pessoaBLL.BuscarPessoaById(tbCodigo.Text);
            //            if (newpessoa != null)
            //            {
            //                pessoa = newpessoa;
            //                PreencheCampos(pessoa);
            //                Editando(false);
            //            }
            //            else
            //            {
            //                Editando(true);
            //                LimpaCampos(false);
            //            }
            //        }
            //        else if (tbCodigo.Text.Length == 0)
            //        {
            //            LimpaCampos(true);
            //            Editando(false);
            //        }
            //    }
            //}
        }
    }
}
