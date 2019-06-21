namespace _5gpro.Forms
{
    partial class fmCaiCadastroCaixa
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
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.gbDadosCaixa = new System.Windows.Forms.GroupBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.gbDadosCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 1;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical_Proximo_Clicked);
            // 
            // gbDadosCaixa
            // 
            this.gbDadosCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosCaixa.Controls.Add(this.tbDescricao);
            this.gbDadosCaixa.Controls.Add(this.lbDescricao);
            this.gbDadosCaixa.Controls.Add(this.tbNome);
            this.gbDadosCaixa.Controls.Add(this.lbNome);
            this.gbDadosCaixa.Controls.Add(this.tbCodigo);
            this.gbDadosCaixa.Controls.Add(this.lbCodigo);
            this.gbDadosCaixa.Location = new System.Drawing.Point(65, 9);
            this.gbDadosCaixa.Name = "gbDadosCaixa";
            this.gbDadosCaixa.Size = new System.Drawing.Size(379, 331);
            this.gbDadosCaixa.TabIndex = 0;
            this.gbDadosCaixa.TabStop = false;
            this.gbDadosCaixa.Text = "Dados do caixa";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(6, 110);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(367, 116);
            this.tbDescricao.TabIndex = 5;
            this.tbDescricao.TextChanged += new System.EventHandler(this.TbDescricao_TextChanged);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(6, 94);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 4;
            this.lbDescricao.Text = "Descrição";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(6, 71);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(367, 20);
            this.tbNome.TabIndex = 3;
            this.tbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 55);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(6, 32);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(71, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
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
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(65, 346);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(379, 20);
            this.tbAjuda.TabIndex = 5;
            // 
            // fmCaiCadastroCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 378);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbDadosCaixa);
            this.Controls.Add(this.menuVertical);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 417);
            this.Name = "fmCaiCadastroCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de caixa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCaiCadastroCaixa_FormClosing);
            this.Load += new System.EventHandler(this.FmCaiCadastroCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCaiCadastroCaixa_KeyDown);
            this.gbDadosCaixa.ResumeLayout(false);
            this.gbDadosCaixa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.GroupBox gbDadosCaixa;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbAjuda;
    }
}