namespace _5gpro.Forms
{
    partial class fmBuscaOperacao
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
            this.dgvOperacao = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNomeOperacao = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperacao
            // 
            this.dgvOperacao.AllowUserToAddRows = false;
            this.dgvOperacao.AllowUserToDeleteRows = false;
            this.dgvOperacao.AllowUserToOrderColumns = true;
            this.dgvOperacao.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvOperacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperacao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOperacao.Location = new System.Drawing.Point(12, 38);
            this.dgvOperacao.MultiSelect = false;
            this.dgvOperacao.Name = "dgvOperacao";
            this.dgvOperacao.ReadOnly = true;
            this.dgvOperacao.RowHeadersVisible = false;
            this.dgvOperacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperacao.Size = new System.Drawing.Size(776, 400);
            this.dgvOperacao.TabIndex = 0;
            this.dgvOperacao.TabStop = false;
            this.dgvOperacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOperacao_CellDoubleClick);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // tbNomeOperacao
            // 
            this.tbNomeOperacao.Location = new System.Drawing.Point(50, 12);
            this.tbNomeOperacao.Name = "tbNomeOperacao";
            this.tbNomeOperacao.Size = new System.Drawing.Size(645, 20);
            this.tbNomeOperacao.TabIndex = 2;
            this.tbNomeOperacao.TextChanged += new System.EventHandler(this.TbNomeOperacao_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(701, 9);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 3;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // fmBuscaOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbNomeOperacao);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.dgvOperacao);
            this.Name = "fmBuscaOperacao";
            this.Text = "fmBuscaOperacao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperacao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNomeOperacao;
        private System.Windows.Forms.Button btPesquisar;
    }
}