namespace _5gpro.Forms
{
    partial class fmBuscaContaCaixa
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.tvPlanoContas = new System.Windows.Forms.TreeView();
            this.tbBuscaContaCaixa = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(304, 275);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // tvPlanoContas
            // 
            this.tvPlanoContas.Location = new System.Drawing.Point(12, 40);
            this.tvPlanoContas.Name = "tvPlanoContas";
            this.tvPlanoContas.Size = new System.Drawing.Size(367, 229);
            this.tvPlanoContas.TabIndex = 1;
            // 
            // tbBuscaContaCaixa
            // 
            this.tbBuscaContaCaixa.Location = new System.Drawing.Point(12, 12);
            this.tbBuscaContaCaixa.Name = "tbBuscaContaCaixa";
            this.tbBuscaContaCaixa.Size = new System.Drawing.Size(286, 20);
            this.tbBuscaContaCaixa.TabIndex = 2;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(304, 11);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 3;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(223, 275);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // fmBuscaContaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 303);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbBuscaContaCaixa);
            this.Controls.Add(this.tvPlanoContas);
            this.Controls.Add(this.btCancelar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBuscaContaCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca conta caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TreeView tvPlanoContas;
        private System.Windows.Forms.TextBox tbBuscaContaCaixa;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btOk;
    }
}