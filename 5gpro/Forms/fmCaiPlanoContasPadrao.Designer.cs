namespace _5gpro.Forms
{
    partial class fmCaiPlanoContasPadrao
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
            this.gbLancamentosSaida = new System.Windows.Forms.GroupBox();
            this.gbLancamentoEntrada = new System.Windows.Forms.GroupBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLancamentosSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLancamentosSaida
            // 
            this.gbLancamentosSaida.Controls.Add(this.label1);
            this.gbLancamentosSaida.Location = new System.Drawing.Point(12, 12);
            this.gbLancamentosSaida.Name = "gbLancamentosSaida";
            this.gbLancamentosSaida.Size = new System.Drawing.Size(360, 396);
            this.gbLancamentosSaida.TabIndex = 0;
            this.gbLancamentosSaida.TabStop = false;
            this.gbLancamentosSaida.Text = "Lançamentos de Saída (Pagamentos)";
            // 
            // gbLancamentoEntrada
            // 
            this.gbLancamentoEntrada.Location = new System.Drawing.Point(378, 12);
            this.gbLancamentoEntrada.Name = "gbLancamentoEntrada";
            this.gbLancamentoEntrada.Size = new System.Drawing.Size(360, 396);
            this.gbLancamentoEntrada.TabIndex = 1;
            this.gbLancamentoEntrada.TabStop = false;
            this.gbLancamentoEntrada.Text = "Lançamentos de Entrada (Recebimentos)";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(581, 414);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(662, 415);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quitação de conta a pagar";
            // 
            // fmCaiPlanoContasPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbLancamentoEntrada);
            this.Controls.Add(this.gbLancamentosSaida);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCaiPlanoContasPadrao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano de Contas Padrão";
            this.gbLancamentosSaida.ResumeLayout(false);
            this.gbLancamentosSaida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLancamentosSaida;
        private System.Windows.Forms.GroupBox gbLancamentoEntrada;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
    }
}