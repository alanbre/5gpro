namespace _5gpro.Forms
{
    partial class fmBuscaContaReceber
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
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lbAValorConta = new System.Windows.Forms.Label();
            this.lbADataVencimentoParcela = new System.Windows.Forms.Label();
            this.dtpDataVencimentoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataVencimentoInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataVencimento = new System.Windows.Forms.Label();
            this.lbADataCadastro = new System.Windows.Forms.Label();
            this.dtpDataCadastroFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataCadastroInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.lbValorInicial = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.dgvtbcConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDataCadastro = new System.Windows.Forms.CheckBox();
            this.cbDataVencimentoParcela = new System.Windows.Forms.CheckBox();
            this.cbValorConta = new System.Windows.Forms.CheckBox();
            this.dbValorFinal = new _5gpro.Controls.DecimalBox();
            this.dbValorInicial = new _5gpro.Controls.DecimalBox();
            this.buscaOperacao = new _5gpro.Controls.BuscaOperacao();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.gbFiltros.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.cbValorConta);
            this.gbFiltros.Controls.Add(this.cbDataVencimentoParcela);
            this.gbFiltros.Controls.Add(this.cbDataCadastro);
            this.gbFiltros.Controls.Add(this.btPesquisar);
            this.gbFiltros.Controls.Add(this.lbAValorConta);
            this.gbFiltros.Controls.Add(this.dbValorFinal);
            this.gbFiltros.Controls.Add(this.lbADataVencimentoParcela);
            this.gbFiltros.Controls.Add(this.dtpDataVencimentoFinal);
            this.gbFiltros.Controls.Add(this.dtpDataVencimentoInicial);
            this.gbFiltros.Controls.Add(this.lbDataVencimento);
            this.gbFiltros.Controls.Add(this.lbADataCadastro);
            this.gbFiltros.Controls.Add(this.dtpDataCadastroFinal);
            this.gbFiltros.Controls.Add(this.dtpDataCadastroInicial);
            this.gbFiltros.Controls.Add(this.lbDataCadastro);
            this.gbFiltros.Controls.Add(this.dbValorInicial);
            this.gbFiltros.Controls.Add(this.lbValorInicial);
            this.gbFiltros.Controls.Add(this.buscaOperacao);
            this.gbFiltros.Controls.Add(this.buscaPessoa);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1040, 143);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(192, 113);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 14;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // lbAValorConta
            // 
            this.lbAValorConta.AutoSize = true;
            this.lbAValorConta.Location = new System.Drawing.Point(80, 118);
            this.lbAValorConta.Margin = new System.Windows.Forms.Padding(0);
            this.lbAValorConta.Name = "lbAValorConta";
            this.lbAValorConta.Size = new System.Drawing.Size(13, 13);
            this.lbAValorConta.TabIndex = 4;
            this.lbAValorConta.Text = "a";
            // 
            // lbADataVencimentoParcela
            // 
            this.lbADataVencimentoParcela.AutoSize = true;
            this.lbADataVencimentoParcela.Location = new System.Drawing.Point(557, 74);
            this.lbADataVencimentoParcela.Margin = new System.Windows.Forms.Padding(0);
            this.lbADataVencimentoParcela.Name = "lbADataVencimentoParcela";
            this.lbADataVencimentoParcela.Size = new System.Drawing.Size(13, 13);
            this.lbADataVencimentoParcela.TabIndex = 12;
            this.lbADataVencimentoParcela.Text = "a";
            // 
            // dtpDataVencimentoFinal
            // 
            this.dtpDataVencimentoFinal.Enabled = false;
            this.dtpDataVencimentoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoFinal.Location = new System.Drawing.Point(571, 71);
            this.dtpDataVencimentoFinal.Name = "dtpDataVencimentoFinal";
            this.dtpDataVencimentoFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoFinal.TabIndex = 13;
            // 
            // dtpDataVencimentoInicial
            // 
            this.dtpDataVencimentoInicial.Enabled = false;
            this.dtpDataVencimentoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoInicial.Location = new System.Drawing.Point(460, 71);
            this.dtpDataVencimentoInicial.Name = "dtpDataVencimentoInicial";
            this.dtpDataVencimentoInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoInicial.TabIndex = 11;
            // 
            // lbDataVencimento
            // 
            this.lbDataVencimento.AutoSize = true;
            this.lbDataVencimento.Location = new System.Drawing.Point(496, 55);
            this.lbDataVencimento.Name = "lbDataVencimento";
            this.lbDataVencimento.Size = new System.Drawing.Size(126, 13);
            this.lbDataVencimento.TabIndex = 10;
            this.lbDataVencimento.Text = "Data vencimento parcela";
            // 
            // lbADataCadastro
            // 
            this.lbADataCadastro.AutoSize = true;
            this.lbADataCadastro.Location = new System.Drawing.Point(556, 35);
            this.lbADataCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.lbADataCadastro.Name = "lbADataCadastro";
            this.lbADataCadastro.Size = new System.Drawing.Size(13, 13);
            this.lbADataCadastro.TabIndex = 8;
            this.lbADataCadastro.Text = "a";
            // 
            // dtpDataCadastroFinal
            // 
            this.dtpDataCadastroFinal.Enabled = false;
            this.dtpDataCadastroFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroFinal.Location = new System.Drawing.Point(570, 32);
            this.dtpDataCadastroFinal.Name = "dtpDataCadastroFinal";
            this.dtpDataCadastroFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadastroFinal.TabIndex = 9;
            // 
            // dtpDataCadastroInicial
            // 
            this.dtpDataCadastroInicial.Enabled = false;
            this.dtpDataCadastroInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroInicial.Location = new System.Drawing.Point(459, 32);
            this.dtpDataCadastroInicial.Name = "dtpDataCadastroInicial";
            this.dtpDataCadastroInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadastroInicial.TabIndex = 7;
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Location = new System.Drawing.Point(526, 16);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(74, 13);
            this.lbDataCadastro.TabIndex = 6;
            this.lbDataCadastro.Text = "Data cadastro";
            // 
            // lbValorInicial
            // 
            this.lbValorInicial.AutoSize = true;
            this.lbValorInicial.Location = new System.Drawing.Point(50, 99);
            this.lbValorInicial.Name = "lbValorInicial";
            this.lbValorInicial.Size = new System.Drawing.Size(76, 13);
            this.lbValorInicial.TabIndex = 2;
            this.lbValorInicial.Text = "Valor da conta";
            // 
            // gbResultados
            // 
            this.gbResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResultados.Controls.Add(this.dgvContas);
            this.gbResultados.Location = new System.Drawing.Point(12, 161);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(1040, 401);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Contas a receber";
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.AllowUserToOrderColumns = true;
            this.dgvContas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvContas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcConta,
            this.dgvtbcCliente,
            this.dgvtbcNome,
            this.dgvtbcDataCadastro,
            this.dgvtbcOperacao,
            this.dgvtbcValorOriginal,
            this.dgvtbcMulta,
            this.dgvtbcJuros,
            this.dgvtbcAcrescimo,
            this.dgvtbcDesconto,
            this.dgvtbcValorFinal});
            this.dgvContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContas.Location = new System.Drawing.Point(3, 16);
            this.dgvContas.MultiSelect = false;
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.RowHeadersVisible = false;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(1034, 382);
            this.dgvContas.TabIndex = 0;
            this.dgvContas.TabStop = false;
            this.dgvContas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContas_CellDoubleClick);
            // 
            // dgvtbcConta
            // 
            this.dgvtbcConta.HeaderText = "Conta";
            this.dgvtbcConta.Name = "dgvtbcConta";
            this.dgvtbcConta.ReadOnly = true;
            // 
            // dgvtbcCliente
            // 
            this.dgvtbcCliente.HeaderText = "Cliente";
            this.dgvtbcCliente.Name = "dgvtbcCliente";
            this.dgvtbcCliente.ReadOnly = true;
            this.dgvtbcCliente.Width = 50;
            // 
            // dgvtbcNome
            // 
            this.dgvtbcNome.HeaderText = "Nome";
            this.dgvtbcNome.Name = "dgvtbcNome";
            this.dgvtbcNome.ReadOnly = true;
            this.dgvtbcNome.Width = 120;
            // 
            // dgvtbcDataCadastro
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvtbcDataCadastro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtbcDataCadastro.HeaderText = "Data cad.";
            this.dgvtbcDataCadastro.Name = "dgvtbcDataCadastro";
            this.dgvtbcDataCadastro.ReadOnly = true;
            // 
            // dgvtbcOperacao
            // 
            this.dgvtbcOperacao.HeaderText = "Operação";
            this.dgvtbcOperacao.Name = "dgvtbcOperacao";
            this.dgvtbcOperacao.ReadOnly = true;
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
            // dgvtbcValorFinal
            // 
            this.dgvtbcValorFinal.HeaderText = "Valor final";
            this.dgvtbcValorFinal.Name = "dgvtbcValorFinal";
            this.dgvtbcValorFinal.ReadOnly = true;
            // 
            // cbDataCadastro
            // 
            this.cbDataCadastro.AutoSize = true;
            this.cbDataCadastro.Location = new System.Drawing.Point(672, 35);
            this.cbDataCadastro.Name = "cbDataCadastro";
            this.cbDataCadastro.Size = new System.Drawing.Size(15, 14);
            this.cbDataCadastro.TabIndex = 15;
            this.cbDataCadastro.UseVisualStyleBackColor = true;
            this.cbDataCadastro.CheckedChanged += new System.EventHandler(this.CbDataCadastro_CheckedChanged);
            // 
            // cbDataVencimentoParcela
            // 
            this.cbDataVencimentoParcela.AutoSize = true;
            this.cbDataVencimentoParcela.Location = new System.Drawing.Point(673, 74);
            this.cbDataVencimentoParcela.Name = "cbDataVencimentoParcela";
            this.cbDataVencimentoParcela.Size = new System.Drawing.Size(15, 14);
            this.cbDataVencimentoParcela.TabIndex = 16;
            this.cbDataVencimentoParcela.UseVisualStyleBackColor = true;
            this.cbDataVencimentoParcela.CheckedChanged += new System.EventHandler(this.CbDataVencimentoParcela_CheckedChanged);
            // 
            // cbValorConta
            // 
            this.cbValorConta.AutoSize = true;
            this.cbValorConta.Location = new System.Drawing.Point(171, 118);
            this.cbValorConta.Name = "cbValorConta";
            this.cbValorConta.Size = new System.Drawing.Size(15, 14);
            this.cbValorConta.TabIndex = 17;
            this.cbValorConta.UseVisualStyleBackColor = true;
            this.cbValorConta.CheckedChanged += new System.EventHandler(this.CbValorConta_CheckedChanged);
            // 
            // dbValorFinal
            // 
            this.dbValorFinal.Enabled = false;
            this.dbValorFinal.Location = new System.Drawing.Point(94, 115);
            this.dbValorFinal.Name = "dbValorFinal";
            this.dbValorFinal.Size = new System.Drawing.Size(70, 22);
            this.dbValorFinal.TabIndex = 5;
            this.dbValorFinal.Valor = new decimal(new int[] {
            99999900,
            0,
            0,
            131072});
            // 
            // dbValorInicial
            // 
            this.dbValorInicial.Enabled = false;
            this.dbValorInicial.Location = new System.Drawing.Point(9, 115);
            this.dbValorInicial.Name = "dbValorInicial";
            this.dbValorInicial.Size = new System.Drawing.Size(70, 22);
            this.dbValorInicial.TabIndex = 3;
            this.dbValorInicial.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // buscaOperacao
            // 
            this.buscaOperacao.Location = new System.Drawing.Point(3, 55);
            this.buscaOperacao.Margin = new System.Windows.Forms.Padding(0);
            this.buscaOperacao.Name = "buscaOperacao";
            this.buscaOperacao.Size = new System.Drawing.Size(442, 39);
            this.buscaOperacao.TabIndex = 1;
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Cliente";
            this.buscaPessoa.Location = new System.Drawing.Point(3, 16);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa.TabIndex = 0;
            // 
            // fmBuscaContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 574);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbFiltros);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 612);
            this.Name = "fmBuscaContaReceber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de contas a receber";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaContaReceber_KeyDown);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private Controls.DecimalBox dbValorFinal;
        private Controls.DecimalBox dbValorInicial;
        private System.Windows.Forms.Label lbValorInicial;
        private Controls.BuscaOperacao buscaOperacao;
        private Controls.BuscaPessoa buscaPessoa;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroInicial;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroFinal;
        private System.Windows.Forms.Label lbADataVencimentoParcela;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoFinal;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoInicial;
        private System.Windows.Forms.Label lbDataVencimento;
        private System.Windows.Forms.Label lbADataCadastro;
        private System.Windows.Forms.Label lbAValorConta;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorFinal;
        private System.Windows.Forms.CheckBox cbValorConta;
        private System.Windows.Forms.CheckBox cbDataVencimentoParcela;
        private System.Windows.Forms.CheckBox cbDataCadastro;
    }
}