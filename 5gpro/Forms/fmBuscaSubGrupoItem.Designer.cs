namespace _5gpro.Forms
{
    partial class fmBuscaSubGrupoItem
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
            this.dgvSubGrupoItem = new System.Windows.Forms.DataGridView();
            this.tbNomeSubGrupo = new System.Windows.Forms.TextBox();
            this.btPesquisarSubGrupoItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubGrupoItem
            // 
            this.dgvSubGrupoItem.AllowUserToAddRows = false;
            this.dgvSubGrupoItem.AllowUserToDeleteRows = false;
            this.dgvSubGrupoItem.AllowUserToOrderColumns = true;
            this.dgvSubGrupoItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvSubGrupoItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubGrupoItem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSubGrupoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGrupoItem.ColumnHeadersVisible = false;
            this.dgvSubGrupoItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubGrupoItem.Location = new System.Drawing.Point(12, 38);
            this.dgvSubGrupoItem.MultiSelect = false;
            this.dgvSubGrupoItem.Name = "dgvSubGrupoItem";
            this.dgvSubGrupoItem.ReadOnly = true;
            this.dgvSubGrupoItem.RowHeadersVisible = false;
            this.dgvSubGrupoItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubGrupoItem.Size = new System.Drawing.Size(298, 308);
            this.dgvSubGrupoItem.TabIndex = 0;
            this.dgvSubGrupoItem.TabStop = false;
            this.dgvSubGrupoItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubGrupoItem_CellDoubleClick);
            // 
            // tbNomeSubGrupo
            // 
            this.tbNomeSubGrupo.Location = new System.Drawing.Point(12, 12);
            this.tbNomeSubGrupo.Name = "tbNomeSubGrupo";
            this.tbNomeSubGrupo.Size = new System.Drawing.Size(217, 20);
            this.tbNomeSubGrupo.TabIndex = 1;
            this.tbNomeSubGrupo.TextChanged += new System.EventHandler(this.TbNomeSubGrupo_TextChanged);
            // 
            // btPesquisarSubGrupoItem
            // 
            this.btPesquisarSubGrupoItem.Location = new System.Drawing.Point(235, 10);
            this.btPesquisarSubGrupoItem.Name = "btPesquisarSubGrupoItem";
            this.btPesquisarSubGrupoItem.Size = new System.Drawing.Size(75, 23);
            this.btPesquisarSubGrupoItem.TabIndex = 2;
            this.btPesquisarSubGrupoItem.Text = "Pesquisar";
            this.btPesquisarSubGrupoItem.UseVisualStyleBackColor = true;
            this.btPesquisarSubGrupoItem.Click += new System.EventHandler(this.BtPesquisarSubGrupoItem_Click);
            // 
            // fmBuscaSubGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 358);
            this.Controls.Add(this.btPesquisarSubGrupoItem);
            this.Controls.Add(this.tbNomeSubGrupo);
            this.Controls.Add(this.dgvSubGrupoItem);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 397);
            this.Name = "fmBuscaSubGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Sub-Grupo Item";
            this.Load += new System.EventHandler(this.FmBuscaSubGrupoItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaSubGrupoItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupoItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubGrupoItem;
        private System.Windows.Forms.TextBox tbNomeSubGrupo;
        private System.Windows.Forms.Button btPesquisarSubGrupoItem;
    }
}