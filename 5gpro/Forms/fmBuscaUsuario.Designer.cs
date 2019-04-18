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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.tbFiltroNomeUsuario = new System.Windows.Forms.TextBox();
            this.lbSobrenomeUsuario = new System.Windows.Forms.Label();
            this.tbFiltroSobrenomeUsuario = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.buscaGrupoUsuario = new _5gpro.Controls.BuscaGrupoUsuario();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 108);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(775, 330);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.TabStop = false;
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
            // buscaGrupoUsuario
            // 
            this.buscaGrupoUsuario.Location = new System.Drawing.Point(6, 6);
            this.buscaGrupoUsuario.Name = "buscaGrupoUsuario";
            this.buscaGrupoUsuario.Size = new System.Drawing.Size(442, 39);
            this.buscaGrupoUsuario.TabIndex = 0;
            // 
            // fmBuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.buscaGrupoUsuario);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroSobrenomeUsuario);
            this.Controls.Add(this.lbSobrenomeUsuario);
            this.Controls.Add(this.tbFiltroNomeUsuario);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "fmBuscaUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.TextBox tbFiltroNomeUsuario;
        private System.Windows.Forms.Label lbSobrenomeUsuario;
        private System.Windows.Forms.TextBox tbFiltroSobrenomeUsuario;
        private System.Windows.Forms.Button btPesquisar;
        private Controls.BuscaGrupoUsuario buscaGrupoUsuario;
    }
}