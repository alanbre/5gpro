namespace _5gpro.Forms
{
    partial class fmBuscaEstado
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
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbFiltroNomeEstado = new System.Windows.Forms.TextBox();
            this.lbFiltroNomeEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstados
            // 
            this.dgvEstados.AllowUserToAddRows = false;
            this.dgvEstados.AllowUserToDeleteRows = false;
            this.dgvEstados.AllowUserToOrderColumns = true;
            this.dgvEstados.AllowUserToResizeRows = false;
            this.dgvEstados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEstados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEstados.Location = new System.Drawing.Point(12, 52);
            this.dgvEstados.MinimumSize = new System.Drawing.Size(560, 360);
            this.dgvEstados.MultiSelect = false;
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.ReadOnly = true;
            this.dgvEstados.RowHeadersVisible = false;
            this.dgvEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstados.Size = new System.Drawing.Size(560, 360);
            this.dgvEstados.TabIndex = 11;
            this.dgvEstados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstados_CellDoubleClick);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(510, 26);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 10;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // tbFiltroNomeEstado
            // 
            this.tbFiltroNomeEstado.Location = new System.Drawing.Point(12, 26);
            this.tbFiltroNomeEstado.Name = "tbFiltroNomeEstado";
            this.tbFiltroNomeEstado.Size = new System.Drawing.Size(492, 20);
            this.tbFiltroNomeEstado.TabIndex = 9;
            // 
            // lbFiltroNomeEstado
            // 
            this.lbFiltroNomeEstado.AutoSize = true;
            this.lbFiltroNomeEstado.Location = new System.Drawing.Point(12, 10);
            this.lbFiltroNomeEstado.Name = "lbFiltroNomeEstado";
            this.lbFiltroNomeEstado.Size = new System.Drawing.Size(85, 13);
            this.lbFiltroNomeEstado.TabIndex = 8;
            this.lbFiltroNomeEstado.Text = "Nome da estado";
            // 
            // fmBuscaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 427);
            this.Controls.Add(this.dgvEstados);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroNomeEstado);
            this.Controls.Add(this.lbFiltroNomeEstado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 465);
            this.Name = "fmBuscaEstado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca Estado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbFiltroNomeEstado;
        private System.Windows.Forms.Label lbFiltroNomeEstado;
    }
}