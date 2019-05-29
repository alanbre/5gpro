namespace _5gpro.Reports
{
    partial class fmRltNotasSaida
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
            this.dtpDataEmissaoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEmissaoInicial = new System.Windows.Forms.DateTimePicker();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btGerar = new System.Windows.Forms.Button();
            this.tcPaginas = new System.Windows.Forms.TabControl();
            this.tpCampos = new System.Windows.Forms.TabPage();
            this.gbCamposCliente = new System.Windows.Forms.GroupBox();
            this.cblCamposClientes = new System.Windows.Forms.CheckedListBox();
            this.cbTodosCamposClientes = new System.Windows.Forms.CheckBox();
            this.gbCamposItens = new System.Windows.Forms.GroupBox();
            this.cblCamposItens = new System.Windows.Forms.CheckedListBox();
            this.cbTodosCamposItens = new System.Windows.Forms.CheckBox();
            this.gbCamposNota = new System.Windows.Forms.GroupBox();
            this.cblCamposNota = new System.Windows.Forms.CheckedListBox();
            this.cbTodosCamposNota = new System.Windows.Forms.CheckBox();
            this.tpFiltros = new System.Windows.Forms.TabPage();
            this.cbFiltroValor = new System.Windows.Forms.CheckBox();
            this.gbFiltrosValor = new System.Windows.Forms.GroupBox();
            this.lbValorFinal = new System.Windows.Forms.Label();
            this.dbValorInicial = new _5gpro.Controls.DecimalBox();
            this.lbValorInicial = new System.Windows.Forms.Label();
            this.dbValorFinal = new _5gpro.Controls.DecimalBox();
            this.cbFiltroDataSaida = new System.Windows.Forms.CheckBox();
            this.gbFiltrosDataSaida = new System.Windows.Forms.GroupBox();
            this.lbDataSaidaFinal = new System.Windows.Forms.Label();
            this.dtpDataSaidaInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataSaidaInicial = new System.Windows.Forms.Label();
            this.dtpDataSaidaFinal = new System.Windows.Forms.DateTimePicker();
            this.cbFiltrosCidades = new System.Windows.Forms.CheckBox();
            this.gbFiltrosCidades = new System.Windows.Forms.GroupBox();
            this.bcInicial = new _5gpro.Controls.BuscaCidade();
            this.bcFinal = new _5gpro.Controls.BuscaCidade();
            this.cbFiltroDataEmissao = new System.Windows.Forms.CheckBox();
            this.gbFiltrosDataEmissao = new System.Windows.Forms.GroupBox();
            this.lbDataEmissaoFinal = new System.Windows.Forms.Label();
            this.lbDataEmissaoInicial = new System.Windows.Forms.Label();
            this.cbFiltrosClientes = new System.Windows.Forms.CheckBox();
            this.gbFiltrosClientes = new System.Windows.Forms.GroupBox();
            this.bpFinal = new _5gpro.Controls.BuscaPessoa();
            this.bpInicial = new _5gpro.Controls.BuscaPessoa();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbRelatorio = new System.Windows.Forms.GroupBox();
            this.btExcluirRelatorio = new System.Windows.Forms.Button();
            this.btNovoRelatorio = new System.Windows.Forms.Button();
            this.btSalvarRelatorio = new System.Windows.Forms.Button();
            this.btCarregarRelatorio = new System.Windows.Forms.Button();
            this.cbRelatorios = new System.Windows.Forms.ComboBox();
            this.tcPaginas.SuspendLayout();
            this.tpCampos.SuspendLayout();
            this.gbCamposCliente.SuspendLayout();
            this.gbCamposItens.SuspendLayout();
            this.gbCamposNota.SuspendLayout();
            this.tpFiltros.SuspendLayout();
            this.gbFiltrosValor.SuspendLayout();
            this.gbFiltrosDataSaida.SuspendLayout();
            this.gbFiltrosCidades.SuspendLayout();
            this.gbFiltrosDataEmissao.SuspendLayout();
            this.gbFiltrosClientes.SuspendLayout();
            this.tpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDataEmissaoFinal
            // 
            this.dtpDataEmissaoFinal.Enabled = false;
            this.dtpDataEmissaoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissaoFinal.Location = new System.Drawing.Point(112, 31);
            this.dtpDataEmissaoFinal.Name = "dtpDataEmissaoFinal";
            this.dtpDataEmissaoFinal.Size = new System.Drawing.Size(97, 20);
            this.dtpDataEmissaoFinal.TabIndex = 1;
            // 
            // dtpDataEmissaoInicial
            // 
            this.dtpDataEmissaoInicial.Enabled = false;
            this.dtpDataEmissaoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissaoInicial.Location = new System.Drawing.Point(6, 32);
            this.dtpDataEmissaoInicial.Name = "dtpDataEmissaoInicial";
            this.dtpDataEmissaoInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpDataEmissaoInicial.TabIndex = 0;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(1053, 89);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(1134, 89);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 3;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.BtGerar_Click);
            // 
            // tcPaginas
            // 
            this.tcPaginas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPaginas.Controls.Add(this.tpCampos);
            this.tcPaginas.Controls.Add(this.tpFiltros);
            this.tcPaginas.Controls.Add(this.tpDados);
            this.tcPaginas.Location = new System.Drawing.Point(0, 118);
            this.tcPaginas.Name = "tcPaginas";
            this.tcPaginas.SelectedIndex = 0;
            this.tcPaginas.Size = new System.Drawing.Size(1221, 504);
            this.tcPaginas.TabIndex = 1;
            // 
            // tpCampos
            // 
            this.tpCampos.Controls.Add(this.gbCamposCliente);
            this.tpCampos.Controls.Add(this.gbCamposItens);
            this.tpCampos.Controls.Add(this.gbCamposNota);
            this.tpCampos.Location = new System.Drawing.Point(4, 22);
            this.tpCampos.Name = "tpCampos";
            this.tpCampos.Padding = new System.Windows.Forms.Padding(3);
            this.tpCampos.Size = new System.Drawing.Size(1213, 478);
            this.tpCampos.TabIndex = 0;
            this.tpCampos.Text = "Campos";
            this.tpCampos.UseVisualStyleBackColor = true;
            // 
            // gbCamposCliente
            // 
            this.gbCamposCliente.Controls.Add(this.cblCamposClientes);
            this.gbCamposCliente.Controls.Add(this.cbTodosCamposClientes);
            this.gbCamposCliente.Location = new System.Drawing.Point(8, 6);
            this.gbCamposCliente.Name = "gbCamposCliente";
            this.gbCamposCliente.Size = new System.Drawing.Size(180, 221);
            this.gbCamposCliente.TabIndex = 0;
            this.gbCamposCliente.TabStop = false;
            this.gbCamposCliente.Text = "Campos do cliente";
            // 
            // cblCamposClientes
            // 
            this.cblCamposClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblCamposClientes.CheckOnClick = true;
            this.cblCamposClientes.FormattingEnabled = true;
            this.cblCamposClientes.Location = new System.Drawing.Point(6, 46);
            this.cblCamposClientes.Name = "cblCamposClientes";
            this.cblCamposClientes.Size = new System.Drawing.Size(168, 169);
            this.cblCamposClientes.TabIndex = 1;
            // 
            // cbTodosCamposClientes
            // 
            this.cbTodosCamposClientes.AutoSize = true;
            this.cbTodosCamposClientes.Location = new System.Drawing.Point(6, 19);
            this.cbTodosCamposClientes.Name = "cbTodosCamposClientes";
            this.cbTodosCamposClientes.Size = new System.Drawing.Size(56, 17);
            this.cbTodosCamposClientes.TabIndex = 0;
            this.cbTodosCamposClientes.Text = "Todos";
            this.cbTodosCamposClientes.UseVisualStyleBackColor = true;
            this.cbTodosCamposClientes.CheckedChanged += new System.EventHandler(this.CbTodosCamposClientes_CheckedChanged);
            // 
            // gbCamposItens
            // 
            this.gbCamposItens.Controls.Add(this.cblCamposItens);
            this.gbCamposItens.Controls.Add(this.cbTodosCamposItens);
            this.gbCamposItens.Location = new System.Drawing.Point(380, 6);
            this.gbCamposItens.Name = "gbCamposItens";
            this.gbCamposItens.Size = new System.Drawing.Size(180, 221);
            this.gbCamposItens.TabIndex = 3;
            this.gbCamposItens.TabStop = false;
            this.gbCamposItens.Text = "Campos dos itens";
            // 
            // cblCamposItens
            // 
            this.cblCamposItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblCamposItens.CheckOnClick = true;
            this.cblCamposItens.FormattingEnabled = true;
            this.cblCamposItens.Location = new System.Drawing.Point(6, 46);
            this.cblCamposItens.Name = "cblCamposItens";
            this.cblCamposItens.Size = new System.Drawing.Size(168, 169);
            this.cblCamposItens.TabIndex = 2;
            // 
            // cbTodosCamposItens
            // 
            this.cbTodosCamposItens.AutoSize = true;
            this.cbTodosCamposItens.Location = new System.Drawing.Point(6, 19);
            this.cbTodosCamposItens.Name = "cbTodosCamposItens";
            this.cbTodosCamposItens.Size = new System.Drawing.Size(56, 17);
            this.cbTodosCamposItens.TabIndex = 2;
            this.cbTodosCamposItens.Text = "Todos";
            this.cbTodosCamposItens.UseVisualStyleBackColor = true;
            this.cbTodosCamposItens.CheckedChanged += new System.EventHandler(this.CbTodosCamposItens_CheckedChanged);
            // 
            // gbCamposNota
            // 
            this.gbCamposNota.Controls.Add(this.cblCamposNota);
            this.gbCamposNota.Controls.Add(this.cbTodosCamposNota);
            this.gbCamposNota.Location = new System.Drawing.Point(194, 6);
            this.gbCamposNota.Name = "gbCamposNota";
            this.gbCamposNota.Size = new System.Drawing.Size(180, 221);
            this.gbCamposNota.TabIndex = 1;
            this.gbCamposNota.TabStop = false;
            this.gbCamposNota.Text = "Campos da nota";
            // 
            // cblCamposNota
            // 
            this.cblCamposNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblCamposNota.CheckOnClick = true;
            this.cblCamposNota.FormattingEnabled = true;
            this.cblCamposNota.Location = new System.Drawing.Point(6, 46);
            this.cblCamposNota.Name = "cblCamposNota";
            this.cblCamposNota.Size = new System.Drawing.Size(168, 169);
            this.cblCamposNota.TabIndex = 2;
            // 
            // cbTodosCamposNota
            // 
            this.cbTodosCamposNota.AutoSize = true;
            this.cbTodosCamposNota.Location = new System.Drawing.Point(6, 19);
            this.cbTodosCamposNota.Name = "cbTodosCamposNota";
            this.cbTodosCamposNota.Size = new System.Drawing.Size(56, 17);
            this.cbTodosCamposNota.TabIndex = 2;
            this.cbTodosCamposNota.Text = "Todos";
            this.cbTodosCamposNota.UseVisualStyleBackColor = true;
            this.cbTodosCamposNota.CheckedChanged += new System.EventHandler(this.CbTodosCamposNota_CheckedChanged);
            // 
            // tpFiltros
            // 
            this.tpFiltros.AutoScroll = true;
            this.tpFiltros.Controls.Add(this.cbFiltroValor);
            this.tpFiltros.Controls.Add(this.gbFiltrosValor);
            this.tpFiltros.Controls.Add(this.cbFiltroDataSaida);
            this.tpFiltros.Controls.Add(this.gbFiltrosDataSaida);
            this.tpFiltros.Controls.Add(this.cbFiltrosCidades);
            this.tpFiltros.Controls.Add(this.gbFiltrosCidades);
            this.tpFiltros.Controls.Add(this.cbFiltroDataEmissao);
            this.tpFiltros.Controls.Add(this.gbFiltrosDataEmissao);
            this.tpFiltros.Controls.Add(this.cbFiltrosClientes);
            this.tpFiltros.Controls.Add(this.gbFiltrosClientes);
            this.tpFiltros.Location = new System.Drawing.Point(4, 22);
            this.tpFiltros.Name = "tpFiltros";
            this.tpFiltros.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiltros.Size = new System.Drawing.Size(1213, 478);
            this.tpFiltros.TabIndex = 1;
            this.tpFiltros.Text = "Filtros";
            this.tpFiltros.UseVisualStyleBackColor = true;
            // 
            // cbFiltroValor
            // 
            this.cbFiltroValor.AutoSize = true;
            this.cbFiltroValor.Location = new System.Drawing.Point(328, 0);
            this.cbFiltroValor.Name = "cbFiltroValor";
            this.cbFiltroValor.Size = new System.Drawing.Size(89, 17);
            this.cbFiltroValor.TabIndex = 8;
            this.cbFiltroValor.Text = "Filtro de valor";
            this.cbFiltroValor.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosValor
            // 
            this.gbFiltrosValor.Controls.Add(this.lbValorFinal);
            this.gbFiltrosValor.Controls.Add(this.dbValorInicial);
            this.gbFiltrosValor.Controls.Add(this.lbValorInicial);
            this.gbFiltrosValor.Controls.Add(this.dbValorFinal);
            this.gbFiltrosValor.Enabled = false;
            this.gbFiltrosValor.Location = new System.Drawing.Point(328, 18);
            this.gbFiltrosValor.Name = "gbFiltrosValor";
            this.gbFiltrosValor.Size = new System.Drawing.Size(313, 63);
            this.gbFiltrosValor.TabIndex = 9;
            this.gbFiltrosValor.TabStop = false;
            // 
            // lbValorFinal
            // 
            this.lbValorFinal.AutoSize = true;
            this.lbValorFinal.Location = new System.Drawing.Point(74, 13);
            this.lbValorFinal.Name = "lbValorFinal";
            this.lbValorFinal.Size = new System.Drawing.Size(53, 13);
            this.lbValorFinal.TabIndex = 5;
            this.lbValorFinal.Text = "Valor final";
            // 
            // dbValorInicial
            // 
            this.dbValorInicial.Enabled = false;
            this.dbValorInicial.Location = new System.Drawing.Point(7, 29);
            this.dbValorInicial.Name = "dbValorInicial";
            this.dbValorInicial.Size = new System.Drawing.Size(64, 22);
            this.dbValorInicial.TabIndex = 0;
            this.dbValorInicial.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbValorInicial
            // 
            this.lbValorInicial.AutoSize = true;
            this.lbValorInicial.Location = new System.Drawing.Point(6, 13);
            this.lbValorInicial.Name = "lbValorInicial";
            this.lbValorInicial.Size = new System.Drawing.Size(60, 13);
            this.lbValorInicial.TabIndex = 4;
            this.lbValorInicial.Text = "Valor inicial";
            // 
            // dbValorFinal
            // 
            this.dbValorFinal.Enabled = false;
            this.dbValorFinal.Location = new System.Drawing.Point(77, 29);
            this.dbValorFinal.Name = "dbValorFinal";
            this.dbValorFinal.Size = new System.Drawing.Size(63, 22);
            this.dbValorFinal.TabIndex = 1;
            this.dbValorFinal.Valor = new decimal(new int[] {
            99999900,
            0,
            0,
            131072});
            // 
            // cbFiltroDataSaida
            // 
            this.cbFiltroDataSaida.AutoSize = true;
            this.cbFiltroDataSaida.Location = new System.Drawing.Point(6, 325);
            this.cbFiltroDataSaida.Name = "cbFiltroDataSaida";
            this.cbFiltroDataSaida.Size = new System.Drawing.Size(132, 17);
            this.cbFiltroDataSaida.TabIndex = 6;
            this.cbFiltroDataSaida.Text = "Filtro de data de saída";
            this.cbFiltroDataSaida.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosDataSaida
            // 
            this.gbFiltrosDataSaida.Controls.Add(this.lbDataSaidaFinal);
            this.gbFiltrosDataSaida.Controls.Add(this.dtpDataSaidaInicial);
            this.gbFiltrosDataSaida.Controls.Add(this.lbDataSaidaInicial);
            this.gbFiltrosDataSaida.Controls.Add(this.dtpDataSaidaFinal);
            this.gbFiltrosDataSaida.Enabled = false;
            this.gbFiltrosDataSaida.Location = new System.Drawing.Point(3, 339);
            this.gbFiltrosDataSaida.Name = "gbFiltrosDataSaida";
            this.gbFiltrosDataSaida.Size = new System.Drawing.Size(317, 60);
            this.gbFiltrosDataSaida.TabIndex = 7;
            this.gbFiltrosDataSaida.TabStop = false;
            // 
            // lbDataSaidaFinal
            // 
            this.lbDataSaidaFinal.AutoSize = true;
            this.lbDataSaidaFinal.Location = new System.Drawing.Point(108, 15);
            this.lbDataSaidaFinal.Name = "lbDataSaidaFinal";
            this.lbDataSaidaFinal.Size = new System.Drawing.Size(52, 13);
            this.lbDataSaidaFinal.TabIndex = 5;
            this.lbDataSaidaFinal.Text = "Data final";
            // 
            // dtpDataSaidaInicial
            // 
            this.dtpDataSaidaInicial.Enabled = false;
            this.dtpDataSaidaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaidaInicial.Location = new System.Drawing.Point(6, 32);
            this.dtpDataSaidaInicial.Name = "dtpDataSaidaInicial";
            this.dtpDataSaidaInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpDataSaidaInicial.TabIndex = 0;
            // 
            // lbDataSaidaInicial
            // 
            this.lbDataSaidaInicial.AutoSize = true;
            this.lbDataSaidaInicial.Location = new System.Drawing.Point(5, 16);
            this.lbDataSaidaInicial.Name = "lbDataSaidaInicial";
            this.lbDataSaidaInicial.Size = new System.Drawing.Size(59, 13);
            this.lbDataSaidaInicial.TabIndex = 4;
            this.lbDataSaidaInicial.Text = "Data inicial";
            // 
            // dtpDataSaidaFinal
            // 
            this.dtpDataSaidaFinal.Enabled = false;
            this.dtpDataSaidaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaidaFinal.Location = new System.Drawing.Point(112, 32);
            this.dtpDataSaidaFinal.Name = "dtpDataSaidaFinal";
            this.dtpDataSaidaFinal.Size = new System.Drawing.Size(97, 20);
            this.dtpDataSaidaFinal.TabIndex = 1;
            // 
            // cbFiltrosCidades
            // 
            this.cbFiltrosCidades.AutoSize = true;
            this.cbFiltrosCidades.Location = new System.Drawing.Point(8, 123);
            this.cbFiltrosCidades.Name = "cbFiltrosCidades";
            this.cbFiltrosCidades.Size = new System.Drawing.Size(108, 17);
            this.cbFiltrosCidades.TabIndex = 2;
            this.cbFiltrosCidades.Text = "Filtros de cidades\r\n";
            this.cbFiltrosCidades.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosCidades
            // 
            this.gbFiltrosCidades.Controls.Add(this.bcInicial);
            this.gbFiltrosCidades.Controls.Add(this.bcFinal);
            this.gbFiltrosCidades.Enabled = false;
            this.gbFiltrosCidades.Location = new System.Drawing.Point(6, 138);
            this.gbFiltrosCidades.Name = "gbFiltrosCidades";
            this.gbFiltrosCidades.Size = new System.Drawing.Size(314, 99);
            this.gbFiltrosCidades.TabIndex = 3;
            this.gbFiltrosCidades.TabStop = false;
            // 
            // bcInicial
            // 
            this.bcInicial.LabelText = "Cidade inicial";
            this.bcInicial.Location = new System.Drawing.Point(3, 13);
            this.bcInicial.Margin = new System.Windows.Forms.Padding(0);
            this.bcInicial.Name = "bcInicial";
            this.bcInicial.Size = new System.Drawing.Size(302, 39);
            this.bcInicial.TabIndex = 0;
            // 
            // bcFinal
            // 
            this.bcFinal.LabelText = "Cidade final";
            this.bcFinal.Location = new System.Drawing.Point(3, 53);
            this.bcFinal.Margin = new System.Windows.Forms.Padding(0);
            this.bcFinal.Name = "bcFinal";
            this.bcFinal.Size = new System.Drawing.Size(302, 39);
            this.bcFinal.TabIndex = 1;
            // 
            // cbFiltroDataEmissao
            // 
            this.cbFiltroDataEmissao.AutoSize = true;
            this.cbFiltroDataEmissao.Location = new System.Drawing.Point(9, 243);
            this.cbFiltroDataEmissao.Name = "cbFiltroDataEmissao";
            this.cbFiltroDataEmissao.Size = new System.Drawing.Size(143, 17);
            this.cbFiltroDataEmissao.TabIndex = 4;
            this.cbFiltroDataEmissao.Text = "Filtro de data de emissão";
            this.cbFiltroDataEmissao.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosDataEmissao
            // 
            this.gbFiltrosDataEmissao.Controls.Add(this.lbDataEmissaoFinal);
            this.gbFiltrosDataEmissao.Controls.Add(this.lbDataEmissaoInicial);
            this.gbFiltrosDataEmissao.Controls.Add(this.dtpDataEmissaoInicial);
            this.gbFiltrosDataEmissao.Controls.Add(this.dtpDataEmissaoFinal);
            this.gbFiltrosDataEmissao.Enabled = false;
            this.gbFiltrosDataEmissao.Location = new System.Drawing.Point(6, 259);
            this.gbFiltrosDataEmissao.Name = "gbFiltrosDataEmissao";
            this.gbFiltrosDataEmissao.Size = new System.Drawing.Size(313, 60);
            this.gbFiltrosDataEmissao.TabIndex = 5;
            this.gbFiltrosDataEmissao.TabStop = false;
            // 
            // lbDataEmissaoFinal
            // 
            this.lbDataEmissaoFinal.AutoSize = true;
            this.lbDataEmissaoFinal.Location = new System.Drawing.Point(109, 15);
            this.lbDataEmissaoFinal.Name = "lbDataEmissaoFinal";
            this.lbDataEmissaoFinal.Size = new System.Drawing.Size(52, 13);
            this.lbDataEmissaoFinal.TabIndex = 3;
            this.lbDataEmissaoFinal.Text = "Data final";
            // 
            // lbDataEmissaoInicial
            // 
            this.lbDataEmissaoInicial.AutoSize = true;
            this.lbDataEmissaoInicial.Location = new System.Drawing.Point(6, 16);
            this.lbDataEmissaoInicial.Name = "lbDataEmissaoInicial";
            this.lbDataEmissaoInicial.Size = new System.Drawing.Size(59, 13);
            this.lbDataEmissaoInicial.TabIndex = 2;
            this.lbDataEmissaoInicial.Text = "Data inicial";
            // 
            // cbFiltrosClientes
            // 
            this.cbFiltrosClientes.AutoSize = true;
            this.cbFiltrosClientes.Location = new System.Drawing.Point(8, 3);
            this.cbFiltrosClientes.Name = "cbFiltrosClientes";
            this.cbFiltrosClientes.Size = new System.Drawing.Size(107, 17);
            this.cbFiltrosClientes.TabIndex = 0;
            this.cbFiltrosClientes.Text = "Filtros de clientes";
            this.cbFiltrosClientes.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosClientes
            // 
            this.gbFiltrosClientes.Controls.Add(this.bpFinal);
            this.gbFiltrosClientes.Controls.Add(this.bpInicial);
            this.gbFiltrosClientes.Enabled = false;
            this.gbFiltrosClientes.Location = new System.Drawing.Point(6, 18);
            this.gbFiltrosClientes.Name = "gbFiltrosClientes";
            this.gbFiltrosClientes.Size = new System.Drawing.Size(314, 99);
            this.gbFiltrosClientes.TabIndex = 1;
            this.gbFiltrosClientes.TabStop = false;
            // 
            // bpFinal
            // 
            this.bpFinal.LabelText = "Cliente final";
            this.bpFinal.Location = new System.Drawing.Point(3, 52);
            this.bpFinal.Margin = new System.Windows.Forms.Padding(0);
            this.bpFinal.Name = "bpFinal";
            this.bpFinal.Size = new System.Drawing.Size(310, 39);
            this.bpFinal.TabIndex = 1;
            // 
            // bpInicial
            // 
            this.bpInicial.LabelText = "Cliente inicial";
            this.bpInicial.Location = new System.Drawing.Point(3, 13);
            this.bpInicial.Margin = new System.Windows.Forms.Padding(0);
            this.bpInicial.Name = "bpInicial";
            this.bpInicial.Size = new System.Drawing.Size(310, 39);
            this.bpInicial.TabIndex = 0;
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.dgvDados);
            this.tpDados.Location = new System.Drawing.Point(4, 22);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(1213, 478);
            this.tpDados.TabIndex = 2;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1207, 472);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.TabStop = false;
            // 
            // gbRelatorio
            // 
            this.gbRelatorio.Controls.Add(this.btExcluirRelatorio);
            this.gbRelatorio.Controls.Add(this.btNovoRelatorio);
            this.gbRelatorio.Controls.Add(this.btSalvarRelatorio);
            this.gbRelatorio.Controls.Add(this.btCarregarRelatorio);
            this.gbRelatorio.Controls.Add(this.cbRelatorios);
            this.gbRelatorio.Location = new System.Drawing.Point(12, 12);
            this.gbRelatorio.Name = "gbRelatorio";
            this.gbRelatorio.Size = new System.Drawing.Size(1035, 100);
            this.gbRelatorio.TabIndex = 0;
            this.gbRelatorio.TabStop = false;
            this.gbRelatorio.Text = "Relatório";
            // 
            // btExcluirRelatorio
            // 
            this.btExcluirRelatorio.Location = new System.Drawing.Point(249, 46);
            this.btExcluirRelatorio.Name = "btExcluirRelatorio";
            this.btExcluirRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btExcluirRelatorio.TabIndex = 4;
            this.btExcluirRelatorio.Text = "Excluir";
            this.btExcluirRelatorio.UseVisualStyleBackColor = true;
            // 
            // btNovoRelatorio
            // 
            this.btNovoRelatorio.Location = new System.Drawing.Point(168, 46);
            this.btNovoRelatorio.Name = "btNovoRelatorio";
            this.btNovoRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btNovoRelatorio.TabIndex = 3;
            this.btNovoRelatorio.Text = "Novo";
            this.btNovoRelatorio.UseVisualStyleBackColor = true;
            // 
            // btSalvarRelatorio
            // 
            this.btSalvarRelatorio.Location = new System.Drawing.Point(87, 46);
            this.btSalvarRelatorio.Name = "btSalvarRelatorio";
            this.btSalvarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btSalvarRelatorio.TabIndex = 2;
            this.btSalvarRelatorio.Text = "Salvar";
            this.btSalvarRelatorio.UseVisualStyleBackColor = true;
            // 
            // btCarregarRelatorio
            // 
            this.btCarregarRelatorio.Location = new System.Drawing.Point(6, 46);
            this.btCarregarRelatorio.Name = "btCarregarRelatorio";
            this.btCarregarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btCarregarRelatorio.TabIndex = 1;
            this.btCarregarRelatorio.Text = "Carregar";
            this.btCarregarRelatorio.UseVisualStyleBackColor = true;
            // 
            // cbRelatorios
            // 
            this.cbRelatorios.FormattingEnabled = true;
            this.cbRelatorios.Location = new System.Drawing.Point(6, 19);
            this.cbRelatorios.Name = "cbRelatorios";
            this.cbRelatorios.Size = new System.Drawing.Size(1023, 21);
            this.cbRelatorios.TabIndex = 0;
            // 
            // fmRltNotasSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 622);
            this.Controls.Add(this.gbRelatorio);
            this.Controls.Add(this.tcPaginas);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btGerar);
            this.KeyPreview = true;
            this.Name = "fmRltNotasSaida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de notas de saída";
            this.tcPaginas.ResumeLayout(false);
            this.tpCampos.ResumeLayout(false);
            this.gbCamposCliente.ResumeLayout(false);
            this.gbCamposCliente.PerformLayout();
            this.gbCamposItens.ResumeLayout(false);
            this.gbCamposItens.PerformLayout();
            this.gbCamposNota.ResumeLayout(false);
            this.gbCamposNota.PerformLayout();
            this.tpFiltros.ResumeLayout(false);
            this.tpFiltros.PerformLayout();
            this.gbFiltrosValor.ResumeLayout(false);
            this.gbFiltrosValor.PerformLayout();
            this.gbFiltrosDataSaida.ResumeLayout(false);
            this.gbFiltrosDataSaida.PerformLayout();
            this.gbFiltrosCidades.ResumeLayout(false);
            this.gbFiltrosDataEmissao.ResumeLayout(false);
            this.gbFiltrosDataEmissao.PerformLayout();
            this.gbFiltrosClientes.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.BuscaPessoa bpInicial;
        private System.Windows.Forms.DateTimePicker dtpDataEmissaoInicial;
        private System.Windows.Forms.DateTimePicker dtpDataEmissaoFinal;
        private Controls.DecimalBox dbValorFinal;
        private Controls.DecimalBox dbValorInicial;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TabControl tcPaginas;
        private System.Windows.Forms.TabPage tpCampos;
        private System.Windows.Forms.TabPage tpFiltros;
        private System.Windows.Forms.GroupBox gbFiltrosClientes;
        private System.Windows.Forms.TabPage tpDados;
        private Controls.BuscaPessoa bpFinal;
        private System.Windows.Forms.CheckBox cbFiltroDataEmissao;
        private System.Windows.Forms.GroupBox gbFiltrosDataEmissao;
        private System.Windows.Forms.CheckBox cbFiltrosClientes;
        private System.Windows.Forms.CheckBox cbFiltrosCidades;
        private System.Windows.Forms.GroupBox gbFiltrosCidades;
        private Controls.BuscaCidade bcFinal;
        private System.Windows.Forms.CheckBox cbFiltroDataSaida;
        private System.Windows.Forms.GroupBox gbFiltrosDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataSaidaInicial;
        private System.Windows.Forms.DateTimePicker dtpDataSaidaFinal;
        private System.Windows.Forms.CheckBox cbFiltroValor;
        private System.Windows.Forms.GroupBox gbFiltrosValor;
        private Controls.BuscaCidade bcInicial;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox gbRelatorio;
        private System.Windows.Forms.Button btNovoRelatorio;
        private System.Windows.Forms.Button btSalvarRelatorio;
        private System.Windows.Forms.Button btCarregarRelatorio;
        private System.Windows.Forms.ComboBox cbRelatorios;
        private System.Windows.Forms.Button btExcluirRelatorio;
        private System.Windows.Forms.GroupBox gbCamposCliente;
        private System.Windows.Forms.CheckedListBox cblCamposClientes;
        private System.Windows.Forms.CheckBox cbTodosCamposClientes;
        private System.Windows.Forms.GroupBox gbCamposNota;
        private System.Windows.Forms.CheckedListBox cblCamposNota;
        private System.Windows.Forms.CheckBox cbTodosCamposNota;
        private System.Windows.Forms.GroupBox gbCamposItens;
        private System.Windows.Forms.CheckedListBox cblCamposItens;
        private System.Windows.Forms.CheckBox cbTodosCamposItens;
        private System.Windows.Forms.Label lbValorFinal;
        private System.Windows.Forms.Label lbValorInicial;
        private System.Windows.Forms.Label lbDataSaidaFinal;
        private System.Windows.Forms.Label lbDataSaidaInicial;
        private System.Windows.Forms.Label lbDataEmissaoFinal;
        private System.Windows.Forms.Label lbDataEmissaoInicial;
    }
}