namespace _5gpro.Controls
{
    partial class BuscaGrupoItem
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
            this.tbCodigoGrupoItem = new System.Windows.Forms.TextBox();
            this.btBuscaGrupoItem = new System.Windows.Forms.Button();
            this.tbNomeGrupoItem = new System.Windows.Forms.TextBox();
            this.lbGrupoItem = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCodigoGrupoItem
            // 
            this.tbCodigoGrupoItem.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoGrupoItem.Name = "tbCodigoGrupoItem";
            this.tbCodigoGrupoItem.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoGrupoItem.TabIndex = 1;
            this.tbCodigoGrupoItem.TextChanged += new System.EventHandler(this.TbCodigoGrupoItem_TextChanged);
            this.tbCodigoGrupoItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoGrupoItem_KeyUp);
            this.tbCodigoGrupoItem.Leave += new System.EventHandler(this.TbCodigoGrupoItem_Leave);
            // 
            // btBuscaGrupoItem
            // 
            this.btBuscaGrupoItem.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaGrupoItem.Location = new System.Drawing.Point(70, 16);
            this.btBuscaGrupoItem.Name = "btBuscaGrupoItem";
            this.btBuscaGrupoItem.Size = new System.Drawing.Size(22, 22);
            this.btBuscaGrupoItem.TabIndex = 2;
            this.btBuscaGrupoItem.TabStop = false;
            this.btBuscaGrupoItem.UseVisualStyleBackColor = true;
            this.btBuscaGrupoItem.Click += new System.EventHandler(this.BtBuscaGrupoItem_Click);
            // 
            // tbNomeGrupoItem
            // 
            this.tbNomeGrupoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeGrupoItem.Location = new System.Drawing.Point(94, 17);
            this.tbNomeGrupoItem.Name = "tbNomeGrupoItem";
            this.tbNomeGrupoItem.ReadOnly = true;
            this.tbNomeGrupoItem.Size = new System.Drawing.Size(346, 20);
            this.tbNomeGrupoItem.TabIndex = 3;
            this.tbNomeGrupoItem.TabStop = false;
            // 
            // lbGrupoItem
            // 
            this.lbGrupoItem.AutoSize = true;
            this.lbGrupoItem.Location = new System.Drawing.Point(3, 1);
            this.lbGrupoItem.Name = "lbGrupoItem";
            this.lbGrupoItem.Size = new System.Drawing.Size(59, 13);
            this.lbGrupoItem.TabIndex = 0;
            this.lbGrupoItem.Text = "Grupo Item";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btAdd.Location = new System.Drawing.Point(442, 16);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(22, 22);
            this.btAdd.TabIndex = 4;
            this.btAdd.TabStop = false;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BuscaGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbGrupoItem);
            this.Controls.Add(this.tbNomeGrupoItem);
            this.Controls.Add(this.btBuscaGrupoItem);
            this.Controls.Add(this.tbCodigoGrupoItem);
            this.Name = "BuscaGrupoItem";
            this.Size = new System.Drawing.Size(465, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigoGrupoItem;
        private System.Windows.Forms.Button btBuscaGrupoItem;
        private System.Windows.Forms.TextBox tbNomeGrupoItem;
        private System.Windows.Forms.Label lbGrupoItem;
        private System.Windows.Forms.Button btAdd;
    }
}
