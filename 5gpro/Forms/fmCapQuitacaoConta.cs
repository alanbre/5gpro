using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCapQuitacaoConta : Form
    {
        private List<ParcelaContaPagar> parcelasContaPagar;
        private readonly ParcelaContaPagarDAO parcelaContaPagarDAO = new ParcelaContaPagarDAO();
        private List<ParcelaContaPagar> parcelasContaPagarSelecionadas = new List<ParcelaContaPagar>();
        private List<CaixaLancamento> caixaLancamentos = null;
        private readonly CaixaLancamentoDAO caixaLancamentoDAO = new CaixaLancamentoDAO();


        private bool valorContaFiltro = false;
        private bool dataCadastroFiltro = false;
        private bool dataVencimentoFiltro = false;

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private string CodGrupoUsuario;

        private int Nivel;
        int codigo = 0;

        public struct Filtros
        {
            public int filtroConta;
            public Pessoa filtroPessoa;
            public decimal filtroValorInicial;
            public decimal filtroValorFinal;
            public DateTime filtroDataCadastroInicial;
            public DateTime filtroDataCadastroFinal;
            public DateTime filtroDataVencimentoInicial;
            public DateTime filtroDataVencimentoFinal;
            public bool usarvalorContaFiltro;
            public bool usardataCadastroFiltro;
            public bool usardataVencimentoFiltro;
        }
        public fmCapQuitacaoConta()
        {
            InitializeComponent();
            SetarNivel();
            DatasIniciais();
        }

        private void FmCapQuitacaoConta_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();
        private void CbDataCadastro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataCadastro.Checked)
            {
                dtpDataCadastroInicial.Enabled = true;
                dtpDataCadastroFinal.Enabled = true;
                dataCadastroFiltro = true;
            }
            else
            {
                dtpDataCadastroInicial.Enabled = false;
                dtpDataCadastroFinal.Enabled = false;
                dataCadastroFiltro = false;
            }
        }
        private void CbDataVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDataVencimento.Checked)
            {
                dtpDataVencimentoInicial.Enabled = true;
                dtpDataVencimentoFinal.Enabled = true;
                dataVencimentoFiltro = true;
            }
            else
            {
                dtpDataVencimentoInicial.Enabled = false;
                dtpDataVencimentoFinal.Enabled = false;
                dataVencimentoFiltro = false;
            }
        }
        private void CbValor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbValor.Checked)
            {
                dbValorInicial.Enabled = true;
                dbValorFinal.Enabled = true;
                valorContaFiltro = true;
            }
            else
            {
                dbValorInicial.Enabled = false;
                dbValorFinal.Enabled = false;
                valorContaFiltro = false;
            }
        }
        private void BtQuitar_Click(object sender, EventArgs e) => Quitar();
        private void DgvParcelas_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => SelecionaLinha();
        private void DgvParcelas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
                return;
            SelecionaLinha();
        }

        private void Pesquisar()
        {
            dgvParcelas.Rows.Clear();
            Filtros f = new Filtros
            {
                filtroConta = codigo,
                filtroPessoa = buscaPessoa.pessoa,
                filtroValorInicial = dbValorInicial.Valor,
                filtroValorFinal = dbValorFinal.Valor,
                filtroDataCadastroInicial = dtpDataCadastroInicial.Value,
                filtroDataCadastroFinal = dtpDataCadastroFinal.Value,
                filtroDataVencimentoInicial = dtpDataVencimentoInicial.Value,
                filtroDataVencimentoFinal = dtpDataVencimentoFinal.Value,
                usardataCadastroFiltro = dataCadastroFiltro,
                usardataVencimentoFiltro = dataVencimentoFiltro,
                usarvalorContaFiltro = valorContaFiltro
            };

            parcelasContaPagar = parcelaContaPagarDAO.Busca(f).ToList();
            dgvParcelas.Rows.Clear();
            foreach (var par in parcelasContaPagar)
            {
                dgvParcelas.Rows.Add(par.ContaPagarID,
                                     par.Sequencia,
                                     par.DataVencimento,
                                     par.Valor,
                                     par.Multa,
                                     par.Juros,
                                     par.Acrescimo,
                                     par.Desconto,
                                     par.ValorFinal
                                     );
            }

            dgvParcelas.Refresh();
        }
        private void DatasIniciais()
        {
            dtpDataCadastroInicial.Value = DateTime.Today.AddDays(-30);
            dtpDataVencimentoInicial.Value = DateTime.Today.AddDays(-30);
        }
        private void SelecionaLinha()
        {
            var parcelaSelecionada = parcelasContaPagar.Single(p => p.ContaPagarID == (int)dgvParcelas.CurrentRow.Cells[0].Value && p.Sequencia == (int)dgvParcelas.CurrentRow.Cells[1].Value);
            if (parcelasContaPagarSelecionadas.Contains(parcelaSelecionada))
            {
                parcelasContaPagarSelecionadas.Remove(parcelaSelecionada);
                dgvParcelas.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                dgvParcelas.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                dgvParcelas.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                parcelasContaPagarSelecionadas.Add(parcelaSelecionada);
                dgvParcelas.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Blue;
                dgvParcelas.CurrentRow.DefaultCellStyle.BackColor = Color.DarkBlue;
                dgvParcelas.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
            }
            CalculaTotais();
        }
        private void CalculaTotais()
        {
            tbCount.Text = parcelasContaPagarSelecionadas.Count.ToString();
            dbValor.Valor = parcelasContaPagarSelecionadas.Sum(p => p.Valor);
            dbMulta.Valor = parcelasContaPagarSelecionadas.Sum(p => p.Multa);
            dbJuros.Valor = parcelasContaPagarSelecionadas.Sum(p => p.Juros);
            dbAcrescimo.Valor = parcelasContaPagarSelecionadas.Sum(p => p.Acrescimo);
            dbDesconto.Valor = parcelasContaPagarSelecionadas.Sum(p => p.Desconto);
            dbValorTotal.Valor = parcelasContaPagarSelecionadas.Sum(p => p.ValorFinal);
            lbTotal.Text = dbValorTotal.Valor.ToString("TOTAL: R$ ########0.00");
        }
        private void Quitar()
        {
            var formTroco = new fmTroco(dbValorTotal.Valor);
            formTroco.ShowDialog();
            if (formTroco.pago)
            {
                int retorno = parcelaContaPagarDAO.QuitarParcelas(parcelasContaPagarSelecionadas);
                if (retorno == 1)
                {
                    MessageBox.Show("Parcelas selecionadas quitadas!");
                    caixaLancamentos = new List<CaixaLancamento>();
                    foreach (var parc in parcelasContaPagarSelecionadas)
                    {
                        var caixaLancamento = new CaixaLancamento();
                        caixaLancamento.Caixa = buscaCaixa.caixa;
                        caixaLancamento.Data = DateTime.Now;
                        caixaLancamento.Documento = parc.ParcelaContaPagarID.ToString();
                        caixaLancamento.TipoDocumento = 1;
                        caixaLancamento.TipoMovimento = 1;
                        caixaLancamento.Lancamento = 1;
                        caixaLancamento.Valor = parc.ValorFinal;
                        caixaLancamento.ParcelaContaPagar = parc;
                        caixaLancamentos.Add(caixaLancamento);
                    }
                    caixaLancamentoDAO.NovosCap(caixaLancamentos);
                    parcelasContaPagarSelecionadas.Clear();
                    Limpar();
                    btPesquisar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Houve problema ao quitar as parcelas!");
                }
            }
        }
        private void Limpar()
        {
            tbCount.Clear();
            dbValor.Valor = 0;
            dbMulta.Valor = 0;
            dbJuros.Valor = 0;
            dbAcrescimo.Valor = 0;
            dbDesconto.Valor = 0;
            dbValorTotal.Valor = 0;
            buscaCaixa.Limpa();
        }
        private void SetarNivel()
        {
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("050200").ToString();

            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
        }


        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void TbCodigoConta_Leave(object sender, EventArgs e)
        {
            int c = 0;
            if (!int.TryParse(tbCodigoConta.Text, out c))
            {
                tbCodigoConta.Clear();
            }
            codigo = c;
        }
    }
}
