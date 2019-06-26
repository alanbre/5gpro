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
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.miniMenuVertical1 = new _5gpro.Controls.MiniMenuVertical();
            this.buscaJurosRecebidos = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaDescontosRecebidos = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaContasReceber = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaVendas = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaJurosPagos = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaDescontosConcedidos = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaContasPagar = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaCompras = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.gbLancamentosSaida.SuspendLayout();
            this.gbLancamentoEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLancamentosSaida
            // 
            this.gbLancamentosSaida.Controls.Add(this.buscaJurosPagos);
            this.gbLancamentosSaida.Controls.Add(this.buscaDescontosConcedidos);
            this.gbLancamentosSaida.Controls.Add(this.buscaContasPagar);
            this.gbLancamentosSaida.Controls.Add(this.buscaCompras);
            this.gbLancamentosSaida.Location = new System.Drawing.Point(71, 12);
            this.gbLancamentosSaida.Name = "gbLancamentosSaida";
            this.gbLancamentosSaida.Size = new System.Drawing.Size(360, 252);
            this.gbLancamentosSaida.TabIndex = 0;
            this.gbLancamentosSaida.TabStop = false;
            this.gbLancamentosSaida.Text = "Lançamentos de Saída (Pagamentos)";
            // 
            // gbLancamentoEntrada
            // 
            this.gbLancamentoEntrada.Controls.Add(this.buscaJurosRecebidos);
            this.gbLancamentoEntrada.Controls.Add(this.buscaDescontosRecebidos);
            this.gbLancamentoEntrada.Controls.Add(this.buscaContasReceber);
            this.gbLancamentoEntrada.Controls.Add(this.buscaVendas);
            this.gbLancamentoEntrada.Location = new System.Drawing.Point(437, 12);
            this.gbLancamentoEntrada.Name = "gbLancamentoEntrada";
            this.gbLancamentoEntrada.Size = new System.Drawing.Size(360, 252);
            this.gbLancamentoEntrada.TabIndex = 1;
            this.gbLancamentoEntrada.TabStop = false;
            this.gbLancamentoEntrada.Text = "Lançamentos de Entrada (Recebimentos)";
            // 
            // tbAjuda
            // 
            this.tbAjuda.Location = new System.Drawing.Point(71, 270);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(726, 20);
            this.tbAjuda.TabIndex = 4;
            // 
            // miniMenuVertical1
            // 
            this.miniMenuVertical1.Location = new System.Drawing.Point(12, 12);
            this.miniMenuVertical1.Name = "miniMenuVertical1";
            this.miniMenuVertical1.Size = new System.Drawing.Size(53, 158);
            this.miniMenuVertical1.TabIndex = 5;
            this.miniMenuVertical1.Salvar_Clicked += new _5gpro.Controls.MiniMenuVertical.salvarEventHandler(this.MiniMenuVertical1_Salvar_Clicked);
            this.miniMenuVertical1.Recarregar_Clicked += new _5gpro.Controls.MiniMenuVertical.recarregarEventHandler(this.MiniMenuVertical1_Recarregar_Clicked);
            this.miniMenuVertical1.Excluir_Clicked += new _5gpro.Controls.MiniMenuVertical.excluirEventHandler(this.MiniMenuVertical1_Excluir_Clicked);
            // 
            // buscaJurosRecebidos
            // 
            this.buscaJurosRecebidos.BackColor = System.Drawing.Color.White;
            this.buscaJurosRecebidos.Entrada = true;
            this.buscaJurosRecebidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaJurosRecebidos.LabelText = "Juros recebidos";
            this.buscaJurosRecebidos.Location = new System.Drawing.Point(31, 169);
            this.buscaJurosRecebidos.Name = "buscaJurosRecebidos";
            this.buscaJurosRecebidos.Saida = false;
            this.buscaJurosRecebidos.Size = new System.Drawing.Size(264, 39);
            this.buscaJurosRecebidos.TabIndex = 7;
            this.buscaJurosRecebidos.Text_Changed += new _5gpro.Controls.BuscaPlanoContaCaixa.text_changedEventHandler(this.BuscaJurosRecebidos_Text_Changed);
            // 
            // buscaDescontosRecebidos
            // 
            this.buscaDescontosRecebidos.BackColor = System.Drawing.Color.White;
            this.buscaDescontosRecebidos.Entrada = true;
            this.buscaDescontosRecebidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaDescontosRecebidos.LabelText = "Descontos recebidos";
            this.buscaDescontosRecebidos.Location = new System.Drawing.Point(31, 124);
            this.buscaDescontosRecebidos.Name = "buscaDescontosRecebidos";
            this.buscaDescontosRecebidos.Saida = false;
            this.buscaDescontosRecebidos.Size = new System.Drawing.Size(264, 39);
            this.buscaDescontosRecebidos.TabIndex = 6;
            this.buscaDescontosRecebidos.Text_Changed += new _5gpro.Controls.BuscaPlanoContaCaixa.text_changedEventHandler(this.BuscaDescontosRecebidos_Text_Changed);
            // 
            // buscaContasReceber
            // 
            this.buscaContasReceber.BackColor = System.Drawing.Color.White;
            this.buscaContasReceber.Entrada = true;
            this.buscaContasReceber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaContasReceber.LabelText = "Contas a receber";
            this.buscaContasReceber.Location = new System.Drawing.Point(31, 79);
            this.buscaContasReceber.Name = "buscaContasReceber";
            this.buscaContasReceber.Saida = false;
            this.buscaContasReceber.Size = new System.Drawing.Size(264, 39);
            this.buscaContasReceber.TabIndex = 5;
            this.buscaContasReceber.Text_Changed += new _5gpro.Controls.BuscaPlanoContaCaixa.text_changedEventHandler(this.BuscaContasReceber_Text_Changed);
            // 
            // buscaVendas
            // 
            this.buscaVendas.BackColor = System.Drawing.Color.White;
            this.buscaVendas.Entrada = true;
            this.buscaVendas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaVendas.LabelText = "Vendas";
            this.buscaVendas.Location = new System.Drawing.Point(31, 34);
            this.buscaVendas.Name = "buscaVendas";
            this.buscaVendas.Saida = false;
            this.buscaVendas.Size = new System.Drawing.Size(264, 39);
            this.buscaVendas.TabIndex = 4;
            this.buscaVendas.Text_Changed += new _5gpro.Controls.BuscaPlanoContaCaixa.text_changedEventHandler(this.BuscaVendas_Text_Changed);
            // 
            // buscaJurosPagos
            // 
            this.buscaJurosPagos.BackColor = System.Drawing.Color.White;
            this.buscaJurosPagos.Entrada = false;
            this.buscaJurosPagos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaJurosPagos.LabelText = "Juros Pagos";
            this.buscaJurosPagos.Location = new System.Drawing.Point(6, 169);
            this.buscaJurosPagos.Name = "buscaJurosPagos";
            this.buscaJurosPagos.Saida = true;
            this.buscaJurosPagos.Size = new System.Drawing.Size(264, 39);
            this.buscaJurosPagos.TabIndex = 7;
            this.buscaJurosPagos.Text_Changed += new _5gpro.Controls.BuscaPlanoContaCaixa.text_changedEventHandler(this.BuscaJurosPagos_Text_Changed);
            // 
            // buscaDescontosConcedidos
            // 
            this.buscaDescontosConcedidos.BackColor = System.Drawing.Color.White;
            this.buscaDescontosConcedidos.Entrada = false;
            this.buscaDescontosConcedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaDescontosConcedidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaDescontosConcedidos.LabelText = "Descontos Concedidos";
            this.buscaDescontosConcedidos.Location = new System.Drawing.Point(6, 124);
            this.buscaDescontosConcedidos.Name = "buscaDescontosConcedidos";
            this.buscaDescontosConcedidos.Saida = true;
            this.buscaDescontosConcedidos.Size = new System.Drawing.Size(264, 39);
            this.buscaDescontosConcedidos.TabIndex = 6;
            this.buscaDescontosConcedidos.Text_Changed += new _5gpro.Controls.BuscaPlanoContaCaixa.text_changedEventHandler(this.BuscaDescontosConcedidos_Text_Changed);
            // 
            // buscaContasPagar
            // 
            this.buscaContasPagar.BackColor = System.Drawing.Color.White;
            this.buscaContasPagar.Entrada = false;
            this.buscaContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaContasPagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaContasPagar.LabelText = "Contas a pagar";
            this.buscaContasPagar.Location = new System.Drawing.Point(6, 79);
            this.buscaContasPagar.Name = "buscaContasPagar";
            this.buscaContasPagar.Saida = true;
            this.buscaContasPagar.Size = new System.Drawing.Size(264, 39);
            this.buscaContasPagar.TabIndex = 5;
            this.buscaContasPagar.Text_Changed += new _5gpro.Controls.BuscaPlanoContaCaixa.text_changedEventHandler(this.BuscaContasPagar_Text_Changed);
            // 
            // buscaCompras
            // 
            this.buscaCompras.BackColor = System.Drawing.Color.White;
            this.buscaCompras.Entrada = false;
            this.buscaCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaCompras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaCompras.LabelText = "Compras";
            this.buscaCompras.Location = new System.Drawing.Point(6, 34);
            this.buscaCompras.Name = "buscaCompras";
            this.buscaCompras.Saida = true;
            this.buscaCompras.Size = new System.Drawing.Size(264, 39);
            this.buscaCompras.TabIndex = 4;
            this.buscaCompras.Text_Changed += new _5gpro.Controls.BuscaPlanoContaCaixa.text_changedEventHandler(this.BuscaCompras_Text_Changed);
            // 
            // fmCaiPlanoContasPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 310);
            this.Controls.Add(this.miniMenuVertical1);
            this.Controls.Add(this.tbAjuda);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCaiPlanoContasPadrao_FormClosing);
            this.Load += new System.EventHandler(this.FmCaiPlanoContasPadrao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCaiPlanoContasPadrao_KeyDown);
            this.gbLancamentosSaida.ResumeLayout(false);
            this.gbLancamentoEntrada.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLancamentosSaida;
        private System.Windows.Forms.GroupBox gbLancamentoEntrada;
        private Controls.BuscaPlanoContaCaixa buscaCompras;
        private Controls.BuscaPlanoContaCaixa buscaContasPagar;
        private Controls.BuscaPlanoContaCaixa buscaVendas;
        private Controls.BuscaPlanoContaCaixa buscaJurosPagos;
        private Controls.BuscaPlanoContaCaixa buscaDescontosConcedidos;
        private Controls.BuscaPlanoContaCaixa buscaJurosRecebidos;
        private Controls.BuscaPlanoContaCaixa buscaDescontosRecebidos;
        private Controls.BuscaPlanoContaCaixa buscaContasReceber;
        private System.Windows.Forms.TextBox tbAjuda;
        private Controls.MiniMenuVertical miniMenuVertical1;
    }
}