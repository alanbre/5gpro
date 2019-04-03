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
    public partial class fmCadastroGrupoUsuario : Form
    {
        GrupoUsuario grupousuario;
        GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
        PermissaoBLL permissaoBLL = new PermissaoBLL();
        PermissoesStruct permissoes = new PermissoesStruct();
        List<Permissao> listapermissoes = new List<Permissao>();
        Validacao validacao = new Validacao();

        bool editando = false;
        bool ignoraCheckEvent;

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
            popularPermissoes();

        }
        public void popularPermissoes()
        {

            listapermissoes = permissaoBLL.BuscaTodasPermissoes().Todas;

            dgvPermissoes.Rows.Clear();
            foreach(Permissao p in listapermissoes)
            {
                dgvPermissoes.Rows.Add(p.Codigo, p.Nome, "0");
            }
            dgvPermissoes.Refresh();


        }

        public void PopularModulos()
        {
            listapermissoes = permissaoBLL.BuscaTodasPermissoes().Modulos;


            foreach (Permissao p in listapermissoes)
            {
                dgvModulos.Rows.Add(p.Codigo, p.Nome);
            }
            dgvModulos.Refresh();

        }

        private void dgvModulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPermissoes_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        {
   
        }

        private void dgvPermissoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dois Clicks na linha para somar 1 no nivel, quando chegar a 3 o próximo valor será 0

            if (int.Parse(dgvPermissoes.CurrentRow.Cells[2].Value.ToString()) < 3)
            {
                dgvPermissoes.CurrentRow.Cells[2].Value = int.Parse(dgvPermissoes.CurrentRow.Cells[2].Value.ToString()) + 1;
            }
            else
            {
                dgvPermissoes.CurrentRow.Cells[2].Value = 0;
            }
        }

        ///CONSTRUINDO
        ///
        private void SalvaCadastro()
        {
            //Cria uma nova instancia de pessoa, seta as informações e tenta salvar.
            editando = true;//RETIRAR DEPOIS DE TESTAR//
            if (editando)
            {
                grupousuario = new GrupoUsuario();
                grupousuario.GrupoUsuarioID = int.Parse(tbCodGrupoUsuario.Text);
                grupousuario.Nome = tbNomeGrupoUsuario.Text;


                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(grupousuario, controls);

                if (ok)
                {
                    int resultado = grupousuarioBLL.SalvarOuAtualizarGrupoUsuario(grupousuario);
                    validacao.despintarCampos(controls);
                    //resultado 0 = nada foi inserido(houve algum erro)
                    //resultado 1 = foi inserido com sucesso
                    //resultado 2 = foi atualizado com sucesso
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {

        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {
            //PROVISÓRIO
            SalvaCadastro();
        }
    }
}
