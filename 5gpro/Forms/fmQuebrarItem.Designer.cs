namespace _5gpro.Forms
{
    partial class fmQuebrarItem
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
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.buscaItem1 = new _5gpro.Controls.BuscaItem();
            this.gbQuebras = new System.Windows.Forms.GroupBox();
            this.dgvQuebras = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPorcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.lbCodigoquebra = new System.Windows.Forms.Label();
            this.lbNomequebra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.gbItem.SuspendLayout();
            this.gbQuebras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuebras)).BeginInit();
            this.SuspendLayout();
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.buscaItem1);
            this.gbItem.Location = new System.Drawing.Point(12, 12);
            this.gbItem.Name = "gbItem";
            this.gbItem.Size = new System.Drawing.Size(528, 74);
            this.gbItem.TabIndex = 1;
            this.gbItem.TabStop = false;
            // 
            // buscaItem1
            // 
            this.buscaItem1.Location = new System.Drawing.Point(6, 10);
            this.buscaItem1.Name = "buscaItem1";
            this.buscaItem1.Size = new System.Drawing.Size(442, 39);
            this.buscaItem1.TabIndex = 0;
            // 
            // gbQuebras
            // 
            this.gbQuebras.Controls.Add(this.btSalvar);
            this.gbQuebras.Controls.Add(this.textBox2);
            this.gbQuebras.Controls.Add(this.textBox1);
            this.gbQuebras.Controls.Add(this.lbNomequebra);
            this.gbQuebras.Controls.Add(this.lbCodigoquebra);
            this.gbQuebras.Controls.Add(this.dgvQuebras);
            this.gbQuebras.Location = new System.Drawing.Point(12, 92);
            this.gbQuebras.Name = "gbQuebras";
            this.gbQuebras.Size = new System.Drawing.Size(528, 320);
            this.gbQuebras.TabIndex = 2;
            this.gbQuebras.TabStop = false;
            this.gbQuebras.Text = "Quebras";
            // 
            // dgvQuebras
            // 
            this.dgvQuebras.AllowUserToAddRows = false;
            this.dgvQuebras.AllowUserToDeleteRows = false;
            this.dgvQuebras.AllowUserToOrderColumns = true;
            this.dgvQuebras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvQuebras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuebras.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuebras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuebras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigo,
            this.dgvtbcNome,
            this.dgvtbcPorcentagem});
            this.dgvQuebras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuebras.Location = new System.Drawing.Point(6, 19);
            this.dgvQuebras.MultiSelect = false;
            this.dgvQuebras.Name = "dgvQuebras";
            this.dgvQuebras.ReadOnly = true;
            this.dgvQuebras.RowHeadersVisible = false;
            this.dgvQuebras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuebras.Size = new System.Drawing.Size(516, 227);
            this.dgvQuebras.TabIndex = 0;
            this.dgvQuebras.TabStop = false;
            // 
            // dgvtbcCodigo
            // 
            this.dgvtbcCodigo.HeaderText = "Código";
            this.dgvtbcCodigo.Name = "dgvtbcCodigo";
            this.dgvtbcCodigo.ReadOnly = true;
            // 
            // dgvtbcNome
            // 
            this.dgvtbcNome.HeaderText = "Nome";
            this.dgvtbcNome.Name = "dgvtbcNome";
            this.dgvtbcNome.ReadOnly = true;
            // 
            // dgvtbcPorcentagem
            // 
            this.dgvtbcPorcentagem.HeaderText = "Porcentagem";
            this.dgvtbcPorcentagem.Name = "dgvtbcPorcentagem";
            this.dgvtbcPorcentagem.ReadOnly = true;
            // 
            // tbAjuda
            // 
            this.tbAjuda.Location = new System.Drawing.Point(12, 418);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(528, 20);
            this.tbAjuda.TabIndex = 3;
            // 
            // lbCodigoquebra
            // 
            this.lbCodigoquebra.AutoSize = true;
            this.lbCodigoquebra.Location = new System.Drawing.Point(6, 249);
            this.lbCodigoquebra.Name = "lbCodigoquebra";
            this.lbCodigoquebra.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoquebra.TabIndex = 1;
            this.lbCodigoquebra.Text = "Código";
            // 
            // lbNomequebra
            // 
            this.lbNomequebra.AutoSize = true;
            this.lbNomequebra.Location = new System.Drawing.Point(68, 249);
            this.lbNomequebra.Name = "lbNomequebra";
            this.lbNomequebra.Size = new System.Drawing.Size(35, 13);
            this.lbNomequebra.TabIndex = 2;
            this.lbNomequebra.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(451, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(6, 291);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // fmQuebrarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbQuebras);
            this.Controls.Add(this.gbItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmQuebrarItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quebrar Item";
            this.gbItem.ResumeLayout(false);
            this.gbQuebras.ResumeLayout(false);
            this.gbQuebras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuebras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbItem;
        private Controls.BuscaItem buscaItem1;
        private System.Windows.Forms.GroupBox gbQuebras;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.DataGridView dgvQuebras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPorcentagem;
        private System.Windows.Forms.Label lbNomequebra;
        private System.Windows.Forms.Label lbCodigoquebra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btSalvar;
    }
}