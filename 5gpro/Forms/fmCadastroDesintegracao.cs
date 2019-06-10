using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCadastroDesintegracao : Form
    {
        Validacao validacao = new Validacao();
        DesintegracaoDAO desintegracaoDAO = new DesintegracaoDAO();
        public Desintegracao desintegracaoconfigurada = new Desintegracao();
        private DesintegracaoResultado resultadodesi;
        public List<DesintegracaoResultado> listaresultadospercentual = new List<DesintegracaoResultado>();
        public List<DesintegracaoResultado> listaresultadosquantitativo = new List<DesintegracaoResultado>();

        public Item itemrecebido = null;

        //Controle de permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();

        bool editando, ignoraCheckEvent = false;

        public fmCadastroDesintegracao()
        {
            InitializeComponent();
            SetarNivel();
        }


        //EVENTOS DE CLICK

        private void BtInserir_Click(object sender, EventArgs e) => InserirLinha();

        private void BtRemoverparte_Click(object sender, EventArgs e) => RemoverLinha();

        private void DgvPartes_CellClick(object sender, DataGridViewCellEventArgs e) => RemoverparteEnable();

        private void RbQuantitativa_CheckedChanged(object sender, EventArgs e)
        {
            AlterarTipoRB();
            Editando(true);
        }

        private void RbPercentual_CheckedChanged(object sender, EventArgs e)
        {
            AlterarTipoRB();
            Editando(true);
        }

        private void AlterarTipoRB()
        {
            if (rbQuantitativa.Checked)
            {
                dgvPartes.Columns[2].HeaderText = "Quantidade";
                lbTipoDesi.Text = "Quantidade";
                PreencherDGV();
            }
            if (rbPercentual.Checked)
            {
                dgvPartes.Columns[2].HeaderText = "Porcentagem";
                lbTipoDesi.Text = "Porcentagem";
                PreencherDGV();
            }
        }

        private void PreencherDGV()
        {
            if (rbQuantitativa.Checked)
            {
                dgvPartes.Rows.Clear();

                foreach (DesintegracaoResultado d in listaresultadosquantitativo)
                {
                    dgvPartes.Rows.Add(d.Item.ItemID, d.Item.Descricao, d.Quantidade);
                }
                dgvPartes.Refresh();
            }
            else
            {
                dgvPartes.Rows.Clear();

                foreach (DesintegracaoResultado d in listaresultadospercentual)
                {
                    dgvPartes.Rows.Add(d.Item.ItemID, d.Item.Descricao, d.Porcentagem);
                }
                dgvPartes.Refresh();
            }
        }


        //MENU PRINCIPAL
        private void MenuVertical_Novo_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salvar();

        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Excluir_Clicked(object sender, EventArgs e)
        {

        }


        //EVENTOS DE LEAVE E LOAD
        private void BuscaItemInteiro_Leave(object sender, EventArgs e) => CarregaDados();

        private void FmDefinirPartesItem_Load(object sender, EventArgs e)
        {
            PreencherItemRecebido();
        }


        //FUNÇÕES
        private void Salvar()
        {
            if (!editando)
            {
                return;
            }
            bool ok = false;

            desintegracaoconfigurada.DesintegracaoID = buscaItemInteiro.item.ItemID;
            desintegracaoconfigurada.Itemdesintegrado = buscaItemInteiro.item;

            if (rbPercentual.Checked)
            {
                desintegracaoconfigurada.Tipo = "P";
                desintegracaoconfigurada.Partes = listaresultadospercentual;
            }
            else
            {
                desintegracaoconfigurada.Tipo = "Q";
                desintegracaoconfigurada.Partes = listaresultadosquantitativo;
            }


            var controls = (ControlCollection)this.Controls;

            ok = validacao.ValidarEntidade(desintegracaoconfigurada, controls);
            if (ok)
            {
                validacao.despintarCampos(controls);
                int resultado = desintegracaoDAO.SalvaOuAtualiza(desintegracaoconfigurada);
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
                    if (desintegracaoconfigurada.Tipo == "P")
                        listaresultadosquantitativo.Clear();
                    else
                        listaresultadospercentual.Clear();

                    tbAjuda.Text = "Dados salvos com sucesso";
                    Editando(false);
                    return;
                }
                else if (resultado == 2)
                {
                    if (desintegracaoconfigurada.Tipo == "P")
                        listaresultadosquantitativo.Clear();
                    else
                        listaresultadospercentual.Clear();

                    tbAjuda.Text = "Dados atualizados com sucesso";
                    Editando(false);
                    return;
                }
            }
        }

        private void RemoverparteEnable()
        {
            if (dgvPartes.SelectedRows.Count > 0)
                btRemoverparte.Enabled = true;
            else
                btRemoverparte.Enabled = false;
        }

        private void PreencherItemRecebido()
        {
            if (itemrecebido != null)
            {
                buscaItemInteiro.item = itemrecebido;
                buscaItemInteiro.PreencheCampos(itemrecebido);
            }
            CarregaDados();
        }

        private void InserirLinha()
        {
            if (buscaItemParte.item == null)
                MessageBox.Show("Escolha a Parte a ser inserida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (buscaItemInteiro.item == null)
                MessageBox.Show("Escolha o Item a ser Desintegrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                resultadodesi = new DesintegracaoResultado();
                resultadodesi.Desintegracao = desintegracaoconfigurada;
                resultadodesi.Item = buscaItemParte.item;

                DataGridViewRow dr = dgvPartes.Rows.Cast<DataGridViewRow>().Where(r => int.Parse(r.Cells[0].Value.ToString()) == resultadodesi.Item.ItemID).FirstOrDefault();

                if (dr == null)
                {
                    if (rbPercentual.Checked)
                    {
                        resultadodesi.Porcentagem = dbValorTipo.Valor;
                        listaresultadospercentual.Add(resultadodesi);
                        dgvPartes.Rows.Add(resultadodesi.Item.ItemID, resultadodesi.Item.Descricao, resultadodesi.Porcentagem);
                    }
                    else
                    {
                        resultadodesi.Quantidade = dbValorTipo.Valor;
                        listaresultadosquantitativo.Add(resultadodesi);
                        dgvPartes.Rows.Add(resultadodesi.Item.ItemID, resultadodesi.Item.Descricao, resultadodesi.Quantidade);
                    }
                }
                else
                {
                    if (rbPercentual.Checked)
                    {
                        resultadodesi.Porcentagem = dbValorTipo.Valor;
                        listaresultadospercentual.Where(i => i.Item.ItemID == resultadodesi.Item.ItemID).First().Porcentagem = resultadodesi.Porcentagem;
                        dr.Cells[dgvtbcPorcentagem.Index].Value = resultadodesi.Porcentagem;
                        dgvPartes.Update();
                        dgvPartes.Refresh();
                    }
                    else
                    {
                        resultadodesi.Quantidade = dbValorTipo.Valor;
                        listaresultadosquantitativo.Where(i => i.Item.ItemID == resultadodesi.Item.ItemID).First().Quantidade = resultadodesi.Quantidade;
                        dr.Cells[dgvtbcPorcentagem.Index].Value = resultadodesi.Porcentagem;
                        dgvPartes.Update();
                        dgvPartes.Refresh();
                    }
                }
                dgvPartes.Refresh();
            }
            Editando(true);
        }

        private void RemoverLinha()
        {
            if (rbPercentual.Checked)
                listaresultadospercentual.Remove(listaresultadospercentual.Find(d => d.Item.ItemID == int.Parse(dgvPartes.CurrentRow.Cells[0].Value.ToString())));
            else
                listaresultadosquantitativo.Remove(listaresultadosquantitativo.Find(d => d.Item.ItemID == int.Parse(dgvPartes.CurrentRow.Cells[0].Value.ToString())));

            dgvPartes.Rows.Remove(dgvPartes.CurrentRow);
            RemoverparteEnable();
            Editando(true);
        }

        private void Editando(bool edit)
        {
            editando = edit;
            menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
        }

        private void CarregaDados()
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

            if (buscaItemInteiro.item == null)
                return;

            var newDesintegracao = desintegracaoDAO.BuscaByID(buscaItemInteiro.item.ItemID);

            if (newDesintegracao != null)
            {
                desintegracaoconfigurada = newDesintegracao;

                if (newDesintegracao.Tipo == "P")
                    listaresultadospercentual = desintegracaoconfigurada.Partes;
                else
                    listaresultadosquantitativo = desintegracaoconfigurada.Partes;

                PreencheCampos(desintegracaoconfigurada);
                Editando(false);
            }
            else
            {
                dgvPartes.Rows.Clear();
                Editando(true);
            }
        }

        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("080100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }

        private void BuscaItemInteiro_Codigo_Changed(object sender, EventArgs e)
        {
            listaresultadosquantitativo.Clear();
            listaresultadospercentual.Clear();
        }

        private void PreencheCampos(Desintegracao desintegracao)
        {
            ignoraCheckEvent = true;

            if (desintegracao.Tipo == "P")
            {
                rbPercentual.Checked = true;
                dgvPartes.Rows.Clear();
                foreach (var p in desintegracao.Partes)
                {
                    dgvPartes.Rows.Add(p.Item.ItemID, p.Item.Descricao, p.Porcentagem);
                }
            }
            else
            {
                rbQuantitativa.Checked = true;
                dgvPartes.Rows.Clear();
                foreach (var p in desintegracao.Partes)
                {
                    dgvPartes.Rows.Add(p.Item.ItemID, p.Item.Descricao, p.Quantidade);
                }
            }

            dgvPartes.Refresh();

            ignoraCheckEvent = false;
        }

        private void Anterior()
        {
            if (buscaItemInteiro.item == null)
            {
                return;
            }

            //var controls = (ControlCollection)this.Controls;

            //if (editando)
            //{
            //    if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            //        "Aviso de alteração",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Warning) == DialogResult.No)
            //        return;
            //}


            //var newitem = itemDAO.Anterior(int.Parse(tbCodigo.Text));
            //if (newitem != null)
            //{
            //    DesintegracaoSimNao(newitem);
            //    validacao.despintarCampos(controls);
            //    item = newitem;
            //    codigo = item.ItemID;
            //    PreencheCampos(item);
            //    if (editando)
            //    {
            //        Editando(false);
            //    }
            //}
        }
        private void Proximo()
        {
            //if (tbCodigo.Text.Length <= 0)
            //{
            //    return;
            //}

            //var controls = (ControlCollection)this.Controls;

            //if (editando)
            //{
            //    if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
            //        "Aviso de alteração",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Warning) == DialogResult.No)
            //        return;
            //}


            //var newitem = itemDAO.Proximo(int.Parse(tbCodigo.Text));
            //if (newitem != null)
            //{
            //    DesintegracaoSimNao(newitem);
            //    validacao.despintarCampos(controls);
            //    item = newitem;
            //    codigo = item.ItemID;
            //    PreencheCampos(item);
            //    if (editando)
            //    {
            //        Editando(false);
            //    }
            //}
        }

    }
}

