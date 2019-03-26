namespace _5gpro
{
    partial class fmMain
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroPessoas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroItens = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrcamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroOrcamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastros,
            this.tsmiOrcamentos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "msMenu";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastroPessoas,
            this.tsmiCadastroPaises,
            this.tsmiCadastroItens});
            this.tsmiCadastros.Name = "tsmiCadastros";
            this.tsmiCadastros.Size = new System.Drawing.Size(71, 20);
            this.tsmiCadastros.Text = "Cadastros";
            // 
            // tsmiCadastroPessoas
            // 
            this.tsmiCadastroPessoas.Name = "tsmiCadastroPessoas";
            this.tsmiCadastroPessoas.Size = new System.Drawing.Size(186, 22);
            this.tsmiCadastroPessoas.Text = "Cadastros de pessoas";
            this.tsmiCadastroPessoas.Click += new System.EventHandler(this.tsmiCadastroPessoas_Click);
            // 
            // tsmiCadastroPaises
            // 
            this.tsmiCadastroPaises.Name = "tsmiCadastroPaises";
            this.tsmiCadastroPaises.Size = new System.Drawing.Size(186, 22);
            this.tsmiCadastroPaises.Text = "Cadastro de Paises";
            this.tsmiCadastroPaises.Click += new System.EventHandler(this.tsmiCadastroPaises_Click);
            // 
            // tsmiCadastroItens
            // 
            this.tsmiCadastroItens.Name = "tsmiCadastroItens";
            this.tsmiCadastroItens.Size = new System.Drawing.Size(186, 22);
            this.tsmiCadastroItens.Text = "Cadastro de Itens";
            this.tsmiCadastroItens.Click += new System.EventHandler(this.tsmiCadastroItens_Click);
            // 
            // tsmiOrcamentos
            // 
            this.tsmiOrcamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastroOrcamentos});
            this.tsmiOrcamentos.Name = "tsmiOrcamentos";
            this.tsmiOrcamentos.Size = new System.Drawing.Size(84, 20);
            this.tsmiOrcamentos.Text = "Orçamentos";
            // 
            // tsmiCadastroOrcamentos
            // 
            this.tsmiCadastroOrcamentos.Name = "tsmiCadastroOrcamentos";
            this.tsmiCadastroOrcamentos.Size = new System.Drawing.Size(208, 22);
            this.tsmiCadastroOrcamentos.Text = "Cadastros de orçamentos";
            this.tsmiCadastroOrcamentos.Click += new System.EventHandler(this.tsmiCadastroOrcamentos_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 585);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fmMain";
            this.Text = "5GPro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroPessoas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroPaises;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroItens;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrcamentos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroOrcamentos;
    }
}

