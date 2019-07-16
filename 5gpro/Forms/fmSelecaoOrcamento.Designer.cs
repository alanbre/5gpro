namespace _5gpro.Forms
{
    partial class fmSelecaoOrcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbListadeitens = new System.Windows.Forms.GroupBox();
            this.dgvItensorcamento = new System.Windows.Forms.DataGridView();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.buscaSubGrupoItem = new _5gpro.Controls.BuscaSubGrupoItem();
            this.buscaGrupoItem = new _5gpro.Controls.BuscaGrupoItem();
            this.btBuscarItens = new System.Windows.Forms.Button();
            this.gbTipoItem = new System.Windows.Forms.GroupBox();
            this.cbServico = new System.Windows.Forms.CheckBox();
            this.cbProduto = new System.Windows.Forms.CheckBox();
            this.lbDenomCompra = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbDenomCompra = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.dgvtbcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQuantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcUnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListadeitens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensorcamento)).BeginInit();
            this.gbTipoItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListadeitens
            // 
            this.gbListadeitens.Controls.Add(this.dgvItensorcamento);
            this.gbListadeitens.Location = new System.Drawing.Point(12, 160);
            this.gbListadeitens.Name = "gbListadeitens";
            this.gbListadeitens.Size = new System.Drawing.Size(762, 344);
            this.gbListadeitens.TabIndex = 10;
            this.gbListadeitens.TabStop = false;
            this.gbListadeitens.Text = "Lista de Itens";
            // 
            // dgvItensorcamento
            // 
            this.dgvItensorcamento.AllowUserToAddRows = false;
            this.dgvItensorcamento.AllowUserToDeleteRows = false;
            this.dgvItensorcamento.AllowUserToOrderColumns = true;
            this.dgvItensorcamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            this.dgvItensorcamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItensorcamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvItensorcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensorcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigo,
            this.dgvtbcDescricao,
            this.dgvtbcQuantidadeEstoque,
            this.dgvtbcUnidadeMedida,
            this.dgvtbcValorSaida,
            this.dgvtbcQuantidade,
            this.dgvtbcTotal});
            this.dgvItensorcamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItensorcamento.Location = new System.Drawing.Point(3, 16);
            this.dgvItensorcamento.Name = "dgvItensorcamento";
            this.dgvItensorcamento.RowHeadersVisible = false;
            this.dgvItensorcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensorcamento.Size = new System.Drawing.Size(756, 325);
            this.dgvItensorcamento.TabIndex = 0;
            this.dgvItensorcamento.TabStop = false;
            this.dgvItensorcamento.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItensorcamento_CellValueChanged);
            this.dgvItensorcamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvItensorcamento_KeyDown);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(618, 507);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 12;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(699, 507);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(12, 128);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(274, 20);
            this.tbReferencia.TabIndex = 5;
            this.tbReferencia.TextChanged += new System.EventHandler(this.TbReferencia_TextChanged);
            // 
            // buscaSubGrupoItem
            // 
            this.buscaSubGrupoItem.Location = new System.Drawing.Point(292, 66);
            this.buscaSubGrupoItem.Name = "buscaSubGrupoItem";
            this.buscaSubGrupoItem.Size = new System.Drawing.Size(442, 39);
            this.buscaSubGrupoItem.TabIndex = 7;
            this.buscaSubGrupoItem.Leave += new System.EventHandler(this.BuscaSubGrupoItem_Leave);
            // 
            // buscaGrupoItem
            // 
            this.buscaGrupoItem.Location = new System.Drawing.Point(292, 21);
            this.buscaGrupoItem.Name = "buscaGrupoItem";
            this.buscaGrupoItem.Size = new System.Drawing.Size(442, 39);
            this.buscaGrupoItem.TabIndex = 6;
            this.buscaGrupoItem.Leave += new System.EventHandler(this.BuscaGrupoItem_Leave);
            // 
            // btBuscarItens
            // 
            this.btBuscarItens.Location = new System.Drawing.Point(447, 130);
            this.btBuscarItens.Name = "btBuscarItens";
            this.btBuscarItens.Size = new System.Drawing.Size(75, 23);
            this.btBuscarItens.TabIndex = 9;
            this.btBuscarItens.Text = "Pesquisar";
            this.btBuscarItens.UseVisualStyleBackColor = true;
            // 
            // gbTipoItem
            // 
            this.gbTipoItem.Controls.Add(this.cbServico);
            this.gbTipoItem.Controls.Add(this.cbProduto);
            this.gbTipoItem.Location = new System.Drawing.Point(292, 111);
            this.gbTipoItem.Name = "gbTipoItem";
            this.gbTipoItem.Size = new System.Drawing.Size(149, 43);
            this.gbTipoItem.TabIndex = 8;
            this.gbTipoItem.TabStop = false;
            this.gbTipoItem.Text = "Tipo";
            // 
            // cbServico
            // 
            this.cbServico.AutoSize = true;
            this.cbServico.Location = new System.Drawing.Point(76, 23);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(62, 17);
            this.cbServico.TabIndex = 1;
            this.cbServico.Text = "Serviço";
            this.cbServico.UseVisualStyleBackColor = true;
            this.cbServico.Click += new System.EventHandler(this.CbServico_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.AutoSize = true;
            this.cbProduto.Location = new System.Drawing.Point(7, 23);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(63, 17);
            this.cbProduto.TabIndex = 0;
            this.cbProduto.Text = "Produto";
            this.cbProduto.UseVisualStyleBackColor = true;
            this.cbProduto.Click += new System.EventHandler(this.CbProduto_Click);
            // 
            // lbDenomCompra
            // 
            this.lbDenomCompra.AutoSize = true;
            this.lbDenomCompra.Location = new System.Drawing.Point(9, 23);
            this.lbDenomCompra.Name = "lbDenomCompra";
            this.lbDenomCompra.Size = new System.Drawing.Size(127, 13);
            this.lbDenomCompra.TabIndex = 0;
            this.lbDenomCompra.Text = "Denominação de Compra";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(12, 85);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(274, 20);
            this.tbDescricao.TabIndex = 3;
            this.tbDescricao.TextChanged += new System.EventHandler(this.TbDescricao_TextChanged);
            // 
            // tbDenomCompra
            // 
            this.tbDenomCompra.Location = new System.Drawing.Point(12, 39);
            this.tbDenomCompra.Name = "tbDenomCompra";
            this.tbDenomCompra.Size = new System.Drawing.Size(274, 20);
            this.tbDenomCompra.TabIndex = 1;
            this.tbDenomCompra.TextChanged += new System.EventHandler(this.TbDenomCompra_TextChanged);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(12, 69);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(15, 111);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(59, 13);
            this.lbReferencia.TabIndex = 4;
            this.lbReferencia.Text = "Referência";
            // 
            // dgvtbcCodigo
            // 
            this.dgvtbcCodigo.HeaderText = "Código";
            this.dgvtbcCodigo.Name = "dgvtbcCodigo";
            this.dgvtbcCodigo.ReadOnly = true;
            this.dgvtbcCodigo.Width = 50;
            // 
            // dgvtbcDescricao
            // 
            this.dgvtbcDescricao.HeaderText = "Descrição";
            this.dgvtbcDescricao.Name = "dgvtbcDescricao";
            this.dgvtbcDescricao.ReadOnly = true;
            this.dgvtbcDescricao.Width = 150;
            // 
            // dgvtbcQuantidadeEstoque
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.dgvtbcQuantidadeEstoque.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvtbcQuantidadeEstoque.HeaderText = "Quantidade em Estoque";
            this.dgvtbcQuantidadeEstoque.Name = "dgvtbcQuantidadeEstoque";
            this.dgvtbcQuantidadeEstoque.ReadOnly = true;
            // 
            // dgvtbcUnidadeMedida
            // 
            this.dgvtbcUnidadeMedida.HeaderText = "Unidade de Medida";
            this.dgvtbcUnidadeMedida.Name = "dgvtbcUnidadeMedida";
            this.dgvtbcUnidadeMedida.ReadOnly = true;
            this.dgvtbcUnidadeMedida.Width = 50;
            // 
            // dgvtbcValorSaida
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.dgvtbcValorSaida.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvtbcValorSaida.HeaderText = "Valor de Saída";
            this.dgvtbcValorSaida.Name = "dgvtbcValorSaida";
            this.dgvtbcValorSaida.ReadOnly = true;
            // 
            // dgvtbcQuantidade
            // 
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.dgvtbcQuantidade.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvtbcQuantidade.HeaderText = "Quantidade";
            this.dgvtbcQuantidade.Name = "dgvtbcQuantidade";
            // 
            // dgvtbcTotal
            // 
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.dgvtbcTotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvtbcTotal.HeaderText = "TOTAL";
            this.dgvtbcTotal.Name = "dgvtbcTotal";
            this.dgvtbcTotal.ReadOnly = true;
            this.dgvtbcTotal.Width = 150;
            // 
            // fmSelecaoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.lbReferencia);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.tbReferencia);
            this.Controls.Add(this.buscaSubGrupoItem);
            this.Controls.Add(this.buscaGrupoItem);
            this.Controls.Add(this.btBuscarItens);
            this.Controls.Add(this.gbTipoItem);
            this.Controls.Add(this.lbDenomCompra);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbDenomCompra);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.gbListadeitens);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSelecaoOrcamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Itens do Orçamento";
            this.Load += new System.EventHandler(this.FmSelecaoOrcamento_Load);
            this.gbListadeitens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensorcamento)).EndInit();
            this.gbTipoItem.ResumeLayout(false);
            this.gbTipoItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadeitens;
        private System.Windows.Forms.DataGridView dgvItensorcamento;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbReferencia;
        private Controls.BuscaSubGrupoItem buscaSubGrupoItem;
        private Controls.BuscaGrupoItem buscaGrupoItem;
        private System.Windows.Forms.Button btBuscarItens;
        private System.Windows.Forms.GroupBox gbTipoItem;
        private System.Windows.Forms.CheckBox cbServico;
        private System.Windows.Forms.CheckBox cbProduto;
        private System.Windows.Forms.Label lbDenomCompra;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbDenomCompra;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQuantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcUnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcTotal;
    }
}