using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroGrupoItem : Form
    {

        static ConexaoDAO connection = new ConexaoDAO();
        GrupoItem grupoitem = null;
        GrupoItemDAO grupoitemDAO = new GrupoItemDAO(connection);
        Validacao validacao = new Validacao();
        PermissaoDAO permissaoDAO = new PermissaoDAO(connection);

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO(connection);
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroGrupoItem()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("010300").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

        private void FmCadastroGrupoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && Nivel > 1 || e.KeyCode == Keys.F1 && CodGrupoUsuario == "999")
            {
                NovoCadastro();
            }

            if (e.KeyCode == Keys.F2 && Nivel > 1 || e.KeyCode == Keys.F2 && CodGrupoUsuario == "999")
            {
                SalvaCadastro();
            }

            EnterTab(this.ActiveControl, e);
        }

        private void FmCadastroGrupoItem_Load(object sender, System.EventArgs e)
        {
            tbCodigo.Focus();
        }


        //EVENTOS DE TEXTCHANGED

        private void TbNomeGrupo_TextChanged(object sender, System.EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }


        //EVENTOS DE LEAVE

        private void TbCodigo_Leave(object sender, System.EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    GrupoItem newgrupoitem = grupoitemDAO.BuscarByID(int.Parse(tbCodigo.Text));
                    if (newgrupoitem != null)
                    {
                        grupoitem = newgrupoitem;
                        PreencheCampos(grupoitem);
                        Editando(false);
                    }
                    else
                    {
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodigo.Text.Length == 0)
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
                    if (tbCodigo.Text.Length > 0)
                    {
                        GrupoItem newgrupoitem = grupoitemDAO.BuscarByID(int.Parse(tbCodigo.Text));
                        if (newgrupoitem != null)
                        {
                            grupoitem = newgrupoitem;
                            PreencheCampos(grupoitem);
                            Editando(false);
                        }
                        else
                        {
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodigo.Text.Length == 0)
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
        }

        //MENU
        private void MiniMenuVertical_Novo_Clicked(object sender, System.EventArgs e)
        {
            NovoCadastro();
        }

        private void MiniMenuVertical_Buscar_Clicked(object sender, System.EventArgs e)
        {
            if (!editando || Nivel == 1)
            {
                AbreTelaBuscaGrupoItem();
            }
        }

        private void MiniMenuVertical_Salvar_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("Pressionou o SALVAR");
            SalvaCadastro();
        }

        private void MiniMenuVertical_Excluir_Clicked(object sender, System.EventArgs e)
        {

        }

        //PADRÕES CRIADAS
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void LimpaCampos(bool cod)
        {
            if (cod) { tbCodigo.Clear(); }
            tbNomeGrupo.Clear();
        }

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
                    tbCodigo.Text = grupoitemDAO.BuscaProxCodigoDisponivel();
                    grupoitem = null;
                    tbNomeGrupo.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigo.Text = grupoitemDAO.BuscaProxCodigoDisponivel();
                grupoitem = null;
                tbNomeGrupo.Focus();
                Editando(true);
            }
        }

        private void PreencheCampos(GrupoItem grupoitem)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = grupoitem.GrupoItemID.ToString();
            tbNomeGrupo.Text = grupoitem.Nome;

            ignoraCheckEvent = false;
        }

        private void Editando(bool edit)
        {
            editando = edit;
            miniMenuVertical.Editando(edit, Nivel, CodGrupoUsuario);
        }

        private void SalvaCadastro()
        {
            bool ok = false;

            if (tbCodigo.Text.Length > 0)
            {
                if (editando)
                {
                    grupoitem = new GrupoItem();

                    grupoitem.GrupoItemID = int.Parse(tbCodigo.Text);
                    grupoitem.Nome = tbNomeGrupo.Text;

                    ControlCollection controls = (ControlCollection)this.Controls;

                    ok = validacao.ValidarEntidade(grupoitem, controls);
                    if (ok) { validacao.despintarCampos(controls); }
                }
            }
            else
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                                    "Aviso",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbCodigo.Text = grupoitemDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
            }
            if (ok)
            {
                int resultado = grupoitemDAO.SalvarOuAtualizar(grupoitem);

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

        private void AbreTelaBuscaGrupoItem()
        {
            var buscaGrupoItem = new fmBuscaGrupoItem();
            buscaGrupoItem.ShowDialog();
            if (buscaGrupoItem.grupoitemSelecionado != null)
            {
                grupoitem = buscaGrupoItem.grupoitemSelecionado;
                PreencheCampos(grupoitem);
            }
        }

        private void TbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
