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
    public partial class fmCadastroGrupoPessoa : Form
    {
        private GrupoPessoa grupoPessoa = null;
        private readonly GrupoPessoaDAO grupopessoaDAO = new GrupoPessoaDAO();
        private readonly SubGrupoPessoaDAO subgrupopessoaDAO = new SubGrupoPessoaDAO();
        private readonly Validacao validacao = new Validacao();
        public SubGrupoPessoa subgrupopessoaSelecionado = null;
        private List<SubGrupoPessoa> listadesubgrupopessoa = new List<SubGrupoPessoa>();

        int codigo = 0;
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
            CodGrupoUsuario = Logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            Nivel = Logado.Usuario.Grupousuario.Permissoes.Find(p => p.Codigo == "010600").Nivel;
            Editando(editando);
        }

        private void FmCadastroGrupoPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && Nivel > 1 || e.KeyCode == Keys.F1 && CodGrupoUsuario == "999")
            {
                Novo();
            }

            if (e.KeyCode == Keys.F2 && Nivel > 1 || e.KeyCode == Keys.F2 && CodGrupoUsuario == "999")
            {
                Salva();
            }

            EnterTab(this.ActiveControl, e);
        }
        private void FmCadastroGrupoPessoa_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MenuVertical1_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical1_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical1_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical1_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical1_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical1_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical1_Excluir_Clicked(object sender, EventArgs e)
        {

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
        private void TbNomeGrupoPessoa_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }
        private void TbCodigo_Leave(object sender, EventArgs e) => CarregaDados();
        private void BtRemoverSub_Click(object sender, EventArgs e) => RemoverSubGrupoPessoa();
        private void BtAddSub_Click(object sender, EventArgs e) => InserirSubGrupoPessoa();
        private void DgvSubGruposPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubGruposPessoas.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvSubGruposPessoas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvSubGruposPessoas.Rows[selectedRowIndex];
                subgrupopessoaSelecionado = grupoPessoa.SubGrupoPessoas.Find(p => p.Codigo == Convert.ToInt32(selectedRow.Cells[0].Value));
                PreencheCamposSubGrupo(subgrupopessoaSelecionado);
                btSalvar.Enabled = true;
                btRemoverSub.Enabled = true;
            }
        }
        private void TbBuscaNomeSub_TextChanged(object sender, EventArgs e)
        {
            if (grupoPessoa != null)
            {
                dgvSubGruposPessoas.Rows.Clear();
                listadesubgrupopessoa = subgrupopessoaDAO.Busca(tbBuscaNomeSub.Text, grupoPessoa.GrupoPessoaID).ToList();
                foreach (SubGrupoPessoa s in listadesubgrupopessoa)
                {
                    dgvSubGruposPessoas.Rows.Add(s.SubGrupoPessoaID, s.Nome);
                }
                dgvSubGruposPessoas.Refresh();
            }
        }
        private void BtSalvar_Click(object sender, EventArgs e) => SalvaSubGrupo();
        private void DgvSubGruposPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void InserirSubGrupoPessoa()
        {
            LimpaCamposSubPessoas();
            tbCodigoSubGrupo.Text = grupoPessoa.SubGrupoPessoas?.Count > 0 ? (grupoPessoa.SubGrupoPessoas?.Max(sg => sg.Codigo) + 1).ToString() : "1";
            tbNomeSubGrupo.Focus();
            btNovoSubGrupo.Enabled = false;
        }
        private void Recarrega()
        {
            if (tbCodigo.Text.Length <= 0)
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

            if (grupoPessoa != null)
            {
                grupoPessoa = grupopessoaDAO.BuscaByID(grupoPessoa.GrupoPessoaID);
                PreencheCampos(grupoPessoa);
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
            }
        }
        private void Proximo()
        {
            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }


            var controls = (ControlCollection)this.Controls;


            validacao.despintarCampos(controls);

            var newgrupopessoa = grupopessoaDAO.Proximo(int.Parse(tbCodigo.Text));
            if (newgrupopessoa != null)
            {
                grupoPessoa = newgrupopessoa;
                PreencheCampos(grupoPessoa);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void Anterior()
        {

            if (tbCodigo.Text.Length <= 0)
            {
                return;
            }

            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                    "Aviso de alteração",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }


            var controls = (ControlCollection)this.Controls;


            validacao.despintarCampos(controls);

            var newgrupopessoa = grupopessoaDAO.Anterior(int.Parse(tbCodigo.Text));
            if (newgrupopessoa != null)
            {
                grupoPessoa = newgrupopessoa;
                PreencheCampos(grupoPessoa);
                if (editando)
                {
                    Editando(false);
                }
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
            dgvSubGruposPessoas.Rows.Clear();
            dgvSubGruposPessoas.Refresh();
            btNovoSubGrupo.Enabled = false;
            LimpaCamposSubPessoas();
            codigo = 0;
            grupoPessoa = null;
        }
        private void LimpaCamposSubPessoas()
        {
            tbCodigoSubGrupo.Clear();
            tbNomeSubGrupo.Clear();
            subgrupopessoaSelecionado = null;
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
                tbCodigo.Text = grupopessoaDAO.BuscaProxCodigoDisponivel().ToString();
                grupoPessoa = null;
                tbNomeGrupoPessoa.Focus();
                ignoraCheckEvent = false;
                Editando(true);
            }
        }
        private void PreencheCampos(GrupoPessoa grupopessoa)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = grupopessoa.GrupoPessoaID.ToString();
            tbNomeGrupoPessoa.Text = grupopessoa.Nome;
            grupoPessoa = grupopessoa;
            btNovoSubGrupo.Enabled = true;
            PreencheGridSubGrupoPessoas();
            ignoraCheckEvent = false;
        }
        private void PreencheCamposSubGrupo(SubGrupoPessoa subGrupoPessoa)
        {
            tbCodigoSubGrupo.Text = subGrupoPessoa.Codigo.ToString();
            tbNomeSubGrupo.Text = subGrupoPessoa.Nome;
        }
        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
        }
        private void Salva()
        {
            if (!editando)
            {
                return;
            }
            bool ok = false;

            if (tbCodigo.Text.Length <= 0)
            {
                if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
                "Aviso",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    tbCodigo.Text = grupopessoaDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
                return;
            }

            grupoPessoa = new GrupoPessoa();
            grupoPessoa.GrupoPessoaID = int.Parse(tbCodigo.Text);
            grupoPessoa.Nome = tbNomeGrupoPessoa.Text;

            var controls = (ControlCollection)this.Controls;

            ok = validacao.ValidarEntidade(grupoPessoa, controls);

            if (ok)
            {
                validacao.despintarCampos(controls);
                int resultado = grupopessoaDAO.SalvarOuAtualizar(grupoPessoa);

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
                    btNovoSubGrupo.Enabled = true;
                    Editando(false);
                    return;
                }
                else if (resultado == 2)
                {
                    tbAjuda.Text = "Dados atualizados com sucesso";
                    Editando(false);
                    return;
                }
            }
        }
        private void SalvaSubGrupo()
        {
            if (tbCodigoSubGrupo.Text.Length <= 0 || grupoPessoa == null)
            {
                return;
            }

            SubGrupoPessoa subGrupo = null;
            if (subgrupopessoaSelecionado != null)
            {
                subGrupo = subgrupopessoaSelecionado;
                grupoPessoa.SubGrupoPessoas.Remove(subGrupo);
                subGrupo.Nome = tbNomeSubGrupo.Text;

                int resultado = grupopessoaDAO.AtualizarSubGrupo(subGrupo);
                if (resultado > 0)
                {
                    tbAjuda.Text = "Sub-grupo atualizado com sucesso";
                    grupoPessoa.SubGrupoPessoas.Add(subGrupo);
                    btNovoSubGrupo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Problema ao atualizar o registro",
                    "Problema ao atualizar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {
                subGrupo = new SubGrupoPessoa();
                subGrupo.Nome = tbNomeSubGrupo.Text;
                subGrupo.Codigo = int.Parse(tbCodigoSubGrupo.Text);
                subGrupo.GrupoPessoa = grupoPessoa;

                int resultado = grupopessoaDAO.InserirSubGrupo(subGrupo);
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
                    tbAjuda.Text = "Sub-grupo salvo com sucesso";

                    grupoPessoa.SubGrupoPessoas.Add(subGrupo);
                    btNovoSubGrupo.Enabled = true;

                }
                else if (resultado == 2)
                {
                    tbAjuda.Text = "Sub-grupo atualizado com sucesso";
                    grupoPessoa.SubGrupoPessoas.Add(subGrupo);
                    btNovoSubGrupo.Enabled = true;
                }
            }
            LimpaCamposSubPessoas();
            PreencheGridSubGrupoPessoas();

        }
        private void PreencheGridSubGrupoPessoas()
        {
            dgvSubGruposPessoas.Rows.Clear();
            foreach (var sub in grupoPessoa.SubGrupoPessoas)
            {
                dgvSubGruposPessoas.Rows.Add(sub.Codigo,
                                           sub.Nome);
            }
            dgvSubGruposPessoas.Refresh();
        }
        private void RemoverSubGrupoPessoa()
        {
            if (grupopessoaDAO.SubGrupoUsado(subgrupopessoaSelecionado))
            {
                MessageBox.Show("Este sub-grupo está sendo utilizado e não pode ser deletado.",
                "Aviso",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                btNovoSubGrupo.Enabled = true;
                btRemoverSub.Enabled = false;
                LimpaCamposSubPessoas();
                return;
            }

            int retorno = grupopessoaDAO.RemoverSubGrupo(subgrupopessoaSelecionado);
            if (retorno > 0)
            {
                grupoPessoa.SubGrupoPessoas.Remove(subgrupopessoaSelecionado);
                dgvSubGruposPessoas.Rows.Clear();
                PreencheGridSubGrupoPessoas();
                btNovoSubGrupo.Enabled = true;
                btRemoverSub.Enabled = false;
                LimpaCamposSubPessoas();
                tbAjuda.Text = "Sub-grupo removido com sucesso";
            }
        }
        private void CarregaDados()
        {
            var controls = (ControlCollection)this.Controls;
            
            if (tbCodigo.Text.Length == 0)
            {
                validacao.despintarCampos(controls);
                LimpaCampos(true);
                Editando(false);
                return;
            }

            int c = 0;
            if (!int.TryParse(tbCodigo.Text, out c))
            {
                tbCodigo.Clear();
            }
            else
            {
                if (c != codigo)
                {
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
            }

            if (codigo == 0)
            {
                LimpaCampos(true);
                Editando(false);
                return;
            }

            if (grupoPessoa?.GrupoPessoaID == codigo)
            {
                return;
            }


            var newGrupoPessoa = grupopessoaDAO.BuscaByID(int.Parse(tbCodigo.Text));
            if (newGrupoPessoa != null)
            {
                validacao.despintarCampos(controls);
                grupoPessoa = newGrupoPessoa;
                PreencheCampos(grupoPessoa);
                Editando(false);
            }
            else
            {
                validacao.despintarCampos(controls);
                Editando(true);
                LimpaCampos(false);
            }
        }
        private void Busca()
        {
            if (CodGrupoUsuario != "999" && Nivel <= 0)
            {
                return;
            }

            if (editando)
            {
                return;
            }

            var buscaGrupoPessoa = new fmBuscaGrupoPessoa();
            buscaGrupoPessoa.ShowDialog();
            if (buscaGrupoPessoa.grupoPessoaSelecionado != null)
            {
                grupoPessoa = buscaGrupoPessoa.grupoPessoaSelecionado;
                PreencheCampos(grupoPessoa);
            }
        }

    }
}
