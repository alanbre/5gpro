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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbFiltroNomeCidade = new System.Windows.Forms.Label();
            this.tbFiltroNomeCidade = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomeCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCodEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomeEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscaEstado = new _5gpro.Controls.BuscaEstado();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFiltroNomeCidade
            // 
            this.lbFiltroNomeCidade.AutoSize = true;
            this.lbFiltroNomeCidade.Location = new System.Drawing.Point(12, 48);
            this.lbFiltroNomeCidade.Name = "lbFiltroNomeCidade";
            this.lbFiltroNomeCidade.Size = new System.Drawing.Size(85, 13);
            this.lbFiltroNomeCidade.TabIndex = 2;
            this.lbFiltroNomeCidade.Text = "Nome da cidade";
            // 
            // tbFiltroNomeCidade
            // 
            this.tbFiltroNomeCidade.Location = new System.Drawing.Point(12, 64);
            this.tbFiltroNomeCidade.Name = "tbFiltroNomeCidade";
            this.tbFiltroNomeCidade.Size = new System.Drawing.Size(492, 20);
            this.tbFiltroNomeCidade.TabIndex = 0;
            this.tbFiltroNomeCidade.TextChanged += new System.EventHandler(this.TbFiltroNomeCidade_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(510, 64);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // dgvCidades
            // 
            this.dgvCidades.AllowUserToAddRows = false;
            this.dgvCidades.AllowUserToDeleteRows = false;
            this.dgvCidades.AllowUserToOrderColumns = true;
            this.dgvCidades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvCidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCidades.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodCidade,
            this.dgvtbcNomeCidade,
            this.dgvtbcCodEstado,
            this.dgvtbcNomeEstado,
            this.dgvtbcUf});
            this.dgvCidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCidades.Location = new System.Drawing.Point(12, 90);
            this.dgvCidades.MinimumSize = new System.Drawing.Size(560, 360);
            this.dgvCidades.MultiSelect = false;
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.ReadOnly = true;
            this.dgvCidades.RowHeadersVisible = false;
            this.dgvCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCidades.Size = new System.Drawing.Size(560, 360);
            this.dgvCidades.TabIndex = 4;
            this.dgvCidades.TabStop = false;
            this.dgvCidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCidades_CellDoubleClick);
            // 
            // dgvtbcCodCidade
            // 
            this.dgvtbcCodCidade.HeaderText = "Código";
            this.dgvtbcCodCidade.Name = "dgvtbcCodCidade";
            this.dgvtbcCodCidade.ReadOnly = true;
            // 
            // dgvtbcNomeCidade
            // 
            this.dgvtbcNomeCidade.HeaderText = "Cidade";
            this.dgvtbcNomeCidade.Name = "dgvtbcNomeCidade";
            this.dgvtbcNomeCidade.ReadOnly = true;
            // 
            // dgvtbcCodEstado
            // 
            this.dgvtbcCodEstado.HeaderText = "Código Estado";
            this.dgvtbcCodEstado.Name = "dgvtbcCodEstado";
            this.dgvtbcCodEstado.ReadOnly = true;
            // 
            // dgvtbcNomeEstado
            // 
            this.dgvtbcNomeEstado.HeaderText = "Estado";
            this.dgvtbcNomeEstado.Name = "dgvtbcNomeEstado";
            this.dgvtbcNomeEstado.ReadOnly = true;
            // 
            // dgvtbcUf
            // 
            this.dgvtbcUf.HeaderText = "UF";
            this.dgvtbcUf.Name = "dgvtbcUf";
            this.dgvtbcUf.ReadOnly = true;
            // 
            // buscaEstado
            // 
            this.buscaEstado.Location = new System.Drawing.Point(6, 5);
            this.buscaEstado.Margin = new System.Windows.Forms.Padding(0);
            this.buscaEstado.Name = "buscaEstado";
            this.buscaEstado.Size = new System.Drawing.Size(442, 39);
            this.buscaEstado.TabIndex = 3;
            // 
            // fmBuscaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buscaEstado);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroNomeCidade);
            this.Controls.Add(this.lbFiltroNomeCidade);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "fmBuscaCidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Cidades";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaCidade_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFiltroNomeCidade;
        private System.Windows.Forms.TextBox tbFiltroNomeCidade;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcUf;
        private Controls.BuscaEstado buscaEstado;
    }
}