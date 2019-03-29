using _5gpro.Bll;
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
    public partial class fmCadastroUsuario : Form
    {
        Usuario usuario;
        GrupoUsuario grupousuario = new GrupoUsuario();
        GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        Validacao validacao = new Validacao();

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroUsuario()
        {
            InitializeComponent();
            AlteraBotoes();  //ALTERA BOTÕES PARA CERTIFICAR QUE VÃO ESTAR CORRETOS AO ABRIR A TELA

            tbSenhaUsuario.UseSystemPasswordChar = true;  //Iniciar com senha oculta
            tbConfirmaSenhaUsuario.UseSystemPasswordChar = true;

        }

        private void tbNomeGrupoUsuario_TextChanged(object sender, EventArgs e)
        {

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
            tbLoginUsuario.Clear();
            tbSenhaUsuario.Clear();
            tbConfirmaSenhaUsuario.Clear();
            tbCodGrupoUsuario.Clear();
            tbNomeGrupoUsuario.Clear();
            tbNomeUsuario.Clear();
            tbSobrenomeUsuario.Clear();
            tbEmailUsuario.Clear();
            mtbTelefoneUsuario.Clear();
            tbAjuda.Clear();
        }

        private void PreencheCampos(Usuario usuario)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);

            tbLoginUsuario.Text = usuario.Login;
            tbSenhaUsuario.Text = usuario.Senha;
            tbConfirmaSenhaUsuario.Text = usuario.Senha;
            tbCodGrupoUsuario.Text = usuario.Grupousuario.Codigo;
            tbNomeUsuario.Text = usuario.Nome;
            tbSobrenomeUsuario.Text = usuario.Sobrenome;
            tbEmailUsuario.Text = usuario.Email;
            mtbTelefoneUsuario.Text = usuario.Telefone;

            if (usuario.Grupousuario != null)
            {
                grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByCod(tbCodGrupoUsuario.Text);
                PreencheCamposGrupoUsuario(grupousuario);
            }


            ignoraCheckEvent = false;
        }

        private void PreencheCamposGrupoUsuario(GrupoUsuario grupousuario)
        {
            if (grupousuario != null)
            {
                tbCodGrupoUsuario.Text = grupousuario.Codigo;
                tbNomeGrupoUsuario.Text = grupousuario.Nome;
            }
            else
            {
                MessageBox.Show("Grupo de usuários não encontrado no banco de dados",
                "Grupo de usuários não encontrado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                tbCodGrupoUsuario.Focus();
                tbNomeGrupoUsuario.SelectAll();
            }
        }

        //Mostrar e ocultar campo senha
        private void cbMostrarSenhaUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenhaUsuario.Checked)
            {
                tbSenhaUsuario.UseSystemPasswordChar = false;
                tbConfirmaSenhaUsuario.UseSystemPasswordChar = false;
            }
            else
            {
                tbSenhaUsuario.UseSystemPasswordChar = true;
                tbConfirmaSenhaUsuario.UseSystemPasswordChar = true;
            }

        }

        private void SalvaCadastro()
        {
            //Cria uma nova instancia de pessoa, seta as informações e tenta salvar.
            if (editando)
            {

                usuario = new Usuario();
                usuario.Codigo = tbCodigoUsuario.Text;
                usuario.Login = tbLoginUsuario.Text;
                usuario.Senha = tbConfirmaSenhaUsuario.Text;
                usuario.Grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByCod(tbCodGrupoUsuario.Text);
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
                    tbLoginUsuario.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigoUsuario.Text = usuarioBLL.BuscaProxCodigoDisponivel();
                usuario = null;
                tbLoginUsuario.Focus();
                Editando(true);
            }
        }

        private void AbreTelaBuscaGrupoUsuario()
        {
            var buscaGrupoUsuario = new fmBuscaGrupoUsuario();
            buscaGrupoUsuario.ShowDialog();
            //if (buscaPessoa.pessoaSelecionada != null)
            //{
            //    pessoa = buscaPessoa.pessoaSelecionada;
            //    PreencheCampos(pessoa);
            //}
        }

        //Botões principais
        private void AlteraBotoes()
        {
            if (editando)
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_black;
                btNovo.Enabled = false;
                btSalvar.Image = Properties.Resources.iosOk_48px_Green;
                btSalvar.Enabled = true;
                btBuscar.Image = Properties.Resources.iosSearch_48px_black;
                btBuscar.Enabled = false;
                btDeletar.Image = Properties.Resources.iosDelete_48px_black;
                btDeletar.Enabled = false;
            }
            else
            {
                btNovo.Image = Properties.Resources.iosPlus_48px_blue;
                btNovo.Enabled = true;
                btSalvar.Image = Properties.Resources.iosOk_48px_black;
                btSalvar.Enabled = false;
                btBuscar.Image = Properties.Resources.iosSearch_48px_Blue;
                btBuscar.Enabled = true;
                btDeletar.Image = Properties.Resources.iosDelete_48px_Red;
                btDeletar.Enabled = false;
            }
        }

        private void Editando(bool edit)
        {
            editando = edit;
            AlteraBotoes();
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
                        usuario = usuarioBLL.BuscarUsuarioById(usuario.Codigo);
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
                    usuario = usuarioBLL.BuscarUsuarioById(usuario.Codigo);
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



        //EVENTOS DE TEXTCHANGED
        private void tbLoginUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbSenhaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbConfirmaSenhaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbCodUsuario_TextChanged(object sender, EventArgs e)
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


        //EVENTOS DE LEAVE
        private void tbCodigoUsuario_Leave(object sender, EventArgs e)
        {
            tbCodigoUsuario.Text = tbCodigoUsuario.Text == "0" ? "" : tbCodigoUsuario.Text;
            if (!editando)
            {
                if (tbCodigoUsuario.Text.Length > 0)
                {
                    Usuario newusuario = usuarioBLL.BuscarUsuarioById(tbCodigoUsuario.Text);
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
                        Usuario newusuario = usuarioBLL.BuscarUsuarioById(tbCodigoUsuario.Text);
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

        private void tbCodGrupoUsuario_Leave(object sender, EventArgs e)
        {
            if (tbCodGrupoUsuario.Text.Length > 0)
            {
                grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByCod(tbCodGrupoUsuario.Text);
                PreencheCamposGrupoUsuario(grupousuario);
            }
            else
            {
                tbNomeGrupoUsuario.Text = "";
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                AbreTelaBuscaUsuario();
            }
        }
    }
}
