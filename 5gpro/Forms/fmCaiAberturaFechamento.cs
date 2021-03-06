﻿using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using _5gpro.StaticFiles;
using System;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCaiAberturaFechamento : Form
    {
        private readonly CaixaDAO caixaDAO = new CaixaDAO();

        private int Nivel;
        private string CodGrupoUsuario;

        public fmCaiAberturaFechamento()
        {
            InitializeComponent();
        }

        private void FmCaiAberturaFechamento_Load(object sender, EventArgs e) => SetarNivel();
        private void FmCaiAberturaFechamento_KeyDown(object sender, KeyEventArgs e) => EnterTab(this.ActiveControl, e);
        private void BuscaCaixa_Leave(object sender, EventArgs e) => CarregaDados();
        private void BtAbriFechar_Click(object sender, EventArgs e) => AbreOuFecha();

        private void CarregaDados()
        {
            if (buscaCaixa.caixa == null)
            {
                LimpaDados();
                return;
            }

            PreencheDados(buscaCaixa.caixa);
        }
        private void PreencheDados(Caixa caixa)
        {
            dbValorAbertura.Valor = caixa.ValorAbertura;
            dbValorFechamento.Valor = caixa.ValorFechamento;
            tbStatusCaixa.Text = caixa.Aberto ? "Aberto" : "Fechado";
            lbValorAberturaFechamento.Text = caixa.Aberto ? "Valor fechamento" : "Valor de abertura";
            btAbrirFechar.Text = caixa.Aberto ? "Fechar" : "Abrir";
        }
        private void LimpaDados()
        {
            dbValorAberturaFechamento.Valor = 0.00m;
            tbStatusCaixa.Clear();
            btAbrirFechar.Text = "Abrir";
        }
        private void AbreOuFecha()
        {
            if (buscaCaixa.caixa == null)
            {
                return;
            }



            if (!buscaCaixa.caixa.Aberto)
            {
                if (MessageBox.Show($"Tem certeza que deseja abrir o caixa com o valor R${dbValorAberturaFechamento.Valor}?",
                                    "Confirmação de abertura de caixa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                buscaCaixa.caixa.DataAbertura = DateTime.Now;
                buscaCaixa.caixa.DataFechamento = null;
                buscaCaixa.caixa.ValorAbertura = dbValorAberturaFechamento.Valor;
                buscaCaixa.caixa.ValorFechamento = 0.00m;
                buscaCaixa.caixa.Aberto = true;
                //buscaCaixa.caixa.Usuario = logado.Usuario;
                if (caixaDAO.AbreOuFecha(buscaCaixa.caixa))
                {
                    MessageBox.Show($"Caixa aberto com o valor R${dbValorAberturaFechamento.Valor}!",
                                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    PreencheDados(buscaCaixa.caixa);
                    dbValorAberturaFechamento.Valor = 0;
                    return;
                }
                else
                {
                    MessageBox.Show("Problema ao abrir o caixa.",
                                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }   
            }
            else
            {
                if (MessageBox.Show($"Tem certeza que deseja fechar o caixa com o valor R${dbValorAberturaFechamento.Valor}?",
                                    "Confirmação de fechamento de caixa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                buscaCaixa.caixa.DataFechamento = DateTime.Now;
                buscaCaixa.caixa.ValorFechamento = dbValorAberturaFechamento.Valor;
                buscaCaixa.caixa.Aberto = false;
                //buscaCaixa.caixa.Usuario = logado.Usuario;
                if (caixaDAO.AbreOuFecha(buscaCaixa.caixa))
                {
                    MessageBox.Show($"Caixa fechado com o valor R${dbValorAberturaFechamento.Valor}!",
                                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    PreencheDados(buscaCaixa.caixa);
                    dbValorAberturaFechamento.Valor = 0;
                    return;
                }
                else
                {
                    MessageBox.Show("Problema ao fechar o caixa.",
                                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
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
        private void SetarNivel()
        {
            CodGrupoUsuario = Logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            Nivel = Logado.Usuario.Grupousuario.Permissoes.Find(p => p.Codigo == "090200").Nivel;
        }

    }
}
