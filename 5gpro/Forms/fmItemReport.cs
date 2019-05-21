using _5gpro.Reports;
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
    public partial class fmItemReport : Form
    {
        public fmItemReport()
        {
            InitializeComponent();
        }

        private void BtGerar_Click(object sender, EventArgs e)
        {
            var RelatorioItem = new fmRltItem(buscaSubGrupoItem.subgrupoItem);
            RelatorioItem.Show(this);
        }

        private void BuscaGrupoItem1_Leave(object sender, EventArgs e)
        {
            buscaSubGrupoItem.EnviarGrupo(buscaGrupoItem.grupoItem);
            if (buscaGrupoItem.grupoItem == null)
            {
                buscaSubGrupoItem.Limpa();
                buscaSubGrupoItem.EscolhaOGrupo(false);
            }
            else
            {
                buscaSubGrupoItem.EscolhaOGrupo(true);
            }
        }

        private void BuscaGrupoItem1_Text_Changed(object sender, EventArgs e)
        {
            buscaSubGrupoItem.Limpa();
        }
    }
}
