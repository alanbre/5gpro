using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCarCadastroConta : Form
    {
        private ParcelaContaReceber parcelaSelecionada = null;
        private bool editando, ignoracheckevent = false;
        private ContaReceber contaReceber = null;
        private List<ParcelaContaReceber> parcelas = new List<ParcelaContaReceber>();

        private readonly FuncoesAuxiliares f = new FuncoesAuxiliares();
        private readonly static ConexaoDAO connection = new ConexaoDAO();
        private readonly ContaReceberDAO contaReceberDAO = new ContaReceberDAO(connection);
        private readonly OperacaoDAO operacaoDAO = new OperacaoDAO(connection);
        private readonly PessoaDAO pessoaDAO = new PessoaDAO(connection);

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO(connection);
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO(connection);
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        public fmCarCadastroConta()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void FmCarCadastroConta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Recarrega();
            }

            if (e.KeyCode == Keys.F1)
            {
                Novo();
            }

            if (e.KeyCode == Keys.F2)
            {
                Salva();
            }

            EnterTab(this.ActiveControl, e);
        }


        //MENU
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void BtGerarParcelas_Click(object sender, EventArgs e) => GerarParcelas();
        private void BtSalvarParcela_Click(object sender, EventArgs e) => SalvaParcela();
        private void DtpDataCadatroConta_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void BuscaOperacao_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void TbValorOriginalParcela_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void TbMultaParcela_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void TbJurosParcela_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void TbValorFinalParcela_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void TbValorOriginalConta_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void TbMultaConta_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void TbJurosConta_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void TbValorFinalConta_KeyPress(object sender, KeyPressEventArgs e) => f.ValidaTeclaDigitadaDecimal(e);
        private void TbCodigoConta_Leave(object sender, EventArgs e) => CarregaDados();
        private void TbMultaParcela_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalParcela();
        }
        private void TbJurosParcela_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalParcela();
        }
        private void TbValorOriginalParcela_Leave(object sender, EventArgs e)
        {
            FormataCampoDecimal((TextBox)sender);
            CalculaTotalParcela();
        }
        private void DgvParcelas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvParcelas.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvParcelas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvParcelas.Rows[selectedRowIndex];
                parcelaSelecionada = parcelas.Find(p => p.Sequencia == Convert.ToInt32(selectedRow.Cells[0].Value));
                PreencheCamposParcelas(parcelaSelecionada);
                btSalvarParcela.Enabled = true;
            }
        }






        private void Novo()
        {
            if (editando)
                return;

            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigoConta.Text = contaReceberDAO.BuscaProxCodigoDisponivel().ToString();
            contaReceber = null;
            dtpDataCadatroConta.Focus();
            ignoracheckevent = false;
            btGerarParcelas.Enabled = true;
            tbValorContaGerar.Enabled = true;
            Editando(true);
        }
        private void Busca()
        {
            if (editando)
                return;
            var buscaContaReceber = new fmBuscaContaReceber();
            buscaContaReceber.ShowDialog();
            if (buscaContaReceber.contaReceberSelecionada != null)
            {
                contaReceber = buscaContaReceber.contaReceberSelecionada;
                PreencheCampos(contaReceber);
            }
        }
        private void Salva()
        {
            if (!editando)
                return;

            contaReceber = new ContaReceber
            {
                ContaReceberID = int.Parse(tbCodigoConta.Text),
                DataCadastro = dtpDataCadatroConta.Value,
                Operacao = buscaOperacao.operacao,

                ValorOriginal = Convert.ToDecimal(tbValorOriginalConta.Text),
                Multa = Convert.ToDecimal(tbMultaConta.Text),
                Juros = Convert.ToDecimal(tbJurosConta.Text),
                ValorFinal = Convert.ToDecimal(tbValorFinalConta.Text),

                Parcelas = parcelas,

                Pessoa = buscaPessoa.pessoa
            };

            int resultado = contaReceberDAO.SalvaOuAtualiza(contaReceber);

            // resultado 0 = nada foi inserido (houve algum erro)
            // resultado 1 = foi inserido com sucesso
            // resultado 2 = foi atualizado com sucesso
            if (resultado == 0)
            {
                MessageBox.Show("Problema ao salvar o registro",
                "Problema ao salvar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
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
            btGerarParcelas.Enabled = false;
            tbValorContaGerar.Enabled = false;
            tbValorContaGerar.Clear();

        }
        private void Recarrega()
        {
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

            if (contaReceber != null)
            {
                contaReceber = contaReceberDAO.BuscaById(contaReceber.ContaReceberID);
                contaReceber.Operacao = operacaoDAO.BuscaById(contaReceber.Operacao.OperacaoID);
                contaReceber.Pessoa = pessoaDAO.BuscaById(contaReceber.Pessoa.PessoaID);
                PreencheCampos(contaReceber);
                if (editando)
                    Editando(false);
            }
            else
            {
                ignoracheckevent = true;
                LimpaCampos(true);
                ignoracheckevent = false;
            }

        }
        private void Proximo()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }


            if (tbCodigoConta.Text.Length > 0)
            {
                var newcontaReceber = contaReceberDAO.BuscaProximo(int.Parse(tbCodigoConta.Text));
                if (newcontaReceber != null)
                {
                    newcontaReceber.Operacao = operacaoDAO.BuscaById(newcontaReceber.Operacao.OperacaoID);
                    newcontaReceber.Pessoa = pessoaDAO.BuscaById(newcontaReceber.Pessoa.PessoaID);
                    contaReceber = newcontaReceber;
                    parcelas = contaReceber.Parcelas.ToList();
                    PreencheCampos(contaReceber);
                    if (editando)
                        Editando(false);
                }
            }
        }
        private void Anterior()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            if (tbCodigoConta.Text.Length > 0)
            {
                var newcontaRebeceber = contaReceberDAO.BuscaAnterior(int.Parse(tbCodigoConta.Text));
                if (newcontaRebeceber != null)
                {
                    newcontaRebeceber.Operacao = operacaoDAO.BuscaById(newcontaRebeceber.Operacao.OperacaoID);
                    newcontaRebeceber.Pessoa = pessoaDAO.BuscaById(newcontaRebeceber.Pessoa.PessoaID);
                    contaReceber = newcontaRebeceber;
                    parcelas = contaReceber.Parcelas.ToList();
                    PreencheCampos(contaReceber);
                    if (editando)
                        Editando(false);
                }
            }
        }
        private void CarregaDados()
        {
            int codigo = 0;
            if (!int.TryParse(tbCodigoConta.Text, out codigo)) { tbCodigoConta.Clear(); }
            if (contaReceber?.ContaReceberID == codigo)
                return;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?", "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            if (tbCodigoConta.Text.Length == 0)
            {
                LimpaCampos(true);
                Editando(false);
                return;
            }

            var newcontaReceber = contaReceberDAO.BuscaById(codigo);
            if (newcontaReceber != null)
            {
                newcontaReceber.Operacao = operacaoDAO.BuscaById(newcontaReceber.Operacao.OperacaoID);
                newcontaReceber.Pessoa = pessoaDAO.BuscaById(newcontaReceber.Pessoa.PessoaID);
                contaReceber = newcontaReceber;
                btGerarParcelas.Enabled = false;
                tbValorContaGerar.Enabled = false;
                PreencheCampos(contaReceber);
                Editando(false);
            }
            else
            {
                Editando(true);
                LimpaCampos(false);
                btGerarParcelas.Enabled = true;
                tbValorContaGerar.Enabled = true;
            }

        }
        private void PreencheCampos(ContaReceber contaReceber)
        {
            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigoConta.Text = contaReceber.ContaReceberID.ToString();
            dtpDataCadatroConta.Value = contaReceber.DataCadastro;
            buscaOperacao.operacao = contaReceber.Operacao;
            tbValorOriginalConta.Text = contaReceber.ValorOriginal.ToString("############0.00");
            tbValorFinalConta.Text = contaReceber.ValorFinal.ToString("############0.00");
            tbMultaConta.Text = contaReceber.Multa.ToString("############0.00");
            tbJurosConta.Text = contaReceber.Juros.ToString("############0.00");
            parcelas = contaReceber.Parcelas.ToList();
            buscaOperacao.PreencheCampos(contaReceber.Operacao);
            buscaPessoa.PreencheCampos(contaReceber.Pessoa);
            PreencheGridParcelas(parcelas);
            ignoracheckevent = false;
        }
        private void PreencheGridParcelas(List<ParcelaContaReceber> parcelas)
        {
            foreach (var parcela in parcelas)
                dgvParcelas.Rows.Add(parcela.Sequencia,
                                     parcela.DataVencimento.ToShortDateString(),
                                     parcela.Valor.ToString("############0.00"),
                                     parcela.Multa.ToString("############0.00"),
                                     parcela.Juros.ToString("############0.00"),
                                     parcela.ValorFinal.ToString("############0.00"),
                                     parcela.DataQuitacao?.Date);
            dgvParcelas.Refresh();
        }
        private void PreencheCamposParcelas(ParcelaContaReceber parcela)
        {
            tbCodigoParcela.Text = parcela.Sequencia.ToString();
            dtpDataVencimentoParcela.Value = parcela.DataVencimento;
            tbValorOriginalParcela.Text = parcela.Valor.ToString();
            tbMultaParcela.Text = parcela.Multa.ToString();
            tbJurosParcela.Text = parcela.Juros.ToString();
            tbValorFinalParcela.Text = parcela.ValorFinal.ToString();
            tbDataQuitacao.Text = parcela.DataQuitacao != null ? parcela.DataQuitacao.Value.ToShortDateString() : "";
        }
        private void GerarParcelas()
        {
            if (buscaOperacao.operacao == null)
            {
                MessageBox.Show("Você deve selecionar um operação para gerar as parcelas!",
                 "Operação não selecionada",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }
            parcelas.Clear();
            dgvParcelas.Rows.Clear();
            dgvParcelas.Refresh();
            tbMultaConta.Text = "0,00";
            tbJurosConta.Text = "0,00";
            tbValorOriginalConta.Text = "0,00";
            tbValorFinalConta.Text = "0,00";
            var parcelasOperacao = buscaOperacao.operacao.Parcelas;



            int sequencia = 1;
            foreach (var parcela in parcelasOperacao)
            {
                var par = new ParcelaContaReceber
                {
                    Sequencia = sequencia,
                    DataVencimento = DateTime.Today.AddDays(parcela.Dias),
                    Multa = 0,
                    Juros = 0,
                    Valor = Convert.ToDecimal(tbValorContaGerar.Text) / parcelasOperacao.Count
                };
                sequencia++;
                this.parcelas.Add(par);
                tbValorOriginalConta.Text = (Convert.ToDecimal(tbValorOriginalConta.Text) + par.Valor).ToString();
            }
            tbValorFinalConta.Text = tbValorOriginalConta.Text;

            PreencheGridParcelas(parcelas);
        }
        private void CalculaTotalParcela()
        {
            tbValorFinalParcela.Text = (Convert.ToDecimal(tbValorOriginalParcela.Text) + Convert.ToDecimal(tbMultaParcela.Text) + Convert.ToDecimal(tbJurosParcela.Text)).ToString("############0.00");
        }
        private void SalvaParcela()
        {
            if (parcelaSelecionada == null)
                return;

            var dr = dgvParcelas.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells[0].Value.ToString()) == parcelaSelecionada.Sequencia).FirstOrDefault();
            if (dr == null)
            {
                MessageBox.Show("Parcela não encontrada!", "Erro ao selecionar parcela",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var ptemp = parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).FirstOrDefault();
                ptemp.Valor = Convert.ToDecimal(tbValorOriginalParcela.Text);
                ptemp.Multa = Convert.ToDecimal(tbMultaParcela.Text);
                ptemp.Juros = Convert.ToDecimal(tbJurosParcela.Text);
                ptemp.DataVencimento = dtpDataVencimentoParcela.Value;
                ptemp.FormaPagamento = buscaFormaPagamento.formaPagamento;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Valor = ptemp.Valor;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().DataVencimento = ptemp.DataVencimento;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Multa = ptemp.Multa;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Juros = ptemp.Juros;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().FormaPagamento = ptemp.FormaPagamento;
                dr.Cells[dgvtbcValorOriginal.Index].Value = ptemp.Valor.ToString("############0.00");
                dr.Cells[dgvtbcDataVencimento.Index].Value = ptemp.DataVencimento.ToShortDateString();
                dr.Cells[dgvtbcMulta.Index].Value = ptemp.Multa.ToString("############0.00");
                dr.Cells[dgvtbcJuros.Index].Value = ptemp.Juros.ToString("############0.00");
                dgvParcelas.Update();
                dgvParcelas.Refresh();
            }
            CalculaTotalConta();
        }
        private void CalculaTotalConta()
        {
            if (parcelas.Count > 0)
            {
                tbValorOriginalConta.Text = parcelas.Sum(p => p.Valor).ToString("############0.00");
                tbMultaConta.Text = parcelas.Sum(p => p.Multa).ToString("############0.00");
                tbJurosConta.Text = parcelas.Sum(p => p.Juros).ToString("############0.00");
                tbValorFinalConta.Text = parcelas.Sum(p => p.ValorFinal).ToString("############0.00");
            }
        }
        private void FormataCampoDecimal(TextBox sender)
        {
            sender.Text = sender.Text.Length > 0 ? Convert.ToDecimal(sender.Text).ToString("############0.00") : "0,00";
        }
        private void LimpaCampos(bool limpaCod)
        {
            if (limpaCod) { tbCodigoConta.Clear(); }
            buscaOperacao.Limpa();
            buscaPessoa.Limpa();
            dtpDataCadatroConta.Value = DateTime.Now;
            dtpDataVencimentoParcela.Value = DateTime.Now;
            tbValorOriginalConta.Text = "0,00";
            tbValorFinalConta.Text = "0,00";
            tbMultaConta.Text = "0,00";
            tbJurosConta.Text = "0,00";
            tbAjuda.Clear();
            parcelas.Clear();
            tbValorContaGerar.Clear();
            dgvParcelas.Rows.Clear();
            dgvParcelas.Refresh();
            LimpaCamposParcela(limpaCod);
        }
        private void LimpaCamposParcela(bool focus)
        {
            tbValorOriginalParcela.Text = "0,00";
            tbValorFinalParcela.Text = "0,00";
            tbMultaParcela.Text = "0,00";
            tbJurosParcela.Text = "0,00";
            this.parcelaSelecionada = null;
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void Editando(bool edit)
        {
            if (!ignoracheckevent)
            {
                editando = edit;
                menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
            }
        }
        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("050100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
