namespace _5gpro.Forms
{
    partial class fmCapCadastroConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.gbTotais = new System.Windows.Forms.GroupBox();
            this.dbValorFinalConta = new _5gpro.Controls.DecimalBox();
            this.dbJurosConta = new _5gpro.Controls.DecimalBox();
            this.dbMultaConta = new _5gpro.Controls.DecimalBox();
            this.dbValorOriginalConta = new _5gpro.Controls.DecimalBox();
            this.lbValorTotalConta = new System.Windows.Forms.Label();
            this.lbJurosConta = new System.Windows.Forms.Label();
            this.lbMultaConta = new System.Windows.Forms.Label();
            this.lbValorOriginalConta = new System.Windows.Forms.Label();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.dbValorFinalParcela = new _5gpro.Controls.DecimalBox();
            this.dbJurosParcela = new _5gpro.Controls.DecimalBox();
            this.dbMultaParcela = new _5gpro.Controls.DecimalBox();
            this.dbValorOriginalParcela = new _5gpro.Controls.DecimalBox();
            this.btExcluirParcela = new System.Windows.Forms.Button();
            this.btNovaParcela = new System.Windows.Forms.Button();
            this.tbDataQuitacao = new System.Windows.Forms.TextBox();
            this.lbDataQuitacao = new System.Windows.Forms.Label();
            this.buscaFormaPagamento = new _5gpro.Controls.BuscaFormaPagamento();
            this.btSalvarParcela = new System.Windows.Forms.Button();
            this.lbValorFinalParcela = new System.Windows.Forms.Label();
            this.lbJurosParcela = new System.Windows.Forms.Label();
            this.lbMultaParcela = new System.Windows.Forms.Label();
            this.lbValorOriginalParcela = new System.Windows.Forms.Label();
            this.dtpDataVencimentoParcela = new System.Windows.Forms.DateTimePicker();
            this.lbDataVencimentoParcela = new System.Windows.Forms.Label();
            this.tbCodigoParcela = new System.Windows.Forms.TextBox();
            this.lbCodigoParcela = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.gbDadosConta = new System.Windows.Forms.GroupBox();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.dtpDataCadatroConta = new System.Windows.Forms.DateTimePicker();
            this.lbDataCadastroConta = new System.Windows.Forms.Label();
            this.tbCodigoConta = new System.Windows.Forms.TextBox();
            this.lbCodigoConta = new System.Windows.Forms.Label();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.dgvtbcSequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataQuitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTotais.SuspendLayout();
            this.gbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.gbDadosConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(67, 572);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(959, 20);
            this.tbAjuda.TabIndex = 4;
            // 
            // gbTotais
            // 
            this.gbTotais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotais.Controls.Add(this.dbValorFinalConta);
            this.gbTotais.Controls.Add(this.dbJurosConta);
            this.gbTotais.Controls.Add(this.dbMultaConta);
            this.gbTotais.Controls.Add(this.dbValorOriginalConta);
            this.gbTotais.Controls.Add(this.lbValorTotalConta);
            this.gbTotais.Controls.Add(this.lbJurosConta);
            this.gbTotais.Controls.Add(this.lbMultaConta);
            this.gbTotais.Controls.Add(this.lbValorOriginalConta);
            this.gbTotais.Location = new System.Drawing.Point(848, 165);
            this.gbTotais.Name = "gbTotais";
            this.gbTotais.Size = new System.Drawing.Size(176, 398);
            this.gbTotais.TabIndex = 2;
            this.gbTotais.TabStop = false;
            this.gbTotais.Text = "Totais";
            // 
            // dbValorFinalConta
            // 
            this.dbValorFinalConta.Enabled = false;
            this.dbValorFinalConta.Location = new System.Drawing.Point(6, 149);
            this.dbValorFinalConta.Name = "dbValorFinalConta";
            this.dbValorFinalConta.Size = new System.Drawing.Size(82, 20);
            this.dbValorFinalConta.TabIndex = 7;
            this.dbValorFinalConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbJurosConta
            // 
            this.dbJurosConta.Enabled = false;
            this.dbJurosConta.Location = new System.Drawing.Point(6, 110);
            this.dbJurosConta.Name = "dbJurosConta";
            this.dbJurosConta.Size = new System.Drawing.Size(82, 20);
            this.dbJurosConta.TabIndex = 5;
            this.dbJurosConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbMultaConta
            // 
            this.dbMultaConta.Enabled = false;
            this.dbMultaConta.Location = new System.Drawing.Point(6, 71);
            this.dbMultaConta.Name = "dbMultaConta";
            this.dbMultaConta.Size = new System.Drawing.Size(82, 20);
            this.dbMultaConta.TabIndex = 3;
            this.dbMultaConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbValorOriginalConta
            // 
            this.dbValorOriginalConta.Enabled = false;
            this.dbValorOriginalConta.Location = new System.Drawing.Point(6, 32);
            this.dbValorOriginalConta.Name = "dbValorOriginalConta";
            this.dbValorOriginalConta.Size = new System.Drawing.Size(82, 20);
            this.dbValorOriginalConta.TabIndex = 1;
            this.dbValorOriginalConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // lbJurosConta
            // 
            this.lbJurosConta.AutoSize = true;
            this.lbJurosConta.Location = new System.Drawing.Point(6, 94);
            this.lbJurosConta.Name = "lbJurosConta";
            this.lbJurosConta.Size = new System.Drawing.Size(32, 13);
            this.lbJurosConta.TabIndex = 4;
            this.lbJurosConta.Text = "Juros";
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
            // lbValorOriginalConta
            // 
            this.lbValorOriginalConta.AutoSize = true;
            this.lbValorOriginalConta.Location = new System.Drawing.Point(6, 16);
            this.lbValorOriginalConta.Name = "lbValorOriginalConta";
            this.lbValorOriginalConta.Size = new System.Drawing.Size(67, 13);
            this.lbValorOriginalConta.TabIndex = 0;
            this.lbValorOriginalConta.Text = "Valor original";
            // 
            // gbParcelas
            // 
            this.gbParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParcelas.Controls.Add(this.dbValorFinalParcela);
            this.gbParcelas.Controls.Add(this.dbJurosParcela);
            this.gbParcelas.Controls.Add(this.dbMultaParcela);
            this.gbParcelas.Controls.Add(this.dbValorOriginalParcela);
            this.gbParcelas.Controls.Add(this.btExcluirParcela);
            this.gbParcelas.Controls.Add(this.btNovaParcela);
            this.gbParcelas.Controls.Add(this.tbDataQuitacao);
            this.gbParcelas.Controls.Add(this.lbDataQuitacao);
            this.gbParcelas.Controls.Add(this.buscaFormaPagamento);
            this.gbParcelas.Controls.Add(this.btSalvarParcela);
            this.gbParcelas.Controls.Add(this.lbValorFinalParcela);
            this.gbParcelas.Controls.Add(this.lbJurosParcela);
            this.gbParcelas.Controls.Add(this.lbMultaParcela);
            this.gbParcelas.Controls.Add(this.lbValorOriginalParcela);
            this.gbParcelas.Controls.Add(this.dtpDataVencimentoParcela);
            this.gbParcelas.Controls.Add(this.lbDataVencimentoParcela);
            this.gbParcelas.Controls.Add(this.tbCodigoParcela);
            this.gbParcelas.Controls.Add(this.lbCodigoParcela);
            this.gbParcelas.Controls.Add(this.dgvParcelas);
            this.gbParcelas.Location = new System.Drawing.Point(68, 165);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(776, 398);
            this.gbParcelas.TabIndex = 1;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            // 
            // dbValorFinalParcela
            // 
            this.dbValorFinalParcela.Location = new System.Drawing.Point(423, 296);
            this.dbValorFinalParcela.Name = "dbValorFinalParcela";
            this.dbValorFinalParcela.Size = new System.Drawing.Size(82, 20);
            this.dbValorFinalParcela.TabIndex = 13;
            this.dbValorFinalParcela.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbJurosParcela
            // 
            this.dbJurosParcela.Location = new System.Drawing.Point(332, 296);
            this.dbJurosParcela.Name = "dbJurosParcela";
            this.dbJurosParcela.Size = new System.Drawing.Size(82, 20);
            this.dbJurosParcela.TabIndex = 11;
            this.dbJurosParcela.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbJurosParcela.Leave += new System.EventHandler(this.DbJurosParcela_Leave);
            // 
            // dbMultaParcela
            // 
            this.dbMultaParcela.Location = new System.Drawing.Point(244, 295);
            this.dbMultaParcela.Name = "dbMultaParcela";
            this.dbMultaParcela.Size = new System.Drawing.Size(82, 20);
            this.dbMultaParcela.TabIndex = 9;
            this.dbMultaParcela.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbMultaParcela.Leave += new System.EventHandler(this.DbMultaParcela_Leave);
            // 
            // dbValorOriginalParcela
            // 
            this.dbValorOriginalParcela.Location = new System.Drawing.Point(156, 296);
            this.dbValorOriginalParcela.Name = "dbValorOriginalParcela";
            this.dbValorOriginalParcela.Size = new System.Drawing.Size(82, 20);
            this.dbValorOriginalParcela.TabIndex = 7;
            this.dbValorOriginalParcela.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbValorOriginalParcela.Leave += new System.EventHandler(this.DbValorOriginalParcela_Leave);
            // 
            // btExcluirParcela
            // 
            this.btExcluirParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirParcela.Enabled = false;
            this.btExcluirParcela.Image = global::_5gpro.Properties.Resources.iosDelete_22px_Red;
            this.btExcluirParcela.Location = new System.Drawing.Point(744, 46);
            this.btExcluirParcela.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btExcluirParcela.Name = "btExcluirParcela";
            this.btExcluirParcela.Size = new System.Drawing.Size(24, 24);
            this.btExcluirParcela.TabIndex = 18;
            this.btExcluirParcela.UseVisualStyleBackColor = true;
            this.btExcluirParcela.Click += new System.EventHandler(this.BtExcluirParcela_Click);
            // 
            // btNovaParcela
            // 
            this.btNovaParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovaParcela.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btNovaParcela.Location = new System.Drawing.Point(744, 16);
            this.btNovaParcela.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btNovaParcela.Name = "btNovaParcela";
            this.btNovaParcela.Size = new System.Drawing.Size(24, 24);
            this.btNovaParcela.TabIndex = 1;
            this.btNovaParcela.UseVisualStyleBackColor = true;
            this.btNovaParcela.Click += new System.EventHandler(this.BtNovaParcela_Click);
            // 
            // tbDataQuitacao
            // 
            this.tbDataQuitacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDataQuitacao.Enabled = false;
            this.tbDataQuitacao.Location = new System.Drawing.Point(511, 296);
            this.tbDataQuitacao.Name = "tbDataQuitacao";
            this.tbDataQuitacao.Size = new System.Drawing.Size(83, 20);
            this.tbDataQuitacao.TabIndex = 15;
            // 
            // lbDataQuitacao
            // 
            this.lbDataQuitacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDataQuitacao.AutoSize = true;
            this.lbDataQuitacao.Location = new System.Drawing.Point(511, 280);
            this.lbDataQuitacao.Name = "lbDataQuitacao";
            this.lbDataQuitacao.Size = new System.Drawing.Size(74, 13);
            this.lbDataQuitacao.TabIndex = 14;
            this.lbDataQuitacao.Text = "Data quitação";
            // 
            // buscaFormaPagamento
            // 
            this.buscaFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buscaFormaPagamento.Location = new System.Drawing.Point(3, 318);
            this.buscaFormaPagamento.Margin = new System.Windows.Forms.Padding(0);
            this.buscaFormaPagamento.Name = "buscaFormaPagamento";
            this.buscaFormaPagamento.Size = new System.Drawing.Size(442, 39);
            this.buscaFormaPagamento.TabIndex = 16;
            // 
            // btSalvarParcela
            // 
            this.btSalvarParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvarParcela.Location = new System.Drawing.Point(9, 361);
            this.btSalvarParcela.Name = "btSalvarParcela";
            this.btSalvarParcela.Size = new System.Drawing.Size(75, 23);
            this.btSalvarParcela.TabIndex = 17;
            this.btSalvarParcela.Text = "Salvar";
            this.btSalvarParcela.UseVisualStyleBackColor = true;
            this.btSalvarParcela.Click += new System.EventHandler(this.BtSalvarParcela_Click);
            // 
            // lbValorFinalParcela
            // 
            this.lbValorFinalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorFinalParcela.AutoSize = true;
            this.lbValorFinalParcela.Location = new System.Drawing.Point(421, 280);
            this.lbValorFinalParcela.Name = "lbValorFinalParcela";
            this.lbValorFinalParcela.Size = new System.Drawing.Size(53, 13);
            this.lbValorFinalParcela.TabIndex = 12;
            this.lbValorFinalParcela.Text = "Valor final";
            // 
            // lbJurosParcela
            // 
            this.lbJurosParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbJurosParcela.AutoSize = true;
            this.lbJurosParcela.Location = new System.Drawing.Point(332, 280);
            this.lbJurosParcela.Name = "lbJurosParcela";
            this.lbJurosParcela.Size = new System.Drawing.Size(32, 13);
            this.lbJurosParcela.TabIndex = 10;
            this.lbJurosParcela.Text = "Juros";
            // 
            // lbMultaParcela
            // 
            this.lbMultaParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMultaParcela.AutoSize = true;
            this.lbMultaParcela.Location = new System.Drawing.Point(244, 280);
            this.lbMultaParcela.Name = "lbMultaParcela";
            this.lbMultaParcela.Size = new System.Drawing.Size(33, 13);
            this.lbMultaParcela.TabIndex = 8;
            this.lbMultaParcela.Text = "Multa";
            // 
            // lbValorOriginalParcela
            // 
            this.lbValorOriginalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorOriginalParcela.AutoSize = true;
            this.lbValorOriginalParcela.Location = new System.Drawing.Point(154, 280);
            this.lbValorOriginalParcela.Name = "lbValorOriginalParcela";
            this.lbValorOriginalParcela.Size = new System.Drawing.Size(67, 13);
            this.lbValorOriginalParcela.TabIndex = 6;
            this.lbValorOriginalParcela.Text = "Valor original";
            // 
            // dtpDataVencimentoParcela
            // 
            this.dtpDataVencimentoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoParcela.Location = new System.Drawing.Point(55, 296);
            this.dtpDataVencimentoParcela.Name = "dtpDataVencimentoParcela";
            this.dtpDataVencimentoParcela.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoParcela.TabIndex = 5;
            // 
            // lbDataVencimentoParcela
            // 
            this.lbDataVencimentoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDataVencimentoParcela.AutoSize = true;
            this.lbDataVencimentoParcela.Location = new System.Drawing.Point(53, 280);
            this.lbDataVencimentoParcela.Name = "lbDataVencimentoParcela";
            this.lbDataVencimentoParcela.Size = new System.Drawing.Size(103, 13);
            this.lbDataVencimentoParcela.TabIndex = 4;
            this.lbDataVencimentoParcela.Text = "Data de vencimento";
            // 
            // tbCodigoParcela
            // 
            this.tbCodigoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodigoParcela.Enabled = false;
            this.tbCodigoParcela.Location = new System.Drawing.Point(9, 296);
            this.tbCodigoParcela.Name = "tbCodigoParcela";
            this.tbCodigoParcela.Size = new System.Drawing.Size(40, 20);
            this.tbCodigoParcela.TabIndex = 3;
            // 
            // lbCodigoParcela
            // 
            this.lbCodigoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCodigoParcela.AutoSize = true;
            this.lbCodigoParcela.Location = new System.Drawing.Point(6, 280);
            this.lbCodigoParcela.Name = "lbCodigoParcela";
            this.lbCodigoParcela.Size = new System.Drawing.Size(43, 13);
            this.lbCodigoParcela.TabIndex = 2;
            this.lbCodigoParcela.Text = "Parcela";
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
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcSequencia,
            this.dgvtbcDataVencimento,
            this.dgvtbcValorOriginal,
            this.dgvtbcMulta,
            this.dgvtbcJuros,
            this.dgvtbcValorFinal,
            this.dgvtbcDataQuitacao});
            this.dgvParcelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParcelas.Location = new System.Drawing.Point(5, 15);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(735, 262);
            this.dgvParcelas.TabIndex = 0;
            this.dgvParcelas.TabStop = false;
            this.dgvParcelas.CurrentCellChanged += new System.EventHandler(this.DgvParcelas_CurrentCellChanged);
            // 
            // gbDadosConta
            // 
            this.gbDadosConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosConta.Controls.Add(this.buscaPessoa);
            this.gbDadosConta.Controls.Add(this.dtpDataCadatroConta);
            this.gbDadosConta.Controls.Add(this.lbDataCadastroConta);
            this.gbDadosConta.Controls.Add(this.tbCodigoConta);
            this.gbDadosConta.Controls.Add(this.lbCodigoConta);
            this.gbDadosConta.Location = new System.Drawing.Point(67, 14);
            this.gbDadosConta.Name = "gbDadosConta";
            this.gbDadosConta.Size = new System.Drawing.Size(958, 145);
            this.gbDadosConta.TabIndex = 0;
            this.gbDadosConta.TabStop = false;
            this.gbDadosConta.Text = "Dados da conta";
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Fornecedor";
            this.buscaPessoa.Location = new System.Drawing.Point(1, 98);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa.TabIndex = 4;
            this.buscaPessoa.Text_Changed += new _5gpro.Controls.BuscaPessoa.text_changedEventHandler(this.BuscaPessoa_Text_Changed);
            // 
            // dtpDataCadatroConta
            // 
            this.dtpDataCadatroConta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadatroConta.Location = new System.Drawing.Point(8, 75);
            this.dtpDataCadatroConta.Name = "dtpDataCadatroConta";
            this.dtpDataCadatroConta.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadatroConta.TabIndex = 3;
            this.dtpDataCadatroConta.ValueChanged += new System.EventHandler(this.DtpDataCadatroConta_ValueChanged);
            // 
            // lbDataCadastroConta
            // 
            this.lbDataCadastroConta.AutoSize = true;
            this.lbDataCadastroConta.Location = new System.Drawing.Point(5, 59);
            this.lbDataCadastroConta.Name = "lbDataCadastroConta";
            this.lbDataCadastroConta.Size = new System.Drawing.Size(89, 13);
            this.lbDataCadastroConta.TabIndex = 2;
            this.lbDataCadastroConta.Text = "Data de cadastro";
            // 
            // tbCodigoConta
            // 
            this.tbCodigoConta.Location = new System.Drawing.Point(8, 32);
            this.tbCodigoConta.Name = "tbCodigoConta";
            this.tbCodigoConta.Size = new System.Drawing.Size(58, 20);
            this.tbCodigoConta.TabIndex = 1;
            this.tbCodigoConta.Leave += new System.EventHandler(this.TbCodigoConta_Leave);
            // 
            // lbCodigoConta
            // 
            this.lbCodigoConta.AutoSize = true;
            this.lbCodigoConta.Location = new System.Drawing.Point(5, 16);
            this.lbCodigoConta.Name = "lbCodigoConta";
            this.lbCodigoConta.Size = new System.Drawing.Size(35, 13);
            this.lbCodigoConta.TabIndex = 0;
            this.lbCodigoConta.Text = "Conta";
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(11, 11);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 3;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical_Proximo_Clicked);
            // 
            // dgvtbcSequencia
            // 
            this.dgvtbcSequencia.HeaderText = "Parcela";
            this.dgvtbcSequencia.Name = "dgvtbcSequencia";
            this.dgvtbcSequencia.ReadOnly = true;
            this.dgvtbcSequencia.Width = 50;
            // 
            // dgvtbcDataVencimento
            // 
            this.dgvtbcDataVencimento.HeaderText = "Data de vencimento";
            this.dgvtbcDataVencimento.Name = "dgvtbcDataVencimento";
            this.dgvtbcDataVencimento.ReadOnly = true;
            this.dgvtbcDataVencimento.Width = 130;
            // 
            // dgvtbcValorOriginal
            // 
            this.dgvtbcValorOriginal.HeaderText = "Valor original";
            this.dgvtbcValorOriginal.Name = "dgvtbcValorOriginal";
            this.dgvtbcValorOriginal.ReadOnly = true;
            this.dgvtbcValorOriginal.Width = 90;
            // 
            // dgvtbcMulta
            // 
            this.dgvtbcMulta.HeaderText = "Multa";
            this.dgvtbcMulta.Name = "dgvtbcMulta";
            this.dgvtbcMulta.ReadOnly = true;
            this.dgvtbcMulta.Width = 40;
            // 
            // dgvtbcJuros
            // 
            this.dgvtbcJuros.HeaderText = "Juros";
            this.dgvtbcJuros.Name = "dgvtbcJuros";
            this.dgvtbcJuros.ReadOnly = true;
            this.dgvtbcJuros.Width = 40;
            // 
            // dgvtbcValorFinal
            // 
            this.dgvtbcValorFinal.HeaderText = "Valor final";
            this.dgvtbcValorFinal.Name = "dgvtbcValorFinal";
            this.dgvtbcValorFinal.ReadOnly = true;
            this.dgvtbcValorFinal.Width = 90;
            // 
            // dgvtbcDataQuitacao
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvtbcDataQuitacao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtbcDataQuitacao.HeaderText = "Data quitação";
            this.dgvtbcDataQuitacao.Name = "dgvtbcDataQuitacao";
            this.dgvtbcDataQuitacao.ReadOnly = true;
            // 
            // fmCapCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 602);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbTotais);
            this.Controls.Add(this.gbParcelas);
            this.Controls.Add(this.gbDadosConta);
            this.Controls.Add(this.menuVertical);
            this.KeyPreview = true;
            this.Name = "fmCapCadastroConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de contas a pagar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCapCadastroConta_KeyDown);
            this.gbTotais.ResumeLayout(false);
            this.gbTotais.PerformLayout();
            this.gbParcelas.ResumeLayout(false);
            this.gbParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.gbDadosConta.ResumeLayout(false);
            this.gbDadosConta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.GroupBox gbTotais;
        private System.Windows.Forms.Label lbValorTotalConta;
        private System.Windows.Forms.Label lbJurosConta;
        private System.Windows.Forms.Label lbMultaConta;
        private System.Windows.Forms.Label lbValorOriginalConta;
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.TextBox tbDataQuitacao;
        private System.Windows.Forms.Label lbDataQuitacao;
        private Controls.BuscaFormaPagamento buscaFormaPagamento;
        private System.Windows.Forms.Button btSalvarParcela;
        private System.Windows.Forms.Label lbValorFinalParcela;
        private System.Windows.Forms.Label lbJurosParcela;
        private System.Windows.Forms.Label lbMultaParcela;
        private System.Windows.Forms.Label lbValorOriginalParcela;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoParcela;
        private System.Windows.Forms.Label lbDataVencimentoParcela;
        private System.Windows.Forms.TextBox tbCodigoParcela;
        private System.Windows.Forms.Label lbCodigoParcela;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.GroupBox gbDadosConta;
        private System.Windows.Forms.DateTimePicker dtpDataCadatroConta;
        private System.Windows.Forms.Label lbDataCadastroConta;
        private System.Windows.Forms.TextBox tbCodigoConta;
        private System.Windows.Forms.Label lbCodigoConta;
        private Controls.MenuVertical menuVertical;
        private Controls.BuscaPessoa buscaPessoa;
        private System.Windows.Forms.Button btExcluirParcela;
        private System.Windows.Forms.Button btNovaParcela;
        private Controls.DecimalBox dbValorOriginalParcela;
        private Controls.DecimalBox dbMultaParcela;
        private Controls.DecimalBox dbJurosParcela;
        private Controls.DecimalBox dbValorFinalParcela;
        private Controls.DecimalBox dbValorOriginalConta;
        private Controls.DecimalBox dbValorFinalConta;
        private Controls.DecimalBox dbJurosConta;
        private Controls.DecimalBox dbMultaConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcSequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataQuitacao;
    }
}