namespace _5gpro.Forms
{
    partial class fmBuscaItemSeleciona
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
            this.lbCodigoInterno = new System.Windows.Forms.Label();
            this.tbCodigoInterno = new System.Windows.Forms.TextBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigoInterno
            // 
            this.lbCodigoInterno.AutoSize = true;
            this.lbCodigoInterno.Location = new System.Drawing.Point(12, 9);
            this.lbCodigoInterno.Name = "lbCodigoInterno";
            this.lbCodigoInterno.Size = new System.Drawing.Size(75, 13);
            this.lbCodigoInterno.TabIndex = 0;
            this.lbCodigoInterno.Text = "Código interno";
            // 
            // tbCodigoInterno
            // 
            this.tbCodigoInterno.Location = new System.Drawing.Point(15, 25);
            this.tbCodigoInterno.Name = "tbCodigoInterno";
            this.tbCodigoInterno.Size = new System.Drawing.Size(120, 20);
            this.tbCodigoInterno.TabIndex = 1;
            this.tbCodigoInterno.TextChanged += new System.EventHandler(this.TbCodigoInterno_TextChanged);
            this.tbCodigoInterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbCodigoInterno_KeyDown);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToOrderColumns = true;
            this.dgvItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItens.Location = new System.Drawing.Point(15, 51);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(606, 401);
            this.dgvItens.TabIndex = 2;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItens_CellDoubleClick);
            this.dgvItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvItens_KeyDown);
            // 
            // fmBuscaItemSeleciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 460);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.tbCodigoInterno);
            this.Controls.Add(this.lbCodigoInterno);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "fmBuscaItemSeleciona";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Seleção do item";
            this.Load += new System.EventHandler(this.FmBuscaItemSeleciona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoInterno;
        private System.Windows.Forms.TextBox tbCodigoInterno;
        private System.Windows.Forms.DataGridView dgvItens;
    }
}