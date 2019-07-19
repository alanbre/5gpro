namespace _5gpro.Forms
{
    partial class fmCapReplicarConta
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
            this.gbDadosReplicação = new System.Windows.Forms.GroupBox();
            this.gbReplicacao = new System.Windows.Forms.GroupBox();
            this.btReplicar = new System.Windows.Forms.Button();
            this.cbTempo = new System.Windows.Forms.ComboBox();
            this.lbIntervalo = new System.Windows.Forms.Label();
            this.tbIntervalo = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbCodigoConta = new System.Windows.Forms.TextBox();
            this.lbCodigoConta = new System.Windows.Forms.Label();
            this.lbDescontoConta = new System.Windows.Forms.Label();
            this.lbValorTotalConta = new System.Windows.Forms.Label();
            this.lbAcrescimoConta = new System.Windows.Forms.Label();
            this.lbValorOriginalConta = new System.Windows.Forms.Label();
            this.lbMultaConta = new System.Windows.Forms.Label();
            this.lbJurosConta = new System.Windows.Forms.Label();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.dgvtbcDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPrimeiroVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbValorFinalConta = new _5gpro.Controls.DecimalBox();
            this.dbDescontoConta = new _5gpro.Controls.DecimalBox();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.dbAcrescimoConta = new _5gpro.Controls.DecimalBox();
            this.dbValorOriginalConta = new _5gpro.Controls.DecimalBox();
            this.dbMultaConta = new _5gpro.Controls.DecimalBox();
            this.dbJurosConta = new _5gpro.Controls.DecimalBox();
            this.gbDadosReplicação.SuspendLayout();
            this.gbReplicacao.SuspendLayout();
            this.gbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosReplicação
            // 
            this.gbDadosReplicação.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosReplicação.Controls.Add(this.gbReplicacao);
            this.gbDadosReplicação.Controls.Add(this.tbCodigoConta);
            this.gbDadosReplicação.Controls.Add(this.lbCodigoConta);
            this.gbDadosReplicação.Controls.Add(this.dbValorFinalConta);
            this.gbDadosReplicação.Controls.Add(this.lbDescontoConta);
            this.gbDadosReplicação.Controls.Add(this.lbValorTotalConta);
            this.gbDadosReplicação.Controls.Add(this.dbDescontoConta);
            this.gbDadosReplicação.Controls.Add(this.buscaPessoa);
            this.gbDadosReplicação.Controls.Add(this.lbAcrescimoConta);
            this.gbDadosReplicação.Controls.Add(this.lbValorOriginalConta);
            this.gbDadosReplicação.Controls.Add(this.dbAcrescimoConta);
            this.gbDadosReplicação.Controls.Add(this.dbValorOriginalConta);
            this.gbDadosReplicação.Controls.Add(this.lbMultaConta);
            this.gbDadosReplicação.Controls.Add(this.dbMultaConta);
            this.gbDadosReplicação.Controls.Add(this.dbJurosConta);
            this.gbDadosReplicação.Controls.Add(this.lbJurosConta);
            this.gbDadosReplicação.Location = new System.Drawing.Point(12, 12);
            this.gbDadosReplicação.Name = "gbDadosReplicação";
            this.gbDadosReplicação.Size = new System.Drawing.Size(933, 123);
            this.gbDadosReplicação.TabIndex = 0;
            this.gbDadosReplicação.TabStop = false;
            this.gbDadosReplicação.Text = "Dados para replicação";
            // 
            // gbReplicacao
            // 
            this.gbReplicacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReplicacao.Controls.Add(this.btReplicar);
            this.gbReplicacao.Controls.Add(this.cbTempo);
            this.gbReplicacao.Controls.Add(this.lbIntervalo);
            this.gbReplicacao.Controls.Add(this.tbIntervalo);
            this.gbReplicacao.Controls.Add(this.lbQuantidade);
            this.gbReplicacao.Controls.Add(this.tbQuantidade);
            this.gbReplicacao.Location = new System.Drawing.Point(668, 16);
            this.gbReplicacao.Name = "gbReplicacao";
            this.gbReplicacao.Size = new System.Drawing.Size(259, 101);
            this.gbReplicacao.TabIndex = 15;
            this.gbReplicacao.TabStop = false;
            this.gbReplicacao.Text = "Replicação";
            // 
            // btReplicar
            // 
            this.btReplicar.Location = new System.Drawing.Point(9, 59);
            this.btReplicar.Name = "btReplicar";
            this.btReplicar.Size = new System.Drawing.Size(75, 23);
            this.btReplicar.TabIndex = 5;
            this.btReplicar.Text = "Replicar";
            this.btReplicar.UseVisualStyleBackColor = true;
            this.btReplicar.Click += new System.EventHandler(this.BtReplicar_Click);
            // 
            // cbTempo
            // 
            this.cbTempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTempo.Items.AddRange(new object[] {
            "dia(s)",
            "mes(es)"});
            this.cbTempo.Location = new System.Drawing.Point(175, 33);
            this.cbTempo.Name = "cbTempo";
            this.cbTempo.Size = new System.Drawing.Size(69, 21);
            this.cbTempo.TabIndex = 4;
            // 
            // lbIntervalo
            // 
            this.lbIntervalo.AutoSize = true;
            this.lbIntervalo.Location = new System.Drawing.Point(112, 17);
            this.lbIntervalo.Name = "lbIntervalo";
            this.lbIntervalo.Size = new System.Drawing.Size(48, 13);
            this.lbIntervalo.TabIndex = 2;
            this.lbIntervalo.Text = "Intervalo";
            // 
            // tbIntervalo
            // 
            this.tbIntervalo.Location = new System.Drawing.Point(115, 33);
            this.tbIntervalo.Name = "tbIntervalo";
            this.tbIntervalo.Size = new System.Drawing.Size(54, 20);
            this.tbIntervalo.TabIndex = 3;
            this.tbIntervalo.Leave += new System.EventHandler(this.TbIntervalo_Leave);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(6, 19);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(89, 13);
            this.lbQuantidade.TabIndex = 0;
            this.lbQuantidade.Text = "Qtd. Replicações";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(9, 33);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.tbQuantidade.TabIndex = 1;
            this.tbQuantidade.Leave += new System.EventHandler(this.TbQuantidade_Leave);
            // 
            // tbCodigoConta
            // 
            this.tbCodigoConta.Enabled = false;
            this.tbCodigoConta.Location = new System.Drawing.Point(6, 33);
            this.tbCodigoConta.Name = "tbCodigoConta";
            this.tbCodigoConta.Size = new System.Drawing.Size(58, 20);
            this.tbCodigoConta.TabIndex = 1;
            // 
            // lbCodigoConta
            // 
            this.lbCodigoConta.AutoSize = true;
            this.lbCodigoConta.Location = new System.Drawing.Point(3, 17);
            this.lbCodigoConta.Name = "lbCodigoConta";
            this.lbCodigoConta.Size = new System.Drawing.Size(61, 13);
            this.lbCodigoConta.TabIndex = 0;
            this.lbCodigoConta.Text = "Conta base";
            // 
            // lbDescontoConta
            // 
            this.lbDescontoConta.AutoSize = true;
            this.lbDescontoConta.Location = new System.Drawing.Point(357, 68);
            this.lbDescontoConta.Name = "lbDescontoConta";
            this.lbDescontoConta.Size = new System.Drawing.Size(53, 13);
            this.lbDescontoConta.TabIndex = 11;
            this.lbDescontoConta.Text = "Desconto";
            // 
            // lbValorTotalConta
            // 
            this.lbValorTotalConta.AutoSize = true;
            this.lbValorTotalConta.Location = new System.Drawing.Point(445, 66);
            this.lbValorTotalConta.Name = "lbValorTotalConta";
            this.lbValorTotalConta.Size = new System.Drawing.Size(54, 13);
            this.lbValorTotalConta.TabIndex = 13;
            this.lbValorTotalConta.Text = "Valor total";
            // 
            // lbAcrescimoConta
            // 
            this.lbAcrescimoConta.AutoSize = true;
            this.lbAcrescimoConta.Location = new System.Drawing.Point(269, 66);
            this.lbAcrescimoConta.Name = "lbAcrescimoConta";
            this.lbAcrescimoConta.Size = new System.Drawing.Size(56, 13);
            this.lbAcrescimoConta.TabIndex = 9;
            this.lbAcrescimoConta.Text = "Acréscimo";
            // 
            // lbValorOriginalConta
            // 
            this.lbValorOriginalConta.AutoSize = true;
            this.lbValorOriginalConta.Location = new System.Drawing.Point(6, 66);
            this.lbValorOriginalConta.Name = "lbValorOriginalConta";
            this.lbValorOriginalConta.Size = new System.Drawing.Size(67, 13);
            this.lbValorOriginalConta.TabIndex = 3;
            this.lbValorOriginalConta.Text = "Valor original";
            // 
            // lbMultaConta
            // 
            this.lbMultaConta.AutoSize = true;
            this.lbMultaConta.Location = new System.Drawing.Point(94, 66);
            this.lbMultaConta.Name = "lbMultaConta";
            this.lbMultaConta.Size = new System.Drawing.Size(33, 13);
            this.lbMultaConta.TabIndex = 5;
            this.lbMultaConta.Text = "Multa";
            // 
            // lbJurosConta
            // 
            this.lbJurosConta.AutoSize = true;
            this.lbJurosConta.Location = new System.Drawing.Point(181, 66);
            this.lbJurosConta.Name = "lbJurosConta";
            this.lbJurosConta.Size = new System.Drawing.Size(32, 13);
            this.lbJurosConta.TabIndex = 7;
            this.lbJurosConta.Text = "Juros";
            // 
            // gbResultado
            // 
            this.gbResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResultado.Controls.Add(this.dgvContas);
            this.gbResultado.Location = new System.Drawing.Point(12, 141);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(933, 382);
            this.gbResultado.TabIndex = 1;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado da replicação";
            // 
            // btConfirmar
            // 
            this.btConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btConfirmar.Location = new System.Drawing.Point(12, 529);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 2;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.BtConfirmar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelar.Location = new System.Drawing.Point(93, 529);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
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
            this.dgvtbcDescricao,
            this.dgvtbcFornecedor,
            this.dgvtbcDataCadastro,
            this.dgvtbcPrimeiroVencimento,
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
            this.dgvContas.Size = new System.Drawing.Size(927, 363);
            this.dgvContas.TabIndex = 1;
            this.dgvContas.TabStop = false;
            // 
            // dgvtbcDescricao
            // 
            this.dgvtbcDescricao.HeaderText = "Descrição";
            this.dgvtbcDescricao.Name = "dgvtbcDescricao";
            this.dgvtbcDescricao.ReadOnly = true;
            this.dgvtbcDescricao.Width = 120;
            // 
            // dgvtbcFornecedor
            // 
            this.dgvtbcFornecedor.HeaderText = "Fornecedor";
            this.dgvtbcFornecedor.Name = "dgvtbcFornecedor";
            this.dgvtbcFornecedor.ReadOnly = true;
            this.dgvtbcFornecedor.Width = 120;
            // 
            // dgvtbcDataCadastro
            // 
            this.dgvtbcDataCadastro.HeaderText = "Data cad.";
            this.dgvtbcDataCadastro.Name = "dgvtbcDataCadastro";
            this.dgvtbcDataCadastro.ReadOnly = true;
            // 
            // dgvtbcPrimeiroVencimento
            // 
            this.dgvtbcPrimeiroVencimento.HeaderText = "Dt. 1° Venc";
            this.dgvtbcPrimeiroVencimento.Name = "dgvtbcPrimeiroVencimento";
            this.dgvtbcPrimeiroVencimento.ReadOnly = true;
            // 
            // dgvtbcValorOriginal
            // 
            this.dgvtbcValorOriginal.HeaderText = "Valor original";
            this.dgvtbcValorOriginal.Name = "dgvtbcValorOriginal";
            this.dgvtbcValorOriginal.ReadOnly = true;
            this.dgvtbcValorOriginal.Width = 80;
            // 
            // dgvtbcMulta
            // 
            this.dgvtbcMulta.HeaderText = "Multa";
            this.dgvtbcMulta.Name = "dgvtbcMulta";
            this.dgvtbcMulta.ReadOnly = true;
            this.dgvtbcMulta.Width = 80;
            // 
            // dgvtbcJuros
            // 
            this.dgvtbcJuros.HeaderText = "Juros";
            this.dgvtbcJuros.Name = "dgvtbcJuros";
            this.dgvtbcJuros.ReadOnly = true;
            this.dgvtbcJuros.Width = 80;
            // 
            // dgvtbcAcrescimo
            // 
            this.dgvtbcAcrescimo.HeaderText = "Acréscimo";
            this.dgvtbcAcrescimo.Name = "dgvtbcAcrescimo";
            this.dgvtbcAcrescimo.ReadOnly = true;
            this.dgvtbcAcrescimo.Width = 80;
            // 
            // dgvtbcDesconto
            // 
            this.dgvtbcDesconto.HeaderText = "Desconto";
            this.dgvtbcDesconto.Name = "dgvtbcDesconto";
            this.dgvtbcDesconto.ReadOnly = true;
            this.dgvtbcDesconto.Width = 80;
            // 
            // dgvtbcValorFinal
            // 
            this.dgvtbcValorFinal.HeaderText = "Valor final";
            this.dgvtbcValorFinal.Name = "dgvtbcValorFinal";
            this.dgvtbcValorFinal.ReadOnly = true;
            this.dgvtbcValorFinal.Width = 80;
            // 
            // dbValorFinalConta
            // 
            this.dbValorFinalConta.Enabled = false;
            this.dbValorFinalConta.Location = new System.Drawing.Point(445, 82);
            this.dbValorFinalConta.Name = "dbValorFinalConta";
            this.dbValorFinalConta.Size = new System.Drawing.Size(82, 20);
            this.dbValorFinalConta.TabIndex = 14;
            this.dbValorFinalConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbDescontoConta
            // 
            this.dbDescontoConta.Enabled = false;
            this.dbDescontoConta.Location = new System.Drawing.Point(357, 82);
            this.dbDescontoConta.Name = "dbDescontoConta";
            this.dbDescontoConta.Size = new System.Drawing.Size(82, 22);
            this.dbDescontoConta.TabIndex = 12;
            this.dbDescontoConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.Enabled = false;
            this.buscaPessoa.LabelText = "Fornecedor";
            this.buscaPessoa.Location = new System.Drawing.Point(67, 16);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(343, 39);
            this.buscaPessoa.TabIndex = 2;
            // 
            // dbAcrescimoConta
            // 
            this.dbAcrescimoConta.Enabled = false;
            this.dbAcrescimoConta.Location = new System.Drawing.Point(269, 82);
            this.dbAcrescimoConta.Name = "dbAcrescimoConta";
            this.dbAcrescimoConta.Size = new System.Drawing.Size(82, 22);
            this.dbAcrescimoConta.TabIndex = 10;
            this.dbAcrescimoConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbValorOriginalConta
            // 
            this.dbValorOriginalConta.Enabled = false;
            this.dbValorOriginalConta.Location = new System.Drawing.Point(6, 82);
            this.dbValorOriginalConta.Name = "dbValorOriginalConta";
            this.dbValorOriginalConta.Size = new System.Drawing.Size(82, 20);
            this.dbValorOriginalConta.TabIndex = 4;
            this.dbValorOriginalConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbMultaConta
            // 
            this.dbMultaConta.Enabled = false;
            this.dbMultaConta.Location = new System.Drawing.Point(94, 82);
            this.dbMultaConta.Name = "dbMultaConta";
            this.dbMultaConta.Size = new System.Drawing.Size(82, 20);
            this.dbMultaConta.TabIndex = 6;
            this.dbMultaConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbJurosConta
            // 
            this.dbJurosConta.Enabled = false;
            this.dbJurosConta.Location = new System.Drawing.Point(181, 82);
            this.dbJurosConta.Name = "dbJurosConta";
            this.dbJurosConta.Size = new System.Drawing.Size(82, 20);
            this.dbJurosConta.TabIndex = 8;
            this.dbJurosConta.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // fmCapReplicarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 561);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbDadosReplicação);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(973, 600);
            this.Name = "fmCapReplicarConta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Replicação de contas a pagar";
            this.Load += new System.EventHandler(this.FmCapReplicarConta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCapReplicarConta_KeyDown);
            this.gbDadosReplicação.ResumeLayout(false);
            this.gbDadosReplicação.PerformLayout();
            this.gbReplicacao.ResumeLayout(false);
            this.gbReplicacao.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosReplicação;
        private Controls.BuscaPessoa buscaPessoa;
        private Controls.DecimalBox dbValorFinalConta;
        private System.Windows.Forms.Label lbDescontoConta;
        private System.Windows.Forms.Label lbValorTotalConta;
        private Controls.DecimalBox dbDescontoConta;
        private System.Windows.Forms.Label lbAcrescimoConta;
        private System.Windows.Forms.Label lbValorOriginalConta;
        private Controls.DecimalBox dbAcrescimoConta;
        private Controls.DecimalBox dbValorOriginalConta;
        private System.Windows.Forms.Label lbMultaConta;
        private Controls.DecimalBox dbMultaConta;
        private Controls.DecimalBox dbJurosConta;
        private System.Windows.Forms.Label lbJurosConta;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox gbReplicacao;
        private System.Windows.Forms.Label lbIntervalo;
        private System.Windows.Forms.TextBox tbIntervalo;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbCodigoConta;
        private System.Windows.Forms.Label lbCodigoConta;
        private System.Windows.Forms.ComboBox cbTempo;
        private System.Windows.Forms.Button btReplicar;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPrimeiroVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorFinal;
    }
}