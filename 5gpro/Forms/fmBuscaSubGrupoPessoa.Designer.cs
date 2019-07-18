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
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupoPessoa)).BeginInit();
            this.gbBusca.SuspendLayout();
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
            this.dgvSubGrupoPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubGrupoPessoa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSubGrupoPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGrupoPessoa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubGrupoPessoa.Location = new System.Drawing.Point(6, 70);
            this.dgvSubGrupoPessoa.MultiSelect = false;
            this.dgvSubGrupoPessoa.Name = "dgvSubGrupoPessoa";
            this.dgvSubGrupoPessoa.ReadOnly = true;
            this.dgvSubGrupoPessoa.RowHeadersVisible = false;
            this.dgvSubGrupoPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubGrupoPessoa.Size = new System.Drawing.Size(286, 156);
            this.dgvSubGrupoPessoa.TabIndex = 0;
            this.dgvSubGrupoPessoa.TabStop = false;
            this.dgvSubGrupoPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubGrupoPessoa_CellDoubleClick);
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
            this.gbBusca.Controls.Add(this.lbNome);
            this.gbBusca.Controls.Add(this.tbNomeSubGrupo);
            this.gbBusca.Controls.Add(this.dgvSubGrupoPessoa);
            this.gbBusca.Location = new System.Drawing.Point(12, 12);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(298, 232);
            this.gbBusca.TabIndex = 2;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Busca Sub-Grupo Pessoa";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(7, 25);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // fmBuscaSubGrupoPessoa
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
            this.Name = "fmBuscaSubGrupoPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Sub-Grupo de Pessoas";
            this.Load += new System.EventHandler(this.FmBuscaSubGrupoPessoa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaSubGrupoPessoa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrupoPessoa)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubGrupoPessoa;
        private System.Windows.Forms.TextBox tbNomeSubGrupo;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label lbNome;
    }
}