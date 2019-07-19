namespace _5gpro.Forms
{
    partial class fmDecimal
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
            this.dbValor = new _5gpro.Controls.DecimalBox();
            this.lbDescDecimal = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbValor
            // 
            this.dbValor.Location = new System.Drawing.Point(12, 24);
            this.dbValor.Name = "dbValor";
            this.dbValor.Size = new System.Drawing.Size(156, 22);
            this.dbValor.TabIndex = 0;
            this.dbValor.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbDescDecimal
            // 
            this.lbDescDecimal.AutoSize = true;
            this.lbDescDecimal.Location = new System.Drawing.Point(13, 5);
            this.lbDescDecimal.Name = "lbDescDecimal";
            this.lbDescDecimal.Size = new System.Drawing.Size(55, 13);
            this.lbDescDecimal.TabIndex = 1;
            this.lbDescDecimal.Text = "Descricao";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(12, 52);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(93, 52);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // fmDecimal
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(180, 82);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbDescDecimal);
            this.Controls.Add(this.dbValor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDecimal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe um Valor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DecimalBox dbValor;
        private System.Windows.Forms.Label lbDescDecimal;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancelar;
    }
}