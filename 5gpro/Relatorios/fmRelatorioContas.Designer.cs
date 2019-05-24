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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRelatorioFiltro = new System.Windows.Forms.DataGridView();
            this.dgvtbcIDconta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcClienteFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDatacad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorfinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cbDataConta = new System.Windows.Forms.CheckBox();
            this.cbDataCadastro = new System.Windows.Forms.CheckBox();
            this.cbValor = new System.Windows.Forms.CheckBox();
            this.lbAte = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbSituacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.dtpContafim = new System.Windows.Forms.DateTimePicker();
            this.dtpContainicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDesmarcados = new System.Windows.Forms.RadioButton();
            this.rbMarcados = new System.Windows.Forms.RadioButton();
            this.btRemover = new System.Windows.Forms.Button();
            this.dtpCadfim = new System.Windows.Forms.DateTimePicker();
            this.dtpCadinicio = new System.Windows.Forms.DateTimePicker();
            this.clContas = new System.Windows.Forms.CheckedListBox();
            this.btGerar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.dbValorfinal = new _5gpro.Controls.DecimalBox();
            this.dbValorinicial = new _5gpro.Controls.DecimalBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioFiltro)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRelatorioFiltro
            // 
            this.dgvRelatorioFiltro.AllowUserToAddRows = false;
            this.dgvRelatorioFiltro.AllowUserToDeleteRows = false;
            this.dgvRelatorioFiltro.AllowUserToOrderColumns = true;
            this.dgvRelatorioFiltro.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.dgvRelatorioFiltro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRelatorioFiltro.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRelatorioFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcIDconta,
            this.dgvtbcClienteFornecedor,
            this.dgvtbcNome,
            this.dgvtbcDatacad,
            this.dgvtbcValorOriginal,
            this.dgvtbcMulta,
            this.dgvtbcJuros,
            this.dgvtbcAcrescimo,
            this.dgvtbcDesconto,
            this.dgvtbcValorfinal});
            this.dgvRelatorioFiltro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRelatorioFiltro.Location = new System.Drawing.Point(12, 12);
            this.dgvRelatorioFiltro.MultiSelect = false;
            this.dgvRelatorioFiltro.Name = "dgvRelatorioFiltro";
            this.dgvRelatorioFiltro.ReadOnly = true;
            this.dgvRelatorioFiltro.RowHeadersVisible = false;
            this.dgvRelatorioFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorioFiltro.Size = new System.Drawing.Size(1008, 352);
            this.dgvRelatorioFiltro.TabIndex = 0;
            this.dgvRelatorioFiltro.TabStop = false;
            // 
            // dgvtbcIDconta
            // 
            this.dgvtbcIDconta.HeaderText = "Conta";
            this.dgvtbcIDconta.Name = "dgvtbcIDconta";
            this.dgvtbcIDconta.ReadOnly = true;
            this.dgvtbcIDconta.Width = 70;
            // 
            // dgvtbcClienteFornecedor
            // 
            this.dgvtbcClienteFornecedor.HeaderText = "ClienteFornecedor";
            this.dgvtbcClienteFornecedor.Name = "dgvtbcClienteFornecedor";
            this.dgvtbcClienteFornecedor.ReadOnly = true;
            // 
            // dgvtbcNome
            // 
            this.dgvtbcNome.HeaderText = "Nome";
            this.dgvtbcNome.Name = "dgvtbcNome";
            this.dgvtbcNome.ReadOnly = true;
            // 
            // dgvtbcDatacad
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvtbcDatacad.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtbcDatacad.HeaderText = "Data cad.";
            this.dgvtbcDatacad.Name = "dgvtbcDatacad";
            this.dgvtbcDatacad.ReadOnly = true;
            // 
            // dgvtbcValorOriginal
            // 
            this.dgvtbcValorOriginal.HeaderText = "Valor original";
            this.dgvtbcValorOriginal.Name = "dgvtbcValorOriginal";
            this.dgvtbcValorOriginal.ReadOnly = true;
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
            this.dgvtbcAcrescimo.HeaderText = "Acréscimo";
            this.dgvtbcAcrescimo.Name = "dgvtbcAcrescimo";
            this.dgvtbcAcrescimo.ReadOnly = true;
            // 
            // dgvtbcDesconto
            // 
            this.dgvtbcDesconto.HeaderText = "Desconto";
            this.dgvtbcDesconto.Name = "dgvtbcDesconto";
            this.dgvtbcDesconto.ReadOnly = true;
            // 
            // dgvtbcValorfinal
            // 
            this.dgvtbcValorfinal.HeaderText = "Valor final";
            this.dgvtbcValorfinal.Name = "dgvtbcValorfinal";
            this.dgvtbcValorfinal.ReadOnly = true;
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
            this.gbFiltros.Controls.Add(this.groupBox1);
            this.gbFiltros.Controls.Add(this.dtpCadfim);
            this.gbFiltros.Controls.Add(this.dtpCadinicio);
            this.gbFiltros.Controls.Add(this.clContas);
            this.gbFiltros.Location = new System.Drawing.Point(56, 381);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(677, 122);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDesmarcados);
            this.groupBox1.Controls.Add(this.rbMarcados);
            this.groupBox1.Controls.Add(this.btRemover);
            this.groupBox1.Location = new System.Drawing.Point(540, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbDesmarcados
            // 
            this.rbDesmarcados.AutoSize = true;
            this.rbDesmarcados.Location = new System.Drawing.Point(6, 36);
            this.rbDesmarcados.Name = "rbDesmarcados";
            this.rbDesmarcados.Size = new System.Drawing.Size(90, 17);
            this.rbDesmarcados.TabIndex = 1;
            this.rbDesmarcados.Text = "Desmarcados";
            this.rbDesmarcados.UseVisualStyleBackColor = true;
            // 
            // rbMarcados
            // 
            this.rbMarcados.AutoSize = true;
            this.rbMarcados.Checked = true;
            this.rbMarcados.Location = new System.Drawing.Point(6, 10);
            this.rbMarcados.Name = "rbMarcados";
            this.rbMarcados.Size = new System.Drawing.Size(72, 17);
            this.rbMarcados.TabIndex = 0;
            this.rbMarcados.TabStop = true;
            this.rbMarcados.Text = "Marcados";
            this.rbMarcados.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(6, 68);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
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
            this.btGerar.Location = new System.Drawing.Point(906, 404);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(92, 69);
            this.btGerar.TabIndex = 0;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.BtGerar_Click);
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(808, 404);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(92, 69);
            this.btListar.TabIndex = 2;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.BtListar_Click);
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
            // fmRelatorioContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 524);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorioFiltro;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.CheckedListBox clContas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDesmarcados;
        private System.Windows.Forms.RadioButton rbMarcados;
        private System.Windows.Forms.Button btRemover;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcIDconta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcClienteFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDatacad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorfinal;
        private System.Windows.Forms.CheckBox cbDataConta;
        private System.Windows.Forms.CheckBox cbDataCadastro;
        private System.Windows.Forms.CheckBox cbValor;
    }
}