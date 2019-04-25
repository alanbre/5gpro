namespace _5gpro.Forms
{
    partial class fmCarCadastroConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDadosConta = new System.Windows.Forms.GroupBox();
            this.lbCodigoConta = new System.Windows.Forms.Label();
            this.tbCodigoConta = new System.Windows.Forms.TextBox();
            this.lbDataCadastroConta = new System.Windows.Forms.Label();
            this.dtpDataCadatroConta = new System.Windows.Forms.DateTimePicker();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.gbTotais = new System.Windows.Forms.GroupBox();
            this.lbCodigoParcela = new System.Windows.Forms.Label();
            this.tbCodigoParcela = new System.Windows.Forms.TextBox();
            this.lbDataVencimentoParcela = new System.Windows.Forms.Label();
            this.dtpDataVencimentoParcela = new System.Windows.Forms.DateTimePicker();
            this.lbValorOriginalParcela = new System.Windows.Forms.Label();
            this.tbValorOriginalParcela = new System.Windows.Forms.TextBox();
            this.lbMultaParcela = new System.Windows.Forms.Label();
            this.tbMultaParcela = new System.Windows.Forms.TextBox();
            this.tbJurosParcela = new System.Windows.Forms.TextBox();
            this.lbJurosParcela = new System.Windows.Forms.Label();
            this.tbValorFinalParcela = new System.Windows.Forms.TextBox();
            this.lbValorFinalParcela = new System.Windows.Forms.Label();
            this.btSalvarParcela = new System.Windows.Forms.Button();
            this.buscaFormaPagamento = new _5gpro.Controls.BuscaFormaPagamento();
            this.buscaOperacao = new _5gpro.Controls.BuscaOperacao();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.lbValorOriginalConta = new System.Windows.Forms.Label();
            this.tbValorOriginalConta = new System.Windows.Forms.TextBox();
            this.tbMultaConta = new System.Windows.Forms.TextBox();
            this.lbMultaConta = new System.Windows.Forms.Label();
            this.tbJurosConta = new System.Windows.Forms.TextBox();
            this.lbJurosConta = new System.Windows.Forms.Label();
            this.tbValorFinalConta = new System.Windows.Forms.TextBox();
            this.lbValorTotalConta = new System.Windows.Forms.Label();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.gbDadosConta.SuspendLayout();
            this.gbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.gbTotais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosConta
            // 
            this.gbDadosConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosConta.Controls.Add(this.buscaFormaPagamento);
            this.gbDadosConta.Controls.Add(this.buscaOperacao);
            this.gbDadosConta.Controls.Add(this.dtpDataCadatroConta);
            this.gbDadosConta.Controls.Add(this.lbDataCadastroConta);
            this.gbDadosConta.Controls.Add(this.tbCodigoConta);
            this.gbDadosConta.Controls.Add(this.lbCodigoConta);
            this.gbDadosConta.Location = new System.Drawing.Point(65, 12);
            this.gbDadosConta.Name = "gbDadosConta";
            this.gbDadosConta.Size = new System.Drawing.Size(958, 184);
            this.gbDadosConta.TabIndex = 1;
            this.gbDadosConta.TabStop = false;
            this.gbDadosConta.Text = "Dados da conta";
            // 
            // lbCodigoConta
            // 
            this.lbCodigoConta.AutoSize = true;
            this.lbCodigoConta.Location = new System.Drawing.Point(3, 16);
            this.lbCodigoConta.Name = "lbCodigoConta";
            this.lbCodigoConta.Size = new System.Drawing.Size(35, 13);
            this.lbCodigoConta.TabIndex = 0;
            this.lbCodigoConta.Text = "Conta";
            // 
            // tbCodigoConta
            // 
            this.tbCodigoConta.Location = new System.Drawing.Point(6, 32);
            this.tbCodigoConta.Name = "tbCodigoConta";
            this.tbCodigoConta.Size = new System.Drawing.Size(58, 20);
            this.tbCodigoConta.TabIndex = 1;
            // 
            // lbDataCadastroConta
            // 
            this.lbDataCadastroConta.AutoSize = true;
            this.lbDataCadastroConta.Location = new System.Drawing.Point(3, 59);
            this.lbDataCadastroConta.Name = "lbDataCadastroConta";
            this.lbDataCadastroConta.Size = new System.Drawing.Size(89, 13);
            this.lbDataCadastroConta.TabIndex = 2;
            this.lbDataCadastroConta.Text = "Data de cadastro";
            // 
            // dtpDataCadatroConta
            // 
            this.dtpDataCadatroConta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadatroConta.Location = new System.Drawing.Point(6, 75);
            this.dtpDataCadatroConta.Name = "dtpDataCadatroConta";
            this.dtpDataCadatroConta.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadatroConta.TabIndex = 3;
            // 
            // gbParcelas
            // 
            this.gbParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParcelas.Controls.Add(this.btSalvarParcela);
            this.gbParcelas.Controls.Add(this.tbValorFinalParcela);
            this.gbParcelas.Controls.Add(this.lbValorFinalParcela);
            this.gbParcelas.Controls.Add(this.tbJurosParcela);
            this.gbParcelas.Controls.Add(this.lbJurosParcela);
            this.gbParcelas.Controls.Add(this.tbMultaParcela);
            this.gbParcelas.Controls.Add(this.lbMultaParcela);
            this.gbParcelas.Controls.Add(this.tbValorOriginalParcela);
            this.gbParcelas.Controls.Add(this.lbValorOriginalParcela);
            this.gbParcelas.Controls.Add(this.dtpDataVencimentoParcela);
            this.gbParcelas.Controls.Add(this.lbDataVencimentoParcela);
            this.gbParcelas.Controls.Add(this.tbCodigoParcela);
            this.gbParcelas.Controls.Add(this.lbCodigoParcela);
            this.gbParcelas.Controls.Add(this.dgvParcelas);
            this.gbParcelas.Location = new System.Drawing.Point(66, 202);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(776, 349);
            this.gbParcelas.TabIndex = 2;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToOrderColumns = true;
            this.dgvParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParcelas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParcelas.Location = new System.Drawing.Point(5, 15);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(766, 281);
            this.dgvParcelas.TabIndex = 0;
            this.dgvParcelas.TabStop = false;
            // 
            // gbTotais
            // 
            this.gbTotais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotais.Controls.Add(this.tbValorFinalConta);
            this.gbTotais.Controls.Add(this.lbValorTotalConta);
            this.gbTotais.Controls.Add(this.tbJurosConta);
            this.gbTotais.Controls.Add(this.lbJurosConta);
            this.gbTotais.Controls.Add(this.tbMultaConta);
            this.gbTotais.Controls.Add(this.lbMultaConta);
            this.gbTotais.Controls.Add(this.tbValorOriginalConta);
            this.gbTotais.Controls.Add(this.lbValorOriginalConta);
            this.gbTotais.Location = new System.Drawing.Point(847, 202);
            this.gbTotais.Name = "gbTotais";
            this.gbTotais.Size = new System.Drawing.Size(176, 349);
            this.gbTotais.TabIndex = 3;
            this.gbTotais.TabStop = false;
            this.gbTotais.Text = "Totais";
            // 
            // lbCodigoParcela
            // 
            this.lbCodigoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCodigoParcela.AutoSize = true;
            this.lbCodigoParcela.Location = new System.Drawing.Point(7, 299);
            this.lbCodigoParcela.Name = "lbCodigoParcela";
            this.lbCodigoParcela.Size = new System.Drawing.Size(43, 13);
            this.lbCodigoParcela.TabIndex = 1;
            this.lbCodigoParcela.Text = "Parcela";
            // 
            // tbCodigoParcela
            // 
            this.tbCodigoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodigoParcela.Location = new System.Drawing.Point(10, 315);
            this.tbCodigoParcela.Name = "tbCodigoParcela";
            this.tbCodigoParcela.Size = new System.Drawing.Size(40, 20);
            this.tbCodigoParcela.TabIndex = 2;
            // 
            // lbDataVencimentoParcela
            // 
            this.lbDataVencimentoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDataVencimentoParcela.AutoSize = true;
            this.lbDataVencimentoParcela.Location = new System.Drawing.Point(54, 299);
            this.lbDataVencimentoParcela.Name = "lbDataVencimentoParcela";
            this.lbDataVencimentoParcela.Size = new System.Drawing.Size(103, 13);
            this.lbDataVencimentoParcela.TabIndex = 3;
            this.lbDataVencimentoParcela.Text = "Data de vencimento";
            // 
            // dtpDataVencimentoParcela
            // 
            this.dtpDataVencimentoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoParcela.Location = new System.Drawing.Point(56, 315);
            this.dtpDataVencimentoParcela.Name = "dtpDataVencimentoParcela";
            this.dtpDataVencimentoParcela.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoParcela.TabIndex = 4;
            // 
            // lbValorOriginalParcela
            // 
            this.lbValorOriginalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorOriginalParcela.AutoSize = true;
            this.lbValorOriginalParcela.Location = new System.Drawing.Point(155, 299);
            this.lbValorOriginalParcela.Name = "lbValorOriginalParcela";
            this.lbValorOriginalParcela.Size = new System.Drawing.Size(67, 13);
            this.lbValorOriginalParcela.TabIndex = 5;
            this.lbValorOriginalParcela.Text = "Valor original";
            // 
            // tbValorOriginalParcela
            // 
            this.tbValorOriginalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorOriginalParcela.Location = new System.Drawing.Point(157, 315);
            this.tbValorOriginalParcela.Name = "tbValorOriginalParcela";
            this.tbValorOriginalParcela.Size = new System.Drawing.Size(82, 20);
            this.tbValorOriginalParcela.TabIndex = 6;
            // 
            // lbMultaParcela
            // 
            this.lbMultaParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMultaParcela.AutoSize = true;
            this.lbMultaParcela.Location = new System.Drawing.Point(245, 299);
            this.lbMultaParcela.Name = "lbMultaParcela";
            this.lbMultaParcela.Size = new System.Drawing.Size(33, 13);
            this.lbMultaParcela.TabIndex = 7;
            this.lbMultaParcela.Text = "Multa";
            // 
            // tbMultaParcela
            // 
            this.tbMultaParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMultaParcela.Location = new System.Drawing.Point(245, 315);
            this.tbMultaParcela.Name = "tbMultaParcela";
            this.tbMultaParcela.Size = new System.Drawing.Size(82, 20);
            this.tbMultaParcela.TabIndex = 8;
            // 
            // tbJurosParcela
            // 
            this.tbJurosParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbJurosParcela.Location = new System.Drawing.Point(334, 315);
            this.tbJurosParcela.Name = "tbJurosParcela";
            this.tbJurosParcela.Size = new System.Drawing.Size(82, 20);
            this.tbJurosParcela.TabIndex = 10;
            // 
            // lbJurosParcela
            // 
            this.lbJurosParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbJurosParcela.AutoSize = true;
            this.lbJurosParcela.Location = new System.Drawing.Point(333, 299);
            this.lbJurosParcela.Name = "lbJurosParcela";
            this.lbJurosParcela.Size = new System.Drawing.Size(32, 13);
            this.lbJurosParcela.TabIndex = 9;
            this.lbJurosParcela.Text = "Juros";
            // 
            // tbValorFinalParcela
            // 
            this.tbValorFinalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorFinalParcela.Location = new System.Drawing.Point(424, 315);
            this.tbValorFinalParcela.Name = "tbValorFinalParcela";
            this.tbValorFinalParcela.Size = new System.Drawing.Size(82, 20);
            this.tbValorFinalParcela.TabIndex = 12;
            // 
            // lbValorFinalParcela
            // 
            this.lbValorFinalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorFinalParcela.AutoSize = true;
            this.lbValorFinalParcela.Location = new System.Drawing.Point(422, 299);
            this.lbValorFinalParcela.Name = "lbValorFinalParcela";
            this.lbValorFinalParcela.Size = new System.Drawing.Size(53, 13);
            this.lbValorFinalParcela.TabIndex = 11;
            this.lbValorFinalParcela.Text = "Valor final";
            // 
            // btSalvarParcela
            // 
            this.btSalvarParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvarParcela.Location = new System.Drawing.Point(512, 312);
            this.btSalvarParcela.Name = "btSalvarParcela";
            this.btSalvarParcela.Size = new System.Drawing.Size(75, 23);
            this.btSalvarParcela.TabIndex = 13;
            this.btSalvarParcela.Text = "Salvar";
            this.btSalvarParcela.UseVisualStyleBackColor = true;
            // 
            // buscaFormaPagamento
            // 
            this.buscaFormaPagamento.Location = new System.Drawing.Point(6, 137);
            this.buscaFormaPagamento.Margin = new System.Windows.Forms.Padding(0);
            this.buscaFormaPagamento.Name = "buscaFormaPagamento";
            this.buscaFormaPagamento.Size = new System.Drawing.Size(437, 39);
            this.buscaFormaPagamento.TabIndex = 5;
            // 
            // buscaOperacao
            // 
            this.buscaOperacao.Location = new System.Drawing.Point(1, 98);
            this.buscaOperacao.Margin = new System.Windows.Forms.Padding(0);
            this.buscaOperacao.Name = "buscaOperacao";
            this.buscaOperacao.Size = new System.Drawing.Size(442, 39);
            this.buscaOperacao.TabIndex = 4;
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 0;
            // 
            // lbValorOriginalConta
            // 
            this.lbValorOriginalConta.AutoSize = true;
            this.lbValorOriginalConta.Location = new System.Drawing.Point(6, 16);
            this.lbValorOriginalConta.Name = "lbValorOriginalConta";
            this.lbValorOriginalConta.Size = new System.Drawing.Size(67, 13);
            this.lbValorOriginalConta.TabIndex = 0;
            this.lbValorOriginalConta.Text = "Valor original";
            // 
            // tbValorOriginalConta
            // 
            this.tbValorOriginalConta.Location = new System.Drawing.Point(6, 32);
            this.tbValorOriginalConta.Name = "tbValorOriginalConta";
            this.tbValorOriginalConta.Size = new System.Drawing.Size(82, 20);
            this.tbValorOriginalConta.TabIndex = 1;
            // 
            // tbMultaConta
            // 
            this.tbMultaConta.Location = new System.Drawing.Point(6, 71);
            this.tbMultaConta.Name = "tbMultaConta";
            this.tbMultaConta.Size = new System.Drawing.Size(82, 20);
            this.tbMultaConta.TabIndex = 3;
            // 
            // lbMultaConta
            // 
            this.lbMultaConta.AutoSize = true;
            this.lbMultaConta.Location = new System.Drawing.Point(6, 55);
            this.lbMultaConta.Name = "lbMultaConta";
            this.lbMultaConta.Size = new System.Drawing.Size(33, 13);
            this.lbMultaConta.TabIndex = 2;
            this.lbMultaConta.Text = "Multa";
            // 
            // tbJurosConta
            // 
            this.tbJurosConta.Location = new System.Drawing.Point(6, 110);
            this.tbJurosConta.Name = "tbJurosConta";
            this.tbJurosConta.Size = new System.Drawing.Size(82, 20);
            this.tbJurosConta.TabIndex = 5;
            // 
            // lbJurosConta
            // 
            this.lbJurosConta.AutoSize = true;
            this.lbJurosConta.Location = new System.Drawing.Point(6, 94);
            this.lbJurosConta.Name = "lbJurosConta";
            this.lbJurosConta.Size = new System.Drawing.Size(32, 13);
            this.lbJurosConta.TabIndex = 4;
            this.lbJurosConta.Text = "Juros";
            // 
            // tbValorTotalConta
            // 
            this.tbValorFinalConta.Location = new System.Drawing.Point(6, 149);
            this.tbValorFinalConta.Name = "tbValorTotalConta";
            this.tbValorFinalConta.Size = new System.Drawing.Size(82, 20);
            this.tbValorFinalConta.TabIndex = 7;
            // 
            // lbValorTotalConta
            // 
            this.lbValorTotalConta.AutoSize = true;
            this.lbValorTotalConta.Location = new System.Drawing.Point(6, 133);
            this.lbValorTotalConta.Name = "lbValorTotalConta";
            this.lbValorTotalConta.Size = new System.Drawing.Size(54, 13);
            this.lbValorTotalConta.TabIndex = 6;
            this.lbValorTotalConta.Text = "Valor total";
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(65, 557);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(959, 20);
            this.tbAjuda.TabIndex = 17;
            // 
            // fmCarCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 589);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbTotais);
            this.Controls.Add(this.gbParcelas);
            this.Controls.Add(this.gbDadosConta);
            this.Controls.Add(this.menuVertical);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1052, 483);
            this.Name = "fmCarCadastroConta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de contas a receber";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCarCadastroConta_KeyDown);
            this.gbDadosConta.ResumeLayout(false);
            this.gbDadosConta.PerformLayout();
            this.gbParcelas.ResumeLayout(false);
            this.gbParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.gbTotais.ResumeLayout(false);
            this.gbTotais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.GroupBox gbDadosConta;
        private System.Windows.Forms.DateTimePicker dtpDataCadatroConta;
        private System.Windows.Forms.Label lbDataCadastroConta;
        private System.Windows.Forms.TextBox tbCodigoConta;
        private System.Windows.Forms.Label lbCodigoConta;
        private Controls.BuscaOperacao buscaOperacao;
        private Controls.BuscaFormaPagamento buscaFormaPagamento;
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.GroupBox gbTotais;
        private System.Windows.Forms.TextBox tbCodigoParcela;
        private System.Windows.Forms.Label lbCodigoParcela;
        private System.Windows.Forms.TextBox tbValorFinalParcela;
        private System.Windows.Forms.Label lbValorFinalParcela;
        private System.Windows.Forms.TextBox tbJurosParcela;
        private System.Windows.Forms.Label lbJurosParcela;
        private System.Windows.Forms.TextBox tbMultaParcela;
        private System.Windows.Forms.Label lbMultaParcela;
        private System.Windows.Forms.TextBox tbValorOriginalParcela;
        private System.Windows.Forms.Label lbValorOriginalParcela;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoParcela;
        private System.Windows.Forms.Label lbDataVencimentoParcela;
        private System.Windows.Forms.Button btSalvarParcela;
        private System.Windows.Forms.TextBox tbValorFinalConta;
        private System.Windows.Forms.Label lbValorTotalConta;
        private System.Windows.Forms.TextBox tbJurosConta;
        private System.Windows.Forms.Label lbJurosConta;
        private System.Windows.Forms.TextBox tbMultaConta;
        private System.Windows.Forms.Label lbMultaConta;
        private System.Windows.Forms.TextBox tbValorOriginalConta;
        private System.Windows.Forms.Label lbValorOriginalConta;
        private System.Windows.Forms.TextBox tbAjuda;
    }
}