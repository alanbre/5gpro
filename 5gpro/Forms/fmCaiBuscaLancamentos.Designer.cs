namespace _5gpro.Forms
{
    partial class fmCaiBuscaLancamentos
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
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.gbLançamentos = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.dgvtbcDataLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCodigoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscaPlanoContaCaixa = new _5gpro.Controls.BuscaPlanoContaCaixa();
            this.buscaCaixa = new _5gpro.Controls.BuscaCaixa();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.gbFiltros.SuspendLayout();
            this.gbLançamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.dtpDataFinal);
            this.gbFiltros.Controls.Add(this.dtpDataInicial);
            this.gbFiltros.Controls.Add(this.btPesquisar);
            this.gbFiltros.Controls.Add(this.buscaPlanoContaCaixa);
            this.gbFiltros.Controls.Add(this.buscaCaixa);
            this.gbFiltros.Controls.Add(this.lbDataFinal);
            this.gbFiltros.Controls.Add(this.lbDataInicial);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1128, 103);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(270, 68);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Location = new System.Drawing.Point(368, 16);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(52, 13);
            this.lbDataFinal.TabIndex = 3;
            this.lbDataFinal.Text = "Data final";
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Location = new System.Drawing.Point(270, 16);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(57, 13);
            this.lbDataInicial.TabIndex = 1;
            this.lbDataInicial.Text = "Data incial";
            // 
            // gbLançamentos
            // 
            this.gbLançamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLançamentos.Controls.Add(this.dgvDados);
            this.gbLançamentos.Location = new System.Drawing.Point(12, 121);
            this.gbLançamentos.Name = "gbLançamentos";
            this.gbLançamentos.Size = new System.Drawing.Size(1128, 416);
            this.gbLançamentos.TabIndex = 1;
            this.gbLançamentos.TabStop = false;
            this.gbLançamentos.Text = "Lançamentos";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcDataLancamento,
            this.dgvtbcValor,
            this.dgvtbcDocumento,
            this.dgvtbcCaixa,
            this.dgvtbcCodigoConta,
            this.dgvtbcConta});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDados.Location = new System.Drawing.Point(3, 16);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1122, 397);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.TabStop = false;
            // 
            // dgvtbcDataLancamento
            // 
            dataGridViewCellStyle2.Format = "dd/MM/aaaa";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvtbcDataLancamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtbcDataLancamento.HeaderText = "Data";
            this.dgvtbcDataLancamento.Name = "dgvtbcDataLancamento";
            this.dgvtbcDataLancamento.ReadOnly = true;
            // 
            // dgvtbcValor
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvtbcValor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtbcValor.HeaderText = "Valor";
            this.dgvtbcValor.Name = "dgvtbcValor";
            this.dgvtbcValor.ReadOnly = true;
            // 
            // dgvtbcDocumento
            // 
            this.dgvtbcDocumento.HeaderText = "Documento";
            this.dgvtbcDocumento.Name = "dgvtbcDocumento";
            this.dgvtbcDocumento.ReadOnly = true;
            // 
            // dgvtbcCaixa
            // 
            this.dgvtbcCaixa.HeaderText = "Caixa";
            this.dgvtbcCaixa.Name = "dgvtbcCaixa";
            this.dgvtbcCaixa.ReadOnly = true;
            // 
            // dgvtbcCodigoConta
            // 
            this.dgvtbcCodigoConta.HeaderText = "Código conta";
            this.dgvtbcCodigoConta.Name = "dgvtbcCodigoConta";
            this.dgvtbcCodigoConta.ReadOnly = true;
            // 
            // dgvtbcConta
            // 
            this.dgvtbcConta.HeaderText = "Conta";
            this.dgvtbcConta.Name = "dgvtbcConta";
            this.dgvtbcConta.ReadOnly = true;
            // 
            // buscaPlanoContaCaixa
            // 
            this.buscaPlanoContaCaixa.BackColor = System.Drawing.Color.White;
            this.buscaPlanoContaCaixa.Entrada = true;
            this.buscaPlanoContaCaixa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscaPlanoContaCaixa.LabelText = "Conta caixa";
            this.buscaPlanoContaCaixa.Location = new System.Drawing.Point(3, 52);
            this.buscaPlanoContaCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPlanoContaCaixa.Name = "buscaPlanoContaCaixa";
            this.buscaPlanoContaCaixa.Saida = true;
            this.buscaPlanoContaCaixa.Size = new System.Drawing.Size(264, 39);
            this.buscaPlanoContaCaixa.TabIndex = 5;
            // 
            // buscaCaixa
            // 
            this.buscaCaixa.BackColor = System.Drawing.Color.White;
            this.buscaCaixa.Location = new System.Drawing.Point(3, 13);
            this.buscaCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCaixa.Name = "buscaCaixa";
            this.buscaCaixa.Size = new System.Drawing.Size(264, 39);
            this.buscaCaixa.TabIndex = 0;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CustomFormat = "dd/MM/yyyy";
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicial.Location = new System.Drawing.Point(270, 32);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataInicial.TabIndex = 7;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFinal.Location = new System.Drawing.Point(371, 32);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataFinal.TabIndex = 8;
            // 
            // fmCaiBuscaLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 549);
            this.Controls.Add(this.gbLançamentos);
            this.Controls.Add(this.gbFiltros);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "fmCaiBuscaLancamentos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Lançamentos do caixa";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbLançamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Button btPesquisar;
        private Controls.BuscaPlanoContaCaixa buscaPlanoContaCaixa;
        private Controls.BuscaCaixa buscaCaixa;
        private System.Windows.Forms.GroupBox gbLançamentos;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcConta;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
    }
}