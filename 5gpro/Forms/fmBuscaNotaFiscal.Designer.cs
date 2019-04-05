namespace _5gpro.Forms
{
    partial class fmBuscaNotaFiscal
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
            this.gbGridDocumentos = new System.Windows.Forms.GroupBox();
            this.dgvOrcamentos = new System.Windows.Forms.DataGridView();
            this.dgvtbcOrcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCodigoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorTotalItens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescontoTotalItens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescontoOrcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorTotalOrçamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltrosDocumento = new System.Windows.Forms.GroupBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lbAValorTotalDocumento = new System.Windows.Forms.Label();
            this.tbFiltroValorTotalDocumentoInicial = new System.Windows.Forms.TextBox();
            this.tbFiltroValorTotalDocumentoFinal = new System.Windows.Forms.TextBox();
            this.lbFiltroValorTotalDocumento = new System.Windows.Forms.Label();
            this.lbFiltroDataEntradaSaida = new System.Windows.Forms.Label();
            this.lbAFiltroDataEntradaSaida = new System.Windows.Forms.Label();
            this.dtpFiltroDataEntradaSaidaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroDataEntradaSaidaInicial = new System.Windows.Forms.DateTimePicker();
            this.lbFiltroDataEmissao = new System.Windows.Forms.Label();
            this.lbAFiltroDataEmissao = new System.Windows.Forms.Label();
            this.dtpFiltroDataEmissaoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroDataEmissaoInicial = new System.Windows.Forms.DateTimePicker();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.btProcuraCliente = new System.Windows.Forms.Button();
            this.tbCodCliente = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.buscaCidade1 = new _5gpro.Controls.BuscaCidade();
            this.gbGridDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).BeginInit();
            this.gbFiltrosDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGridDocumentos
            // 
            this.gbGridDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridDocumentos.Controls.Add(this.dgvOrcamentos);
            this.gbGridDocumentos.Location = new System.Drawing.Point(12, 192);
            this.gbGridDocumentos.Name = "gbGridDocumentos";
            this.gbGridDocumentos.Size = new System.Drawing.Size(1069, 258);
            this.gbGridDocumentos.TabIndex = 3;
            this.gbGridDocumentos.TabStop = false;
            this.gbGridDocumentos.Text = "Notas fiscais";
            // 
            // dgvOrcamentos
            // 
            this.dgvOrcamentos.AllowUserToAddRows = false;
            this.dgvOrcamentos.AllowUserToDeleteRows = false;
            this.dgvOrcamentos.AllowUserToOrderColumns = true;
            this.dgvOrcamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvOrcamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrcamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrcamentos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcOrcamento,
            this.dgvtbcCodigoPessoa,
            this.dgvtbcNome,
            this.dgvtbcDataCadastro,
            this.dgvtbcDataValidade,
            this.dgvtbcValorTotalItens,
            this.dgvtbcDescontoTotalItens,
            this.dgvtbcDescontoOrcamento,
            this.dgvtbcValorTotalOrçamento});
            this.dgvOrcamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrcamentos.Location = new System.Drawing.Point(10, 19);
            this.dgvOrcamentos.MultiSelect = false;
            this.dgvOrcamentos.Name = "dgvOrcamentos";
            this.dgvOrcamentos.ReadOnly = true;
            this.dgvOrcamentos.RowHeadersVisible = false;
            this.dgvOrcamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrcamentos.Size = new System.Drawing.Size(1053, 233);
            this.dgvOrcamentos.TabIndex = 0;
            this.dgvOrcamentos.TabStop = false;
            // 
            // dgvtbcOrcamento
            // 
            this.dgvtbcOrcamento.HeaderText = "Nota Fiscal";
            this.dgvtbcOrcamento.MinimumWidth = 90;
            this.dgvtbcOrcamento.Name = "dgvtbcOrcamento";
            this.dgvtbcOrcamento.ReadOnly = true;
            this.dgvtbcOrcamento.Width = 90;
            // 
            // dgvtbcCodigoPessoa
            // 
            this.dgvtbcCodigoPessoa.HeaderText = "Cliente";
            this.dgvtbcCodigoPessoa.MinimumWidth = 50;
            this.dgvtbcCodigoPessoa.Name = "dgvtbcCodigoPessoa";
            this.dgvtbcCodigoPessoa.ReadOnly = true;
            this.dgvtbcCodigoPessoa.Width = 50;
            // 
            // dgvtbcNome
            // 
            this.dgvtbcNome.HeaderText = "Nome";
            this.dgvtbcNome.MinimumWidth = 30;
            this.dgvtbcNome.Name = "dgvtbcNome";
            this.dgvtbcNome.ReadOnly = true;
            this.dgvtbcNome.Width = 150;
            // 
            // dgvtbcDataCadastro
            // 
            this.dgvtbcDataCadastro.HeaderText = "Data do cadastro";
            this.dgvtbcDataCadastro.MinimumWidth = 120;
            this.dgvtbcDataCadastro.Name = "dgvtbcDataCadastro";
            this.dgvtbcDataCadastro.ReadOnly = true;
            this.dgvtbcDataCadastro.Width = 120;
            // 
            // dgvtbcDataValidade
            // 
            this.dgvtbcDataValidade.HeaderText = "Data de validade";
            this.dgvtbcDataValidade.MinimumWidth = 120;
            this.dgvtbcDataValidade.Name = "dgvtbcDataValidade";
            this.dgvtbcDataValidade.ReadOnly = true;
            this.dgvtbcDataValidade.Width = 120;
            // 
            // dgvtbcValorTotalItens
            // 
            this.dgvtbcValorTotalItens.HeaderText = "Valor dos itens";
            this.dgvtbcValorTotalItens.MinimumWidth = 50;
            this.dgvtbcValorTotalItens.Name = "dgvtbcValorTotalItens";
            this.dgvtbcValorTotalItens.ReadOnly = true;
            this.dgvtbcValorTotalItens.Width = 110;
            // 
            // dgvtbcDescontoTotalItens
            // 
            this.dgvtbcDescontoTotalItens.HeaderText = "Descontos dos itens";
            this.dgvtbcDescontoTotalItens.MinimumWidth = 50;
            this.dgvtbcDescontoTotalItens.Name = "dgvtbcDescontoTotalItens";
            this.dgvtbcDescontoTotalItens.ReadOnly = true;
            this.dgvtbcDescontoTotalItens.Width = 130;
            // 
            // dgvtbcDescontoOrcamento
            // 
            this.dgvtbcDescontoOrcamento.HeaderText = "Desconto do orçamento";
            this.dgvtbcDescontoOrcamento.MinimumWidth = 50;
            this.dgvtbcDescontoOrcamento.Name = "dgvtbcDescontoOrcamento";
            this.dgvtbcDescontoOrcamento.ReadOnly = true;
            this.dgvtbcDescontoOrcamento.Width = 150;
            // 
            // dgvtbcValorTotalOrçamento
            // 
            this.dgvtbcValorTotalOrçamento.HeaderText = "Total do orçamento";
            this.dgvtbcValorTotalOrçamento.MinimumWidth = 50;
            this.dgvtbcValorTotalOrçamento.Name = "dgvtbcValorTotalOrçamento";
            this.dgvtbcValorTotalOrçamento.ReadOnly = true;
            this.dgvtbcValorTotalOrçamento.Width = 130;
            // 
            // gbFiltrosDocumento
            // 
            this.gbFiltrosDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrosDocumento.Controls.Add(this.buscaCidade1);
            this.gbFiltrosDocumento.Controls.Add(this.btPesquisar);
            this.gbFiltrosDocumento.Controls.Add(this.lbAValorTotalDocumento);
            this.gbFiltrosDocumento.Controls.Add(this.tbFiltroValorTotalDocumentoInicial);
            this.gbFiltrosDocumento.Controls.Add(this.tbFiltroValorTotalDocumentoFinal);
            this.gbFiltrosDocumento.Controls.Add(this.lbFiltroValorTotalDocumento);
            this.gbFiltrosDocumento.Controls.Add(this.lbFiltroDataEntradaSaida);
            this.gbFiltrosDocumento.Controls.Add(this.lbAFiltroDataEntradaSaida);
            this.gbFiltrosDocumento.Controls.Add(this.dtpFiltroDataEntradaSaidaFinal);
            this.gbFiltrosDocumento.Controls.Add(this.dtpFiltroDataEntradaSaidaInicial);
            this.gbFiltrosDocumento.Controls.Add(this.lbFiltroDataEmissao);
            this.gbFiltrosDocumento.Controls.Add(this.lbAFiltroDataEmissao);
            this.gbFiltrosDocumento.Controls.Add(this.dtpFiltroDataEmissaoFinal);
            this.gbFiltrosDocumento.Controls.Add(this.dtpFiltroDataEmissaoInicial);
            this.gbFiltrosDocumento.Controls.Add(this.tbNomeCliente);
            this.gbFiltrosDocumento.Controls.Add(this.btProcuraCliente);
            this.gbFiltrosDocumento.Controls.Add(this.tbCodCliente);
            this.gbFiltrosDocumento.Controls.Add(this.lbCliente);
            this.gbFiltrosDocumento.Location = new System.Drawing.Point(12, 12);
            this.gbFiltrosDocumento.Name = "gbFiltrosDocumento";
            this.gbFiltrosDocumento.Size = new System.Drawing.Size(1068, 174);
            this.gbFiltrosDocumento.TabIndex = 2;
            this.gbFiltrosDocumento.TabStop = false;
            this.gbFiltrosDocumento.Text = "Filtros do documento";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(10, 143);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 40;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // lbAValorTotalDocumento
            // 
            this.lbAValorTotalDocumento.AutoSize = true;
            this.lbAValorTotalDocumento.Location = new System.Drawing.Point(75, 119);
            this.lbAValorTotalDocumento.Name = "lbAValorTotalDocumento";
            this.lbAValorTotalDocumento.Size = new System.Drawing.Size(13, 13);
            this.lbAValorTotalDocumento.TabIndex = 10;
            this.lbAValorTotalDocumento.Text = "a";
            // 
            // tbFiltroValorTotalDocumentoInicial
            // 
            this.tbFiltroValorTotalDocumentoInicial.Location = new System.Drawing.Point(9, 117);
            this.tbFiltroValorTotalDocumentoInicial.MaxLength = 8;
            this.tbFiltroValorTotalDocumentoInicial.Name = "tbFiltroValorTotalDocumentoInicial";
            this.tbFiltroValorTotalDocumentoInicial.Size = new System.Drawing.Size(63, 20);
            this.tbFiltroValorTotalDocumentoInicial.TabIndex = 9;
            this.tbFiltroValorTotalDocumentoInicial.Text = "0,00";
            // 
            // tbFiltroValorTotalDocumentoFinal
            // 
            this.tbFiltroValorTotalDocumentoFinal.Location = new System.Drawing.Point(90, 117);
            this.tbFiltroValorTotalDocumentoFinal.MaxLength = 13;
            this.tbFiltroValorTotalDocumentoFinal.Name = "tbFiltroValorTotalDocumentoFinal";
            this.tbFiltroValorTotalDocumentoFinal.Size = new System.Drawing.Size(63, 20);
            this.tbFiltroValorTotalDocumentoFinal.TabIndex = 11;
            this.tbFiltroValorTotalDocumentoFinal.Text = "999999,00";
            // 
            // lbFiltroValorTotalDocumento
            // 
            this.lbFiltroValorTotalDocumento.AutoSize = true;
            this.lbFiltroValorTotalDocumento.Location = new System.Drawing.Point(7, 96);
            this.lbFiltroValorTotalDocumento.Name = "lbFiltroValorTotalDocumento";
            this.lbFiltroValorTotalDocumento.Size = new System.Drawing.Size(125, 13);
            this.lbFiltroValorTotalDocumento.TabIndex = 8;
            this.lbFiltroValorTotalDocumento.Text = "Valor total do documento";
            // 
            // lbFiltroDataEntradaSaida
            // 
            this.lbFiltroDataEntradaSaida.AutoSize = true;
            this.lbFiltroDataEntradaSaida.Location = new System.Drawing.Point(452, 56);
            this.lbFiltroDataEntradaSaida.Name = "lbFiltroDataEntradaSaida";
            this.lbFiltroDataEntradaSaida.Size = new System.Drawing.Size(122, 13);
            this.lbFiltroDataEntradaSaida.TabIndex = 16;
            this.lbFiltroDataEntradaSaida.Text = "Data de entrada / saída";
            // 
            // lbAFiltroDataEntradaSaida
            // 
            this.lbAFiltroDataEntradaSaida.AutoSize = true;
            this.lbAFiltroDataEntradaSaida.Location = new System.Drawing.Point(561, 77);
            this.lbAFiltroDataEntradaSaida.Name = "lbAFiltroDataEntradaSaida";
            this.lbAFiltroDataEntradaSaida.Size = new System.Drawing.Size(13, 13);
            this.lbAFiltroDataEntradaSaida.TabIndex = 18;
            this.lbAFiltroDataEntradaSaida.Text = "a";
            // 
            // dtpFiltroDataEntradaSaidaFinal
            // 
            this.dtpFiltroDataEntradaSaidaFinal.CustomFormat = "";
            this.dtpFiltroDataEntradaSaidaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataEntradaSaidaFinal.Location = new System.Drawing.Point(580, 73);
            this.dtpFiltroDataEntradaSaidaFinal.Name = "dtpFiltroDataEntradaSaidaFinal";
            this.dtpFiltroDataEntradaSaidaFinal.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataEntradaSaidaFinal.TabIndex = 19;
            this.dtpFiltroDataEntradaSaidaFinal.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFiltroDataEntradaSaidaInicial
            // 
            this.dtpFiltroDataEntradaSaidaInicial.CustomFormat = "";
            this.dtpFiltroDataEntradaSaidaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataEntradaSaidaInicial.Location = new System.Drawing.Point(455, 73);
            this.dtpFiltroDataEntradaSaidaInicial.Name = "dtpFiltroDataEntradaSaidaInicial";
            this.dtpFiltroDataEntradaSaidaInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataEntradaSaidaInicial.TabIndex = 17;
            this.dtpFiltroDataEntradaSaidaInicial.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lbFiltroDataEmissao
            // 
            this.lbFiltroDataEmissao.AutoSize = true;
            this.lbFiltroDataEmissao.Location = new System.Drawing.Point(452, 16);
            this.lbFiltroDataEmissao.Name = "lbFiltroDataEmissao";
            this.lbFiltroDataEmissao.Size = new System.Drawing.Size(89, 13);
            this.lbFiltroDataEmissao.TabIndex = 12;
            this.lbFiltroDataEmissao.Text = "Data de cadastro";
            // 
            // lbAFiltroDataEmissao
            // 
            this.lbAFiltroDataEmissao.AutoSize = true;
            this.lbAFiltroDataEmissao.Location = new System.Drawing.Point(561, 37);
            this.lbAFiltroDataEmissao.Name = "lbAFiltroDataEmissao";
            this.lbAFiltroDataEmissao.Size = new System.Drawing.Size(13, 13);
            this.lbAFiltroDataEmissao.TabIndex = 14;
            this.lbAFiltroDataEmissao.Text = "a";
            // 
            // dtpFiltroDataEmissaoFinal
            // 
            this.dtpFiltroDataEmissaoFinal.CustomFormat = "";
            this.dtpFiltroDataEmissaoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataEmissaoFinal.Location = new System.Drawing.Point(580, 33);
            this.dtpFiltroDataEmissaoFinal.Name = "dtpFiltroDataEmissaoFinal";
            this.dtpFiltroDataEmissaoFinal.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataEmissaoFinal.TabIndex = 15;
            this.dtpFiltroDataEmissaoFinal.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFiltroDataEmissaoInicial
            // 
            this.dtpFiltroDataEmissaoInicial.CustomFormat = "";
            this.dtpFiltroDataEmissaoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataEmissaoInicial.Location = new System.Drawing.Point(455, 33);
            this.dtpFiltroDataEmissaoInicial.Name = "dtpFiltroDataEmissaoInicial";
            this.dtpFiltroDataEmissaoInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataEmissaoInicial.TabIndex = 13;
            this.dtpFiltroDataEmissaoInicial.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNomeCliente.Location = new System.Drawing.Point(100, 72);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(346, 20);
            this.tbNomeCliente.TabIndex = 7;
            this.tbNomeCliente.TabStop = false;
            // 
            // btProcuraCliente
            // 
            this.btProcuraCliente.Location = new System.Drawing.Point(77, 71);
            this.btProcuraCliente.Name = "btProcuraCliente";
            this.btProcuraCliente.Size = new System.Drawing.Size(20, 20);
            this.btProcuraCliente.TabIndex = 6;
            this.btProcuraCliente.TabStop = false;
            this.btProcuraCliente.UseVisualStyleBackColor = true;
            // 
            // tbCodCliente
            // 
            this.tbCodCliente.Location = new System.Drawing.Point(10, 71);
            this.tbCodCliente.Name = "tbCodCliente";
            this.tbCodCliente.Size = new System.Drawing.Size(65, 20);
            this.tbCodCliente.TabIndex = 5;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(7, 55);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 4;
            this.lbCliente.Text = "Cliente";
            // 
            // buscaCidade1
            // 
            this.buscaCidade1.Location = new System.Drawing.Point(6, 16);
            this.buscaCidade1.Name = "buscaCidade1";
            this.buscaCidade1.Size = new System.Drawing.Size(450, 45);
            this.buscaCidade1.TabIndex = 41;
            // 
            // fmBuscaNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 461);
            this.Controls.Add(this.gbGridDocumentos);
            this.Controls.Add(this.gbFiltrosDocumento);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "fmBuscaNotaFiscal";
            this.Text = "Busca notas fiscais";
            this.gbGridDocumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).EndInit();
            this.gbFiltrosDocumento.ResumeLayout(false);
            this.gbFiltrosDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGridDocumentos;
        private System.Windows.Forms.DataGridView dgvOrcamentos;
        private System.Windows.Forms.GroupBox gbFiltrosDocumento;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label lbAValorTotalDocumento;
        private System.Windows.Forms.TextBox tbFiltroValorTotalDocumentoInicial;
        private System.Windows.Forms.TextBox tbFiltroValorTotalDocumentoFinal;
        private System.Windows.Forms.Label lbFiltroValorTotalDocumento;
        private System.Windows.Forms.Label lbFiltroDataEntradaSaida;
        private System.Windows.Forms.Label lbAFiltroDataEntradaSaida;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataEntradaSaidaFinal;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataEntradaSaidaInicial;
        private System.Windows.Forms.Label lbFiltroDataEmissao;
        private System.Windows.Forms.Label lbAFiltroDataEmissao;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataEmissaoFinal;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataEmissaoInicial;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Button btProcuraCliente;
        private System.Windows.Forms.TextBox tbCodCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoTotalItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalOrçamento;
        private Controls.BuscaCidade buscaCidade1;
    }
}