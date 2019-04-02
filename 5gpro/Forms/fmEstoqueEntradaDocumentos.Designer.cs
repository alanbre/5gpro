namespace _5gpro.Forms
{
    partial class fmEstoqueEntradaDocumentos
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
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.gbDadosDocumento = new System.Windows.Forms.GroupBox();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.lbEntrada = new System.Windows.Forms.Label();
            this.lbEmissao = new System.Windows.Forms.Label();
            this.tbNomeFornecedor = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.btProcuraFornecedor = new System.Windows.Forms.Button();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.tbCodFornecedor = new System.Windows.Forms.TextBox();
            this.gbTotais = new System.Windows.Forms.GroupBox();
            this.tbDescontoDocumento = new System.Windows.Forms.TextBox();
            this.lbDescontoDocumento = new System.Windows.Forms.Label();
            this.tbDescontoTotalItens = new System.Windows.Forms.TextBox();
            this.lbDescontoTotalItens = new System.Windows.Forms.Label();
            this.tbValorTotalDocumento = new System.Windows.Forms.TextBox();
            this.lbValorTotalDocumento = new System.Windows.Forms.Label();
            this.lbTotalItens = new System.Windows.Forms.Label();
            this.tbValorTotalItens = new System.Windows.Forms.TextBox();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.tbDescontoItem = new System.Windows.Forms.TextBox();
            this.lbDescItem = new System.Windows.Forms.Label();
            this.tbDescontoItemPorc = new System.Windows.Forms.TextBox();
            this.lbDescontoPorc = new System.Windows.Forms.Label();
            this.btNovoItem = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.btInserirItem = new System.Windows.Forms.Button();
            this.lbCodItem = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbValorTotItem = new System.Windows.Forms.TextBox();
            this.lbValorUnit = new System.Windows.Forms.Label();
            this.tbCodItem = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbValorTot = new System.Windows.Forms.Label();
            this.tbValorUnitItem = new System.Windows.Forms.TextBox();
            this.btProcuraItem = new System.Windows.Forms.Button();
            this.tbDescItem = new System.Windows.Forms.TextBox();
            this.pnBotoes.SuspendLayout();
            this.gbDadosDocumento.SuspendLayout();
            this.gbTotais.SuspendLayout();
            this.gbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
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
            this.pnBotoes.Location = new System.Drawing.Point(3, 6);
            this.pnBotoes.Margin = new System.Windows.Forms.Padding(1, 1, 3, 3);
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
            this.btRecarregar.TabIndex = 3;
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
            this.btDeletar.TabIndex = 6;
            this.btDeletar.UseVisualStyleBackColor = true;
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
            this.btAnterior.TabIndex = 5;
            this.btAnterior.UseVisualStyleBackColor = true;
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
            this.btProximo.TabIndex = 4;
            this.btProximo.UseVisualStyleBackColor = true;
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
            // 
            // gbDadosDocumento
            // 
            this.gbDadosDocumento.Controls.Add(this.dtpEntrada);
            this.gbDadosDocumento.Controls.Add(this.dtpEmissao);
            this.gbDadosDocumento.Controls.Add(this.lbEntrada);
            this.gbDadosDocumento.Controls.Add(this.lbEmissao);
            this.gbDadosDocumento.Controls.Add(this.tbNomeFornecedor);
            this.gbDadosDocumento.Controls.Add(this.tbCodigo);
            this.gbDadosDocumento.Controls.Add(this.lbDocumento);
            this.gbDadosDocumento.Controls.Add(this.btProcuraFornecedor);
            this.gbDadosDocumento.Controls.Add(this.lbFornecedor);
            this.gbDadosDocumento.Controls.Add(this.tbCodFornecedor);
            this.gbDadosDocumento.Location = new System.Drawing.Point(65, 6);
            this.gbDadosDocumento.Name = "gbDadosDocumento";
            this.gbDadosDocumento.Size = new System.Drawing.Size(1162, 181);
            this.gbDadosDocumento.TabIndex = 0;
            this.gbDadosDocumento.TabStop = false;
            this.gbDadosDocumento.Text = "Dados do documento";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(11, 152);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(99, 20);
            this.dtpEntrada.TabIndex = 9;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.CustomFormat = "";
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmissao.Location = new System.Drawing.Point(10, 113);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(100, 20);
            this.dtpEmissao.TabIndex = 7;
            this.dtpEmissao.Value = new System.DateTime(2019, 4, 2, 14, 27, 19, 0);
            // 
            // lbEntrada
            // 
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Location = new System.Drawing.Point(7, 136);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(84, 13);
            this.lbEntrada.TabIndex = 8;
            this.lbEntrada.Text = "Data de entrada";
            // 
            // lbEmissao
            // 
            this.lbEmissao.AutoSize = true;
            this.lbEmissao.Location = new System.Drawing.Point(7, 94);
            this.lbEmissao.Name = "lbEmissao";
            this.lbEmissao.Size = new System.Drawing.Size(86, 13);
            this.lbEmissao.TabIndex = 6;
            this.lbEmissao.Text = "Data da emissão";
            // 
            // tbNomeFornecedor
            // 
            this.tbNomeFornecedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNomeFornecedor.Location = new System.Drawing.Point(98, 70);
            this.tbNomeFornecedor.Name = "tbNomeFornecedor";
            this.tbNomeFornecedor.ReadOnly = true;
            this.tbNomeFornecedor.Size = new System.Drawing.Size(355, 20);
            this.tbNomeFornecedor.TabIndex = 5;
            this.tbNomeFornecedor.TabStop = false;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(9, 32);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(65, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(6, 16);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(62, 13);
            this.lbDocumento.TabIndex = 0;
            this.lbDocumento.Text = "Documento";
            // 
            // btProcuraFornecedor
            // 
            this.btProcuraFornecedor.Location = new System.Drawing.Point(76, 70);
            this.btProcuraFornecedor.Name = "btProcuraFornecedor";
            this.btProcuraFornecedor.Size = new System.Drawing.Size(20, 20);
            this.btProcuraFornecedor.TabIndex = 4;
            this.btProcuraFornecedor.TabStop = false;
            this.btProcuraFornecedor.UseVisualStyleBackColor = true;
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Location = new System.Drawing.Point(6, 55);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lbFornecedor.TabIndex = 2;
            this.lbFornecedor.Text = "Fornecedor";
            // 
            // tbCodFornecedor
            // 
            this.tbCodFornecedor.Location = new System.Drawing.Point(9, 71);
            this.tbCodFornecedor.Name = "tbCodFornecedor";
            this.tbCodFornecedor.Size = new System.Drawing.Size(65, 20);
            this.tbCodFornecedor.TabIndex = 3;
            // 
            // gbTotais
            // 
            this.gbTotais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotais.Controls.Add(this.tbDescontoDocumento);
            this.gbTotais.Controls.Add(this.lbDescontoDocumento);
            this.gbTotais.Controls.Add(this.tbDescontoTotalItens);
            this.gbTotais.Controls.Add(this.lbDescontoTotalItens);
            this.gbTotais.Controls.Add(this.tbValorTotalDocumento);
            this.gbTotais.Controls.Add(this.lbValorTotalDocumento);
            this.gbTotais.Controls.Add(this.lbTotalItens);
            this.gbTotais.Controls.Add(this.tbValorTotalItens);
            this.gbTotais.Location = new System.Drawing.Point(1064, 193);
            this.gbTotais.MinimumSize = new System.Drawing.Size(163, 326);
            this.gbTotais.Name = "gbTotais";
            this.gbTotais.Size = new System.Drawing.Size(163, 326);
            this.gbTotais.TabIndex = 2;
            this.gbTotais.TabStop = false;
            this.gbTotais.Text = "Totais";
            // 
            // tbDescontoDocumento
            // 
            this.tbDescontoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescontoDocumento.Location = new System.Drawing.Point(9, 113);
            this.tbDescontoDocumento.Name = "tbDescontoDocumento";
            this.tbDescontoDocumento.Size = new System.Drawing.Size(85, 20);
            this.tbDescontoDocumento.TabIndex = 5;
            this.tbDescontoDocumento.Text = "0,00";
            // 
            // lbDescontoDocumento
            // 
            this.lbDescontoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescontoDocumento.AutoSize = true;
            this.lbDescontoDocumento.Location = new System.Drawing.Point(6, 97);
            this.lbDescontoDocumento.Name = "lbDescontoDocumento";
            this.lbDescontoDocumento.Size = new System.Drawing.Size(124, 13);
            this.lbDescontoDocumento.TabIndex = 4;
            this.lbDescontoDocumento.Text = "Desconto do documento";
            // 
            // tbDescontoTotalItens
            // 
            this.tbDescontoTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescontoTotalItens.Location = new System.Drawing.Point(9, 74);
            this.tbDescontoTotalItens.Name = "tbDescontoTotalItens";
            this.tbDescontoTotalItens.ReadOnly = true;
            this.tbDescontoTotalItens.Size = new System.Drawing.Size(85, 20);
            this.tbDescontoTotalItens.TabIndex = 3;
            this.tbDescontoTotalItens.TabStop = false;
            this.tbDescontoTotalItens.Text = "0,00";
            // 
            // lbDescontoTotalItens
            // 
            this.lbDescontoTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescontoTotalItens.AutoSize = true;
            this.lbDescontoTotalItens.Location = new System.Drawing.Point(6, 58);
            this.lbDescontoTotalItens.Name = "lbDescontoTotalItens";
            this.lbDescontoTotalItens.Size = new System.Drawing.Size(121, 13);
            this.lbDescontoTotalItens.TabIndex = 2;
            this.lbDescontoTotalItens.Text = "Desconto total dos itens";
            // 
            // tbValorTotalDocumento
            // 
            this.tbValorTotalDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorTotalDocumento.Location = new System.Drawing.Point(8, 152);
            this.tbValorTotalDocumento.Name = "tbValorTotalDocumento";
            this.tbValorTotalDocumento.Size = new System.Drawing.Size(85, 20);
            this.tbValorTotalDocumento.TabIndex = 7;
            this.tbValorTotalDocumento.Text = "0,00";
            // 
            // lbValorTotalDocumento
            // 
            this.lbValorTotalDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValorTotalDocumento.AutoSize = true;
            this.lbValorTotalDocumento.Location = new System.Drawing.Point(5, 136);
            this.lbValorTotalDocumento.Name = "lbValorTotalDocumento";
            this.lbValorTotalDocumento.Size = new System.Drawing.Size(125, 13);
            this.lbValorTotalDocumento.TabIndex = 6;
            this.lbValorTotalDocumento.Text = "Valor total do documento";
            // 
            // lbTotalItens
            // 
            this.lbTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalItens.AutoSize = true;
            this.lbTotalItens.Location = new System.Drawing.Point(6, 19);
            this.lbTotalItens.Name = "lbTotalItens";
            this.lbTotalItens.Size = new System.Drawing.Size(99, 13);
            this.lbTotalItens.TabIndex = 0;
            this.lbTotalItens.Text = "Valor total dos itens";
            // 
            // tbValorTotalItens
            // 
            this.tbValorTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorTotalItens.Location = new System.Drawing.Point(9, 35);
            this.tbValorTotalItens.Name = "tbValorTotalItens";
            this.tbValorTotalItens.ReadOnly = true;
            this.tbValorTotalItens.Size = new System.Drawing.Size(85, 20);
            this.tbValorTotalItens.TabIndex = 1;
            this.tbValorTotalItens.TabStop = false;
            this.tbValorTotalItens.Text = "0,00";
            // 
            // gbItens
            // 
            this.gbItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbItens.Controls.Add(this.tbDescontoItem);
            this.gbItens.Controls.Add(this.lbDescItem);
            this.gbItens.Controls.Add(this.tbDescontoItemPorc);
            this.gbItens.Controls.Add(this.lbDescontoPorc);
            this.gbItens.Controls.Add(this.btNovoItem);
            this.gbItens.Controls.Add(this.dgvItens);
            this.gbItens.Controls.Add(this.btInserirItem);
            this.gbItens.Controls.Add(this.lbCodItem);
            this.gbItens.Controls.Add(this.tbQuantidade);
            this.gbItens.Controls.Add(this.tbValorTotItem);
            this.gbItens.Controls.Add(this.lbValorUnit);
            this.gbItens.Controls.Add(this.tbCodItem);
            this.gbItens.Controls.Add(this.lbQuantidade);
            this.gbItens.Controls.Add(this.lbValorTot);
            this.gbItens.Controls.Add(this.tbValorUnitItem);
            this.gbItens.Controls.Add(this.btProcuraItem);
            this.gbItens.Controls.Add(this.tbDescItem);
            this.gbItens.Location = new System.Drawing.Point(65, 193);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(993, 326);
            this.gbItens.TabIndex = 1;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens";
            // 
            // tbDescontoItem
            // 
            this.tbDescontoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescontoItem.Location = new System.Drawing.Point(75, 294);
            this.tbDescontoItem.MaxLength = 13;
            this.tbDescontoItem.Name = "tbDescontoItem";
            this.tbDescontoItem.Size = new System.Drawing.Size(63, 20);
            this.tbDescontoItem.TabIndex = 14;
            this.tbDescontoItem.Text = "0,00";
            // 
            // lbDescItem
            // 
            this.lbDescItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescItem.AutoSize = true;
            this.lbDescItem.Location = new System.Drawing.Point(73, 278);
            this.lbDescItem.Name = "lbDescItem";
            this.lbDescItem.Size = new System.Drawing.Size(58, 13);
            this.lbDescItem.TabIndex = 13;
            this.lbDescItem.Text = "Desc. Item";
            // 
            // tbDescontoItemPorc
            // 
            this.tbDescontoItemPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescontoItemPorc.Location = new System.Drawing.Point(6, 294);
            this.tbDescontoItemPorc.MaxLength = 6;
            this.tbDescontoItemPorc.Name = "tbDescontoItemPorc";
            this.tbDescontoItemPorc.Size = new System.Drawing.Size(62, 20);
            this.tbDescontoItemPorc.TabIndex = 12;
            this.tbDescontoItemPorc.Text = "0,00";
            // 
            // lbDescontoPorc
            // 
            this.lbDescontoPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescontoPorc.AutoSize = true;
            this.lbDescontoPorc.Location = new System.Drawing.Point(3, 278);
            this.lbDescontoPorc.Name = "lbDescontoPorc";
            this.lbDescontoPorc.Size = new System.Drawing.Size(46, 13);
            this.lbDescontoPorc.TabIndex = 11;
            this.lbDescontoPorc.Text = "% Desc.";
            // 
            // btNovoItem
            // 
            this.btNovoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovoItem.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btNovoItem.Location = new System.Drawing.Point(963, 19);
            this.btNovoItem.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btNovoItem.Name = "btNovoItem";
            this.btNovoItem.Size = new System.Drawing.Size(24, 24);
            this.btNovoItem.TabIndex = 16;
            this.btNovoItem.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToOrderColumns = true;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItens.Location = new System.Drawing.Point(6, 19);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(955, 172);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.TabStop = false;
            // 
            // btInserirItem
            // 
            this.btInserirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btInserirItem.Location = new System.Drawing.Point(144, 290);
            this.btInserirItem.Name = "btInserirItem";
            this.btInserirItem.Size = new System.Drawing.Size(59, 24);
            this.btInserirItem.TabIndex = 15;
            this.btInserirItem.Text = "Inserir";
            this.btInserirItem.UseVisualStyleBackColor = true;
            // 
            // lbCodItem
            // 
            this.lbCodItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCodItem.AutoSize = true;
            this.lbCodItem.Location = new System.Drawing.Point(6, 194);
            this.lbCodItem.Name = "lbCodItem";
            this.lbCodItem.Size = new System.Drawing.Size(27, 13);
            this.lbCodItem.TabIndex = 1;
            this.lbCodItem.Text = "Item";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbQuantidade.Location = new System.Drawing.Point(6, 257);
            this.tbQuantidade.MaxLength = 8;
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(63, 20);
            this.tbQuantidade.TabIndex = 6;
            this.tbQuantidade.Text = "0,00";
            // 
            // tbValorTotItem
            // 
            this.tbValorTotItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorTotItem.Location = new System.Drawing.Point(144, 257);
            this.tbValorTotItem.MaxLength = 13;
            this.tbValorTotItem.Name = "tbValorTotItem";
            this.tbValorTotItem.Size = new System.Drawing.Size(87, 20);
            this.tbValorTotItem.TabIndex = 10;
            this.tbValorTotItem.Text = "0,00";
            // 
            // lbValorUnit
            // 
            this.lbValorUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorUnit.AutoSize = true;
            this.lbValorUnit.Location = new System.Drawing.Point(72, 241);
            this.lbValorUnit.Name = "lbValorUnit";
            this.lbValorUnit.Size = new System.Drawing.Size(56, 13);
            this.lbValorUnit.TabIndex = 7;
            this.lbValorUnit.Text = "Valor Unit.";
            // 
            // tbCodItem
            // 
            this.tbCodItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodItem.Location = new System.Drawing.Point(6, 210);
            this.tbCodItem.Name = "tbCodItem";
            this.tbCodItem.Size = new System.Drawing.Size(63, 20);
            this.tbCodItem.TabIndex = 2;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(6, 241);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 5;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbValorTot
            // 
            this.lbValorTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorTot.AutoSize = true;
            this.lbValorTot.Location = new System.Drawing.Point(141, 241);
            this.lbValorTot.Name = "lbValorTot";
            this.lbValorTot.Size = new System.Drawing.Size(53, 13);
            this.lbValorTot.TabIndex = 9;
            this.lbValorTot.Text = "Valor Tot.";
            // 
            // tbValorUnitItem
            // 
            this.tbValorUnitItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorUnitItem.Location = new System.Drawing.Point(75, 257);
            this.tbValorUnitItem.MaxLength = 13;
            this.tbValorUnitItem.Name = "tbValorUnitItem";
            this.tbValorUnitItem.Size = new System.Drawing.Size(63, 20);
            this.tbValorUnitItem.TabIndex = 8;
            this.tbValorUnitItem.Text = "0,00";
            // 
            // btProcuraItem
            // 
            this.btProcuraItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btProcuraItem.Location = new System.Drawing.Point(71, 210);
            this.btProcuraItem.Name = "btProcuraItem";
            this.btProcuraItem.Size = new System.Drawing.Size(20, 20);
            this.btProcuraItem.TabIndex = 3;
            this.btProcuraItem.TabStop = false;
            this.btProcuraItem.UseVisualStyleBackColor = true;
            // 
            // tbDescItem
            // 
            this.tbDescItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDescItem.Location = new System.Drawing.Point(93, 210);
            this.tbDescItem.Name = "tbDescItem";
            this.tbDescItem.ReadOnly = true;
            this.tbDescItem.Size = new System.Drawing.Size(355, 20);
            this.tbDescItem.TabIndex = 4;
            // 
            // fmEstoqueEntradaDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 571);
            this.Controls.Add(this.gbTotais);
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.gbDadosDocumento);
            this.Controls.Add(this.pnBotoes);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1255, 610);
            this.Name = "fmEstoqueEntradaDocumentos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Entrada de documentos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmEstoqueEntradaDocumentos_KeyDown);
            this.pnBotoes.ResumeLayout(false);
            this.gbDadosDocumento.ResumeLayout(false);
            this.gbDadosDocumento.PerformLayout();
            this.gbTotais.ResumeLayout(false);
            this.gbTotais.PerformLayout();
            this.gbItens.ResumeLayout(false);
            this.gbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btRecarregar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.GroupBox gbDadosDocumento;
        private System.Windows.Forms.TextBox tbNomeFornecedor;
        private System.Windows.Forms.Button btProcuraFornecedor;
        private System.Windows.Forms.TextBox tbCodFornecedor;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.Label lbEntrada;
        private System.Windows.Forms.Label lbEmissao;
        private System.Windows.Forms.GroupBox gbTotais;
        private System.Windows.Forms.TextBox tbDescontoDocumento;
        private System.Windows.Forms.Label lbDescontoDocumento;
        private System.Windows.Forms.TextBox tbDescontoTotalItens;
        private System.Windows.Forms.Label lbDescontoTotalItens;
        private System.Windows.Forms.TextBox tbValorTotalDocumento;
        private System.Windows.Forms.Label lbValorTotalDocumento;
        private System.Windows.Forms.Label lbTotalItens;
        private System.Windows.Forms.TextBox tbValorTotalItens;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.TextBox tbDescontoItem;
        private System.Windows.Forms.Label lbDescItem;
        private System.Windows.Forms.TextBox tbDescontoItemPorc;
        private System.Windows.Forms.Label lbDescontoPorc;
        private System.Windows.Forms.Button btNovoItem;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btInserirItem;
        private System.Windows.Forms.Label lbCodItem;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbValorTotItem;
        private System.Windows.Forms.Label lbValorUnit;
        private System.Windows.Forms.TextBox tbCodItem;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbValorTot;
        private System.Windows.Forms.TextBox tbValorUnitItem;
        private System.Windows.Forms.Button btProcuraItem;
        private System.Windows.Forms.TextBox tbDescItem;
    }
}