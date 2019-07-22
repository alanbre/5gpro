namespace _5gpro.Forms
{
    partial class fmCfgBase
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
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbIp = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.tbIp);
            this.gbDados.Controls.Add(this.tbSenha);
            this.gbDados.Controls.Add(this.lbSenha);
            this.gbDados.Controls.Add(this.tbUsuario);
            this.gbDados.Controls.Add(this.lbUsuario);
            this.gbDados.Controls.Add(this.lbIp);
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(266, 142);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Base de dados";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(93, 160);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(12, 160);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 1;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.BtConfirmar_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(6, 110);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(254, 20);
            this.tbSenha.TabIndex = 5;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(3, 94);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(6, 71);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(254, 20);
            this.tbUsuario.TabIndex = 3;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(3, 55);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuário";
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Location = new System.Drawing.Point(3, 16);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(72, 13);
            this.lbIp.TabIndex = 0;
            this.lbIp.Text = "IP do servidor";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(6, 32);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(254, 20);
            this.tbIp.TabIndex = 1;
            // 
            // fmCfgBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 191);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.btConfirmar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 230);
            this.Name = "fmCfgBase";
            this.ShowIcon = false;
            this.Text = "Configuração da base de dados";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox tbIp;
    }
}