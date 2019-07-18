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
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupoItem)).BeginInit();
            this.gbBusca.SuspendLayout();
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
            this.dgvSubGrupoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubGrupoItem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSubGrupoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGrupoItem.ColumnHeadersVisible = false;
            this.dgvSubGrupoItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubGrupoItem.Location = new System.Drawing.Point(6, 70);
            this.dgvSubGrupoItem.MultiSelect = false;
            this.dgvSubGrupoItem.Name = "dgvSubGrupoItem";
            this.dgvSubGrupoItem.ReadOnly = true;
            this.dgvSubGrupoItem.RowHeadersVisible = false;
            this.dgvSubGrupoItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubGrupoItem.Size = new System.Drawing.Size(286, 156);
            this.dgvSubGrupoItem.TabIndex = 0;
            this.dgvSubGrupoItem.TabStop = false;
            this.dgvSubGrupoItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubGrupoItem_CellDoubleClick);
            // 
            // tbNomeSubGrupo
            // 
            this.tbNomeSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeSubGrupo.Location = new System.Drawing.Point(6, 44);
            this.tbNomeSubGrupo.Name = "tbNomeSubGrupo";
            this.tbNomeSubGrupo.Size = new System.Drawing.Size(286, 20);
            this.tbNomeSubGrupo.TabIndex = 1;
            this.tbNomeSubGrupo.TextChanged += new System.EventHandler(this.TbNomeSubGrupo_TextChanged);
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.label1);
            this.gbBusca.Controls.Add(this.dgvSubGrupoItem);
            this.gbBusca.Controls.Add(this.tbNomeSubGrupo);
            this.gbBusca.Location = new System.Drawing.Point(12, 12);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(298, 232);
            this.gbBusca.TabIndex = 2;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Busca Sub-Grupo Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // fmBuscaSubGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 253);
            this.Controls.Add(this.gbBusca);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 292);
            this.Name = "fmBuscaSubGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Sub-Grupo Item";
            this.Load += new System.EventHandler(this.FmBuscaSubGrupoItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaSubGrupoItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupoItem)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubGrupoItem;
        private System.Windows.Forms.TextBox tbNomeSubGrupo;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label label1;
    }
}