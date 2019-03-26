namespace _5gpro.Forms
{
    partial class fmOrcamento
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
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.btProcuraCliente = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.tbCodItem = new System.Windows.Forms.TextBox();
            this.lbCodItem = new System.Windows.Forms.Label();
            this.btProcuraItem = new System.Windows.Forms.Button();
            this.tbDescItem = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lbValorUnit = new System.Windows.Forms.Label();
            this.tbValorUnit = new System.Windows.Forms.TextBox();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btRecarregar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btProximo = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.lbValorTot = new System.Windows.Forms.Label();
            this.tbValorTot = new System.Windows.Forms.TextBox();
            this.btInserirItem = new System.Windows.Forms.Button();
            this.gbDadosOrcamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosOrcamento
            // 
            this.gbDadosOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDadosOrcamento.Controls.Add(this.tbNomeCliente);
            this.gbDadosOrcamento.Controls.Add(this.btProcuraCliente);
            this.gbDadosOrcamento.Controls.Add(this.tbCliente);
            this.gbDadosOrcamento.Controls.Add(this.lbCliente);
            this.gbDadosOrcamento.Controls.Add(this.tbCod);
            this.gbDadosOrcamento.Controls.Add(this.lbCodigo);
            this.gbDadosOrcamento.Location = new System.Drawing.Point(65, 12);
            this.gbDadosOrcamento.Name = "gbDadosOrcamento";
            this.gbDadosOrcamento.Size = new System.Drawing.Size(994, 213);
            this.gbDadosOrcamento.TabIndex = 0;
            this.gbDadosOrcamento.TabStop = false;
            this.gbDadosOrcamento.Text = "Dados do orçamento";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNomeCliente.Location = new System.Drawing.Point(98, 74);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(355, 20);
            this.tbNomeCliente.TabIndex = 8;
            // 
            // btProcuraCliente
            // 
            this.btProcuraCliente.Location = new System.Drawing.Point(76, 74);
            this.btProcuraCliente.Name = "btProcuraCliente";
            this.btProcuraCliente.Size = new System.Drawing.Size(20, 20);
            this.btProcuraCliente.TabIndex = 7;
            this.btProcuraCliente.TabStop = false;
            this.btProcuraCliente.UseVisualStyleBackColor = true;
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(9, 75);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(65, 20);
            this.tbCliente.TabIndex = 6;
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
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(9, 36);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(65, 20);
            this.tbCod.TabIndex = 1;
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
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToOrderColumns = true;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItens.Location = new System.Drawing.Point(65, 231);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(994, 241);
            this.dgvItens.TabIndex = 1;
            // 
            // tbCodItem
            // 
            this.tbCodItem.Location = new System.Drawing.Point(66, 491);
            this.tbCodItem.Name = "tbCodItem";
            this.tbCodItem.Size = new System.Drawing.Size(63, 20);
            this.tbCodItem.TabIndex = 2;
            // 
            // lbCodItem
            // 
            this.lbCodItem.AutoSize = true;
            this.lbCodItem.Location = new System.Drawing.Point(66, 475);
            this.lbCodItem.Name = "lbCodItem";
            this.lbCodItem.Size = new System.Drawing.Size(27, 13);
            this.lbCodItem.TabIndex = 3;
            this.lbCodItem.Text = "Item";
            // 
            // btProcuraItem
            // 
            this.btProcuraItem.Location = new System.Drawing.Point(131, 491);
            this.btProcuraItem.Name = "btProcuraItem";
            this.btProcuraItem.Size = new System.Drawing.Size(20, 20);
            this.btProcuraItem.TabIndex = 4;
            this.btProcuraItem.TabStop = false;
            this.btProcuraItem.UseVisualStyleBackColor = true;
            // 
            // tbDescItem
            // 
            this.tbDescItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDescItem.Location = new System.Drawing.Point(153, 491);
            this.tbDescItem.Name = "tbDescItem";
            this.tbDescItem.ReadOnly = true;
            this.tbDescItem.Size = new System.Drawing.Size(355, 20);
            this.tbDescItem.TabIndex = 5;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(66, 522);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 6;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(66, 538);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(63, 20);
            this.tbQuantidade.TabIndex = 7;
            // 
            // lbValorUnit
            // 
            this.lbValorUnit.AutoSize = true;
            this.lbValorUnit.Location = new System.Drawing.Point(132, 522);
            this.lbValorUnit.Name = "lbValorUnit";
            this.lbValorUnit.Size = new System.Drawing.Size(56, 13);
            this.lbValorUnit.TabIndex = 8;
            this.lbValorUnit.Text = "Valor Unit.";
            // 
            // tbValorUnit
            // 
            this.tbValorUnit.Location = new System.Drawing.Point(135, 538);
            this.tbValorUnit.Name = "tbValorUnit";
            this.tbValorUnit.Size = new System.Drawing.Size(63, 20);
            this.tbValorUnit.TabIndex = 9;
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
            this.pnBotoes.TabIndex = 10;
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
            // lbValorTot
            // 
            this.lbValorTot.AutoSize = true;
            this.lbValorTot.Location = new System.Drawing.Point(201, 522);
            this.lbValorTot.Name = "lbValorTot";
            this.lbValorTot.Size = new System.Drawing.Size(53, 13);
            this.lbValorTot.TabIndex = 11;
            this.lbValorTot.Text = "Valor Tot.";
            // 
            // tbValorTot
            // 
            this.tbValorTot.Location = new System.Drawing.Point(204, 538);
            this.tbValorTot.Name = "tbValorTot";
            this.tbValorTot.Size = new System.Drawing.Size(87, 20);
            this.tbValorTot.TabIndex = 12;
            // 
            // btInserirItem
            // 
            this.btInserirItem.Location = new System.Drawing.Point(297, 534);
            this.btInserirItem.Name = "btInserirItem";
            this.btInserirItem.Size = new System.Drawing.Size(59, 24);
            this.btInserirItem.TabIndex = 13;
            this.btInserirItem.Text = "Inserir";
            this.btInserirItem.UseVisualStyleBackColor = true;
            // 
            // fmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 569);
            this.Controls.Add(this.btInserirItem);
            this.Controls.Add(this.tbValorTot);
            this.Controls.Add(this.lbValorTot);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.tbValorUnit);
            this.Controls.Add(this.lbValorUnit);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.tbDescItem);
            this.Controls.Add(this.btProcuraItem);
            this.Controls.Add(this.lbCodItem);
            this.Controls.Add(this.tbCodItem);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.gbDadosOrcamento);
            this.Name = "fmOrcamento";
            this.Text = "Orçamentos";
            this.gbDadosOrcamento.ResumeLayout(false);
            this.gbDadosOrcamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosOrcamento;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.TextBox tbCodItem;
        private System.Windows.Forms.Label lbCodItem;
        private System.Windows.Forms.Button btProcuraItem;
        private System.Windows.Forms.TextBox tbDescItem;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lbValorUnit;
        private System.Windows.Forms.TextBox tbValorUnit;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Button btRecarregar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label lbValorTot;
        private System.Windows.Forms.TextBox tbValorTot;
        private System.Windows.Forms.Button btInserirItem;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Button btProcuraCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCliente;
    }
}