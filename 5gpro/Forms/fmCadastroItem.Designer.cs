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
            this.gbTipoDeItem = new System.Windows.Forms.GroupBox();
            this.rbServico = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.tbDescricaoUndMedida = new System.Windows.Forms.TextBox();
            this.btBuscaUndMedida = new System.Windows.Forms.Button();
            this.tbCodUnimedida = new System.Windows.Forms.TextBox();
            this.lbUndMedida = new System.Windows.Forms.Label();
            this.tbDescricaoDeCompra = new System.Windows.Forms.TextBox();
            this.lbDescricaoFornecedor = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbAjuda = new System.Windows.Forms.TextBox();
            this.tcItens = new System.Windows.Forms.TabControl();
            this.tpEstoque = new System.Windows.Forms.TabPage();
            this.tbEstoqueNecessario = new System.Windows.Forms.TextBox();
            this.lbEstoqueNecessario = new System.Windows.Forms.Label();
            this.btHistEntradas = new System.Windows.Forms.Button();
            this.tbPrecoUltimaEntrada = new System.Windows.Forms.TextBox();
            this.lbPrecoUltimaEntrada = new System.Windows.Forms.Label();
            this.tpVendas = new System.Windows.Forms.TabPage();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.lbPrecoVenda = new System.Windows.Forms.Label();
            this.menuVertical = new _5gpro.Controls.MenuVertical();
            this.pnDadosGerais.SuspendLayout();
            this.gbTipoDeItem.SuspendLayout();
            this.tcItens.SuspendLayout();
            this.tpEstoque.SuspendLayout();
            this.tpVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDadosGerais
            // 
            this.pnDadosGerais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDadosGerais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDadosGerais.Controls.Add(this.gbTipoDeItem);
            this.pnDadosGerais.Controls.Add(this.tbReferencia);
            this.pnDadosGerais.Controls.Add(this.lbReferencia);
            this.pnDadosGerais.Controls.Add(this.tbDescricaoUndMedida);
            this.pnDadosGerais.Controls.Add(this.btBuscaUndMedida);
            this.pnDadosGerais.Controls.Add(this.tbCodUnimedida);
            this.pnDadosGerais.Controls.Add(this.lbUndMedida);
            this.pnDadosGerais.Controls.Add(this.tbDescricaoDeCompra);
            this.pnDadosGerais.Controls.Add(this.lbDescricaoFornecedor);
            this.pnDadosGerais.Controls.Add(this.tbDescricao);
            this.pnDadosGerais.Controls.Add(this.lbDescricao);
            this.pnDadosGerais.Controls.Add(this.tbCodigo);
            this.pnDadosGerais.Controls.Add(this.lbCodigo);
            this.pnDadosGerais.Location = new System.Drawing.Point(74, 12);
            this.pnDadosGerais.Name = "pnDadosGerais";
            this.pnDadosGerais.Size = new System.Drawing.Size(1110, 218);
            this.pnDadosGerais.TabIndex = 0;
            // 
            // gbTipoDeItem
            // 
            this.gbTipoDeItem.Controls.Add(this.rbServico);
            this.gbTipoDeItem.Controls.Add(this.rbProduto);
            this.gbTipoDeItem.Location = new System.Drawing.Point(286, 138);
            this.gbTipoDeItem.Name = "gbTipoDeItem";
            this.gbTipoDeItem.Size = new System.Drawing.Size(131, 45);
            this.gbTipoDeItem.TabIndex = 0;
            this.gbTipoDeItem.TabStop = false;
            this.gbTipoDeItem.Text = "Tipo de item";
            // 
            // rbServico
            // 
            this.rbServico.AutoSize = true;
            this.rbServico.Location = new System.Drawing.Point(68, 19);
            this.rbServico.Name = "rbServico";
            this.rbServico.Size = new System.Drawing.Size(61, 17);
            this.rbServico.TabIndex = 9;
            this.rbServico.Text = "Serviço";
            this.rbServico.UseVisualStyleBackColor = true;
            this.rbServico.CheckedChanged += new System.EventHandler(this.rbServico_CheckedChanged);
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Checked = true;
            this.rbProduto.Location = new System.Drawing.Point(6, 19);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(62, 17);
            this.rbProduto.TabIndex = 8;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            this.rbProduto.CheckedChanged += new System.EventHandler(this.rbProduto_CheckedChanged);
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(15, 186);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(265, 20);
            this.tbReferencia.TabIndex = 10;
            this.tbReferencia.TextChanged += new System.EventHandler(this.tbReferencia_TextChanged);
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(12, 170);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(59, 13);
            this.lbReferencia.TabIndex = 11;
            this.lbReferencia.Text = "Referência";
            // 
            // tbDescricaoUndMedida
            // 
            this.tbDescricaoUndMedida.Enabled = false;
            this.tbDescricaoUndMedida.Location = new System.Drawing.Point(99, 147);
            this.tbDescricaoUndMedida.Name = "tbDescricaoUndMedida";
            this.tbDescricaoUndMedida.Size = new System.Drawing.Size(181, 20);
            this.tbDescricaoUndMedida.TabIndex = 9;
            this.tbDescricaoUndMedida.TabStop = false;
            // 
            // btBuscaUndMedida
            // 
            this.btBuscaUndMedida.Location = new System.Drawing.Point(77, 147);
            this.btBuscaUndMedida.Name = "btBuscaUndMedida";
            this.btBuscaUndMedida.Size = new System.Drawing.Size(20, 20);
            this.btBuscaUndMedida.TabIndex = 8;
            this.btBuscaUndMedida.TabStop = false;
            this.btBuscaUndMedida.UseVisualStyleBackColor = true;
            this.btBuscaUndMedida.Click += new System.EventHandler(this.btBuscaUndMedida_Click);
            // 
            // tbCodUnimedida
            // 
            this.tbCodUnimedida.Location = new System.Drawing.Point(16, 147);
            this.tbCodUnimedida.Name = "tbCodUnimedida";
            this.tbCodUnimedida.Size = new System.Drawing.Size(59, 20);
            this.tbCodUnimedida.TabIndex = 7;
            this.tbCodUnimedida.TextChanged += new System.EventHandler(this.tbCodUnimedida_TextChanged);
            this.tbCodUnimedida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCodUnimedida_KeyUp);
            this.tbCodUnimedida.Leave += new System.EventHandler(this.tbCodUnimedida_Leave_1);
            // 
            // lbUndMedida
            // 
            this.lbUndMedida.AutoSize = true;
            this.lbUndMedida.Location = new System.Drawing.Point(13, 131);
            this.lbUndMedida.Name = "lbUndMedida";
            this.lbUndMedida.Size = new System.Drawing.Size(99, 13);
            this.lbUndMedida.TabIndex = 6;
            this.lbUndMedida.Text = "Unidade de medida";
            // 
            // tbDescricaoDeCompra
            // 
            this.tbDescricaoDeCompra.Location = new System.Drawing.Point(15, 108);
            this.tbDescricaoDeCompra.MaxLength = 255;
            this.tbDescricaoDeCompra.Name = "tbDescricaoDeCompra";
            this.tbDescricaoDeCompra.Size = new System.Drawing.Size(528, 20);
            this.tbDescricaoDeCompra.TabIndex = 5;
            this.tbDescricaoDeCompra.TextChanged += new System.EventHandler(this.tbDescricaoDeCompra_TextChanged);
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
            this.tbDescricao.TextChanged += new System.EventHandler(this.tbDescricao_TextChanged);
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
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
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
            // tbAjuda
            // 
            this.tbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAjuda.Enabled = false;
            this.tbAjuda.HideSelection = false;
            this.tbAjuda.Location = new System.Drawing.Point(74, 540);
            this.tbAjuda.Name = "tbAjuda";
            this.tbAjuda.Size = new System.Drawing.Size(1110, 20);
            this.tbAjuda.TabIndex = 0;
            this.tbAjuda.TabStop = false;
            // 
            // tcItens
            // 
            this.tcItens.Controls.Add(this.tpEstoque);
            this.tcItens.Controls.Add(this.tpVendas);
            this.tcItens.Location = new System.Drawing.Point(74, 236);
            this.tcItens.Name = "tcItens";
            this.tcItens.SelectedIndex = 0;
            this.tcItens.Size = new System.Drawing.Size(1108, 298);
            this.tcItens.TabIndex = 0;
            // 
            // tpEstoque
            // 
            this.tpEstoque.AutoScroll = true;
            this.tpEstoque.BackColor = System.Drawing.SystemColors.Control;
            this.tpEstoque.Controls.Add(this.tbEstoqueNecessario);
            this.tpEstoque.Controls.Add(this.lbEstoqueNecessario);
            this.tpEstoque.Controls.Add(this.btHistEntradas);
            this.tpEstoque.Controls.Add(this.tbPrecoUltimaEntrada);
            this.tpEstoque.Controls.Add(this.lbPrecoUltimaEntrada);
            this.tpEstoque.Location = new System.Drawing.Point(4, 22);
            this.tpEstoque.Name = "tpEstoque";
            this.tpEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tpEstoque.Size = new System.Drawing.Size(1100, 272);
            this.tpEstoque.TabIndex = 0;
            this.tpEstoque.Text = "Estoque";
            // 
            // tbEstoqueNecessario
            // 
            this.tbEstoqueNecessario.Location = new System.Drawing.Point(6, 58);
            this.tbEstoqueNecessario.Name = "tbEstoqueNecessario";
            this.tbEstoqueNecessario.Size = new System.Drawing.Size(108, 20);
            this.tbEstoqueNecessario.TabIndex = 12;
            this.tbEstoqueNecessario.TextChanged += new System.EventHandler(this.tbEstoqueNecessario_TextChanged);
            // 
            // lbEstoqueNecessario
            // 
            this.lbEstoqueNecessario.AutoSize = true;
            this.lbEstoqueNecessario.Location = new System.Drawing.Point(6, 42);
            this.lbEstoqueNecessario.Name = "lbEstoqueNecessario";
            this.lbEstoqueNecessario.Size = new System.Drawing.Size(100, 13);
            this.lbEstoqueNecessario.TabIndex = 3;
            this.lbEstoqueNecessario.Text = "Estoque necessário";
            // 
            // btHistEntradas
            // 
            this.btHistEntradas.BackgroundImage = global::_5gpro.Properties.Resources.iosHistory_18px_black;
            this.btHistEntradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btHistEntradas.Location = new System.Drawing.Point(94, 19);
            this.btHistEntradas.Name = "btHistEntradas";
            this.btHistEntradas.Size = new System.Drawing.Size(20, 20);
            this.btHistEntradas.TabIndex = 2;
            this.btHistEntradas.TabStop = false;
            this.btHistEntradas.UseVisualStyleBackColor = true;
            // 
            // tbPrecoUltimaEntrada
            // 
            this.tbPrecoUltimaEntrada.Location = new System.Drawing.Point(6, 19);
            this.tbPrecoUltimaEntrada.Name = "tbPrecoUltimaEntrada";
            this.tbPrecoUltimaEntrada.Size = new System.Drawing.Size(86, 20);
            this.tbPrecoUltimaEntrada.TabIndex = 11;
            this.tbPrecoUltimaEntrada.TextChanged += new System.EventHandler(this.tbPrecoUltimaEntrada_TextChanged);
            // 
            // lbPrecoUltimaEntrada
            // 
            this.lbPrecoUltimaEntrada.AutoSize = true;
            this.lbPrecoUltimaEntrada.Location = new System.Drawing.Point(3, 3);
            this.lbPrecoUltimaEntrada.Name = "lbPrecoUltimaEntrada";
            this.lbPrecoUltimaEntrada.Size = new System.Drawing.Size(104, 13);
            this.lbPrecoUltimaEntrada.TabIndex = 0;
            this.lbPrecoUltimaEntrada.Text = "Preço última entrada";
            // 
            // tpVendas
            // 
            this.tpVendas.BackColor = System.Drawing.SystemColors.Control;
            this.tpVendas.Controls.Add(this.tbPrecoVenda);
            this.tpVendas.Controls.Add(this.lbPrecoVenda);
            this.tpVendas.Location = new System.Drawing.Point(4, 22);
            this.tpVendas.Name = "tpVendas";
            this.tpVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tpVendas.Size = new System.Drawing.Size(1100, 272);
            this.tpVendas.TabIndex = 1;
            this.tpVendas.Text = "Vendas";
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Location = new System.Drawing.Point(6, 19);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(86, 20);
            this.tbPrecoVenda.TabIndex = 13;
            this.tbPrecoVenda.TextChanged += new System.EventHandler(this.tbPrecoVenda_TextChanged);
            // 
            // lbPrecoVenda
            // 
            this.lbPrecoVenda.AutoSize = true;
            this.lbPrecoVenda.Location = new System.Drawing.Point(3, 3);
            this.lbPrecoVenda.Name = "lbPrecoVenda";
            this.lbPrecoVenda.Size = new System.Drawing.Size(83, 13);
            this.lbPrecoVenda.TabIndex = 0;
            this.lbPrecoVenda.Text = "Preço de venda";
            // 
            // menuVertical
            // 
            this.menuVertical.Location = new System.Drawing.Point(9, 12);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(53, 364);
            this.menuVertical.TabIndex = 1;
            this.menuVertical.Novo_Clicked += new _5gpro.Controls.MenuVertical.novoEventHandler(this.MenuVertical1_Novo_Clicked);
            this.menuVertical.Buscar_Clicked += new _5gpro.Controls.MenuVertical.buscarEventHandler(this.MenuVertical1_Buscar_Clicked);
            this.menuVertical.Salvar_Clicked += new _5gpro.Controls.MenuVertical.salvarEventHandler(this.MenuVertical1_Salvar_Clicked);
            this.menuVertical.Recarregar_Clicked += new _5gpro.Controls.MenuVertical.recarregarEventHandler(this.MenuVertical1_Recarregar_Clicked);
            this.menuVertical.Anterior_Clicked += new _5gpro.Controls.MenuVertical.anteriorEventHandler(this.MenuVertical1_Anterior_Clicked);
            this.menuVertical.Proximo_Clicked += new _5gpro.Controls.MenuVertical.proximoEventHandler(this.MenuVertical1_Proximo_Clicked);
            this.menuVertical.Excluir_Clicked += new _5gpro.Controls.MenuVertical.excluirEventHandler(this.MenuVertical1_Excluir_Clicked);
            // 
            // fmCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 562);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.tcItens);
            this.Controls.Add(this.tbAjuda);
            this.Controls.Add(this.pnDadosGerais);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "fmCadastroItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de itens";
            this.Load += new System.EventHandler(this.fmCadastroItens_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmCadastroItens_KeyDown);
            this.pnDadosGerais.ResumeLayout(false);
            this.pnDadosGerais.PerformLayout();
            this.gbTipoDeItem.ResumeLayout(false);
            this.gbTipoDeItem.PerformLayout();
            this.tcItens.ResumeLayout(false);
            this.tpEstoque.ResumeLayout(false);
            this.tpEstoque.PerformLayout();
            this.tpVendas.ResumeLayout(false);
            this.tpVendas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnDadosGerais;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.TextBox tbDescricaoUndMedida;
        private System.Windows.Forms.Button btBuscaUndMedida;
        private System.Windows.Forms.TextBox tbCodUnimedida;
        private System.Windows.Forms.Label lbUndMedida;
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
        private System.Windows.Forms.TabControl tcItens;
        private System.Windows.Forms.TabPage tpEstoque;
        private System.Windows.Forms.TabPage tpVendas;
        private System.Windows.Forms.TextBox tbPrecoUltimaEntrada;
        private System.Windows.Forms.Label lbPrecoUltimaEntrada;
        private System.Windows.Forms.TextBox tbEstoqueNecessario;
        private System.Windows.Forms.Label lbEstoqueNecessario;
        private System.Windows.Forms.Button btHistEntradas;
        private System.Windows.Forms.Label lbPrecoVenda;
        private System.Windows.Forms.TextBox tbPrecoVenda;
        private Controls.MenuVertical menuVertical;
    }
}