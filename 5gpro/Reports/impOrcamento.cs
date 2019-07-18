using _5gpro.Entities;
using _5gpro.Funcoes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Reports
{
    public partial class impOrcamento : Form
    {
        private FuncoesAuxiliares fa = new FuncoesAuxiliares();
        private DataTable _dados = new DataTable();
        private Orcamento orcamento;


        public impOrcamento(DataTable dados, Orcamento orcamento)
        {
            InitializeComponent();
            _dados = fa.DeepCopy(dados);
            this.orcamento = orcamento;
        }

        private void ImpOrcamento_Load(object sender, EventArgs e)
        {
            _dados.TableName = "Orçamento";
            this.rvOrcamento.LocalReport.DisplayName = "Orçamento";

            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"razaosocial", Estabelecimento.Nome, true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"endereco", $"{Estabelecimento.Rua}, {Estabelecimento.Numero} {Estabelecimento.Complemento} - {Estabelecimento.Bairro}", true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"telefone", fa.FormataTel(Estabelecimento.Telefone), true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"email", fa.FormataTel(Estabelecimento.Email), true));


            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"numero", orcamento.OrcamentoID.ToString(), true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_cod", orcamento.Pessoa.PessoaID.ToString(), true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_nome", orcamento.Pessoa.Nome.ToString(), true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_endereco", orcamento.Pessoa.Rua + orcamento.Pessoa.Numero, true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_cidade", orcamento.Pessoa.Cidade.Nome, true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_bairro", orcamento.Pessoa.Bairro, true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_email", orcamento.Pessoa.Email, true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_doc", orcamento.Pessoa.TipoPessoa == "F" 
                                                                                         ? fa.FormataCPF(orcamento.Pessoa.CpfCnpj)
                                                                                         : fa.FormataCNPJ(orcamento.Pessoa.CpfCnpj), true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_uf", orcamento.Pessoa.Cidade.Estado.Uf, true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"cliente_telefone", fa.FormataTel(orcamento.Pessoa.Telefone), true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"data_cadastro", orcamento.DataCadastro.ToString(), true));
            this.rvOrcamento.LocalReport.SetParameters(new ReportParameter($"data_vencimento", orcamento.DataValidade?.ToString(), true));
            this.rvOrcamento.LocalReport.DataSources.Add(new ReportDataSource("dsOrcamento", _dados));
            this.rvOrcamento.SetDisplayMode(DisplayMode.PrintLayout);

            this.rvOrcamento.RefreshReport();
        }
    }
}
