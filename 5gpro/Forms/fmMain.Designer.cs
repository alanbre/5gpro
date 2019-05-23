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
            this.tsmiCadastroItens = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroGrupoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroDeOperações = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeGrupoDeItensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeGrupoDePessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroOrcamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntradaNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmissaoNF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContasReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCarCadastroContaReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCarQuitacaoConta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContasPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapCadastroConta = new System.Windows.Forms.ToolStripMenuItem();
            this.quitaçãoDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelTeste = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplorelatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioContaReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastroContaReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.Transparent;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastros,
            this.tsmiOrcamento,
            this.tsmiEntrada,
            this.tsmiSaida,
            this.tsmiContasReceber,
            this.tsmiContasPagar,
            this.relatóriosToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMain.Size = new System.Drawing.Size(1162, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMenu";
            // 
            // tsmiCadastros
            // 
            this.tsmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastroPessoas,
            this.tsmiCadastroItens,
            this.tsmiCadastroUsuarios,
            this.tsmiCadastroGrupoUsuario,
            this.tsmiCadastroDeOperações,
            this.cadastroDeGrupoDeItensToolStripMenuItem,
            this.cadastroDeGrupoDePessoasToolStripMenuItem});
            this.tsmiCadastros.Name = "tsmiCadastros";
            this.tsmiCadastros.Size = new System.Drawing.Size(66, 20);
            this.tsmiCadastros.Text = "Cadastro";
            // 
            // tsmiCadastroPessoas
            // 
            this.tsmiCadastroPessoas.Name = "tsmiCadastroPessoas";
            this.tsmiCadastroPessoas.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroPessoas.Text = "Cadastro de Pessoas";
            this.tsmiCadastroPessoas.Click += new System.EventHandler(this.TsmiCadastroPessoas_Click);
            // 
            // tsmiCadastroItens
            // 
            this.tsmiCadastroItens.Name = "tsmiCadastroItens";
            this.tsmiCadastroItens.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroItens.Text = "Cadastro de Itens";
            this.tsmiCadastroItens.Click += new System.EventHandler(this.TsmiCadastroItens_Click);
            // 
            // tsmiCadastroUsuarios
            // 
            this.tsmiCadastroUsuarios.Name = "tsmiCadastroUsuarios";
            this.tsmiCadastroUsuarios.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroUsuarios.Text = "Cadastro de Usuários";
            this.tsmiCadastroUsuarios.Click += new System.EventHandler(this.TsmiCadastroUsuarios_Click);
            // 
            // tsmiCadastroGrupoUsuario
            // 
            this.tsmiCadastroGrupoUsuario.Name = "tsmiCadastroGrupoUsuario";
            this.tsmiCadastroGrupoUsuario.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroGrupoUsuario.Text = "Cadastro de Grupo de Usuários";
            this.tsmiCadastroGrupoUsuario.Click += new System.EventHandler(this.TsmiCadastroDeGrupoDeUsuários_Click);
            // 
            // tsmiCadastroDeOperações
            // 
            this.tsmiCadastroDeOperações.Name = "tsmiCadastroDeOperações";
            this.tsmiCadastroDeOperações.Size = new System.Drawing.Size(237, 22);
            this.tsmiCadastroDeOperações.Text = "Cadastro de Operações";
            this.tsmiCadastroDeOperações.Click += new System.EventHandler(this.TsmiCadastroDeOperações_Click);
            // 
            // cadastroDeGrupoDeItensToolStripMenuItem
            // 
            this.cadastroDeGrupoDeItensToolStripMenuItem.Name = "cadastroDeGrupoDeItensToolStripMenuItem";
            this.cadastroDeGrupoDeItensToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.cadastroDeGrupoDeItensToolStripMenuItem.Text = "Cadastro de Grupo de Itens";
            this.cadastroDeGrupoDeItensToolStripMenuItem.Click += new System.EventHandler(this.CadastroDeGrupoDeItensToolStripMenuItem_Click);
            // 
            // cadastroDeGrupoDePessoasToolStripMenuItem
            // 
            this.cadastroDeGrupoDePessoasToolStripMenuItem.Name = "cadastroDeGrupoDePessoasToolStripMenuItem";
            this.cadastroDeGrupoDePessoasToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.cadastroDeGrupoDePessoasToolStripMenuItem.Text = "Cadastro de Grupo de Pessoas";
            this.cadastroDeGrupoDePessoasToolStripMenuItem.Click += new System.EventHandler(this.CadastroDeGrupoDePessoasToolStripMenuItem_Click);
            // 
            // tsmiOrcamento
            // 
            this.tsmiOrcamento.BackColor = System.Drawing.Color.Transparent;
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
            this.tsmiCadastroOrcamentos.Click += new System.EventHandler(this.TsmiCadastroOrcamentos_Click);
            // 
            // tsmiEntrada
            // 
            this.tsmiEntrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEntradaNotas});
            this.tsmiEntrada.Name = "tsmiEntrada";
            this.tsmiEntrada.Size = new System.Drawing.Size(59, 20);
            this.tsmiEntrada.Text = "Entrada";
            // 
            // tsmiEntradaNotas
            // 
            this.tsmiEntradaNotas.Name = "tsmiEntradaNotas";
            this.tsmiEntradaNotas.Size = new System.Drawing.Size(162, 22);
            this.tsmiEntradaNotas.Text = "Entrada de notas";
            this.tsmiEntradaNotas.Click += new System.EventHandler(this.TsmiEntradaNotas_Click);
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
            this.tsmiEmissaoNF.Click += new System.EventHandler(this.TsmiEmissaoNF_Click);
            // 
            // tsmiContasReceber
            // 
            this.tsmiContasReceber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCarCadastroContaReceber,
            this.tsmiCarQuitacaoConta});
            this.tsmiContasReceber.Name = "tsmiContasReceber";
            this.tsmiContasReceber.Size = new System.Drawing.Size(107, 20);
            this.tsmiContasReceber.Text = "Contas a receber";
            // 
            // tsmiCarCadastroContaReceber
            // 
            this.tsmiCarCadastroContaReceber.Name = "tsmiCarCadastroContaReceber";
            this.tsmiCarCadastroContaReceber.Size = new System.Drawing.Size(178, 22);
            this.tsmiCarCadastroContaReceber.Text = "Cadastro de Contas";
            this.tsmiCarCadastroContaReceber.Click += new System.EventHandler(this.TsmiCarCadastroContaReceber_Click);
            // 
            // tsmiCarQuitacaoConta
            // 
            this.tsmiCarQuitacaoConta.Name = "tsmiCarQuitacaoConta";
            this.tsmiCarQuitacaoConta.Size = new System.Drawing.Size(178, 22);
            this.tsmiCarQuitacaoConta.Text = "Quitação de Contas";
            this.tsmiCarQuitacaoConta.Click += new System.EventHandler(this.TsmiCarQuitacaoConta_Click);
            // 
            // tsmiContasPagar
            // 
            this.tsmiContasPagar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCapCadastroConta,
            this.quitaçãoDeContasToolStripMenuItem});
            this.tsmiContasPagar.Name = "tsmiContasPagar";
            this.tsmiContasPagar.Size = new System.Drawing.Size(98, 20);
            this.tsmiContasPagar.Text = "Contas a pagar";
            // 
            // tsmiCapCadastroConta
            // 
            this.tsmiCapCadastroConta.Name = "tsmiCapCadastroConta";
            this.tsmiCapCadastroConta.Size = new System.Drawing.Size(176, 22);
            this.tsmiCapCadastroConta.Text = "Cadastro de conta";
            this.tsmiCapCadastroConta.Click += new System.EventHandler(this.TsmiCapCadastroContaReceber_Click);
            // 
            // quitaçãoDeContasToolStripMenuItem
            // 
            this.quitaçãoDeContasToolStripMenuItem.Name = "quitaçãoDeContasToolStripMenuItem";
            this.quitaçãoDeContasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quitaçãoDeContasToolStripMenuItem.Text = "Quitação de contas";
            this.quitaçãoDeContasToolStripMenuItem.Click += new System.EventHandler(this.QuitaçãoDeContasToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRelTeste,
            this.exemplorelatorioToolStripMenuItem,
            this.relatorioDeUsuarioToolStripMenuItem,
            this.relatorioDeItemToolStripMenuItem,
            this.relatorioContaReceberToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // tsmiRelTeste
            // 
            this.tsmiRelTeste.Name = "tsmiRelTeste";
            this.tsmiRelTeste.Size = new System.Drawing.Size(201, 22);
            this.tsmiRelTeste.Text = "teste";
            this.tsmiRelTeste.Click += new System.EventHandler(this.TsmiTeste_Click);
            // 
            // exemplorelatorioToolStripMenuItem
            // 
            this.exemplorelatorioToolStripMenuItem.Name = "exemplorelatorioToolStripMenuItem";
            this.exemplorelatorioToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exemplorelatorioToolStripMenuItem.Text = "exemplorelatorio";
            this.exemplorelatorioToolStripMenuItem.Click += new System.EventHandler(this.ExemplorelatorioToolStripMenuItem_Click);
            // 
            // relatorioDeUsuarioToolStripMenuItem
            // 
            this.relatorioDeUsuarioToolStripMenuItem.Name = "relatorioDeUsuarioToolStripMenuItem";
            this.relatorioDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.relatorioDeUsuarioToolStripMenuItem.Text = "Relatorio de Usuario";
            this.relatorioDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.RelatorioDeUsuarioToolStripMenuItem_Click);
            // 
            // relatorioDeItemToolStripMenuItem
            // 
            this.relatorioDeItemToolStripMenuItem.Name = "relatorioDeItemToolStripMenuItem";
            this.relatorioDeItemToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.relatorioDeItemToolStripMenuItem.Text = "Relatorio de Item";
            this.relatorioDeItemToolStripMenuItem.Click += new System.EventHandler(this.RelatorioDeItemToolStripMenuItem_Click);
            // 
            // relatorioContaReceberToolStripMenuItem
            // 
            this.relatorioContaReceberToolStripMenuItem.Name = "relatorioContaReceberToolStripMenuItem";
            this.relatorioContaReceberToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.relatorioContaReceberToolStripMenuItem.Text = "Relatorio Conta Receber";
            this.relatorioContaReceberToolStripMenuItem.Click += new System.EventHandler(this.RelatorioContaReceberToolStripMenuItem_Click);
            // 
            // tsmiCadastroContaReceber
            // 
            this.tsmiCadastroContaReceber.Name = "tsmiCadastroContaReceber";
            this.tsmiCadastroContaReceber.Size = new System.Drawing.Size(32, 19);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 585);
            this.Controls.Add(this.msMain);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroItens;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrcamento;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroOrcamentos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaida;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmissaoNF;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroGrupoUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroDeOperações;
        private System.Windows.Forms.ToolStripMenuItem tsmiContasReceber;
        private System.Windows.Forms.ToolStripMenuItem tsmiCarCadastroContaReceber;
        private System.Windows.Forms.ToolStripMenuItem tsmiContasPagar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapCadastroConta;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastroContaReceber;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeGrupoDeItensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiCarQuitacaoConta;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeGrupoDePessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelTeste;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntrada;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntradaNotas;
        private System.Windows.Forms.ToolStripMenuItem quitaçãoDeContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplorelatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioContaReceberToolStripMenuItem;
    }
}

