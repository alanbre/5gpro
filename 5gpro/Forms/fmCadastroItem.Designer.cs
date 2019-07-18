namespace _5gpro.Forms
{
    partial class fmCadastroItem
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
            this.gbDesintegracao = new System.Windows.Forms.GroupBox();
            this.btConfigDesintegracao = new System.Windows.Forms.Button();
            this.rbDesiNao = new System.Windows.Forms.RadioButton();
            this.rbDesiSim = new System.Windows.Forms.RadioButton();
            this.btAddUnimedida = new System.Windows.Forms.Button();
            this.dbQuantidade = new _5gpro.Controls.DecimalBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.buscaSubGrupoItem = new _5gpro.Controls.BuscaSubGrupoItem();
            this.buscaGrupoItem = new _5gpro.Controls.BuscaGrupoItem();
            this.buscaUnimedidaItem = new _5gpro.Controls.BuscaUnimedida();
            this.gbTipoDeItem = new System.Windows.Forms.GroupBox();
            this.rbServico = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.tbDescricaoDeCompra = new System.Windows.Forms.TextBox();
            this.lbDescricaoFornecedor = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.tpValores = new System.Windows.Forms.TabPage();
            this.btCalcular = new System.Windows.Forms.Button();
            this.dbValorEntrada = new _5gpro.Controls.DecimalBox();
            this.lbValorEntrada = new System.Windows.Forms.Label();
            this.dbPrecoVenda = new _5gpro.Controls.DecimalBox();
            this.lbPrecoVenda = new System.Windows.Forms.Label();
            this.dbEstoqueNecessario = new _5gpro.Controls.DecimalBox();
            this.lbEstoqueNecessario = new System.Windows.Forms.Label();
            this.tcItens = new System.Windows.Forms.TabControl();
            this.pnDadosGerais.SuspendLayout();
            this.gbDesintegracao.SuspendLayout();
            this.gbTipoDeItem.SuspendLayout();
            this.tpValores.SuspendLayout();
            this.tcItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDadosGerais
            // 
            this.pnDadosGerais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDadosGerais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDadosGerais.Controls.Add(this.gbDesintegracao);
            this.pnDadosGerais.Controls.Add(this.btAddUnimedida);
            this.pnDadosGerais.Controls.Add(this.dbQuantidade);
            this.pnDadosGerais.Controls.Add(this.lbQuantidade);
            this.pnDadosGerais.Controls.Add(this.buscaSubGrupoItem);
            this.pnDadosGerais.Controls.Add(this.buscaGrupoItem);
            this.pnDadosGerais.Controls.Add(this.buscaUnimedidaItem);
            this.pnDadosGerais.Controls.Add(this.gbTipoDeItem);
            this.pnDadosGerais.Controls.Add(this.tbReferencia);
            this.pnDadosGerais.Controls.Add(this.lbReferencia);
            this.pnDadosGerais.Controls.Add(this.tbDescricaoDeCompra);
            this.pnDadosGerais.Controls.Add(this.lbDescricaoFornecedor);
            this.pnDadosGerais.Controls.Add(this.tbDescricao);
            this.pnDadosGerais.Controls.Add(this.lbDescricao);
            this.pnDadosGerais.Controls.Add(this.tbCodigo);
            this.pnDadosGerais.Controls.Add(this.lbCodigo);
            this.pnDadosGerais.Location = new System.Drawing.Point(74, 13);
            this.pnDadosGerais.Name = "pnDadosGerais";
            this.pnDadosGerais.Size = new System.Drawing.Size(565, 364);
            this.pnDadosGerais.TabIndex = 0;
            // 
            // gbDesintegracao
            // 
            this.gbDesintegracao.Controls.Add(this.btConfigDesintegracao);
            this.gbDesintegracao.Controls.Add(this.rbDesiNao);
            this.gbDesintegracao.Controls.Add(this.rbDesiSim);
            this.gbDesintegracao.Enabled = false;
            this.gbDesintegracao.Location = new System.Drawing.Point(372, 186);
            this.gbDesintegracao.Name = "gbDesintegracao";
            this.gbDesintegracao.Size = new System.Drawing.Size(105, 72);
            this.gbDesintegracao.TabIndex = 27;
            this.gbDesintegracao.TabStop = false;
            this.gbDesintegracao.Text = "Desintegração";
            // 
            // btConfigDesintegracao
            // 
            this.btConfigDesintegracao.Enabled = false;
            this.btConfigDesintegracao.Location = new System.Drawing.Point(6, 43);
            this.btConfigDesintegracao.Name = "btConfigDesintegracao";
            this.btConfigDesintegracao.Size = new System.Drawing.Size(93, 23);
            this.btConfigDesintegracao.TabIndex = 28;
            this.btConfigDesintegracao.Text = "Configurar";
            this.btConfigDesintegracao.UseVisualStyleBackColor = true;
            this.btConfigDesintegracao.Click += new System.EventHandler(this.BtConfigDesintegracao_Click);
            // 
            // rbDesiNao
            // 
            this.rbDesiNao.AutoSize = true;
            this.rbDesiNao.Checked = true;
            this.rbDesiNao.Location = new System.Drawing.Point(54, 22);
            this.rbDesiNao.Name = "rbDesiNao";
            this.rbDesiNao.Size = new System.Drawing.Size(45, 17);
            this.rbDesiNao.TabIndex = 1;
            this.rbDesiNao.TabStop = true;
            this.rbDesiNao.Text = "Não";
            this.rbDesiNao.UseVisualStyleBackColor = true;
            this.rbDesiNao.CheckedChanged += new System.EventHandler(this.RbDesiNao_CheckedChanged);
            // 
            // rbDesiSim
            // 
            this.rbDesiSim.AutoSize = true;
            this.rbDesiSim.Location = new System.Drawing.Point(6, 22);
            this.rbDesiSim.Name = "rbDesiSim";
            this.rbDesiSim.Size = new System.Drawing.Size(42, 17);
            this.rbDesiSim.TabIndex = 0;
            this.rbDesiSim.Text = "Sim";
            this.rbDesiSim.UseVisualStyleBackColor = true;
            this.rbDesiSim.CheckedChanged += new System.EventHandler(this.RbDesiSim_CheckedChanged);
            // 
            // btAddUnimedida
            // 
            this.btAddUnimedida.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btAddUnimedida.Location = new System.Drawing.Point(327, 151);
            this.btAddUnimedida.Name = "btAddUnimedida";
            this.btAddUnimedida.Size = new System.Drawing.Size(22, 22);
            this.btAddUnimedida.TabIndex = 26;
            this.btAddUnimedida.TabStop = false;
            this.btAddUnimedida.UseVisualStyleBackColor = true;
            this.btAddUnimedida.Click += new System.EventHandler(this.BtAddUnimedida_Click);
            // 
            // dbQuantidade
            // 
            this.dbQuantidade.Enabled = false;
            this.dbQuantidade.Location = new System.Drawing.Point(16, 197);
            this.dbQuantidade.Name = "dbQuantidade";
            this.dbQuantidade.Size = new System.Drawing.Size(79, 22);
            this.dbQuantidade.TabIndex = 9;
            this.dbQuantidade.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(13, 181);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 8;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // buscaSubGrupoItem
            // 
            this.buscaSubGrupoItem.Location = new System.Drawing.Point(12, 309);
            this.buscaSubGrupoItem.Name = "buscaSubGrupoItem";
            this.buscaSubGrupoItem.Size = new System.Drawing.Size(465, 39);
            this.buscaSubGrupoItem.TabIndex = 13;
            this.buscaSubGrupoItem.Text_Changed += new _5gpro.Controls.BuscaSubGrupoItem.text_changedEventHandler(this.BuscaSubGrupoItem_Text_Changed);
            // 
            // buscaGrupoItem
            // 
            this.buscaGrupoItem.Location = new System.Drawing.Point(12, 264);
            this.buscaGrupoItem.Name = "buscaGrupoItem";
            this.buscaGrupoItem.Size = new System.Drawing.Size(465, 39);
            this.buscaGrupoItem.TabIndex = 12;
            this.buscaGrupoItem.Text_Changed += new _5gpro.Controls.BuscaGrupoItem.text_changedEventHandler(this.BuscaGrupoItem_Text_Changed);
            this.buscaGrupoItem.Leave += new System.EventHandler(this.BuscaGrupoItemTelaCadItem_Leave);
            // 
            // buscaUnimedidaItem
            // 
            this.buscaUnimedidaItem.Location = new System.Drawing.Point(9, 135);
            this.buscaUnimedidaItem.Name = "buscaUnimedidaItem";
            this.buscaUnimedidaItem.Size = new System.Drawing.Size(319, 39);
            this.buscaUnimedidaItem.TabIndex = 6;
            this.buscaUnimedidaItem.Text_Changed += new _5gpro.Controls.BuscaUnimedida.text_changedEventHandler(this.BuscaUnimedidaItem_Text_Changed);
            // 
            // gbTipoDeItem
            // 
            this.gbTipoDeItem.Controls.Add(this.rbServico);
            this.gbTipoDeItem.Controls.Add(this.rbProduto);
            this.gbTipoDeItem.Location = new System.Drawing.Point(372, 135);
            this.gbTipoDeItem.Name = "gbTipoDeItem";
            this.gbTipoDeItem.Size = new System.Drawing.Size(131, 45);
            this.gbTipoDeItem.TabIndex = 7;
            this.gbTipoDeItem.TabStop = false;
            this.gbTipoDeItem.Text = "Tipo de item";
            // 
            // rbServico
            // 
            this.rbServico.AutoSize = true;
            this.rbServico.Location = new System.Drawing.Point(68, 19);
            this.rbServico.Name = "rbServico";
            this.rbServico.Size = new System.Drawing.Size(61, 17);
            this.rbServico.TabIndex = 1;
            this.rbServico.Text = "Serviço";
            this.rbServico.UseVisualStyleBackColor = true;
            this.rbServico.CheckedChanged += new System.EventHandler(this.RbServico_CheckedChanged);
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Checked = true;
            this.rbProduto.Location = new System.Drawing.Point(6, 19);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(62, 17);
            this.rbProduto.TabIndex = 0;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            this.rbProduto.CheckedChanged += new System.EventHandler(this.RbProduto_CheckedChanged);
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(16, 238);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(308, 20);
            this.tbReferencia.TabIndex = 11;
            this.tbReferencia.TextChanged += new System.EventHandler(this.TbReferencia_TextChanged);
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(13, 222);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(59, 13);
            this.lbReferencia.TabIndex = 10;
            this.lbReferencia.Text = "Referência";
            // 
            // tbDescricaoDeCompra
            // 
            this.tbDescricaoDeCompra.Location = new System.Drawing.Point(15, 108);
            this.tbDescricaoDeCompra.MaxLength = 255;
            this.tbDescricaoDeCompra.Name = "tbDescricaoDeCompra";
            this.tbDescricaoDeCompra.Size = new System.Drawing.Size(528, 20);
            this.tbDescricaoDeCompra.TabIndex = 5;
            this.tbDescricaoDeCompra.TextChanged += new System.EventHandler(this.TbDescricaoDeCompra_TextChanged);
            // 
            // lbDescricaoFornecedor
            // 
            this.lbDescricaoFornecedor.AutoSize = true;
            this.lbDescricaoFornecedor.Location = new System.Drawing.Point(13, 88);
            this.lbDescricaoFornecedor.Name = "lbDescricaoFornecedor";
            this.lbDescricaoFornecedor.Size = new System.Drawing.Size(108, 13);
            this.lbDescricaoFornecedor.TabIndex = 4;
            this.lbDescricaoFornecedor.Text = "Descrição de compra";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(16, 65);
            this.tbDescricao.MaxLength = 255;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(527, 20);
            this.tbDescricao.TabIndex = 3;
            this.tbDescricao.TextChanged += new System.EventHandler(this.TbDescricao_TextChanged);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(13, 49);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(92, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição do item";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(16, 26);
            this.tbCodigo.MaxLength = 5;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(79, 20);
            this.tbCodigo.TabIndex = 1;
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
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.Enabled = false;
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(74, 507);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.Size = new System.Drawing.Size(561, 20);
            this.tbAjuda.TabIndex = 3;
            this.tbAjuda.TabStop = false;
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 12);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 2;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical_Proximo_Clicked);
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical_Excluir_Clicked);
            // 
            // tpValores
            // 
            this.tpValores.AutoScroll = true;
            this.tpValores.BackColor = System.Drawing.Color.White;
            this.tpValores.Controls.Add(this.btCalcular);
            this.tpValores.Controls.Add(this.dbValorEntrada);
            this.tpValores.Controls.Add(this.lbValorEntrada);
            this.tpValores.Controls.Add(this.dbPrecoVenda);
            this.tpValores.Controls.Add(this.lbPrecoVenda);
            this.tpValores.Controls.Add(this.dbEstoqueNecessario);
            this.tpValores.Controls.Add(this.lbEstoqueNecessario);
            this.tpValores.Location = new System.Drawing.Point(4, 22);
            this.tpValores.Name = "tpValores";
            this.tpValores.Padding = new System.Windows.Forms.Padding(3);
            this.tpValores.Size = new System.Drawing.Size(557, 97);
            this.tpValores.TabIndex = 0;
            this.tpValores.Text = "Valores";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(208, 28);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(55, 23);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // dbValorEntrada
            // 
            this.dbValorEntrada.Location = new System.Drawing.Point(9, 28);
            this.dbValorEntrada.Name = "dbValorEntrada";
            this.dbValorEntrada.Size = new System.Drawing.Size(86, 22);
            this.dbValorEntrada.TabIndex = 2;
            this.dbValorEntrada.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbValorEntrada.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbCusto_Valor_Changed);
            // 
            // lbValorEntrada
            // 
            this.lbValorEntrada.AutoSize = true;
            this.lbValorEntrada.Location = new System.Drawing.Point(9, 12);
            this.lbValorEntrada.Name = "lbValorEntrada";
            this.lbValorEntrada.Size = new System.Drawing.Size(85, 13);
            this.lbValorEntrada.TabIndex = 1;
            this.lbValorEntrada.Text = "Valor de entrada";
            // 
            // dbPrecoVenda
            // 
            this.dbPrecoVenda.Location = new System.Drawing.Point(116, 28);
            this.dbPrecoVenda.Name = "dbPrecoVenda";
            this.dbPrecoVenda.Size = new System.Drawing.Size(86, 22);
            this.dbPrecoVenda.TabIndex = 4;
            this.dbPrecoVenda.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbPrecoVenda.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbPrecoVenda_Valor_Changed);
            // 
            // lbPrecoVenda
            // 
            this.lbPrecoVenda.AutoSize = true;
            this.lbPrecoVenda.Location = new System.Drawing.Point(113, 12);
            this.lbPrecoVenda.Name = "lbPrecoVenda";
            this.lbPrecoVenda.Size = new System.Drawing.Size(83, 13);
            this.lbPrecoVenda.TabIndex = 3;
            this.lbPrecoVenda.Text = "Preço de venda";
            // 
            // dbEstoqueNecessario
            // 
            this.dbEstoqueNecessario.Location = new System.Drawing.Point(9, 69);
            this.dbEstoqueNecessario.Name = "dbEstoqueNecessario";
            this.dbEstoqueNecessario.Size = new System.Drawing.Size(86, 22);
            this.dbEstoqueNecessario.TabIndex = 6;
            this.dbEstoqueNecessario.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbEstoqueNecessario.Valor_Changed += new _5gpro.Controls.DecimalBox.valor_changedEventHandler(this.DbEstoqueNecessario_Valor_Changed);
            // 
            // lbEstoqueNecessario
            // 
            this.lbEstoqueNecessario.AutoSize = true;
            this.lbEstoqueNecessario.Location = new System.Drawing.Point(9, 53);
            this.lbEstoqueNecessario.Name = "lbEstoqueNecessario";
            this.lbEstoqueNecessario.Size = new System.Drawing.Size(100, 13);
            this.lbEstoqueNecessario.TabIndex = 6;
            this.lbEstoqueNecessario.Text = "Estoque necessário";
            // 
            // tcItens
            // 
            this.tcItens.Controls.Add(this.tpValores);
            this.tcItens.Location = new System.Drawing.Point(74, 379);
            this.tcItens.Name = "tcItens";
            this.tcItens.SelectedIndex = 0;
            this.tcItens.Size = new System.Drawing.Size(565, 123);
            this.tcItens.TabIndex = 1;
            // 
            // fmCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 539);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.tcItens);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.pnDadosGerais);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(668, 578);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(668, 578);
            this.Name = "fmCadastroItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de itens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmCadastroItem_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadastroItens_KeyDown);
            this.pnDadosGerais.ResumeLayout(false);
            this.pnDadosGerais.PerformLayout();
            this.gbDesintegracao.ResumeLayout(false);
            this.gbDesintegracao.PerformLayout();
            this.gbTipoDeItem.ResumeLayout(false);
            this.gbTipoDeItem.PerformLayout();
            this.tpValores.ResumeLayout(false);
            this.tpValores.PerformLayout();
            this.tcItens.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnDadosGerais;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.TextBox tbDescricaoDeCompra;
        private System.Windows.Forms.Label lbDescricaoFornecedor;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.GroupBox gbTipoDeItem;
        private System.Windows.Forms.RadioButton rbServico;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.TextBox tbAjuda;
        private Controls.MenuVertical menuVertical;
        private Controls.BuscaUnimedida buscaUnimedidaItem;
        private Controls.BuscaGrupoItem buscaGrupoItem;
        private Controls.BuscaSubGrupoItem buscaSubGrupoItem;
        private Controls.DecimalBox dbQuantidade;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Button btAddUnimedida;
        private System.Windows.Forms.GroupBox gbDesintegracao;
        private System.Windows.Forms.RadioButton rbDesiNao;
        private System.Windows.Forms.RadioButton rbDesiSim;
        private System.Windows.Forms.Button btConfigDesintegracao;
        private System.Windows.Forms.TabPage tpValores;
        private Controls.DecimalBox dbPrecoVenda;
        private System.Windows.Forms.Label lbPrecoVenda;
        private Controls.DecimalBox dbEstoqueNecessario;
        private System.Windows.Forms.Label lbEstoqueNecessario;
        private System.Windows.Forms.TabControl tcItens;
        private Controls.DecimalBox dbValorEntrada;
        private System.Windows.Forms.Label lbValorEntrada;
        private System.Windows.Forms.Button btCalcular;
    }
}