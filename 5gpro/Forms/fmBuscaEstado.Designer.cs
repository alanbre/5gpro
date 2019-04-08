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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomeEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbFiltroNomeEstado = new System.Windows.Forms.TextBox();
            this.lbFiltroNomeEstado = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstados
            // 
            this.dgvEstados.AllowUserToAddRows = false;
            this.dgvEstados.AllowUserToDeleteRows = false;
            this.dgvEstados.AllowUserToOrderColumns = true;
            this.dgvEstados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvEstados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodEstado,
            this.dgvtbcNomeEstado});
            this.dgvEstados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEstados.Location = new System.Drawing.Point(12, 92);
            this.dgvEstados.MinimumSize = new System.Drawing.Size(560, 360);
            this.dgvEstados.MultiSelect = false;
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.ReadOnly = true;
            this.dgvEstados.RowHeadersVisible = false;
            this.dgvEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstados.Size = new System.Drawing.Size(573, 363);
            this.dgvEstados.TabIndex = 2;
            this.dgvEstados.TabStop = false;
            this.dgvEstados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstados_CellDoubleClick);
            // 
            // dgvtbcCodEstado
            // 
            this.dgvtbcCodEstado.HeaderText = "Código";
            this.dgvtbcCodEstado.Name = "dgvtbcCodEstado";
            this.dgvtbcCodEstado.ReadOnly = true;
            // 
            // dgvtbcNomeEstado
            // 
            this.dgvtbcNomeEstado.HeaderText = "Nome";
            this.dgvtbcNomeEstado.Name = "dgvtbcNomeEstado";
            this.dgvtbcNomeEstado.ReadOnly = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(504, 32);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // tbFiltroNomeEstado
            // 
            this.tbFiltroNomeEstado.Location = new System.Drawing.Point(6, 32);
            this.tbFiltroNomeEstado.Name = "tbFiltroNomeEstado";
            this.tbFiltroNomeEstado.Size = new System.Drawing.Size(492, 20);
            this.tbFiltroNomeEstado.TabIndex = 0;
            // 
            // lbFiltroNomeEstado
            // 
            this.lbFiltroNomeEstado.AutoSize = true;
            this.lbFiltroNomeEstado.Location = new System.Drawing.Point(6, 16);
            this.lbFiltroNomeEstado.Name = "lbFiltroNomeEstado";
            this.lbFiltroNomeEstado.Size = new System.Drawing.Size(85, 13);
            this.lbFiltroNomeEstado.TabIndex = 3;
            this.lbFiltroNomeEstado.Text = "Nome da estado";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.lbFiltroNomeEstado);
            this.gbFiltros.Controls.Add(this.tbFiltroNomeEstado);
            this.gbFiltros.Controls.Add(this.btPesquisar);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(573, 74);
            this.gbFiltros.TabIndex = 4;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros estado";
            // 
            // fmBuscaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 469);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvEstados);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(613, 508);
            this.Name = "fmBuscaEstado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca Estado";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaEstado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbFiltroNomeEstado;
        private System.Windows.Forms.Label lbFiltroNomeEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeEstado;
        private System.Windows.Forms.GroupBox gbFiltros;
    }
}