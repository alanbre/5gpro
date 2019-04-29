namespace _5gpro.Controls
{
    partial class BuscaOperacao
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
            this.btBuscaOperacao = new System.Windows.Forms.Button();
            this.tbNomeOperacao = new System.Windows.Forms.TextBox();
            this.tbCodigoOperacao = new System.Windows.Forms.TextBox();
            this.lbCodigoOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBuscaOperacao
            // 
            this.btBuscaOperacao.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaOperacao.Location = new System.Drawing.Point(69, 17);
            this.btBuscaOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscaOperacao.Name = "btBuscaOperacao";
            this.btBuscaOperacao.Size = new System.Drawing.Size(22, 22);
            this.btBuscaOperacao.TabIndex = 2;
            this.btBuscaOperacao.TabStop = false;
            this.btBuscaOperacao.UseVisualStyleBackColor = true;
            this.btBuscaOperacao.Click += new System.EventHandler(this.BtBuscaOperacao_Click);
            // 
            // tbNomeOperacao
            // 
            this.tbNomeOperacao.Location = new System.Drawing.Point(93, 18);
            this.tbNomeOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeOperacao.Name = "tbNomeOperacao";
            this.tbNomeOperacao.ReadOnly = true;
            this.tbNomeOperacao.Size = new System.Drawing.Size(346, 20);
            this.tbNomeOperacao.TabIndex = 3;
            this.tbNomeOperacao.TabStop = false;
            // 
            // tbCodigoOperacao
            // 
            this.tbCodigoOperacao.Location = new System.Drawing.Point(5, 18);
            this.tbCodigoOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoOperacao.MaxLength = 5;
            this.tbCodigoOperacao.Name = "tbCodigoOperacao";
            this.tbCodigoOperacao.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoOperacao.TabIndex = 1;
            this.tbCodigoOperacao.TextChanged += new System.EventHandler(this.TbCodigoOperacao_TextChanged);
            this.tbCodigoOperacao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoOperacao_KeyUp);
            this.tbCodigoOperacao.Leave += new System.EventHandler(this.TbCodigoOperacao_Leave);
            // 
            // lbCodigoOperacao
            // 
            this.lbCodigoOperacao.AutoSize = true;
            this.lbCodigoOperacao.Location = new System.Drawing.Point(2, 2);
            this.lbCodigoOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.lbCodigoOperacao.Name = "lbCodigoOperacao";
            this.lbCodigoOperacao.Size = new System.Drawing.Size(54, 13);
            this.lbCodigoOperacao.TabIndex = 0;
            this.lbCodigoOperacao.Text = "Operação";
            // 
            // BuscaOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaOperacao);
            this.Controls.Add(this.tbNomeOperacao);
            this.Controls.Add(this.tbCodigoOperacao);
            this.Controls.Add(this.lbCodigoOperacao);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscaOperacao";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaOperacao;
        private System.Windows.Forms.TextBox tbNomeOperacao;
        private System.Windows.Forms.TextBox tbCodigoOperacao;
        private System.Windows.Forms.Label lbCodigoOperacao;
    }
}
