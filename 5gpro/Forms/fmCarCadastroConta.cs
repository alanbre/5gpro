﻿using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _5gpro.Forms
{
    public partial class fmCarCadastroConta : Form
    {
        private Parcela parcelaSelecionada = null;
        private bool editando, ignoracheckevent = false;
        private ContaReceber contaReceber = null;
        private List<Parcela> parcelas = null;


        private static ConexaoDAO connection = new ConexaoDAO();
        private readonly ContaReceberDAO contaReceberDAO = new ContaReceberDAO(connection);

        //Controle de Permissões
        PermissaoDAO permissaoDAO = new PermissaoDAO(connection);
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO(connection);
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        public fmCarCadastroConta()
        {
            InitializeComponent();
        }

        private void FmCarCadastroConta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RecarregaDados(contaReceber);
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







        private void NovoCadastro()
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ignoracheckevent = true;
                    LimpaCampos(false);
                    tbCodigoConta.Text = contaReceberDAO.BuscaProxCodigoDisponivel().ToString();
                    contaReceber = null;
                    dtpDataCadatroConta.Focus();
                    ignoracheckevent = false;
                    Editando(true);
                }
            }
            else
            {
                ignoracheckevent = true;
                LimpaCampos(false);
                tbCodigoConta.Text = contaReceberDAO.BuscaProxCodigoDisponivel().ToString();
                contaReceber = null;
                Editando(false);
                dtpDataCadatroConta.Focus();
                ignoracheckevent = false;
                Editando(true);
            }
        }

        private void SalvaCadastro()
        {
            if (editando)
            {
                contaReceber = new ContaReceber
                {
                    ContaReceberID = int.Parse(tbCodigoConta.Text),
                    DataCadastro = dtpDataCadatroConta.Value,
                    Operacao = buscaOperacao.operacao,
                    FormaPagamento = buscaFormaPagamento.formaPagamento,

                    ValorOriginal = Convert.ToDecimal(tbValorOriginalConta),
                    Multa = Convert.ToDecimal(tbMultaConta.Text),
                    Juros = Convert.ToDecimal(tbJurosConta.Text),
                    ValorFinal = Convert.ToDecimal(tbValorFinalConta.Text),

                    Parcelas = parcelas
                };
                int resultado = 0;
                //int resultado = contaReceberDAO.SalvaOuAtualiza(contaReceber);

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

        private void RecarregaDados(ContaReceber contaReceber)
        {
            if (editando)
            {
                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
                "Aviso de alteração",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (contaReceber != null)
                    {
                        contaReceber = contaReceberDAO.BuscaById(contaReceber.ContaReceberID);
                        //PreencheCampos(orcamento);
                        Editando(false);
                    }
                    else
                    {
                        ignoracheckevent = true;
                        LimpaCampos(true);
                        ignoracheckevent = false;
                    }
                }
            }
            else
            {
                if (contaReceber != null)
                {
                    contaReceber = contaReceberDAO.BuscaById(contaReceber.ContaReceberID);
                    //PreencheCampos(orcamento);
                }
                else
                {
                    ignoracheckevent = true;
                    LimpaCampos(true);
                    ignoracheckevent = false;
                }
            }

        }

        private void ProximoCadastro()
        {
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


            if (tbCodigoConta.Text.Length > 0)
            {
                var newcontaRebeceber = contaReceberDAO.BuscaProximo(int.Parse(tbCodigoConta.Text));
                if (newcontaRebeceber != null)
                {
                    contaReceber = newcontaRebeceber;
                    parcelas = contaReceber.Parcelas.ToList();
                    PreencheCampos(contaReceber);
                    if(editando)
                        Editando(false);
                }
            }
        }

        private void CadastroAnterior()
        {
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

            if (tbCodigoConta.Text.Length > 0)
            {
                var newcontaRebeceber = contaReceberDAO.BuscaAnterior(int.Parse(tbCodigoConta.Text));
                if (newcontaRebeceber != null)
                {
                    contaReceber = newcontaRebeceber;
                    parcelas = contaReceber.Parcelas.ToList();
                    PreencheCampos(contaReceber);
                    if (editando)
                        Editando(false);
                }
            }
        }

        private void PreencheCampos(ContaReceber contaReceber)
        {
            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigoConta.Text = contaReceber.ContaReceberID.ToString();
            dtpDataCadatroConta.Value = contaReceber.DataCadastro;
            buscaOperacao.operacao = contaReceber.Operacao;
            buscaFormaPagamento.formaPagamento = contaReceber.FormaPagamento;
            tbValorOriginalConta.Text = contaReceber.ValorOriginal.ToString("############0.00");
            tbValorFinalConta.Text = contaReceber.ValorFinal.ToString("############0.00");
            tbMultaConta.Text = contaReceber.Multa.ToString("############0.00");
            tbJurosConta.Text = contaReceber.Juros.ToString("############0.00");
            parcelas = contaReceber.Parcelas.ToList();
            PreencheGridParcelas(parcelas);
            ignoracheckevent = false;
        }

        private void PreencheGridParcelas(List<Parcela> parcelas)
        {

        }

        private void LimpaCampos(bool limpaCod)
        {
            if (limpaCod) { tbCodigoConta.Clear(); }
            buscaFormaPagamento.Limpa();
            buscaOperacao.Limpa();
            dtpDataCadatroConta.Value = DateTime.Now;
            dtpDataVencimentoParcela.Value = DateTime.Now;
            tbValorOriginalConta.Text = "0,00";
            tbValorFinalConta.Text = "0,00";
            tbMultaConta.Text = "0,00";
            tbJurosConta.Text = "0,00";
            tbAjuda.Text = "";
            dgvParcelas.Rows.Clear();
            dgvParcelas.Refresh();
            LimpaCamposParcela(limpaCod);
        }

        private void LimpaCamposParcela(bool focus)
        {
            tbValorOriginalParcela.Text = "0,00";
            tbValorFinalParcela.Text = "0,00";
            tbMultaParcela.Text = "0,00";
            tbJurosParcela.Text = "0,00";
            parcelaSelecionada = null;
        }

        private void EnterTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void Editando(bool edit)
        {
            if (!ignoracheckevent)
            {
                editando = edit;
                menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
            }
        }


        private void SetarNivel()
        {
            //Busca o usuário logado no pc, através do MAC
            logado = logadoDAO.BuscaLogadoByMac(adap.Mac);
            CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
            string Codpermissao = permissaoDAO.BuscarIDbyCodigo("020100").ToString();

            //Busca o nivel de permissão através do código do Grupo Usuario e do código da Tela
            Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
            Editando(editando);
        }
    }
}
