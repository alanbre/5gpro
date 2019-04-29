using _5gpro.Daos;
using _5gpro.Entities;
using _5gpro.Funcoes;
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
    public partial class fmCapCadastroConta : Form
    {
        private ParcelaContaPagar parcelaSelecionada = null;
        private bool editando, ignoracheckevent = false;
        private ContaPagar contaPagar = null;
        private List<ParcelaContaPagar> parcelas = new List<ParcelaContaPagar>();

        private readonly FuncoesAuxiliares f = new FuncoesAuxiliares();
        private readonly static ConexaoDAO connection = new ConexaoDAO();
        private readonly ContaPagarDAO contaPagarDAO = new ContaPagarDAO(connection);

        //Controle de Permissões
        private readonly PermissaoDAO permissaoDAO = new PermissaoDAO(connection);
        private Logado logado;
        private readonly LogadoDAO logadoDAO = new LogadoDAO(connection);
        private readonly NetworkAdapter adap = new NetworkAdapter();
        private int Nivel;
        private string CodGrupoUsuario;

        public fmCapCadastroConta()
        {
            InitializeComponent();
        }


        private void MenuVertical_Novo_Clicked(object sender, EventArgs e) => Novo();

        private void MenuVertical_Buscar_Clicked(object sender, EventArgs e) => Busca();

        private void MenuVertical_Salvar_Clicked(object sender, EventArgs e) => Salva();

        private void MenuVertical_Recarregar_Clicked(object sender, EventArgs e) => Recarrega();

        private void MenuVertical_Anterior_Clicked(object sender, EventArgs e) => Anterior();

        private void MenuVertical_Proximo_Clicked(object sender, EventArgs e) => Proximo();








        private void Novo()
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
                    tbCodigoConta.Text = contaPagarDAO.BuscaProxCodigoDisponivel().ToString();
                    contaPagar = null;
                    dtpDataCadatroConta.Focus();
                    ignoracheckevent = false;
                    Editando(true);
                }
            }
            else
            {
                ignoracheckevent = true;
                LimpaCampos(false);
                tbCodigoConta.Text = contaPagarDAO.BuscaProxCodigoDisponivel().ToString();
                contaPagar = null;
                Editando(false);
                dtpDataCadatroConta.Focus();
                ignoracheckevent = false;
                Editando(true);
            }
        }

        private void Busca()
        {
            if (editando)
                return;
            var buscaContaPagar = new fmBuscaContaPagar();
            buscaContaPagar.ShowDialog();
            if (buscaContaPagar.contaPagarSelecionada != null)
            {
                contaPagar = buscaContaPagar.contaPagarSelecionada;
                PreencheCampos(contaPagar);
            }
        }

        private void Salva()
        {
            if (editando)
            {
                contaPagar = new ContaPagar
                {
                    ContaPagarID = int.Parse(tbCodigoConta.Text),
                    DataCadastro = dtpDataCadatroConta.Value,
                    Operacao = buscaOperacao.operacao,

                    ValorOriginal = Convert.ToDecimal(tbValorOriginalConta),
                    Multa = Convert.ToDecimal(tbMultaConta.Text),
                    Juros = Convert.ToDecimal(tbJurosConta.Text),
                    ValorFinal = Convert.ToDecimal(tbValorFinalConta.Text),

                    Parcelas = parcelas
                };

                int resultado = contaPagarDAO.SalvaOuAtualiza(contaPagar);

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

        private void Recarrega()
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

            if (contaPagar != null)
            {
                contaPagar = contaPagarDAO.BuscaById(contaPagar.ContaPagarID);
                PreencheCampos(contaPagar);
                if (editando)
                    Editando(false);
            }
            else
            {
                ignoracheckevent = true;
                LimpaCampos(true);
                ignoracheckevent = false;
            }

        }

        private void Proximo()
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
                var newcontaPagar = contaPagarDAO.BuscaProximo(int.Parse(tbCodigoConta.Text));
                if (newcontaPagar != null)
                {
                    contaPagar = newcontaPagar;
                    parcelas = contaPagar.Parcelas.ToList();
                    PreencheCampos(contaPagar);
                    if (editando)
                        Editando(false);
                }
            }
        }

        private void Anterior()
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
                var newcontaPagar = contaPagarDAO.BuscaAnterior(int.Parse(tbCodigoConta.Text));
                if (newcontaPagar != null)
                {
                    contaPagar = newcontaPagar;
                    parcelas = contaPagar.Parcelas.ToList();
                    PreencheCampos(contaPagar);
                    if (editando)
                        Editando(false);
                }
            }
        }


        private void PreencheCampos(ContaPagar contaPagar)
        {
            ignoracheckevent = true;
            LimpaCampos(false);
            tbCodigoConta.Text = contaPagar.ContaPagarID.ToString();
            dtpDataCadatroConta.Value = contaPagar.DataCadastro;
            buscaOperacao.operacao = contaPagar.Operacao;
            tbValorOriginalConta.Text = contaPagar.ValorOriginal.ToString("############0.00");
            tbValorFinalConta.Text = contaPagar.ValorFinal.ToString("############0.00");
            tbMultaConta.Text = contaPagar.Multa.ToString("############0.00");
            tbJurosConta.Text = contaPagar.Juros.ToString("############0.00");
            parcelas = contaPagar.Parcelas.ToList();
            PreencheGridParcelas(parcelas);
            ignoracheckevent = false;
        }

        private void PreencheGridParcelas(List<ParcelaContaPagar> parcelas)
        {
            foreach (var parcela in parcelas)
                dgvParcelas.Rows.Add(parcela.Sequencia, parcela.DataVencimento, parcela.Valor, parcela.Multa, parcela.Multa, parcela.ValorFinal, parcela.DataQuitacao?.Date);
            dgvParcelas.Refresh();
        }

        private void GerarParcelas()
        {
            if (buscaOperacao.operacao == null)
            {
                MessageBox.Show("Você deve selecionar um operação para gerar as parcelas!",
                 "Operação não selecionada",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }
            var parcelasOperacao = buscaOperacao.operacao.Parcelas;



            int sequencia = 1;
            foreach (var parcela in parcelasOperacao)
            {
                var par = new ParcelaContaPagar
                {
                    Sequencia = sequencia,
                    DataVencimento = DateTime.Today.AddDays(parcela.Dias),
                    Multa = 0,
                    Juros = 0,
                    Valor = Convert.ToDecimal(tbValorOriginalConta.Text) / parcelasOperacao.Count
                };
                sequencia++;
                this.parcelas.Add(par);
            }

            PreencheGridParcelas(parcelas);
        }

        private void CalculaTotalParcela()
        {
            tbValorFinalParcela.Text = (Convert.ToDecimal(tbValorOriginalParcela.Text) + Convert.ToDecimal(tbMultaParcela.Text) + Convert.ToDecimal(tbJurosParcela.Text)).ToString("############0.00");
        }

        private void FormataCampoDecimal(TextBox sender)
        {
            sender.Text = sender.Text.Length > 0 ? Convert.ToDecimal(sender.Text).ToString("############0.00") : "0,00";
        }

        private void LimpaCampos(bool limpaCod)
        {
            if (limpaCod) { tbCodigoConta.Clear(); }
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
            this.parcelaSelecionada = null;
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
