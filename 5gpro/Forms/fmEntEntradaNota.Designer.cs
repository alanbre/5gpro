namespace _5gpro.Forms
{
    partial class fmEntEntradaNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEntEntradaNota));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.gbTotais = new System.Windows.Forms.GroupBox();
            this.lbDescontoDocumento = new System.Windows.Forms.Label();
            this.lbDescontoTotalItens = new System.Windows.Forms.Label();
            this.lbValorTotalDocumento = new System.Windows.Forms.Label();
            this.lbTotalItens = new System.Windows.Forms.Label();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.btDesintegrar = new System.Windows.Forms.Button();
            this.btExcluirItem = new System.Windows.Forms.Button();
            this.lbDescItem = new System.Windows.Forms.Label();
            this.lbDescontoPorc = new System.Windows.Forms.Label();
            this.btNovoItem = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescontoPorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescontoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInserirItem = new System.Windows.Forms.Button();
            this.lbValorUnit = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbValorTot = new System.Windows.Forms.Label();
            this.gbDadosDocumento = new System.Windows.Forms.GroupBox();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.lbEntrada = new System.Windows.Forms.Label();
            this.lbEmissao = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbNumeroDocumento = new System.Windows.Forms.Label();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.dbValorTotalDocumento = new _5gpro.Controls.DecimalBox();
            this.dbDescontoDocumento = new _5gpro.Controls.DecimalBox();
            this.dbDescontoTotalItens = new _5gpro.Controls.DecimalBox();
            this.dbValorTotalItens = new _5gpro.Controls.DecimalBox();
            this.buscaItem1 = new _5gpro.Controls.BuscaItem();
            this.dbDescontoItem = new _5gpro.Controls.DecimalBox();
            this.dbDescontoItemPorc = new _5gpro.Controls.DecimalBox();
            this.dbValorTotItem = new _5gpro.Controls.DecimalBox();
            this.dbValorUnitItem = new _5gpro.Controls.DecimalBox();
            this.dbQuantidade = new _5gpro.Controls.DecimalBox();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.gbTotais.SuspendLayout();
            this.gbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbDadosDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(67, 543);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(993, 20);
            this.tbAjuda.TabIndex = 4;
            // 
            // gbTotais
            // 
            this.gbTotais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotais.Controls.Add(this.dbValorTotalDocumento);
            this.gbTotais.Controls.Add(this.dbDescontoDocumento);
            this.gbTotais.Controls.Add(this.dbDescontoTotalItens);
            this.gbTotais.Controls.Add(this.dbValorTotalItens);
            this.gbTotais.Controls.Add(this.lbDescontoDocumento);
            this.gbTotais.Controls.Add(this.lbDescontoTotalItens);
            this.gbTotais.Controls.Add(this.lbValorTotalDocumento);
            this.gbTotais.Controls.Add(this.lbTotalItens);
            this.gbTotais.Location = new System.Drawing.Point(1066, 197);
            this.gbTotais.MinimumSize = new System.Drawing.Size(163, 326);
            this.gbTotais.Name = "gbTotais";
            this.gbTotais.Size = new System.Drawing.Size(163, 340);
            this.gbTotais.TabIndex = 2;
            this.gbTotais.TabStop = false;
            this.gbTotais.Text = "Totais";
            // 
            // lbDescontoDocumento
            // 
            this.lbDescontoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescontoDocumento.AutoSize = true;
            this.lbDescontoDocumento.Location = new System.Drawing.Point(6, 97);
            this.lbDescontoDocumento.Name = "lbDescontoDocumento";
            this.lbDescontoDocumento.Size = new System.Drawing.Size(124, 13);
            this.lbDescontoDocumento.TabIndex = 4;
            this.lbDescontoDocumento.Text = "Desconto do documento";
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
            // lbValorTotalDocumento
            // 
            this.lbValorTotalDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorTotalDocumento.AutoSize = true;
            this.lbValorTotalDocumento.Location = new System.Drawing.Point(5, 136);
            this.lbValorTotalDocumento.Name = "lbValorTotalDocumento";
            this.lbValorTotalDocumento.Size = new System.Drawing.Size(125, 13);
            this.lbValorTotalDocumento.TabIndex = 6;
            this.lbValorTotalDocumento.Text = "Valor total do documento";
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
            // gbItens
            // 
            this.gbItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbItens.Controls.Add(this.buscaItem1);
            this.gbItens.Controls.Add(this.btDesintegrar);
            this.gbItens.Controls.Add(this.dbDescontoItem);
            this.gbItens.Controls.Add(this.dbDescontoItemPorc);
            this.gbItens.Controls.Add(this.dbValorTotItem);
            this.gbItens.Controls.Add(this.dbValorUnitItem);
            this.gbItens.Controls.Add(this.dbQuantidade);
            this.gbItens.Controls.Add(this.btExcluirItem);
            this.gbItens.Controls.Add(this.lbDescItem);
            this.gbItens.Controls.Add(this.lbDescontoPorc);
            this.gbItens.Controls.Add(this.btNovoItem);
            this.gbItens.Controls.Add(this.dgvItens);
            this.gbItens.Controls.Add(this.btInserirItem);
            this.gbItens.Controls.Add(this.lbValorUnit);
            this.gbItens.Controls.Add(this.lbQuantidade);
            this.gbItens.Controls.Add(this.lbValorTot);
            this.gbItens.Location = new System.Drawing.Point(67, 197);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(993, 340);
            this.gbItens.TabIndex = 1;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens";
            // 
            // btDesintegrar
            // 
            this.btDesintegrar.Enabled = false;
            this.btDesintegrar.Location = new System.Drawing.Point(209, 305);
            this.btDesintegrar.Name = "btDesintegrar";
            this.btDesintegrar.Size = new System.Drawing.Size(75, 23);
            this.btDesintegrar.TabIndex = 15;
            this.btDesintegrar.Text = "Desintegrar";
            this.btDesintegrar.UseVisualStyleBackColor = true;
            this.btDesintegrar.Click += new System.EventHandler(this.BtDesintegrar_Click);
            // 
            // btExcluirItem
            // 
            this.btExcluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirItem.Enabled = false;
            this.btExcluirItem.Image = ((System.Drawing.Image)(resources.GetObject("btExcluirItem.Image")));
            this.btExcluirItem.Location = new System.Drawing.Point(963, 49);
            this.btExcluirItem.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btExcluirItem.Name = "btExcluirItem";
            this.btExcluirItem.Size = new System.Drawing.Size(24, 24);
            this.btExcluirItem.TabIndex = 14;
            this.btExcluirItem.UseVisualStyleBackColor = true;
            this.btExcluirItem.Click += new System.EventHandler(this.BtExcluirItem_Click);
            // 
            // lbDescItem
            // 
            this.lbDescItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescItem.AutoSize = true;
            this.lbDescItem.Location = new System.Drawing.Point(73, 292);
            this.lbDescItem.Name = "lbDescItem";
            this.lbDescItem.Size = new System.Drawing.Size(58, 13);
            this.lbDescItem.TabIndex = 10;
            this.lbDescItem.Text = "Desc. Item";
            // 
            // lbDescontoPorc
            // 
            this.lbDescontoPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescontoPorc.AutoSize = true;
            this.lbDescontoPorc.Location = new System.Drawing.Point(3, 292);
            this.lbDescontoPorc.Name = "lbDescontoPorc";
            this.lbDescontoPorc.Size = new System.Drawing.Size(46, 13);
            this.lbDescontoPorc.TabIndex = 8;
            this.lbDescontoPorc.Text = "% Desc.";
            // 
            // btNovoItem
            // 
            this.btNovoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("btNovoItem.Image")));
            this.btNovoItem.Location = new System.Drawing.Point(963, 19);
            this.btNovoItem.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btNovoItem.Name = "btNovoItem";
            this.btNovoItem.Size = new System.Drawing.Size(24, 24);
            this.btNovoItem.TabIndex = 13;
            this.btNovoItem.UseVisualStyleBackColor = true;
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
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(955, 186);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.TabStop = false;
            this.dgvItens.CurrentCellChanged += new System.EventHandler(this.DgvItens_CurrentCellChanged);
            // 
            // dgvtbcCodigo
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvtbcCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtbcCodigo.Frozen = true;
            this.dgvtbcCodigo.HeaderText = "Código";
            this.dgvtbcCodigo.MinimumWidth = 60;
            this.dgvtbcCodigo.Name = "dgvtbcCodigo";
            this.dgvtbcCodigo.ReadOnly = true;
            this.dgvtbcCodigo.Width = 60;
            // 
            // dgvtbcDescricao
            // 
            this.dgvtbcDescricao.Frozen = true;
            this.dgvtbcDescricao.HeaderText = "Descrição";
            this.dgvtbcDescricao.MinimumWidth = 70;
            this.dgvtbcDescricao.Name = "dgvtbcDescricao";
            this.dgvtbcDescricao.ReadOnly = true;
            this.dgvtbcDescricao.Width = 150;
            // 
            // dgvtbcQuantidade
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvtbcQuantidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtbcQuantidade.Frozen = true;
            this.dgvtbcQuantidade.HeaderText = "Quantidade";
            this.dgvtbcQuantidade.MinimumWidth = 70;
            this.dgvtbcQuantidade.Name = "dgvtbcQuantidade";
            this.dgvtbcQuantidade.ReadOnly = true;
            this.dgvtbcQuantidade.Width = 70;
            // 
            // dgvtbcValorUnitario
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvtbcValorUnitario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtbcValorUnitario.HeaderText = "Valor unitário";
            this.dgvtbcValorUnitario.MinimumWidth = 100;
            this.dgvtbcValorUnitario.Name = "dgvtbcValorUnitario";
            this.dgvtbcValorUnitario.ReadOnly = true;
            // 
            // dgvtbcValorTotalItem
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvtbcValorTotalItem.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtbcValorTotalItem.HeaderText = "Valor total";
            this.dgvtbcValorTotalItem.MinimumWidth = 80;
            this.dgvtbcValorTotalItem.Name = "dgvtbcValorTotalItem";
            this.dgvtbcValorTotalItem.ReadOnly = true;
            this.dgvtbcValorTotalItem.Width = 80;
            // 
            // dgvtbcDescontoPorc
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.dgvtbcDescontoPorc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtbcDescontoPorc.HeaderText = "% Desc";
            this.dgvtbcDescontoPorc.MinimumWidth = 50;
            this.dgvtbcDescontoPorc.Name = "dgvtbcDescontoPorc";
            this.dgvtbcDescontoPorc.ReadOnly = true;
            this.dgvtbcDescontoPorc.Width = 50;
            // 
            // dgvtbcDescontoItem
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.dgvtbcDescontoItem.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtbcDescontoItem.HeaderText = "Desconto";
            this.dgvtbcDescontoItem.MinimumWidth = 70;
            this.dgvtbcDescontoItem.Name = "dgvtbcDescontoItem";
            this.dgvtbcDescontoItem.ReadOnly = true;
            this.dgvtbcDescontoItem.Width = 70;
            // 
            // btInserirItem
            // 
            this.btInserirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btInserirItem.Location = new System.Drawing.Point(144, 304);
            this.btInserirItem.Name = "btInserirItem";
            this.btInserirItem.Size = new System.Drawing.Size(59, 24);
            this.btInserirItem.TabIndex = 12;
            this.btInserirItem.Text = "Inserir";
            this.btInserirItem.UseVisualStyleBackColor = true;
            this.btInserirItem.Click += new System.EventHandler(this.BtInserirItem_Click);
            // 
            // lbValorUnit
            // 
            this.lbValorUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorUnit.AutoSize = true;
            this.lbValorUnit.Location = new System.Drawing.Point(72, 255);
            this.lbValorUnit.Name = "lbValorUnit";
            this.lbValorUnit.Size = new System.Drawing.Size(56, 13);
            this.lbValorUnit.TabIndex = 4;
            this.lbValorUnit.Text = "Valor Unit.";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(6, 255);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 2;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbValorTot
            // 
            this.lbValorTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorTot.AutoSize = true;
            this.lbValorTot.Location = new System.Drawing.Point(141, 255);
            this.lbValorTot.Name = "lbValorTot";
            this.lbValorTot.Size = new System.Drawing.Size(53, 13);
            this.lbValorTot.TabIndex = 6;
            this.lbValorTot.Text = "Valor Tot.";
            // 
            // gbDadosDocumento
            // 
            this.gbDadosDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosDocumento.Controls.Add(this.buscaPessoa);
            this.gbDadosDocumento.Controls.Add(this.dtpEntrada);
            this.gbDadosDocumento.Controls.Add(this.dtpEmissao);
            this.gbDadosDocumento.Controls.Add(this.lbEntrada);
            this.gbDadosDocumento.Controls.Add(this.lbEmissao);
            this.gbDadosDocumento.Controls.Add(this.tbCodigo);
            this.gbDadosDocumento.Controls.Add(this.lbNumeroDocumento);
            this.gbDadosDocumento.Location = new System.Drawing.Point(67, 10);
            this.gbDadosDocumento.Name = "gbDadosDocumento";
            this.gbDadosDocumento.Size = new System.Drawing.Size(1162, 181);
            this.gbDadosDocumento.TabIndex = 0;
            this.gbDadosDocumento.TabStop = false;
            this.gbDadosDocumento.Text = "Dados do documento";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(11, 152);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(99, 20);
            this.dtpEntrada.TabIndex = 6;
            this.dtpEntrada.ValueChanged += new System.EventHandler(this.DtpEntrada_ValueChanged);
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Checked = false;
            this.dtpEmissao.CustomFormat = "";
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(10, 113);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(100, 20);
            this.dtpEmissao.TabIndex = 4;
            this.dtpEmissao.ValueChanged += new System.EventHandler(this.DtpEmissao_ValueChanged);
            // 
            // lbEntrada
            // 
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Location = new System.Drawing.Point(7, 136);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(84, 13);
            this.lbEntrada.TabIndex = 5;
            this.lbEntrada.Text = "Data de entrada";
            // 
            // lbEmissao
            // 
            this.lbEmissao.AutoSize = true;
            this.lbEmissao.Location = new System.Drawing.Point(7, 94);
            this.lbEmissao.Name = "lbEmissao";
            this.lbEmissao.Size = new System.Drawing.Size(86, 13);
            this.lbEmissao.TabIndex = 3;
            this.lbEmissao.Text = "Data da emissão";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(9, 32);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(65, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // lbNumeroDocumento
            // 
            this.lbNumeroDocumento.AutoSize = true;
            this.lbNumeroDocumento.Location = new System.Drawing.Point(6, 16);
            this.lbNumeroDocumento.Name = "lbNumeroDocumento";
            this.lbNumeroDocumento.Size = new System.Drawing.Size(77, 13);
            this.lbNumeroDocumento.TabIndex = 0;
            this.lbNumeroDocumento.Text = "N° Documento";
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 15);
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
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical_Excluir_Clicked);
            // 
            // dbValorTotalDocumento
            // 
            this.dbValorTotalDocumento.Location = new System.Drawing.Point(9, 152);
            this.dbValorTotalDocumento.Name = "dbValorTotalDocumento";
            this.dbValorTotalDocumento.Size = new System.Drawing.Size(85, 20);
            this.dbValorTotalDocumento.TabIndex = 7;
            this.dbValorTotalDocumento.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbValorTotalDocumento.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbValorTotalDocumento_Valor_Changed);
            // 
            // dbDescontoDocumento
            // 
            this.dbDescontoDocumento.Location = new System.Drawing.Point(9, 113);
            this.dbDescontoDocumento.Name = "dbDescontoDocumento";
            this.dbDescontoDocumento.Size = new System.Drawing.Size(85, 20);
            this.dbDescontoDocumento.TabIndex = 5;
            this.dbDescontoDocumento.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbDescontoDocumento.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbDescontoDocumento_Valor_Changed);
            this.dbDescontoDocumento.Leave += new System.EventHandler(this.DbDescontoDocumento_Leave);
            // 
            // dbDescontoTotalItens
            // 
            this.dbDescontoTotalItens.Enabled = false;
            this.dbDescontoTotalItens.Location = new System.Drawing.Point(9, 74);
            this.dbDescontoTotalItens.Name = "dbDescontoTotalItens";
            this.dbDescontoTotalItens.Size = new System.Drawing.Size(85, 20);
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
            this.dbValorTotalItens.Location = new System.Drawing.Point(9, 35);
            this.dbValorTotalItens.Name = "dbValorTotalItens";
            this.dbValorTotalItens.Size = new System.Drawing.Size(85, 20);
            this.dbValorTotalItens.TabIndex = 1;
            this.dbValorTotalItens.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // buscaItem1
            // 
            this.buscaItem1.Location = new System.Drawing.Point(3, 211);
            this.buscaItem1.Name = "buscaItem1";
            this.buscaItem1.Size = new System.Drawing.Size(442, 39);
            this.buscaItem1.TabIndex = 16;
            this.buscaItem1.Codigo_Leave += new _5gpro.Controls.BuscaItem.codigo_leaveEventHandler(this.BuscaItem1_Codigo_Leave);
            this.buscaItem1.Codigo_Changed += new _5gpro.Controls.BuscaItem.codigo_changedEventHandler(this.BuscaItem1_Codigo_Changed);
            // 
            // dbDescontoItem
            // 
            this.dbDescontoItem.Location = new System.Drawing.Point(76, 308);
            this.dbDescontoItem.Name = "dbDescontoItem";
            this.dbDescontoItem.Size = new System.Drawing.Size(63, 20);
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
            this.dbDescontoItemPorc.Location = new System.Drawing.Point(6, 308);
            this.dbDescontoItemPorc.Name = "dbDescontoItemPorc";
            this.dbDescontoItemPorc.Size = new System.Drawing.Size(63, 20);
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
            this.dbValorTotItem.Enabled = false;
            this.dbValorTotItem.Location = new System.Drawing.Point(144, 271);
            this.dbValorTotItem.Name = "dbValorTotItem";
            this.dbValorTotItem.Size = new System.Drawing.Size(63, 20);
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
            this.dbValorUnitItem.Enabled = false;
            this.dbValorUnitItem.Location = new System.Drawing.Point(75, 271);
            this.dbValorUnitItem.Name = "dbValorUnitItem";
            this.dbValorUnitItem.Size = new System.Drawing.Size(63, 20);
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
            this.dbQuantidade.Location = new System.Drawing.Point(6, 271);
            this.dbQuantidade.Name = "dbQuantidade";
            this.dbQuantidade.Size = new System.Drawing.Size(63, 20);
            this.dbQuantidade.TabIndex = 3;
            this.dbQuantidade.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbQuantidade.Leave += new System.EventHandler(this.DbQuantidade_Leave);
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Fornecedor";
            this.buscaPessoa.Location = new System.Drawing.Point(3, 55);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa.TabIndex = 2;
            this.buscaPessoa.Text_Changed += new _5gpro.Controls.BuscaPessoa.text_changedEventHandler(this.BuscaPessoa_Text_Changed);
            // 
            // fmEntEntradaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 573);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbTotais);
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.gbDadosDocumento);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1255, 612);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1255, 612);
            this.Name = "fmEntEntradaNota";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de entradas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmEntEntradaNota_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmEntEntradaNota_KeyDown);
            this.gbTotais.ResumeLayout(false);
            this.gbTotais.PerformLayout();
            this.gbItens.ResumeLayout(false);
            this.gbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbDadosDocumento.ResumeLayout(false);
            this.gbDadosDocumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.GroupBox gbTotais;
        private System.Windows.Forms.Label lbDescontoDocumento;
        private System.Windows.Forms.Label lbDescontoTotalItens;
        private System.Windows.Forms.Label lbValorTotalDocumento;
        private System.Windows.Forms.Label lbTotalItens;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.Button btExcluirItem;
        private System.Windows.Forms.Label lbDescItem;
        private System.Windows.Forms.Label lbDescontoPorc;
        private System.Windows.Forms.Button btNovoItem;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btInserirItem;
        private System.Windows.Forms.Label lbValorUnit;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbValorTot;
        private System.Windows.Forms.GroupBox gbDadosDocumento;
        private Controls.BuscaPessoa buscaPessoa;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.Label lbEntrada;
        private System.Windows.Forms.Label lbEmissao;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbNumeroDocumento;
        private Controls.DecimalBox dbQuantidade;
        private Controls.DecimalBox dbDescontoTotalItens;
        private Controls.DecimalBox dbValorTotalItens;
        private Controls.DecimalBox dbDescontoItem;
        private Controls.DecimalBox dbDescontoItemPorc;
        private Controls.DecimalBox dbValorTotItem;
        private Controls.DecimalBox dbValorUnitItem;
        private Controls.DecimalBox dbValorTotalDocumento;
        private Controls.DecimalBox dbDescontoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoPorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoItem;
        private System.Windows.Forms.Button btDesintegrar;
        private Controls.BuscaItem buscaItem1;
    }
}