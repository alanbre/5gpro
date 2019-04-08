﻿using _5gpro.Bll;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroPessoa : Form
    {
        Pessoa pessoa;
        PessoaBLL pessoaBLL = new PessoaBLL();
        Validacao validacao = new Validacao();

        FuncoesAuxiliares f = new FuncoesAuxiliares();

        bool editando = false;
        bool ignoraCheckEvent;





        public fmCadastroPessoa()
        {
            InitializeComponent();
        }

        private void fmCadastroPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RecarregaDados(pessoa);
            }

            if (e.KeyCode == Keys.F1)
            {
                NovoCadastro();
            }

            if (e.KeyCode == Keys.F2)
            {
                SalvaCadastro();
            }

            EnterTab(this.ActiveControl, e);
        }




        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            //ALTERA A MASCARA DO CAMPO PARA CPF
            mtbCpfCnpj.Clear();
            mtbCpfCnpj.Mask = "###.###.###-##";
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            //ALTERA A MASCARA DO CAMPO PARA CNPJ
            mtbCpfCnpj.Clear();
            mtbCpfCnpj.Mask = "##.###.###/####-##";
            if (!ignoraCheckEvent) { Editando(true); }
        }



        private void MenuVertical_Novo_Clicked(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e)
        {
            if (!editando)
            {
                AbreTelaBuscaPessoa();
            }
        }

        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e)
        {
            RecarregaDados(pessoa);
        }

        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e)
        {
            CadastroAnterior();
        }

        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }


        //EVENTOS DE KEY PRESS
        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //EVENTOS DE TEXTCHANGED
        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbFantasia_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbRua_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbBairro_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbComplemento_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbCodCidade_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void mtbCpfCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void mtbTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }


        //EVENTOS DE LEAVE
        private void tbCodigo_Leave(object sender, EventArgs e)
        {

            tbCodigo.Text = tbCodigo.Text == "0" ? "" : tbCodigo.Text;
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    Pessoa newpessoa = pessoaBLL.BuscarPessoaById(int.Parse(tbCodigo.Text));
                    if (newpessoa != null)
                    {
                        pessoa = newpessoa;
                        PreencheCampos(pessoa);
                        Editando(false);
                    }
                    else
                    {
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodigo.Text.Length == 0)
                {
                    LimpaCampos(true);
                    Editando(false);
                }
            }
            else
            {

                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbCodigo.Text.Length > 0)
                    {

                        Pessoa newpessoa = pessoaBLL.BuscarPessoaById(int.Parse(tbCodigo.Text));
                        if (newpessoa != null)
                        {
                            pessoa = newpessoa;
                            PreencheCampos(pessoa);
                            Editando(false);
                        }
                        else
                        {
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodigo.Text.Length == 0)
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
                else
                {

                }

            }
        }




        //EVENTOS DE KEY UP
        private void tbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                AbreTelaBuscaPessoa();
            }
        }


        private void cblAtuacao_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }



        private void fmCadastroPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


        //PADRÕES CRIADAS
        private void NovoCadastro()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LimpaCampos(false);
                    tbCodigo.Text = pessoaBLL.BuscaProxCodigoDisponivel();
                    pessoa = null;
                    Editando(false);
                    tbNome.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigo.Text = pessoaBLL.BuscaProxCodigoDisponivel();
                pessoa = null;
                Editando(false);
                tbNome.Focus();
                Editando(true);
            }
        }

        private void AbreTelaBuscaPessoa()
        {
            var buscaPessoa = new fmBuscaPessoa();
            buscaPessoa.ShowDialog();
            if (buscaPessoa.pessoaSelecionada != null)
            {
                pessoa = buscaPessoa.pessoaSelecionada;
                PreencheCampos(pessoa);
            }
        }

        private void SalvaCadastro()
        {
            //Cria uma nova instancia de pessoa, seta as informações e tenta salvar.
            if (editando)
            {

                pessoa = new Pessoa();
                pessoa.PessoaID = int.Parse(tbCodigo.Text);
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
                pessoa.Cidade = buscaCidade.cidade;
                pessoa.CpfCnpj = mtbCpfCnpj.TextNoMask();
                pessoa.Telefone = mtbTelefone.TextNoMask();
                pessoa.Email = tbEmail.Text;

                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(pessoa, controls);

                if (ok)
                {
                    int resultado = pessoaBLL.SalvarOuAtualizarPessoa(pessoa);
                    validacao.despintarCampos(controls);
                    // resultado 0 = nada foi inserido (houve algum erro)
                    // resultado 1 = foi inserido com sucesso
                    // resultado 2 = foi atualizado com sucesso
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
                        Editando(false);
                    }
                    else if (resultado == 2)
                    {
                        tbAjuda.Text = "Dados atualizados com sucesso";
                        Editando(false);
                    }
                }
            }
        }

        private void RecarregaDados(Pessoa pessoa)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (pessoa != null)
                    {
                        pessoa = pessoaBLL.BuscarPessoaById(pessoa.PessoaID);
                        PreencheCampos(pessoa);
                        Editando(false);
                    }
                    else
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
            else
            {
                if (pessoa != null)
                {
                    pessoa = pessoaBLL.BuscarPessoaById(pessoa.PessoaID);
                    PreencheCampos(pessoa);
                }
                else
                {
                    LimpaCampos(true);
                }
                Editando(false);
            }

        }

        private void ProximoCadastro()
        {
            //Busca a pessoa com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se pessoa existe. Se não existir busca o maior anterior ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigo.Text.Length > 0)
            {
                //Os registros com newpessoa é só para garantir que não vai dar confusão com a variável "global"
                //la do inicio do arquivo.

                validacao.despintarCampos(controls);

                Pessoa newpessoa = pessoaBLL.BuscarProximaPessoa(tbCodigo.Text);
                if (newpessoa != null)
                {
                    pessoa = newpessoa;
                    PreencheCampos(pessoa);
                }
            }
            else if (editando && tbCodigo.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    Pessoa newpessoa = pessoaBLL.BuscarProximaPessoa(tbCodigo.Text);
                    if (newpessoa != null)
                    {
                        pessoa = newpessoa;
                        PreencheCampos(pessoa);
                        Editando(false);
                    }
                    else
                    {
                        newpessoa = pessoaBLL.BuscarPessoaAnterior(tbCodigo.Text);
                        if (newpessoa != null)
                        {
                            pessoa = newpessoa;
                            PreencheCampos(pessoa);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void CadastroAnterior()
        {
            //Busca a pessoa com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            //Caso não houver registro com ID menor, verifica se pessoa existe. Se não existir busca o proximo ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigo.Text.Length > 0)
            {
                //Os registros com newpessoa é só para garantir que não vai dar confusão com a variável "global"
                //la do inicio do arquivo.

                validacao.despintarCampos(controls);
                Pessoa newpessoa = pessoaBLL.BuscarPessoaAnterior(tbCodigo.Text);
                if (newpessoa != null)
                {
                    pessoa = newpessoa;
                    PreencheCampos(pessoa);
                }
            }
            else if (editando && tbCodigo.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    Pessoa newpessoa = pessoaBLL.BuscarPessoaAnterior(tbCodigo.Text);
                    if (newpessoa != null)
                    {
                        pessoa = newpessoa;
                        PreencheCampos(pessoa);
                        Editando(false);
                    }
                    else
                    {
                        newpessoa = pessoaBLL.BuscarProximaPessoa(tbCodigo.Text);
                        if (newpessoa != null)
                        {
                            pessoa = newpessoa;
                            PreencheCampos(pessoa);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit);
        }

        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
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
            buscaCidade.Limpa();
            mtbCpfCnpj.Clear();
            mtbTelefone.Clear();
            tbEmail.Clear();
            foreach (int i in cblAtuacao.CheckedIndices)
            {
                cblAtuacao.SetItemCheckState(i, CheckState.Unchecked);
            }
            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;
            tbAjuda.Clear();
        }

        private void PreencheCampos(Pessoa pessoa)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = pessoa.PessoaID.ToString();
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
            mtbCpfCnpj.Text = pessoa.CpfCnpj;
            mtbTelefone.Text = pessoa.Telefone;
            tbEmail.Text = pessoa.Email;

            buscaCidade.PreencheCampos(pessoa.Cidade);

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
            ignoraCheckEvent = false;
        }

    }
}