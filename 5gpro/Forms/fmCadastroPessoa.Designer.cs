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
            this.btBuscaCidade = new System.Windows.Forms.Button();
            this.tbNomeCidade = new System.Windows.Forms.TextBox();
            this.tbCodCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
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
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.pnDadosGerais.SuspendLayout();
            this.gbAtuacao.SuspendLayout();
            this.gbTipoDePessoa.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDadosGerais
            // 
            this.pnDadosGerais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDadosGerais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDadosGerais.Controls.Add(this.gbAtuacao);
            this.pnDadosGerais.Controls.Add(this.tbFantasia);
            this.pnDadosGerais.Controls.Add(this.lbFantasia);
            this.pnDadosGerais.Controls.Add(this.tbNome);
            this.pnDadosGerais.Controls.Add(this.lbNome);
            this.pnDadosGerais.Controls.Add(this.tbCodigo);
            this.pnDadosGerais.Controls.Add(this.lbCodigo);
            this.pnDadosGerais.Location = new System.Drawing.Point(72, 12);
            this.pnDadosGerais.Name = "pnDadosGerais";
            this.pnDadosGerais.Size = new System.Drawing.Size(1110, 138);
            this.pnDadosGerais.TabIndex = 0;
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
            // 
            // tbFantasia
            // 
            this.tbFantasia.Location = new System.Drawing.Point(15, 108);
            this.tbFantasia.MaxLength = 255;
            this.tbFantasia.Name = "tbFantasia";
            this.tbFantasia.Size = new System.Drawing.Size(528, 20);
            this.tbFantasia.TabIndex = 5;
            this.tbFantasia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFantasia_KeyUp);
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
            this.tbNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNome_KeyUp);
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
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            this.tbCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCodigo_KeyUp);
            this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
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
            this.gbTipoDePessoa.Location = new System.Drawing.Point(72, 156);
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
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDados.Controls.Add(this.btBuscaCidade);
            this.pnDados.Controls.Add(this.tbNomeCidade);
            this.pnDados.Controls.Add(this.tbCodCidade);
            this.pnDados.Controls.Add(this.lbCidade);
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
            this.pnDados.Location = new System.Drawing.Point(72, 207);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(1110, 305);
            this.pnDados.TabIndex = 2;
            // 
            // btBuscaCidade
            // 
            this.btBuscaCidade.Location = new System.Drawing.Point(85, 142);
            this.btBuscaCidade.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btBuscaCidade.Name = "btBuscaCidade";
            this.btBuscaCidade.Size = new System.Drawing.Size(20, 20);
            this.btBuscaCidade.TabIndex = 1;
            this.btBuscaCidade.TabStop = false;
            this.btBuscaCidade.UseVisualStyleBackColor = true;
            this.btBuscaCidade.Click += new System.EventHandler(this.btBuscaCidade_Click);
            // 
            // tbNomeCidade
            // 
            this.tbNomeCidade.Enabled = false;
            this.tbNomeCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCidade.Location = new System.Drawing.Point(107, 143);
            this.tbNomeCidade.Name = "tbNomeCidade";
            this.tbNomeCidade.Size = new System.Drawing.Size(436, 21);
            this.tbNomeCidade.TabIndex = 16;
            // 
            // tbCodCidade
            // 
            this.tbCodCidade.Location = new System.Drawing.Point(15, 143);
            this.tbCodCidade.MaxLength = 5;
            this.tbCodCidade.Name = "tbCodCidade";
            this.tbCodCidade.Size = new System.Drawing.Size(68, 20);
            this.tbCodCidade.TabIndex = 8;
            this.tbCodCidade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCodCidade_KeyUp);
            this.tbCodCidade.Leave += new System.EventHandler(this.tbCodCidade_Leave);
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(13, 127);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 8;
            this.lbCidade.Text = "Cidade";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(15, 267);
            this.tbEmail.MaxLength = 45;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(528, 20);
            this.tbEmail.TabIndex = 15;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(13, 251);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "E-mail";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(15, 228);
            this.mtbTelefone.Mask = "(##) ####-####";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(153, 20);
            this.mtbTelefone.TabIndex = 13;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(13, 212);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 12;
            this.lbTelefone.Text = "Telefone";
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.BeepOnError = true;
            this.mtbCpfCnpj.Location = new System.Drawing.Point(15, 189);
            this.mtbCpfCnpj.Mask = "###.###.###-##";
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(153, 20);
            this.mtbCpfCnpj.TabIndex = 11;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(13, 173);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(59, 13);
            this.lbCpf.TabIndex = 10;
            this.lbCpf.Text = "CPF/CNPJ";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(16, 104);
            this.tbComplemento.MaxLength = 45;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(527, 20);
            this.tbComplemento.TabIndex = 7;
            this.tbComplemento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbComplemento_KeyUp);
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
            this.tbBairro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBairro_KeyUp);
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
            this.tbNumero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNumero_KeyUp);
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
            this.tbRua.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRua_KeyUp);
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
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btRecarregar);
            this.pnBotoes.Controls.Add(this.btSalvar);
            this.pnBotoes.Controls.Add(this.btDeletar);
            this.pnBotoes.Controls.Add(this.btAnterior);
            this.pnBotoes.Controls.Add(this.btProximo);
            this.pnBotoes.Controls.Add(this.btBuscar);
            this.pnBotoes.Controls.Add(this.btNovo);
            this.pnBotoes.Location = new System.Drawing.Point(10, 11);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(56, 488);
            this.pnBotoes.TabIndex = 3;
            // 
            // btRecarregar
            // 
            this.btRecarregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRecarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btRecarregar.Image = global::_5gpro.Properties.Resources.iosReload_48px_blue;
            this.btRecarregar.Location = new System.Drawing.Point(3, 157);
            this.btRecarregar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btRecarregar.Name = "btRecarregar";
            this.btRecarregar.Size = new System.Drawing.Size(48, 48);
            this.btRecarregar.TabIndex = 6;
            this.btRecarregar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.Image = global::_5gpro.Properties.Resources.iosOk_48px_black;
            this.btSalvar.Location = new System.Drawing.Point(3, 106);
            this.btSalvar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(48, 48);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeletar.Image = global::_5gpro.Properties.Resources.iosDelete_48px_black;
            this.btDeletar.Location = new System.Drawing.Point(3, 310);
            this.btDeletar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(48, 48);
            this.btDeletar.TabIndex = 5;
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAnterior.Image = global::_5gpro.Properties.Resources.iosLeft_48px_Blue;
            this.btAnterior.Location = new System.Drawing.Point(3, 259);
            this.btAnterior.MinimumSize = new System.Drawing.Size(48, 48);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(48, 48);
            this.btAnterior.TabIndex = 4;
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btProximo
            // 
            this.btProximo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btProximo.Image = global::_5gpro.Properties.Resources.iosRight_48px_Blue;
            this.btProximo.Location = new System.Drawing.Point(3, 208);
            this.btProximo.MinimumSize = new System.Drawing.Size(48, 48);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(48, 48);
            this.btProximo.TabIndex = 3;
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Image = global::_5gpro.Properties.Resources.iosSearch_48px_black;
            this.btBuscar.Location = new System.Drawing.Point(3, 55);
            this.btBuscar.MinimumSize = new System.Drawing.Size(48, 48);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(48, 48);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovo.Image = global::_5gpro.Properties.Resources.iosPlus_48px_black;
            this.btNovo.Location = new System.Drawing.Point(3, 3);
            this.btNovo.MinimumSize = new System.Drawing.Size(48, 48);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(48, 48);
            this.btNovo.TabIndex = 1;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(72, 530);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(1110, 20);
            this.tbAjuda.TabIndex = 4;
            // 
            // fmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 562);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.gbTipoDePessoa);
            this.Controls.Add(this.pnDadosGerais);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "fmCadastroPessoa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de pessoas";
            this.pnDadosGerais.ResumeLayout(false);
            this.pnDadosGerais.PerformLayout();
            this.gbAtuacao.ResumeLayout(false);
            this.gbTipoDePessoa.ResumeLayout(false);
            this.gbTipoDePessoa.PerformLayout();
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbAjuda;
        private System.Windows.Forms.Button btBuscaCidade;
        private System.Windows.Forms.TextBox tbNomeCidade;
        private System.Windows.Forms.TextBox tbCodCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.CheckedListBox cblAtuacao;
        private System.Windows.Forms.Button btRecarregar;
    }
}