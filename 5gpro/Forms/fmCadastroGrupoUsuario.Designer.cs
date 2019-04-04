namespace _5gpro.Forms
{
    partial class fmCadastroGrupoUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.gbGrupoDeUsuario = new System.Windows.Forms.GroupBox();
            this.tbNomeGrupoUsuario = new System.Windows.Forms.TextBox();
            this.tbCodGrupoUsuario = new System.Windows.Forms.TextBox();
            this.lbNomeGrupoUsuario = new System.Windows.Forms.Label();
            this.lbCodGrupoUsuario = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPermissoes = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigoPermissoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomePermissoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNivelPermissoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvModulos = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigoModulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNomeModulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcNivelModulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.pnBotoes.SuspendLayout();
            this.gbGrupoDeUsuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.gbModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btRecarregar);
            this.pnBotoes.Controls.Add(this.btSalvar);
            this.pnBotoes.Controls.Add(this.btDeletar);
            this.pnBotoes.Controls.Add(this.btAnterior);
            this.pnBotoes.Controls.Add(this.btProximo);
            this.pnBotoes.Controls.Add(this.btBuscar);
            this.pnBotoes.Controls.Add(this.btNovo);
            this.pnBotoes.Location = new System.Drawing.Point(12, 2);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(56, 488);
            this.pnBotoes.TabIndex = 3;
            // 
            // btRecarregar
            // 
            this.btRecarregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRecarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRecarregar.Image = global::_5gpro.Properties.Resources.iosReload_48px_blue;
            this.btRecarregar.Location = new System.Drawing.Point(3, 157);
            this.btRecarregar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Size = new System.Drawing.Size(48, 48);
            this.btRecarregar.TabIndex = 6;
            this.btRecarregar.UseVisualStyleBackColor = true;
            this.btRecarregar.Click += new System.EventHandler(this.btRecarregar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.Image = global::_5gpro.Properties.Resources.iosOk_48px_black;
            this.btSalvar.Location = new System.Drawing.Point(3, 106);
            this.btSalvar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(48, 48);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeletar.Image = global::_5gpro.Properties.Resources.iosDelete_48px_black;
            this.btDeletar.Location = new System.Drawing.Point(3, 310);
            this.btDeletar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(48, 48);
            this.btDeletar.TabIndex = 5;
            this.btDeletar.UseVisualStyleBackColor = true;
            // 
            // btAnterior
            // 
            this.btAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnterior.Image = global::_5gpro.Properties.Resources.iosLeft_48px_Blue;
            this.btAnterior.Location = new System.Drawing.Point(3, 259);
            this.btAnterior.MinimumSize = new System.Drawing.Size(48, 48);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(48, 48);
            this.btAnterior.TabIndex = 4;
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btProximo
            // 
            this.btProximo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btProximo.Image = global::_5gpro.Properties.Resources.iosRight_48px_Blue;
            this.btProximo.Location = new System.Drawing.Point(3, 208);
            this.btProximo.MinimumSize = new System.Drawing.Size(48, 48);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(48, 48);
            this.btProximo.TabIndex = 3;
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Image = global::_5gpro.Properties.Resources.iosSearch_48px_black;
            this.btBuscar.Location = new System.Drawing.Point(3, 55);
            this.btBuscar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(48, 48);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovo.Image = global::_5gpro.Properties.Resources.iosPlus_48px_black;
            this.btNovo.Location = new System.Drawing.Point(3, 3);
            this.btNovo.MinimumSize = new System.Drawing.Size(48, 48);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(48, 48);
            this.btNovo.TabIndex = 1;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // gbGrupoDeUsuario
            // 
            this.gbGrupoDeUsuario.Controls.Add(this.tbNomeGrupoUsuario);
            this.gbGrupoDeUsuario.Controls.Add(this.tbCodGrupoUsuario);
            this.gbGrupoDeUsuario.Controls.Add(this.lbNomeGrupoUsuario);
            this.gbGrupoDeUsuario.Controls.Add(this.lbCodGrupoUsuario);
            this.gbGrupoDeUsuario.Location = new System.Drawing.Point(74, 12);
            this.gbGrupoDeUsuario.Name = "gbGrupoDeUsuario";
            this.gbGrupoDeUsuario.Size = new System.Drawing.Size(310, 93);
            this.gbGrupoDeUsuario.TabIndex = 4;
            this.gbGrupoDeUsuario.TabStop = false;
            this.gbGrupoDeUsuario.Text = "Grupo de Usuários";
            // 
            // tbNomeGrupoUsuario
            // 
            this.tbNomeGrupoUsuario.Location = new System.Drawing.Point(55, 58);
            this.tbNomeGrupoUsuario.Name = "tbNomeGrupoUsuario";
            this.tbNomeGrupoUsuario.Size = new System.Drawing.Size(213, 20);
            this.tbNomeGrupoUsuario.TabIndex = 3;
            this.tbNomeGrupoUsuario.TextChanged += new System.EventHandler(this.tbNomeGrupoUsuario_TextChanged);
            // 
            // tbCodGrupoUsuario
            // 
            this.tbCodGrupoUsuario.Location = new System.Drawing.Point(55, 30);
            this.tbCodGrupoUsuario.Name = "tbCodGrupoUsuario";
            this.tbCodGrupoUsuario.Size = new System.Drawing.Size(103, 20);
            this.tbCodGrupoUsuario.TabIndex = 2;
            this.tbCodGrupoUsuario.TextChanged += new System.EventHandler(this.tbCodGrupoUsuario_TextChanged);
            this.tbCodGrupoUsuario.Leave += new System.EventHandler(this.tbCodGrupoUsuario_Leave);
            // 
            // lbNomeGrupoUsuario
            // 
            this.lbNomeGrupoUsuario.AutoSize = true;
            this.lbNomeGrupoUsuario.Location = new System.Drawing.Point(19, 61);
            this.lbNomeGrupoUsuario.Name = "lbNomeGrupoUsuario";
            this.lbNomeGrupoUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbNomeGrupoUsuario.TabIndex = 1;
            this.lbNomeGrupoUsuario.Text = "Nome";
            // 
            // lbCodGrupoUsuario
            // 
            this.lbCodGrupoUsuario.AutoSize = true;
            this.lbCodGrupoUsuario.Location = new System.Drawing.Point(14, 33);
            this.lbCodGrupoUsuario.Name = "lbCodGrupoUsuario";
            this.lbCodGrupoUsuario.Size = new System.Drawing.Size(40, 13);
            this.lbCodGrupoUsuario.TabIndex = 0;
            this.lbCodGrupoUsuario.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPermissoes);
            this.groupBox2.Location = new System.Drawing.Point(74, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 235);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissões";
            // 
            // dgvPermissoes
            // 
            this.dgvPermissoes.AllowUserToAddRows = false;
            this.dgvPermissoes.AllowUserToDeleteRows = false;
            this.dgvPermissoes.AllowUserToOrderColumns = true;
            this.dgvPermissoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvPermissoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPermissoes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPermissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigoPermissoes,
            this.dgvtbcNomePermissoes,
            this.dgvtbcNivelPermissoes});
            this.dgvPermissoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPermissoes.Location = new System.Drawing.Point(7, 18);
            this.dgvPermissoes.MultiSelect = false;
            this.dgvPermissoes.Name = "dgvPermissoes";
            this.dgvPermissoes.ReadOnly = true;
            this.dgvPermissoes.RowHeadersVisible = false;
            this.dgvPermissoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermissoes.Size = new System.Drawing.Size(734, 211);
            this.dgvPermissoes.TabIndex = 0;
            this.dgvPermissoes.TabStop = false;
            this.dgvPermissoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermissoes_CellDoubleClick);
            this.dgvPermissoes.ColumnDividerDoubleClick += new System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventHandler(this.dgvPermissoes_ColumnDividerDoubleClick);
            // 
            // dgvtbcCodigoPermissoes
            // 
            this.dgvtbcCodigoPermissoes.HeaderText = "Código";
            this.dgvtbcCodigoPermissoes.Name = "dgvtbcCodigoPermissoes";
            this.dgvtbcCodigoPermissoes.ReadOnly = true;
            // 
            // dgvtbcNomePermissoes
            // 
            this.dgvtbcNomePermissoes.HeaderText = "Nome";
            this.dgvtbcNomePermissoes.MinimumWidth = 280;
            this.dgvtbcNomePermissoes.Name = "dgvtbcNomePermissoes";
            this.dgvtbcNomePermissoes.ReadOnly = true;
            this.dgvtbcNomePermissoes.Width = 280;
            // 
            // dgvtbcNivelPermissoes
            // 
            this.dgvtbcNivelPermissoes.HeaderText = "Nível";
            this.dgvtbcNivelPermissoes.Name = "dgvtbcNivelPermissoes";
            this.dgvtbcNivelPermissoes.ReadOnly = true;
            // 
            // dgvModulos
            // 
            this.dgvModulos.AllowUserToAddRows = false;
            this.dgvModulos.AllowUserToDeleteRows = false;
            this.dgvModulos.AllowUserToOrderColumns = true;
            this.dgvModulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvModulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigoModulos,
            this.dgvtbcNomeModulos,
            this.dgvtbcNivelModulos});
            this.dgvModulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvModulos.Location = new System.Drawing.Point(6, 19);
            this.dgvModulos.MultiSelect = false;
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.ReadOnly = true;
            this.dgvModulos.RowHeadersVisible = false;
            this.dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulos.Size = new System.Drawing.Size(736, 173);
            this.dgvModulos.TabIndex = 0;
            this.dgvModulos.TabStop = false;
            this.dgvModulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModulos_CellClick);
            this.dgvModulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModulos_CellContentClick);
            this.dgvModulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModulos_CellDoubleClick);
            this.dgvModulos.CurrentCellChanged += new System.EventHandler(this.DgvModulos_CurrentCellChanged);
            this.dgvModulos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModulos_RowEnter);
            // 
            // dgvtbcCodigoModulos
            // 
            this.dgvtbcCodigoModulos.HeaderText = "Código";
            this.dgvtbcCodigoModulos.MinimumWidth = 70;
            this.dgvtbcCodigoModulos.Name = "dgvtbcCodigoModulos";
            this.dgvtbcCodigoModulos.ReadOnly = true;
            this.dgvtbcCodigoModulos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtbcCodigoModulos.Width = 70;
            // 
            // dgvtbcNomeModulos
            // 
            this.dgvtbcNomeModulos.HeaderText = "Nome";
            this.dgvtbcNomeModulos.MinimumWidth = 30;
            this.dgvtbcNomeModulos.Name = "dgvtbcNomeModulos";
            this.dgvtbcNomeModulos.ReadOnly = true;
            this.dgvtbcNomeModulos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtbcNomeModulos.Width = 150;
            // 
            // dgvtbcNivelModulos
            // 
            this.dgvtbcNivelModulos.HeaderText = "Nível";
            this.dgvtbcNivelModulos.Name = "dgvtbcNivelModulos";
            this.dgvtbcNivelModulos.ReadOnly = true;
            this.dgvtbcNivelModulos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtbcNivelModulos.Visible = false;
            // 
            // gbModulos
            // 
            this.gbModulos.Controls.Add(this.dgvModulos);
            this.gbModulos.Location = new System.Drawing.Point(74, 111);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(747, 198);
            this.gbModulos.TabIndex = 6;
            this.gbModulos.TabStop = false;
            this.gbModulos.Text = "Módulos";
            // 
            // tbAjuda
            // 
            this.tbAjuda.Enabled = false;
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(81, 550);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.Size = new System.Drawing.Size(741, 20);
            this.tbAjuda.TabIndex = 7;
            // 
            // fmCadastroGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 579);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbModulos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbGrupoDeUsuario);
            this.Controls.Add(this.pnBotoes);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "fmCadastroGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Grupos de Usuário";
            this.Load += new System.EventHandler(this.fmCadastroGrupoUsuario_Load);
            this.pnBotoes.ResumeLayout(false);
            this.gbGrupoDeUsuario.ResumeLayout(false);
            this.gbGrupoDeUsuario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.gbModulos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btRecarregar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.GroupBox gbGrupoDeUsuario;
        private System.Windows.Forms.TextBox tbNomeGrupoUsuario;
        private System.Windows.Forms.TextBox tbCodGrupoUsuario;
        private System.Windows.Forms.Label lbNomeGrupoUsuario;
        private System.Windows.Forms.Label lbCodGrupoUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPermissoes;
        private System.Windows.Forms.DataGridView dgvModulos;
        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoPermissoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomePermissoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNivelPermissoes;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNivelModulos;
    }
}