﻿namespace _5gpro.Controls
{
    partial class BuscaSubGrupoItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCodigoSubGrupoItem = new System.Windows.Forms.TextBox();
            this.btBuscaSubGrupoItem = new System.Windows.Forms.Button();
            this.tbNomeSubGrupoItem = new System.Windows.Forms.TextBox();
            this.lbSubGrupoItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCodigoSubGrupoItem
            // 
            this.tbCodigoSubGrupoItem.Enabled = false;
            this.tbCodigoSubGrupoItem.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoSubGrupoItem.Name = "tbCodigoSubGrupoItem";
            this.tbCodigoSubGrupoItem.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoSubGrupoItem.TabIndex = 0;
            this.tbCodigoSubGrupoItem.TextChanged += new System.EventHandler(this.TbCodigoSubGrupoItem_TextChanged);
            this.tbCodigoSubGrupoItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoSubGrupoItem_KeyUp);
            this.tbCodigoSubGrupoItem.Leave += new System.EventHandler(this.TbCodigoSubGrupoItem_Leave);
            // 
            // btBuscaSubGrupoItem
            // 
            this.btBuscaSubGrupoItem.Enabled = false;
            this.btBuscaSubGrupoItem.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btBuscaSubGrupoItem.Location = new System.Drawing.Point(70, 16);
            this.btBuscaSubGrupoItem.Name = "btBuscaSubGrupoItem";
            this.btBuscaSubGrupoItem.Size = new System.Drawing.Size(22, 22);
            this.btBuscaSubGrupoItem.TabIndex = 1;
            this.btBuscaSubGrupoItem.UseVisualStyleBackColor = true;
            this.btBuscaSubGrupoItem.Click += new System.EventHandler(this.BtBuscaSubGrupoItem_Click);
            // 
            // tbNomeSubGrupoItem
            // 
            this.tbNomeSubGrupoItem.Enabled = false;
            this.tbNomeSubGrupoItem.Location = new System.Drawing.Point(94, 17);
            this.tbNomeSubGrupoItem.Name = "tbNomeSubGrupoItem";
            this.tbNomeSubGrupoItem.ReadOnly = true;
            this.tbNomeSubGrupoItem.Size = new System.Drawing.Size(346, 20);
            this.tbNomeSubGrupoItem.TabIndex = 2;
            // 
            // lbSubGrupoItem
            // 
            this.lbSubGrupoItem.AutoSize = true;
            this.lbSubGrupoItem.Location = new System.Drawing.Point(3, 1);
            this.lbSubGrupoItem.Name = "lbSubGrupoItem";
            this.lbSubGrupoItem.Size = new System.Drawing.Size(81, 13);
            this.lbSubGrupoItem.TabIndex = 3;
            this.lbSubGrupoItem.Text = "Sub-Grupo Item";
            // 
            // BuscaSubGrupoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSubGrupoItem);
            this.Controls.Add(this.tbNomeSubGrupoItem);
            this.Controls.Add(this.btBuscaSubGrupoItem);
            this.Controls.Add(this.tbCodigoSubGrupoItem);
            this.Name = "BuscaSubGrupoItem";
            this.Size = new System.Drawing.Size(442, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigoSubGrupoItem;
        private System.Windows.Forms.Button btBuscaSubGrupoItem;
        private System.Windows.Forms.TextBox tbNomeSubGrupoItem;
        private System.Windows.Forms.Label lbSubGrupoItem;
    }
}
