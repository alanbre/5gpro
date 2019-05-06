using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroItem : Form
    {
        static ConexaoDAO connection = new ConexaoDAO();
        public Unimedida unimedidadostestes = null;

        Item item;
        Unimedida unimedida = new Unimedida();
        ItemDAO itemDAO = new ItemDAO(connection);
        UnimedidaDAO unimedidaDAO = new UnimedidaDAO(connection);
        Validacao validacao = new Validacao();
        PermissaoDAO permissaoDAO = new PermissaoDAO(connection);
        GrupoItemDAO grupoitemdao = new GrupoItemDAO(connection);

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO(connection);
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroItem()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("010300").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }


        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fmCadastroItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RecarregaDados(item);
            }

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

        private void fmCadastroItens_Load(object sender, EventArgs e)
        {
            tbCodigo.Focus();
        }


        //EVENTOS DE TEXTCHANGED
        private void tbDescricao_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbDescricaoDeCompra_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbReferencia_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbPrecoUltimaEntrada_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbEstoqueNecessario_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void tbCodUnimedida_TextChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void rbProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void rbServico_CheckedChanged(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }

        private void BuscaSubGrupoItem_Text_Changed(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }
        }


        //FUNÇÕES DE LEAVE

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCodigo.Text, out int codigo)) { tbCodigo.Clear(); }
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    Item newitem = itemDAO.BuscarItemById(int.Parse(tbCodigo.Text));
                    if (newitem != null)
                    {
                        item = newitem;
                        PreencheCampos(item);
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
                        Item newitem = itemDAO.BuscarItemById(int.Parse(tbCodigo.Text));
                        if (newitem != null)
                        {
                            item = newitem;
                            PreencheCampos(item);
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

        //MENU
        private void MenuVertical1_Novo_Clicked(object sender, EventArgs e)
        {
            NovoCadastro();

        }

        private void MenuVertical1_Proximo_Clicked(object sender, EventArgs e)
        {
            ProximoCadastro();
        }

        private void MenuVertical1_Recarregar_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVertical1_Salvar_Clicked(object sender, EventArgs e)
        {
            SalvaCadastro();
        }

        private void MenuVertical1_Anterior_Clicked(object sender, EventArgs e)
        {
            CadastroAnterior();
        }

        private void MenuVertical1_Buscar_Clicked(object sender, EventArgs e)
        {
            if (!editando || Nivel == 1)
            {
                AbreTelaBuscaItem();
            }
        }

        private void MenuVertical1_Excluir_Clicked(object sender, EventArgs e)
        {

        }


        //PADRÕES CRIADAS
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
            tbDescricao.Clear();
            tbDescricaoDeCompra.Clear();
            tbReferencia.Clear();
            tbPrecoUltimaEntrada.Clear();
            tbEstoqueNecessario.Clear();
            tbPrecoVenda.Clear();
            rbProduto.Checked = true;
            rbServico.Checked = false;
            buscaGrupoItem.Limpa();
            buscaSubGrupoItem.Limpa();
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
                    tbCodigo.Text = itemDAO.BuscaProxCodigoDisponivel();
                    item = null;
                    tbDescricao.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigo.Text = itemDAO.BuscaProxCodigoDisponivel();
                item = null;
                tbDescricao.Focus();
                Editando(true);
            }
        }

        private void PreencheCampos(Item item)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = item.ItemID.ToString();
            tbDescricao.Text = item.Descricao;
            tbDescricaoDeCompra.Text = item.DescCompra;
          

            if (item.TipoItem == "P")
            {
                rbProduto.Checked = true;
                rbServico.Checked = false;
            }
            else
            {
                rbProduto.Checked = false;
                rbServico.Checked = true;
            }

            tbReferencia.Text = item.Referencia;
            tbPrecoUltimaEntrada.Text = item.ValorEntrada.ToString();
            tbEstoqueNecessario.Text = item.Estoquenecessario.ToString();
            tbPrecoVenda.Text = item.ValorSaida.ToString();

            buscaGrupoItem.PreencheCampos(item.SubGrupoItem.GrupoItem);
            buscaSubGrupoItem.PreencheCampos(item.SubGrupoItem);


            ignoraCheckEvent = false;
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
                    item = new Item();

                    item.ItemID = int.Parse(tbCodigo.Text);
                    item.Descricao = tbDescricao.Text;
                    item.DescCompra = tbDescricaoDeCompra.Text;
                    item.Referencia = tbReferencia.Text;
                    item.TipoItem = rbProduto.Checked ? "P" : "S";

                    if (tbPrecoUltimaEntrada.TextLength > 0)
                    {
                        item.ValorEntrada = decimal.Parse(tbPrecoUltimaEntrada.Text);
                    }
                    else
                    {
                        item.ValorEntrada = 0;
                    }

                    if (tbPrecoVenda.TextLength > 0)
                    {
                        item.ValorSaida = decimal.Parse(tbPrecoVenda.Text);
                    }
                    else
                    {
                        item.ValorSaida = 0;
                    }

                    if (tbEstoqueNecessario.TextLength > 0)
                    {
                        item.Estoquenecessario = decimal.Parse(tbEstoqueNecessario.Text);
                    }
                    else
                    {
                        item.Estoquenecessario = 0;
                    }

                    item.Unimedida = buscaUnimedidaItem.unimedida;

                    item.SubGrupoItem = buscaSubGrupoItem.subgrupoItem;

                    ControlCollection controls = (ControlCollection)this.Controls;

                    ok = validacao.ValidarEntidade(item, controls);
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
                    tbCodigo.Text = itemDAO.BuscaProxCodigoDisponivel().ToString();
                }
                ok = false;
            }
            if (ok)
            {
                int resultado = itemDAO.SalvarOuAtualizarItem(item);

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
        }



        private void RecarregaDados(Item item)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (item != null)
                    {
                        item = itemDAO.BuscarItemById(item.ItemID);
                        PreencheCampos(item);
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
                item = itemDAO.BuscarItemById(item.ItemID);
                PreencheCampos(item);
                Editando(false);
            }

        }

        private void ProximoCadastro()
        {
            //Busca o item com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se item existe. Se não existir busca o maior anterior ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigo.Text.Length > 0)
            {
                validacao.despintarCampos(controls);
                Item newitem = itemDAO.BuscarProximoItem(tbCodigo.Text);
                if (newitem != null)
                {
                    item = newitem;
                    PreencheCampos(item);
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
                    Item newitem = itemDAO.BuscarProximoItem(tbCodigo.Text);
                    if (newitem != null)
                    {
                        item = newitem;
                        PreencheCampos(item);
                        Editando(false);
                    }
                    else
                    {
                        newitem = itemDAO.BuscarProximoItem(tbCodigo.Text);
                        if (newitem != null)
                        {
                            item = newitem;
                            PreencheCampos(item);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void CadastroAnterior()
        {
            //Busca o item com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            //Caso não houver registro com ID menor, verifica se item existe. Se não existir busca o proximo ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigo.Text.Length > 0)
            {
                validacao.despintarCampos(controls);
                Item newitem = itemDAO.BuscarItemAnterior(tbCodigo.Text);
                if (newitem != null)
                {
                    item = newitem;
                    PreencheCampos(item);
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
                    Item newitem = itemDAO.BuscarItemAnterior(tbCodigo.Text);
                    if (newitem != null)
                    {
                        item = newitem;
                        PreencheCampos(item);
                        Editando(false);
                    }
                    else
                    {
                        newitem = itemDAO.BuscarProximoItem(tbCodigo.Text);
                        if (newitem != null)
                        {
                            item = newitem;
                            PreencheCampos(item);
                            Editando(false);
                        }
                    }
                }
            }
        }

        private void AbreTelaBuscaItem()
        {
            var buscaItem = new fmBuscaItem();
            buscaItem.ShowDialog();
            if (buscaItem.itemSelecionado != null)
            {
                item = buscaItem.itemSelecionado;
                PreencheCampos(item);
            }
        }

        private void BuscaGrupoItemTelaCadItem_Leave(object sender, EventArgs e)
        {
            if (!ignoraCheckEvent) { Editando(true); }

            if (buscaGrupoItem.grupoItem != null)
            {
                buscaSubGrupoItem.Limpa();
                buscaSubGrupoItem.EnviarGrupo(buscaGrupoItem.grupoItem);
            }
            else
            {
                buscaSubGrupoItem.EnviarGrupo(buscaGrupoItem.grupoItem);
                buscaSubGrupoItem.Limpa();
                buscaSubGrupoItem.EscolhaOGrupo();
            }
        }
    }
}
