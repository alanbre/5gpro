namespace _5gpro.Forms
{
    partial class fmCadastroCheque
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
            this.menuVertical1 = new _5gpro.Controls.MenuVertical();
            this.buscaPessoa1 = new _5gpro.Controls.BuscaPessoa();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.lbCpfCnpj = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDadosPessoais.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertical1
            // 
            this.menuVertical1.Location = new System.Drawing.Point(9, 9);
            this.menuVertical1.Margin = new System.Windows.Forms.Padding(0);
            this.menuVertical1.Name = "menuVertical1";
            this.menuVertical1.Size = new System.Drawing.Size(53, 364);
            this.menuVertical1.TabIndex = 0;
            // 
            // buscaPessoa1
            // 
            this.buscaPessoa1.LabelText = "Cliente";
            this.buscaPessoa1.Location = new System.Drawing.Point(3, 72);
            this.buscaPessoa1.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa1.Name = "buscaPessoa1";
            this.buscaPessoa1.Size = new System.Drawing.Size(449, 39);
            this.buscaPessoa1.TabIndex = 1;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.label4);
            this.gbDadosPessoais.Controls.Add(this.label3);
            this.gbDadosPessoais.Controls.Add(this.lbTelefone);
            this.gbDadosPessoais.Controls.Add(this.lbCpfCnpj);
            this.gbDadosPessoais.Controls.Add(this.gbTipo);
            this.gbDadosPessoais.Controls.Add(this.buscaPessoa1);
            this.gbDadosPessoais.Location = new System.Drawing.Point(65, 12);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(723, 249);
            this.gbDadosPessoais.TabIndex = 2;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbFornecedor);
            this.gbTipo.Controls.Add(this.rbCliente);
            this.gbTipo.Location = new System.Drawing.Point(13, 19);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(155, 50);
            this.gbTipo.TabIndex = 2;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(7, 20);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Location = new System.Drawing.Point(70, 19);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(79, 17);
            this.rbFornecedor.TabIndex = 1;
            this.rbFornecedor.TabStop = true;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            // 
            // lbCpfCnpj
            // 
            this.lbCpfCnpj.AutoSize = true;
            this.lbCpfCnpj.Location = new System.Drawing.Point(10, 125);
            this.lbCpfCnpj.Name = "lbCpfCnpj";
            this.lbCpfCnpj.Size = new System.Drawing.Size(27, 13);
            this.lbCpfCnpj.TabIndex = 3;
            this.lbCpfCnpj.Text = "CPF";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(113, 125);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbTelefone.TabIndex = 4;
            this.lbTelefone.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // fmCadastroCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.menuVertical1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCadastroCheque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Cheque";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MenuVertical menuVertical1;
        private Controls.BuscaPessoa buscaPessoa1;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbCpfCnpj;
    }
}