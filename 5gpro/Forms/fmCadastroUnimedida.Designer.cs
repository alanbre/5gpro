namespace _5gpro.Forms
{
    partial class fmCadastroUnimedida
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.gbUnimedidaCad = new System.Windows.Forms.GroupBox();
            this.lbSigla = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbUnimedidaCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(244, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 2;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(163, 92);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(244, 92);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(82, 92);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 6;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // gbUnimedidaCad
            // 
            this.gbUnimedidaCad.Controls.Add(this.lbCodigo);
            this.gbUnimedidaCad.Controls.Add(this.lbDescricao);
            this.gbUnimedidaCad.Controls.Add(this.lbSigla);
            this.gbUnimedidaCad.Controls.Add(this.textBox2);
            this.gbUnimedidaCad.Controls.Add(this.textBox1);
            this.gbUnimedidaCad.Controls.Add(this.textBox3);
            this.gbUnimedidaCad.Location = new System.Drawing.Point(12, 12);
            this.gbUnimedidaCad.Name = "gbUnimedidaCad";
            this.gbUnimedidaCad.Size = new System.Drawing.Size(306, 74);
            this.gbUnimedidaCad.TabIndex = 7;
            this.gbUnimedidaCad.TabStop = false;
            this.gbUnimedidaCad.Text = "Unidade de Medida";
            this.gbUnimedidaCad.Enter += new System.EventHandler(this.GbUnimedidaCad_Enter);
            // 
            // lbSigla
            // 
            this.lbSigla.AutoSize = true;
            this.lbSigla.Location = new System.Drawing.Point(241, 29);
            this.lbSigla.Name = "lbSigla";
            this.lbSigla.Size = new System.Drawing.Size(30, 13);
            this.lbSigla.TabIndex = 3;
            this.lbSigla.Text = "Sigla";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(77, 29);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 4;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(7, 29);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 5;
            this.lbCodigo.Text = "Código";
            // 
            // fmCadastroUnimedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 129);
            this.Controls.Add(this.gbUnimedidaCad);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCadastroUnimedida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de unidade de medida";
            this.gbUnimedidaCad.ResumeLayout(false);
            this.gbUnimedidaCad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.GroupBox gbUnimedidaCad;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbSigla;
    }
}