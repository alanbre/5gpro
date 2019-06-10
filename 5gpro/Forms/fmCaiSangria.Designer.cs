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
            this.dbSangria = new _5gpro.Controls.DecimalBox();
            this.lbSangrias = new System.Windows.Forms.Label();
            this.dbFaturamento = new _5gpro.Controls.DecimalBox();
            this.lbFaturamento = new System.Windows.Forms.Label();
            this.dbAberturaCaixa = new _5gpro.Controls.DecimalBox();
            this.lbAbertura = new System.Windows.Forms.Label();
            this.dbDinheiroCaixa = new _5gpro.Controls.DecimalBox();
            this.lbTotalCaixa = new System.Windows.Forms.Label();
            this.tpCheque = new System.Windows.Forms.TabPage();
            this.cbTodosCheques = new System.Windows.Forms.CheckBox();
            this.dgvCheque = new System.Windows.Forms.DataGridView();
            this.tpCartaoCredito = new System.Windows.Forms.TabPage();
            this.cbTodosCartaoCredito = new System.Windows.Forms.CheckBox();
            this.dgvCartaoCredito = new System.Windows.Forms.DataGridView();
            this.tpCartaoDebito = new System.Windows.Forms.TabPage();
            this.cbTodosCartaoDebito = new System.Windows.Forms.CheckBox();
            this.dgvCartaoDebito = new System.Windows.Forms.DataGridView();
            this.buscaCaixa = new _5gpro.Controls.BuscaCaixa();
            this.gbTotaisConta = new System.Windows.Forms.GroupBox();
            this.gbDemonstrativoCaixa = new System.Windows.Forms.GroupBox();
            this.lbDemonstrativoDinheiro = new System.Windows.Forms.Label();
            this.dbDemonstrativoDinheiro = new _5gpro.Controls.DecimalBox();
            this.lbDemonstrativoCheque = new System.Windows.Forms.Label();
            this.dbDemonstrativoCheque = new _5gpro.Controls.DecimalBox();
            this.lbDemonstrativoCartaoCredito = new System.Windows.Forms.Label();
            this.dbDemonstrativoCartaoCredito = new _5gpro.Controls.DecimalBox();
            this.lbDemonstrativoCartaoDebito = new System.Windows.Forms.Label();
            this.dbDemonstrativoCartaoDebito = new _5gpro.Controls.DecimalBox();
            this.gbTotaisSangria = new System.Windows.Forms.GroupBox();
            this.lbSangriaDinheiro = new System.Windows.Forms.Label();
            this.dbSangriaDinheiro = new _5gpro.Controls.DecimalBox();
            this.dbSangriaCheque = new _5gpro.Controls.DecimalBox();
            this.lbSangriaCheque = new System.Windows.Forms.Label();
            this.dbSangriaCartaoCredito = new _5gpro.Controls.DecimalBox();
            this.lbSangriaCartaoCredito = new System.Windows.Forms.Label();
            this.dbSangriaCartaoDebito = new _5gpro.Controls.DecimalBox();
            this.lbSangriaCartaoDebito = new System.Windows.Forms.Label();
            this.btRealizarSangria = new System.Windows.Forms.Button();
            this.dbSangriaTotal = new _5gpro.Controls.DecimalBox();
            this.lbSangriaTotal = new System.Windows.Forms.Label();
            this.gbSangria.SuspendLayout();
            this.tcSangria.SuspendLayout();
            this.tpGeral.SuspendLayout();
            this.tpCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).BeginInit();
            this.tpCartaoCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartaoCredito)).BeginInit();
            this.tpCartaoDebito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartaoDebito)).BeginInit();
            this.gbTotaisConta.SuspendLayout();
            this.gbDemonstrativoCaixa.SuspendLayout();
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
            // dbSangria
            // 
            this.dbSangria.ForeColor = System.Drawing.Color.Red;
            this.dbSangria.Location = new System.Drawing.Point(9, 117);
            this.dbSangria.Name = "dbSangria";
            this.dbSangria.Size = new System.Drawing.Size(100, 22);
            this.dbSangria.TabIndex = 5;
            this.dbSangria.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // dbFaturamento
            // 
            this.dbFaturamento.ForeColor = System.Drawing.Color.Lime;
            this.dbFaturamento.Location = new System.Drawing.Point(9, 76);
            this.dbFaturamento.Name = "dbFaturamento";
            this.dbFaturamento.Size = new System.Drawing.Size(100, 22);
            this.dbFaturamento.TabIndex = 3;
            this.dbFaturamento.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // dbAberturaCaixa
            // 
            this.dbAberturaCaixa.Location = new System.Drawing.Point(9, 35);
            this.dbAberturaCaixa.Name = "dbAberturaCaixa";
            this.dbAberturaCaixa.Size = new System.Drawing.Size(100, 22);
            this.dbAberturaCaixa.TabIndex = 1;
            this.dbAberturaCaixa.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // dbDinheiroCaixa
            // 
            this.dbDinheiroCaixa.Location = new System.Drawing.Point(9, 158);
            this.dbDinheiroCaixa.Name = "dbDinheiroCaixa";
            this.dbDinheiroCaixa.Size = new System.Drawing.Size(100, 22);
            this.dbDinheiroCaixa.TabIndex = 7;
            this.dbDinheiroCaixa.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // buscaCaixa
            // 
            this.buscaCaixa.BackColor = System.Drawing.Color.White;
            this.buscaCaixa.Location = new System.Drawing.Point(9, 9);
            this.buscaCaixa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCaixa.Name = "buscaCaixa";
            this.buscaCaixa.Size = new System.Drawing.Size(264, 39);
            this.buscaCaixa.TabIndex = 0;
            // 
            // gbTotaisConta
            // 
            this.gbTotaisConta.Controls.Add(this.lbFaturamento);
            this.gbTotaisConta.Controls.Add(this.dbSangria);
            this.gbTotaisConta.Controls.Add(this.lbTotalCaixa);
            this.gbTotaisConta.Controls.Add(this.lbSangrias);
            this.gbTotaisConta.Controls.Add(this.dbDinheiroCaixa);
            this.gbTotaisConta.Controls.Add(this.dbFaturamento);
            this.gbTotaisConta.Controls.Add(this.lbAbertura);
            this.gbTotaisConta.Controls.Add(this.dbAberturaCaixa);
            this.gbTotaisConta.Location = new System.Drawing.Point(6, 3);
            this.gbTotaisConta.Name = "gbTotaisConta";
            this.gbTotaisConta.Size = new System.Drawing.Size(124, 194);
            this.gbTotaisConta.TabIndex = 8;
            this.gbTotaisConta.TabStop = false;
            this.gbTotaisConta.Text = "Totais da conta";
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
            // lbDemonstrativoDinheiro
            // 
            this.lbDemonstrativoDinheiro.AutoSize = true;
            this.lbDemonstrativoDinheiro.Location = new System.Drawing.Point(3, 16);
            this.lbDemonstrativoDinheiro.Name = "lbDemonstrativoDinheiro";
            this.lbDemonstrativoDinheiro.Size = new System.Drawing.Size(46, 13);
            this.lbDemonstrativoDinheiro.TabIndex = 0;
            this.lbDemonstrativoDinheiro.Text = "Dinheiro";
            // 
            // dbDemonstrativoDinheiro
            // 
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
            // lbDemonstrativoCheque
            // 
            this.lbDemonstrativoCheque.AutoSize = true;
            this.lbDemonstrativoCheque.Location = new System.Drawing.Point(3, 57);
            this.lbDemonstrativoCheque.Name = "lbDemonstrativoCheque";
            this.lbDemonstrativoCheque.Size = new System.Drawing.Size(44, 13);
            this.lbDemonstrativoCheque.TabIndex = 2;
            this.lbDemonstrativoCheque.Text = "Cheque";
            // 
            // dbDemonstrativoCheque
            // 
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
            // lbDemonstrativoCartaoCredito
            // 
            this.lbDemonstrativoCartaoCredito.AutoSize = true;
            this.lbDemonstrativoCartaoCredito.Location = new System.Drawing.Point(6, 98);
            this.lbDemonstrativoCartaoCredito.Name = "lbDemonstrativoCartaoCredito";
            this.lbDemonstrativoCartaoCredito.Size = new System.Drawing.Size(88, 13);
            this.lbDemonstrativoCartaoCredito.TabIndex = 4;
            this.lbDemonstrativoCartaoCredito.Text = "Cartão de crédito";
            // 
            // dbDemonstrativoCartaoCredito
            // 
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
            // lbDemonstrativoCartaoDebito
            // 
            this.lbDemonstrativoCartaoDebito.AutoSize = true;
            this.lbDemonstrativoCartaoDebito.Location = new System.Drawing.Point(6, 139);
            this.lbDemonstrativoCartaoDebito.Name = "lbDemonstrativoCartaoDebito";
            this.lbDemonstrativoCartaoDebito.Size = new System.Drawing.Size(85, 13);
            this.lbDemonstrativoCartaoDebito.TabIndex = 6;
            this.lbDemonstrativoCartaoDebito.Text = "Cartão de débito";
            // 
            // dbDemonstrativoCartaoDebito
            // 
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
            // gbTotaisSangria
            // 
            this.gbTotaisSangria.Controls.Add(this.dbSangriaTotal);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaTotal);
            this.gbTotaisSangria.Controls.Add(this.btRealizarSangria);
            this.gbTotaisSangria.Controls.Add(this.dbSangriaCartaoDebito);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaCartaoDebito);
            this.gbTotaisSangria.Controls.Add(this.dbSangriaCartaoCredito);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaCartaoCredito);
            this.gbTotaisSangria.Controls.Add(this.dbSangriaCheque);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaCheque);
            this.gbTotaisSangria.Controls.Add(this.dbSangriaDinheiro);
            this.gbTotaisSangria.Controls.Add(this.lbSangriaDinheiro);
            this.gbTotaisSangria.Location = new System.Drawing.Point(12, 444);
            this.gbTotaisSangria.Name = "gbTotaisSangria";
            this.gbTotaisSangria.Size = new System.Drawing.Size(776, 77);
            this.gbTotaisSangria.TabIndex = 4;
            this.gbTotaisSangria.TabStop = false;
            this.gbTotaisSangria.Text = "Totais da sangria";
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
            // dbSangriaDinheiro
            // 
            this.dbSangriaDinheiro.Location = new System.Drawing.Point(9, 32);
            this.dbSangriaDinheiro.Name = "dbSangriaDinheiro";
            this.dbSangriaDinheiro.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaDinheiro.TabIndex = 1;
            this.dbSangriaDinheiro.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbSangriaCheque
            // 
            this.dbSangriaCheque.Enabled = false;
            this.dbSangriaCheque.Location = new System.Drawing.Point(119, 32);
            this.dbSangriaCheque.Name = "dbSangriaCheque";
            this.dbSangriaCheque.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaCheque.TabIndex = 3;
            this.dbSangriaCheque.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // dbSangriaCartaoCredito
            // 
            this.dbSangriaCartaoCredito.Enabled = false;
            this.dbSangriaCartaoCredito.Location = new System.Drawing.Point(231, 32);
            this.dbSangriaCartaoCredito.Name = "dbSangriaCartaoCredito";
            this.dbSangriaCartaoCredito.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaCartaoCredito.TabIndex = 5;
            this.dbSangriaCartaoCredito.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // dbSangriaCartaoDebito
            // 
            this.dbSangriaCartaoDebito.Enabled = false;
            this.dbSangriaCartaoDebito.Location = new System.Drawing.Point(337, 32);
            this.dbSangriaCartaoDebito.Name = "dbSangriaCartaoDebito";
            this.dbSangriaCartaoDebito.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaCartaoDebito.TabIndex = 7;
            this.dbSangriaCartaoDebito.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
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
            // btRealizarSangria
            // 
            this.btRealizarSangria.Location = new System.Drawing.Point(552, 32);
            this.btRealizarSangria.Name = "btRealizarSangria";
            this.btRealizarSangria.Size = new System.Drawing.Size(75, 23);
            this.btRealizarSangria.TabIndex = 8;
            this.btRealizarSangria.Text = "Finalizar";
            this.btRealizarSangria.UseVisualStyleBackColor = true;
            // 
            // dbSangriaTotal
            // 
            this.dbSangriaTotal.Enabled = false;
            this.dbSangriaTotal.Location = new System.Drawing.Point(446, 32);
            this.dbSangriaTotal.Name = "dbSangriaTotal";
            this.dbSangriaTotal.Size = new System.Drawing.Size(100, 22);
            this.dbSangriaTotal.TabIndex = 10;
            this.dbSangriaTotal.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbSangriaTotal
            // 
            this.lbSangriaTotal.AutoSize = true;
            this.lbSangriaTotal.Location = new System.Drawing.Point(443, 16);
            this.lbSangriaTotal.Name = "lbSangriaTotal";
            this.lbSangriaTotal.Size = new System.Drawing.Size(83, 13);
            this.lbSangriaTotal.TabIndex = 9;
            this.lbSangriaTotal.Text = "Total da sangria";
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
            this.tpCheque.ResumeLayout(false);
            this.tpCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).EndInit();
            this.tpCartaoCredito.ResumeLayout(false);
            this.tpCartaoCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartaoCredito)).EndInit();
            this.tpCartaoDebito.ResumeLayout(false);
            this.tpCartaoDebito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartaoDebito)).EndInit();
            this.gbTotaisConta.ResumeLayout(false);
            this.gbTotaisConta.PerformLayout();
            this.gbDemonstrativoCaixa.ResumeLayout(false);
            this.gbDemonstrativoCaixa.PerformLayout();
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
        private Controls.DecimalBox dbDinheiroCaixa;
        private System.Windows.Forms.Label lbTotalCaixa;
        private Controls.DecimalBox dbSangria;
        private System.Windows.Forms.Label lbSangrias;
        private Controls.DecimalBox dbFaturamento;
        private System.Windows.Forms.Label lbFaturamento;
        private Controls.DecimalBox dbAberturaCaixa;
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
        private Controls.DecimalBox dbSangriaCartaoDebito;
        private System.Windows.Forms.Label lbSangriaCartaoDebito;
        private Controls.DecimalBox dbSangriaCartaoCredito;
        private System.Windows.Forms.Label lbSangriaCartaoCredito;
        private Controls.DecimalBox dbSangriaCheque;
        private System.Windows.Forms.Label lbSangriaCheque;
        private Controls.DecimalBox dbSangriaDinheiro;
        private System.Windows.Forms.Label lbSangriaDinheiro;
    }
}