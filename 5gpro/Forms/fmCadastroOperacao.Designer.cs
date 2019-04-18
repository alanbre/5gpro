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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbCondicaoOperacao = new System.Windows.Forms.GroupBox();
            this.rbAprazo = new System.Windows.Forms.RadioButton();
            this.rbAvista = new System.Windows.Forms.RadioButton();
            this.tcOpcoes = new System.Windows.Forms.TabControl();
            this.tpAvista = new System.Windows.Forms.TabPage();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.tbDeconto = new System.Windows.Forms.TextBox();
            this.tpAprazo = new System.Windows.Forms.TabPage();
            this.btDias = new System.Windows.Forms.Button();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.tbNparcelas = new System.Windows.Forms.TextBox();
            this.lbNparcelas = new System.Windows.Forms.Label();
            this.lbAcrescimo = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuVertical1 = new _5gpro.Controls.MenuVertical();
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
            this.gbDadosOperacao.Controls.Add(this.textBox3);
            this.gbDadosOperacao.Controls.Add(this.textBox2);
            this.gbDadosOperacao.Controls.Add(this.textBox1);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 134);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 61);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 3;
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
            this.tcOpcoes.Size = new System.Drawing.Size(466, 206);
            this.tcOpcoes.TabIndex = 3;
            // 
            // tpAvista
            // 
            this.tpAvista.Controls.Add(this.lbDesconto);
            this.tpAvista.Controls.Add(this.tbDeconto);
            this.tpAvista.Location = new System.Drawing.Point(4, 22);
            this.tpAvista.Name = "tpAvista";
            this.tpAvista.Padding = new System.Windows.Forms.Padding(3);
            this.tpAvista.Size = new System.Drawing.Size(651, 218);
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
            // tbDeconto
            // 
            this.tbDeconto.Location = new System.Drawing.Point(6, 19);
            this.tbDeconto.Name = "tbDeconto";
            this.tbDeconto.Size = new System.Drawing.Size(100, 20);
            this.tbDeconto.TabIndex = 0;
            // 
            // tpAprazo
            // 
            this.tpAprazo.Controls.Add(this.textBox4);
            this.tpAprazo.Controls.Add(this.lbAcrescimo);
            this.tpAprazo.Controls.Add(this.btDias);
            this.tpAprazo.Controls.Add(this.gbEntrada);
            this.tpAprazo.Controls.Add(this.tbEntrada);
            this.tpAprazo.Controls.Add(this.tbNparcelas);
            this.tpAprazo.Controls.Add(this.lbNparcelas);
            this.tpAprazo.Location = new System.Drawing.Point(4, 22);
            this.tpAprazo.Name = "tpAprazo";
            this.tpAprazo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAprazo.Size = new System.Drawing.Size(458, 180);
            this.tpAprazo.TabIndex = 1;
            this.tpAprazo.Text = "Opções A Prazo";
            this.tpAprazo.UseVisualStyleBackColor = true;
            // 
            // btDias
            // 
            this.btDias.Location = new System.Drawing.Point(126, 18);
            this.btDias.Name = "btDias";
            this.btDias.Size = new System.Drawing.Size(41, 23);
            this.btDias.TabIndex = 7;
            this.btDias.Text = "Dias";
            this.btDias.UseVisualStyleBackColor = true;
            this.btDias.Click += new System.EventHandler(this.BtDias_Click);
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbNao);
            this.gbEntrada.Controls.Add(this.rbSim);
            this.gbEntrada.Location = new System.Drawing.Point(6, 46);
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
            this.tbEntrada.Location = new System.Drawing.Point(6, 96);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(114, 20);
            this.tbEntrada.TabIndex = 5;
            // 
            // tbNparcelas
            // 
            this.tbNparcelas.Location = new System.Drawing.Point(6, 20);
            this.tbNparcelas.Name = "tbNparcelas";
            this.tbNparcelas.Size = new System.Drawing.Size(114, 20);
            this.tbNparcelas.TabIndex = 1;
            // 
            // lbNparcelas
            // 
            this.lbNparcelas.AutoSize = true;
            this.lbNparcelas.Location = new System.Drawing.Point(3, 3);
            this.lbNparcelas.Name = "lbNparcelas";
            this.lbNparcelas.Size = new System.Drawing.Size(63, 13);
            this.lbNparcelas.TabIndex = 0;
            this.lbNparcelas.Text = "Nº Parcelas";
            // 
            // lbAcrescimo
            // 
            this.lbAcrescimo.AutoSize = true;
            this.lbAcrescimo.Location = new System.Drawing.Point(7, 123);
            this.lbAcrescimo.Name = "lbAcrescimo";
            this.lbAcrescimo.Size = new System.Drawing.Size(56, 13);
            this.lbAcrescimo.TabIndex = 8;
            this.lbAcrescimo.Text = "Acréscimo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 9;
            // 
            // menuVertical1
            // 
            this.menuVertical1.Location = new System.Drawing.Point(9, 9);
            this.menuVertical1.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical1.Name = "menuVertical1";
            this.menuVertical1.Size = new System.Drawing.Size(53, 364);
            this.menuVertical1.TabIndex = 0;
            // 
            // fmCadastroOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 538);
            this.Controls.Add(this.tcOpcoes);
            this.Controls.Add(this.gbCondicaoOperacao);
            this.Controls.Add(this.gbDadosOperacao);
            this.Controls.Add(this.menuVertical1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCadastroOperacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Operação";
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

        }

        #endregion

        private Controls.MenuVertical menuVertical1;
        private System.Windows.Forms.GroupBox gbDadosOperacao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gbCondicaoOperacao;
        private System.Windows.Forms.RadioButton rbAprazo;
        private System.Windows.Forms.RadioButton rbAvista;
        private System.Windows.Forms.TabControl tcOpcoes;
        private System.Windows.Forms.TabPage tpAvista;
        private System.Windows.Forms.TextBox tbDeconto;
        private System.Windows.Forms.TabPage tpAprazo;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.TextBox tbNparcelas;
        private System.Windows.Forms.Label lbNparcelas;
        private System.Windows.Forms.Button btDias;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbAcrescimo;
    }
}