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
            this.dtpDataEmissaoFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEmissaoInicial = new System.Windows.Forms.DateTimePicker();
            this.dbValorFinal = new _5gpro.Controls.DecimalBox();
            this.dbValorInicial = new _5gpro.Controls.DecimalBox();
            this.bpInicial = new _5gpro.Controls.BuscaPessoa();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btGerar = new System.Windows.Forms.Button();
            this.tcPaginas = new System.Windows.Forms.TabControl();
            this.tpCampos = new System.Windows.Forms.TabPage();
            this.tpFiltros = new System.Windows.Forms.TabPage();
            this.cbFiltroClientes = new System.Windows.Forms.CheckBox();
            this.gbFiltrosCidades = new System.Windows.Forms.GroupBox();
            this.bcCidadeInicial = new _5gpro.Controls.BuscaCidade();
            this.bcFinal = new _5gpro.Controls.BuscaCidade();
            this.cbFiltroDataEmissao = new System.Windows.Forms.CheckBox();
            this.gbFiltrosDataEmissao = new System.Windows.Forms.GroupBox();
            this.cbFiltrosClientes = new System.Windows.Forms.CheckBox();
            this.gbFiltrosClientes = new System.Windows.Forms.GroupBox();
            this.bpFinal = new _5gpro.Controls.BuscaPessoa();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.cbFiltroDataSaida = new System.Windows.Forms.CheckBox();
            this.gbFiltrosDataSaida = new System.Windows.Forms.GroupBox();
            this.dtpDataSaidaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaidaFinal = new System.Windows.Forms.DateTimePicker();
            this.cbFiltroValor = new System.Windows.Forms.CheckBox();
            this.gbFiltrosValor = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbRelatorio = new System.Windows.Forms.GroupBox();
            this.cbRelatorios = new System.Windows.Forms.ComboBox();
            this.btCarregarRelatorio = new System.Windows.Forms.Button();
            this.btSalvarRelatorio = new System.Windows.Forms.Button();
            this.btNovoRelatorio = new System.Windows.Forms.Button();
            this.tcPaginas.SuspendLayout();
            this.tpFiltros.SuspendLayout();
            this.gbFiltrosCidades.SuspendLayout();
            this.gbFiltrosDataEmissao.SuspendLayout();
            this.gbFiltrosClientes.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.gbFiltrosDataSaida.SuspendLayout();
            this.gbFiltrosValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDataEmissaoFinal
            // 
            this.dtpDataEmissaoFinal.Enabled = false;
            this.dtpDataEmissaoFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissaoFinal.Location = new System.Drawing.Point(112, 10);
            this.dtpDataEmissaoFinal.Name = "dtpDataEmissaoFinal";
            this.dtpDataEmissaoFinal.Size = new System.Drawing.Size(97, 20);
            this.dtpDataEmissaoFinal.TabIndex = 1;
            // 
            // dtpDataEmissaoInicial
            // 
            this.dtpDataEmissaoInicial.Enabled = false;
            this.dtpDataEmissaoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissaoInicial.Location = new System.Drawing.Point(6, 10);
            this.dtpDataEmissaoInicial.Name = "dtpDataEmissaoInicial";
            this.dtpDataEmissaoInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpDataEmissaoInicial.TabIndex = 0;
            // 
            // dbValorFinal
            // 
            this.dbValorFinal.Enabled = false;
            this.dbValorFinal.Location = new System.Drawing.Point(77, 9);
            this.dbValorFinal.Name = "dbValorFinal";
            this.dbValorFinal.Size = new System.Drawing.Size(63, 22);
            this.dbValorFinal.TabIndex = 1;
            this.dbValorFinal.Valor = new decimal(new int[] {
            99999900,
            0,
            0,
            131072});
            // 
            // dbValorInicial
            // 
            this.dbValorInicial.Enabled = false;
            this.dbValorInicial.Location = new System.Drawing.Point(7, 9);
            this.dbValorInicial.Name = "dbValorInicial";
            this.dbValorInicial.Size = new System.Drawing.Size(64, 22);
            this.dbValorInicial.TabIndex = 0;
            this.dbValorInicial.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(1053, 89);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 0;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(1134, 89);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 1;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            // 
            // tcPaginas
            // 
            this.tcPaginas.Controls.Add(this.tpCampos);
            this.tcPaginas.Controls.Add(this.tpFiltros);
            this.tcPaginas.Controls.Add(this.tpDados);
            this.tcPaginas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcPaginas.Location = new System.Drawing.Point(0, 118);
            this.tcPaginas.Name = "tcPaginas";
            this.tcPaginas.SelectedIndex = 0;
            this.tcPaginas.Size = new System.Drawing.Size(1221, 504);
            this.tcPaginas.TabIndex = 2;
            // 
            // tpCampos
            // 
            this.tpCampos.Location = new System.Drawing.Point(4, 22);
            this.tpCampos.Name = "tpCampos";
            this.tpCampos.Padding = new System.Windows.Forms.Padding(3);
            this.tpCampos.Size = new System.Drawing.Size(1213, 478);
            this.tpCampos.TabIndex = 0;
            this.tpCampos.Text = "Campos";
            this.tpCampos.UseVisualStyleBackColor = true;
            // 
            // tpFiltros
            // 
            this.tpFiltros.Controls.Add(this.cbFiltroValor);
            this.tpFiltros.Controls.Add(this.gbFiltrosValor);
            this.tpFiltros.Controls.Add(this.cbFiltroDataSaida);
            this.tpFiltros.Controls.Add(this.gbFiltrosDataSaida);
            this.tpFiltros.Controls.Add(this.cbFiltroClientes);
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
            // cbFiltroClientes
            // 
            this.cbFiltroClientes.AutoSize = true;
            this.cbFiltroClientes.Location = new System.Drawing.Point(8, 123);
            this.cbFiltroClientes.Name = "cbFiltroClientes";
            this.cbFiltroClientes.Size = new System.Drawing.Size(107, 17);
            this.cbFiltroClientes.TabIndex = 2;
            this.cbFiltroClientes.Text = "Filtros de clientes";
            this.cbFiltroClientes.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosCidades
            // 
            this.gbFiltrosCidades.Controls.Add(this.bcCidadeInicial);
            this.gbFiltrosCidades.Controls.Add(this.bcFinal);
            this.gbFiltrosCidades.Enabled = false;
            this.gbFiltrosCidades.Location = new System.Drawing.Point(6, 138);
            this.gbFiltrosCidades.Name = "gbFiltrosCidades";
            this.gbFiltrosCidades.Size = new System.Drawing.Size(314, 99);
            this.gbFiltrosCidades.TabIndex = 3;
            this.gbFiltrosCidades.TabStop = false;
            // 
            // bcCidadeInicial
            // 
            this.bcCidadeInicial.LabelText = "Cidade inicial";
            this.bcCidadeInicial.Location = new System.Drawing.Point(3, 13);
            this.bcCidadeInicial.Margin = new System.Windows.Forms.Padding(0);
            this.bcCidadeInicial.Name = "bcCidadeInicial";
            this.bcCidadeInicial.Size = new System.Drawing.Size(302, 39);
            this.bcCidadeInicial.TabIndex = 0;
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
            this.gbFiltrosDataEmissao.Controls.Add(this.dtpDataEmissaoInicial);
            this.gbFiltrosDataEmissao.Controls.Add(this.dtpDataEmissaoFinal);
            this.gbFiltrosDataEmissao.Enabled = false;
            this.gbFiltrosDataEmissao.Location = new System.Drawing.Point(6, 259);
            this.gbFiltrosDataEmissao.Name = "gbFiltrosDataEmissao";
            this.gbFiltrosDataEmissao.Size = new System.Drawing.Size(313, 42);
            this.gbFiltrosDataEmissao.TabIndex = 5;
            this.gbFiltrosDataEmissao.TabStop = false;
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
            // cbFiltroDataSaida
            // 
            this.cbFiltroDataSaida.AutoSize = true;
            this.cbFiltroDataSaida.Location = new System.Drawing.Point(9, 307);
            this.cbFiltroDataSaida.Name = "cbFiltroDataSaida";
            this.cbFiltroDataSaida.Size = new System.Drawing.Size(132, 17);
            this.cbFiltroDataSaida.TabIndex = 6;
            this.cbFiltroDataSaida.Text = "Filtro de data de saída";
            this.cbFiltroDataSaida.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosDataSaida
            // 
            this.gbFiltrosDataSaida.Controls.Add(this.dtpDataSaidaInicial);
            this.gbFiltrosDataSaida.Controls.Add(this.dtpDataSaidaFinal);
            this.gbFiltrosDataSaida.Enabled = false;
            this.gbFiltrosDataSaida.Location = new System.Drawing.Point(6, 321);
            this.gbFiltrosDataSaida.Name = "gbFiltrosDataSaida";
            this.gbFiltrosDataSaida.Size = new System.Drawing.Size(313, 42);
            this.gbFiltrosDataSaida.TabIndex = 7;
            this.gbFiltrosDataSaida.TabStop = false;
            // 
            // dtpDataSaidaInicial
            // 
            this.dtpDataSaidaInicial.Enabled = false;
            this.dtpDataSaidaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaidaInicial.Location = new System.Drawing.Point(6, 10);
            this.dtpDataSaidaInicial.Name = "dtpDataSaidaInicial";
            this.dtpDataSaidaInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpDataSaidaInicial.TabIndex = 0;
            // 
            // dtpDataSaidaFinal
            // 
            this.dtpDataSaidaFinal.Enabled = false;
            this.dtpDataSaidaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaidaFinal.Location = new System.Drawing.Point(112, 10);
            this.dtpDataSaidaFinal.Name = "dtpDataSaidaFinal";
            this.dtpDataSaidaFinal.Size = new System.Drawing.Size(97, 20);
            this.dtpDataSaidaFinal.TabIndex = 1;
            // 
            // cbFiltroValor
            // 
            this.cbFiltroValor.AutoSize = true;
            this.cbFiltroValor.Location = new System.Drawing.Point(8, 369);
            this.cbFiltroValor.Name = "cbFiltroValor";
            this.cbFiltroValor.Size = new System.Drawing.Size(89, 17);
            this.cbFiltroValor.TabIndex = 8;
            this.cbFiltroValor.Text = "Filtro de valor";
            this.cbFiltroValor.UseVisualStyleBackColor = true;
            // 
            // gbFiltrosValor
            // 
            this.gbFiltrosValor.Controls.Add(this.dbValorInicial);
            this.gbFiltrosValor.Controls.Add(this.dbValorFinal);
            this.gbFiltrosValor.Enabled = false;
            this.gbFiltrosValor.Location = new System.Drawing.Point(5, 383);
            this.gbFiltrosValor.Name = "gbFiltrosValor";
            this.gbFiltrosValor.Size = new System.Drawing.Size(313, 42);
            this.gbFiltrosValor.TabIndex = 9;
            this.gbFiltrosValor.TabStop = false;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(1207, 472);
            this.dgvDados.TabIndex = 0;
            // 
            // gbRelatorio
            // 
            this.gbRelatorio.Controls.Add(this.btNovoRelatorio);
            this.gbRelatorio.Controls.Add(this.btSalvarRelatorio);
            this.gbRelatorio.Controls.Add(this.btCarregarRelatorio);
            this.gbRelatorio.Controls.Add(this.cbRelatorios);
            this.gbRelatorio.Location = new System.Drawing.Point(12, 12);
            this.gbRelatorio.Name = "gbRelatorio";
            this.gbRelatorio.Size = new System.Drawing.Size(1035, 100);
            this.gbRelatorio.TabIndex = 3;
            this.gbRelatorio.TabStop = false;
            this.gbRelatorio.Text = "Relatório";
            // 
            // cbRelatorios
            // 
            this.cbRelatorios.FormattingEnabled = true;
            this.cbRelatorios.Location = new System.Drawing.Point(6, 19);
            this.cbRelatorios.Name = "cbRelatorios";
            this.cbRelatorios.Size = new System.Drawing.Size(1023, 21);
            this.cbRelatorios.TabIndex = 0;
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
            // btSalvarRelatorio
            // 
            this.btSalvarRelatorio.Location = new System.Drawing.Point(87, 46);
            this.btSalvarRelatorio.Name = "btSalvarRelatorio";
            this.btSalvarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btSalvarRelatorio.TabIndex = 2;
            this.btSalvarRelatorio.Text = "Salvar";
            this.btSalvarRelatorio.UseVisualStyleBackColor = true;
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
            this.Text = "Relatório de notas de saída";
            this.tcPaginas.ResumeLayout(false);
            this.tpFiltros.ResumeLayout(false);
            this.tpFiltros.PerformLayout();
            this.gbFiltrosCidades.ResumeLayout(false);
            this.gbFiltrosDataEmissao.ResumeLayout(false);
            this.gbFiltrosClientes.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.gbFiltrosDataSaida.ResumeLayout(false);
            this.gbFiltrosValor.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox cbFiltroClientes;
        private System.Windows.Forms.GroupBox gbFiltrosCidades;
        private Controls.BuscaCidade bcFinal;
        private System.Windows.Forms.CheckBox cbFiltroDataSaida;
        private System.Windows.Forms.GroupBox gbFiltrosDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataSaidaInicial;
        private System.Windows.Forms.DateTimePicker dtpDataSaidaFinal;
        private System.Windows.Forms.CheckBox cbFiltroValor;
        private System.Windows.Forms.GroupBox gbFiltrosValor;
        private Controls.BuscaCidade bcCidadeInicial;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox gbRelatorio;
        private System.Windows.Forms.Button btNovoRelatorio;
        private System.Windows.Forms.Button btSalvarRelatorio;
        private System.Windows.Forms.Button btCarregarRelatorio;
        private System.Windows.Forms.ComboBox cbRelatorios;
    }
}