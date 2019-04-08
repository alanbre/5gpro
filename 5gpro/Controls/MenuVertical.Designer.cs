namespace _5gpro.Controls
{
    partial class MenuVertical
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
            this.btRecarregar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRecarregar
            // 
            this.btRecarregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRecarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRecarregar.Image = global::_5gpro.Properties.Resources.iosReload_43px_blue;
            this.btRecarregar.Location = new System.Drawing.Point(2, 158);
            this.btRecarregar.Margin = new System.Windows.Forms.Padding(2);
            this.btRecarregar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Size = new System.Drawing.Size(48, 48);
            this.btRecarregar.TabIndex = 3;
            this.btRecarregar.UseVisualStyleBackColor = true;
            this.btRecarregar.Click += new System.EventHandler(this.BtRecarregar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.Enabled = false;
            this.btSalvar.Image = global::_5gpro.Properties.Resources.iosOk_48px_Green;
            this.btSalvar.Location = new System.Drawing.Point(2, 106);
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
            this.btExcluir.Location = new System.Drawing.Point(2, 314);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.MinimumSize = new System.Drawing.Size(48, 48);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(48, 48);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovo.Image = global::_5gpro.Properties.Resources.iosPlus_48px_blue;
            this.btNovo.Location = new System.Drawing.Point(2, 2);
            this.btNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btNovo.MinimumSize = new System.Drawing.Size(48, 48);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(48, 48);
            this.btNovo.TabIndex = 1;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnterior.Image = global::_5gpro.Properties.Resources.iosLeft_48px_Blue;
            this.btAnterior.Location = new System.Drawing.Point(2, 210);
            this.btAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btAnterior.MinimumSize = new System.Drawing.Size(48, 48);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(48, 48);
            this.btAnterior.TabIndex = 4;
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.BtAnterior_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Image = global::_5gpro.Properties.Resources.iosSearch_45px_Blue;
            this.btBuscar.Location = new System.Drawing.Point(2, 54);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(48, 48);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // btProximo
            // 
            this.btProximo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btProximo.Image = global::_5gpro.Properties.Resources.iosRight_48px_Blue;
            this.btProximo.Location = new System.Drawing.Point(2, 262);
            this.btProximo.Margin = new System.Windows.Forms.Padding(2);
            this.btProximo.MinimumSize = new System.Drawing.Size(48, 48);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(48, 48);
            this.btProximo.TabIndex = 5;
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.BtProximo_Click);
            // 
            // MenuVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRecarregar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btAnterior);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btProximo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MenuVertical";
            this.Size = new System.Drawing.Size(53, 364);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRecarregar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btNovo;
    }
}
