namespace _5gpro.Forms
{
    partial class fmCadastroOrcamento
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
            this.gbDadosOrcamento = new System.Windows.Forms.GroupBox();
            this.cbVencimento = new System.Windows.Forms.CheckBox();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.lbVencimento = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.btProcuraCliente = new System.Windows.Forms.Button();
            this.tbCodCliente = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lbValorUnit = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.tbValorUnitItem = new System.Windows.Forms.TextBox();
            this.tbDescItem = new System.Windows.Forms.TextBox();
            this.btProcuraItem = new System.Windows.Forms.Button();
            this.lbValorTot = new System.Windows.Forms.Label();
            this.tbCodItem = new System.Windows.Forms.TextBox();
            this.tbValorTotItem = new System.Windows.Forms.TextBox();
            this.lbCodItem = new System.Windows.Forms.Label();
            this.btInserirItem = new System.Windows.Forms.Button();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.tbDescontoItem = new System.Windows.Forms.TextBox();
            this.lbDescItem = new System.Windows.Forms.Label();
            this.tbDescontoItemPorc = new System.Windows.Forms.TextBox();
            this.lbDescontoPorc = new System.Windows.Forms.Label();
            this.btAutoriza = new System.Windows.Forms.Button();
            this.btNovoItem = new System.Windows.Forms.Button();
            this.lbTotalItens = new System.Windows.Forms.Label();
            this.tbTotalItens = new System.Windows.Forms.TextBox();
            this.gbTotais = new System.Windows.Forms.GroupBox();
            this.tbDescontoOrcamento = new System.Windows.Forms.TextBox();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.tbDescontoTotalItens = new System.Windows.Forms.TextBox();
            this.lbDescontoTotalItens = new System.Windows.Forms.Label();
            this.tbTotalOrcamento = new System.Windows.Forms.TextBox();
            this.lbTotalOrcamento = new System.Windows.Forms.Label();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.gbDadosOrcamento.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbItens.SuspendLayout();
            this.gbTotais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosOrcamento
            // 
            this.gbDadosOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosOrcamento.Controls.Add(this.cbVencimento);
            this.gbDadosOrcamento.Controls.Add(this.dtpVencimento);
            this.gbDadosOrcamento.Controls.Add(this.dtpCadastro);
            this.gbDadosOrcamento.Controls.Add(this.lbVencimento);
            this.gbDadosOrcamento.Controls.Add(this.lbCadastro);
            this.gbDadosOrcamento.Controls.Add(this.tbNomeCliente);
            this.gbDadosOrcamento.Controls.Add(this.btProcuraCliente);
            this.gbDadosOrcamento.Controls.Add(this.tbCodCliente);
            this.gbDadosOrcamento.Controls.Add(this.lbCliente);
            this.gbDadosOrcamento.Controls.Add(this.tbCodigo);
            this.gbDadosOrcamento.Controls.Add(this.lbCodigo);
            this.gbDadosOrcamento.Location = new System.Drawing.Point(65, 12);
            this.gbDadosOrcamento.Name = "gbDadosOrcamento";
            this.gbDadosOrcamento.Size = new System.Drawing.Size(1162, 182);
            this.gbDadosOrcamento.TabIndex = 0;
            this.gbDadosOrcamento.TabStop = false;
            this.gbDadosOrcamento.Text = "Dados do orçamento";
            // 
            // cbVencimento
            // 
            this.cbVencimento.AutoSize = true;
            this.cbVencimento.Location = new System.Drawing.Point(114, 160);
            this.cbVencimento.Name = "cbVencimento";
            this.cbVencimento.Size = new System.Drawing.Size(15, 14);
            this.cbVencimento.TabIndex = 8;
            this.cbVencimento.TabStop = false;
            this.cbVencimento.UseVisualStyleBackColor = true;
            this.cbVencimento.CheckedChanged += new System.EventHandler(this.cbVencimento_CheckedChanged);
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Enabled = false;
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(10, 156);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(99, 20);
            this.dtpVencimento.TabIndex = 7;
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCadastro.Location = new System.Drawing.Point(9, 117);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(100, 20);
            this.dtpCadastro.TabIndex = 5;
            this.dtpCadastro.Value = new System.DateTime(2019, 3, 27, 0, 0, 0, 0);
            this.dtpCadastro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpCadastro_KeyUp);
            // 
            // lbVencimento
            // 
            this.lbVencimento.AutoSize = true;
            this.lbVencimento.Location = new System.Drawing.Point(6, 140);
            this.lbVencimento.Name = "lbVencimento";
            this.lbVencimento.Size = new System.Drawing.Size(103, 13);
            this.lbVencimento.TabIndex = 6;
            this.lbVencimento.Text = "Data do vencimento";
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.Location = new System.Drawing.Point(6, 98);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(89, 13);
            this.lbCadastro.TabIndex = 4;
            this.lbCadastro.Text = "Data do cadastro";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNomeCliente.Location = new System.Drawing.Point(98, 74);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(355, 20);
            this.tbNomeCliente.TabIndex = 10;
            this.tbNomeCliente.TabStop = false;
            // 
            // btProcuraCliente
            // 
            this.btProcuraCliente.Location = new System.Drawing.Point(76, 74);
            this.btProcuraCliente.Name = "btProcuraCliente";
            this.btProcuraCliente.Size = new System.Drawing.Size(20, 20);
            this.btProcuraCliente.TabIndex = 9;
            this.btProcuraCliente.TabStop = false;
            this.btProcuraCliente.UseVisualStyleBackColor = true;
            // 
            // tbCodCliente
            // 
            this.tbCodCliente.Location = new System.Drawing.Point(9, 75);
            this.tbCodCliente.Name = "tbCodCliente";
            this.tbCodCliente.Size = new System.Drawing.Size(65, 20);
            this.tbCodCliente.TabIndex = 3;
            this.tbCodCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCliente_KeyUp);
            this.tbCodCliente.Leave += new System.EventHandler(this.tbCodCliente_Leave);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(6, 59);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 2;
            this.lbCliente.Text = "Cliente";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(9, 36);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(65, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(6, 20);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
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
            this.pnBotoes.Location = new System.Drawing.Point(4, 11);
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
            this.dgvItens.Size = new System.Drawing.Size(955, 179);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.TabStop = false;
            this.dgvItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellClick);
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbQuantidade.Location = new System.Drawing.Point(6, 264);
            this.tbQuantidade.MaxLength = 8;
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(63, 20);
            this.tbQuantidade.TabIndex = 4;
            this.tbQuantidade.Text = "0,00";
            this.tbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantidade_KeyPress);
            this.tbQuantidade.Leave += new System.EventHandler(this.tbQuantidade_Leave);
            // 
            // lbValorUnit
            // 
            this.lbValorUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorUnit.AutoSize = true;
            this.lbValorUnit.Location = new System.Drawing.Point(72, 248);
            this.lbValorUnit.Name = "lbValorUnit";
            this.lbValorUnit.Size = new System.Drawing.Size(56, 13);
            this.lbValorUnit.TabIndex = 5;
            this.lbValorUnit.Text = "Valor Unit.";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(6, 248);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 3;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // tbValorUnitItem
            // 
            this.tbValorUnitItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorUnitItem.Location = new System.Drawing.Point(75, 264);
            this.tbValorUnitItem.MaxLength = 13;
            this.tbValorUnitItem.Name = "tbValorUnitItem";
            this.tbValorUnitItem.Size = new System.Drawing.Size(63, 20);
            this.tbValorUnitItem.TabIndex = 6;
            this.tbValorUnitItem.Text = "0,00";
            this.tbValorUnitItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorUnitItem_KeyPress);
            this.tbValorUnitItem.Leave += new System.EventHandler(this.tbValorUnitItem_Leave);
            // 
            // tbDescItem
            // 
            this.tbDescItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDescItem.Location = new System.Drawing.Point(93, 217);
            this.tbDescItem.Name = "tbDescItem";
            this.tbDescItem.ReadOnly = true;
            this.tbDescItem.Size = new System.Drawing.Size(355, 20);
            this.tbDescItem.TabIndex = 13;
            // 
            // btProcuraItem
            // 
            this.btProcuraItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btProcuraItem.Location = new System.Drawing.Point(71, 217);
            this.btProcuraItem.Name = "btProcuraItem";
            this.btProcuraItem.Size = new System.Drawing.Size(20, 20);
            this.btProcuraItem.TabIndex = 12;
            this.btProcuraItem.TabStop = false;
            this.btProcuraItem.UseVisualStyleBackColor = true;
            // 
            // lbValorTot
            // 
            this.lbValorTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbValorTot.AutoSize = true;
            this.lbValorTot.Location = new System.Drawing.Point(141, 248);
            this.lbValorTot.Name = "lbValorTot";
            this.lbValorTot.Size = new System.Drawing.Size(53, 13);
            this.lbValorTot.TabIndex = 7;
            this.lbValorTot.Text = "Valor Tot.";
            // 
            // tbCodItem
            // 
            this.tbCodItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCodItem.Location = new System.Drawing.Point(6, 217);
            this.tbCodItem.Name = "tbCodItem";
            this.tbCodItem.Size = new System.Drawing.Size(63, 20);
            this.tbCodItem.TabIndex = 2;
            this.tbCodItem.Leave += new System.EventHandler(this.tbCodItem_Leave);
            // 
            // tbValorTotItem
            // 
            this.tbValorTotItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbValorTotItem.Location = new System.Drawing.Point(144, 264);
            this.tbValorTotItem.MaxLength = 13;
            this.tbValorTotItem.Name = "tbValorTotItem";
            this.tbValorTotItem.Size = new System.Drawing.Size(87, 20);
            this.tbValorTotItem.TabIndex = 8;
            this.tbValorTotItem.Text = "0,00";
            this.tbValorTotItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorTotItem_KeyPress);
            this.tbValorTotItem.Leave += new System.EventHandler(this.tbValorTotItem_Leave);
            // 
            // lbCodItem
            // 
            this.lbCodItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCodItem.AutoSize = true;
            this.lbCodItem.Location = new System.Drawing.Point(6, 201);
            this.lbCodItem.Name = "lbCodItem";
            this.lbCodItem.Size = new System.Drawing.Size(27, 13);
            this.lbCodItem.TabIndex = 1;
            this.lbCodItem.Text = "Item";
            // 
            // btInserirItem
            // 
            this.btInserirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btInserirItem.Location = new System.Drawing.Point(144, 297);
            this.btInserirItem.Name = "btInserirItem";
            this.btInserirItem.Size = new System.Drawing.Size(59, 24);
            this.btInserirItem.TabIndex = 13;
            this.btInserirItem.Text = "Inserir";
            this.btInserirItem.UseVisualStyleBackColor = true;
            this.btInserirItem.Click += new System.EventHandler(this.btInserirItem_Click);
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
            this.gbItens.Controls.Add(this.btAutoriza);
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
            this.gbItens.Location = new System.Drawing.Point(65, 200);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(993, 333);
            this.gbItens.TabIndex = 1;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens";
            // 
            // tbDescontoItem
            // 
            this.tbDescontoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescontoItem.Location = new System.Drawing.Point(75, 301);
            this.tbDescontoItem.MaxLength = 13;
            this.tbDescontoItem.Name = "tbDescontoItem";
            this.tbDescontoItem.Size = new System.Drawing.Size(63, 20);
            this.tbDescontoItem.TabIndex = 12;
            this.tbDescontoItem.Text = "0,00";
            this.tbDescontoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescontoItem_KeyPress);
            this.tbDescontoItem.Leave += new System.EventHandler(this.tbDescontoItem_Leave);
            // 
            // lbDescItem
            // 
            this.lbDescItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescItem.AutoSize = true;
            this.lbDescItem.Location = new System.Drawing.Point(73, 285);
            this.lbDescItem.Name = "lbDescItem";
            this.lbDescItem.Size = new System.Drawing.Size(58, 13);
            this.lbDescItem.TabIndex = 11;
            this.lbDescItem.Text = "Desc. Item";
            // 
            // tbDescontoItemPorc
            // 
            this.tbDescontoItemPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescontoItemPorc.Location = new System.Drawing.Point(6, 301);
            this.tbDescontoItemPorc.MaxLength = 6;
            this.tbDescontoItemPorc.Name = "tbDescontoItemPorc";
            this.tbDescontoItemPorc.Size = new System.Drawing.Size(62, 20);
            this.tbDescontoItemPorc.TabIndex = 10;
            this.tbDescontoItemPorc.Text = "0,00";
            this.tbDescontoItemPorc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescontoItemPorc_KeyPress);
            this.tbDescontoItemPorc.Leave += new System.EventHandler(this.tbDescontoItemPorc_Leave);
            // 
            // lbDescontoPorc
            // 
            this.lbDescontoPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDescontoPorc.AutoSize = true;
            this.lbDescontoPorc.Location = new System.Drawing.Point(3, 285);
            this.lbDescontoPorc.Name = "lbDescontoPorc";
            this.lbDescontoPorc.Size = new System.Drawing.Size(46, 13);
            this.lbDescontoPorc.TabIndex = 9;
            this.lbDescontoPorc.Text = "% Desc.";
            // 
            // btAutoriza
            // 
            this.btAutoriza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAutoriza.Image = global::_5gpro.Properties.Resources.iosOk_22px_Green;
            this.btAutoriza.Location = new System.Drawing.Point(963, 49);
            this.btAutoriza.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btAutoriza.Name = "btAutoriza";
            this.btAutoriza.Size = new System.Drawing.Size(24, 24);
            this.btAutoriza.TabIndex = 15;
            this.btAutoriza.UseVisualStyleBackColor = true;
            this.btAutoriza.Visible = false;
            // 
            // btNovoItem
            // 
            this.btNovoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovoItem.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btNovoItem.Location = new System.Drawing.Point(963, 19);
            this.btNovoItem.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btNovoItem.Name = "btNovoItem";
            this.btNovoItem.Size = new System.Drawing.Size(24, 24);
            this.btNovoItem.TabIndex = 14;
            this.btNovoItem.UseVisualStyleBackColor = true;
            this.btNovoItem.Click += new System.EventHandler(this.btNovoItem_Click);
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
            // tbTotalItens
            // 
            this.tbTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalItens.Location = new System.Drawing.Point(9, 35);
            this.tbTotalItens.Name = "tbTotalItens";
            this.tbTotalItens.ReadOnly = true;
            this.tbTotalItens.Size = new System.Drawing.Size(85, 20);
            this.tbTotalItens.TabIndex = 1;
            this.tbTotalItens.TabStop = false;
            this.tbTotalItens.Text = "0,00";
            // 
            // gbTotais
            // 
            this.gbTotais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotais.Controls.Add(this.tbDescontoOrcamento);
            this.gbTotais.Controls.Add(this.lbDesconto);
            this.gbTotais.Controls.Add(this.tbDescontoTotalItens);
            this.gbTotais.Controls.Add(this.lbDescontoTotalItens);
            this.gbTotais.Controls.Add(this.tbTotalOrcamento);
            this.gbTotais.Controls.Add(this.lbTotalOrcamento);
            this.gbTotais.Controls.Add(this.lbTotalItens);
            this.gbTotais.Controls.Add(this.tbTotalItens);
            this.gbTotais.Location = new System.Drawing.Point(1064, 200);
            this.gbTotais.MinimumSize = new System.Drawing.Size(163, 326);
            this.gbTotais.Name = "gbTotais";
            this.gbTotais.Size = new System.Drawing.Size(163, 375);
            this.gbTotais.TabIndex = 2;
            this.gbTotais.TabStop = false;
            this.gbTotais.Text = "Totais";
            // 
            // tbDescontoOrcamento
            // 
            this.tbDescontoOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescontoOrcamento.Location = new System.Drawing.Point(9, 113);
            this.tbDescontoOrcamento.Name = "tbDescontoOrcamento";
            this.tbDescontoOrcamento.Size = new System.Drawing.Size(85, 20);
            this.tbDescontoOrcamento.TabIndex = 5;
            this.tbDescontoOrcamento.Text = "0,00";
            // 
            // lbDesconto
            // 
            this.lbDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(6, 97);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(121, 13);
            this.lbDesconto.TabIndex = 4;
            this.lbDesconto.Text = "Desconto do orçamento";
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
            // tbTotalOrcamento
            // 
            this.tbTotalOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalOrcamento.Location = new System.Drawing.Point(8, 152);
            this.tbTotalOrcamento.Name = "tbTotalOrcamento";
            this.tbTotalOrcamento.Size = new System.Drawing.Size(85, 20);
            this.tbTotalOrcamento.TabIndex = 7;
            this.tbTotalOrcamento.Text = "0,00";
            // 
            // lbTotalOrcamento
            // 
            this.lbTotalOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalOrcamento.AutoSize = true;
            this.lbTotalOrcamento.Location = new System.Drawing.Point(5, 136);
            this.lbTotalOrcamento.Name = "lbTotalOrcamento";
            this.lbTotalOrcamento.Size = new System.Drawing.Size(122, 13);
            this.lbTotalOrcamento.TabIndex = 6;
            this.lbTotalOrcamento.Text = "Valor total do orçamento";
            // 
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(65, 539);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.ReadOnly = true;
            this.tbAjuda.Size = new System.Drawing.Size(993, 20);
            this.tbAjuda.TabIndex = 16;
            // 
            // fmCadastroOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 581);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.gbTotais);
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.gbDadosOrcamento);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1255, 570);
            this.Name = "fmCadastroOrcamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Orçamentos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmCadastroOrcamento_KeyDown);
            this.gbDadosOrcamento.ResumeLayout(false);
            this.gbDadosOrcamento.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbItens.ResumeLayout(false);
            this.gbItens.PerformLayout();
            this.gbTotais.ResumeLayout(false);
            this.gbTotais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosOrcamento;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btRecarregar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Button btProcuraCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodCliente;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.Label lbVencimento;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.CheckBox cbVencimento;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lbValorUnit;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox tbValorUnitItem;
        private System.Windows.Forms.TextBox tbDescItem;
        private System.Windows.Forms.Button btProcuraItem;
        private System.Windows.Forms.Label lbValorTot;
        private System.Windows.Forms.TextBox tbCodItem;
        private System.Windows.Forms.TextBox tbValorTotItem;
        private System.Windows.Forms.Label lbCodItem;
        private System.Windows.Forms.Button btInserirItem;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.Button btNovoItem;
        private System.Windows.Forms.Label lbTotalItens;
        private System.Windows.Forms.TextBox tbTotalItens;
        private System.Windows.Forms.GroupBox gbTotais;
        private System.Windows.Forms.TextBox tbTotalOrcamento;
        private System.Windows.Forms.Label lbTotalOrcamento;
        private System.Windows.Forms.Button btAutoriza;
        private System.Windows.Forms.TextBox tbDescontoOrcamento;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.TextBox tbDescontoTotalItens;
        private System.Windows.Forms.Label lbDescontoTotalItens;
        private System.Windows.Forms.Label lbDescontoPorc;
        private System.Windows.Forms.TextBox tbDescontoItem;
        private System.Windows.Forms.Label lbDescItem;
        private System.Windows.Forms.TextBox tbDescontoItemPorc;
        private System.Windows.Forms.TextBox tbAjuda;
    }
}