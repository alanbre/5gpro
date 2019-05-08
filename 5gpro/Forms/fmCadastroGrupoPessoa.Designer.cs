namespace _5gpro.Forms
{
    partial class fmCadastroGrupoPessoa
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
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.gbNovoGrupoPessoa = new System.Windows.Forms.GroupBox();
            this.tbNomeGrupoPessoa = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbSubgrupos = new System.Windows.Forms.GroupBox();
            this.btRemoverSub = new System.Windows.Forms.Button();
            this.btAddSub = new System.Windows.Forms.Button();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.dgvSubGruposPessoas = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigoSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomeSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscaNomeSub = new System.Windows.Forms.TextBox();
            this.gbNovoGrupoPessoa.SuspendLayout();
            this.gbSubgrupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGruposPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 9);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 0;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical1_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical1_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical1_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical1_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical1_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical1_Proximo_Clicked);
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical1_Excluir_Clicked);
            // 
            // gbNovoGrupoPessoa
            // 
            this.gbNovoGrupoPessoa.Controls.Add(this.tbNomeGrupoPessoa);
            this.gbNovoGrupoPessoa.Controls.Add(this.tbCodigo);
            this.gbNovoGrupoPessoa.Controls.Add(this.label2);
            this.gbNovoGrupoPessoa.Controls.Add(this.lbCodigo);
            this.gbNovoGrupoPessoa.Location = new System.Drawing.Point(71, 12);
            this.gbNovoGrupoPessoa.Name = "gbNovoGrupoPessoa";
            this.gbNovoGrupoPessoa.Size = new System.Drawing.Size(255, 121);
            this.gbNovoGrupoPessoa.TabIndex = 1;
            this.gbNovoGrupoPessoa.TabStop = false;
            this.gbNovoGrupoPessoa.Text = "Novo Grupo de Pessoas";
            // 
            // tbNomeGrupoPessoa
            // 
            this.tbNomeGrupoPessoa.Location = new System.Drawing.Point(9, 89);
            this.tbNomeGrupoPessoa.Name = "tbNomeGrupoPessoa";
            this.tbNomeGrupoPessoa.Size = new System.Drawing.Size(184, 20);
            this.tbNomeGrupoPessoa.TabIndex = 3;
            this.tbNomeGrupoPessoa.TextChanged += new System.EventHandler(this.TbNomeGrupoPessoa_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Grupo";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 28);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // gbSubgrupos
            // 
            this.gbSubgrupos.Controls.Add(this.btRemoverSub);
            this.gbSubgrupos.Controls.Add(this.btAddSub);
            this.gbSubgrupos.Controls.Add(this.tbAjuda);
            this.gbSubgrupos.Controls.Add(this.dgvSubGruposPessoas);
            this.gbSubgrupos.Controls.Add(this.tbBuscaNomeSub);
            this.gbSubgrupos.Location = new System.Drawing.Point(72, 139);
            this.gbSubgrupos.Name = "gbSubgrupos";
            this.gbSubgrupos.Size = new System.Drawing.Size(527, 295);
            this.gbSubgrupos.TabIndex = 2;
            this.gbSubgrupos.TabStop = false;
            this.gbSubgrupos.Text = "Sub-Grupos";
            // 
            // btRemoverSub
            // 
            this.btRemoverSub.Image = global::_5gpro.Properties.Resources.icons8_Delete_Subtra_22px;
            this.btRemoverSub.Location = new System.Drawing.Point(500, 76);
            this.btRemoverSub.Name = "btRemoverSub";
            this.btRemoverSub.Size = new System.Drawing.Size(22, 22);
            this.btRemoverSub.TabIndex = 4;
            this.btRemoverSub.UseVisualStyleBackColor = true;
            this.btRemoverSub.Click += new System.EventHandler(this.BtRemoverSub_Click);
            // 
            // btAddSub
            // 
            this.btAddSub.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btAddSub.Location = new System.Drawing.Point(500, 48);
            this.btAddSub.Name = "btAddSub";
            this.btAddSub.Size = new System.Drawing.Size(22, 22);
            this.btAddSub.TabIndex = 3;
            this.btAddSub.UseVisualStyleBackColor = true;
            this.btAddSub.Click += new System.EventHandler(this.BtAddSub_Click);
            // 
            // tbAjuda
            // 
            this.tbAjuda.Location = new System.Drawing.Point(11, 263);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(483, 20);
            this.tbAjuda.TabIndex = 2;
            // 
            // dgvSubGruposPessoas
            // 
            this.dgvSubGruposPessoas.AllowUserToAddRows = false;
            this.dgvSubGruposPessoas.AllowUserToDeleteRows = false;
            this.dgvSubGruposPessoas.AllowUserToOrderColumns = true;
            this.dgvSubGruposPessoas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvSubGruposPessoas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubGruposPessoas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSubGruposPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGruposPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigoSub,
            this.dgvtbcNomeSub});
            this.dgvSubGruposPessoas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubGruposPessoas.Location = new System.Drawing.Point(11, 48);
            this.dgvSubGruposPessoas.MultiSelect = false;
            this.dgvSubGruposPessoas.Name = "dgvSubGruposPessoas";
            this.dgvSubGruposPessoas.ReadOnly = true;
            this.dgvSubGruposPessoas.RowHeadersVisible = false;
            this.dgvSubGruposPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubGruposPessoas.Size = new System.Drawing.Size(483, 208);
            this.dgvSubGruposPessoas.TabIndex = 1;
            this.dgvSubGruposPessoas.TabStop = false;
            this.dgvSubGruposPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubGruposPessoas_CellDoubleClick);
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
            this.tbBuscaNomeSub.TabIndex = 0;
            this.tbBuscaNomeSub.TextChanged += new System.EventHandler(this.TbBuscaNomeSub_TextChanged);
            // 
            // fmCadastroGrupoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 449);
            this.Controls.Add(this.gbSubgrupos);
            this.Controls.Add(this.gbNovoGrupoPessoa);
            this.Controls.Add(this.menuVertical);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(626, 488);
            this.Name = "fmCadastroGrupoPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Grupo Pessoa";
            this.Load += new System.EventHandler(this.FmCadastroGrupoPessoa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroGrupoPessoa_KeyDown);
            this.gbNovoGrupoPessoa.ResumeLayout(false);
            this.gbNovoGrupoPessoa.PerformLayout();
            this.gbSubgrupos.ResumeLayout(false);
            this.gbSubgrupos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGruposPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.GroupBox gbNovoGrupoPessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbNomeGrupoPessoa;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.GroupBox gbSubgrupos;
        private System.Windows.Forms.TextBox tbBuscaNomeSub;
        private System.Windows.Forms.DataGridView dgvSubGruposPessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeSub;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.Button btRemoverSub;
        private System.Windows.Forms.Button btAddSub;
    }
}