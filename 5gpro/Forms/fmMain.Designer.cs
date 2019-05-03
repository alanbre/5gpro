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
            this.tsmiCadastroGrupoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroDeOperações = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroOrcamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmissaoNF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContasReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroContaReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastros,
            this.tsmiOrcamento,
            this.tsmiSaida,
            this.tsmiContasReceber});
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
            this.tsmiCadastroGrupoUsuario,
            this.tsmiCadastroDeOperações});
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
            this.tsmiCadastroUsuarios.Click += new System.EventHandler(this.tsmiCadastroUsuarios_Click);
            // 
            // tsmiCadastroGrupoUsuario
            // 
            this.tsmiCadastroGrupoUsuario.Name = "tsmiCadastroGrupoUsuario";
            this.tsmiCadastroGrupoUsuario.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroGrupoUsuario.Text = "Cadastro de Grupo de Usuários";
            this.tsmiCadastroGrupoUsuario.Click += new System.EventHandler(this.tsmiCadastroDeGrupoDeUsuários_Click);
            // 
            // tsmiCadastroDeOperações
            // 
            this.tsmiCadastroDeOperações.Name = "tsmiCadastroDeOperações";
            this.tsmiCadastroDeOperações.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroDeOperações.Text = "Cadastro de Operações";
            this.tsmiCadastroDeOperações.Click += new System.EventHandler(this.tsmiCadastroDeOperações_Click);
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
            // tsmiSaida
            // 
            this.tsmiSaida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmissaoNF});
            this.tsmiSaida.Name = "tsmiSaida";
            this.tsmiSaida.Size = new System.Drawing.Size(47, 20);
            this.tsmiSaida.Text = "Saída";
            // 
            // tsmiEmissaoNF
            // 
            this.tsmiEmissaoNF.Name = "tsmiEmissaoNF";
            this.tsmiEmissaoNF.Size = new System.Drawing.Size(190, 22);
            this.tsmiEmissaoNF.Text = "Emissão de nota fiscal";
            this.tsmiEmissaoNF.Click += new System.EventHandler(this.tsmiEmissaoNF_Click);
            // 
            // tsmiContasReceber
            // 
            this.tsmiContasReceber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastroContaReceber});
            this.tsmiContasReceber.Name = "tsmiContasReceber";
            this.tsmiContasReceber.Size = new System.Drawing.Size(107, 20);
            this.tsmiContasReceber.Text = "Contas a receber";
            // 
            // tsmiCadastroContaReceber
            // 
            this.tsmiCadastroContaReceber.Name = "tsmiCadastroContaReceber";
            this.tsmiCadastroContaReceber.Size = new System.Drawing.Size(170, 22);
            this.tsmiCadastroContaReceber.Text = "Cadastro de conta";
            this.tsmiCadastroContaReceber.Click += new System.EventHandler(this.TsmiCadastroContaReceber_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmMain_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiSaida;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmissaoNF;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroGrupoUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroDeOperações;
        private System.Windows.Forms.ToolStripMenuItem tsmiContasReceber;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroContaReceber;
    }
}

