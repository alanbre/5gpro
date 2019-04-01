namespace _5gpro.Forms
{
    partial class fmBuscaGrupoUsuario
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
            this.dgvGrupoUsuario = new System.Windows.Forms.DataGridView();
            this.tbFiltroNomeGrupoUsuario = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupoUsuario
            // 
            this.dgvGrupoUsuario.AllowUserToAddRows = false;
            this.dgvGrupoUsuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGrupoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoUsuario.Location = new System.Drawing.Point(12, 43);
            this.dgvGrupoUsuario.Name = "dgvGrupoUsuario";
            this.dgvGrupoUsuario.Size = new System.Drawing.Size(560, 406);
            this.dgvGrupoUsuario.TabIndex = 0;
            this.dgvGrupoUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupoUsuario_CellDoubleClick);
            // 
            // tbFiltroNomeGrupoUsuario
            // 
            this.tbFiltroNomeGrupoUsuario.Location = new System.Drawing.Point(13, 17);
            this.tbFiltroNomeGrupoUsuario.Name = "tbFiltroNomeGrupoUsuario";
            this.tbFiltroNomeGrupoUsuario.Size = new System.Drawing.Size(478, 20);
            this.tbFiltroNomeGrupoUsuario.TabIndex = 1;
            this.tbFiltroNomeGrupoUsuario.TextChanged += new System.EventHandler(this.tbFiltroNomeGrupoUsuario_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(497, 14);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // fmBuscaGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroNomeGrupoUsuario);
            this.Controls.Add(this.dgvGrupoUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "fmBuscaGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca Grupo de Usuários";
            this.Load += new System.EventHandler(this.fmBuscaGrupoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupoUsuario;
        private System.Windows.Forms.TextBox tbFiltroNomeGrupoUsuario;
        private System.Windows.Forms.Button btPesquisar;
    }
}