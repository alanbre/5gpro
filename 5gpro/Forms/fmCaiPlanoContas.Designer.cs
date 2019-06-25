namespace _5gpro.Forms
{
    partial class fmCaiPlanoContas
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
            this.gbPlanoContas = new System.Windows.Forms.GroupBox();
            this.tbCodigoFilho = new System.Windows.Forms.TextBox();
            this.tvPlanoContas = new System.Windows.Forms.TreeView();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.gbPlanoContas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlanoContas
            // 
            this.gbPlanoContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPlanoContas.Controls.Add(this.tbCodigoFilho);
            this.gbPlanoContas.Controls.Add(this.tvPlanoContas);
            this.gbPlanoContas.Controls.Add(this.tbDescricao);
            this.gbPlanoContas.Controls.Add(this.lbDescricao);
            this.gbPlanoContas.Controls.Add(this.tbCodigo);
            this.gbPlanoContas.Controls.Add(this.lbCodigo);
            this.gbPlanoContas.Location = new System.Drawing.Point(65, 12);
            this.gbPlanoContas.Name = "gbPlanoContas";
            this.gbPlanoContas.Size = new System.Drawing.Size(664, 361);
            this.gbPlanoContas.TabIndex = 1;
            this.gbPlanoContas.TabStop = false;
            this.gbPlanoContas.Text = "Plano de contas";
            // 
            // tbCodigoFilho
            // 
            this.tbCodigoFilho.Location = new System.Drawing.Point(78, 32);
            this.tbCodigoFilho.Name = "tbCodigoFilho";
            this.tbCodigoFilho.Size = new System.Drawing.Size(28, 20);
            this.tbCodigoFilho.TabIndex = 5;
            // 
            // tvPlanoContas
            // 
            this.tvPlanoContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvPlanoContas.Location = new System.Drawing.Point(9, 58);
            this.tvPlanoContas.Name = "tvPlanoContas";
            this.tvPlanoContas.Size = new System.Drawing.Size(649, 297);
            this.tvPlanoContas.TabIndex = 4;
            this.tvPlanoContas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvPlanoContas_AfterSelect);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricao.Location = new System.Drawing.Point(112, 32);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(546, 20);
            this.tbDescricao.TabIndex = 3;
            this.tbDescricao.TextChanged += new System.EventHandler(this.TbDescricao_TextChanged);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(109, 16);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(9, 32);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(65, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 16);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 0;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical_Novo_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical_Salvar_Clicked);
            // 
            // fmCaiPlanoContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 381);
            this.Controls.Add(this.gbPlanoContas);
            this.Controls.Add(this.menuVertical);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(757, 420);
            this.Name = "fmCaiPlanoContas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano de contas do caixa";
            this.gbPlanoContas.ResumeLayout(false);
            this.gbPlanoContas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.GroupBox gbPlanoContas;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TreeView tvPlanoContas;
        private System.Windows.Forms.TextBox tbCodigoFilho;
    }
}