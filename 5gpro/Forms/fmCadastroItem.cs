using _5gpro.Bll;
using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroItem : Form
    {

        Item item;
        Unimedida unimedida = new Unimedida();
        ItemBLL itemBLL = new ItemBLL();
        UnimedidaBLL unimedidaBLL = new UnimedidaBLL();
        Validacao validacao = new Validacao();


        bool editando = false;
        bool ignoraCheckEvent;

        public fmCadastroItem()
        {
            InitializeComponent();
            AlteraBotoes();
        }

        private void fmCadastroItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RecarregaDados(item);
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
        private void tbCodUnimedida_Leave(object sender, EventArgs e)
        {

        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            tbCodigo.Text = tbCodigo.Text == "0" ? "" : tbCodigo.Text;
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    Item newitem = itemBLL.BuscaItemById(int.Parse(tbCodigo.Text));
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
                        Item newitem = itemBLL.BuscaItemById(int.Parse(tbCodigo.Text));
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



        //FUNÇÕES DE CLICK
        private void btBuscaUndMedida_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaUnimedida();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            SalvaCadastro();

        }

        private void btNovo_Click(object sender, EventArgs e)
        {

            NovoCadastro();

        }


        //FUNÇÕES DE KEY UP
        private void tbCodUnimedida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaUnimedida();
            }
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


        private void fmCadastroItens_Load(object sender, EventArgs e)
        {
            tbCodigo.Focus();
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
            tbCodUnimedida.Clear();
            tbDescricaoUndMedida.Clear();
            tbReferencia.Clear();
            tbPrecoUltimaEntrada.Clear();
            tbEstoqueNecessario.Clear();
            tbPrecoVenda.Clear();
            rbProduto.Checked = true;
            rbServico.Checked = false;
        }

        private void PreencheCamposUnimedida(Unimedida unimedida)
        {
            if (unimedida != null)
            {
                tbCodUnimedida.Text = unimedida.UnimedidaID.ToString();
                tbDescricaoUndMedida.Text = unimedida.Descricao;
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
                    tbCodigo.Text = itemBLL.BuscaProxCodigoDisponivel();
                    item = null;
                    tbDescricao.Focus();
                    Editando(true);
                }
            }
            else
            {
                LimpaCampos(false);
                tbCodigo.Text = itemBLL.BuscaProxCodigoDisponivel();
                item = null;
                tbDescricao.Focus();
                Editando(true);
            }
        }

        private void AbreTelaBuscaUnimedida()
        {
            var buscaUnimedida = new fmBuscaUnimedida();
            buscaUnimedida.ShowDialog();
            unimedida = buscaUnimedida.Unimedida;
            PreencheCamposUnimedida(unimedida);
        }

        private void PreencheCampos(Item item)
        {
            ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = item.ItemID.ToString();
            tbDescricao.Text = item.Descricao;
            tbDescricaoDeCompra.Text = item.DescCompra;


            if (item.Unimedida != null)
            {
                unimedida = unimedidaBLL.BuscaUnimedidaByCod(item.Unimedida.UnimedidaID);
                PreencheCamposUnimedida(unimedida);
            }

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

            ignoraCheckEvent = false;
        }

        private void Editando(bool edit)
        {
            editando = edit;
            AlteraBotoes();
        }

        private void SalvaCadastro()
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

                item.Unimedida = unimedidaBLL.BuscaUnimedidaByCod(int.Parse(tbCodUnimedida.Text));


                ControlCollection controls = (ControlCollection)this.Controls;
                bool ok = validacao.ValidarEntidade(item, controls);

                if (ok)
                {
                    validacao.despintarCampos(controls);
                    int resultado = itemBLL.SalvarOuAtualizarItem(item);

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
                        item = itemBLL.BuscaItemById(item.ItemID);
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
                item = itemBLL.BuscaItemById(item.ItemID);
                PreencheCampos(item);
                Editando(false);
            }

        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            //Busca o item com ID maior que o atual preenchido. Só preenche se houver algum registro maior
            //Caso não houver registro com ID maior, verifica se item existe. Se não existir busca o maior anterior ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigo.Text.Length > 0)
            {
                validacao.despintarCampos(controls);
                Item newitem = itemBLL.BuscarProximoItem(tbCodigo.Text);
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
                    Item newitem = itemBLL.BuscarProximoItem(tbCodigo.Text);
                    if (newitem != null)
                    {
                        item = newitem;
                        PreencheCampos(item);
                        Editando(false);
                    }
                    else
                    {
                        newitem = itemBLL.BuscarProximoItem(tbCodigo.Text);
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

        private void btAnterior_Click(object sender, EventArgs e)
        {
            //Busca o item com ID menor que o atual preenchido. Só preenche se houver algum registro menor
            //Caso não houver registro com ID menor, verifica se item existe. Se não existir busca o proximo ao digitado

            ControlCollection controls = (ControlCollection)this.Controls;

            if (!editando && tbCodigo.Text.Length > 0)
            {
                validacao.despintarCampos(controls);
                Item newitem = itemBLL.BuscarItemAnterior(tbCodigo.Text);
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
                    Item newitem = itemBLL.BuscarItemAnterior(tbCodigo.Text);
                    if (newitem != null)
                    {
                        item = newitem;
                        PreencheCampos(item);
                        Editando(false);
                    }
                    else
                    {
                        newitem = itemBLL.BuscarProximoItem(tbCodigo.Text);
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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //ABRE O FORM DE BUSCA ITEM
            if (!editando)
            {
                AbreTelaBuscaItem();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ControlCollection controls = (ControlCollection)this.Controls;
            List<string> botoes = new List<string>();
            botoes.Add("tbCodigo");
            botoes.Add("tbDescricao");

            validacao.pintarBotoes(botoes, controls);

        }

        private void tbCodUnimedida_Leave_1(object sender, EventArgs e)
        {
            if (tbCodUnimedida.Text.Length > 0)
            {
                unimedida = unimedidaBLL.BuscaUnimedidaByCod(int.Parse(tbCodUnimedida.Text));
                PreencheCamposUnimedida(unimedida);
            }
            else
            {
                tbDescricaoUndMedida.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ControlCollection controls = (ControlCollection)this.Controls;
            List<string> excecoes = new List<string>();
            excecoes.Add("tbCodigo");
            excecoes.Add("tbDescricao");

            Limpar limpar = new Limpar();
            limpar.limparComExcessao(controls, excecoes);
        }
    }
}
