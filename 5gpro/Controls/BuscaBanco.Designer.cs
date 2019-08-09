namespace _5gpro.Controls
{
    partial class BuscaBanco
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
            this.btBuscaBanco = new System.Windows.Forms.Button();
            this.tbNomeBanco = new System.Windows.Forms.TextBox();
            this.tbCodigoBanco = new System.Windows.Forms.TextBox();
            this.lbFiltroBanco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBuscaBanco
            // 
            this.btBuscaBanco.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaBanco.Location = new System.Drawing.Point(69, 17);
            this.btBuscaBanco.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscaBanco.Name = "btBuscaBanco";
            this.btBuscaBanco.Size = new System.Drawing.Size(22, 22);
            this.btBuscaBanco.TabIndex = 2;
            this.btBuscaBanco.TabStop = false;
            this.btBuscaBanco.UseVisualStyleBackColor = true;
            this.btBuscaBanco.Click += new System.EventHandler(this.BtBuscaBanco_Click);
            // 
            // tbNomeBanco
            // 
            this.tbNomeBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeBanco.Location = new System.Drawing.Point(93, 18);
            this.tbNomeBanco.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeBanco.Name = "tbNomeBanco";
            this.tbNomeBanco.ReadOnly = true;
            this.tbNomeBanco.Size = new System.Drawing.Size(346, 20);
            this.tbNomeBanco.TabIndex = 3;
            this.tbNomeBanco.TabStop = false;
            // 
            // tbCodigoBanco
            // 
            this.tbCodigoBanco.Location = new System.Drawing.Point(5, 18);
            this.tbCodigoBanco.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoBanco.MaxLength = 3;
            this.tbCodigoBanco.Name = "tbCodigoBanco";
            this.tbCodigoBanco.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoBanco.TabIndex = 1;
            this.tbCodigoBanco.TextChanged += new System.EventHandler(this.TbCodigoBanco_TextChanged);
            this.tbCodigoBanco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoBanco_KeyUp);
            this.tbCodigoBanco.Leave += new System.EventHandler(this.TbCodigoBanco_Leave);
            // 
            // lbFiltroBanco
            // 
            this.lbFiltroBanco.AutoSize = true;
            this.lbFiltroBanco.Location = new System.Drawing.Point(2, 2);
            this.lbFiltroBanco.Margin = new System.Windows.Forms.Padding(2);
            this.lbFiltroBanco.Name = "lbFiltroBanco";
            this.lbFiltroBanco.Size = new System.Drawing.Size(38, 13);
            this.lbFiltroBanco.TabIndex = 0;
            this.lbFiltroBanco.Text = "Banco";
            // 
            // BuscaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaBanco);
            this.Controls.Add(this.tbNomeBanco);
            this.Controls.Add(this.tbCodigoBanco);
            this.Controls.Add(this.lbFiltroBanco);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscaBanco";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaBanco;
        private System.Windows.Forms.TextBox tbNomeBanco;
        private System.Windows.Forms.TextBox tbCodigoBanco;
        private System.Windows.Forms.Label lbFiltroBanco;
    }
}
