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
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoPessoa)).BeginInit();
            this.gbBusca.SuspendLayout();
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
            this.dgvGrupoPessoa.Location = new System.Drawing.Point(6, 70);
            this.dgvGrupoPessoa.MultiSelect = false;
            this.dgvGrupoPessoa.Name = "dgvGrupoPessoa";
            this.dgvGrupoPessoa.ReadOnly = true;
            this.dgvGrupoPessoa.RowHeadersVisible = false;
            this.dgvGrupoPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupoPessoa.Size = new System.Drawing.Size(286, 156);
            this.dgvGrupoPessoa.TabIndex = 0;
            this.dgvGrupoPessoa.TabStop = false;
            this.dgvGrupoPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupoPessoa_CellDoubleClick);
            // 
            // tbNomeGrupoPessoa
            // 
            this.tbNomeGrupoPessoa.Location = new System.Drawing.Point(6, 44);
            this.tbNomeGrupoPessoa.Name = "tbNomeGrupoPessoa";
            this.tbNomeGrupoPessoa.Size = new System.Drawing.Size(286, 20);
            this.tbNomeGrupoPessoa.TabIndex = 1;
            this.tbNomeGrupoPessoa.TextChanged += new System.EventHandler(this.TbNomeGrupoPessoa_TextChanged);
            // 
            // gbBusca
            // 
            this.gbBusca.Controls.Add(this.lbNome);
            this.gbBusca.Controls.Add(this.tbNomeGrupoPessoa);
            this.gbBusca.Controls.Add(this.dgvGrupoPessoa);
            this.gbBusca.Location = new System.Drawing.Point(12, 12);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(298, 232);
            this.gbBusca.TabIndex = 3;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Busca";
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
            // fmBuscaGrupoPessoa
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
            this.Name = "fmBuscaGrupoPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Grupo de Pessoa";
            this.Load += new System.EventHandler(this.FmBuscaGrupoPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoPessoa)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupoPessoa;
        private System.Windows.Forms.TextBox tbNomeGrupoPessoa;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label lbNome;
    }
}