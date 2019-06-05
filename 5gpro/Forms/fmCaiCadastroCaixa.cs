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
    public partial class fmCaiCadastroCaixa : Form
    {
        private Caixa caixa = null;
        private CaixaDAO caixaDAO = new CaixaDAO();
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
        int codigo = 0;

        public fmCaiCadastroCaixa()
        {
            InitializeComponent();
        }
        private void FmCaiCadastroCaixa_Load(object sender, EventArgs e) => SetarNivel();
        private void FmCaiCadastroCaixa_KeyDown(object sender, KeyEventArgs e)
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
        private void FmCaiCadastroCaixa_FormClosing(object sender, FormClosingEventArgs e)
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
        private void TbNome_TextChanged(object sender, EventArgs e) => Editando(true);
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
                codigo = caixaDAO.BuscaProxCodigoDisponivel();
                tbCodigo.Text = codigo.ToString();
                caixa = null;
                tbNome.Focus();
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

            var buscaCaixa = new fmCaiBuscaCaixa();
            buscaCaixa.ShowDialog();
            if (buscaCaixa.caixaSelecionada != null)
            {
                caixa = buscaCaixa.caixaSelecionada;
                codigo = caixa.CaixaID;
                PreencheCampos(caixa);
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
                codigo = caixaDAO.BuscaProxCodigoDisponivel();
                tbCodigo.Text = codigo.ToString();
            }
            var ok = false;

            caixa = new Caixa();
            caixa.CaixaID = int.Parse(tbCodigo.Text);
            caixa.Nome = tbNome.Text;
            caixa.Descricao = tbDescricao.Text;

            var controls = (ControlCollection)this.Controls;

            ok = validacao.ValidarEntidade(caixa, controls);
            if (!ok)
            {
                return;
            }

            validacao.despintarCampos(controls);

            int resultado = caixaDAO.SalvaOuAtualiza(caixa);
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

            var controls = (ControlCollection)this.Controls;
            validacao.despintarCampos(controls);

            if (caixa != null)
            {
                caixa = caixaDAO.Busca(caixa.CaixaID);
                PreencheCampos(caixa);
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

            var newCaixa = caixaDAO.Anterior(int.Parse(tbCodigo.Text));
            if (newCaixa == null)
            {
                return;
            }

            caixa = newCaixa;
            codigo = caixa.CaixaID;
            PreencheCampos(caixa);

            if (editando)
            {
                Editando(false);
            }

            var controls = (ControlCollection)this.Controls;
            validacao.despintarCampos(controls);
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

            var newCaixa = caixaDAO.Proximo(int.Parse(tbCodigo.Text));
            if (newCaixa == null)
            {
                return;
            }

            caixa = newCaixa;
            codigo = caixa.CaixaID;
            PreencheCampos(caixa);

            if (editando)
            {
                Editando(false);
            }

            var controls = (ControlCollection)this.Controls;
            validacao.despintarCampos(controls);
        }
        private void CarregaDados()
        {
            int c = 0;
            if (!int.TryParse(tbCodigo.Text, out c))
            {
                tbCodigo.Clear();
            }

            if (tbCodigo.Text.Length == 0 || c == 0)
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
                LimpaCampos(true);
                Editando(false);
                return;
            }

            if (codigo == c)
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
            codigo = c;

            var novaCaixa = caixaDAO.Busca(int.Parse(tbCodigo.Text));
            if (novaCaixa != null)
            {
                caixa = novaCaixa;
                codigo = caixa.CaixaID;
                PreencheCampos(caixa);
                Editando(false);
            }
            else
            {
                LimpaCampos(false);
                Editando(true);
            }
            var controls = (ControlCollection)this.Controls;
            validacao.despintarCampos(controls);
        }
        private void PreencheCampos(Caixa caixa)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = caixa.CaixaID.ToString();
            tbNome.Text = caixa.Nome;
            tbDescricao.Text = caixa.Descricao;
            this.caixa = caixa;
            ignoraCheckEvent = false;
        }
        private void LimpaCampos(bool limpaCodigo)
        {
            if (limpaCodigo) { tbCodigo.Clear(); }
            tbNome.Clear();
            tbDescricao.Clear();
            caixa = null;
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
            var Codpermissao = permissaoDAO.BuscarIDbyCodigo("090100").ToString();
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
