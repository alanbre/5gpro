namespace _5gpro.Forms
{
    partial class fmCaiSangria
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
            this.tbStatusCaixa = new System.Windows.Forms.TextBox();
            this.lbStatusCaixa = new System.Windows.Forms.Label();
            this.gbSangria = new System.Windows.Forms.GroupBox();
            this.tcSangria = new System.Windows.Forms.TabControl();
            this.tpGeral = new System.Windows.Forms.TabPage();
            this.gbDemonstrativoCaixa = new System.Windows.Forms.GroupBox();
            this.lbDemonstrativoCartaoDebito = new System.Windows.Forms.Label();
            this.lbDemonstrativoCartaoCredito = new System.Windows.Forms.Label();
            this.lbDemonstrativoCheque = new System.Windows.Forms.Label();
            this.lbDemonstrativoDinheiro = new System.Windows.Forms.Label();
            this.gbTotaisConta = new System.Windows.Forms.GroupBox();
            this.lbFaturamento = new System.Windows.Forms.Label();
            this.lbTotalCaixa = new System.Windows.Forms.Label();
            this.lbSangrias = new System.Windows.Forms.Label();
            this.lbAbertura = new System.Windows.Forms.Label();
            this.tpCheque = new System.Windows.Forms.TabPage();
            this.cbTodosCheques = new System.Windows.Forms.CheckBox();
            this.dgvCheque = new System.Windows.Forms.DataGridView();
            this.tpCartaoCredito = new System.Windows.Forms.TabPage();
            this.cbTodosCartaoCredito = new System.Windows.Forms.CheckBox();
            this.dgvCartaoCredito = new System.Windows.Forms.DataGridView();
            this.tpCartaoDebito = new System.Windows.Forms.TabPage();
            this.cbTodosCartaoDebito = new System.Windows.Forms.CheckBox();
            this.dgvCartaoDebito = new System.Windows.Forms.DataGridView();
            this.gbTotaisSangria = new System.Windows.Forms.GroupBox();
            this.lbSangriaTotal = new System.Windows.Forms.Label();
            this.btRealizarSangria = new System.Windows.Forms.Button();
            this.lbSangriaCartaoDebito = new System.Windows.Forms.Label();
            this.lbSangriaCartaoCredito = new System.Windows.Forms.Label();
            this.lbSangriaCheque = new System.Windows.Forms.Label();
            this.lbSangriaDinheiro = new System.Windows.Forms.Label();
            this.dbSangriaTotal = new _5gpro.Controls.DecimalBox();
            this.dbSangriaCartaoDebitoTotal = new _5gpro.Controls.DecimalBox();
            this.dbSangriaCartaoCreditoTotal = new _5gpro.Controls.DecimalBox();
            this.dbSangriaChequeTotal = new _5gpro.Controls.DecimalBox();
            this.dbSangriaDinheiroTotal = new _5gpro.Controls.DecimalBox();
            this.dbDemonstrativoCartaoDebito = new _5gpro.Controls.DecimalBox();
            this.dbDemonstrativoCartaoCredito = new _5gpro.Controls.DecimalBox();
            this.dbDemonstrativoCheque = new _5gpro.Controls.DecimalBox();
            this.dbDemonstrativoDinheiro = new _5gpro.Controls.DecimalBox();
            this.dbCaixaSangria = new _5gpro.Controls.DecimalBox();
            this.dbCaixaTotal = new _5gpro.Controls.DecimalBox();
            this.dbCaixaFaturamento = new _5gpro.Controls.DecimalBox();
            this.dbCaixaAbertura = new _5gpro.Controls.DecimalBox();
            this.buscaCaixa = new _5gpro.Controls.BuscaCaixa();
            this.gbSangria.SuspendLayout();
            this.tcSangria.SuspendLayout();
            this.tpGeral.SuspendLayout();
            this.gbDemonstrativoCaixa.SuspendLayout();
            this.gbTotaisConta.SuspendLayout();
            this.tpCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).BeginInit();
            this.tpCartaoCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartaoCredito)).BeginInit();
            this.tpCartaoDebito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartaoDebito)).BeginInit();
            this.gbTotaisSangria.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStatusCaixa
            // 
            this.tbStatusCaixa.Enabled = false;
            this.tbStatusCaixa.Location = new System.Drawing.Point(279, 25);
            this.tbStatusCaixa.Name = "tbStatusCaixa";
            this.tbStatusCaixa.Size = new System.Drawing.Size(100, 20);
            this.tbStatusCaixa.TabIndex = 2;
            // 
            // lbStatusCaixa
            // 
            this.lbStatusCaixa.AutoSize = true;
            this.lbStatusCaixa.Location = new System.Drawing.Point(276, 9);
            this.lbStatusCaixa.Name = "lbStatusCaixa";
            this.lbStatusCaixa.Size = new System.Drawing.Size(37, 13);
            this.lbStatusCaixa.TabIndex = 1;
            this.lbStatusCaixa.Text = "Status";
            // 
            // gbSangria
            // 
            this.gbSangria.Controls.Add(this.tcSangria);
            this.gbSangria.Location = new System.Drawing.Point(12, 51);
            this.gbSangria.Name = "gbSangria";
            this.gbSangria.Size = new System.Drawing.Size(776, 387);
            this.gbSangria.TabIndex = 3;
            this.gbSangria.TabStop = false;
            this.gbSangria.Text = "Sangria";
            // 
            // tcSangria
            // 
            this.tcSangria.Controls.Add(this.tpGeral);
            this.tcSangria.Controls.Add(this.tpCheque);
            this.tcSangria.Controls.Add(this.tpCartaoCredito);
            this.tcSangria.Controls.Add(this.tpCartaoDebito);
            this.tcSangria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSangria.Location = new System.Drawing.Point(3, 16);
            this.tcSangria.Name = "tcSangria";
            this.tcSangria.SelectedIndex = 0;
            this.tcSangria.Size = new System.Drawing.Size(770, 368);
            this.tcSangria.TabIndex = 0;
            // 
            // tpGeral
            // 
            this.tpGeral.Controls.Add(this.gbDemonstrativoCaixa);
            this.tpGeral.Controls.Add(this.gbTotaisConta);
            this.tpGeral.Location = new System.Drawing.Point(4, 22);
            this.tpGeral.Name = "tpGeral";
            this.tpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeral.Size = new System.Drawing.Size(762, 342);
            this.tpGeral.TabIndex = 0;
            this.tpGeral.Text = "Geral";
            this.tpGeral.UseVisualStyleBackColor = true;
            // 
            // gbDemonstrativoCaixa
            // 
            this.gbDemonstrativoCaixa.Controls.Add(this.dbDemonstrativoCartaoDebito);
            this.gbDemonstrativoCaixa.Controls.Add(this.lbDemonstrativoCartaoDebito);
            this.gbDemonstrativoCaixa.Controls.Add(this.dbDemonstrativoCartaoCredito);
            this.gbDemonstrativoCaixa.Controls.Add(this.lbDemonstrativoCartaoCredito);
            this.gbDemonstrativoCaixa.Controls.Add(this.dbDemonstrativoCheque);
            this.gbDemonstrativoCaixa.Controls.Add(this.lbDemonstrativoCheque);
            this.gbDemonstrativoCaixa.Controls.Add(this.dbDemonstrativoDinheiro);
            this.gbDemonstrativoCaixa.Controls.Add(this.lbDemonstrativoDinheiro);
            this.gbDemonstrativoCaixa.Location = new System.Drawing.Point(136, 3);
            this.gbDemonstrativoCaixa.Name = "gbDemonstrativoCaixa";
            this.gbDemonstrativoCaixa.Size = new System.Drawing.Size(124, 194);
            this.gbDemonstrativoCaixa.TabIndex = 9;
            this.gbDemonstrativoCaixa.TabStop = false;
            this.gbDemonstrativoCaixa.Text = "Demonstrativo";
            // 
            // lbDemonstrativoCartaoDebito
            // 
            this.lbDemonstrativoCartaoDebito.AutoSize = true;
            this.lbDemonstrativoCartaoDebito.Location = new System.Drawing.Point(6, 139);
            this.lbDemonstrativoCartaoDebito.Name = "lbDemonstrativoCartaoDebito";
            this.lbDemonstrativoCartaoDebito.Size = new System.Drawing.Size(85, 13);
            this.lbDemonstrativoCartaoDebito.TabIndex = 6;
            this.lbDemonstrativoCartaoDebito.Text = "Cartão de débito";
            // 
            // lbDemonstrativoCartaoCredito
            // 
            this.lbDemonstrativoCartaoCredito.AutoSize = true;
            this.lbDemonstrativoCartaoCredito.Location = new System.Drawing.Point(6, 98);
            this.lbDemonstrativoCartaoCredito.Name = "lbDemonstrativoCartaoCredito";
            this.lbDemonstrativoCartaoCredito.Size = new System.Drawing.Size(88, 13);
            this.lbDemonstrativoCartaoCredito.TabIndex = 4;
            this.lbDemonstrativoCartaoCredito.Text = "Cartão de crédito";
            // 
            // lbDemonstrativoCheque
            // 
            this.lbDemonstrativoCheque.AutoSize = true;
            this.lbDemonstrativoCheque.Location = new System.Drawing.Point(3, 57);
            this.lbDemonstrativoCheque.Name = "lbDemonstrativoCheque";
            this.lbDemonstrativoCheque.Size = new System.Drawing.Size(44, 13);
            this.lbDemonstrativoCheque.TabIndex = 2;
            this.lbDemonstrativoCheque.Text = "Cheque";
            // 
            // lbDemonstrativoDinheiro
            // 
            this.lbDemonstrativoDinheiro.AutoSize = true;
            this.lbDemonstrativoDinheiro.Location = new System.Drawing.Point(3, 16);
            this.lbDemonstrativoDinheiro.Name = "lbDemonstrativoDinheiro";
            this.lbDemonstrativoDinheiro.Size = new System.Drawing.Size(46, 13);
            this.lbDemonstrativoDinheiro.TabIndex = 0;
            this.lbDemonstrativoDinheiro.Text = "Dinheiro";
            // 
            // gbTotaisConta
            // 
            this.gbTotaisConta.Controls.Add(this.lbFaturamento);
            this.gbTotaisConta.Controls.Add(this.dbCaixaSangria);
            this.gbTotaisConta.Controls.Add(this.lbTotalCaixa);
            this.gbTotaisConta.Controls.Add(this.lbSangrias);
            this.gbTotaisConta.Controls.Add(this.dbCaixaTotal);
            this.gbTotaisConta.Controls.Add(this.dbCaixaFaturamento);
            this.gbTotaisConta.Controls.Add(this.lbAbertura);
            this.gbTotaisConta.Controls.Add(this.dbCaixaAbertura);
            this.gbTotaisConta.Location = new System.Drawing.Point(6, 3);
            this.gbTotaisConta.Name = "gbTotaisConta";
            this.gbTotaisConta.Size = new System.Drawing.Size(124, 194);
            this.gbTotaisConta.TabIndex = 8;
            this.gbTotaisConta.TabStop = false;
            this.gbTotaisConta.Text = "Totais da conta";
            // 
            // lbFaturamento
            // 
            this.lbFaturamento.AutoSize = true;
            this.lbFaturamento.Location = new System.Drawing.Point(6, 60);
            this.lbFaturamento.Name = "lbFaturamento";
            this.lbFaturamento.Size = new System.Drawing.Size(66, 13);
            this.lbFaturamento.TabIndex = 2;
            this.lbFaturamento.Text = "Faturamento";
            // 
            // lbTotalCaixa
            // 
            this.lbTotalCaixa.AutoSize = true;
            this.lbTotalCaixa.Location = new System.Drawing.Point(6, 142);
            this.lbTotalCaixa.Name = "lbTotalCaixa";
            this.lbTotalCaixa.Size = new System.Drawing.Size(76, 13);
            this.lbTotalCaixa.TabIndex = 6;
            this.lbTotalCaixa.Text = "Total em caixa";
            // 
            // lbSangrias
            // 
            this.lbSangrias.AutoSize = true;
            this.lbSangrias.Location = new System.Drawing.Point(6, 101);
            this.lbSangrias.Name = "lbSangrias";
            this.lbSangrias.Size = new System.Drawing.Size(48, 13);
            this.lbSangrias.TabIndex = 4;
            this.lbSangrias.Text = "Sangrias";
            // 
            // lbAbertura
            // 
            this.lbAbertura.AutoSize = true;
            this.lbAbertura.Location = new System.Drawing.Point(6, 19);
            this.lbAbertura.Name = "lbAbertura";
            this.lbAbertura.Size = new System.Drawing.Size(90, 13);
            this.lbAbertura.TabIndex = 0;
            this.lbAbertura.Text = "Abertura de caixa";
            // 
            // tpCheque
            // 
            this.tpCheque.Controls.Add(this.cbTodosCheques);
            this.tpCheque.Controls.Add(this.dgvCheque);
            this.tpCheque.Location = new System.Drawing.Point(4, 22);
            this.tpCheque.Name = "tpCheque";
            this.tpCheque.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheque.Size = new System.Drawing.Size(762, 342);
            this.tpCheque.TabIndex = 1;
            this.tpCheque.Text = "Cheque";
            this.tpCheque.UseVisualStyleBackColor = true;
            // 
            // cbTodosCheques
            // 
            this.cbTodosCheques.AutoSize = true;
            this.cbTodosCheques.Location = new System.Drawing.Point(6, 319);
            this.cbTodosCheques.Name = "cbTodosCheques";
            this.cbTodosCheques.Size = new System.Drawing.Size(144, 17);
            this.cbTodosCheques.TabIndex = 1;
            this.cbTodosCheques.Text = "Marcar todos os registros";
            this.cbTodosCheques.UseVisualStyleBackColor = true;
            // 
            // dgvCheque
            // 
            this.dgvCheque.AllowUserToAddRows = false;
            this.dgvCheque.AllowUserToDeleteRows = false;
            this.dgvCheque.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            this.dgvCheque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheque.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheque.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCheque.Location = new System.Drawing.Point(3, 3);
            this.dgvCheque.Name = "dgvCheque";
            this.dgvCheque.ReadOnly = true;
            this.dgvCheque.Size = new System.Drawing.Size(756, 310);
            this.dgvCheque.TabIndex = 0;
            // 
            // tpCartaoCredito
            // 
            this.tpCartaoCredito.Controls.Add(this.cbTodosCartaoCredito);
            this.tpCartaoCredito.Controls.Add(this.dgvCartaoCredito);
            this.tpCartaoCredito.Location = new System.Drawing.Point(4, 22);
            this.tpCartaoCredito.Name = "tpCartaoCredito";
            this.tpCartaoCredito.Padding = new System.Windows.Forms.Padding(3);
            this.tpCartaoCredito.Size = new System.Drawing.Size(762, 342);
            this.tpCartaoCredito.TabIndex = 2;
            this.tpCartaoCredito.Text = "Cartão de crédito";
            this.tpCartaoCredito.UseVisualStyleBackColor = true;
            // 
            // cbTodosCartaoCredito
            // 
            this.cbTodosCartaoCredito.AutoSize = true;
            this.cbTodosCartaoCredito.Location = new System.Drawing.Point(6, 319);
            this.cbTodosCartaoCredito.Name = "cbTodosCartaoCredito";
            this.cbTodosCartaoCredito.Size = new System.Drawing.Size(144, 17);
            this.cbTodosCartaoCredito.TabIndex = 1;
            this.cbTodosCartaoCredito.Text = "Marcar todos os registros";
            this.cbTodosCartaoCredito.UseVisualStyleBackColor = true;
            // 
            // dgvCartaoCredito
            // 
            this.dgvCartaoCredito.AllowUserToAddRows = false;
            this.dgvCartaoCredito.AllowUserToDeleteRows = false;
            this.dgvCartaoCredito.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            this.dgvCartaoCredito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCartaoCredito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCartaoCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartaoCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCartaoCredito.Location = new System.Drawing.Point(3, 3);
            this.dgvCartaoCredito.Name = "dgvCartaoCredito";
            this.dgvCartaoCredito.ReadOnly = true;
            this.dgvCartaoCredito.Size = new System.Drawing.Size(756, 310);
            this.dgvCartaoCredito.TabIndex = 0;
            // 
            // tpCartaoDebito
            // 
            this.tpCartaoDebito.Controls.Add(this.cbTodosCartaoDebito);
            this.tpCartaoDebito.Controls.Add(this.dgvCartaoDebito);
            this.tpCartaoDebito.Location = new System.Drawing.Point(4, 22);
            this.tpCartaoDebito.Name = "tpCartaoDebito";
            this.tpCartaoDebito.Padding = new System.Windows.Forms.Padding(3);
            this.tpCartaoDebito.Size = new System.Drawing.Size(762, 342);
            this.tpCartaoDebito.TabIndex = 3;
            this.tpCartaoDebito.Text = "Cartão de débito";
            this.tpCartaoDebito.UseVisualStyleBackColor = true;
            // 
            // cbTodosCartaoDebito
            // 
            this.cbTodosCartaoDebito.AutoSize = true;
            this.cbTodosCartaoDebito.Location = new System.Drawing.Point(6, 319);
            this.cbTodosCartaoDebito.Name = "cbTodosCartaoDebito";
            this.cbTodosCartaoDebito.Size = new System.Drawing.Size(144, 17);
            this.cbTodosCartaoDebito.TabIndex = 1;
            this.cbTodosCartaoDebito.Text = "Marcar todos os registros";
            this.cbTodosCartaoDebito.UseVisualStyleBackColor = true;
            // 
            // dgvCartaoDebito
            // 
            this.dgvCartaoDebito.AllowUserToAddRows = false;
            this.dgvCartaoDebito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            this.dgvCartaoDebito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCartaoDebito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCartaoDebito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartaoDebito.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCartaoDebito.Location = new System.Drawing.Point(3, 3);
            this.dgvCartaoDebito.Name = "dgvCartaoDebito";
            this.dgvCartaoDebito.ReadOnly = true;
            this.dgvCartaoDebito.Size = new System.Drawing.Size(756, 310);
            this.dgvCartaoDebito.TabIndex = 0;
            // 
            // gbTotaisSangria
            // 
            this.gbTotaisSangria.Controls.Add(this.dbSangriaTotal);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaTotal);
            this.gbTotaisSangria.Controls.Add(this.btRealizarSangria);
            this.gbTotaisSangria.Controls.Add(this.dbSangriaCartaoDebitoTotal);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaCartaoDebito);
            this.gbTotaisSangria.Controls.Add(this.dbSangriaCartaoCreditoTotal);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaCartaoCredito);
            this.gbTotaisSangria.Controls.Add(this.dbSangriaChequeTotal);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaCheque);
            this.gbTotaisSangria.Controls.Add(this.dbSangriaDinheiroTotal);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaDinheiro);
            this.gbTotaisSangria.Location = new System.Drawing.Point(12, 444);
            this.gbTotaisSangria.Name = "gbTotaisSangria";
            this.gbTotaisSangria.Size = new System.Drawing.Size(776, 77);
            this.gbTotaisSangria.TabIndex = 4;
            this.gbTotaisSangria.TabStop = false;
            this.gbTotaisSangria.Text = "Totais da sangria";
            // 
            // lbSangriaTotal
            // 
            this.lbSangriaTotal.AutoSize = true;
            this.lbSangriaTotal.Location = new System.Drawing.Point(443, 16);
            this.lbSangriaTotal.Name = "lbSangriaTotal";
            this.lbSangriaTotal.Size = new System.Drawing.Size(83, 13);
            this.lbSangriaTotal.TabIndex = 8;
            this.lbSangriaTotal.Text = "Total da sangria";
            // 
            // btRealizarSangria
            // 
            this.btRealizarSangria.Location = new System.Drawing.Point(552, 32);
            this.btRealizarSangria.Name = "btRealizarSangria";
            this.btRealizarSangria.Size = new System.Drawing.Size(75, 23);
            this.btRealizarSangria.TabIndex = 10;
            this.btRealizarSangria.Text = "Finalizar";
            this.btRealizarSangria.UseVisualStyleBackColor = true;
            // 
            // lbSangriaCartaoDebito
            // 
            this.lbSangriaCartaoDebito.AutoSize = true;
            this.lbSangriaCartaoDebito.Location = new System.Drawing.Point(334, 16);
            this.lbSangriaCartaoDebito.Name = "lbSangriaCartaoDebito";
            this.lbSangriaCartaoDebito.Size = new System.Drawing.Size(85, 13);
            this.lbSangriaCartaoDebito.TabIndex = 6;
            this.lbSangriaCartaoDebito.Text = "Cartão de débito";
            // 
            // lbSangriaCartaoCredito
            // 
            this.lbSangriaCartaoCredito.AutoSize = true;
            this.lbSangriaCartaoCredito.Location = new System.Drawing.Point(228, 16);
            this.lbSangriaCartaoCredito.Name = "lbSangriaCartaoCredito";
            this.lbSangriaCartaoCredito.Size = new System.Drawing.Size(88, 13);
            this.lbSangriaCartaoCredito.TabIndex = 4;
            this.lbSangriaCartaoCredito.Text = "Cartão de crédito";
            // 
            // lbSangriaCheque
            // 
            this.lbSangriaCheque.AutoSize = true;
            this.lbSangriaCheque.Location = new System.Drawing.Point(116, 16);
            this.lbSangriaCheque.Name = "lbSangriaCheque";
            this.lbSangriaCheque.Size = new System.Drawing.Size(49, 13);
            this.lbSangriaCheque.TabIndex = 2;
            this.lbSangriaCheque.Text = "Cheques";
            // 
            // lbSangriaDinheiro
            // 
            this.lbSangriaDinheiro.AutoSize = true;
            this.lbSangriaDinheiro.Location = new System.Drawing.Point(6, 16);
            this.lbSangriaDinheiro.Name = "lbSangriaDinheiro";
            this.lbSangriaDinheiro.Size = new System.Drawing.Size(46, 13);
            this.lbSangriaDinheiro.TabIndex = 0;
            this.lbSangriaDinheiro.Text = "Dinheiro";
            // 
            // dbSangriaTotal
            // 
            this.dbSangriaTotal.Enabled = false;
            this.dbSangriaTotal.Location = new System.Drawing.Point(446, 32);
            this.dbSangriaTotal.Name = "dbSangriaTotal";
            this.dbSangriaTotal.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaTotal.TabIndex = 9;
            this.dbSangriaTotal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbSangriaCartaoDebitoTotal
            // 
            this.dbSangriaCartaoDebitoTotal.Enabled = false;
            this.dbSangriaCartaoDebitoTotal.Location = new System.Drawing.Point(337, 32);
            this.dbSangriaCartaoDebitoTotal.Name = "dbSangriaCartaoDebitoTotal";
            this.dbSangriaCartaoDebitoTotal.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaCartaoDebitoTotal.TabIndex = 7;
            this.dbSangriaCartaoDebitoTotal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbSangriaCartaoCreditoTotal
            // 
            this.dbSangriaCartaoCreditoTotal.Enabled = false;
            this.dbSangriaCartaoCreditoTotal.Location = new System.Drawing.Point(231, 32);
            this.dbSangriaCartaoCreditoTotal.Name = "dbSangriaCartaoCreditoTotal";
            this.dbSangriaCartaoCreditoTotal.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaCartaoCreditoTotal.TabIndex = 5;
            this.dbSangriaCartaoCreditoTotal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbSangriaChequeTotal
            // 
            this.dbSangriaChequeTotal.Enabled = false;
            this.dbSangriaChequeTotal.Location = new System.Drawing.Point(119, 32);
            this.dbSangriaChequeTotal.Name = "dbSangriaChequeTotal";
            this.dbSangriaChequeTotal.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaChequeTotal.TabIndex = 3;
            this.dbSangriaChequeTotal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbSangriaDinheiroTotal
            // 
            this.dbSangriaDinheiroTotal.Location = new System.Drawing.Point(9, 32);
            this.dbSangriaDinheiroTotal.Name = "dbSangriaDinheiroTotal";
            this.dbSangriaDinheiroTotal.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaDinheiroTotal.TabIndex = 1;
            this.dbSangriaDinheiroTotal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbDemonstrativoCartaoDebito
            // 
            this.dbDemonstrativoCartaoDebito.Enabled = false;
            this.dbDemonstrativoCartaoDebito.Location = new System.Drawing.Point(6, 155);
            this.dbDemonstrativoCartaoDebito.Name = "dbDemonstrativoCartaoDebito";
            this.dbDemonstrativoCartaoDebito.Size = new System.Drawing.Size(100, 22);
            this.dbDemonstrativoCartaoDebito.TabIndex = 7;
            this.dbDemonstrativoCartaoDebito.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbDemonstrativoCartaoCredito
            // 
            this.dbDemonstrativoCartaoCredito.Enabled = false;
            this.dbDemonstrativoCartaoCredito.Location = new System.Drawing.Point(6, 114);
            this.dbDemonstrativoCartaoCredito.Name = "dbDemonstrativoCartaoCredito";
            this.dbDemonstrativoCartaoCredito.Size = new System.Drawing.Size(100, 22);
            this.dbDemonstrativoCartaoCredito.TabIndex = 5;
            this.dbDemonstrativoCartaoCredito.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbDemonstrativoCheque
            // 
            this.dbDemonstrativoCheque.Enabled = false;
            this.dbDemonstrativoCheque.Location = new System.Drawing.Point(6, 73);
            this.dbDemonstrativoCheque.Name = "dbDemonstrativoCheque";
            this.dbDemonstrativoCheque.Size = new System.Drawing.Size(100, 22);
            this.dbDemonstrativoCheque.TabIndex = 3;
            this.dbDemonstrativoCheque.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbDemonstrativoDinheiro
            // 
            this.dbDemonstrativoDinheiro.Enabled = false;
            this.dbDemonstrativoDinheiro.Location = new System.Drawing.Point(6, 32);
            this.dbDemonstrativoDinheiro.Name = "dbDemonstrativoDinheiro";
            this.dbDemonstrativoDinheiro.Size = new System.Drawing.Size(100, 22);
            this.dbDemonstrativoDinheiro.TabIndex = 1;
            this.dbDemonstrativoDinheiro.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbCaixaSangria
            // 
            this.dbCaixaSangria.Enabled = false;
            this.dbCaixaSangria.ForeColor = System.Drawing.Color.Red;
            this.dbCaixaSangria.Location = new System.Drawing.Point(9, 117);
            this.dbCaixaSangria.Name = "dbCaixaSangria";
            this.dbCaixaSangria.Size = new System.Drawing.Size(100, 22);
            this.dbCaixaSangria.TabIndex = 5;
            this.dbCaixaSangria.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbCaixaTotal
            // 
            this.dbCaixaTotal.Enabled = false;
            this.dbCaixaTotal.Location = new System.Drawing.Point(9, 158);
            this.dbCaixaTotal.Name = "dbCaixaTotal";
            this.dbCaixaTotal.Size = new System.Drawing.Size(100, 22);
            this.dbCaixaTotal.TabIndex = 7;
            this.dbCaixaTotal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbCaixaFaturamento
            // 
            this.dbCaixaFaturamento.Enabled = false;
            this.dbCaixaFaturamento.ForeColor = System.Drawing.Color.Lime;
            this.dbCaixaFaturamento.Location = new System.Drawing.Point(9, 76);
            this.dbCaixaFaturamento.Name = "dbCaixaFaturamento";
            this.dbCaixaFaturamento.Size = new System.Drawing.Size(100, 22);
            this.dbCaixaFaturamento.TabIndex = 3;
            this.dbCaixaFaturamento.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbCaixaAbertura
            // 
            this.dbCaixaAbertura.Enabled = false;
            this.dbCaixaAbertura.Location = new System.Drawing.Point(9, 35);
            this.dbCaixaAbertura.Name = "dbCaixaAbertura";
            this.dbCaixaAbertura.Size = new System.Drawing.Size(100, 22);
            this.dbCaixaAbertura.TabIndex = 1;
            this.dbCaixaAbertura.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // buscaCaixa
            // 
            this.buscaCaixa.BackColor = System.Drawing.Color.White;
            this.buscaCaixa.Location = new System.Drawing.Point(9, 9);
            this.buscaCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCaixa.Name = "buscaCaixa";
            this.buscaCaixa.Size = new System.Drawing.Size(264, 39);
            this.buscaCaixa.TabIndex = 0;
            this.buscaCaixa.Leave += new System.EventHandler(this.BuscaCaixa_Leave);
            // 
            // fmCaiSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.gbTotaisSangria);
            this.Controls.Add(this.gbSangria);
            this.Controls.Add(this.tbStatusCaixa);
            this.Controls.Add(this.lbStatusCaixa);
            this.Controls.Add(this.buscaCaixa);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCaiSangria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangria de caixa";
            this.gbSangria.ResumeLayout(false);
            this.tcSangria.ResumeLayout(false);
            this.tpGeral.ResumeLayout(false);
            this.gbDemonstrativoCaixa.ResumeLayout(false);
            this.gbDemonstrativoCaixa.PerformLayout();
            this.gbTotaisConta.ResumeLayout(false);
            this.gbTotaisConta.PerformLayout();
            this.tpCheque.ResumeLayout(false);
            this.tpCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).EndInit();
            this.tpCartaoCredito.ResumeLayout(false);
            this.tpCartaoCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartaoCredito)).EndInit();
            this.tpCartaoDebito.ResumeLayout(false);
            this.tpCartaoDebito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartaoDebito)).EndInit();
            this.gbTotaisSangria.ResumeLayout(false);
            this.gbTotaisSangria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.BuscaCaixa buscaCaixa;
        private System.Windows.Forms.TextBox tbStatusCaixa;
        private System.Windows.Forms.Label lbStatusCaixa;
        private System.Windows.Forms.GroupBox gbSangria;
        private System.Windows.Forms.TabControl tcSangria;
        private System.Windows.Forms.TabPage tpGeral;
        private System.Windows.Forms.TabPage tpCheque;
        private System.Windows.Forms.DataGridView dgvCheque;
        private System.Windows.Forms.TabPage tpCartaoCredito;
        private System.Windows.Forms.CheckBox cbTodosCheques;
        private System.Windows.Forms.CheckBox cbTodosCartaoCredito;
        private System.Windows.Forms.DataGridView dgvCartaoCredito;
        private System.Windows.Forms.TabPage tpCartaoDebito;
        private System.Windows.Forms.CheckBox cbTodosCartaoDebito;
        private System.Windows.Forms.DataGridView dgvCartaoDebito;
        private Controls.DecimalBox dbCaixaTotal;
        private System.Windows.Forms.Label lbTotalCaixa;
        private Controls.DecimalBox dbCaixaSangria;
        private System.Windows.Forms.Label lbSangrias;
        private Controls.DecimalBox dbCaixaFaturamento;
        private System.Windows.Forms.Label lbFaturamento;
        private Controls.DecimalBox dbCaixaAbertura;
        private System.Windows.Forms.Label lbAbertura;
        private System.Windows.Forms.GroupBox gbDemonstrativoCaixa;
        private Controls.DecimalBox dbDemonstrativoCheque;
        private System.Windows.Forms.Label lbDemonstrativoCheque;
        private Controls.DecimalBox dbDemonstrativoDinheiro;
        private System.Windows.Forms.Label lbDemonstrativoDinheiro;
        private System.Windows.Forms.GroupBox gbTotaisConta;
        private Controls.DecimalBox dbDemonstrativoCartaoDebito;
        private System.Windows.Forms.Label lbDemonstrativoCartaoDebito;
        private Controls.DecimalBox dbDemonstrativoCartaoCredito;
        private System.Windows.Forms.Label lbDemonstrativoCartaoCredito;
        private System.Windows.Forms.GroupBox gbTotaisSangria;
        private Controls.DecimalBox dbSangriaTotal;
        private System.Windows.Forms.Label lbSangriaTotal;
        private System.Windows.Forms.Button btRealizarSangria;
        private Controls.DecimalBox dbSangriaCartaoDebitoTotal;
        private System.Windows.Forms.Label lbSangriaCartaoDebito;
        private Controls.DecimalBox dbSangriaCartaoCreditoTotal;
        private System.Windows.Forms.Label lbSangriaCartaoCredito;
        private Controls.DecimalBox dbSangriaChequeTotal;
        private System.Windows.Forms.Label lbSangriaCheque;
        private Controls.DecimalBox dbSangriaDinheiroTotal;
        private System.Windows.Forms.Label lbSangriaDinheiro;
    }
}