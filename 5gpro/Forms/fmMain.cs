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
            var formCadPessoas = new fmCadastroPessoa();
            formCadPessoas.Show(this);
            
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
