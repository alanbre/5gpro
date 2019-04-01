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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroPessoas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroItens = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroOrcamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntradaDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeGrupoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastros,
            this.tsmiOrcamento,
            this.tsmiEstoque});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1162, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMenu";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastroPessoas,
            this.tsmiCadastroPaises,
            this.tsmiCadastroItens,
            this.tsmiCadastroUsuarios,
            this.cadastroDeGrupoDeUsuáriosToolStripMenuItem});
            this.tsmiCadastros.Name = "tsmiCadastros";
            this.tsmiCadastros.Size = new System.Drawing.Size(66, 20);
            this.tsmiCadastros.Text = "Cadastro";
            // 
            // tsmiCadastroPessoas
            // 
            this.tsmiCadastroPessoas.Name = "tsmiCadastroPessoas";
            this.tsmiCadastroPessoas.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroPessoas.Text = "Cadastro de Pessoas";
            this.tsmiCadastroPessoas.Click += new System.EventHandler(this.tsmiCadastroPessoas_Click);
            // 
            // tsmiCadastroPaises
            // 
            this.tsmiCadastroPaises.Name = "tsmiCadastroPaises";
            this.tsmiCadastroPaises.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroPaises.Text = "Cadastro de Paises";
            this.tsmiCadastroPaises.Click += new System.EventHandler(this.tsmiCadastroPaises_Click);
            // 
            // tsmiCadastroItens
            // 
            this.tsmiCadastroItens.Name = "tsmiCadastroItens";
            this.tsmiCadastroItens.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroItens.Text = "Cadastro de Itens";
            this.tsmiCadastroItens.Click += new System.EventHandler(this.tsmiCadastroItens_Click);
            // 
            // tsmiCadastroUsuarios
            // 
            this.tsmiCadastroUsuarios.Name = "tsmiCadastroUsuarios";
            this.tsmiCadastroUsuarios.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroUsuarios.Text = "Cadastro de Usuários";
            this.tsmiCadastroUsuarios.Click += new System.EventHandler(this.tsmiCadastroUsuariosMenuItem_Click);
            // 
            // tsmiOrcamento
            // 
            this.tsmiOrcamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastroOrcamentos});
            this.tsmiOrcamento.Name = "tsmiOrcamento";
            this.tsmiOrcamento.Size = new System.Drawing.Size(79, 20);
            this.tsmiOrcamento.Text = "Orçamento";
            // 
            // tsmiCadastroOrcamentos
            // 
            this.tsmiCadastroOrcamentos.Name = "tsmiCadastroOrcamentos";
            this.tsmiCadastroOrcamentos.Size = new System.Drawing.Size(208, 22);
            this.tsmiCadastroOrcamentos.Text = "Cadastros de orçamentos";
            this.tsmiCadastroOrcamentos.Click += new System.EventHandler(this.tsmiCadastroOrcamentos_Click);
            // 
            // tsmiEstoque
            // 
            this.tsmiEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEntradaDoc});
            this.tsmiEstoque.Name = "tsmiEstoque";
            this.tsmiEstoque.Size = new System.Drawing.Size(61, 20);
            this.tsmiEstoque.Text = "Estoque";
            // 
            // tsmiEntradaDoc
            // 
            this.tsmiEntradaDoc.Name = "tsmiEntradaDoc";
            this.tsmiEntradaDoc.Size = new System.Drawing.Size(200, 22);
            this.tsmiEntradaDoc.Text = "Entrada de documentos";
            this.tsmiEntradaDoc.Click += new System.EventHandler(this.tsmiEntradaDoc_Click);
            // 
            // cadastroDeGrupoDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeGrupoDeUsuáriosToolStripMenuItem.Name = "cadastroDeGrupoDeUsuáriosToolStripMenuItem";
            this.cadastroDeGrupoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.cadastroDeGrupoDeUsuáriosToolStripMenuItem.Text = "Cadastro de Grupo de Usuários";
            this.cadastroDeGrupoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeGrupoDeUsuáriosToolStripMenuItem_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 585);
            this.Controls.Add(this.msMain);
            this.Name = "fmMain";
            this.Text = "5GPro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroPessoas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroPaises;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroItens;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrcamento;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroOrcamentos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstoque;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntradaDoc;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeGrupoDeUsuáriosToolStripMenuItem;
    }
}

