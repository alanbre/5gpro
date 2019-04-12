namespace _5gpro.Forms
{
    partial class fmBuscaUnidadeMedida
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
            this.tbFiltroUnimedida = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.unimedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnimedida)).BeginInit();
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
            this.dgvUnimedida.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUnimedida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUnimedida.Location = new System.Drawing.Point(12, 41);
            this.dgvUnimedida.MultiSelect = false;
            this.dgvUnimedida.Name = "dgvUnimedida";
            this.dgvUnimedida.ReadOnly = true;
            this.dgvUnimedida.RowHeadersVisible = false;
            this.dgvUnimedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnimedida.Size = new System.Drawing.Size(560, 360);
            this.dgvUnimedida.TabIndex = 3;
            this.dgvUnimedida.TabStop = false;
            this.dgvUnimedida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnimedida_CellContentClick);
            this.dgvUnimedida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnimedida_CellDoubleClick);
            // 
            // tbFiltroUnimedida
            // 
            this.tbFiltroUnimedida.Location = new System.Drawing.Point(12, 12);
            this.tbFiltroUnimedida.Name = "tbFiltroUnimedida";
            this.tbFiltroUnimedida.Size = new System.Drawing.Size(483, 20);
            this.tbFiltroUnimedida.TabIndex = 4;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(501, 12);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(71, 23);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // unimedidaBindingSource
            // 
            this.unimedidaBindingSource.DataSource = typeof(_5gpro.Entities.UnidadeMedida);
            // 
            // fmBuscaUnimedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroUnimedida);
            this.Controls.Add(this.dgvUnimedida);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "fmBuscaUnimedida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca de Unidade de Medida";
            this.Load += new System.EventHandler(this.fmBuscaUnimedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnimedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unimedidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnimedida;
        private System.Windows.Forms.BindingSource unimedidaBindingSource;
        private System.Windows.Forms.TextBox tbFiltroUnimedida;
        private System.Windows.Forms.Button btPesquisar;
    }
}