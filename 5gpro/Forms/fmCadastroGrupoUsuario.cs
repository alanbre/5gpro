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
        List<Permissao> listapermissoes = new List<Permissao>();
        List<Permissao> listamodulos = new List<Permissao>();
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
            AlteraBotoes();  //ALTERA BOTÕES PARA CERTIFICAR QUE VÃO ESTAR CORRETOS AO ABRIR A TELA
            PopularListapermissoes();

        }

        public void PopularListapermissoes()
        {
            listapermissoes = permissaoBLL.BuscaTodasPermissoes().Todas;
        }

        private void fmCadastroItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RecarregaDados(grupousuario);
            }

            if (e.KeyCode == Keys.F1)
            {
                NovoCadastro();
            }

            if (e.KeyCode == Keys.F2)
            {
                SalvaCadastro();
            }

            EnterTab(this.ActiveControl, e);
        }

        //FUNÇÕES DE KEY PRESS
        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //FUNÇÕES DE LEAVE

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

        //FALTA SETAR OS NIVEIS DE PERMISSÃO
        private void PreencheCampos(GrupoUsuario grupousuario)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodGrupoUsuario.Text = grupousuario.GrupoUsuarioID.ToString();
            tbNomeGrupoUsuario.Text = grupousuario.Nome;
            listapermissoes = permissaoBLL.BuscaPermissoesGrupo(grupousuario.GrupoUsuarioID.ToString()).Todas;
            popularPermissoes();


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
                grupousuario = null;
                tbNomeGrupoUsuario.Focus();
                Editando(true);
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
        private void fmCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            PopularModulos();
            popularPermissoes();

        }
        public void popularPermissoes()
        {

            dgvPermissoes.Rows.Clear();
            foreach (Permissao p in listapermissoes)
            {
                dgvPermissoes.Rows.Add(p.Codigo, p.Nome, p.Nivel);
            }
            dgvPermissoes.Refresh();

        }

        public void PopularModulos()
        {
            listamodulos = permissaoBLL.BuscaTodasPermissoes().Modulos;
            dgvModulos.Rows.Add("000000", "TODOS");
            foreach (Permissao p in listamodulos)
            {
                dgvModulos.Rows.Add(p.Codigo, p.Nome, p.Nivel);
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

        ///CONSTRUINDO
        ///
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
            NovoCadastro();
        }

        private void btRecarregar_Click(object sender, EventArgs e)
        {

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

        //EVENTOS DE TEXTCHANGED

        private void tbNomeGrupoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbCodGrupoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            CadastroAnterior();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                AbreTelaBuscaGrupoUsuario();
            }
        }

        private void DgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AO CLICKAR UMA FILTRA AS PERMISSOES POR MÓDULO, COMPARANDO
            //OS 2 PRIMEIROS NÚMEROS DO CÓDIGO DO MÓDULO COM OS 2 PRIMEIROS
            //NÚMEROS DO CÓDIGO DA PERMISSÃO

            dgvPermissoes.Rows.Clear();
            if (dgvModulos.CurrentRow.Cells[0].Value.ToString() != "000000")
            {
                foreach (Permissao p in listapermissoes)
                {
                    if (p.Codigo.Substring(0, 2) == dgvModulos.CurrentRow.Cells[0].Value.ToString().Substring(0, 2))
                    {
                        dgvPermissoes.Rows.Add(p.Codigo, p.Nome, p.Nivel);
                    }

                }
            }
            else
            {
                popularPermissoes();
            }

            dgvPermissoes.Refresh();

        }

        private void DgvModulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dois Clicks na linha para somar 1 no nivel, quando chegar a 3 o próximo valor será 0
            //if (tbCodGrupoUsuario.Text.Length > 0)
            //{

            //    if (int.Parse(dgvModulos.CurrentRow.Cells[2].Value.ToString()) < 3)
            //    {
            //        dgvModulos.CurrentRow.Cells[2].Value = int.Parse(dgvModulos.CurrentRow.Cells[2].Value.ToString()) + 1;
            //    }
            //    else
            //    {
            //        dgvModulos.CurrentRow.Cells[2].Value = 0;
            //    }

                //ATUALIZA O NIVEL DA LISTA DE PERMISSÕES A CADA DOUBLECLICK
                //listapermissoes.Find(l => l.Codigo == dgvPermissoes.CurrentRow.Cells[0].Value.ToString()).Nivel = dgvPermissoes.CurrentRow.Cells[2].Value.ToString();
                //Editando(true);
            }
        }
    }
}
