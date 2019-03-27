using _5gpro.Bll;
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

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroPessoa()
        {
            InitializeComponent();
            AlteraBotoes();  //ALTERA BOTÕES PARA CERTIFICAR QUE VÃO ESTAR CORRETOS AO ABRIR A TELA
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
            if (!editando)
            {
                AbreTelaBuscaPessoa();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Cria uma nova instancia de pessoa, seta as informações e tenta salvar.
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
            pessoa.Cidade = tbCodCidade.Text;
            pessoa.CpfCnpj = mtbCpfCnpj.TextNoMask();
            pessoa.Telefone = mtbTelefone.TextNoMask();
            pessoa.Email = tbEmail.Text;

            ControlCollection controls = (ControlCollection)this.Controls;
            bool ok = validacao.ValidarEntidade(pessoa, controls);

            if (ok)
            {
                int resultado = pessoaBLL.SalvarOuAtualizarPessoa(pessoa);

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

        private void btBuscaCidade_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaCidade();
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            //Se não houver uma pessoa setada (por qualquer motivo) ele limpa os campos. Se tiver pessoa recarrega com as informações do banco.
            //Desta forma é necessário ter carregado um registro pra poder recarregar.
            if (pessoa != null) { RecarregarDados(pessoa); } else { LimpaCampos(true); }
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            //Busca a pessoa com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se pessoa existe. Se não existir busca o maior anterior ao digitado
            if (!editando && tbCodigo.Text.Length > 0)
            {
                //Os registros com newpessoa é só para garantir que não vai dar confusão com a variável "global"
                //la do inicio do arquivo.
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

        private void btLeft_Click(object sender, EventArgs e)
        {
            //Busca a pessoa com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            //Caso não houver registro com ID menor, verifica se pessoa existe. Se não existir busca o proximo ao digitado
            if (!editando && tbCodigo.Text.Length > 0)
            {
                //Os registros com newpessoa é só para garantir que não vai dar confusão com a variável "global"
                //la do inicio do arquivo.
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

        private void tbNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void tbFantasia_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void tbRua_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void tbNumero_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
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

            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }

        }

        private void mtbCpfCnpj_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void mtbTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }
        }

        private void tbEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Editando(true);
            }
        }




        //EVENTOS DE KEY DOWN
        private void tbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbFantasia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void rbPessoaFisica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void rbPessoaJuridica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbRua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbCodCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void mtbCpfCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void mtbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }



        private void cblAtuacao_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }


        //PADRÕES CRIADAS
        private void RecarregarDados(Pessoa pessoa)
        {

            pessoa = pessoaBLL.BuscarPessoaById(pessoa.Codigo);
            PreencheCampos(pessoa);
            Editando(false);
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
            ignoraCheckEvent = false;
        }

        private void PreencheCamposCidade(Cidade cidade)
        {
            if (cidade != null)
            {
                tbCodCidade.Text = cidade.CodCidade;
                tbNomeCidade.Text = cidade.Nome;
                Editando(true);
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

        private void Editando(bool edit)
        {
            editando = edit;
            AlteraBotoes();
        }


    }
}