namespace _5gpro.Forms
{
    partial class fmCadastroOperacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDadosOperacao = new System.Windows.Forms.GroupBox();
            this.tbDescOperacao = new System.Windows.Forms.TextBox();
            this.tbNomeOperacao = new System.Windows.Forms.TextBox();
            this.tbCodOperacao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbCondicaoOperacao = new System.Windows.Forms.GroupBox();
            this.rbAprazo = new System.Windows.Forms.RadioButton();
            this.rbAvista = new System.Windows.Forms.RadioButton();
            this.tcOpcoes = new System.Windows.Forms.TabControl();
            this.tpAvista = new System.Windows.Forms.TabPage();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.tpAprazo = new System.Windows.Forms.TabPage();
            this.tbAcrescimo = new System.Windows.Forms.TextBox();
            this.lbAcrescimo = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.tbNparcelas = new System.Windows.Forms.TextBox();
            this.lbNparcelas = new System.Windows.Forms.Label();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.tbVisualizar = new System.Windows.Forms.TextBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.gbDadosOperacao.SuspendLayout();
            this.gbCondicaoOperacao.SuspendLayout();
            this.tcOpcoes.SuspendLayout();
            this.tpAvista.SuspendLayout();
            this.tpAprazo.SuspendLayout();
            this.gbEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosOperacao
            // 
            this.gbDadosOperacao.Controls.Add(this.tbDescOperacao);
            this.gbDadosOperacao.Controls.Add(this.tbNomeOperacao);
            this.gbDadosOperacao.Controls.Add(this.tbCodOperacao);
            this.gbDadosOperacao.Controls.Add(this.lbDescricao);
            this.gbDadosOperacao.Controls.Add(this.lbNome);
            this.gbDadosOperacao.Controls.Add(this.lbCodigo);
            this.gbDadosOperacao.Location = new System.Drawing.Point(66, 13);
            this.gbDadosOperacao.Name = "gbDadosOperacao";
            this.gbDadosOperacao.Size = new System.Drawing.Size(659, 207);
            this.gbDadosOperacao.TabIndex = 1;
            this.gbDadosOperacao.TabStop = false;
            this.gbDadosOperacao.Text = "Dados da operação";
            // 
            // tbDescOperacao
            // 
            this.tbDescOperacao.Location = new System.Drawing.Point(9, 134);
            this.tbDescOperacao.Multiline = true;
            this.tbDescOperacao.Name = "tbDescOperacao";
            this.tbDescOperacao.Size = new System.Drawing.Size(338, 61);
            this.tbDescOperacao.TabIndex = 5;
            // 
            // tbNomeOperacao
            // 
            this.tbNomeOperacao.Location = new System.Drawing.Point(9, 83);
            this.tbNomeOperacao.Name = "tbNomeOperacao";
            this.tbNomeOperacao.Size = new System.Drawing.Size(100, 20);
            this.tbNomeOperacao.TabIndex = 4;
            // 
            // tbCodOperacao
            // 
            this.tbCodOperacao.Location = new System.Drawing.Point(9, 36);
            this.tbCodOperacao.Name = "tbCodOperacao";
            this.tbCodOperacao.Size = new System.Drawing.Size(65, 20);
            this.tbCodOperacao.TabIndex = 3;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(6, 117);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 66);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 20);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // gbCondicaoOperacao
            // 
            this.gbCondicaoOperacao.Controls.Add(this.rbAprazo);
            this.gbCondicaoOperacao.Controls.Add(this.rbAvista);
            this.gbCondicaoOperacao.Location = new System.Drawing.Point(66, 227);
            this.gbCondicaoOperacao.Name = "gbCondicaoOperacao";
            this.gbCondicaoOperacao.Size = new System.Drawing.Size(138, 49);
            this.gbCondicaoOperacao.TabIndex = 2;
            this.gbCondicaoOperacao.TabStop = false;
            this.gbCondicaoOperacao.Text = "Condição";
            // 
            // rbAprazo
            // 
            this.rbAprazo.AutoSize = true;
            this.rbAprazo.Location = new System.Drawing.Point(71, 19);
            this.rbAprazo.Name = "rbAprazo";
            this.rbAprazo.Size = new System.Drawing.Size(62, 17);
            this.rbAprazo.TabIndex = 1;
            this.rbAprazo.TabStop = true;
            this.rbAprazo.Text = "A Prazo";
            this.rbAprazo.UseVisualStyleBackColor = true;
            this.rbAprazo.CheckedChanged += new System.EventHandler(this.RbAprazo_CheckedChanged);
            // 
            // rbAvista
            // 
            this.rbAvista.AutoSize = true;
            this.rbAvista.Location = new System.Drawing.Point(7, 19);
            this.rbAvista.Name = "rbAvista";
            this.rbAvista.Size = new System.Drawing.Size(58, 17);
            this.rbAvista.TabIndex = 0;
            this.rbAvista.TabStop = true;
            this.rbAvista.Text = "A Vista";
            this.rbAvista.UseVisualStyleBackColor = true;
            this.rbAvista.CheckedChanged += new System.EventHandler(this.RbAvista_CheckedChanged);
            // 
            // tcOpcoes
            // 
            this.tcOpcoes.Controls.Add(this.tpAvista);
            this.tcOpcoes.Controls.Add(this.tpAprazo);
            this.tcOpcoes.Location = new System.Drawing.Point(66, 282);
            this.tcOpcoes.Name = "tcOpcoes";
            this.tcOpcoes.SelectedIndex = 0;
            this.tcOpcoes.Size = new System.Drawing.Size(745, 241);
            this.tcOpcoes.TabIndex = 3;
            // 
            // tpAvista
            // 
            this.tpAvista.Controls.Add(this.lbDesconto);
            this.tpAvista.Controls.Add(this.tbDesconto);
            this.tpAvista.Location = new System.Drawing.Point(4, 22);
            this.tpAvista.Name = "tpAvista";
            this.tpAvista.Padding = new System.Windows.Forms.Padding(3);
            this.tpAvista.Size = new System.Drawing.Size(737, 215);
            this.tpAvista.TabIndex = 0;
            this.tpAvista.Text = "Opções A Vista";
            this.tpAvista.UseVisualStyleBackColor = true;
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(6, 3);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(53, 13);
            this.lbDesconto.TabIndex = 1;
            this.lbDesconto.Text = "Desconto";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(6, 19);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(100, 20);
            this.tbDesconto.TabIndex = 0;
            // 
            // tpAprazo
            // 
            this.tpAprazo.Controls.Add(this.btRemover);
            this.tpAprazo.Controls.Add(this.tbVisualizar);
            this.tpAprazo.Controls.Add(this.btGerar);
            this.tpAprazo.Controls.Add(this.tbAcrescimo);
            this.tpAprazo.Controls.Add(this.lbAcrescimo);
            this.tpAprazo.Controls.Add(this.btEditar);
            this.tpAprazo.Controls.Add(this.gbEntrada);
            this.tpAprazo.Controls.Add(this.tbEntrada);
            this.tpAprazo.Controls.Add(this.tbNparcelas);
            this.tpAprazo.Controls.Add(this.lbNparcelas);
            this.tpAprazo.Location = new System.Drawing.Point(4, 22);
            this.tpAprazo.Name = "tpAprazo";
            this.tpAprazo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAprazo.Size = new System.Drawing.Size(737, 215);
            this.tpAprazo.TabIndex = 1;
            this.tpAprazo.Text = "Opções A Prazo";
            this.tpAprazo.UseVisualStyleBackColor = true;
            // 
            // tbAcrescimo
            // 
            this.tbAcrescimo.Location = new System.Drawing.Point(15, 119);
            this.tbAcrescimo.Name = "tbAcrescimo";
            this.tbAcrescimo.Size = new System.Drawing.Size(114, 20);
            this.tbAcrescimo.TabIndex = 9;
            // 
            // lbAcrescimo
            // 
            this.lbAcrescimo.AutoSize = true;
            this.lbAcrescimo.Location = new System.Drawing.Point(16, 102);
            this.lbAcrescimo.Name = "lbAcrescimo";
            this.lbAcrescimo.Size = new System.Drawing.Size(56, 13);
            this.lbAcrescimo.TabIndex = 8;
            this.lbAcrescimo.Text = "Acréscimo";
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(298, 67);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(67, 23);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbNao);
            this.gbEntrada.Controls.Add(this.rbSim);
            this.gbEntrada.Location = new System.Drawing.Point(15, 25);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(114, 44);
            this.gbEntrada.TabIndex = 6;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Checked = true;
            this.rbNao.Location = new System.Drawing.Point(59, 19);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 4;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.RbNao_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(11, 19);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 3;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.RbSim_CheckedChanged);
            // 
            // tbEntrada
            // 
            this.tbEntrada.Enabled = false;
            this.tbEntrada.Location = new System.Drawing.Point(15, 75);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(114, 20);
            this.tbEntrada.TabIndex = 5;
            // 
            // tbNparcelas
            // 
            this.tbNparcelas.Location = new System.Drawing.Point(162, 42);
            this.tbNparcelas.Name = "tbNparcelas";
            this.tbNparcelas.Size = new System.Drawing.Size(114, 20);
            this.tbNparcelas.TabIndex = 1;
            this.tbNparcelas.TextChanged += new System.EventHandler(this.TbNparcelas_TextChanged);
            this.tbNparcelas.Leave += new System.EventHandler(this.TbNparcelas_Leave);
            // 
            // lbNparcelas
            // 
            this.lbNparcelas.AutoSize = true;
            this.lbNparcelas.Location = new System.Drawing.Point(159, 25);
            this.lbNparcelas.Name = "lbNparcelas";
            this.lbNparcelas.Size = new System.Drawing.Size(63, 13);
            this.lbNparcelas.TabIndex = 0;
            this.lbNparcelas.Text = "Nº Parcelas";
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 0;
            // 
            // tbAjuda
            // 
            this.tbAjuda.Enabled = false;
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(70, 529);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.Size = new System.Drawing.Size(741, 20);
            this.tbAjuda.TabIndex = 8;
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(232, 66);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(44, 23);
            this.btGerar.TabIndex = 10;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.BtGerar_Click);
            // 
            // tbVisualizar
            // 
            this.tbVisualizar.Location = new System.Drawing.Point(298, 41);
            this.tbVisualizar.Name = "tbVisualizar";
            this.tbVisualizar.Size = new System.Drawing.Size(149, 20);
            this.tbVisualizar.TabIndex = 11;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(372, 66);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 12;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // fmCadastroOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.tcOpcoes);
            this.Controls.Add(this.gbCondicaoOperacao);
            this.Controls.Add(this.gbDadosOperacao);
            this.Controls.Add(this.menuVertical);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 600);
            this.MinimizeBox = false;
            this.Name = "fmCadastroOperacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Operação";
            this.Load += new System.EventHandler(this.FmCadastroOperacao_Load);
            this.gbDadosOperacao.ResumeLayout(false);
            this.gbDadosOperacao.PerformLayout();
            this.gbCondicaoOperacao.ResumeLayout(false);
            this.gbCondicaoOperacao.PerformLayout();
            this.tcOpcoes.ResumeLayout(false);
            this.tpAvista.ResumeLayout(false);
            this.tpAvista.PerformLayout();
            this.tpAprazo.ResumeLayout(false);
            this.tpAprazo.PerformLayout();
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.GroupBox gbDadosOperacao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbCodOperacao;
        private System.Windows.Forms.TextBox tbNomeOperacao;
        private System.Windows.Forms.TextBox tbDescOperacao;
        private System.Windows.Forms.GroupBox gbCondicaoOperacao;
        private System.Windows.Forms.RadioButton rbAprazo;
        private System.Windows.Forms.RadioButton rbAvista;
        private System.Windows.Forms.TabControl tcOpcoes;
        private System.Windows.Forms.TabPage tpAvista;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.TabPage tpAprazo;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.TextBox tbNparcelas;
        private System.Windows.Forms.Label lbNparcelas;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox tbAcrescimo;
        private System.Windows.Forms.Label lbAcrescimo;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.TextBox tbVisualizar;
        private System.Windows.Forms.Button btRemover;
    }
}