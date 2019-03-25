using _5gpro.Bll;
using _5gpro.Entities;
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
    public partial class fmCadastroItens : Form
    {

        _Item _item = new _Item();
        Unimedida unimedida = new Unimedida();
        _ItemBLL _itemBLL = new _ItemBLL();
        UnimedidaBLL unimedidaBLL = new UnimedidaBLL();

        bool editando = false;
        //bool ignoraCheckEvent;

        public fmCadastroItens()
        {
            InitializeComponent();
            AlteraBotoes();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    editando = true;
                    NovoRegistro();
                    tbCodigo.Focus();
                }
                else
                {

                }
            }
            else
            {
                tbCodigo.Focus();
                editando = true;
            }
            AlteraBotoes();
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            editando = true;
            AlteraBotoes();
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

        private void NovoRegistro()
        {
            LimpaCampos(true);
        }

        private void LimpaCampos(bool cod)
        {
            if (cod) { tbCodigo.Clear(); }
            tbDescricao.Clear();
            tbDescricaoDeCompra.Clear();
            tbCodUnimedida.Clear();
            tbDescricaoUndMedida.Clear();
            tbReferncia.Clear();
            tbPrecoUltimaEntrada.Clear();
            tbEstoqueNecessario.Clear();
            tbPrecoVenda.Clear();
            rbProduto.Checked = true;
            rbServico.Checked = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            _item.Codigo = tbCodigo.Text;
            _item.Descricao = tbDescricao.Text;
            _item.DescCompra = tbDescricaoDeCompra.Text;
            _item.Referencia = tbReferncia.Text;
            _item.TipoItem = rbProduto.Checked ? "P" : "S";
            _item.ValorEntrada = decimal.Parse(tbPrecoUltimaEntrada.Text);
            _item.ValorSaida = decimal.Parse(tbPrecoVenda.Text);
            _item.Estoquenecessario = decimal.Parse(tbEstoqueNecessario.Text);
            _item.Unimedida = tbCodUnimedida.Text;

            _ItemBLL itemBLL = new _ItemBLL();
            itemBLL.SalvarOuAtualizarItem(_item);

            MessageBox.Show("Item adicionado com sucesso!");
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {

            tbCodigo.Text = tbCodigo.Text == "0" ? "" : tbCodigo.Text;
            if (!editando)
            {
                if (tbCodigo.Text.Length > 0)
                {
                    _Item newitem = _itemBLL.BuscaItemById(tbCodigo.Text);
                    if (newitem != null)
                    {
                        _item = newitem;
                        PreencheCampos(_item);
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
                        _Item newitem = _itemBLL.BuscaItemById(tbCodigo.Text);
                        if (newitem != null)
                        {
                            _item = newitem;
                            PreencheCampos(_item);
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


        private void fmCadastroItens_Load(object sender, EventArgs e)
        {

        }

        private void PreencheCamposUnimedida(Unimedida unimedida)
        {
            if (unimedida != null)
            {
               
                tbCodUnimedida.Text = unimedida.Codigo.ToString();
                tbDescricaoUndMedida.Text = unimedida.Descricao;
            }
            else
            {
                
            }
        }

        private void tbCodUnimedida_Leave(object sender, EventArgs e)
        {
            if (tbCodUnimedida.Text.Length > 0)
            {
                unimedida = unimedidaBLL.BuscaUnimedidaByCod(tbCodUnimedida.Text);
                PreencheCamposUnimedida(unimedida);
            }
            else
            {
                tbDescricaoUndMedida.Text = "";
            }
        }

        private void btBuscaUndMedida_Click(object sender, EventArgs e)
        {
            AbreTelaBuscaUnimedida();
        }


        private void tbCodUnimedida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                AbreTelaBuscaUnimedida();
            }
        }

        private void AbreTelaBuscaUnimedida()
        {
            var buscaUnimedida = new fmBuscaUnimedida();
            buscaUnimedida.ShowDialog();
            unimedida = buscaUnimedida.Unimedida;
            PreencheCamposUnimedida(unimedida);
        }

        private void PreencheCampos(_Item _item)
        {
            //ignoraCheckEvent = true;
            LimpaCampos(false);
            tbCodigo.Text = _item.Codigo;
            tbDescricao.Text = _item.Descricao;
            tbDescricaoDeCompra.Text = _item.DescCompra;

            if (_item.Unimedida != null)
            {
                unimedida = unimedidaBLL.BuscaUnimedidaByCod(_item.Unimedida);
                PreencheCamposUnimedida(unimedida);
            }

            if (_item.TipoItem == "P")
            {
                rbProduto.Checked = true;
                rbServico.Checked = false;
            }
            else
            {
                rbProduto.Checked = false;
                rbServico.Checked = true;
            }

            tbReferncia.Text = _item.Referencia;
            tbPrecoUltimaEntrada.Text = _item.ValorEntrada.ToString();
            tbEstoqueNecessario.Text = _item.Estoquenecessario.ToString();
            tbPrecoVenda.Text = _item.ValorSaida.ToString();

            //ignoraCheckEvent = false;
        }

        private void Editando(bool edit)
        {
            editando = edit;
            AlteraBotoes();
        }

        private void tbCodigo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbCodigo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
