namespace _5gpro.Forms
{
    partial class fmCadastroUnimedida
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbSigla = new System.Windows.Forms.TextBox();
            this.gbUnimedidaCad = new System.Windows.Forms.GroupBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbSigla = new System.Windows.Forms.Label();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.gbUnimedidaCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(6, 35);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(68, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(6, 118);
            this.tbDescricao.MaxLength = 45;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(368, 20);
            this.tbDescricao.TabIndex = 5;
            this.tbDescricao.TextChanged += new System.EventHandler(this.TbDescricao_TextChanged);
            // 
            // tbSigla
            // 
            this.tbSigla.Location = new System.Drawing.Point(6, 77);
            this.tbSigla.MaxLength = 10;
            this.tbSigla.Name = "tbSigla";
            this.tbSigla.Size = new System.Drawing.Size(68, 20);
            this.tbSigla.TabIndex = 3;
            this.tbSigla.TextChanged += new System.EventHandler(this.TbSigla_TextChanged);
            // 
            // gbUnimedidaCad
            // 
            this.gbUnimedidaCad.Controls.Add(this.lbCodigo);
            this.gbUnimedidaCad.Controls.Add(this.lbDescricao);
            this.gbUnimedidaCad.Controls.Add(this.lbSigla);
            this.gbUnimedidaCad.Controls.Add(this.tbDescricao);
            this.gbUnimedidaCad.Controls.Add(this.tbCodigo);
            this.gbUnimedidaCad.Controls.Add(this.tbSigla);
            this.gbUnimedidaCad.Location = new System.Drawing.Point(65, 12);
            this.gbUnimedidaCad.Name = "gbUnimedidaCad";
            this.gbUnimedidaCad.Size = new System.Drawing.Size(565, 151);
            this.gbUnimedidaCad.TabIndex = 0;
            this.gbUnimedidaCad.TabStop = false;
            this.gbUnimedidaCad.Text = "Unidade de Medida";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(7, 16);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(3, 99);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 4;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbSigla
            // 
            this.lbSigla.AutoSize = true;
            this.lbSigla.Location = new System.Drawing.Point(3, 58);
            this.lbSigla.Name = "lbSigla";
            this.lbSigla.Size = new System.Drawing.Size(30, 13);
            this.lbSigla.TabIndex = 2;
            this.lbSigla.Text = "Sigla";
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
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(65, 349);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(565, 20);
            this.tbAjuda.TabIndex = 2;
            // 
            // fmCadastroUnimedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 378);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.gbUnimedidaCad);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(658, 417);
            this.Name = "fmCadastroUnimedida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de unidade de medida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroUnimedida_FormClosing);
            this.Load += new System.EventHandler(this.FmCadastroUnimedida_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroUnimedida_KeyDown);
            this.gbUnimedidaCad.ResumeLayout(false);
            this.gbUnimedidaCad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbSigla;
        private System.Windows.Forms.GroupBox gbUnimedidaCad;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbSigla;
        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.TextBox tbAjuda;
    }
}