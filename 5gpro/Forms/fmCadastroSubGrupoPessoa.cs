using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroSubGrupoPessoa : Form
    {

        static ConexaoDAO connection = new ConexaoDAO();
        GrupoPessoa grupopessoareferencia = null;
        fmCadastroGrupoPessoa telacadgrupopessoa = null;
        GrupoPessoaDAO grupopessoaDAO = new GrupoPessoaDAO(connection);
        Validacao validacao = new Validacao();
        SubGrupoPessoa subgrupopessoa = null;
        SubGrupoPessoaDAO subgrupopessoaDAO = new SubGrupoPessoaDAO(connection);

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroSubGrupoPessoa(GrupoPessoa grupopessoarecebido, fmCadastroGrupoPessoa cadgrupopessoa)
        {
            InitializeComponent();
            tbNomeSub.Focus();

            SetarDados(grupopessoarecebido, cadgrupopessoa);
            if (cadgrupopessoa.subgrupopessoaSelecionado != null)
            {
                subgrupopessoa = cadgrupopessoa.subgrupopessoaSelecionado;
                PreencheCampos(subgrupopessoa);
            }
            else
            {
                tbCodigo.Text = subgrupopessoaDAO.BuscaProxCodigoDisponivel();
            }
        }

        private void SetarDados(GrupoPessoa grupopessoa, fmCadastroGrupoPessoa tcg)
        {
            grupopessoareferencia = grupopessoa;
            telacadgrupopessoa = tcg;

        }


        //EVENTOS DE CLICK
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                if (MessageBox.Show("Deseja fechar?",
                                    "Aviso de alteração",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }


        //EVENTOS DE LEAVE
        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    SubGrupoPessoa newsubgrupopessoa = subgrupopessoaDAO.BuscarByID(int.Parse(tbCodigo.Text), grupopessoareferencia.GrupoPessoaID);
                    if (newsubgrupopessoa != null)
                    {
                        subgrupopessoa = newsubgrupopessoa;
                        PreencheCampos(subgrupopessoa);
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
                        SubGrupoPessoa newsubgrupopessoa = subgrupopessoaDAO.BuscarByID(int.Parse(tbCodigo.Text), grupopessoareferencia.GrupoPessoaID);
                        if (newsubgrupopessoa != null)
                        {
                            subgrupopessoa = newsubgrupopessoa;
                            PreencheCampos(subgrupopessoa);
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

        //EVENTOS DE TEXTCHANGED
        private void TbNomeSub_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        //PADRÕES CRIADAS
        private void SalvaCadastro()
        {
            if (editando)
            {
                subgrupopessoa = new SubGrupoPessoa();

                subgrupopessoa.SubGrupoPessoaID = int.Parse(tbCodigo.Text);
                subgrupopessoa.Nome = tbNomeSub.Text;
                subgrupopessoa.GrupoPessoa = grupopessoareferencia;

                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(subgrupopessoa, controls);

                if (ok)
                {
                    int resultado = subgrupopessoaDAO.SalvarOuAtualizar(subgrupopessoa);
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
                        MessageBox.Show("Salvo", "Aviso de alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        telacadgrupopessoa.AtualizarDgvSub();
                        Editando(false);
                    }
                    else if (resultado == 2)
                    {
                        MessageBox.Show("Atualizado", "Aviso de alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        telacadgrupopessoa.AtualizarDgvSub();
                        Editando(false);
                    }
                }
            }
        }

        private void Editando(bool edit)
        {
            editando = edit;
            AlterarBotoes(editando);
        }

        private void AlterarBotoes(bool editando)
        {
            if (editando)
                btSalvar.Enabled = true;
            else
                btSalvar.Enabled = false;
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
            tbNomeSub.Clear();
        }

        private void PreencheCampos(SubGrupoPessoa subgrupopessoa)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);

            tbCodigo.Text = subgrupopessoa.SubGrupoPessoaID.ToString();
            tbNomeSub.Text = subgrupopessoa.Nome;

            ignoraCheckEvent = false;
        }

        private void FmCadastroSubGrupoPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            telacadgrupopessoa.AtualizarDgvSub();
            telacadgrupopessoa.subgrupopessoaSelecionado = null;
        }

        private void FmCadastroSubGrupoPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }
    }
}
