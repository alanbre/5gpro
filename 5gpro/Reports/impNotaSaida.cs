using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.StaticFiles;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.Windows.Forms;

namespace _5gpro.Reports
{
    public partial class impNotaSaida : Form
    {
        private FuncoesAuxiliares fa = new FuncoesAuxiliares();
        private DataTable _dados = new DataTable();
        private NotaFiscalPropria _notaFiscalPropria;

        public impNotaSaida(DataTable dados, NotaFiscalPropria notaFiscalPropria)
        {
            InitializeComponent();
            _dados = fa.DeepCopy(dados);
            _notaFiscalPropria = notaFiscalPropria;
        }

        private void ImpNotaSaida_Load(object sender, System.EventArgs e)
        {
            _dados.TableName = "Nota saída";
            this.rvNotaSaida.LocalReport.DisplayName = "Nota de saída";
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"razaosocial", Estabelecimento.Nome, true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"endereco", $"{Estabelecimento.Rua}, {Estabelecimento.Numero} {Estabelecimento.Complemento} - {Estabelecimento.Bairro}", true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"telefone", fa.FormataTel(Estabelecimento.Telefone), true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"email", fa.FormataTel(Estabelecimento.Email), true));

            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"numero", _notaFiscalPropria.NotaFiscalPropriaID.ToString(), true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_cod", _notaFiscalPropria.Pessoa.PessoaID.ToString(), true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_nome", _notaFiscalPropria.Pessoa.Nome.ToString(), true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_endereco", _notaFiscalPropria.Pessoa.Rua + _notaFiscalPropria.Pessoa.Numero, true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_cidade", _notaFiscalPropria.Pessoa.Cidade.Nome, true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_bairro", _notaFiscalPropria.Pessoa.Bairro, true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_cep", _notaFiscalPropria.Pessoa.Cep, true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_email", _notaFiscalPropria.Pessoa.Email, true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_doc", _notaFiscalPropria.Pessoa.TipoPessoa == "F"
                                                                                         ? fa.FormataCPF(_notaFiscalPropria.Pessoa.CpfCnpj)
                                                                                         : fa.FormataCNPJ(_notaFiscalPropria.Pessoa.CpfCnpj), true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_uf", _notaFiscalPropria.Pessoa.Cidade.Estado.Uf, true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"cliente_telefone", fa.FormataTel(_notaFiscalPropria.Pessoa.Telefone), true));
            this.rvNotaSaida.LocalReport.SetParameters(new ReportParameter($"data_saida", _notaFiscalPropria.DataEntradaSaida.ToString(), true));

            this.rvNotaSaida.LocalReport.DataSources.Add(new ReportDataSource("itens", _dados));
            this.rvNotaSaida.SetDisplayMode(DisplayMode.PrintLayout);

            this.rvNotaSaida.RefreshReport();
        }
    }
}
