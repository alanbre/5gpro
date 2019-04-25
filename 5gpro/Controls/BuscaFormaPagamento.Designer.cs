namespace _5gpro.Controls
{
    partial class BuscaFormaPagamento
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
            this.btBuscaFormaPagamento = new System.Windows.Forms.Button();
            this.tbNomeFormaPagamento = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento = new System.Windows.Forms.TextBox();
            this.lbCodigoFormaPagamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBuscaFormaPagamento
            // 
            this.btBuscaFormaPagamento.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaFormaPagamento.Location = new System.Drawing.Point(63, 17);
            this.btBuscaFormaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscaFormaPagamento.Name = "btBuscaFormaPagamento";
            this.btBuscaFormaPagamento.Size = new System.Drawing.Size(22, 22);
            this.btBuscaFormaPagamento.TabIndex = 6;
            this.btBuscaFormaPagamento.TabStop = false;
            this.btBuscaFormaPagamento.UseVisualStyleBackColor = true;
            this.btBuscaFormaPagamento.Click += new System.EventHandler(this.BtBuscaFormaPagamento_Click);
            // 
            // tbNomeFormaPagamento
            // 
            this.tbNomeFormaPagamento.Location = new System.Drawing.Point(89, 18);
            this.tbNomeFormaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeFormaPagamento.Name = "tbNomeFormaPagamento";
            this.tbNomeFormaPagamento.ReadOnly = true;
            this.tbNomeFormaPagamento.Size = new System.Drawing.Size(346, 20);
            this.tbNomeFormaPagamento.TabIndex = 7;
            this.tbNomeFormaPagamento.TabStop = false;
            // 
            // tbCodigoFormaPagamento
            // 
            this.tbCodigoFormaPagamento.Location = new System.Drawing.Point(0, 18);
            this.tbCodigoFormaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoFormaPagamento.MaxLength = 5;
            this.tbCodigoFormaPagamento.Name = "tbCodigoFormaPagamento";
            this.tbCodigoFormaPagamento.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoFormaPagamento.TabIndex = 5;
            this.tbCodigoFormaPagamento.TextChanged += new System.EventHandler(this.TbCodigoFormaPagamento_TextChanged);
            this.tbCodigoFormaPagamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento_KeyUp);
            this.tbCodigoFormaPagamento.Leave += new System.EventHandler(this.TbCodigoFormaPagamento_Leave);
            // 
            // lbCodigoFormaPagamento
            // 
            this.lbCodigoFormaPagamento.AutoSize = true;
            this.lbCodigoFormaPagamento.Location = new System.Drawing.Point(-3, 2);
            this.lbCodigoFormaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.lbCodigoFormaPagamento.Name = "lbCodigoFormaPagamento";
            this.lbCodigoFormaPagamento.Size = new System.Drawing.Size(107, 13);
            this.lbCodigoFormaPagamento.TabIndex = 4;
            this.lbCodigoFormaPagamento.Text = "Forma de pagamento";
            // 
            // BuscaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaFormaPagamento);
            this.Controls.Add(this.tbNomeFormaPagamento);
            this.Controls.Add(this.tbCodigoFormaPagamento);
            this.Controls.Add(this.lbCodigoFormaPagamento);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscaFormaPagamento";
            this.Size = new System.Drawing.Size(437, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaFormaPagamento;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento;
        private System.Windows.Forms.Label lbCodigoFormaPagamento;
    }
}
