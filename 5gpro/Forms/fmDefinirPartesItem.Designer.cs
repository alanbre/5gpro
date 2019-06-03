namespace _5gpro.Forms
{
    partial class fmDefinirPartesItem
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
            this.gbQuebradgv = new System.Windows.Forms.GroupBox();
            this.lbPorcentagem = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.dgvPartes = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcPorcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverparte = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbInteiro = new System.Windows.Forms.GroupBox();
            this.menuVerticalSemNovo1 = new _5gpro.Controls.MenuVerticalSemNovo();
            this.buscaItemInteiro = new _5gpro.Controls.BuscaItem();
            this.dbPorcentagem = new _5gpro.Controls.DecimalBox();
            this.buscaItemParte = new _5gpro.Controls.BuscaItem();
            this.gbQuebradgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartes)).BeginInit();
            this.gbInteiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQuebradgv
            // 
            this.gbQuebradgv.Controls.Add(this.dbPorcentagem);
            this.gbQuebradgv.Controls.Add(this.lbPorcentagem);
            this.gbQuebradgv.Controls.Add(this.btInserir);
            this.gbQuebradgv.Controls.Add(this.buscaItemParte);
            this.gbQuebradgv.Controls.Add(this.dgvPartes);
            this.gbQuebradgv.Controls.Add(this.btRemoverparte);
            this.gbQuebradgv.Location = new System.Drawing.Point(65, 101);
            this.gbQuebradgv.Name = "gbQuebradgv";
            this.gbQuebradgv.Size = new System.Drawing.Size(508, 273);
            this.gbQuebradgv.TabIndex = 26;
            this.gbQuebradgv.TabStop = false;
            this.gbQuebradgv.Text = "Partes";
            // 
            // lbPorcentagem
            // 
            this.lbPorcentagem.AutoSize = true;
            this.lbPorcentagem.Location = new System.Drawing.Point(357, 34);
            this.lbPorcentagem.Name = "lbPorcentagem";
            this.lbPorcentagem.Size = new System.Drawing.Size(70, 13);
            this.lbPorcentagem.TabIndex = 27;
            this.lbPorcentagem.Text = "Porcentagem";
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(435, 49);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(52, 23);
            this.btInserir.TabIndex = 26;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.BtInserir_Click);
            // 
            // dgvPartes
            // 
            this.dgvPartes.AllowUserToAddRows = false;
            this.dgvPartes.AllowUserToDeleteRows = false;
            this.dgvPartes.AllowUserToOrderColumns = true;
            this.dgvPartes.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            this.dgvPartes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPartes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigo,
            this.dgvtbcDescricao,
            this.dgvtbcPorcentagem});
            this.dgvPartes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPartes.Location = new System.Drawing.Point(12, 79);
            this.dgvPartes.MultiSelect = false;
            this.dgvPartes.Name = "dgvPartes";
            this.dgvPartes.ReadOnly = true;
            this.dgvPartes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartes.Size = new System.Drawing.Size(447, 172);
            this.dgvPartes.TabIndex = 15;
            this.dgvPartes.TabStop = false;
            this.dgvPartes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPartes_CellClick);
            // 
            // dgvtbcCodigo
            // 
            this.dgvtbcCodigo.HeaderText = "Código";
            this.dgvtbcCodigo.Name = "dgvtbcCodigo";
            this.dgvtbcCodigo.ReadOnly = true;
            // 
            // dgvtbcDescricao
            // 
            this.dgvtbcDescricao.HeaderText = "Descrição";
            this.dgvtbcDescricao.Name = "dgvtbcDescricao";
            this.dgvtbcDescricao.ReadOnly = true;
            // 
            // dgvtbcPorcentagem
            // 
            this.dgvtbcPorcentagem.HeaderText = "Porcentagem";
            this.dgvtbcPorcentagem.Name = "dgvtbcPorcentagem";
            this.dgvtbcPorcentagem.ReadOnly = true;
            // 
            // btRemoverparte
            // 
            this.btRemoverparte.Enabled = false;
            this.btRemoverparte.Image = global::_5gpro.Properties.Resources.icons8_Delete_Subtra_22px;
            this.btRemoverparte.Location = new System.Drawing.Point(465, 78);
            this.btRemoverparte.Name = "btRemoverparte";
            this.btRemoverparte.Size = new System.Drawing.Size(22, 22);
            this.btRemoverparte.TabIndex = 24;
            this.btRemoverparte.UseVisualStyleBackColor = true;
            this.btRemoverparte.Click += new System.EventHandler(this.BtRemoverparte_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 20);
            this.textBox1.TabIndex = 28;
            // 
            // gbInteiro
            // 
            this.gbInteiro.Controls.Add(this.buscaItemInteiro);
            this.gbInteiro.Location = new System.Drawing.Point(65, 12);
            this.gbInteiro.Name = "gbInteiro";
            this.gbInteiro.Size = new System.Drawing.Size(508, 83);
            this.gbInteiro.TabIndex = 29;
            this.gbInteiro.TabStop = false;
            this.gbInteiro.Text = "Item a ser desintegrado";
            // 
            // menuVerticalSemNovo1
            // 
            this.menuVerticalSemNovo1.Location = new System.Drawing.Point(9, 12);
            this.menuVerticalSemNovo1.Margin = new System.Windows.Forms.Padding(0);
            this.menuVerticalSemNovo1.Name = "menuVerticalSemNovo1";
            this.menuVerticalSemNovo1.Size = new System.Drawing.Size(53, 312);
            this.menuVerticalSemNovo1.TabIndex = 32;
            this.menuVerticalSemNovo1.Buscar_Clicked += new _5gpro.Controls.MenuVerticalSemNovo.buscarEventHandler(this.MenuVerticalSemNovo1_Buscar_Clicked);
            this.menuVerticalSemNovo1.Salvar_Clicked += new _5gpro.Controls.MenuVerticalSemNovo.salvarEventHandler(this.MenuVerticalSemNovo1_Salvar_Clicked);
            this.menuVerticalSemNovo1.Recarregar_Clicked += new _5gpro.Controls.MenuVerticalSemNovo.recarregarEventHandler(this.MenuVerticalSemNovo1_Recarregar_Clicked);
            this.menuVerticalSemNovo1.Anterior_Clicked += new _5gpro.Controls.MenuVerticalSemNovo.anteriorEventHandler(this.MenuVerticalSemNovo1_Anterior_Clicked);
            this.menuVerticalSemNovo1.Proximo_Clicked += new _5gpro.Controls.MenuVerticalSemNovo.proximoEventHandler(this.MenuVerticalSemNovo1_Proximo_Clicked);
            // 
            // buscaItemInteiro
            // 
            this.buscaItemInteiro.Location = new System.Drawing.Point(6, 29);
            this.buscaItemInteiro.Name = "buscaItemInteiro";
            this.buscaItemInteiro.Size = new System.Drawing.Size(442, 39);
            this.buscaItemInteiro.TabIndex = 0;
            // 
            // dbPorcentagem
            // 
            this.dbPorcentagem.Location = new System.Drawing.Point(360, 51);
            this.dbPorcentagem.Name = "dbPorcentagem";
            this.dbPorcentagem.Size = new System.Drawing.Size(69, 22);
            this.dbPorcentagem.TabIndex = 28;
            this.dbPorcentagem.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // buscaItemParte
            // 
            this.buscaItemParte.Location = new System.Drawing.Point(6, 34);
            this.buscaItemParte.Name = "buscaItemParte";
            this.buscaItemParte.Size = new System.Drawing.Size(350, 39);
            this.buscaItemParte.TabIndex = 25;
            // 
            // fmDefinirPartesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 419);
            this.Controls.Add(this.menuVerticalSemNovo1);
            this.Controls.Add(this.gbInteiro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbQuebradgv);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(608, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(608, 458);
            this.Name = "fmDefinirPartesItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definição de partes";
            this.gbQuebradgv.ResumeLayout(false);
            this.gbQuebradgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartes)).EndInit();
            this.gbInteiro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuebradgv;
        private Controls.DecimalBox dbPorcentagem;
        private System.Windows.Forms.Label lbPorcentagem;
        private System.Windows.Forms.Button btInserir;
        private Controls.BuscaItem buscaItemParte;
        private System.Windows.Forms.DataGridView dgvPartes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcPorcentagem;
        private System.Windows.Forms.Button btRemoverparte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbInteiro;
        private Controls.BuscaItem buscaItemInteiro;
        private Controls.MenuVerticalSemNovo menuVerticalSemNovo1;
    }
}