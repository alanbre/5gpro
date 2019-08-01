using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.StaticFiles;
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

        private int Nivel;
        private string CodGrupoUsuario;

        bool editando, ignoracheckevent = false;
        public fmCaiPlanoContas()
        {
            InitializeComponent();
            SetarNivel();
            PreencheContas();
        }

        private void FmCaiPlanoContas_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
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



            if (string.IsNullOrWhiteSpace(tbDescricao.Text))
            {
                MessageBox.Show("Descrição não preenchida!",
               "Problema ao salvar",
               MessageBoxButtons.OK,
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
        private void Anterior()
        {
            TreeNode tn = tvPlanoContas.SelectedNode;
            if (tn == null) return;
            if (tn.Parent == null)
            {
                if (tn.PrevNode == null)
                {
                    tvPlanoContas.Focus();
                    return;
                }
                TreeNode last = tvPlanoContas.Nodes[tn.Index - 1] ?? tvPlanoContas.SelectedNode;
                while (last.LastNode != null)
                {
                    last = last.LastNode;
                }
                tvPlanoContas.SelectedNode = last;
            }
            else
            {
                if (tn.PrevNode != null)
                {
                    tvPlanoContas.SelectedNode = tn.PrevNode.LastNode ?? tn.PrevNode;
                }
                else
                {
                    tvPlanoContas.SelectedNode = tn.Parent ?? (tn.Parent.PrevNode ?? tn.Parent);
                }
            }
            tvPlanoContas.Focus();
        }
        private void Proximo()
        {
            TreeNode tn = tvPlanoContas.SelectedNode;
            if (tn != null)
            {
                if (tn.Parent == null)
                {
                    if (tn.FirstNode != null)
                    {
                        tvPlanoContas.SelectedNode = tn.FirstNode;
                    }
                    else
                    {
                        if (tn.NextNode != null)
                        {
                            tvPlanoContas.SelectedNode = tn.NextNode;
                        }
                    }
                }
                else
                {
                    if (tn.FirstNode != null)
                    {
                        tvPlanoContas.SelectedNode = tn.FirstNode;
                    }
                    else
                    {
                        if (tn.NextNode != null)
                        {
                            tvPlanoContas.SelectedNode = tn.NextNode;
                        }
                        else
                        {
                            if (tn.Parent.NextNode != null)
                            {
                                tvPlanoContas.SelectedNode = tn.Parent.NextNode;
                            }
                            else
                            {
                                while (tn.NextNode == null)
                                {
                                    if (tn.Parent == null)
                                    {
                                        break;
                                    }
                                    tn = tn.Parent;
                                }
                                tvPlanoContas.SelectedNode = tn.NextNode;
                            }
                        }
                    }
                }
                tvPlanoContas.Focus();
            }
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
                root.Text = $"{planoConta.CodigoCompleto} - {planoConta.Descricao}";
                root.Tag = planoConta.PlanoContaID;
                foreach (var pc in planoConta.SubContas)
                {
                    var child = new TreeNode();
                    child.Text = $"{pc.CodigoCompleto} - {pc.Descricao}";
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
                    child.Text = $"{pc.CodigoCompleto} - {pc.Descricao}";
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
        private void SetarNivel()
        {
            CodGrupoUsuario = Logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            Nivel = Logado.Usuario.Grupousuario.Permissoes.Find(p => p.Codigo == "090500").Nivel;
            Editando(editando);
        }
    }
}
