using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaOrcamento : Form
    {
        Cidade cidade = null;
        Pessoa pessoa = null;
        public Orcamento orcamentoSelecionado = null;
        List<Orcamento> orcamentos;

        CidadeBLL cidadeBLL = new CidadeBLL();
        PessoaBLL pessoaBLL = new PessoaBLL();
        OrcamentoBLL orcamentoBLL = new OrcamentoBLL();

        FuncoesAuxiliares f = new FuncoesAuxiliares();

        DataTable table = new DataTable();

        public struct Filtros
        {
            public Pessoa filtroPessoa;
            public Cidade filtroCidade;
            public DateTime? filtroDataCadastroInicial;
            public DateTime? filtroDataCadastroFinal;
            public DateTime? filtroDataValidadeInicial;
            public DateTime? filtroDataValidadeFinal;
            public DateTime? filtroDataEfetivacaoInicial;
            public DateTime? filtroDataEfetivacaoFinal;
            public decimal filtroValorTotalInical;
            public decimal filtroValorTotalFinal;
            public bool contemValidade;
            public bool contemEfetivacao;
        }

        public fmBuscaOrcamento()
        {
            InitializeComponent();
        }

        private void fmBuscaOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }



        private void tbFiltroCodCidade_Leave(object sender, EventArgs e)
        {
            if (tbFiltroCodCidade.Text.Length > 0)
            {
                cidade = cidadeBLL.BuscaCidadeByCod(int.Parse(tbFiltroCodCidade.Text));
                PreencheCamposCidade(cidade);
            }
            else
            {
                tbNomeCidade.Text = "";
            }
        }

        private void tbCodCliente_Leave(object sender, EventArgs e)
        {
            if (tbCodCliente.Text.Length > 0)
            {
                pessoa = pessoaBLL.BuscarPessoaById(int.Parse(tbCodCliente.Text));
                PreencheCamposPessoa(pessoa);
            }
            else
            {
                tbNomeCliente.Text = "";
            }
        }

        private void tbFiltroValorTotalOrcamentoInicial_Leave(object sender, EventArgs e)
        {
            tbFiltroValorTotalOrcamentoInicial.Text = tbFiltroValorTotalOrcamentoInicial.Text.Length > 0 ? Convert.ToDecimal(tbFiltroValorTotalOrcamentoInicial.Text).ToString("############0.00") : "0,00";
        }

        private void tbFiltroValorTotalOrcamentoFinal_Leave(object sender, EventArgs e)
        {
            tbFiltroValorTotalOrcamentoFinal.Text = tbFiltroValorTotalOrcamentoFinal.Text.Length > 0 ? Convert.ToDecimal(tbFiltroValorTotalOrcamentoFinal.Text).ToString("############0.00") : "999999,00";
        }



        private void tbFiltroCodCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaCidade();
            }
        }

        private void tbCodCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaPessoa();
            }
        }




        private void btBuscaCidade_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaCidade();
        }

        private void btProcuraCliente_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaPessoa();
        }



        private void tbFiltroValorTotalOrcamentoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbFiltroValorTotalOrcamentoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f.ValidaTeclaDigitadaDecimal(e))
            {
                e.Handled = true;
                return;
            }
        }





        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void AbreTelaBuscaCidade()
        {
            var buscaCidade = new fmBuscaCidade();
            buscaCidade.ShowDialog();
            if (buscaCidade.cidadeSelecionada != null)
            {
                cidade = buscaCidade.cidadeSelecionada;
                PreencheCamposCidade(cidade);
            }
        }

        private void AbreTelaBuscaPessoa()
        {
            var buscaPessoa = new fmBuscaPessoa();
            buscaPessoa.ShowDialog();
            if (buscaPessoa.pessoaSelecionada != null)
            {
                pessoa = buscaPessoa.pessoaSelecionada;
                PreencheCamposPessoa(pessoa);
            }
        }

        private void PreencheCamposCidade(Cidade cidade)
        {
            if (cidade != null)
            {
                tbFiltroCodCidade.Text = cidade.CidadeID.ToString();
                tbNomeCidade.Text = cidade.Nome;
            }
        }

        private void PreencheCamposPessoa(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                tbCodCliente.Text = pessoa.PessoaID.ToString();
                tbNomeCliente.Text = pessoa.Nome;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado no banco de dados",
                "Cliente não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodCliente.Focus();
                tbCodCliente.SelectAll();
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            dgvOrcamentos.Rows.Clear();
            Filtros f = new Filtros();
            f.filtroCidade = cidade;
            f.filtroPessoa = pessoa;
            f.filtroDataCadastroInicial = dtpFiltroDataCadastroInicial.Value;
            f.filtroDataCadastroFinal = dtpFiltroDataCadastroFinal.Value;
            f.filtroDataValidadeInicial = dtpFiltroDataValidadeInicial.Value;
            f.filtroDataValidadeFinal = dtpFiltroDataValidadeFinal.Value;
            f.filtroDataEfetivacaoInicial = dtpFiltroDataEfetivacaoInicial.Value;
            f.filtroDataEfetivacaoFinal = dtpFiltroDataEfetivacaoFinal.Value;
            f.contemValidade = cblFiltros.GetItemChecked(0);
            f.contemEfetivacao = cblFiltros.GetItemChecked(1);
            f.filtroValorTotalInical = Convert.ToDecimal(tbFiltroValorTotalOrcamentoInicial.Text);
            f.filtroValorTotalFinal = Convert.ToDecimal(tbFiltroValorTotalOrcamentoFinal.Text);

            orcamentos = orcamentoBLL.BuscaOrcamentos(f);

            foreach (var o in orcamentos)
            {
                if (o.DataValidade.HasValue)
                {
                    dgvOrcamentos.Rows.Add(o.OrcamentoID, o.Pessoa.PessoaID, o.Pessoa.Nome, o.DataCadastro.ToShortDateString(), o.DataValidade.Value.ToShortDateString(), o.ValorTotalItens, o.DescontoTotalItens, o.DescontoOrcamento, o.ValorTotalOrcamento);
                }
                else
                {
                    dgvOrcamentos.Rows.Add(o.OrcamentoID, o.Pessoa.PessoaID, o.Pessoa.Nome, o.DataCadastro.ToShortDateString(), o.DataValidade, o.ValorTotalItens, o.DescontoTotalItens, o.DescontoOrcamento, o.ValorTotalOrcamento);
                }
                
                //table.Rows.Add(o.Codigo, o.Pessoa.Codigo, o.Pessoa.Nome, o.DataCadastro, o.DataValidade, o.ValorTotalItens, o.DescontoTotalItens, o.DescontoOrcamento, o.ValorTotalOrcamento);
            }
            dgvOrcamentos.Refresh();
        }


        private void dgvOrcamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvOrcamentos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvOrcamentos.Rows[selectedRowIndex];
            orcamentoSelecionado = orcamentos.Find(o => o.OrcamentoID == Convert.ToInt32(selectedRow.Cells[0].Value));
            this.Close();
        }
    }
}
