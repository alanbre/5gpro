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



        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void TbDescricao_TextChanged(object sender, EventArgs e) => Editando(true);




        private void Salva()
        {
            tvPlanoContas.Nodes.Add(tbDescricao.Text);
        }
        private void PreencheContas()
        {
            var pai1 = new PlanoConta();
            pai1.PlanoContaID = 1;
            pai1.Codigo = 1;
            pai1.Descricao = "Entradas";
            pai1.Level = 0;

            var pai2 = new PlanoConta();
            pai2.PlanoContaID = 2;
            pai2.Codigo = 2;
            pai2.Descricao = "Saidas";
            pai2.Level = 0;

            var pai3 = new PlanoConta();
            pai3.PlanoContaID = 8;
            pai3.Codigo = 3;
            pai3.Descricao = "Testes de pai";
            pai3.Level = 0;

            var filho = new PlanoConta();
            filho.PlanoContaID = 3;
            filho.Codigo = 1;
            filho.Descricao = "Entradas por compras";
            filho.Level = 1;
            filho.PaiID = 1;

            var neto = new PlanoConta();
            neto.PlanoContaID = 4;
            neto.Codigo = 1;
            neto.Descricao = "Entradas de boi";
            neto.Level = 2;
            neto.PaiID = 3;

            var filho2 = new PlanoConta();
            filho2.PlanoContaID = 5;
            filho2.Codigo = 2;
            filho2.Descricao = "Entradas por rendimentos";
            filho2.Level = 1;
            filho2.PaiID = 1;

            var neto2 = new PlanoConta();
            neto2.PlanoContaID = 6;
            neto2.Codigo = 2;
            neto2.Descricao = "Rendimentos brutos";
            neto2.Level = 2;
            neto2.PaiID = 5;

            var filho3 = new PlanoConta();
            filho3.PlanoContaID = 7;
            filho3.Codigo = 2;
            filho3.Descricao = "Saídas por vendas";
            filho3.Level = 1;
            filho3.PaiID = 2;


            planoContas.Add(pai1);
            planoContas.Add(filho3);
            planoContas.Add(pai2);
            planoContas.Add(pai3);
            planoContas.Add(filho);
            planoContas.Add(neto);
            planoContas.Add(filho2);
            planoContas.Add(neto2);

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
                root.Tag = null;
                foreach (var pc in planoConta.SubContas)
                {
                    var child = new TreeNode();
                    child.Text = $"- {pc.Descricao}";
                    child.Tag = pc.Codigo;
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
                    child.Tag = pc.Codigo;
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
