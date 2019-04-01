namespace _5gpro.Forms
{
    partial class fmBuscaPessoa
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
            this.btBuscaCidade = new System.Windows.Forms.Button();
            this.tbNomeCidade = new System.Windows.Forms.TextBox();
            this.tbFiltroCodCidade = new System.Windows.Forms.TextBox();
            this.lbFiltroCidade = new System.Windows.Forms.Label();
            this.lbFiltroNome = new System.Windows.Forms.Label();
            this.tbFiltroNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.tbCpfCnpj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscaCidade
            // 
            this.btBuscaCidade.Location = new System.Drawing.Point(77, 24);
            this.btBuscaCidade.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btBuscaCidade.Name = "btBuscaCidade";
            this.btBuscaCidade.Size = new System.Drawing.Size(20, 20);
            this.btBuscaCidade.TabIndex = 2;
            this.btBuscaCidade.TabStop = false;
            this.btBuscaCidade.UseVisualStyleBackColor = true;
            this.btBuscaCidade.Click += new System.EventHandler(this.btBuscaCidade_Click);
            // 
            // tbNomeCidade
            // 
            this.tbNomeCidade.Location = new System.Drawing.Point(101, 25);
            this.tbNomeCidade.Name = "tbNomeCidade";
            this.tbNomeCidade.ReadOnly = true;
            this.tbNomeCidade.Size = new System.Drawing.Size(436, 20);
            this.tbNomeCidade.TabIndex = 3;
            this.tbNomeCidade.TabStop = false;
            // 
            // tbFiltroCodCidade
            // 
            this.tbFiltroCodCidade.Location = new System.Drawing.Point(7, 24);
            this.tbFiltroCodCidade.MaxLength = 5;
            this.tbFiltroCodCidade.Name = "tbFiltroCodCidade";
            this.tbFiltroCodCidade.Size = new System.Drawing.Size(68, 20);
            this.tbFiltroCodCidade.TabIndex = 1;
            this.tbFiltroCodCidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCodCidade_KeyUp);
            this.tbFiltroCodCidade.Leave += new System.EventHandler(this.tbFiltroCodCidade_Leave);
            // 
            // lbFiltroCidade
            // 
            this.lbFiltroCidade.AutoSize = true;
            this.lbFiltroCidade.Location = new System.Drawing.Point(4, 8);
            this.lbFiltroCidade.Name = "lbFiltroCidade";
            this.lbFiltroCidade.Size = new System.Drawing.Size(40, 13);
            this.lbFiltroCidade.TabIndex = 0;
            this.lbFiltroCidade.Text = "Cidade";
            // 
            // lbFiltroNome
            // 
            this.lbFiltroNome.AutoSize = true;
            this.lbFiltroNome.Location = new System.Drawing.Point(9, 47);
            this.lbFiltroNome.Name = "lbFiltroNome";
            this.lbFiltroNome.Size = new System.Drawing.Size(35, 13);
            this.lbFiltroNome.TabIndex = 4;
            this.lbFiltroNome.Text = "Nome";
            // 
            // tbFiltroNome
            // 
            this.tbFiltroNome.Location = new System.Drawing.Point(7, 63);
            this.tbFiltroNome.Name = "tbFiltroNome";
            this.tbFiltroNome.Size = new System.Drawing.Size(530, 20);
            this.tbFiltroNome.TabIndex = 5;
            this.tbFiltroNome.TextChanged += new System.EventHandler(this.tbFiltroNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF/CNPJ";
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            this.dgvPessoas.AllowUserToOrderColumns = true;
            this.dgvPessoas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvPessoas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPessoas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPessoas.Location = new System.Drawing.Point(7, 128);
            this.dgvPessoas.MultiSelect = false;
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowHeadersVisible = false;
            this.dgvPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoas.Size = new System.Drawing.Size(1046, 377);
            this.dgvPessoas.TabIndex = 9;
            this.dgvPessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoas_CellContentClick);
            this.dgvPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoas_CellDoubleClick);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(154, 100);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 8;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Location = new System.Drawing.Point(7, 102);
            this.tbCpfCnpj.MaxLength = 14;
            this.tbCpfCnpj.Name = "tbCpfCnpj";
            this.tbCpfCnpj.Size = new System.Drawing.Size(141, 20);
            this.tbCpfCnpj.TabIndex = 7;
            this.tbCpfCnpj.TextChanged += new System.EventHandler(this.tbCpfCnpj_TextChanged);
            // 
            // fmBuscaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 517);
            this.Controls.Add(this.tbCpfCnpj);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFiltroNome);
            this.Controls.Add(this.lbFiltroNome);
            this.Controls.Add(this.btBuscaCidade);
            this.Controls.Add(this.tbNomeCidade);
            this.Controls.Add(this.tbFiltroCodCidade);
            this.Controls.Add(this.lbFiltroCidade);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBuscaPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca pessoa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmBuscaPessoa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaCidade;
        private System.Windows.Forms.TextBox tbNomeCidade;
        private System.Windows.Forms.TextBox tbFiltroCodCidade;
        private System.Windows.Forms.Label lbFiltroCidade;
        private System.Windows.Forms.Label lbFiltroNome;
        private System.Windows.Forms.TextBox tbFiltroNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox tbCpfCnpj;
    }
}