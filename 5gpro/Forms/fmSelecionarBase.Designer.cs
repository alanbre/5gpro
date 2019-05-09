namespace _5gpro.Forms
{
    partial class fmSelecionarBase
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
            this.dgvBases = new System.Windows.Forms.DataGridView();
            this.btEntrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dgvtbcDataBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBases)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBases
            // 
            this.dgvBases.AllowUserToAddRows = false;
            this.dgvBases.AllowUserToDeleteRows = false;
            this.dgvBases.AllowUserToOrderColumns = true;
            this.dgvBases.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvBases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBases.BackgroundColor = System.Drawing.Color.White;
            this.dgvBases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcDataBase,
            this.dgvtbcServer,
            this.dgvtbcUid,
            this.dgvtbcPassword});
            this.dgvBases.Location = new System.Drawing.Point(12, 12);
            this.dgvBases.MultiSelect = false;
            this.dgvBases.Name = "dgvBases";
            this.dgvBases.ReadOnly = true;
            this.dgvBases.RowHeadersVisible = false;
            this.dgvBases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBases.Size = new System.Drawing.Size(412, 210);
            this.dgvBases.TabIndex = 0;
            this.dgvBases.TabStop = false;
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(12, 228);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(75, 23);
            this.btEntrar.TabIndex = 1;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(93, 228);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // dgvtbcDataBase
            // 
            this.dgvtbcDataBase.HeaderText = "DataBase";
            this.dgvtbcDataBase.Name = "dgvtbcDataBase";
            this.dgvtbcDataBase.ReadOnly = true;
            // 
            // dgvtbcServer
            // 
            this.dgvtbcServer.HeaderText = "Server";
            this.dgvtbcServer.Name = "dgvtbcServer";
            this.dgvtbcServer.ReadOnly = true;
            // 
            // dgvtbcUid
            // 
            this.dgvtbcUid.HeaderText = "UID";
            this.dgvtbcUid.Name = "dgvtbcUid";
            this.dgvtbcUid.ReadOnly = true;
            // 
            // dgvtbcPassword
            // 
            this.dgvtbcPassword.HeaderText = "Password";
            this.dgvtbcPassword.Name = "dgvtbcPassword";
            this.dgvtbcPassword.ReadOnly = true;
            // 
            // fmSelecionarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 263);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.dgvBases);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSelecionarBase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar base";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBases;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDataBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcUid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPassword;
    }
}