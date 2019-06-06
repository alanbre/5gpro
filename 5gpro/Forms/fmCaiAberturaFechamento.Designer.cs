namespace _5gpro.Forms
{
    partial class fmCaiAberturaFechamento
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbStatusCaixa = new System.Windows.Forms.TextBox();
            this.lbStatusCaixa = new System.Windows.Forms.Label();
            this.dbValorFechamento = new _5gpro.Controls.DecimalBox();
            this.lbValorFechamento = new System.Windows.Forms.Label();
            this.buscaCaixa = new _5gpro.Controls.BuscaCaixa();
            this.lbValorAberturaFechamento = new System.Windows.Forms.Label();
            this.btAbrirFechar = new System.Windows.Forms.Button();
            this.dbValorAberturaFechamento = new _5gpro.Controls.DecimalBox();
            this.lbValorAbertura = new System.Windows.Forms.Label();
            this.dbValorAbertura = new _5gpro.Controls.DecimalBox();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dbValorAbertura);
            this.gbInfo.Controls.Add(this.lbValorAbertura);
            this.gbInfo.Controls.Add(this.tbStatusCaixa);
            this.gbInfo.Controls.Add(this.lbStatusCaixa);
            this.gbInfo.Controls.Add(this.dbValorFechamento);
            this.gbInfo.Controls.Add(this.lbValorFechamento);
            this.gbInfo.Controls.Add(this.buscaCaixa);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(277, 136);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informações do caixa";
            // 
            // tbStatusCaixa
            // 
            this.tbStatusCaixa.Enabled = false;
            this.tbStatusCaixa.Location = new System.Drawing.Point(9, 71);
            this.tbStatusCaixa.Name = "tbStatusCaixa";
            this.tbStatusCaixa.Size = new System.Drawing.Size(100, 20);
            this.tbStatusCaixa.TabIndex = 2;
            // 
            // lbStatusCaixa
            // 
            this.lbStatusCaixa.AutoSize = true;
            this.lbStatusCaixa.Location = new System.Drawing.Point(6, 55);
            this.lbStatusCaixa.Name = "lbStatusCaixa";
            this.lbStatusCaixa.Size = new System.Drawing.Size(37, 13);
            this.lbStatusCaixa.TabIndex = 1;
            this.lbStatusCaixa.Text = "Status";
            // 
            // dbValorFechamento
            // 
            this.dbValorFechamento.Enabled = false;
            this.dbValorFechamento.Location = new System.Drawing.Point(124, 110);
            this.dbValorFechamento.Name = "dbValorFechamento";
            this.dbValorFechamento.Size = new System.Drawing.Size(100, 22);
            this.dbValorFechamento.TabIndex = 6;
            this.dbValorFechamento.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbValorFechamento
            // 
            this.lbValorFechamento.AutoSize = true;
            this.lbValorFechamento.Location = new System.Drawing.Point(121, 94);
            this.lbValorFechamento.Name = "lbValorFechamento";
            this.lbValorFechamento.Size = new System.Drawing.Size(105, 13);
            this.lbValorFechamento.TabIndex = 5;
            this.lbValorFechamento.Text = "Valor do fechamento";
            // 
            // buscaCaixa
            // 
            this.buscaCaixa.BackColor = System.Drawing.Color.White;
            this.buscaCaixa.Location = new System.Drawing.Point(3, 16);
            this.buscaCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCaixa.Name = "buscaCaixa";
            this.buscaCaixa.Size = new System.Drawing.Size(264, 39);
            this.buscaCaixa.TabIndex = 0;
            this.buscaCaixa.Leave += new System.EventHandler(this.BuscaCaixa_Leave);
            // 
            // lbValorAberturaFechamento
            // 
            this.lbValorAberturaFechamento.AutoSize = true;
            this.lbValorAberturaFechamento.Location = new System.Drawing.Point(9, 151);
            this.lbValorAberturaFechamento.Name = "lbValorAberturaFechamento";
            this.lbValorAberturaFechamento.Size = new System.Drawing.Size(88, 13);
            this.lbValorAberturaFechamento.TabIndex = 1;
            this.lbValorAberturaFechamento.Text = "Valor da abertura";
            // 
            // btAbrirFechar
            // 
            this.btAbrirFechar.Location = new System.Drawing.Point(12, 195);
            this.btAbrirFechar.Name = "btAbrirFechar";
            this.btAbrirFechar.Size = new System.Drawing.Size(63, 23);
            this.btAbrirFechar.TabIndex = 3;
            this.btAbrirFechar.Text = "Abrir";
            this.btAbrirFechar.UseVisualStyleBackColor = true;
            this.btAbrirFechar.Click += new System.EventHandler(this.BtAbriFechar_Click);
            // 
            // dbValorAberturaFechamento
            // 
            this.dbValorAberturaFechamento.Location = new System.Drawing.Point(12, 167);
            this.dbValorAberturaFechamento.Name = "dbValorAberturaFechamento";
            this.dbValorAberturaFechamento.Size = new System.Drawing.Size(100, 22);
            this.dbValorAberturaFechamento.TabIndex = 2;
            this.dbValorAberturaFechamento.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbValorAbertura
            // 
            this.lbValorAbertura.AutoSize = true;
            this.lbValorAbertura.Location = new System.Drawing.Point(6, 94);
            this.lbValorAbertura.Name = "lbValorAbertura";
            this.lbValorAbertura.Size = new System.Drawing.Size(88, 13);
            this.lbValorAbertura.TabIndex = 3;
            this.lbValorAbertura.Text = "Valor da abertura";
            // 
            // dbValorAbertura
            // 
            this.dbValorAbertura.Enabled = false;
            this.dbValorAbertura.Location = new System.Drawing.Point(9, 110);
            this.dbValorAbertura.Name = "dbValorAbertura";
            this.dbValorAbertura.Size = new System.Drawing.Size(100, 22);
            this.dbValorAbertura.TabIndex = 4;
            this.dbValorAbertura.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // fmCaiAberturaFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 227);
            this.Controls.Add(this.btAbrirFechar);
            this.Controls.Add(this.dbValorAberturaFechamento);
            this.Controls.Add(this.lbValorAberturaFechamento);
            this.Controls.Add(this.gbInfo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 266);
            this.Name = "fmCaiAberturaFechamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Abertura e fechamento de caixa";
            this.Load += new System.EventHandler(this.FmCaiAberturaFechamento_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private Controls.BuscaCaixa buscaCaixa;
        private Controls.DecimalBox dbValorFechamento;
        private System.Windows.Forms.Label lbValorFechamento;
        private System.Windows.Forms.Label lbValorAberturaFechamento;
        private System.Windows.Forms.TextBox tbStatusCaixa;
        private System.Windows.Forms.Label lbStatusCaixa;
        private Controls.DecimalBox dbValorAberturaFechamento;
        private System.Windows.Forms.Button btAbrirFechar;
        private System.Windows.Forms.Label lbValorAbertura;
        private Controls.DecimalBox dbValorAbertura;
    }
}