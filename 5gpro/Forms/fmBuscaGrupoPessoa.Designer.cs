namespace _5gpro.Forms
{
    partial class fmBuscaGrupoPessoa
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
            this.dgvGrupoPessoa = new System.Windows.Forms.DataGridView();
            this.tbNomeGrupoPessoa = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupoPessoa
            // 
            this.dgvGrupoPessoa.AllowUserToAddRows = false;
            this.dgvGrupoPessoa.AllowUserToDeleteRows = false;
            this.dgvGrupoPessoa.AllowUserToOrderColumns = true;
            this.dgvGrupoPessoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvGrupoPessoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupoPessoa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGrupoPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoPessoa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrupoPessoa.Location = new System.Drawing.Point(12, 38);
            this.dgvGrupoPessoa.MultiSelect = false;
            this.dgvGrupoPessoa.Name = "dgvGrupoPessoa";
            this.dgvGrupoPessoa.ReadOnly = true;
            this.dgvGrupoPessoa.RowHeadersVisible = false;
            this.dgvGrupoPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupoPessoa.Size = new System.Drawing.Size(298, 308);
            this.dgvGrupoPessoa.TabIndex = 0;
            this.dgvGrupoPessoa.TabStop = false;
            this.dgvGrupoPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupoPessoa_CellDoubleClick);
            // 
            // tbNomeGrupoPessoa
            // 
            this.tbNomeGrupoPessoa.Location = new System.Drawing.Point(13, 12);
            this.tbNomeGrupoPessoa.Name = "tbNomeGrupoPessoa";
            this.tbNomeGrupoPessoa.Size = new System.Drawing.Size(216, 20);
            this.tbNomeGrupoPessoa.TabIndex = 1;
            this.tbNomeGrupoPessoa.TextChanged += new System.EventHandler(this.TbNomeGrupoPessoa_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(235, 9);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // fmBuscaGrupoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 358);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbNomeGrupoPessoa);
            this.Controls.Add(this.dgvGrupoPessoa);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 397);
            this.Name = "fmBuscaGrupoPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca Grupo de Pessoa";
            this.Load += new System.EventHandler(this.FmBuscaGrupoPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupoPessoa;
        private System.Windows.Forms.TextBox tbNomeGrupoPessoa;
        private System.Windows.Forms.Button btPesquisar;
    }
}