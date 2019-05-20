namespace _5gpro.Controls
{
    partial class BuscaCidade
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
            this.tbNomeCidade = new System.Windows.Forms.TextBox();
            this.tbCodigoCidade = new System.Windows.Forms.TextBox();
            this.lbFiltroCidade = new System.Windows.Forms.Label();
            this.btBuscaCidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNomeCidade
            // 
            this.tbNomeCidade.Location = new System.Drawing.Point(94, 17);
            this.tbNomeCidade.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeCidade.Name = "tbNomeCidade";
            this.tbNomeCidade.ReadOnly = true;
            this.tbNomeCidade.Size = new System.Drawing.Size(346, 20);
            this.tbNomeCidade.TabIndex = 3;
            this.tbNomeCidade.TabStop = false;
            // 
            // tbCodigoCidade
            // 
            this.tbCodigoCidade.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoCidade.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoCidade.MaxLength = 5;
            this.tbCodigoCidade.Name = "tbCodigoCidade";
            this.tbCodigoCidade.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoCidade.TabIndex = 1;
            this.tbCodigoCidade.TextChanged += new System.EventHandler(this.TbCodigoCidade_TextChanged);
            this.tbCodigoCidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbFiltroCodigoCidade_KeyUp);
            this.tbCodigoCidade.Leave += new System.EventHandler(this.TbFiltroCodigoCidade_Leave);
            // 
            // lbFiltroCidade
            // 
            this.lbFiltroCidade.AutoSize = true;
            this.lbFiltroCidade.Location = new System.Drawing.Point(3, 1);
            this.lbFiltroCidade.Margin = new System.Windows.Forms.Padding(2);
            this.lbFiltroCidade.Name = "lbFiltroCidade";
            this.lbFiltroCidade.Size = new System.Drawing.Size(40, 13);
            this.lbFiltroCidade.TabIndex = 0;
            this.lbFiltroCidade.Text = "Cidade";
            // 
            // btBuscaCidade
            // 
            this.btBuscaCidade.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaCidade.Location = new System.Drawing.Point(70, 16);
            this.btBuscaCidade.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscaCidade.Name = "btBuscaCidade";
            this.btBuscaCidade.Size = new System.Drawing.Size(22, 22);
            this.btBuscaCidade.TabIndex = 2;
            this.btBuscaCidade.TabStop = false;
            this.btBuscaCidade.UseVisualStyleBackColor = true;
            this.btBuscaCidade.Click += new System.EventHandler(this.BtBuscaCidade_Click);
            // 
            // BuscaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaCidade);
            this.Controls.Add(this.tbNomeCidade);
            this.Controls.Add(this.tbCodigoCidade);
            this.Controls.Add(this.lbFiltroCidade);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscaCidade";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaCidade;
        private System.Windows.Forms.TextBox tbNomeCidade;
        private System.Windows.Forms.TextBox tbCodigoCidade;
        private System.Windows.Forms.Label lbFiltroCidade;
    }
}
