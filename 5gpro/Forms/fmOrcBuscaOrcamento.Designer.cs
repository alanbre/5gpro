﻿namespace _5gpro.Forms
{
    partial class fmOrcBuscaOrcamento
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
            this.gbFiltrosOrcamento = new System.Windows.Forms.GroupBox();
            this.dbValorTotalIni = new _5gpro.Controls.DecimalBox();
            this.dbValorTotalFinal = new _5gpro.Controls.DecimalBox();
            this.cbValorTotal = new System.Windows.Forms.CheckBox();
            this.cbDataValidade = new System.Windows.Forms.CheckBox();
            this.cbDataCadastro = new System.Windows.Forms.CheckBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFiltroValorTotalOrcamento = new System.Windows.Forms.Label();
            this.lbFiltroDataValidade = new System.Windows.Forms.Label();
            this.lbAFiltroDataValidade = new System.Windows.Forms.Label();
            this.dtpFiltroDataValidadeFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroDataValidadeInicial = new System.Windows.Forms.DateTimePicker();
            this.lbFiltroDataCadastro = new System.Windows.Forms.Label();
            this.lbAFiltroDataCadastro = new System.Windows.Forms.Label();
            this.dtpFiltroDataCadastroFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroDataCadastroInicial = new System.Windows.Forms.DateTimePicker();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.buscaCidade = new _5gpro.Controls.BuscaCidade();
            this.gbGridOrcamentos = new System.Windows.Forms.GroupBox();
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
            this.gbFiltrosOrcamento.SuspendLayout();
            this.gbGridOrcamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltrosOrcamento
            // 
            this.gbFiltrosOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrosOrcamento.Controls.Add(this.dbValorTotalIni);
            this.gbFiltrosOrcamento.Controls.Add(this.dbValorTotalFinal);
            this.gbFiltrosOrcamento.Controls.Add(this.cbValorTotal);
            this.gbFiltrosOrcamento.Controls.Add(this.cbDataValidade);
            this.gbFiltrosOrcamento.Controls.Add(this.cbDataCadastro);
            this.gbFiltrosOrcamento.Controls.Add(this.btPesquisar);
            this.gbFiltrosOrcamento.Controls.Add(this.label1);
            this.gbFiltrosOrcamento.Controls.Add(this.lbFiltroValorTotalOrcamento);
            this.gbFiltrosOrcamento.Controls.Add(this.lbFiltroDataValidade);
            this.gbFiltrosOrcamento.Controls.Add(this.lbAFiltroDataValidade);
            this.gbFiltrosOrcamento.Controls.Add(this.dtpFiltroDataValidadeFinal);
            this.gbFiltrosOrcamento.Controls.Add(this.dtpFiltroDataValidadeInicial);
            this.gbFiltrosOrcamento.Controls.Add(this.lbFiltroDataCadastro);
            this.gbFiltrosOrcamento.Controls.Add(this.lbAFiltroDataCadastro);
            this.gbFiltrosOrcamento.Controls.Add(this.dtpFiltroDataCadastroFinal);
            this.gbFiltrosOrcamento.Controls.Add(this.dtpFiltroDataCadastroInicial);
            this.gbFiltrosOrcamento.Controls.Add(this.buscaPessoa);
            this.gbFiltrosOrcamento.Controls.Add(this.buscaCidade);
            this.gbFiltrosOrcamento.Location = new System.Drawing.Point(12, 12);
            this.gbFiltrosOrcamento.Name = "gbFiltrosOrcamento";
            this.gbFiltrosOrcamento.Size = new System.Drawing.Size(1048, 230);
            this.gbFiltrosOrcamento.TabIndex = 0;
            this.gbFiltrosOrcamento.TabStop = false;
            this.gbFiltrosOrcamento.Text = "Filtros do orçamento";
            // 
            // dbValorTotalIni
            // 
            this.dbValorTotalIni.Enabled = false;
            this.dbValorTotalIni.Location = new System.Drawing.Point(276, 109);
            this.dbValorTotalIni.Name = "dbValorTotalIni";
            this.dbValorTotalIni.Size = new System.Drawing.Size(63, 22);
            this.dbValorTotalIni.TabIndex = 25;
            this.dbValorTotalIni.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbValorTotalFinal
            // 
            this.dbValorTotalFinal.Enabled = false;
            this.dbValorTotalFinal.Location = new System.Drawing.Point(356, 109);
            this.dbValorTotalFinal.Name = "dbValorTotalFinal";
            this.dbValorTotalFinal.Size = new System.Drawing.Size(63, 22);
            this.dbValorTotalFinal.TabIndex = 24;
            this.dbValorTotalFinal.Valor = new decimal(new int[] {
            99999900,
            0,
            0,
            131072});
            // 
            // cbValorTotal
            // 
            this.cbValorTotal.AutoSize = true;
            this.cbValorTotal.Location = new System.Drawing.Point(425, 113);
            this.cbValorTotal.Name = "cbValorTotal";
            this.cbValorTotal.Size = new System.Drawing.Size(15, 14);
            this.cbValorTotal.TabIndex = 23;
            this.cbValorTotal.UseVisualStyleBackColor = true;
            this.cbValorTotal.CheckedChanged += new System.EventHandler(this.CbValorTotal_CheckedChanged);
            // 
            // cbDataValidade
            // 
            this.cbDataValidade.AutoSize = true;
            this.cbDataValidade.Location = new System.Drawing.Point(240, 155);
            this.cbDataValidade.Name = "cbDataValidade";
            this.cbDataValidade.Size = new System.Drawing.Size(15, 14);
            this.cbDataValidade.TabIndex = 21;
            this.cbDataValidade.UseVisualStyleBackColor = true;
            this.cbDataValidade.CheckedChanged += new System.EventHandler(this.CbDataValidade_CheckedChanged);
            // 
            // cbDataCadastro
            // 
            this.cbDataCadastro.AutoSize = true;
            this.cbDataCadastro.Location = new System.Drawing.Point(240, 112);
            this.cbDataCadastro.Name = "cbDataCadastro";
            this.cbDataCadastro.Size = new System.Drawing.Size(15, 14);
            this.cbDataCadastro.TabIndex = 20;
            this.cbDataCadastro.UseVisualStyleBackColor = true;
            this.cbDataCadastro.CheckedChanged += new System.EventHandler(this.CbDataCadastro_CheckedChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(10, 190);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 19;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "a";
            // 
            // lbFiltroValorTotalOrcamento
            // 
            this.lbFiltroValorTotalOrcamento.AutoSize = true;
            this.lbFiltroValorTotalOrcamento.Location = new System.Drawing.Point(273, 93);
            this.lbFiltroValorTotalOrcamento.Name = "lbFiltroValorTotalOrcamento";
            this.lbFiltroValorTotalOrcamento.Size = new System.Drawing.Size(122, 13);
            this.lbFiltroValorTotalOrcamento.TabIndex = 2;
            this.lbFiltroValorTotalOrcamento.Text = "Valor total do orçamento";
            // 
            // lbFiltroDataValidade
            // 
            this.lbFiltroDataValidade.AutoSize = true;
            this.lbFiltroDataValidade.Location = new System.Drawing.Point(6, 132);
            this.lbFiltroDataValidade.Name = "lbFiltroDataValidade";
            this.lbFiltroDataValidade.Size = new System.Drawing.Size(88, 13);
            this.lbFiltroDataValidade.TabIndex = 10;
            this.lbFiltroDataValidade.Text = "Data de validade";
            // 
            // lbAFiltroDataValidade
            // 
            this.lbAFiltroDataValidade.AutoSize = true;
            this.lbAFiltroDataValidade.Location = new System.Drawing.Point(115, 153);
            this.lbAFiltroDataValidade.Name = "lbAFiltroDataValidade";
            this.lbAFiltroDataValidade.Size = new System.Drawing.Size(13, 13);
            this.lbAFiltroDataValidade.TabIndex = 12;
            this.lbAFiltroDataValidade.Text = "a";
            // 
            // dtpFiltroDataValidadeFinal
            // 
            this.dtpFiltroDataValidadeFinal.CustomFormat = "";
            this.dtpFiltroDataValidadeFinal.Enabled = false;
            this.dtpFiltroDataValidadeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataValidadeFinal.Location = new System.Drawing.Point(134, 149);
            this.dtpFiltroDataValidadeFinal.Name = "dtpFiltroDataValidadeFinal";
            this.dtpFiltroDataValidadeFinal.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataValidadeFinal.TabIndex = 13;
            this.dtpFiltroDataValidadeFinal.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFiltroDataValidadeInicial
            // 
            this.dtpFiltroDataValidadeInicial.CustomFormat = "";
            this.dtpFiltroDataValidadeInicial.Enabled = false;
            this.dtpFiltroDataValidadeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataValidadeInicial.Location = new System.Drawing.Point(9, 149);
            this.dtpFiltroDataValidadeInicial.Name = "dtpFiltroDataValidadeInicial";
            this.dtpFiltroDataValidadeInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataValidadeInicial.TabIndex = 11;
            this.dtpFiltroDataValidadeInicial.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lbFiltroDataCadastro
            // 
            this.lbFiltroDataCadastro.AutoSize = true;
            this.lbFiltroDataCadastro.Location = new System.Drawing.Point(6, 92);
            this.lbFiltroDataCadastro.Name = "lbFiltroDataCadastro";
            this.lbFiltroDataCadastro.Size = new System.Drawing.Size(89, 13);
            this.lbFiltroDataCadastro.TabIndex = 6;
            this.lbFiltroDataCadastro.Text = "Data de cadastro";
            // 
            // lbAFiltroDataCadastro
            // 
            this.lbAFiltroDataCadastro.AutoSize = true;
            this.lbAFiltroDataCadastro.Location = new System.Drawing.Point(115, 113);
            this.lbAFiltroDataCadastro.Name = "lbAFiltroDataCadastro";
            this.lbAFiltroDataCadastro.Size = new System.Drawing.Size(13, 13);
            this.lbAFiltroDataCadastro.TabIndex = 8;
            this.lbAFiltroDataCadastro.Text = "a";
            // 
            // dtpFiltroDataCadastroFinal
            // 
            this.dtpFiltroDataCadastroFinal.CustomFormat = "";
            this.dtpFiltroDataCadastroFinal.Enabled = false;
            this.dtpFiltroDataCadastroFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataCadastroFinal.Location = new System.Drawing.Point(134, 109);
            this.dtpFiltroDataCadastroFinal.Name = "dtpFiltroDataCadastroFinal";
            this.dtpFiltroDataCadastroFinal.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataCadastroFinal.TabIndex = 9;
            this.dtpFiltroDataCadastroFinal.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFiltroDataCadastroInicial
            // 
            this.dtpFiltroDataCadastroInicial.CustomFormat = "";
            this.dtpFiltroDataCadastroInicial.Enabled = false;
            this.dtpFiltroDataCadastroInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDataCadastroInicial.Location = new System.Drawing.Point(9, 109);
            this.dtpFiltroDataCadastroInicial.Name = "dtpFiltroDataCadastroInicial";
            this.dtpFiltroDataCadastroInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltroDataCadastroInicial.TabIndex = 7;
            this.dtpFiltroDataCadastroInicial.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Cliente";
            this.buscaPessoa.Location = new System.Drawing.Point(1, 51);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa.TabIndex = 1;
            // 
            // buscaCidade
            // 
            this.buscaCidade.LabelText = "Cidade";
            this.buscaCidade.Location = new System.Drawing.Point(1, 14);
            this.buscaCidade.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCidade.Name = "buscaCidade";
            this.buscaCidade.Size = new System.Drawing.Size(442, 39);
            this.buscaCidade.TabIndex = 0;
            // 
            // gbGridOrcamentos
            // 
            this.gbGridOrcamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridOrcamentos.Controls.Add(this.dgvOrcamentos);
            this.gbGridOrcamentos.Location = new System.Drawing.Point(12, 248);
            this.gbGridOrcamentos.Name = "gbGridOrcamentos";
            this.gbGridOrcamentos.Size = new System.Drawing.Size(1049, 272);
            this.gbGridOrcamentos.TabIndex = 1;
            this.gbGridOrcamentos.TabStop = false;
            this.gbGridOrcamentos.Text = "Orçamentos";
            // 
            // dgvOrcamentos
            // 
            this.dgvOrcamentos.AllowUserToAddRows = false;
            this.dgvOrcamentos.AllowUserToDeleteRows = false;
            this.dgvOrcamentos.AllowUserToOrderColumns = true;
            this.dgvOrcamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvOrcamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvOrcamentos.Size = new System.Drawing.Size(1033, 247);
            this.dgvOrcamentos.TabIndex = 0;
            this.dgvOrcamentos.TabStop = false;
            this.dgvOrcamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrcamentos_CellDoubleClick);
            // 
            // dgvtbcOrcamento
            // 
            this.dgvtbcOrcamento.HeaderText = "Orcamento";
            this.dgvtbcOrcamento.MinimumWidth = 70;
            this.dgvtbcOrcamento.Name = "dgvtbcOrcamento";
            this.dgvtbcOrcamento.ReadOnly = true;
            this.dgvtbcOrcamento.Width = 70;
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvtbcDataCadastro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtbcDataCadastro.HeaderText = "Data do cadastro";
            this.dgvtbcDataCadastro.MinimumWidth = 120;
            this.dgvtbcDataCadastro.Name = "dgvtbcDataCadastro";
            this.dgvtbcDataCadastro.ReadOnly = true;
            this.dgvtbcDataCadastro.Width = 120;
            // 
            // dgvtbcDataValidade
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvtbcDataValidade.DefaultCellStyle = dataGridViewCellStyle3;
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
            // fmOrcBuscaOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 533);
            this.Controls.Add(this.gbGridOrcamentos);
            this.Controls.Add(this.gbFiltrosOrcamento);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1089, 572);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1089, 572);
            this.Name = "fmOrcBuscaOrcamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de orçamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaOrcamento_KeyDown);
            this.gbFiltrosOrcamento.ResumeLayout(false);
            this.gbFiltrosOrcamento.PerformLayout();
            this.gbGridOrcamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltrosOrcamento;
        private System.Windows.Forms.Label lbFiltroDataValidade;
        private System.Windows.Forms.Label lbAFiltroDataValidade;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataValidadeFinal;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataValidadeInicial;
        private System.Windows.Forms.Label lbFiltroDataCadastro;
        private System.Windows.Forms.Label lbAFiltroDataCadastro;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataCadastroFinal;
        private System.Windows.Forms.DateTimePicker dtpFiltroDataCadastroInicial;
        private System.Windows.Forms.Label lbFiltroValorTotalOrcamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbGridOrcamentos;
        private System.Windows.Forms.DataGridView dgvOrcamentos;
        private Controls.BuscaCidade buscaCidade;
        private Controls.BuscaPessoa buscaPessoa;
        private System.Windows.Forms.CheckBox cbValorTotal;
        private System.Windows.Forms.CheckBox cbDataValidade;
        private System.Windows.Forms.CheckBox cbDataCadastro;
        private Controls.DecimalBox dbValorTotalIni;
        private Controls.DecimalBox dbValorTotalFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoTotalItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescontoOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalOrçamento;
    }
}