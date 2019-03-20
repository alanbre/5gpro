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
            this.btBuscaCidade = new System.Windows.Forms.Button();
            this.tbNomeCidade = new System.Windows.Forms.TextBox();
            this.tbFiltroCodCidade = new System.Windows.Forms.TextBox();
            this.lbFiltroCidade = new System.Windows.Forms.Label();
            this.lbFiltroNome = new System.Windows.Forms.Label();
            this.tbFiltroNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.colunaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscaCidade
            // 
            this.btBuscaCidade.Location = new System.Drawing.Point(77, 24);
            this.btBuscaCidade.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btBuscaCidade.Name = "btBuscaCidade";
            this.btBuscaCidade.Size = new System.Drawing.Size(20, 20);
            this.btBuscaCidade.TabIndex = 17;
            this.btBuscaCidade.TabStop = false;
            this.btBuscaCidade.UseVisualStyleBackColor = true;
            this.btBuscaCidade.Click += new System.EventHandler(this.btBuscaCidade_Click);
            // 
            // tbNomeCidade
            // 
            this.tbNomeCidade.Enabled = false;
            this.tbNomeCidade.Location = new System.Drawing.Point(101, 25);
            this.tbNomeCidade.Name = "tbNomeCidade";
            this.tbNomeCidade.Size = new System.Drawing.Size(436, 20);
            this.tbNomeCidade.TabIndex = 20;
            // 
            // tbFiltroCodCidade
            // 
            this.tbFiltroCodCidade.Location = new System.Drawing.Point(7, 24);
            this.tbFiltroCodCidade.MaxLength = 5;
            this.tbFiltroCodCidade.Name = "tbFiltroCodCidade";
            this.tbFiltroCodCidade.Size = new System.Drawing.Size(68, 20);
            this.tbFiltroCodCidade.TabIndex = 18;
            this.tbFiltroCodCidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCodCidade_KeyUp);
            // 
            // lbFiltroCidade
            // 
            this.lbFiltroCidade.AutoSize = true;
            this.lbFiltroCidade.Location = new System.Drawing.Point(4, 8);
            this.lbFiltroCidade.Name = "lbFiltroCidade";
            this.lbFiltroCidade.Size = new System.Drawing.Size(40, 13);
            this.lbFiltroCidade.TabIndex = 19;
            this.lbFiltroCidade.Text = "Cidade";
            // 
            // lbFiltroNome
            // 
            this.lbFiltroNome.AutoSize = true;
            this.lbFiltroNome.Location = new System.Drawing.Point(9, 47);
            this.lbFiltroNome.Name = "lbFiltroNome";
            this.lbFiltroNome.Size = new System.Drawing.Size(35, 13);
            this.lbFiltroNome.TabIndex = 21;
            this.lbFiltroNome.Text = "Nome";
            // 
            // tbFiltroNome
            // 
            this.tbFiltroNome.Location = new System.Drawing.Point(7, 63);
            this.tbFiltroNome.Name = "tbFiltroNome";
            this.tbFiltroNome.Size = new System.Drawing.Size(781, 20);
            this.tbFiltroNome.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "CPF/CNPJ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(7, 102);
            this.maskedTextBox1.Mask = "###.###.###-##";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(141, 20);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // dgvCidades
            // 
            this.dgvCidades.AllowUserToAddRows = false;
            this.dgvCidades.AllowUserToDeleteRows = false;
            this.dgvCidades.AllowUserToOrderColumns = true;
            this.dgvCidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCidades.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaCodigo,
            this.colunaNomeCliente,
            this.colunaFantasia,
            this.colunaCpfCnpj,
            this.colunaEndereco,
            this.colunaTelefone,
            this.colunaEmail});
            this.dgvCidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCidades.Location = new System.Drawing.Point(7, 128);
            this.dgvCidades.MultiSelect = false;
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.ReadOnly = true;
            this.dgvCidades.RowHeadersVisible = false;
            this.dgvCidades.Size = new System.Drawing.Size(875, 365);
            this.dgvCidades.TabIndex = 25;
            // 
            // colunaCodigo
            // 
            this.colunaCodigo.HeaderText = "Código";
            this.colunaCodigo.MinimumWidth = 50;
            this.colunaCodigo.Name = "colunaCodigo";
            this.colunaCodigo.ReadOnly = true;
            this.colunaCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colunaCodigo.Width = 186;
            // 
            // colunaNomeCliente
            // 
            this.colunaNomeCliente.HeaderText = "Nome do cliente";
            this.colunaNomeCliente.MinimumWidth = 100;
            this.colunaNomeCliente.Name = "colunaNomeCliente";
            this.colunaNomeCliente.ReadOnly = true;
            this.colunaNomeCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colunaNomeCliente.Width = 250;
            // 
            // colunaFantasia
            // 
            this.colunaFantasia.HeaderText = "Apelido / Fantasia";
            this.colunaFantasia.MinimumWidth = 100;
            this.colunaFantasia.Name = "colunaFantasia";
            this.colunaFantasia.ReadOnly = true;
            this.colunaFantasia.Width = 250;
            // 
            // colunaCpfCnpj
            // 
            this.colunaCpfCnpj.HeaderText = "CPF/CNPJ";
            this.colunaCpfCnpj.Name = "colunaCpfCnpj";
            this.colunaCpfCnpj.ReadOnly = true;
            // 
            // colunaEndereco
            // 
            this.colunaEndereco.HeaderText = "Endereço";
            this.colunaEndereco.Name = "colunaEndereco";
            this.colunaEndereco.ReadOnly = true;
            // 
            // colunaTelefone
            // 
            this.colunaTelefone.HeaderText = "Telefone";
            this.colunaTelefone.Name = "colunaTelefone";
            this.colunaTelefone.ReadOnly = true;
            // 
            // colunaEmail
            // 
            this.colunaEmail.HeaderText = "E-Mail";
            this.colunaEmail.Name = "colunaEmail";
            this.colunaEmail.ReadOnly = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(154, 100);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 26;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // fmBuscaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 505);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFiltroNome);
            this.Controls.Add(this.lbFiltroNome);
            this.Controls.Add(this.btBuscaCidade);
            this.Controls.Add(this.tbNomeCidade);
            this.Controls.Add(this.tbFiltroCodCidade);
            this.Controls.Add(this.lbFiltroCidade);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBuscaPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca pessoa";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaEmail;
        private System.Windows.Forms.Button btPesquisar;
    }
}