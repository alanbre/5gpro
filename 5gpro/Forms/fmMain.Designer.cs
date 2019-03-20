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
<<<<<<< HEAD:5gpro/Forms/formMain.Designer.cs
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosDePessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "msMenu";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosDePessoasToolStripMenuItem,
            this.cadastroDePaisesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrosDePessoasToolStripMenuItem
            // 
            this.cadastrosDePessoasToolStripMenuItem.Name = "cadastrosDePessoasToolStripMenuItem";
            this.cadastrosDePessoasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cadastrosDePessoasToolStripMenuItem.Text = "Cadastros de pessoas";
            this.cadastrosDePessoasToolStripMenuItem.Click += new System.EventHandler(this.cadastrosDePessoasToolStripMenuItem_Click);
            // 
            // cadastroDePaisesToolStripMenuItem
            // 
            this.cadastroDePaisesToolStripMenuItem.Name = "cadastroDePaisesToolStripMenuItem";
            this.cadastroDePaisesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cadastroDePaisesToolStripMenuItem.Text = "Cadastro de Paises";
            this.cadastroDePaisesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePaisesToolStripMenuItem_Click);
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

=======
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosDePessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeItensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "msMenu";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosDePessoasToolStripMenuItem,
            this.cadastroDeFuncionáriosToolStripMenuItem,
            this.cadastroDeItensToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrosDePessoasToolStripMenuItem
            // 
            this.cadastrosDePessoasToolStripMenuItem.Name = "cadastrosDePessoasToolStripMenuItem";
            this.cadastrosDePessoasToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastrosDePessoasToolStripMenuItem.Text = "Cadastros de pessoas";
            this.cadastrosDePessoasToolStripMenuItem.Click += new System.EventHandler(this.cadastrosDePessoasToolStripMenuItem_Click);
            // 
            // cadastroDeFuncionáriosToolStripMenuItem
            // 
            this.cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
            this.cadastroDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de funcionários";
            this.cadastroDeFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionáriosToolStripMenuItem_Click);
            // 
            // cadastroDeItensToolStripMenuItem
            // 
            this.cadastroDeItensToolStripMenuItem.Name = "cadastroDeItensToolStripMenuItem";
            this.cadastroDeItensToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastroDeItensToolStripMenuItem.Text = "Cadastro de itens";
            this.cadastroDeItensToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeItensToolStripMenuItem_Click);
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

>>>>>>> master:5gpro/Forms/fmMain.Designer.cs
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
<<<<<<< HEAD:5gpro/Forms/formMain.Designer.cs
        private System.Windows.Forms.ToolStripMenuItem cadastrosDePessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePaisesToolStripMenuItem;
=======
        private System.Windows.Forms.ToolStripMenuItem cadastrosDePessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeItensToolStripMenuItem;
>>>>>>> master:5gpro/Forms/fmMain.Designer.cs
    }
}

