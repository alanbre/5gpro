using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCapCadastroConta : Form
    {
        private ParcelaContaPagar parcelaSelecionada = null;
        private bool editando, ignoracheckevent = false;
        private ContaPagar contaPagar = null;
        private List<ParcelaContaPagar> parcelas = new List<ParcelaContaPagar>();
        Validacao validacao = new Validacao();

        private readonly FuncoesAuxiliares f = new FuncoesAuxiliares();
        private readonly ContaPagarDAO contaPagarDAO = new ContaPagarDAO();
        private readonly PessoaDAO pessoaDAO = new PessoaDAO();

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        public fmCapCadastroConta()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void FmCapCadastroConta_KeyDown(object sender, KeyEventArgs e)
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
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void BtSalvarParcela_Click(object sender, EventArgs e) => SalvaParcela();
        private void DtpDataCadatroConta_ValueChanged(object sender, EventArgs e) => Editando(true);
        private void BuscaPessoa_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void TbCodigoConta_Leave(object sender, EventArgs e) => CarregaDados();
        private void DbValorOriginalParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
        private void DbMultaParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
        private void DbJurosParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
        private void DbAcrescimoParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();
        private void DbDescontoParcela_Leave(object sender, EventArgs e) => CalculaTotalParcela();

        private void DgvParcelas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvParcelas.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvParcelas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvParcelas.Rows[selectedRowIndex];
                parcelaSelecionada = parcelas.Find(p => p.Sequencia == Convert.ToInt32(selectedRow.Cells[0].Value));
                PreencheCamposParcelas(parcelaSelecionada);
                btSalvarParcela.Enabled = true;
                btNovaParcela.Enabled = false;
                btExcluirParcela.Enabled = true;
            }
        }
        private void BtNovaParcela_Click(object sender, EventArgs e) => InserirParcela();
        private void BtExcluirParcela_Click(object sender, EventArgs e) => ExcluirParcela();


        private void Novo()
        {
            if (editando)
                return;

            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigoConta.Text = contaPagarDAO.BuscaProxCodigoDisponivel().ToString();
            contaPagar = null;
            dtpDataConta.Focus();
            ignoracheckevent = false;
            Editando(true);
        }
        private void Busca()
        {
            if (editando)
                return;
            var buscaContaPagar = new fmBuscaContaPagar();
            buscaContaPagar.ShowDialog();
            if (buscaContaPagar.contaPagarSelecionada != null)
            {
                contaPagar = buscaContaPagar.contaPagarSelecionada;
                PreencheCampos(contaPagar);
            }
        }
        private void Salva()
        {
            bool ok = false;

            if (!editando)
                return;
            if (tbCodigoConta.Text.Length > 0)
            {

                contaPagar = new ContaPagar
                {
                    ContaPagarID = int.Parse(tbCodigoConta.Text),
                    DataCadastro = DateTime.Today,
                    DataConta = dtpDataConta.Value,

                    ValorOriginal = dbValorOriginalConta.Valor,
                    Multa = dbMultaConta.Valor,
                    Juros = dbJurosConta.Valor,
                    Acrescimo = dbAcrescimoConta.Valor,
                    Desconto = dbDescontoConta.Valor,
                    ValorFinal = dbValorFinalConta.Valor,
                    Situacao = "Aberto",

                    Parcelas = parcelas,
                    Pessoa = buscaPessoa.pessoa
                };

                ControlCollection controls = (ControlCollection)this.Controls;
                ok = validacao.ValidarEntidade(contaPagar, controls);
                if (ok) { validacao.despintarCampos(controls); }

                if (ok)
                {
                    int resultado = contaPagarDAO.SalvaOuAtualiza(contaPagar);

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
                }
            }
            else
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                                    "Aviso",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbCodigoConta.Text = contaPagarDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
            }
        }


        private void Recarrega()
        {
            if (tbCodigoConta.Text.Length > 0)
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

                if (contaPagar != null)
                {
                    contaPagar = contaPagarDAO.BuscaByID(contaPagar.ContaPagarID);
                    contaPagar.Pessoa = pessoaDAO.BuscaById(contaPagar.Pessoa.PessoaID);
                    PreencheCampos(contaPagar);
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
        }
        private void Proximo()
        {
            ControlCollection controls = (ControlCollection)this.Controls;

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
                validacao.despintarCampos(controls);

                var newcontaPagar = contaPagarDAO.Proximo(int.Parse(tbCodigoConta.Text));
                if (newcontaPagar != null)
                {
                    newcontaPagar.Pessoa = pessoaDAO.BuscaById(newcontaPagar.Pessoa.PessoaID);
                    contaPagar = newcontaPagar;
                    parcelas = contaPagar.Parcelas.ToList();
                    PreencheCampos(contaPagar);
                    if (editando)
                        Editando(false);
                }
            }
        }
        private void Anterior()
        {
            ControlCollection controls = (ControlCollection)this.Controls;

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
                validacao.despintarCampos(controls);

                var newcontaPagar = contaPagarDAO.Anterior(int.Parse(tbCodigoConta.Text));
                if (newcontaPagar != null)
                {
                    newcontaPagar.Pessoa = pessoaDAO.BuscaById(newcontaPagar.Pessoa.PessoaID);
                    contaPagar = newcontaPagar;
                    parcelas = contaPagar.Parcelas.ToList();
                    PreencheCampos(contaPagar);
                    if (editando)
                        Editando(false);
                }
            }
        }
        private void CarregaDados()
        {
            int codigo = 0;
            if (!int.TryParse(tbCodigoConta.Text, out codigo)) { tbCodigoConta.Clear(); }
            if (contaPagar?.ContaPagarID == codigo)
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

            var newcontaPagar = contaPagarDAO.BuscaByID(codigo);
            if (newcontaPagar != null)
            {
                newcontaPagar.Pessoa = pessoaDAO.BuscaById(newcontaPagar.Pessoa.PessoaID);
                contaPagar = newcontaPagar;
                PreencheCampos(contaPagar);
                Editando(false);
            }
            else
            {
                Editando(true);
                LimpaCampos(false);
            }

        }
        private void PreencheCampos(ContaPagar contaPagar)
        {
            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigoConta.Text = contaPagar.ContaPagarID.ToString();
            dtpDataConta.Value = contaPagar.DataCadastro;
            dbValorOriginalConta.Valor = contaPagar.ValorOriginal;
            dbValorFinalConta.Valor = contaPagar.ValorFinal;
            dbMultaConta.Valor = contaPagar.Multa;
            dbJurosConta.Valor = contaPagar.Juros;
            dbAcrescimoConta.Valor = contaPagar.Acrescimo;
            dbDescontoConta.Valor = contaPagar.Desconto;
            parcelas = contaPagar.Parcelas.ToList();
            buscaPessoa.PreencheCampos(contaPagar.Pessoa);
            PreencheGridParcelas(parcelas);
            ignoracheckevent = false;
        }
        private void PreencheGridParcelas(List<ParcelaContaPagar> parcelas)
        {
            foreach (var parcela in parcelas)
                dgvParcelas.Rows.Add(parcela.Sequencia,
                                     parcela.DataVencimento.ToShortDateString(),
                                     parcela.Valor,
                                     parcela.Multa,
                                     parcela.Juros,
                                     parcela.Acrescimo,
                                     parcela.Desconto,
                                     parcela.ValorFinal,
                                     parcela.DataQuitacao?.Date,
                                     parcela.Situacao);
            dgvParcelas.Refresh();
        }
        private void PreencheCamposParcelas(ParcelaContaPagar parcela)
        {
            tbCodigoParcela.Text = parcela.Sequencia.ToString();
            dtpDataVencimentoParcela.Value = parcela.DataVencimento;
            dbValorOriginalParcela.Valor = parcela.Valor;
            dbMultaParcela.Valor = parcela.Multa;
            dbJurosParcela.Valor = parcela.Juros;
            dbAcrescimoParcela.Valor = parcela.Acrescimo;
            dbDescontoParcela.Valor = parcela.Desconto;
            dbValorFinalParcela.Valor = parcela.ValorFinal;
            tbSituacaoParcela.Text = parcela.Situacao;
            tbDataQuitacao.Text = parcela.DataQuitacao != null ? parcela.DataQuitacao.Value.ToShortDateString() : "";
            if (parcela.FormaPagamento != null)
                tbFormaPagamentoParcela.Text = parcela.FormaPagamento.Nome;
            else
                tbFormaPagamentoParcela.Clear();
        }
        private void InserirParcela()
        {
            if(tbCodigoConta.Text.Length > 0)
            {
                LimpaCamposParcela();
                string codigo = "1";
                if (parcelas.Count > 0)
                    codigo = (parcelas.Max(p => p.Sequencia) + 1).ToString();
                tbCodigoParcela.Text = codigo;
                dtpDataVencimentoParcela.Focus();
                btNovaParcela.Enabled = false;
            }
            else
            {
                MessageBox.Show("Informe o código da conta","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void ExcluirParcela()
        {
            parcelas.Remove(parcelas.Single(p => p.Sequencia.ToString() == tbCodigoParcela.Text));
            dgvParcelas.Rows.Clear();
            PreencheGridParcelas(parcelas);
            CalculaTotalConta();
            Editando(true);
        }
        private void CalculaTotalParcela()
        {
            dbValorFinalParcela.Valor = dbValorOriginalParcela.Valor + dbMultaParcela.Valor + dbJurosParcela.Valor + dbAcrescimoParcela.Valor - dbDescontoParcela.Valor;
        }
        private void SalvaParcela()
        {
            
            if (tbCodigoParcela.Text.Length == 0)
                return;
            var dr = dgvParcelas.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells[0].Value.ToString()) == parcelaSelecionada?.Sequencia).FirstOrDefault();
            if (dr == null)
            {
                var parcela = new ParcelaContaPagar()
                {
                    Sequencia = Convert.ToInt32(tbCodigoParcela.Text),
                    DataVencimento = dtpDataVencimentoParcela.Value,
                    Valor = dbValorOriginalParcela.Valor,
                    Multa = dbMultaParcela.Valor,
                    Juros = dbJurosParcela.Valor,
                    Acrescimo = dbAcrescimoParcela.Valor,
                    Desconto = dbDescontoParcela.Valor
                };
                if (tbSituacaoParcela.Text.Length > 0)
                    parcela.Situacao = tbSituacaoParcela.Text;
                else
                    parcela.Situacao = "Aberto";

                parcelas.Add(parcela);
                dgvParcelas.Rows.Add(parcela.Sequencia,
                                     parcela.DataVencimento.ToShortDateString(),
                                     parcela.Valor,
                                     parcela.Multa,
                                     parcela.Juros,
                                     parcela.Acrescimo,
                                     parcela.Desconto,
                                     parcela.ValorFinal,
                                     parcela.DataQuitacao?.Date,
                                     parcela.Situacao
                                     );
                dgvParcelas.Refresh();
                btNovaParcela.Enabled = true;
                btNovaParcela.PerformClick();
                Editando(true);
            }
            else
            {
                var ptemp = parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).FirstOrDefault();
                ptemp.Valor = dbValorOriginalParcela.Valor;
                ptemp.Multa = dbMultaParcela.Valor;
                ptemp.Juros = dbJurosParcela.Valor;
                ptemp.Acrescimo = dbAcrescimoParcela.Valor;
                ptemp.Desconto = dbDescontoParcela.Valor;
                ptemp.DataVencimento = dtpDataVencimentoParcela.Value;
                ptemp.Situacao = tbSituacaoParcela.Text;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Valor = ptemp.Valor;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().DataVencimento = ptemp.DataVencimento;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Multa = ptemp.Multa;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Juros = ptemp.Juros;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Acrescimo = ptemp.Acrescimo;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Desconto = ptemp.Desconto;
                parcelas.Where(p => p.Sequencia == int.Parse(dr.Cells[0].Value.ToString())).First().Situacao = ptemp.Situacao;
                dr.Cells[dgvtbcValorOriginal.Index].Value = ptemp.Valor;
                dr.Cells[dgvtbcDataVencimento.Index].Value = ptemp.DataVencimento.ToShortDateString();
                dr.Cells[dgvtbcMulta.Index].Value = ptemp.Multa;
                dr.Cells[dgvtbcJuros.Index].Value = ptemp.Juros;
                dr.Cells[dgvtbcAcrescimo.Index].Value = ptemp.Acrescimo;
                dr.Cells[dgvtbcDesconto.Index].Value = ptemp.Desconto;
                dr.Cells[dgvtbcValorFinal.Index].Value = ptemp.ValorFinal;
                dr.Cells[dgvtbcSituacao.Index].Value = ptemp.Situacao;
                dgvParcelas.Update();
                dgvParcelas.Refresh();
                Editando(true);
            }
            CalculaTotalConta();
            LimpaCamposParcela();
            btNovaParcela.Enabled = true;
            btExcluirParcela.Enabled = false;
        }
        private void CalculaTotalConta()
        {
            if (parcelas.Count > 0)
            {
                dbValorOriginalConta.Valor = parcelas.Sum(p => p.Valor);
                dbMultaConta.Valor = parcelas.Sum(p => p.Multa);
                dbJurosConta.Valor = parcelas.Sum(p => p.Juros);
                dbAcrescimoConta.Valor = parcelas.Sum(p => p.Acrescimo);
                dbDescontoConta.Valor = parcelas.Sum(p => p.Desconto);
                dbValorFinalConta.Valor = parcelas.Sum(p => p.ValorFinal);
            }
        }
        private void LimpaCampos(bool limpaCod)
        {
            if (limpaCod) { tbCodigoConta.Clear(); }
            buscaPessoa.Limpa();
            dtpDataConta.Value = DateTime.Now;
            tbCodigoParcela.Clear();
            dtpDataVencimentoParcela.Value = DateTime.Now;
            dbValorOriginalConta.Valor = 0.00m;
            dbValorFinalConta.Valor = 0.00m;
            dbMultaConta.Valor = 0.00m;
            dbJurosConta.Valor = 0.00m;
            dbAcrescimoConta.Valor = 0.00m;
            dbDescontoConta.Valor = 0.00m;
            tbAjuda.Clear();
            parcelas.Clear();
            dgvParcelas.Rows.Clear();
            dgvParcelas.Refresh();
            LimpaCamposParcela();
        }
        private void LimpaCamposParcela()
        {
            tbCodigoParcela.Clear();
            dtpDataVencimentoParcela.Value = DateTime.Today;
            dbValorOriginalParcela.Valor = 0.00m;
            dbValorFinalParcela.Valor = 0.00m;
            dbMultaParcela.Valor = 0.00m;
            dbJurosParcela.Valor = 0.00m;
            dbAcrescimoParcela.Valor = 0.00m;
            dbDescontoParcela.Valor = 0.00m;
            tbDataQuitacao.Clear();
            tbSituacaoParcela.Clear();
            tbFormaPagamentoParcela.Clear();
            this.parcelaSelecionada = null;
            btNovaParcela.Enabled = true;
            btExcluirParcela.Enabled = false;
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
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("060100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
