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
            this.dgvParcelasOperacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasOperacao)).BeginInit();
            this.SuspendLayout();
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
            this.dgvParcelasOperacao.ColumnHeadersVisible = false;
            this.dgvParcelasOperacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParcelasOperacao.Location = new System.Drawing.Point(12, 56);
            this.dgvParcelasOperacao.MultiSelect = false;
            this.dgvParcelasOperacao.Name = "dgvParcelasOperacao";
            this.dgvParcelasOperacao.ReadOnly = true;
            this.dgvParcelasOperacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelasOperacao.Size = new System.Drawing.Size(401, 235);
            this.dgvParcelasOperacao.TabIndex = 0;
            this.dgvParcelasOperacao.TabStop = false;
            // 
            // fmBuscaParcelasOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 304);
            this.Controls.Add(this.dgvParcelasOperacao);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBuscaParcelasOperacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dias a Vencer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasOperacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcelasOperacao;
    }
}