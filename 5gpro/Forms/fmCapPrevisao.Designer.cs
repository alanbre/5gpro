namespace _5gpro.Forms
{
    partial class fmCapPrevisao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPrevisao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btPrevisao = new System.Windows.Forms.Button();
            this.buscaPessoa = new _5gpro.Controls.BuscaPessoa();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrevisao)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPrevisao
            // 
            this.chartPrevisao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartPrevisao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrevisao.Legends.Add(legend1);
            this.chartPrevisao.Location = new System.Drawing.Point(12, 84);
            this.chartPrevisao.Name = "chartPrevisao";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Tomato;
            series1.Legend = "Legend1";
            series1.Name = "Valor a pagar";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LightGreen;
            series2.Legend = "Legend1";
            series2.Name = "Pago";
            this.chartPrevisao.Series.Add(series1);
            this.chartPrevisao.Series.Add(series2);
            this.chartPrevisao.Size = new System.Drawing.Size(776, 354);
            this.chartPrevisao.TabIndex = 0;
            this.chartPrevisao.Text = "Previsão";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.btPrevisao);
            this.gbFiltros.Controls.Add(this.buscaPessoa);
            this.gbFiltros.Controls.Add(this.dtpDataFinal);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.dtpDataInicial);
            this.gbFiltros.Controls.Add(this.lbDataInicio);
            this.gbFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(776, 66);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btPrevisao
            // 
            this.btPrevisao.Location = new System.Drawing.Point(518, 29);
            this.btPrevisao.Name = "btPrevisao";
            this.btPrevisao.Size = new System.Drawing.Size(144, 23);
            this.btPrevisao.TabIndex = 5;
            this.btPrevisao.Text = "Gerar previsão";
            this.btPrevisao.UseVisualStyleBackColor = true;
            this.btPrevisao.Click += new System.EventHandler(this.BtPrevisao_Click);
            // 
            // buscaPessoa
            // 
            this.buscaPessoa.LabelText = "Fornecedor";
            this.buscaPessoa.Location = new System.Drawing.Point(208, 15);
            this.buscaPessoa.Margin = new System.Windows.Forms.Padding(0);
            this.buscaPessoa.Name = "buscaPessoa";
            this.buscaPessoa.Size = new System.Drawing.Size(307, 39);
            this.buscaPessoa.TabIndex = 4;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(110, 32);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataFinal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data final";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(9, 32);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataInicial.TabIndex = 1;
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(6, 16);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(57, 13);
            this.lbDataInicio.TabIndex = 0;
            this.lbDataInicio.Text = "Data inicio";
            // 
            // fmCapPrevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.chartPrevisao);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "fmCapPrevisao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Previsão de despesas";
            ((System.ComponentModel.ISupportInitialize)(this.chartPrevisao)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrevisao;
        private System.Windows.Forms.GroupBox gbFiltros;
        private Controls.BuscaPessoa buscaPessoa;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lbDataInicio;
        private System.Windows.Forms.Button btPrevisao;
    }
}