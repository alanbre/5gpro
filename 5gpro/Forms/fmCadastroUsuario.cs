using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroUsuario : Form
    {
        private Usuario usuario;

        private readonly UsuarioDAO usuarioDAO = new UsuarioDAO();
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly Validacao validacao = new Validacao();

        //Controle de Permissões
        private Logado logado;
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroUsuario()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("010200").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela

            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);

        }

        private void FmCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Recarrega();
                return;
            }

            if (e.KeyCode == Keys.F1)
            {
                if (!editando)
                {
                    Novo();
                }
                return;
            }

            if (e.KeyCode == Keys.F2)
            {
                if (editando)
                {
                    Salva();
                }
                return;
            }

            EnterTab(this.ActiveControl, e);
        }
        private void FmCadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!editando)
                return;

            if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            "Aviso de alteração",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void CbMostrarSenhaUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenhaUsuario.Checked)
            {
                tbSenhaUsuario.PasswordChar = '\0';
                tbConfirmaSenhaUsuario.PasswordChar = '\0';
            }
            else
            {
                tbSenhaUsuario.PasswordChar = '*';
                tbConfirmaSenhaUsuario.PasswordChar = '*';
            }

        }
        private void TbSenhaUsuario_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbConfirmaSenhaUsuario_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbNomeUsuario_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbSobrenomeUsuario_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbEmailUsuario_TextChanged(object sender, EventArgs e) => Editando(true);
        private void MtbTelefoneUsuario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) => Editando(true);
        private void TbCodigoUsuario_Leave(object sender, EventArgs e) => CarregaDados();
        private void TbSenhaUsuario_Leave(object sender, EventArgs e) => ConfirmaSenhas();
        private void TbConfirmaSenhaUsuario_Leave(object sender, EventArgs e) => ConfirmaSenhas();
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }



        private void Novo()
        {
            if (editando)
            {
                return;
            }
            if (Nivel > 1 || CodGrupoUsuario == "999")
            {
                ignoraCheckEvent = true;
                LimpaCampos(false);
                tbCodigoUsuario.Text = usuarioDAO.BuscaProxCodigoDisponivel().ToString();
                usuario = null;
                tbSenhaUsuario.Focus();
                ignoraCheckEvent = false;
                Editando(true);
            }

        }
        private void Busca()
        {
            if (CodGrupoUsuario != "999" && Nivel <= 0)
            {
                return;
            }

            if (editando)
            {
                return;
            }

            var buscaUsuario = new fmBuscaUsuario();
            buscaUsuario.ShowDialog();
            if (buscaUsuario.usuarioSelecionado != null)
            {
                usuario = buscaUsuario.usuarioSelecionado;
                PreencheCampos(usuario);
            }
        }
        private void Salva()
        {
            if (!editando)
            {
                return;
            }
            var ok = false;

            if (!ConfirmaSenhas())
            {
                MessageBox.Show("As senhas devem ser iguais",
                    "Senhas não conferem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbConfirmaSenhaUsuario.Focus();
                tbConfirmaSenhaUsuario.SelectAll();
                return;
            }

            if (tbCodigoUsuario.Text.Length <= 0)
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                "Aviso",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbCodigoUsuario.Text = usuarioDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
            }

            usuario = new Usuario();
            usuario.Senha = tbSenhaUsuario.Text;
            usuario.UsuarioID = int.Parse(tbCodigoUsuario.Text);
            usuario.Grupousuario = buscaGrupoUsuario.grupoUsuario;
            usuario.Nome = tbNomeUsuario.Text;
            usuario.Sobrenome = tbSobrenomeUsuario.Text;
            usuario.Email = tbEmailUsuario.Text;
            usuario.Telefone = mtbTelefoneUsuario.Text;


            var controls = (ControlCollection)this.Controls;
            ok = validacao.ValidarEntidade(usuario, controls);

            if (ok)
            {
                validacao.despintarCampos(controls);
                int resultado = usuarioDAO.Salvar(usuario);
                if (resultado == 0)
                {
                    MessageBox.Show("Problema ao salvar o registro",
                    "Problema ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
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
        }
        private void Recarrega()
        {
            if (tbCodigoUsuario.Text.Length <= 0)
            {
                return;
            }

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            if (usuario != null)
            {
                usuario = usuarioDAO.BuscaByID(usuario.UsuarioID);
                PreencheCampos(usuario);
                if (editando)
                {
                    Editando(false);
                }
            }
            else
            {
                ignoraCheckEvent = true;
                LimpaCampos(true);
                ignoraCheckEvent = false;
            }

        }
        private void Anterior()
        {
            if (tbCodigoUsuario.Text.Length <= 0)
            {
                return;
            }

            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            validacao.despintarCampos(controls);

            var newusuario = usuarioDAO.Anterior(int.Parse(tbCodigoUsuario.Text));
            if (newusuario != null)
            {
                usuario = newusuario;
                PreencheCampos(usuario);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void Proximo()
        {
            if (tbCodigoUsuario.Text.Length <= 0)
            {
                return;
            }

            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            validacao.despintarCampos(controls);

            var newusuario = usuarioDAO.Proximo(int.Parse(tbCodigoUsuario.Text));
            if (newusuario != null)
            {
                usuario = newusuario;
                PreencheCampos(usuario);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void CarregaDados()
        {
            int codigo = 0;
            if (!int.TryParse(tbCodigoUsuario.Text, out codigo)) { tbCodigoUsuario.Clear(); }
            if (usuario?.UsuarioID == codigo)
            {
                return;
            }

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?", "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            if (tbCodigoUsuario.Text.Length == 0)
            {
                LimpaCampos(true);
                Editando(false);
                return;
            }



            var newUsuario = usuarioDAO.BuscaByID(int.Parse(tbCodigoUsuario.Text));
            if (newUsuario != null)
            {
                usuario = newUsuario;
                PreencheCampos(usuario);
                Editando(false);
            }
            else
            {
                Editando(true);
                LimpaCampos(false);
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
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void LimpaCampos(bool limpaCodigo)
        {
            if (limpaCodigo) { tbCodigoUsuario.Clear(); }
            tbSenhaUsuario.Clear();
            tbConfirmaSenhaUsuario.Clear();
            buscaGrupoUsuario.Limpa();
            tbNomeUsuario.Clear();
            tbSobrenomeUsuario.Clear();
            tbEmailUsuario.Clear();
            mtbTelefoneUsuario.Clear();
            tbAjuda.Clear();
        }
        private bool ConfirmaSenhas()
        {
            lbConfirmaSenha.Visible = !tbSenhaUsuario.Text.Equals(tbConfirmaSenhaUsuario.Text);
            return tbSenhaUsuario.Text.Equals(tbConfirmaSenhaUsuario.Text);
        }
        private void PreencheCampos(Usuario usuario)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);

            tbCodigoUsuario.Text = usuario.UsuarioID.ToString();
            tbSenhaUsuario.Text = usuario.Senha;
            tbConfirmaSenhaUsuario.Text = usuario.Senha;
            buscaGrupoUsuario.PreencheCampos(usuario.Grupousuario);
            tbNomeUsuario.Text = usuario.Nome;
            tbSobrenomeUsuario.Text = usuario.Sobrenome;
            tbEmailUsuario.Text = usuario.Email;
            mtbTelefoneUsuario.Text = usuario.Telefone;

            ignoraCheckEvent = false;
        }
    }
}
