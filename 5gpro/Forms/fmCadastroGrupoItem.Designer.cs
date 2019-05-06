namespace _5gpro.Forms
{
    partial class fmCadastroGrupoItem
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbNovoGrupoItem = new System.Windows.Forms.GroupBox();
            this.tbNomeGrupo = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.miniMenuVertical = new _5gpro.Controls.MiniMenuVertical();
            this.gbNovoGrupoItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 28);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código";
            // 
            // gbNovoGrupoItem
            // 
            this.gbNovoGrupoItem.Controls.Add(this.tbNomeGrupo);
            this.gbNovoGrupoItem.Controls.Add(this.lbNome);
            this.gbNovoGrupoItem.Controls.Add(this.tbCodigo);
            this.gbNovoGrupoItem.Controls.Add(this.lbCodigo);
            this.gbNovoGrupoItem.Location = new System.Drawing.Point(71, 12);
            this.gbNovoGrupoItem.Name = "gbNovoGrupoItem";
            this.gbNovoGrupoItem.Size = new System.Drawing.Size(255, 121);
            this.gbNovoGrupoItem.TabIndex = 2;
            this.gbNovoGrupoItem.TabStop = false;
            this.gbNovoGrupoItem.Text = "Novo Grupo de Itens";
            // 
            // tbNomeGrupo
            // 
            this.tbNomeGrupo.Location = new System.Drawing.Point(9, 89);
            this.tbNomeGrupo.Name = "tbNomeGrupo";
            this.tbNomeGrupo.Size = new System.Drawing.Size(184, 20);
            this.tbNomeGrupo.TabIndex = 4;
            this.tbNomeGrupo.TextChanged += new System.EventHandler(this.TbNomeGrupo_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 72);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(82, 13);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome do Grupo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(9, 45);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(82, 20);
            this.tbCodigo.TabIndex = 2;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCodigo_KeyPress);
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // tbAjuda
            // 
            this.tbAjuda.Location = new System.Drawing.Point(71, 193);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(255, 20);
            this.tbAjuda.TabIndex = 5;
            // 
            // miniMenuVertical
            // 
            this.miniMenuVertical.Location = new System.Drawing.Point(12, 3);
            this.miniMenuVertical.Name = "miniMenuVertical";
            this.miniMenuVertical.Size = new System.Drawing.Size(53, 210);
            this.miniMenuVertical.TabIndex = 3;
            this.miniMenuVertical.Novo_Clicked += new _5gpro.Controls.MiniMenuVertical.novoEventHandler(this.MiniMenuVertical_Novo_Clicked);
            this.miniMenuVertical.Buscar_Clicked += new _5gpro.Controls.MiniMenuVertical.buscarEventHandler(this.MiniMenuVertical_Buscar_Clicked);
            this.miniMenuVertical.Salvar_Clicked += new _5gpro.Controls.MiniMenuVertical.salvarEventHandler(this.MiniMenuVertical_Salvar_Clicked);
            this.miniMenuVertical.Excluir_Clicked += new _5gpro.Controls.MiniMenuVertical.excluirEventHandler(this.MiniMenuVertical_Excluir_Clicked);
            // 
            // fmCadastroGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 216);
            this.Controls.Add(this.miniMenuVertical);
            this.Controls.Add(this.gbNovoGrupoItem);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCadastroGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro Grupo de Itens";
            this.Load += new System.EventHandler(this.FmCadastroGrupoItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroGrupoItem_KeyDown);
            this.gbNovoGrupoItem.ResumeLayout(false);
            this.gbNovoGrupoItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.GroupBox gbNovoGrupoItem;
        private System.Windows.Forms.TextBox tbNomeGrupo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbCodigo;
        private Controls.MiniMenuVertical miniMenuVertical;
        private System.Windows.Forms.TextBox tbAjuda;
    }
}