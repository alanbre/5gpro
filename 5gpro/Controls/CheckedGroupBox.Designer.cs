namespace _5gpro.Controls
{
    partial class CheckedGroupBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDados.Controls.Add(this.cbName);
            this.gbDados.Location = new System.Drawing.Point(0, 0);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(536, 247);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(0, 3);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(15, 14);
            this.cbName.TabIndex = 0;
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.CbName_CheckedChanged);
            // 
            // CheckedGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDados);
            this.Name = "CheckedGroupBox";
            this.Size = new System.Drawing.Size(536, 247);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox gbDados;
        protected System.Windows.Forms.CheckBox cbName;
    }
}
