using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroGrupoItem : Form
    {

        GrupoItem grupoitem = null;
        GrupoItemDAO grupoitemDAO = new GrupoItemDAO();
        SubGrupoItemDAO subgrupoitemDAO = new SubGrupoItemDAO();
        Validacao validacao = new Validacao();
        PermissaoDAO permissaoDAO = new PermissaoDAO();
        public SubGrupoItem subgrupoitemSelecionado = null;
        List<SubGrupoItem> listadesubgrupo = new List<SubGrupoItem>();

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroGrupoItem()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("010500").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

        private void FmCadastroGrupoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && Nivel > 1 || e.KeyCode == Keys.F1 && CodGrupoUsuario == "999")
            {
                NovoCadastro();
            }

            if (e.KeyCode == Keys.F2 && Nivel > 1 || e.KeyCode == Keys.F2 && CodGrupoUsuario == "999")
            {
                SalvaCadastro();
            }

            EnterTab(this.ActiveControl, e);
        }

        private void TbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FmCadastroGrupoItem_Load(object sender, System.EventArgs e)
        {
            tbCodigo.Focus();
        }


        //EVENTOS DE TEXTCHANGED
        private void TbNomeGrupo_TextChanged(object sender, System.EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }


        //EVENTOS DE LEAVE
        private void TbCodigo_Leave(object sender, System.EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    GrupoItem newgrupoitem = grupoitemDAO.BuscarByID(int.Parse(tbCodigo.Text));
                    if (newgrupoitem != null)
                    {
                        grupoitem = newgrupoitem;
                        PreencheCampos(grupoitem);
                        Editando(false);
                    }
                    else
                    {
                        grupoitem = null;
                        AtualizarDgvSub();
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodigo.Text.Length == 0)
                {
                    grupoitem = null;
                    AtualizarDgvSub();
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
                    if (tbCodigo.Text.Length > 0)
                    {
                        GrupoItem newgrupoitem = grupoitemDAO.BuscarByID(int.Parse(tbCodigo.Text));
                        if (newgrupoitem != null)
                        {
                            grupoitem = newgrupoitem;
                            PreencheCampos(grupoitem);
                            Editando(false);
                        }
                        else
                        {
                            grupoitem = null;
                            AtualizarDgvSub();
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodigo.Text.Length == 0)
                    {
                        grupoitem = null;
                        AtualizarDgvSub();
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
            AlterarBotoesSubAdd();
        }


        //EVENTOS DE CLICK
        private void BtRemoverSub_Click(object sender, EventArgs e)
        {
            string codsub = dgvSubGruposItens.SelectedCells[0].Value.ToString();
            string nomesub = dgvSubGruposItens.SelectedCells[1].Value.ToString();

            if (MessageBox.Show("Deseja excluir o sub-grupo " + nomesub + " ?",
                                "Aviso de alteração",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int retorno = subgrupoitemDAO.Remover(codsub);

                if (retorno != 0)
                {
                    MessageBox.Show("Sub-Grupo removido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgvSub();
                }
                else
                {
                    MessageBox.Show("Problema ao remover Sub-Grupo, o mesmo deve estar vinculado a algum item ou serviço", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AtualizarDgvSub();
                }
            }
        }

        private void BtAddSub_Click(object sender, EventArgs e)
        {
            AbreTelaCadSubGrupoItem();
        }

        private void DgvSubGruposItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvSubGruposItens.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSubGruposItens.Rows[selectedRowIndex];
            subgrupoitemSelecionado = grupoitem.SubGrupoItens.Find(g => (g.SubGrupoItemID).ToString() == Convert.ToString(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA

            AbreTelaCadSubGrupoItem();
        }


        //EVENTOS DE TEXTCHANGED
        private void TbBuscaNomeSub_TextChanged(object sender, EventArgs e)
        {
            if (grupoitem != null)
            {
                dgvSubGruposItens.Rows.Clear();
                listadesubgrupo = subgrupoitemDAO.BuscaTodos(tbBuscaNomeSub.Text, grupoitem.GrupoItemID).ToList();
                foreach (SubGrupoItem s in listadesubgrupo)
                {
                    dgvSubGruposItens.Rows.Add(s.SubGrupoItemID, s.Nome);
                }
                dgvSubGruposItens.Refresh();
            }
        }


        //MENU
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e)
        {
            if (!editando || Nivel == 1)
            {
                AbreTelaBuscaGrupoItem();
            }
        }

        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e)
        {
            RecarregaDados(grupoitem);
        }

        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e)
        {
            CadastroAnterior();
        }

        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }


        //PADRÕES CRIADAS
        private void RecarregaDados(GrupoItem grupoitem)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (grupoitem != null)
                    {
                        grupoitem = grupoitemDAO.BuscarByID(grupoitem.GrupoItemID);
                        PreencheCampos(grupoitem);
                        Editando(false);
                    }
                    else
                    {
                        ignoraCheckEvent = true;
                        LimpaCampos(true);
                        ignoraCheckEvent = false;
                    }
                }
            }
            else
            {
                if (grupoitem != null)
                {
                    grupoitem = grupoitemDAO.BuscarByID(grupoitem.GrupoItemID);
                    PreencheCampos(grupoitem);
                }
                else
                {
                    ignoraCheckEvent = true;
                    LimpaCampos(true);
                    ignoraCheckEvent = false;
                }
            }
            AlterarBotoesSubAdd();
        }

        private void ProximoCadastro()
        {

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigo.Text.Length > 0)
            {

                validacao.despintarCampos(controls);

                GrupoItem newgrupoitem = grupoitemDAO.BuscarProximo(tbCodigo.Text);
                if (newgrupoitem != null)
                {
                    grupoitem = newgrupoitem;
                    PreencheCampos(grupoitem);
                }
            }
            else if (editando && tbCodigo.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    GrupoItem newgrupoitem = grupoitemDAO.BuscarProximo(tbCodigo.Text);
                    if (newgrupoitem != null)
                    {
                        grupoitem = newgrupoitem;
                        PreencheCampos(grupoitem);
                        Editando(false);
                    }
                    else
                    {
                        newgrupoitem = grupoitemDAO.BuscarAnterior(tbCodigo.Text);
                        if (newgrupoitem != null)
                        {
                            grupoitem = newgrupoitem;
                            PreencheCampos(grupoitem);
                            Editando(false);
                        }
                    }
                }
            }
            AlterarBotoesSubAdd();
        }

        private void CadastroAnterior()
        {

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigo.Text.Length > 0)
            {

                validacao.despintarCampos(controls);
                GrupoItem newgrupoitem = grupoitemDAO.BuscarAnterior(tbCodigo.Text);
                if (newgrupoitem != null)
                {
                    grupoitem = newgrupoitem;
                    PreencheCampos(grupoitem);
                }
            }
            else if (editando && tbCodigo.Text.Length > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
               "Aviso de alteração",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    validacao.despintarCampos(controls);
                    GrupoItem newgrupoitem = grupoitemDAO.BuscarAnterior(tbCodigo.Text);
                    if (newgrupoitem != null)
                    {
                        grupoitem = newgrupoitem;
                        PreencheCampos(grupoitem);
                        Editando(false);
                    }
                    else
                    {
                        newgrupoitem = grupoitemDAO.BuscarProximo(tbCodigo.Text);
                        if (newgrupoitem != null)
                        {
                            grupoitem = newgrupoitem;
                            PreencheCampos(grupoitem);
                            Editando(false);
                        }
                    }
                }
            }
            AlterarBotoesSubAdd();
        }

        private void AlterarBotoesSubAdd()
        {
            if (grupoitem != null)
            {
                btAddSub.Enabled = true;

                if (grupoitem.SubGrupoItens != null)
                {
                    if (grupoitem.SubGrupoItens.Count > 0)
                    {
                        btRemoverSub.Enabled = true;
                    }
                    else
                    {
                        btRemoverSub.Enabled = false;
                    }
                }
            }
            else
            {
                btAddSub.Enabled = false;
                btRemoverSub.Enabled = false;
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

        private void LimpaCampos(bool cod)
        {
            if (cod) { tbCodigo.Clear(); }
            tbNomeGrupoItem.Clear();
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
                    tbCodigo.Text = grupoitemDAO.BuscaProxCodigoDisponivel().ToString();
                    grupoitem = null;
                    tbNomeGrupoItem.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigo.Text = grupoitemDAO.BuscaProxCodigoDisponivel().ToString();
                grupoitem = null;
                tbNomeGrupoItem.Focus();
                Editando(true);
            }
            AlterarBotoesSubAdd();
            AtualizarDgvSub();
        }

        private void PreencheCampos(GrupoItem grupoitem)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = grupoitem.GrupoItemID.ToString();
            tbNomeGrupoItem.Text = grupoitem.Nome;

            if (grupoitem.SubGrupoItens != null)
            {
                dgvSubGruposItens.Rows.Clear();
                foreach (SubGrupoItem s in grupoitem.SubGrupoItens)
                {
                    dgvSubGruposItens.Rows.Add(s.SubGrupoItemID, s.Nome);
                }
                dgvSubGruposItens.Refresh();
            }

            ignoraCheckEvent = false;
        }

        public void AtualizarDgvSub()
        {

            ignoraCheckEvent = true;

            if (grupoitem != null)
            {
                grupoitem = grupoitemDAO.BuscarByID(grupoitem.GrupoItemID);
                if (grupoitem.SubGrupoItens != null)
                {
                    if (grupoitem.SubGrupoItens.Count > 0)
                    {
                        dgvSubGruposItens.Rows.Clear();
                        grupoitem.SubGrupoItens = grupoitemDAO.BuscarByID(grupoitem.GrupoItemID).SubGrupoItens;
                        foreach (SubGrupoItem s in grupoitem.SubGrupoItens)
                        {
                            dgvSubGruposItens.Rows.Add(s.SubGrupoItemID, s.Nome);
                        }
                        dgvSubGruposItens.Refresh();
                    }
                    else
                    {
                        dgvSubGruposItens.Rows.Clear();
                        dgvSubGruposItens.Refresh();
                    }
                }
                else
                {
                    dgvSubGruposItens.Rows.Clear();
                    dgvSubGruposItens.Refresh();
                }
            }
            else
            {
                dgvSubGruposItens.Rows.Clear();
                dgvSubGruposItens.Refresh();
            }
            ignoraCheckEvent = false;
            AlterarBotoesSubAdd();
        }

        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
        }

        private void SalvaCadastro()
        {
            bool ok = false;

            if (tbCodigo.Text.Length > 0)
            {
                if (editando)
                {
                    grupoitem = new GrupoItem();

                    grupoitem.GrupoItemID = int.Parse(tbCodigo.Text);
                    grupoitem.Nome = tbNomeGrupoItem.Text;

                    ControlCollection controls = (ControlCollection)this.Controls;

                    ok = validacao.ValidarEntidade(grupoitem, controls);
                    if (ok) { validacao.despintarCampos(controls); }
                }
            }
            else
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                                    "Aviso",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbCodigo.Text = grupoitemDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
            }
            if (ok)
            {
                int resultado = grupoitemDAO.SalvarOuAtualizar(grupoitem);

                // resultado 0 = nada foi inserido (houve algum erro)
                // resultado 1 = foi inserido com sucesso
                // resultado 2 = foi atualizado com sucesso
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
            AlterarBotoesSubAdd();
            AtualizarDgvSub();
        }

        private void AbreTelaBuscaGrupoItem()
        {
            var buscaGrupoItem = new fmBuscaGrupoItem();
            buscaGrupoItem.ShowDialog();
            if (buscaGrupoItem.grupoitemSelecionado != null)
            {
                grupoitem = buscaGrupoItem.grupoitemSelecionado;
                AlterarBotoesSubAdd();
                PreencheCampos(grupoitem);
            }
        }

        private void AbreTelaCadSubGrupoItem()
        {
            var cadSubGrupoItem = new fmCadastroSubGrupoItem(grupoitem, this);
            cadSubGrupoItem.ShowDialog();
        }
    }
}
