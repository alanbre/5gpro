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
        //TODO: Implementar recarregamento da operação
        //TODO: Possibilitar usuário poder alterar a quantidade de parcelas.
        //TODO: Verificar botão "Aplicar" na tela fmBuscaParcelasOperacao para não apresentar erro se caso não tiver nada preenchido....




        //CÓDIGO DA TELA CAD.OPERAÇÃO = 040100

        ParcelaOperacao parcela = new ParcelaOperacao();
        public List<ParcelaOperacao> listaparcelasprincipal = new List<ParcelaOperacao>();

        Operacao operacao;
        OperacaoDAO operacaoDAO = new OperacaoDAO();
        Validacao validacao = new Validacao();
        public int variaveldias = 30;

        //Controle de permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;
        PermissaoDAO permissaoDAO = new PermissaoDAO();

        bool editando, ignoraCheckEvent = false;

        public fmCadastroOperacao()
        {
            InitializeComponent();
            SetarNivel();
            LimpaCampos(true);
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("040100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
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


        //EVENTOS DE LEAVE
        private void TbCodOperacao_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodOperacao.Text, out int codigo)) { tbCodOperacao.Clear(); }
            if (!editando)
            {
                if (tbCodOperacao.Text.Length > 0)
                {
                    Operacao newoperacao = operacaoDAO.BuscaById(int.Parse(tbCodOperacao.Text));

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
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbCodOperacao.Text.Length > 0)
                    {
                        Operacao newoperacao = operacaoDAO.BuscaById(int.Parse(tbCodOperacao.Text));
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
            tbEntrada.Enabled = true;
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void RbNao_CheckedChanged(object sender, EventArgs e)
        {
            tbEntrada.Enabled = false;
            tbEntrada.Text = "";
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
                //listaparcelasprincipal = new List<ParcelaOperacao>();
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
        private void SalvaCadastro()
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

                        if (!int.TryParse(tbEntrada.Text, out int codigo)) { tbEntrada.Clear(); }
                        if (rbSim.Checked && tbEntrada.Text.Length > 0)
                            operacao.Entrada = decimal.Parse(tbEntrada.Text);
                        else
                            operacao.Entrada = 0;

                        if (!int.TryParse(tbAcrescimo.Text, out int cod)) { tbAcrescimo.Clear(); }
                        if (tbAcrescimo.Text.Length > 0)
                            operacao.Acrescimo = decimal.Parse(tbAcrescimo.Text);
                        else
                            operacao.Acrescimo = 0;

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

                            if (!int.TryParse(tbDesconto.Text, out int codigo)) { tbDesconto.Clear(); }
                            if (tbDesconto.Text.Length > 0)
                            {
                                operacao.Desconto = decimal.Parse(tbDesconto.Text);
                            }
                            else
                            {
                                operacao.Desconto = 0;
                            }
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
                if (operacaoDAO.OperacaoExist(operacao.OperacaoID))
                    operacaoDAO.RemoverParcelasOperacao(tbCodOperacao.Text);

                int resultado = operacaoDAO.SalvarOuAtualizarOperacao(operacao);
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

                    listaparcelasprincipal = operacao.Parcelas;
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

        private void HDaprazo(bool a)
        {
            if (a)
                pnAprazo.Enabled = true;
            else
                pnAprazo.Enabled = false;
        }

    }
}
