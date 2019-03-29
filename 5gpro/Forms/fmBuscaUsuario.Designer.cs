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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.tbFiltroCodUsuario = new System.Windows.Forms.TextBox();
            this.btBuscaGrupoUsuario = new System.Windows.Forms.Button();
            this.tbNomeGrupoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSobrenomeUsuario = new System.Windows.Forms.Label();
            this.tbSobrenomeUsuario = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 330);
            this.dataGridView1.TabIndex = 0;
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
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(10, 64);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.Size = new System.Drawing.Size(200, 20);
            this.tbNomeUsuario.TabIndex = 2;
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
            // tbSobrenomeUsuario
            // 
            this.tbSobrenomeUsuario.Location = new System.Drawing.Point(250, 64);
            this.tbSobrenomeUsuario.Name = "tbSobrenomeUsuario";
            this.tbSobrenomeUsuario.Size = new System.Drawing.Size(200, 20);
            this.tbSobrenomeUsuario.TabIndex = 8;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(467, 61);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 9;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // fmBuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbSobrenomeUsuario);
            this.Controls.Add(this.lbSobrenomeUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomeGrupoUsuario);
            this.Controls.Add(this.btBuscaGrupoUsuario);
            this.Controls.Add(this.tbFiltroCodUsuario);
            this.Controls.Add(this.tbNomeUsuario);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fmBuscaUsuario";
            this.Text = "fmBuscaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.TextBox tbNomeUsuario;
        private System.Windows.Forms.TextBox tbFiltroCodUsuario;
        private System.Windows.Forms.Button btBuscaGrupoUsuario;
        private System.Windows.Forms.TextBox tbNomeGrupoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSobrenomeUsuario;
        private System.Windows.Forms.TextBox tbSobrenomeUsuario;
        private System.Windows.Forms.Button btPesquisar;
    }
}