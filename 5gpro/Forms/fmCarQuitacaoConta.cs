using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCarQuitacaoConta : Form
    {

        private List<ParcelaContaReceber> parcelasContaReceber;
        private static ConexaoDAO connection = new ConexaoDAO();
        private readonly ContaReceberDAO contaReceberDAO = new ContaReceberDAO(connection);
        private readonly ParcelaContaReceberDAO parcelaContaReceberDAO = new ParcelaContaReceberDAO(connection);
        private List<ParcelaContaReceber> parcelasContaReceberSelecionadas = new List<ParcelaContaReceber>();

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO(connection);
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO(connection);
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
        }

        public fmCarQuitacaoConta()
        {
            InitializeComponent();
            SetarNivel();
            DatasIniciais();
        }

        private void BtPesquisar_Click(object sender, EventArgs e) => Pesquisar();
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
                filtroDataVencimentoFinal = dtpDataVencimentoFinal.Value
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
            dbValorTotal.Valor = parcelasContaReceberSelecionadas.Sum(p => p.ValorFinal);
            lbTotal.Text = dbValorTotal.Valor.ToString("TOTAL: R$ ########0.00");
        }


        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("050200").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
        }
    }
}
