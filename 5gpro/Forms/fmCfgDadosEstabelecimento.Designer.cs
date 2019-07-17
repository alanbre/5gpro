namespace _5gpro.Forms
{
    partial class fmCfgDadosEstabelecimento
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
            this.menuVertical1 = new _5gpro.Controls.MenuVertical();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.tbFantasia = new System.Windows.Forms.TextBox();
            this.lbFantasia = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.buscaCidade = new _5gpro.Controls.BuscaCidade();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.mtbCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.lbRua = new System.Windows.Forms.Label();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertical1
            // 
            this.menuVertical1.Location = new System.Drawing.Point(9, 9);
            this.menuVertical1.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical1.Name = "menuVertical1";
            this.menuVertical1.Size = new System.Drawing.Size(53, 364);
            this.menuVertical1.TabIndex = 0;
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(64, 418);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(724, 20);
            this.tbAjuda.TabIndex = 5;
            // 
            // gbDados
            // 
            this.gbDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDados.Controls.Add(this.buscaCidade);
            this.gbDados.Controls.Add(this.tbEmail);
            this.gbDados.Controls.Add(this.lbEmail);
            this.gbDados.Controls.Add(this.mtbTelefone);
            this.gbDados.Controls.Add(this.lbTelefone);
            this.gbDados.Controls.Add(this.mtbCpfCnpj);
            this.gbDados.Controls.Add(this.lbCpf);
            this.gbDados.Controls.Add(this.tbComplemento);
            this.gbDados.Controls.Add(this.lbComplemento);
            this.gbDados.Controls.Add(this.tbBairro);
            this.gbDados.Controls.Add(this.lbBairro);
            this.gbDados.Controls.Add(this.tbNumero);
            this.gbDados.Controls.Add(this.lbNumero);
            this.gbDados.Controls.Add(this.tbRua);
            this.gbDados.Controls.Add(this.lbRua);
            this.gbDados.Controls.Add(this.tbFantasia);
            this.gbDados.Controls.Add(this.lbFantasia);
            this.gbDados.Controls.Add(this.tbNome);
            this.gbDados.Controls.Add(this.lbNome);
            this.gbDados.Location = new System.Drawing.Point(65, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(723, 400);
            this.gbDados.TabIndex = 6;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // tbFantasia
            // 
            this.tbFantasia.Location = new System.Drawing.Point(8, 75);
            this.tbFantasia.MaxLength = 255;
            this.tbFantasia.Name = "tbFantasia";
            this.tbFantasia.Size = new System.Drawing.Size(528, 20);
            this.tbFantasia.TabIndex = 9;
            // 
            // lbFantasia
            // 
            this.lbFantasia.AutoSize = true;
            this.lbFantasia.Location = new System.Drawing.Point(6, 55);
            this.lbFantasia.Name = "lbFantasia";
            this.lbFantasia.Size = new System.Drawing.Size(121, 13);
            this.lbFantasia.TabIndex = 8;
            this.lbFantasia.Text = "Apelido / Nome fantasia";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(9, 32);
            this.tbNome.MaxLength = 255;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(527, 20);
            this.tbNome.TabIndex = 7;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 16);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(107, 13);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome / Razão social";
            // 
            // buscaCidade
            // 
            this.buscaCidade.LabelText = "Cidade";
            this.buscaCidade.Location = new System.Drawing.Point(4, 215);
            this.buscaCidade.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCidade.Name = "buscaCidade";
            this.buscaCidade.Size = new System.Drawing.Size(442, 39);
            this.buscaCidade.TabIndex = 23;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(9, 355);
            this.tbEmail.MaxLength = 45;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(528, 20);
            this.tbEmail.TabIndex = 29;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(7, 339);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 28;
            this.lbEmail.Text = "E-mail";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(9, 316);
            this.mtbTelefone.Mask = "(##) ####-#####";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(153, 20);
            this.mtbTelefone.TabIndex = 27;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(7, 300);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 26;
            this.lbTelefone.Text = "Telefone";
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.BeepOnError = true;
            this.mtbCpfCnpj.Location = new System.Drawing.Point(9, 277);
            this.mtbCpfCnpj.Mask = "##.###.###/####-##";
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(153, 20);
            this.mtbCpfCnpj.TabIndex = 25;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(7, 261);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(34, 13);
            this.lbCpf.TabIndex = 24;
            this.lbCpf.Text = "CNPJ";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(10, 192);
            this.tbComplemento.MaxLength = 45;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(527, 20);
            this.tbComplemento.TabIndex = 22;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(6, 176);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 21;
            this.lbComplemento.Text = "Complemento";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(9, 153);
            this.tbBairro.MaxLength = 45;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(528, 20);
            this.tbBairro.TabIndex = 20;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(7, 137);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 19;
            this.lbBairro.Text = "Bairro";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(547, 114);
            this.tbNumero.MaxLength = 10;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(64, 20);
            this.tbNumero.TabIndex = 18;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(544, 98);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 17;
            this.lbNumero.Text = "Número";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(9, 114);
            this.tbRua.MaxLength = 150;
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(528, 20);
            this.tbRua.TabIndex = 16;
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(6, 98);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 15;
            this.lbRua.Text = "Rua";
            // 
            // fmCfgEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.menuVertical1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCfgEmpresa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dados da empresa";
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MenuVertical menuVertical1;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.TextBox tbFantasia;
        private System.Windows.Forms.Label lbFantasia;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private Controls.BuscaCidade buscaCidade;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCpfCnpj;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label lbRua;
    }
}