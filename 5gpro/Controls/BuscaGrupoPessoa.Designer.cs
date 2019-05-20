namespace _5gpro.Controls
{
    partial class BuscaGrupoPessoa
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
            this.tbCodigoGrupoPessoa = new System.Windows.Forms.TextBox();
            this.tbNomeGrupoPessoa = new System.Windows.Forms.TextBox();
            this.btBuscaGrupoPessoa = new System.Windows.Forms.Button();
            this.lbGrupoPessoa = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCodigoGrupoPessoa
            // 
            this.tbCodigoGrupoPessoa.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoGrupoPessoa.Name = "tbCodigoGrupoPessoa";
            this.tbCodigoGrupoPessoa.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoGrupoPessoa.TabIndex = 1;
            this.tbCodigoGrupoPessoa.TextChanged += new System.EventHandler(this.TbCodigoGrupoPessoa_TextChanged);
            this.tbCodigoGrupoPessoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoGrupoPessoa_KeyUp);
            this.tbCodigoGrupoPessoa.Leave += new System.EventHandler(this.TbCodigoGrupoPessoa_Leave);
            // 
            // tbNomeGrupoPessoa
            // 
            this.tbNomeGrupoPessoa.Location = new System.Drawing.Point(94, 17);
            this.tbNomeGrupoPessoa.Name = "tbNomeGrupoPessoa";
            this.tbNomeGrupoPessoa.ReadOnly = true;
            this.tbNomeGrupoPessoa.Size = new System.Drawing.Size(346, 20);
            this.tbNomeGrupoPessoa.TabIndex = 3;
            // 
            // btBuscaGrupoPessoa
            // 
            this.btBuscaGrupoPessoa.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaGrupoPessoa.Location = new System.Drawing.Point(70, 16);
            this.btBuscaGrupoPessoa.Name = "btBuscaGrupoPessoa";
            this.btBuscaGrupoPessoa.Size = new System.Drawing.Size(22, 22);
            this.btBuscaGrupoPessoa.TabIndex = 2;
            this.btBuscaGrupoPessoa.UseVisualStyleBackColor = true;
            this.btBuscaGrupoPessoa.Click += new System.EventHandler(this.BtBuscaGrupoPessoa_Click);
            // 
            // lbGrupoPessoa
            // 
            this.lbGrupoPessoa.AutoSize = true;
            this.lbGrupoPessoa.Location = new System.Drawing.Point(3, 1);
            this.lbGrupoPessoa.Name = "lbGrupoPessoa";
            this.lbGrupoPessoa.Size = new System.Drawing.Size(74, 13);
            this.lbGrupoPessoa.TabIndex = 0;
            this.lbGrupoPessoa.Text = "Grupo Pessoa";
            // 
            // btAdd
            // 
            this.btAdd.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btAdd.Location = new System.Drawing.Point(442, 16);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(22, 22);
            this.btAdd.TabIndex = 4;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BuscaGrupoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbGrupoPessoa);
            this.Controls.Add(this.btBuscaGrupoPessoa);
            this.Controls.Add(this.tbNomeGrupoPessoa);
            this.Controls.Add(this.tbCodigoGrupoPessoa);
            this.Name = "BuscaGrupoPessoa";
            this.Size = new System.Drawing.Size(465, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigoGrupoPessoa;
        private System.Windows.Forms.TextBox tbNomeGrupoPessoa;
        private System.Windows.Forms.Button btBuscaGrupoPessoa;
        private System.Windows.Forms.Label lbGrupoPessoa;
        private System.Windows.Forms.Button btAdd;
    }
}
