using _5gpro.Bll;
using _5gpro.Entities;
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
    public partial class fmCadastroGrupoUsuario : Form
    {
        PermissaoBLL permissaoBLL = new PermissaoBLL();
        PermissoesStruct permissoes = new PermissoesStruct();
        List<Permissao> listapermissoes = new List<Permissao>();

        public struct PermissoesStruct
        {
            public List<Permissao> Todas;
            public List<Permissao> Modulos;
            public List<Permissao> Telas;
            public List<Permissao> Funcoes;

        }

        public fmCadastroGrupoUsuario()
        {
            InitializeComponent();
        }

        private void fmCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            PopularModulos();

        }

        public void PopularModulos()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Código", typeof(string));
            table.Columns.Add("Nome", typeof(string));

            listapermissoes = permissaoBLL.BuscaTodasPermissoes().Modulos;
           
            foreach (Permissao p in listapermissoes)
            {
                table.Rows.Add(p.PermissaoId, p.Nome);
            }
            dgvModulos.DataSource = table;

        }
    }
}
