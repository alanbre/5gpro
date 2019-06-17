namespace _5gpro.Forms
{
    partial class fmSaiBuscaNotaFiscalPropria
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
            this.gbGridDocumentos = new System.Windows.Forms.GroupBox();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
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
            this.dbValorFinal = new _5gpro.Controls.DecimalBox();
            this.dbValorInicial = new _5gpro.Controls.DecimalBox();
            this.cbValorTotal = new System.Windows.Forms.CheckBox();
            this.cbDataEntrada = new System.Windows.Forms.CheckBox();
            this.cbDataCadastro = new System.Windows.Forms.CheckBox();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.buscaCidade = new _5gpro.Controls.BuscaCidade();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.lbAValorTotalDocumento = new System.Windows.Forms.Label();
            this.lbFiltroValorTotalDocumento = new System.Windows.Forms.Label();
            this.lbFiltroDataEntradaSaida = new System.Windows.Forms.Label();
            this.lbAFiltroDataEntradaSaida = new System.Windows.Forms.Label();
            this.dtpFiltroDataEntradaSaidaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroDataEntradaSaidaInicial = new System.Windows.Forms.DateTimePicker();
            this.lbFiltroDataEmissao = new System.Windows.Forms.Label();
            this.lbAFiltroDataEmissao = new System.Windows.Forms.Label();
            this.dtpFiltroDataEmissaoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroDataEmissaoInicial = new System.Windows.Forms.DateTimePicker();
            this.gbGridDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.gbFiltrosDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGridDocumentos
            // 
            this.gbGridDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridDocumentos.Controls.Add(this.dgvNotas);
            this.gbGridDocumentos.Location = new System.Drawing.Point(12, 161);
            this.gbGridDocumentos.Name = "gbGridDocumentos";
            this.gbGridDocumentos.Size = new System.Drawing.Size(1068, 289);
            this.gbGridDocumentos.TabIndex = 1;
            this.gbGridDocumentos.TabStop = false;
            this.gbGridDocumentos.Text = "Notas fiscais";
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AllowUserToOrderColumns = true;
            this.dgvNotas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvNotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcOrcamento,
            this.dgvtbcCodigoPessoa,
            this.dgvtbcNome,
            this.dgvtbcDataCadastro,
            this.dgvtbcDataValidade,
            this.dgvtbcValorTotalItens,
            this.dgvtbcDescontoTotalItens,
            this.dgvtbcDescontoOrcamento,
            this.dgvtbcValorTotalOrçamento});
            this.dgvNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotas.Location = new System.Drawing.Point(10, 19);
            this.dgvNotas.MultiSelect = false;
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersVisible = false;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(1052, 264);
            this.dgvNotas.TabIndex = 0;
            this.dgvNotas.TabStop = false;
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
            this.gbFiltrosDocumento.Controls.Add(this.dbValorFinal);
            this.gbFiltrosDocumento.Controls.Add(this.dbValorInicial);
            this.gbFiltrosDocumento.Controls.Add(this.cbValorTotal);
            this.gbFiltrosDocumento.Controls.Add(this.cbDataEntrada);
            this.gbFiltrosDocumento.Controls.Add(this.cbDataCadastro);
            this.gbFiltrosDocumento.Controls.Add(this.buscaPessoa);
            this.gbFiltrosDocumento.Controls.Add(this.buscaCidade);
            this.gbFiltrosDocumento.Controls.Add(this.btPesquisar);
            this.gbFiltrosDocumento.Controls.Add(this.lbAValorTotalDocumento);
            this.gbFiltrosDocumento.Controls.Add(this.lbFiltroValorTotalDocumento);
            this.gbFiltrosDocumento.Controls.Add(this.lbFiltroDataEntradaSaida);
            this.gbFiltrosDocumento.Controls.Add(this.lbAFiltroDataEntradaSaida);
            this.gbFiltrosDocumento.Controls.Add(this.dtpFiltroDataEntradaSaidaFinal);
            this.gbFiltrosDocumento.Controls.Add(this.dtpFiltroDataEntradaSaidaInicial);
            this.gbFiltrosDocumento.Controls.Add(this.lbFiltroDataEmissao);
            this.gbFiltrosDocumento.Controls.Add(this.lbAFiltroDataEmissao);
            this.gbFiltrosDocumento.Controls.Add(this.dtpFiltroDataEmissaoFinal);
            this.gbFiltrosDocumento.Controls.Add(this.dtpFiltroDataEmissaoInicial);
            this.gbFiltrosDocumento.Location = new System.Drawing.Point(12, 12);
            this.gbFiltrosDocumento.Name = "gbFiltrosDocumento";
            this.gbFiltrosDocumento.Size = new System.Drawing.Size(1068, 143);
            this.gbFiltrosDocumento.TabIndex = 0;
            this.gbFiltrosDocumento.TabStop = false;
            this.gbFiltrosDocumento.Text = "Filtros do documento";
            // 
            // dbValorFinal
            // 
            this.dbValorFinal.Location = new System.Drawing.Point(94, 115);
            this.dbValorFinal.Name = "dbValorFinal";
            this.dbValorFinal.Size = new System.Drawing.Size(70, 22);
            this.dbValorFinal.TabIndex = 19;
            this.dbValorFinal.Valor = new decimal(new int[] {
            99999900,
            0,
            0,
            131072});
            // 
            // dbValorInicial
            // 
            this.dbValorInicial.Location = new System.Drawing.Point(9, 115);
            this.dbValorInicial.Name = "dbValorInicial";
            this.dbValorInicial.Size = new System.Drawing.Size(70, 22);
            this.dbValorInicial.TabIndex = 18;
            this.dbValorInicial.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // cbValorTotal
            // 
            this.cbValorTotal.AutoSize = true;
            this.cbValorTotal.Location = new System.Drawing.Point(171, 118);
            this.cbValorTotal.Name = "cbValorTotal";
            this.cbValorTotal.Size = new System.Drawing.Size(15, 14);
            this.cbValorTotal.TabIndex = 17;
            this.cbValorTotal.UseVisualStyleBackColor = true;
            this.cbValorTotal.CheckedChanged += new System.EventHandler(this.CbValorTotal_CheckedChanged);
            // 
            // cbDataEntrada
            // 
            this.cbDataEntrada.AutoSize = true;
            this.cbDataEntrada.Location = new System.Drawing.Point(686, 76);
            this.cbDataEntrada.Name = "cbDataEntrada";
            this.cbDataEntrada.Size = new System.Drawing.Size(15, 14);
            this.cbDataEntrada.TabIndex = 16;
            this.cbDataEntrada.UseVisualStyleBackColor = true;
            this.cbDataEntrada.CheckedChanged += new System.EventHandler(this.CbDataEntrada_CheckedChanged);
            // 
            // cbDataCadastro
            // 
            this.cbDataCadastro.AutoSize = true;
            this.cbDataCadastro.Location = new System.Drawing.Point(686, 37);
            this.cbDataCadastro.Name = "cbDataCadastro";
            this.cbDataCadastro.Size = new System.Drawing.Size(15, 14);
            this.cbDataCadastro.TabIndex = 15;
            this.cbDataCadastro.UseVisualStyleBackColor = true;
            this.cbDataCadastro.CheckedChanged += new System.EventHandler(this.CbDataEmissao_CheckedChanged);
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Cliente";
            this.buscaPessoa.Location = new System.Drawing.Point(3, 54);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa.TabIndex = 1;
            // 
            // buscaCidade
            // 
            this.buscaCidade.LabelText = "Cidade";
            this.buscaCidade.Location = new System.Drawing.Point(3, 16);
            this.buscaCidade.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCidade.Name = "buscaCidade";
            this.buscaCidade.Size = new System.Drawing.Size(442, 39);
            this.buscaCidade.TabIndex = 0;
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
            // lbAValorTotalDocumento
            // 
            this.lbAValorTotalDocumento.AutoSize = true;
            this.lbAValorTotalDocumento.Location = new System.Drawing.Point(80, 118);
            this.lbAValorTotalDocumento.Name = "lbAValorTotalDocumento";
            this.lbAValorTotalDocumento.Size = new System.Drawing.Size(13, 13);
            this.lbAValorTotalDocumento.TabIndex = 4;
            this.lbAValorTotalDocumento.Text = "a";
            // 
            // lbFiltroValorTotalDocumento
            // 
            this.lbFiltroValorTotalDocumento.AutoSize = true;
            this.lbFiltroValorTotalDocumento.Location = new System.Drawing.Point(7, 96);
            this.lbFiltroValorTotalDocumento.Name = "lbFiltroValorTotalDocumento";
            this.lbFiltroValorTotalDocumento.Size = new System.Drawing.Size(125, 13);
            this.lbFiltroValorTotalDocumento.TabIndex = 2;
            this.lbFiltroValorTotalDocumento.Text = "Valor total do documento";
            // 
            // lbFiltroDataEntradaSaida
            // 
            this.lbFiltroDataEntradaSaida.AutoSize = true;
            this.lbFiltroDataEntradaSaida.Location = new System.Drawing.Point(452, 56);
            this.lbFiltroDataEntradaSaida.Name = "lbFiltroDataEntradaSaida";
            this.lbFiltroDataEntradaSaida.Size = new System.Drawing.Size(122, 13);
            this.lbFiltroDataEntradaSaida.TabIndex = 10;
            this.lbFiltroDataEntradaSaida.Text = "Data de entrada / saída";
            // 
            // lbAFiltroDataEntradaSaida
            // 
            this.lbAFiltroDataEntradaSaida.AutoSize = true;
            this.lbAFiltroDataEntradaSaida.Location = new System.Drawing.Point(561, 77);
            this.lbAFiltroDataEntradaSaida.Name = "lbAFiltroDataEntradaSaida";
            this.lbAFiltroDataEntradaSaida.Size = new System.Drawing.Size(13, 13);
            this.lbAFiltroDataEntradaSaida.TabIndex = 12;
            this.lbAFiltroDataEntradaSaida.Text = "a";
            // 
            // dtpFiltroDataEntradaSaidaFinal
            // 
            this.dtpFiltroDataEntradaSaidaFinal.CustomFormat = "";
            this.dtpFiltroDataEntradaSaidaFinal.Enabled = false;
            this.dtpFiltroDataEntradaSaidaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataEntradaSaidaFinal.Location = new System.Drawing.Point(580, 73);
            this.dtpFiltroDataEntradaSaidaFinal.Name = "dtpFiltroDataEntradaSaidaFinal";
            this.dtpFiltroDataEntradaSaidaFinal.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataEntradaSaidaFinal.TabIndex = 13;
            this.dtpFiltroDataEntradaSaidaFinal.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFiltroDataEntradaSaidaInicial
            // 
            this.dtpFiltroDataEntradaSaidaInicial.CustomFormat = "";
            this.dtpFiltroDataEntradaSaidaInicial.Enabled = false;
            this.dtpFiltroDataEntradaSaidaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataEntradaSaidaInicial.Location = new System.Drawing.Point(455, 73);
            this.dtpFiltroDataEntradaSaidaInicial.Name = "dtpFiltroDataEntradaSaidaInicial";
            this.dtpFiltroDataEntradaSaidaInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataEntradaSaidaInicial.TabIndex = 11;
            this.dtpFiltroDataEntradaSaidaInicial.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lbFiltroDataEmissao
            // 
            this.lbFiltroDataEmissao.AutoSize = true;
            this.lbFiltroDataEmissao.Location = new System.Drawing.Point(452, 16);
            this.lbFiltroDataEmissao.Name = "lbFiltroDataEmissao";
            this.lbFiltroDataEmissao.Size = new System.Drawing.Size(86, 13);
            this.lbFiltroDataEmissao.TabIndex = 6;
            this.lbFiltroDataEmissao.Text = "Data de emissão";
            // 
            // lbAFiltroDataEmissao
            // 
            this.lbAFiltroDataEmissao.AutoSize = true;
            this.lbAFiltroDataEmissao.Location = new System.Drawing.Point(561, 37);
            this.lbAFiltroDataEmissao.Name = "lbAFiltroDataEmissao";
            this.lbAFiltroDataEmissao.Size = new System.Drawing.Size(13, 13);
            this.lbAFiltroDataEmissao.TabIndex = 8;
            this.lbAFiltroDataEmissao.Text = "a";
            // 
            // dtpFiltroDataEmissaoFinal
            // 
            this.dtpFiltroDataEmissaoFinal.CustomFormat = "";
            this.dtpFiltroDataEmissaoFinal.Enabled = false;
            this.dtpFiltroDataEmissaoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataEmissaoFinal.Location = new System.Drawing.Point(580, 33);
            this.dtpFiltroDataEmissaoFinal.Name = "dtpFiltroDataEmissaoFinal";
            this.dtpFiltroDataEmissaoFinal.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataEmissaoFinal.TabIndex = 9;
            this.dtpFiltroDataEmissaoFinal.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFiltroDataEmissaoInicial
            // 
            this.dtpFiltroDataEmissaoInicial.CustomFormat = "";
            this.dtpFiltroDataEmissaoInicial.Enabled = false;
            this.dtpFiltroDataEmissaoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataEmissaoInicial.Location = new System.Drawing.Point(455, 33);
            this.dtpFiltroDataEmissaoInicial.Name = "dtpFiltroDataEmissaoInicial";
            this.dtpFiltroDataEmissaoInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataEmissaoInicial.TabIndex = 7;
            this.dtpFiltroDataEmissaoInicial.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // fmSaiBuscaNotaFiscalPropria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 462);
            this.Controls.Add(this.gbGridDocumentos);
            this.Controls.Add(this.gbFiltrosDocumento);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1108, 501);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1108, 501);
            this.Name = "fmSaiBuscaNotaFiscalPropria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca notas fiscais";
            this.gbGridDocumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.gbFiltrosDocumento.ResumeLayout(false);
            this.gbFiltrosDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGridDocumentos;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.GroupBox gbFiltrosDocumento;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label lbAValorTotalDocumento;
        private System.Windows.Forms.Label lbFiltroValorTotalDocumento;
        private System.Windows.Forms.Label lbFiltroDataEntradaSaida;
        private System.Windows.Forms.Label lbAFiltroDataEntradaSaida;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataEntradaSaidaFinal;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataEntradaSaidaInicial;
        private System.Windows.Forms.Label lbFiltroDataEmissao;
        private System.Windows.Forms.Label lbAFiltroDataEmissao;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataEmissaoFinal;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataEmissaoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoTotalItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalOrçamento;
        private Controls.BuscaCidade buscaCidade;
        private Controls.BuscaPessoa buscaPessoa;
        private System.Windows.Forms.CheckBox cbValorTotal;
        private System.Windows.Forms.CheckBox cbDataEntrada;
        private System.Windows.Forms.CheckBox cbDataCadastro;
        private Controls.DecimalBox dbValorFinal;
        private Controls.DecimalBox dbValorInicial;
    }
}