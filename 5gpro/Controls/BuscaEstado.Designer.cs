namespace _5gpro.Controls
{
    partial class BuscaEstado
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
            this.btBuscaEstado = new System.Windows.Forms.Button();
            this.tbNomeEstado = new System.Windows.Forms.TextBox();
            this.tbCodigoEstado = new System.Windows.Forms.TextBox();
            this.lbFiltroEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBuscaEstado
            // 
            this.btBuscaEstado.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaEstado.Location = new System.Drawing.Point(70, 16);
            this.btBuscaEstado.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscaEstado.Name = "btBuscaEstado";
            this.btBuscaEstado.Size = new System.Drawing.Size(22, 22);
            this.btBuscaEstado.TabIndex = 2;
            this.btBuscaEstado.TabStop = false;
            this.btBuscaEstado.UseVisualStyleBackColor = true;
            this.btBuscaEstado.Click += new System.EventHandler(this.BtBuscaEstado_Click);
            // 
            // tbNomeEstado
            // 
            this.tbNomeEstado.Location = new System.Drawing.Point(94, 17);
            this.tbNomeEstado.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeEstado.Name = "tbNomeEstado";
            this.tbNomeEstado.ReadOnly = true;
            this.tbNomeEstado.Size = new System.Drawing.Size(346, 20);
            this.tbNomeEstado.TabIndex = 3;
            this.tbNomeEstado.TabStop = false;
            // 
            // tbCodigoEstado
            // 
            this.tbCodigoEstado.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoEstado.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoEstado.MaxLength = 5;
            this.tbCodigoEstado.Name = "tbCodigoEstado";
            this.tbCodigoEstado.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoEstado.TabIndex = 1;
            this.tbCodigoEstado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoEstado_KeyUp);
            this.tbCodigoEstado.Leave += new System.EventHandler(this.TbCodigoEstado_Leave);
            // 
            // lbFiltroEstado
            // 
            this.lbFiltroEstado.AutoSize = true;
            this.lbFiltroEstado.Location = new System.Drawing.Point(3, 1);
            this.lbFiltroEstado.Margin = new System.Windows.Forms.Padding(2);
            this.lbFiltroEstado.Name = "lbFiltroEstado";
            this.lbFiltroEstado.Size = new System.Drawing.Size(40, 13);
            this.lbFiltroEstado.TabIndex = 0;
            this.lbFiltroEstado.Text = "Estado";
            // 
            // BuscaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btBuscaEstado);
            this.Controls.Add(this.tbNomeEstado);
            this.Controls.Add(this.tbCodigoEstado);
            this.Controls.Add(this.lbFiltroEstado);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscaEstado";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaEstado;
        private System.Windows.Forms.TextBox tbNomeEstado;
        private System.Windows.Forms.TextBox tbCodigoEstado;
        private System.Windows.Forms.Label lbFiltroEstado;
    }
}
