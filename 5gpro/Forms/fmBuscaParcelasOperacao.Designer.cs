namespace _5gpro.Forms
{
    partial class fmBuscaParcelasOperacao
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
            this.tbDias = new System.Windows.Forms.TextBox();
            this.lbDias = new System.Windows.Forms.Label();
            this.gbAlterar = new System.Windows.Forms.GroupBox();
            this.btAplicar = new System.Windows.Forms.Button();
            this.dgvParcelasOperacao = new System.Windows.Forms.DataGridView();
            this.gbAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasOperacao)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDias
            // 
            this.tbDias.Location = new System.Drawing.Point(43, 19);
            this.tbDias.Name = "tbDias";
            this.tbDias.Size = new System.Drawing.Size(59, 20);
            this.tbDias.TabIndex = 2;
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Location = new System.Drawing.Point(9, 24);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(28, 13);
            this.lbDias.TabIndex = 3;
            this.lbDias.Text = "Dias";
            // 
            // gbAlterar
            // 
            this.gbAlterar.Controls.Add(this.btAplicar);
            this.gbAlterar.Controls.Add(this.lbDias);
            this.gbAlterar.Controls.Add(this.tbDias);
            this.gbAlterar.Location = new System.Drawing.Point(16, 250);
            this.gbAlterar.Name = "gbAlterar";
            this.gbAlterar.Size = new System.Drawing.Size(175, 47);
            this.gbAlterar.TabIndex = 5;
            this.gbAlterar.TabStop = false;
            this.gbAlterar.Text = "Alterar Todas";
            // 
            // btAplicar
            // 
            this.btAplicar.Location = new System.Drawing.Point(108, 17);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(59, 23);
            this.btAplicar.TabIndex = 4;
            this.btAplicar.Text = "Aplicar";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.BtAplicar_Click);
            // 
            // dgvParcelasOperacao
            // 
            this.dgvParcelasOperacao.AllowUserToAddRows = false;
            this.dgvParcelasOperacao.AllowUserToDeleteRows = false;
            this.dgvParcelasOperacao.AllowUserToOrderColumns = true;
            this.dgvParcelasOperacao.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvParcelasOperacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcelasOperacao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvParcelasOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelasOperacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvParcelasOperacao.Location = new System.Drawing.Point(16, 12);
            this.dgvParcelasOperacao.MultiSelect = false;
            this.dgvParcelasOperacao.Name = "dgvParcelasOperacao";
            this.dgvParcelasOperacao.RowHeadersVisible = false;
            this.dgvParcelasOperacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelasOperacao.Size = new System.Drawing.Size(304, 232);
            this.dgvParcelasOperacao.TabIndex = 8;
            this.dgvParcelasOperacao.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParcelasOperacao_CellEndEdit);
            this.dgvParcelasOperacao.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParcelasOperacao_CellEnter);
            // 
            // fmBuscaParcelasOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 316);
            this.Controls.Add(this.dgvParcelasOperacao);
            this.Controls.Add(this.gbAlterar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(348, 355);
            this.Name = "fmBuscaParcelasOperacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcelas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaParcelasOperacao_KeyDown);
            this.gbAlterar.ResumeLayout(false);
            this.gbAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasOperacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbDias;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.GroupBox gbAlterar;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.DataGridView dgvParcelasOperacao;
    }
}