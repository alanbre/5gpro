namespace _5gpro.Controls
{
    partial class BuscaItem
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
            this.lbItem = new System.Windows.Forms.Label();
            this.tbCodigoItem = new System.Windows.Forms.TextBox();
            this.tbDescricaoItem = new System.Windows.Forms.TextBox();
            this.btProcuraItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Location = new System.Drawing.Point(3, 1);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(27, 13);
            this.lbItem.TabIndex = 0;
            this.lbItem.Text = "Item";
            // 
            // tbCodigoItem
            // 
            this.tbCodigoItem.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoItem.Name = "tbCodigoItem";
            this.tbCodigoItem.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoItem.TabIndex = 1;
            this.tbCodigoItem.TextChanged += new System.EventHandler(this.TbCodigoItem_TextChanged);
            this.tbCodigoItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoItem_KeyUp);
            this.tbCodigoItem.Leave += new System.EventHandler(this.TbCodigoItem_Leave);
            // 
            // tbDescricaoItem
            // 
            this.tbDescricaoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricaoItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDescricaoItem.Location = new System.Drawing.Point(94, 17);
            this.tbDescricaoItem.Name = "tbDescricaoItem";
            this.tbDescricaoItem.ReadOnly = true;
            this.tbDescricaoItem.Size = new System.Drawing.Size(346, 20);
            this.tbDescricaoItem.TabIndex = 3;
            this.tbDescricaoItem.TabStop = false;
            // 
            // btProcuraItem
            // 
            this.btProcuraItem.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btProcuraItem.Location = new System.Drawing.Point(70, 16);
            this.btProcuraItem.Margin = new System.Windows.Forms.Padding(2);
            this.btProcuraItem.Name = "btProcuraItem";
            this.btProcuraItem.Size = new System.Drawing.Size(22, 22);
            this.btProcuraItem.TabIndex = 2;
            this.btProcuraItem.TabStop = false;
            this.btProcuraItem.UseVisualStyleBackColor = true;
            this.btProcuraItem.Click += new System.EventHandler(this.BtProcuraItem_Click);
            // 
            // BuscaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btProcuraItem);
            this.Controls.Add(this.tbDescricaoItem);
            this.Controls.Add(this.tbCodigoItem);
            this.Controls.Add(this.lbItem);
            this.Name = "BuscaItem";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.TextBox tbCodigoItem;
        private System.Windows.Forms.TextBox tbDescricaoItem;
        private System.Windows.Forms.Button btProcuraItem;
    }
}
