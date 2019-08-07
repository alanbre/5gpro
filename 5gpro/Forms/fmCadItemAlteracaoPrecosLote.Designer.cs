namespace _5gpro.Forms
{
    partial class fmCadItemAlteracaoPrecosLote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcAltercaoPrecosItens = new System.Windows.Forms.TabControl();
            this.tpFiltros = new System.Windows.Forms.TabPage();
            this.tbCodigoInterno = new System.Windows.Forms.TextBox();
            this.lbCodigoInterno = new System.Windows.Forms.Label();
            this.lbDenomCompra = new System.Windows.Forms.Label();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.btBuscarItens = new System.Windows.Forms.Button();
            this.tbDenomCompra = new System.Windows.Forms.TextBox();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.gbTipoItem = new System.Windows.Forms.GroupBox();
            this.cbServico = new System.Windows.Forms.CheckBox();
            this.cbProduto = new System.Windows.Forms.CheckBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tpAlteracao = new System.Windows.Forms.TabPage();
            this.gbAlteracoes = new System.Windows.Forms.GroupBox();
            this.btSimular = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.lbPorcentagemValor = new System.Windows.Forms.Label();
            this.gbAplicar = new System.Windows.Forms.GroupBox();
            this.rbAcrescimo = new System.Windows.Forms.RadioButton();
            this.rbDesconto = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbValorFixo = new System.Windows.Forms.RadioButton();
            this.rbPorcentagem = new System.Windows.Forms.RadioButton();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCodInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescricaoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscaUnimedida1 = new _5gpro.Controls.BuscaUnimedida();
            this.buscaSubGrupoItem = new _5gpro.Controls.BuscaSubGrupoItem();
            this.buscaGrupoItem = new _5gpro.Controls.BuscaGrupoItem();
            this.dbPorcentagemValor = new _5gpro.Controls.DecimalBox();
            this.tcAltercaoPrecosItens.SuspendLayout();
            this.tpFiltros.SuspendLayout();
            this.gbTipoItem.SuspendLayout();
            this.tpAlteracao.SuspendLayout();
            this.gbAlteracoes.SuspendLayout();
            this.gbAplicar.SuspendLayout();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAltercaoPrecosItens
            // 
            this.tcAltercaoPrecosItens.Controls.Add(this.tpFiltros);
            this.tcAltercaoPrecosItens.Controls.Add(this.tpAlteracao);
            this.tcAltercaoPrecosItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAltercaoPrecosItens.Location = new System.Drawing.Point(0, 0);
            this.tcAltercaoPrecosItens.Name = "tcAltercaoPrecosItens";
            this.tcAltercaoPrecosItens.SelectedIndex = 0;
            this.tcAltercaoPrecosItens.Size = new System.Drawing.Size(800, 450);
            this.tcAltercaoPrecosItens.TabIndex = 0;
            // 
            // tpFiltros
            // 
            this.tpFiltros.Controls.Add(this.buscaUnimedida1);
            this.tpFiltros.Controls.Add(this.tbCodigoInterno);
            this.tpFiltros.Controls.Add(this.lbCodigoInterno);
            this.tpFiltros.Controls.Add(this.lbDenomCompra);
            this.tpFiltros.Controls.Add(this.tbReferencia);
            this.tpFiltros.Controls.Add(this.btBuscarItens);
            this.tpFiltros.Controls.Add(this.buscaSubGrupoItem);
            this.tpFiltros.Controls.Add(this.tbDenomCompra);
            this.tpFiltros.Controls.Add(this.buscaGrupoItem);
            this.tpFiltros.Controls.Add(this.lbReferencia);
            this.tpFiltros.Controls.Add(this.gbTipoItem);
            this.tpFiltros.Controls.Add(this.lbDescricao);
            this.tpFiltros.Controls.Add(this.tbDescricao);
            this.tpFiltros.Location = new System.Drawing.Point(4, 22);
            this.tpFiltros.Name = "tpFiltros";
            this.tpFiltros.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiltros.Size = new System.Drawing.Size(792, 424);
            this.tpFiltros.TabIndex = 0;
            this.tpFiltros.Text = "Filtros";
            this.tpFiltros.UseVisualStyleBackColor = true;
            // 
            // tbCodigoInterno
            // 
            this.tbCodigoInterno.Location = new System.Drawing.Point(6, 139);
            this.tbCodigoInterno.Name = "tbCodigoInterno";
            this.tbCodigoInterno.Size = new System.Drawing.Size(274, 20);
            this.tbCodigoInterno.TabIndex = 8;
            // 
            // lbCodigoInterno
            // 
            this.lbCodigoInterno.AutoSize = true;
            this.lbCodigoInterno.Location = new System.Drawing.Point(3, 123);
            this.lbCodigoInterno.Name = "lbCodigoInterno";
            this.lbCodigoInterno.Size = new System.Drawing.Size(75, 13);
            this.lbCodigoInterno.TabIndex = 7;
            this.lbCodigoInterno.Text = "Código interno";
            // 
            // lbDenomCompra
            // 
            this.lbDenomCompra.AutoSize = true;
            this.lbDenomCompra.Location = new System.Drawing.Point(3, 3);
            this.lbDenomCompra.Name = "lbDenomCompra";
            this.lbDenomCompra.Size = new System.Drawing.Size(127, 13);
            this.lbDenomCompra.TabIndex = 0;
            this.lbDenomCompra.Text = "Denominação de Compra";
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(6, 97);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(274, 20);
            this.tbReferencia.TabIndex = 6;
            // 
            // btBuscarItens
            // 
            this.btBuscarItens.Location = new System.Drawing.Point(6, 301);
            this.btBuscarItens.Name = "btBuscarItens";
            this.btBuscarItens.Size = new System.Drawing.Size(75, 23);
            this.btBuscarItens.TabIndex = 12;
            this.btBuscarItens.Text = "Pesquisar";
            this.btBuscarItens.UseVisualStyleBackColor = true;
            this.btBuscarItens.Click += new System.EventHandler(this.BtBuscarItens_Click);
            // 
            // tbDenomCompra
            // 
            this.tbDenomCompra.Location = new System.Drawing.Point(6, 19);
            this.tbDenomCompra.Name = "tbDenomCompra";
            this.tbDenomCompra.Size = new System.Drawing.Size(274, 20);
            this.tbDenomCompra.TabIndex = 1;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(3, 81);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(59, 13);
            this.lbReferencia.TabIndex = 5;
            this.lbReferencia.Text = "Referência";
            // 
            // gbTipoItem
            // 
            this.gbTipoItem.Controls.Add(this.cbServico);
            this.gbTipoItem.Controls.Add(this.cbProduto);
            this.gbTipoItem.Location = new System.Drawing.Point(286, 6);
            this.gbTipoItem.Name = "gbTipoItem";
            this.gbTipoItem.Size = new System.Drawing.Size(141, 43);
            this.gbTipoItem.TabIndex = 2;
            this.gbTipoItem.TabStop = false;
            this.gbTipoItem.Text = "Tipo";
            // 
            // cbServico
            // 
            this.cbServico.AutoSize = true;
            this.cbServico.Location = new System.Drawing.Point(76, 19);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(62, 17);
            this.cbServico.TabIndex = 1;
            this.cbServico.Text = "Serviço";
            this.cbServico.UseVisualStyleBackColor = true;
            // 
            // cbProduto
            // 
            this.cbProduto.AutoSize = true;
            this.cbProduto.Location = new System.Drawing.Point(7, 19);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(63, 17);
            this.cbProduto.TabIndex = 0;
            this.cbProduto.Text = "Produto";
            this.cbProduto.UseVisualStyleBackColor = true;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(3, 42);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(6, 58);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(274, 20);
            this.tbDescricao.TabIndex = 4;
            // 
            // tpAlteracao
            // 
            this.tpAlteracao.Controls.Add(this.gbAlteracoes);
            this.tpAlteracao.Controls.Add(this.dgvItens);
            this.tpAlteracao.Location = new System.Drawing.Point(4, 22);
            this.tpAlteracao.Name = "tpAlteracao";
            this.tpAlteracao.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlteracao.Size = new System.Drawing.Size(792, 424);
            this.tpAlteracao.TabIndex = 1;
            this.tpAlteracao.Text = "Alterações";
            this.tpAlteracao.UseVisualStyleBackColor = true;
            // 
            // gbAlteracoes
            // 
            this.gbAlteracoes.Controls.Add(this.btSimular);
            this.gbAlteracoes.Controls.Add(this.btConfirmar);
            this.gbAlteracoes.Controls.Add(this.dbPorcentagemValor);
            this.gbAlteracoes.Controls.Add(this.lbPorcentagemValor);
            this.gbAlteracoes.Controls.Add(this.gbAplicar);
            this.gbAlteracoes.Controls.Add(this.gbTipo);
            this.gbAlteracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAlteracoes.Location = new System.Drawing.Point(3, 3);
            this.gbAlteracoes.Name = "gbAlteracoes";
            this.gbAlteracoes.Size = new System.Drawing.Size(786, 95);
            this.gbAlteracoes.TabIndex = 0;
            this.gbAlteracoes.TabStop = false;
            this.gbAlteracoes.Text = "Alterações";
            // 
            // btSimular
            // 
            this.btSimular.Location = new System.Drawing.Point(286, 37);
            this.btSimular.Name = "btSimular";
            this.btSimular.Size = new System.Drawing.Size(75, 23);
            this.btSimular.TabIndex = 4;
            this.btSimular.Text = "Simular";
            this.btSimular.UseVisualStyleBackColor = true;
            this.btSimular.Click += new System.EventHandler(this.BtSimular_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(210, 66);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(121, 23);
            this.btConfirmar.TabIndex = 5;
            this.btConfirmar.Text = "Confirmar valores";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.BtConfirmar_Click);
            // 
            // lbPorcentagemValor
            // 
            this.lbPorcentagemValor.AutoSize = true;
            this.lbPorcentagemValor.Location = new System.Drawing.Point(210, 19);
            this.lbPorcentagemValor.Name = "lbPorcentagemValor";
            this.lbPorcentagemValor.Size = new System.Drawing.Size(70, 13);
            this.lbPorcentagemValor.TabIndex = 2;
            this.lbPorcentagemValor.Text = "Porcentagem";
            // 
            // gbAplicar
            // 
            this.gbAplicar.Controls.Add(this.rbAcrescimo);
            this.gbAplicar.Controls.Add(this.rbDesconto);
            this.gbAplicar.Location = new System.Drawing.Point(108, 19);
            this.gbAplicar.Name = "gbAplicar";
            this.gbAplicar.Size = new System.Drawing.Size(96, 68);
            this.gbAplicar.TabIndex = 1;
            this.gbAplicar.TabStop = false;
            this.gbAplicar.Text = "Aplicar";
            // 
            // rbAcrescimo
            // 
            this.rbAcrescimo.AutoSize = true;
            this.rbAcrescimo.Location = new System.Drawing.Point(6, 42);
            this.rbAcrescimo.Name = "rbAcrescimo";
            this.rbAcrescimo.Size = new System.Drawing.Size(74, 17);
            this.rbAcrescimo.TabIndex = 1;
            this.rbAcrescimo.Text = "Acréscimo";
            this.rbAcrescimo.UseVisualStyleBackColor = true;
            // 
            // rbDesconto
            // 
            this.rbDesconto.AutoSize = true;
            this.rbDesconto.Checked = true;
            this.rbDesconto.Location = new System.Drawing.Point(6, 19);
            this.rbDesconto.Name = "rbDesconto";
            this.rbDesconto.Size = new System.Drawing.Size(71, 17);
            this.rbDesconto.TabIndex = 0;
            this.rbDesconto.TabStop = true;
            this.rbDesconto.Text = "Desconto";
            this.rbDesconto.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbValorFixo);
            this.gbTipo.Controls.Add(this.rbPorcentagem);
            this.gbTipo.Location = new System.Drawing.Point(6, 19);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(96, 68);
            this.gbTipo.TabIndex = 0;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbValorFixo
            // 
            this.rbValorFixo.AutoSize = true;
            this.rbValorFixo.Location = new System.Drawing.Point(6, 42);
            this.rbValorFixo.Name = "rbValorFixo";
            this.rbValorFixo.Size = new System.Drawing.Size(71, 17);
            this.rbValorFixo.TabIndex = 1;
            this.rbValorFixo.Text = "Valor Fixo";
            this.rbValorFixo.UseVisualStyleBackColor = true;
            this.rbValorFixo.CheckedChanged += new System.EventHandler(this.RbValorFixo_CheckedChanged);
            // 
            // rbPorcentagem
            // 
            this.rbPorcentagem.AutoSize = true;
            this.rbPorcentagem.Checked = true;
            this.rbPorcentagem.Location = new System.Drawing.Point(6, 19);
            this.rbPorcentagem.Name = "rbPorcentagem";
            this.rbPorcentagem.Size = new System.Drawing.Size(88, 17);
            this.rbPorcentagem.TabIndex = 0;
            this.rbPorcentagem.TabStop = true;
            this.rbPorcentagem.Text = "Porcentagem";
            this.rbPorcentagem.UseVisualStyleBackColor = true;
            this.rbPorcentagem.CheckedChanged += new System.EventHandler(this.RbPorcentagem_CheckedChanged);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToOrderColumns = true;
            this.dgvItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dgvItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigo,
            this.dgvtbcCodInterno,
            this.dgvtbcDescricao,
            this.dgvtbcDescricaoCompra,
            this.dgvtbcValorSaida});
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItens.Location = new System.Drawing.Point(3, 104);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvItens.Size = new System.Drawing.Size(786, 317);
            this.dgvItens.TabIndex = 1;
            // 
            // dgvtbcCodigo
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvtbcCodigo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtbcCodigo.HeaderText = "Código";
            this.dgvtbcCodigo.Name = "dgvtbcCodigo";
            this.dgvtbcCodigo.ReadOnly = true;
            // 
            // dgvtbcCodInterno
            // 
            this.dgvtbcCodInterno.HeaderText = "Código Int.";
            this.dgvtbcCodInterno.Name = "dgvtbcCodInterno";
            this.dgvtbcCodInterno.ReadOnly = true;
            // 
            // dgvtbcDescricao
            // 
            this.dgvtbcDescricao.HeaderText = "Descrição";
            this.dgvtbcDescricao.Name = "dgvtbcDescricao";
            this.dgvtbcDescricao.ReadOnly = true;
            // 
            // dgvtbcDescricaoCompra
            // 
            this.dgvtbcDescricaoCompra.HeaderText = "Denominação da Compra";
            this.dgvtbcDescricaoCompra.Name = "dgvtbcDescricaoCompra";
            this.dgvtbcDescricaoCompra.ReadOnly = true;
            this.dgvtbcDescricaoCompra.Width = 180;
            // 
            // dgvtbcValorSaida
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.dgvtbcValorSaida.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvtbcValorSaida.HeaderText = "Valor de Saída";
            this.dgvtbcValorSaida.Name = "dgvtbcValorSaida";
            this.dgvtbcValorSaida.ReadOnly = true;
            this.dgvtbcValorSaida.Width = 150;
            // 
            // buscaUnimedida1
            // 
            this.buscaUnimedida1.Location = new System.Drawing.Point(0, 256);
            this.buscaUnimedida1.Name = "buscaUnimedida1";
            this.buscaUnimedida1.Size = new System.Drawing.Size(280, 39);
            this.buscaUnimedida1.TabIndex = 11;
            // 
            // buscaSubGrupoItem
            // 
            this.buscaSubGrupoItem.Location = new System.Drawing.Point(0, 211);
            this.buscaSubGrupoItem.Name = "buscaSubGrupoItem";
            this.buscaSubGrupoItem.Size = new System.Drawing.Size(280, 39);
            this.buscaSubGrupoItem.TabIndex = 10;
            // 
            // buscaGrupoItem
            // 
            this.buscaGrupoItem.Location = new System.Drawing.Point(0, 165);
            this.buscaGrupoItem.Name = "buscaGrupoItem";
            this.buscaGrupoItem.Size = new System.Drawing.Size(280, 39);
            this.buscaGrupoItem.TabIndex = 9;
            // 
            // dbPorcentagemValor
            // 
            this.dbPorcentagemValor.Location = new System.Drawing.Point(213, 38);
            this.dbPorcentagemValor.Name = "dbPorcentagemValor";
            this.dbPorcentagemValor.Size = new System.Drawing.Size(67, 22);
            this.dbPorcentagemValor.TabIndex = 3;
            this.dbPorcentagemValor.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // fmCadItemAlteracaoPrecosLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAltercaoPrecosItens);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "fmCadItemAlteracaoPrecosLote";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração de preços em lote";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FmCadItemAlteracaoPrecosLote_KeyDown);
            this.tcAltercaoPrecosItens.ResumeLayout(false);
            this.tpFiltros.ResumeLayout(false);
            this.tpFiltros.PerformLayout();
            this.gbTipoItem.ResumeLayout(false);
            this.gbTipoItem.PerformLayout();
            this.tpAlteracao.ResumeLayout(false);
            this.gbAlteracoes.ResumeLayout(false);
            this.gbAlteracoes.PerformLayout();
            this.gbAplicar.ResumeLayout(false);
            this.gbAplicar.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAltercaoPrecosItens;
        private System.Windows.Forms.TabPage tpFiltros;
        private System.Windows.Forms.TabPage tpAlteracao;
        private Controls.BuscaUnimedida buscaUnimedida1;
        private System.Windows.Forms.TextBox tbCodigoInterno;
        private System.Windows.Forms.Label lbCodigoInterno;
        private System.Windows.Forms.Label lbDenomCompra;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.Button btBuscarItens;
        private Controls.BuscaSubGrupoItem buscaSubGrupoItem;
        private System.Windows.Forms.TextBox tbDenomCompra;
        private Controls.BuscaGrupoItem buscaGrupoItem;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.GroupBox gbTipoItem;
        private System.Windows.Forms.CheckBox cbServico;
        private System.Windows.Forms.CheckBox cbProduto;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.GroupBox gbAlteracoes;
        private System.Windows.Forms.Button btConfirmar;
        private Controls.DecimalBox dbPorcentagemValor;
        private System.Windows.Forms.Label lbPorcentagemValor;
        private System.Windows.Forms.GroupBox gbAplicar;
        private System.Windows.Forms.RadioButton rbAcrescimo;
        private System.Windows.Forms.RadioButton rbDesconto;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbValorFixo;
        private System.Windows.Forms.RadioButton rbPorcentagem;
        private System.Windows.Forms.Button btSimular;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricaoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorSaida;
    }
}