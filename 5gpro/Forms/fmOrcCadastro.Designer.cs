namespace _5gpro.Forms
{
    partial class fmOrcCadastro
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
            this.gbDadosOrcamento = new System.Windows.Forms.GroupBox();
            this.gbDadosNota = new System.Windows.Forms.GroupBox();
            this.btNotaGerar = new System.Windows.Forms.Button();
            this.tbNotaDataEmissao = new System.Windows.Forms.TextBox();
            this.lbDataEmissao = new System.Windows.Forms.Label();
            this.tbNotaNumero = new System.Windows.Forms.TextBox();
            this.lbNotaNumero = new System.Windows.Forms.Label();
            this.cbVencimento = new System.Windows.Forms.CheckBox();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.lbVencimento = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescontoPorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescontoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbValorUnit = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbValorTot = new System.Windows.Forms.Label();
            this.btInserirItem = new System.Windows.Forms.Button();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btExcluirItem = new System.Windows.Forms.Button();
            this.lbDescItem = new System.Windows.Forms.Label();
            this.lbDescontoPorc = new System.Windows.Forms.Label();
            this.btNovoItem = new System.Windows.Forms.Button();
            this.lbTotalItens = new System.Windows.Forms.Label();
            this.gbTotais = new System.Windows.Forms.GroupBox();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.lbDescontoTotalItens = new System.Windows.Forms.Label();
            this.lbTotalOrcamento = new System.Windows.Forms.Label();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.dbValorTotalOrcamento = new _5gpro.Controls.DecimalBox();
            this.dbDescontoOrcamento = new _5gpro.Controls.DecimalBox();
            this.dbDescontoTotalItens = new _5gpro.Controls.DecimalBox();
            this.dbValorTotalItens = new _5gpro.Controls.DecimalBox();
            this.dbDescontoItem = new _5gpro.Controls.DecimalBox();
            this.dbDescontoItemPorc = new _5gpro.Controls.DecimalBox();
            this.dbValorTotItem = new _5gpro.Controls.DecimalBox();
            this.dbValorUnitItem = new _5gpro.Controls.DecimalBox();
            this.dbQuantidade = new _5gpro.Controls.DecimalBox();
            this.buscaItem = new _5gpro.Controls.BuscaItem();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.gbDadosOrcamento.SuspendLayout();
            this.gbDadosNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbItens.SuspendLayout();
            this.gbTotais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosOrcamento
            // 
            this.gbDadosOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosOrcamento.Controls.Add(this.tbDescricao);
            this.gbDadosOrcamento.Controls.Add(this.lbDescricao);
            this.gbDadosOrcamento.Controls.Add(this.gbDadosNota);
            this.gbDadosOrcamento.Controls.Add(this.buscaPessoa);
            this.gbDadosOrcamento.Controls.Add(this.cbVencimento);
            this.gbDadosOrcamento.Controls.Add(this.dtpVencimento);
            this.gbDadosOrcamento.Controls.Add(this.dtpCadastro);
            this.gbDadosOrcamento.Controls.Add(this.lbVencimento);
            this.gbDadosOrcamento.Controls.Add(this.lbCadastro);
            this.gbDadosOrcamento.Controls.Add(this.tbCodigo);
            this.gbDadosOrcamento.Controls.Add(this.lbCodigo);
            this.gbDadosOrcamento.Location = new System.Drawing.Point(65, 12);
            this.gbDadosOrcamento.Name = "gbDadosOrcamento";
            this.gbDadosOrcamento.Size = new System.Drawing.Size(1162, 201);
            this.gbDadosOrcamento.TabIndex = 0;
            this.gbDadosOrcamento.TabStop = false;
            this.gbDadosOrcamento.Text = "Dados do orçamento";
            // 
            // gbDadosNota
            // 
            this.gbDadosNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosNota.Controls.Add(this.btNotaGerar);
            this.gbDadosNota.Controls.Add(this.tbNotaDataEmissao);
            this.gbDadosNota.Controls.Add(this.lbDataEmissao);
            this.gbDadosNota.Controls.Add(this.tbNotaNumero);
            this.gbDadosNota.Controls.Add(this.lbNotaNumero);
            this.gbDadosNota.Location = new System.Drawing.Point(1000, 19);
            this.gbDadosNota.Name = "gbDadosNota";
            this.gbDadosNota.Size = new System.Drawing.Size(156, 92);
            this.gbDadosNota.TabIndex = 8;
            this.gbDadosNota.TabStop = false;
            this.gbDadosNota.Text = "Nota Fiscal";
            // 
            // btNotaGerar
            // 
            this.btNotaGerar.Enabled = false;
            this.btNotaGerar.Location = new System.Drawing.Point(6, 58);
            this.btNotaGerar.Name = "btNotaGerar";
            this.btNotaGerar.Size = new System.Drawing.Size(94, 23);
            this.btNotaGerar.TabIndex = 4;
            this.btNotaGerar.Text = "Gerar nota fiscal";
            this.btNotaGerar.UseVisualStyleBackColor = true;
            this.btNotaGerar.Click += new System.EventHandler(this.BtNotaGerar_Click);
            // 
            // tbNotaDataEmissao
            // 
            this.tbNotaDataEmissao.Enabled = false;
            this.tbNotaDataEmissao.Location = new System.Drawing.Point(75, 32);
            this.tbNotaDataEmissao.Name = "tbNotaDataEmissao";
            this.tbNotaDataEmissao.Size = new System.Drawing.Size(73, 20);
            this.tbNotaDataEmissao.TabIndex = 3;
            // 
            // lbDataEmissao
            // 
            this.lbDataEmissao.AutoSize = true;
            this.lbDataEmissao.Location = new System.Drawing.Point(72, 16);
            this.lbDataEmissao.Name = "lbDataEmissao";
            this.lbDataEmissao.Size = new System.Drawing.Size(71, 13);
            this.lbDataEmissao.TabIndex = 2;
            this.lbDataEmissao.Text = "Data emissão";
            // 
            // tbNotaNumero
            // 
            this.tbNotaNumero.Enabled = false;
            this.tbNotaNumero.Location = new System.Drawing.Point(6, 32);
            this.tbNotaNumero.Name = "tbNotaNumero";
            this.tbNotaNumero.Size = new System.Drawing.Size(56, 20);
            this.tbNotaNumero.TabIndex = 1;
            // 
            // lbNotaNumero
            // 
            this.lbNotaNumero.AutoSize = true;
            this.lbNotaNumero.Location = new System.Drawing.Point(6, 16);
            this.lbNotaNumero.Name = "lbNotaNumero";
            this.lbNotaNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNotaNumero.TabIndex = 0;
            this.lbNotaNumero.Text = "Número";
            // 
            // cbVencimento
            // 
            this.cbVencimento.AutoSize = true;
            this.cbVencimento.Location = new System.Drawing.Point(231, 179);
            this.cbVencimento.Name = "cbVencimento";
            this.cbVencimento.Size = new System.Drawing.Size(15, 14);
            this.cbVencimento.TabIndex = 9;
            this.cbVencimento.TabStop = false;
            this.cbVencimento.UseVisualStyleBackColor = true;
            this.cbVencimento.CheckedChanged += new System.EventHandler(this.CbVencimento_CheckedChanged);
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Enabled = false;
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(127, 175);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(99, 20);
            this.dtpVencimento.TabIndex = 7;
            this.dtpVencimento.ValueChanged += new System.EventHandler(this.DtpVencimento_ValueChanged);
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Checked = false;
            this.dtpCadastro.CustomFormat = "";
            this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCadastro.Location = new System.Drawing.Point(10, 175);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(100, 20);
            this.dtpCadastro.TabIndex = 5;
            this.dtpCadastro.ValueChanged += new System.EventHandler(this.DtpCadastro_ValueChanged);
            // 
            // lbVencimento
            // 
            this.lbVencimento.AutoSize = true;
            this.lbVencimento.Location = new System.Drawing.Point(123, 159);
            this.lbVencimento.Name = "lbVencimento";
            this.lbVencimento.Size = new System.Drawing.Size(103, 13);
            this.lbVencimento.TabIndex = 6;
            this.lbVencimento.Text = "Data do vencimento";
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.Location = new System.Drawing.Point(7, 156);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(89, 13);
            this.lbCadastro.TabIndex = 4;
            this.lbCadastro.Text = "Data do cadastro";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(9, 36);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(65, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigo_KeyUp);
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 20);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToOrderColumns = true;
            this.dgvItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigo,
            this.dgvtbcDescricao,
            this.dgvtbcQuantidade,
            this.dgvtbcValorUnitario,
            this.dgvtbcValorTotalItem,
            this.dgvtbcDescontoPorc,
            this.dgvtbcDescontoItem});
            this.dgvItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItens.Location = new System.Drawing.Point(6, 19);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(955, 187);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.TabStop = false;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItens_CellClick);
            this.dgvItens.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItens_CellContentDoubleClick);
            this.dgvItens.CurrentCellChanged += new System.EventHandler(this.DgvItens_CurrentCellChanged);
            this.dgvItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvItens_KeyDown);
            // 
            // dgvtbcCodigo
            // 
            this.dgvtbcCodigo.HeaderText = "Código";
            this.dgvtbcCodigo.Name = "dgvtbcCodigo";
            this.dgvtbcCodigo.ReadOnly = true;
            // 
            // dgvtbcDescricao
            // 
            this.dgvtbcDescricao.HeaderText = "Descrição";
            this.dgvtbcDescricao.Name = "dgvtbcDescricao";
            this.dgvtbcDescricao.ReadOnly = true;
            // 
            // dgvtbcQuantidade
            // 
            this.dgvtbcQuantidade.HeaderText = "Quantidade";
            this.dgvtbcQuantidade.Name = "dgvtbcQuantidade";
            this.dgvtbcQuantidade.ReadOnly = true;
            // 
            // dgvtbcValorUnitario
            // 
            this.dgvtbcValorUnitario.HeaderText = "Valor unitário";
            this.dgvtbcValorUnitario.Name = "dgvtbcValorUnitario";
            this.dgvtbcValorUnitario.ReadOnly = true;
            // 
            // dgvtbcValorTotalItem
            // 
            this.dgvtbcValorTotalItem.HeaderText = "Valor total";
            this.dgvtbcValorTotalItem.Name = "dgvtbcValorTotalItem";
            this.dgvtbcValorTotalItem.ReadOnly = true;
            // 
            // dgvtbcDescontoPorc
            // 
            this.dgvtbcDescontoPorc.HeaderText = "% Desc";
            this.dgvtbcDescontoPorc.Name = "dgvtbcDescontoPorc";
            this.dgvtbcDescontoPorc.ReadOnly = true;
            // 
            // dgvtbcDescontoItem
            // 
            this.dgvtbcDescontoItem.HeaderText = "Desc. Item";
            this.dgvtbcDescontoItem.Name = "dgvtbcDescontoItem";
            this.dgvtbcDescontoItem.ReadOnly = true;
            // 
            // lbValorUnit
            // 
            this.lbValorUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorUnit.AutoSize = true;
            this.lbValorUnit.Location = new System.Drawing.Point(73, 256);
            this.lbValorUnit.Name = "lbValorUnit";
            this.lbValorUnit.Size = new System.Drawing.Size(56, 13);
            this.lbValorUnit.TabIndex = 4;
            this.lbValorUnit.Text = "Valor Unit.";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(7, 256);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 2;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbValorTot
            // 
            this.lbValorTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorTot.AutoSize = true;
            this.lbValorTot.Location = new System.Drawing.Point(142, 256);
            this.lbValorTot.Name = "lbValorTot";
            this.lbValorTot.Size = new System.Drawing.Size(53, 13);
            this.lbValorTot.TabIndex = 6;
            this.lbValorTot.Text = "Valor Tot.";
            // 
            // btInserirItem
            // 
            this.btInserirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btInserirItem.Location = new System.Drawing.Point(147, 305);
            this.btInserirItem.Name = "btInserirItem";
            this.btInserirItem.Size = new System.Drawing.Size(59, 24);
            this.btInserirItem.TabIndex = 12;
            this.btInserirItem.Text = "Inserir";
            this.btInserirItem.UseVisualStyleBackColor = true;
            this.btInserirItem.Click += new System.EventHandler(this.BtInserirItem_Click);
            // 
            // gbItens
            // 
            this.gbItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbItens.Controls.Add(this.btSelecionar);
            this.gbItens.Controls.Add(this.dbDescontoItem);
            this.gbItens.Controls.Add(this.dbDescontoItemPorc);
            this.gbItens.Controls.Add(this.dbValorTotItem);
            this.gbItens.Controls.Add(this.dbValorUnitItem);
            this.gbItens.Controls.Add(this.dbQuantidade);
            this.gbItens.Controls.Add(this.buscaItem);
            this.gbItens.Controls.Add(this.btExcluirItem);
            this.gbItens.Controls.Add(this.lbDescItem);
            this.gbItens.Controls.Add(this.lbDescontoPorc);
            this.gbItens.Controls.Add(this.btNovoItem);
            this.gbItens.Controls.Add(this.dgvItens);
            this.gbItens.Controls.Add(this.btInserirItem);
            this.gbItens.Controls.Add(this.lbValorUnit);
            this.gbItens.Controls.Add(this.lbQuantidade);
            this.gbItens.Controls.Add(this.lbValorTot);
            this.gbItens.Location = new System.Drawing.Point(65, 219);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(993, 341);
            this.gbItens.TabIndex = 1;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens";
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionar.Location = new System.Drawing.Point(212, 306);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btSelecionar.TabIndex = 15;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.BtConjunto_Click);
            // 
            // btExcluirItem
            // 
            this.btExcluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirItem.Enabled = false;
            this.btExcluirItem.Image = global::_5gpro.Properties.Resources.iosDelete_22px_Red;
            this.btExcluirItem.Location = new System.Drawing.Point(963, 49);
            this.btExcluirItem.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btExcluirItem.Name = "btExcluirItem";
            this.btExcluirItem.Size = new System.Drawing.Size(24, 24);
            this.btExcluirItem.TabIndex = 14;
            this.btExcluirItem.UseVisualStyleBackColor = true;
            this.btExcluirItem.Click += new System.EventHandler(this.BtDeletarItem_Click);
            // 
            // lbDescItem
            // 
            this.lbDescItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescItem.AutoSize = true;
            this.lbDescItem.Location = new System.Drawing.Point(74, 293);
            this.lbDescItem.Name = "lbDescItem";
            this.lbDescItem.Size = new System.Drawing.Size(58, 13);
            this.lbDescItem.TabIndex = 10;
            this.lbDescItem.Text = "Desc. Item";
            // 
            // lbDescontoPorc
            // 
            this.lbDescontoPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescontoPorc.AutoSize = true;
            this.lbDescontoPorc.Location = new System.Drawing.Point(4, 293);
            this.lbDescontoPorc.Name = "lbDescontoPorc";
            this.lbDescontoPorc.Size = new System.Drawing.Size(46, 13);
            this.lbDescontoPorc.TabIndex = 8;
            this.lbDescontoPorc.Text = "% Desc.";
            // 
            // btNovoItem
            // 
            this.btNovoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovoItem.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btNovoItem.Location = new System.Drawing.Point(963, 19);
            this.btNovoItem.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btNovoItem.Name = "btNovoItem";
            this.btNovoItem.Size = new System.Drawing.Size(24, 24);
            this.btNovoItem.TabIndex = 13;
            this.btNovoItem.UseVisualStyleBackColor = true;
            this.btNovoItem.Click += new System.EventHandler(this.BtNovoItem_Click);
            // 
            // lbTotalItens
            // 
            this.lbTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalItens.AutoSize = true;
            this.lbTotalItens.Location = new System.Drawing.Point(6, 19);
            this.lbTotalItens.Name = "lbTotalItens";
            this.lbTotalItens.Size = new System.Drawing.Size(99, 13);
            this.lbTotalItens.TabIndex = 0;
            this.lbTotalItens.Text = "Valor total dos itens";
            // 
            // gbTotais
            // 
            this.gbTotais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotais.Controls.Add(this.dbValorTotalOrcamento);
            this.gbTotais.Controls.Add(this.dbDescontoOrcamento);
            this.gbTotais.Controls.Add(this.dbDescontoTotalItens);
            this.gbTotais.Controls.Add(this.dbValorTotalItens);
            this.gbTotais.Controls.Add(this.lbDesconto);
            this.gbTotais.Controls.Add(this.lbDescontoTotalItens);
            this.gbTotais.Controls.Add(this.lbTotalOrcamento);
            this.gbTotais.Controls.Add(this.lbTotalItens);
            this.gbTotais.Location = new System.Drawing.Point(1064, 200);
            this.gbTotais.MinimumSize = new System.Drawing.Size(163, 326);
            this.gbTotais.Name = "gbTotais";
            this.gbTotais.Size = new System.Drawing.Size(163, 386);
            this.gbTotais.TabIndex = 2;
            this.gbTotais.TabStop = false;
            this.gbTotais.Text = "Totais";
            // 
            // lbDesconto
            // 
            this.lbDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(6, 97);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(121, 13);
            this.lbDesconto.TabIndex = 4;
            this.lbDesconto.Text = "Desconto do orçamento";
            // 
            // lbDescontoTotalItens
            // 
            this.lbDescontoTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescontoTotalItens.AutoSize = true;
            this.lbDescontoTotalItens.Location = new System.Drawing.Point(6, 58);
            this.lbDescontoTotalItens.Name = "lbDescontoTotalItens";
            this.lbDescontoTotalItens.Size = new System.Drawing.Size(121, 13);
            this.lbDescontoTotalItens.TabIndex = 2;
            this.lbDescontoTotalItens.Text = "Desconto total dos itens";
            // 
            // lbTotalOrcamento
            // 
            this.lbTotalOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalOrcamento.AutoSize = true;
            this.lbTotalOrcamento.Location = new System.Drawing.Point(5, 136);
            this.lbTotalOrcamento.Name = "lbTotalOrcamento";
            this.lbTotalOrcamento.Size = new System.Drawing.Size(122, 13);
            this.lbTotalOrcamento.TabIndex = 6;
            this.lbTotalOrcamento.Text = "Valor total do orçamento";
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(65, 566);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(993, 20);
            this.tbAjuda.TabIndex = 4;
            // 
            // btImprimir
            // 
            this.btImprimir.Image = global::_5gpro.Properties.Resources.print_48px;
            this.btImprimir.Location = new System.Drawing.Point(9, 380);
            this.btImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btImprimir.MinimumSize = new System.Drawing.Size(48, 48);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(48, 48);
            this.btImprimir.TabIndex = 7;
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.BtImprimir_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(7, 12);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(2);
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
            // dbValorTotalOrcamento
            // 
            this.dbValorTotalOrcamento.Enabled = false;
            this.dbValorTotalOrcamento.Location = new System.Drawing.Point(8, 152);
            this.dbValorTotalOrcamento.Name = "dbValorTotalOrcamento";
            this.dbValorTotalOrcamento.Size = new System.Drawing.Size(85, 22);
            this.dbValorTotalOrcamento.TabIndex = 7;
            this.dbValorTotalOrcamento.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbDescontoOrcamento
            // 
            this.dbDescontoOrcamento.Enabled = false;
            this.dbDescontoOrcamento.Location = new System.Drawing.Point(7, 113);
            this.dbDescontoOrcamento.Name = "dbDescontoOrcamento";
            this.dbDescontoOrcamento.Size = new System.Drawing.Size(86, 22);
            this.dbDescontoOrcamento.TabIndex = 5;
            this.dbDescontoOrcamento.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbDescontoOrcamento.Leave += new System.EventHandler(this.DbDescontoOrcamento_Leave);
            // 
            // dbDescontoTotalItens
            // 
            this.dbDescontoTotalItens.Enabled = false;
            this.dbDescontoTotalItens.Location = new System.Drawing.Point(9, 72);
            this.dbDescontoTotalItens.Name = "dbDescontoTotalItens";
            this.dbDescontoTotalItens.Size = new System.Drawing.Size(84, 22);
            this.dbDescontoTotalItens.TabIndex = 3;
            this.dbDescontoTotalItens.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbValorTotalItens
            // 
            this.dbValorTotalItens.Enabled = false;
            this.dbValorTotalItens.Location = new System.Drawing.Point(8, 35);
            this.dbValorTotalItens.Name = "dbValorTotalItens";
            this.dbValorTotalItens.Size = new System.Drawing.Size(85, 22);
            this.dbValorTotalItens.TabIndex = 1;
            this.dbValorTotalItens.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbDescontoItem
            // 
            this.dbDescontoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dbDescontoItem.Location = new System.Drawing.Point(78, 309);
            this.dbDescontoItem.Name = "dbDescontoItem";
            this.dbDescontoItem.Size = new System.Drawing.Size(63, 22);
            this.dbDescontoItem.TabIndex = 11;
            this.dbDescontoItem.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbDescontoItem.Leave += new System.EventHandler(this.DbDescontoItem_Leave);
            // 
            // dbDescontoItemPorc
            // 
            this.dbDescontoItemPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dbDescontoItemPorc.Location = new System.Drawing.Point(9, 309);
            this.dbDescontoItemPorc.Name = "dbDescontoItemPorc";
            this.dbDescontoItemPorc.Size = new System.Drawing.Size(62, 22);
            this.dbDescontoItemPorc.TabIndex = 9;
            this.dbDescontoItemPorc.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbDescontoItemPorc.Leave += new System.EventHandler(this.DbDescontoItemPorc_Leave);
            // 
            // dbValorTotItem
            // 
            this.dbValorTotItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dbValorTotItem.Location = new System.Drawing.Point(147, 272);
            this.dbValorTotItem.Name = "dbValorTotItem";
            this.dbValorTotItem.Size = new System.Drawing.Size(87, 22);
            this.dbValorTotItem.TabIndex = 7;
            this.dbValorTotItem.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbValorTotItem.Leave += new System.EventHandler(this.DbValorTotItem_Leave);
            // 
            // dbValorUnitItem
            // 
            this.dbValorUnitItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dbValorUnitItem.Location = new System.Drawing.Point(78, 272);
            this.dbValorUnitItem.Name = "dbValorUnitItem";
            this.dbValorUnitItem.Size = new System.Drawing.Size(63, 22);
            this.dbValorUnitItem.TabIndex = 5;
            this.dbValorUnitItem.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbValorUnitItem.Leave += new System.EventHandler(this.DbValorUnitItem_Leave);
            // 
            // dbQuantidade
            // 
            this.dbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dbQuantidade.Location = new System.Drawing.Point(9, 272);
            this.dbQuantidade.Name = "dbQuantidade";
            this.dbQuantidade.Size = new System.Drawing.Size(62, 22);
            this.dbQuantidade.TabIndex = 3;
            this.dbQuantidade.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbQuantidade.Leave += new System.EventHandler(this.DbQuantidade_Leave);
            // 
            // buscaItem
            // 
            this.buscaItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buscaItem.Location = new System.Drawing.Point(3, 212);
            this.buscaItem.Name = "buscaItem";
            this.buscaItem.Size = new System.Drawing.Size(442, 39);
            this.buscaItem.TabIndex = 1;
            this.buscaItem.Codigo_Leave += new _5gpro.Controls.BuscaItem.codigo_leaveEventHandler(this.BuscaItem_Codigo_Leave);
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Cliente";
            this.buscaPessoa.Location = new System.Drawing.Point(249, 156);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa.TabIndex = 8;
            this.buscaPessoa.Text_Changed += new _5gpro.Controls.BuscaPessoa.text_changedEventHandler(this.BuscaPessoa_Text_Changed);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(4, 61);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(7, 77);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(368, 70);
            this.tbDescricao.TabIndex = 3;
            // 
            // fmOrcCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 599);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbTotais);
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.gbDadosOrcamento);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1255, 621);
            this.Name = "fmOrcCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmOrcamentoCadastroOrcamento_FormClosing);
            this.Load += new System.EventHandler(this.FmOrcCadastro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroOrcamento_KeyDown);
            this.gbDadosOrcamento.ResumeLayout(false);
            this.gbDadosOrcamento.PerformLayout();
            this.gbDadosNota.ResumeLayout(false);
            this.gbDadosNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbItens.ResumeLayout(false);
            this.gbItens.PerformLayout();
            this.gbTotais.ResumeLayout(false);
            this.gbTotais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosOrcamento;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.Label lbVencimento;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.CheckBox cbVencimento;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label lbValorUnit;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbValorTot;
        private System.Windows.Forms.Button btInserirItem;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.Button btNovoItem;
        private System.Windows.Forms.Label lbTotalItens;
        private System.Windows.Forms.GroupBox gbTotais;
        private System.Windows.Forms.Label lbTotalOrcamento;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Label lbDescontoTotalItens;
        private System.Windows.Forms.Label lbDescontoPorc;
        private System.Windows.Forms.Label lbDescItem;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.Button btExcluirItem;
        private Controls.BuscaPessoa buscaPessoa;
        private Controls.MenuVertical menuVertical;
        private Controls.BuscaItem buscaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoPorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoItem;
        private System.Windows.Forms.GroupBox gbDadosNota;
        private System.Windows.Forms.TextBox tbNotaDataEmissao;
        private System.Windows.Forms.Label lbDataEmissao;
        private System.Windows.Forms.TextBox tbNotaNumero;
        private System.Windows.Forms.Label lbNotaNumero;
        private System.Windows.Forms.Button btNotaGerar;
        private Controls.DecimalBox dbDescontoItem;
        private Controls.DecimalBox dbDescontoItemPorc;
        private Controls.DecimalBox dbValorTotItem;
        private Controls.DecimalBox dbValorUnitItem;
        private Controls.DecimalBox dbQuantidade;
        private Controls.DecimalBox dbValorTotalItens;
        private Controls.DecimalBox dbValorTotalOrcamento;
        private Controls.DecimalBox dbDescontoOrcamento;
        private Controls.DecimalBox dbDescontoTotalItens;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
    }
}