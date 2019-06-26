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
            this.buscaPlanoContaCaixa1 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.gbLancamentoEntrada = new System.Windows.Forms.GroupBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.buscaPlanoContaCaixa2 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaPlanoContaCaixa3 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaPlanoContaCaixa4 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaPlanoContaCaixa5 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaPlanoContaCaixa6 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaPlanoContaCaixa7 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaPlanoContaCaixa8 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.gbLancamentosSaida.SuspendLayout();
            this.gbLancamentoEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLancamentosSaida
            // 
            this.gbLancamentosSaida.Controls.Add(this.buscaPlanoContaCaixa5);
            this.gbLancamentosSaida.Controls.Add(this.buscaPlanoContaCaixa4);
            this.gbLancamentosSaida.Controls.Add(this.buscaPlanoContaCaixa3);
            this.gbLancamentosSaida.Controls.Add(this.buscaPlanoContaCaixa1);
            this.gbLancamentosSaida.Location = new System.Drawing.Point(12, 12);
            this.gbLancamentosSaida.Name = "gbLancamentosSaida";
            this.gbLancamentosSaida.Size = new System.Drawing.Size(360, 252);
            this.gbLancamentosSaida.TabIndex = 0;
            this.gbLancamentosSaida.TabStop = false;
            this.gbLancamentosSaida.Text = "Lançamentos de Saída (Pagamentos)";
            // 
            // buscaPlanoContaCaixa1
            // 
            this.buscaPlanoContaCaixa1.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa1.Entrada = false;
            this.buscaPlanoContaCaixa1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa1.LabelText = "Compras";
            this.buscaPlanoContaCaixa1.Location = new System.Drawing.Point(6, 34);
            this.buscaPlanoContaCaixa1.Name = "buscaPlanoContaCaixa1";
            this.buscaPlanoContaCaixa1.Saida = true;
            this.buscaPlanoContaCaixa1.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa1.TabIndex = 4;
            // 
            // gbLancamentoEntrada
            // 
            this.gbLancamentoEntrada.Controls.Add(this.buscaPlanoContaCaixa8);
            this.gbLancamentoEntrada.Controls.Add(this.buscaPlanoContaCaixa7);
            this.gbLancamentoEntrada.Controls.Add(this.buscaPlanoContaCaixa6);
            this.gbLancamentoEntrada.Controls.Add(this.buscaPlanoContaCaixa2);
            this.gbLancamentoEntrada.Location = new System.Drawing.Point(378, 12);
            this.gbLancamentoEntrada.Name = "gbLancamentoEntrada";
            this.gbLancamentoEntrada.Size = new System.Drawing.Size(360, 252);
            this.gbLancamentoEntrada.TabIndex = 1;
            this.gbLancamentoEntrada.TabStop = false;
            this.gbLancamentoEntrada.Text = "Lançamentos de Entrada (Recebimentos)";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(582, 269);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(663, 270);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // buscaPlanoContaCaixa2
            // 
            this.buscaPlanoContaCaixa2.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa2.Entrada = true;
            this.buscaPlanoContaCaixa2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa2.LabelText = "Vendas";
            this.buscaPlanoContaCaixa2.Location = new System.Drawing.Point(31, 34);
            this.buscaPlanoContaCaixa2.Name = "buscaPlanoContaCaixa2";
            this.buscaPlanoContaCaixa2.Saida = false;
            this.buscaPlanoContaCaixa2.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa2.TabIndex = 4;
            // 
            // buscaPlanoContaCaixa3
            // 
            this.buscaPlanoContaCaixa3.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa3.Entrada = false;
            this.buscaPlanoContaCaixa3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa3.LabelText = "Conta a pagar";
            this.buscaPlanoContaCaixa3.Location = new System.Drawing.Point(6, 79);
            this.buscaPlanoContaCaixa3.Name = "buscaPlanoContaCaixa3";
            this.buscaPlanoContaCaixa3.Saida = true;
            this.buscaPlanoContaCaixa3.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa3.TabIndex = 5;
            // 
            // buscaPlanoContaCaixa4
            // 
            this.buscaPlanoContaCaixa4.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa4.Entrada = false;
            this.buscaPlanoContaCaixa4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa4.LabelText = "Descontos concedidos";
            this.buscaPlanoContaCaixa4.Location = new System.Drawing.Point(6, 124);
            this.buscaPlanoContaCaixa4.Name = "buscaPlanoContaCaixa4";
            this.buscaPlanoContaCaixa4.Saida = true;
            this.buscaPlanoContaCaixa4.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa4.TabIndex = 6;
            // 
            // buscaPlanoContaCaixa5
            // 
            this.buscaPlanoContaCaixa5.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa5.Entrada = false;
            this.buscaPlanoContaCaixa5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa5.LabelText = "Juros pagos";
            this.buscaPlanoContaCaixa5.Location = new System.Drawing.Point(6, 169);
            this.buscaPlanoContaCaixa5.Name = "buscaPlanoContaCaixa5";
            this.buscaPlanoContaCaixa5.Saida = true;
            this.buscaPlanoContaCaixa5.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa5.TabIndex = 7;
            // 
            // buscaPlanoContaCaixa6
            // 
            this.buscaPlanoContaCaixa6.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa6.Entrada = true;
            this.buscaPlanoContaCaixa6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa6.LabelText = "Contas a receber";
            this.buscaPlanoContaCaixa6.Location = new System.Drawing.Point(31, 79);
            this.buscaPlanoContaCaixa6.Name = "buscaPlanoContaCaixa6";
            this.buscaPlanoContaCaixa6.Saida = false;
            this.buscaPlanoContaCaixa6.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa6.TabIndex = 5;
            // 
            // buscaPlanoContaCaixa7
            // 
            this.buscaPlanoContaCaixa7.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa7.Entrada = true;
            this.buscaPlanoContaCaixa7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa7.LabelText = "Descontos recebidos";
            this.buscaPlanoContaCaixa7.Location = new System.Drawing.Point(31, 124);
            this.buscaPlanoContaCaixa7.Name = "buscaPlanoContaCaixa7";
            this.buscaPlanoContaCaixa7.Saida = false;
            this.buscaPlanoContaCaixa7.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa7.TabIndex = 6;
            // 
            // buscaPlanoContaCaixa8
            // 
            this.buscaPlanoContaCaixa8.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa8.Entrada = true;
            this.buscaPlanoContaCaixa8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa8.LabelText = "Juros recebidos";
            this.buscaPlanoContaCaixa8.Location = new System.Drawing.Point(31, 169);
            this.buscaPlanoContaCaixa8.Name = "buscaPlanoContaCaixa8";
            this.buscaPlanoContaCaixa8.Saida = false;
            this.buscaPlanoContaCaixa8.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa8.TabIndex = 7;
            // 
            // fmCaiPlanoContasPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 306);
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
            this.gbLancamentoEntrada.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLancamentosSaida;
        private System.Windows.Forms.GroupBox gbLancamentoEntrada;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa1;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa3;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa2;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa5;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa4;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa8;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa7;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa6;
    }
}