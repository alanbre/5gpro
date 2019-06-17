namespace _5gpro.Forms
{
    partial class fmBuscaSubGrupoPessoa
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
            this.dgvSubGrupoPessoa = new System.Windows.Forms.DataGridView();
            this.tbNomeSubGrupo = new System.Windows.Forms.TextBox();
            this.btPesquisarSubGrupoPessoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupoPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubGrupoPessoa
            // 
            this.dgvSubGrupoPessoa.AllowUserToAddRows = false;
            this.dgvSubGrupoPessoa.AllowUserToDeleteRows = false;
            this.dgvSubGrupoPessoa.AllowUserToOrderColumns = true;
            this.dgvSubGrupoPessoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvSubGrupoPessoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubGrupoPessoa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSubGrupoPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGrupoPessoa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubGrupoPessoa.Location = new System.Drawing.Point(12, 38);
            this.dgvSubGrupoPessoa.MultiSelect = false;
            this.dgvSubGrupoPessoa.Name = "dgvSubGrupoPessoa";
            this.dgvSubGrupoPessoa.ReadOnly = true;
            this.dgvSubGrupoPessoa.RowHeadersVisible = false;
            this.dgvSubGrupoPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubGrupoPessoa.Size = new System.Drawing.Size(298, 308);
            this.dgvSubGrupoPessoa.TabIndex = 0;
            this.dgvSubGrupoPessoa.TabStop = false;
            this.dgvSubGrupoPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubGrupoPessoa_CellDoubleClick);
            // 
            // tbNomeSubGrupo
            // 
            this.tbNomeSubGrupo.Location = new System.Drawing.Point(13, 12);
            this.tbNomeSubGrupo.Name = "tbNomeSubGrupo";
            this.tbNomeSubGrupo.Size = new System.Drawing.Size(216, 20);
            this.tbNomeSubGrupo.TabIndex = 1;
            this.tbNomeSubGrupo.TextChanged += new System.EventHandler(this.TbNomeSubGrupo_TextChanged);
            // 
            // btPesquisarSubGrupoPessoa
            // 
            this.btPesquisarSubGrupoPessoa.Location = new System.Drawing.Point(235, 10);
            this.btPesquisarSubGrupoPessoa.Name = "btPesquisarSubGrupoPessoa";
            this.btPesquisarSubGrupoPessoa.Size = new System.Drawing.Size(75, 23);
            this.btPesquisarSubGrupoPessoa.TabIndex = 2;
            this.btPesquisarSubGrupoPessoa.Text = "Pesquisar";
            this.btPesquisarSubGrupoPessoa.UseVisualStyleBackColor = true;
            this.btPesquisarSubGrupoPessoa.Click += new System.EventHandler(this.BtPesquisarSubGrupoPessoa_Click);
            // 
            // fmBuscaSubGrupoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 358);
            this.Controls.Add(this.btPesquisarSubGrupoPessoa);
            this.Controls.Add(this.tbNomeSubGrupo);
            this.Controls.Add(this.dgvSubGrupoPessoa);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 397);
            this.Name = "fmBuscaSubGrupoPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Sub-Grupo de Pessoas";
            this.Load += new System.EventHandler(this.FmBuscaSubGrupoPessoa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaSubGrupoPessoa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupoPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubGrupoPessoa;
        private System.Windows.Forms.TextBox tbNomeSubGrupo;
        private System.Windows.Forms.Button btPesquisarSubGrupoPessoa;
    }
}