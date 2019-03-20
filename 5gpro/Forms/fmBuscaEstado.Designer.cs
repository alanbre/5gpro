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
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbFiltroNomeCidade = new System.Windows.Forms.TextBox();
            this.lbFiltroNomeEstado = new System.Windows.Forms.Label();
            this.colunaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCidades
            // 
            this.dgvCidades.AllowUserToAddRows = false;
            this.dgvCidades.AllowUserToDeleteRows = false;
            this.dgvCidades.AllowUserToOrderColumns = true;
            this.dgvCidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCidades.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaCodigo,
            this.colunaNomeEstado});
            this.dgvCidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCidades.Location = new System.Drawing.Point(12, 52);
            this.dgvCidades.MaximumSize = new System.Drawing.Size(560, 360);
            this.dgvCidades.MinimumSize = new System.Drawing.Size(560, 360);
            this.dgvCidades.MultiSelect = false;
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.ReadOnly = true;
            this.dgvCidades.RowHeadersVisible = false;
            this.dgvCidades.Size = new System.Drawing.Size(560, 360);
            this.dgvCidades.TabIndex = 11;
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
            // tbFiltroNomeCidade
            // 
            this.tbFiltroNomeCidade.Location = new System.Drawing.Point(12, 26);
            this.tbFiltroNomeCidade.Name = "tbFiltroNomeCidade";
            this.tbFiltroNomeCidade.Size = new System.Drawing.Size(492, 20);
            this.tbFiltroNomeCidade.TabIndex = 9;
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
            // colunaCodigo
            // 
            this.colunaCodigo.HeaderText = "Código";
            this.colunaCodigo.MinimumWidth = 50;
            this.colunaCodigo.Name = "colunaCodigo";
            this.colunaCodigo.ReadOnly = true;
            this.colunaCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colunaNomeEstado
            // 
            this.colunaNomeEstado.HeaderText = "Nome do estado";
            this.colunaNomeEstado.MinimumWidth = 100;
            this.colunaNomeEstado.Name = "colunaNomeEstado";
            this.colunaNomeEstado.ReadOnly = true;
            // 
            // fmBuscaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 427);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroNomeCidade);
            this.Controls.Add(this.lbFiltroNomeEstado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 465);
            this.Name = "fmBuscaEstado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca Estado";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbFiltroNomeCidade;
        private System.Windows.Forms.Label lbFiltroNomeEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeEstado;
    }
}