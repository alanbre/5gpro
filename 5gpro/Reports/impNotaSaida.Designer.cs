namespace _5gpro.Reports
{
    partial class impNotaSaida
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
            this.rvNotaSaida = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvNotaSaida
            // 
            this.rvNotaSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvNotaSaida.LocalReport.ReportEmbeddedResource = "_5gpro.Reports.impOrcamento.rdlc";
            this.rvNotaSaida.Location = new System.Drawing.Point(0, 0);
            this.rvNotaSaida.Name = "rvNotaSaida";
            this.rvNotaSaida.ServerReport.BearerToken = null;
            this.rvNotaSaida.Size = new System.Drawing.Size(1165, 557);
            this.rvNotaSaida.TabIndex = 0;
            // 
            // impNotaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 557);
            this.Controls.Add(this.rvNotaSaida);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "impNotaSaida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de nota de saída";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvNotaSaida;
    }
}