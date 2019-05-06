namespace _5gpro.Forms
{
    partial class fmCadastroPessoa
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
            this.pnDadosGerais = new System.Windows.Forms.Panel();
            this.buscaSubGrupoPessoa = new _5gpro.Controls.BuscaSubGrupoPessoa();
            this.buscaGrupoPessoa = new _5gpro.Controls.BuscaGrupoPessoa();
            this.gbAtuacao = new System.Windows.Forms.GroupBox();
            this.cblAtuacao = new System.Windows.Forms.CheckedListBox();
            this.tbFantasia = new System.Windows.Forms.TextBox();
            this.lbFantasia = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.gbTipoDePessoa = new System.Windows.Forms.GroupBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.pnDados = new System.Windows.Forms.Panel();
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
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.pnDadosGerais.SuspendLayout();
            this.gbAtuacao.SuspendLayout();
            this.gbTipoDePessoa.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDadosGerais
            // 
            this.pnDadosGerais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDadosGerais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDadosGerais.Controls.Add(this.buscaSubGrupoPessoa);
            this.pnDadosGerais.Controls.Add(this.buscaGrupoPessoa);
            this.pnDadosGerais.Controls.Add(this.gbAtuacao);
            this.pnDadosGerais.Controls.Add(this.tbFantasia);
            this.pnDadosGerais.Controls.Add(this.lbFantasia);
            this.pnDadosGerais.Controls.Add(this.tbNome);
            this.pnDadosGerais.Controls.Add(this.lbNome);
            this.pnDadosGerais.Controls.Add(this.tbCodigo);
            this.pnDadosGerais.Controls.Add(this.lbCodigo);
            this.pnDadosGerais.Location = new System.Drawing.Point(69, 12);
            this.pnDadosGerais.Name = "pnDadosGerais";
            this.pnDadosGerais.Size = new System.Drawing.Size(1110, 237);
            this.pnDadosGerais.TabIndex = 0;
            // 
            // buscaSubGrupoPessoa
            // 
            this.buscaSubGrupoPessoa.Location = new System.Drawing.Point(10, 179);
            this.buscaSubGrupoPessoa.Name = "buscaSubGrupoPessoa";
            this.buscaSubGrupoPessoa.Size = new System.Drawing.Size(442, 39);
            this.buscaSubGrupoPessoa.TabIndex = 8;
            // 
            // buscaGrupoPessoa
            // 
            this.buscaGrupoPessoa.Location = new System.Drawing.Point(10, 134);
            this.buscaGrupoPessoa.Name = "buscaGrupoPessoa";
            this.buscaGrupoPessoa.Size = new System.Drawing.Size(442, 39);
            this.buscaGrupoPessoa.TabIndex = 7;
            // 
            // gbAtuacao
            // 
            this.gbAtuacao.Controls.Add(this.cblAtuacao);
            this.gbAtuacao.Location = new System.Drawing.Point(553, 6);
            this.gbAtuacao.Name = "gbAtuacao";
            this.gbAtuacao.Size = new System.Drawing.Size(135, 121);
            this.gbAtuacao.TabIndex = 6;
            this.gbAtuacao.TabStop = false;
            this.gbAtuacao.Text = "Atuação";
            // 
            // cblAtuacao
            // 
            this.cblAtuacao.BackColor = System.Drawing.SystemColors.Control;
            this.cblAtuacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblAtuacao.FormattingEnabled = true;
            this.cblAtuacao.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor"});
            this.cblAtuacao.Location = new System.Drawing.Point(6, 19);
            this.cblAtuacao.Name = "cblAtuacao";
            this.cblAtuacao.Size = new System.Drawing.Size(120, 90);
            this.cblAtuacao.TabIndex = 7;
            this.cblAtuacao.TabStop = false;
            this.cblAtuacao.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CblAtuacao_ItemCheck);
            // 
            // tbFantasia
            // 
            this.tbFantasia.Location = new System.Drawing.Point(15, 108);
            this.tbFantasia.MaxLength = 255;
            this.tbFantasia.Name = "tbFantasia";
            this.tbFantasia.Size = new System.Drawing.Size(528, 20);
            this.tbFantasia.TabIndex = 5;
            this.tbFantasia.TextChanged += new System.EventHandler(this.TbFantasia_TextChanged);
            // 
            // lbFantasia
            // 
            this.lbFantasia.AutoSize = true;
            this.lbFantasia.Location = new System.Drawing.Point(13, 88);
            this.lbFantasia.Name = "lbFantasia";
            this.lbFantasia.Size = new System.Drawing.Size(121, 13);
            this.lbFantasia.TabIndex = 4;
            this.lbFantasia.Text = "Apelido / Nome fantasia";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(16, 65);
            this.tbNome.MaxLength = 255;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(527, 20);
            this.tbNome.TabIndex = 3;
            this.tbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(13, 49);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(107, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome / Razão social";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(16, 26);
            this.tbCodigo.MaxLength = 5;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(79, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCodigo_KeyPress);
            this.tbCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigo_KeyUp);
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(13, 10);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // gbTipoDePessoa
            // 
            this.gbTipoDePessoa.Controls.Add(this.rbPessoaJuridica);
            this.gbTipoDePessoa.Controls.Add(this.rbPessoaFisica);
            this.gbTipoDePessoa.Location = new System.Drawing.Point(69, 255);
            this.gbTipoDePessoa.Name = "gbTipoDePessoa";
            this.gbTipoDePessoa.Size = new System.Drawing.Size(215, 45);
            this.gbTipoDePessoa.TabIndex = 1;
            this.gbTipoDePessoa.TabStop = false;
            this.gbTipoDePessoa.Text = "Tipo de pessoa";
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(108, 19);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.RbPessoaJuridica_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Checked = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(6, 19);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.RbPessoaFisica_CheckedChanged);
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDados.Controls.Add(this.buscaCidade);
            this.pnDados.Controls.Add(this.tbEmail);
            this.pnDados.Controls.Add(this.lbEmail);
            this.pnDados.Controls.Add(this.mtbTelefone);
            this.pnDados.Controls.Add(this.lbTelefone);
            this.pnDados.Controls.Add(this.mtbCpfCnpj);
            this.pnDados.Controls.Add(this.lbCpf);
            this.pnDados.Controls.Add(this.tbComplemento);
            this.pnDados.Controls.Add(this.lbComplemento);
            this.pnDados.Controls.Add(this.tbBairro);
            this.pnDados.Controls.Add(this.lbBairro);
            this.pnDados.Controls.Add(this.tbNumero);
            this.pnDados.Controls.Add(this.lbNumero);
            this.pnDados.Controls.Add(this.tbRua);
            this.pnDados.Controls.Add(this.lbRua);
            this.pnDados.Location = new System.Drawing.Point(69, 306);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(1110, 299);
            this.pnDados.TabIndex = 2;
            // 
            // buscaCidade
            // 
            this.buscaCidade.Location = new System.Drawing.Point(10, 127);
            this.buscaCidade.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCidade.Name = "buscaCidade";
            this.buscaCidade.Size = new System.Drawing.Size(442, 39);
            this.buscaCidade.TabIndex = 15;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(15, 267);
            this.tbEmail.MaxLength = 45;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(528, 20);
            this.tbEmail.TabIndex = 14;
            this.tbEmail.TextChanged += new System.EventHandler(this.TbEmail_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(13, 251);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "E-mail";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(15, 228);
            this.mtbTelefone.Mask = "(##) ####-####";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(153, 20);
            this.mtbTelefone.TabIndex = 12;
            this.mtbTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbTelefone_MaskInputRejected);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(13, 212);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 11;
            this.lbTelefone.Text = "Telefone";
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.BeepOnError = true;
            this.mtbCpfCnpj.Location = new System.Drawing.Point(15, 189);
            this.mtbCpfCnpj.Mask = "###.###.###-##";
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(153, 20);
            this.mtbCpfCnpj.TabIndex = 10;
            this.mtbCpfCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtbCpfCnpj_MaskInputRejected);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(13, 173);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(59, 13);
            this.lbCpf.TabIndex = 9;
            this.lbCpf.Text = "CPF/CNPJ";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(16, 104);
            this.tbComplemento.MaxLength = 45;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(527, 20);
            this.tbComplemento.TabIndex = 7;
            this.tbComplemento.TextChanged += new System.EventHandler(this.TbComplemento_TextChanged);
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(12, 88);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 6;
            this.lbComplemento.Text = "Complemento";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(15, 65);
            this.tbBairro.MaxLength = 45;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(528, 20);
            this.tbBairro.TabIndex = 5;
            this.tbBairro.TextChanged += new System.EventHandler(this.TbBairro_TextChanged);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(13, 49);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 4;
            this.lbBairro.Text = "Bairro";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(553, 26);
            this.tbNumero.MaxLength = 10;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(64, 20);
            this.tbNumero.TabIndex = 3;
            this.tbNumero.TextChanged += new System.EventHandler(this.TbNumero_TextChanged);
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(550, 10);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 2;
            this.lbNumero.Text = "Número";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(15, 26);
            this.tbRua.MaxLength = 150;
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(528, 20);
            this.tbRua.TabIndex = 1;
            this.tbRua.TextChanged += new System.EventHandler(this.TbRua_TextChanged);
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(12, 10);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 0;
            this.lbRua.Text = "Rua";
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(72, 623);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(1110, 20);
            this.tbAjuda.TabIndex = 4;
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(11, 11);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 3;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical_Proximo_Clicked);
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical_Excluir_Clicked);
            // 
            // fmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 655);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.gbTipoDePessoa);
            this.Controls.Add(this.pnDadosGerais);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "fmCadastroPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de pessoas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroPessoa_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroPessoa_KeyDown);
            this.pnDadosGerais.ResumeLayout(false);
            this.pnDadosGerais.PerformLayout();
            this.gbAtuacao.ResumeLayout(false);
            this.gbTipoDePessoa.ResumeLayout(false);
            this.gbTipoDePessoa.PerformLayout();
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDadosGerais;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbFantasia;
        private System.Windows.Forms.Label lbFantasia;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.GroupBox gbTipoDePessoa;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.GroupBox gbAtuacao;
        private System.Windows.Forms.Panel pnDados;
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
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.CheckedListBox cblAtuacao;
        private Controls.MenuVertical menuVertical;
        private Controls.BuscaCidade buscaCidade;
        private Controls.BuscaSubGrupoPessoa buscaSubGrupoPessoa;
        private Controls.BuscaGrupoPessoa buscaGrupoPessoa;
    }
}