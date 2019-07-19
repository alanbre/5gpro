using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.StaticFiles;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCfgDadosEstabelecimento : Form
    {
        private readonly EstabelecimentoDAO estabelecimentoDAO = new EstabelecimentoDAO();
        private readonly Validacao validacao = new Validacao();

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCfgDadosEstabelecimento()
        {
            InitializeComponent();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("100100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

        private void FmCfgDadosEstabelecimento_Load(object sender, EventArgs e)
        {
            estabelecimentoDAO.Busca();
            PreencheDados();
            SetarNivel();
        }
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void TbNome_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbFantasia_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbRua_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbNumero_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbBairro_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbComplemento_TextChanged(object sender, EventArgs e) => Editando(true);
        private void BuscaCidade_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void MtbCpfCnpj_TextChanged(object sender, EventArgs e) => Editando(true);
        private void MtbTelefone_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbEmail_TextChanged(object sender, EventArgs e) => Editando(true);
        private void FmCfgDadosEstabelecimento_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);



        private void Salva()
        {
            if (!editando) return;
            

            Estabelecimento.Nome = tbNome.Text;
            Estabelecimento.Fantasia = tbFantasia.Text;
            Estabelecimento.Rua = tbRua.Text;
            Estabelecimento.Numero = tbNumero.Text;
            Estabelecimento.Bairro = tbBairro.Text;
            Estabelecimento.Complemento = tbComplemento.Text;
            Estabelecimento.Cidade = buscaCidade.cidade;
            Estabelecimento.CpfCnpj = mtbCpfCnpj.TextNoMask();
            Estabelecimento.Telefone = mtbTelefone.TextNoMask();
            Estabelecimento.Email = tbEmail.Text;

            int resultado = estabelecimentoDAO.SalvaOuAtualiza();
            if (resultado == 0)
            {
                MessageBox.Show("Problema ao salvar o registro",
                "Problema ao salvar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (resultado == 1)
            {
                tbAjuda.Text = "Dados salvos com sucesso";
                Editando(false);
                return;
            }
            else if (resultado == 2)
            {
                tbAjuda.Text = "Dados atualizados com sucesso";
                Editando(false);
                return;
            }

        }
        private void PreencheDados()
        {
            ignoraCheckEvent = true;
            tbNome.Text = Estabelecimento.Nome;
            tbFantasia.Text = Estabelecimento.Fantasia;
            tbRua.Text = Estabelecimento.Rua;
            tbNumero.Text = Estabelecimento.Numero;
            tbBairro.Text = Estabelecimento.Bairro;
            tbComplemento.Text = Estabelecimento.Complemento;
            mtbCpfCnpj.Text = Estabelecimento.CpfCnpj;
            mtbTelefone.Text = Estabelecimento.Telefone;
            tbEmail.Text = Estabelecimento.Email;
            buscaCidade.PreencheCampos(Estabelecimento.Cidade);
            ignoraCheckEvent = false;
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void Editando(bool edit)
        {
            if (!ignoraCheckEvent)
            {
                editando = edit;
                menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
            }
        }
    }
}
