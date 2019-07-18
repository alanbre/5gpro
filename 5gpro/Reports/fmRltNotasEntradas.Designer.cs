namespace _5gpro.Reports
{
    partial class fmRltNotasEntradas
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
            this.rvNotasEntradas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsNotasEntradas = new _5gpro.Reports.dsNotasEntradas();
            this.notas_entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_entradasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvNotasEntradas
            // 
            this.rvNotasEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsNotasEntradas";
            reportDataSource1.Value = this.notas_entradasBindingSource;
            this.rvNotasEntradas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvNotasEntradas.LocalReport.ReportEmbeddedResource = "_5gpro.Reports.rltNotasEntradas.rdlc";
            this.rvNotasEntradas.Location = new System.Drawing.Point(0, 0);
            this.rvNotasEntradas.Name = "rvNotasEntradas";
            this.rvNotasEntradas.ServerReport.BearerToken = null;
            this.rvNotasEntradas.Size = new System.Drawing.Size(800, 450);
            this.rvNotasEntradas.TabIndex = 0;
            // 
            // dsNotasEntradas
            // 
            this.dsNotasEntradas.DataSetName = "dsNotasEntradas";
            this.dsNotasEntradas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notas_entradasBindingSource
            // 
            this.notas_entradasBindingSource.DataMember = "notas_entradas";
            this.notas_entradasBindingSource.DataSource = this.dsNotasEntradas;
            // 
            // fmRltNotasEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvNotasEntradas);
            this.MinimizeBox = false;
            this.Name = "fmRltNotasEntradas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Relatório de notas de entrada";
            this.Load += new System.EventHandler(this.FmRltNotasTerceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNotasEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_entradasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvNotasEntradas;
        private System.Windows.Forms.BindingSource notas_entradasBindingSource;
        private dsNotasEntradas dsNotasEntradas;
    }
}