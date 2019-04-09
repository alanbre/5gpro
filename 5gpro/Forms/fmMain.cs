using _5gpro.Bll;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Forms;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
            FiltroDePermissoes();

        }

        private Permissao permissao = new Permissao();
        private PermissaoBLL permissaoBLL = new PermissaoBLL();
        private Logado logado = new Logado();
        private LogadoBLL logadoBLL = new LogadoBLL();
        private NetworkAdapter adap = new NetworkAdapter();
        private int Nivel = 0;

        private void FiltroDePermissoes()
        {
            logado = logadoBLL.BuscaLogadoByMac(adap.Mac);
            List<Permissao> listapermissoes = permissaoBLL.BuscarListaPermissoesByCodGrupo(logado.Usuario.Grupousuario.GrupoUsuarioID.ToString());

            if (logado.Usuario.Grupousuario.GrupoUsuarioID == 999)
            {
                cadastroDeGrupoDeUsuáriosToolStripMenuItem.Visible = true;
            }
        }

        private void tsmiCadastroPessoas_Click(object sender, EventArgs e)
        {
            //CÓDIGO TELA CADASTRO DE PESSOA : 010100

            logado = logadoBLL.BuscaLogadoByMac(adap.Mac);
            string Codgrupousuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoBLL.BuscarIDbyCodigo("010100").ToString();

            //Aqui busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoBLL.BuscarNivelPermissao(Codgrupousuario, Codpermissao);

            if (Nivel > 0)
            {
                var formCadPessoas = new fmCadastroPessoa();
                formCadPessoas.Show(this);
            }
            else
            {
                MessageBox.Show("Você não tem permissao",
                "Acesso Negado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        
            
        }

        private void tsmiCadastroPaises_Click(object sender, EventArgs e)
        {
            var formCadPais = new fmCadastroPais();
            formCadPais.Show(this);
        }

        private void tsmiCadastroItens_Click(object sender, EventArgs e)
        {
            var formCadItens = new fmCadastroItem();
            formCadItens.Show(this);
        }

        private void tsmiCadastroOrcamentos_Click(object sender, EventArgs e)
        {
            var formOrcamentoCadOrcamentos = new fmOrcamentoCadastroOrcamento();
            formOrcamentoCadOrcamentos.Show(this);
        }

        private void tsmiCadastroUsuariosMenuItem_Click(object sender, EventArgs e)
        {
            var formCadUsuarios = new fmCadastroUsuario();
            formCadUsuarios.Show(this);
        }

        private void tsmiEmissaoNF_Click(object sender, EventArgs e)
        {
            var formSaidaEmissaoNota = new fmSaidaEmissaoNota();
            formSaidaEmissaoNota.Show(this);
        }

        private void cadastroDeGrupoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCadGrupoUsuarios = new fmCadastroGrupoUsuario();
            formCadGrupoUsuarios.Show(this);
        }

        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Retira usuário da tabela Logado
            logadoBLL.RemoverLogado(adap.Mac);
        }
    }
}
