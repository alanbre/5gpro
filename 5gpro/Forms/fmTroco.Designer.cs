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
            this.dbPagamento1 = new _5gpro.Controls.DecimalBox();
            this.tbNomeFormaPagamento1 = new System.Windows.Forms.TextBox();
            this.tbCodigoFormaPagamento1 = new System.Windows.Forms.TextBox();
            this.pnTroco = new System.Windows.Forms.Panel();
            this.lbValorTroco = new System.Windows.Forms.Label();
            this.lbTroco = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbInformacao = new System.Windows.Forms.Label();
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
            this.pnTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTotal.Controls.Add(this.lbValorTotal);
            this.pnTotal.Controls.Add(this.lbTotal);
            this.pnTotal.Location = new System.Drawing.Point(12, 12);
            this.pnTotal.Name = "pnTotal";
            this.pnTotal.Size = new System.Drawing.Size(327, 42);
            this.pnTotal.TabIndex = 0;
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(250, 9);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(72, 20);
            this.lbValorTotal.TabIndex = 1;
            this.lbValorTotal.Text = "R$ 0,00";
            // 
            // gbFormasPagamento
            // 
            this.gbFormasPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFormasPagamento.Controls.Add(this.dbPagamento1);
            this.gbFormasPagamento.Controls.Add(this.tbNomeFormaPagamento1);
            this.gbFormasPagamento.Controls.Add(this.tbCodigoFormaPagamento1);
            this.gbFormasPagamento.Location = new System.Drawing.Point(12, 60);
            this.gbFormasPagamento.Name = "gbFormasPagamento";
            this.gbFormasPagamento.Size = new System.Drawing.Size(327, 87);
            this.gbFormasPagamento.TabIndex = 1;
            this.gbFormasPagamento.TabStop = false;
            this.gbFormasPagamento.Text = "Formas de pagamento";
            // 
            // dbPagamento1
            // 
            this.dbPagamento1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dbPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbPagamento1.Location = new System.Drawing.Point(233, 34);
            this.dbPagamento1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbPagamento1.Name = "dbPagamento1";
            this.dbPagamento1.Size = new System.Drawing.Size(70, 26);
            this.dbPagamento1.TabIndex = 2;
            this.dbPagamento1.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbPagamento1.Leave += new System.EventHandler(this.DbPagamento1_Leave);
            // 
            // tbNomeFormaPagamento1
            // 
            this.tbNomeFormaPagamento1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeFormaPagamento1.Enabled = false;
            this.tbNomeFormaPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFormaPagamento1.Location = new System.Drawing.Point(54, 34);
            this.tbNomeFormaPagamento1.Name = "tbNomeFormaPagamento1";
            this.tbNomeFormaPagamento1.Size = new System.Drawing.Size(173, 26);
            this.tbNomeFormaPagamento1.TabIndex = 1;
            // 
            // tbCodigoFormaPagamento1
            // 
            this.tbCodigoFormaPagamento1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoFormaPagamento1.Location = new System.Drawing.Point(7, 34);
            this.tbCodigoFormaPagamento1.Name = "tbCodigoFormaPagamento1";
            this.tbCodigoFormaPagamento1.Size = new System.Drawing.Size(41, 26);
            this.tbCodigoFormaPagamento1.TabIndex = 0;
            this.tbCodigoFormaPagamento1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoFormaPagamento1_KeyUp);
            this.tbCodigoFormaPagamento1.Leave += new System.EventHandler(this.TbCodigoFormaPagamento1_Leave);
            // 
            // pnTroco
            // 
            this.pnTroco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTroco.Controls.Add(this.lbValorTroco);
            this.pnTroco.Controls.Add(this.lbTroco);
            this.pnTroco.Location = new System.Drawing.Point(12, 153);
            this.pnTroco.Name = "pnTroco";
            this.pnTroco.Size = new System.Drawing.Size(327, 42);
            this.pnTroco.TabIndex = 2;
            // 
            // lbValorTroco
            // 
            this.lbValorTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTroco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbValorTroco.Location = new System.Drawing.Point(169, 9);
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
            this.btSalvar.Location = new System.Drawing.Point(12, 201);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(72, 23);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar - F2";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // lbInformacao
            // 
            this.lbInformacao.AutoSize = true;
            this.lbInformacao.Location = new System.Drawing.Point(206, 216);
            this.lbInformacao.Name = "lbInformacao";
            this.lbInformacao.Size = new System.Drawing.Size(133, 13);
            this.lbInformacao.TabIndex = 4;
            this.lbInformacao.Text = "F3 - Formas de pagamento";
            // 
            // fmTroco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 238);
            this.Controls.Add(this.lbInformacao);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.pnTroco);
            this.Controls.Add(this.gbFormasPagamento);
            this.Controls.Add(this.pnTotal);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(367, 277);
            this.MinimizeBox = false;
            this.Name = "fmTroco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmTroco_KeyDown);
            this.pnTotal.ResumeLayout(false);
            this.pnTotal.PerformLayout();
            this.gbFormasPagamento.ResumeLayout(false);
            this.gbFormasPagamento.PerformLayout();
            this.pnTroco.ResumeLayout(false);
            this.pnTroco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel pnTotal;
        private System.Windows.Forms.Label lbValorTotal;
        private System.Windows.Forms.GroupBox gbFormasPagamento;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento1;
        private System.Windows.Forms.TextBox tbCodigoFormaPagamento1;
        private System.Windows.Forms.Panel pnTroco;
        private System.Windows.Forms.Label lbValorTroco;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.Button btSalvar;
        private Controls.DecimalBox dbPagamento1;
        private System.Windows.Forms.Label lbInformacao;
    }
}