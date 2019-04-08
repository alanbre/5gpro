namespace _5gpro.Forms
{
    partial class fmCadastroUsuario
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
            this.pnDadosGerais = new System.Windows.Forms.Panel();
            this.lbConfirmaSenha = new System.Windows.Forms.Label();
            this.cbMostrarSenhaUsuario = new System.Windows.Forms.CheckBox();
            this.tbConfirmaSenhaUsuario = new System.Windows.Forms.TextBox();
            this.lbConfirmaSenhaUsuario = new System.Windows.Forms.Label();
            this.tbSenhaUsuario = new System.Windows.Forms.TextBox();
            this.lbSenhaUsuario = new System.Windows.Forms.Label();
            this.lbGrupoUsuario = new System.Windows.Forms.Label();
            this.tbNomeGrupoUsuario = new System.Windows.Forms.TextBox();
            this.lbCodigoUsuario = new System.Windows.Forms.Label();
            this.btGrupoUsuario = new System.Windows.Forms.Button();
            this.tbCodigoUsuario = new System.Windows.Forms.TextBox();
            this.tbCodGrupoUsuario = new System.Windows.Forms.TextBox();
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.lbSobrenomeUsuario = new System.Windows.Forms.Label();
            this.tbSobrenomeUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtbTelefoneUsuario = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefoneUsuario = new System.Windows.Forms.Label();
            this.tbEmailUsuario = new System.Windows.Forms.TextBox();
            this.lbEmailUsuario = new System.Windows.Forms.Label();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.pnDadosGerais.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDadosGerais
            // 
            this.pnDadosGerais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDadosGerais.Controls.Add(this.lbConfirmaSenha);
            this.pnDadosGerais.Controls.Add(this.cbMostrarSenhaUsuario);
            this.pnDadosGerais.Controls.Add(this.tbConfirmaSenhaUsuario);
            this.pnDadosGerais.Controls.Add(this.lbConfirmaSenhaUsuario);
            this.pnDadosGerais.Controls.Add(this.tbSenhaUsuario);
            this.pnDadosGerais.Controls.Add(this.lbSenhaUsuario);
            this.pnDadosGerais.Controls.Add(this.lbGrupoUsuario);
            this.pnDadosGerais.Controls.Add(this.tbNomeGrupoUsuario);
            this.pnDadosGerais.Controls.Add(this.lbCodigoUsuario);
            this.pnDadosGerais.Controls.Add(this.btGrupoUsuario);
            this.pnDadosGerais.Controls.Add(this.tbCodigoUsuario);
            this.pnDadosGerais.Controls.Add(this.tbCodGrupoUsuario);
            this.pnDadosGerais.Location = new System.Drawing.Point(72, 14);
            this.pnDadosGerais.Name = "pnDadosGerais";
            this.pnDadosGerais.Size = new System.Drawing.Size(750, 184);
            this.pnDadosGerais.TabIndex = 0;
            // 
            // lbConfirmaSenha
            // 
            this.lbConfirmaSenha.AutoSize = true;
            this.lbConfirmaSenha.ForeColor = System.Drawing.Color.Red;
            this.lbConfirmaSenha.Location = new System.Drawing.Point(266, 111);
            this.lbConfirmaSenha.Name = "lbConfirmaSenha";
            this.lbConfirmaSenha.Size = new System.Drawing.Size(114, 13);
            this.lbConfirmaSenha.TabIndex = 9;
            this.lbConfirmaSenha.Text = "Senhas não são iguais";
            this.lbConfirmaSenha.Visible = false;
            // 
            // cbMostrarSenhaUsuario
            // 
            this.cbMostrarSenhaUsuario.AutoSize = true;
            this.cbMostrarSenhaUsuario.Location = new System.Drawing.Point(262, 69);
            this.cbMostrarSenhaUsuario.Name = "cbMostrarSenhaUsuario";
            this.cbMostrarSenhaUsuario.Size = new System.Drawing.Size(61, 17);
            this.cbMostrarSenhaUsuario.TabIndex = 4;
            this.cbMostrarSenhaUsuario.TabStop = false;
            this.cbMostrarSenhaUsuario.Text = "Mostrar";
            this.cbMostrarSenhaUsuario.UseVisualStyleBackColor = true;
            this.cbMostrarSenhaUsuario.CheckedChanged += new System.EventHandler(this.cbMostrarSenhaUsuario_CheckedChanged);
            // 
            // tbConfirmaSenhaUsuario
            // 
            this.tbConfirmaSenhaUsuario.Location = new System.Drawing.Point(9, 105);
            this.tbConfirmaSenhaUsuario.Name = "tbConfirmaSenhaUsuario";
            this.tbConfirmaSenhaUsuario.PasswordChar = '*';
            this.tbConfirmaSenhaUsuario.Size = new System.Drawing.Size(250, 20);
            this.tbConfirmaSenhaUsuario.TabIndex = 6;
            this.tbConfirmaSenhaUsuario.TextChanged += new System.EventHandler(this.tbConfirmaSenhaUsuario_TextChanged);
            this.tbConfirmaSenhaUsuario.Leave += new System.EventHandler(this.tbConfirmaSenhaUsuario_Leave);
            // 
            // lbConfirmaSenhaUsuario
            // 
            this.lbConfirmaSenhaUsuario.AutoSize = true;
            this.lbConfirmaSenhaUsuario.Location = new System.Drawing.Point(6, 89);
            this.lbConfirmaSenhaUsuario.Name = "lbConfirmaSenhaUsuario";
            this.lbConfirmaSenhaUsuario.Size = new System.Drawing.Size(89, 13);
            this.lbConfirmaSenhaUsuario.TabIndex = 5;
            this.lbConfirmaSenhaUsuario.Text = "Confirme a senha";
            // 
            // tbSenhaUsuario
            // 
            this.tbSenhaUsuario.Location = new System.Drawing.Point(9, 66);
            this.tbSenhaUsuario.Name = "tbSenhaUsuario";
            this.tbSenhaUsuario.PasswordChar = '*';
            this.tbSenhaUsuario.Size = new System.Drawing.Size(250, 20);
            this.tbSenhaUsuario.TabIndex = 3;
            this.tbSenhaUsuario.TextChanged += new System.EventHandler(this.tbSenhaUsuario_TextChanged);
            this.tbSenhaUsuario.Leave += new System.EventHandler(this.tbSenhaUsuario_Leave);
            // 
            // lbSenhaUsuario
            // 
            this.lbSenhaUsuario.AutoSize = true;
            this.lbSenhaUsuario.Location = new System.Drawing.Point(6, 50);
            this.lbSenhaUsuario.Name = "lbSenhaUsuario";
            this.lbSenhaUsuario.Size = new System.Drawing.Size(38, 13);
            this.lbSenhaUsuario.TabIndex = 2;
            this.lbSenhaUsuario.Text = "Senha";
            // 
            // lbGrupoUsuario
            // 
            this.lbGrupoUsuario.AutoSize = true;
            this.lbGrupoUsuario.Location = new System.Drawing.Point(7, 128);
            this.lbGrupoUsuario.Name = "lbGrupoUsuario";
            this.lbGrupoUsuario.Size = new System.Drawing.Size(75, 13);
            this.lbGrupoUsuario.TabIndex = 7;
            this.lbGrupoUsuario.Text = "Grupo Usuário";
            // 
            // tbNomeGrupoUsuario
            // 
            this.tbNomeGrupoUsuario.Enabled = false;
            this.tbNomeGrupoUsuario.Location = new System.Drawing.Point(103, 144);
            this.tbNomeGrupoUsuario.Name = "tbNomeGrupoUsuario";
            this.tbNomeGrupoUsuario.Size = new System.Drawing.Size(433, 20);
            this.tbNomeGrupoUsuario.TabIndex = 10;
            this.tbNomeGrupoUsuario.TabStop = false;
            this.tbNomeGrupoUsuario.TextChanged += new System.EventHandler(this.tbNomeGrupoUsuario_TextChanged);
            // 
            // lbCodigoUsuario
            // 
            this.lbCodigoUsuario.AutoSize = true;
            this.lbCodigoUsuario.Location = new System.Drawing.Point(6, 4);
            this.lbCodigoUsuario.Name = "lbCodigoUsuario";
            this.lbCodigoUsuario.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoUsuario.TabIndex = 0;
            this.lbCodigoUsuario.Text = "Código";
            // 
            // btGrupoUsuario
            // 
            this.btGrupoUsuario.Location = new System.Drawing.Point(80, 144);
            this.btGrupoUsuario.Name = "btGrupoUsuario";
            this.btGrupoUsuario.Size = new System.Drawing.Size(20, 20);
            this.btGrupoUsuario.TabIndex = 9;
            this.btGrupoUsuario.TabStop = false;
            this.btGrupoUsuario.UseVisualStyleBackColor = true;
            this.btGrupoUsuario.Click += new System.EventHandler(this.btGrupoUsuario_Click);
            // 
            // tbCodigoUsuario
            // 
            this.tbCodigoUsuario.Location = new System.Drawing.Point(9, 27);
            this.tbCodigoUsuario.Name = "tbCodigoUsuario";
            this.tbCodigoUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoUsuario.TabIndex = 1;
            this.tbCodigoUsuario.Leave += new System.EventHandler(this.tbCodigoUsuario_Leave);
            // 
            // tbCodGrupoUsuario
            // 
            this.tbCodGrupoUsuario.Location = new System.Drawing.Point(9, 144);
            this.tbCodGrupoUsuario.Name = "tbCodGrupoUsuario";
            this.tbCodGrupoUsuario.Size = new System.Drawing.Size(68, 20);
            this.tbCodGrupoUsuario.TabIndex = 8;
            this.tbCodGrupoUsuario.TextChanged += new System.EventHandler(this.tbCodigoUsuario_TextChanged);
            this.tbCodGrupoUsuario.Leave += new System.EventHandler(this.tbCodGrupoUsuario_Leave);
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(9, 29);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.Size = new System.Drawing.Size(527, 20);
            this.tbNomeUsuario.TabIndex = 1;
            this.tbNomeUsuario.TextChanged += new System.EventHandler(this.tbNomeUsuario_TextChanged);
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Location = new System.Drawing.Point(7, 15);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbNomeUsuario.TabIndex = 0;
            this.lbNomeUsuario.Text = "Nome";
            // 
            // lbSobrenomeUsuario
            // 
            this.lbSobrenomeUsuario.AutoSize = true;
            this.lbSobrenomeUsuario.Location = new System.Drawing.Point(7, 52);
            this.lbSobrenomeUsuario.Name = "lbSobrenomeUsuario";
            this.lbSobrenomeUsuario.Size = new System.Drawing.Size(61, 13);
            this.lbSobrenomeUsuario.TabIndex = 2;
            this.lbSobrenomeUsuario.Text = "Sobrenome";
            // 
            // tbSobrenomeUsuario
            // 
            this.tbSobrenomeUsuario.Location = new System.Drawing.Point(9, 68);
            this.tbSobrenomeUsuario.Name = "tbSobrenomeUsuario";
            this.tbSobrenomeUsuario.Size = new System.Drawing.Size(527, 20);
            this.tbSobrenomeUsuario.TabIndex = 3;
            this.tbSobrenomeUsuario.TextChanged += new System.EventHandler(this.tbSobrenomeUsuario_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mtbTelefoneUsuario);
            this.panel2.Controls.Add(this.lbTelefoneUsuario);
            this.panel2.Controls.Add(this.tbEmailUsuario);
            this.panel2.Controls.Add(this.lbEmailUsuario);
            this.panel2.Controls.Add(this.lbNomeUsuario);
            this.panel2.Controls.Add(this.tbNomeUsuario);
            this.panel2.Controls.Add(this.tbSobrenomeUsuario);
            this.panel2.Controls.Add(this.lbSobrenomeUsuario);
            this.panel2.Location = new System.Drawing.Point(72, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 184);
            this.panel2.TabIndex = 1;
            // 
            // mtbTelefoneUsuario
            // 
            this.mtbTelefoneUsuario.Location = new System.Drawing.Point(9, 147);
            this.mtbTelefoneUsuario.Mask = "(##) ####-####";
            this.mtbTelefoneUsuario.Name = "mtbTelefoneUsuario";
            this.mtbTelefoneUsuario.Size = new System.Drawing.Size(153, 20);
            this.mtbTelefoneUsuario.TabIndex = 7;
            this.mtbTelefoneUsuario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefoneUsuario_MaskInputRejected);
            // 
            // lbTelefoneUsuario
            // 
            this.lbTelefoneUsuario.AutoSize = true;
            this.lbTelefoneUsuario.Location = new System.Drawing.Point(7, 130);
            this.lbTelefoneUsuario.Name = "lbTelefoneUsuario";
            this.lbTelefoneUsuario.Size = new System.Drawing.Size(49, 13);
            this.lbTelefoneUsuario.TabIndex = 6;
            this.lbTelefoneUsuario.Text = "Telefone";
            // 
            // tbEmailUsuario
            // 
            this.tbEmailUsuario.Location = new System.Drawing.Point(9, 107);
            this.tbEmailUsuario.Name = "tbEmailUsuario";
            this.tbEmailUsuario.Size = new System.Drawing.Size(527, 20);
            this.tbEmailUsuario.TabIndex = 5;
            this.tbEmailUsuario.TextChanged += new System.EventHandler(this.tbEmailUsuario_TextChanged);
            // 
            // lbEmailUsuario
            // 
            this.lbEmailUsuario.AutoSize = true;
            this.lbEmailUsuario.Location = new System.Drawing.Point(7, 91);
            this.lbEmailUsuario.Name = "lbEmailUsuario";
            this.lbEmailUsuario.Size = new System.Drawing.Size(32, 13);
            this.lbEmailUsuario.TabIndex = 4;
            this.lbEmailUsuario.Text = "Email";
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(72, 421);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(750, 20);
            this.tbAjuda.TabIndex = 3;
            this.tbAjuda.TabStop = false;
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(11, 11);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 2;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical_Proximo_Clicked);
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical_Excluir_Clicked);
            // 
            // fmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 453);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnDadosGerais);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(10, 11);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 492);
            this.Name = "fmCadastroUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmCadastroUsuario_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FmCadastroUsuario_KeyUp);
            this.pnDadosGerais.ResumeLayout(false);
            this.pnDadosGerais.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnDadosGerais;
        private System.Windows.Forms.Label lbCodigoUsuario;
        private System.Windows.Forms.TextBox tbCodigoUsuario;
        private System.Windows.Forms.TextBox tbSobrenomeUsuario;
        private System.Windows.Forms.Label lbSobrenomeUsuario;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.TextBox tbNomeUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbCodGrupoUsuario;
        private System.Windows.Forms.Label lbTelefoneUsuario;
        private System.Windows.Forms.TextBox tbEmailUsuario;
        private System.Windows.Forms.Label lbEmailUsuario;
        private System.Windows.Forms.TextBox tbNomeGrupoUsuario;
        private System.Windows.Forms.Button btGrupoUsuario;
        private System.Windows.Forms.Label lbGrupoUsuario;
        private System.Windows.Forms.TextBox tbSenhaUsuario;
        private System.Windows.Forms.Label lbSenhaUsuario;
        private System.Windows.Forms.TextBox tbConfirmaSenhaUsuario;
        private System.Windows.Forms.Label lbConfirmaSenhaUsuario;
        private System.Windows.Forms.CheckBox cbMostrarSenhaUsuario;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneUsuario;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.Label lbConfirmaSenha;
        private Controls.MenuVertical menuVertical;
    }
}