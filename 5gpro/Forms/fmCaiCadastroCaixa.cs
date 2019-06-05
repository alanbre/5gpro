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
    public partial class fmCaiCadastroCaixa : Form
    {
        public fmCaiCadastroCaixa()
        {
            InitializeComponent();
        }

        //private void Novo()
        //{
        //    if (editando)
        //    {
        //        return;
        //    }

        //    if (Nivel > 1 || CodGrupoUsuario == "999")
        //    {
        //        ignoraCheckEvent = true;
        //        LimpaCampos(false);
        //        codigo = unimedidaDAO.BuscaProxCodigoDisponivel();
        //        tbCodigo.Text = codigo.ToString();
        //        unimedida = null;
        //        tbSigla.Focus();
        //        ignoraCheckEvent = false;
        //        Editando(true);
        //    }
        //}
        //private void Busca()
        //{
        //    if (CodGrupoUsuario != "999" && Nivel <= 0)
        //    {
        //        return;
        //    }

        //    if (editando)
        //    {
        //        return;
        //    }

        //    var buscaUnimedida = new fmBuscaUnimedida();
        //    buscaUnimedida.ShowDialog();
        //    if (buscaUnimedida.unimedidaSelecionada != null)
        //    {
        //        unimedida = buscaUnimedida.unimedidaSelecionada;
        //        codigo = unimedida.UnimedidaID;
        //        PreencheCampos(unimedida);
        //    }
        //}
        //private void Salva()
        //{
        //    if (!editando)
        //    {
        //        return;
        //    }

        //    if (tbCodigo.Text.Length <= 0)
        //    {
        //        if (MessageBox.Show("Código em branco, deseja gerar um código automaticamente?",
        //        "Aviso",
        //         MessageBoxButtons.YesNo,
        //         MessageBoxIcon.Information) == DialogResult.No)
        //        {
        //            return;
        //        }
        //        codigo = unimedidaDAO.BuscaProxCodigoDisponivel();
        //        tbCodigo.Text = codigo.ToString();
        //    }
        //    var ok = false;

        //    unimedida = new Unimedida();
        //    unimedida.UnimedidaID = int.Parse(tbCodigo.Text);
        //    unimedida.Sigla = tbSigla.Text;
        //    unimedida.Descricao = tbDescricao.Text;

        //    var controls = (ControlCollection)this.Controls;

        //    ok = validacao.ValidarEntidade(unimedida, controls);
        //    if (!ok)
        //    {
        //        return;
        //    }

        //    validacao.despintarCampos(controls);

        //    int resultado = unimedidaDAO.SalvaOuAtualiza(unimedida);
        //    if (resultado == 0)
        //    {
        //        MessageBox.Show("Problema ao salvar o registro",
        //        "Problema ao salvar",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Warning);
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
        //}
        //private void Recarrega()
        //{
        //    if (tbCodigo.Text.Length <= 0)
        //    {
        //        return;
        //    }

        //    if (editando)
        //    {
        //        if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
        //        "Aviso de alteração",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Warning) == DialogResult.No)
        //        {
        //            return;
        //        }
        //    }

        //    var controls = (ControlCollection)this.Controls;
        //    validacao.despintarCampos(controls);

        //    if (unimedida != null)
        //    {
        //        unimedida = unimedidaDAO.BuscaByID(unimedida.UnimedidaID);
        //        PreencheCampos(unimedida);
        //        if (editando)
        //        {
        //            Editando(false);
        //        }
        //    }
        //    else
        //    {
        //        ignoraCheckEvent = true;
        //        LimpaCampos(true);
        //        ignoraCheckEvent = false;
        //        Editando(false);
        //    }
        //}
        //private void Anterior()
        //{
        //    if (tbCodigo.Text.Length <= 0)
        //    {
        //        return;
        //    }

        //    if (editando)
        //    {
        //        if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
        //            "Aviso de alteração",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Warning) == DialogResult.No)
        //            return;
        //    }

        //    var newUnidadeMedida = unimedidaDAO.Anterior(int.Parse(tbCodigo.Text));
        //    if (newUnidadeMedida == null)
        //    {
        //        return;
        //    }

        //    unimedida = newUnidadeMedida;
        //    codigo = unimedida.UnimedidaID;
        //    PreencheCampos(unimedida);

        //    if (editando)
        //    {
        //        Editando(false);
        //    }

        //    var controls = (ControlCollection)this.Controls;
        //    validacao.despintarCampos(controls);
        //}
        //private void Proximo()
        //{
        //    if (tbCodigo.Text.Length <= 0)
        //    {
        //        return;
        //    }

        //    if (editando)
        //    {
        //        if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?",
        //            "Aviso de alteração",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Warning) == DialogResult.No)
        //            return;
        //    }

        //    var newUnidadeMedida = unimedidaDAO.Proximo(int.Parse(tbCodigo.Text));
        //    if (newUnidadeMedida == null)
        //    {
        //        return;
        //    }

        //    unimedida = newUnidadeMedida;
        //    codigo = unimedida.UnimedidaID;
        //    PreencheCampos(unimedida);
        //    if (editando)
        //    {
        //        Editando(false);
        //    }

        //    var controls = (ControlCollection)this.Controls;
        //    validacao.despintarCampos(controls);
        //}
        //private void CarregaDados()
        //{
        //    int c;
        //    if (!int.TryParse(tbCodigo.Text, out c))
        //    {
        //        tbCodigo.Clear();
        //    }
        //    else
        //    {
        //        if (c != codigo)
        //        {
        //            if (editando)
        //            {
        //                if (MessageBox.Show("Tem certeza que deseja perder os dados alterados?", "Aviso de alteração",
        //                    MessageBoxButtons.YesNo,
        //                    MessageBoxIcon.Warning) == DialogResult.No)
        //                {
        //                    return;
        //                }
        //            }
        //            codigo = c;
        //        }
        //    }

        //    if (unimedida?.UnimedidaID == codigo)
        //    {
        //        return;
        //    }

        //    if (tbCodigo.Text.Length == 0)
        //    {
        //        LimpaCampos(true);
        //        Editando(false);
        //        return;
        //    }

        //    var novaUnidadeMedida = unimedidaDAO.BuscaByID(int.Parse(tbCodigo.Text));
        //    if (novaUnidadeMedida != null)
        //    {
        //        unimedida = novaUnidadeMedida;
        //        codigo = unimedida.UnimedidaID;
        //        PreencheCampos(unimedida);
        //        Editando(false);
        //    }
        //    else
        //    {
        //        Editando(true);
        //        LimpaCampos(false);
        //    }
        //    var controls = (ControlCollection)this.Controls;
        //    validacao.despintarCampos(controls);
        //}
        //private void PreencheCampos(Caixa caixa)
        //{
        //    ignoraCheckEvent = true;
        //    LimpaCampos(false);
        //    tbCodigo.Text = unimedida.UnimedidaID.ToString();
        //    tbSigla.Text = unimedida.Sigla;
        //    tbDescricao.Text = unimedida.Descricao;
        //    this.unimedida = unimedida;
        //    ignoraCheckEvent = false;
        //}
        //private void LimpaCampos(bool limpaCodigo)
        //{
        //    if (limpaCodigo) { tbCodigo.Clear(); }
        //    tbSigla.Clear();
        //    tbDescricao.Clear();
        //    unimedida = null;
        //}
        //private void Editando(bool edit)
        //{
        //    if (!ignoraCheckEvent)
        //    {
        //        editando = edit;
        //        menuVertical.Editando(edit, Nivel, CodGrupoUsuario);
        //    }
        //}
        //private void EnterTab(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        this.SelectNextControl((Control)sender, true, true, true, true);
        //        e.Handled = e.SuppressKeyPress = true;
        //    }
        //}
        //private void SetarNivel()
        //{
        //    logado = logadoDAO.BuscaByMac(adap.Mac);
        //    CodGrupoUsuario = logado.Usuario.Grupousuario.GrupoUsuarioID.ToString();
        //    var Codpermissao = permissaoDAO.BuscarIDbyCodigo("010700").ToString();
        //    Nivel = permissaoDAO.BuscarNivelPermissao(CodGrupoUsuario, Codpermissao);
        //    Editando(editando);
        //}
    }
}
