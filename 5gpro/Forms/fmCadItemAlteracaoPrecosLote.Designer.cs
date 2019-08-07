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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcAltercaoPrecosItens = new System.Windows.Forms.TabControl();
            this.tpFiltros = new System.Windows.Forms.TabPage();
            this.tpAlteracao = new System.Windows.Forms.TabPage();
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
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.buscaUnimedida1 = new _5gpro.Controls.BuscaUnimedida();
            this.buscaSubGrupoItem = new _5gpro.Controls.BuscaSubGrupoItem();
            this.buscaGrupoItem = new _5gpro.Controls.BuscaGrupoItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcAltercaoPrecosItens.SuspendLayout();
            this.tpFiltros.SuspendLayout();
            this.tpAlteracao.SuspendLayout();
            this.gbTipoItem.SuspendLayout();
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
            // tpAlteracao
            // 
            this.tpAlteracao.Controls.Add(this.groupBox1);
            this.tpAlteracao.Controls.Add(this.dgvItens);
            this.tpAlteracao.Location = new System.Drawing.Point(4, 22);
            this.tpAlteracao.Name = "tpAlteracao";
            this.tpAlteracao.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlteracao.Size = new System.Drawing.Size(792, 424);
            this.tpAlteracao.TabIndex = 1;
            this.tpAlteracao.Text = "Alterações";
            this.tpAlteracao.UseVisualStyleBackColor = true;
            // 
            // tbCodigoInterno
            // 
            this.tbCodigoInterno.Location = new System.Drawing.Point(6, 139);
            this.tbCodigoInterno.Name = "tbCodigoInterno";
            this.tbCodigoInterno.Size = new System.Drawing.Size(274, 20);
            this.tbCodigoInterno.TabIndex = 28;
            // 
            // lbCodigoInterno
            // 
            this.lbCodigoInterno.AutoSize = true;
            this.lbCodigoInterno.Location = new System.Drawing.Point(3, 123);
            this.lbCodigoInterno.Name = "lbCodigoInterno";
            this.lbCodigoInterno.Size = new System.Drawing.Size(75, 13);
            this.lbCodigoInterno.TabIndex = 27;
            this.lbCodigoInterno.Text = "Código interno";
            // 
            // lbDenomCompra
            // 
            this.lbDenomCompra.AutoSize = true;
            this.lbDenomCompra.Location = new System.Drawing.Point(3, 3);
            this.lbDenomCompra.Name = "lbDenomCompra";
            this.lbDenomCompra.Size = new System.Drawing.Size(127, 13);
            this.lbDenomCompra.TabIndex = 20;
            this.lbDenomCompra.Text = "Denominação de Compra";
            // 
            // tbReferencia
            // 
            this.tbReferencia.Location = new System.Drawing.Point(6, 97);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(274, 20);
            this.tbReferencia.TabIndex = 26;
            // 
            // btBuscarItens
            // 
            this.btBuscarItens.Location = new System.Drawing.Point(6, 301);
            this.btBuscarItens.Name = "btBuscarItens";
            this.btBuscarItens.Size = new System.Drawing.Size(75, 23);
            this.btBuscarItens.TabIndex = 22;
            this.btBuscarItens.Text = "Pesquisar";
            this.btBuscarItens.UseVisualStyleBackColor = true;
            // 
            // tbDenomCompra
            // 
            this.tbDenomCompra.Location = new System.Drawing.Point(6, 19);
            this.tbDenomCompra.Name = "tbDenomCompra";
            this.tbDenomCompra.Size = new System.Drawing.Size(274, 20);
            this.tbDenomCompra.TabIndex = 17;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(3, 81);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(59, 13);
            this.lbReferencia.TabIndex = 25;
            this.lbReferencia.Text = "Referência";
            // 
            // gbTipoItem
            // 
            this.gbTipoItem.Controls.Add(this.cbServico);
            this.gbTipoItem.Controls.Add(this.cbProduto);
            this.gbTipoItem.Location = new System.Drawing.Point(286, 6);
            this.gbTipoItem.Name = "gbTipoItem";
            this.gbTipoItem.Size = new System.Drawing.Size(141, 43);
            this.gbTipoItem.TabIndex = 21;
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
            this.lbDescricao.TabIndex = 19;
            this.lbDescricao.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(6, 58);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(274, 20);
            this.tbDescricao.TabIndex = 18;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToOrderColumns = true;
            this.dgvItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItens.Location = new System.Drawing.Point(3, 117);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvItens.Size = new System.Drawing.Size(786, 304);
            this.dgvItens.TabIndex = 0;
            // 
            // buscaUnimedida1
            // 
            this.buscaUnimedida1.Location = new System.Drawing.Point(0, 256);
            this.buscaUnimedida1.Name = "buscaUnimedida1";
            this.buscaUnimedida1.Size = new System.Drawing.Size(280, 39);
            this.buscaUnimedida1.TabIndex = 29;
            // 
            // buscaSubGrupoItem
            // 
            this.buscaSubGrupoItem.Location = new System.Drawing.Point(0, 211);
            this.buscaSubGrupoItem.Name = "buscaSubGrupoItem";
            this.buscaSubGrupoItem.Size = new System.Drawing.Size(280, 39);
            this.buscaSubGrupoItem.TabIndex = 24;
            // 
            // buscaGrupoItem
            // 
            this.buscaGrupoItem.Location = new System.Drawing.Point(0, 165);
            this.buscaGrupoItem.Name = "buscaGrupoItem";
            this.buscaGrupoItem.Size = new System.Drawing.Size(280, 39);
            this.buscaGrupoItem.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.tcAltercaoPrecosItens.ResumeLayout(false);
            this.tpFiltros.ResumeLayout(false);
            this.tpFiltros.PerformLayout();
            this.tpAlteracao.ResumeLayout(false);
            this.gbTipoItem.ResumeLayout(false);
            this.gbTipoItem.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}