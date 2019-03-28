using _5gpro.Bll;
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
        Cidade cidade;
        PessoaBLL pessoaBLL = new PessoaBLL();
        CidadeBLL cidadeBLL = new CidadeBLL();
        Validacao validacao = new Validacao();

        FuncoesAuxiliares f = new FuncoesAuxiliares();

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroPessoa()
        {
            InitializeComponent();
            AlteraBotoes();  //ALTERA BOTÕES PARA CERTIFICAR QUE VÃO ESTAR CORRETOS AO ABRIR A TELA
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



        //EVENTOS DE CLICK
        private void btNovo_Click(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                AbreTelaBuscaPessoa();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void btBuscaCidade_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaCidade();
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            //Se não houver uma pessoa setada (por qualquer motivo) ele limpa os campos. Se tiver pessoa recarrega com as informações do banco.
            //Desta forma é necessário ter carregado um registro pra poder recarregar.
            RecarregaDados(pessoa);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            CadastroAnterior();
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
            tbCodigo.Text = tbCodigo.Text == "0" ? "" : tbCodigo.Text;
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    Pessoa newpessoa = pessoaBLL.BuscarPessoaById(tbCodigo.Text);
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
                        Pessoa newpessoa = pessoaBLL.BuscarPessoaById(tbCodigo.Text);
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

        private void tbCodCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaCidade();
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
                    tbNome.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigo.Text = pessoaBLL.BuscaProxCodigoDisponivel();
                pessoa = null;
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
                pessoa.Cidade = new CidadeDAO().BuscaCidadeByCod(tbCodCidade.Text);
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
                        pessoa = pessoaBLL.BuscarPessoaById(pessoa.Codigo);
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
                pessoa = pessoaBLL.BuscarPessoaById(pessoa.Codigo);
                PreencheCampos(pessoa);
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
            tbAjuda.Clear();
        }

        private void PreencheCampos(Pessoa pessoa)
        {
            ignoraCheckEvent = true;
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
            tbCodCidade.Text = pessoa.Cidade.CodCidade;
            mtbCpfCnpj.Text = pessoa.CpfCnpj;
            mtbTelefone.Text = pessoa.Telefone;
            tbEmail.Text = pessoa.Email;

            if (pessoa.Cidade != null)
            {
                cidade = cidadeBLL.BuscaCidadeByCod(pessoa.Cidade.CodCidade);
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
            ignoraCheckEvent = false;
        }

        private void PreencheCamposCidade(Cidade cidade)
        {
            if (cidade != null)
            {
                tbCodCidade.Text = cidade.CodCidade;
                tbNomeCidade.Text = cidade.Nome;
            }
            else
            {
                MessageBox.Show("Cidade não encontrada no banco de dados",
                "Cidade não encontrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodCidade.Focus();
                tbCodCidade.SelectAll();
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
                Editando(true);
            }
        }



    }
}