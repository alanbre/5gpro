namespace _5gpro.Forms
{
    partial class fmBuscaUsuario
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.tbFiltroNomeUsuario = new System.Windows.Forms.TextBox();
            this.tbFiltroCodUsuario = new System.Windows.Forms.TextBox();
            this.btBuscaGrupoUsuario = new System.Windows.Forms.Button();
            this.tbNomeGrupoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSobrenomeUsuario = new System.Windows.Forms.Label();
            this.tbFiltroSobrenomeUsuario = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 108);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(775, 330);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.AllowUserToAddRowsChanged += new System.EventHandler(this.dgvUsuarios_AllowUserToAddRowsChanged);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Location = new System.Drawing.Point(7, 48);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbNomeUsuario.TabIndex = 1;
            this.lbNomeUsuario.Text = "Nome";
            // 
            // tbFiltroNomeUsuario
            // 
            this.tbFiltroNomeUsuario.Location = new System.Drawing.Point(10, 64);
            this.tbFiltroNomeUsuario.Name = "tbFiltroNomeUsuario";
            this.tbFiltroNomeUsuario.Size = new System.Drawing.Size(200, 20);
            this.tbFiltroNomeUsuario.TabIndex = 2;
            this.tbFiltroNomeUsuario.TextChanged += new System.EventHandler(this.tbFiltroNomeUsuario_TextChanged);
            // 
            // tbFiltroCodUsuario
            // 
            this.tbFiltroCodUsuario.Location = new System.Drawing.Point(12, 24);
            this.tbFiltroCodUsuario.Name = "tbFiltroCodUsuario";
            this.tbFiltroCodUsuario.Size = new System.Drawing.Size(68, 20);
            this.tbFiltroCodUsuario.TabIndex = 3;
            // 
            // btBuscaGrupoUsuario
            // 
            this.btBuscaGrupoUsuario.Location = new System.Drawing.Point(82, 24);
            this.btBuscaGrupoUsuario.Name = "btBuscaGrupoUsuario";
            this.btBuscaGrupoUsuario.Size = new System.Drawing.Size(20, 20);
            this.btBuscaGrupoUsuario.TabIndex = 4;
            this.btBuscaGrupoUsuario.UseVisualStyleBackColor = true;
            // 
            // tbNomeGrupoUsuario
            // 
            this.tbNomeGrupoUsuario.Location = new System.Drawing.Point(106, 24);
            this.tbNomeGrupoUsuario.Name = "tbNomeGrupoUsuario";
            this.tbNomeGrupoUsuario.ReadOnly = true;
            this.tbNomeGrupoUsuario.Size = new System.Drawing.Size(436, 20);
            this.tbNomeGrupoUsuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grupo de usuários";
            // 
            // lbSobrenomeUsuario
            // 
            this.lbSobrenomeUsuario.AutoSize = true;
            this.lbSobrenomeUsuario.Location = new System.Drawing.Point(247, 48);
            this.lbSobrenomeUsuario.Name = "lbSobrenomeUsuario";
            this.lbSobrenomeUsuario.Size = new System.Drawing.Size(61, 13);
            this.lbSobrenomeUsuario.TabIndex = 7;
            this.lbSobrenomeUsuario.Text = "Sobrenome";
            // 
            // tbFiltroSobrenomeUsuario
            // 
            this.tbFiltroSobrenomeUsuario.Location = new System.Drawing.Point(250, 64);
            this.tbFiltroSobrenomeUsuario.Name = "tbFiltroSobrenomeUsuario";
            this.tbFiltroSobrenomeUsuario.Size = new System.Drawing.Size(200, 20);
            this.tbFiltroSobrenomeUsuario.TabIndex = 8;
            this.tbFiltroSobrenomeUsuario.TextChanged += new System.EventHandler(this.tbFiltroSobrenomeUsuario_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(467, 61);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 9;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // fmBuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroSobrenomeUsuario);
            this.Controls.Add(this.lbSobrenomeUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomeGrupoUsuario);
            this.Controls.Add(this.btBuscaGrupoUsuario);
            this.Controls.Add(this.tbFiltroCodUsuario);
            this.Controls.Add(this.tbFiltroNomeUsuario);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "fmBuscaUsuario";
            this.Text = "fmBuscaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.TextBox tbFiltroNomeUsuario;
        private System.Windows.Forms.TextBox tbFiltroCodUsuario;
        private System.Windows.Forms.Button btBuscaGrupoUsuario;
        private System.Windows.Forms.TextBox tbNomeGrupoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSobrenomeUsuario;
        private System.Windows.Forms.TextBox tbFiltroSobrenomeUsuario;
        private System.Windows.Forms.Button btPesquisar;
    }
}