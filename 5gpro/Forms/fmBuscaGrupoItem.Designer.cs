namespace _5gpro.Forms
{
    partial class fmBuscaGrupoItem
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
            this.dgvGrupoItens = new System.Windows.Forms.DataGridView();
            this.tbNomeGrupoIten = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoItens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupoItens
            // 
            this.dgvGrupoItens.AllowUserToAddRows = false;
            this.dgvGrupoItens.AllowUserToDeleteRows = false;
            this.dgvGrupoItens.AllowUserToOrderColumns = true;
            this.dgvGrupoItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvGrupoItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupoItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGrupoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrupoItens.Location = new System.Drawing.Point(12, 38);
            this.dgvGrupoItens.MultiSelect = false;
            this.dgvGrupoItens.Name = "dgvGrupoItens";
            this.dgvGrupoItens.ReadOnly = true;
            this.dgvGrupoItens.RowHeadersVisible = false;
            this.dgvGrupoItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupoItens.Size = new System.Drawing.Size(298, 308);
            this.dgvGrupoItens.TabIndex = 0;
            this.dgvGrupoItens.TabStop = false;
            this.dgvGrupoItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupoItens_CellDoubleClick);
            // 
            // tbNomeGrupoIten
            // 
            this.tbNomeGrupoIten.Location = new System.Drawing.Point(12, 12);
            this.tbNomeGrupoIten.Name = "tbNomeGrupoIten";
            this.tbNomeGrupoIten.Size = new System.Drawing.Size(217, 20);
            this.tbNomeGrupoIten.TabIndex = 1;
            this.tbNomeGrupoIten.TextChanged += new System.EventHandler(this.TbNomeGrupoIten_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(235, 10);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // fmBuscaGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 358);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbNomeGrupoIten);
            this.Controls.Add(this.dgvGrupoItens);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 397);
            this.Name = "fmBuscaGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca de Grupo de Itens";
            this.Load += new System.EventHandler(this.FmBuscaGrupoItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupoItens;
        private System.Windows.Forms.TextBox tbNomeGrupoIten;
        private System.Windows.Forms.Button btPesquisar;
    }
}