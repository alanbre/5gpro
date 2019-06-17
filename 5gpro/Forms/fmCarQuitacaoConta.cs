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
    public partial class fmCarQuitacaoConta : Form
    {

        private List<ParcelaContaReceber> parcelasContaReceber;
        private readonly ParcelaContaReceberDAO parcelaContaReceberDAO = new ParcelaContaReceberDAO();
        private readonly CaixaLancamentoDAO caixaLancamentoDAO = new CaixaLancamentoDAO();
        private List<ParcelaContaReceber> parcelasContaReceberSelecionadas = new List<ParcelaContaReceber>();
        private List<CaixaLancamento> caixaLancamentos = null;
        private bool valorContaFiltro = false;
        private bool dataCadastroFiltro = false;
        private bool dataVencimentoFiltro = false;

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

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

        public fmCarQuitacaoConta()
        {
            InitializeComponent();
            SetarNivel();
            DatasIniciais();
        }

        private void FmCarQuitacaoConta_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();
        private void BtQuitar_Click(object sender, EventArgs e) => Quitar();
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
                dbValorInicial.Enabled = false ;
                dbValorFinal.Enabled = false;
                valorContaFiltro = false;
            }
        }
        private void DgvParcelas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) => SelecionaLinha();
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

            parcelasContaReceber = parcelaContaReceberDAO.Busca(f).ToList();
            dgvParcelas.Rows.Clear();
            foreach (var par in parcelasContaReceber)
            {
                dgvParcelas.Rows.Add(par.ContaReceberID,
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
        private void Quitar()
        {
            if (parcelasContaReceberSelecionadas.Count <= 0)
            {
                MessageBox.Show("Nenhuma parcela seleciona!",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            var formTroco = new fmTroco(dbValorTotal.Valor);
            formTroco.ShowDialog();
            if (!formTroco.pago)
            {
                return;
            }

            int retorno = parcelaContaReceberDAO.QuitarParcelas(parcelasContaReceberSelecionadas);
            if (retorno == 1)
            {
                MessageBox.Show("Parcelas selecionadas quitadas!");
                caixaLancamentos = new List<CaixaLancamento>();
                foreach(var parc in parcelasContaReceberSelecionadas)
                {
                    var caixaLancamento = new CaixaLancamento();
                    caixaLancamento.Caixa = buscaCaixa.caixa;
                    caixaLancamento.Data = DateTime.Now;
                    caixaLancamento.Documento = parc.ParcelaContaReceberID.ToString();
                    caixaLancamento.TipoDocumento = 0;
                    caixaLancamento.TipoMovimento = 0;
                    caixaLancamento.Lancamento = 1;
                    caixaLancamento.Valor = parc.ValorFinal;
                    caixaLancamento.ParcelaContaReceber = parc;
                    caixaLancamentos.Add(caixaLancamento);
                }
                caixaLancamentoDAO.NovosCar(caixaLancamentos);
                parcelasContaReceberSelecionadas.Clear();
                Limpar();
                btPesquisar.PerformClick();
            }
            else
            {
                MessageBox.Show("Houve problema ao quitar as parcelas!");
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
        private void DatasIniciais()
        {
            dtpDataCadastroInicial.Value = DateTime.Today.AddDays(-30);
            dtpDataVencimentoInicial.Value = DateTime.Today.AddDays(-30);
        }
        private void SelecionaLinha()
        {
            var parcelaSelecionada = parcelasContaReceber.Single(p => p.ContaReceberID == (int) dgvParcelas.CurrentRow.Cells[0].Value && p.Sequencia == (int)dgvParcelas.CurrentRow.Cells[1].Value);
            if(parcelasContaReceberSelecionadas.Contains(parcelaSelecionada))
            {
                parcelasContaReceberSelecionadas.Remove(parcelaSelecionada);
                dgvParcelas.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
                dgvParcelas.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                dgvParcelas.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                parcelasContaReceberSelecionadas.Add(parcelaSelecionada);
                dgvParcelas.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Blue;
                dgvParcelas.CurrentRow.DefaultCellStyle.BackColor = Color.DarkBlue;
                dgvParcelas.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
            }
            CalculaTotais();
        }
        private void CalculaTotais()
        {
            tbCount.Text = parcelasContaReceberSelecionadas.Count.ToString();
            dbValor.Valor = parcelasContaReceberSelecionadas.Sum(p => p.Valor);
            dbMulta.Valor = parcelasContaReceberSelecionadas.Sum(p => p.Multa);
            dbJuros.Valor = parcelasContaReceberSelecionadas.Sum(p => p.Juros);
            dbAcrescimo.Valor = parcelasContaReceberSelecionadas.Sum(p => p.Acrescimo);
            dbDesconto.Valor = parcelasContaReceberSelecionadas.Sum(p => p.Desconto);
            dbValorTotal.Valor = parcelasContaReceberSelecionadas.Sum(p => p.ValorFinal);
            lbTotal.Text = dbValorTotal.Valor.ToString("TOTAL: R$ ########0.00");
        }
        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("050200").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
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
    }
}
