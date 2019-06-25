using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCaiPlanoContas : Form
    {
        private List<PlanoConta> planoContas = new List<PlanoConta>();
        private PlanoConta planoContaSelecionada = null;
        private readonly PlanoContaDAO planoContaDAO = new PlanoContaDAO();


        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;
        int codigo = 0;

        bool editando, ignoracheckevent = false;
        public fmCaiPlanoContas()
        {
            InitializeComponent();
            SetarNivel();
            PreencheContas();
        }



        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void TbDescricao_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TvPlanoContas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ignoracheckevent = true;
            Limpa(true);
            planoContaSelecionada = planoContas.First(pc => pc.PlanoContaID == (int)tvPlanoContas.SelectedNode.Tag);
            if (planoContaSelecionada == null) return;
            tbCodigo.Text = planoContaSelecionada.Codigo.ToString();
            tbDescricao.Text = planoContaSelecionada.Descricao;
            ignoracheckevent = false;
        }



        private void Novo()
        {
            if (editando || planoContaSelecionada == null)
                return;

            ignoracheckevent = true;
            Limpa(false);
            tbCodigoFilho.Text = planoContaDAO.BuscaProxCodigoDisponivel(planoContaSelecionada.PlanoContaID).ToString();
            tbDescricao.Focus();
            ignoracheckevent = false;
            Editando(true);
        }
        private void Salva()
        {
            if (!editando || planoContaSelecionada == null) return;

            if (tbDescricao.Text.Length == 0)
            {
                MessageBox.Show("Descrição não preenchida!",
               "Problema ao salvar",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);
                tbDescricao.Focus();
                return;
            }

            var resultado = 0;
            if (tbCodigoFilho.Text.Length > 0)
            {
                var planoContaFilho = new PlanoConta();
                planoContaFilho.Codigo = Convert.ToInt32(tbCodigoFilho.Text);
                planoContaFilho.Descricao = tbDescricao.Text;
                planoContaFilho.PaiID = planoContaSelecionada.PlanoContaID;
                planoContaFilho.Level = planoContaSelecionada.Level + 1;
                resultado = planoContaDAO.Salva(planoContaFilho);
            }
            else
            {
                planoContaSelecionada.Descricao = tbDescricao.Text;
                resultado = planoContaDAO.Atualiza(planoContaSelecionada);
            }

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
            }
            else if (resultado == 2)
            {
                tbAjuda.Text = "Dados atualizados com sucesso";
            }
            Limpa(true);
            PreencheContas();
            Editando(false);
        }
        private void PreencheContas()
        {
            tvPlanoContas.Nodes.Clear();
            planoContas = planoContaDAO.Busca();
            var pais = planoContas.Where(pc => pc.PaiID == 0).ToList();

            foreach (var pc in pais)
            {
                CarregarPlanosContasFilho(pc, planoContas);
            }

            foreach (var pc in pais)
            {
                TreeNode root = null;
                PreencherTreeView(ref root, pc);
                tvPlanoContas.Nodes.Add(root);
            }
        }
        private void CarregarPlanosContasFilho(PlanoConta pai, List<PlanoConta> planoContas)
        {
            List<PlanoConta> planosFilhos = planoContas.Where(pc => pc.PaiID == pai.PlanoContaID).ToList();
            pai.SubContas = planosFilhos;
            if (pai.SubContas.Count > 0)
            {
                foreach (var pc in pai.SubContas)
                {
                    CarregarPlanosContasFilho(pc, planoContas);
                }
            }
        }
        private void PreencherTreeView(ref TreeNode root, PlanoConta planoConta)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.Text = $"- {planoConta.Descricao}";
                root.Tag = planoConta.PlanoContaID;
                foreach (var pc in planoConta.SubContas)
                {
                    var child = new TreeNode();
                    child.Text = $"- {pc.Descricao}";
                    child.Tag = pc.PlanoContaID;
                    PreencherTreeView(ref child, pc);
                    root.Nodes.Add(child);
                }
            }
            else
            {
                foreach (var pc in planoConta.SubContas)
                {
                    var child = new TreeNode();
                    child.Text = $"- {pc.Descricao}";
                    child.Tag = pc.PlanoContaID;
                    PreencherTreeView(ref child, pc);
                    root.Nodes.Add(child);
                }
            }
        }
        private void Editando(bool edit)
        {
            if (!ignoracheckevent)
            {
                editando = edit;
                menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
            }
        }
        private void Limpa(bool limpaCodigo)
        {
            if (limpaCodigo) tbCodigo.Clear();
            tbCodigoFilho.Clear();
            tbDescricao.Clear();
        }
        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void FmCaiPlanoContas_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("090500").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
