namespace _5gpro.Relatorios
{
    partial class fmRelatorioContas
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
            this.dgvRelatorioFiltro = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cbDataConta = new System.Windows.Forms.CheckBox();
            this.cbDataCadastro = new System.Windows.Forms.CheckBox();
            this.cbValor = new System.Windows.Forms.CheckBox();
            this.lbAte = new System.Windows.Forms.Label();
            this.dbValorfinal = new _5gpro.Controls.DecimalBox();
            this.dbValorinicial = new _5gpro.Controls.DecimalBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbSituacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.dtpContafim = new System.Windows.Forms.DateTimePicker();
            this.dtpContainicio = new System.Windows.Forms.DateTimePicker();
            this.dtpCadfim = new System.Windows.Forms.DateTimePicker();
            this.dtpCadinicio = new System.Windows.Forms.DateTimePicker();
            this.clContas = new System.Windows.Forms.CheckedListBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.clColunas = new System.Windows.Forms.CheckedListBox();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioFiltro)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRelatorioFiltro
            // 
            this.dgvRelatorioFiltro.AllowUserToAddRows = false;
            this.dgvRelatorioFiltro.AllowUserToDeleteRows = false;
            this.dgvRelatorioFiltro.AllowUserToOrderColumns = true;
            this.dgvRelatorioFiltro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvRelatorioFiltro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorioFiltro.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRelatorioFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioFiltro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRelatorioFiltro.Location = new System.Drawing.Point(138, 12);
            this.dgvRelatorioFiltro.MultiSelect = false;
            this.dgvRelatorioFiltro.Name = "dgvRelatorioFiltro";
            this.dgvRelatorioFiltro.ReadOnly = true;
            this.dgvRelatorioFiltro.RowHeadersVisible = false;
            this.dgvRelatorioFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorioFiltro.Size = new System.Drawing.Size(1008, 349);
            this.dgvRelatorioFiltro.TabIndex = 0;
            this.dgvRelatorioFiltro.TabStop = false;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cbDataConta);
            this.gbFiltros.Controls.Add(this.cbDataCadastro);
            this.gbFiltros.Controls.Add(this.cbValor);
            this.gbFiltros.Controls.Add(this.lbAte);
            this.gbFiltros.Controls.Add(this.dbValorfinal);
            this.gbFiltros.Controls.Add(this.dbValorinicial);
            this.gbFiltros.Controls.Add(this.lbValor);
            this.gbFiltros.Controls.Add(this.lbSituacao);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.lbDataCadastro);
            this.gbFiltros.Controls.Add(this.dtpContafim);
            this.gbFiltros.Controls.Add(this.dtpContainicio);
            this.gbFiltros.Controls.Add(this.dtpCadfim);
            this.gbFiltros.Controls.Add(this.dtpCadinicio);
            this.gbFiltros.Controls.Add(this.clContas);
            this.gbFiltros.Location = new System.Drawing.Point(138, 367);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(548, 122);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            // 
            // cbDataConta
            // 
            this.cbDataConta.AutoSize = true;
            this.cbDataConta.Location = new System.Drawing.Point(220, 87);
            this.cbDataConta.Name = "cbDataConta";
            this.cbDataConta.Size = new System.Drawing.Size(15, 14);
            this.cbDataConta.TabIndex = 18;
            this.cbDataConta.UseVisualStyleBackColor = true;
            this.cbDataConta.CheckedChanged += new System.EventHandler(this.CbDataConta_CheckedChanged);
            // 
            // cbDataCadastro
            // 
            this.cbDataCadastro.AutoSize = true;
            this.cbDataCadastro.Location = new System.Drawing.Point(220, 42);
            this.cbDataCadastro.Name = "cbDataCadastro";
            this.cbDataCadastro.Size = new System.Drawing.Size(15, 14);
            this.cbDataCadastro.TabIndex = 17;
            this.cbDataCadastro.UseVisualStyleBackColor = true;
            this.cbDataCadastro.CheckedChanged += new System.EventHandler(this.CbDataCadastro_CheckedChanged);
            // 
            // cbValor
            // 
            this.cbValor.AutoSize = true;
            this.cbValor.Location = new System.Drawing.Point(501, 61);
            this.cbValor.Name = "cbValor";
            this.cbValor.Size = new System.Drawing.Size(15, 14);
            this.cbValor.TabIndex = 16;
            this.cbValor.UseVisualStyleBackColor = true;
            this.cbValor.CheckedChanged += new System.EventHandler(this.CbValor_CheckedChanged);
            // 
            // lbAte
            // 
            this.lbAte.AutoSize = true;
            this.lbAte.Location = new System.Drawing.Point(394, 66);
            this.lbAte.Name = "lbAte";
            this.lbAte.Size = new System.Drawing.Size(23, 13);
            this.lbAte.TabIndex = 15;
            this.lbAte.Text = "Até";
            // 
            // dbValorfinal
            // 
            this.dbValorfinal.Enabled = false;
            this.dbValorfinal.Location = new System.Drawing.Point(395, 82);
            this.dbValorfinal.Name = "dbValorfinal";
            this.dbValorfinal.Size = new System.Drawing.Size(100, 22);
            this.dbValorfinal.TabIndex = 14;
            this.dbValorfinal.Valor = new decimal(new int[] {
            99999900,
            0,
            0,
            131072});
            // 
            // dbValorinicial
            // 
            this.dbValorinicial.Enabled = false;
            this.dbValorinicial.Location = new System.Drawing.Point(394, 40);
            this.dbValorinicial.Name = "dbValorinicial";
            this.dbValorinicial.Size = new System.Drawing.Size(100, 22);
            this.dbValorinicial.TabIndex = 13;
            this.dbValorinicial.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(392, 23);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 12;
            this.lbValor.Text = "Valor";
            // 
            // lbSituacao
            // 
            this.lbSituacao.AutoSize = true;
            this.lbSituacao.Location = new System.Drawing.Point(256, 23);
            this.lbSituacao.Name = "lbSituacao";
            this.lbSituacao.Size = new System.Drawing.Size(94, 13);
            this.lbSituacao.TabIndex = 11;
            this.lbSituacao.Text = "Situação da conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data da Conta";
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Location = new System.Drawing.Point(71, 23);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(90, 13);
            this.lbDataCadastro.TabIndex = 9;
            this.lbDataCadastro.Text = "Data do Cadastro";
            // 
            // dtpContafim
            // 
            this.dtpContafim.Enabled = false;
            this.dtpContafim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContafim.Location = new System.Drawing.Point(117, 84);
            this.dtpContafim.Name = "dtpContafim";
            this.dtpContafim.Size = new System.Drawing.Size(97, 20);
            this.dtpContafim.TabIndex = 8;
            // 
            // dtpContainicio
            // 
            this.dtpContainicio.Enabled = false;
            this.dtpContainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContainicio.Location = new System.Drawing.Point(10, 84);
            this.dtpContainicio.Name = "dtpContainicio";
            this.dtpContainicio.Size = new System.Drawing.Size(100, 20);
            this.dtpContainicio.TabIndex = 7;
            // 
            // dtpCadfim
            // 
            this.dtpCadfim.Enabled = false;
            this.dtpCadfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadfim.Location = new System.Drawing.Point(117, 39);
            this.dtpCadfim.Name = "dtpCadfim";
            this.dtpCadfim.Size = new System.Drawing.Size(97, 20);
            this.dtpCadfim.TabIndex = 6;
            // 
            // dtpCadinicio
            // 
            this.dtpCadinicio.Enabled = false;
            this.dtpCadinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadinicio.Location = new System.Drawing.Point(10, 39);
            this.dtpCadinicio.Name = "dtpCadinicio";
            this.dtpCadinicio.Size = new System.Drawing.Size(100, 20);
            this.dtpCadinicio.TabIndex = 5;
            // 
            // clContas
            // 
            this.clContas.CheckOnClick = true;
            this.clContas.FormattingEnabled = true;
            this.clContas.Items.AddRange(new object[] {
            "Aberto",
            "Pago",
            "A Pagar",
            "A Receber"});
            this.clContas.Location = new System.Drawing.Point(259, 40);
            this.clContas.Name = "clContas";
            this.clContas.Size = new System.Drawing.Size(120, 64);
            this.clContas.TabIndex = 4;
            this.clContas.Tag = "";
            this.clContas.SelectedIndexChanged += new System.EventHandler(this.ClContas_SelectedIndexChanged);
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(760, 377);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(62, 26);
            this.btGerar.TabIndex = 0;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.BtGerar_Click);
            // 
            // btListar
            // 
            this.btListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btListar.Location = new System.Drawing.Point(692, 377);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(62, 26);
            this.btListar.TabIndex = 2;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.BtListar_Click);
            // 
            // clColunas
            // 
            this.clColunas.CheckOnClick = true;
            this.clColunas.FormattingEnabled = true;
            this.clColunas.Items.AddRange(new object[] {
            "Conta",
            "ClienteFornecedor",
            "Nome",
            "Data cad.",
            "Valor original",
            "Multa",
            "Juros",
            "Acréscimo",
            "Desconto",
            "Valor final"});
            this.clColunas.Location = new System.Drawing.Point(12, 57);
            this.clColunas.Name = "clColunas";
            this.clColunas.Size = new System.Drawing.Size(120, 184);
            this.clColunas.TabIndex = 19;
            this.clColunas.SelectedIndexChanged += new System.EventHandler(this.ClColunas_SelectedIndexChanged);
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Checked = true;
            this.cbTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTodos.Location = new System.Drawing.Point(15, 38);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(56, 17);
            this.cbTodos.TabIndex = 20;
            this.cbTodos.Text = "Todos";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckedChanged += new System.EventHandler(this.CbTodos_CheckedChanged);
            // 
            // fmRelatorioContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 524);
            this.Controls.Add(this.cbTodos);
            this.Controls.Add(this.clColunas);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvRelatorioFiltro);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btGerar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmRelatorioContas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Contas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioFiltro)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorioFiltro;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.CheckedListBox clContas;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.DateTimePicker dtpCadinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.DateTimePicker dtpContafim;
        private System.Windows.Forms.DateTimePicker dtpContainicio;
        private System.Windows.Forms.DateTimePicker dtpCadfim;
        private System.Windows.Forms.Label lbAte;
        private Controls.DecimalBox dbValorfinal;
        private Controls.DecimalBox dbValorinicial;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbSituacao;
        private System.Windows.Forms.CheckBox cbDataConta;
        private System.Windows.Forms.CheckBox cbDataCadastro;
        private System.Windows.Forms.CheckBox cbValor;
        private System.Windows.Forms.CheckedListBox clColunas;
        private System.Windows.Forms.CheckBox cbTodos;
    }
}