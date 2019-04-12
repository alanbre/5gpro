using _5gpro.Bll;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroUsuario : Form
    {
        Usuario usuario;
        GrupoUsuario grupousuario = new GrupoUsuario();
        GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        Validacao validacao = new Validacao();

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoBLL logadoBLL = new LogadoBLL();
        private readonly PermissaoBLL permissaoBLL = new PermissaoBLL();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;

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
            logado = logadoBLL.BuscaLogadoByMac(adap.Mac);
            string Codgrupousuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoBLL.BuscarIDbyCodigo("010200").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoBLL.BuscarNivelPermissao(Codgrupousuario, Codpermissao);
            Editando(editando);

        }

        private void FmCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }

        private void tbNomeGrupoUsuario_TextChanged(object sender, EventArgs e)
        {
            Editando(true);
        }

        private void fmCadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


        //Mostrar e ocultar campo senha
        private void cbMostrarSenhaUsuario_CheckedChanged(object sender, EventArgs e)
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


        //EVENTOS DE TEXTCHANGED
        private void tbSenhaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbConfirmaSenhaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void TbCodGrupoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbSobrenomeUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbEmailUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void mtbTelefoneUsuario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }


        //EVENTOS DE LEAVE
        private void tbCodigoUsuario_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigoUsuario.Text, out int codigo)) { tbCodigoUsuario.Clear(); }
            if (!editando)
            {
                if (tbCodigoUsuario.Text.Length > 0)
                {
                    Usuario newusuario = usuarioBLL.BuscarUsuarioById(int.Parse(tbCodigoUsuario.Text));
                    if (newusuario != null)
                    {
                        usuario = newusuario;
                        PreencheCampos(usuario);
                        Editando(false);
                    }
                    else
                    {
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodigoUsuario.Text.Length == 0)
                {
                    LimpaCampos(true);
                    Editando(false);
                }
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbCodigoUsuario.Text.Length > 0)
                    {
                        Usuario newusuario = usuarioBLL.BuscarUsuarioById(int.Parse(tbCodigoUsuario.Text));
                        if (newusuario != null)
                        {
                            usuario = newusuario;
                            PreencheCampos(usuario);
                            Editando(false);
                        }
                        else
                        {
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodigoUsuario.Text.Length == 0)
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
        }

        private void tbSenhaUsuario_Leave(object sender, EventArgs e)
        {
            if(tbConfirmaSenhaUsuario.TextLength > 0)
            {
                ConfirmaSenhas();
            }
        }

        private void tbConfirmaSenhaUsuario_Leave(object sender, EventArgs e)
        {
            ConfirmaSenhas();
        }


        //EVENTOS DE CLICK
        private void btGrupoUsuario_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaGrupoUsuario();
        }


        //MENU
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e)
        {
            if (!editando || Nivel == 1)
            {
                AbreTelaBuscaUsuario();
            }
        }

        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e)
        {
            RecarregaDados(usuario);
        }

        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e)
        {
            CadastroAnterior();
        }

        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }



        //PADRÕES CRIADAS
        private void NovoCadastro()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LimpaCampos(false);
                    tbCodigoUsuario.Text = usuarioBLL.BuscaProxCodigoDisponivel();
                    usuario = null;
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigoUsuario.Text = usuarioBLL.BuscaProxCodigoDisponivel();
                usuario = null;
                Editando(true);
            }
        }

        private void SalvaCadastro()
        {
            //Cria uma nova instancia de pessoa, seta as informações e tenta salvar.

            if (editando)
            {
                usuario = new Usuario();

                if (ConfirmaSenhas() == true)
                {
                    usuario.Senha = tbSenhaUsuario.Text;
                }
                else
                {
                    MessageBox.Show("As senhas devem ser iguais",
                        "Senhas não conferem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    tbConfirmaSenhaUsuario.Focus();
                    tbConfirmaSenhaUsuario.SelectAll();
                    return;
                }

                usuario.UsuarioID = int.Parse(tbCodigoUsuario.Text);
                usuario.Grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(buscaGrupoUsuario.grupoUsuario.GrupoUsuarioID);
                usuario.Nome = tbNomeUsuario.Text;
                usuario.Sobrenome = tbSobrenomeUsuario.Text;
                usuario.Email = tbEmailUsuario.Text;
                usuario.Telefone = mtbTelefoneUsuario.Text;


                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(usuario, controls);

                if (ok)
                {
                    int resultado = usuarioBLL.SalvarOuAtualizarUsuario(usuario);
                    validacao.despintarCampos(controls);
                    // resultado 0 = nada foi inserido (houve algum erro)
                    // resultado 1 = foi inserido com sucesso
                    // resultado 2 = foi atualizado com sucesso
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
                    }
                    else if (resultado == 2)
                    {
                        tbAjuda.Text = "Dados atualizados com sucesso";
                        Editando(false);
                    }
                }
            }
        }

        private void AbreTelaBuscaUsuario()
        {
            var buscaUsuario = new fmBuscaUsuario();
            buscaUsuario.ShowDialog();
            if (buscaUsuario.usuarioSelecionado != null)
            {
                usuario = buscaUsuario.usuarioSelecionado;
                PreencheCampos(usuario);
            }
        }

        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit, Nivel);
        }

        private void RecarregaDados(Usuario usuario)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (usuario != null)
                    {
                        usuario = usuarioBLL.BuscarUsuarioById(usuario.UsuarioID);
                        PreencheCampos(usuario);
                        Editando(false);
                    }
                    else
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
            else
            {
                if (usuario != null)
                {
                    usuario = usuarioBLL.BuscarUsuarioById(usuario.UsuarioID);
                    PreencheCampos(usuario);
                }
                else
                {
                    LimpaCampos(true);
                }
                Editando(false);
            }

        }

        private void ProximoCadastro()
        {
            //Busca o usuario com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se pessoa existe. Se não existir busca o maior anterior ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigoUsuario.Text.Length > 0)
            {

                validacao.despintarCampos(controls);

                Usuario newusuario = usuarioBLL.BuscarProximoUsuario(tbCodigoUsuario.Text);
                if (newusuario != null)
                {
                    usuario = newusuario;
                    PreencheCampos(usuario);
                }
            }
            else if (editando && tbCodigoUsuario.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    Usuario newusuario = usuarioBLL.BuscarProximoUsuario(tbCodigoUsuario.Text);
                    if (newusuario != null)
                    {
                        usuario = newusuario;
                        PreencheCampos(usuario);
                        Editando(false);
                    }
                    else
                    {
                        newusuario = usuarioBLL.BuscarUsuarioAnterior(tbCodigoUsuario.Text);
                        if (newusuario != null)
                        {
                            usuario = newusuario;
                            PreencheCampos(usuario);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void CadastroAnterior()
        {
            //Busca o usuário com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            //Caso não houver registro com ID menor, verifica se pessoa existe. Se não existir busca o proximo ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigoUsuario.Text.Length > 0)
            {


                validacao.despintarCampos(controls);
                Usuario newusuario = usuarioBLL.BuscarUsuarioAnterior(tbCodigoUsuario.Text);
                if (newusuario != null)
                {
                    usuario = newusuario;
                    PreencheCampos(usuario);
                }
            }
            else if (editando && tbCodigoUsuario.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    Usuario newusuario = usuarioBLL.BuscarUsuarioAnterior(tbCodigoUsuario.Text);
                    if (newusuario != null)
                    {
                        usuario = newusuario;
                        PreencheCampos(usuario);
                        Editando(false);
                    }
                    else
                    {
                        newusuario = usuarioBLL.BuscarProximoUsuario(tbCodigoUsuario.Text);
                        if (newusuario != null)
                        {
                            usuario = newusuario;
                            PreencheCampos(usuario);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void AbreTelaBuscaGrupoUsuario()
        {
            var buscaGrupoUsuario = new fmBuscaGrupoUsuario();
            buscaGrupoUsuario.ShowDialog();
            if (buscaGrupoUsuario.grupousuarioSelecionado != null)
            {
                grupousuario = buscaGrupoUsuario.grupousuarioSelecionado;
                PreencheCamposGrupoUsuario(grupousuario);
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

            if (usuario.Grupousuario != null)
            {
                grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(buscaGrupoUsuario.grupoUsuario.GrupoUsuarioID);
                PreencheCamposGrupoUsuario(grupousuario);
            }

            ignoraCheckEvent = false;
        }

        private void FmCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void PreencheCamposGrupoUsuario(GrupoUsuario grupousuario)
        {
            if (grupousuario != null)
            {
                buscaGrupoUsuario.PreencheCampos(grupousuario);
            }
            else
            {
                MessageBox.Show("Grupo de usuários não encontrado no banco de dados",
                "Grupo de usuários não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                buscaGrupoUsuario.Focus();
            }
        }
    }
}
