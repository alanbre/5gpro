using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCapReplicarConta : Form
    {
        private ContaPagar contaPagarBase = null;
        private List<ContaPagar> contasPagarGeradas = new List<ContaPagar>();
        private FuncoesAuxiliares f = new FuncoesAuxiliares();
        private readonly ContaPagarDAO contaPagarDAO = new ContaPagarDAO();

        public fmCapReplicarConta(ContaPagar contaPagar)
        {
            InitializeComponent();
            this.contaPagarBase = contaPagar;
        }

        private void FmCapReplicarConta_Load(object sender, EventArgs e) => PreencheDadosContaBase();
        private void TbQuantidade_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbQuantidade.Text, out int codigo)) { tbQuantidade.Clear(); }
            if (codigo == 0) { tbQuantidade.Clear(); }
        }
        private void TbIntervalo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbIntervalo.Text, out int codigo)) { tbIntervalo.Clear(); }
            if (codigo == 0) { tbIntervalo.Clear(); }
        }
        private void FmCapReplicarConta_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }
        private void BtReplicar_Click(object sender, EventArgs e) => Replicar();
        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtConfirmar_Click(object sender, EventArgs e) => Confirmar();



        private void PreencheDadosContaBase()
        {
            tbCodigoConta.Text = contaPagarBase.ContaPagarID.ToString();
            buscaPessoa.PreencheCampos(contaPagarBase.Pessoa);
            dbValorOriginalConta.Valor = contaPagarBase.ValorOriginal;
            dbMultaConta.Valor = contaPagarBase.Multa;
            dbJurosConta.Valor = contaPagarBase.Juros;
            dbAcrescimoConta.Valor = contaPagarBase.Acrescimo;
            dbDescontoConta.Valor = contaPagarBase.Desconto;
            dbValorFinalConta.Valor = contaPagarBase.ValorFinal;
        }
        private void Replicar()
        {
            if (!(tbQuantidade.Text.Length > 0) || !(tbIntervalo.Text.Length > 0))
            {
                MessageBox.Show("Deve ser preenchida a quantidade de contas e o intervalo para replicar!",
                "Erro ao replicar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                cbTempo.Focus();
                return;
            }
            if(cbTempo.SelectedIndex == -1)
            {
                MessageBox.Show("Deve ser selecionado um tipo de período para replicar!",
                "Erro ao replicar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                cbTempo.Focus();
                return;
            }

            contasPagarGeradas.Clear();

            int quantidade = Convert.ToInt32(tbQuantidade.Text);
            int intervalo = Convert.ToInt32(tbIntervalo.Text);
            for (int i = 1; i <= quantidade; i++)
            {
                var novaConta = new ContaPagar();
                novaConta.DataCadastro = contaPagarBase.DataCadastro;
                novaConta.DataConta = contaPagarBase.DataConta;
                novaConta.Pessoa = contaPagarBase.Pessoa;
                novaConta.ValorOriginal = contaPagarBase.ValorOriginal;
                novaConta.Multa = contaPagarBase.Multa;
                novaConta.Juros = contaPagarBase.Juros;
                novaConta.ValorFinal = contaPagarBase.ValorFinal;
                novaConta.Acrescimo = contaPagarBase.Acrescimo;
                novaConta.Desconto = contaPagarBase.Desconto;
                novaConta.Situacao = contaPagarBase.Situacao;
                novaConta.Descricao = contaPagarBase.Descricao;
                novaConta.Entrada = contaPagarBase.Entrada;
                List<ParcelaContaPagar> parcelas = new List<ParcelaContaPagar>();
                foreach(var parcela in contaPagarBase.Parcelas)
                {
                    ParcelaContaPagar p = new ParcelaContaPagar();
                    p.Sequencia = parcela.Sequencia;
                    p.DataVencimento = cbTempo.SelectedIndex == 0 ? parcela.DataVencimento.AddDays(i * intervalo) : parcela.DataVencimento.AddMonths(i * intervalo);
                    p.Valor = parcela.Valor;
                    p.Multa = parcela.Multa;
                    p.Juros = parcela.Juros;
                    p.Acrescimo = parcela.Acrescimo;
                    p.Desconto = parcela.Desconto;
                    p.DataQuitacao = null;
                    p.FormaPagamento = null;
                    p.Situacao = "Aberto";
                    p.Descricao = parcela.Descricao;
                    parcelas.Add(p);
                }
                novaConta.Parcelas = parcelas;
                contasPagarGeradas.Add(novaConta);
            }
            PreencheGrid();
        }
        private void PreencheGrid()
        {
            dgvContas.Rows.Clear();

            foreach (var cp in contasPagarGeradas)
                dgvContas.Rows.Add(cp.Descricao,
                                   cp.Pessoa.Nome,
                                   cp.DataCadastro.ToShortDateString(),
                                   cp.Parcelas[0].DataVencimento.ToShortDateString(),
                                   cp.ValorOriginal,
                                   cp.Multa,
                                   cp.Juros,
                                   cp.Acrescimo,
                                   cp.Desconto,
                                   cp.ValorFinal);

            dgvContas.Refresh();
        }
        private void Confirmar()
        {
            if (contasPagarGeradas.Count == 0)
            {
                MessageBox.Show("Não há nenhuma conta para ser replicada!",
                "Erro ao replicar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem certeza que deseja gerar as contas a pagar?",
            "Aviso de geração",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            contaPagarDAO.SalvaOuAtualiza(contasPagarGeradas);
            this.Close();
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
