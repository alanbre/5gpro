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
            this.buscaCaixa = new _5gpro.Controls.BuscaCaixa();
            this.tbStatusCaixa = new System.Windows.Forms.TextBox();
            this.lbStatusCaixa = new System.Windows.Forms.Label();
            this.gbSangria = new System.Windows.Forms.GroupBox();
            this.tcSangria = new System.Windows.Forms.TabControl();
            this.tpDinheiro = new System.Windows.Forms.TabPage();
            this.tpCheque = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpCartaoCredito = new System.Windows.Forms.TabPage();
            this.tpCartaoDebito = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cbTodosCheques = new System.Windows.Forms.CheckBox();
            this.cbTodosCartaoCredito = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbSangria.SuspendLayout();
            this.tcSangria.SuspendLayout();
            this.tpCheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpCartaoCredito.SuspendLayout();
            this.tpCartaoDebito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
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
            // tbStatusCaixa
            // 
            this.tbStatusCaixa.Enabled = false;
            this.tbStatusCaixa.Location = new System.Drawing.Point(279, 25);
            this.tbStatusCaixa.Name = "tbStatusCaixa";
            this.tbStatusCaixa.Size = new System.Drawing.Size(100, 20);
            this.tbStatusCaixa.TabIndex = 4;
            // 
            // lbStatusCaixa
            // 
            this.lbStatusCaixa.AutoSize = true;
            this.lbStatusCaixa.Location = new System.Drawing.Point(276, 9);
            this.lbStatusCaixa.Name = "lbStatusCaixa";
            this.lbStatusCaixa.Size = new System.Drawing.Size(37, 13);
            this.lbStatusCaixa.TabIndex = 3;
            this.lbStatusCaixa.Text = "Status";
            // 
            // gbSangria
            // 
            this.gbSangria.Controls.Add(this.tcSangria);
            this.gbSangria.Location = new System.Drawing.Point(12, 51);
            this.gbSangria.Name = "gbSangria";
            this.gbSangria.Size = new System.Drawing.Size(776, 387);
            this.gbSangria.TabIndex = 5;
            this.gbSangria.TabStop = false;
            this.gbSangria.Text = "Sangria";
            // 
            // tcSangria
            // 
            this.tcSangria.Controls.Add(this.tpDinheiro);
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
            // tpDinheiro
            // 
            this.tpDinheiro.Location = new System.Drawing.Point(4, 22);
            this.tpDinheiro.Name = "tpDinheiro";
            this.tpDinheiro.Padding = new System.Windows.Forms.Padding(3);
            this.tpDinheiro.Size = new System.Drawing.Size(762, 342);
            this.tpDinheiro.TabIndex = 0;
            this.tpDinheiro.Text = "Dinheiro";
            this.tpDinheiro.UseVisualStyleBackColor = true;
            // 
            // tpCheque
            // 
            this.tpCheque.Controls.Add(this.cbTodosCheques);
            this.tpCheque.Controls.Add(this.dataGridView1);
            this.tpCheque.Location = new System.Drawing.Point(4, 22);
            this.tpCheque.Name = "tpCheque";
            this.tpCheque.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheque.Size = new System.Drawing.Size(762, 342);
            this.tpCheque.TabIndex = 1;
            this.tpCheque.Text = "Cheque";
            this.tpCheque.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(756, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpCartaoCredito
            // 
            this.tpCartaoCredito.Controls.Add(this.cbTodosCartaoCredito);
            this.tpCartaoCredito.Controls.Add(this.dataGridView2);
            this.tpCartaoCredito.Location = new System.Drawing.Point(4, 22);
            this.tpCartaoCredito.Name = "tpCartaoCredito";
            this.tpCartaoCredito.Padding = new System.Windows.Forms.Padding(3);
            this.tpCartaoCredito.Size = new System.Drawing.Size(762, 342);
            this.tpCartaoCredito.TabIndex = 2;
            this.tpCartaoCredito.Text = "Cartão de crédito";
            this.tpCartaoCredito.UseVisualStyleBackColor = true;
            // 
            // tpCartaoDebito
            // 
            this.tpCartaoDebito.Controls.Add(this.checkBox1);
            this.tpCartaoDebito.Controls.Add(this.dataGridView3);
            this.tpCartaoDebito.Location = new System.Drawing.Point(4, 22);
            this.tpCartaoDebito.Name = "tpCartaoDebito";
            this.tpCartaoDebito.Padding = new System.Windows.Forms.Padding(3);
            this.tpCartaoDebito.Size = new System.Drawing.Size(762, 342);
            this.tpCartaoDebito.TabIndex = 3;
            this.tpCartaoDebito.Text = "Cartão de débito";
            this.tpCartaoDebito.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(756, 310);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(756, 310);
            this.dataGridView3.TabIndex = 0;
            // 
            // cbTodosCheques
            // 
            this.cbTodosCheques.AutoSize = true;
            this.cbTodosCheques.Location = new System.Drawing.Point(6, 319);
            this.cbTodosCheques.Name = "cbTodosCheques";
            this.cbTodosCheques.Size = new System.Drawing.Size(144, 17);
            this.cbTodosCheques.TabIndex = 2;
            this.cbTodosCheques.Text = "Marcar todos os registros";
            this.cbTodosCheques.UseVisualStyleBackColor = true;
            // 
            // cbTodosCartaoCredito
            // 
            this.cbTodosCartaoCredito.AutoSize = true;
            this.cbTodosCartaoCredito.Location = new System.Drawing.Point(6, 319);
            this.cbTodosCartaoCredito.Name = "cbTodosCartaoCredito";
            this.cbTodosCartaoCredito.Size = new System.Drawing.Size(144, 17);
            this.cbTodosCartaoCredito.TabIndex = 3;
            this.cbTodosCartaoCredito.Text = "Marcar todos os registros";
            this.cbTodosCartaoCredito.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 319);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Marcar todos os registros";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fmCaiSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 521);
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
            this.tpCheque.ResumeLayout(false);
            this.tpCheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpCartaoCredito.ResumeLayout(false);
            this.tpCartaoCredito.PerformLayout();
            this.tpCartaoDebito.ResumeLayout(false);
            this.tpCartaoDebito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.BuscaCaixa buscaCaixa;
        private System.Windows.Forms.TextBox tbStatusCaixa;
        private System.Windows.Forms.Label lbStatusCaixa;
        private System.Windows.Forms.GroupBox gbSangria;
        private System.Windows.Forms.TabControl tcSangria;
        private System.Windows.Forms.TabPage tpDinheiro;
        private System.Windows.Forms.TabPage tpCheque;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tpCartaoCredito;
        private System.Windows.Forms.CheckBox cbTodosCheques;
        private System.Windows.Forms.CheckBox cbTodosCartaoCredito;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tpCartaoDebito;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}