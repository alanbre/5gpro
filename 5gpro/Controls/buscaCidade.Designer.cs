namespace _5gpro.Controls
{
    partial class buscaCidade
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
            this.btBuscaCidade = new System.Windows.Forms.Button();
            this.tbNomeCidade = new System.Windows.Forms.TextBox();
            this.tbFiltroCodigoCidade = new System.Windows.Forms.TextBox();
            this.lbFiltroCidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBuscaCidade
            // 
            this.btBuscaCidade.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaCidade.Location = new System.Drawing.Point(67, 15);
            this.btBuscaCidade.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btBuscaCidade.Name = "btBuscaCidade";
            this.btBuscaCidade.Size = new System.Drawing.Size(22, 22);
            this.btBuscaCidade.TabIndex = 6;
            this.btBuscaCidade.TabStop = false;
            this.btBuscaCidade.UseVisualStyleBackColor = true;
            this.btBuscaCidade.Click += new System.EventHandler(this.BtBuscaCidade_Click);
            // 
            // tbNomeCidade
            // 
            this.tbNomeCidade.Location = new System.Drawing.Point(91, 16);
            this.tbNomeCidade.Name = "tbNomeCidade";
            this.tbNomeCidade.ReadOnly = true;
            this.tbNomeCidade.Size = new System.Drawing.Size(346, 20);
            this.tbNomeCidade.TabIndex = 7;
            this.tbNomeCidade.TabStop = false;
            // 
            // tbFiltroCodigoCidade
            // 
            this.tbFiltroCodigoCidade.Location = new System.Drawing.Point(3, 16);
            this.tbFiltroCodigoCidade.MaxLength = 5;
            this.tbFiltroCodigoCidade.Name = "tbFiltroCodigoCidade";
            this.tbFiltroCodigoCidade.Size = new System.Drawing.Size(65, 20);
            this.tbFiltroCodigoCidade.TabIndex = 5;
            this.tbFiltroCodigoCidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbFiltroCodigoCidade_KeyUp);
            this.tbFiltroCodigoCidade.Leave += new System.EventHandler(this.TbFiltroCodigoCidade_Leave);
            // 
            // lbFiltroCidade
            // 
            this.lbFiltroCidade.AutoSize = true;
            this.lbFiltroCidade.Location = new System.Drawing.Point(0, 0);
            this.lbFiltroCidade.Name = "lbFiltroCidade";
            this.lbFiltroCidade.Size = new System.Drawing.Size(40, 13);
            this.lbFiltroCidade.TabIndex = 4;
            this.lbFiltroCidade.Text = "Cidade";
            // 
            // buscaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaCidade);
            this.Controls.Add(this.tbNomeCidade);
            this.Controls.Add(this.tbFiltroCodigoCidade);
            this.Controls.Add(this.lbFiltroCidade);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "buscaCidade";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaCidade;
        private System.Windows.Forms.TextBox tbNomeCidade;
        private System.Windows.Forms.TextBox tbFiltroCodigoCidade;
        private System.Windows.Forms.Label lbFiltroCidade;
    }
}
