namespace _5gpro.Forms
{
    partial class fmCapQuitacaoConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.lbValorInicial = new System.Windows.Forms.Label();
            this.lbDataVencimento = new System.Windows.Forms.Label();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.cbDataCadastro = new System.Windows.Forms.CheckBox();
            this.cbValor = new System.Windows.Forms.CheckBox();
            this.cbDataVencimento = new System.Windows.Forms.CheckBox();
            this.dbValorInicial = new _5gpro.Controls.DecimalBox();
            this.dbValorFinal = new _5gpro.Controls.DecimalBox();
            this.lbAValorConta = new System.Windows.Forms.Label();
            this.lbADataVencimentoParcela = new System.Windows.Forms.Label();
            this.lbADataCadastro = new System.Windows.Forms.Label();
            this.dtpDataVencimentoInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataVencimentoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataCadastroFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataCadastroInicial = new System.Windows.Forms.DateTimePicker();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lbCodigoConta = new System.Windows.Forms.Label();
            this.tbCodigoConta = new System.Windows.Forms.TextBox();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscaCaixa = new _5gpro.Controls.BuscaCaixa();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.dbDesconto = new _5gpro.Controls.DecimalBox();
            this.btQuitar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dbValorTotal = new _5gpro.Controls.DecimalBox();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.dbAcrescimo = new _5gpro.Controls.DecimalBox();
            this.lbAcrescimo = new System.Windows.Forms.Label();
            this.dbJuros = new _5gpro.Controls.DecimalBox();
            this.lbJuros = new System.Windows.Forms.Label();
            this.dbMulta = new _5gpro.Controls.DecimalBox();
            this.lbMulta = new System.Windows.Forms.Label();
            this.dbValor = new _5gpro.Controls.DecimalBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCodigoParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscaPlanoContaCaixa = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.gbPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.lbValorInicial);
            this.gbPesquisa.Controls.Add(this.lbDataVencimento);
            this.gbPesquisa.Controls.Add(this.lbDataCadastro);
            this.gbPesquisa.Controls.Add(this.cbDataCadastro);
            this.gbPesquisa.Controls.Add(this.cbValor);
            this.gbPesquisa.Controls.Add(this.cbDataVencimento);
            this.gbPesquisa.Controls.Add(this.dbValorInicial);
            this.gbPesquisa.Controls.Add(this.dbValorFinal);
            this.gbPesquisa.Controls.Add(this.lbAValorConta);
            this.gbPesquisa.Controls.Add(this.lbADataVencimentoParcela);
            this.gbPesquisa.Controls.Add(this.lbADataCadastro);
            this.gbPesquisa.Controls.Add(this.dtpDataVencimentoInicial);
            this.gbPesquisa.Controls.Add(this.dtpDataVencimentoFinal);
            this.gbPesquisa.Controls.Add(this.dtpDataCadastroFinal);
            this.gbPesquisa.Controls.Add(this.dtpDataCadastroInicial);
            this.gbPesquisa.Controls.Add(this.btPesquisar);
            this.gbPesquisa.Controls.Add(this.lbCodigoConta);
            this.gbPesquisa.Controls.Add(this.tbCodigoConta);
            this.gbPesquisa.Controls.Add(this.buscaPessoa);
            this.gbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(927, 107);
            this.gbPesquisa.TabIndex = 0;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisa";
            // 
            // lbValorInicial
            // 
            this.lbValorInicial.AutoSize = true;
            this.lbValorInicial.Location = new System.Drawing.Point(552, 71);
            this.lbValorInicial.Name = "lbValorInicial";
            this.lbValorInicial.Size = new System.Drawing.Size(77, 13);
            this.lbValorInicial.TabIndex = 13;
            this.lbValorInicial.Text = "Valor da Conta";
            // 
            // lbDataVencimento
            // 
            this.lbDataVencimento.AutoSize = true;
            this.lbDataVencimento.Location = new System.Drawing.Point(529, 42);
            this.lbDataVencimento.Name = "lbDataVencimento";
            this.lbDataVencimento.Size = new System.Drawing.Size(102, 13);
            this.lbDataVencimento.TabIndex = 8;
            this.lbDataVencimento.Text = "Vencimento Parcela";
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Location = new System.Drawing.Point(554, 13);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(75, 13);
            this.lbDataCadastro.TabIndex = 3;
            this.lbDataCadastro.Text = "Data Cadastro";
            // 
            // cbDataCadastro
            // 
            this.cbDataCadastro.AutoSize = true;
            this.cbDataCadastro.Location = new System.Drawing.Point(846, 15);
            this.cbDataCadastro.Name = "cbDataCadastro";
            this.cbDataCadastro.Size = new System.Drawing.Size(15, 14);
            this.cbDataCadastro.TabIndex = 7;
            this.cbDataCadastro.UseVisualStyleBackColor = true;
            this.cbDataCadastro.CheckedChanged += new System.EventHandler(this.CbDataCadastro_CheckedChanged);
            // 
            // cbValor
            // 
            this.cbValor.AutoSize = true;
            this.cbValor.Location = new System.Drawing.Point(847, 71);
            this.cbValor.Name = "cbValor";
            this.cbValor.Size = new System.Drawing.Size(15, 14);
            this.cbValor.TabIndex = 17;
            this.cbValor.UseVisualStyleBackColor = true;
            this.cbValor.CheckedChanged += new System.EventHandler(this.CbValor_CheckedChanged);
            // 
            // cbDataVencimento
            // 
            this.cbDataVencimento.AutoSize = true;
            this.cbDataVencimento.Location = new System.Drawing.Point(847, 43);
            this.cbDataVencimento.Name = "cbDataVencimento";
            this.cbDataVencimento.Size = new System.Drawing.Size(15, 14);
            this.cbDataVencimento.TabIndex = 12;
            this.cbDataVencimento.UseVisualStyleBackColor = true;
            this.cbDataVencimento.CheckedChanged += new System.EventHandler(this.CbDataVencimento_CheckedChanged);
            // 
            // dbValorInicial
            // 
            this.dbValorInicial.Enabled = false;
            this.dbValorInicial.Location = new System.Drawing.Point(634, 67);
            this.dbValorInicial.Name = "dbValorInicial";
            this.dbValorInicial.Size = new System.Drawing.Size(95, 22);
            this.dbValorInicial.TabIndex = 14;
            this.dbValorInicial.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbValorFinal
            // 
            this.dbValorFinal.Enabled = false;
            this.dbValorFinal.Location = new System.Drawing.Point(745, 67);
            this.dbValorFinal.Name = "dbValorFinal";
            this.dbValorFinal.Size = new System.Drawing.Size(95, 22);
            this.dbValorFinal.TabIndex = 16;
            this.dbValorFinal.Valor = new decimal(new int[] {
            99999900,
            0,
            0,
            131072});
            // 
            // lbAValorConta
            // 
            this.lbAValorConta.AutoSize = true;
            this.lbAValorConta.Location = new System.Drawing.Point(732, 71);
            this.lbAValorConta.Name = "lbAValorConta";
            this.lbAValorConta.Size = new System.Drawing.Size(13, 13);
            this.lbAValorConta.TabIndex = 15;
            this.lbAValorConta.Text = "a";
            // 
            // lbADataVencimentoParcela
            // 
            this.lbADataVencimentoParcela.AutoSize = true;
            this.lbADataVencimentoParcela.Location = new System.Drawing.Point(731, 43);
            this.lbADataVencimentoParcela.Name = "lbADataVencimentoParcela";
            this.lbADataVencimentoParcela.Size = new System.Drawing.Size(13, 13);
            this.lbADataVencimentoParcela.TabIndex = 10;
            this.lbADataVencimentoParcela.Text = "a";
            // 
            // lbADataCadastro
            // 
            this.lbADataCadastro.AutoSize = true;
            this.lbADataCadastro.Location = new System.Drawing.Point(731, 16);
            this.lbADataCadastro.Name = "lbADataCadastro";
            this.lbADataCadastro.Size = new System.Drawing.Size(13, 13);
            this.lbADataCadastro.TabIndex = 5;
            this.lbADataCadastro.Text = "a";
            // 
            // dtpDataVencimentoInicial
            // 
            this.dtpDataVencimentoInicial.Enabled = false;
            this.dtpDataVencimentoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoInicial.Location = new System.Drawing.Point(634, 40);
            this.dtpDataVencimentoInicial.Name = "dtpDataVencimentoInicial";
            this.dtpDataVencimentoInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoInicial.TabIndex = 9;
            // 
            // dtpDataVencimentoFinal
            // 
            this.dtpDataVencimentoFinal.Enabled = false;
            this.dtpDataVencimentoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoFinal.Location = new System.Drawing.Point(745, 40);
            this.dtpDataVencimentoFinal.Name = "dtpDataVencimentoFinal";
            this.dtpDataVencimentoFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoFinal.TabIndex = 11;
            // 
            // dtpDataCadastroFinal
            // 
            this.dtpDataCadastroFinal.Enabled = false;
            this.dtpDataCadastroFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroFinal.Location = new System.Drawing.Point(745, 13);
            this.dtpDataCadastroFinal.Name = "dtpDataCadastroFinal";
            this.dtpDataCadastroFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadastroFinal.TabIndex = 6;
            // 
            // dtpDataCadastroInicial
            // 
            this.dtpDataCadastroInicial.Enabled = false;
            this.dtpDataCadastroInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroInicial.Location = new System.Drawing.Point(634, 13);
            this.dtpDataCadastroInicial.Name = "dtpDataCadastroInicial";
            this.dtpDataCadastroInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadastroInicial.TabIndex = 4;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(13, 71);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 18;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // lbCodigoConta
            // 
            this.lbCodigoConta.AutoSize = true;
            this.lbCodigoConta.Location = new System.Drawing.Point(10, 22);
            this.lbCodigoConta.Name = "lbCodigoConta";
            this.lbCodigoConta.Size = new System.Drawing.Size(35, 13);
            this.lbCodigoConta.TabIndex = 0;
            this.lbCodigoConta.Text = "Conta";
            // 
            // tbCodigoConta
            // 
            this.tbCodigoConta.Location = new System.Drawing.Point(13, 38);
            this.tbCodigoConta.Name = "tbCodigoConta";
            this.tbCodigoConta.Size = new System.Drawing.Size(66, 20);
            this.tbCodigoConta.TabIndex = 1;
            this.tbCodigoConta.Leave += new System.EventHandler(this.TbCodigoConta_Leave);
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Fornecedor";
            this.buscaPessoa.Location = new System.Drawing.Point(79, 21);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buscaPlanoContaCaixa);
            this.groupBox1.Controls.Add(this.buscaCaixa);
            this.groupBox1.Controls.Add(this.lbDesconto);
            this.groupBox1.Controls.Add(this.dbDesconto);
            this.groupBox1.Controls.Add(this.btQuitar);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.dbValorTotal);
            this.groupBox1.Controls.Add(this.lbValorTotal);
            this.groupBox1.Controls.Add(this.dbAcrescimo);
            this.groupBox1.Controls.Add(this.lbAcrescimo);
            this.groupBox1.Controls.Add(this.dbJuros);
            this.groupBox1.Controls.Add(this.lbJuros);
            this.groupBox1.Controls.Add(this.dbMulta);
            this.groupBox1.Controls.Add(this.lbMulta);
            this.groupBox1.Controls.Add(this.dbValor);
            this.groupBox1.Controls.Add(this.lbValor);
            this.groupBox1.Controls.Add(this.tbCount);
            this.groupBox1.Controls.Add(this.lbCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento";
            // 
            // buscaCaixa
            // 
            this.buscaCaixa.BackColor = System.Drawing.Color.White;
            this.buscaCaixa.Location = new System.Drawing.Point(475, 15);
            this.buscaCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCaixa.Name = "buscaCaixa";
            this.buscaCaixa.Size = new System.Drawing.Size(264, 39);
            this.buscaCaixa.TabIndex = 14;
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(334, 15);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(53, 13);
            this.lbDesconto.TabIndex = 10;
            this.lbDesconto.Text = "Desconto";
            // 
            // dbDesconto
            // 
            this.dbDesconto.Location = new System.Drawing.Point(334, 32);
            this.dbDesconto.Name = "dbDesconto";
            this.dbDesconto.Size = new System.Drawing.Size(66, 22);
            this.dbDesconto.TabIndex = 11;
            this.dbDesconto.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(745, 70);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(75, 23);
            this.btQuitar.TabIndex = 16;
            this.btQuitar.Text = "Quitar";
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.BtQuitar_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(6, 71);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(304, 42);
            this.lbTotal.TabIndex = 15;
            this.lbTotal.Text = "TOTAL: R$ 0,00";
            // 
            // dbValorTotal
            // 
            this.dbValorTotal.Location = new System.Drawing.Point(406, 32);
            this.dbValorTotal.Name = "dbValorTotal";
            this.dbValorTotal.Size = new System.Drawing.Size(66, 22);
            this.dbValorTotal.TabIndex = 13;
            this.dbValorTotal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Location = new System.Drawing.Point(403, 14);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lbValorTotal.TabIndex = 12;
            this.lbValorTotal.Text = "Valor Total";
            // 
            // dbAcrescimo
            // 
            this.dbAcrescimo.Location = new System.Drawing.Point(262, 32);
            this.dbAcrescimo.Name = "dbAcrescimo";
            this.dbAcrescimo.Size = new System.Drawing.Size(66, 22);
            this.dbAcrescimo.TabIndex = 9;
            this.dbAcrescimo.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbAcrescimo
            // 
            this.lbAcrescimo.AutoSize = true;
            this.lbAcrescimo.Location = new System.Drawing.Point(259, 16);
            this.lbAcrescimo.Name = "lbAcrescimo";
            this.lbAcrescimo.Size = new System.Drawing.Size(56, 13);
            this.lbAcrescimo.TabIndex = 8;
            this.lbAcrescimo.Text = "Acréscimo";
            // 
            // dbJuros
            // 
            this.dbJuros.Location = new System.Drawing.Point(190, 32);
            this.dbJuros.Name = "dbJuros";
            this.dbJuros.Size = new System.Drawing.Size(66, 22);
            this.dbJuros.TabIndex = 7;
            this.dbJuros.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbJuros
            // 
            this.lbJuros.AutoSize = true;
            this.lbJuros.Location = new System.Drawing.Point(187, 16);
            this.lbJuros.Name = "lbJuros";
            this.lbJuros.Size = new System.Drawing.Size(32, 13);
            this.lbJuros.TabIndex = 6;
            this.lbJuros.Text = "Juros";
            // 
            // dbMulta
            // 
            this.dbMulta.Location = new System.Drawing.Point(118, 32);
            this.dbMulta.Name = "dbMulta";
            this.dbMulta.Size = new System.Drawing.Size(66, 22);
            this.dbMulta.TabIndex = 5;
            this.dbMulta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbMulta
            // 
            this.lbMulta.AutoSize = true;
            this.lbMulta.Location = new System.Drawing.Point(115, 16);
            this.lbMulta.Name = "lbMulta";
            this.lbMulta.Size = new System.Drawing.Size(33, 13);
            this.lbMulta.TabIndex = 4;
            this.lbMulta.Text = "Multa";
            // 
            // dbValor
            // 
            this.dbValor.Location = new System.Drawing.Point(47, 32);
            this.dbValor.Name = "dbValor";
            this.dbValor.Size = new System.Drawing.Size(66, 22);
            this.dbValor.TabIndex = 3;
            this.dbValor.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(44, 16);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Valor";
            // 
            // tbCount
            // 
            this.tbCount.Enabled = false;
            this.tbCount.Location = new System.Drawing.Point(9, 32);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(32, 20);
            this.tbCount.TabIndex = 1;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(6, 16);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(24, 13);
            this.lbCount.TabIndex = 0;
            this.lbCount.Text = "Qtd";
            // 
            // gbParcelas
            // 
            this.gbParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParcelas.Controls.Add(this.dgvParcelas);
            this.gbParcelas.Location = new System.Drawing.Point(12, 125);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(928, 338);
            this.gbParcelas.TabIndex = 1;
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
            this.dgvParcelas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigoConta,
            this.dgvtbcCodigoParcela,
            this.dgvtbcDataVencimento,
            this.dgvtbcValor,
            this.dgvtbcMulta,
            this.dgvtbcJuros,
            this.dgvtbcAcrescimo,
            this.dgvtbcDesconto,
            this.dgvtbcValorFinal});
            this.dgvParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParcelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParcelas.Location = new System.Drawing.Point(3, 16);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(922, 319);
            this.dgvParcelas.TabIndex = 0;
            this.dgvParcelas.TabStop = false;
            this.dgvParcelas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParcelas_CellDoubleClick);
            this.dgvParcelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvParcelas_KeyDown);
            // 
            // dgvtbcCodigoConta
            // 
            this.dgvtbcCodigoConta.HeaderText = "Conta";
            this.dgvtbcCodigoConta.Name = "dgvtbcCodigoConta";
            this.dgvtbcCodigoConta.ReadOnly = true;
            // 
            // dgvtbcCodigoParcela
            // 
            this.dgvtbcCodigoParcela.HeaderText = "Parcela";
            this.dgvtbcCodigoParcela.Name = "dgvtbcCodigoParcela";
            this.dgvtbcCodigoParcela.ReadOnly = true;
            // 
            // dgvtbcDataVencimento
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvtbcDataVencimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtbcDataVencimento.HeaderText = "Vencimento";
            this.dgvtbcDataVencimento.Name = "dgvtbcDataVencimento";
            this.dgvtbcDataVencimento.ReadOnly = true;
            // 
            // dgvtbcValor
            // 
            this.dgvtbcValor.HeaderText = "Valor";
            this.dgvtbcValor.Name = "dgvtbcValor";
            this.dgvtbcValor.ReadOnly = true;
            // 
            // dgvtbcMulta
            // 
            this.dgvtbcMulta.HeaderText = "Multa";
            this.dgvtbcMulta.Name = "dgvtbcMulta";
            this.dgvtbcMulta.ReadOnly = true;
            // 
            // dgvtbcJuros
            // 
            this.dgvtbcJuros.HeaderText = "Juros";
            this.dgvtbcJuros.Name = "dgvtbcJuros";
            this.dgvtbcJuros.ReadOnly = true;
            // 
            // dgvtbcAcrescimo
            // 
            this.dgvtbcAcrescimo.HeaderText = "Acrescimo";
            this.dgvtbcAcrescimo.Name = "dgvtbcAcrescimo";
            this.dgvtbcAcrescimo.ReadOnly = true;
            // 
            // dgvtbcDesconto
            // 
            this.dgvtbcDesconto.HeaderText = "Desconto";
            this.dgvtbcDesconto.Name = "dgvtbcDesconto";
            this.dgvtbcDesconto.ReadOnly = true;
            // 
            // dgvtbcValorFinal
            // 
            this.dgvtbcValorFinal.HeaderText = "Valor final";
            this.dgvtbcValorFinal.Name = "dgvtbcValorFinal";
            this.dgvtbcValorFinal.ReadOnly = true;
            // 
            // buscaPlanoContaCaixa
            // 
            this.buscaPlanoContaCaixa.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa.Entrada = false;
            this.buscaPlanoContaCaixa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa.LabelText = "Conta Caixa";
            this.buscaPlanoContaCaixa.Location = new System.Drawing.Point(475, 54);
            this.buscaPlanoContaCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPlanoContaCaixa.Name = "buscaPlanoContaCaixa";
            this.buscaPlanoContaCaixa.Saida = false;
            this.buscaPlanoContaCaixa.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa.TabIndex = 17;
            // 
            // fmCapQuitacaoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 614);
            this.Controls.Add(this.gbParcelas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPesquisa);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(968, 653);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(968, 652);
            this.Name = "fmCapQuitacaoConta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quitação de contas a pagar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCapQuitacaoConta_KeyDown);
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPesquisa;
        private Controls.BuscaPessoa buscaPessoa;
        private System.Windows.Forms.Label lbCodigoConta;
        private System.Windows.Forms.TextBox tbCodigoConta;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroInicial;
        private System.Windows.Forms.Label lbADataVencimentoParcela;
        private System.Windows.Forms.Label lbADataCadastro;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoInicial;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoFinal;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroFinal;
        private System.Windows.Forms.Label lbAValorConta;
        private Controls.DecimalBox dbValorInicial;
        private Controls.DecimalBox dbValorFinal;
        private System.Windows.Forms.CheckBox cbDataVencimento;
        private System.Windows.Forms.CheckBox cbDataCadastro;
        private System.Windows.Forms.CheckBox cbValor;
        private System.Windows.Forms.Label lbValorInicial;
        private System.Windows.Forms.Label lbDataVencimento;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDesconto;
        private Controls.DecimalBox dbDesconto;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Label lbTotal;
        private Controls.DecimalBox dbValorTotal;
        private System.Windows.Forms.Label lbValorTotal;
        private Controls.DecimalBox dbAcrescimo;
        private System.Windows.Forms.Label lbAcrescimo;
        private Controls.DecimalBox dbJuros;
        private System.Windows.Forms.Label lbJuros;
        private Controls.DecimalBox dbMulta;
        private System.Windows.Forms.Label lbMulta;
        private Controls.DecimalBox dbValor;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorFinal;
        private Controls.BuscaCaixa buscaCaixa;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa;
    }
}