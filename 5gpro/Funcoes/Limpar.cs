using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Funcoes
{
    public class Limpar
    {
      

        public void limparTudo(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {

                //var radioButtons = groupBox1.Controls.OfType<RadioButton>();
                //foreach (RadioButton rb in radioButtons)
                //{
                //    bool state = rb.Checked;
                //    string name = rb.Name;
                //}

                if (ctrl is GroupBox)
                {
                    if (ctrl.Name.Equals("gbTipoDePessoa"))
                    {

                        foreach (Control ctrlrb in ctrl.Controls)
                        {
                            if (ctrlrb.Name.Equals("rbPessoaFisica"))
                            {
                                ((RadioButton)(ctrlrb)).Checked = true;
                            }
                            else
                            {
                                ((RadioButton)(ctrlrb)).Checked = false;
                            }
                        }

                    }

                }

                //se for um Panel
                if (ctrl is Panel)
                {
                    foreach (Control ctrlp in ctrl.Controls)
                    {
                        if (ctrlp is TextBox)
                        {
                            ((TextBox)(ctrlp)).Text = String.Empty;
                            ctrlp.BackColor = System.Drawing.Color.White;
                        }
                        if(ctrlp is MaskedTextBox)
                        {
                            ((MaskedTextBox)(ctrlp)).Text = String.Empty;
                            ctrlp.BackColor = System.Drawing.Color.White;
                        }
                    }

                }

                //se for um TablePage
                if (ctrl is TabControl)
                {
                    foreach (TabPage page in ctrl.Controls)
                    {
                        foreach (Control ctrltabpage in page.Controls)
                        {
                            if (ctrltabpage is TextBox)
                            {
                                ((TextBox)(ctrltabpage)).Text = String.Empty;
                                ctrltabpage.BackColor = System.Drawing.Color.White;
                            }
                            if (ctrltabpage is MaskedTextBox)
                            {
                                ((MaskedTextBox)(ctrltabpage)).Text = String.Empty;
                                ctrltabpage.BackColor = System.Drawing.Color.White;
                            }
                        }
                    }
                }
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                    ctrl.BackColor = System.Drawing.Color.White;
                }
                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                    ctrl.BackColor = System.Drawing.Color.White;
                }
            }
        }

    }
}
