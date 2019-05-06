namespace _5gpro.Forms
{
    partial class fmCadastroGrupoItem
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
            this.gbNovoGrupoItem = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.miniMenuVertical1 = new _5gpro.Controls.MiniMenuVertical();
            this.gbNovoGrupoItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 26);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código";
            // 
            // gbNovoGrupoItem
            // 
            this.gbNovoGrupoItem.Controls.Add(this.textBox2);
            this.gbNovoGrupoItem.Controls.Add(this.lbNome);
            this.gbNovoGrupoItem.Controls.Add(this.textBox1);
            this.gbNovoGrupoItem.Controls.Add(this.lbCodigo);
            this.gbNovoGrupoItem.Location = new System.Drawing.Point(41, 46);
            this.gbNovoGrupoItem.Name = "gbNovoGrupoItem";
            this.gbNovoGrupoItem.Size = new System.Drawing.Size(257, 127);
            this.gbNovoGrupoItem.TabIndex = 2;
            this.gbNovoGrupoItem.TabStop = false;
            this.gbNovoGrupoItem.Text = "Novo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 70);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(82, 13);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome do Grupo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 2;
            // 
            // miniMenuVertical1
            // 
            this.miniMenuVertical1.Location = new System.Drawing.Point(6, -1);
            this.miniMenuVertical1.Name = "miniMenuVertical1";
            this.miniMenuVertical1.Size = new System.Drawing.Size(29, 211);
            this.miniMenuVertical1.TabIndex = 3;
            // 
            // fmCadastroGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 216);
            this.Controls.Add(this.miniMenuVertical1);
            this.Controls.Add(this.gbNovoGrupoItem);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCadastroGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro Grupo de Itens";
            this.gbNovoGrupoItem.ResumeLayout(false);
            this.gbNovoGrupoItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.GroupBox gbNovoGrupoItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox textBox1;
        private Controls.MiniMenuVertical miniMenuVertical1;
    }
}