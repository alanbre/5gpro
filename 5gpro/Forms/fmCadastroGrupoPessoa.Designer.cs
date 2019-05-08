namespace _5gpro.Forms
{
    partial class fmCadastroGrupoPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuVertical1 = new _5gpro.Controls.MenuVertical();
            this.SuspendLayout();
            // 
            // menuVertical1
            // 
            this.menuVertical1.Location = new System.Drawing.Point(9, 9);
            this.menuVertical1.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical1.Name = "menuVertical1";
            this.menuVertical1.Size = new System.Drawing.Size(53, 364);
            this.menuVertical1.TabIndex = 0;
            // 
            // fmCadastroGrupoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 397);
            this.Controls.Add(this.menuVertical1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(609, 436);
            this.Name = "fmCadastroGrupoPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro Grupo Pessoa";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MenuVertical menuVertical1;
    }
}