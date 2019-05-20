namespace _5gpro.Controls
{
    partial class BuscaPessoa
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
            this.tbNomePessoa = new System.Windows.Forms.TextBox();
            this.btProcuraCliente = new System.Windows.Forms.Button();
            this.tbCodigoPessoa = new System.Windows.Forms.TextBox();
            this.lbPessoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNomePessoa
            // 
            this.tbNomePessoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNomePessoa.Location = new System.Drawing.Point(94, 17);
            this.tbNomePessoa.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomePessoa.Name = "tbNomePessoa";
            this.tbNomePessoa.ReadOnly = true;
            this.tbNomePessoa.Size = new System.Drawing.Size(346, 20);
            this.tbNomePessoa.TabIndex = 3;
            this.tbNomePessoa.TabStop = false;
            // 
            // btProcuraCliente
            // 
            this.btProcuraCliente.Image = global::_5gpro.Properties.Resources.iosSearch_17px_black;
            this.btProcuraCliente.Location = new System.Drawing.Point(70, 16);
            this.btProcuraCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btProcuraCliente.Name = "btProcuraCliente";
            this.btProcuraCliente.Size = new System.Drawing.Size(22, 22);
            this.btProcuraCliente.TabIndex = 2;
            this.btProcuraCliente.TabStop = false;
            this.btProcuraCliente.UseVisualStyleBackColor = true;
            this.btProcuraCliente.Click += new System.EventHandler(this.BtProcuraCliente_Click);
            // 
            // tbCodigoPessoa
            // 
            this.tbCodigoPessoa.Location = new System.Drawing.Point(6, 17);
            this.tbCodigoPessoa.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoPessoa.Name = "tbCodigoPessoa";
            this.tbCodigoPessoa.Size = new System.Drawing.Size(65, 20);
            this.tbCodigoPessoa.TabIndex = 1;
            this.tbCodigoPessoa.TextChanged += new System.EventHandler(this.TbCodigoPessoa_TextChanged);
            this.tbCodigoPessoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCodigoPessoa_KeyUp);
            this.tbCodigoPessoa.Leave += new System.EventHandler(this.TbCodigoPessoa_Leave);
            // 
            // lbPessoa
            // 
            this.lbPessoa.AutoSize = true;
            this.lbPessoa.Location = new System.Drawing.Point(3, 1);
            this.lbPessoa.Margin = new System.Windows.Forms.Padding(2);
            this.lbPessoa.Name = "lbPessoa";
            this.lbPessoa.Size = new System.Drawing.Size(0, 13);
            this.lbPessoa.TabIndex = 0;
            // 
            // BuscaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbNomePessoa);
            this.Controls.Add(this.btProcuraCliente);
            this.Controls.Add(this.tbCodigoPessoa);
            this.Controls.Add(this.lbPessoa);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BuscaPessoa";
            this.Size = new System.Drawing.Size(449, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomePessoa;
        private System.Windows.Forms.Button btProcuraCliente;
        private System.Windows.Forms.TextBox tbCodigoPessoa;
        private System.Windows.Forms.Label lbPessoa;
    }
}
