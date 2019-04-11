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
        //CÓDIGO DA TELA CAD.GRUPO USUARIO = 010400

        GrupoUsuario grupousuario;
        GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
        PermissaoBLL permissaoBLL = new PermissaoBLL();
        List<Permissao> listapermissoes = new List<Permissao>();
        List<Permissao> listamodulos = new List<Permissao>();
        Validacao validacao = new Validacao();
        int NivelTodas = 0;

        //Controle de permissões
        private Logado logado;
        private readonly LogadoBLL logadoBLL = new LogadoBLL();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;

        bool editando, ignoraCheckEvent = false;

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
            //Busca o usuário logado no pc, através do MAC
            logado = logadoBLL.BuscaLogadoByMac(adap.Mac);
            string Codgrupousuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoBLL.BuscarIDbyCodigo("010400").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoBLL.BuscarNivelPermissao(Codgrupousuario, Codpermissao);
            Editando(editando);

        }

        private void FmCadastroGrupoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }

        private void fmCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            PopularModulos();
            popularPermissoes();

        }


        //EVENTOS DE TEXTCHANGED
        private void tbNomeGrupoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbCodGrupoUsuario_TextChanged(object sender, EventArgs e)
        {

        }


        //EVENTOS DE LEAVE
        private void tbCodGrupoUsuario_Leave(object sender, EventArgs e)
        {
            tbCodGrupoUsuario.Text = tbCodGrupoUsuario.Text == "0" ? "" : tbCodGrupoUsuario.Text;
            if (!editando)
            {
                if (tbCodGrupoUsuario.Text.Length > 0)
                {
                    GrupoUsuario newgrupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(tbCodGrupoUsuario.Text);

                    if (newgrupousuario != null)
                    {
                        grupousuario = newgrupousuario;
                        PreencheCampos(grupousuario);
                        listapermissoes = permissaoBLL.BuscaPermissoesGrupo(grupousuario.GrupoUsuarioID.ToString()).Todas;
                        popularPermissoes();
                        Editando(false);
                    }
                    else
                    {
                        listapermissoes = permissaoBLL.BuscaTodasPermissoes().Todas;
                        popularPermissoes();
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodGrupoUsuario.Text.Length == 0)
                {
                    listapermissoes = permissaoBLL.BuscaTodasPermissoes().Todas;
                    popularPermissoes();
                    LimpaCampos(true);
                    Editando(false);
                }
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbCodGrupoUsuario.Text.Length > 0)
                    {
                        GrupoUsuario newgrupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(tbCodGrupoUsuario.Text);
                        if (newgrupousuario != null)
                        {
                            grupousuario = newgrupousuario;
                            PreencheCampos(grupousuario);
                            Editando(false);
                        }
                        else
                        {
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodGrupoUsuario.Text.Length == 0)
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }

        }


        //MENU
        private void MenuVertical1_Load(object sender, EventArgs e)
        {
        }

        private void MenuVertical1_Novo_Clicked(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void MenuVertical1_Buscar_Clicked(object sender, EventArgs e)
        {
            if (!editando)
            {
                AbreTelaBuscaGrupoUsuario();
            }
        }

        private void MenuVertical1_Salvar_Clicked(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void MenuVertical1_Proximo_Clicked(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void MenuVertical1_Anterior_Clicked(object sender, EventArgs e)
        {
            CadastroAnterior();
        }


        //EVENTOS DE CLICK

        private void DgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLICKAR UMA FILTRA AS PERMISSOES POR MÓDULO, COMPARANDO
            //OS 2 PRIMEIROS NÚMEROS DO CÓDIGO DO MÓDULO COM OS 2 PRIMEIROS
            //NÚMEROS DO CÓDIGO DA PERMISSÃO

            if (dgvModulos.CurrentRow.Cells[0].Value.ToString() != "000000")
            {
                popularPermissoesByCodModulo(dgvModulos.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                popularPermissoes();
            }

        }

        private void DgvModulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dois Clicks na linha para somar 1 no nivel, quando chegar a 3 o próximo valor será 0

            if (tbCodGrupoUsuario.Text.Length > 0 && dgvModulos.CurrentRow.Cells[0].Value.ToString() != "000000")
            {

                if (MessageBox.Show("Deseja alterar TODAS as permissões do Módulo " + dgvModulos.CurrentRow.Cells[1].Value.ToString() + " ?",
                                        "Aviso de alteração",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {

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
                            p.Nivel = dgvModulos.CurrentRow.Cells[2].Value.ToString();
                        }
                    }
                    popularPermissoesByCodModulo(dgvModulos.CurrentRow.Cells[0].Value.ToString());
                    PopularModulos();
                    Editando(true);
                }

            }
            else
            {
                if (tbCodGrupoUsuario.Text.Length > 0 && dgvModulos.CurrentRow.Cells[0].Value.ToString() == "000000")
                {
                    if (MessageBox.Show("Deseja alterar TODAS as permissões de TODOS os MÓDULOS" + " ?",
                        "Aviso de alteração",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

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
                            p.Nivel = dgvModulos.CurrentRow.Cells[2].Value.ToString();
                        }
                        NivelTodas = int.Parse(dgvModulos.CurrentRow.Cells[2].Value.ToString());
                        popularPermissoesByCodModulo(dgvModulos.CurrentRow.Cells[0].Value.ToString());
                        PopularModulos();
                        Editando(true);


                    }
                }
            }
        }

        private void dgvPermissoes_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        {

        }

        private void dgvPermissoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dois Clicks na linha para somar 1 no nivel, quando chegar a 3 o próximo valor será 0
            if (tbCodGrupoUsuario.Text.Length > 0)
            {

                if (int.Parse(dgvPermissoes.CurrentRow.Cells[2].Value.ToString()) < 3)
                {
                    dgvPermissoes.CurrentRow.Cells[2].Value = int.Parse(dgvPermissoes.CurrentRow.Cells[2].Value.ToString()) + 1;
                }
                else
                {
                    dgvPermissoes.CurrentRow.Cells[2].Value = 0;
                }

                //ATUALIZA O NIVEL DA LISTA DE PERMISSÕES A CADA DOUBLECLICK
                listapermissoes.Find(l => l.Codigo == dgvPermissoes.CurrentRow.Cells[0].Value.ToString()).Nivel = dgvPermissoes.CurrentRow.Cells[2].Value.ToString();
                Editando(true);
            }
        }

        private void DgvModulos_CurrentCellChanged(object sender, EventArgs e)
        {
            //MUDAR MODULO NAS SETAS
            if (dgvModulos.SelectedRows.Count > 0)
            {
                if (dgvModulos.CurrentRow.Cells[0].Value.ToString() != "000000")
                {
                    popularPermissoesByCodModulo(dgvModulos.CurrentRow.Cells[0].Value.ToString());
                }
                else
                {
                    popularPermissoes();
                }
            }

        }


        //PADRÕES CRIADAS

        public void PopularListapermissoes()
        {
            listapermissoes = permissaoBLL.BuscaTodasPermissoes().Todas;
        }

        private void PreencheCampos(GrupoUsuario grupousuario)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodGrupoUsuario.Text = grupousuario.GrupoUsuarioID.ToString();
            tbNomeGrupoUsuario.Text = grupousuario.Nome;
            listapermissoes = permissaoBLL.BuscaPermissoesGrupo(grupousuario.GrupoUsuarioID.ToString()).Todas;
            popularPermissoes();
            PopularModulos();


            ignoraCheckEvent = false;
        }

        private void LimpaCampos(bool cod)
        {
            if (cod) { tbCodGrupoUsuario.Clear(); }
            tbNomeGrupoUsuario.Clear();
            tbAjuda.Clear();
        }

        private void RecarregaDados(GrupoUsuario grupousuario)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (grupousuario != null)
                    {
                        grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(grupousuario.GrupoUsuarioID.ToString());
                        PreencheCampos(grupousuario);
                        Editando(false);
                    }
                    else
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
            else
            {
                grupousuario = grupousuarioBLL.BuscaGrupoUsuarioByID(grupousuario.GrupoUsuarioID.ToString());
                PreencheCampos(grupousuario);
                Editando(false);
            }

        }

        private void NovoCadastro()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LimpaCampos(false);
                    tbCodGrupoUsuario.Text = grupousuarioBLL.BuscaProxCodigoDisponivel();
                    listapermissoes = permissaoBLL.BuscaTodasPermissoes().Todas;
                    popularPermissoes();
                    PopularModulos();
                    grupousuario = null;
                    tbNomeGrupoUsuario.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodGrupoUsuario.Text = grupousuarioBLL.BuscaProxCodigoDisponivel();
                listapermissoes = permissaoBLL.BuscaTodasPermissoes().Todas;
                popularPermissoes();
                PopularModulos();
                grupousuario = null;
                tbNomeGrupoUsuario.Focus();
                Editando(true);
            }
        }

        public void popularPermissoes()
        {

            dgvPermissoes.Rows.Clear();
            foreach (Permissao p in listapermissoes)
            {
                //VERFICIA SE NÃO É MODULO, E ENTÃO ADICIONA
                if (p.Codigo.Substring(2) != "0000")
                {
                    dgvPermissoes.Rows.Add(p.Codigo, p.Nome, p.Nivel);
                }
            }
            dgvPermissoes.Sort(dgvPermissoes.Columns[1], ListSortDirection.Ascending); //Ordena pela coluna 1
            dgvPermissoes.Refresh();

        }

        public void PopularModulos()
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

        private void SalvaCadastro()
        {

            if (editando)
            {
                grupousuario = new GrupoUsuario();
                grupousuario.GrupoUsuarioID = int.Parse(tbCodGrupoUsuario.Text);
                grupousuario.Nome = tbNomeGrupoUsuario.Text;

                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(grupousuario, controls);

                if (ok)
                {
                    int resultado = grupousuarioBLL.SalvarOuAtualizarGrupoUsuario(grupousuario, listapermissoes);
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

        private void ProximoCadastro()
        {
            //Busca o grupo_usuario com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se pessoa existe. Se não existir busca o maior anterior ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodGrupoUsuario.Text.Length > 0)
            {

                validacao.despintarCampos(controls);

                GrupoUsuario newgrupousuario = grupousuarioBLL.BuscarProximoGrupoUsuario(tbCodGrupoUsuario.Text);
                if (newgrupousuario != null)
                {
                    grupousuario = newgrupousuario;
                    PreencheCampos(grupousuario);
                }
            }
            else if (editando && tbCodGrupoUsuario.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    GrupoUsuario newgrupousuario = grupousuarioBLL.BuscarProximoGrupoUsuario(tbCodGrupoUsuario.Text);
                    if (newgrupousuario != null)
                    {
                        grupousuario = newgrupousuario;
                        PreencheCampos(grupousuario);
                        Editando(false);
                    }
                    else
                    {
                        newgrupousuario = grupousuarioBLL.BuscarGrupoUsuarioAnterior(tbCodGrupoUsuario.Text);
                        if (newgrupousuario != null)
                        {
                            grupousuario = newgrupousuario;
                            PreencheCampos(grupousuario);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void CadastroAnterior()
        {
            //Busca a pessoa com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            //Caso não houver registro com ID menor, verifica se pessoa existe. Se não existir busca o proximo ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodGrupoUsuario.Text.Length > 0)
            {
                //Os registros com newpessoa é só para garantir que não vai dar confusão com a variável "global"
                //la do inicio do arquivo.

                validacao.despintarCampos(controls);
                GrupoUsuario newgrupousuario = grupousuarioBLL.BuscarGrupoUsuarioAnterior(tbCodGrupoUsuario.Text);
                if (newgrupousuario != null)
                {
                    grupousuario = newgrupousuario;
                    PreencheCampos(grupousuario);
                }
            }
            else if (editando && tbCodGrupoUsuario.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    GrupoUsuario newgrupousuario = grupousuarioBLL.BuscarGrupoUsuarioAnterior(tbCodGrupoUsuario.Text);
                    if (newgrupousuario != null)
                    {
                        grupousuario = newgrupousuario;
                        PreencheCampos(grupousuario);
                        Editando(false);
                    }
                    else
                    {
                        newgrupousuario = grupousuarioBLL.BuscarProximoGrupoUsuario(tbCodGrupoUsuario.Text);
                        if (newgrupousuario != null)
                        {
                            grupousuario = newgrupousuario;
                            PreencheCampos(grupousuario);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void popularPermissoesByCodModulo(string codmodulo)
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

        private void AbreTelaBuscaGrupoUsuario()
        {
            var buscaGrupoUsuario = new fmBuscaGrupoUsuario();
            buscaGrupoUsuario.ShowDialog();
            if (buscaGrupoUsuario.grupousuarioSelecionado != null)
            {
                grupousuario = buscaGrupoUsuario.grupousuarioSelecionado;
                PreencheCampos(grupousuario);
            }
        }

        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit, Nivel);
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
