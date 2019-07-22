using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCaiPlanoContasPadrao : Form
    {

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando = false;
        bool ignoraCheckEvent;

        private readonly PlanoContaDAO planocontaDAO = new PlanoContaDAO();
        private PlanoContaPadraoDAO planocontapadraoDAO = new PlanoContaPadraoDAO();
        private PlanoContaPadrao planocontapadrao;

        public fmCaiPlanoContasPadrao()
        {
            InitializeComponent();
        }
        private void FmCaiPlanoContasPadrao_Load(object sender, EventArgs e)
        {
            SetarNivel();
            Carrega();
            Editando(false);
        }

        private void FmCaiPlanoContasPadrao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Salva();
                return;
            }

            if (e.KeyCode == Keys.F5)
            {
                //Recarrega();
                return;
            }
            EnterTab(this.ActiveControl, e);
        }

        private void FmCaiPlanoContasPadrao_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MiniMenuVertical1_Salvar_Clicked(object sender, EventArgs e) => Salva();

        private void MiniMenuVertical1_Recarregar_Clicked(object sender, EventArgs e)
        {
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
            Carrega();
            Editando(false);
        }

        private void MiniMenuVertical1_Excluir_Clicked(object sender, EventArgs e)
        {

        }

        private void Carrega()
        {
            planocontapadrao = planocontapadraoDAO.Busca();
            buscaCompras.PreencheCampos(planocontaDAO.BuscaByID(planocontapadrao.Compras.PlanoContaID));
            buscaContasPagar.PreencheCampos(planocontaDAO.BuscaByID(planocontapadrao.ContasPagar.PlanoContaID));
            buscaDescontosConcedidos.PreencheCampos(planocontaDAO.BuscaByID(planocontapadrao.DescontosConcedidos.PlanoContaID));
            buscaJurosPagos.PreencheCampos(planocontaDAO.BuscaByID(planocontapadrao.JurosPagos.PlanoContaID));

            buscaVendas.PreencheCampos(planocontaDAO.BuscaByID(planocontapadrao.Vendas.PlanoContaID));
            buscaContasReceber.PreencheCampos(planocontaDAO.BuscaByID(planocontapadrao.ContasReceber.PlanoContaID));
            buscaDescontosRecebidos.PreencheCampos(planocontaDAO.BuscaByID(planocontapadrao.DescontosRecebidos.PlanoContaID));
            buscaJurosRecebidos.PreencheCampos(planocontaDAO.BuscaByID(planocontapadrao.JurosRecebidos.PlanoContaID));

        }

        private void Salva()
        {
            planocontapadrao = new PlanoContaPadrao();

            planocontapadrao.Compras = buscaCompras.conta != null ? buscaCompras.conta : null;
            planocontapadrao.ContasPagar = buscaContasPagar.conta != null ? buscaContasPagar.conta : null;
            planocontapadrao.DescontosConcedidos = buscaDescontosConcedidos.conta != null ? buscaDescontosConcedidos.conta : null;
            planocontapadrao.JurosPagos = buscaJurosPagos.conta != null ? buscaJurosPagos.conta : null;

            planocontapadrao.Vendas = buscaVendas.conta != null ? buscaVendas.conta : null;
            planocontapadrao.ContasReceber = buscaContasReceber.conta != null ? buscaContasReceber.conta : null;
            planocontapadrao.DescontosRecebidos = buscaDescontosRecebidos.conta != null ? buscaDescontosRecebidos.conta : null;
            planocontapadrao.JurosRecebidos = buscaJurosRecebidos.conta != null ? buscaJurosRecebidos.conta : null;

            int resultado = planocontapadraoDAO.Salva(planocontapadrao);

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

        private void Editando(bool edit)
        {
            if (!ignoraCheckEvent)
            {
                editando = edit;
                miniMenuVertical1.Editando(edit, Nivel, CodGrupoUsuario);
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
            var Codpermissao = permissaoDAO.BuscarIDbyCodigo("090600").ToString();
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

        //EVENTOS DE TEXTCHANGED
        private void BuscaCompras_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaContasPagar_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaDescontosConcedidos_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaJurosPagos_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaVendas_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaContasReceber_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaDescontosRecebidos_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaJurosRecebidos_Text_Changed(object sender, EventArgs e) => Editando(true);

    }
}
