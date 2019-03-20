namespace _5gpro.Forms
{
    partial class formCadastroPais
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdpais = new System.Windows.Forms.TextBox();
            this.tbNomepais = new System.Windows.Forms.TextBox();
            this.tbSigla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelpais = new System.Windows.Forms.Button();
            this.btSavepais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sigla";
            // 
            // tbIdpais
            // 
            this.tbIdpais.Location = new System.Drawing.Point(68, 66);
            this.tbIdpais.Name = "tbIdpais";
            this.tbIdpais.Size = new System.Drawing.Size(100, 20);
            this.tbIdpais.TabIndex = 3;
            // 
            // tbNomepais
            // 
            this.tbNomepais.Location = new System.Drawing.Point(68, 105);
            this.tbNomepais.Name = "tbNomepais";
            this.tbNomepais.Size = new System.Drawing.Size(100, 20);
            this.tbNomepais.TabIndex = 4;
            // 
            // tbSigla
            // 
            this.tbSigla.Location = new System.Drawing.Point(68, 146);
            this.tbSigla.Name = "tbSigla";
            this.tbSigla.Size = new System.Drawing.Size(100, 20);
            this.tbSigla.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PAÍSES";
            // 
            // btCancelpais
            // 
            this.btCancelpais.Image = global::_5gpro.Properties.Resources.delete_32_black;
            this.btCancelpais.Location = new System.Drawing.Point(123, 189);
            this.btCancelpais.Name = "btCancelpais";
            this.btCancelpais.Size = new System.Drawing.Size(75, 35);
            this.btCancelpais.TabIndex = 8;
            this.btCancelpais.UseVisualStyleBackColor = true;
            // 
            // btSavepais
            // 
            this.btSavepais.Image = global::_5gpro.Properties.Resources.ok_32_black;
            this.btSavepais.Location = new System.Drawing.Point(25, 189);
            this.btSavepais.Name = "btSavepais";
            this.btSavepais.Size = new System.Drawing.Size(75, 35);
            this.btSavepais.TabIndex = 7;
            this.btSavepais.UseVisualStyleBackColor = true;
            this.btSavepais.Click += new System.EventHandler(this.btSavepais_Click);
            // 
            // formCadastroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 236);
            this.Controls.Add(this.btCancelpais);
            this.Controls.Add(this.btSavepais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSigla);
            this.Controls.Add(this.tbNomepais);
            this.Controls.Add(this.tbIdpais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formCadastroPais";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdpais;
        private System.Windows.Forms.TextBox tbNomepais;
        private System.Windows.Forms.TextBox tbSigla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSavepais;
        private System.Windows.Forms.Button btCancelpais;
    }
}