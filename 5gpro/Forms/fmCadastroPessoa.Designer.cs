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
            this.gbSituacao = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.buscaGrupoPessoa = new _5gpro.Controls.BuscaGrupoPessoa();
            this.buscaSubGrupoPessoa = new _5gpro.Controls.BuscaSubGrupoPessoa();
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
            this.tbCep = new System.Windows.Forms.TextBox();
            this.lbCep = new System.Windows.Forms.Label();
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
            this.gbDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.tcDados = new System.Windows.Forms.TabControl();
            this.tpEndereco = new System.Windows.Forms.TabPage();
            this.tpBancaria = new System.Windows.Forms.TabPage();
            this.gbTipoConta = new System.Windows.Forms.GroupBox();
            this.rbContaPoupanca = new System.Windows.Forms.RadioButton();
            this.rbContaCorrente = new System.Windows.Forms.RadioButton();
            this.tbAgencia = new System.Windows.Forms.TextBox();
            this.lbAgencia = new System.Windows.Forms.Label();
            this.buscaBanco = new _5gpro.Controls.BuscaBanco();
            this.tbContaBancaria = new System.Windows.Forms.TextBox();
            this.lbContaBancaria = new System.Windows.Forms.Label();
            this.gbSituacao.SuspendLayout();
            this.gbAtuacao.SuspendLayout();
            this.gbTipoDePessoa.SuspendLayout();
            this.gbDadosPrincipais.SuspendLayout();
            this.tcDados.SuspendLayout();
            this.tpEndereco.SuspendLayout();
            this.tpBancaria.SuspendLayout();
            this.gbTipoConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSituacao
            // 
            this.gbSituacao.Controls.Add(this.rbInativo);
            this.gbSituacao.Controls.Add(this.rbAtivo);
            this.gbSituacao.Location = new System.Drawing.Point(465, 16);
            this.gbSituacao.Name = "gbSituacao";
            this.gbSituacao.Size = new System.Drawing.Size(130, 45);
            this.gbSituacao.TabIndex = 15;
            this.gbSituacao.TabStop = false;
            this.gbSituacao.Text = "Situação";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(62, 19);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(57, 17);
            this.rbInativo.TabIndex = 1;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            this.rbInativo.CheckedChanged += new System.EventHandler(this.RbInativo_CheckedChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(7, 19);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            this.rbAtivo.CheckedChanged += new System.EventHandler(this.RbAtivo_CheckedChanged);
            // 
            // buscaGrupoPessoa
            // 
            this.buscaGrupoPessoa.Location = new System.Drawing.Point(4, 141);
            this.buscaGrupoPessoa.Name = "buscaGrupoPessoa";
            this.buscaGrupoPessoa.Size = new System.Drawing.Size(465, 39);
            this.buscaGrupoPessoa.TabIndex = 6;
            this.buscaGrupoPessoa.Text_Changed += new _5gpro.Controls.BuscaGrupoPessoa.text_changedEventHandler(this.BuscaGrupoPessoa_Text_Changed);
            this.buscaGrupoPessoa.Leave += new System.EventHandler(this.BuscaGrupoPessoa_Leave);
            // 
            // buscaSubGrupoPessoa
            // 
            this.buscaSubGrupoPessoa.Location = new System.Drawing.Point(4, 186);
            this.buscaSubGrupoPessoa.Name = "buscaSubGrupoPessoa";
            this.buscaSubGrupoPessoa.Size = new System.Drawing.Size(442, 39);
            this.buscaSubGrupoPessoa.TabIndex = 7;
            this.buscaSubGrupoPessoa.Text_Changed += new _5gpro.Controls.BuscaSubGrupoPessoa.text_changedEventHandler(this.BuscaSubGrupoPessoa_Text_Changed);
            // 
            // gbAtuacao
            // 
            this.gbAtuacao.Controls.Add(this.cblAtuacao);
            this.gbAtuacao.Location = new System.Drawing.Point(604, 19);
            this.gbAtuacao.Name = "gbAtuacao";
            this.gbAtuacao.Size = new System.Drawing.Size(135, 89);
            this.gbAtuacao.TabIndex = 16;
            this.gbAtuacao.TabStop = false;
            this.gbAtuacao.Text = "Atuação";
            // 
            // cblAtuacao
            // 
            this.cblAtuacao.BackColor = System.Drawing.Color.White;
            this.cblAtuacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblAtuacao.CheckOnClick = true;
            this.cblAtuacao.FormattingEnabled = true;
            this.cblAtuacao.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor",
            "Vendedor(a)"});
            this.cblAtuacao.Location = new System.Drawing.Point(6, 19);
            this.cblAtuacao.Name = "cblAtuacao";
            this.cblAtuacao.Size = new System.Drawing.Size(120, 60);
            this.cblAtuacao.TabIndex = 0;
            this.cblAtuacao.TabStop = false;
            this.cblAtuacao.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CblAtuacao_ItemCheck);
            // 
            // tbFantasia
            // 
            this.tbFantasia.Location = new System.Drawing.Point(9, 115);
            this.tbFantasia.MaxLength = 255;
            this.tbFantasia.Name = "tbFantasia";
            this.tbFantasia.Size = new System.Drawing.Size(528, 20);
            this.tbFantasia.TabIndex = 5;
            this.tbFantasia.TextChanged += new System.EventHandler(this.TbFantasia_TextChanged);
            // 
            // lbFantasia
            // 
            this.lbFantasia.AutoSize = true;
            this.lbFantasia.Location = new System.Drawing.Point(7, 95);
            this.lbFantasia.Name = "lbFantasia";
            this.lbFantasia.Size = new System.Drawing.Size(121, 13);
            this.lbFantasia.TabIndex = 4;
            this.lbFantasia.Text = "Apelido / Nome fantasia";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(9, 71);
            this.tbNome.MaxLength = 255;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(527, 20);
            this.tbNome.TabIndex = 3;
            this.tbNome.TextChanged += new System.EventHandler(this.TbNome_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 55);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(107, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome / Razão social";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(9, 32);
            this.tbCodigo.MaxLength = 5;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(79, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigo_KeyUp);
            this.tbCodigo.Leave += new System.EventHandler(this.TbCodigo_Leave);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 16);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // gbTipoDePessoa
            // 
            this.gbTipoDePessoa.Controls.Add(this.rbPessoaJuridica);
            this.gbTipoDePessoa.Controls.Add(this.rbPessoaFisica);
            this.gbTipoDePessoa.Location = new System.Drawing.Point(244, 16);
            this.gbTipoDePessoa.Name = "gbTipoDePessoa";
            this.gbTipoDePessoa.Size = new System.Drawing.Size(215, 45);
            this.gbTipoDePessoa.TabIndex = 14;
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
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(545, 58);
            this.tbCep.MaxLength = 9;
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(64, 20);
            this.tbCep.TabIndex = 7;
            this.tbCep.TextChanged += new System.EventHandler(this.TbCep_TextChanged);
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(542, 42);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(28, 13);
            this.lbCep.TabIndex = 6;
            this.lbCep.Text = "CEP";
            // 
            // buscaCidade
            // 
            this.buscaCidade.LabelText = "Cidade";
            this.buscaCidade.Location = new System.Drawing.Point(3, 120);
            this.buscaCidade.Margin = new System.Windows.Forms.Padding(0);
            this.buscaCidade.Name = "buscaCidade";
            this.buscaCidade.Size = new System.Drawing.Size(442, 39);
            this.buscaCidade.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(9, 322);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(528, 20);
            this.tbEmail.TabIndex = 13;
            this.tbEmail.TextChanged += new System.EventHandler(this.TbEmail_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(7, 306);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "E-mail";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(9, 283);
            this.mtbTelefone.Mask = "(##) ####-#####";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(153, 20);
            this.mtbTelefone.TabIndex = 11;
            this.mtbTelefone.TextChanged += new System.EventHandler(this.MtbTelefone_TextChanged);
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(7, 267);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 10;
            this.lbTelefone.Text = "Telefone";
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.BeepOnError = true;
            this.mtbCpfCnpj.Location = new System.Drawing.Point(9, 244);
            this.mtbCpfCnpj.Mask = "###.###.###-##";
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(153, 20);
            this.mtbCpfCnpj.TabIndex = 9;
            this.mtbCpfCnpj.TextChanged += new System.EventHandler(this.MtbCpfCnpj_TextChanged);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(7, 228);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(59, 13);
            this.lbCpf.TabIndex = 8;
            this.lbCpf.Text = "CPF/CNPJ";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(9, 97);
            this.tbComplemento.MaxLength = 45;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(527, 20);
            this.tbComplemento.TabIndex = 9;
            this.tbComplemento.TextChanged += new System.EventHandler(this.TbComplemento_TextChanged);
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(6, 81);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 8;
            this.lbComplemento.Text = "Complemento";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(9, 58);
            this.tbBairro.MaxLength = 45;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(528, 20);
            this.tbBairro.TabIndex = 5;
            this.tbBairro.TextChanged += new System.EventHandler(this.TbBairro_TextChanged);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(6, 42);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 4;
            this.lbBairro.Text = "Bairro";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(546, 19);
            this.tbNumero.MaxLength = 10;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(64, 20);
            this.tbNumero.TabIndex = 3;
            this.tbNumero.TextChanged += new System.EventHandler(this.TbNumero_TextChanged);
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(543, 3);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 2;
            this.lbNumero.Text = "Número";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(9, 19);
            this.tbRua.MaxLength = 150;
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(528, 20);
            this.tbRua.TabIndex = 1;
            this.tbRua.TextChanged += new System.EventHandler(this.TbRua_TextChanged);
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(6, 3);
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
            this.tbAjuda.Location = new System.Drawing.Point(72, 633);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(755, 20);
            this.tbAjuda.TabIndex = 2;
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
            // gbDadosPrincipais
            // 
            this.gbDadosPrincipais.Controls.Add(this.tbEmail);
            this.gbDadosPrincipais.Controls.Add(this.buscaGrupoPessoa);
            this.gbDadosPrincipais.Controls.Add(this.lbEmail);
            this.gbDadosPrincipais.Controls.Add(this.buscaSubGrupoPessoa);
            this.gbDadosPrincipais.Controls.Add(this.mtbTelefone);
            this.gbDadosPrincipais.Controls.Add(this.gbSituacao);
            this.gbDadosPrincipais.Controls.Add(this.lbTelefone);
            this.gbDadosPrincipais.Controls.Add(this.lbCodigo);
            this.gbDadosPrincipais.Controls.Add(this.mtbCpfCnpj);
            this.gbDadosPrincipais.Controls.Add(this.tbFantasia);
            this.gbDadosPrincipais.Controls.Add(this.lbCpf);
            this.gbDadosPrincipais.Controls.Add(this.gbTipoDePessoa);
            this.gbDadosPrincipais.Controls.Add(this.tbCodigo);
            this.gbDadosPrincipais.Controls.Add(this.lbFantasia);
            this.gbDadosPrincipais.Controls.Add(this.gbAtuacao);
            this.gbDadosPrincipais.Controls.Add(this.tbNome);
            this.gbDadosPrincipais.Controls.Add(this.lbNome);
            this.gbDadosPrincipais.Location = new System.Drawing.Point(69, 11);
            this.gbDadosPrincipais.Name = "gbDadosPrincipais";
            this.gbDadosPrincipais.Size = new System.Drawing.Size(758, 358);
            this.gbDadosPrincipais.TabIndex = 0;
            this.gbDadosPrincipais.TabStop = false;
            this.gbDadosPrincipais.Text = "Dados Principais";
            // 
            // tcDados
            // 
            this.tcDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tcDados.Controls.Add(this.tpEndereco);
            this.tcDados.Controls.Add(this.tpBancaria);
            this.tcDados.Location = new System.Drawing.Point(69, 375);
            this.tcDados.Name = "tcDados";
            this.tcDados.SelectedIndex = 0;
            this.tcDados.Size = new System.Drawing.Size(758, 252);
            this.tcDados.TabIndex = 1;
            // 
            // tpEndereco
            // 
            this.tpEndereco.Controls.Add(this.buscaCidade);
            this.tpEndereco.Controls.Add(this.tbCep);
            this.tpEndereco.Controls.Add(this.lbRua);
            this.tpEndereco.Controls.Add(this.lbCep);
            this.tpEndereco.Controls.Add(this.tbRua);
            this.tpEndereco.Controls.Add(this.lbNumero);
            this.tpEndereco.Controls.Add(this.tbNumero);
            this.tpEndereco.Controls.Add(this.lbBairro);
            this.tpEndereco.Controls.Add(this.tbComplemento);
            this.tpEndereco.Controls.Add(this.tbBairro);
            this.tpEndereco.Controls.Add(this.lbComplemento);
            this.tpEndereco.Location = new System.Drawing.Point(4, 22);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tpEndereco.Size = new System.Drawing.Size(750, 226);
            this.tpEndereco.TabIndex = 0;
            this.tpEndereco.Text = "Endereço";
            this.tpEndereco.UseVisualStyleBackColor = true;
            // 
            // tpBancaria
            // 
            this.tpBancaria.Controls.Add(this.gbTipoConta);
            this.tpBancaria.Controls.Add(this.tbAgencia);
            this.tpBancaria.Controls.Add(this.lbAgencia);
            this.tpBancaria.Controls.Add(this.buscaBanco);
            this.tpBancaria.Controls.Add(this.tbContaBancaria);
            this.tpBancaria.Controls.Add(this.lbContaBancaria);
            this.tpBancaria.Location = new System.Drawing.Point(4, 22);
            this.tpBancaria.Name = "tpBancaria";
            this.tpBancaria.Padding = new System.Windows.Forms.Padding(3);
            this.tpBancaria.Size = new System.Drawing.Size(750, 226);
            this.tpBancaria.TabIndex = 1;
            this.tpBancaria.Text = "Bancária";
            this.tpBancaria.UseVisualStyleBackColor = true;
            // 
            // gbTipoConta
            // 
            this.gbTipoConta.Controls.Add(this.rbContaPoupanca);
            this.gbTipoConta.Controls.Add(this.rbContaCorrente);
            this.gbTipoConta.Location = new System.Drawing.Point(10, 133);
            this.gbTipoConta.Name = "gbTipoConta";
            this.gbTipoConta.Size = new System.Drawing.Size(158, 45);
            this.gbTipoConta.TabIndex = 5;
            this.gbTipoConta.TabStop = false;
            this.gbTipoConta.Text = "Tipo de conta";
            // 
            // rbContaPoupanca
            // 
            this.rbContaPoupanca.AutoSize = true;
            this.rbContaPoupanca.Location = new System.Drawing.Point(78, 19);
            this.rbContaPoupanca.Name = "rbContaPoupanca";
            this.rbContaPoupanca.Size = new System.Drawing.Size(74, 17);
            this.rbContaPoupanca.TabIndex = 1;
            this.rbContaPoupanca.Text = "Poupança";
            this.rbContaPoupanca.UseVisualStyleBackColor = true;
            this.rbContaPoupanca.CheckedChanged += new System.EventHandler(this.RbContaPoupanca_CheckedChanged);
            // 
            // rbContaCorrente
            // 
            this.rbContaCorrente.AutoSize = true;
            this.rbContaCorrente.Checked = true;
            this.rbContaCorrente.Location = new System.Drawing.Point(7, 19);
            this.rbContaCorrente.Name = "rbContaCorrente";
            this.rbContaCorrente.Size = new System.Drawing.Size(65, 17);
            this.rbContaCorrente.TabIndex = 0;
            this.rbContaCorrente.TabStop = true;
            this.rbContaCorrente.Text = "Corrente";
            this.rbContaCorrente.UseVisualStyleBackColor = true;
            this.rbContaCorrente.CheckedChanged += new System.EventHandler(this.RbContaCorrente_CheckedChanged);
            // 
            // tbAgencia
            // 
            this.tbAgencia.Location = new System.Drawing.Point(10, 68);
            this.tbAgencia.MaxLength = 20;
            this.tbAgencia.Name = "tbAgencia";
            this.tbAgencia.Size = new System.Drawing.Size(100, 20);
            this.tbAgencia.TabIndex = 2;
            this.tbAgencia.TextChanged += new System.EventHandler(this.TbAgencia_TextChanged);
            // 
            // lbAgencia
            // 
            this.lbAgencia.AutoSize = true;
            this.lbAgencia.Location = new System.Drawing.Point(7, 52);
            this.lbAgencia.Name = "lbAgencia";
            this.lbAgencia.Size = new System.Drawing.Size(46, 13);
            this.lbAgencia.TabIndex = 1;
            this.lbAgencia.Text = "Agência";
            // 
            // buscaBanco
            // 
            this.buscaBanco.Location = new System.Drawing.Point(5, 8);
            this.buscaBanco.Margin = new System.Windows.Forms.Padding(0);
            this.buscaBanco.Name = "buscaBanco";
            this.buscaBanco.Size = new System.Drawing.Size(442, 39);
            this.buscaBanco.TabIndex = 0;
            this.buscaBanco.Text_Changed += new _5gpro.Controls.BuscaBanco.text_changedEventHandler(this.BuscaBanco_Text_Changed);
            // 
            // tbContaBancaria
            // 
            this.tbContaBancaria.Location = new System.Drawing.Point(10, 107);
            this.tbContaBancaria.MaxLength = 20;
            this.tbContaBancaria.Name = "tbContaBancaria";
            this.tbContaBancaria.Size = new System.Drawing.Size(100, 20);
            this.tbContaBancaria.TabIndex = 4;
            this.tbContaBancaria.TextChanged += new System.EventHandler(this.TbContaBancaria_TextChanged);
            // 
            // lbContaBancaria
            // 
            this.lbContaBancaria.AutoSize = true;
            this.lbContaBancaria.Location = new System.Drawing.Point(7, 91);
            this.lbContaBancaria.Name = "lbContaBancaria";
            this.lbContaBancaria.Size = new System.Drawing.Size(35, 13);
            this.lbContaBancaria.TabIndex = 3;
            this.lbContaBancaria.Text = "Conta";
            // 
            // fmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 665);
            this.Controls.Add(this.tcDados);
            this.Controls.Add(this.gbDadosPrincipais);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.tbAjuda);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 704);
            this.Name = "fmCadastroPessoa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de pessoas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroPessoa_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroPessoa_KeyDown);
            this.gbSituacao.ResumeLayout(false);
            this.gbSituacao.PerformLayout();
            this.gbAtuacao.ResumeLayout(false);
            this.gbTipoDePessoa.ResumeLayout(false);
            this.gbTipoDePessoa.PerformLayout();
            this.gbDadosPrincipais.ResumeLayout(false);
            this.gbDadosPrincipais.PerformLayout();
            this.tcDados.ResumeLayout(false);
            this.tpEndereco.ResumeLayout(false);
            this.tpEndereco.PerformLayout();
            this.tpBancaria.ResumeLayout(false);
            this.tpBancaria.PerformLayout();
            this.gbTipoConta.ResumeLayout(false);
            this.gbTipoConta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox gbSituacao;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.GroupBox gbDadosPrincipais;
        private System.Windows.Forms.TabControl tcDados;
        private System.Windows.Forms.TabPage tpEndereco;
        private System.Windows.Forms.TabPage tpBancaria;
        private System.Windows.Forms.GroupBox gbTipoConta;
        private System.Windows.Forms.RadioButton rbContaPoupanca;
        private System.Windows.Forms.RadioButton rbContaCorrente;
        private System.Windows.Forms.TextBox tbAgencia;
        private System.Windows.Forms.Label lbAgencia;
        private Controls.BuscaBanco buscaBanco;
        private System.Windows.Forms.TextBox tbContaBancaria;
        private System.Windows.Forms.Label lbContaBancaria;
    }
}