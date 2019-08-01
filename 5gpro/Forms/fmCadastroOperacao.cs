using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.StaticFiles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroOperacao : Form
    {
        //TODO: Possibilitar usuário poder alterar a quantidade de parcelas.
        //TODO: Verificar botão "Aplicar" na tela fmBuscaParcelasOperacao para não apresentar erro se caso não tiver nada preenchido....




        //CÓDIGO DA TELA CAD.OPERAÇÃO = 040100

        private ParcelaOperacao parcela = new ParcelaOperacao();
        private List<ParcelaOperacao> listaparcelasprincipal = new List<ParcelaOperacao>();

        private Operacao operacao;
        private readonly OperacaoDAO operacaoDAO = new OperacaoDAO();
        private readonly Validacao validacao = new Validacao();
        public int variaveldias = 30;

        private int Nivel;
        private string CodGrupoUsuario;

        bool editando, ignoraCheckEvent = false;

        public fmCadastroOperacao()
        {
            InitializeComponent();
            SetarNivel();
            LimpaCampos(true);
        }

        private void FmCadastroOperacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && Nivel > 1)
            {
                Novo();
                return;
            }

            if (e.KeyCode == Keys.F2 && Nivel > 1)
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

        private void FmCadastroOperacao_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SetarNivel()
        {
            CodGrupoUsuario = Logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            Nivel = Logado.Usuario.Grupousuario.Permissoes.Find(p => p.Codigo == "040100").Nivel;
            Editando(editando);
        }


        //EVENTOS DE TEXTCHANGED
        private void TbNomeOperacao_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void TbDescOperacao_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void TbDesconto_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void TbEntrada_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void TbAcrescimo_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void TbNparcelas_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        public void Dias_Changed()
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void DbAcrescimo_Valor_Changed(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void DbDesconto_Valor_Changed(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        //EVENTOS DE LEAVE
        private void TbCodOperacao_Leave(object sender, EventArgs e)
        {
            ControlCollection controls = (ControlCollection)this.Controls;

            if (!int.TryParse(tbCodOperacao.Text, out int codigo)) { tbCodOperacao.Clear(); }
            if (!editando)
            {
                validacao.despintarCampos(controls);
                if (tbCodOperacao.Text.Length > 0)
                {
                    Operacao newoperacao = operacaoDAO.BuscaByID(int.Parse(tbCodOperacao.Text));

                    if (newoperacao != null)
                    {
                        operacao = newoperacao;
                        PreencheCampos(operacao);
                        Editando(false);
                    }
                    else
                    {
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodOperacao.Text.Length == 0)
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
                    validacao.despintarCampos(controls);
                    if (tbCodOperacao.Text.Length > 0)
                    {
                        Operacao newoperacao = operacaoDAO.BuscaByID(int.Parse(tbCodOperacao.Text));
                        if (newoperacao != null)
                        {
                            operacao = newoperacao;
                            PreencheCampos(operacao);
                            Editando(false);
                        }
                        else
                        {
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodOperacao.Text.Length == 0)
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
        }

        //MENU PRINCIPAL
        private void MenuVertical1_Novo_Clicked(object sender, EventArgs e) => Novo();

        private void MenuVertical1_Buscar_Clicked(object sender, EventArgs e) => AbreTelaBuscaOperacao();

        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();

        private void MenuVertical1_Salvar_Clicked(object sender, EventArgs e) => Salva();

        private void MenuVertical1_Proximo_Clicked(object sender, EventArgs e) => ProximoCadastro();

        private void MenuVertical1_Anterior_Clicked(object sender, EventArgs e) => CadastroAnterior();


        //RADIONBUTTONS
        private void RbAvista_CheckedChanged(object sender, EventArgs e)
        {

            listaparcelasprincipal.Clear();
            MostrarEsconder(false);
            tbNparcelas.Enabled = true;

            HDavista(true);
            HDaprazo(false);
            tcOpcoes.SelectedTab = tpAvista;
            if (!ignoraCheckEvent) { Editando(true); }


        }

        private void RbAprazo_CheckedChanged(object sender, EventArgs e)
        {
            listaparcelasprincipal.Clear();
            MostrarEsconder(false);
            tbNparcelas.Enabled = true;

            HDavista(false);
            HDaprazo(true);
            tcOpcoes.SelectedTab = tpAprazo;
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void RbSim_CheckedChanged(object sender, EventArgs e)
        {
            dbEntrada.Enabled = true;
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void RbNao_CheckedChanged(object sender, EventArgs e)
        {
            dbEntrada.Enabled = false;
            dbEntrada.Valor = 0;
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            var fmdiasavencer = new fmBuscaParcelasOperacao(listaparcelasprincipal, this);
            fmdiasavencer.ShowDialog();
        }


        //EVENTOS DE CLICK
        private void BtRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remover parcelas?",
               "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listaparcelasprincipal.Clear();
                MostrarEsconder(false);
                tbNparcelas.Enabled = true;
            }
        }
        private void BtGerar_Click(object sender, EventArgs e)
        {
            Gerar();
        }


        //PADRÕES CRIADAS
        private void Salva()
        {
            bool ok = false;
            if (tbCodOperacao.Text.Length > 0)
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

                        operacao.Parcelas = listaparcelasprincipal;

                        if (rbSim.Checked)
                            operacao.Entrada = dbEntrada.Valor;

                        operacao.Acrescimo = dbAcrescimo.Valor;
                        operacao.Multa = dbMulta.Valor;
                        operacao.Juros = dbJuros.Valor;
                        operacao.Desconto = 0;

                    }
                    else
                    {
                        if (rbAvista.Checked)
                        {
                            operacao.Condicao = "AV";
                            operacao.Entrada = 0;
                            operacao.Acrescimo = 0;
                            listaparcelasprincipal = new List<ParcelaOperacao>();

                            operacao.Desconto = dbDesconto.Valor;
                        }
                    }
                }

                ControlCollection controls = (ControlCollection)this.Controls;
                ok = validacao.ValidarEntidade(operacao, controls);
                if (ok) { validacao.despintarCampos(controls); }

                if (operacao.Condicao != null)
                {
                    if (tbVisualizar.Text.Length <= 0 && operacao.Condicao.Equals("AP"))
                    {
                        ok = false;
                        MessageBox.Show("Deve Gerar as parcelas",
                                        "",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                                    "Aviso",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbCodOperacao.Text = operacaoDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
            }

            if (ok)
            {
                int resultado = operacaoDAO.SalvaOuAtualiza(operacao);
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

        private void Novo()
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
            dbEntrada.Valor = 0m;
            dbDesconto.Valor = 0m;
            dbMulta.Valor = 0m;
            dbJuros.Valor = 0m;
            tbNparcelas.Clear();
            dbAcrescimo.Valor = 0;
            rbNao.Checked = true;
            rbSim.Checked = false;
            rbAprazo.Checked = false;
            rbAvista.Checked = false;
            HDavista(false);
            HDaprazo(false);

            listaparcelasprincipal.Clear();
            MostrarEsconder(false);
            tbNparcelas.Enabled = true;
        }

        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
        }

        private void AbreTelaBuscaOperacao()
        {
            var buscaOperacao = new fmBuscaOperacao();
            buscaOperacao.ShowDialog();
            if (buscaOperacao.operacaoSelecionada != null)
            {
                operacao = operacaoDAO.BuscaByID(buscaOperacao.operacaoSelecionada.OperacaoID);
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
                    dbDesconto.Valor = operacao.Desconto;
                    tbNparcelas.Clear();
                    dbEntrada.Valor = 0;
                    dbAcrescimo.Valor = 0;
                    break;

                case "AP":
                    rbAvista.Checked = false;
                    rbAprazo.Checked = true;

                    if (operacao.Entrada > 0)
                    {
                        rbSim.Checked = true;
                        rbNao.Checked = false;
                        dbEntrada.Valor = operacao.Entrada;
                    }
                    else
                    {
                        rbSim.Checked = false;
                        rbNao.Checked = true;
                        dbEntrada.Valor = 0;
                    }
                    dbDesconto.Valor = 0;
                    dbMulta.Valor = operacao.Multa;
                    dbJuros.Valor = operacao.Juros;

                    listaparcelasprincipal = operacao.Parcelas;
                    tbNparcelas.Clear();
                    Gerar();

                    dbAcrescimo.Valor = operacao.Acrescimo;
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

                Operacao newoperacao = operacaoDAO.Proxima(tbCodOperacao.Text);
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
                    Operacao newoperacao = operacaoDAO.Proxima(tbCodOperacao.Text);
                    if (newoperacao != null)
                    {
                        operacao = newoperacao;
                        PreencheCampos(operacao);
                        Editando(false);
                    }
                    else
                    {
                        newoperacao = operacaoDAO.Anterior(tbCodOperacao.Text);
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

        private void Recarrega()
        {
            ControlCollection controls = (ControlCollection)this.Controls;

            if (tbCodOperacao.Text.Length <= 0)
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

            validacao.despintarCampos(controls);

            if (operacao != null)
            {
                operacao = operacaoDAO.BuscaByID(operacao.OperacaoID);
                PreencheCampos(operacao);
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

        private void CadastroAnterior()
        {

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodOperacao.Text.Length > 0)
            {

                validacao.despintarCampos(controls);
                Operacao newoperacao = operacaoDAO.Anterior(tbCodOperacao.Text);
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
                    Operacao newoperacao = operacaoDAO.Anterior(tbCodOperacao.Text);
                    if (newoperacao != null)
                    {
                        operacao = newoperacao;
                        PreencheCampos(operacao);
                        Editando(false);
                    }
                    else
                    {
                        newoperacao = operacaoDAO.Proxima(tbCodOperacao.Text);
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

        private void Gerar()
        {

            if (!int.TryParse(tbNparcelas.Text, out int codigo)) { tbNparcelas.Clear(); }

            if (tbNparcelas.Text.Length > 0)
            {

                int numero = int.Parse(tbNparcelas.Text);
                listaparcelasprincipal = new List<ParcelaOperacao>();

                for (int a = 1; a <= numero; a++)
                {
                    parcela = new ParcelaOperacao();
                    parcela.Numero = a;
                    parcela.Dias = variaveldias * a;
                    listaparcelasprincipal.Add(parcela);
                }
                if (listaparcelasprincipal.Count > 0)
                {
                    tbVisualizar.Text = listaparcelasprincipal.Count + " Parcela(s)";
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
                if (listaparcelasprincipal.Count > 0)
                {
                    tbVisualizar.Text = listaparcelasprincipal.Count + " Parcela(s)";
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

        private void HDavista(bool a)
        {
            if (a)
                pnAvista.Enabled = true;
            else
                pnAvista.Enabled = false;
        }

        private void DbEntrada_Valor_Changed(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void HDaprazo(bool a)
        {
            if (a)
                pnAprazo.Enabled = true;
            else
                pnAprazo.Enabled = false;
        }



        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
