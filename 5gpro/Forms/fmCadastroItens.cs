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

        public fmCadastroItens()
        {
            InitializeComponent();
            AlteraBotoes();
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           // editando = true;
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
            if (!editando)
            {

                
                if (tbCodigo.Text.Length > 0)
                {
                    _item = _itemBLL.BuscaItemById(tbCodigo.Text);
                    if (_item.Codigo != null)
                    {
                        PreencheCampos(_item, false);
                        editando = false;
                    }
                    else
                    {
                        editando = true;
                        LimpaCampos(false);
                    }
                }
                AlteraBotoes();
            }
            else
            {
      
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
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

        private void PreencheCamposUnimedida(Unimedida unimedida)
        {
            if (unimedida != null)
            {
                Console.WriteLine("Entrou no IF");
                tbCodUnimedida.Text = unimedida.Codigo.ToString();
                tbDescricaoUndMedida.Text = unimedida.Descricao;
            }
            else
            {
                Console.WriteLine("Entrou no ELSE");
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
            Console.WriteLine("Entrou no ABRETELABUSCAUNIMEDIDA");
            var buscaUnimedida = new fmBuscaUnimedida();
            buscaUnimedida.ShowDialog();
            unimedida = buscaUnimedida.Unimedida;
            PreencheCamposUnimedida(unimedida);
        }

        private void PreencheCampos(_Item _item, bool alteraCodigo)
        {
            tbCodigo.Text = alteraCodigo ? _item.Codigo : tbCodigo.Text;
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

        }
    }
}
