namespace _5gpro.Controls
{
    partial class BuscaUnidadeMedida
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
            this.btBuscaUnidadeMedida = new System.Windows.Forms.Button();
            this.tbNomeUnidadeMedida = new System.Windows.Forms.TextBox();
            this.tbCodigoUnidadeMedida = new System.Windows.Forms.TextBox();
            this.lbUnidadeMedida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBuscaUnidadeMedida
            // 
            this.btBuscaUnidadeMedida.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaUnidadeMedida.Location = new System.Drawing.Point(69, 17);
            this.btBuscaUnidadeMedida.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscaUnidadeMedida.Name = "btBuscaUnidadeMedida";
            this.btBuscaUnidadeMedida.Size = new System.Drawing.Size(22, 22);
            this.btBuscaUnidadeMedida.TabIndex = 10;
            this.btBuscaUnidadeMedida.TabStop = false;
            this.btBuscaUnidadeMedida.UseVisualStyleBackColor = true;
            this.btBuscaUnidadeMedida.Click += new System.EventHandler(this.BtBuscaUnidadeMedida_Click);
            // 
            // tbNomeUnidadeMedida
            // 
            this.tbNomeUnidadeMedida.Location = new System.Drawing.Point(93, 18);
            this.tbNomeUnidadeMedida.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeUnidadeMedida.Name = "tbNomeUnidadeMedida";
            this.tbNomeUnidadeMedida.ReadOnly = true;
            this.tbNomeUnidadeMedida.Size = new System.Drawing.Size(181, 20);
            this.tbNomeUnidadeMedida.TabIndex = 11;
            this.tbNomeUnidadeMedida.TabStop = false;
            // 
            // tbCodigoUnidadeMedida
            // 
            this.tbCodigoUnidadeMedida.Location = new System.Drawing.Point(5, 18);
            this.tbCodigoUnidadeMedida.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoUnidadeMedida.MaxLength = 5;
            this.tbCodigoUnidadeMedida.Name = "tbCodigoUnidadeMedida";
            this.tbCodigoUnidadeMedida.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoUnidadeMedida.TabIndex = 9;
            this.tbCodigoUnidadeMedida.TextChanged += new System.EventHandler(this.TbCodigoUnidadeMedida_TextChanged);
            this.tbCodigoUnidadeMedida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoUnidadeMedida_KeyUp);
            this.tbCodigoUnidadeMedida.Leave += new System.EventHandler(this.TbCodigoUnidadeMedida_Leave);
            // 
            // lbUnidadeMedida
            // 
            this.lbUnidadeMedida.AutoSize = true;
            this.lbUnidadeMedida.Location = new System.Drawing.Point(2, 2);
            this.lbUnidadeMedida.Margin = new System.Windows.Forms.Padding(2);
            this.lbUnidadeMedida.Name = "lbUnidadeMedida";
            this.lbUnidadeMedida.Size = new System.Drawing.Size(99, 13);
            this.lbUnidadeMedida.TabIndex = 8;
            this.lbUnidadeMedida.Text = "Unidade de medida";
            // 
            // BuscaUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaUnidadeMedida);
            this.Controls.Add(this.tbNomeUnidadeMedida);
            this.Controls.Add(this.tbCodigoUnidadeMedida);
            this.Controls.Add(this.lbUnidadeMedida);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscaUnidadeMedida";
            this.Size = new System.Drawing.Size(277, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaUnidadeMedida;
        private System.Windows.Forms.TextBox tbNomeUnidadeMedida;
        private System.Windows.Forms.TextBox tbCodigoUnidadeMedida;
        private System.Windows.Forms.Label lbUnidadeMedida;
    }
}
