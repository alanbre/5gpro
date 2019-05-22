namespace _5gpro.Reports
{
    partial class fmRltGenerico
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
            this.rpGenerico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpGenerico
            // 
            this.rpGenerico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpGenerico.LocalReport.ReportEmbeddedResource = "_5gpro.Reports.rltGenerico.rdlc";
            this.rpGenerico.Location = new System.Drawing.Point(0, 0);
            this.rpGenerico.Name = "rpGenerico";
            this.rpGenerico.ServerReport.BearerToken = null;
            this.rpGenerico.Size = new System.Drawing.Size(800, 450);
            this.rpGenerico.TabIndex = 0;
            // 
            // fmRltGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpGenerico);
            this.Name = "fmRltGenerico";
            this.Text = "Relatório genérico";
            this.Load += new System.EventHandler(this.FmRltGenerico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpGenerico;
    }
}