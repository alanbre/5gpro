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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btProcuraUsuario = new System.Windows.Forms.Button();
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new _5gpro.GradientPanel();
            this.lb5gpro = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.ForeColor = System.Drawing.Color.White;
            this.lbCodigo.Location = new System.Drawing.Point(79, 126);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(79, 142);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(40, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Enter += new System.EventHandler(this.tbLogin_Enter);
            this.tbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.ForeColor = System.Drawing.Color.White;
            this.lbSenha.Location = new System.Drawing.Point(79, 165);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(79, 181);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(204, 20);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.Enter += new System.EventHandler(this.tbSenha_Enter);
            this.tbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSenha_KeyDown);
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.White;
            this.btEntrar.Location = new System.Drawing.Point(102, 207);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 4;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(189, 207);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btProcuraUsuario
            // 
            this.btProcuraUsuario.Location = new System.Drawing.Point(121, 142);
            this.btProcuraUsuario.Name = "btProcuraUsuario";
            this.btProcuraUsuario.Size = new System.Drawing.Size(20, 20);
            this.btProcuraUsuario.TabIndex = 6;
            this.btProcuraUsuario.TabStop = false;
            this.btProcuraUsuario.UseVisualStyleBackColor = true;
            this.btProcuraUsuario.Click += new System.EventHandler(this.btProcuraUsuario_Click);
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(143, 143);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.ReadOnly = true;
            this.tbNomeUsuario.Size = new System.Drawing.Size(140, 20);
            this.tbNomeUsuario.TabIndex = 7;
            this.tbNomeUsuario.TabStop = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Black;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Blue;
            this.gradientPanel1.Controls.Add(this.lb5gpro);
            this.gradientPanel1.Controls.Add(this.tbSenha);
            this.gradientPanel1.Controls.Add(this.tbNomeUsuario);
            this.gradientPanel1.Controls.Add(this.btEntrar);
            this.gradientPanel1.Controls.Add(this.lbCodigo);
            this.gradientPanel1.Controls.Add(this.lbSenha);
            this.gradientPanel1.Controls.Add(this.btProcuraUsuario);
            this.gradientPanel1.Controls.Add(this.btSair);
            this.gradientPanel1.Controls.Add(this.tbCodigo);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(369, 256);
            this.gradientPanel1.TabIndex = 9;
            // 
            // lb5gpro
            // 
            this.lb5gpro.AutoSize = true;
            this.lb5gpro.BackColor = System.Drawing.Color.Transparent;
            this.lb5gpro.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5gpro.ForeColor = System.Drawing.Color.White;
            this.lb5gpro.Location = new System.Drawing.Point(85, 39);
            this.lb5gpro.Name = "lb5gpro";
            this.lb5gpro.Size = new System.Drawing.Size(179, 55);
            this.lb5gpro.TabIndex = 8;
            this.lb5gpro.Text = "5GPro";
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 256);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(245, 170);
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lb5gpro;
    }
}