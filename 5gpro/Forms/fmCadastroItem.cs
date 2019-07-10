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
        public Unimedida unimedidadostestes = null;

        private Item item = null;
        private readonly ItemDAO itemDAO = new ItemDAO();
        private readonly Validacao validacao = new Validacao();
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();

        //Desintegração
        DesintegracaoDAO desintegracaoDAO = new DesintegracaoDAO();
        private Item itemdesintegrar = null;
        //private Desintegracao desintegracao = null;
        //private DesintegracaoResultado resultado;
        private List<DesintegracaoResultado> listaresultados = new List<DesintegracaoResultado>();

        //Controle de Permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        bool editando, ignoraCheckEvent = false;
        int codigo = 0;

        public fmCadastroItem()
        {
            InitializeComponent();
            SetarNivel();
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("010300").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

        private void FmCadastroItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Recarrega();
                return;
            }

            if (e.KeyCode == Keys.F1 && Nivel > 1 || e.KeyCode == Keys.F1 && CodGrupoUsuario == "999")
            {
                Novo();
                return;
            }

            if (e.KeyCode == Keys.F2 && Nivel > 1 || e.KeyCode == Keys.F2 && CodGrupoUsuario == "999")
            {
                Salva();
                return;
            }

            EnterTab(this.ActiveControl, e);
        }
        private void FmCadastroItem_FormClosing(object sender, FormClosingEventArgs e)
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
        private void DbCusto_Valor_Changed(object sender, EventArgs e) => Editando(true);
        private void DbPrecoVenda_Valor_Changed(object sender, EventArgs e) => Editando(true);
        private void DbEstoqueNecessario_Valor_Changed(object sender, EventArgs e) => Editando(true);
        private void TbDescricao_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbDescricaoDeCompra_TextChanged(object sender, EventArgs e) => Editando(true);
        private void TbReferencia_TextChanged(object sender, EventArgs e) => Editando(true);
        private void RbProduto_CheckedChanged(object sender, EventArgs e) => Editando(true);     
        private void RbServico_CheckedChanged(object sender, EventArgs e)
        {
            Editando(true);
            if (rbServico.Checked)
                gbDesintegracao.Enabled = false;
            else
                if(item != null)
                gbDesintegracao.Enabled = true;
        }
        private void BuscaUnimedidaItem_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void BuscaSubGrupoItem_Text_Changed(object sender, EventArgs e) => Editando(true);
        private void TbCodigo_Leave(object sender, EventArgs e) => CarregaDados();
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();
        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();
        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();
        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();
        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();
        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();
        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }
        private void BuscaGrupoItemTelaCadItem_Leave(object sender, EventArgs e)
        {
            buscaSubGrupoItem.EnviarGrupo(buscaGrupoItem.grupoItem);
            if (buscaGrupoItem.grupoItem == null)
            {
                buscaSubGrupoItem.Limpa();
                buscaSubGrupoItem.EscolhaOGrupo(false);
            }
            else
            {
                buscaSubGrupoItem.EscolhaOGrupo(true);
            }
        }
        private void BuscaGrupoItem_Text_Changed(object sender, EventArgs e)
        {
            Editando(true);
            buscaSubGrupoItem.Limpa();
        }
        private void RbDesiSim_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbServico.Checked)
                btConfigDesintegracao.Enabled = true;
            else
            {
                MessageBox.Show("Serviço não pode ser desintegrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbDesiSim.Checked = false;
                btConfigDesintegracao.Enabled = false;
            }
            Editando(true);
        }
        private void RbDesiNao_CheckedChanged(object sender, EventArgs e)
        {
            btConfigDesintegracao.Enabled = false;
            Editando(true);
        }
        private void BtConfigDesintegracao_Click(object sender, EventArgs e)
        {
            var formDefPartes = new fmCadastroDesintegracao();
            formDefPartes.itemrecebido = itemdesintegrar;
            formDefPartes.Show(this);
        }
        private void BtAddUnimedida_Click(object sender, EventArgs e)
        {
            var formCadUnidadeMedida = new fmCadastroUnimedida();
            formCadUnidadeMedida.Show(this);
        }
        private void TpEstoque_Click(object sender, EventArgs e)
        {

        }
        private void BtCalcular_Click(object sender, EventArgs e)
        {

            var formCalculoPrecoVenda = new fmCalculoPrecoVenda();
            formCalculoPrecoVenda.custo = dbCusto.Valor;
            formCalculoPrecoVenda.valor = dbPrecoVenda.Valor;
            formCalculoPrecoVenda.ShowDialog();
            dbPrecoVenda.Valor = formCalculoPrecoVenda.valor;
            dbCusto.Valor = formCalculoPrecoVenda.custo;

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
                codigo = itemDAO.BuscaProxCodigoDisponivel();
                tbCodigo.Text = codigo.ToString();
                item = null;
                tbDescricao.Focus();
                ignoraCheckEvent = false;
                Editando(true);
                gbDesintegracao.Enabled = false;
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

            var buscaItem = new fmBuscaItem();
            buscaItem.ShowDialog();
            if (buscaItem.itemSelecionado != null)
            {
                item = buscaItem.itemSelecionado;
                codigo = item.ItemID;
                PreencheCampos(item);
            }
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
                 MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                tbCodigo.Text = itemDAO.BuscaProxCodigoDisponivel().ToString();
                ok = false;
            }


            item = new Item();
            item.ItemID = int.Parse(tbCodigo.Text);
            item.Descricao = tbDescricao.Text;
            item.DescCompra = tbDescricaoDeCompra.Text;
            item.Referencia = tbReferencia.Text;
            item.TipoItem = rbProduto.Checked ? "P" : "S";
            item.Quantidade = dbQuantidade.Valor;
            item.Custo = dbCusto.Valor;
            item.ValorEntrada = 0;
            item.ValorUnitario = dbPrecoVenda.Valor;
            item.Estoquenecessario = dbEstoqueNecessario.Valor;
            item.Unimedida = buscaUnimedidaItem.unimedida;
            item.SubGrupoItem = buscaSubGrupoItem.subgrupoItem;

            var controls = (ControlCollection)this.Controls;

            ok = validacao.ValidarEntidade(item, controls);
            if (ok)
            {
                validacao.despintarCampos(controls);
                int resultado = itemDAO.SalvaOuAtualiza(item);
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
                    if (rbDesiNao.Checked)
                    {
                        desintegracaoDAO.RemoverDesintegracao(item.ItemID);
                    }
                    gbDesintegracao.Enabled = true;
                    itemdesintegrar = item;
                    tbAjuda.Text = "Dados salvos com sucesso";
                    Editando(false);
                    return;
                }
                else if (resultado == 2)
                {
                    if (rbDesiNao.Checked)
                    {
                        desintegracaoDAO.RemoverDesintegracao(item.ItemID);
                    }
                    tbAjuda.Text = "Dados atualizados com sucesso";
                    Editando(false);
                    return;
                }
            }
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

            var controls = (ControlCollection)this.Controls;
            validacao.despintarCampos(controls);

            if (item != null)
            {
                item = itemDAO.BuscaByID(item.ItemID);
                PreencheCampos(item);
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
        private void Anterior()
        {
            if (tbCodigo.Text.Length <= 0)
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


            var newitem = itemDAO.Anterior(int.Parse(tbCodigo.Text));
            if (newitem != null)
            {
                DesintegracaoSimNao(newitem);
                validacao.despintarCampos(controls);
                item = newitem;
                codigo = item.ItemID;
                PreencheCampos(item);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void Proximo()
        {
            if (tbCodigo.Text.Length <= 0)
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


            var newitem = itemDAO.Proximo(int.Parse(tbCodigo.Text));
            if (newitem != null)
            {
                DesintegracaoSimNao(newitem);
                validacao.despintarCampos(controls);
                item = newitem;
                codigo = item.ItemID;
                PreencheCampos(item);
                if (editando)
                {
                    Editando(false);
                }
            }
        }
        private void CarregaDados()
        {
            if (tbCodigo.Text.Length == 0)
            {
                LimpaCampos(true);
                Editando(false);
                gbDesintegracao.Enabled = false;
                return;
            }

            var controls = (ControlCollection)this.Controls;
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
                gbDesintegracao.Enabled = false;
                return;
            }

            if (item?.ItemID == codigo)
            {
                return;
            }             
            

            var newItem = itemDAO.BuscaByID(int.Parse(tbCodigo.Text));
            if (newItem != null)
            {
                DesintegracaoSimNao(newItem);
                gbDesintegracao.Enabled = true;
                validacao.despintarCampos(controls);
                itemdesintegrar = new Item();
                itemdesintegrar = item;
                PreencheCampos(newItem);
                item = newItem;
                Editando(false);
            }
            else
            {
                gbDesintegracao.Enabled = false;
                validacao.despintarCampos(controls);
                Editando(true);
                LimpaCampos(false);
            }
        }
        private void LimpaCampos(bool cod, bool limpaitem = true)
        {
            if (cod) { tbCodigo.Clear(); }
            tbDescricao.Clear();
            tbDescricaoDeCompra.Clear();
            tbReferencia.Clear();
            dbEstoqueNecessario.Valor = 0.00m;
            dbPrecoVenda.Valor = 0.00m;
            dbCusto.Valor = 0.00m;
            rbProduto.Checked = true;
            rbServico.Checked = false;
            buscaGrupoItem.Limpa();
            buscaSubGrupoItem.Limpa();
            buscaUnimedidaItem.Limpa();
            tbAjuda.Clear();
            dbQuantidade.Valor = 0.00m;
            codigo = 0;
            if (limpaitem) { item = null; }
            
        }
        private void PreencheCampos(Item item)
        {
            if (item != null)
            {
                ignoraCheckEvent = true;
                LimpaCampos(false, false);
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
                dbCusto.Valor = item.Custo;
                dbEstoqueNecessario.Valor = item.Estoquenecessario;
                dbPrecoVenda.Valor = item.ValorUnitario;
                dbQuantidade.Valor = item.Quantidade;

                buscaGrupoItem.PreencheCampos(item.SubGrupoItem.GrupoItem);
                buscaSubGrupoItem.PreencheCampos(item.SubGrupoItem);
                buscaUnimedidaItem.PreencheCampos(item.Unimedida);


                ignoraCheckEvent = false;
            }
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
        private void DesintegracaoSimNao(Item d)
        {
            if (desintegracaoDAO.BuscaByID(d.ItemID) == null)
            {
                rbDesiSim.Checked = false;
                rbDesiNao.Checked = true;
            }
            else
            {
                rbDesiSim.Checked = true;
                rbDesiNao.Checked = false;
            }
        }
    }
}