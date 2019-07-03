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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOperacao = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNomeOperacao = new System.Windows.Forms.TextBox();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.gbCondicao = new System.Windows.Forms.GroupBox();
            this.cbAvista = new System.Windows.Forms.CheckBox();
            this.cbAprazo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacao)).BeginInit();
            this.gbBusca.SuspendLayout();
            this.gbCondicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOperacao
            // 
            this.dgvOperacao.AllowUserToAddRows = false;
            this.dgvOperacao.AllowUserToDeleteRows = false;
            this.dgvOperacao.AllowUserToOrderColumns = true;
            this.dgvOperacao.AllowUserToResizeColumns = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.dgvOperacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOperacao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOperacao.Location = new System.Drawing.Point(6, 72);
            this.dgvOperacao.MultiSelect = false;
            this.dgvOperacao.Name = "dgvOperacao";
            this.dgvOperacao.ReadOnly = true;
            this.dgvOperacao.RowHeadersVisible = false;
            this.dgvOperacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperacao.Size = new System.Drawing.Size(518, 205);
            this.dgvOperacao.TabIndex = 0;
            this.dgvOperacao.TabStop = false;
            this.dgvOperacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOperacao_CellDoubleClick);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(3, 30);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // tbNomeOperacao
            // 
            this.tbNomeOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeOperacao.Location = new System.Drawing.Point(6, 46);
            this.tbNomeOperacao.Name = "tbNomeOperacao";
            this.tbNomeOperacao.Size = new System.Drawing.Size(284, 20);
            this.tbNomeOperacao.TabIndex = 2;
            this.tbNomeOperacao.TextChanged += new System.EventHandler(this.TbNomeOperacao_TextChanged);
            // 
            // gbBusca
            // 
            this.gbBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBusca.Controls.Add(this.gbCondicao);
            this.gbBusca.Controls.Add(this.dgvOperacao);
            this.gbBusca.Controls.Add(this.tbNomeOperacao);
            this.gbBusca.Controls.Add(this.lbNome);
            this.gbBusca.Location = new System.Drawing.Point(12, 12);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(541, 299);
            this.gbBusca.TabIndex = 3;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Busca";
            // 
            // gbCondicao
            // 
            this.gbCondicao.Controls.Add(this.cbAprazo);
            this.gbCondicao.Controls.Add(this.cbAvista);
            this.gbCondicao.Location = new System.Drawing.Point(296, 19);
            this.gbCondicao.Name = "gbCondicao";
            this.gbCondicao.Size = new System.Drawing.Size(137, 47);
            this.gbCondicao.TabIndex = 3;
            this.gbCondicao.TabStop = false;
            this.gbCondicao.Text = "Condição";
            // 
            // cbAvista
            // 
            this.cbAvista.AutoSize = true;
            this.cbAvista.Location = new System.Drawing.Point(6, 19);
            this.cbAvista.Name = "cbAvista";
            this.cbAvista.Size = new System.Drawing.Size(58, 17);
            this.cbAvista.TabIndex = 0;
            this.cbAvista.Text = "À vista";
            this.cbAvista.UseVisualStyleBackColor = true;
            this.cbAvista.Click += new System.EventHandler(this.CbAvista_Click);
            // 
            // cbAprazo
            // 
            this.cbAprazo.AutoSize = true;
            this.cbAprazo.Location = new System.Drawing.Point(70, 19);
            this.cbAprazo.Name = "cbAprazo";
            this.cbAprazo.Size = new System.Drawing.Size(62, 17);
            this.cbAprazo.TabIndex = 1;
            this.cbAprazo.Text = "A prazo";
            this.cbAprazo.UseVisualStyleBackColor = true;
            this.cbAprazo.Click += new System.EventHandler(this.CbAprazo_Click);
            // 
            // fmBuscaOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 320);
            this.Controls.Add(this.gbBusca);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(579, 359);
            this.Name = "fmBuscaOperacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Operação";
            this.Load += new System.EventHandler(this.FmBuscaOperacao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaOperacao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacao)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.gbCondicao.ResumeLayout(false);
            this.gbCondicao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperacao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNomeOperacao;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.GroupBox gbCondicao;
        private System.Windows.Forms.CheckBox cbAprazo;
        private System.Windows.Forms.CheckBox cbAvista;
    }
}