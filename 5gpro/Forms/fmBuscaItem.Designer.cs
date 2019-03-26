namespace _5gpro.Forms
{
    partial class fmBuscaItem
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
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tbDenomCompra = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbDenomCompra = new System.Windows.Forms.Label();
            this.gbTipoItem = new System.Windows.Forms.GroupBox();
            this.cbServico = new System.Windows.Forms.CheckBox();
            this.cbProduto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbTipoItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(12, 67);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.Size = new System.Drawing.Size(892, 371);
            this.dgvItens.TabIndex = 0;
            // 
            // tbDenomCompra
            // 
            this.tbDenomCompra.Location = new System.Drawing.Point(226, 35);
            this.tbDenomCompra.Name = "tbDenomCompra";
            this.tbDenomCompra.Size = new System.Drawing.Size(214, 20);
            this.tbDenomCompra.TabIndex = 1;
            this.tbDenomCompra.TextChanged += new System.EventHandler(this.tbDenomCompra_TextChanged);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(15, 35);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(205, 20);
            this.tbDescricao.TabIndex = 4;
            this.tbDescricao.TextChanged += new System.EventHandler(this.tbDescricao_TextChanged);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(15, 19);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 5;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbDenomCompra
            // 
            this.lbDenomCompra.AutoSize = true;
            this.lbDenomCompra.Location = new System.Drawing.Point(223, 19);
            this.lbDenomCompra.Name = "lbDenomCompra";
            this.lbDenomCompra.Size = new System.Drawing.Size(127, 13);
            this.lbDenomCompra.TabIndex = 6;
            this.lbDenomCompra.Text = "Denominação de Compra";
            // 
            // gbTipoItem
            // 
            this.gbTipoItem.Controls.Add(this.cbServico);
            this.gbTipoItem.Controls.Add(this.cbProduto);
            this.gbTipoItem.Location = new System.Drawing.Point(457, 12);
            this.gbTipoItem.Name = "gbTipoItem";
            this.gbTipoItem.Size = new System.Drawing.Size(149, 43);
            this.gbTipoItem.TabIndex = 8;
            this.gbTipoItem.TabStop = false;
            this.gbTipoItem.Text = "Tipo";
            // 
            // cbServico
            // 
            this.cbServico.AutoSize = true;
            this.cbServico.Location = new System.Drawing.Point(76, 23);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(62, 17);
            this.cbServico.TabIndex = 1;
            this.cbServico.Text = "Serviço";
            this.cbServico.UseVisualStyleBackColor = true;
            this.cbServico.Click += new System.EventHandler(this.cbServico_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.AutoSize = true;
            this.cbProduto.Location = new System.Drawing.Point(7, 23);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(63, 17);
            this.cbProduto.TabIndex = 0;
            this.cbProduto.Text = "Produto";
            this.cbProduto.UseVisualStyleBackColor = true;
            this.cbProduto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.cbProduto.Click += new System.EventHandler(this.cbProduto_Click);
            // 
            // fmBuscaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.gbTipoItem);
            this.Controls.Add(this.lbDenomCompra);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbDenomCompra);
            this.Controls.Add(this.dgvItens);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(932, 489);
            this.Name = "fmBuscaItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca de Itens";
            this.Load += new System.EventHandler(this.fmBuscaItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbTipoItem.ResumeLayout(false);
            this.gbTipoItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TextBox tbDenomCompra;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbDenomCompra;
        private System.Windows.Forms.GroupBox gbTipoItem;
        private System.Windows.Forms.CheckBox cbServico;
        private System.Windows.Forms.CheckBox cbProduto;
    }
}