namespace _5gpro.Forms
{
    partial class fmBuscaGrupoItem
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
            this.dgvGrupoItens = new System.Windows.Forms.DataGridView();
            this.tbNomeGrupoIten = new System.Windows.Forms.TextBox();
            this.gbNovo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.lbNomeBusca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoItens)).BeginInit();
            this.gbBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrupoItens
            // 
            this.dgvGrupoItens.AllowUserToAddRows = false;
            this.dgvGrupoItens.AllowUserToDeleteRows = false;
            this.dgvGrupoItens.AllowUserToOrderColumns = true;
            this.dgvGrupoItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvGrupoItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupoItens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGrupoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGrupoItens.Location = new System.Drawing.Point(6, 70);
            this.dgvGrupoItens.MultiSelect = false;
            this.dgvGrupoItens.Name = "dgvGrupoItens";
            this.dgvGrupoItens.ReadOnly = true;
            this.dgvGrupoItens.RowHeadersVisible = false;
            this.dgvGrupoItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupoItens.Size = new System.Drawing.Size(286, 156);
            this.dgvGrupoItens.TabIndex = 0;
            this.dgvGrupoItens.TabStop = false;
            this.dgvGrupoItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupoItens_CellDoubleClick);
            // 
            // tbNomeGrupoIten
            // 
            this.tbNomeGrupoIten.Location = new System.Drawing.Point(6, 44);
            this.tbNomeGrupoIten.Name = "tbNomeGrupoIten";
            this.tbNomeGrupoIten.Size = new System.Drawing.Size(286, 20);
            this.tbNomeGrupoIten.TabIndex = 1;
            this.tbNomeGrupoIten.TextChanged += new System.EventHandler(this.TbNomeGrupoIten_TextChanged);
            // 
            // gbNovo
            // 
            this.gbNovo.Controls.Add(this.textBox2);
            this.gbNovo.Controls.Add(this.textBox1);
            this.gbNovo.Controls.Add(this.lbNome);
            this.gbNovo.Controls.Add(this.lbCodigo);
            this.gbNovo.Location = new System.Drawing.Point(41, 12);
            this.gbNovo.Name = "gbNovo";
            this.gbNovo.Size = new System.Drawing.Size(269, 121);
            this.gbNovo.TabIndex = 3;
            this.gbNovo.TabStop = false;
            this.gbNovo.Text = "Novo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(7, 68);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(82, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome do Grupo";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(7, 28);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // btNovo
            // 
            this.btNovo.Image = global::_5gpro.Properties.Resources.iosPlus_22px_blue;
            this.btNovo.Location = new System.Drawing.Point(12, 36);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(23, 21);
            this.btNovo.TabIndex = 4;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::_5gpro.Properties.Resources.iosOk_22px_Green;
            this.btSalvar.Location = new System.Drawing.Point(12, 63);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(23, 22);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::_5gpro.Properties.Resources.iosDelete_22px_Red;
            this.btCancelar.Location = new System.Drawing.Point(12, 91);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(23, 22);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // gbBusca
            // 
            this.gbBusca.Controls.Add(this.lbNomeBusca);
            this.gbBusca.Controls.Add(this.dgvGrupoItens);
            this.gbBusca.Controls.Add(this.tbNomeGrupoIten);
            this.gbBusca.Location = new System.Drawing.Point(12, 12);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(298, 232);
            this.gbBusca.TabIndex = 7;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Busca";
            // 
            // lbNomeBusca
            // 
            this.lbNomeBusca.AutoSize = true;
            this.lbNomeBusca.Location = new System.Drawing.Point(7, 25);
            this.lbNomeBusca.Name = "lbNomeBusca";
            this.lbNomeBusca.Size = new System.Drawing.Size(35, 13);
            this.lbNomeBusca.TabIndex = 2;
            this.lbNomeBusca.Text = "Nome";
            // 
            // fmBuscaGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 395);
            this.Controls.Add(this.gbBusca);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 292);
            this.Name = "fmBuscaGrupoItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca de Grupo de Itens";
            this.Load += new System.EventHandler(this.FmBuscaGrupoItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoItens)).EndInit();
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupoItens;
        private System.Windows.Forms.TextBox tbNomeGrupoIten;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.Label lbNomeBusca;
    }
}