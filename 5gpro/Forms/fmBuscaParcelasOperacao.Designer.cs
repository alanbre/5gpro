namespace _5gpro.Forms
{
    partial class fmBuscaParcelasOperacao
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
            this.dgvParcelasOperacao = new System.Windows.Forms.DataGridView();
            this.tbNumeroParcela = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbDias = new System.Windows.Forms.TextBox();
            this.lbDias = new System.Windows.Forms.Label();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.rbSelecionar = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.gbAlterar = new System.Windows.Forms.GroupBox();
            this.btAplicar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasOperacao)).BeginInit();
            this.gbParcelas.SuspendLayout();
            this.gbAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParcelasOperacao
            // 
            this.dgvParcelasOperacao.AllowUserToAddRows = false;
            this.dgvParcelasOperacao.AllowUserToDeleteRows = false;
            this.dgvParcelasOperacao.AllowUserToOrderColumns = true;
            this.dgvParcelasOperacao.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dgvParcelasOperacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParcelasOperacao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvParcelasOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelasOperacao.ColumnHeadersVisible = false;
            this.dgvParcelasOperacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParcelasOperacao.Location = new System.Drawing.Point(12, 12);
            this.dgvParcelasOperacao.MultiSelect = false;
            this.dgvParcelasOperacao.Name = "dgvParcelasOperacao";
            this.dgvParcelasOperacao.ReadOnly = true;
            this.dgvParcelasOperacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelasOperacao.Size = new System.Drawing.Size(303, 235);
            this.dgvParcelasOperacao.TabIndex = 0;
            this.dgvParcelasOperacao.TabStop = false;
            // 
            // tbNumeroParcela
            // 
            this.tbNumeroParcela.Enabled = false;
            this.tbNumeroParcela.Location = new System.Drawing.Point(29, 66);
            this.tbNumeroParcela.Name = "tbNumeroParcela";
            this.tbNumeroParcela.Size = new System.Drawing.Size(53, 20);
            this.tbNumeroParcela.TabIndex = 0;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(4, 69);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(19, 13);
            this.lbNumero.TabIndex = 1;
            this.lbNumero.Text = "Nº";
            // 
            // tbDias
            // 
            this.tbDias.Location = new System.Drawing.Point(43, 19);
            this.tbDias.Name = "tbDias";
            this.tbDias.Size = new System.Drawing.Size(59, 20);
            this.tbDias.TabIndex = 2;
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Location = new System.Drawing.Point(9, 24);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(28, 13);
            this.lbDias.TabIndex = 3;
            this.lbDias.Text = "Dias";
            // 
            // gbParcelas
            // 
            this.gbParcelas.Controls.Add(this.rbSelecionar);
            this.gbParcelas.Controls.Add(this.rbTodas);
            this.gbParcelas.Controls.Add(this.lbNumero);
            this.gbParcelas.Controls.Add(this.tbNumeroParcela);
            this.gbParcelas.Location = new System.Drawing.Point(12, 255);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(122, 95);
            this.gbParcelas.TabIndex = 4;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            // 
            // rbSelecionar
            // 
            this.rbSelecionar.AutoSize = true;
            this.rbSelecionar.Location = new System.Drawing.Point(7, 43);
            this.rbSelecionar.Name = "rbSelecionar";
            this.rbSelecionar.Size = new System.Drawing.Size(75, 17);
            this.rbSelecionar.TabIndex = 1;
            this.rbSelecionar.Text = "Selecionar";
            this.rbSelecionar.UseVisualStyleBackColor = true;
            this.rbSelecionar.CheckedChanged += new System.EventHandler(this.RbSelecionar_CheckedChanged);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(7, 20);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 0;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.RbTodas_CheckedChanged);
            // 
            // gbAlterar
            // 
            this.gbAlterar.Controls.Add(this.btAplicar);
            this.gbAlterar.Controls.Add(this.lbDias);
            this.gbAlterar.Controls.Add(this.tbDias);
            this.gbAlterar.Location = new System.Drawing.Point(140, 255);
            this.gbAlterar.Name = "gbAlterar";
            this.gbAlterar.Size = new System.Drawing.Size(175, 47);
            this.gbAlterar.TabIndex = 5;
            this.gbAlterar.TabStop = false;
            this.gbAlterar.Text = "Alterar";
            // 
            // btAplicar
            // 
            this.btAplicar.Location = new System.Drawing.Point(108, 17);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(59, 23);
            this.btAplicar.TabIndex = 4;
            this.btAplicar.Text = "Aplicar";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.BtAplicar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::_5gpro.Properties.Resources.iosOk_22px_Green;
            this.btSalvar.Location = new System.Drawing.Point(213, 320);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(48, 30);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::_5gpro.Properties.Resources.delete_32_black;
            this.btCancelar.Location = new System.Drawing.Point(267, 320);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(48, 30);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // fmBuscaParcelasOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 360);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.gbAlterar);
            this.Controls.Add(this.gbParcelas);
            this.Controls.Add(this.dgvParcelasOperacao);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBuscaParcelasOperacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Parcelas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasOperacao)).EndInit();
            this.gbParcelas.ResumeLayout(false);
            this.gbParcelas.PerformLayout();
            this.gbAlterar.ResumeLayout(false);
            this.gbAlterar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParcelasOperacao;
        private System.Windows.Forms.TextBox tbNumeroParcela;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbDias;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.RadioButton rbSelecionar;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.GroupBox gbAlterar;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
    }
}