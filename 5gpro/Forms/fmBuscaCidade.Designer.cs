﻿namespace _5gpro.Forms
{
    partial class fmBuscaCidade
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
            this.lbEstado = new System.Windows.Forms.Label();
            this.tbFiltroCodEstado = new System.Windows.Forms.TextBox();
            this.btProcuraEstado = new System.Windows.Forms.Button();
            this.tbNomeEstado = new System.Windows.Forms.TextBox();
            this.lbFiltroNomeCidade = new System.Windows.Forms.Label();
            this.tbFiltroNomeCidade = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.colunaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(12, 9);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 0;
            this.lbEstado.Text = "Estado";
            // 
            // tbFiltroCodEstado
            // 
            this.tbFiltroCodEstado.Location = new System.Drawing.Point(12, 25);
            this.tbFiltroCodEstado.Name = "tbFiltroCodEstado";
            this.tbFiltroCodEstado.Size = new System.Drawing.Size(54, 20);
            this.tbFiltroCodEstado.TabIndex = 1;
            this.tbFiltroCodEstado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbFiltroCodEstado_KeyUp);
            // 
            // btProcuraEstado
            // 
            this.btProcuraEstado.Location = new System.Drawing.Point(68, 25);
            this.btProcuraEstado.Name = "btProcuraEstado";
            this.btProcuraEstado.Size = new System.Drawing.Size(20, 20);
            this.btProcuraEstado.TabIndex = 2;
            this.btProcuraEstado.TabStop = false;
            this.btProcuraEstado.UseVisualStyleBackColor = true;
            this.btProcuraEstado.Click += new System.EventHandler(this.btProcuraEstado_Click);
            // 
            // tbNomeEstado
            // 
            this.tbNomeEstado.Enabled = false;
            this.tbNomeEstado.Location = new System.Drawing.Point(90, 25);
            this.tbNomeEstado.Name = "tbNomeEstado";
            this.tbNomeEstado.Size = new System.Drawing.Size(414, 20);
            this.tbNomeEstado.TabIndex = 3;
            // 
            // lbFiltroNomeCidade
            // 
            this.lbFiltroNomeCidade.AutoSize = true;
            this.lbFiltroNomeCidade.Location = new System.Drawing.Point(12, 48);
            this.lbFiltroNomeCidade.Name = "lbFiltroNomeCidade";
            this.lbFiltroNomeCidade.Size = new System.Drawing.Size(85, 13);
            this.lbFiltroNomeCidade.TabIndex = 4;
            this.lbFiltroNomeCidade.Text = "Nome da cidade";
            // 
            // tbFiltroNomeCidade
            // 
            this.tbFiltroNomeCidade.Location = new System.Drawing.Point(12, 64);
            this.tbFiltroNomeCidade.Name = "tbFiltroNomeCidade";
            this.tbFiltroNomeCidade.Size = new System.Drawing.Size(492, 20);
            this.tbFiltroNomeCidade.TabIndex = 5;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(510, 64);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(62, 23);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dgvCidades
            // 
            this.dgvCidades.AllowUserToAddRows = false;
            this.dgvCidades.AllowUserToDeleteRows = false;
            this.dgvCidades.AllowUserToOrderColumns = true;
            this.dgvCidades.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaCodigo,
            this.colunaNomeCidade,
            this.colunaNomeEstado});
            this.dgvCidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCidades.Location = new System.Drawing.Point(12, 90);
            this.dgvCidades.MultiSelect = false;
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.ReadOnly = true;
            this.dgvCidades.RowHeadersVisible = false;
            this.dgvCidades.Size = new System.Drawing.Size(560, 360);
            this.dgvCidades.TabIndex = 7;
            // 
            // colunaCodigo
            // 
            this.colunaCodigo.HeaderText = "Código";
            this.colunaCodigo.MinimumWidth = 50;
            this.colunaCodigo.Name = "colunaCodigo";
            this.colunaCodigo.ReadOnly = true;
            this.colunaCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colunaCodigo.Width = 186;
            // 
            // colunaNomeCidade
            // 
            this.colunaNomeCidade.HeaderText = "Nome da cidade";
            this.colunaNomeCidade.MinimumWidth = 100;
            this.colunaNomeCidade.Name = "colunaNomeCidade";
            this.colunaNomeCidade.ReadOnly = true;
            this.colunaNomeCidade.Width = 185;
            // 
            // colunaNomeEstado
            // 
            this.colunaNomeEstado.HeaderText = "Estado";
            this.colunaNomeEstado.MinimumWidth = 100;
            this.colunaNomeEstado.Name = "colunaNomeEstado";
            this.colunaNomeEstado.ReadOnly = true;
            this.colunaNomeEstado.Width = 186;
            // 
            // fmBuscaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.dgvCidades);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbFiltroNomeCidade);
            this.Controls.Add(this.lbFiltroNomeCidade);
            this.Controls.Add(this.tbNomeEstado);
            this.Controls.Add(this.btProcuraEstado);
            this.Controls.Add(this.tbFiltroCodEstado);
            this.Controls.Add(this.lbEstado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "fmBuscaCidade";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Busca Cidades";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox tbFiltroCodEstado;
        private System.Windows.Forms.Button btProcuraEstado;
        private System.Windows.Forms.TextBox tbNomeEstado;
        private System.Windows.Forms.Label lbFiltroNomeCidade;
        private System.Windows.Forms.TextBox tbFiltroNomeCidade;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeEstado;
    }
}