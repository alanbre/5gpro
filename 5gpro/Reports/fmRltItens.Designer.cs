namespace _5gpro.Reports
{
    partial class fmRltItens
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.itensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsItens = new _5gpro.Reports.dsItens();
            this.rvItens = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens)).BeginInit();
            this.SuspendLayout();
            // 
            // itensBindingSource
            // 
            this.itensBindingSource.DataMember = "itens";
            this.itensBindingSource.DataSource = this.dsItens;
            // 
            // dsItens
            // 
            this.dsItens.DataSetName = "dsItens";
            this.dsItens.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvItens
            // 
            this.rvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsItens";
            reportDataSource2.Value = this.itensBindingSource;
            this.rvItens.LocalReport.DataSources.Add(reportDataSource2);
            this.rvItens.LocalReport.ReportEmbeddedResource = "_5gpro.Reports.rltItens.rdlc";
            this.rvItens.Location = new System.Drawing.Point(0, 0);
            this.rvItens.Name = "rvItens";
            this.rvItens.ServerReport.BearerToken = null;
            this.rvItens.Size = new System.Drawing.Size(1048, 549);
            this.rvItens.TabIndex = 0;
            // 
            // fmRltItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 549);
            this.Controls.Add(this.rvItens);
            this.MinimizeBox = false;
            this.Name = "fmRltItens";
            this.ShowIcon = false;
            this.Text = "Listagem de itens";
            this.Load += new System.EventHandler(this.FmRltItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvItens;
        private System.Windows.Forms.BindingSource itensBindingSource;
        private dsItens dsItens;
    }
}