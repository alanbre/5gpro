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
    public partial class fmCadastroItens : Form, IMessageFilter
    {
        _Item item = new _Item();
        bool editando = false;

        public fmCadastroItens()
        {
            InitializeComponent();
            Application.AddMessageFilter(this); // código para trocar o enter por tab
            AlteraBotoes();
        }

        //Continuação do código para trocar o enter por tab
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x100)//WM_KEYDOWN
            {
                if (m.WParam.ToInt32() == 0xd)//VK_RETURN = 0xd
                {
                    if (this.ActiveControl is TextBox || this.ActiveControl is RadioButton || this.ActiveControl is MaskedTextBox)
                    {
                        SendKeys.Send("{TAB}");
                        return true; //Discard the Enter key
                    }
                }
            }
            return false;
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
            tbCodUniMedida.Clear();
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
            item.Iditem = tbCodigo.Text;
            item.Descricao = tbDescricao.Text;
            item.DenomCompra = tbDescricaoDeCompra.Text;
            item.Referencia = tbReferncia.Text;
            item.TipoItem = rbProduto.Checked ? "P" : "S";
            item.ValorEntrada = decimal.Parse(tbPrecoUltimaEntrada.Text);
            item.ValorSaida = decimal.Parse(tbPrecoVenda.Text);
            item.Estoquenecessario = decimal.Parse(tbEstoqueNecessario.Text);
            item.Unimedida = int.Parse(tbCodUniMedida.Text);

            _ItemBLL itemBLL = new _ItemBLL();
            itemBLL.salvar(item);

            MessageBox.Show("Item adicionado com sucesso!");
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            if (item.Iditem == null)
            {
                editando = tbCodigo.Text.Length > 0 ? true : false;
                LimpaCampos(false);
                AlteraBotoes();
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    editando = true;
                    NovoRegistro();
                }
            }
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

        private void fmCadastroItens_Load(object sender, EventArgs e)
        {

        }
    }
}
