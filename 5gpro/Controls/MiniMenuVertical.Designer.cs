namespace _5gpro.Controls
{
    partial class MiniMenuVertical
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
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.Enabled = false;
            this.btSalvar.Image = global::_5gpro.Properties.Resources.iosOk_48px_Green;
            this.btSalvar.Location = new System.Drawing.Point(2, 107);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(48, 48);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluir.Enabled = false;
            this.btExcluir.Image = global::_5gpro.Properties.Resources.iosDelete_48px_Red;
            this.btExcluir.Location = new System.Drawing.Point(2, 159);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.MinimumSize = new System.Drawing.Size(48, 48);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(48, 48);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovo.Image = global::_5gpro.Properties.Resources.iosPlus_48px_blue;
            this.btNovo.Location = new System.Drawing.Point(2, 3);
            this.btNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btNovo.MinimumSize = new System.Drawing.Size(48, 48);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(48, 48);
            this.btNovo.TabIndex = 1;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Image = global::_5gpro.Properties.Resources.iosSearch_45px_Blue;
            this.btBuscar.Location = new System.Drawing.Point(2, 55);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(48, 48);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // MiniMenuVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btBuscar);
            this.Name = "MiniMenuVertical";
            this.Size = new System.Drawing.Size(53, 334);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btBuscar;
    }
}
