using _5gpro.Bll;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroPessoa : Form, IMessageFilter
    {
        Pessoa pessoa = new Pessoa();
        Cidade cidade = new Cidade();
        PessoaBLL pessoaBLL = new PessoaBLL();
        CidadeBLL cidadeBLL = new CidadeBLL();

        bool editando = false;

        public fmCadastroPessoa()
        {
            InitializeComponent();
            Application.AddMessageFilter(this); // código para trocar o enter por tab
            AlteraBotoes();
        }

        //Continuação do código para trocar o enter por tab
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x100)//WM_KEYDOWN
            {
                if (m.WParam.ToInt32() == 0xd)//VK_RETURN = 0xd
                {
                    if (this.ActiveControl is TextBox || this.ActiveControl is RadioButton || this.ActiveControl is MaskedTextBox)
                    {
                        SendKeys.Send("{TAB}");
                        return true; //Discard the Enter key
                    }
                }
            }
            return false;
        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Clear();
            mtbCpfCnpj.Mask = "###.###.###-##";
            editando = true;
            AlteraBotoes();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Clear();
            mtbCpfCnpj.Mask = "##.###.###/####-##";
            editando = true;
            AlteraBotoes();
        }




        //EVENTOS DE CLICK
        private void btNovo_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    editando = true;
                    NovoRegistro();
                    tbCodigo.Focus();
                }
                else
                {

                }
            }
            else
            {
                tbCodigo.Focus();
                editando = true;
            }
            AlteraBotoes();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            var buscaPessoa = new fmBuscaPessoa();
            buscaPessoa.ShowDialog();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            pessoa.Codigo = tbCodigo.Text;
            pessoa.Nome = tbNome.Text;
            pessoa.Fantasia = tbFantasia.Text;
            List<string> atuacoes = new List<string>();
            foreach (string s in cblAtuacao.CheckedItems)
            {
                atuacoes.Add(s);
            }
            pessoa.Atuacao = atuacoes;
            pessoa.TipoPessoa = rbPessoaFisica.Checked ? "F" : "J";
            pessoa.Rua = tbRua.Text;
            pessoa.Numero = tbNumero.Text;
            pessoa.Bairro = tbBairro.Text;
            pessoa.Complemento = tbComplemento.Text;
            pessoa.Cidade = tbCodCidade.Text;
            pessoa.CpfCnpj = mtbCpfCnpj.TextNoMask();
            pessoa.Telefone = mtbTelefone.TextNoMask();
            pessoa.Email = tbEmail.Text;

            int resultado = pessoaBLL.SalvarOuAtualizarPessoa(pessoa);
            if (resultado == 0)
            {
                MessageBox.Show("Problema ao salvar o registro",
                "Problema ao salvar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (resultado == 1)
            {
                tbAjuda.Text = "Dados salvos com sucesso";
                editando = false;
                AlteraBotoes();
            }
            else if (resultado == 2)
            {
                tbAjuda.Text = "Dados atualizados com sucesso";
                editando = false;
                AlteraBotoes();
            }
        }

        private void btBuscaCidade_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaCidade();
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            RecarregarDados(pessoa);
        }

        private void btRight_Click(object sender, EventArgs e)
        {

        }

        private void btLeft_Click(object sender, EventArgs e)
        {

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {

            }
        }




        //EVENTOS DE KEY PRESS
        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        //EVENTOS DE LEAVE
        private void tbCodCidade_Leave(object sender, EventArgs e)
        {
            if (tbCodCidade.Text.Length > 0)
            {
                cidade = cidadeBLL.BuscaCidadeByCod(tbCodCidade.Text);
                PreencheCamposCidade(cidade);
            }
            else
            {
                tbNomeCidade.Text = "";
            }
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    pessoa = pessoaBLL.BuscaPessoaById(tbCodigo.Text);
                    if (pessoa.Codigo != null)
                    {
                        PreencheCampos(pessoa);
                        Editando(false);
                    }
                    else
                    {
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                AlteraBotoes();
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    NovoRegistro();
                }
            }
        }




        //EVENTOS DE KEY UP
        private void tbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                var buscaPessoa = new fmBuscaPessoa();
                buscaPessoa.ShowDialog();
            }
        }

        private void tbNome_KeyUp(object sender, KeyEventArgs e)
        {
            editando = true;
            AlteraBotoes();
        }

        private void tbFantasia_KeyUp(object sender, KeyEventArgs e)
        {
            editando = true;
            AlteraBotoes();
        }

        private void tbRua_KeyUp(object sender, KeyEventArgs e)
        {
            editando = true;
            AlteraBotoes();
        }

        private void tbNumero_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char) e.KeyCode))
            {
                Editando(true);
            }
        }

        private void tbBairro_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void tbComplemento_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void tbCodCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaCidade();
            }

            if (e.KeyCode < Keys.F1 || e.KeyCode > Keys.F12)
            {
                editando = true;
                AlteraBotoes();
            }

        }



        private void cblAtuacao_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Editando(true);
        }








        //PADRÕES CRIADAS
        private void RecarregarDados(Pessoa pessoa)
        {
            //TODO
            //BUSCAR NOVAMENTO OS DADOS DO BANCO (POIS OS DADOS PODEM TER SIDO ALTERADOS ENQUANTO O REGISTRO ESTAVA CARREGADO)
            PreencheCampos(pessoa);
            editando = false;
            AlteraBotoes();
        }

        private void NovoRegistro()
        {
            LimpaCampos(false);
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

        private void LimpaCampos(bool limpaCodigo)
        {
            if (limpaCodigo) { tbCodigo.Clear(); }
            tbNome.Clear();
            tbFantasia.Clear();
            tbRua.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbComplemento.Clear();
            tbCodCidade.Clear();
            tbNomeCidade.Clear();
            mtbCpfCnpj.Clear();
            mtbTelefone.Clear();
            tbEmail.Clear();
            foreach (int i in cblAtuacao.CheckedIndices)
            {
                cblAtuacao.SetItemCheckState(i, CheckState.Unchecked);
            }
            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;
        }

        private void PreencheCampos(Pessoa pessoa)
        {
            LimpaCampos(false);
            tbCodigo.Text = pessoa.Codigo;
            tbNome.Text = pessoa.Nome;
            tbFantasia.Text = pessoa.Fantasia;
            if (pessoa.TipoPessoa == "F")
            {
                rbPessoaFisica.Checked = true;
                rbPessoaJuridica.Checked = false;
            }
            else
            {
                rbPessoaFisica.Checked = false;
                rbPessoaJuridica.Checked = true;
            }
            tbRua.Text = pessoa.Rua;
            tbNumero.Text = pessoa.Numero;
            tbBairro.Text = pessoa.Bairro;
            tbComplemento.Text = pessoa.Complemento;
            tbCodCidade.Text = pessoa.Cidade;
            mtbCpfCnpj.Text = pessoa.CpfCnpj;
            mtbTelefone.Text = pessoa.Telefone;
            tbEmail.Text = pessoa.Email;

            if (pessoa.Cidade != null)
            {
                cidade = cidadeBLL.BuscaCidadeByCod(pessoa.Cidade);
                PreencheCamposCidade(cidade);
            }

            foreach (string atuacao in pessoa.Atuacao)
            {
                switch (atuacao)
                {
                    case "Cliente":
                        cblAtuacao.SetItemChecked(0, true);
                        break;
                    case "Fornecedor":
                        cblAtuacao.SetItemChecked(1, true);
                        break;
                }
            }
        }

        private void PreencheCamposCidade(Cidade cidade)
        {
            if (cidade != null)
            {
                tbCodCidade.Text = cidade.CodCidade;
                tbNomeCidade.Text = cidade.Nome;
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

        private void Editando(bool edit)
        {
            editando = edit;
            AlteraBotoes();
        }

    }
}
