namespace _5gpro.Forms
{
    partial class fmBuscaFormaPagamento
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
            this.dgvFormaPagamento = new System.Windows.Forms.DataGridView();
            this.tbNomeFormaPagamento = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFormaPagamento
            // 
            this.dgvFormaPagamento.AllowUserToAddRows = false;
            this.dgvFormaPagamento.AllowUserToDeleteRows = false;
            this.dgvFormaPagamento.AllowUserToOrderColumns = true;
            this.dgvFormaPagamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvFormaPagamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFormaPagamento.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPagamento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFormaPagamento.Location = new System.Drawing.Point(12, 41);
            this.dgvFormaPagamento.MultiSelect = false;
            this.dgvFormaPagamento.Name = "dgvFormaPagamento";
            this.dgvFormaPagamento.ReadOnly = true;
            this.dgvFormaPagamento.RowHeadersVisible = false;
            this.dgvFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormaPagamento.Size = new System.Drawing.Size(303, 305);
            this.dgvFormaPagamento.TabIndex = 0;
            this.dgvFormaPagamento.TabStop = false;
            this.dgvFormaPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFormaPagamento_CellDoubleClick);
            // 
            // tbNomeFormaPagamento
            // 
            this.tbNomeFormaPagamento.Location = new System.Drawing.Point(12, 12);
            this.tbNomeFormaPagamento.Name = "tbNomeFormaPagamento";
            this.tbNomeFormaPagamento.Size = new System.Drawing.Size(222, 20);
            this.tbNomeFormaPagamento.TabIndex = 1;
            this.tbNomeFormaPagamento.TextChanged += new System.EventHandler(this.TbNomeFormaPagamento_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(240, 9);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // fmBuscaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 358);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbNomeFormaPagamento);
            this.Controls.Add(this.dgvFormaPagamento);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 295);
            this.Name = "fmBuscaFormaPagamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca Forma de Pagamento";
            this.Load += new System.EventHandler(this.FmBuscaFormaPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormaPagamento;
        private System.Windows.Forms.TextBox tbNomeFormaPagamento;
        private System.Windows.Forms.Button btPesquisar;
    }
}