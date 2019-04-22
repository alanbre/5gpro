using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroOperacao : Form
    {
        //CÓDIGO DA TELA CAD.OPERAÇÃO = 040100
        static ConexaoDAO connection = new ConexaoDAO();

        ParcelaOperacao parcela = new ParcelaOperacao();
        List<ParcelaOperacao> listaparcelas = new List<ParcelaOperacao>();

        Operacao operacao;
        OperacaoDAO operacaoDAO = new OperacaoDAO(connection);
        Validacao validacao = new Validacao();
        public int variaveldias = 30;

        bool editando, ignoraCheckEvent = false;

        public fmCadastroOperacao()
        {
            InitializeComponent();
            RemoverTabs();
        }

        //RADIONBUTTONS

        private void RemoverTabs()
        {
            tcOpcoes.TabPages.Remove(tpAvista);
            tcOpcoes.TabPages.Remove(tpAprazo);
        }

        private void RbAvista_CheckedChanged(object sender, EventArgs e)
        {
            tcOpcoes.TabPages.Remove(tpAvista);
            tcOpcoes.TabPages.Remove(tpAprazo);
            tcOpcoes.TabPages.Add(tpAvista);
        }

        private void RbAprazo_CheckedChanged(object sender, EventArgs e)
        {
            tcOpcoes.TabPages.Remove(tpAvista);
            tcOpcoes.TabPages.Remove(tpAprazo);
            tcOpcoes.TabPages.Add(tpAprazo);
        }


        private void RbSim_CheckedChanged(object sender, EventArgs e)
        {
            tbEntrada.Enabled = true;
        }

        private void RbNao_CheckedChanged(object sender, EventArgs e)
        {
            tbEntrada.Enabled = false;
            tbEntrada.Text = "";
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            var fmdiasavencer = new fmBuscaParcelasOperacao(listaparcelas);
            fmdiasavencer.Show(this);

        }


        //MENU
        private void MenuVertical1_Load(object sender, EventArgs e)
        {
        }

        private void MenuVertical1_Novo_Clicked(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void MenuVertical1_Buscar_Clicked(object sender, EventArgs e)
        {
            if (!editando)
            {
                AbreTelaBuscaOperacao();
            }
        }

        private void MenuVertical1_Salvar_Clicked(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void MenuVertical1_Proximo_Clicked(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void MenuVertical1_Anterior_Clicked(object sender, EventArgs e)
        {
            CadastroAnterior();
        }


        //PADRÕES CRIADAS

        private void SalvaCadastro()
        {

            if (editando)
            {
                operacao = new Operacao();
                operacao.OperacaoID = int.Parse(tbCodOperacao.Text);
                operacao.Nome = tbNomeOperacao.Text;
                operacao.Descricao = tbDescOperacao.Text;

                if (rbAprazo.Checked)
                {
                    operacao.Condicao = "AP";

                    if (rbSim.Checked && tbEntrada.Text.Length > 0)
                    {
                        operacao.Entrada = decimal.Parse(tbEntrada.Text);
                    }
                    else
                    {
                        operacao.Entrada = 0;
                    }

                    if (tbAcrescimo.Text.Length > 0)
                    {
                        operacao.Acrescimo = decimal.Parse(tbAcrescimo.Text);
                    }
                    else
                    {
                        operacao.Acrescimo = 0;
                    }

                    operacao.Desconto = 0;

                }
                else
                {
                    operacao.Condicao = "AV";
                    operacao.Entrada = 0;
                    operacao.Acrescimo = 0;
                    listaparcelas = new List<ParcelaOperacao>();
                    if (tbDesconto.Text.Length > 0)
                    {
                        operacao.Desconto = decimal.Parse(tbDesconto.Text);
                    }
                    else
                    {
                        operacao.Desconto = 0;
                    }
                }

                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(operacao, controls);

                if (ok)
                {

                    int resultado = operacaoDAO.SalvarOuAtualizarOperacao(operacao, listaparcelas);

                    validacao.despintarCampos(controls);
                    //resultado 0 = nada foi inserido(houve algum erro)
                    //resultado 1 = foi inserido com sucesso
                    //resultado 2 = foi atualizado com sucesso
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
                    tbCodOperacao.Text = operacaoDAO.BuscaProxCodigoDisponivel().ToString();
                    operacao = null;
                    tbNomeOperacao.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodOperacao.Text = operacaoDAO.BuscaProxCodigoDisponivel().ToString();
                operacao = null;
                tbNomeOperacao.Focus();
                Editando(true);
            }
        }

        private void LimpaCampos(bool cod)
        {
            if (cod) { tbCodOperacao.Clear(); }
            tbNomeOperacao.Clear();
            tbAjuda.Clear();
            tbDescOperacao.Clear();
            tbEntrada.Clear();
            tbDesconto.Clear();
            tbNparcelas.Clear();
            tbAcrescimo.Clear();
            rbNao.Checked = true;
            rbSim.Checked = false;
            rbAprazo.Checked = false;
            rbAvista.Checked = false;
            RemoverTabs();
        }

        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit, 3, "999");

            //menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
        }

        private void AbreTelaBuscaOperacao()
        {
            var buscaOperacao = new fmBuscaOperacao();
            buscaOperacao.ShowDialog();
            if (buscaOperacao.operacaoSelecionada != null)
            {
                operacao = buscaOperacao.operacaoSelecionada;
                PreencheCampos(operacao);
            }
        }

        private void PreencheCampos(Operacao operacao)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodOperacao.Text = operacao.OperacaoID.ToString();
            tbNomeOperacao.Text = operacao.Nome;
            tbDescOperacao.Text = operacao.Descricao;
            switch (operacao.Condicao)
            {
                case "AV":
                    rbAvista.Checked = true;
                    rbAprazo.Checked = false;
                    rbSim.Checked = false;
                    rbNao.Checked = true;
                    tbDesconto.Text = operacao.Desconto.ToString();
                    tbNparcelas.Clear();
                    tbEntrada.Clear();
                    tbAcrescimo.Clear();
                    break;

                case "AP":
                    rbAvista.Checked = false;
                    rbAprazo.Checked = true;

                    if (operacao.Entrada.ToString().Length > 0)
                    {
                        rbSim.Checked = true;
                        rbNao.Checked = false;
                        tbEntrada.Text = operacao.Entrada.ToString();
                    }
                    else
                    {
                        rbSim.Checked = false;
                        rbNao.Checked = true;
                        tbEntrada.Clear();
                    }
                    tbDesconto.Clear();

                    listaparcelas = operacao.Parcelas;
                    tbNparcelas.Clear();
                    Gerar();

                    tbAcrescimo.Text = operacao.Acrescimo.ToString();
                    break;
            }

            ignoraCheckEvent = false;
        }

        private void ProximoCadastro()
        {

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodOperacao.Text.Length > 0)
            {

                validacao.despintarCampos(controls);

                Operacao newoperacao = operacaoDAO.BuscarProximaOperacao(tbCodOperacao.Text);
                if (newoperacao != null)
                {
                    operacao = newoperacao;
                    PreencheCampos(operacao);
                }
            }
            else if (editando && tbCodOperacao.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    Operacao newoperacao = operacaoDAO.BuscarProximaOperacao(tbCodOperacao.Text);
                    if (newoperacao != null)
                    {
                        operacao = newoperacao;
                        PreencheCampos(operacao);
                        Editando(false);
                    }
                    else
                    {
                        newoperacao = operacaoDAO.BuscarOperacaoAnterior(tbCodOperacao.Text);
                        if (newoperacao != null)
                        {
                            operacao = newoperacao;
                            PreencheCampos(operacao);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void CadastroAnterior()
        {

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodOperacao.Text.Length > 0)
            {
                //Os registros com newpessoa é só para garantir que não vai dar confusão com a variável "global"
                //la do inicio do arquivo.

                validacao.despintarCampos(controls);
                Operacao newoperacao = operacaoDAO.BuscarOperacaoAnterior(tbCodOperacao.Text);
                if (newoperacao != null)
                {
                    operacao = newoperacao;
                    PreencheCampos(operacao);
                }
            }
            else if (editando && tbCodOperacao.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    Operacao newoperacao = operacaoDAO.BuscarOperacaoAnterior(tbCodOperacao.Text);
                    if (newoperacao != null)
                    {
                        operacao = newoperacao;
                        PreencheCampos(operacao);
                        Editando(false);
                    }
                    else
                    {
                        newoperacao = operacaoDAO.BuscarProximaOperacao(tbCodOperacao.Text);
                        if (newoperacao != null)
                        {
                            operacao = newoperacao;
                            PreencheCampos(operacao);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void TbNparcelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNparcelas_Leave(object sender, EventArgs e)
        {

        }

        private void BtGerar_Click(object sender, EventArgs e)
        {
            Gerar();
        }

        private void Gerar()
        {

            if (tbNparcelas.Text.Length > 0)
            {
                int numero = int.Parse(tbNparcelas.Text);
                listaparcelas = new List<ParcelaOperacao>();

                for (int a = 1; a <= numero; a++)
                {
                    parcela = new ParcelaOperacao();
                    parcela.Numero = a;
                    parcela.Dias = variaveldias * a;
                    listaparcelas.Add(parcela);
                }
                if (listaparcelas.Count > 0)
                {
                    tbVisualizar.Text = listaparcelas.Count + " Parcela(s)";
                    MostrarEsconder(true);
                    tbNparcelas.Clear();
                    tbNparcelas.Enabled = false;
                }
                else
                {
                    MostrarEsconder(false);
                }
            }
            else
            {
                if (listaparcelas.Count > 0)
                {
                    tbVisualizar.Text = listaparcelas.Count + " Parcela(s)";
                    MostrarEsconder(true);
                    tbNparcelas.Clear();
                    tbNparcelas.Enabled = false;
                }
                else
                {
                    MostrarEsconder(false);
                }
            }
        }

        private void MostrarEsconder(bool a)
        {
            if (a)
            {
                gbVisualizar.Visible = true;
                tbVisualizar.Visible = true;
                btEditar.Visible = true;
                btRemover.Visible = true;
            }
            else
            {
                gbVisualizar.Visible = false;
                tbVisualizar.Clear();
                tbVisualizar.Visible = false;
                btEditar.Visible = false;
                btRemover.Visible = false;
            }
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remover parcelas?",
               "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listaparcelas = new List<ParcelaOperacao>();
                MostrarEsconder(false);
                tbNparcelas.Enabled = true;
            }
        }

        private void MenuVertical_Load(object sender, EventArgs e)
        {

        }

        private void FmCadastroOperacao_Load(object sender, EventArgs e)
        {

        }
    }
}
