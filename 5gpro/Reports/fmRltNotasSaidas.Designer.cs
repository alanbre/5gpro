namespace _5gpro.Reports
{
    partial class fmRltNotasSaidas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.notas_saidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNotasSaidas = new _5gpro.Reports.dsNotasSaidas();
            this.rvNotasProprias = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // notas_saidaBindingSource
            // 
            this.notas_saidaBindingSource.DataMember = "notas_saida";
            this.notas_saidaBindingSource.DataSource = this.dsNotasSaidas;
            // 
            // dsNotasSaidas
            // 
            this.dsNotasSaidas.DataSetName = "dsNotasSaidas";
            this.dsNotasSaidas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvNotasProprias
            // 
            this.rvNotasProprias.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsNotasSaidas";
            reportDataSource1.Value = this.notas_saidaBindingSource;
            this.rvNotasProprias.LocalReport.DataSources.Add(reportDataSource1);
            this.rvNotasProprias.LocalReport.ReportEmbeddedResource = "_5gpro.Reports.rltNotasSaidas.rdlc";
            this.rvNotasProprias.Location = new System.Drawing.Point(0, 0);
            this.rvNotasProprias.Name = "rvNotasProprias";
            this.rvNotasProprias.ServerReport.BearerToken = null;
            this.rvNotasProprias.Size = new System.Drawing.Size(800, 450);
            this.rvNotasProprias.TabIndex = 0;
            // 
            // fmRltNotasSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvNotasProprias);
            this.MinimizeBox = false;
            this.Name = "fmRltNotasSaidas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Relatório de notas de saída";
            this.Load += new System.EventHandler(this.FmRltNotasPropria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notas_saidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasSaidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvNotasProprias;
        private System.Windows.Forms.BindingSource notas_saidaBindingSource;
        private dsNotasSaidas dsNotasSaidas;
    }
}