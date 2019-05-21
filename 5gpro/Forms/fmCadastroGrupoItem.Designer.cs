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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbNovoGrupoItem = new System.Windows.Forms.GroupBox();
            this.tbNomeGrupoItem = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.dgvSubGruposItens = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigoSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomeSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscaNomeSub = new System.Windows.Forms.TextBox();
            this.btRemoverSub = new System.Windows.Forms.Button();
            this.btAddSub = new System.Windows.Forms.Button();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.gbBuscaSubgrupo = new System.Windows.Forms.GroupBox();
            this.gbNovoGrupoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGruposItens)).BeginInit();
            this.gbBuscaSubgrupo.SuspendLayout();
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
            this.gbNovoGrupoItem.Controls.Add(this.tbNomeGrupoItem);
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
            // tbNomeGrupoItem
            // 
            this.tbNomeGrupoItem.Location = new System.Drawing.Point(9, 89);
            this.tbNomeGrupoItem.Name = "tbNomeGrupoItem";
            this.tbNomeGrupoItem.Size = new System.Drawing.Size(184, 20);
            this.tbNomeGrupoItem.TabIndex = 4;
            this.tbNomeGrupoItem.TextChanged += new System.EventHandler(this.TbNomeGrupo_TextChanged);
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
            // dgvSubGruposItens
            // 
            this.dgvSubGruposItens.AllowUserToAddRows = false;
            this.dgvSubGruposItens.AllowUserToDeleteRows = false;
            this.dgvSubGruposItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvSubGruposItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubGruposItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSubGruposItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGruposItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigoSub,
            this.dgvtbcNomeSub});
            this.dgvSubGruposItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubGruposItens.Location = new System.Drawing.Point(11, 48);
            this.dgvSubGruposItens.MultiSelect = false;
            this.dgvSubGruposItens.Name = "dgvSubGruposItens";
            this.dgvSubGruposItens.ReadOnly = true;
            this.dgvSubGruposItens.RowHeadersVisible = false;
            this.dgvSubGruposItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubGruposItens.Size = new System.Drawing.Size(483, 208);
            this.dgvSubGruposItens.TabIndex = 4;
            this.dgvSubGruposItens.TabStop = false;
            this.dgvSubGruposItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubGruposItens_CellDoubleClick);
            // 
            // dgvtbcCodigoSub
            // 
            this.dgvtbcCodigoSub.HeaderText = "Código";
            this.dgvtbcCodigoSub.Name = "dgvtbcCodigoSub";
            this.dgvtbcCodigoSub.ReadOnly = true;
            // 
            // dgvtbcNomeSub
            // 
            this.dgvtbcNomeSub.HeaderText = "Nome";
            this.dgvtbcNomeSub.Name = "dgvtbcNomeSub";
            this.dgvtbcNomeSub.ReadOnly = true;
            // 
            // tbBuscaNomeSub
            // 
            this.tbBuscaNomeSub.Location = new System.Drawing.Point(12, 22);
            this.tbBuscaNomeSub.Name = "tbBuscaNomeSub";
            this.tbBuscaNomeSub.Size = new System.Drawing.Size(482, 20);
            this.tbBuscaNomeSub.TabIndex = 7;
            this.tbBuscaNomeSub.TextChanged += new System.EventHandler(this.TbBuscaNomeSub_TextChanged);
            // 
            // btRemoverSub
            // 
            this.btRemoverSub.Enabled = false;
            this.btRemoverSub.Image = global::_5gpro.Properties.Resources.icons8_Delete_Subtra_22px;
            this.btRemoverSub.Location = new System.Drawing.Point(500, 76);
            this.btRemoverSub.Name = "btRemoverSub";
            this.btRemoverSub.Size = new System.Drawing.Size(22, 22);
            this.btRemoverSub.TabIndex = 6;
            this.btRemoverSub.UseVisualStyleBackColor = true;
            this.btRemoverSub.Click += new System.EventHandler(this.BtRemoverSub_Click);
            // 
            // btAddSub
            // 
            this.btAddSub.Enabled = false;
            this.btAddSub.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btAddSub.Location = new System.Drawing.Point(500, 48);
            this.btAddSub.Name = "btAddSub";
            this.btAddSub.Size = new System.Drawing.Size(22, 22);
            this.btAddSub.TabIndex = 5;
            this.btAddSub.UseVisualStyleBackColor = true;
            this.btAddSub.Click += new System.EventHandler(this.BtAddSub_Click);
            // 
            // tbAjuda
            // 
            this.tbAjuda.Location = new System.Drawing.Point(11, 263);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(483, 20);
            this.tbAjuda.TabIndex = 9;
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 8;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical_Proximo_Clicked);
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical_Excluir_Clicked);
            // 
            // gbBuscaSubgrupo
            // 
            this.gbBuscaSubgrupo.Controls.Add(this.tbBuscaNomeSub);
            this.gbBuscaSubgrupo.Controls.Add(this.tbAjuda);
            this.gbBuscaSubgrupo.Controls.Add(this.dgvSubGruposItens);
            this.gbBuscaSubgrupo.Controls.Add(this.btAddSub);
            this.gbBuscaSubgrupo.Controls.Add(this.btRemoverSub);
            this.gbBuscaSubgrupo.Location = new System.Drawing.Point(72, 139);
            this.gbBuscaSubgrupo.Name = "gbBuscaSubgrupo";
            this.gbBuscaSubgrupo.Size = new System.Drawing.Size(527, 295);
            this.gbBuscaSubgrupo.TabIndex = 10;
            this.gbBuscaSubgrupo.TabStop = false;
            this.gbBuscaSubgrupo.Text = "Sub-Grupos";
            // 
            // fmCadastroGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.gbBuscaSubgrupo);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.gbNovoGrupoItem);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(626, 488);
            this.Name = "fmCadastroGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Grupo de Itens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroGrupoItem_FormClosing);
            this.Load += new System.EventHandler(this.FmCadastroGrupoItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroGrupoItem_KeyDown);
            this.gbNovoGrupoItem.ResumeLayout(false);
            this.gbNovoGrupoItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGruposItens)).EndInit();
            this.gbBuscaSubgrupo.ResumeLayout(false);
            this.gbBuscaSubgrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.GroupBox gbNovoGrupoItem;
        private System.Windows.Forms.TextBox tbNomeGrupoItem;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.DataGridView dgvSubGruposItens;
        private System.Windows.Forms.Button btAddSub;
        private System.Windows.Forms.Button btRemoverSub;
        private System.Windows.Forms.TextBox tbBuscaNomeSub;
        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeSub;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.GroupBox gbBuscaSubgrupo;
    }
}