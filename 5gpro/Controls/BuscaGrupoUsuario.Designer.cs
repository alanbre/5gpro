namespace _5gpro.Controls
{
    partial class BuscaGrupoUsuario
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
            this.btBuscaGrupoUsuario = new System.Windows.Forms.Button();
            this.tbNomeGrupoUsuario = new System.Windows.Forms.TextBox();
            this.tbCodigoGrupoUsuario = new System.Windows.Forms.TextBox();
            this.lbGrupoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBuscaGrupoUsuario
            // 
            this.btBuscaGrupoUsuario.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaGrupoUsuario.Location = new System.Drawing.Point(70, 16);
            this.btBuscaGrupoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscaGrupoUsuario.Name = "btBuscaGrupoUsuario";
            this.btBuscaGrupoUsuario.Size = new System.Drawing.Size(22, 22);
            this.btBuscaGrupoUsuario.TabIndex = 10;
            this.btBuscaGrupoUsuario.TabStop = false;
            this.btBuscaGrupoUsuario.UseVisualStyleBackColor = true;
            this.btBuscaGrupoUsuario.Click += new System.EventHandler(this.BtBuscaGrupoUsuario_Click);
            // 
            // tbNomeGrupoUsuario
            // 
            this.tbNomeGrupoUsuario.Location = new System.Drawing.Point(94, 17);
            this.tbNomeGrupoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeGrupoUsuario.Name = "tbNomeGrupoUsuario";
            this.tbNomeGrupoUsuario.ReadOnly = true;
            this.tbNomeGrupoUsuario.Size = new System.Drawing.Size(346, 20);
            this.tbNomeGrupoUsuario.TabIndex = 11;
            this.tbNomeGrupoUsuario.TabStop = false;
            // 
            // tbCodigoGrupoUsuario
            // 
            this.tbCodigoGrupoUsuario.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoGrupoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoGrupoUsuario.MaxLength = 5;
            this.tbCodigoGrupoUsuario.Name = "tbCodigoGrupoUsuario";
            this.tbCodigoGrupoUsuario.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoGrupoUsuario.TabIndex = 9;
            this.tbCodigoGrupoUsuario.TextChanged += new System.EventHandler(this.TbCodigoGrupoUsuario_TextChanged);
            this.tbCodigoGrupoUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoGrupoUsuario_KeyUp);
            this.tbCodigoGrupoUsuario.Leave += new System.EventHandler(this.TbCodigoGrupoUsuario_Leave);
            // 
            // lbGrupoUsuario
            // 
            this.lbGrupoUsuario.AutoSize = true;
            this.lbGrupoUsuario.Location = new System.Drawing.Point(3, 1);
            this.lbGrupoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.lbGrupoUsuario.Name = "lbGrupoUsuario";
            this.lbGrupoUsuario.Size = new System.Drawing.Size(93, 13);
            this.lbGrupoUsuario.TabIndex = 8;
            this.lbGrupoUsuario.Text = "Grupo de usuários";
            // 
            // BuscaGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaGrupoUsuario);
            this.Controls.Add(this.tbNomeGrupoUsuario);
            this.Controls.Add(this.tbCodigoGrupoUsuario);
            this.Controls.Add(this.lbGrupoUsuario);
            this.Name = "BuscaGrupoUsuario";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaGrupoUsuario;
        private System.Windows.Forms.TextBox tbNomeGrupoUsuario;
        private System.Windows.Forms.TextBox tbCodigoGrupoUsuario;
        private System.Windows.Forms.Label lbGrupoUsuario;
    }
}
