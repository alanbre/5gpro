namespace _5gpro.Forms
{
    partial class fmCarQuitacaoConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.tbCodigoConta = new System.Windows.Forms.TextBox();
            this.lbCodigoConta = new System.Windows.Forms.Label();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.lbADataVencimentoParcela = new System.Windows.Forms.Label();
            this.dtpDataVencimentoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataVencimentoInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataVencimento = new System.Windows.Forms.Label();
            this.lbADataCadastro = new System.Windows.Forms.Label();
            this.dtpDataCadastroFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataCadastroInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.lbAValorConta = new System.Windows.Forms.Label();
            this.dbValorFinal = new _5gpro.Controls.DecimalBox();
            this.dbValorInicial = new _5gpro.Controls.DecimalBox();
            this.lbValorInicial = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCodigoParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataQuitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPagamento = new System.Windows.Forms.GroupBox();
            this.lbQtdParcelasSelecionadas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbPesquisa.SuspendLayout();
            this.gbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.gbPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPesquisa.Controls.Add(this.btPesquisar);
            this.gbPesquisa.Controls.Add(this.lbAValorConta);
            this.gbPesquisa.Controls.Add(this.lbADataVencimentoParcela);
            this.gbPesquisa.Controls.Add(this.dbValorFinal);
            this.gbPesquisa.Controls.Add(this.buscaPessoa);
            this.gbPesquisa.Controls.Add(this.dbValorInicial);
            this.gbPesquisa.Controls.Add(this.dtpDataVencimentoFinal);
            this.gbPesquisa.Controls.Add(this.lbValorInicial);
            this.gbPesquisa.Controls.Add(this.tbCodigoConta);
            this.gbPesquisa.Controls.Add(this.dtpDataVencimentoInicial);
            this.gbPesquisa.Controls.Add(this.lbCodigoConta);
            this.gbPesquisa.Controls.Add(this.lbDataVencimento);
            this.gbPesquisa.Controls.Add(this.lbDataCadastro);
            this.gbPesquisa.Controls.Add(this.lbADataCadastro);
            this.gbPesquisa.Controls.Add(this.dtpDataCadastroInicial);
            this.gbPesquisa.Controls.Add(this.dtpDataCadastroFinal);
            this.gbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(927, 105);
            this.gbPesquisa.TabIndex = 0;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisa";
            // 
            // tbCodigoConta
            // 
            this.tbCodigoConta.Location = new System.Drawing.Point(9, 32);
            this.tbCodigoConta.Name = "tbCodigoConta";
            this.tbCodigoConta.Size = new System.Drawing.Size(66, 20);
            this.tbCodigoConta.TabIndex = 3;
            // 
            // lbCodigoConta
            // 
            this.lbCodigoConta.AutoSize = true;
            this.lbCodigoConta.Location = new System.Drawing.Point(6, 16);
            this.lbCodigoConta.Name = "lbCodigoConta";
            this.lbCodigoConta.Size = new System.Drawing.Size(35, 13);
            this.lbCodigoConta.TabIndex = 2;
            this.lbCodigoConta.Text = "Conta";
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Cliente";
            this.buscaPessoa.Location = new System.Drawing.Point(3, 55);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa.TabIndex = 5;
            // 
            // lbADataVencimentoParcela
            // 
            this.lbADataVencimentoParcela.AutoSize = true;
            this.lbADataVencimentoParcela.Location = new System.Drawing.Point(556, 74);
            this.lbADataVencimentoParcela.Margin = new System.Windows.Forms.Padding(0);
            this.lbADataVencimentoParcela.Name = "lbADataVencimentoParcela";
            this.lbADataVencimentoParcela.Size = new System.Drawing.Size(13, 13);
            this.lbADataVencimentoParcela.TabIndex = 16;
            this.lbADataVencimentoParcela.Text = "a";
            // 
            // dtpDataVencimentoFinal
            // 
            this.dtpDataVencimentoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoFinal.Location = new System.Drawing.Point(570, 71);
            this.dtpDataVencimentoFinal.Name = "dtpDataVencimentoFinal";
            this.dtpDataVencimentoFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoFinal.TabIndex = 19;
            // 
            // dtpDataVencimentoInicial
            // 
            this.dtpDataVencimentoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoInicial.Location = new System.Drawing.Point(459, 71);
            this.dtpDataVencimentoInicial.Name = "dtpDataVencimentoInicial";
            this.dtpDataVencimentoInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVencimentoInicial.TabIndex = 17;
            // 
            // lbDataVencimento
            // 
            this.lbDataVencimento.AutoSize = true;
            this.lbDataVencimento.Location = new System.Drawing.Point(495, 55);
            this.lbDataVencimento.Name = "lbDataVencimento";
            this.lbDataVencimento.Size = new System.Drawing.Size(126, 13);
            this.lbDataVencimento.TabIndex = 18;
            this.lbDataVencimento.Text = "Data vencimento parcela";
            // 
            // lbADataCadastro
            // 
            this.lbADataCadastro.AutoSize = true;
            this.lbADataCadastro.Location = new System.Drawing.Point(555, 35);
            this.lbADataCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.lbADataCadastro.Name = "lbADataCadastro";
            this.lbADataCadastro.Size = new System.Drawing.Size(13, 13);
            this.lbADataCadastro.TabIndex = 12;
            this.lbADataCadastro.Text = "a";
            // 
            // dtpDataCadastroFinal
            // 
            this.dtpDataCadastroFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroFinal.Location = new System.Drawing.Point(569, 32);
            this.dtpDataCadastroFinal.Name = "dtpDataCadastroFinal";
            this.dtpDataCadastroFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadastroFinal.TabIndex = 15;
            // 
            // dtpDataCadastroInicial
            // 
            this.dtpDataCadastroInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastroInicial.Location = new System.Drawing.Point(458, 32);
            this.dtpDataCadastroInicial.Name = "dtpDataCadastroInicial";
            this.dtpDataCadastroInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataCadastroInicial.TabIndex = 13;
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Location = new System.Drawing.Point(525, 16);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(74, 13);
            this.lbDataCadastro.TabIndex = 14;
            this.lbDataCadastro.Text = "Data cadastro";
            // 
            // lbAValorConta
            // 
            this.lbAValorConta.AutoSize = true;
            this.lbAValorConta.Location = new System.Drawing.Point(744, 35);
            this.lbAValorConta.Margin = new System.Windows.Forms.Padding(0);
            this.lbAValorConta.Name = "lbAValorConta";
            this.lbAValorConta.Size = new System.Drawing.Size(13, 13);
            this.lbAValorConta.TabIndex = 16;
            this.lbAValorConta.Text = "a";
            // 
            // dbValorFinal
            // 
            this.dbValorFinal.Location = new System.Drawing.Point(758, 32);
            this.dbValorFinal.Name = "dbValorFinal";
            this.dbValorFinal.Size = new System.Drawing.Size(70, 22);
            this.dbValorFinal.TabIndex = 15;
            this.dbValorFinal.Valor = new decimal(new int[] {
            99999900,
            0,
            0,
            131072});
            // 
            // dbValorInicial
            // 
            this.dbValorInicial.Location = new System.Drawing.Point(673, 32);
            this.dbValorInicial.Name = "dbValorInicial";
            this.dbValorInicial.Size = new System.Drawing.Size(70, 22);
            this.dbValorInicial.TabIndex = 14;
            this.dbValorInicial.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbValorInicial
            // 
            this.lbValorInicial.AutoSize = true;
            this.lbValorInicial.Location = new System.Drawing.Point(714, 16);
            this.lbValorInicial.Name = "lbValorInicial";
            this.lbValorInicial.Size = new System.Drawing.Size(76, 13);
            this.lbValorInicial.TabIndex = 13;
            this.lbValorInicial.Text = "Valor da conta";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(673, 68);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 20;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // gbParcelas
            // 
            this.gbParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParcelas.Controls.Add(this.dgvParcelas);
            this.gbParcelas.Location = new System.Drawing.Point(12, 123);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(928, 340);
            this.gbParcelas.TabIndex = 1;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParcelas.BackgroundColor = System.Drawing.Color.White;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigoConta,
            this.dgvtbcCodigoParcela,
            this.dgvtbcDataVencimento,
            this.dgvtbcValor,
            this.dgvtbcMulta,
            this.dgvtbcJuros,
            this.dgvtbcAcrescimo,
            this.dgvtbcValorFinal,
            this.dgvtbcDataQuitacao});
            this.dgvParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParcelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParcelas.Location = new System.Drawing.Point(3, 16);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(922, 321);
            this.dgvParcelas.TabIndex = 0;
            this.dgvParcelas.TabStop = false;
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
            // dgvtbcValorFinal
            // 
            this.dgvtbcValorFinal.HeaderText = "Valor final";
            this.dgvtbcValorFinal.Name = "dgvtbcValorFinal";
            this.dgvtbcValorFinal.ReadOnly = true;
            // 
            // dgvtbcDataQuitacao
            // 
            this.dgvtbcDataQuitacao.HeaderText = "Data quitação";
            this.dgvtbcDataQuitacao.Name = "dgvtbcDataQuitacao";
            this.dgvtbcDataQuitacao.ReadOnly = true;
            // 
            // gbPagamento
            // 
            this.gbPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPagamento.Controls.Add(this.textBox1);
            this.gbPagamento.Controls.Add(this.lbQtdParcelasSelecionadas);
            this.gbPagamento.Location = new System.Drawing.Point(12, 469);
            this.gbPagamento.Name = "gbPagamento";
            this.gbPagamento.Size = new System.Drawing.Size(928, 132);
            this.gbPagamento.TabIndex = 2;
            this.gbPagamento.TabStop = false;
            this.gbPagamento.Text = "Pagamento";
            // 
            // lbQtdParcelasSelecionadas
            // 
            this.lbQtdParcelasSelecionadas.AutoSize = true;
            this.lbQtdParcelasSelecionadas.Location = new System.Drawing.Point(6, 16);
            this.lbQtdParcelasSelecionadas.Name = "lbQtdParcelasSelecionadas";
            this.lbQtdParcelasSelecionadas.Size = new System.Drawing.Size(19, 13);
            this.lbQtdParcelasSelecionadas.TabIndex = 0;
            this.lbQtdParcelasSelecionadas.Text = "N°";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 1;
            // 
            // fmCarQuitacaoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 613);
            this.Controls.Add(this.gbPagamento);
            this.Controls.Add(this.gbParcelas);
            this.Controls.Add(this.gbPesquisa);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(968, 651);
            this.Name = "fmCarQuitacaoConta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Quitação de contas a receber";
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.gbParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.gbPagamento.ResumeLayout(false);
            this.gbPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.TextBox tbCodigoConta;
        private System.Windows.Forms.Label lbCodigoConta;
        private Controls.BuscaPessoa buscaPessoa;
        private System.Windows.Forms.Label lbADataVencimentoParcela;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoFinal;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoInicial;
        private System.Windows.Forms.Label lbDataVencimento;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.Label lbADataCadastro;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroInicial;
        private System.Windows.Forms.DateTimePicker dtpDataCadastroFinal;
        private System.Windows.Forms.Label lbAValorConta;
        private Controls.DecimalBox dbValorFinal;
        private Controls.DecimalBox dbValorInicial;
        private System.Windows.Forms.Label lbValorInicial;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataQuitacao;
        private System.Windows.Forms.GroupBox gbPagamento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbQtdParcelasSelecionadas;
    }
}