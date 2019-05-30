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
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.gbIndice = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGrupoDeUsuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).BeginInit();
            this.gbModulos.SuspendLayout();
            this.gbIndice.SuspendLayout();
            this.SuspendLayout();
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
            this.tbNomeGrupoUsuario.TextChanged += new System.EventHandler(this.TbNomeGrupoUsuario_TextChanged);
            // 
            // tbCodGrupoUsuario
            // 
            this.tbCodGrupoUsuario.Location = new System.Drawing.Point(55, 30);
            this.tbCodGrupoUsuario.Name = "tbCodGrupoUsuario";
            this.tbCodGrupoUsuario.Size = new System.Drawing.Size(103, 20);
            this.tbCodGrupoUsuario.TabIndex = 2;
            this.tbCodGrupoUsuario.Leave += new System.EventHandler(this.TbCodGrupoUsuario_Leave);
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
            this.groupBox2.Location = new System.Drawing.Point(326, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 422);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissões";
            // 
            // dgvPermissoes
            // 
            this.dgvPermissoes.AllowUserToAddRows = false;
            this.dgvPermissoes.AllowUserToDeleteRows = false;
            this.dgvPermissoes.AllowUserToResizeColumns = false;
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
            this.dgvPermissoes.Location = new System.Drawing.Point(6, 28);
            this.dgvPermissoes.MultiSelect = false;
            this.dgvPermissoes.Name = "dgvPermissoes";
            this.dgvPermissoes.ReadOnly = true;
            this.dgvPermissoes.RowHeadersVisible = false;
            this.dgvPermissoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermissoes.Size = new System.Drawing.Size(489, 388);
            this.dgvPermissoes.TabIndex = 0;
            this.dgvPermissoes.TabStop = false;
            this.dgvPermissoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPermissoes_CellDoubleClick);
            this.dgvPermissoes.ColumnDividerDoubleClick += new System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventHandler(this.DgvPermissoes_ColumnDividerDoubleClick);
            // 
            // dgvtbcCodigoPermissoes
            // 
            this.dgvtbcCodigoPermissoes.HeaderText = "Código";
            this.dgvtbcCodigoPermissoes.Name = "dgvtbcCodigoPermissoes";
            this.dgvtbcCodigoPermissoes.ReadOnly = true;
            this.dgvtbcCodigoPermissoes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtbcNomePermissoes
            // 
            this.dgvtbcNomePermissoes.HeaderText = "Nome";
            this.dgvtbcNomePermissoes.MinimumWidth = 280;
            this.dgvtbcNomePermissoes.Name = "dgvtbcNomePermissoes";
            this.dgvtbcNomePermissoes.ReadOnly = true;
            this.dgvtbcNomePermissoes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtbcNomePermissoes.Width = 280;
            // 
            // dgvtbcNivelPermissoes
            // 
            this.dgvtbcNivelPermissoes.HeaderText = "Nível";
            this.dgvtbcNivelPermissoes.Name = "dgvtbcNivelPermissoes";
            this.dgvtbcNivelPermissoes.ReadOnly = true;
            this.dgvtbcNivelPermissoes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvModulos
            // 
            this.dgvModulos.AllowUserToAddRows = false;
            this.dgvModulos.AllowUserToDeleteRows = false;
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
            this.dgvModulos.Location = new System.Drawing.Point(7, 28);
            this.dgvModulos.MultiSelect = false;
            this.dgvModulos.Name = "dgvModulos";
            this.dgvModulos.ReadOnly = true;
            this.dgvModulos.RowHeadersVisible = false;
            this.dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModulos.Size = new System.Drawing.Size(233, 388);
            this.dgvModulos.TabIndex = 0;
            this.dgvModulos.TabStop = false;
            this.dgvModulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModulos_CellClick);
            this.dgvModulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModulos_CellDoubleClick);
            this.dgvModulos.CurrentCellChanged += new System.EventHandler(this.DgvModulos_CurrentCellChanged);
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
            this.gbModulos.Location = new System.Drawing.Point(74, 122);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(246, 422);
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
            // 
            // gbIndice
            // 
            this.gbIndice.Controls.Add(this.label4);
            this.gbIndice.Controls.Add(this.label3);
            this.gbIndice.Controls.Add(this.label2);
            this.gbIndice.Controls.Add(this.label1);
            this.gbIndice.Location = new System.Drawing.Point(478, 9);
            this.gbIndice.Name = "gbIndice";
            this.gbIndice.Size = new System.Drawing.Size(253, 104);
            this.gbIndice.TabIndex = 9;
            this.gbIndice.TabStop = false;
            this.gbIndice.Text = "Índice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "3 - Visualiza, busca, grava e exclui";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2 - Visualiza, busca e grava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1 - Visualiza e busca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 - Não visualiza";
            // 
            // fmCadastroGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 579);
            this.Controls.Add(this.gbIndice);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbModulos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbGrupoDeUsuario);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 618);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "fmCadastroGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Grupos de Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroGrupoUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FmCadastroGrupoUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroGrupoUsuario_KeyDown);
            this.gbGrupoDeUsuario.ResumeLayout(false);
            this.gbGrupoDeUsuario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModulos)).EndInit();
            this.gbModulos.ResumeLayout(false);
            this.gbIndice.ResumeLayout(false);
            this.gbIndice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGrupoDeUsuario;
        private System.Windows.Forms.TextBox tbNomeGrupoUsuario;
        private System.Windows.Forms.TextBox tbCodGrupoUsuario;
        private System.Windows.Forms.Label lbNomeGrupoUsuario;
        private System.Windows.Forms.Label lbCodGrupoUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPermissoes;
        private System.Windows.Forms.DataGridView dgvModulos;
        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomeModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNivelModulos;
        private Controls.MenuVertical menuVertical;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigoPermissoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNomePermissoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcNivelPermissoes;
        private System.Windows.Forms.GroupBox gbIndice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}