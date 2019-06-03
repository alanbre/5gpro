using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroUnimedida : Form
    {
        private Unimedida unimedida = null;
        private UnimedidaDAO unimedidaDAO = new UnimedidaDAO();

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando = false;
        bool ignoraCheckEvent;
        int codigo = 0;

        public fmCadastroUnimedida()
        {
            InitializeComponent();
        }

        private void FmCadastroUnimedida_Load(object sender, EventArgs e) => SetarNivel();
        private void FmCadastroUnimedida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Novo();
                return;
            }

            if (e.KeyCode == Keys.F2)
            {
                Salva();
                return;
            }

            if (e.KeyCode == Keys.F5)
            {
                Recarrega();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }
        private void FmCadastroUnimedida_FormClosing(object sender, FormClosingEventArgs e)
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
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void TbCodigo_Leave(object sender, EventArgs e) => CarregaDados();
        private void TbSigla_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbDescricao_TextChanged(object sender, EventArgs e) => Editando(true);



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
                codigo = unimedidaDAO.BuscaProxCodigoDisponivel();
                tbCodigo.Text = codigo.ToString();
                unimedida = null;
                tbSigla.Focus();
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

            var buscaUnimedida = new fmBuscaUnimedida();
            buscaUnimedida.ShowDialog();
            if(buscaUnimedida.unimedidaSelecionada != null)
            {
                unimedida = buscaUnimedida.unimedidaSelecionada;
                codigo = unimedida.UnimedidaID;
                PreencheCampos(unimedida);
            }
        }
        private void Salva()
        {
            if (!editando)
            {
                return;
            }

            if (tbCodigo.Text.Length <= 0)
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                "Aviso",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                codigo = unimedidaDAO.BuscaProxCodigoDisponivel();
                tbCodigo.Text = codigo.ToString();
            }

            unimedida = new Unimedida();
            unimedida.UnimedidaID = int.Parse(tbCodigo.Text);
            unimedida.Sigla = tbSigla.Text;
            unimedida.Descricao = tbDescricao.Text;

            int resultado = unimedidaDAO.SalvaOuAtualiza(unimedida);
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
        private void Recarrega()
        {
            if (tbCodigo.Text.Length <= 0)
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

            if (unimedida != null)
            {
                unimedida = unimedidaDAO.BuscaByID(unimedida.UnimedidaID);
                PreencheCampos(unimedida);
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
                Editando(false);
            }
        }
        private void Anterior()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            var newUnidadeMedida = unimedidaDAO.Anterior(int.Parse(tbCodigo.Text));
            if (newUnidadeMedida == null)
            {
                return;
            }

            unimedida = newUnidadeMedida;
            codigo = unimedida.UnimedidaID;
            PreencheCampos(unimedida);
            if (editando)
            {
                Editando(false);
            }
        }
        private void Proximo()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            var newUnidadeMedida = unimedidaDAO.Proximo(int.Parse(tbCodigo.Text));
            if (newUnidadeMedida == null)
            {
                return;
            }

            unimedida = newUnidadeMedida;
            codigo = unimedida.UnimedidaID;
            PreencheCampos(unimedida);
            if (editando)
            {
                Editando(false);
            }
        }
        private void CarregaDados()
        {
            int c;
            if (!int.TryParse(tbCodigo.Text, out c))
            {
                tbCodigo.Clear();
            }
            else
            {
                if (c != codigo)
                {
                    if (editando)
                    {
                        if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?", "Aviso de alteração",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    codigo = c;
                }
            }

            if(unimedida?.UnimedidaID == codigo)
            {
                return;
            }

            if (tbCodigo.Text.Length == 0)
            {
                LimpaCampos(true);
                Editando(false);
                return;
            }

            var novaUnidadeMedida = unimedidaDAO.BuscaByID(int.Parse(tbCodigo.Text));
            if (novaUnidadeMedida != null)
            {
                unimedida = novaUnidadeMedida;
                codigo = unimedida.UnimedidaID;
                PreencheCampos(unimedida);
                Editando(false);
            }
            else
            {
                Editando(true);
                LimpaCampos(false);
            }
        }
        private void PreencheCampos(Unimedida unimedida)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = unimedida.UnimedidaID.ToString();
            tbSigla.Text = unimedida.Sigla;
            tbDescricao.Text = unimedida.Descricao;
            ignoraCheckEvent = false;
        }
        private void LimpaCampos(bool limpaCodigo)
        {
            if (limpaCodigo) { tbCodigo.Clear(); }
            tbSigla.Clear();
            tbDescricao.Clear();
            unimedida = null;
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
        private void SetarNivel()
        {
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            var Codpermissao = permissaoDAO.BuscarIDbyCodigo("010700").ToString();
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

    }
}
