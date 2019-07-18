namespace _5gpro.Forms
{
    partial class fmBuscaUnimedida
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUnimedida = new System.Windows.Forms.DataGridView();
            this.tbFiltroDescUnimedida = new System.Windows.Forms.TextBox();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.unimedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnimedida)).BeginInit();
            this.gbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unimedidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnimedida
            // 
            this.dgvUnimedida.AllowUserToAddRows = false;
            this.dgvUnimedida.AllowUserToDeleteRows = false;
            this.dgvUnimedida.AllowUserToOrderColumns = true;
            this.dgvUnimedida.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvUnimedida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnimedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnimedida.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUnimedida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUnimedida.Location = new System.Drawing.Point(9, 68);
            this.dgvUnimedida.MultiSelect = false;
            this.dgvUnimedida.Name = "dgvUnimedida";
            this.dgvUnimedida.ReadOnly = true;
            this.dgvUnimedida.RowHeadersVisible = false;
            this.dgvUnimedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnimedida.Size = new System.Drawing.Size(232, 199);
            this.dgvUnimedida.TabIndex = 3;
            this.dgvUnimedida.TabStop = false;
            this.dgvUnimedida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUnimedida_CellDoubleClick);
            // 
            // tbFiltroDescUnimedida
            // 
            this.tbFiltroDescUnimedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltroDescUnimedida.Location = new System.Drawing.Point(9, 42);
            this.tbFiltroDescUnimedida.Name = "tbFiltroDescUnimedida";
            this.tbFiltroDescUnimedida.Size = new System.Drawing.Size(232, 20);
            this.tbFiltroDescUnimedida.TabIndex = 4;
            this.tbFiltroDescUnimedida.TextChanged += new System.EventHandler(this.TbFiltroDescUnimedida_TextChanged);
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.lbNome);
            this.gbBusca.Controls.Add(this.dgvUnimedida);
            this.gbBusca.Controls.Add(this.tbFiltroDescUnimedida);
            this.gbBusca.Location = new System.Drawing.Point(12, 16);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(261, 291);
            this.gbBusca.TabIndex = 5;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Busca";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 26);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome";
            // 
            // unimedidaBindingSource
            // 
            this.unimedidaBindingSource.DataSource = typeof(_5gpro.Entities.Unimedida);
            // 
            // fmBuscaUnimedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 319);
            this.Controls.Add(this.gbBusca);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(296, 358);
            this.Name = "fmBuscaUnimedida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Unidade de Medida";
            this.Load += new System.EventHandler(this.FmBuscaUnimedida_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaUnimedida_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnimedida)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unimedidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnimedida;
        private System.Windows.Forms.BindingSource unimedidaBindingSource;
        private System.Windows.Forms.TextBox tbFiltroDescUnimedida;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label lbNome;
    }
}