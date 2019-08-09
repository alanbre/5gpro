namespace _5gpro.Forms
{
    partial class fmBuscaBanco
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
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lbFiltroNomeBanco = new System.Windows.Forms.Label();
            this.dgvBancos = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomeBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFiltroNomeBanco = new System.Windows.Forms.TextBox();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.lbFiltroNomeBanco);
            this.gbFiltros.Controls.Add(this.dgvBancos);
            this.gbFiltros.Controls.Add(this.tbFiltroNomeBanco);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(297, 355);
            this.gbFiltros.TabIndex = 5;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Busca";
            // 
            // lbFiltroNomeBanco
            // 
            this.lbFiltroNomeBanco.AutoSize = true;
            this.lbFiltroNomeBanco.Location = new System.Drawing.Point(6, 16);
            this.lbFiltroNomeBanco.Name = "lbFiltroNomeBanco";
            this.lbFiltroNomeBanco.Size = new System.Drawing.Size(83, 13);
            this.lbFiltroNomeBanco.TabIndex = 3;
            this.lbFiltroNomeBanco.Text = "Nome do banco";
            // 
            // dgvBancos
            // 
            this.dgvBancos.AllowUserToAddRows = false;
            this.dgvBancos.AllowUserToDeleteRows = false;
            this.dgvBancos.AllowUserToOrderColumns = true;
            this.dgvBancos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvBancos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBancos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBancos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodBanco,
            this.dgvtbcNomeBanco});
            this.dgvBancos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBancos.Location = new System.Drawing.Point(8, 58);
            this.dgvBancos.MultiSelect = false;
            this.dgvBancos.Name = "dgvBancos";
            this.dgvBancos.ReadOnly = true;
            this.dgvBancos.RowHeadersVisible = false;
            this.dgvBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBancos.Size = new System.Drawing.Size(280, 291);
            this.dgvBancos.TabIndex = 2;
            this.dgvBancos.TabStop = false;
            this.dgvBancos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBancos_CellDoubleClick);
            // 
            // dgvtbcCodBanco
            // 
            this.dgvtbcCodBanco.FillWeight = 50.76142F;
            this.dgvtbcCodBanco.HeaderText = "Código";
            this.dgvtbcCodBanco.Name = "dgvtbcCodBanco";
            this.dgvtbcCodBanco.ReadOnly = true;
            // 
            // dgvtbcNomeBanco
            // 
            this.dgvtbcNomeBanco.FillWeight = 149.2386F;
            this.dgvtbcNomeBanco.HeaderText = "Nome";
            this.dgvtbcNomeBanco.Name = "dgvtbcNomeBanco";
            this.dgvtbcNomeBanco.ReadOnly = true;
            // 
            // tbFiltroNomeBanco
            // 
            this.tbFiltroNomeBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltroNomeBanco.Location = new System.Drawing.Point(6, 32);
            this.tbFiltroNomeBanco.Name = "tbFiltroNomeBanco";
            this.tbFiltroNomeBanco.Size = new System.Drawing.Size(280, 20);
            this.tbFiltroNomeBanco.TabIndex = 0;
            this.tbFiltroNomeBanco.TextChanged += new System.EventHandler(this.TbFiltroNomeEstado_TextChanged);
            // 
            // fmBuscaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 379);
            this.Controls.Add(this.gbFiltros);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(337, 418);
            this.Name = "fmBuscaBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de bancos";
            this.Load += new System.EventHandler(this.FmBuscaBanco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaBanco_KeyDown);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lbFiltroNomeBanco;
        private System.Windows.Forms.DataGridView dgvBancos;
        private System.Windows.Forms.TextBox tbFiltroNomeBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeBanco;
    }
}