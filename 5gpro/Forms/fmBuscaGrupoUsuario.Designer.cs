namespace _5gpro.Forms
{
    partial class fmBuscaGrupoUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGrupoUsuario = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxNomeGrupoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFiltroNomeGrupoUsuario = new System.Windows.Forms.TextBox();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoUsuario)).BeginInit();
            this.gbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrupoUsuario
            // 
            this.dgvGrupoUsuario.AllowUserToAddRows = false;
            this.dgvGrupoUsuario.AllowUserToDeleteRows = false;
            this.dgvGrupoUsuario.AllowUserToOrderColumns = true;
            this.dgvGrupoUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvGrupoUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrupoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrupoUsuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGrupoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn,
            this.DataGridViewTextBoxNomeGrupoUsuario});
            this.dgvGrupoUsuario.Location = new System.Drawing.Point(6, 69);
            this.dgvGrupoUsuario.MultiSelect = false;
            this.dgvGrupoUsuario.Name = "dgvGrupoUsuario";
            this.dgvGrupoUsuario.ReadOnly = true;
            this.dgvGrupoUsuario.RowHeadersVisible = false;
            this.dgvGrupoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupoUsuario.Size = new System.Drawing.Size(335, 204);
            this.dgvGrupoUsuario.TabIndex = 0;
            this.dgvGrupoUsuario.TabStop = false;
            this.dgvGrupoUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupoUsuario_CellDoubleClick);
            // 
            // DataGridViewTextBoxColumn
            // 
            this.DataGridViewTextBoxColumn.HeaderText = "Código";
            this.DataGridViewTextBoxColumn.MinimumWidth = 80;
            this.DataGridViewTextBoxColumn.Name = "DataGridViewTextBoxColumn";
            this.DataGridViewTextBoxColumn.ReadOnly = true;
            this.DataGridViewTextBoxColumn.Width = 80;
            // 
            // DataGridViewTextBoxNomeGrupoUsuario
            // 
            this.DataGridViewTextBoxNomeGrupoUsuario.HeaderText = "Nome";
            this.DataGridViewTextBoxNomeGrupoUsuario.MinimumWidth = 250;
            this.DataGridViewTextBoxNomeGrupoUsuario.Name = "DataGridViewTextBoxNomeGrupoUsuario";
            this.DataGridViewTextBoxNomeGrupoUsuario.ReadOnly = true;
            this.DataGridViewTextBoxNomeGrupoUsuario.Width = 250;
            // 
            // tbFiltroNomeGrupoUsuario
            // 
            this.tbFiltroNomeGrupoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiltroNomeGrupoUsuario.Location = new System.Drawing.Point(7, 43);
            this.tbFiltroNomeGrupoUsuario.Name = "tbFiltroNomeGrupoUsuario";
            this.tbFiltroNomeGrupoUsuario.Size = new System.Drawing.Size(334, 20);
            this.tbFiltroNomeGrupoUsuario.TabIndex = 1;
            this.tbFiltroNomeGrupoUsuario.TextChanged += new System.EventHandler(this.TbFiltroNomeGrupoUsuario_TextChanged);
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.lbNome);
            this.gbBusca.Controls.Add(this.dgvGrupoUsuario);
            this.gbBusca.Controls.Add(this.tbFiltroNomeGrupoUsuario);
            this.gbBusca.Location = new System.Drawing.Point(12, 12);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(348, 287);
            this.gbBusca.TabIndex = 2;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Busca";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 27);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // fmBuscaGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 311);
            this.Controls.Add(this.gbBusca);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 350);
            this.Name = "fmBuscaGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Grupo de Usuários";
            this.Load += new System.EventHandler(this.FmBuscaGrupoUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaGrupoUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoUsuario)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupoUsuario;
        private System.Windows.Forms.TextBox tbFiltroNomeGrupoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxNomeGrupoUsuario;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label lbNome;
    }
}