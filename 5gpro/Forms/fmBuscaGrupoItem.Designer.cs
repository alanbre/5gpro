namespace _5gpro.Forms
{
    partial class fmBuscaGrupoItem
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
            this.dgvGrupoItens = new System.Windows.Forms.DataGridView();
            this.tbNomeGrupoIten = new System.Windows.Forms.TextBox();
            this.gbBuscaGrupo = new System.Windows.Forms.GroupBox();
            this.lbNomeBusca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoItens)).BeginInit();
            this.gbBuscaGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrupoItens
            // 
            this.dgvGrupoItens.AllowUserToAddRows = false;
            this.dgvGrupoItens.AllowUserToDeleteRows = false;
            this.dgvGrupoItens.AllowUserToOrderColumns = true;
            this.dgvGrupoItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvGrupoItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupoItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrupoItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGrupoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrupoItens.Location = new System.Drawing.Point(6, 70);
            this.dgvGrupoItens.MultiSelect = false;
            this.dgvGrupoItens.Name = "dgvGrupoItens";
            this.dgvGrupoItens.ReadOnly = true;
            this.dgvGrupoItens.RowHeadersVisible = false;
            this.dgvGrupoItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupoItens.Size = new System.Drawing.Size(286, 156);
            this.dgvGrupoItens.TabIndex = 0;
            this.dgvGrupoItens.TabStop = false;
            this.dgvGrupoItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupoItens_CellDoubleClick);
            // 
            // tbNomeGrupoIten
            // 
            this.tbNomeGrupoIten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeGrupoIten.Location = new System.Drawing.Point(6, 44);
            this.tbNomeGrupoIten.Name = "tbNomeGrupoIten";
            this.tbNomeGrupoIten.Size = new System.Drawing.Size(286, 20);
            this.tbNomeGrupoIten.TabIndex = 1;
            this.tbNomeGrupoIten.TextChanged += new System.EventHandler(this.TbNomeGrupoIten_TextChanged);
            // 
            // gbBuscaGrupo
            // 
            this.gbBuscaGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscaGrupo.Controls.Add(this.lbNomeBusca);
            this.gbBuscaGrupo.Controls.Add(this.dgvGrupoItens);
            this.gbBuscaGrupo.Controls.Add(this.tbNomeGrupoIten);
            this.gbBuscaGrupo.Location = new System.Drawing.Point(12, 12);
            this.gbBuscaGrupo.Name = "gbBuscaGrupo";
            this.gbBuscaGrupo.Size = new System.Drawing.Size(298, 232);
            this.gbBuscaGrupo.TabIndex = 7;
            this.gbBuscaGrupo.TabStop = false;
            this.gbBuscaGrupo.Text = "Busca Grupo Item";
            // 
            // lbNomeBusca
            // 
            this.lbNomeBusca.AutoSize = true;
            this.lbNomeBusca.Location = new System.Drawing.Point(7, 25);
            this.lbNomeBusca.Name = "lbNomeBusca";
            this.lbNomeBusca.Size = new System.Drawing.Size(35, 13);
            this.lbNomeBusca.TabIndex = 2;
            this.lbNomeBusca.Text = "Nome";
            // 
            // fmBuscaGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 253);
            this.Controls.Add(this.gbBuscaGrupo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 292);
            this.Name = "fmBuscaGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Grupo de Itens";
            this.Load += new System.EventHandler(this.FmBuscaGrupoItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaGrupoItem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoItens)).EndInit();
            this.gbBuscaGrupo.ResumeLayout(false);
            this.gbBuscaGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupoItens;
        private System.Windows.Forms.TextBox tbNomeGrupoIten;
        private System.Windows.Forms.GroupBox gbBuscaGrupo;
        private System.Windows.Forms.Label lbNomeBusca;
    }
}