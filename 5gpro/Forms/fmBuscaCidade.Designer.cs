namespace _5gpro.Forms
{
    partial class fmBuscaCidade
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
            this.lbEstado = new System.Windows.Forms.Label();
            this.tbFiltroCodEstado = new System.Windows.Forms.TextBox();
            this.btProcuraEstado = new System.Windows.Forms.Button();
            this.tbNomeEstado = new System.Windows.Forms.TextBox();
            this.lbFiltroNomeCidade = new System.Windows.Forms.Label();
            this.tbFiltroNomeCidade = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(12, 9);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 0;
            this.lbEstado.Text = "Estado";
            // 
            // tbFiltroCodEstado
            // 
            this.tbFiltroCodEstado.Location = new System.Drawing.Point(12, 25);
            this.tbFiltroCodEstado.Name = "tbFiltroCodEstado";
            this.tbFiltroCodEstado.Size = new System.Drawing.Size(54, 20);
            this.tbFiltroCodEstado.TabIndex = 0;
            this.tbFiltroCodEstado.Enter += new System.EventHandler(this.tbFiltroCodEstado_Enter);
            this.tbFiltroCodEstado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltroCodEstado_KeyUp);
            this.tbFiltroCodEstado.Leave += new System.EventHandler(this.tbFiltroCodEstado_Leave);
            // 
            // btProcuraEstado
            // 
            this.btProcuraEstado.Location = new System.Drawing.Point(68, 25);
            this.btProcuraEstado.Name = "btProcuraEstado";
            this.btProcuraEstado.Size = new System.Drawing.Size(20, 20);
            this.btProcuraEstado.TabIndex = 0;
            this.btProcuraEstado.TabStop = false;
            this.btProcuraEstado.UseVisualStyleBackColor = true;
            this.btProcuraEstado.Click += new System.EventHandler(this.btProcuraEstado_Click);
            // 
            // tbNomeEstado
            // 
            this.tbNomeEstado.Location = new System.Drawing.Point(90, 25);
            this.tbNomeEstado.Name = "tbNomeEstado";
            this.tbNomeEstado.ReadOnly = true;
            this.tbNomeEstado.Size = new System.Drawing.Size(414, 20);
            this.tbNomeEstado.TabIndex = 1;
            this.tbNomeEstado.TabStop = false;
            // 
            // lbFiltroNomeCidade
            // 
            this.lbFiltroNomeCidade.AutoSize = true;
            this.lbFiltroNomeCidade.Location = new System.Drawing.Point(12, 48);
            this.lbFiltroNomeCidade.Name = "lbFiltroNomeCidade";
            this.lbFiltroNomeCidade.Size = new System.Drawing.Size(85, 13);
            this.lbFiltroNomeCidade.TabIndex = 4;
            this.lbFiltroNomeCidade.Text = "Nome da cidade";
            // 
            // tbFiltroNomeCidade
            // 
            this.tbFiltroNomeCidade.Location = new System.Drawing.Point(12, 64);
            this.tbFiltroNomeCidade.Name = "tbFiltroNomeCidade";
            this.tbFiltroNomeCidade.Size = new System.Drawing.Size(492, 20);
            this.tbFiltroNomeCidade.TabIndex = 1;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(510, 64);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dgvCidades
            // 
            this.dgvCidades.AllowUserToAddRows = false;
            this.dgvCidades.AllowUserToDeleteRows = false;
            this.dgvCidades.AllowUserToOrderColumns = true;
            this.dgvCidades.AllowUserToResizeRows = false;
            this.dgvCidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCidades.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCidades.Location = new System.Drawing.Point(12, 90);
            this.dgvCidades.MinimumSize = new System.Drawing.Size(560, 360);
            this.dgvCidades.MultiSelect = false;
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.ReadOnly = true;
            this.dgvCidades.RowHeadersVisible = false;
            this.dgvCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCidades.Size = new System.Drawing.Size(560, 360);
            this.dgvCidades.TabIndex = 3;
            this.dgvCidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCidades_CellDoubleClick);
            // 
            // fmBuscaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroNomeCidade);
            this.Controls.Add(this.lbFiltroNomeCidade);
            this.Controls.Add(this.tbNomeEstado);
            this.Controls.Add(this.btProcuraEstado);
            this.Controls.Add(this.tbFiltroCodEstado);
            this.Controls.Add(this.lbEstado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "fmBuscaCidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca Cidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox tbFiltroCodEstado;
        private System.Windows.Forms.Button btProcuraEstado;
        private System.Windows.Forms.TextBox tbNomeEstado;
        private System.Windows.Forms.Label lbFiltroNomeCidade;
        private System.Windows.Forms.TextBox tbFiltroNomeCidade;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dgvCidades;
    }
}