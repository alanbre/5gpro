namespace _5gpro.Controls
{
    partial class BuscaSubGrupoPessoa
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
            this.lbSubGrupoPessoa = new System.Windows.Forms.Label();
            this.tbCodigoSubGrupoPessoa = new System.Windows.Forms.TextBox();
            this.tbNomeSubGrupoPessoa = new System.Windows.Forms.TextBox();
            this.btBuscaSubGrupoPessoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSubGrupoPessoa
            // 
            this.lbSubGrupoPessoa.AutoSize = true;
            this.lbSubGrupoPessoa.Location = new System.Drawing.Point(3, 1);
            this.lbSubGrupoPessoa.Name = "lbSubGrupoPessoa";
            this.lbSubGrupoPessoa.Size = new System.Drawing.Size(96, 13);
            this.lbSubGrupoPessoa.TabIndex = 0;
            this.lbSubGrupoPessoa.Text = "Sub-Grupo Pessoa";
            // 
            // tbCodigoSubGrupoPessoa
            // 
            this.tbCodigoSubGrupoPessoa.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoSubGrupoPessoa.Name = "tbCodigoSubGrupoPessoa";
            this.tbCodigoSubGrupoPessoa.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoSubGrupoPessoa.TabIndex = 1;
            // 
            // tbNomeSubGrupoPessoa
            // 
            this.tbNomeSubGrupoPessoa.Location = new System.Drawing.Point(94, 17);
            this.tbNomeSubGrupoPessoa.Name = "tbNomeSubGrupoPessoa";
            this.tbNomeSubGrupoPessoa.ReadOnly = true;
            this.tbNomeSubGrupoPessoa.Size = new System.Drawing.Size(346, 20);
            this.tbNomeSubGrupoPessoa.TabIndex = 2;
            this.tbNomeSubGrupoPessoa.Text = "Escolha o Grupo";
            // 
            // btBuscaSubGrupoPessoa
            // 
            this.btBuscaSubGrupoPessoa.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaSubGrupoPessoa.Location = new System.Drawing.Point(70, 16);
            this.btBuscaSubGrupoPessoa.Name = "btBuscaSubGrupoPessoa";
            this.btBuscaSubGrupoPessoa.Size = new System.Drawing.Size(22, 22);
            this.btBuscaSubGrupoPessoa.TabIndex = 3;
            this.btBuscaSubGrupoPessoa.UseVisualStyleBackColor = true;
            // 
            // BuscaSubGrupoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaSubGrupoPessoa);
            this.Controls.Add(this.tbNomeSubGrupoPessoa);
            this.Controls.Add(this.tbCodigoSubGrupoPessoa);
            this.Controls.Add(this.lbSubGrupoPessoa);
            this.Name = "BuscaSubGrupoPessoa";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubGrupoPessoa;
        private System.Windows.Forms.TextBox tbCodigoSubGrupoPessoa;
        private System.Windows.Forms.TextBox tbNomeSubGrupoPessoa;
        private System.Windows.Forms.Button btBuscaSubGrupoPessoa;
    }
}
