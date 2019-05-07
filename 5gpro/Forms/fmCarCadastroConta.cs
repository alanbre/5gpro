﻿using _5gpro.Daos;
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
        private bool editando, ignoracheckevent, novo = false;
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
                return;
            }

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
        private void TbCodigoConta_Leave(object sender, EventArgs e) => CarregaDados();
        private void DbValorOriginalParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
        private void DbMultaParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
        private void DbJurosParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
        private void LbAcrescimoParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
        private void DbAcrescimoParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
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

            novo = true;
            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigoConta.Text = contaReceberDAO.BuscaProxCodigoDisponivel().ToString();
            contaReceber = null;
            dtpDataCadatroConta.Focus();
            ignoracheckevent = false;
            btGerarParcelas.Enabled = true;
            dbValorContaGerar.Enabled = true;
            Editando(true);
            novo = false;
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

                ValorOriginal = dbValorOriginalConta.Valor,
                Multa = dbMultaConta.Valor,
                Juros = dbJurosConta.Valor,
                Acrescimo = dbAcrescimoConta.Valor,
                ValorFinal = dbValorFinalConta.Valor,

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
            dbValorContaGerar.Enabled = false;
            dbValorContaGerar.Valor = 0.00m;

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
            if (novo)
                return;
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
                dbValorContaGerar.Enabled = false;
                PreencheCampos(contaReceber);
                Editando(false);
            }
            else
            {
                Editando(true);
                LimpaCampos(false);
                btGerarParcelas.Enabled = true;
                dbValorContaGerar.Enabled = true;
            }

        }
        private void PreencheCampos(ContaReceber contaReceber)
        {
            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigoConta.Text = contaReceber.ContaReceberID.ToString();
            dtpDataCadatroConta.Value = contaReceber.DataCadastro;
            buscaOperacao.operacao = contaReceber.Operacao;
            dbValorOriginalConta.Valor = contaReceber.ValorOriginal;
            dbValorFinalConta.Valor = contaReceber.ValorFinal;
            dbMultaConta.Valor = contaReceber.Multa;
            dbJurosConta.Valor = contaReceber.Juros;
            dbAcrescimoConta.Valor = contaReceber.Acrescimo;
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
                                     parcela.Valor,
                                     parcela.Multa,
                                     parcela.Juros,
                                     parcela.Acrescimo,
                                     parcela.ValorFinal,
                                     parcela.DataQuitacao?.Date);
            dgvParcelas.Refresh();
        }
        private void PreencheCamposParcelas(ParcelaContaReceber parcela)
        {
            tbCodigoParcela.Text = parcela.Sequencia.ToString();
            dtpDataVencimentoParcela.Value = parcela.DataVencimento;
            dbValorOriginalParcela.Valor = parcela.Valor;
            dbMultaParcela.Valor = parcela.Multa;
            dbJurosParcela.Valor = parcela.Juros;
            dbAcrescimoParcela.Valor = parcela.Acrescimo;
            dbValorFinalParcela.Valor = parcela.ValorFinal;
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
            dbMultaConta.Valor = 0.00m;
            dbJurosConta.Valor = 0.00m;
            dbAcrescimoParcela.Valor = 0.00m;
            dbValorOriginalConta.Valor = 0.00m;
            dbValorFinalConta.Valor = 0.00m;
            var parcelasOperacao = buscaOperacao.operacao.Parcelas;



            int sequencia = 1;
            foreach (var parcela in parcelasOperacao)
            {
                var par = new ParcelaContaReceber
                {
                    Sequencia = sequencia,
                    DataVencimento = DateTime.Today.AddDays(parcela.Dias),
                    Multa = 0.00m,
                    Juros = 0.00m,
                    Valor = dbValorContaGerar.Valor / parcelasOperacao.Count,
                    Acrescimo = dbValorContaGerar.Valor  * buscaOperacao.operacao.Acrescimo / 100 / parcelasOperacao.Count
                };
                sequencia++;
                this.parcelas.Add(par);
                dbValorOriginalConta.Valor += par.Valor;
                dbAcrescimoConta.Valor += par.Acrescimo;
                dbValorFinalConta.Valor += par.Valor + par.Acrescimo;
            }
            PreencheGridParcelas(parcelas);
        }
        private void CalculaTotalParcela()
        {
            dbValorFinalParcela.Valor = dbValorOriginalParcela.Valor + dbMultaParcela.Valor + dbJurosParcela.Valor + dbAcrescimoParcela.Valor;
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
                ptemp.Valor = dbValorOriginalParcela.Valor;
                ptemp.Multa = dbMultaParcela.Valor;
                ptemp.Juros = dbJurosParcela.Valor;
                ptemp.Acrescimo = dbAcrescimoParcela.Valor;
                ptemp.DataVencimento = dtpDataVencimentoParcela.Value;
                ptemp.FormaPagamento = buscaFormaPagamento.formaPagamento;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Valor = ptemp.Valor;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().DataVencimento = ptemp.DataVencimento;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Multa = ptemp.Multa;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Juros = ptemp.Juros;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Acrescimo = ptemp.Acrescimo;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().FormaPagamento = ptemp.FormaPagamento;
                dr.Cells[dgvtbcValorOriginal.Index].Value = ptemp.Valor;
                dr.Cells[dgvtbcDataVencimento.Index].Value = ptemp.DataVencimento.ToShortDateString();
                dr.Cells[dgvtbcMulta.Index].Value = ptemp.Multa;
                dr.Cells[dgvtbcJuros.Index].Value = ptemp.Juros;
                dr.Cells[dgvtbcAcrescimo.Index].Value = ptemp.Acrescimo;
                dr.Cells[dgvtbcValorFinal.Index].Value = ptemp.ValorFinal;
                dgvParcelas.Update();
                dgvParcelas.Refresh();
            }
            Editando(true);
            CalculaTotalConta();
        }
        private void CalculaTotalConta()
        {
            if (parcelas.Count > 0)
            {
                dbValorOriginalConta.Valor = parcelas.Sum(p => p.Valor);
                dbMultaConta.Valor = parcelas.Sum(p => p.Multa);
                dbJurosConta.Valor = parcelas.Sum(p => p.Juros);
                dbAcrescimoConta.Valor = parcelas.Sum(p => p.Acrescimo);
                dbValorFinalConta.Valor = parcelas.Sum(p => p.ValorFinal);
            }
        }
        private void LimpaCampos(bool limpaCod)
        {
            if (limpaCod) { tbCodigoConta.Clear(); }
            buscaOperacao.Limpa();
            buscaPessoa.Limpa();
            dtpDataCadatroConta.Value = DateTime.Now;
            dtpDataVencimentoParcela.Value = DateTime.Now;
            dbValorOriginalConta.Valor = 0.00m;
            dbValorFinalConta.Valor = 0.00m;
            dbMultaConta.Valor = 0.00m;
            dbJurosConta.Valor = 0.00m;
            dbAcrescimoConta.Valor = 0.00m;
            tbAjuda.Clear();
            parcelas.Clear();
            dbValorContaGerar.Valor = 0.00m;
            dgvParcelas.Rows.Clear();
            dgvParcelas.Refresh();
            LimpaCamposParcela(limpaCod);
        }
        private void LimpaCamposParcela(bool focus)
        {
            dbValorOriginalParcela.Valor = 0.00m;
            dbValorFinalParcela.Valor = 0.00m;
            dbMultaParcela.Valor = 0.00m;
            dbJurosParcela.Valor = 0.00m;
            dbAcrescimoParcela.Valor = 0.00m;
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
