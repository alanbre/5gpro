namespace _5gpro.Forms
{
    partial class fmCadastroSubGrupoPessoa
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
            this.gbCadSubGrupo = new System.Windows.Forms.GroupBox();
            this.tbNomeSub = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbNomeSub = new System.Windows.Forms.Label();
            this.lbCodigoSub = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbCadSubGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCadSubGrupo
            // 
            this.gbCadSubGrupo.Controls.Add(this.tbNomeSub);
            this.gbCadSubGrupo.Controls.Add(this.tbCodigo);
            this.gbCadSubGrupo.Controls.Add(this.lbNomeSub);
            this.gbCadSubGrupo.Controls.Add(this.lbCodigoSub);
            this.gbCadSubGrupo.Location = new System.Drawing.Point(12, 12);
            this.gbCadSubGrupo.Name = "gbCadSubGrupo";
            this.gbCadSubGrupo.Size = new System.Drawing.Size(207, 107);
            this.gbCadSubGrupo.TabIndex = 0;
            this.gbCadSubGrupo.TabStop = false;
            // 
            // tbNomeSub
            // 
            this.tbNomeSub.Location = new System.Drawing.Point(6, 71);
            this.tbNomeSub.Name = "tbNomeSub";
            this.tbNomeSub.Size = new System.Drawing.Size(177, 20);
            this.tbNomeSub.TabIndex = 3;
            this.tbNomeSub.TextChanged += new System.EventHandler(this.TbNomeSub_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(6, 32);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(105, 20);
            this.tbCodigo.TabIndex = 2;
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // lbNomeSub
            // 
            this.lbNomeSub.AutoSize = true;
            this.lbNomeSub.Location = new System.Drawing.Point(3, 55);
            this.lbNomeSub.Name = "lbNomeSub";
            this.lbNomeSub.Size = new System.Drawing.Size(35, 13);
            this.lbNomeSub.TabIndex = 1;
            this.lbNomeSub.Text = "Nome";
            // 
            // lbCodigoSub
            // 
            this.lbCodigoSub.AutoSize = true;
            this.lbCodigoSub.Location = new System.Drawing.Point(3, 15);
            this.lbCodigoSub.Name = "lbCodigoSub";
            this.lbCodigoSub.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoSub.TabIndex = 0;
            this.lbCodigoSub.Text = "Código";
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::_5gpro.Properties.Resources.iosOk_22px_Green;
            this.btSalvar.Location = new System.Drawing.Point(119, 125);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(47, 24);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::_5gpro.Properties.Resources.iosDelete_22px_Red;
            this.btCancelar.Location = new System.Drawing.Point(172, 125);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(47, 24);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // fmCadastroSubGrupoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(231, 158);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.gbCadSubGrupo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(247, 197);
            this.Name = "fmCadastroSubGrupoPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro Sub-Grupo Pessoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroSubGrupoPessoa_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroSubGrupoPessoa_KeyDown);
            this.gbCadSubGrupo.ResumeLayout(false);
            this.gbCadSubGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadSubGrupo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbNomeSub;
        private System.Windows.Forms.Label lbCodigoSub;
        private System.Windows.Forms.TextBox tbNomeSub;
        private System.Windows.Forms.TextBox tbCodigo;
    }
}