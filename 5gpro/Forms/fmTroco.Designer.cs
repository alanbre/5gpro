namespace _5gpro.Forms
{
    partial class fmTroco
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
            this.lbTotal = new System.Windows.Forms.Label();
            this.pnTotal = new System.Windows.Forms.Panel();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.gbFormasPagamento = new System.Windows.Forms.GroupBox();
            this.tbNomeFormaPagamento7 = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento7 = new System.Windows.Forms.TextBox();
            this.tbNomeFormaPagamento6 = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento6 = new System.Windows.Forms.TextBox();
            this.tbNomeFormaPagamento5 = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento5 = new System.Windows.Forms.TextBox();
            this.tbNomeFormaPagamento4 = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento4 = new System.Windows.Forms.TextBox();
            this.tbNomeFormaPagamento3 = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento3 = new System.Windows.Forms.TextBox();
            this.tbNomeFormaPagamento2 = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento2 = new System.Windows.Forms.TextBox();
            this.tbNomeFormaPagamento1 = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento1 = new System.Windows.Forms.TextBox();
            this.pnTroco = new System.Windows.Forms.Panel();
            this.lbValorTroco = new System.Windows.Forms.Label();
            this.lbTroco = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.dbPagamento1 = new _5gpro.Controls.DecimalBox();
            this.dbPagamento2 = new _5gpro.Controls.DecimalBox();
            this.dbPagamento3 = new _5gpro.Controls.DecimalBox();
            this.dbPagamento6 = new _5gpro.Controls.DecimalBox();
            this.dbPagamento5 = new _5gpro.Controls.DecimalBox();
            this.dbPagamento4 = new _5gpro.Controls.DecimalBox();
            this.dbPagamento7 = new _5gpro.Controls.DecimalBox();
            this.pnTotal.SuspendLayout();
            this.gbFormasPagamento.SuspendLayout();
            this.pnTroco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(3, 9);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(115, 20);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "Total a pagar";
            // 
            // pnTotal
            // 
            this.pnTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTotal.Controls.Add(this.lbValorTotal);
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Location = new System.Drawing.Point(12, 12);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(299, 42);
            this.pnTotal.TabIndex = 0;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(222, 9);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(72, 20);
            this.lbValorTotal.TabIndex = 1;
            this.lbValorTotal.Text = "R$ 0,00";
            // 
            // gbFormasPagamento
            // 
            this.gbFormasPagamento.Controls.Add(this.dbPagamento7);
            this.gbFormasPagamento.Controls.Add(this.dbPagamento6);
            this.gbFormasPagamento.Controls.Add(this.dbPagamento5);
            this.gbFormasPagamento.Controls.Add(this.dbPagamento4);
            this.gbFormasPagamento.Controls.Add(this.dbPagamento3);
            this.gbFormasPagamento.Controls.Add(this.dbPagamento2);
            this.gbFormasPagamento.Controls.Add(this.dbPagamento1);
            this.gbFormasPagamento.Controls.Add(this.tbNomeFormaPagamento7);
            this.gbFormasPagamento.Controls.Add(this.tbCodigoFormaPagamento7);
            this.gbFormasPagamento.Controls.Add(this.tbNomeFormaPagamento6);
            this.gbFormasPagamento.Controls.Add(this.tbCodigoFormaPagamento6);
            this.gbFormasPagamento.Controls.Add(this.tbNomeFormaPagamento5);
            this.gbFormasPagamento.Controls.Add(this.tbCodigoFormaPagamento5);
            this.gbFormasPagamento.Controls.Add(this.tbNomeFormaPagamento4);
            this.gbFormasPagamento.Controls.Add(this.tbCodigoFormaPagamento4);
            this.gbFormasPagamento.Controls.Add(this.tbNomeFormaPagamento3);
            this.gbFormasPagamento.Controls.Add(this.tbCodigoFormaPagamento3);
            this.gbFormasPagamento.Controls.Add(this.tbNomeFormaPagamento2);
            this.gbFormasPagamento.Controls.Add(this.tbCodigoFormaPagamento2);
            this.gbFormasPagamento.Controls.Add(this.tbNomeFormaPagamento1);
            this.gbFormasPagamento.Controls.Add(this.tbCodigoFormaPagamento1);
            this.gbFormasPagamento.Location = new System.Drawing.Point(12, 60);
            this.gbFormasPagamento.Name = "gbFormasPagamento";
            this.gbFormasPagamento.Size = new System.Drawing.Size(299, 249);
            this.gbFormasPagamento.TabIndex = 1;
            this.gbFormasPagamento.TabStop = false;
            this.gbFormasPagamento.Text = "Formas de pagamento";
            // 
            // tbNomeFormaPagamento7
            // 
            this.tbNomeFormaPagamento7.Enabled = false;
            this.tbNomeFormaPagamento7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFormaPagamento7.Location = new System.Drawing.Point(53, 211);
            this.tbNomeFormaPagamento7.Name = "tbNomeFormaPagamento7";
            this.tbNomeFormaPagamento7.Size = new System.Drawing.Size(145, 26);
            this.tbNomeFormaPagamento7.TabIndex = 19;
            // 
            // tbCodigoFormaPagamento7
            // 
            this.tbCodigoFormaPagamento7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFormaPagamento7.Location = new System.Drawing.Point(6, 211);
            this.tbCodigoFormaPagamento7.Name = "tbCodigoFormaPagamento7";
            this.tbCodigoFormaPagamento7.Size = new System.Drawing.Size(41, 26);
            this.tbCodigoFormaPagamento7.TabIndex = 18;
            this.tbCodigoFormaPagamento7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento7_KeyUp);
            this.tbCodigoFormaPagamento7.Leave += new System.EventHandler(this.TbCodigoFormaPagamento7_Leave);
            // 
            // tbNomeFormaPagamento6
            // 
            this.tbNomeFormaPagamento6.Enabled = false;
            this.tbNomeFormaPagamento6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFormaPagamento6.Location = new System.Drawing.Point(53, 179);
            this.tbNomeFormaPagamento6.Name = "tbNomeFormaPagamento6";
            this.tbNomeFormaPagamento6.Size = new System.Drawing.Size(145, 26);
            this.tbNomeFormaPagamento6.TabIndex = 16;
            // 
            // tbCodigoFormaPagamento6
            // 
            this.tbCodigoFormaPagamento6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFormaPagamento6.Location = new System.Drawing.Point(6, 179);
            this.tbCodigoFormaPagamento6.Name = "tbCodigoFormaPagamento6";
            this.tbCodigoFormaPagamento6.Size = new System.Drawing.Size(41, 26);
            this.tbCodigoFormaPagamento6.TabIndex = 15;
            this.tbCodigoFormaPagamento6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento6_KeyUp);
            this.tbCodigoFormaPagamento6.Leave += new System.EventHandler(this.TbCodigoFormaPagamento6_Leave);
            // 
            // tbNomeFormaPagamento5
            // 
            this.tbNomeFormaPagamento5.Enabled = false;
            this.tbNomeFormaPagamento5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFormaPagamento5.Location = new System.Drawing.Point(53, 147);
            this.tbNomeFormaPagamento5.Name = "tbNomeFormaPagamento5";
            this.tbNomeFormaPagamento5.Size = new System.Drawing.Size(145, 26);
            this.tbNomeFormaPagamento5.TabIndex = 13;
            // 
            // tbCodigoFormaPagamento5
            // 
            this.tbCodigoFormaPagamento5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFormaPagamento5.Location = new System.Drawing.Point(6, 147);
            this.tbCodigoFormaPagamento5.Name = "tbCodigoFormaPagamento5";
            this.tbCodigoFormaPagamento5.Size = new System.Drawing.Size(41, 26);
            this.tbCodigoFormaPagamento5.TabIndex = 12;
            this.tbCodigoFormaPagamento5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento5_KeyUp);
            this.tbCodigoFormaPagamento5.Leave += new System.EventHandler(this.TbCodigoFormaPagamento5_Leave);
            // 
            // tbNomeFormaPagamento4
            // 
            this.tbNomeFormaPagamento4.Enabled = false;
            this.tbNomeFormaPagamento4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFormaPagamento4.Location = new System.Drawing.Point(53, 115);
            this.tbNomeFormaPagamento4.Name = "tbNomeFormaPagamento4";
            this.tbNomeFormaPagamento4.Size = new System.Drawing.Size(145, 26);
            this.tbNomeFormaPagamento4.TabIndex = 10;
            // 
            // tbCodigoFormaPagamento4
            // 
            this.tbCodigoFormaPagamento4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFormaPagamento4.Location = new System.Drawing.Point(6, 115);
            this.tbCodigoFormaPagamento4.Name = "tbCodigoFormaPagamento4";
            this.tbCodigoFormaPagamento4.Size = new System.Drawing.Size(41, 26);
            this.tbCodigoFormaPagamento4.TabIndex = 9;
            this.tbCodigoFormaPagamento4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento4_KeyUp);
            this.tbCodigoFormaPagamento4.Leave += new System.EventHandler(this.TbCodigoFormaPagamento4_Leave);
            // 
            // tbNomeFormaPagamento3
            // 
            this.tbNomeFormaPagamento3.Enabled = false;
            this.tbNomeFormaPagamento3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFormaPagamento3.Location = new System.Drawing.Point(53, 83);
            this.tbNomeFormaPagamento3.Name = "tbNomeFormaPagamento3";
            this.tbNomeFormaPagamento3.Size = new System.Drawing.Size(145, 26);
            this.tbNomeFormaPagamento3.TabIndex = 7;
            // 
            // tbCodigoFormaPagamento3
            // 
            this.tbCodigoFormaPagamento3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFormaPagamento3.Location = new System.Drawing.Point(6, 83);
            this.tbCodigoFormaPagamento3.Name = "tbCodigoFormaPagamento3";
            this.tbCodigoFormaPagamento3.Size = new System.Drawing.Size(41, 26);
            this.tbCodigoFormaPagamento3.TabIndex = 6;
            this.tbCodigoFormaPagamento3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento3_KeyUp);
            this.tbCodigoFormaPagamento3.Leave += new System.EventHandler(this.TbCodigoFormaPagamento3_Leave);
            // 
            // tbNomeFormaPagamento2
            // 
            this.tbNomeFormaPagamento2.Enabled = false;
            this.tbNomeFormaPagamento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFormaPagamento2.Location = new System.Drawing.Point(53, 51);
            this.tbNomeFormaPagamento2.Name = "tbNomeFormaPagamento2";
            this.tbNomeFormaPagamento2.Size = new System.Drawing.Size(145, 26);
            this.tbNomeFormaPagamento2.TabIndex = 4;
            // 
            // tbCodigoFormaPagamento2
            // 
            this.tbCodigoFormaPagamento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFormaPagamento2.Location = new System.Drawing.Point(6, 51);
            this.tbCodigoFormaPagamento2.Name = "tbCodigoFormaPagamento2";
            this.tbCodigoFormaPagamento2.Size = new System.Drawing.Size(41, 26);
            this.tbCodigoFormaPagamento2.TabIndex = 3;
            this.tbCodigoFormaPagamento2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento2_KeyUp);
            this.tbCodigoFormaPagamento2.Leave += new System.EventHandler(this.TbCodigoFormaPagamento2_Leave);
            // 
            // tbNomeFormaPagamento1
            // 
            this.tbNomeFormaPagamento1.Enabled = false;
            this.tbNomeFormaPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFormaPagamento1.Location = new System.Drawing.Point(53, 19);
            this.tbNomeFormaPagamento1.Name = "tbNomeFormaPagamento1";
            this.tbNomeFormaPagamento1.Size = new System.Drawing.Size(145, 26);
            this.tbNomeFormaPagamento1.TabIndex = 1;
            // 
            // tbCodigoFormaPagamento1
            // 
            this.tbCodigoFormaPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFormaPagamento1.Location = new System.Drawing.Point(6, 19);
            this.tbCodigoFormaPagamento1.Name = "tbCodigoFormaPagamento1";
            this.tbCodigoFormaPagamento1.Size = new System.Drawing.Size(41, 26);
            this.tbCodigoFormaPagamento1.TabIndex = 0;
            this.tbCodigoFormaPagamento1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento1_KeyUp);
            this.tbCodigoFormaPagamento1.Leave += new System.EventHandler(this.TbCodigoFormaPagamento1_Leave);
            // 
            // pnTroco
            // 
            this.pnTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTroco.Controls.Add(this.lbValorTroco);
            this.pnTroco.Controls.Add(this.lbTroco);
            this.pnTroco.Location = new System.Drawing.Point(12, 315);
            this.pnTroco.Name = "pnTroco";
            this.pnTroco.Size = new System.Drawing.Size(299, 42);
            this.pnTroco.TabIndex = 2;
            // 
            // lbValorTroco
            // 
            this.lbValorTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTroco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbValorTroco.Location = new System.Drawing.Point(141, 9);
            this.lbValorTroco.Name = "lbValorTroco";
            this.lbValorTroco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbValorTroco.Size = new System.Drawing.Size(151, 20);
            this.lbValorTroco.TabIndex = 1;
            this.lbValorTroco.Text = "R$ 0,00";
            this.lbValorTroco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTroco
            // 
            this.lbTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTroco.AutoSize = true;
            this.lbTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTroco.Location = new System.Drawing.Point(3, 9);
            this.lbTroco.Name = "lbTroco";
            this.lbTroco.Size = new System.Drawing.Size(54, 20);
            this.lbTroco.TabIndex = 0;
            this.lbTroco.Text = "Troco";
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSalvar.Location = new System.Drawing.Point(12, 363);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(72, 23);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar - F2";
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // dbPagamento1
            // 
            this.dbPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPagamento1.Location = new System.Drawing.Point(204, 19);
            this.dbPagamento1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbPagamento1.Name = "dbPagamento1";
            this.dbPagamento1.Size = new System.Drawing.Size(91, 26);
            this.dbPagamento1.TabIndex = 21;
            this.dbPagamento1.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbPagamento2
            // 
            this.dbPagamento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPagamento2.Location = new System.Drawing.Point(204, 51);
            this.dbPagamento2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbPagamento2.Name = "dbPagamento2";
            this.dbPagamento2.Size = new System.Drawing.Size(91, 26);
            this.dbPagamento2.TabIndex = 22;
            this.dbPagamento2.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbPagamento3
            // 
            this.dbPagamento3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPagamento3.Location = new System.Drawing.Point(204, 83);
            this.dbPagamento3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbPagamento3.Name = "dbPagamento3";
            this.dbPagamento3.Size = new System.Drawing.Size(91, 26);
            this.dbPagamento3.TabIndex = 23;
            this.dbPagamento3.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbPagamento6
            // 
            this.dbPagamento6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPagamento6.Location = new System.Drawing.Point(204, 179);
            this.dbPagamento6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbPagamento6.Name = "dbPagamento6";
            this.dbPagamento6.Size = new System.Drawing.Size(91, 26);
            this.dbPagamento6.TabIndex = 26;
            this.dbPagamento6.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbPagamento5
            // 
            this.dbPagamento5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPagamento5.Location = new System.Drawing.Point(204, 147);
            this.dbPagamento5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbPagamento5.Name = "dbPagamento5";
            this.dbPagamento5.Size = new System.Drawing.Size(91, 26);
            this.dbPagamento5.TabIndex = 25;
            this.dbPagamento5.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbPagamento4
            // 
            this.dbPagamento4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPagamento4.Location = new System.Drawing.Point(204, 115);
            this.dbPagamento4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbPagamento4.Name = "dbPagamento4";
            this.dbPagamento4.Size = new System.Drawing.Size(91, 26);
            this.dbPagamento4.TabIndex = 24;
            this.dbPagamento4.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbPagamento7
            // 
            this.dbPagamento7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPagamento7.Location = new System.Drawing.Point(204, 211);
            this.dbPagamento7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbPagamento7.Name = "dbPagamento7";
            this.dbPagamento7.Size = new System.Drawing.Size(91, 26);
            this.dbPagamento7.TabIndex = 27;
            this.dbPagamento7.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // fmTroco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 399);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.pnTroco);
            this.Controls.Add(this.gbFormasPagamento);
            this.Controls.Add(this.pnTotal);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmTroco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pagamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmTroco_KeyDown);
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            this.gbFormasPagamento.ResumeLayout(false);
            this.gbFormasPagamento.PerformLayout();
            this.pnTroco.ResumeLayout(false);
            this.pnTroco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.GroupBox gbFormasPagamento;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento7;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento7;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento6;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento6;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento5;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento5;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento4;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento4;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento3;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento3;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento2;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento2;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento1;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento1;
        private System.Windows.Forms.Panel pnTroco;
        private System.Windows.Forms.Label lbValorTroco;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.Button btSalvar;
        private Controls.DecimalBox dbPagamento1;
        private Controls.DecimalBox dbPagamento7;
        private Controls.DecimalBox dbPagamento6;
        private Controls.DecimalBox dbPagamento5;
        private Controls.DecimalBox dbPagamento4;
        private Controls.DecimalBox dbPagamento3;
        private Controls.DecimalBox dbPagamento2;
    }
}