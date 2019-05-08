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

        private IEnumerable<ContaReceber> contasReceber;
        private static ConexaoDAO connection = new ConexaoDAO();
        private readonly ContaReceberDAO contaReceberDAO = new ContaReceberDAO(connection);

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

            contasReceber = contaReceberDAO.Busca(f);
            dgvParcelas.Rows.Clear();
            foreach (var cr in contasReceber)
            {
                foreach(var par in cr.Parcelas)
                {
                    dgvParcelas.Rows.Add(cr.ContaReceberID,
                                         par.Sequencia,
                                         par.DataVencimento.Date,
                                         par.Valor,
                                         par.Multa,
                                         par.Juros,
                                         par.Acrescimo,
                                         par.ValorFinal,
                                         par.DataQuitacao?.Date);
                }
            }

            dgvParcelas.Refresh();
        }

        private void DatasIniciais()
        {
            dtpDataCadastroInicial.Value = DateTime.Today.AddDays(-30);
            dtpDataVencimentoInicial.Value = DateTime.Today.AddDays(-30);
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
