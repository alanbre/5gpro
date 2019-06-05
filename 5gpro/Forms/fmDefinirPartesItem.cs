﻿using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmDefinirPartesItem : Form
    {
        Validacao validacao = new Validacao();
        DesintegracaoDAO desintegracaoDAO = new DesintegracaoDAO();

        public Desintegracao desintegracaoconfigurada = new Desintegracao();
        private DesintegracaoResultado resultadodesi;
        private DesintegracaoResultado resultadodesiSelecionado;
        public List<DesintegracaoResultado> listaresultados = new List<DesintegracaoResultado>();

        public Item itemrecebido = null;

        //Controle de permissões
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO();
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO();

        bool editando, ignoraCheckEvent = false;

        public fmDefinirPartesItem()
        {
            InitializeComponent();
            SetarNivel();
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


        private void BtInserir_Click(object sender, EventArgs e)
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
                resultadodesi.Porcentagem = dbPorcentagem.Valor;
                listaresultados.Remove(resultadodesi);
                listaresultados.Add(resultadodesi);


                dgvPartes.Rows.Add(resultadodesi.Item.ItemID, resultadodesi.Item.Descricao, resultadodesi.Porcentagem);
                dgvPartes.Refresh();
            }
        }

        private void BtRemoverparte_Click(object sender, EventArgs e)
        {
            listaresultados.Remove(listaresultados.Find(d => d.Item.ItemID == int.Parse(dgvPartes.CurrentRow.Cells[0].Value.ToString())));
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
            desintegracaoconfigurada.Partes = listaresultados;


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
                    tbAjuda.Text = "Dados salvos com sucesso";
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

        private void BuscaItemInteiro_Leave(object sender, EventArgs e) => CarregaDados();

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
                //validacao.despintarCampos(controls);
                desintegracaoconfigurada = newDesintegracao;
                listaresultados = desintegracaoconfigurada.Partes;
                PreencheCampos(desintegracaoconfigurada);
                Editando(false);
            }
            else
            {
                //validacao.despintarCampos(controls);
                //desintegracao.DesintegracaoID = buscaItemInteiro.item.ItemID;
                //desintegracao.Itemdesintegrado = buscaItemInteiro.item;
                //desintegracao.Partes = new List<DesintegracaoResultado>();
                Editando(true);
                //LimpaCampos(false);
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

        private void FmDefinirPartesItem_Load(object sender, EventArgs e)
        {
            PreencherItemRecebido();
        }

        private void PreencheCampos(Desintegracao desintegracao)
        {
            ignoraCheckEvent = true;

            dgvPartes.Rows.Clear();
            foreach (var p in desintegracao.Partes)
            {
                dgvPartes.Rows.Add(p.Item.ItemID, p.Item.Descricao, p.Porcentagem);
            }
            dgvPartes.Refresh();

            ignoraCheckEvent = false;
        }
    }
}

