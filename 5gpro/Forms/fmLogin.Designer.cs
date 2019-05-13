namespace _5gpro.Forms
{
    partial class fmLogin
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
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btProcuraUsuario = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(20, 86);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(204, 20);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.Enter += new System.EventHandler(this.tbSenha_Enter);
            this.tbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSenha_KeyDown);
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(84, 48);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.ReadOnly = true;
            this.tbNomeUsuario.Size = new System.Drawing.Size(140, 20);
            this.tbNomeUsuario.TabIndex = 7;
            this.tbNomeUsuario.TabStop = false;
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.White;
            this.btEntrar.Location = new System.Drawing.Point(43, 112);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.ForeColor = System.Drawing.Color.Black;
            this.lbCodigo.Location = new System.Drawing.Point(20, 31);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.ForeColor = System.Drawing.Color.Black;
            this.lbSenha.Location = new System.Drawing.Point(20, 70);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha";
            // 
            // btProcuraUsuario
            // 
            this.btProcuraUsuario.Location = new System.Drawing.Point(62, 47);
            this.btProcuraUsuario.Name = "btProcuraUsuario";
            this.btProcuraUsuario.Size = new System.Drawing.Size(20, 20);
            this.btProcuraUsuario.TabIndex = 6;
            this.btProcuraUsuario.TabStop = false;
            this.btProcuraUsuario.UseVisualStyleBackColor = true;
            this.btProcuraUsuario.Click += new System.EventHandler(this.btProcuraUsuario_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(130, 112);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(20, 47);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(40, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Enter += new System.EventHandler(this.tbLogin_Enter);
            this.tbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(245, 170);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbNomeUsuario);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.btProcuraUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(245, 170);
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btProcuraUsuario;
        private System.Windows.Forms.TextBox tbNomeUsuario;
    }
}