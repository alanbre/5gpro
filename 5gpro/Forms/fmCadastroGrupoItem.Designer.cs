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
            this.gbGrupoItem = new System.Windows.Forms.GroupBox();
            this.tbNomeGrupoItem = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.dgvSubGruposItens = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigoSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomeSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverSub = new System.Windows.Forms.Button();
            this.btNovoSubGrupo = new System.Windows.Forms.Button();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.gbSubGrupos = new System.Windows.Forms.GroupBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbNomeSubGrupo = new System.Windows.Forms.TextBox();
            this.lbNomeSubGrupo = new System.Windows.Forms.Label();
            this.tbCodigoSubGrupo = new System.Windows.Forms.TextBox();
            this.lbCodigoSubGrupo = new System.Windows.Forms.Label();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.gbGrupoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGruposItens)).BeginInit();
            this.gbSubGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(4, 16);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // gbGrupoItem
            // 
            this.gbGrupoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGrupoItem.Controls.Add(this.tbNomeGrupoItem);
            this.gbGrupoItem.Controls.Add(this.lbNome);
            this.gbGrupoItem.Controls.Add(this.tbCodigo);
            this.gbGrupoItem.Controls.Add(this.lbCodigo);
            this.gbGrupoItem.Location = new System.Drawing.Point(71, 12);
            this.gbGrupoItem.Name = "gbGrupoItem";
            this.gbGrupoItem.Size = new System.Drawing.Size(528, 102);
            this.gbGrupoItem.TabIndex = 0;
            this.gbGrupoItem.TabStop = false;
            this.gbGrupoItem.Text = "Dados do grupo";
            // 
            // tbNomeGrupoItem
            // 
            this.tbNomeGrupoItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeGrupoItem.Location = new System.Drawing.Point(7, 72);
            this.tbNomeGrupoItem.Name = "tbNomeGrupoItem";
            this.tbNomeGrupoItem.Size = new System.Drawing.Size(514, 20);
            this.tbNomeGrupoItem.TabIndex = 3;
            this.tbNomeGrupoItem.TextChanged += new System.EventHandler(this.TbNomeGrupo_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 55);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(82, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome do Grupo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(7, 32);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(82, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // dgvSubGruposItens
            // 
            this.dgvSubGruposItens.AllowUserToAddRows = false;
            this.dgvSubGruposItens.AllowUserToDeleteRows = false;
            this.dgvSubGruposItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvSubGruposItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubGruposItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubGruposItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSubGruposItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGruposItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigoSub,
            this.dgvtbcNomeSub});
            this.dgvSubGruposItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubGruposItens.Location = new System.Drawing.Point(6, 19);
            this.dgvSubGruposItens.MultiSelect = false;
            this.dgvSubGruposItens.Name = "dgvSubGruposItens";
            this.dgvSubGruposItens.ReadOnly = true;
            this.dgvSubGruposItens.RowHeadersVisible = false;
            this.dgvSubGruposItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubGruposItens.Size = new System.Drawing.Size(488, 170);
            this.dgvSubGruposItens.TabIndex = 0;
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
            // btRemoverSub
            // 
            this.btRemoverSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemoverSub.Enabled = false;
            this.btRemoverSub.Image = global::_5gpro.Properties.Resources.icons8_Delete_Subtra_22px;
            this.btRemoverSub.Location = new System.Drawing.Point(499, 47);
            this.btRemoverSub.Name = "btRemoverSub";
            this.btRemoverSub.Size = new System.Drawing.Size(22, 22);
            this.btRemoverSub.TabIndex = 7;
            this.btRemoverSub.UseVisualStyleBackColor = true;
            this.btRemoverSub.Click += new System.EventHandler(this.BtRemoverSub_Click);
            // 
            // btNovoSubGrupo
            // 
            this.btNovoSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovoSubGrupo.Enabled = false;
            this.btNovoSubGrupo.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btNovoSubGrupo.Location = new System.Drawing.Point(499, 19);
            this.btNovoSubGrupo.Name = "btNovoSubGrupo";
            this.btNovoSubGrupo.Size = new System.Drawing.Size(22, 22);
            this.btNovoSubGrupo.TabIndex = 6;
            this.btNovoSubGrupo.UseVisualStyleBackColor = true;
            this.btNovoSubGrupo.Click += new System.EventHandler(this.BtNovoSubGrupo_Click);
            // 
            // tbAjuda
            // 
            this.tbAjuda.Location = new System.Drawing.Point(71, 390);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(527, 20);
            this.tbAjuda.TabIndex = 3;
            // 
            // gbSubGrupos
            // 
            this.gbSubGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSubGrupos.Controls.Add(this.btSalvar);
            this.gbSubGrupos.Controls.Add(this.tbNomeSubGrupo);
            this.gbSubGrupos.Controls.Add(this.lbNomeSubGrupo);
            this.gbSubGrupos.Controls.Add(this.tbCodigoSubGrupo);
            this.gbSubGrupos.Controls.Add(this.lbCodigoSubGrupo);
            this.gbSubGrupos.Controls.Add(this.dgvSubGruposItens);
            this.gbSubGrupos.Controls.Add(this.btNovoSubGrupo);
            this.gbSubGrupos.Controls.Add(this.btRemoverSub);
            this.gbSubGrupos.Location = new System.Drawing.Point(71, 120);
            this.gbSubGrupos.Name = "gbSubGrupos";
            this.gbSubGrupos.Size = new System.Drawing.Size(527, 263);
            this.gbSubGrupos.TabIndex = 1;
            this.gbSubGrupos.TabStop = false;
            this.gbSubGrupos.Text = "Sub-Grupos";
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSalvar.Location = new System.Drawing.Point(6, 234);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Inserir";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // tbNomeSubGrupo
            // 
            this.tbNomeSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeSubGrupo.Location = new System.Drawing.Point(71, 208);
            this.tbNomeSubGrupo.Name = "tbNomeSubGrupo";
            this.tbNomeSubGrupo.Size = new System.Drawing.Size(424, 20);
            this.tbNomeSubGrupo.TabIndex = 4;
            // 
            // lbNomeSubGrupo
            // 
            this.lbNomeSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNomeSubGrupo.AutoSize = true;
            this.lbNomeSubGrupo.Location = new System.Drawing.Point(71, 192);
            this.lbNomeSubGrupo.Name = "lbNomeSubGrupo";
            this.lbNomeSubGrupo.Size = new System.Drawing.Size(35, 13);
            this.lbNomeSubGrupo.TabIndex = 3;
            this.lbNomeSubGrupo.Text = "Nome";
            // 
            // tbCodigoSubGrupo
            // 
            this.tbCodigoSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodigoSubGrupo.Enabled = false;
            this.tbCodigoSubGrupo.Location = new System.Drawing.Point(7, 208);
            this.tbCodigoSubGrupo.Name = "tbCodigoSubGrupo";
            this.tbCodigoSubGrupo.Size = new System.Drawing.Size(58, 20);
            this.tbCodigoSubGrupo.TabIndex = 2;
            // 
            // lbCodigoSubGrupo
            // 
            this.lbCodigoSubGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCodigoSubGrupo.AutoSize = true;
            this.lbCodigoSubGrupo.Location = new System.Drawing.Point(6, 192);
            this.lbCodigoSubGrupo.Name = "lbCodigoSubGrupo";
            this.lbCodigoSubGrupo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoSubGrupo.TabIndex = 1;
            this.lbCodigoSubGrupo.Text = "Código";
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 2;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical_Proximo_Clicked);
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical_Excluir_Clicked);
            // 
            // fmCadastroGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 421);
            this.Controls.Add(this.gbSubGrupos);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.gbGrupoItem);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(626, 460);
            this.Name = "fmCadastroGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Grupo de Itens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroGrupoItem_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroGrupoItem_KeyDown);
            this.gbGrupoItem.ResumeLayout(false);
            this.gbGrupoItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGruposItens)).EndInit();
            this.gbSubGrupos.ResumeLayout(false);
            this.gbSubGrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.GroupBox gbGrupoItem;
        private System.Windows.Forms.TextBox tbNomeGrupoItem;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.DataGridView dgvSubGruposItens;
        private System.Windows.Forms.Button btNovoSubGrupo;
        private System.Windows.Forms.Button btRemoverSub;
        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeSub;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.GroupBox gbSubGrupos;
        private System.Windows.Forms.Label lbCodigoSubGrupo;
        private System.Windows.Forms.TextBox tbCodigoSubGrupo;
        private System.Windows.Forms.TextBox tbNomeSubGrupo;
        private System.Windows.Forms.Label lbNomeSubGrupo;
        private System.Windows.Forms.Button btSalvar;
    }
}