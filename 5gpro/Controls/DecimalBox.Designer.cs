namespace _5gpro.Controls
{
    partial class DecimalBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDecimal
            // 
            this.tbDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDecimal.Location = new System.Drawing.Point(0, 0);
            this.tbDecimal.Margin = new System.Windows.Forms.Padding(0);
            this.tbDecimal.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.tbDecimal.Name = "tbDecimal";
            this.tbDecimal.Size = new System.Drawing.Size(100, 20);
            this.tbDecimal.TabIndex = 0;
            this.tbDecimal.Enter += new System.EventHandler(this.TbDecimal_Enter);
            this.tbDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbDecimal_KeyPress);
            this.tbDecimal.Leave += new System.EventHandler(this.TbDecimal_Leave);
            // 
            // DecimalBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDecimal);
            this.Name = "DecimalBox";
            this.Size = new System.Drawing.Size(100, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDecimal;
    }
}
