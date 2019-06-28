namespace _5gpro.Forms
{
    partial class fmCalculoPrecoVenda
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
            this.gpMetodo1 = new System.Windows.Forms.GroupBox();
            this.btAceitar = new System.Windows.Forms.Button();
            this.lbValorSugerido = new System.Windows.Forms.Label();
            this.lbPorcentagem = new System.Windows.Forms.Label();
            this.lbCusto = new System.Windows.Forms.Label();
            this.lbCalculoMetodo1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.lbValor = new System.Windows.Forms.Label();
            this.dbValor = new _5gpro.Controls.DecimalBox();
            this.dbValorSugerido = new _5gpro.Controls.DecimalBox();
            this.dbPorcentagem = new _5gpro.Controls.DecimalBox();
            this.dbCusto = new _5gpro.Controls.DecimalBox();
            this.gpMetodo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMetodo1
            // 
            this.gpMetodo1.Controls.Add(this.btAceitar);
            this.gpMetodo1.Controls.Add(this.dbValorSugerido);
            this.gpMetodo1.Controls.Add(this.dbPorcentagem);
            this.gpMetodo1.Controls.Add(this.dbCusto);
            this.gpMetodo1.Controls.Add(this.lbValorSugerido);
            this.gpMetodo1.Controls.Add(this.lbPorcentagem);
            this.gpMetodo1.Controls.Add(this.lbCusto);
            this.gpMetodo1.Controls.Add(this.lbCalculoMetodo1);
            this.gpMetodo1.Controls.Add(this.panel2);
            this.gpMetodo1.Controls.Add(this.panel1);
            this.gpMetodo1.Location = new System.Drawing.Point(12, 80);
            this.gpMetodo1.Name = "gpMetodo1";
            this.gpMetodo1.Size = new System.Drawing.Size(424, 141);
            this.gpMetodo1.TabIndex = 2;
            this.gpMetodo1.TabStop = false;
            this.gpMetodo1.Text = "Método 1";
            // 
            // btAceitar
            // 
            this.btAceitar.Location = new System.Drawing.Point(293, 89);
            this.btAceitar.Name = "btAceitar";
            this.btAceitar.Size = new System.Drawing.Size(102, 22);
            this.btAceitar.TabIndex = 9;
            this.btAceitar.Text = "Aceitar este valor";
            this.btAceitar.UseVisualStyleBackColor = true;
            this.btAceitar.Click += new System.EventHandler(this.BtAceitar_Click);
            // 
            // lbValorSugerido
            // 
            this.lbValorSugerido.AutoSize = true;
            this.lbValorSugerido.Location = new System.Drawing.Point(202, 72);
            this.lbValorSugerido.Name = "lbValorSugerido";
            this.lbValorSugerido.Size = new System.Drawing.Size(76, 13);
            this.lbValorSugerido.TabIndex = 5;
            this.lbValorSugerido.Text = "Valor Sugerido";
            // 
            // lbPorcentagem
            // 
            this.lbPorcentagem.AutoSize = true;
            this.lbPorcentagem.Location = new System.Drawing.Point(105, 72);
            this.lbPorcentagem.Name = "lbPorcentagem";
            this.lbPorcentagem.Size = new System.Drawing.Size(70, 13);
            this.lbPorcentagem.TabIndex = 4;
            this.lbPorcentagem.Text = "Porcentagem";
            // 
            // lbCusto
            // 
            this.lbCusto.AutoSize = true;
            this.lbCusto.Location = new System.Drawing.Point(6, 72);
            this.lbCusto.Name = "lbCusto";
            this.lbCusto.Size = new System.Drawing.Size(34, 13);
            this.lbCusto.TabIndex = 3;
            this.lbCusto.Text = "Custo";
            // 
            // lbCalculoMetodo1
            // 
            this.lbCalculoMetodo1.AutoSize = true;
            this.lbCalculoMetodo1.Location = new System.Drawing.Point(16, 27);
            this.lbCalculoMetodo1.Name = "lbCalculoMetodo1";
            this.lbCalculoMetodo1.Size = new System.Drawing.Size(316, 13);
            this.lbCalculoMetodo1.TabIndex = 2;
            this.lbCalculoMetodo1.Text = "Cálculo: Preço de custo + (Preço de Custo * Porcentagem / 100) ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(6, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 1);
            this.panel1.TabIndex = 0;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(361, 227);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(280, 227);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(358, 9);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(48, 13);
            this.lbValor.TabIndex = 6;
            this.lbValor.Text = "Valor R$";
            // 
            // dbValor
            // 
            this.dbValor.Location = new System.Drawing.Point(358, 28);
            this.dbValor.Name = "dbValor";
            this.dbValor.Size = new System.Drawing.Size(78, 22);
            this.dbValor.TabIndex = 5;
            this.dbValor.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // dbValorSugerido
            // 
            this.dbValorSugerido.Location = new System.Drawing.Point(205, 89);
            this.dbValorSugerido.Name = "dbValorSugerido";
            this.dbValorSugerido.Size = new System.Drawing.Size(81, 22);
            this.dbValorSugerido.TabIndex = 8;
            this.dbValorSugerido.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbValorSugerido.Leave += new System.EventHandler(this.DbValorSugerido_Leave);
            // 
            // dbPorcentagem
            // 
            this.dbPorcentagem.Location = new System.Drawing.Point(108, 89);
            this.dbPorcentagem.Name = "dbPorcentagem";
            this.dbPorcentagem.Size = new System.Drawing.Size(81, 22);
            this.dbPorcentagem.TabIndex = 7;
            this.dbPorcentagem.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbPorcentagem.Leave += new System.EventHandler(this.DbPorcentagem_Leave);
            // 
            // dbCusto
            // 
            this.dbCusto.Location = new System.Drawing.Point(7, 89);
            this.dbCusto.Name = "dbCusto";
            this.dbCusto.Size = new System.Drawing.Size(81, 22);
            this.dbCusto.TabIndex = 6;
            this.dbCusto.Valor = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.dbCusto.Leave += new System.EventHandler(this.DbCusto_Leave);
            // 
            // fmCalculoPrecoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.dbValor);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.gpMetodo1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCalculoPrecoVenda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo do preço de venda";
            this.Load += new System.EventHandler(this.FmCalculoPrecoVenda_Load);
            this.gpMetodo1.ResumeLayout(false);
            this.gpMetodo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpMetodo1;
        private System.Windows.Forms.Button btAceitar;
        private Controls.DecimalBox dbValorSugerido;
        private Controls.DecimalBox dbPorcentagem;
        private Controls.DecimalBox dbCusto;
        private System.Windows.Forms.Label lbValorSugerido;
        private System.Windows.Forms.Label lbPorcentagem;
        private System.Windows.Forms.Label lbCusto;
        private System.Windows.Forms.Label lbCalculoMetodo1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btOk;
        private Controls.DecimalBox dbValor;
        private System.Windows.Forms.Label lbValor;
    }
}