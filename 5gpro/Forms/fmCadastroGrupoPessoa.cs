using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroGrupoPessoa : Form
    {
        GrupoPessoa grupopessoa = null;
        GrupoPessoaDAO grupopessoaDAO = new GrupoPessoaDAO();
        SubGrupoPessoaDAO subgrupopessoaDAO = new SubGrupoPessoaDAO();
        Validacao validacao = new Validacao();
        PermissaoDAO permissaoDAO = new PermissaoDAO();
        public SubGrupoPessoa subgrupopessoaSelecionado = null;
        List<SubGrupoPessoa> listadesubgrupopessoa = new List<SubGrupoPessoa>();

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroGrupoPessoa()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("010600").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

        private void FmCadastroGrupoPessoa_KeyDown(object sender, KeyEventArgs e)
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

        private void FmCadastroGrupoPessoa_Load(object sender, EventArgs e)
        {
            tbCodigo.Focus();
        }


        //EVENTOS DE TEXTCHANGED
        private void TbNomeGrupoPessoa_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }


        //EVENTOS DE LEAVE
        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    GrupoPessoa newgrupopessoa = grupopessoaDAO.BuscarByID(int.Parse(tbCodigo.Text));
                    if (newgrupopessoa != null)
                    {
                        grupopessoa = newgrupopessoa;
                        PreencheCampos(grupopessoa);
                        Editando(false);
                    }
                    else
                    {
                        grupopessoa = null;
                        AtualizarDgvSub();
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodigo.Text.Length == 0)
                {
                    grupopessoa = null;
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
                        GrupoPessoa newgrupopessoa = grupopessoaDAO.BuscarByID(int.Parse(tbCodigo.Text));
                        if (newgrupopessoa != null)
                        {
                            grupopessoa = newgrupopessoa;
                            PreencheCampos(grupopessoa);
                            Editando(false);
                        }
                        else
                        {
                            grupopessoa = null;
                            AtualizarDgvSub();
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodigo.Text.Length == 0)
                    {
                        grupopessoa = null;
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
            string codsub = dgvSubGruposPessoas.SelectedCells[0].Value.ToString();
            string nomesub = dgvSubGruposPessoas.SelectedCells[1].Value.ToString();

            if (MessageBox.Show("Deseja excluir o sub-grupo " + nomesub + " ?",
                                "Aviso de alteração",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int retorno = subgrupopessoaDAO.Remover(codsub);

                if (retorno != 0)
                {
                    MessageBox.Show("Sub-Grupo removido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgvSub();
                }
                else
                {
                    MessageBox.Show("Problema ao remover Sub-Grupo, o mesmo deve estar vinculado a algum item ou serviço", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtAddSub_Click(object sender, EventArgs e)
        {
            AbreTelaCadSubGrupoPessoa();
        }

        private void DgvSubGruposPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvSubGruposPessoas.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSubGruposPessoas.Rows[selectedRowIndex];
            subgrupopessoaSelecionado = grupopessoa.SubGrupoPessoas.Find(g => (g.SubGrupoPessoaID).ToString() == Convert.ToString(selectedRow.Cells[0].Value)); // FAZ UMA BUSCA NA LISTA ONDE A CONDIÇÃO É ACEITA

            AbreTelaCadSubGrupoPessoa();
        }


        //EVENTOS DE TEXTCHANGED
        private void TbBuscaNomeSub_TextChanged(object sender, EventArgs e)
        {
            if (grupopessoa != null)
            {
                dgvSubGruposPessoas.Rows.Clear();
                listadesubgrupopessoa = subgrupopessoaDAO.BuscaTodos(tbBuscaNomeSub.Text, grupopessoa.GrupoPessoaID).ToList();
                foreach (SubGrupoPessoa s in listadesubgrupopessoa)
                {
                    dgvSubGruposPessoas.Rows.Add(s.SubGrupoPessoaID, s.Nome);
                }
                dgvSubGruposPessoas.Refresh();
            }
        }


        //MENU
        private void MenuVertical1_Novo_Clicked(object sender, EventArgs e)
        {
            NovoCadastro();
        }

        private void MenuVertical1_Buscar_Clicked(object sender, EventArgs e)
        {
            if (!editando || Nivel == 1)
            {
                AbreTelaBuscaGrupoPessoa();
            }
        }

        private void MenuVertical1_Salvar_Clicked(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void MenuVertical1_Recarregar_Clicked(object sender, EventArgs e)
        {
            RecarregaDados(grupopessoa);
        }

        private void MenuVertical1_Anterior_Clicked(object sender, EventArgs e)
        {
            CadastroAnterior();
        }

        private void MenuVertical1_Proximo_Clicked(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void MenuVertical1_Excluir_Clicked(object sender, EventArgs e)
        {

        }


        //PADRÕES CRIADAS
        private void RecarregaDados(GrupoPessoa grupopessoa)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (grupopessoa != null)
                    {
                        grupopessoa = grupopessoaDAO.BuscarByID(grupopessoa.GrupoPessoaID);
                        PreencheCampos(grupopessoa);
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
                if (grupopessoa != null)
                {
                    grupopessoa = grupopessoaDAO.BuscarByID(grupopessoa.GrupoPessoaID);
                    PreencheCampos(grupopessoa);
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

                GrupoPessoa newgrupopessoa = grupopessoaDAO.Proximo(tbCodigo.Text);
                if (newgrupopessoa != null)
                {
                    grupopessoa = newgrupopessoa;
                    PreencheCampos(grupopessoa);
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
                    GrupoPessoa newgrupopessoa = grupopessoaDAO.Proximo(tbCodigo.Text);
                    if (newgrupopessoa != null)
                    {
                        grupopessoa = newgrupopessoa;
                        PreencheCampos(grupopessoa);
                        Editando(false);
                    }
                    else
                    {
                        newgrupopessoa = grupopessoaDAO.Anterior(tbCodigo.Text);
                        if (newgrupopessoa != null)
                        {
                            grupopessoa = newgrupopessoa;
                            PreencheCampos(grupopessoa);
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
                GrupoPessoa newgrupopessoa = grupopessoaDAO.Anterior(tbCodigo.Text);
                if (newgrupopessoa != null)
                {
                    grupopessoa = newgrupopessoa;
                    PreencheCampos(grupopessoa);
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
                    GrupoPessoa newgrupopessoa = grupopessoaDAO.Anterior(tbCodigo.Text);
                    if (newgrupopessoa != null)
                    {
                        grupopessoa = newgrupopessoa;
                        PreencheCampos(grupopessoa);
                        Editando(false);
                    }
                    else
                    {
                        newgrupopessoa = grupopessoaDAO.Proximo(tbCodigo.Text);
                        if (newgrupopessoa != null)
                        {
                            grupopessoa = newgrupopessoa;
                            PreencheCampos(grupopessoa);
                            Editando(false);
                        }
                    }
                }
            }
            AlterarBotoesSubAdd();
        }

        private void AlterarBotoesSubAdd()
        {
            if (grupopessoa != null)
            {
                btAddSub.Enabled = true;

                if (grupopessoa.SubGrupoPessoas != null)
                {
                    if (grupopessoa.SubGrupoPessoas.Count > 0)
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
            tbNomeGrupoPessoa.Clear();
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
                    tbCodigo.Text = grupopessoaDAO.BuscaProxCodigoDisponivel().ToString();
                    grupopessoa = null;
                    tbNomeGrupoPessoa.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigo.Text = grupopessoaDAO.BuscaProxCodigoDisponivel().ToString();
                grupopessoa = null;
                tbNomeGrupoPessoa.Focus();
                Editando(true);
            }
            AlterarBotoesSubAdd();
            AtualizarDgvSub();
        }

        private void PreencheCampos(GrupoPessoa grupopessoa)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = grupopessoa.GrupoPessoaID.ToString();
            tbNomeGrupoPessoa.Text = grupopessoa.Nome;

            if (grupopessoa.SubGrupoPessoas != null)
            {
                dgvSubGruposPessoas.Rows.Clear();
                foreach (SubGrupoPessoa s in grupopessoa.SubGrupoPessoas)
                {
                    dgvSubGruposPessoas.Rows.Add(s.SubGrupoPessoaID, s.Nome);
                }
                dgvSubGruposPessoas.Refresh();
            }

            ignoraCheckEvent = false;
        }

        public void AtualizarDgvSub()
        {
            ignoraCheckEvent = true;

            if (grupopessoa != null)
            {
                grupopessoa = grupopessoaDAO.BuscarByID(grupopessoa.GrupoPessoaID);
                if (grupopessoa.SubGrupoPessoas != null)
                {
                    if (grupopessoa.SubGrupoPessoas.Count > 0)
                    {
                        dgvSubGruposPessoas.Rows.Clear();
                        grupopessoa.SubGrupoPessoas = grupopessoaDAO.BuscarByID(grupopessoa.GrupoPessoaID).SubGrupoPessoas;
                        foreach (SubGrupoPessoa s in grupopessoa.SubGrupoPessoas)
                        {
                            dgvSubGruposPessoas.Rows.Add(s.SubGrupoPessoaID, s.Nome);
                        }
                        dgvSubGruposPessoas.Refresh();
                    }
                    else
                    {
                        dgvSubGruposPessoas.Rows.Clear();
                        dgvSubGruposPessoas.Refresh();
                    }
                }
                else
                {
                    dgvSubGruposPessoas.Rows.Clear();
                    dgvSubGruposPessoas.Refresh();
                }
            }
            else
            {
                dgvSubGruposPessoas.Rows.Clear();
                dgvSubGruposPessoas.Refresh();
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
                    grupopessoa = new GrupoPessoa();

                    grupopessoa.GrupoPessoaID = int.Parse(tbCodigo.Text);
                    grupopessoa.Nome = tbNomeGrupoPessoa.Text;

                    ControlCollection controls = (ControlCollection)this.Controls;

                    ok = validacao.ValidarEntidade(grupopessoa, controls);
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
                    tbCodigo.Text = grupopessoaDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
            }
            if (ok)
            {
                int resultado = grupopessoaDAO.SalvarOuAtualizar(grupopessoa);

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

        private void AbreTelaBuscaGrupoPessoa()
        {
            var buscaGrupoPessoa = new fmBuscaGrupoPessoa();
            buscaGrupoPessoa.ShowDialog();
            if (buscaGrupoPessoa.grupoPessoaSelecionado != null)
            {
                grupopessoa = buscaGrupoPessoa.grupoPessoaSelecionado;
                AlterarBotoesSubAdd();
                PreencheCampos(grupopessoa);
            }
        }

        private void AbreTelaCadSubGrupoPessoa()
        {
            var cadSubGrupoPessoa = new fmCadastroSubGrupoPessoa(grupopessoa, this);
            cadSubGrupoPessoa.ShowDialog();
        }
    }
}
