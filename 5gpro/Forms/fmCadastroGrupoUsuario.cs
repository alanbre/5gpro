using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.StaticFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroGrupoUsuario : Form
    {
        //CÓDIGO DA TELA CAD.GRUPO USUARIO = 010400

        private GrupoUsuario grupousuario;
        private readonly GrupoUsuarioDAO grupousuarioDAO = new GrupoUsuarioDAO();
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();
        private List<Permissao> listapermissoes = new List<Permissao>();
        private readonly Validacao validacao = new Validacao();
        int NivelTodas = 0;

        //Controle de permissões
        //private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando, ignoraCheckEvent = false;
        int codigo = 0;

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
            PopularListapermissoes();
            SetarNivel();

        }

        private void SetarNivel()
        {
            CodGrupoUsuario = Logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            Nivel = Logado.Usuario.Grupousuario.Permissoes.Find(p => p.Codigo == "010400").Nivel;
            Editando(editando); 
        }

        private void FmCadastroGrupoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }
        private void FmCadastroGrupoUsuario_FormClosing(object sender, FormClosingEventArgs e)
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
        private void FmCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            PopularModulos();
            PopularPermissoes();

        }
        private void TbNomeGrupoUsuario_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbCodGrupoUsuario_Leave(object sender, EventArgs e) => CarregaDados();
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void DgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLICKAR UMA FILTRA AS PERMISSOES POR MÓDULO, COMPARANDO
            //OS 2 PRIMEIROS NÚMEROS DO CÓDIGO DO MÓDULO COM OS 2 PRIMEIROS
            //NÚMEROS DO CÓDIGO DA PERMISSÃO

            if (dgvModulos.CurrentRow.Cells[0].Value.ToString() != "000000")
            {
                PopularPermissoesByCodModulo(dgvModulos.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                PopularPermissoes();
            }

        }
        private void DgvModulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tbCodGrupoUsuario.Text.Length <= 0)
            {
                return;
            }


            if (dgvModulos.CurrentRow.Cells[0].Value.ToString() != "000000")
            {

                if (MessageBox.Show("Deseja alterar TODAS as permissões do Módulo " + dgvModulos.CurrentRow.Cells[1].Value.ToString() + " ?",
                                    "Aviso de alteração",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                if (int.Parse(dgvModulos.CurrentRow.Cells[2].Value.ToString()) < 3)
                {
                    dgvModulos.CurrentRow.Cells[2].Value = int.Parse(dgvModulos.CurrentRow.Cells[2].Value.ToString()) + 1;
                }
                else
                {
                    dgvModulos.CurrentRow.Cells[2].Value = 0;
                }

                foreach (Permissao p in listapermissoes)
                {
                    if (p.Codigo.Substring(0, 2) == dgvModulos.CurrentRow.Cells[0].Value.ToString().Substring(0, 2))
                    {
                        p.Nivel = Convert.ToInt32(dgvModulos.CurrentRow.Cells[2].Value);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Deseja alterar TODAS as permissões de TODOS os MÓDULOS" + " ?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                if (int.Parse(dgvModulos.CurrentRow.Cells[2].Value.ToString()) < 3)
                {
                    dgvModulos.CurrentRow.Cells[2].Value = int.Parse(dgvModulos.CurrentRow.Cells[2].Value.ToString()) + 1;
                }
                else
                {
                    dgvModulos.CurrentRow.Cells[2].Value = 0;
                }

                foreach (Permissao p in listapermissoes)
                {
                    p.Nivel = Convert.ToInt32(dgvModulos.CurrentRow.Cells[2].Value);
                }
                NivelTodas = int.Parse(dgvModulos.CurrentRow.Cells[2].Value.ToString());


            }
            PopularPermissoesByCodModulo(dgvModulos.CurrentRow.Cells[0].Value.ToString());
            PopularModulos();
            Editando(true);
        }
        private void DgvPermissoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dois Clicks na linha para somar 1 no nivel, quando chegar a 3 o próximo valor será 0
            if (tbCodGrupoUsuario.Text.Length <= 0)
            {
                return;
            }

            if (int.Parse(dgvPermissoes.CurrentRow.Cells[2].Value.ToString()) < 3)
            {
                dgvPermissoes.CurrentRow.Cells[2].Value = int.Parse(dgvPermissoes.CurrentRow.Cells[2].Value.ToString()) + 1;
            }
            else
            {
                dgvPermissoes.CurrentRow.Cells[2].Value = 0;
            }

            listapermissoes.Find(l => l.Codigo == dgvPermissoes.CurrentRow.Cells[0].Value.ToString()).Nivel = Convert.ToInt32(dgvPermissoes.CurrentRow.Cells[2].Value);
            Editando(true);
        }
        private void DgvModulos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvModulos.SelectedRows.Count <= 0)
            {
                return;
            }

            if (dgvModulos.CurrentRow.Cells[0].Value.ToString() != "000000")
            {
                PopularPermissoesByCodModulo(dgvModulos.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                PopularPermissoes();
            }

        }



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
                codigo = grupousuarioDAO.BuscaProxCodigoDisponivel();
                tbCodGrupoUsuario.Text = codigo.ToString();
                PopularPermissoes();
                PopularModulos();
                grupousuario = null;
                tbNomeGrupoUsuario.Focus();
                ignoraCheckEvent = false;
                Editando(true);

            }
        }
        private void Busca()
        {
            if (editando)
            {
                return;
            }

            var buscaGrupoUsuario = new fmBuscaGrupoUsuario();
            buscaGrupoUsuario.ShowDialog();
            if (buscaGrupoUsuario.grupoUsuarioSelecionado != null)
            {
                grupousuario = buscaGrupoUsuario.grupoUsuarioSelecionado;
                PreencheCampos(grupousuario);
            }
        }
        private void Salva()
        {
            if (!editando)
            {
                return;
            }

            if (tbCodGrupoUsuario.Text.Length <= 0)
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                "Aviso",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                tbCodGrupoUsuario.Text = grupousuarioDAO.BuscaProxCodigoDisponivel().ToString();
            }
            grupousuario = new GrupoUsuario();
            grupousuario.GrupoUsuarioID = int.Parse(tbCodGrupoUsuario.Text);
            grupousuario.Nome = tbNomeGrupoUsuario.Text;

            var controls = (ControlCollection)this.Controls;
            bool ok = validacao.ValidarEntidade(grupousuario, controls);

            if (!ok)
            {
                return;
            }

            int resultado = grupousuarioDAO.SalvaOuAtualiza(grupousuario, listapermissoes);

            validacao.despintarCampos(controls);
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
        private void Anterior()
        {
            if (tbCodGrupoUsuario.Text.Length <= 0)
            {
                return;
            }

            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            validacao.despintarCampos(controls);

            var newgrupousuario = grupousuarioDAO.Anterior(tbCodGrupoUsuario.Text);
            if (newgrupousuario != null)
            {
                grupousuario = newgrupousuario;
                codigo = grupousuario.GrupoUsuarioID;
                PreencheCampos(grupousuario);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void Proximo()
        {
            if (tbCodGrupoUsuario.Text.Length <= 0)
            {
                return;
            }

            var controls = (ControlCollection)this.Controls;

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            validacao.despintarCampos(controls);

            var newgrupousuario = grupousuarioDAO.Proximo(tbCodGrupoUsuario.Text);
            if (newgrupousuario != null)
            {
                grupousuario = newgrupousuario;
                codigo = grupousuario.GrupoUsuarioID;
                PreencheCampos(grupousuario);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void CarregaDados()
        {
            int c;
            if (!int.TryParse(tbCodGrupoUsuario.Text, out c))
            {
                tbCodGrupoUsuario.Clear();
            }
            else
            {
                if (c == codigo)
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
            }

            if (tbCodGrupoUsuario.Text.Length == 0)
            {
                LimpaCampos(true);
                Editando(false);
                return;
            }

            var newGrupoUsuario = grupousuarioDAO.BuscaByID(int.Parse(tbCodGrupoUsuario.Text));
            if (newGrupoUsuario != null)
            {
                grupousuario = newGrupoUsuario;
                PreencheCampos(grupousuario);
                listapermissoes = permissaoDAO.BuscaPermissoesByIdGrupo(grupousuario.GrupoUsuarioID.ToString()).Todas;
                PopularPermissoes();
                Editando(false);
            }
            else
            {
                listapermissoes = permissaoDAO.BuscaTodasPermissoes().Todas;
                PopularPermissoes();
                Editando(true);
                LimpaCampos(false);
            }
        }
        private void PreencheCampos(GrupoUsuario grupousuario)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodGrupoUsuario.Text = grupousuario.GrupoUsuarioID.ToString();
            tbNomeGrupoUsuario.Text = grupousuario.Nome;
            listapermissoes = permissaoDAO.BuscaPermissoesByIdGrupo(grupousuario.GrupoUsuarioID.ToString()).Todas;
            PopularPermissoes();
            PopularModulos();


            ignoraCheckEvent = false;
        }
        private void LimpaCampos(bool cod)
        {
            if (cod) { tbCodGrupoUsuario.Clear(); }
            tbNomeGrupoUsuario.Clear();
            tbAjuda.Clear();
            listapermissoes = permissaoDAO.BuscaTodasPermissoes().Todas;
        }
        private void Recarrega()
        {
            if (tbCodGrupoUsuario.Text.Length <= 0)
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

            if (grupousuario != null)
            {
                grupousuario = grupousuarioDAO.BuscaByID(grupousuario.GrupoUsuarioID);
                PreencheCampos(grupousuario);
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
        private void PopularPermissoes()
        {

            dgvPermissoes.Rows.Clear();
            foreach (Permissao p in listapermissoes)
            {
                if (p.Codigo.Substring(2) != "0000")
                {
                    dgvPermissoes.Rows.Add(p.Codigo, p.Nome, p.Nivel);
                }
            }
            dgvPermissoes.Sort(dgvPermissoes.Columns[0], ListSortDirection.Ascending);
            dgvPermissoes.Refresh();

        }
        private void PopularModulos()
        {
            dgvModulos.Rows.Clear();
            dgvModulos.Rows.Add("000000", "Todos", NivelTodas);
            foreach (Permissao p in listapermissoes)
            {
                if (p.Codigo.Substring(2, 4) == "0000")
                {
                    dgvModulos.Rows.Add(p.Codigo, p.Nome, p.Nivel);

                }
            }
            dgvModulos.Refresh();
        }
        private void PopularListapermissoes()
        {
            listapermissoes = permissaoDAO.BuscaTodasPermissoes().Todas;
        }
        private void PopularPermissoesByCodModulo(string codmodulo)
        {
            dgvPermissoes.Rows.Clear();

            foreach (Permissao p in listapermissoes)
            {
                if (codmodulo == "000000")
                {
                    if (p.Codigo.Substring(2, 4) != "0000")
                    {
                        dgvPermissoes.Rows.Add(p.Codigo, p.Nome, p.Nivel);
                    }
                }
                else
                {
                    if (p.Codigo.Substring(0, 2) == codmodulo.Substring(0, 2) && p.Codigo.Substring(2, 4) != "0000")
                    {
                        dgvPermissoes.Rows.Add(p.Codigo, p.Nome, p.Nivel);
                    }
                }
            }

            dgvPermissoes.Refresh();
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
    }
}
