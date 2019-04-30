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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDadosConta = new System.Windows.Forms.GroupBox();
            this.dtpDataCadatroConta = new System.Windows.Forms.DateTimePicker();
            this.lbDataCadastroConta = new System.Windows.Forms.Label();
            this.tbCodigoConta = new System.Windows.Forms.TextBox();
            this.lbCodigoConta = new System.Windows.Forms.Label();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.tbDataQuitacao = new System.Windows.Forms.TextBox();
            this.lbDataQuitacao = new System.Windows.Forms.Label();
            this.btSalvarParcela = new System.Windows.Forms.Button();
            this.tbValorFinalParcela = new System.Windows.Forms.TextBox();
            this.lbValorFinalParcela = new System.Windows.Forms.Label();
            this.tbJurosParcela = new System.Windows.Forms.TextBox();
            this.lbJurosParcela = new System.Windows.Forms.Label();
            this.tbMultaParcela = new System.Windows.Forms.TextBox();
            this.lbMultaParcela = new System.Windows.Forms.Label();
            this.tbValorOriginalParcela = new System.Windows.Forms.TextBox();
            this.lbValorOriginalParcela = new System.Windows.Forms.Label();
            this.dtpDataVencimentoParcela = new System.Windows.Forms.DateTimePicker();
            this.lbDataVencimentoParcela = new System.Windows.Forms.Label();
            this.tbCodigoParcela = new System.Windows.Forms.TextBox();
            this.lbCodigoParcela = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.dgvtbcSequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataQuitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTotais = new System.Windows.Forms.GroupBox();
            this.btGerarParcelas = new System.Windows.Forms.Button();
            this.tbValorFinalConta = new System.Windows.Forms.TextBox();
            this.lbValorTotalConta = new System.Windows.Forms.Label();
            this.tbJurosConta = new System.Windows.Forms.TextBox();
            this.lbJurosConta = new System.Windows.Forms.Label();
            this.tbMultaConta = new System.Windows.Forms.TextBox();
            this.lbMultaConta = new System.Windows.Forms.Label();
            this.tbValorOriginalConta = new System.Windows.Forms.TextBox();
            this.lbValorOriginalConta = new System.Windows.Forms.Label();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.buscaFormaPagamento = new _5gpro.Controls.BuscaFormaPagamento();
            this.buscaOperacao = new _5gpro.Controls.BuscaOperacao();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
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
            this.gbDadosConta.Controls.Add(this.buscaOperacao);
            this.gbDadosConta.Controls.Add(this.dtpDataCadatroConta);
            this.gbDadosConta.Controls.Add(this.lbDataCadastroConta);
            this.gbDadosConta.Controls.Add(this.tbCodigoConta);
            this.gbDadosConta.Controls.Add(this.lbCodigoConta);
            this.gbDadosConta.Location = new System.Drawing.Point(65, 12);
            this.gbDadosConta.Name = "gbDadosConta";
            this.gbDadosConta.Size = new System.Drawing.Size(958, 143);
            this.gbDadosConta.TabIndex = 0;
            this.gbDadosConta.TabStop = false;
            this.gbDadosConta.Text = "Dados da conta";
            // 
            // dtpDataCadatroConta
            // 
            this.dtpDataCadatroConta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadatroConta.Location = new System.Drawing.Point(6, 75);
            this.dtpDataCadatroConta.Name = "dtpDataCadatroConta";
            this.dtpDataCadatroConta.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadatroConta.TabIndex = 3;
            this.dtpDataCadatroConta.ValueChanged += new System.EventHandler(this.DtpDataCadatroConta_ValueChanged);
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
            // tbCodigoConta
            // 
            this.tbCodigoConta.Location = new System.Drawing.Point(6, 32);
            this.tbCodigoConta.Name = "tbCodigoConta";
            this.tbCodigoConta.Size = new System.Drawing.Size(58, 20);
            this.tbCodigoConta.TabIndex = 1;
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
            // gbParcelas
            // 
            this.gbParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParcelas.Controls.Add(this.tbDataQuitacao);
            this.gbParcelas.Controls.Add(this.lbDataQuitacao);
            this.gbParcelas.Controls.Add(this.buscaFormaPagamento);
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
            this.gbParcelas.Location = new System.Drawing.Point(65, 161);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(776, 391);
            this.gbParcelas.TabIndex = 1;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            // 
            // tbDataQuitacao
            // 
            this.tbDataQuitacao.Enabled = false;
            this.tbDataQuitacao.Location = new System.Drawing.Point(511, 289);
            this.tbDataQuitacao.Name = "tbDataQuitacao";
            this.tbDataQuitacao.Size = new System.Drawing.Size(83, 20);
            this.tbDataQuitacao.TabIndex = 14;
            // 
            // lbDataQuitacao
            // 
            this.lbDataQuitacao.AutoSize = true;
            this.lbDataQuitacao.Location = new System.Drawing.Point(511, 273);
            this.lbDataQuitacao.Name = "lbDataQuitacao";
            this.lbDataQuitacao.Size = new System.Drawing.Size(74, 13);
            this.lbDataQuitacao.TabIndex = 13;
            this.lbDataQuitacao.Text = "Data quitação";
            // 
            // btSalvarParcela
            // 
            this.btSalvarParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvarParcela.Location = new System.Drawing.Point(9, 354);
            this.btSalvarParcela.Name = "btSalvarParcela";
            this.btSalvarParcela.Size = new System.Drawing.Size(75, 23);
            this.btSalvarParcela.TabIndex = 16;
            this.btSalvarParcela.Text = "Salvar";
            this.btSalvarParcela.UseVisualStyleBackColor = true;
            this.btSalvarParcela.Click += new System.EventHandler(this.BtSalvarParcela_Click);
            // 
            // tbValorFinalParcela
            // 
            this.tbValorFinalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorFinalParcela.Location = new System.Drawing.Point(423, 289);
            this.tbValorFinalParcela.Name = "tbValorFinalParcela";
            this.tbValorFinalParcela.Size = new System.Drawing.Size(82, 20);
            this.tbValorFinalParcela.TabIndex = 12;
            this.tbValorFinalParcela.Text = "0,00";
            this.tbValorFinalParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValorFinalParcela_KeyPress);
            // 
            // lbValorFinalParcela
            // 
            this.lbValorFinalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorFinalParcela.AutoSize = true;
            this.lbValorFinalParcela.Location = new System.Drawing.Point(421, 273);
            this.lbValorFinalParcela.Name = "lbValorFinalParcela";
            this.lbValorFinalParcela.Size = new System.Drawing.Size(53, 13);
            this.lbValorFinalParcela.TabIndex = 11;
            this.lbValorFinalParcela.Text = "Valor final";
            // 
            // tbJurosParcela
            // 
            this.tbJurosParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbJurosParcela.Location = new System.Drawing.Point(333, 289);
            this.tbJurosParcela.Name = "tbJurosParcela";
            this.tbJurosParcela.Size = new System.Drawing.Size(82, 20);
            this.tbJurosParcela.TabIndex = 10;
            this.tbJurosParcela.Text = "0,00";
            this.tbJurosParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbJurosParcela_KeyPress);
            this.tbJurosParcela.Leave += new System.EventHandler(this.TbJurosParcela_Leave);
            // 
            // lbJurosParcela
            // 
            this.lbJurosParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbJurosParcela.AutoSize = true;
            this.lbJurosParcela.Location = new System.Drawing.Point(332, 273);
            this.lbJurosParcela.Name = "lbJurosParcela";
            this.lbJurosParcela.Size = new System.Drawing.Size(32, 13);
            this.lbJurosParcela.TabIndex = 9;
            this.lbJurosParcela.Text = "Juros";
            // 
            // tbMultaParcela
            // 
            this.tbMultaParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMultaParcela.Location = new System.Drawing.Point(244, 289);
            this.tbMultaParcela.Name = "tbMultaParcela";
            this.tbMultaParcela.Size = new System.Drawing.Size(82, 20);
            this.tbMultaParcela.TabIndex = 8;
            this.tbMultaParcela.Text = "0,00";
            this.tbMultaParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMultaParcela_KeyPress);
            this.tbMultaParcela.Leave += new System.EventHandler(this.TbMultaParcela_Leave);
            // 
            // lbMultaParcela
            // 
            this.lbMultaParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMultaParcela.AutoSize = true;
            this.lbMultaParcela.Location = new System.Drawing.Point(244, 273);
            this.lbMultaParcela.Name = "lbMultaParcela";
            this.lbMultaParcela.Size = new System.Drawing.Size(33, 13);
            this.lbMultaParcela.TabIndex = 7;
            this.lbMultaParcela.Text = "Multa";
            // 
            // tbValorOriginalParcela
            // 
            this.tbValorOriginalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorOriginalParcela.Location = new System.Drawing.Point(156, 289);
            this.tbValorOriginalParcela.Name = "tbValorOriginalParcela";
            this.tbValorOriginalParcela.Size = new System.Drawing.Size(82, 20);
            this.tbValorOriginalParcela.TabIndex = 6;
            this.tbValorOriginalParcela.Text = "0,00";
            this.tbValorOriginalParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValorOriginalParcela_KeyPress);
            this.tbValorOriginalParcela.Leave += new System.EventHandler(this.TbValorOriginalParcela_Leave);
            // 
            // lbValorOriginalParcela
            // 
            this.lbValorOriginalParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorOriginalParcela.AutoSize = true;
            this.lbValorOriginalParcela.Location = new System.Drawing.Point(154, 273);
            this.lbValorOriginalParcela.Name = "lbValorOriginalParcela";
            this.lbValorOriginalParcela.Size = new System.Drawing.Size(67, 13);
            this.lbValorOriginalParcela.TabIndex = 5;
            this.lbValorOriginalParcela.Text = "Valor original";
            // 
            // dtpDataVencimentoParcela
            // 
            this.dtpDataVencimentoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoParcela.Location = new System.Drawing.Point(55, 289);
            this.dtpDataVencimentoParcela.Name = "dtpDataVencimentoParcela";
            this.dtpDataVencimentoParcela.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoParcela.TabIndex = 4;
            // 
            // lbDataVencimentoParcela
            // 
            this.lbDataVencimentoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDataVencimentoParcela.AutoSize = true;
            this.lbDataVencimentoParcela.Location = new System.Drawing.Point(53, 273);
            this.lbDataVencimentoParcela.Name = "lbDataVencimentoParcela";
            this.lbDataVencimentoParcela.Size = new System.Drawing.Size(103, 13);
            this.lbDataVencimentoParcela.TabIndex = 3;
            this.lbDataVencimentoParcela.Text = "Data de vencimento";
            // 
            // tbCodigoParcela
            // 
            this.tbCodigoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodigoParcela.Location = new System.Drawing.Point(9, 289);
            this.tbCodigoParcela.Name = "tbCodigoParcela";
            this.tbCodigoParcela.Size = new System.Drawing.Size(40, 20);
            this.tbCodigoParcela.TabIndex = 2;
            // 
            // lbCodigoParcela
            // 
            this.lbCodigoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCodigoParcela.AutoSize = true;
            this.lbCodigoParcela.Location = new System.Drawing.Point(6, 273);
            this.lbCodigoParcela.Name = "lbCodigoParcela";
            this.lbCodigoParcela.Size = new System.Drawing.Size(43, 13);
            this.lbCodigoParcela.TabIndex = 1;
            this.lbCodigoParcela.Text = "Parcela";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToOrderColumns = true;
            this.dgvParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dgvParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvParcelas.Size = new System.Drawing.Size(766, 255);
            this.dgvParcelas.TabIndex = 0;
            this.dgvParcelas.TabStop = false;
            this.dgvParcelas.CurrentCellChanged += new System.EventHandler(this.DgvParcelas_CurrentCellChanged);
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
            this.dgvtbcDataQuitacao.HeaderText = "Data quitação";
            this.dgvtbcDataQuitacao.Name = "dgvtbcDataQuitacao";
            this.dgvtbcDataQuitacao.ReadOnly = true;
            // 
            // gbTotais
            // 
            this.gbTotais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotais.Controls.Add(this.btGerarParcelas);
            this.gbTotais.Controls.Add(this.tbValorFinalConta);
            this.gbTotais.Controls.Add(this.lbValorTotalConta);
            this.gbTotais.Controls.Add(this.tbJurosConta);
            this.gbTotais.Controls.Add(this.lbJurosConta);
            this.gbTotais.Controls.Add(this.tbMultaConta);
            this.gbTotais.Controls.Add(this.lbMultaConta);
            this.gbTotais.Controls.Add(this.tbValorOriginalConta);
            this.gbTotais.Controls.Add(this.lbValorOriginalConta);
            this.gbTotais.Location = new System.Drawing.Point(846, 161);
            this.gbTotais.Name = "gbTotais";
            this.gbTotais.Size = new System.Drawing.Size(176, 391);
            this.gbTotais.TabIndex = 2;
            this.gbTotais.TabStop = false;
            this.gbTotais.Text = "Totais";
            // 
            // btGerarParcelas
            // 
            this.btGerarParcelas.Location = new System.Drawing.Point(6, 175);
            this.btGerarParcelas.Name = "btGerarParcelas";
            this.btGerarParcelas.Size = new System.Drawing.Size(88, 23);
            this.btGerarParcelas.TabIndex = 8;
            this.btGerarParcelas.Text = "Gerar parcelas";
            this.btGerarParcelas.UseVisualStyleBackColor = true;
            this.btGerarParcelas.Click += new System.EventHandler(this.BtGerarParcelas_Click);
            // 
            // tbValorFinalConta
            // 
            this.tbValorFinalConta.Location = new System.Drawing.Point(6, 149);
            this.tbValorFinalConta.Name = "tbValorFinalConta";
            this.tbValorFinalConta.Size = new System.Drawing.Size(82, 20);
            this.tbValorFinalConta.TabIndex = 7;
            this.tbValorFinalConta.Text = "0,00";
            this.tbValorFinalConta.TextChanged += new System.EventHandler(this.TbValorFinalConta_TextChanged);
            this.tbValorFinalConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValorFinalConta_KeyPress);
            this.tbValorFinalConta.Leave += new System.EventHandler(this.TbValorFinalConta_Leave);
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
            // tbJurosConta
            // 
            this.tbJurosConta.Location = new System.Drawing.Point(6, 110);
            this.tbJurosConta.Name = "tbJurosConta";
            this.tbJurosConta.Size = new System.Drawing.Size(82, 20);
            this.tbJurosConta.TabIndex = 5;
            this.tbJurosConta.Text = "0,00";
            this.tbJurosConta.TextChanged += new System.EventHandler(this.TbJurosConta_TextChanged);
            this.tbJurosConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbJurosConta_KeyPress);
            this.tbJurosConta.Leave += new System.EventHandler(this.TbJurosConta_Leave);
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
            // tbMultaConta
            // 
            this.tbMultaConta.Location = new System.Drawing.Point(6, 71);
            this.tbMultaConta.Name = "tbMultaConta";
            this.tbMultaConta.Size = new System.Drawing.Size(82, 20);
            this.tbMultaConta.TabIndex = 3;
            this.tbMultaConta.Text = "0,00";
            this.tbMultaConta.TextChanged += new System.EventHandler(this.TbMultaConta_TextChanged);
            this.tbMultaConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMultaConta_KeyPress);
            this.tbMultaConta.Leave += new System.EventHandler(this.TbMultaConta_Leave);
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
            // tbValorOriginalConta
            // 
            this.tbValorOriginalConta.Location = new System.Drawing.Point(6, 32);
            this.tbValorOriginalConta.Name = "tbValorOriginalConta";
            this.tbValorOriginalConta.Size = new System.Drawing.Size(82, 20);
            this.tbValorOriginalConta.TabIndex = 1;
            this.tbValorOriginalConta.Text = "0,00";
            this.tbValorOriginalConta.TextChanged += new System.EventHandler(this.TbValorOriginalConta_TextChanged);
            this.tbValorOriginalConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbValorOriginalConta_KeyPress);
            this.tbValorOriginalConta.Leave += new System.EventHandler(this.TbValorOriginalConta_Leave);
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
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(65, 558);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(959, 20);
            this.tbAjuda.TabIndex = 4;
            // 
            // buscaFormaPagamento
            // 
            this.buscaFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buscaFormaPagamento.Location = new System.Drawing.Point(3, 311);
            this.buscaFormaPagamento.Margin = new System.Windows.Forms.Padding(0);
            this.buscaFormaPagamento.Name = "buscaFormaPagamento";
            this.buscaFormaPagamento.Size = new System.Drawing.Size(442, 39);
            this.buscaFormaPagamento.TabIndex = 15;
            // 
            // buscaOperacao
            // 
            this.buscaOperacao.Location = new System.Drawing.Point(1, 98);
            this.buscaOperacao.Margin = new System.Windows.Forms.Padding(0);
            this.buscaOperacao.Name = "buscaOperacao";
            this.buscaOperacao.Size = new System.Drawing.Size(442, 39);
            this.buscaOperacao.TabIndex = 4;
            this.buscaOperacao.Text_Changed += new _5gpro.Controls.BuscaOperacao.text_changedEventHandler(this.BuscaOperacao_Text_Changed);
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
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
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical_Excluir_Clicked);
            // 
            // fmCarCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 590);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbTotais);
            this.Controls.Add(this.gbParcelas);
            this.Controls.Add(this.gbDadosConta);
            this.Controls.Add(this.menuVertical);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1052, 628);
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
        private Controls.BuscaFormaPagamento buscaFormaPagamento;
        private System.Windows.Forms.Button btGerarParcelas;
        private System.Windows.Forms.TextBox tbDataQuitacao;
        private System.Windows.Forms.Label lbDataQuitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcSequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataQuitacao;
    }
}