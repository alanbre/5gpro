namespace _5gpro.Controls
{
    partial class BuscaPlanoContaCaixa
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btBusca = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(6, 17);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(65, 20);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.TextChanged += new System.EventHandler(this.TbCodigo_TextChanged);
            this.tbCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigo_KeyUp);
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.Location = new System.Drawing.Point(94, 17);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(168, 20);
            this.tbNome.TabIndex = 3;
            this.tbNome.TabStop = false;
            // 
            // btBusca
            // 
            this.btBusca.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBusca.Location = new System.Drawing.Point(70, 16);
            this.btBusca.Margin = new System.Windows.Forms.Padding(2);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(22, 22);
            this.btBusca.TabIndex = 1;
            this.btBusca.TabStop = false;
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.BtBusca_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // BuscaPlanoContaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCodigo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscaPlanoContaCaixa";
            this.Size = new System.Drawing.Size(264, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Label lbNome;
    }
}
