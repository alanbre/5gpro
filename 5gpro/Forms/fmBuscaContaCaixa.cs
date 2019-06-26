using _5gpro.Daos;
using _5gpro.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmBuscaContaCaixa : Form
    {
        private List<PlanoConta> planoContas = new List<PlanoConta>();
        public PlanoConta planoContaSelecionada = null;
        private readonly PlanoContaDAO planoContaDAO = new PlanoContaDAO();
        bool entrada, saida;

        public fmBuscaContaCaixa(bool entrada = true, bool saida = true)
        {
            InitializeComponent();
            entradasaida(entrada, saida);
            PreencheContas();
        }

        private void entradasaida(bool entradarecebida, bool saidarecebida)
        {
            entrada = entradarecebida;
            saida = saidarecebida;
        }

        private void PreencheContas()
        {
            tvPlanoContas.Nodes.Clear();
            planoContas = planoContaDAO.Busca(entrada, saida);
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

        private void BtOk_Click(object sender, EventArgs e)
        {
            planoContaSelecionada = planoContas.First(pc => pc.PlanoContaID == (int)tvPlanoContas.SelectedNode.Tag);
            if (planoContaSelecionada == null) return;
            this.Close();
        }

        private void TvPlanoContas_DoubleClick(object sender, EventArgs e)
        {
            planoContaSelecionada = planoContas.First(pc => pc.PlanoContaID == (int)tvPlanoContas.SelectedNode.Tag);
            if (planoContaSelecionada == null) return;
            this.Close();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
