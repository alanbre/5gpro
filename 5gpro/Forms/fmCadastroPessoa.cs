﻿using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.StaticFiles;
using System;
using System.Windows.Forms;

//CÓDIGO TELA CADASTRO DE PESSOA : 010100

namespace _5gpro.Forms
{
    public partial class fmCadastroPessoa : Form
    {
        private Pessoa pessoa;
        private readonly PessoaDAO pessoaDAO = new PessoaDAO();
        private readonly Validacao validacao = new Validacao();

        private int Nivel;
        private string CodGrupoUsuario;


        bool editando = false;
        bool ignoraCheckEvent;
        int codigo = 0;

        public fmCadastroPessoa()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void SetarNivel()
        {
            CodGrupoUsuario = Logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            Nivel = Logado.Usuario.Grupousuario.Permissoes.Find(p => p.Codigo == "010100").Nivel;
            Editando(editando);
        }

        private void FmCadastroPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Novo();
                return;
            }

            if (e.KeyCode == Keys.F2)
            {
                Salva();
                return;
            }

            if (e.KeyCode == Keys.F5)
            {
                Recarrega();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void FmCadastroPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!editando)
                return;

            if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            "Aviso de alteração",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }
        private void BuscaSubGrupoPessoa_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void TbNome_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbFantasia_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbRua_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbNumero_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbBairro_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbComplemento_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbEmail_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbCep_TextChanged(object sender, EventArgs e) => Editando(true);
        private void RbAtivo_CheckedChanged(object sender, EventArgs e) => Editando(true);
        private void RbInativo_CheckedChanged(object sender, EventArgs e) => Editando(true);
        private void TbAgencia_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbContaBancaria_TextChanged(object sender, EventArgs e) => Editando(true);
        private void RbContaCorrente_CheckedChanged(object sender, EventArgs e) => Editando(true);
        private void RbContaPoupanca_CheckedChanged(object sender, EventArgs e) => Editando(true);
        private void BuscaBanco_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void MtbCpfCnpj_TextChanged(object sender, EventArgs e) => Editando(true);
        private void MtbTelefone_TextChanged(object sender, EventArgs e) => Editando(true);
        private void BuscaGrupoPessoa_Text_Changed(object sender, EventArgs e)
        {
            Editando(true);
            buscaSubGrupoPessoa.Limpa();
        }
        private void RbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            //ALTERA A MASCARA DO CAMPO PARA CPF
            mtbCpfCnpj.Clear();
            mtbCpfCnpj.Mask = "###.###.###-##";
            if (!ignoraCheckEvent) { Editando(true); }
        }
        private void RbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            //ALTERA A MASCARA DO CAMPO PARA CNPJ
            mtbCpfCnpj.Clear();
            mtbCpfCnpj.Mask = "##.###.###/####-##";
            if (!ignoraCheckEvent) { Editando(true); }
        }
        private void TbCodigo_Leave(object sender, EventArgs e) => CarregaDados();
        private void TbCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && !editando)
            {
                e.Handled = true;
                Busca();
            }
        }
        private void CblAtuacao_ItemCheck(object sender, ItemCheckEventArgs e) => Editando(true);
        private void BuscaGrupoPessoa_Leave(object sender, EventArgs e)
        {
            buscaSubGrupoPessoa.EnviarGrupo(buscaGrupoPessoa.grupoPessoa);
            if (buscaGrupoPessoa.grupoPessoa == null)
            {
                buscaSubGrupoPessoa.Limpa();
                buscaSubGrupoPessoa.EscolhaOGrupo(false);
            }
            else
            {
                buscaSubGrupoPessoa.EscolhaOGrupo(true);
            }
        }

        private void Novo()
        {
            if (editando)
            {
                return;
            }

            if (Nivel > 1 || CodGrupoUsuario == "999")
            {
                ignoraCheckEvent = true;
                LimpaCampos(false);
                codigo = pessoaDAO.BuscaProxCodigoDisponivel();
                tbCodigo.Text = codigo.ToString();
                pessoa = null;
                tbNome.Focus();
                ignoraCheckEvent = false;
                Editando(true);
            }
        }
        private void Busca()
        {
            if (CodGrupoUsuario != "999" && Nivel <= 0)
            {
                return;
            }

            if (editando)
            {
                return;
            }

            var buscaPessoa = new fmBuscaPessoa();
            buscaPessoa.ShowDialog();
            if (buscaPessoa.pessoaSelecionada != null)
            {
                pessoa = buscaPessoa.pessoaSelecionada;
                codigo = pessoa.PessoaID;
                PreencheCampos(pessoa);
            }

        }
        private void Salva()
        {
            if (!editando)
            {
                return;
            }
            var ok = false;

            if (tbCodigo.Text.Length <= 0)
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                "Aviso",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                tbCodigo.Text = pessoaDAO.BuscaProxCodigoDisponivel().ToString();
                ok = false;
            }

            pessoa = new Pessoa();
            pessoa.PessoaID = int.Parse(tbCodigo.Text);
            pessoa.Nome = tbNome.Text;
            pessoa.Fantasia = tbFantasia.Text;
            pessoa.TipoPessoa = rbPessoaFisica.Checked ? "F" : "J";
            pessoa.Rua = tbRua.Text;
            pessoa.Numero = tbNumero.Text;
            pessoa.Bairro = tbBairro.Text;
            pessoa.Cep = tbCep.Text;
            pessoa.Complemento = tbComplemento.Text;
            pessoa.Cidade = buscaCidade.cidade;
            pessoa.CpfCnpj = mtbCpfCnpj.TextNoMask();
            pessoa.Telefone = mtbTelefone.TextNoMask();
            pessoa.Email = tbEmail.Text;
            pessoa.Banco = buscaBanco.banco;
            pessoa.ContaBancaria = tbContaBancaria.Text;
            pessoa.Agencia = tbAgencia.Text;
            pessoa.TipoContaBancaria = rbContaPoupanca.Checked ? "P" : "C";
            var atuacaostring = "";
            foreach (var s in cblAtuacao.CheckedItems)
            {
                switch (s)
                {
                    case "Cliente":
                        atuacaostring += "C";
                        break;
                    case "Fornecedor":
                        atuacaostring += "F";
                        break;
                    case "Vendedor(a)":
                        atuacaostring += "V";
                        break;
                }
            }
            pessoa.Atuacao = atuacaostring;

            if (rbAtivo.Checked)
                pessoa.Situacao = "A";
            else
                pessoa.Situacao = "I";

            pessoa.SubGrupoPessoa = buscaSubGrupoPessoa.subgrupoPessoa;

            var controls = (ControlCollection)this.Controls;

            ok = validacao.ValidarEntidade(pessoa, controls);
            if (!ok)
            {
                return;
            }

            validacao.despintarCampos(controls);
            int resultado = pessoaDAO.SalvaOuAtualiza(pessoa);
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
                return;
            }
            else if (resultado == 2)
            {
                tbAjuda.Text = "Dados atualizados com sucesso";
                Editando(false);
                return;
            }

        }
        private void Recarrega()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            if (pessoa != null)
            {
                pessoa = pessoaDAO.BuscaByID(pessoa.PessoaID);
                PreencheCampos(pessoa);
                if (editando)
                {
                    Editando(false);
                }
            }
            else
            {
                ignoraCheckEvent = true;
                LimpaCampos(true);
                ignoraCheckEvent = false;
                Editando(false);
            }
        }
        private void Anterior()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            validacao.despintarCampos(controls);

            var newpessoa = pessoaDAO.Anterior(int.Parse(tbCodigo.Text));
            if (newpessoa != null)
            {
                pessoa = newpessoa;
                codigo = pessoa.PessoaID;
                PreencheCampos(pessoa);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void Proximo()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            validacao.despintarCampos(controls);

            var newpessoa = pessoaDAO.Proximo(int.Parse(tbCodigo.Text));
            if (newpessoa != null)
            {
                pessoa = newpessoa;
                codigo = pessoa.PessoaID;
                PreencheCampos(pessoa);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void CarregaDados()
        {
            if (tbCodigo.Text.Length == 0)
            {
                LimpaCampos(true);
                Editando(false);
                return;
            }

            var controls = (ControlCollection)this.Controls;
            int c = 0;
            if (!int.TryParse(tbCodigo.Text, out c))
            {
                tbCodigo.Clear();
            }

            if (codigo != c)
            {
                if (editando)
                {
                    if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?", "Aviso de alteração",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
            }


            if (pessoa?.PessoaID == c)
            {
                return;
            }

            if (c == 0)
            {
                LimpaCampos(true);
                Editando(false);
                return;
            }

            if (pessoa?.PessoaID == codigo)
            {
                return;
            }

            if (codigo != c)
            {
                var newPessoa = pessoaDAO.BuscaByID(int.Parse(tbCodigo.Text));
                if (newPessoa != null)
                {
                    pessoa = newPessoa;
                    codigo = pessoa.PessoaID;
                    validacao.despintarCampos(controls);
                    PreencheCampos(pessoa);
                    Editando(false);
                }
                else
                {
                    validacao.despintarCampos(controls);
                    Editando(true);
                    LimpaCampos(false);
                }
            }

        }
        private void Editando(bool edit)
        {
            if (!ignoraCheckEvent)
            {
                editando = edit;
                menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
            }
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void LimpaCampos(bool limpaCodigo, bool limpapessoa = true)
        {
            if (limpaCodigo) { tbCodigo.Clear(); codigo = 0; }
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
            rbAtivo.Checked = true;
            rbInativo.Checked = false;
            tbAjuda.Clear();
            buscaGrupoPessoa.Limpa();
            buscaSubGrupoPessoa.Limpa();
            buscaBanco.Limpa();
            tbContaBancaria.Clear();
            tbAgencia.Clear();
            rbContaCorrente.Checked = true;
            rbContaPoupanca.Checked = false;

            if (limpapessoa) { pessoa = null; }
        }
        private void PreencheCampos(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                return;
            }

            ignoraCheckEvent = true;
            LimpaCampos(false, false);
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
            tbCep.Text = pessoa.Cep;
            tbComplemento.Text = pessoa.Complemento;
            mtbCpfCnpj.Text = pessoa.CpfCnpj;
            mtbTelefone.Text = pessoa.Telefone;
            tbEmail.Text = pessoa.Email;

            buscaCidade.PreencheCampos(pessoa.Cidade);

            if (pessoa.Atuacao.Contains("C"))
            {
                cblAtuacao.SetItemChecked(0, true);
            }
            if (pessoa.Atuacao.Contains("F"))
            {
                cblAtuacao.SetItemChecked(1, true);
            }
            if (pessoa.Atuacao.Contains("V"))
            {
                cblAtuacao.SetItemChecked(2, true);
            }
            switch (pessoa.Situacao)
            {
                case "A":
                    rbAtivo.Checked = true;
                    rbInativo.Checked = false;
                    break;
                case "I":
                    rbAtivo.Checked = false;
                    rbInativo.Checked = true;
                    break;
            }
            tbContaBancaria.Text = pessoa.ContaBancaria;
            tbAgencia.Text = pessoa.Agencia;
            rbContaCorrente.Checked = (pessoa.TipoContaBancaria == "C" || pessoa.TipoContaBancaria == "");
            rbContaPoupanca.Checked = pessoa.TipoContaBancaria == "P";
            buscaGrupoPessoa.PreencheCampos(pessoa.SubGrupoPessoa.GrupoPessoa);
            buscaSubGrupoPessoa.PreencheCampos(pessoa.SubGrupoPessoa);
            buscaBanco.PreencheCampos(pessoa.Banco);

            ignoraCheckEvent = false;

        }
    }
}