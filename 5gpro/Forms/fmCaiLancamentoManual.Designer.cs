namespace _5gpro.Forms
{
    partial class fmCaiLancamentoManual
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
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tbStatusCaixa = new System.Windows.Forms.TextBox();
            this.lbStatusCaixa = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dbValor = new _5gpro.Controls.DecimalBox();
            this.buscaCaixa = new _5gpro.Controls.BuscaCaixa();
            this.gbDados.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDados
            // 
            this.gbDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDados.Controls.Add(this.tbDocumento);
            this.gbDados.Controls.Add(this.lbDocumento);
            this.gbDados.Controls.Add(this.dbValor);
            this.gbDados.Controls.Add(this.gbTipo);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Controls.Add(this.dtpData);
            this.gbDados.Controls.Add(this.tbStatusCaixa);
            this.gbDados.Controls.Add(this.lbStatusCaixa);
            this.gbDados.Controls.Add(this.lbData);
            this.gbDados.Controls.Add(this.buscaCaixa);
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(364, 234);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // tbDocumento
            // 
            this.tbDocumento.Location = new System.Drawing.Point(9, 162);
            this.tbDocumento.MaxLength = 11;
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(100, 20);
            this.tbDocumento.TabIndex = 7;
            this.tbDocumento.TextChanged += new System.EventHandler(this.TbDocumento_TextChanged);
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(6, 146);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(62, 13);
            this.lbDocumento.TabIndex = 6;
            this.lbDocumento.Text = "Documento";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbDebito);
            this.gbTipo.Controls.Add(this.rbCredito);
            this.gbTipo.Location = new System.Drawing.Point(9, 97);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(135, 46);
            this.gbTipo.TabIndex = 5;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Location = new System.Drawing.Point(70, 19);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(56, 17);
            this.rbDebito.TabIndex = 1;
            this.rbDebito.Text = "Débito";
            this.rbDebito.UseVisualStyleBackColor = true;
            this.rbDebito.CheckedChanged += new System.EventHandler(this.RbDebito_CheckedChanged);
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Checked = true;
            this.rbCredito.Location = new System.Drawing.Point(6, 19);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(58, 17);
            this.rbCredito.TabIndex = 0;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Crédito";
            this.rbCredito.UseVisualStyleBackColor = true;
            this.rbCredito.CheckedChanged += new System.EventHandler(this.RbCredito_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(9, 71);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 20);
            this.dtpData.TabIndex = 4;
            this.dtpData.ValueChanged += new System.EventHandler(this.DtpData_ValueChanged);
            // 
            // tbStatusCaixa
            // 
            this.tbStatusCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatusCaixa.Enabled = false;
            this.tbStatusCaixa.Location = new System.Drawing.Point(291, 32);
            this.tbStatusCaixa.Name = "tbStatusCaixa";
            this.tbStatusCaixa.Size = new System.Drawing.Size(67, 20);
            this.tbStatusCaixa.TabIndex = 2;
            // 
            // lbStatusCaixa
            // 
            this.lbStatusCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatusCaixa.AutoSize = true;
            this.lbStatusCaixa.Location = new System.Drawing.Point(288, 16);
            this.lbStatusCaixa.Name = "lbStatusCaixa";
            this.lbStatusCaixa.Size = new System.Drawing.Size(37, 13);
            this.lbStatusCaixa.TabIndex = 1;
            this.lbStatusCaixa.Text = "Status";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(6, 55);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 3;
            this.lbData.Text = "Data";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(12, 252);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(93, 252);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // dbValor
            // 
            this.dbValor.Location = new System.Drawing.Point(9, 201);
            this.dbValor.Name = "dbValor";
            this.dbValor.Size = new System.Drawing.Size(100, 22);
            this.dbValor.TabIndex = 9;
            this.dbValor.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbValor.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbValor_Valor_Changed);
            // 
            // buscaCaixa
            // 
            this.buscaCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscaCaixa.BackColor = System.Drawing.Color.White;
            this.buscaCaixa.Location = new System.Drawing.Point(3, 16);
            this.buscaCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCaixa.Name = "buscaCaixa";
            this.buscaCaixa.Size = new System.Drawing.Size(282, 39);
            this.buscaCaixa.TabIndex = 0;
            this.buscaCaixa.Text_Changed += new _5gpro.Controls.BuscaCaixa.text_changedEventHandler(this.BuscaCaixa_Text_Changed);
            this.buscaCaixa.Leave += new System.EventHandler(this.BuscaCaixa_Leave);
            // 
            // fmCaiLancamentoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 289);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbDados);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 328);
            this.Name = "fmCaiLancamentoManual";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Lançamento manual do caixa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCaiLancamentoManual_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCaiLancamentoManual_KeyDown);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Label lbData;
        private Controls.BuscaCaixa buscaCaixa;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox tbStatusCaixa;
        private System.Windows.Forms.Label lbStatusCaixa;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.Label lbDocumento;
        private Controls.DecimalBox dbValor;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btSair;
    }
}