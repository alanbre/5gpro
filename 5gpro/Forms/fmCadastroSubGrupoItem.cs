using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroSubGrupoItem : Form
    {

        static ConexaoDAO connection = new ConexaoDAO();
        GrupoItem grupoitemreferencia = null;
        fmCadastroGrupoItem telacadgrupoitem = null;
        GrupoItemDAO grupoitemDAO = new GrupoItemDAO(connection);
        Validacao validacao = new Validacao();
        SubGrupoItem subgrupoitem = null;
        SubGrupoItemDAO subgrupoitemDAO = new SubGrupoItemDAO(connection);

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroSubGrupoItem(GrupoItem grupoitemrecebido, fmCadastroGrupoItem cadgrupoitem)
        {
            InitializeComponent();
            tbNome.Focus();

            SetarDados(grupoitemrecebido, cadgrupoitem);
            if (cadgrupoitem.subgrupoitemSelecionado != null)
            {
                subgrupoitem = cadgrupoitem.subgrupoitemSelecionado;
                PreencheCampos(subgrupoitem);
            }
            else
            {
                tbCodigo.Text = subgrupoitemDAO.BuscaProxCodigoDisponivel();
            }
        }

        private void SetarDados(GrupoItem grupoitem, fmCadastroGrupoItem tcg)
        {
            grupoitemreferencia = grupoitem;
            telacadgrupoitem = tcg;
            
        }

        //EVENTOS DE CLICK
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                if (MessageBox.Show("Deseja fechar?",
                                    "Aviso de alteração",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }


        //EVENTOS DE LEAVE
        private void TbCodigo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    SubGrupoItem newsubgrupoitem = subgrupoitemDAO.BuscarByID(int.Parse(tbCodigo.Text), grupoitemreferencia.GrupoItemID);
                    if (newsubgrupoitem != null)
                    {
                        subgrupoitem = newsubgrupoitem;
                        PreencheCampos(subgrupoitem);
                        Editando(false);
                    }
                    else
                    {
                        Editando(true);
                        LimpaCampos(false);
                    }
                }
                else if (tbCodigo.Text.Length == 0)
                {
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
                        SubGrupoItem newsubgrupoitem = subgrupoitemDAO.BuscarByID(int.Parse(tbCodigo.Text), grupoitemreferencia.GrupoItemID);
                        if (newsubgrupoitem != null)
                        {
                            subgrupoitem = newsubgrupoitem;
                            PreencheCampos(subgrupoitem);
                            Editando(false);
                        }
                        else
                        {
                            Editando(true);
                            LimpaCampos(false);
                        }
                    }
                    else if (tbCodigo.Text.Length == 0)
                    {
                        LimpaCampos(true);
                        Editando(false);
                    }
                }
            }
        }


        //EVENTOS DE TEXTCHANGED
        private void TbNome_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }


        //PADRÕES CRIADAS
        private void SalvaCadastro()
        {
            if (editando)
            {
                subgrupoitem = new SubGrupoItem();

                subgrupoitem.SubGrupoItemID = int.Parse(tbCodigo.Text);
                subgrupoitem.Nome = tbNome.Text;
                subgrupoitem.GrupoItem = grupoitemreferencia;

                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(subgrupoitem, controls);

                if (ok)
                {
                    int resultado = subgrupoitemDAO.SalvarOuAtualizar(subgrupoitem);
                    validacao.despintarCampos(controls);
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
                        MessageBox.Show("Salvo", "Aviso de alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        telacadgrupoitem.AtualizarDgvSub();
                        Editando(false);
                    }
                    else if (resultado == 2)
                    {
                        MessageBox.Show("Atualizado", "Aviso de alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        telacadgrupoitem.AtualizarDgvSub();
                        Editando(false);
                    }
                }
            }
        }

        private void Editando(bool edit)
        {
            editando = edit;
            AlterarBotoes(editando);       
        }

        private void AlterarBotoes(bool editando)
        {
            if (editando)
                btSalvar.Enabled = true;
            else
                btSalvar.Enabled = false;
        }

        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void LimpaCampos(bool limpaCodigo)
        {
            if (limpaCodigo) { tbCodigo.Clear(); }
            tbNome.Clear();
        }

        private void PreencheCampos(SubGrupoItem subgrupoitem)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);

            tbCodigo.Text = subgrupoitem.SubGrupoItemID.ToString();
            tbNome.Text = subgrupoitem.Nome;

            ignoraCheckEvent = false;
        }

        private void FmCadastroSubGrupoItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            telacadgrupoitem.AtualizarDgvSub();
            telacadgrupoitem.subgrupoitemSelecionado = null;
        }

        private void FmCadastroSubGrupoItem_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTab(this.ActiveControl, e);
        }
    }
}
