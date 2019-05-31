namespace _5gpro.Controls
{
    partial class BuscaUnimedida
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCodigoUnimedida = new System.Windows.Forms.TextBox();
            this.tbSiglaUnimedida = new System.Windows.Forms.TextBox();
            this.lbUnimedida = new System.Windows.Forms.Label();
            this.btBuscaUnimedida = new System.Windows.Forms.Button();
            this.tbDescricaoUnimedida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCodigoUnimedida
            // 
            this.tbCodigoUnimedida.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoUnimedida.Name = "tbCodigoUnimedida";
            this.tbCodigoUnimedida.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoUnimedida.TabIndex = 1;
            this.tbCodigoUnimedida.TextChanged += new System.EventHandler(this.TbCodigoUnimedida_TextChanged);
            this.tbCodigoUnimedida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoUnimedida_KeyUp);
            this.tbCodigoUnimedida.Leave += new System.EventHandler(this.TbCodigoUnimedida_Leave);
            // 
            // tbSiglaUnimedida
            // 
            this.tbSiglaUnimedida.Location = new System.Drawing.Point(94, 17);
            this.tbSiglaUnimedida.Name = "tbSiglaUnimedida";
            this.tbSiglaUnimedida.ReadOnly = true;
            this.tbSiglaUnimedida.Size = new System.Drawing.Size(44, 20);
            this.tbSiglaUnimedida.TabIndex = 3;
            // 
            // lbUnimedida
            // 
            this.lbUnimedida.AutoSize = true;
            this.lbUnimedida.Location = new System.Drawing.Point(3, 1);
            this.lbUnimedida.Name = "lbUnimedida";
            this.lbUnimedida.Size = new System.Drawing.Size(100, 13);
            this.lbUnimedida.TabIndex = 0;
            this.lbUnimedida.Text = "Unidade de Medida";
            // 
            // btBuscaUnimedida
            // 
            this.btBuscaUnimedida.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaUnimedida.Location = new System.Drawing.Point(70, 16);
            this.btBuscaUnimedida.Name = "btBuscaUnimedida";
            this.btBuscaUnimedida.Size = new System.Drawing.Size(22, 22);
            this.btBuscaUnimedida.TabIndex = 2;
            this.btBuscaUnimedida.UseVisualStyleBackColor = true;
            this.btBuscaUnimedida.Click += new System.EventHandler(this.BtBuscaUnimedida_Click);
            // 
            // tbDescricaoUnimedida
            // 
            this.tbDescricaoUnimedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricaoUnimedida.Location = new System.Drawing.Point(144, 17);
            this.tbDescricaoUnimedida.Name = "tbDescricaoUnimedida";
            this.tbDescricaoUnimedida.ReadOnly = true;
            this.tbDescricaoUnimedida.Size = new System.Drawing.Size(171, 20);
            this.tbDescricaoUnimedida.TabIndex = 4;
            // 
            // BuscaUnimedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDescricaoUnimedida);
            this.Controls.Add(this.btBuscaUnimedida);
            this.Controls.Add(this.lbUnimedida);
            this.Controls.Add(this.tbSiglaUnimedida);
            this.Controls.Add(this.tbCodigoUnimedida);
            this.Name = "BuscaUnimedida";
            this.Size = new System.Drawing.Size(318, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigoUnimedida;
        private System.Windows.Forms.TextBox tbSiglaUnimedida;
        private System.Windows.Forms.Label lbUnimedida;
        private System.Windows.Forms.Button btBuscaUnimedida;
        private System.Windows.Forms.TextBox tbDescricaoUnimedida;
    }
}
