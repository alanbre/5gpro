namespace _5gpro.Forms
{
    partial class fmVisualizaParcelas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvtbcSequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDataQuitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToOrderColumns = true;
            this.dgvParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
            this.dgvParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvParcelas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcSequencia,
            this.dgvtbcDataVencimento,
            this.dgvtbcValorOriginal,
            this.dgvtbcMulta,
            this.dgvtbcJuros,
            this.dgvtbcAcrescimo,
            this.dgvtbcDesconto,
            this.dgvtbcValorFinal,
            this.dgvtbcDataQuitacao,
            this.dgvtbcSituacao});
            this.dgvParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParcelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParcelas.Location = new System.Drawing.Point(3, 16);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersVisible = false;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(910, 293);
            this.dgvParcelas.TabIndex = 1;
            this.dgvParcelas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvParcelas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvtbcSequencia
            // 
            this.dgvtbcSequencia.HeaderText = "Parcela";
            this.dgvtbcSequencia.Name = "dgvtbcSequencia";
            this.dgvtbcSequencia.ReadOnly = true;
            this.dgvtbcSequencia.Width = 50;
            // 
            // dgvtbcDataVencimento
            // 
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.dgvtbcDataVencimento.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvtbcDataVencimento.HeaderText = "Data de vencimento";
            this.dgvtbcDataVencimento.Name = "dgvtbcDataVencimento";
            this.dgvtbcDataVencimento.ReadOnly = true;
            // 
            // dgvtbcValorOriginal
            // 
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.dgvtbcValorOriginal.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvtbcValorOriginal.HeaderText = "Valor original";
            this.dgvtbcValorOriginal.Name = "dgvtbcValorOriginal";
            this.dgvtbcValorOriginal.ReadOnly = true;
            this.dgvtbcValorOriginal.Width = 90;
            // 
            // dgvtbcMulta
            // 
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.dgvtbcMulta.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvtbcMulta.HeaderText = "Multa";
            this.dgvtbcMulta.Name = "dgvtbcMulta";
            this.dgvtbcMulta.ReadOnly = true;
            this.dgvtbcMulta.Width = 90;
            // 
            // dgvtbcJuros
            // 
            dataGridViewCellStyle14.Format = "C2";
            this.dgvtbcJuros.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvtbcJuros.HeaderText = "Juros";
            this.dgvtbcJuros.Name = "dgvtbcJuros";
            this.dgvtbcJuros.ReadOnly = true;
            this.dgvtbcJuros.Width = 90;
            // 
            // dgvtbcAcrescimo
            // 
            dataGridViewCellStyle15.Format = "C2";
            this.dgvtbcAcrescimo.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvtbcAcrescimo.HeaderText = "Acréscimo";
            this.dgvtbcAcrescimo.Name = "dgvtbcAcrescimo";
            this.dgvtbcAcrescimo.ReadOnly = true;
            this.dgvtbcAcrescimo.Width = 90;
            // 
            // dgvtbcDesconto
            // 
            dataGridViewCellStyle16.Format = "C2";
            this.dgvtbcDesconto.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvtbcDesconto.HeaderText = "Desconto";
            this.dgvtbcDesconto.Name = "dgvtbcDesconto";
            this.dgvtbcDesconto.ReadOnly = true;
            this.dgvtbcDesconto.Width = 90;
            // 
            // dgvtbcValorFinal
            // 
            dataGridViewCellStyle17.Format = "C2";
            this.dgvtbcValorFinal.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvtbcValorFinal.HeaderText = "Valor final";
            this.dgvtbcValorFinal.Name = "dgvtbcValorFinal";
            this.dgvtbcValorFinal.ReadOnly = true;
            this.dgvtbcValorFinal.Width = 90;
            // 
            // dgvtbcDataQuitacao
            // 
            dataGridViewCellStyle18.Format = "d";
            dataGridViewCellStyle18.NullValue = null;
            this.dgvtbcDataQuitacao.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvtbcDataQuitacao.HeaderText = "Data quitação";
            this.dgvtbcDataQuitacao.Name = "dgvtbcDataQuitacao";
            this.dgvtbcDataQuitacao.ReadOnly = true;
            // 
            // dgvtbcSituacao
            // 
            this.dgvtbcSituacao.HeaderText = "Situação";
            this.dgvtbcSituacao.Name = "dgvtbcSituacao";
            this.dgvtbcSituacao.ReadOnly = true;
            // 
            // fmVisualizaParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 330);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "fmVisualizaParcelas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmVisualizaParcelas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcSequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataQuitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcSituacao;
    }
}