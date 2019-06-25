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
            this.lbJurosPagos = new System.Windows.Forms.Label();
            this.lbDescontosConcedidos = new System.Windows.Forms.Label();
            this.lbContasPagar = new System.Windows.Forms.Label();
            this.lbCompras = new System.Windows.Forms.Label();
            this.gbLancamentoEntrada = new System.Windows.Forms.GroupBox();
            this.lbJurosRecebidos = new System.Windows.Forms.Label();
            this.lbDescontosRecebidos = new System.Windows.Forms.Label();
            this.lbContasReceber = new System.Windows.Forms.Label();
            this.lbVendas = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.buscaPlanoContaCaixa1 = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.gbLancamentosSaida.SuspendLayout();
            this.gbLancamentoEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLancamentosSaida
            // 
            this.gbLancamentosSaida.Controls.Add(this.buscaPlanoContaCaixa1);
            this.gbLancamentosSaida.Controls.Add(this.lbJurosPagos);
            this.gbLancamentosSaida.Controls.Add(this.lbDescontosConcedidos);
            this.gbLancamentosSaida.Controls.Add(this.lbContasPagar);
            this.gbLancamentosSaida.Controls.Add(this.lbCompras);
            this.gbLancamentosSaida.Location = new System.Drawing.Point(12, 12);
            this.gbLancamentosSaida.Name = "gbLancamentosSaida";
            this.gbLancamentosSaida.Size = new System.Drawing.Size(360, 396);
            this.gbLancamentosSaida.TabIndex = 0;
            this.gbLancamentosSaida.TabStop = false;
            this.gbLancamentosSaida.Text = "Lançamentos de Saída (Pagamentos)";
            // 
            // lbJurosPagos
            // 
            this.lbJurosPagos.AutoSize = true;
            this.lbJurosPagos.Location = new System.Drawing.Point(6, 188);
            this.lbJurosPagos.Name = "lbJurosPagos";
            this.lbJurosPagos.Size = new System.Drawing.Size(65, 13);
            this.lbJurosPagos.TabIndex = 3;
            this.lbJurosPagos.Text = "Juros Pagos";
            // 
            // lbDescontosConcedidos
            // 
            this.lbDescontosConcedidos.AutoSize = true;
            this.lbDescontosConcedidos.Location = new System.Drawing.Point(6, 136);
            this.lbDescontosConcedidos.Name = "lbDescontosConcedidos";
            this.lbDescontosConcedidos.Size = new System.Drawing.Size(117, 13);
            this.lbDescontosConcedidos.TabIndex = 2;
            this.lbDescontosConcedidos.Text = "Descontos Concedidos";
            // 
            // lbContasPagar
            // 
            this.lbContasPagar.AutoSize = true;
            this.lbContasPagar.Location = new System.Drawing.Point(6, 85);
            this.lbContasPagar.Name = "lbContasPagar";
            this.lbContasPagar.Size = new System.Drawing.Size(80, 13);
            this.lbContasPagar.TabIndex = 1;
            this.lbContasPagar.Text = "Contas a Pagar";
            // 
            // lbCompras
            // 
            this.lbCompras.AutoSize = true;
            this.lbCompras.Location = new System.Drawing.Point(6, 16);
            this.lbCompras.Name = "lbCompras";
            this.lbCompras.Size = new System.Drawing.Size(48, 13);
            this.lbCompras.TabIndex = 0;
            this.lbCompras.Text = "Compras";
            // 
            // gbLancamentoEntrada
            // 
            this.gbLancamentoEntrada.Controls.Add(this.lbJurosRecebidos);
            this.gbLancamentoEntrada.Controls.Add(this.lbDescontosRecebidos);
            this.gbLancamentoEntrada.Controls.Add(this.lbContasReceber);
            this.gbLancamentoEntrada.Controls.Add(this.lbVendas);
            this.gbLancamentoEntrada.Location = new System.Drawing.Point(378, 12);
            this.gbLancamentoEntrada.Name = "gbLancamentoEntrada";
            this.gbLancamentoEntrada.Size = new System.Drawing.Size(360, 396);
            this.gbLancamentoEntrada.TabIndex = 1;
            this.gbLancamentoEntrada.TabStop = false;
            this.gbLancamentoEntrada.Text = "Lançamentos de Entrada (Recebimentos)";
            // 
            // lbJurosRecebidos
            // 
            this.lbJurosRecebidos.AutoSize = true;
            this.lbJurosRecebidos.Location = new System.Drawing.Point(36, 174);
            this.lbJurosRecebidos.Name = "lbJurosRecebidos";
            this.lbJurosRecebidos.Size = new System.Drawing.Size(86, 13);
            this.lbJurosRecebidos.TabIndex = 3;
            this.lbJurosRecebidos.Text = "Juros Recebidos";
            // 
            // lbDescontosRecebidos
            // 
            this.lbDescontosRecebidos.AutoSize = true;
            this.lbDescontosRecebidos.Location = new System.Drawing.Point(36, 119);
            this.lbDescontosRecebidos.Name = "lbDescontosRecebidos";
            this.lbDescontosRecebidos.Size = new System.Drawing.Size(112, 13);
            this.lbDescontosRecebidos.TabIndex = 2;
            this.lbDescontosRecebidos.Text = "Descontos Recebidos";
            // 
            // lbContasReceber
            // 
            this.lbContasReceber.AutoSize = true;
            this.lbContasReceber.Location = new System.Drawing.Point(36, 84);
            this.lbContasReceber.Name = "lbContasReceber";
            this.lbContasReceber.Size = new System.Drawing.Size(93, 13);
            this.lbContasReceber.TabIndex = 1;
            this.lbContasReceber.Text = "Contas a Receber";
            // 
            // lbVendas
            // 
            this.lbVendas.AutoSize = true;
            this.lbVendas.Location = new System.Drawing.Point(33, 46);
            this.lbVendas.Name = "lbVendas";
            this.lbVendas.Size = new System.Drawing.Size(43, 13);
            this.lbVendas.TabIndex = 0;
            this.lbVendas.Text = "Vendas";
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
            // buscaPlanoContaCaixa1
            // 
            this.buscaPlanoContaCaixa1.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa1.LabelText = "Compras";
            this.buscaPlanoContaCaixa1.Location = new System.Drawing.Point(42, 263);
            this.buscaPlanoContaCaixa1.Name = "buscaPlanoContaCaixa1";
            this.buscaPlanoContaCaixa1.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa1.TabIndex = 4;
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
            this.gbLancamentoEntrada.ResumeLayout(false);
            this.gbLancamentoEntrada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLancamentosSaida;
        private System.Windows.Forms.GroupBox gbLancamentoEntrada;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbCompras;
        private System.Windows.Forms.Label lbJurosPagos;
        private System.Windows.Forms.Label lbDescontosConcedidos;
        private System.Windows.Forms.Label lbContasPagar;
        private System.Windows.Forms.Label lbJurosRecebidos;
        private System.Windows.Forms.Label lbDescontosRecebidos;
        private System.Windows.Forms.Label lbContasReceber;
        private System.Windows.Forms.Label lbVendas;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa1;
    }
}