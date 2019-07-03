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
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 108);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(435, 230);
            this.dgvUsuarios.TabIndex = 5;
            this.dgvUsuarios.TabStop = false;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellDoubleClick);
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Location = new System.Drawing.Point(7, 48);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbNomeUsuario.TabIndex = 0;
            this.lbNomeUsuario.Text = "Nome";
            // 
            // tbFiltroNomeUsuario
            // 
            this.tbFiltroNomeUsuario.Location = new System.Drawing.Point(10, 64);
            this.tbFiltroNomeUsuario.Name = "tbFiltroNomeUsuario";
            this.tbFiltroNomeUsuario.Size = new System.Drawing.Size(215, 20);
            this.tbFiltroNomeUsuario.TabIndex = 1;
            this.tbFiltroNomeUsuario.TextChanged += new System.EventHandler(this.TbFiltroNomeUsuario_TextChanged);
            // 
            // lbSobrenomeUsuario
            // 
            this.lbSobrenomeUsuario.AutoSize = true;
            this.lbSobrenomeUsuario.Location = new System.Drawing.Point(231, 48);
            this.lbSobrenomeUsuario.Name = "lbSobrenomeUsuario";
            this.lbSobrenomeUsuario.Size = new System.Drawing.Size(61, 13);
            this.lbSobrenomeUsuario.TabIndex = 2;
            this.lbSobrenomeUsuario.Text = "Sobrenome";
            // 
            // tbFiltroSobrenomeUsuario
            // 
            this.tbFiltroSobrenomeUsuario.Location = new System.Drawing.Point(231, 64);
            this.tbFiltroSobrenomeUsuario.Name = "tbFiltroSobrenomeUsuario";
            this.tbFiltroSobrenomeUsuario.Size = new System.Drawing.Size(219, 20);
            this.tbFiltroSobrenomeUsuario.TabIndex = 3;
            this.tbFiltroSobrenomeUsuario.TextChanged += new System.EventHandler(this.TbFiltroSobrenomeUsuario_TextChanged);
            // 
            // buscaGrupoUsuario
            // 
            this.buscaGrupoUsuario.Location = new System.Drawing.Point(6, 6);
            this.buscaGrupoUsuario.Name = "buscaGrupoUsuario";
            this.buscaGrupoUsuario.Size = new System.Drawing.Size(442, 39);
            this.buscaGrupoUsuario.TabIndex = 4;
            this.buscaGrupoUsuario.Text_Changed += new _5gpro.Controls.BuscaGrupoUsuario.text_changedEventHandler(this.BuscaGrupoUsuario_Text_Changed);
            this.buscaGrupoUsuario.Leave += new System.EventHandler(this.BuscaGrupoUsuario_Leave);
            // 
            // fmBuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 364);
            this.Controls.Add(this.buscaGrupoUsuario);
            this.Controls.Add(this.tbFiltroSobrenomeUsuario);
            this.Controls.Add(this.lbSobrenomeUsuario);
            this.Controls.Add(this.tbFiltroNomeUsuario);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBuscaUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Usuários";
            this.Load += new System.EventHandler(this.FmBuscaUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmBuscaUsuario_KeyDown);
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
        private Controls.BuscaGrupoUsuario buscaGrupoUsuario;
    }
}