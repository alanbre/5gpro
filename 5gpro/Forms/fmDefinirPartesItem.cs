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
    public partial class fmDefinirPartesItem : Form
    {
        private List<Desintegracao> listadesintegracoes = new List<Desintegracao>();
        private List<DesintegracaoResultado> listaresultados = new List<DesintegracaoResultado>();

        private Desintegracao desintegracao;
        private DesintegracaoResultado resultado;

        bool editando, ignoraCheckEvent = false;

        public fmDefinirPartesItem()
        {
            InitializeComponent();
        }

        private void BtInserir_Click(object sender, EventArgs e)
        {
            if (buscaItemParte.item == null)
                MessageBox.Show("Escolha a Parte a ser inserido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (buscaItemInteiro.item == null)
                MessageBox.Show("Escolha o Item a ser Desintegrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                desintegracao = new Desintegracao();
                resultado = new DesintegracaoResultado();

                desintegracao.DesintegracaoID = buscaItemInteiro.item.ItemID;
                desintegracao.Itemdesintegrado = buscaItemInteiro.item;

                resultado.Item = buscaItemParte.item;
                resultado.Porcentagem = dbPorcentagem.Valor;
                listadesintegracoes.Add(desintegracao);

                //dgvPartes.Rows.Add(desintegracao.Parteitem.ItemID, desintegracao.Parteitem.Descricao, desintegracao.Porcentagem);
                dgvPartes.Refresh();
            }
        }

        private void BtRemoverparte_Click(object sender, EventArgs e)
        {
            //listadesintegracoes.Remove(listadesintegracoes.Find(d => d.Parteitem.ItemID == int.Parse(dgvPartes.CurrentRow.Cells[0].Value.ToString())));
            dgvPartes.Rows.Remove(dgvPartes.CurrentRow);
            RemoverparteEnable();
        }

        private void RemoverparteEnable()
        {
            if (dgvPartes.SelectedRows.Count > 0)
                btRemoverparte.Enabled = true;
            else
                btRemoverparte.Enabled = false;
        }

        private void DgvPartes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoverparteEnable();
        }

        //MENU PRINCIPAL
        private void MenuVerticalSemNovo1_Buscar_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVerticalSemNovo1_Salvar_Clicked(object sender, EventArgs e) => Salvar();

        private void MenuVerticalSemNovo1_Recarregar_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVerticalSemNovo1_Anterior_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVerticalSemNovo1_Proximo_Clicked(object sender, EventArgs e)
        {

        }

        //FUNÇÕES

        private void Salvar()
        {
            if (!editando)
            {
                return;
            }
            bool ok = false;




            var controls = (ControlCollection)this.Controls;

            //ok = validacao.ValidarEntidade(item, controls);
            //if (ok)
            //{
            //    validacao.despintarCampos(controls);
            //    int resultado = itemDAO.SalvaOuAtualiza(item);
            //    if (resultado == 0)
            //    {
            //        MessageBox.Show("Problema ao salvar o registro",
            //        "Problema ao salvar",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //        return;
            //    }
            //    else if (resultado == 1)
            //    {
            //        tbAjuda.Text = "Dados salvos com sucesso";
            //        Editando(false);
            //        return;
            //    }
            //    else if (resultado == 2)
            //    {
            //        tbAjuda.Text = "Dados atualizados com sucesso";
            //        Editando(false);
            //        return;
            //    }


        }
    }
}
    
