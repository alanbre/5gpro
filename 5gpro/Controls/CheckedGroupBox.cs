using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5gpro.Controls
{
    public partial class CheckedGroupBox : UserControl
    {
        [Description("Texto do Label"), Category("Appearance")]
        public string LabelText
        {
            get
            {
                return cbName.Text;
            }
            set
            {
                cbName.Text = value;
            }
        }


        public CheckedGroupBox()
        {
            InitializeComponent();
        }


        private void AtivaInativa(CheckBox chk, GroupBox grp)
        {
            if (chk.Parent == grp)
            {
                
                grp.Parent.Controls.Add(chk);

                
                chk.Location = new Point(
                    chk.Left + grp.Left,
                    chk.Top + grp.Top);

                
                chk.BringToFront();
            }

            
            grp.Enabled = chk.Checked;
        }

        private void CbName_CheckedChanged(object sender, EventArgs e)
        {
            AtivaInativa(cbName, gbDados);
        }
    }
}
